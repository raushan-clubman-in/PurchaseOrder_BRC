Imports System.IO
Public Class Prov_Master
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents GrdAuditTrail As AxFPSpreadADO.AxfpSpread
    Friend WithEvents lbl_GroupCode As System.Windows.Forms.Label
    Friend WithEvents lbl_Grndate As System.Windows.Forms.Label
    Friend WithEvents cmdMemberCode As System.Windows.Forms.Button
    Friend WithEvents dtp_Docdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_MemName As System.Windows.Forms.Label
    Friend WithEvents Txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Prov_Master))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GrdAuditTrail = New AxFPSpreadADO.AxfpSpread
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.lbl_GroupCode = New System.Windows.Forms.Label
        Me.cmdMemberCode = New System.Windows.Forms.Button
        Me.lbl_Grndate = New System.Windows.Forms.Label
        Me.dtp_Docdate = New System.Windows.Forms.DateTimePicker
        Me.Lbl_MemName = New System.Windows.Forms.Label
        Me.Txt_MemberCode = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrdAuditTrail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GrdAuditTrail)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(968, 264)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'GrdAuditTrail
        '
        Me.GrdAuditTrail.ContainingControl = Me
        Me.GrdAuditTrail.DataSource = Nothing
        Me.GrdAuditTrail.Location = New System.Drawing.Point(16, 24)
        Me.GrdAuditTrail.Name = "GrdAuditTrail"
        Me.GrdAuditTrail.OcxState = CType(resources.GetObject("GrdAuditTrail.OcxState"), System.Windows.Forms.AxHost.State)
        Me.GrdAuditTrail.Size = New System.Drawing.Size(936, 216)
        Me.GrdAuditTrail.TabIndex = 129
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(88, 400)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 12
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox2.Controls.Add(Me.Cmd_Print)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Location = New System.Drawing.Point(272, 424)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(560, 64)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(32, 16)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 442
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(168, 16)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 451
        Me.Cmd_Print.Text = " Print [F8]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(304, 16)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 449
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(440, 16)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 450
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 496)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(383, 18)
        Me.Label5.TabIndex = 417
        Me.Label5.Text = "Press F4 for HELP / Press ENTER key to navigate"
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(264, 16)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(417, 31)
        Me.lbl_Heading.TabIndex = 7
        Me.lbl_Heading.Text = "SMART CARD PROVISIONAL SLIP"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_GroupCode
        '
        Me.lbl_GroupCode.AutoSize = True
        Me.lbl_GroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupCode.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupCode.Location = New System.Drawing.Point(200, 72)
        Me.lbl_GroupCode.Name = "lbl_GroupCode"
        Me.lbl_GroupCode.Size = New System.Drawing.Size(257, 19)
        Me.lbl_GroupCode.TabIndex = 419
        Me.lbl_GroupCode.Text = "FOR MEMBER / AFFILIATED CLUB :"
        '
        'cmdMemberCode
        '
        Me.cmdMemberCode.Image = CType(resources.GetObject("cmdMemberCode.Image"), System.Drawing.Image)
        Me.cmdMemberCode.Location = New System.Drawing.Point(560, 72)
        Me.cmdMemberCode.Name = "cmdMemberCode"
        Me.cmdMemberCode.Size = New System.Drawing.Size(23, 26)
        Me.cmdMemberCode.TabIndex = 420
        '
        'lbl_Grndate
        '
        Me.lbl_Grndate.AutoSize = True
        Me.lbl_Grndate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Grndate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grndate.Location = New System.Drawing.Point(760, 72)
        Me.lbl_Grndate.Name = "lbl_Grndate"
        Me.lbl_Grndate.Size = New System.Drawing.Size(49, 18)
        Me.lbl_Grndate.TabIndex = 422
        Me.lbl_Grndate.Text = "DATE :"
        '
        'dtp_Docdate
        '
        Me.dtp_Docdate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Docdate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_Docdate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_Docdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Docdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Docdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Docdate.Location = New System.Drawing.Point(824, 64)
        Me.dtp_Docdate.Name = "dtp_Docdate"
        Me.dtp_Docdate.Size = New System.Drawing.Size(104, 26)
        Me.dtp_Docdate.TabIndex = 421
        '
        'Lbl_MemName
        '
        Me.Lbl_MemName.AutoSize = True
        Me.Lbl_MemName.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_MemName.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_MemName.ForeColor = System.Drawing.Color.Red
        Me.Lbl_MemName.Location = New System.Drawing.Point(136, 102)
        Me.Lbl_MemName.Name = "Lbl_MemName"
        Me.Lbl_MemName.Size = New System.Drawing.Size(0, 31)
        Me.Lbl_MemName.TabIndex = 423
        Me.Lbl_MemName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_MemberCode
        '
        Me.Txt_MemberCode.Location = New System.Drawing.Point(472, 72)
        Me.Txt_MemberCode.Name = "Txt_MemberCode"
        Me.Txt_MemberCode.Size = New System.Drawing.Size(80, 20)
        Me.Txt_MemberCode.TabIndex = 0
        Me.Txt_MemberCode.Text = ""
        '
        'Prov_Master
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(982, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.Txt_MemberCode)
        Me.Controls.Add(Me.Lbl_MemName)
        Me.Controls.Add(Me.lbl_Grndate)
        Me.Controls.Add(Me.lbl_GroupCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.dtp_Docdate)
        Me.Controls.Add(Me.cmdMemberCode)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "Prov_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMART CARD PROVISIONAL SLIP"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GrdAuditTrail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim gconnection As New GlobalClass
    Private Sub Prov_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        GroupMasterbool = True
        Txt_MemberCode.Focus()
    End Sub

    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='INV' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%' ORDER BY RIGHTS"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        'Me.Cmd_Add.Enabled = False
        'Me.Cmd_Freeze.Enabled = False
        Me.Cmd_View.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    ' Me.Cmd_Add.Enabled = True
                    'Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Exit Sub
                End If
                'If UCase(Mid(Me.Cmd_Add.Text, 1, 1)) = "A" Then
                '    If Right(x) = "S" Then
                '        Me.Cmd_Add.Enabled = True
                '    End If
                'Else
                '    If Right(x) = "M" Then
                '        Me.Cmd_Add.Enabled = True
                '    End If
                'End If
                If Right(x) = "D" Then
                    'Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strSQL As String
        'If Cmd_Add.Text = "Add [F7]" Then
        '    Call checkValidation() '''--->Check Validation
        '    If boolchk = False Then Exit Sub
        '    strSQL = " INSERT INTO inventorygroupmaster (Groupcode,Groupdesc,Freeze,Adduser,Adddate)"
        '    strSQL = strSQL & "VALUES ( '" & Trim(Txt_MemberCode.Text) & "','" & Replace(Trim(txt_GroupDesc.Text), "'", "") & "',"
        '    strSQL = strSQL & "'N','" & Trim(gUsername) & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
        '    gconnection.dataOperation(1, strSQL, "inventorygroupmaster")
        '    Me.Cmd_Clear_Click(sender, e)
        'ElseIf Cmd_Add.Text = "Update[F7]" Then
        '    Call checkValidation() '''--->Check Validation
        '    If boolchk = False Then Exit Sub
        '    If Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
        '        If Me.lbl_Freeze.Visible = True Then
        '            MessageBox.Show(" The Frezzed Record Can Not Be Update", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        '            boolchk = False
        '        End If
        '    End If
        '    strSQL = "UPDATE  inventorygroupmaster "
        '    strSQL = strSQL & " SET Groupdesc='" & Replace(Trim(txt_GroupDesc.Text), "'", "") & "',"
        '    strSQL = strSQL & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm") & "',freeze='N'"
        '    strSQL = strSQL & " WHERE Groupcode = '" & Trim(Txt_MemberCode.Text) & "'"
        '    gconnection.dataOperation(2, strSQL, "inventorygroupmaster")
        '    Me.Cmd_Clear_Click(sender, e)
        '    Cmd_Add.Text = "Add [F7]"
        'End If
    End Sub


    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub prov_Master_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click_1(Cmd_Clear, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F8 Then
            'Call Cmd_Freeze_Click(Cmd_Freeze, e).
            Call Cmd_Print_Click_1(Cmd_Print, e)
            Exit Sub
        End If
        'If e.KeyCode = Keys.F7 Then
        '    Call Cmd_Add_Click(Cmd_Add, e)
        '    Exit Sub
        'End If
        If e.KeyCode = Keys.F9 Then
            Call Cmd_View_Click(Cmd_View, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(Cmd_Exit, e)
            Exit Sub
        End If
    End Sub

    Private Sub Txt_MemberCode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Trim(Txt_MemberCode.Text) <> "" Then
            sqlstring = "SELECT mcode,mname,ISNULL(TERMINATION, '') AS TERMINATION FROM Membermaster WHERE mcode='" & Trim(Txt_MemberCode.Text) & "'"
            gconnection.getDataSet(sqlstring, "membermaster")
            If gdataset.Tables("membermaster").Rows.Count > 0 Then
                Txt_MemberCode.Text = Trim(gdataset.Tables("membermaster").Rows(0).Item("mcode"))
                Lbl_MemName.Text = Trim(gdataset.Tables("membermaster").Rows(0).Item("mname"))
                dtp_Docdate.Focus()
                Txt_MemberCode.ReadOnly = True
                If gdataset.Tables("membermaster").Rows(0).Item("TERMINATION") = "Y" Then
                    Me.lbl_Freeze.Text = "Member Terminated"
                End If
            Else
                Txt_MemberCode.ReadOnly = False
                dtp_Docdate.Focus()
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Else
            Txt_MemberCode.Text = ""
            dtp_Docdate.Focus()
        End If
    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check  Member Code Can't be blank *********************'''
        If Trim(Txt_MemberCode.Text) = "" Then
            MessageBox.Show(" Group Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txt_MemberCode.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub Group_Master_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        provmasterbool = False
    End Sub

    Private Sub cmdMemberCode_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMemberCode.Click
        Dim vform As New ListOperattion1
        gSQLString = "SELECT mcode,mname FROM Membermaster"
        M_WhereCondition = " "
        vform.Field = " MCODE,MNAME "
        vform.vFormatstring = "                 MEMBER CODE            |                 MEMBER NAME                                "
        vform.vCaption = "MEMBER MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_MemberCode.Text = Trim(vform.keyfield & "")
            Lbl_MemName.Text = Trim(vform.keyfield1 & "")
            dtp_Docdate.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub dtp_Docdate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Docdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            GrdAuditTrail.Focus()
            With GrdAuditTrail
                .SetActiveCell(1, 1)
                .Focus()
            End With
        End If
        '--LIN--GRID DATA RETRIEVE START HERE
        Dim SSQL As String
        Dim vconn As New GlobalClass
        Dim I As Integer
        Dim ROWCOUNT As Integer
        SSQL = "select * from SM_VW_MEMBERDEPENDENT where mcode = '" & Trim(Txt_MemberCode.Text) & "' ORDER BY RNO"
        vconn.getDataSet(SSQL, "MEMBERDEPENDENT")
        If gdataset.Tables("MEMBERDEPENDENT").Rows.Count > 0 Then
            With GrdAuditTrail
                ROWCOUNT = 1
                GrdAuditTrail.ClearRange(1, 1, -1, -1, True)
                For I = 0 To gdataset.Tables("MEMBERDEPENDENT").Rows.Count - 1
                    .Row = ROWCOUNT
                    .Col = 1
                    .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                    .Text = gdataset.Tables("MEMBERDEPENDENT").Rows(I).Item("mcode")
                    .Col = 2
                    .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                    .Text = gdataset.Tables("MEMBERDEPENDENT").Rows(I).Item("Mname")
                    .Col = 3
                    .Text = gdataset.Tables("MEMBERDEPENDENT").Rows(I).Item("relationship")
                    .Col = 5
                    .CellType = FPSpreadADO.CellTypeConstants.CellTypeDate
                    .Text = CDate(gdataset.Tables("MEMBERDEPENDENT").Rows(I).Item("VALIDITY_FROM"))
                    .Col = 6
                    .CellType = FPSpreadADO.CellTypeConstants.CellTypeDate
                    .Text = CDate(gdataset.Tables("MEMBERDEPENDENT").Rows(I).Item("VALIDITY_TO"))
                    '.Col = 4 
                    'If gdataset.Tables("billhead").Rows(I).IsNull("cramount") = False Then
                    '    .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                    '    .Text = gdataset.Tables("billhead").Rows(I).Item("cramount")
                    '    grandcramt = Val(grandcramt) + gdataset.Tables("billhead").Rows(I).Item("cramount")
                    'End If
                    '.Col = 5
                    'If gdataset.Tables("billhead").Rows(I).IsNull("recamount") = False Then
                    '    .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
                    '    .Text = gdataset.Tables("billhead").Rows(I).Item("recamount")
                    '    grandrecamt = Val(grandrecamt) + gdataset.Tables("billhead").Rows(I).Item("recamount")
                    'End If
                    ROWCOUNT = ROWCOUNT + 1
                    '.MaxRows = .MaxRows + 1
                    'If .MaxRows < ROWCOUNT + 20 Then
                    '.MaxRows = .MaxRows + 50
                    'End If
                Next
            End With
        End If
        'data grid end

    End Sub

    Private Sub Txt_MemberCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_MemberCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmdMemberCode_Click_1(sender, e)
        End If
    End Sub

    Private Sub Txt_MemberCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_MemberCode.KeyPress
        'getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Txt_MemberCode.Text = "" Then
                Call cmdMemberCode_Click_1(sender, e)
            Else
                Txt_MemberCode_Validated(sender, e)
            End If
        End If
    End Sub
    Public Sub viewoperation()
        Dim vOutfile, SSQL, vcaption As String
        Dim pageno As Integer = 1
        Dim ROWCOUNT As Double = 3
        Dim I, k As Integer
        Randomize()
        vOutfile = Mid("CLR" & (Rnd() * 800000), 1, 8)
        VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        Filewrite = File.AppendText(VFilePath)
        printfile = VFilePath
        I = 3
        vcaption = "SMART CARD PROVISIONAL SLIP"
        Dim j, intPageLength As Int16
        Dim strHead, strColumnHead, strDescription As String
        Dim intDescriptionLength, intStartIndex, intDescLenIndex, intDescMaxLen As Int16
        Dim strSpaceBefore, strSpaceAfter, strLine As String
        Filewrite.WriteLine("---------------------------------------------------------------------------------------------------------------------")
        Filewrite.WriteLine("                   " & Chr(27) & "E" & gCompanyname & Chr(27) & "F")
        Filewrite.WriteLine(Chr(15))
        Filewrite.WriteLine()
        Filewrite.WriteLine(Chr(27) & "E" & "                                                SMART CARD PROVISIONAL SLIP                          " & Chr(27) & "F")
        Filewrite.WriteLine("")
        Filewrite.WriteLine("                        For Member / Affiliated club: " & Chr(27) & "E" & Mid(Txt_MemberCode.Text, 1, 25) & Chr(27) & "F" & Space(25 - Len(Mid(Txt_MemberCode.Text, 1, 25))) & " Date: " & Format(dtp_Docdate.Value, "dd/MM/yyyy"))
        Filewrite.WriteLine("")
        Filewrite.WriteLine("---------------------------------------------------------------------------------------------------------------------")
        Filewrite.WriteLine("| SL. |   MEMBER   |           MEMBER             | RELATIONSHIP |   SMART   |       VALIDITY          |     OTC    |")
        Filewrite.WriteLine("| NO  |    CODE    |            NAME              |              | CARD CODE |    FROM    |     TO     |            |")
        Filewrite.WriteLine("---------------------------------------------------------------------------------------------------------------------")
        Dim SNO As Integer
        Dim MEMBER_CODE, MEMBER_NAME, SMART_CARD_CODE, VALIDITY_FROM, VALIDITY_TO, OTC As String
        SNO = 1
        For SNO = 1 To GrdAuditTrail.DataRowCnt
            'GrdAuditTrail.GetText(1, SNO, MEMBER_CODE)
            'GrdAuditTrail.GetText(2, SNO, MEMBER_NAME)
            'GrdAuditTrail.GetText(4, SNO, SMART_CARD_CODE)
            'GrdAuditTrail.GetText(5, SNO, VALIDITY_FROM)
            'GrdAuditTrail.GetText(6, SNO, VALIDITY_TO)
            'GrdAuditTrail.GetText(7, SNO, OTC)
            With GrdAuditTrail
                .Row = SNO
                Filewrite.Write("|" & Mid(SNO, 1, 5) & Space(5 - Len(Mid(SNO, 1, 5))))
                .Col = 1
                Filewrite.Write("|" & Mid(Trim(.Text), 1, 12) & Space(12 - Len(Mid(Trim(.Text), 1, 12))))
                .Col = 2
                Filewrite.Write("|" & Mid(Trim(.Text), 1, 30) & Space(30 - Len(Mid(Trim(.Text), 1, 30))))
                .Col = 3
                Filewrite.Write("|" & Mid(Trim(.Text), 1, 14) & Space(14 - Len(Mid(Trim(.Text), 1, 14))))
                .Col = 4
                Filewrite.Write("|" & Mid(Trim(.Text), 1, 11) & Space(11 - Len(Mid(Trim(.Text), 1, 11))))
                .Col = 5
                Filewrite.Write("|" & Mid(Trim(.Text), 1, 12) & Space(12 - Len(Mid(Trim(.Text), 1, 12))))
                .Col = 6
                Filewrite.Write("|" & Mid(Trim(.Text), 1, 12) & Space(12 - Len(Mid(Trim(.Text), 1, 12))))
                .Col = 7
                Filewrite.WriteLine("|" & Space(12 - Len(Mid(Trim(.Text), 1, 12))) & Mid(Trim(.Text), 1, 12) & "|")
            End With
        Next
        Filewrite.WriteLine("---------------------------------------------------------------------------------------------------------------------")
        Filewrite.WriteLine("")
        Filewrite.WriteLine("")
        Filewrite.WriteLine("")
        Filewrite.Write(Chr(27) & "E")
        Filewrite.WriteLine("                        I have gone through the rules and regulations of smart card usage and ")
        Filewrite.WriteLine("                        they are acceptable to me.")
        Filewrite.WriteLine("")
        Filewrite.WriteLine("")
        Filewrite.WriteLine("")
        Filewrite.WriteLine("")
        Filewrite.WriteLine("")
        Filewrite.WriteLine("")
        Filewrite.WriteLine("                                                                                Signature of the Member                ")
        Filewrite.Write(Chr(27) & "F")
        Filewrite.WriteLine("-----------------------------------------------------------------------------------------------------------------------")
        Filewrite.WriteLine(Chr(12))
        Filewrite.Close()
        If gPrint = False Then
            OpenTextFile(vOutfile)
        Else
            PrintTextFile(VFilePath)
        End If
    End Sub

    Private Sub Cmd_Clear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        Me.Txt_MemberCode.Text = ""
        Me.Txt_MemberCode.ReadOnly = False
        Me.Lbl_MemName.Text = ""
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        GrdAuditTrail.ClearRange(1, 1, -1, -1, True)
        Txt_MemberCode.Focus()
    End Sub

    Private Sub Cmd_Print_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        gPrint = True
        viewoperation()
    End Sub

    Private Sub Cmd_View_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        'Dim FrReport As New ReportDesigner
        'tables = " From inventorygroupmaster"
        'Gheader = "GROUP MASTER"
        'FrReport.SsGridReport.SetText(2, 1, "GROUPCODE")
        'FrReport.SsGridReport.SetText(3, 1, 15)
        'FrReport.SsGridReport.SetText(2, 2, "GROUPDESC")
        'FrReport.SsGridReport.SetText(3, 2, 35)
        'FrReport.SsGridReport.SetText(2, 3, "FREEZE")
        'FrReport.SsGridReport.SetText(3, 3, 5)
        'FrReport.Show()
        gPrint = False
        Call viewoperation()
    End Sub

    Private Sub Cmd_Exit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

End Class
