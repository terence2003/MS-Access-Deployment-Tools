Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Runtime.InteropServices

Public Class Form1

    Private objAccess As Access.Application

    Private Sub cmdClose_Click(sender As System.Object, e As System.EventArgs) Handles cmdClose.Click
        End
    End Sub

    Private Sub cmdConvert_Click(sender As System.Object, e As System.EventArgs) Handles cmdConvert.Click
        Dim strSource As String
        Dim strTarget As String

        Try
            objAccess = New Access.Application
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Me.cmdConvert.Enabled = False
        End Try


        If UCase(Path.GetExtension(txtSourceFile.Text)) <> ".ACCDB" Then
            MsgBox("File must be in ACCDB extension")
            Exit Sub
        End If
        strSource = Me.txtSourceFile.Text
        strTarget = Path.GetDirectoryName(txtSourceFile.Text) & "\" & Path.GetFileNameWithoutExtension(txtSourceFile.Text) & ".accde"

        If ConvertToAccde(strSource, strTarget) = False Then
            MsgBox("Fail to Convert to ACCDE", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Try
            objAccess.OpenCurrentDatabase(strTarget, True, "")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try


        If chkSetAllowBypassKeyToFalse.Checked = True Then
            SetStartupOptions(objAccess.CurrentDb, "AllowBypassKey", 1, False)
        End If
        If chkSetStartupShowDBWindowToFalse.Checked = True Then
            SetStartupOptions(objAccess.CurrentDb, "StartupShowDBWindow", 1, False)
        End If
        If chkSetAllowFullMenusToFalse.Checked = True Then
            SetStartupOptions(objAccess.CurrentDb, "AllowFullMenus", 1, False)
        End If
        If chkSetAllowSpecialKeysToFalse.Checked = True Then
            SetStartupOptions(objAccess.CurrentDb, "AllowSpecialKeys", 1, False)
        End If
        If chkSetPassword.Checked = True And txtPassword.Text.Trim() <> "" Then
            SetDatabasePassword(objAccess.CurrentDb, txtPassword.Text.Trim())
        End If
        If chkRunVBASubProcedure.Checked = True Then
            If txtProcedure1.Text.Trim() <> "" Then
                Try
                    objAccess.Run(txtProcedure1.Text.Trim())
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try

            End If
            If txtProcedure2.Text.Trim() <> "" Then
                Try
                    objAccess.Run(txtProcedure2.Text.Trim())
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
                End Try

            End If
        End If
        Try
            objAccess.CurrentDb.Close()
            objAccess.Application.Quit()
            Marshal.ReleaseComObject(objAccess)
            GC.Collect()


            '            End
        Catch ex As Exception
            objAccess.Visible = True
        End Try
        MsgBox("Converted")
    End Sub

    Private Function ConvertToAccde(ByVal strSource As String, ByVal strTarget As String) As Boolean
        Dim i As Long
        Try
            i = objAccess.SysCmd(603, strSource, strTarget)
            If i = 1 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function


    'https://msdn.microsoft.com/en-us/library/aa141813(office.10).aspx
    Private Sub SetDatabasePassword(ByRef dbs As Object, ByVal strPasssword As String)
        Try
            dbs.NewPassword("", strPasssword)
        Catch ex As Exception
            MsgBox("Password cannot be set", MsgBoxStyle.Critical, "Error")
        End Try

    End Sub


    'http://www.techrepublic.com/blog/10-things/10-tips-for-securing-a-microsoft-access-database/
    Private Sub SetStartupOptions(ByRef dbs As Object, ByVal propname As String, ByVal propdb As Object, ByVal prop As Object)
        'Set passed startup property.
        Dim prp As Object
        On Error Resume Next
        dbs.Properties(propname) = prop
        If Err.Number = 3270 Then
            prp = dbs.CreateProperty(propname, propdb, prop)
            dbs.Properties.Append(prp)
        End If
        dbs = Nothing
        prp = Nothing
    End Sub


    Private Sub txtPassword_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtPassword.TextChanged
        If txtPassword.Text.Trim() <> "" Then
            Me.chkSetPassword.Checked = True
        Else
            Me.chkSetPassword.Checked = False
        End If
    End Sub

    Private Sub txtProcedure1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtProcedure1.TextChanged
        If txtProcedure1.Text.Trim() <> "" Or txtProcedure2.Text.Trim() <> "" Then
            Me.chkRunVBASubProcedure.Checked = True
        Else
            Me.chkRunVBASubProcedure.Checked = False
        End If
    End Sub

    Private Sub txtProcedure2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtProcedure2.TextChanged
        txtProcedure1_TextChanged(sender, e)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdBrowseSourceFile_Click(sender As System.Object, e As System.EventArgs) Handles cmdBrowseSourceFile.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "MS Access|*.accdb"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Me.txtSourceFile.Text = OpenFileDialog1.FileName
        End If

    End Sub
End Class
