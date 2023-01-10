<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepartmentMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DepartmentMaster))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmd_help = New System.Windows.Forms.Button()
        Me.txt_deptname = New System.Windows.Forms.RichTextBox()
        Me.txt_dept = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmd_add = New System.Windows.Forms.Button()
        Me.cmd_exit = New System.Windows.Forms.Button()
        Me.cmd_freeze = New System.Windows.Forms.Button()
        Me.cmd_clear = New System.Windows.Forms.Button()
        Me.lbl_Freeze = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(158, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DEPARTMENT MASTER"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.cmd_help)
        Me.Panel1.Controls.Add(Me.txt_deptname)
        Me.Panel1.Controls.Add(Me.txt_dept)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(27, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(590, 135)
        Me.Panel1.TabIndex = 1
        '
        'cmd_help
        '
        Me.cmd_help.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmd_help.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_help.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_help.Image = CType(resources.GetObject("cmd_help.Image"), System.Drawing.Image)
        Me.cmd_help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_help.Location = New System.Drawing.Point(360, 23)
        Me.cmd_help.Name = "cmd_help"
        Me.cmd_help.Size = New System.Drawing.Size(34, 22)
        Me.cmd_help.TabIndex = 4
        Me.cmd_help.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_help.UseVisualStyleBackColor = False
        '
        'txt_deptname
        '
        Me.txt_deptname.Location = New System.Drawing.Point(209, 76)
        Me.txt_deptname.Name = "txt_deptname"
        Me.txt_deptname.Size = New System.Drawing.Size(375, 28)
        Me.txt_deptname.TabIndex = 5
        Me.txt_deptname.Text = ""
        '
        'txt_dept
        '
        Me.txt_dept.Location = New System.Drawing.Point(208, 24)
        Me.txt_dept.Name = "txt_dept"
        Me.txt_dept.Size = New System.Drawing.Size(149, 20)
        Me.txt_dept.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(20, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DEPARTMENT NAME :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(20, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DEPARTMENT CODE :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.cmd_add)
        Me.Panel2.Controls.Add(Me.cmd_exit)
        Me.Panel2.Controls.Add(Me.cmd_freeze)
        Me.Panel2.Controls.Add(Me.cmd_clear)
        Me.Panel2.Location = New System.Drawing.Point(656, 96)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(149, 271)
        Me.Panel2.TabIndex = 2
        '
        'cmd_add
        '
        Me.cmd_add.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmd_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_add.Image = CType(resources.GetObject("cmd_add.Image"), System.Drawing.Image)
        Me.cmd_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_add.Location = New System.Drawing.Point(10, 74)
        Me.cmd_add.Name = "cmd_add"
        Me.cmd_add.Size = New System.Drawing.Size(130, 60)
        Me.cmd_add.TabIndex = 3
        Me.cmd_add.Text = "Save [F7]"
        Me.cmd_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_add.UseVisualStyleBackColor = False
        '
        'cmd_exit
        '
        Me.cmd_exit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmd_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exit.Image = CType(resources.GetObject("cmd_exit.Image"), System.Drawing.Image)
        Me.cmd_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exit.Location = New System.Drawing.Point(10, 200)
        Me.cmd_exit.Name = "cmd_exit"
        Me.cmd_exit.Size = New System.Drawing.Size(130, 60)
        Me.cmd_exit.TabIndex = 2
        Me.cmd_exit.Text = "Exit [F11]"
        Me.cmd_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_exit.UseVisualStyleBackColor = False
        '
        'cmd_freeze
        '
        Me.cmd_freeze.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmd_freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_freeze.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_freeze.Image = CType(resources.GetObject("cmd_freeze.Image"), System.Drawing.Image)
        Me.cmd_freeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_freeze.Location = New System.Drawing.Point(10, 137)
        Me.cmd_freeze.Name = "cmd_freeze"
        Me.cmd_freeze.Size = New System.Drawing.Size(130, 60)
        Me.cmd_freeze.TabIndex = 1
        Me.cmd_freeze.Text = "Freeze [F8]"
        Me.cmd_freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_freeze.UseVisualStyleBackColor = False
        '
        'cmd_clear
        '
        Me.cmd_clear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clear.Image = CType(resources.GetObject("cmd_clear.Image"), System.Drawing.Image)
        Me.cmd_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_clear.Location = New System.Drawing.Point(10, 11)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(130, 60)
        Me.cmd_clear.TabIndex = 0
        Me.cmd_clear.Text = "Clear [F6}"
        Me.cmd_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_clear.UseVisualStyleBackColor = False
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(180, 296)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(165, 19)
        Me.lbl_Freeze.TabIndex = 431
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'DepartmentMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(842, 444)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "DepartmentMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DepartmentMaster"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_deptname As System.Windows.Forms.RichTextBox
    Friend WithEvents txt_dept As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmd_clear As System.Windows.Forms.Button
    Friend WithEvents cmd_add As System.Windows.Forms.Button
    Friend WithEvents cmd_exit As System.Windows.Forms.Button
    Friend WithEvents cmd_freeze As System.Windows.Forms.Button
    Friend WithEvents cmd_help As System.Windows.Forms.Button
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
End Class
