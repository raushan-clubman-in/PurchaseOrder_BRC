Imports System.Data
Imports System.Data.SqlClient

Public Class Warrantyterms
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim boolchk As Boolean
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents lbl_GroupDescription As System.Windows.Forms.Label
    Friend WithEvents lbl_GroupCode As System.Windows.Forms.Label
    Friend WithEvents cmdGroupCode As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpaymentdesc As System.Windows.Forms.TextBox
    Friend WithEvents txtpaymentcode As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Warrantyterms))
        Me.Label5 = New System.Windows.Forms.Label
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.txtpaymentdesc = New System.Windows.Forms.TextBox
        Me.txtpaymentcode = New System.Windows.Forms.TextBox
        Me.lbl_GroupDescription = New System.Windows.Forms.Label
        Me.lbl_GroupCode = New System.Windows.Forms.Label
        Me.cmdGroupCode = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label5.Location = New System.Drawing.Point(16, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(324, 16)
        Me.Label5.TabIndex = 432
        Me.Label5.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(8, 216)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 421
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(320, 216)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 423
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(216, 216)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 422
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(112, 216)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 420
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(544, 216)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 424
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(648, 48)
        Me.GroupBox2.TabIndex = 431
        Me.GroupBox2.TabStop = False
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(96, 182)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 430
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_Heading.Location = New System.Drawing.Point(127, 16)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(369, 31)
        Me.lbl_Heading.TabIndex = 425
        Me.lbl_Heading.Text = "WARRANTY TERMS  MASTER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtpaymentdesc
        '
        Me.txtpaymentdesc.BackColor = System.Drawing.Color.Wheat
        Me.txtpaymentdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpaymentdesc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaymentdesc.Location = New System.Drawing.Point(272, 136)
        Me.txtpaymentdesc.MaxLength = 50
        Me.txtpaymentdesc.Name = "txtpaymentdesc"
        Me.txtpaymentdesc.Size = New System.Drawing.Size(213, 26)
        Me.txtpaymentdesc.TabIndex = 419
        Me.txtpaymentdesc.Text = ""
        '
        'txtpaymentcode
        '
        Me.txtpaymentcode.BackColor = System.Drawing.Color.Wheat
        Me.txtpaymentcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpaymentcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaymentcode.Location = New System.Drawing.Point(272, 88)
        Me.txtpaymentcode.MaxLength = 10
        Me.txtpaymentcode.Name = "txtpaymentcode"
        Me.txtpaymentcode.Size = New System.Drawing.Size(189, 26)
        Me.txtpaymentcode.TabIndex = 418
        Me.txtpaymentcode.Text = ""
        '
        'lbl_GroupDescription
        '
        Me.lbl_GroupDescription.AutoSize = True
        Me.lbl_GroupDescription.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupDescription.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupDescription.Location = New System.Drawing.Point(75, 136)
        Me.lbl_GroupDescription.Name = "lbl_GroupDescription"
        Me.lbl_GroupDescription.Size = New System.Drawing.Size(176, 18)
        Me.lbl_GroupDescription.TabIndex = 429
        Me.lbl_GroupDescription.Text = "WARRANTY TERM DESC :"
        '
        'lbl_GroupCode
        '
        Me.lbl_GroupCode.AutoSize = True
        Me.lbl_GroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupCode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupCode.Location = New System.Drawing.Point(72, 88)
        Me.lbl_GroupCode.Name = "lbl_GroupCode"
        Me.lbl_GroupCode.Size = New System.Drawing.Size(182, 18)
        Me.lbl_GroupCode.TabIndex = 427
        Me.lbl_GroupCode.Text = "WARRANTY TERM  CODE :"
        '
        'cmdGroupCode
        '
        Me.cmdGroupCode.Image = CType(resources.GetObject("cmdGroupCode.Image"), System.Drawing.Image)
        Me.cmdGroupCode.Location = New System.Drawing.Point(464, 88)
        Me.cmdGroupCode.Name = "cmdGroupCode"
        Me.cmdGroupCode.Size = New System.Drawing.Size(23, 26)
        Me.cmdGroupCode.TabIndex = 428
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(16, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 104)
        Me.GroupBox1.TabIndex = 426
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(424, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 424
        Me.Button1.Text = "VALIDATE"
        '
        'Warrantyterms
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(664, 293)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.txtpaymentdesc)
        Me.Controls.Add(Me.txtpaymentcode)
        Me.Controls.Add(Me.lbl_GroupDescription)
        Me.Controls.Add(Me.lbl_GroupCode)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Freeze)
        Me.Controls.Add(Me.Cmd_Add)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdGroupCode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Warrantyterms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Warranty Terms Master"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim strsql As String
        If Cmd_Add.Text = "Add [F7]" Then
            Call checkValidation()
            If boolchk = False Then Exit Sub
            strsql = "insert into PO_WARRANTYTERMS (warrantytermcode,warrantytermdesc,freeze,adduser,adddatetime)"
            strsql = strsql & " values "
            strsql = strsql & "('" & Trim(txtpaymentcode.Text) & "','" & Trim(txtpaymentdesc.Text) & "',"
            strsql = strsql & " 'N','" & Trim(gUsername) & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
            gconnection.dataOperation(1, strsql, "PO_WARRANTYTERMS")
        ElseIf Cmd_Add.Text = "Update[F7]" And Me.lbl_Freeze.Visible = True Then
            Call checkValidation() '''--->Check Validation
            If Mid(Me.Cmd_Add.Text, 1, 1) = "U" And Me.lbl_Freeze.Visible = True Then
                MessageBox.Show(" The Frezzed Record Cannot Be Updated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                boolchk = False
            End If
            If boolchk = False Then
                Call clearform(Me)
                Me.Cmd_Clear_Click(sender, e)
                Cmd_Add.Text = "Add [F7]"
                Exit Sub
            End If
        Else
            strsql = "UPDATE  PO_WARRANTYTERMS "
            strsql = strsql & " SET warrantytermdesc='" & Replace(Trim(txtpaymentdesc.Text), "'", "") & "',"
            strsql = strsql & "updateuser='" & Trim(gUsername) & "',updatedatetime='" & Format(Now, "dd-MMM-yyyy hh:mm") & "',freeze='N'"
            strsql = strsql & " WHERE warrantytermcode = '" & Trim(txtpaymentcode.Text) & "'"
            gconnection.dataOperation(2, strsql, "PO_WARRANTYTERMS")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
        Call clearform(Me)
        txtpaymentcode.Focus()
    End Sub

    Public Sub checkValidation()
        boolchk = False
        '''********** Check  Group desc Can't be blank *********************'''
        If Trim(txtpaymentcode.Text) = "" Then
            MessageBox.Show("Warranty Term Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpaymentcode.Focus()
            Exit Sub
        End If
        If Trim(txtpaymentdesc.Text) = "" Then
            MessageBox.Show("Warranty Term Description can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtpaymentdesc.Focus()
            Exit Sub
        End If
        'If Mid(Me.Cmd_Add.Text, 1, 1) = "U" And Me.lbl_Freeze.Visible = True Then
        '    MessageBox.Show(" The Frezzed Record Cannot Be Updated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '    boolchk = False
        'End If
        boolchk = True
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed On"
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add [F7]"
        txtpaymentcode.Enabled = True
        txtpaymentcode.ReadOnly = False
        txtpaymentdesc.ReadOnly = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txtpaymentcode.Focus()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Dim sqlstring As String
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  PO_WARRANTYTERMS "
            sqlstring = sqlstring & " SET Freeze= 'Y',Freezeuser='" & gUsername & " ',Freezedatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE warrantytermcode = '" & Trim(txtpaymentcode.Text) & "' "
            gconnection.dataOperation(3, sqlstring, "PO_paymentterms")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        Else
            sqlstring = "UPDATE  PO_WARRANTYTERMS "
            sqlstring = sqlstring & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE warrantytermcode = '" & Trim(txtpaymentcode.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "PO_paymentterms")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='Purchase Order' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%' ORDER BY RIGHTS"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.Cmd_Add.Enabled = False
        Me.Cmd_Freeze.Enabled = False
        Me.Cmd_View.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.Cmd_Add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
            Next
        End If

        'Dim i, j, k, x As Integer
        'Dim vmain, vsmod, vssmod As Long
        'Dim ssql, SQLSTRING As String
        'Dim M1 As New MainMenu
        'Dim chstr As String
        'SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='POS' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        'vconn.getDataSet(SQLSTRING, "USER")
        'If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
        '    For i = 0 To gdataset.Tables("USER").Rows.Count - 1
        '        With gdataset.Tables("USER").Rows(i)
        '            chstr = abcdMINUS(.Item("RIGHTS"))
        '        End With
        '    Next
        'End If
        'Me.CmdView.Enabled = False
        'Me.CmdPrint.Enabled = False
        ''A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        'If Len(chstr) > 0 Then
        '    Dim Right() As Char
        '    Right = chstr.ToCharArray
        '    For x = 0 To Right.Length - 1
        '        If Right(x) = "A" Then
        '            Me.CmdView.Enabled = True
        '            Me.CmdPrint.Enabled = True
        '            Exit Sub
        '        End If
        '        If Right(x) = "V" Then
        '            Me.CmdView.Enabled = True
        '            Me.CmdPrint.Enabled = True
        '        End If
        '    Next
        'End If

    End Sub
    Private Sub cmdpaymentcode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGroupCode.Click
        gSQLString = "SELECT ISNULL(warrantytermcode,'') AS warrantytermcode,ISNULL(warrantytermdesc,'') AS         warrantytermdesc FROM PO_WARRANTYTERMS"
        M_WhereCondition = " "
        Dim vform As New List_Operation
        vform.Field = "WARRANTYTERMCODE,WARRANTYTERDESC"
        vform.vFormatstring = "     WARRANTYTERM CODE              |             WARRANTYTERM DESCRIPTION  "
        vform.vCaption = "WARRANTY TERM MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txtpaymentcode.Text = Trim(vform.keyfield & "")
            Call txt_paymentcode_Validated(txtpaymentcode, e)
        End If
        vform.Close()
        vform = Nothing
        'Cmd_Freeze.Enabled = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub

    Private Sub txt_paymentcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtpaymentcode.Validated
        Dim strsql As String
        If Trim(txtpaymentcode.Text) <> "" Then
            strsql = "SELECT * FROM PO_WARRANTYTERMS WHERE warrantytermcode='" & Trim(txtpaymentcode.Text) & "'"
            gconnection.getDataSet(strsql, "PO_WARRANTYTERMS")
            If gdataset.Tables("PO_WARRANTYTERMS").Rows.Count > 0 Then
                txtpaymentcode.Text = Trim(gdataset.Tables("PO_WARRANTYTERMS").Rows(0).Item("warrantytermcode"))
                txtpaymentdesc.Text = Trim(gdataset.Tables("PO_WARRANTYTERMS").Rows(0).Item("warrantytermdesc"))
                txtpaymentdesc.Focus()
                txtpaymentcode.ReadOnly = True
                If gdataset.Tables("PO_WARRANTYTERMS").Rows(0).Item("Freeze") = "Y" Then
                    Me.lbl_Freeze.Visible = True
                    Me.lbl_Freeze.Text = ""
                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("PO_WARRANTYTERMS").Rows(0).Item("AddDatetime")), "dd-MMM-yyyy")
                    Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
                Me.Cmd_Add.Text = "Update[F7]"
            Else
                Me.lbl_Freeze.Visible = False
                Me.lbl_Freeze.Text = "Record Freezed  On "
                Me.Cmd_Add.Text = "Add [F7]"
                txtpaymentcode.ReadOnly = False
                txtpaymentdesc.Focus()
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Else
            txtpaymentdesc.Focus()
        End If
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub

    Private Sub txtpaymentcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpaymentcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtpaymentcode.Text) = "" Then
                Call cmdpaymentcode_Click(cmdGroupCode, e)
            Else
                txtpaymentdesc.Focus()
            End If

        End If
    End Sub
    Private Sub paymentterms_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(Cmd_Clear, e)
            Exit Sub
        End If

        If e.KeyCode = Keys.F8 Then
            Call Cmd_Freeze_Click(Cmd_Freeze, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F7 Then
            Call Cmd_Add_Click(Cmd_Add, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F9 Then
            Call Cmd_View_Click(Cmd_View, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(Cmd_Exit, e)
            Exit Sub
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim FrReport As New ReportDesigner
        tables = "PO_WARRANTYTERMS"
        Gheader = "WARRANTY TERMS MASTER"
        FrReport.SsGridReport.SetText(2, 1, "WARRANTYTERMCODE")
        FrReport.SsGridReport.SetText(3, 1, 20)
        FrReport.SsGridReport.SetText(2, 2, "WARRANTYTERMDESC")
        FrReport.SsGridReport.SetText(3, 2, 35)
        FrReport.SsGridReport.SetText(2, 3, "FREEZE")
        FrReport.SsGridReport.SetText(3, 3, 6)
        FrReport.Show()
    End Sub

    Private Sub txtpaymentcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpaymentcode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmdpaymentcode_Click(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub paymentterms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cmd_Freeze.Enabled = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub

    Private Sub txtpaymentdesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpaymentdesc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txtpaymentdesc.Text) = "" Then
                Call cmdpaymentcode_Click(cmdGroupCode, e)

            Else
                Cmd_Add.Focus()
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start(AppPath & "\STUDY\WARANTYTERMMASTER.XLS")
    End Sub
End Class
