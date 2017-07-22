<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtSourceFile = New System.Windows.Forms.TextBox()
        Me.chkSetAllowBypassKeyToFalse = New System.Windows.Forms.CheckBox()
        Me.chkSetStartupShowDBWindowToFalse = New System.Windows.Forms.CheckBox()
        Me.chkSetAllowFullMenusToFalse = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkSetAllowSpecialKeysToFalse = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.chkSetPassword = New System.Windows.Forms.CheckBox()
        Me.cmdBrowseSourceFile = New System.Windows.Forms.Button()
        Me.chkRunVBASubProcedure = New System.Windows.Forms.CheckBox()
        Me.txtProcedure1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProcedure2 = New System.Windows.Forms.TextBox()
        Me.cmdConvert = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'txtSourceFile
        '
        Me.txtSourceFile.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSourceFile.Location = New System.Drawing.Point(93, 15)
        Me.txtSourceFile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSourceFile.Name = "txtSourceFile"
        Me.txtSourceFile.Size = New System.Drawing.Size(497, 23)
        Me.txtSourceFile.TabIndex = 0
        Me.txtSourceFile.Text = "D:\Users\Terence\Documents\Project\TeamUniversal\MSAccess\TeamUniversal.accdb"
        '
        'chkSetAllowBypassKeyToFalse
        '
        Me.chkSetAllowBypassKeyToFalse.AutoSize = True
        Me.chkSetAllowBypassKeyToFalse.Checked = True
        Me.chkSetAllowBypassKeyToFalse.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSetAllowBypassKeyToFalse.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSetAllowBypassKeyToFalse.Location = New System.Drawing.Point(23, 46)
        Me.chkSetAllowBypassKeyToFalse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkSetAllowBypassKeyToFalse.Name = "chkSetAllowBypassKeyToFalse"
        Me.chkSetAllowBypassKeyToFalse.Size = New System.Drawing.Size(196, 19)
        Me.chkSetAllowBypassKeyToFalse.TabIndex = 3
        Me.chkSetAllowBypassKeyToFalse.Text = "Set ""Allow Bypass Key"" to False"
        Me.chkSetAllowBypassKeyToFalse.UseVisualStyleBackColor = True
        '
        'chkSetStartupShowDBWindowToFalse
        '
        Me.chkSetStartupShowDBWindowToFalse.AutoSize = True
        Me.chkSetStartupShowDBWindowToFalse.Checked = True
        Me.chkSetStartupShowDBWindowToFalse.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSetStartupShowDBWindowToFalse.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSetStartupShowDBWindowToFalse.Location = New System.Drawing.Point(23, 73)
        Me.chkSetStartupShowDBWindowToFalse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkSetStartupShowDBWindowToFalse.Name = "chkSetStartupShowDBWindowToFalse"
        Me.chkSetStartupShowDBWindowToFalse.Size = New System.Drawing.Size(240, 19)
        Me.chkSetStartupShowDBWindowToFalse.TabIndex = 4
        Me.chkSetStartupShowDBWindowToFalse.Text = "Set ""Startup Show DB Window"" to False"
        Me.chkSetStartupShowDBWindowToFalse.UseVisualStyleBackColor = True
        '
        'chkSetAllowFullMenusToFalse
        '
        Me.chkSetAllowFullMenusToFalse.AutoSize = True
        Me.chkSetAllowFullMenusToFalse.Checked = True
        Me.chkSetAllowFullMenusToFalse.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSetAllowFullMenusToFalse.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSetAllowFullMenusToFalse.Location = New System.Drawing.Point(23, 100)
        Me.chkSetAllowFullMenusToFalse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkSetAllowFullMenusToFalse.Name = "chkSetAllowFullMenusToFalse"
        Me.chkSetAllowFullMenusToFalse.Size = New System.Drawing.Size(196, 19)
        Me.chkSetAllowFullMenusToFalse.TabIndex = 5
        Me.chkSetAllowFullMenusToFalse.Text = "Set ""Allow Full Menus"" to False"
        Me.chkSetAllowFullMenusToFalse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Source File"
        '
        'chkSetAllowSpecialKeysToFalse
        '
        Me.chkSetAllowSpecialKeysToFalse.AutoSize = True
        Me.chkSetAllowSpecialKeysToFalse.Checked = True
        Me.chkSetAllowSpecialKeysToFalse.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSetAllowSpecialKeysToFalse.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSetAllowSpecialKeysToFalse.Location = New System.Drawing.Point(23, 127)
        Me.chkSetAllowSpecialKeysToFalse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkSetAllowSpecialKeysToFalse.Name = "chkSetAllowSpecialKeysToFalse"
        Me.chkSetAllowSpecialKeysToFalse.Size = New System.Drawing.Size(203, 19)
        Me.chkSetAllowSpecialKeysToFalse.TabIndex = 6
        Me.chkSetAllowSpecialKeysToFalse.Text = "Set ""Allow Special Keys"" to False"
        Me.chkSetAllowSpecialKeysToFalse.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(128, 154)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPassword.MaxLength = 20
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(243, 23)
        Me.txtPassword.TabIndex = 8
        '
        'chkSetPassword
        '
        Me.chkSetPassword.AutoSize = True
        Me.chkSetPassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSetPassword.Location = New System.Drawing.Point(23, 154)
        Me.chkSetPassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkSetPassword.Name = "chkSetPassword"
        Me.chkSetPassword.Size = New System.Drawing.Size(99, 19)
        Me.chkSetPassword.TabIndex = 7
        Me.chkSetPassword.Text = "Set Password"
        Me.chkSetPassword.UseVisualStyleBackColor = True
        '
        'cmdBrowseSourceFile
        '
        Me.cmdBrowseSourceFile.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowseSourceFile.Location = New System.Drawing.Point(596, 13)
        Me.cmdBrowseSourceFile.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmdBrowseSourceFile.Name = "cmdBrowseSourceFile"
        Me.cmdBrowseSourceFile.Size = New System.Drawing.Size(23, 29)
        Me.cmdBrowseSourceFile.TabIndex = 2
        Me.cmdBrowseSourceFile.Text = "..."
        Me.cmdBrowseSourceFile.UseVisualStyleBackColor = True
        '
        'chkRunVBASubProcedure
        '
        Me.chkRunVBASubProcedure.AutoSize = True
        Me.chkRunVBASubProcedure.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRunVBASubProcedure.Location = New System.Drawing.Point(23, 181)
        Me.chkRunVBASubProcedure.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkRunVBASubProcedure.Name = "chkRunVBASubProcedure"
        Me.chkRunVBASubProcedure.Size = New System.Drawing.Size(153, 19)
        Me.chkRunVBASubProcedure.TabIndex = 9
        Me.chkRunVBASubProcedure.Text = "Run VBA Sub Procedure"
        Me.chkRunVBASubProcedure.UseVisualStyleBackColor = True
        '
        'txtProcedure1
        '
        Me.txtProcedure1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcedure1.Location = New System.Drawing.Point(168, 201)
        Me.txtProcedure1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtProcedure1.MaxLength = 20
        Me.txtProcedure1.Name = "txtProcedure1"
        Me.txtProcedure1.Size = New System.Drawing.Size(115, 23)
        Me.txtProcedure1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Procedure Name 1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 15)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Procedure Name 2"
        '
        'txtProcedure2
        '
        Me.txtProcedure2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcedure2.Location = New System.Drawing.Point(168, 232)
        Me.txtProcedure2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtProcedure2.MaxLength = 20
        Me.txtProcedure2.Name = "txtProcedure2"
        Me.txtProcedure2.Size = New System.Drawing.Size(115, 23)
        Me.txtProcedure2.TabIndex = 13
        '
        'cmdConvert
        '
        Me.cmdConvert.Location = New System.Drawing.Point(212, 277)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(119, 23)
        Me.cmdConvert.TabIndex = 16
        Me.cmdConvert.Text = "Convert to ACCDE"
        Me.cmdConvert.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(355, 277)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 25
        Me.cmdClose.Text = "Close"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 312)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.cmdConvert)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtProcedure2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProcedure1)
        Me.Controls.Add(Me.chkRunVBASubProcedure)
        Me.Controls.Add(Me.cmdBrowseSourceFile)
        Me.Controls.Add(Me.chkSetPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.chkSetAllowSpecialKeysToFalse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkSetAllowFullMenusToFalse)
        Me.Controls.Add(Me.chkSetStartupShowDBWindowToFalse)
        Me.Controls.Add(Me.chkSetAllowBypassKeyToFalse)
        Me.Controls.Add(Me.txtSourceFile)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MS Access Deployment Tools"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSourceFile As System.Windows.Forms.TextBox
    Friend WithEvents chkSetAllowBypassKeyToFalse As System.Windows.Forms.CheckBox
    Friend WithEvents chkSetStartupShowDBWindowToFalse As System.Windows.Forms.CheckBox
    Friend WithEvents chkSetAllowFullMenusToFalse As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkSetAllowSpecialKeysToFalse As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents chkSetPassword As System.Windows.Forms.CheckBox
    Friend WithEvents cmdBrowseSourceFile As System.Windows.Forms.Button
    Friend WithEvents chkRunVBASubProcedure As System.Windows.Forms.CheckBox
    Friend WithEvents txtProcedure1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtProcedure2 As System.Windows.Forms.TextBox
    Friend WithEvents cmdConvert As System.Windows.Forms.Button
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
