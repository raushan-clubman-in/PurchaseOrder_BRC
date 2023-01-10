<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VIEWHDR
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveExcelFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.DTGRDHDR = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbCol = New System.Windows.Forms.ComboBox()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.grp_browsehdr = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMD_CLEAR = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DTGRDHDR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_browsehdr.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(619, 590)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "EXPORT [F10]"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DTGRDHDR
        '
        Me.DTGRDHDR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGRDHDR.Location = New System.Drawing.Point(3, 2)
        Me.DTGRDHDR.Name = "DTGRDHDR"
        Me.DTGRDHDR.Size = New System.Drawing.Size(995, 581)
        Me.DTGRDHDR.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(882, 590)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "EXIT [F12]"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(166, 593)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(157, 20)
        Me.txtSearch.TabIndex = 4
        '
        'cmbCol
        '
        Me.cmbCol.FormattingEnabled = True
        Me.cmbCol.Location = New System.Drawing.Point(28, 593)
        Me.cmbCol.Name = "cmbCol"
        Me.cmbCol.Size = New System.Drawing.Size(121, 21)
        Me.cmbCol.TabIndex = 5
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.cmdSearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.Location = New System.Drawing.Point(455, 589)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(149, 32)
        Me.cmdSearch.TabIndex = 6
        Me.cmdSearch.Text = "NEW SEARCH [F9]"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'grp_browsehdr
        '
        Me.grp_browsehdr.BackColor = System.Drawing.Color.Transparent
        Me.grp_browsehdr.Controls.Add(Me.TextBox1)
        Me.grp_browsehdr.Controls.Add(Me.Label1)
        Me.grp_browsehdr.Controls.Add(Me.CMD_CLEAR)
        Me.grp_browsehdr.Controls.Add(Me.Button3)
        Me.grp_browsehdr.Location = New System.Drawing.Point(2, -9)
        Me.grp_browsehdr.Name = "grp_browsehdr"
        Me.grp_browsehdr.Size = New System.Drawing.Size(1020, 721)
        Me.grp_browsehdr.TabIndex = 7
        Me.grp_browsehdr.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(7, 636)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(987, 35)
        Me.TextBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 605)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "F1 FOR SEARCH"
        '
        'CMD_CLEAR
        '
        Me.CMD_CLEAR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CMD_CLEAR.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_CLEAR.Location = New System.Drawing.Point(752, 598)
        Me.CMD_CLEAR.Name = "CMD_CLEAR"
        Me.CMD_CLEAR.Size = New System.Drawing.Size(113, 32)
        Me.CMD_CLEAR.TabIndex = 3
        Me.CMD_CLEAR.Text = "CLEAR [F11]"
        Me.CMD_CLEAR.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(433, 336)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 38)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "EXPORT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'VIEWHDR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1008, 699)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmbCol)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DTGRDHDR)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grp_browsehdr)
        Me.KeyPreview = True
        Me.Name = "VIEWHDR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VIEW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DTGRDHDR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_browsehdr.ResumeLayout(False)
        Me.grp_browsehdr.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveExcelFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents DTGRDHDR As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbCol As System.Windows.Forms.ComboBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents grp_browsehdr As System.Windows.Forms.GroupBox
    Friend WithEvents CMD_CLEAR As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
