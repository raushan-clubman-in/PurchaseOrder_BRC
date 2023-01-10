Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Public Class StockIssue_Indent_authorization
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
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents txt_Docno As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_Docnohelp As System.Windows.Forms.Button
    Friend WithEvents txt_Mainstore As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Tostore As System.Windows.Forms.Label
    Friend WithEvents lbl_Mainstore As System.Windows.Forms.Label
    Friend WithEvents dtp_Docdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Docdate As System.Windows.Forms.Label
    Friend WithEvents lbl_Docno As System.Windows.Forms.Label
    Friend WithEvents grp_issue1 As System.Windows.Forms.GroupBox
    Friend WithEvents grp_issue2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_Tostore As System.Windows.Forms.ComboBox
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents txt_Tostorecode As System.Windows.Forms.TextBox
    Friend WithEvents txt_Mainstorecode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents grp_Stockissue As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Stockissuedetails As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_IssueView As System.Windows.Forms.Button
    Friend WithEvents Cmd_Issueexit As System.Windows.Forms.Button
    Friend WithEvents Cmd_IssueClear As System.Windows.Forms.Button
    Friend WithEvents Cmd_Issueprint As System.Windows.Forms.Button
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents lbl_closingqty As System.Windows.Forms.Label
    Friend WithEvents Cmd_ToDocno As System.Windows.Forms.Button
    Friend WithEvents Cmd_FromDocno As System.Windows.Forms.Button
    Friend WithEvents txt_ToDocno As System.Windows.Forms.TextBox
    Friend WithEvents txt_FromDocno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ToDocno As System.Windows.Forms.Label
    Friend WithEvents lbl_FromDocno As System.Windows.Forms.Label
    Friend WithEvents cmd_Print As System.Windows.Forms.Button
    Friend WithEvents cmd_storecode As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_IndentNo As System.Windows.Forms.TextBox
    Friend WithEvents cmd_IndentNoHelp As System.Windows.Forms.Button
    Friend WithEvents dtp_IndentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Chk_item As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents grp_footer As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_signature As System.Windows.Forms.TextBox
    Friend WithEvents Txt_footer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CHK_WAR As System.Windows.Forms.CheckBox
    Friend WithEvents chk_excel As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_export As System.Windows.Forms.Button
    Friend WithEvents dtp_completiondate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_approvedby As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Pic_auth1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Pic_auth2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents txt_Totalamount As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents UNAUTHORISED As System.Windows.Forms.CheckBox
    Friend WithEvents CMD_BROWSE As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_auth As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockIssue_Indent_authorization))
        Me.txt_Docno = New System.Windows.Forms.TextBox()
        Me.Cmd_Docnohelp = New System.Windows.Forms.Button()
        Me.txt_Mainstore = New System.Windows.Forms.TextBox()
        Me.lbl_Remarks = New System.Windows.Forms.Label()
        Me.lbl_Tostore = New System.Windows.Forms.Label()
        Me.lbl_Mainstore = New System.Windows.Forms.Label()
        Me.dtp_Docdate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Heading = New System.Windows.Forms.Label()
        Me.lbl_Docdate = New System.Windows.Forms.Label()
        Me.lbl_Docno = New System.Windows.Forms.Label()
        Me.grp_issue1 = New System.Windows.Forms.GroupBox()
        Me.cmd_storecode = New System.Windows.Forms.Button()
        Me.cbo_Tostore = New System.Windows.Forms.ComboBox()
        Me.txt_Tostorecode = New System.Windows.Forms.TextBox()
        Me.txt_Mainstorecode = New System.Windows.Forms.TextBox()
        Me.grp_issue2 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Txt_IndentNo = New System.Windows.Forms.TextBox()
        Me.cmd_IndentNoHelp = New System.Windows.Forms.Button()
        Me.dtp_IndentDate = New System.Windows.Forms.DateTimePicker()
        Me.Cmd_Clear = New System.Windows.Forms.Button()
        Me.Cmd_View = New System.Windows.Forms.Button()
        Me.Cmd_Freeze = New System.Windows.Forms.Button()
        Me.Cmd_Add = New System.Windows.Forms.Button()
        Me.Cmd_Exit = New System.Windows.Forms.Button()
        Me.frmbut = New System.Windows.Forms.GroupBox()
        Me.CMD_BROWSE = New System.Windows.Forms.Button()
        Me.btn_auth = New System.Windows.Forms.Button()
        Me.cmd_export = New System.Windows.Forms.Button()
        Me.cmd_Print = New System.Windows.Forms.Button()
        Me.chk_excel = New System.Windows.Forms.CheckBox()
        Me.lbl_Freeze = New System.Windows.Forms.Label()
        Me.grp_Stockissue = New System.Windows.Forms.GroupBox()
        Me.lbl_Stockissuedetails = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cmd_Issueprint = New System.Windows.Forms.Button()
        Me.Cmd_IssueView = New System.Windows.Forms.Button()
        Me.Cmd_Issueexit = New System.Windows.Forms.Button()
        Me.Cmd_IssueClear = New System.Windows.Forms.Button()
        Me.lbl_FromDocno = New System.Windows.Forms.Label()
        Me.txt_FromDocno = New System.Windows.Forms.TextBox()
        Me.lbl_ToDocno = New System.Windows.Forms.Label()
        Me.txt_ToDocno = New System.Windows.Forms.TextBox()
        Me.Cmd_ToDocno = New System.Windows.Forms.Button()
        Me.Cmd_FromDocno = New System.Windows.Forms.Button()
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread()
        Me.lbl_closingqty = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Chk_item = New System.Windows.Forms.CheckBox()
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.grp_footer = New System.Windows.Forms.GroupBox()
        Me.Txt_signature = New System.Windows.Forms.TextBox()
        Me.Txt_footer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CHK_WAR = New System.Windows.Forms.CheckBox()
        Me.dtp_completiondate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_approvedby = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Pic_auth1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Pic_auth2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_qty = New System.Windows.Forms.TextBox()
        Me.txt_Totalamount = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.UNAUTHORISED = New System.Windows.Forms.CheckBox()
        Me.grp_issue1.SuspendLayout()
        Me.grp_issue2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frmbut.SuspendLayout()
        Me.grp_Stockissue.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.grp_footer.SuspendLayout()
        CType(Me.Pic_auth1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_auth2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Docno
        '
        Me.txt_Docno.BackColor = System.Drawing.Color.Wheat
        Me.txt_Docno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Docno.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Docno.Location = New System.Drawing.Point(99, 13)
        Me.txt_Docno.MaxLength = 15
        Me.txt_Docno.Name = "txt_Docno"
        Me.txt_Docno.Size = New System.Drawing.Size(216, 21)
        Me.txt_Docno.TabIndex = 1
        '
        'Cmd_Docnohelp
        '
        Me.Cmd_Docnohelp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Docnohelp.Image = CType(resources.GetObject("Cmd_Docnohelp.Image"), System.Drawing.Image)
        Me.Cmd_Docnohelp.Location = New System.Drawing.Point(318, 11)
        Me.Cmd_Docnohelp.Name = "Cmd_Docnohelp"
        Me.Cmd_Docnohelp.Size = New System.Drawing.Size(23, 26)
        Me.Cmd_Docnohelp.TabIndex = 21
        '
        'txt_Mainstore
        '
        Me.txt_Mainstore.BackColor = System.Drawing.Color.Wheat
        Me.txt_Mainstore.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Mainstore.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Mainstore.Location = New System.Drawing.Point(190, 15)
        Me.txt_Mainstore.MaxLength = 15
        Me.txt_Mainstore.Name = "txt_Mainstore"
        Me.txt_Mainstore.ReadOnly = True
        Me.txt_Mainstore.Size = New System.Drawing.Size(153, 21)
        Me.txt_Mainstore.TabIndex = 15
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AutoSize = True
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.Location = New System.Drawing.Point(24, 16)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(64, 15)
        Me.lbl_Remarks.TabIndex = 25
        Me.lbl_Remarks.Text = "REMARKS"
        '
        'lbl_Tostore
        '
        Me.lbl_Tostore.AutoSize = True
        Me.lbl_Tostore.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Tostore.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tostore.Location = New System.Drawing.Point(27, 45)
        Me.lbl_Tostore.Name = "lbl_Tostore"
        Me.lbl_Tostore.Size = New System.Drawing.Size(65, 15)
        Me.lbl_Tostore.TabIndex = 17
        Me.lbl_Tostore.Text = "TO STORE"
        '
        'lbl_Mainstore
        '
        Me.lbl_Mainstore.AutoSize = True
        Me.lbl_Mainstore.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Mainstore.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mainstore.Location = New System.Drawing.Point(10, 17)
        Me.lbl_Mainstore.Name = "lbl_Mainstore"
        Me.lbl_Mainstore.Size = New System.Drawing.Size(82, 15)
        Me.lbl_Mainstore.TabIndex = 14
        Me.lbl_Mainstore.Text = "FROM STORE"
        '
        'dtp_Docdate
        '
        Me.dtp_Docdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Docdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Docdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Docdate.Location = New System.Drawing.Point(514, 14)
        Me.dtp_Docdate.Name = "dtp_Docdate"
        Me.dtp_Docdate.Size = New System.Drawing.Size(96, 21)
        Me.dtp_Docdate.TabIndex = 2
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(185, 81)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(215, 18)
        Me.lbl_Heading.TabIndex = 12
        Me.lbl_Heading.Text = "PO INDENT AUTHORIZATION"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Docdate
        '
        Me.lbl_Docdate.AutoSize = True
        Me.lbl_Docdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Docdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Docdate.Location = New System.Drawing.Point(16, 44)
        Me.lbl_Docdate.Name = "lbl_Docdate"
        Me.lbl_Docdate.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Docdate.TabIndex = 22
        Me.lbl_Docdate.Text = "INDENT DATE"
        '
        'lbl_Docno
        '
        Me.lbl_Docno.AutoSize = True
        Me.lbl_Docno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Docno.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Docno.Location = New System.Drawing.Point(28, 16)
        Me.lbl_Docno.Name = "lbl_Docno"
        Me.lbl_Docno.Size = New System.Drawing.Size(68, 15)
        Me.lbl_Docno.TabIndex = 20
        Me.lbl_Docno.Text = "INDENT NO"
        '
        'grp_issue1
        '
        Me.grp_issue1.BackColor = System.Drawing.Color.Transparent
        Me.grp_issue1.Controls.Add(Me.cmd_storecode)
        Me.grp_issue1.Controls.Add(Me.cbo_Tostore)
        Me.grp_issue1.Controls.Add(Me.txt_Tostorecode)
        Me.grp_issue1.Controls.Add(Me.lbl_Mainstore)
        Me.grp_issue1.Controls.Add(Me.lbl_Tostore)
        Me.grp_issue1.Controls.Add(Me.txt_Mainstore)
        Me.grp_issue1.Controls.Add(Me.txt_Mainstorecode)
        Me.grp_issue1.Location = New System.Drawing.Point(193, 101)
        Me.grp_issue1.Name = "grp_issue1"
        Me.grp_issue1.Size = New System.Drawing.Size(344, 76)
        Me.grp_issue1.TabIndex = 13
        Me.grp_issue1.TabStop = False
        '
        'cmd_storecode
        '
        Me.cmd_storecode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_storecode.Image = CType(resources.GetObject("cmd_storecode.Image"), System.Drawing.Image)
        Me.cmd_storecode.Location = New System.Drawing.Point(164, 12)
        Me.cmd_storecode.Name = "cmd_storecode"
        Me.cmd_storecode.Size = New System.Drawing.Size(24, 26)
        Me.cmd_storecode.TabIndex = 373
        '
        'cbo_Tostore
        '
        Me.cbo_Tostore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Tostore.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Tostore.Location = New System.Drawing.Point(99, 41)
        Me.cbo_Tostore.Name = "cbo_Tostore"
        Me.cbo_Tostore.Size = New System.Drawing.Size(180, 23)
        Me.cbo_Tostore.TabIndex = 0
        '
        'txt_Tostorecode
        '
        Me.txt_Tostorecode.BackColor = System.Drawing.Color.Wheat
        Me.txt_Tostorecode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tostorecode.Location = New System.Drawing.Point(283, 42)
        Me.txt_Tostorecode.Name = "txt_Tostorecode"
        Me.txt_Tostorecode.Size = New System.Drawing.Size(64, 21)
        Me.txt_Tostorecode.TabIndex = 18
        '
        'txt_Mainstorecode
        '
        Me.txt_Mainstorecode.BackColor = System.Drawing.Color.Wheat
        Me.txt_Mainstorecode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Mainstorecode.Location = New System.Drawing.Point(99, 15)
        Me.txt_Mainstorecode.Name = "txt_Mainstorecode"
        Me.txt_Mainstorecode.ReadOnly = True
        Me.txt_Mainstorecode.Size = New System.Drawing.Size(64, 21)
        Me.txt_Mainstorecode.TabIndex = 16
        '
        'grp_issue2
        '
        Me.grp_issue2.BackColor = System.Drawing.Color.Transparent
        Me.grp_issue2.Controls.Add(Me.Label16)
        Me.grp_issue2.Controls.Add(Me.PictureBox2)
        Me.grp_issue2.Controls.Add(Me.lbl_Docno)
        Me.grp_issue2.Controls.Add(Me.lbl_Docdate)
        Me.grp_issue2.Controls.Add(Me.Txt_IndentNo)
        Me.grp_issue2.Controls.Add(Me.cmd_IndentNoHelp)
        Me.grp_issue2.Controls.Add(Me.dtp_IndentDate)
        Me.grp_issue2.Location = New System.Drawing.Point(541, 101)
        Me.grp_issue2.Name = "grp_issue2"
        Me.grp_issue2.Size = New System.Drawing.Size(309, 76)
        Me.grp_issue2.TabIndex = 19
        Me.grp_issue2.TabStop = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(272, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 24)
        Me.Label16.TabIndex = 475
        Me.Label16.Text = "F4"
        Me.Label16.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(123, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 26)
        Me.PictureBox2.TabIndex = 474
        Me.PictureBox2.TabStop = False
        '
        'Txt_IndentNo
        '
        Me.Txt_IndentNo.BackColor = System.Drawing.Color.Wheat
        Me.Txt_IndentNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_IndentNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_IndentNo.Location = New System.Drawing.Point(103, 14)
        Me.Txt_IndentNo.MaxLength = 15
        Me.Txt_IndentNo.Name = "Txt_IndentNo"
        Me.Txt_IndentNo.Size = New System.Drawing.Size(127, 21)
        Me.Txt_IndentNo.TabIndex = 374
        '
        'cmd_IndentNoHelp
        '
        Me.cmd_IndentNoHelp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_IndentNoHelp.Image = CType(resources.GetObject("cmd_IndentNoHelp.Image"), System.Drawing.Image)
        Me.cmd_IndentNoHelp.Location = New System.Drawing.Point(232, 13)
        Me.cmd_IndentNoHelp.Name = "cmd_IndentNoHelp"
        Me.cmd_IndentNoHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmd_IndentNoHelp.TabIndex = 376
        '
        'dtp_IndentDate
        '
        Me.dtp_IndentDate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_IndentDate.Enabled = False
        Me.dtp_IndentDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_IndentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_IndentDate.Location = New System.Drawing.Point(158, 41)
        Me.dtp_IndentDate.Name = "dtp_IndentDate"
        Me.dtp_IndentDate.Size = New System.Drawing.Size(96, 21)
        Me.dtp_IndentDate.TabIndex = 377
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Clear.Image = Global.SmartCard.My.Resources.Resources.Clear
        Me.Cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Clear.Location = New System.Drawing.Point(7, 16)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Clear.TabIndex = 7
        Me.Cmd_Clear.Text = "Clear[F6]"
        Me.Cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Clear.UseVisualStyleBackColor = False
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.Black
        Me.Cmd_View.Image = Global.SmartCard.My.Resources.Resources.view
        Me.Cmd_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_View.Location = New System.Drawing.Point(4, 195)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_View.TabIndex = 10
        Me.Cmd_View.Text = " View[F9]"
        Me.Cmd_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_View.UseVisualStyleBackColor = False
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Freeze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Freeze.Image = Global.SmartCard.My.Resources.Resources.Delete
        Me.Cmd_Freeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Freeze.Location = New System.Drawing.Point(5, 135)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Freeze.TabIndex = 9
        Me.Cmd_Freeze.Text = "Void[F8]"
        Me.Cmd_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Freeze.UseVisualStyleBackColor = False
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Add.Image = Global.SmartCard.My.Resources.Resources.save
        Me.Cmd_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Add.Location = New System.Drawing.Point(6, 76)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Add.TabIndex = 8
        Me.Cmd_Add.Text = "Add [F7]"
        Me.Cmd_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Add.UseVisualStyleBackColor = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Exit.Image = Global.SmartCard.My.Resources.Resources._Exit
        Me.Cmd_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Exit.Location = New System.Drawing.Point(4, 496)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Exit.TabIndex = 11
        Me.Cmd_Exit.Text = "Exit[F11]"
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.CMD_BROWSE)
        Me.frmbut.Controls.Add(Me.btn_auth)
        Me.frmbut.Controls.Add(Me.cmd_export)
        Me.frmbut.Controls.Add(Me.Cmd_Clear)
        Me.frmbut.Controls.Add(Me.cmd_Print)
        Me.frmbut.Controls.Add(Me.Cmd_Exit)
        Me.frmbut.Controls.Add(Me.Cmd_Add)
        Me.frmbut.Controls.Add(Me.Cmd_Freeze)
        Me.frmbut.Controls.Add(Me.Cmd_View)
        Me.frmbut.Location = New System.Drawing.Point(858, 77)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(144, 556)
        Me.frmbut.TabIndex = 27
        Me.frmbut.TabStop = False
        '
        'CMD_BROWSE
        '
        Me.CMD_BROWSE.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_BROWSE.Location = New System.Drawing.Point(7, 439)
        Me.CMD_BROWSE.Name = "CMD_BROWSE"
        Me.CMD_BROWSE.Size = New System.Drawing.Size(130, 51)
        Me.CMD_BROWSE.TabIndex = 468
        Me.CMD_BROWSE.Text = "Browse"
        Me.CMD_BROWSE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CMD_BROWSE.UseVisualStyleBackColor = True
        '
        'btn_auth
        '
        Me.btn_auth.BackColor = System.Drawing.Color.Transparent
        Me.btn_auth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_auth.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_auth.ForeColor = System.Drawing.Color.Black
        Me.btn_auth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_auth.Location = New System.Drawing.Point(4, 377)
        Me.btn_auth.Name = "btn_auth"
        Me.btn_auth.Size = New System.Drawing.Size(134, 56)
        Me.btn_auth.TabIndex = 466
        Me.btn_auth.Text = "Authorize"
        Me.btn_auth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_auth.UseVisualStyleBackColor = False
        '
        'cmd_export
        '
        Me.cmd_export.BackColor = System.Drawing.Color.Transparent
        Me.cmd_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_export.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_export.ForeColor = System.Drawing.Color.Black
        Me.cmd_export.Image = Global.SmartCard.My.Resources.Resources.excel
        Me.cmd_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_export.Location = New System.Drawing.Point(3, 317)
        Me.cmd_export.Name = "cmd_export"
        Me.cmd_export.Size = New System.Drawing.Size(134, 56)
        Me.cmd_export.TabIndex = 467
        Me.cmd_export.Text = "Export"
        Me.cmd_export.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_export.UseVisualStyleBackColor = False
        '
        'cmd_Print
        '
        Me.cmd_Print.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_Print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Print.ForeColor = System.Drawing.Color.Black
        Me.cmd_Print.Image = Global.SmartCard.My.Resources.Resources.print
        Me.cmd_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Print.Location = New System.Drawing.Point(4, 255)
        Me.cmd_Print.Name = "cmd_Print"
        Me.cmd_Print.Size = New System.Drawing.Size(134, 56)
        Me.cmd_Print.TabIndex = 22
        Me.cmd_Print.Text = "Print[F10]"
        Me.cmd_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Print.UseVisualStyleBackColor = False
        '
        'chk_excel
        '
        Me.chk_excel.BackColor = System.Drawing.Color.Transparent
        Me.chk_excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_excel.Location = New System.Drawing.Point(907, 661)
        Me.chk_excel.Name = "chk_excel"
        Me.chk_excel.Size = New System.Drawing.Size(72, 24)
        Me.chk_excel.TabIndex = 465
        Me.chk_excel.Text = "EXCEL"
        Me.chk_excel.UseVisualStyleBackColor = False
        Me.chk_excel.Visible = False
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Arial", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(483, 43)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(328, 25)
        Me.lbl_Freeze.TabIndex = 26
        Me.lbl_Freeze.Text = "Record Void  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'grp_Stockissue
        '
        Me.grp_Stockissue.BackgroundImage = CType(resources.GetObject("grp_Stockissue.BackgroundImage"), System.Drawing.Image)
        Me.grp_Stockissue.Controls.Add(Me.lbl_Stockissuedetails)
        Me.grp_Stockissue.Controls.Add(Me.GroupBox2)
        Me.grp_Stockissue.Controls.Add(Me.lbl_FromDocno)
        Me.grp_Stockissue.Controls.Add(Me.txt_FromDocno)
        Me.grp_Stockissue.Controls.Add(Me.lbl_ToDocno)
        Me.grp_Stockissue.Controls.Add(Me.txt_ToDocno)
        Me.grp_Stockissue.Controls.Add(Me.Cmd_ToDocno)
        Me.grp_Stockissue.Controls.Add(Me.Cmd_FromDocno)
        Me.grp_Stockissue.Location = New System.Drawing.Point(64, 1000)
        Me.grp_Stockissue.Name = "grp_Stockissue"
        Me.grp_Stockissue.Size = New System.Drawing.Size(520, 214)
        Me.grp_Stockissue.TabIndex = 360
        Me.grp_Stockissue.TabStop = False
        '
        'lbl_Stockissuedetails
        '
        Me.lbl_Stockissuedetails.BackColor = System.Drawing.Color.Maroon
        Me.lbl_Stockissuedetails.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Stockissuedetails.ForeColor = System.Drawing.Color.White
        Me.lbl_Stockissuedetails.Location = New System.Drawing.Point(0, 9)
        Me.lbl_Stockissuedetails.Name = "lbl_Stockissuedetails"
        Me.lbl_Stockissuedetails.Size = New System.Drawing.Size(520, 24)
        Me.lbl_Stockissuedetails.TabIndex = 26
        Me.lbl_Stockissuedetails.Text = "ISSUE CHECKLIST"
        Me.lbl_Stockissuedetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cmd_Issueprint)
        Me.GroupBox2.Controls.Add(Me.Cmd_IssueView)
        Me.GroupBox2.Controls.Add(Me.Cmd_Issueexit)
        Me.GroupBox2.Controls.Add(Me.Cmd_IssueClear)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(496, 56)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'Cmd_Issueprint
        '
        Me.Cmd_Issueprint.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Issueprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Issueprint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Issueprint.ForeColor = System.Drawing.Color.White
        Me.Cmd_Issueprint.Image = CType(resources.GetObject("Cmd_Issueprint.Image"), System.Drawing.Image)
        Me.Cmd_Issueprint.Location = New System.Drawing.Point(256, 16)
        Me.Cmd_Issueprint.Name = "Cmd_Issueprint"
        Me.Cmd_Issueprint.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Issueprint.TabIndex = 25
        Me.Cmd_Issueprint.Text = "Print [F10]"
        Me.Cmd_Issueprint.UseVisualStyleBackColor = False
        '
        'Cmd_IssueView
        '
        Me.Cmd_IssueView.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_IssueView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_IssueView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_IssueView.ForeColor = System.Drawing.Color.White
        Me.Cmd_IssueView.Image = CType(resources.GetObject("Cmd_IssueView.Image"), System.Drawing.Image)
        Me.Cmd_IssueView.Location = New System.Drawing.Point(128, 16)
        Me.Cmd_IssueView.Name = "Cmd_IssueView"
        Me.Cmd_IssueView.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_IssueView.TabIndex = 13
        Me.Cmd_IssueView.Text = "View [F9]"
        Me.Cmd_IssueView.UseVisualStyleBackColor = False
        '
        'Cmd_Issueexit
        '
        Me.Cmd_Issueexit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Issueexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Issueexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Issueexit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Issueexit.Image = CType(resources.GetObject("Cmd_Issueexit.Image"), System.Drawing.Image)
        Me.Cmd_Issueexit.Location = New System.Drawing.Point(376, 16)
        Me.Cmd_Issueexit.Name = "Cmd_Issueexit"
        Me.Cmd_Issueexit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Issueexit.TabIndex = 15
        Me.Cmd_Issueexit.Text = "Exit[F11]"
        Me.Cmd_Issueexit.UseVisualStyleBackColor = False
        '
        'Cmd_IssueClear
        '
        Me.Cmd_IssueClear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_IssueClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_IssueClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_IssueClear.ForeColor = System.Drawing.Color.White
        Me.Cmd_IssueClear.Image = CType(resources.GetObject("Cmd_IssueClear.Image"), System.Drawing.Image)
        Me.Cmd_IssueClear.Location = New System.Drawing.Point(8, 16)
        Me.Cmd_IssueClear.Name = "Cmd_IssueClear"
        Me.Cmd_IssueClear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_IssueClear.TabIndex = 24
        Me.Cmd_IssueClear.Text = "Clear[F6]"
        Me.Cmd_IssueClear.UseVisualStyleBackColor = False
        '
        'lbl_FromDocno
        '
        Me.lbl_FromDocno.AutoSize = True
        Me.lbl_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FromDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FromDocno.Location = New System.Drawing.Point(48, 56)
        Me.lbl_FromDocno.Name = "lbl_FromDocno"
        Me.lbl_FromDocno.Size = New System.Drawing.Size(134, 19)
        Me.lbl_FromDocno.TabIndex = 2
        Me.lbl_FromDocno.Text = "FROM DOC NO :"
        '
        'txt_FromDocno
        '
        Me.txt_FromDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_FromDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromDocno.Location = New System.Drawing.Point(200, 56)
        Me.txt_FromDocno.Name = "txt_FromDocno"
        Me.txt_FromDocno.Size = New System.Drawing.Size(208, 29)
        Me.txt_FromDocno.TabIndex = 4
        '
        'lbl_ToDocno
        '
        Me.lbl_ToDocno.AutoSize = True
        Me.lbl_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ToDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ToDocno.Location = New System.Drawing.Point(72, 104)
        Me.lbl_ToDocno.Name = "lbl_ToDocno"
        Me.lbl_ToDocno.Size = New System.Drawing.Size(107, 19)
        Me.lbl_ToDocno.TabIndex = 3
        Me.lbl_ToDocno.Text = "TO DOC NO :"
        '
        'txt_ToDocno
        '
        Me.txt_ToDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_ToDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ToDocno.Location = New System.Drawing.Point(200, 104)
        Me.txt_ToDocno.Name = "txt_ToDocno"
        Me.txt_ToDocno.Size = New System.Drawing.Size(208, 29)
        Me.txt_ToDocno.TabIndex = 5
        '
        'Cmd_ToDocno
        '
        Me.Cmd_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_ToDocno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ToDocno.Image = CType(resources.GetObject("Cmd_ToDocno.Image"), System.Drawing.Image)
        Me.Cmd_ToDocno.Location = New System.Drawing.Point(408, 104)
        Me.Cmd_ToDocno.Name = "Cmd_ToDocno"
        Me.Cmd_ToDocno.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_ToDocno.TabIndex = 39
        Me.Cmd_ToDocno.UseVisualStyleBackColor = False
        '
        'Cmd_FromDocno
        '
        Me.Cmd_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_FromDocno.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_FromDocno.Image = CType(resources.GetObject("Cmd_FromDocno.Image"), System.Drawing.Image)
        Me.Cmd_FromDocno.Location = New System.Drawing.Point(408, 56)
        Me.Cmd_FromDocno.Name = "Cmd_FromDocno"
        Me.Cmd_FromDocno.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_FromDocno.TabIndex = 38
        Me.Cmd_FromDocno.UseVisualStyleBackColor = False
        '
        'ssgrid
        '
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(272, 230)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(777, 193)
        Me.ssgrid.TabIndex = 368
        '
        'lbl_closingqty
        '
        Me.lbl_closingqty.AutoSize = True
        Me.lbl_closingqty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_closingqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_closingqty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_closingqty.Location = New System.Drawing.Point(0, 664)
        Me.lbl_closingqty.Name = "lbl_closingqty"
        Me.lbl_closingqty.Size = New System.Drawing.Size(159, 24)
        Me.lbl_closingqty.TabIndex = 369
        Me.lbl_closingqty.Text = "CLOSING QTY :"
        Me.lbl_closingqty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_closingqty.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 15)
        Me.Label1.TabIndex = 375
        Me.Label1.Text = "DOC NO "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(383, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 378
        Me.Label2.Text = " DOC DATE"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.dtp_Docdate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Cmd_Docnohelp)
        Me.GroupBox1.Controls.Add(Me.txt_Docno)
        Me.GroupBox1.Location = New System.Drawing.Point(193, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(660, 45)
        Me.GroupBox1.TabIndex = 379
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(345, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 24)
        Me.Label4.TabIndex = 476
        Me.Label4.Text = "F4"
        Me.Label4.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(482, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 26)
        Me.PictureBox1.TabIndex = 475
        Me.PictureBox1.TabStop = False
        '
        'Chk_item
        '
        Me.Chk_item.BackColor = System.Drawing.Color.Transparent
        Me.Chk_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_item.Location = New System.Drawing.Point(16, 648)
        Me.Chk_item.Name = "Chk_item"
        Me.Chk_item.Size = New System.Drawing.Size(120, 24)
        Me.Chk_item.TabIndex = 463
        Me.Chk_item.Text = "FooterUpdation"
        Me.Chk_item.UseVisualStyleBackColor = False
        Me.Chk_item.Visible = False
        '
        'txt_Remarks
        '
        Me.txt_Remarks.BackColor = System.Drawing.Color.White
        Me.txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Remarks.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(120, 16)
        Me.txt_Remarks.MaxLength = 200
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(480, 32)
        Me.txt_Remarks.TabIndex = 443
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txt_Remarks)
        Me.GroupBox3.Controls.Add(Me.lbl_Remarks)
        Me.GroupBox3.Location = New System.Drawing.Point(188, 616)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(665, 64)
        Me.GroupBox3.TabIndex = 464
        Me.GroupBox3.TabStop = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(24, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 24)
        Me.Label20.TabIndex = 478
        Me.Label20.Text = "ALT+ R"
        '
        'grp_footer
        '
        Me.grp_footer.BackColor = System.Drawing.Color.Transparent
        Me.grp_footer.Controls.Add(Me.Txt_signature)
        Me.grp_footer.Controls.Add(Me.Txt_footer)
        Me.grp_footer.Controls.Add(Me.Label9)
        Me.grp_footer.Controls.Add(Me.Label7)
        Me.grp_footer.Controls.Add(Me.Label8)
        Me.grp_footer.Location = New System.Drawing.Point(48, 272)
        Me.grp_footer.Name = "grp_footer"
        Me.grp_footer.Size = New System.Drawing.Size(752, 80)
        Me.grp_footer.TabIndex = 465
        Me.grp_footer.TabStop = False
        '
        'Txt_signature
        '
        Me.Txt_signature.Location = New System.Drawing.Point(120, 48)
        Me.Txt_signature.MaxLength = 79
        Me.Txt_signature.Name = "Txt_signature"
        Me.Txt_signature.Size = New System.Drawing.Size(620, 22)
        Me.Txt_signature.TabIndex = 441
        '
        'Txt_footer
        '
        Me.Txt_footer.Location = New System.Drawing.Point(120, 16)
        Me.Txt_footer.MaxLength = 150
        Me.Txt_footer.Name = "Txt_footer"
        Me.Txt_footer.Size = New System.Drawing.Size(620, 22)
        Me.Txt_footer.TabIndex = 440
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 15)
        Me.Label9.TabIndex = 439
        Me.Label9.Text = "FOOTER SIGN:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 15)
        Me.Label7.TabIndex = 438
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 15)
        Me.Label8.TabIndex = 438
        Me.Label8.Text = "FOOTER NAME:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(255, 442)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 16)
        Me.Label10.TabIndex = 466
        Me.Label10.Text = "[F3 DELETE A ROW IN GRID]"
        '
        'CHK_WAR
        '
        Me.CHK_WAR.BackColor = System.Drawing.Color.Transparent
        Me.CHK_WAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_WAR.Location = New System.Drawing.Point(8, 56)
        Me.CHK_WAR.Name = "CHK_WAR"
        Me.CHK_WAR.Size = New System.Drawing.Size(64, 24)
        Me.CHK_WAR.TabIndex = 467
        Me.CHK_WAR.Text = "WAR"
        Me.CHK_WAR.UseVisualStyleBackColor = False
        Me.CHK_WAR.Visible = False
        '
        'dtp_completiondate
        '
        Me.dtp_completiondate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_completiondate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_completiondate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_completiondate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_completiondate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_completiondate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_completiondate.Location = New System.Drawing.Point(470, 16)
        Me.dtp_completiondate.Name = "dtp_completiondate"
        Me.dtp_completiondate.Size = New System.Drawing.Size(133, 21)
        Me.dtp_completiondate.TabIndex = 486
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(327, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 15)
        Me.Label11.TabIndex = 483
        Me.Label11.Text = "AUTHORIZATION DATE"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 15)
        Me.Label15.TabIndex = 485
        Me.Label15.Text = "AUTHORISED BY"
        '
        'cmb_approvedby
        '
        Me.cmb_approvedby.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_approvedby.Items.AddRange(New Object() {"MANAGER", "STORE INCHARGE"})
        Me.cmb_approvedby.Location = New System.Drawing.Point(133, 15)
        Me.cmb_approvedby.Name = "cmb_approvedby"
        Me.cmb_approvedby.Size = New System.Drawing.Size(188, 23)
        Me.cmb_approvedby.TabIndex = 484
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 488
        Me.Label3.Text = "AUTH. DOC1"
        '
        'Pic_auth1
        '
        Me.Pic_auth1.BackColor = System.Drawing.Color.White
        Me.Pic_auth1.Location = New System.Drawing.Point(11, 44)
        Me.Pic_auth1.Name = "Pic_auth1"
        Me.Pic_auth1.Size = New System.Drawing.Size(310, 112)
        Me.Pic_auth1.TabIndex = 487
        Me.Pic_auth1.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(456, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 16)
        Me.Label5.TabIndex = 490
        Me.Label5.Text = "AUTH. DOC2"
        '
        'Pic_auth2
        '
        Me.Pic_auth2.BackColor = System.Drawing.Color.White
        Me.Pic_auth2.Location = New System.Drawing.Point(342, 44)
        Me.Pic_auth2.Name = "Pic_auth2"
        Me.Pic_auth2.Size = New System.Drawing.Size(218, 112)
        Me.Pic_auth2.TabIndex = 489
        Me.Pic_auth2.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Pic_auth1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.cmb_approvedby)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Pic_auth2)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.dtp_completiondate)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(201, 457)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(664, 166)
        Me.GroupBox4.TabIndex = 476
        Me.GroupBox4.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Txt_qty)
        Me.GroupBox5.Controls.Add(Me.txt_Totalamount)
        Me.GroupBox5.Location = New System.Drawing.Point(505, 426)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(291, 38)
        Me.GroupBox5.TabIndex = 491
        Me.GroupBox5.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 486
        Me.Label6.Text = "TOTAL"
        '
        'Txt_qty
        '
        Me.Txt_qty.BackColor = System.Drawing.Color.Wheat
        Me.Txt_qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_qty.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_qty.Location = New System.Drawing.Point(86, 9)
        Me.Txt_qty.MaxLength = 15
        Me.Txt_qty.Name = "Txt_qty"
        Me.Txt_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_qty.Size = New System.Drawing.Size(88, 26)
        Me.Txt_qty.TabIndex = 382
        '
        'txt_Totalamount
        '
        Me.txt_Totalamount.BackColor = System.Drawing.Color.Wheat
        Me.txt_Totalamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Totalamount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Totalamount.Location = New System.Drawing.Point(180, 8)
        Me.txt_Totalamount.MaxLength = 15
        Me.txt_Totalamount.Name = "txt_Totalamount"
        Me.txt_Totalamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Totalamount.Size = New System.Drawing.Size(104, 26)
        Me.txt_Totalamount.TabIndex = 381
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Location = New System.Drawing.Point(188, 212)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(623, 207)
        Me.GroupBox6.TabIndex = 492
        Me.GroupBox6.TabStop = False
        '
        'UNAUTHORISED
        '
        Me.UNAUTHORISED.AutoSize = True
        Me.UNAUTHORISED.Checked = True
        Me.UNAUTHORISED.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UNAUTHORISED.Location = New System.Drawing.Point(506, 83)
        Me.UNAUTHORISED.Name = "UNAUTHORISED"
        Me.UNAUTHORISED.Size = New System.Drawing.Size(124, 19)
        Me.UNAUTHORISED.TabIndex = 493
        Me.UNAUTHORISED.Text = "UNAUTHORISED"
        Me.UNAUTHORISED.UseVisualStyleBackColor = True
        '
        'StockIssue_Indent_authorization
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.BackgroundImage = Global.SmartCard.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1005, 745)
        Me.Controls.Add(Me.UNAUTHORISED)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.CHK_WAR)
        Me.Controls.Add(Me.chk_excel)
        Me.Controls.Add(Me.lbl_closingqty)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Chk_item)
        Me.Controls.Add(Me.grp_Stockissue)
        Me.Controls.Add(Me.ssgrid)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.grp_issue2)
        Me.Controls.Add(Me.grp_issue1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp_footer)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox6)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "StockIssue_Indent_authorization"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRANSACTION[STOCK ISSUE -INDENT]"
        Me.grp_issue1.ResumeLayout(False)
        Me.grp_issue1.PerformLayout()
        Me.grp_issue2.ResumeLayout(False)
        Me.grp_issue2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frmbut.ResumeLayout(False)
        Me.grp_Stockissue.ResumeLayout(False)
        Me.grp_Stockissue.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grp_footer.ResumeLayout(False)
        Me.grp_footer.PerformLayout()
        CType(Me.Pic_auth1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_auth2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim TotalCount As Integer
    Dim boolchk As Boolean
    Dim TOTALQTY, ISSUEQTY As Double
    Dim sqlstring As String
    Dim docno, doctype, docno1() As String
    Dim gconnection As New GlobalClass
    Dim vsearch, vitem, accountcode As String
    Dim VSTORECODE, VSTORENAME, VSTRDOCNO As String
    Dim CLQTY, CLQTY1 As Integer
    Dim CURRENTUOM As String
    Dim Sqlstr As String
    Dim strcn As String = "Data Source=" & gserver & ";Persist Security Info=False;User ID=" & ggusername & ";pwd=" & ggpassword & ";Initial Catalog= " & gDatabase & ";"
    Dim strPhotoFilePath_auth1, strPhotoFilePath_auth2 As String
    Private Sub StockIssue_Indent_authorization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.DoubleBuffered = True
            contadd()
            Resize_Form()
            'ssgrid.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width * 17.4) / 100, (Screen.PrimaryScreen.WorkingArea.Height * 33.51) / 100)
            'ssgrid.Width = 900
            'ssgrid.Height = 165
            'GroupBox6.Controls.Add(ssgrid)
            'ssgrid.Location = New Point(85, 20)

            StockIssueTransbool = True
            ssgrid.Lock = False
            txt_Docno.ReadOnly = True
            Me.Cmd_Freeze.Enabled = True
            txt_Tostorecode.ReadOnly = True
            ssgrid.SetActiveCell(1, 1)
            grp_Stockissue.Top = 1000
            cmb_approvedby.SelectedIndex = 0
            Call FOOTER()
            grp_footer.Visible = False
            Call FillStore() ''-->Fill Store Desc
            lbl_closingqty.Text = ""
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            If Not String.IsNullOrEmpty(gAuditFlg) Then
                If gAuditFlg.ToUpper = "Y" Then
                    Me.Cmd_Add.Enabled = False
                    Me.Cmd_Freeze.Enabled = False
                End If
            End If
            Show()
            Txt_IndentNo.Focus()
            gPrint = False
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Try
            Call clearform(Me)
            Call FillStore() '''-->Fill Store Desc
            'Call FillMainstore() '''-->Fill Main Store
            Me.dtp_Docdate.Value = Format(Now, "dd/MM/yyyy")
            Me.dtp_IndentDate.Value = Format(Now, "dd/MM/yyyy")
            Call FOOTER()
            grp_footer.Visible = False
            txt_Docno.Text = ""
            Me.lbl_Freeze.Visible = False
            Me.lbl_Freeze.Text = "Record Void  On "
            cmb_approvedby.SelectedIndex = 0
            ssgrid.ClearRange(1, 1, -1, -1, True)
            Me.Cmd_Freeze.Text = "Void [F8]"
            Cmd_Add.Text = "Add [F7]"
            txt_Mainstorecode.Text = ""
            txt_Mainstore.Text = ""
            txt_Remarks.Text = ""
            ssgrid.SetActiveCell(1, 1)
            grp_Stockissue.Top = 1000
            Cmd_Add.Enabled = True
            Cmd_Freeze.Enabled = True
            txt_Docno.Enabled = True
            txt_Docno.ReadOnly = False
            Txt_IndentNo.ReadOnly = False
            txt_Tostorecode.ReadOnly = False
            Me.Cmd_Freeze.Enabled = True
            txt_Mainstore.ReadOnly = True
            cbo_Tostore.Enabled = True
            txt_Tostorecode.Enabled = True
            ' dtp_IndentDate.Enabled = True
            Txt_qty.Enabled = True
            txt_Totalamount.Enabled = True
            Pic_auth2.Image = Nothing
            Pic_auth1.Image = Nothing
            strPhotoFilePath_auth1 = ""
            strPhotoFilePath_auth2 = ""
            lbl_closingqty.Text = ""
            ssgrid.Focus()
            ssgrid.SetActiveCell(1, 1)
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            If Not String.IsNullOrEmpty(gAuditFlg) Then
                If gAuditFlg.ToUpper = "Y" Then
                    Me.Cmd_Add.Enabled = False
                    Me.Cmd_Freeze.Enabled = False
                End If
            End If
            Show()
            Txt_IndentNo.Text = ""
            Txt_IndentNo.Focus()
            gPrint = False
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Try
            Dim Totalamt, totalqty, Avgrate, AvgQuantity, CHK_QTY As Double
            Dim sqlstring, Itemcode, Insert(0) As String
            Dim dblval, dblqty As Double
            Dim i, j As Integer
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            Calculate()


            ''*********************************************************** Case-1 : Add [F7] *******************************************'''
            If Cmd_Add.Text = "Add [F7]" Then
                docno1 = Split(Trim(txt_Docno.Text), "/")
                sqlstring = "INSERT INTO PO_STOCKINDENTAUTH_HDR(Docno,Docdetails,Doctype,Docdate,IndentNo,IndentDate,Storelocationcode,Storelocationname, "
                sqlstring = sqlstring & " Opstorelocationcode, Opstorelocationname, Totalamt,Remarks,Void,VoidReason,Adduser,Adddate,Updateuser,Updatetime,AUTHRZEBY,AUTHRZEDATE,UPDFOOTER,UPDSIGN)"
                sqlstring = sqlstring & " VALUES ('" & CStr(docno1(1)) & "','" & Trim(txt_Docno.Text) & "','" & Trim(docno) & "',"
                'sqlstring = sqlstring & " VALUES ('" & Trim(txt_Docno.Text) & "','" & Trim(txt_Docno.Text) & "','" & Trim(docno) & "',"
                sqlstring = sqlstring & " '" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy") & "','" & Trim(Txt_IndentNo.Text) & "','" & Format(CDate(dtp_IndentDate.Value), "dd-MMM-yyyy") & "',"
                sqlstring = sqlstring & " '" & Trim(txt_Mainstorecode.Text) & "','" & Trim(txt_Mainstore.Text) & "','" & Trim(txt_Tostorecode.Text) & "', "
                sqlstring = sqlstring & " '" & Trim(cbo_Tostore.Text) & "'," & Format(Val(txt_Totalamount.Text), "0.00") & " ,"
                sqlstring = sqlstring & " '" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "' ,'N','" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "',"
                sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                sqlstring = sqlstring & " '','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Trim(cmb_approvedby.Text) & "','" & Format(dtp_completiondate.Value, "dd-MMM-yyyy hh:mm:ss") & "',"
                sqlstring = sqlstring & " '" & Trim(Txt_footer.Text) & "',' " & Trim(Txt_signature.Text) & "' )"
                Insert(0) = sqlstring
                '''******************************************************** Insert into stockissuedetail **********************************'''
                For i = 1 To ssgrid.DataRowCnt
                    CHK_QTY = 0
                    ssgrid.Row = i
                    ssgrid.Col = 12
                    CHK_QTY = Val(ssgrid.Text)
                    ssgrid.Row = i
                    ssgrid.Col = 1
                    Avgrate = CalAverageRate(Trim(ssgrid.Text))
                    AvgQuantity = CalAverageQuantity(Trim(ssgrid.Text))
                    sqlstring = "INSERT INTO PO_STOCKINDENTAUTH_DET(Docno,Docdetails,Docdate,IndentNo,IndentDate,Storelocationcode,Storelocationname,"
                    sqlstring = sqlstring & " Opstorelocationcode,Opstorelocationname,Itemcode,Itemname,Uom,Qty,Rate,Amount,Clsqty,"
                    sqlstring = sqlstring & " Dblamt,Dblconv,Highratio,Groupcode,Subgroupcode,Void,Avgqty,Avgrate,Adduser,adddatetime,Updateuser,Updatetime,IND_QTY)"
                    sqlstring = sqlstring & " VALUES ('" & Trim(txt_Docno.Text) & "','" & Trim(txt_Docno.Text) & "',"
                    sqlstring = sqlstring & " '" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy") & "',"
                    sqlstring = sqlstring & " '" & Trim(Txt_IndentNo.Text) & "','" & Format(CDate(dtp_IndentDate.Value), "dd-MMM-yyyy") & "',"
                    sqlstring = sqlstring & " '" & Trim(txt_Mainstorecode.Text) & "','" & Trim(txt_Mainstore.Text) & "', "
                    sqlstring = sqlstring & " '" & Trim(txt_Tostorecode.Text) & "','" & Trim(cbo_Tostore.Text) & "',"

                    ssgrid.Col = 1
                    Itemcode = Trim(ssgrid.Text)
                    sqlstring = sqlstring & "'" & Trim(Itemcode) & "',"
                    ssgrid.Col = 2
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 3
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 4
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.000") & ","

                    ssgrid.Col = 5
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 6
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 13
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 7
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 8
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 9
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 10
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 11
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    sqlstring = sqlstring & "'N'," & Format(Val(AvgQuantity), "0.000") & "," & Format(Val(Avgrate), "0.00") & ","
                    sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                    sqlstring = sqlstring & " ' ','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                    ssgrid.Col = 4
                    sqlstring = sqlstring & "" & Format(CHK_QTY - Val(ssgrid.Text), "0.00") & ")"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring

                    ' UPDATING CURRENT STOCK IN INVENTORYITEMMASTER -START  --***VENUJD
                    '    clqty = 0
                    '    CLQTY1 = 0
                    '    ssgrid.Col = 1
                    '    ssgrid.Row = i
                    '    sqlstring = "select (QTY * b.convvalue) as QTY from PO_STOCKINDENTAUTH_DET,INVENTORY_TRANSCONVERSION B,INVENTORYITEMMASTER i WHERE DOCDETAILS ='" & txt_Docno.Text & "' AND i.ITEMCODE ='" & Trim(ssgrid.Text) & "' AND i.STORECODE = '" & Trim(txt_Mainstorecode.Text) & "' AND i.STOCKUOM = B.TRANSUOM AND  uom = B.BASEUOM"
                    '    gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
                    '    If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
                    '        clqty = gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")
                    '    End If
                    '    sqlstring = "select (QTY * b.convvalue) as QTY from PO_STOCKINDENTAUTH_DET,INVENTORY_TRANSCONVERSION B,INVENTORYITEMMASTER i WHERE DOCDETAILS ='" & txt_Docno.Text & "' AND i.ITEMCODE ='" & Trim(ssgrid.Text) & "' AND i.STORECODE = '" & Trim(txt_Tostorecode.Text) & "' AND i.STOCKUOM = B.TRANSUOM AND  uom = B.BASEUOM"
                    '    gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
                    '    If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
                    '        CLQTY1 = gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")
                    '    End If

                    '    ssgrid.Col = 3
                    '    ssgrid.Row = i
                    '    currentuom = Trim(ssgrid.Text)
                    '    ssgrid.Col = 4
                    '    ssgrid.Row = i
                    '    sqlstring = "UPDATE INVENTORYITEMMASTER SET CLOSINGQTY = (ISNULL(CLOSINGQTY,0) + " & Format(Val(clqty), "0.00") & ") - (" & Format(Val(ssgrid.Text), "0.00") & " * B.CONVVALUE)  FROM INVENTORY_TRANSCONVERSION B "
                    '    ssgrid.Col = 1
                    '    ssgrid.Row = i
                    '    sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "' AND STORECODE = '" & Trim(txt_Mainstorecode.Text) & "' AND STOCKUOM = B.TRANSUOM AND  '" & Trim(currentuom) & "' = B.BASEUOM"
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring

                    '    ssgrid.Col = 3
                    '    ssgrid.Row = i
                    '    currentuom = Trim(ssgrid.Text)
                    '    ssgrid.Col = 4
                    '    ssgrid.Row = i
                    '    sqlstring = "UPDATE INVENTORYITEMMASTER SET CLOSINGQTY = (ISNULL(CLOSINGQTY,0) - " & Format(Val(CLQTY1), "0.00") & ") + (" & Format(Val(ssgrid.Text), "0.00") & " * B.CONVVALUE)  FROM INVENTORY_TRANSCONVERSION B "
                    '    ssgrid.Col = 1
                    '    ssgrid.Row = i
                    '    sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "' AND STORECODE = '" & Trim(txt_Tostorecode.Text) & "' AND STOCKUOM = B.TRANSUOM AND  '" & Trim(currentuom) & "' = B.BASEUOM"
                    '    ReDim Preserve Insert(Insert.Length)
                    '    Insert(Insert.Length - 1) = sqlstring
                    '    ' UPDATING CURRENT STOCK IN INVENTORYITEMMASTER -END  --***VENUJD
                Next i
                ' Loadimage()
                gconnection.MoreTrans(Insert)

                Sqlstr = " Update PO_STOCKINDENTAUTH_HDR set auth1=@memimage Where docdetails='" & txt_Docno.Text & "' "
                Call SaveFoto(strPhotoFilePath_auth1, Trim(txt_Docno.Text.Replace("'", "")), Sqlstr)
                Sqlstr = " Update PO_STOCKINDENTAUTH_HDR set auth2=@memimage Where docdetails='" & txt_Docno.Text & "' "
                Call SaveFoto(strPhotoFilePath_auth2, Trim(txt_Docno.Text.Replace("'", "")), Sqlstr)

                Cmd_Add.Text = "Add [F7]"
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Call Cmd_View_Click(Cmd_View, e)
                    Call Cmd_Clear_Click(sender, e)
                Else
                    Call Cmd_Clear_Click(sender, e)
                End If
                '''*********************************************************** Case-2 : Update [F7] *******************************************'''
            Else
                docno1 = Split(Trim(txt_Docno.Text), "/")
                ''''****************************************CHECK FOR CLSSTOCK OF CORRESPONDING SUBSTORE ******************************************************'''
                Dim CURQTY, PREVQTY, CLSQTY, VDIFF As Double

                sqlstring = " SELECT auth_docno FROM PO_HDR WHERE auth_docno='" & txt_Docno.Text & "' AND ISNULL(freeze,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "docVAL")
                If gdataset.Tables("docVAL").Rows.Count > 0 Then
                    MessageBox.Show("This document Has Been Processed,You Cannot do any modification")
                    Exit Sub
                End If
                'For i = 1 To ssgrid.DataRowCnt
                '    ssgrid.Row = i
                '    ssgrid.Col = 4
                '    CURQTY = Val(ssgrid.Text)
                '    ssgrid.Col = 12
                '    PREVQTY = Val(ssgrid.Text)
                '    ssgrid.Col = 13
                '    CLSQTY = Val(ssgrid.Text)
                '    VDIFF = Val(CLSQTY) + Val(PREVQTY) - Val(CURQTY)
                '    If Val(VDIFF) < 0 Then
                '        MessageBox.Show("STOCK IS NOT SUFFICIENT TO  MODIFY...", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '        ssgrid.Col = 4
                '        'ssgrid.Text = ""
                '        ssgrid.SetActiveCell(4, i)
                '        ssgrid.Focus()
                '        Exit Sub
                '    End If
                'Next
                ''''*************************************
                sqlstring = "UPDATE PO_STOCKINDENTAUTH_HDR SET Docdate='" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy") & "', "
                sqlstring = sqlstring & " Storelocationcode='" & Trim(txt_Mainstorecode.Text) & "',"
                sqlstring = sqlstring & " Storelocationname='" & Trim(txt_Mainstore.Text) & "',"
                sqlstring = sqlstring & " Opstorelocationcode='" & Trim(txt_Tostorecode.Text) & "',"
                sqlstring = sqlstring & " Opstorelocationname='" & Trim(cbo_Tostore.Text) & "', "
                sqlstring = sqlstring & " Totalamt=" & Format(Val(txt_Totalamount.Text), "0.00") & ","
                sqlstring = sqlstring & " UPDFOOTER = ' " & Trim(Txt_footer.Text) & " ' ,"
                sqlstring = sqlstring & " UPDSIGN = ' " & Trim(Txt_signature.Text) & " ' ,"
                sqlstring = sqlstring & " Remarks='" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "' ,Void='N',"
                sqlstring = sqlstring & " VoidReason = '" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "',Updateuser='" & Trim(gUsername) & "',"
                sqlstring = sqlstring & " Updatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                sqlstring = sqlstring & " AUTHRZEBY = ' " & Trim(cmb_approvedby.Text) & " ' ,"
                sqlstring = sqlstring & " AUTHRZEDATE='" & Format(dtp_completiondate.Value, "dd-MMM-yyyy hh:mm:ss") & "'"
                sqlstring = sqlstring & " WHERE Docdetails='" & Trim(txt_Docno.Text) & "' "
                sqlstring = sqlstring & " AND INDENTNO = '" & Trim(Txt_IndentNo.Text) & "'"
                Insert(0) = sqlstring
                '''********************************************************* DELETE FROM stockissuedetail *****************************************************'''
                sqlstring = "DELETE FROM PO_STOCKINDENTAUTH_DET WHERE docdetails='" & Trim(txt_Docno.Text) & "' "
                sqlstring = sqlstring & " AND INDENTNO = '" & Trim(Txt_IndentNo.Text) & "'"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
                '''******************************************************** INSERT INTO stockissuedetail ******************************************************'''
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Row = i
                    ssgrid.Col = 1
                    Avgrate = CalAverageRate(Trim(ssgrid.Text))
                    AvgQuantity = CalAverageQuantity(Trim(ssgrid.Text))
                    sqlstring = "INSERT INTO PO_STOCKINDENTAUTH_DET(Docno,Docdetails,Docdate,IndentNo,IndentDate,Storelocationcode,Storelocationname,"
                    sqlstring = sqlstring & " Opstorelocationcode,Opstorelocationname,Itemcode,Itemname,Uom,Qty,Rate,Amount,Clsqty,"
                    sqlstring = sqlstring & " Dblamt,Dblconv,Highratio,Groupcode,Subgroupcode,Void,Avgqty,Avgrate,Adduser,adddatetime,Updateuser,Updatetime,IND_QTY)"
                    sqlstring = sqlstring & " VALUES ('" & CStr(docno1(1)) & "','" & Trim(txt_Docno.Text) & "',"
                    sqlstring = sqlstring & " '" & Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy") & "',"
                    sqlstring = sqlstring & " '" & Trim(Txt_IndentNo.Text) & "','" & Format(CDate(dtp_IndentDate.Value), "dd-MMM-yyyy") & "',"
                    sqlstring = sqlstring & " '" & Trim(txt_Mainstorecode.Text) & "','" & Trim(txt_Mainstore.Text) & "', "
                    sqlstring = sqlstring & " '" & Trim(txt_Tostorecode.Text) & "','" & Trim(cbo_Tostore.Text) & "',"
                    ssgrid.Col = 1
                    Itemcode = Trim(ssgrid.Text)
                    sqlstring = sqlstring & "'" & Trim(Itemcode) & "',"
                    ssgrid.Col = 2
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 3
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 4
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.000") & ","
                    ssgrid.Col = 5
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 6
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 13
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 7
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.000") & ","
                    ssgrid.Col = 8
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 9
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
                    ssgrid.Col = 10
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    ssgrid.Col = 11
                    sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
                    sqlstring = sqlstring & "'N'," & Format(Val(AvgQuantity), "0.000") & "," & Format(Val(Avgrate), "0.00") & ","
                    sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                    sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                    ssgrid.Col = 12
                    sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ")"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring

                    ' UPDATING CURRENT STOCK IN INVENTORYITEMMASTER -START  --***VENUJD
                    CLQTY = 0
                    CLQTY1 = 0
                    ssgrid.Col = 1
                    ssgrid.Row = i
                    sqlstring = "select (QTY * b.convvalue) as QTY from PO_STOCKINDENTAUTH_DET,INVENTORY_TRANSCONVERSION B,INVENTORYITEMMASTER i WHERE DOCDETAILS ='" & txt_Docno.Text & "' AND i.ITEMCODE ='" & Trim(ssgrid.Text) & "' AND i.STORECODE = '" & Trim(txt_Mainstorecode.Text) & "' AND i.STOCKUOM = B.TRANSUOM AND  uom = B.BASEUOM"
                    gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
                    If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
                        CLQTY = gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")
                    End If
                    sqlstring = "select (QTY * b.convvalue) as QTY from PO_STOCKINDENTAUTH_DET,INVENTORY_TRANSCONVERSION B,INVENTORYITEMMASTER i WHERE DOCDETAILS ='" & txt_Docno.Text & "' AND i.ITEMCODE ='" & Trim(ssgrid.Text) & "' AND i.STORECODE = '" & Trim(txt_Tostorecode.Text) & "' AND i.STOCKUOM = B.TRANSUOM AND  uom = B.BASEUOM"
                    gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
                    If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
                        CLQTY1 = gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")
                    End If

                    'ssgrid.Col = 3
                    'ssgrid.Row = i
                    'CURRENTUOM = Trim(ssgrid.Text)
                    'ssgrid.Col = 4
                    'ssgrid.Row = i
                    'sqlstring = "UPDATE INVENTORYITEMMASTER SET CLOSINGQTY = (ISNULL(CLOSINGQTY,0) + " & Format(Val(CLQTY), "0.00") & ") - (" & Format(Val(ssgrid.Text), "0.00") & " * B.CONVVALUE)  FROM INVENTORY_TRANSCONVERSION B "
                    'ssgrid.Col = 1
                    'ssgrid.Row = i
                    'sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "' AND STORECODE = '" & Trim(txt_Mainstorecode.Text) & "' AND STOCKUOM = B.TRANSUOM AND  '" & Trim(CURRENTUOM) & "' = B.BASEUOM"
                    'ReDim Preserve Insert(Insert.Length)
                    'Insert(Insert.Length - 1) = sqlstring

                    'ssgrid.Col = 3
                    'ssgrid.Row = i
                    'CURRENTUOM = Trim(ssgrid.Text)
                    'ssgrid.Col = 4
                    'ssgrid.Row = i
                    'sqlstring = "UPDATE INVENTORYITEMMASTER SET CLOSINGQTY = (ISNULL(CLOSINGQTY,0) - " & Format(Val(CLQTY1), "0.00") & ") + (" & Format(Val(ssgrid.Text), "0.00") & " * B.CONVVALUE)  FROM INVENTORY_TRANSCONVERSION B "
                    'ssgrid.Col = 1
                    'ssgrid.Row = i
                    'sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "' AND STORECODE = '" & Trim(txt_Tostorecode.Text) & "' AND STOCKUOM = B.TRANSUOM AND  '" & Trim(CURRENTUOM) & "' = B.BASEUOM "
                    'ReDim Preserve Insert(Insert.Length)
                    'Insert(Insert.Length - 1) = sqlstring
                    ' UPDATING CURRENT STOCK IN INVENTORYITEMMASTER -END  --***VENUJD


                    '''****************************************** UPDATE Complete *********************************************'''
                Next i
                gconnection.MoreTrans(Insert)
                '   Call Issue_Triggers(txt_Docno.Text)
                Sqlstr = " Update PO_STOCKINDENTAUTH_HDR set auth1=@memimage Where docdetails='" & txt_Docno.Text & "' "
                Call SaveFoto(strPhotoFilePath_auth1, Trim(txt_Docno.Text.Replace("'", "")), Sqlstr)

                Sqlstr = " Update PO_STOCKINDENTAUTH_HDR set auth2=@memimage Where docdetails='" & txt_Docno.Text & "' "
                Call SaveFoto(strPhotoFilePath_auth2, Trim(txt_Docno.Text.Replace("'", "")), Sqlstr)

                Cmd_Add.Text = "Add [F7]"
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    If Trim(txt_Docno.Text) <> "" Then
                        txt_FromDocno.Text = Trim(txt_Docno.Text)
                        txt_ToDocno.Text = Trim(txt_Docno.Text)
                    End If
                    ' Call cmd_Print_Click(Cmd_View, e)
                    Call Cmd_View_Click(Cmd_View, e)
                    Call Cmd_Clear_Click(sender, e)
                Else
                    Call Cmd_Clear_Click(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Function CHECKUPDATECLBAL(ByVal VPREVQTY As Double, ByVal VCURQTY As Double, ByVal VCLQTY As Double) As Double
        Try
            '   CHECKUPDATECLBAL = Val(VCLQTY) + Val(VCURQTY) - Val(VPREVQTY)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Try
            Dim i As Integer
            Dim insert(0), strsql As String
            Call checkValidation() ''-->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_Freeze.Text, 1, 1) = "V" Then

                If MsgBox("Are you Sure to Freeze the Record..", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                    Exit Sub
                End If
                ''***************************************** Void the DOCNO is Complete **********************************'''
                sqlstring = "INSERT INTO PO_STOCKINDENTAUTH_HDR_DEL( Docno , Docdetails , Doctype , Docdate , IndentNo , IndentDate , Storelocationcode , Storelocationname , Opstorelocationcode , Opstorelocationname , Totalamt , Remarks , Void , Voidreason , Adduser , Adddate , Updateuser , Updatetime )                                        "
                sqlstring = sqlstring & " SELECT Docno , Docdetails , Doctype , Docdate , IndentNo , IndentDate , Storelocationcode , Storelocationname , Opstorelocationcode , Opstorelocationname , Totalamt , Remarks , Void , Voidreason , Adduser , Adddate , Updateuser , Updatetime"
                sqlstring = sqlstring & " FROM PO_STOCKINDENTAUTH_HDR A"
                sqlstring = sqlstring & " WHERE A.INDENTNO = '" & Trim(Txt_IndentNo.Text) & "' "
                sqlstring = sqlstring & " AND Docdetails = '" & Trim(txt_Docno.Text) & "'"
                insert(0) = sqlstring

                sqlstring = " DELETE FROM PO_STOCKINDENTAUTH_HDR "
                sqlstring = sqlstring & " WHERE INDENTNO = '" & Trim(Txt_IndentNo.Text) & "' "
                sqlstring = sqlstring & " AND Docdetails = '" & Trim(txt_Docno.Text) & "'"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = sqlstring
                ''***************************************** DELETE the DOCNO in Complete **********************************'''
                ''***************************************** DELETE the DOCNO in stockissuedetails **************************'''
                For i = 1 To ssgrid.DataRowCnt
                    With ssgrid
                        sqlstring = "INSERT INTO PO_STOCKINDENTAUTH_DET_DEL( Docno , Docdetails , Docdate , IndentNo , IndentDate , Storelocationcode , Storelocationname , Opstorelocationcode  , Opstorelocationname , Itemcode , Itemname , Uom , Qty , Rate , Amount , Dblamt , Dblconv , Highratio , Groupcode , Subgroupcode , Void , Avgqty , Avgrate , Adduser , Adddatetime , Updateuser , Updatetime )               "
                        sqlstring = sqlstring & " SELECT  Docno , Docdetails , Docdate , IndentNo , IndentDate , Storelocationcode , Storelocationname , Opstorelocationcode  , Opstorelocationname , Itemcode , Itemname , Uom , Qty , Rate , Amount , Dblamt , Dblconv , Highratio , Groupcode , Subgroupcode , Void , Avgqty , Avgrate , Adduser , Adddatetime , Updateuser , Updatetime "
                        sqlstring = sqlstring & " FROM PO_STOCKINDENTAUTH_DET A"
                        sqlstring = sqlstring & " WHERE INDENTNO = '" & Trim(Txt_IndentNo.Text) & "' "
                        sqlstring = sqlstring & " AND Docdetails = '" & Trim(txt_Docno.Text) & "'"
                        ReDim Preserve insert(insert.Length)
                        insert(insert.Length - 1) = sqlstring

                        ' UPDATING CURRENT STOCK IN INVENTORYITEMMASTER -START  --***VENUJD
                        CLQTY = 0
                        CLQTY1 = 0
                        ssgrid.Col = 1
                        ssgrid.Row = i
                        sqlstring = "select (QTY * b.convvalue) as QTY from PO_STOCKINDENTAUTH_DET,INVENTORY_TRANSCONVERSION B,INVENTORYITEMMASTER i WHERE DOCDETAILS ='" & txt_Docno.Text & "' AND i.ITEMCODE ='" & Trim(ssgrid.Text) & "' AND i.STORECODE = '" & Trim(txt_Mainstorecode.Text) & "' AND i.STOCKUOM = B.TRANSUOM AND  uom = B.BASEUOM"
                        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
                        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
                            CLQTY = gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")
                        End If
                        sqlstring = "select (QTY * b.convvalue) as QTY from PO_STOCKINDENTAUTH_DET,INVENTORY_TRANSCONVERSION B,INVENTORYITEMMASTER i WHERE DOCDETAILS ='" & txt_Docno.Text & "' AND i.ITEMCODE ='" & Trim(ssgrid.Text) & "' AND i.STORECODE = '" & Trim(txt_Tostorecode.Text) & "' AND i.STOCKUOM = B.TRANSUOM AND  uom = B.BASEUOM"
                        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
                        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
                            CLQTY1 = gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")
                        End If

                        ssgrid.Col = 3
                        ssgrid.Row = i
                        CURRENTUOM = Trim(ssgrid.Text)
                        ssgrid.Col = 4
                        ssgrid.Row = i
                        sqlstring = "UPDATE INVENTORYITEMMASTER SET CLOSINGQTY = (ISNULL(CLOSINGQTY,0) + " & Format(Val(CLQTY), "0.00") & ")  "
                        ssgrid.Col = 1
                        ssgrid.Row = i
                        sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "' AND STORECODE = '" & Trim(txt_Mainstorecode.Text) & "' "
                        'ReDim Preserve insert(insert.Length)
                        'insert(insert.Length - 1) = sqlstring

                        ssgrid.Col = 3
                        ssgrid.Row = i
                        CURRENTUOM = Trim(ssgrid.Text)
                        ssgrid.Col = 4
                        ssgrid.Row = i
                        sqlstring = "UPDATE INVENTORYITEMMASTER SET CLOSINGQTY = (ISNULL(CLOSINGQTY,0) - " & Format(Val(CLQTY1), "0.00") & ")  "
                        ssgrid.Col = 1
                        ssgrid.Row = i
                        sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "' AND STORECODE = '" & Trim(txt_Tostorecode.Text) & "' "
                        'ReDim Preserve insert(insert.Length)
                        'insert(insert.Length - 1) = sqlstring
                        '' UPDATING CURRENT STOCK IN INVENTORYITEMMASTER -END  --***VENUJD
                    End With
                Next i
                sqlstring = " DELETE FROM PO_STOCKINDENTAUTH_DET "
                sqlstring = sqlstring & " WHERE INDENTNO = '" & Trim(Txt_IndentNo.Text) & "' "
                sqlstring = sqlstring & " AND Docdetails = '" & Trim(txt_Docno.Text) & "'"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = sqlstring
                '''****************************************** UPDATE Opening Stock ***************************************

                gconnection.MoreTrans(insert)
                Me.Cmd_Clear_Click(sender, e)
                Cmd_Add.Text = "Add [F7]"
                '''****************************************** UPDATE Complete *********************************************
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Try
            'If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
            Dim rViewer As New Viewer
            Dim sqlstring, SSQL, FROMSTORE As String
            Dim r As New Rpt_IndentIssue_
            sqlstring = "SELECT TOP 100 PERCENT docdetails, docdate, storelocationname, "
            sqlstring = sqlstring & " opstorelocationname, itemcode,storelocationcode,opstorelocationcode, "
            sqlstring = sqlstring & " itemname, uom,qty,AUTH1,AUTH2, rate, amount ,clsqty, indentno , indentdate,remarks,UPDFOOTER,UPDSIGN,ADDDATE"
            sqlstring = sqlstring & " FROM VW_PO_STOCKINDENTAUTH_BILL "
            sqlstring = sqlstring & " WHERE docdetails = '" & Trim(txt_Docno.Text) & "' "
            sqlstring = sqlstring & " ORDER BY docdetails"

            gconnection.getDataSet(sqlstring, "VW_INV_ISSUEBILL")
            If gdataset.Tables("VW_INV_ISSUEBILL").Rows.Count > 0 Then
                If chk_excel.Checked = True Then
                    Dim exp As New exportexcel
                    exp.Show()
                    Call exp.export(sqlstring, "STOCK ISSUE ", "")
                Else
                    rViewer.ssql = sqlstring
                    rViewer.Report = r
                    rViewer.TableName = "VW_INV_ISSUEBILL"
                    Dim textobj1 As TextObject
                    textobj1 = r.ReportDefinition.ReportObjects("Text13")
                    textobj1.Text = MyCompanyName
                    textobj1 = r.ReportDefinition.ReportObjects("Text21")
                    textobj1.Text = gUsername

                    Dim TXTOBJ2 As TextObject
                    TXTOBJ2 = r.ReportDefinition.ReportObjects("Text23")
                    TXTOBJ2.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode

                    Dim txtobj3 As TextObject
                    txtobj3 = r.ReportDefinition.ReportObjects("Text25")
                    txtobj3.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:" & gEmail & ", Web:" & gWebsite

                    Dim txtobj4 As TextObject
                    txtobj4 = r.ReportDefinition.ReportObjects("Text26")
                    txtobj4.Text = "Service Tax:" & gServiceTax & ", Tin No.:" & gTinNo
                    rViewer.Show()
                End If
            Else
                MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
            End If
            ''''Else

            ''''gPrint = False
            ''''Dim i As Integer
            ''''Dim objStockIssueClass As New rptStockissuereport
            ''''sqlstring = "SELECT TOP 100 PERCENT dbo.stockissueheader.docdetails, dbo.stockissueheader.docdate, dbo.stockissueheader.storelocationname, "
            ''''sqlstring = sqlstring & " dbo.stockissueheader.opstorelocationname, dbo.stockissuedetail.itemcode,dbo.stockissueheader.storelocationcode,dbo.stockissueheader.opstorelocationcode, "
            ''''sqlstring = sqlstring & " dbo.stockissuedetail.itemname, dbo.stockissuedetail.uom,dbo.stockissuedetail.qty, dbo.stockissuedetail.rate, dbo.stockissuedetail.amount , dbo.stockissueheader.indentno ,  dbo.stockissueheader.indentdate,dbo.stockissueheader.remarks,dbo.stockissueheader.UPDFOOTER,dbo.stockissueheader.UPDSIGN"
            ''''sqlstring = sqlstring & " FROM dbo.stockissuedetail INNER JOIN dbo.stockissueheader ON dbo.stockissuedetail.docdetails = dbo.stockissueheader.docdetails"
            ''''sqlstring = sqlstring & " WHERE dbo.stockissueheader.docdetails = '" & Trim(txt_Docno.Text) & "' "
            ''''sqlstring = sqlstring & " ORDER BY dbo.stockissueheader.docdetails"
            ''''Dim arraystring() As String = {"SLNO", "ITEM CODE", "ITEM NAME", "UOM", "QUANTITY", "RATE", "AMOUNT"}
            ''''Dim heading() As String = {"STOCK ISSUE"}
            ''''Dim colsize() As Integer = {5, 15, 40, 16, 10, 12, 12}
            ''''objStockIssueClass.Reportdetails(sqlstring, heading, arraystring, colsize)
            ''''End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillStore()
        Try
            Dim i As Integer
            sqlstring = " SELECT DISTINCT(storecode),storedesc FROM STOREMASTER WHERE  (ISNULL(STORESTATUS,'') = 'S' OR ISNULL(STORESTATUS,'') = '')  AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STOREDESC ASC"
            gconnection.getDataSet(sqlstring, "STOREMASTER")
            cbo_Tostore.Items.Clear()
            cbo_Tostore.Sorted = True
            If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("STOREMASTER").Rows.Count - 1
                    cbo_Tostore.Items.Add(gdataset.Tables("STOREMASTER").Rows(i).Item("STOREDESC"))
                Next i
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub autogenerate()
        Try
            Dim sqlstring, financalyear As String
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialyearEnd, 3, 4)
            docno = doctype
            sqlstring = "SELECT MAX(SUBSTRING(docno,1,5)) FROM PO_STOCKINDENTAUTH_HDR WHERE doctype='" & docno & "'"
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_Docno.Text = docno & "/00001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_Docno.Text = docno & "/" & Format(gdreader(0) + 1, "00000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_Docno.Text = docno & "/00001/" & financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cbo_Tostore_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_Tostore.SelectedIndexChanged
        '''******************************* Show Store Code ****************************************'''
        Try
            Dim i As Integer
            If Cmd_Add.Text = "Add [F7]" Then
                sqlstring = "SELECT Storecode FROM StoreMaster Where Storedesc='" & Trim(cbo_Tostore.Text) & "'"
                gconnection.getDataSet(sqlstring, "StoreMaster")
                If gdataset.Tables("StoreMaster").Rows.Count > 0 Then
                    txt_Tostorecode.Text = Trim(gdataset.Tables("StoreMaster").Rows(i).Item("Storecode"))
                    txt_Tostorecode.ReadOnly = True
                End If
                '''******************************* End Store Code *****************************************'''
                doctype = Trim(txt_Tostorecode.Text)
                Call autogenerate()
            Else
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub GridUOM(ByVal i As Integer)
        Try
            Dim Z As Integer
            sqlstring = "SELECT ISNULL(UOMDESC,'') AS UOMDESC FROM UOMMASTER WHERE ISNULL(FREEZE,'') <> 'Y'"
            gconnection.getDataSet(sqlstring, "UOMMASTER1")
            If gdataset.Tables("UOMMASTER1").Rows.Count > 0 Then
                For Z = 0 To gdataset.Tables("UOMMASTER1").Rows.Count - 1
                    ssgrid.Col = 3
                    ssgrid.Row = i
                    ssgrid.TypeComboBoxString = Trim(gdataset.Tables("UOMMASTER1").Rows(Z).Item("UOMDESC"))
                    ssgrid.Text = Trim(gdataset.Tables("UOMMASTER1").Rows(Z).Item("UOMDESC"))
                Next Z
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub checkValidation()
        Try
            Dim i, j As Integer
            Dim itemcode As String
            boolchk = False
            Call Checkdatevalidate(Format(dtp_Docdate.Value, "dd-MMM-yyyy"))

            If DateDiff(DateInterval.Day, dtp_IndentDate.Value, dtp_Docdate.Value) < 0 Then
                MessageBox.Show("Indent Date cannot be greater than Document Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                chkdatevalidate = False
                Exit Sub
            End If
            If DateDiff(DateInterval.Day, dtp_IndentDate.Value, dtp_completiondate.Value) < 0 Then
                MessageBox.Show("Indent Date cannot be greater than Authorized Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                chkdatevalidate = False
                Exit Sub
            End If
            If DateDiff(DateInterval.Day, dtp_Docdate.Value, dtp_completiondate.Value) < 0 Then
                MessageBox.Show("Document Date cannot be greater than Authorized Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                chkdatevalidate = False
                Exit Sub
            End If
            If DateDiff(DateInterval.Day, dtp_Docdate.Value, DateValue(Now)) < 0 Then
                MessageBox.Show("Document Date cannot be greater than Current Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                chkdatevalidate = False
                'Exit Function
            End If
            If DateDiff(DateInterval.Day, dtp_completiondate.Value, DateValue(Now)) < 0 Then
                MessageBox.Show("Authorized Date cannot be greater than Current Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                chkdatevalidate = False
                'Exit Function
            End If
            If chkdatevalidate = False Then Exit Sub
            '''********** Check  Main Store Can't be blank *********************'''
            If Trim(txt_Mainstore.Text) = "" Then
                MessageBox.Show(" Main Store field can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Mainstore.Focus()
                Exit Sub
            End If
            '''********** Check  To Store Can't be blank *********************'''
            If Trim(cbo_Tostore.Text) = "" Then
                MessageBox.Show(" To Store field can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cbo_Tostore.Focus()
                Exit Sub
            End If
            '''********** Check  Doc No. Can't be blank *********************'''
            If Trim(txt_Docno.Text) = "" Then
                MessageBox.Show(" Doc No. can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Docno.Focus()
                Exit Sub
            End If
            '''********** Check  Totalamount Can't be blank *********************'''
            If Val(txt_Totalamount.Text) = 0 Then
                MessageBox.Show(" Totalamount can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Totalamount.Focus()
                Exit Sub
            End If
            If Trim(cmb_approvedby.Text) = "" Then
                MessageBox.Show(" Authorized By can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txt_Docno.Focus()
                Exit Sub
            End If
            ''' ********** Check ItemCode,ItemDesc,UOM,Rate can't be blank ***********'''
            For i = 1 To ssgrid.DataRowCnt
                ssgrid.Row = i
                ssgrid.Col = 1
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("ItemCode can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(1, i)
                    Exit Sub
                End If
                ssgrid.Col = 2
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("Itemdesc can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(2, i)
                    Exit Sub
                End If
                ssgrid.Col = 3
                If Trim(ssgrid.Text) = "" Then
                    MessageBox.Show("UOM can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(3, i)
                    Exit Sub
                End If
                ssgrid.Col = 4
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Quantity can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(4, i)
                    Exit Sub
                End If
                ssgrid.Col = 5
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Rate can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(5, i)
                    Exit Sub
                End If
                ssgrid.Col = 6
                If Val(ssgrid.Text) = 0 Then
                    MessageBox.Show("Amount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    ssgrid.SetActiveCell(6, i)
                    Exit Sub
                End If
            Next i
            '''****************************************** Check if that specified quantity is avaliable or not *************************************************'''
            For i = 1 To ssgrid.DataRowCnt
                ssgrid.Row = i
                ssgrid.Col = 1
                itemcode = Trim(ssgrid.Text)
                Dim VCHKCURQTY, VCHKCLQTY As Double
                ssgrid.Col = 4
                VCHKCURQTY = ssgrid.Text
                'VCHKCLQTY = ClosingQuantity(Trim(itemcode), "MNS")
                If gInventoryVersion = "N" Then
                    gconnection.closingStock(Format(dtp_Docdate.Value, "dd/MMM/yyyy"), Trim(itemcode), Trim(txt_Mainstorecode.Text), "")
                    Dim closingqty, rate As Double
                    If (gdataset.Tables("closingstock").Rows.Count > 0) Then
                        VCHKCLQTY = gdataset.Tables("closingstock").Rows(0).Item("closingstock")
                    Else
                        VCHKCLQTY = 0
                    End If
                Else
                    VCHKCLQTY = ClosingQuantity(Trim(itemcode), Trim(txt_Mainstorecode.Text))
                End If

            Next i
            '''****************************************** Check if that specified quantity is completed *************************************************'''
            boolchk = True
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Stock_Issue_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                Call Cmd_Clear_Click(Cmd_Clear, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                txt_Docno.Text = ""
                txt_Docno.Focus()
                Exit Sub
            ElseIf e.KeyCode = Keys.F8 And Cmd_Freeze.Enabled = True Then
                Call Cmd_Freeze_Click(Cmd_Freeze, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F7 And Cmd_Add.Enabled = True Then
                Call Cmd_Add_Click(Cmd_Add, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F9 And Cmd_View.Enabled = True Then
                Call Cmd_View_Click(Cmd_View, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F10 And cmd_Print.Enabled = True Then
                Call cmd_Print_Click(cmd_Print, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If grp_Stockissue.Top = 176 Then
                    grp_Stockissue.Top = 1000
                    Cmd_View.Focus()
                    Exit Sub
                Else
                    Call Cmd_Exit_Click(Cmd_Exit, e)
                    Exit Sub
                End If
            ElseIf e.Alt = True And e.KeyCode = Keys.R Then
                Me.txt_Remarks.Focus()
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.A Then
                Me.txt_Totalamount.Focus()
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.G Then
                Me.ssgrid.Focus()
                Me.ssgrid.SetActiveCell(1, 1)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub FillMenu()
        Try
            Dim Avgrate, clsquantity As Double
            Dim K As Integer
            Dim vform As New ListOperattion1_N
            '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
            gSQLString = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(CLSTOCK,0) AS CLSTOCK,ISNULL(CLVALUE,0) AS CLVALUE,ISNULL(I.STOCKUOM,'') AS STOCKUOM, 0 AS AVGRATE, "
            gSQLString = gSQLString & " ISNULL(CONVVALUE,0) AS CONVUOM,0 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I  "
            If Trim(vsearch) = " " Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = " WHERE I.ITEMCODE LIKE '" & Trim(vsearch) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'"
            End If
            vform.Field = "I.ITEMNAME,I.ITEMCODE"
            vform.vFormatstring = "   ITEMCODE    |                      ITEMNAME              | CLSTOCK   | CLVALUE   | STOCKUOM | AVGRATE | CONVUOM | HIGHRATIO |"
            vform.vCaption = "INVENTORY ITEM CODE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.KeyPos2 = 4
            vform.Keypos3 = 5
            vform.keypos4 = 6
            vform.Keypos5 = 7
            vform.Keypos6 = 8
            vform.Keypos7 = 9
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                ' Call GridUOM(ssgrid.ActiveRow) '''---> Fill the UOM feild
                ssgrid.Col = 1
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield)

                ssgrid.Col = 2
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield1)
                ssgrid.Col = 3
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = vform.keyfield2
                ssgrid.Text = Trim(vform.keyfield2)
                ssgrid.Col = 5
                ssgrid.Row = ssgrid.ActiveRow

                If CHK_WAR.Checked = True Then
                    ' Avgrate = CALWAR(Format(CDate("01/04/" & gFinancalyearStart), "dd MMM yyyy"), Format(dtp_IndentDate.Value, "dd MMM yyyy"), Trim(vform.keyfield), Trim(txt_Mainstorecode.Text), "Q")
                    sqlstring = "SELECT CLSQTY,CLSVAL,CLSRATE FROM STOCKSUMMARY WHERE ITEMCODE='" & Trim(vform.keyfield) & "'"
                    gconnection.getDataSet(sqlstring, "RATE")
                    If gdataset.Tables("RATE").Rows.Count > 0 Then
                        If Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")) > 0 And Val(gdataset.Tables("RATE").Rows(0).Item("CLSVAL")) > 0 Then
                            ssgrid.SetText(5, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSRATE"))))
                        Else
                            ssgrid.SetText(5, ssgrid.ActiveRow, 1)
                        End If
                        ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")), "0.00"))
                    End If
                Else

                    Avgrate = CalAverageRate(Trim(vform.keyfield))
                    ssgrid.Text = Format(Val(Avgrate), "0.00")
                End If

                ssgrid.Col = 8
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield4)
                ssgrid.Col = 9
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Format(Val(vform.keyfield5), "0.00")
                ssgrid.Col = 10
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield6)
                ssgrid.Col = 11
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield7)
                'clsquantity = ClosingQuantity(Trim(vform.keyfield), "MNS")
                If gInventoryVersion = "N" Then
                    gconnection.closingStock(Format(dtp_Docdate.Value, "dd/MMM/yyyy"), Trim(vform.keyfield), Trim(txt_Mainstorecode.Text), "")
                    Dim closingqty, rate As Double
                    If (gdataset.Tables("closingstock").Rows.Count > 0) Then
                        clsquantity = gdataset.Tables("closingstock").Rows(0).Item("closingstock")
                    Else
                        clsquantity = 0
                    End If
                Else
                    clsquantity = ClosingQuantity(Trim(vform.keyfield), Trim(txt_Mainstorecode.Text))
                End If


                lbl_closingqty.Text = UCase(Trim(vform.keyfield1)) & " CLOSING QTY : " & Format(Val(clsquantity), "0.000")
                ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                ssgrid.Focus()
            Else
                ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
                Exit Sub
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillMenuItem()
        Try
            Dim Avgrate, clsquantity As Double
            Dim K As Integer
            Dim vform As New List_Operation
            Dim ssql As String
            '''******************************************************** $ FILL THE ITEMDESC,ITEMCODE INTO SSGRID ********** 
            gSQLString = " SELECT DISTINCT  ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.STOCKUOM,'') AS STOCKUOM, 0 AS AVGRATE, "
            gSQLString = gSQLString & " ISNULL(CONVVALUE,0) AS CONVUOM,0 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I  "
            'gSQLString = gSQLString & " INNER JOIN OPENINGSTOCK AS O ON O.ITEMCODE = I.ITEMCODE "
            If Trim(vsearch) = " " Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = " WHERE I.ITEMNAME like '" & Trim(vsearch) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'"
            End If
            vform.Field = "I.ITEMNAME,I.ITEMCODE"
            vform.vFormatstring = "             ITEMNAME               |  ITEMCODE    | STOCKUOM | AVGRATE | CONVUOM | HIGHRATIO |"
            vform.vCaption = "INVENTORY ITEM CODE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.KeyPos2 = 2
            vform.Keypos3 = 3
            vform.keypos4 = 4
            vform.Keypos5 = 5
            vform.Keypos6 = 6
            vform.Keypos7 = 7
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                ssgrid.Col = 1
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield1)

                ssgrid.Col = 2
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield)
                ssgrid.Col = 3
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeComboBox
                ssgrid.TypeComboBoxString = vform.keyfield2
                ssgrid.Text = Trim(vform.keyfield2)
                ssgrid.Col = 5
                ssgrid.Row = ssgrid.ActiveRow

                If CHK_WAR.Checked = True Then
                    ' Avgrate = CALWAR(Format(CDate("01/04/" & gFinancalyearStart), "dd MMM yyyy"), Format(dtp_IndentDate.Value, "dd MMM yyyy"), Trim(vform.keyfield), Trim(txt_Mainstorecode.Text), "Q")
                    sqlstring = "SELECT CLSQTY,CLSVAL,CLSRATE FROM STOCKSUMMARY WHERE ITEMCODE='" & Trim(vform.keyfield) & "'"
                    gconnection.getDataSet(sqlstring, "RATE")
                    If gdataset.Tables("RATE").Rows.Count > 0 Then
                        If Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")) > 0 And Val(gdataset.Tables("RATE").Rows(0).Item("CLSVAL")) > 0 Then
                            ssgrid.SetText(5, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSRATE"))))
                        Else
                            ssgrid.SetText(5, ssgrid.ActiveRow, 1)
                        End If
                        ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")), "0.00"))
                    End If
                Else

                    Avgrate = CalAverageRate(Trim(vform.keyfield))
                    ssgrid.Text = Format(Val(Avgrate), "0.00")
                End If
                ssgrid.Col = 8
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield4)
                ssgrid.Col = 9
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Format(Val(vform.keyfield5), "0.00")
                ssgrid.Col = 10
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield6)
                ssgrid.Col = 11
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield7)
                'clsquantity = ClosingQuantity(Trim(vform.keyfield1), "MNS")
                If gInventoryVersion = "N" Then
                    gconnection.closingStock(Format(dtp_Docdate.Value, "dd/MMM/yyyy"), Trim(vform.keyfield), Trim(txt_Mainstorecode.Text), "")
                    Dim closingqty, rate As Double
                    If (gdataset.Tables("closingstock").Rows.Count > 0) Then
                        clsquantity = gdataset.Tables("closingstock").Rows(0).Item("closingstock")
                    Else
                        clsquantity = 0
                    End If
                Else
                    clsquantity = ClosingQuantity(Trim(vform.keyfield), Trim(txt_Mainstorecode.Text))
                End If

                'clsquantity = ClosingQuantity(Trim(vform.keyfield1), Trim(txt_Mainstorecode.Text))
                lbl_closingqty.Text = UCase(Trim(vform.keyfield)) & "CLOSING QTY : " & Format(Val(clsquantity), "0.000")
                ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                ssgrid.Focus()
            Else
                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                Exit Sub
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_Totalamount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            txt_Totalamount.Text = Format(Val(txt_Totalamount.Text), "0.00")
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillMainstore()
        Try
            Dim i As Integer
            sqlstring = "SELECT ISNULL(STOREDESC,'') AS STOREDESC,ISNULL(STORECODE,'') AS STORECODE FROM STOREMASTER WHERE ISNULL(STORESTATUS,'') ='M' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STOREDESC ASC"
            gconnection.getDataSet(sqlstring, "StoreMaster1")
            If gdataset.Tables("StoreMaster1").Rows.Count > 0 Then
                txt_Mainstore.Text = Trim(gdataset.Tables("StoreMaster1").Rows(i).Item("STOREDESC"))
                txt_Mainstorecode.Text = Trim(gdataset.Tables("StoreMaster1").Rows(i).Item("STORECODE"))
                txt_Mainstore.ReadOnly = True
                txt_Mainstorecode.ReadOnly = True
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cbo_Tostore_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_Tostore.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                dtp_Docdate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub dtp_Docdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Docdate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                ssgrid.Focus()
                ssgrid.SetActiveCell(1, 1)
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Totalqty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            getNumeric(e)
            If Asc(e.KeyChar) = 13 Then
                txt_Remarks.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Remarks_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            getAlphanumeric(e)
            If Asc(e.KeyChar) = 13 Then
                Cmd_Add.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Calculate()
        Try
            Dim ValQty, ValRate, ValDiscount, VarTotal, clsquantiy, Varqty As Double
            Dim ValHighratio, ValItemamount, ValDblamount, Calqty As Double
            Dim Itemcode As String
            Dim i, j As Integer
            If ssgrid.ActiveCol = 1 Or ssgrid.ActiveCol = 2 Or ssgrid.ActiveCol = 3 Or ssgrid.ActiveCol = 4 Or ssgrid.ActiveCol = 5 Or ssgrid.ActiveCol = 6 Then
                lbl_closingqty.Text = ""
                i = ssgrid.ActiveRow
                ssgrid.Col = 4
                ssgrid.Row = i
                ValQty = Val(ssgrid.Text)
                ssgrid.Col = 5
                ssgrid.Row = i
                ValRate = Val(ssgrid.Text)
                ssgrid.Col = 9
                ssgrid.Row = i
                ValHighratio = Val(ssgrid.Text())
                ValItemamount = Format(Val(ValQty) * Val(ValRate), "0.00")
                ValDblamount = Format(Val(ValQty) * Val(ValHighratio), "0.000")
                If Val(ValItemamount) = 0 Then
                    ssgrid.SetText(6, i, "")
                    ssgrid.SetText(7, i, "")
                Else
                    ssgrid.SetText(6, i, Val(ValItemamount))
                    ssgrid.SetText(7, i, Val(ValDblamount))
                End If
                ssgrid.Col = 1
                ssgrid.Row = ssgrid.ActiveRow
                Itemcode = Trim(ssgrid.Text)
                For j = 1 To ssgrid.DataRowCnt
                    ssgrid.Col = 1
                    ssgrid.Row = j
                    If Trim(Itemcode) = Trim(ssgrid.Text) Then
                        ssgrid.Col = 4
                        ssgrid.Row = j
                        Calqty = Calqty + Val(ssgrid.Text)
                    End If
                Next

                If gInventoryVersion = "O" Then
                    clsquantiy = ClosingQuantity(Trim(Itemcode), Trim(txt_Mainstorecode.Text))
                Else

                    gconnection.closingStock(Format(dtp_Docdate.Value, "dd/MMM/yyyy"), Trim(Itemcode), Trim(txt_Mainstorecode.Text), "")

                    Dim closingqty, rate As Double
                    If (gdataset.Tables("closingstock").Rows.Count > 0) Then
                        clsquantiy = gdataset.Tables("closingstock").Rows(0).Item("closingstock")
                        rate = gdataset.Tables("closingstock").Rows(0).Item("rate")
                    Else
                        closingqty = 0
                        rate = 0
                    End If
                End If


                ssgrid.Col = 2
                ssgrid.Row = i
                lbl_closingqty.Text = UCase(Trim(ssgrid.Text)) & " CLOSING QTY : " & Format(Val(clsquantiy - Calqty), "0.000")
                Me.txt_Totalamount.Text = 0
                VarTotal = 0
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Col = 6
                    ssgrid.Row = i
                    VarTotal = Val(ssgrid.Text)
                    Me.txt_Totalamount.Text = Format(Val(Me.txt_Totalamount.Text) + Val(VarTotal), "0.00")
                Next i
                i = i - 1

                Me.Txt_qty.Text = 0
                Varqty = 0
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Col = 4
                    ssgrid.Row = i
                    Varqty = Val(ssgrid.Text)
                    Me.Txt_qty.Text = Format(Val(Me.Txt_qty.Text) + Val(Varqty), "0.00")
                Next i
                i = i - 1
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Docno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Docno.Validated
        Dim j, i As Integer
        Dim dt As New DataTable
        Dim vString, sqlstring As String
        Dim vTypeseqno, Clsquantity, vGroupseqno As Double
        If Trim(txt_Docno.Text) <> "" Then
            Try
                sqlstring = "SELECT ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE AS DOCDATE,H.INDENTNO INDENTNO, H.INDENTDATE AS INDENTDATE, "
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONNAME,'') AS STORELOCATIONNAME,ISNULL(H.OPSTORELOCATIONCODE,'') AS OPSTORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.OPSTORELOCATIONNAME,'') AS OPSTORELOCATIONNAME,ISNULL(H.TOTALAMT,0) AS TOTALAMT,ISNULL(H.REMARKS,'') AS REMARKS,"
                sqlstring = sqlstring & " ISNULL(H.VOID,'') AS VOID,ISNULL(H.VOIDREASON,'') AS VOIDREASON,ISNULL(H.ADDUSER,'') AS ADDUSER,ADDDATE,ISNULL(H.UPDATEUSER,'') AS UPDATEUSER,UPDATETIME,ISNULL(H.UPDFOOTER,'') AS UPDFOOTER,ISNULL(H.UPDSIGN,'') AS UPDSIGN,ISNULL(AUTHRZEBY,'') AS AUTHRZEBY,ISNULL(AUTHRZEDATE,'') AS AUTHRZEDATE"
                sqlstring = sqlstring & " FROM PO_STOCKINDENTAUTH_HDR AS H WHERE DOCNO='" & Trim(txt_Docno.Text) & "'OR DOCDETAILS='" & Trim(txt_Docno.Text) & "' "
                gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")
                '''************************************************* SELECT RECORD FROM STOCKISSUEHEADER *********************************************''''                
                If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
                    Cmd_Add.Text = "Update[F7]"
                    Me.txt_Docno.ReadOnly = True
                    VSTRDOCNO = Trim(txt_Docno.Text)
                    txt_Docno.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDETAILS") & "")
                    Txt_IndentNo.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("INDENTNO") & "")
                    dtp_IndentDate.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("INDENTDATE")), "dd-MM-yyyy")
                    dtp_Docdate.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDATE")), "dd-MM-yyyy")
                    txt_Mainstorecode.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONCODE"))
                    txt_Mainstore.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONNAME"))
                    txt_Tostorecode.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONCODE"))
                    cbo_Tostore.DropDownStyle = ComboBoxStyle.DropDown
                    VSTORECODE = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONCODE"))
                    VSTORENAME = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONNAME"))
                    cbo_Tostore.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONNAME"))
                    cbo_Tostore.DropDownStyle = ComboBoxStyle.DropDownList
                    cmb_approvedby.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("AUTHRZEBY"))
                    cmb_approvedby.DropDownStyle = ComboBoxStyle.DropDownList
                    dtp_completiondate.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("AUTHRZEDATE")), "dd-MM-yyyy")
                    txt_Totalamount.Text = Format(Val(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("TOTALAMT")), "0.00")
                    txt_Remarks.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("REMARKS"))
                    Txt_footer.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("UPDFOOTER"))
                    Txt_signature.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("UPDSIGN"))
                    If gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("VOID") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("ADDDATE")), "dd-MMM-yyyy")
                        Me.Cmd_Freeze.Enabled = False
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.Cmd_Freeze.Enabled = True
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.Cmd_Freeze.Text = "Void[F8]"
                    End If
                    If Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("VOID")) = "Y" Then
                        Cmd_Add.Enabled = False
                        Cmd_Freeze.Enabled = False
                    End If
                    Sqlstr = "SELECT AUTH1 as memimage FROM PO_STOCKINDENTAUTH_HDR WHERE DOCDETAILS='" & Trim(txt_Docno.Text) & "' "
                    LoadFoto_DB(Sqlstr, Pic_auth1)
                    Sqlstr = "SELECT AUTH2 as memimage FROM PO_STOCKINDENTAUTH_HDR WHERE DOCDETAILS='" & Trim(txt_Docno.Text) & "' "
                    LoadFoto_DB(Sqlstr, Pic_auth2)
                    '''************************************************* SELECT RECORD FROM STOCKISSUEDETAILS *********************************************''''                
                    Dim strsql As String
                    Dim STRITEMCODE, STRITEMUOM As String
                    sqlstring = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM,ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE ,"
                    sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT,ISNULL(DBLAMT,0) AS DBLAMT,ISNULL(DBLCONV,'') AS DBLCONV,ISNULL(HIGHRATIO,0) AS HIGHRATIO,"
                    sqlstring = sqlstring & " ISNULL(GROUPCODE,'') AS GROUPCODE,ISNULL(SUBGROUPCODE,'') AS SUBGROUPCODE FROM PO_STOCKINDENTAUTH_DET WHERE  DOCDETAILS ='" & Trim(txt_Docno.Text) & "' ORDER BY AUTOID"
                    gconnection.getDataSet(sqlstring, "STOCKISSUEDETAILSALL")
                    If gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count
                            ' Call GridUOM(i) '''---> FILL GRID UOM
                            ssgrid.SetText(1, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("ITEMCODE")))
                            STRITEMCODE = Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("ITEMCODE"))
                            ssgrid.SetText(2, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("ITEMNAME")))
                            ssgrid.Col = 3
                            ssgrid.Row = i
                            ssgrid.TypeComboBoxString = Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("UOM"))
                            STRITEMUOM = Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("UOM"))
                            ssgrid.Text = Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("UOM"))
                            ssgrid.SetText(4, i, Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("QTY")))
                            ssgrid.SetText(12, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("QTY")), "0.000"))
                            ssgrid.SetText(5, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("RATE")), "0.00"))
                            ssgrid.SetText(6, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("AMOUNT")), "0.00"))
                            ssgrid.SetText(7, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("DBLAMT")), "0.000"))
                            ssgrid.SetText(8, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("DBLCONV")))
                            ssgrid.SetText(9, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("HIGHRATIO")), "0.00"))
                            ssgrid.SetText(10, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("GROUPCODE")))
                            ssgrid.SetText(11, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("SUBGROUPCODE")))
                            'Clsquantity = ClosingQuantity(STRITEMCODE, "MNS")
                            Dim ISSDATE As Date
                            ISSDATE = Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy")
                            'Clsquantity = ClosingQuantity_Date(STRITEMCODE, Trim(txt_Mainstorecode.Text), STRITEMUOM, ISSDATE)
                            ssgrid.SetText(13, i, Clsquantity)
                            j = j + 1
                        Next
                    End If
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                    If Not String.IsNullOrEmpty(gAuditFlg) Then
                        If gAuditFlg.ToUpper = "Y" Then
                            Me.Cmd_Add.Enabled = False
                            Me.Cmd_Freeze.Enabled = False
                        End If
                    End If
                    TotalCount = gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count
                    ssgrid.SetActiveCell(1, 1)
                End If
            Catch ex As Exception
                MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub Cmd_Docnohelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Docnohelp.Click
        Try
            gSQLString = "SELECT docdetails,docdate FROM PO_STOCKINDENTAUTH_HDR"
            M_WhereCondition = " "
            Dim vform As New ListOperattion1_N
            vform.Field = "DOCDETAILS,DOCDATE"
            vform.vFormatstring = "       DOC NO                       |         DOC DATE                                                           "
            vform.vCaption = "STOCK ISSUE NO HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_Docno.Text = Trim(vform.keyfield & "")
                ssgrid.ClearRange(1, 1, -1, -1, True)
                Call txt_Docno_Validated(txt_Docno, e)
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_Docno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Docno.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If Cmd_Docnohelp.Enabled = True Then
                    search = Trim(txt_Docno.Text)
                    Call Cmd_Docnohelp_Click(Cmd_Docnohelp, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Docno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Docno.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_Docno.Text) = "" Then
                    Call Cmd_Docnohelp_Click(Cmd_Docnohelp, e)
                Else
                    txt_Docno_Validated(txt_Docno, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub


    Private Sub Cmd_IssueClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_IssueClear.Click
        Try
            txt_FromDocno.Text = ""
            txt_ToDocno.Text = ""
            txt_FromDocno.Focus()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_IssueView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_IssueView.Click
        Try
            gPrint = False
            Dim i As Integer
            Dim objStockIssueClass As New rptStockissuereport
            If Trim(txt_FromDocno.Text) = "" Then
                MessageBox.Show("From doc no. can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            If Trim(txt_ToDocno.Text) = "" Then
                MessageBox.Show("To doc no. can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            Dim sqlstring = "SELECT TOP 100 PERCENT dbo.PO_STOCKINDENTAUTH_HDR.docdetails, dbo.PO_STOCKINDENTAUTH_HDR.docdate, dbo.PO_STOCKINDENTAUTH_HDR.storelocationname, "
            sqlstring = sqlstring & " dbo.PO_STOCKINDENTAUTH_HDR.opstorelocationname, dbo.stockissuedetail.itemcode,dbo.PO_STOCKINDENTAUTH_HDR.storelocationcode,dbo.PO_STOCKINDENTAUTH_HDR.opstorelocationcode, "
            sqlstring = sqlstring & " dbo.stockissuedetail.itemname, dbo.stockissuedetail.uom,dbo.stockissuedetail.qty, dbo.stockissuedetail.rate, dbo.stockissuedetail.amount"
            sqlstring = sqlstring & " FROM dbo.stockissuedetail INNER JOIN dbo.PO_STOCKINDENTAUTH_HDR ON dbo.stockissuedetail.docdetails = dbo.PO_STOCKINDENTAUTH_HDR.docdetails"
            sqlstring = sqlstring & " WHERE dbo.PO_STOCKINDENTAUTH_HDR.docdetails BETWEEN '" & Trim(txt_FromDocno.Text) & "' AND '" & Trim(txt_ToDocno.Text) & "' "
            sqlstring = sqlstring & " ORDER BY dbo.PO_STOCKINDENTAUTH_HDR.docdetails"
            Dim arraystring() As String = {"ITEM CODE", "ITEM NAME", "UOM", "QUANTITY", "RATE", "AMOUNT"}
            Dim heading() As String = {"STOCK ISSUE TO BAR"}
            Dim colsize() As Integer = {15, 40, 16, 10, 10, 12}
            objStockIssueClass.Reportdetails(sqlstring, heading, arraystring, colsize)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Issueexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Issueexit.Click
        Try
            txt_FromDocno.Text = ""
            txt_ToDocno.Text = ""
            grp_Stockissue.Top = 1000
            'Call Cmd_Clear_Click(Cmd_Clear, e)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_FromDocno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FromDocno.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_FromDocno.Text) = "" Then
                    Call Cmd_FromDocno_Click(Cmd_FromDocno, e)
                Else
                    txt_FromDocno_Validated(txt_FromDocno, e)
                    txt_ToDocno.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_ToDocno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ToDocno.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_ToDocno.Text) = "" Then
                    Call Cmd_ToDocno_Click(Cmd_ToDocno, e)
                Else
                    txt_ToDocno_Validated(txt_ToDocno, e)
                    Cmd_IssueView.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_FromDocno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_FromDocno.Click
        Try
            gSQLString = "SELECT docdetails,docdate FROM PO_STOCKINDENTAUTH_HDR"
            M_WhereCondition = " "
            Dim vform As New List_Operation
            vform.Field = "DOCDETAILS,DOCDATE"
            vform.vFormatstring = "       DOC NO.            |         DOC DATE                             "
            vform.vCaption = "STOCK AUTHORIZE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_FromDocno.Text = Trim(vform.keyfield & "")
                txt_ToDocno.Focus()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_ToDocno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ToDocno.Click
        Try
            gSQLString = "SELECT docdetails,docdate FROM PO_STOCKINDENTAUTH_HDR"
            M_WhereCondition = " "
            Dim vform As New List_Operation
            vform.Field = "DOCDETAILS,DOCDATE"
            vform.vFormatstring = "       DOC NO.            |         DOC DATE                             "
            vform.vCaption = "STOCK AUTHORIZE HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_ToDocno.Text = Trim(vform.keyfield & "")
                Cmd_IssueView.Focus()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Issueprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Issueprint.Click
        Try
            gPrint = True
            Dim i As Integer
            Dim objStockIssueClass As New rptStockissuereport
            If Trim(txt_FromDocno.Text) = "" Then
                MessageBox.Show("From doc no. can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            If Trim(txt_ToDocno.Text) = "" Then
                MessageBox.Show("To doc no. can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            Dim sqlstring = "SELECT TOP 100 PERCENT dbo.PO_STOCKINDENTAUTH_HDR.docdetails, dbo.PO_STOCKINDENTAUTH_HDR.docdate, dbo.PO_STOCKINDENTAUTH_HDR.storelocationname, "
            sqlstring = sqlstring & " dbo.PO_STOCKINDENTAUTH_HDR.opstorelocationname, dbo.PO_STOCKINDENTAUTH_DET.itemcode,dbo.PO_STOCKINDENTAUTH_HDR.storelocationcode,dbo.PO_STOCKINDENTAUTH_HDR.opstorelocationcode, "
            sqlstring = sqlstring & " dbo.PO_STOCKINDENTAUTH_DET.itemname, dbo.PO_STOCKINDENTAUTH_DET.uom,dbo.PO_STOCKINDENTAUTH_DET.qty, dbo.PO_STOCKINDENTAUTH_DET.rate, dbo.PO_STOCKINDENTAUTH_DET.amount"
            sqlstring = sqlstring & " FROM dbo.stockissuedetail INNER JOIN dbo.PO_STOCKINDENTAUTH_HDR ON dbo.PO_STOCKINDENTAUTH_DET.docdetails = dbo.PO_STOCKINDENTAUTH_HDR.docdetails"
            sqlstring = sqlstring & " WHERE dbo.PO_STOCKINDENTAUTH_HDR.docdetails BETWEEN '" & Trim(txt_FromDocno.Text) & "' AND '" & Trim(txt_ToDocno.Text) & "' "
            sqlstring = sqlstring & " ORDER BY dbo.PO_STOCKINDENTAUTH_HDR.docdetails"
            Dim arraystring() As String = {"ITEM CODE", "ITEM NAME", "UOM", "QUANTITY", "RATE", "AMOUNT"}
            Dim heading() As String = {"AUTHORIZED"}
            Dim colsize() As Integer = {15, 40, 16, 10, 10, 12}
            objStockIssueClass.Reportdetails(sqlstring, heading, arraystring, colsize)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub ssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
        Dim Issuerate, Highratio, Dblamount, clsquantity As Double
        Dim ItemQty, ItemAmount, ItemRate, IssueQty, CurrentQty As Double
        Dim sqlstring, Itemcode, Itemdesc As String
        Dim focusbool As Boolean
        Dim i, j, K As Integer
        search = Nothing
        Try
            If e.keyCode = Keys.Enter Then
                '    i = ssgrid.ActiveRow
                '    If ssgrid.ActiveCol = 1 Then
                '        ssgrid.Col = 1
                '        ssgrid.Row = i
                '        ssgrid.Lock = False
                '        If ssgrid.Lock = False Then
                '            If Trim(ssgrid.Text) = "" Then
                '                '   Call FillMenu() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
                '            Else
                '                Itemcode = Trim(ssgrid.Text)
                '                ssgrid.ClearRange(1, ssgrid.ActiveRow, 10, ssgrid.ActiveRow, True)
                '                '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                '                sqlstring = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, "
                '                sqlstring = sqlstring & " ISNULL(CONVVALUE,'') AS CONVUOM,0 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, "
                '                sqlstring = sqlstring & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I"
                '                sqlstring = sqlstring & " WHERE I.ITEMCODE ='" & Trim(Itemcode) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'"
                '                gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER1")
                '                If gdataset.Tables("INVENTORYITEMMASTER1").Rows.Count > 0 Then

                '                    ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))
                '                    ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMNAME")))
                '                    ssgrid.Col = 3
                '                    ssgrid.Row = i
                '                    ssgrid.Text = Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("STOCKUOM"))
                '                    If CHK_WAR.Checked = True Then
                '                        Issuerate = CALWAR(Format(CDate("01/04/" & gFinancalyearStart), "dd MMM yyyy"), Format(dtp_IndentDate.Value, "dd MMM yyyy"), Trim(Itemcode), Trim(txt_Mainstorecode.Text), "Q")
                '                        sqlstring = "SELECT CLSQTY,CLSVAL,CLSRATE FROM STOCKSUMMARY WHERE ITEMCODE='" & Trim(Itemcode) & "'"
                '                        gconnection.getDataSet(sqlstring, "RATE")
                '                        If gdataset.Tables("RATE").Rows.Count > 0 Then
                '                            If Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")) > 0 And Val(gdataset.Tables("RATE").Rows(0).Item("CLSVAL")) > 0 Then
                '                                ssgrid.SetText(5, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSRATE"))))
                '                            Else
                '                                ssgrid.SetText(5, ssgrid.ActiveRow, 1)
                '                            End If
                '                            ssgrid.SetText(7, ssgrid.ActiveRow, Format(Val(gdataset.Tables("RATE").Rows(0).Item("CLSQTY")), "0.00"))
                '                        End If
                '                    Else
                '                        Issuerate = CalAverageRate_new(Trim(Itemcode), Format(dtp_IndentDate.Value, "dd/MMM/yyyy"), txt_Mainstorecode.Text, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("STOCKUOM")))
                '                        ssgrid.SetText(5, ssgrid.ActiveRow, Format(Val(Issuerate), "0.00"))
                '                    End If

                '                    ssgrid.SetText(8, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("CONVUOM")))
                '                    ssgrid.SetText(9, i, Val(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("HIGHRATIO")))
                '                    ssgrid.SetText(10, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("GROUPCODE")))
                '                    ssgrid.SetText(11, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("SUBGROUPCODE")))
                '                    'lbl_closingqty.Text = UCase(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMNAME"))) & " CLOSING QTY : " & Format(Val(clsquantity), "0.000")
                '                    Dim TransUOm As String
                '                    ssgrid.Col = 3
                '                    ssgrid.Row = ssgrid.ActiveRow
                '                    TransUOm = ssgrid.Text
                '                    ssgrid.Col = 13
                '                    ssgrid.Row = ssgrid.ActiveRow
                '                    ssgrid.Text = ClosingQuantity_NewTrans(Itemcode, Trim(txt_Mainstorecode.Text), TransUOm)
                '                    ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                '                    ssgrid.Focus()
                '                Else
                '                    MessageBox.Show("Specified ITEM CODE not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '                    ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
                '                    ssgrid.Text = ""
                '                    ssgrid.Focus()
                '                    Exit Sub
                '                End If
                '            End If
                '        Else
                '            ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                '        End If
                '    ElseIf ssgrid.ActiveCol = 2 Then
                '        ssgrid.Col = 2
                '        i = ssgrid.ActiveRow
                '        ssgrid.Row = i
                '        If ssgrid.Lock = False Then
                '            If Trim(ssgrid.Text) = "" Then
                '                '  Call FillMenuItem() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
                '            Else
                '                Itemdesc = Trim(ssgrid.Text)
                '                ssgrid.ClearRange(1, ssgrid.ActiveRow, 10, ssgrid.ActiveRow, True)
                '                '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                '                sqlstring = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, "
                '                sqlstring = sqlstring & " ISNULL(CONVVALUE,'') AS CONVUOM,0 AS HIGHRATIO, ISNULL(I.GROUPCODE,'') AS GROUPCODE, "
                '                sqlstring = sqlstring & " ISNULL(I.SUBGROUPCODE,'') AS SUBGROUPCODE FROM INVENTORYITEMMASTER AS I "
                '                sqlstring = sqlstring & " WHERE I.ITEMNAME ='" & Trim(Itemdesc) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'"
                '                gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER1")
                '                If gdataset.Tables("INVENTORYITEMMASTER1").Rows.Count > 0 Then
                '                    ' Call GridUOM(i) '''---> Fill the UOM feild
                '                    ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))
                '                    ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMNAME")))
                '                    ssgrid.Col = 3
                '                    ssgrid.Row = i
                '                    ssgrid.TypeComboBoxString = Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("STOCKUOM"))
                '                    ssgrid.Text = Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("STOCKUOM"))
                '                    Issuerate = CalAverageRate(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE")))
                '                    ssgrid.SetText(5, i, Format(Val(Issuerate), "0.00"))
                '                    ssgrid.SetText(8, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("CONVUOM")))
                '                    ssgrid.SetText(9, i, Val(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("HIGHRATIO")))
                '                    ssgrid.SetText(10, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("GROUPCODE")))
                '                    ssgrid.SetText(11, i, Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("SUBGROUPCODE")))
                '                    'clsquantity = ClosingQuantity(Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE"))), "MNS")
                '                    clsquantity = ClosingQuantity(Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMCODE"))), Trim(txt_Mainstorecode.Text))
                '                    lbl_closingqty.Text = UCase(Trim(gdataset.Tables("INVENTORYITEMMASTER1").Rows(j).Item("ITEMNAME"))) & " CLOSING QTY : " & Format(Val(clsquantity), "0.000")
                '                    ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                '                Else
                '                    MessageBox.Show("Specified ITEM DESCRIPTION not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                '                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                '                    ssgrid.Text = ""
                '                    ssgrid.Focus()
                '                    Exit Sub
                '                End If
                '            End If
                '        End If
                '    ElseIf ssgrid.ActiveCol = 3 Then
                '        ssgrid.Col = 3
                '        i = ssgrid.ActiveRow
                '        ssgrid.Row = i
                '        If ssgrid.Lock = False Then
                '            If Trim(ssgrid.Text) = "" Then
                '                ssgrid.SetActiveCell(2, ssgrid.ActiveRow)
                '            End If
                '        End If
                '    ElseIf ssgrid.ActiveCol = 4 Then
                '        CurrentQty = 0 : IssueQty = 0
                '        ssgrid.Col = 4
                '        i = ssgrid.ActiveRow
                '        ssgrid.Row = i
                '        ssgrid.Lock = False

                '        If ssgrid.Lock = False Then
                '            If Val(ssgrid.Text) = 0 Then
                '                ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                '            Else
                '                Call Calculate() '''--> Calculate total amount
                '                ssgrid.Row = ssgrid.ActiveRow + 1
                '                ssgrid.Col = 1
                '                ssgrid.Lock = False
                '                ssgrid.Col = 2
                '                ssgrid.Lock = False
                '                ssgrid.Col = 3
                '                ssgrid.Lock = False
                '                ssgrid.Col = 4
                '                ssgrid.Lock = False
                '                ssgrid.Col = 5
                '                ssgrid.Lock = False
                '                ssgrid.Col = 6
                '                ssgrid.Lock = False

                '                ssgrid.Col = 4
                '                i = ssgrid.ActiveRow
                '                ssgrid.Row = i
                '                IssueQty = Val(ssgrid.Text)

                '                ssgrid.Col = 12
                '                i = ssgrid.ActiveRow
                '                ssgrid.Row = i
                '                CurrentQty = Val(ssgrid.Text)
                '                If IssueQty > CurrentQty Then
                '                    MsgBox("Issue Qty cannot Be Greater Than Indent Qty")
                '                    ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                '                    Exit Sub
                '                Else
                '                    ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                '                End If
                '            End If
                '        Else
                '            ssgrid.Col = 4
                '            i = ssgrid.ActiveRow
                '            ssgrid.Row = i
                '            IssueQty = Val(ssgrid.Text)

                '            ssgrid.Col = 12
                '            i = ssgrid.ActiveRow
                '            ssgrid.Row = i
                '            CurrentQty = Val(ssgrid.Text)

                '            If IssueQty > CurrentQty Then
                '                MsgBox("Issue Qty cannot Be Greater Than Indent Qty")
                '                ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                '                Exit Sub
                '            Else
                '                ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)

                '            End If
                '        End If

                '    ElseIf ssgrid.ActiveCol = 5 Then
                '        ssgrid.Col = 5
                '        i = ssgrid.ActiveRow
                '        ssgrid.Row = i
                '        If ssgrid.Lock = False Then
                '            If Val(ssgrid.Text) = 0 Then
                '                ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                '            Else
                '                Call Calculate() '''--> Calculate total amount
                '                ssgrid.Row = ssgrid.ActiveRow + 1
                '                ssgrid.Col = 1
                '                ssgrid.Lock = False
                '                ssgrid.Col = 2
                '                ssgrid.Lock = False
                '                ssgrid.Col = 3
                '                ssgrid.Lock = False
                '                ssgrid.Col = 4
                '                ssgrid.Lock = False
                '                ssgrid.Col = 5
                '                ssgrid.Lock = False
                '                ssgrid.Col = 6
                '                ssgrid.Lock = False
                '                ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                '            End If
                '        End If
                '    ElseIf ssgrid.ActiveCol = 6 Then
                '        ssgrid.Col = 6
                '        i = ssgrid.ActiveRow
                '        ssgrid.Row = i
                '        If ssgrid.Lock = False Then
                '            If Val(ssgrid.Text) = 0 Then
                '                ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
                '            Else
                '                ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                '            End If
                '        Else
                '            ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
                '        End If
                '    ElseIf ssgrid.ActiveCol = 7 Then
                '        ssgrid.Col = 7
                '        i = ssgrid.ActiveRow
                '        ssgrid.Row = i
                '        If ssgrid.Lock = False Then
                '            If Trim(ssgrid.Text) = "" Then
                '                ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
                '            Else
                '                ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                '            End If
                '        End If
                '    ElseIf ssgrid.ActiveCol = 8 Then
                '        ssgrid.Col = 8
                '        i = ssgrid.ActiveRow
                '        ssgrid.Row = i
                '        If ssgrid.Lock = False Then
                '            If Trim(ssgrid.Text) = "" Then
                '                ssgrid.SetActiveCell(7, ssgrid.ActiveRow)
                '            Else
                '                ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                '            End If
                '        End If
                '    ElseIf ssgrid.ActiveCol = 9 Then
                '        ssgrid.Col = 9
                '        i = ssgrid.ActiveRow
                '        ssgrid.Row = i
                '        If ssgrid.Lock = False Then
                '            If Trim(ssgrid.Text) = "" Then
                '                ssgrid.SetActiveCell(8, ssgrid.ActiveRow)
                '            Else
                '                ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
                '            End If
                '        End If
                '    End If
                'ElseIf e.keyCode = Keys.F4 Then
                '    If ssgrid.ActiveCol = 1 Then
                '        ssgrid.Col = 1
                '        ssgrid.Row = i
                '        If ssgrid.Lock = False Then
                '            ssgrid.Col = 1
                '            ssgrid.Row = ssgrid.ActiveRow
                '            search = Trim(ssgrid.Text)
                '            Call FillMenu()
                '        End If
                '    ElseIf ssgrid.ActiveCol = 2 Then
                '        ssgrid.Col = 2
                '        ssgrid.Row = i
                '        If ssgrid.Lock = False Then
                '            ssgrid.Col = 2
                '            ssgrid.Row = ssgrid.ActiveRow
                '            search = Trim(ssgrid.Text)
                '            Call FillMenuItem()
                '        End If
                '''    End If
            ElseIf e.keyCode = Keys.F3 Then
                '''ssgrid.Col = ssgrid.ActiveCol
                '''i = ssgrid.ActiveRow
                '''ssgrid.Row = i
                '''ssgrid.Lock = False
                '''If ssgrid.Lock = False Then
                '''    With ssgrid
                '''        .Row = .ActiveRow
                '''        .ClearRange(1, .ActiveRow, 11, .ActiveRow, True)
                '''        .DeleteRows(.ActiveRow, 1)
                '''        Call Calculate()
                '''        .SetActiveCell(1, ssgrid.ActiveRow)
                '''        .Focus()
                '''    End With
                '''End If
                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
                ssgrid.Focus()

            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Function WHITE(ByVal ColNum As Integer, ByVal Rownum As Integer)
        ssgrid.Col = ssgrid.ActiveCol
        ssgrid.Row = ssgrid.ActiveRow
        ssgrid.BackColor = Color.White
    End Function
    Private Function gold(ByVal ColNum As Integer, ByVal Rownum As Integer)
        ssgrid.Col = ssgrid.ActiveCol
        ssgrid.Row = ssgrid.ActiveRow
        ssgrid.BackColor = Color.Gold
    End Function
    Private Sub GridLocking()
        Try
            Dim Row, Col As Integer
            ssgrid.Col = 6
            ssgrid.Row = ssgrid.ActiveRow
            For Row = 1 To 50
                For Col = 1 To 6
                    ssgrid.Row = Row
                    ssgrid.Col = Col
                    ssgrid.Lock = True
                Next
            Next
            ssgrid.Row = 1
            For Col = 1 To 6
                ssgrid.Col = Col
                ssgrid.Lock = False
            Next
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Function GridUnlocking(ByVal ActiveCol, ByVal ActiveRow)
        Try
            Dim i As Integer = 1
            ssgrid.Row = ActiveRow
            ssgrid.Col = ActiveCol
            For i = ActiveCol To ssgrid.MaxCols
                ssgrid.Row = ActiveRow
                ssgrid.Col = i
                ssgrid.Lock = False
            Next i
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function

    Private Sub GridUnLock()
        Try
            Dim i, j As Integer
            For i = 1 To 100
                For j = 1 To 6
                    ssgrid.Col = j
                    ssgrid.Row = i
                    ssgrid.Lock = False
                Next j
            Next i
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Stock_Issue_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Try
            StockIssueTransbool = False
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_FromDocno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_FromDocno.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If Cmd_FromDocno.Enabled = True Then
                    search = Trim(txt_FromDocno.Text)
                    Call Cmd_FromDocno_Click(Cmd_FromDocno, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_FromDocno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FromDocno.Validated
        If Trim(txt_FromDocno.Text) <> "" Then
            Try
                sqlstring = "SELECT  ISNULL(DOCDETAILS,'') AS DOCDETAILS"
                sqlstring = sqlstring & " FROM PO_STOCKINDENTAUTH_HDR WHERE DOCDETAILS='" & Trim(txt_FromDocno.Text) & "'"
                gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")
                '''************************************************* SELECT record from Grn_header *********************************************''''                
                If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
                    Me.txt_FromDocno.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDETAILS"))
                    Me.txt_FromDocno.ReadOnly = True
                End If
            Catch
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txt_ToDocno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ToDocno.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If Cmd_ToDocno.Enabled = True Then
                    search = Trim(txt_ToDocno.Text)
                    Call Cmd_ToDocno_Click(Cmd_ToDocno, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_ToDocno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ToDocno.Validated
        If Trim(txt_ToDocno.Text) <> "" Then
            Try
                sqlstring = "SELECT  ISNULL(DOCDETAILS,'') AS DOCDETAILS"
                sqlstring = sqlstring & " FROM PO_STOCKINDENTAUTH_HDR WHERE DOCDETAILS='" & Trim(txt_ToDocno.Text) & "'"
                gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")
                '''************************************************* SELECT record from Grn_header *********************************************''''                
                If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
                    Me.txt_ToDocno.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDETAILS"))
                    Me.txt_ToDocno.ReadOnly = True
                End If
            Catch ex As Exception
                MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='PURCHASE ORDER' AND MODULENAME LIKE 'Indent Authorization%' ORDER BY RIGHTS"
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
        Me.cmd_Print.Enabled = False
        Me.cmd_export.Enabled = False
        Me.btn_auth.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Me.btn_auth.Enabled = True
                    Me.cmd_export.Enabled = True
                    Me.cmd_Print.Enabled = True
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
                    'Me.cmd_rpt.Enabled = True
                    Me.cmd_export.Enabled = True
                End If
                If Right(x) = "U" Then
                    Me.btn_auth.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.cmd_Print.Enabled = True
                End If
            Next
        End If


    End Sub

    Private Sub ssgrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid.LeaveCell
        Dim Issuerate, Highratio, Dblamount, clsquantity As Double
        Dim ItemQty, ItemAmount, ItemRate, IssueQty, CurrentQty As Double
        Dim sqlstring, Itemcode, Itemdesc As String
        Dim focusbool As Boolean
        Dim i, j, K As Integer
        search = Nothing
        If ssgrid.ActiveCol = 1 Or ssgrid.ActiveCol = 2 Then
            Call Calculate()
        End If
        Try
            i = ssgrid.ActiveRow
            If ssgrid.ActiveCol = 4 Then
                ssgrid.Col = 4
                i = ssgrid.ActiveRow
                ssgrid.Row = i
                'ssgrid.Lock = False
                If ssgrid.Lock = False Then
                    If Val(ssgrid.Text) = 0 Then
                        ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                    Else
                        Call Calculate() '''--> Calculate total amount
                        ssgrid.Row = ssgrid.ActiveRow + 1
                        ssgrid.Col = 1
                        ssgrid.Lock = False
                        ssgrid.Col = 2
                        ssgrid.Lock = False
                        ssgrid.Col = 3
                        ssgrid.Lock = False
                        ssgrid.Col = 4
                        ssgrid.Lock = False
                        ssgrid.Col = 5
                        ssgrid.Lock = False
                        ssgrid.Col = 6
                        ssgrid.Lock = False

                        ssgrid.Col = 4
                        i = ssgrid.ActiveRow
                        ssgrid.Row = i
                        IssueQty = Val(ssgrid.Text)

                        ssgrid.Col = 12
                        i = ssgrid.ActiveRow
                        ssgrid.Row = i
                        'CurrentQty = Val(ssgrid.Text)
                        'If IssueQty > CurrentQty Then
                        '    MsgBox("Issue Qty cannot Be Greater Than Indent Qty")
                        '    ssgrid.Col = 4
                        '    ssgrid.Text = ""
                        '    ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
                        '    Exit Sub
                        'Else
                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
                        ' End If
                    End If
                End If
            ElseIf ssgrid.ActiveCol = 5 Then
                ssgrid.Col = 5
                i = ssgrid.ActiveRow
                ssgrid.Row = i
                'ssgrid.Lock = False
                If ssgrid.Lock = False Then
                    If Val(ssgrid.Text) = 0 Then
                        ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
                    Else
                        Call Calculate() '''--> Calculate total amount
                        ssgrid.Row = ssgrid.ActiveRow + 1
                        ssgrid.Col = 1
                        ssgrid.Lock = False
                        ssgrid.Col = 2
                        ssgrid.Lock = False
                        ssgrid.Col = 3
                        ssgrid.Lock = False
                        ssgrid.Col = 4
                        ssgrid.Lock = False
                        ssgrid.Col = 5
                        ssgrid.Lock = False
                        ssgrid.Col = 6
                        ssgrid.Lock = False
                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try

    End Sub

    Private Sub cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Print.Click
        ''''Try
        ''''    gPrint = True
        ''''    Dim i As Integer
        ''''    Dim objStockIssueClass As New rptStockissuereport
        ''''    Dim sqlstring = "SELECT TOP 100 PERCENT dbo.stockissueheader.docdetails, dbo.stockissueheader.docdate, dbo.stockissueheader.storelocationname, "
        ''''    sqlstring = sqlstring & " dbo.stockissueheader.opstorelocationname, dbo.stockissuedetail.itemcode,dbo.stockissueheader.storelocationcode,dbo.stockissueheader.opstorelocationcode, "
        ''''    sqlstring = sqlstring & " dbo.stockissuedetail.itemname, dbo.stockissuedetail.uom,dbo.stockissuedetail.qty, dbo.stockissuedetail.rate, dbo.stockissuedetail.amount ,  dbo.stockissueheader.indentno ,  dbo.stockissueheader.indentdate,dbo.stockissueheader.remarks,dbo.stockissueheader.updfooter,dbo.stockissueheader.updsign"
        ''''    sqlstring = sqlstring & " FROM dbo.stockissuedetail INNER JOIN dbo.stockissueheader ON dbo.stockissuedetail.docdetails = dbo.stockissueheader.docdetails"
        ''''    sqlstring = sqlstring & " WHERE dbo.stockissueheader.docdetails = '" & Trim(txt_Docno.Text) & "' "
        ''''    sqlstring = sqlstring & " ORDER BY dbo.stockissueheader.docdetails"
        ''''    ' Dim arraystring() As String = {"ITEM CODE", "ITEM NAME", "UOM", "QUANTITY", "RATE", "AMOUNT"}
        ''''    Dim arraystring() As String = {"SLNO", "ITEM CODE", "ITEM NAME", "UOM", "QUANTITY", "RATE", "AMOUNT"}
        ''''    Dim heading() As String = {"STOCK ISSUE"}
        ''''    'Dim colsize() As Integer = {15, 40, 16, 10, 10, 12}
        ''''    Dim colsize() As Integer = {5, 15, 40, 16, 10, 10, 12}
        ''''    objStockIssueClass.Reportdetails(sqlstring, heading, arraystring, colsize)
        ''''Catch ex As Exception
        ''''    MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        ''''    Exit Sub
        ''''End Try
        Try
            'If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
            Dim rViewer As New Viewer
            Dim sqlstring, SSQL, FROMSTORE As String
            Dim r As New Rpt_IndentIssue_
            sqlstring = "SELECT TOP 100 PERCENT docdetails, docdate, storelocationname, "
            sqlstring = sqlstring & " opstorelocationname, itemcode,storelocationcode,opstorelocationcode, "
            sqlstring = sqlstring & " itemname, uom,qty, rate, amount , indentno , indentdate,remarks,UPDFOOTER,UPDSIGN"
            sqlstring = sqlstring & " FROM VW_PO_STOCKINDENTAUTH_BILL "
            sqlstring = sqlstring & " WHERE docdetails = '" & Trim(txt_Docno.Text) & "' "
            sqlstring = sqlstring & " ORDER BY docdetails"

            gconnection.getDataSet(sqlstring, "VW_INV_ISSUEBILL")
            If gdataset.Tables("VW_INV_ISSUEBILL").Rows.Count > 0 Then
                rViewer.ssql = sqlstring
                rViewer.Report = r
                rViewer.TableName = "VW_INV_ISSUEBILL"
                Dim textobj1 As TextObject
                textobj1 = r.ReportDefinition.ReportObjects("Text13")
                textobj1.Text = MyCompanyName
                rViewer.Show()
            Else
                MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_storecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_storecode.Click
        gSQLString = "SELECT DISTINCT(storecode),storedesc FROM storemaster "
        M_WhereCondition = " where freeze <> 'Y' and isnull(storestatus,'')='M'"
        Dim vform As New ListOperattion1_N
        vform.Field = "STOREDESC,STORECODE"
        vform.vFormatstring = "         STORE CODE              |                  STORE DESCRIPTION                                                                                                   "
        vform.vCaption = "INVENTORY STORE MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_Mainstorecode.Text = Trim(vform.keyfield & "")
            txt_Mainstore.Text = Trim(vform.keyfield1 & "")
            cbo_Tostore.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txt_Mainstorecode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Mainstorecode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_Mainstorecode.Text) = "" Then
                Call cmd_storecode_Click(cmd_storecode, e)
            Else
                Call txt_Mainstorecode_Validated(sender, e)
                cbo_Tostore.Focus()
            End If
        End If
    End Sub

    Private Sub txt_Mainstorecode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Mainstorecode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_storecode_Click(cmd_storecode, e)
        End If
    End Sub

    Private Sub txt_Mainstorecode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Mainstorecode.Validated
        Try
            If Trim(txt_Mainstorecode.Text) <> "" Then
                sqlstring = "SELECT * FROM storemaster WHERE storecode='" & Trim(txt_Mainstorecode.Text) & "'"
                gconnection.getDataSet(sqlstring, "storemaster")
                If gdataset.Tables("storemaster").Rows.Count > 0 Then
                    txt_Mainstorecode.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storecode"))
                    txt_Mainstore.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storedesc"))
                    cbo_Tostore.Focus()
                End If
            End If
        Catch
            MessageBox.Show("Check The Error", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub



    Private Sub cmd_IndentNoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_IndentNoHelp.Click

        Try
            If gInventoryVersion = "N" Then
                gSQLString = "SELECT DISTINCT (INDENT_NO),INDENT_DATE  FROM PENDINGINDENTAUTH  INNER JOIN Categoryuserdetail C ON category=C.CATEGORYcode "
            Else
                gSQLString = "SELECT DISTINCT (INDENT_NO),INDENT_DATE  FROM PENDINGINDENTAUTH  INNER JOIN Categoryuserdetail C ON category=C.CATEGORYDESC "
            End If

            'If Me.UNAUTHORISED.Checked = True Then
            If txt_Mainstorecode.Text <> "" Then
                M_WhereCondition = "  WHERE USERCODE='" & gUsername & "'AND  fromstorecode='" & txt_Mainstorecode.Text & "' "
            Else
                MessageBox.Show("Select Store First ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
                txt_Mainstorecode.Focus()
                Exit Sub
            End If

            'Else
            '    If txt_Mainstorecode.Text <> "" Then
            '        M_WhereCondition = "  WHERE indent_no NOT IN(SELECT INDENTNO FROM PO_STOCKINDENTAUTH_HDR) and fromstorecode='" & txt_Mainstorecode.Text & "'"
            '    Else
            '        MessageBox.Show("Select Store First ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            '        txt_Mainstorecode.Focus()
            '        Exit Sub
            '    End If
            'End If

            Dim vform As New ListOperattion1_N
            vform.Field = "INDENT_NO,INDENT_DATE"
            vform.vFormatstring = "       INDENT_NO                  |     INDENT_DATE                                                           "
            vform.vCaption = "PO STOCK INDENT HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                Txt_IndentNo.Text = Trim(vform.keyfield & "")
                ssgrid.ClearRange(1, 1, -1, -1, True)
                Call Txt_IndentNo_Validated(Txt_IndentNo, e)
                dtp_IndentDate.Focus()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Txt_IndentNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_IndentNo.Validated
        Try
            Dim Clsquantity, TotAmount, Totqty As Double
            Dim i, j, k As Integer
            Dim SSQL, remark As String

            If Trim(Txt_IndentNo.Text) <> "" Then

                sqlstring = " SELECT INDENTNO FROM PO_STOCKINDENTAUTH_HDR WHERE INDENTNO='" & Txt_IndentNo.Text & "'" ' AND ISNULL(VOID,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "INDENTVAL")
                If gdataset.Tables("INDENTVAL").Rows.Count > 0 Then
                    MessageBox.Show("THIS INDENTNO HAD BEEN PROCESSED ALREADY")
                    Txt_IndentNo.Focus()
                    Txt_IndentNo.Text = ""
                    Exit Sub
                End If

                sqlstring = "SELECT ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE AS DOCDATE,H.INDENTNO INDENTNO, H.INDENTDATE AS INDENTDATE, "
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONNAME,'') AS STORELOCATIONNAME,ISNULL(H.OPSTORELOCATIONCODE,'') AS OPSTORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.OPSTORELOCATIONNAME,'') AS OPSTORELOCATIONNAME,ISNULL(H.TOTALAMT,0) AS TOTALAMT,ISNULL(H.REMARKS,'') AS REMARKS,"
                sqlstring = sqlstring & " ISNULL(H.VOID,'') AS VOID,ISNULL(H.VOIDREASON,'') AS VOIDREASON,ISNULL(H.ADDUSER,'') AS ADDUSER,ADDDATE,ISNULL(H.UPDATEUSER,'') AS UPDATEUSER,UPDATETIME"
                sqlstring = sqlstring & " FROM PO_STOCKINDENTAUTH_HDR AS H WHERE INDENTNO='" & Trim(Txt_IndentNo.Text) & "'"
                gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")

                If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
                    Call DOCNO_INDNO_VALIDATE()
                Else
                    sqlstring = " SELECT ISNULL(H.INDENT_NO,'') AS INDENT_NO,H.INDENT_DATE AS INDENT_DATE,ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE, "
                    sqlstring = sqlstring & " ISNULL(H.STORELOCATIONNAME,'') AS STORELOCATIONNAME,ISNULL(H.PRODUCT_TYPE,'') AS PRODUCT_TYPE,"
                    sqlstring = sqlstring & " ISNULL(H.REMARKS,'') AS REMARKS, ISNULL(H.VOID,'') AS VOID,"
                    sqlstring = sqlstring & " ISNULL(H.ADDUSER,'') AS ADDUSER,ADDDATETIME,ISNULL(H.UPDATEUSER,'') AS UPDATEUSER,UPDATETIME , ISNULL(H.FROMSTORECODE,'') FROMSTORECODE"
                    sqlstring = sqlstring & " FROM PO_INDENTHDR AS H "
                    sqlstring = sqlstring & " WHERE INDENT_NO='" & Txt_IndentNo.Text & "'"
                    gconnection.getDataSet(sqlstring, "INDENTHDR")
                    '''************************************************* SELECT RECORD FROM INDENTHDR *********************************************''''                
                    If gdataset.Tables("INDENTHDR").Rows.Count > 0 Then
                        'Cmd_Add.Text = "Update[F7]"
                        Me.Txt_IndentNo.ReadOnly = True
                        'txt_Docno.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("INDENT_NO") & "")
                        dtp_IndentDate.Value = Format(CDate(gdataset.Tables("INDENTHDR").Rows(0).Item("INDENT_DATE")), "dd-MM-yyyy")
                        txt_Tostorecode.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("STORELOCATIONCODE"))
                        cbo_Tostore.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("STORELOCATIONNAME"))
                        txt_Mainstorecode.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("FROMSTORECODE"))
                        remark = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("REMARKS"))
                        txt_Remarks.Text = Replace(remark, "?", "'")
                        Call txt_Mainstorecode_Validated(Txt_IndentNo.Text, e)
                        'cbo_type.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("PRODUCT_TYPE"))
                        'txt_Remarks.Text = Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("REMARKS"))
                        If gdataset.Tables("INDENTHDR").Rows(0).Item("VOID") = "Y" Then
                            Me.lbl_Freeze.Visible = True
                            Me.lbl_Freeze.Text = "Record Freezed On " & Format(CDate(gdataset.Tables("INDENTHDR").Rows(0).Item("UPDATETIME")), "dd-MMM-yyyy")
                            Me.Cmd_Freeze.Enabled = False
                        Else
                            Me.lbl_Freeze.Visible = False
                            Me.Cmd_Freeze.Enabled = True
                            Me.lbl_Freeze.Text = "Record Freezed  On "
                            Me.Cmd_Freeze.Text = "Void[F8]"
                        End If
                        If Trim(gdataset.Tables("INDENTHDR").Rows(0).Item("VOID")) = "Y" Then
                            Cmd_Add.Enabled = False
                            Cmd_Freeze.Enabled = False
                        End If
                        '''************************************************* SELECT RECORD FROM INDENTDETAILS *********************************************''''                
                        Dim strsql As String
                        Dim STRITEMCODE, STRITEMUOM As String
                        sqlstring = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM,ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE ,"
                        sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT, ISNULL(IND_QTY,0) AS IND_QTY"
                        sqlstring = sqlstring & " FROM PO_INDENTDET WHERE  INDENT_NO ='" & Trim(Txt_IndentNo.Text) & "' ORDER BY AUTOID"
                        gconnection.getDataSet(sqlstring, "INDENTDETAILS")
                        If gdataset.Tables("INDENTDETAILS").Rows.Count > 0 Then
                            TotAmount = 0
                            For i = 1 To gdataset.Tables("INDENTDETAILS").Rows.Count
                                Call GridUOM(i) '''---> FILL GRID UOM
                                ssgrid.SetText(1, i, Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("ITEMCODE")))
                                STRITEMCODE = Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("ITEMCODE"))
                                STRITEMUOM = Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("UOM"))
                                ssgrid.SetText(2, i, Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("ITEMNAME")))
                                ssgrid.Col = 3
                                ssgrid.Row = i
                                ssgrid.TypeComboBoxString = Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("UOM"))
                                ssgrid.Text = Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("UOM"))
                                Dim ISSDATE As Date
                                ISSDATE = Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy")
                                'Clsquantity = ClosingQuantity_Date(STRITEMCODE, Trim(txt_Mainstorecode.Text), STRITEMUOM, ISSDATE)
                                'If Val(Clsquantity) < Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("QTY")) Then
                                '    MsgBox("STOCK NOT AVAILABLE FOR " & STRITEMCODE, MsgBoxStyle.Critical, "INVENTORY")
                                '    ssgrid.Col = 4
                                '    ssgrid.Row = i
                                '    ssgrid.Text = ""
                                '    ssgrid.SetActiveCell(4, i)
                                '    ssgrid.Focus()
                                '    'ssgrid.SetText(13, i, Val(ClosingQuantity_Date(STRITEMCODE, Trim(txt_Mainstorecode.Text), STRITEMUOM, ISSDATE)))
                                '    Exit Sub
                                'Else
                                ssgrid.SetText(4, i, Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("QTY")))
                                'End If
                                ssgrid.SetText(12, i, Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("IND_QTY")), "0.000"))
                                ssgrid.SetText(5, i, Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("RATE")), "0.00"))
                                SSQL = " select groupcode, subgroupcode from inventoryitemmaster"
                                SSQL = SSQL & " where itemcode = '" & Trim(gdataset.Tables("INDENTDETAILS").Rows(j).Item("ITEMCODE")) & "'"
                                gconnection.getDataSet(SSQL, "storecode")
                                If gdataset.Tables("storecode").Rows.Count > 0 Then
                                    ssgrid.SetText(10, i, gdataset.Tables("storecode").Rows(0).Item("groupcode"))
                                    ssgrid.SetText(11, i, gdataset.Tables("storecode").Rows(0).Item("subgroupcode"))
                                End If
                                TotAmount = TotAmount + Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("AMOUNT")), "0.00")
                                ssgrid.SetText(6, i, Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("AMOUNT")), "0.00"))
                                Dim TransUOm As String
                                ssgrid.Col = 3
                                ssgrid.Row = ssgrid.ActiveRow
                                TransUOm = ssgrid.Text
                                ssgrid.Col = 13
                                ssgrid.Row = ssgrid.ActiveRow
                                Dim INDDATE As Date
                                INDDATE = Format(CDate(dtp_IndentDate.Value), "dd-MMM-yyyy")
                                'Clsquantity = ClosingQuantity_Date(STRITEMCODE, Trim(txt_Mainstorecode.Text), STRITEMUOM, INDDATE)
                                ssgrid.SetText(13, i, Clsquantity)
                                Totqty = Totqty + Format(Val(gdataset.Tables("INDENTDETAILS").Rows(j).Item("qty")), "0.00")
                                j = j + 1
                            Next
                            txt_Totalamount.Text = TotAmount
                            Txt_qty.Text = Format(Totqty, "0.000")
                        End If
                        If gUserCategory <> "S" Then
                            Call GetRights()
                        End If
                        If Not String.IsNullOrEmpty(gAuditFlg) Then
                            If gAuditFlg.ToUpper = "Y" Then
                                Me.Cmd_Add.Enabled = False
                                Me.Cmd_Freeze.Enabled = False
                            End If
                        End If
                        cbo_Tostore.Enabled = False
                        txt_Tostorecode.Enabled = False
                        dtp_IndentDate.Enabled = False
                        Txt_qty.Enabled = False
                        txt_Totalamount.Enabled = False
                        ssgrid.SetActiveCell(1, 1)
                    Else
                        MsgBox("NOT A VAILD INDENT NO", MsgBoxStyle.Question)
                        Txt_IndentNo.Text = ""
                        Txt_IndentNo.Focus()
                    End If
                End If
            End If
            Call Grid_lock()
        Catch ex As Exception
            MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Txt_IndentNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_IndentNo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Txt_IndentNo.Text = "" Then
                Call cmd_IndentNoHelp_Click(Txt_IndentNo, e)
            Else
                Call Txt_IndentNo_Validated(Txt_IndentNo, e)
            End If
        End If
    End Sub
    Private Sub DOCNO_INDNO_VALIDATE()
        Dim j, i As Integer
        Dim dt As New DataTable
        Dim vString, sqlstring, remarks, SSQL, SSQL1 As String
        Dim vTypeseqno, Clsquantity, vGroupseqno, Totqty, TOTAMT As Double




        TOTALQTY = 0
        SSQL = "SELECT SUM(QTY) AS QTY"
        SSQL = SSQL & " FROM PO_INDENTDET WHERE  INDENT_NO ='" & Trim(Txt_IndentNo.Text) & "'"
        gconnection.getDataSet(SSQL, "STOCKISSUEHEADER1")
        If gdataset.Tables("STOCKISSUEHEADER1").Rows.Count > 0 Then
            TOTALQTY = Trim(gdataset.Tables("STOCKISSUEHEADER1").Rows(0).Item("QTY"))
        End If

        ISSUEQTY = 0
        SSQL1 = "SELECT SUM(QTY) AS QTY"
        SSQL1 = SSQL1 & " FROM PO_STOCKINDENTAUTH_DET WHERE  INDENTNO ='" & Trim(Txt_IndentNo.Text) & "'"
        gconnection.getDataSet(SSQL1, "STOCKISSUEHEADER11")
        If gdataset.Tables("STOCKISSUEHEADER11").Rows.Count > 0 Then
            ISSUEQTY = Trim(gdataset.Tables("STOCKISSUEHEADER11").Rows(0).Item("QTY"))
        End If

        If Trim(Txt_IndentNo.Text) <> "" Then
            Try
                sqlstring = "SELECT ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE AS DOCDATE,H.INDENTNO INDENTNO, H.INDENTDATE AS INDENTDATE, "
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONNAME,'') AS STORELOCATIONNAME,ISNULL(H.OPSTORELOCATIONCODE,'') AS OPSTORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.OPSTORELOCATIONNAME,'') AS OPSTORELOCATIONNAME,ISNULL(H.TOTALAMT,0) AS TOTALAMT,ISNULL(H.REMARKS,'') AS REMARKS,"
                sqlstring = sqlstring & " ISNULL(H.VOID,'') AS VOID,ISNULL(H.VOIDREASON,'') AS VOIDREASON,ISNULL(H.ADDUSER,'') AS ADDUSER,ADDDATE,ISNULL(H.UPDATEUSER,'') AS UPDATEUSER,UPDATETIME"
                sqlstring = sqlstring & " FROM PO_STOCKINDENTAUTH_HDR AS H WHERE INDENTNO='" & Trim(Txt_IndentNo.Text) & "'"
                gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")
                '''************************************************* SELECT RECORD FROM STOCKISSUEHEADER *********************************************''''                
                If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
                    'Cmd_Add.Text = "Update[F7]"
                    Me.txt_Docno.ReadOnly = True
                    VSTRDOCNO = Trim(txt_Docno.Text)
                    '  txt_Docno.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDETAILS") & "")
                    Txt_IndentNo.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("INDENTNO") & "")
                    dtp_IndentDate.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("INDENTDATE")), "dd-MM-yyyy")
                    dtp_Docdate.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDATE")), "dd-MM-yyyy")
                    txt_Mainstorecode.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONCODE"))
                    txt_Mainstore.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONNAME"))
                    txt_Tostorecode.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONCODE"))
                    cbo_Tostore.DropDownStyle = ComboBoxStyle.DropDown
                    VSTORECODE = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONCODE"))
                    VSTORENAME = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONNAME"))
                    cbo_Tostore.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONNAME"))
                    cbo_Tostore.DropDownStyle = ComboBoxStyle.DropDownList
                    ' txt_Totalamount.Text = Format(Val(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("TOTALAMT")), "0.00")
                    remarks = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("REMARKS"))
                    txt_Remarks.Text = Replace(remarks, "?", "'")
                    If gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("VOID") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("ADDDATE")), "dd-MMM-yyyy")
                        Me.Cmd_Freeze.Enabled = False
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.Cmd_Freeze.Enabled = True
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.Cmd_Freeze.Text = "Void[F8]"
                    End If
                    If Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("VOID")) = "Y" Then
                        Cmd_Add.Enabled = False
                        Cmd_Freeze.Enabled = False
                    End If
                    '''************************************************* SELECT RECORD FROM STOCKISSUEDETAILS *********************************************''''                
                    ' If TOTALQTY <> ISSUEQTY Then
                    Dim strsql As String
                    Dim STRITEMCODE As String
                    sqlstring = "SELECT ISNULL(A.ITEMCODE,'') AS ITEMCODE,ISNULL(A.ITEMNAME,'') AS ITEMNAME,ISNULL(A.UOM,'') AS UOM,(SUM(B.ISSQTY)- SUM(A.ISSQTY)) AS QTY,ISNULL(A.RATE,0) AS RATE ,"
                    sqlstring = sqlstring & "( (SUM(B.ISSQTY)- SUM(A.ISSQTY)) * A.RATE ) AS AMOUNT,ISNULL(A.DBLAMT,0) AS DBLAMT,ISNULL(A.DBLCONV,'') AS DBLCONV,ISNULL(A.HIGHRATIO,0) AS HIGHRATIO,"
                    sqlstring = sqlstring & " ISNULL(A.GROUPCODE,'') AS GROUPCODE,ISNULL(A.SUBGROUPCODE,'') AS SUBGROUPCODE FROM PO_BREAK_ISSUE A, PO_BREAK_INDENT B WHERE   A.INDENTNO='" & Trim(Txt_IndentNo.Text) & "' AND "
                    sqlstring = sqlstring & "A.ITEMCODE=B.ITEMCODE AND A.INDENTNO=B.INDENTNO   "
                    sqlstring = sqlstring & " GROUP BY A.itemcode,A.itemname,A.UOM,A.RATE,A.DBLAMT,A.DBLCONV,A.HIGHRATIO,A.GROUPCODE,A.SUBGROUPCODE,A.INDENTNO HAVING (SUM(B.ISSQTY)- SUM(A.ISSQTY)) >0"

                    gconnection.getDataSet(sqlstring, "STOCKISSUEDETAILSALL")
                    If gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count
                            ssgrid.SetText(1, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("ITEMCODE")))
                            STRITEMCODE = Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("ITEMCODE"))
                            ssgrid.SetText(2, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("ITEMNAME")))
                            ssgrid.Col = 3
                            ssgrid.Row = i
                            ssgrid.Text = Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("UOM"))
                            ssgrid.SetText(4, i, Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("QTY")))
                            ssgrid.SetText(12, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("QTY")), "0.000"))
                            ssgrid.SetText(5, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("RATE")), "0.00"))
                            ssgrid.SetText(6, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("AMOUNT")), "0.00"))
                            ssgrid.SetText(7, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("DBLAMT")), "0.000"))
                            ssgrid.SetText(8, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("DBLCONV")))
                            ssgrid.SetText(9, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("HIGHRATIO")), "0.00"))
                            ssgrid.SetText(10, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("GROUPCODE")))
                            ssgrid.SetText(11, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("SUBGROUPCODE")))
                            If gInventoryVersion = "N" Then
                                gconnection.closingStock(Format(dtp_Docdate.Value, "dd/MMM/yyyy"), Trim(STRITEMCODE), Trim(txt_Mainstorecode.Text), "")
                                Dim closingqty, rate As Double
                                If (gdataset.Tables("closingstock").Rows.Count > 0) Then
                                    Clsquantity = gdataset.Tables("closingstock").Rows(0).Item("closingstock")
                                Else
                                    Clsquantity = 0
                                End If
                            Else
                                Clsquantity = ClosingQuantity(Trim(STRITEMCODE), Trim(txt_Mainstorecode.Text))
                            End If

                            ' Clsquantity = ClosingQuantity(STRITEMCODE, Trim(txt_Mainstorecode.Text))
                            ssgrid.SetText(13, i, Clsquantity)
                            Totqty = Totqty + Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("qty")), "0.00")
                            TOTAMT = TOTAMT + Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("AMOUNT")), "0.00")
                            j = j + 1
                        Next
                        Txt_qty.Text = Totqty
                        txt_Totalamount.Text = TOTAMT
                    End If
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                    If Not String.IsNullOrEmpty(gAuditFlg) Then
                        If gAuditFlg.ToUpper = "Y" Then
                            Me.Cmd_Add.Enabled = False
                            Me.Cmd_Freeze.Enabled = False
                        End If
                    End If
                    TotalCount = gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count
                    ssgrid.SetActiveCell(1, 1)
                End If
            Catch ex As Exception
                MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub
    Private Function Grid_lock()
        Dim i, j As Integer
        For i = 1 To ssgrid.DataRowCnt
            ssgrid.Row = i
            For j = 1 To ssgrid.MaxCols
                ssgrid.Col = j
                ssgrid.Lock = True
            Next
        Next
    End Function

    Private Sub txt_Tostorecode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Tostorecode.Validated
        Call cbo_Tostore_SelectedIndexChanged(txt_Tostorecode, e)
    End Sub

    Private Sub Txt_IndentNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_IndentNo.GotFocus
        Txt_IndentNo.BackColor = Color.Gold
        Label16.Visible = True
    End Sub

    Private Sub Txt_IndentNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_IndentNo.LostFocus
        Txt_IndentNo.BackColor = Color.Wheat
        Label16.Visible = False
    End Sub
    Private Sub Txt_qty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Txt_qty.Text = Format(Val(Txt_qty.Text), "0.00")
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub Txt_footer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If Trim(Txt_footer.Text) <> "" Then
                Txt_signature.Focus()
            Else
                Txt_footer.Focus()
            End If
        End If
    End Sub
    Private Sub Chk_item_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_item.CheckedChanged
        If Chk_item.Checked = True Then
            grp_footer.Visible = True
            Txt_footer.Focus()
        Else
            grp_footer.Visible = False
        End If
    End Sub
    Private Sub Txt_signature_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Chk_item.Focus()
        End If
    End Sub
    Public Function FOOTER()
        sqlstring = "SELECT isnull(UPDFOOTER,'') as UPDFOOTER,isnull(UPDsign,'') as UPDsign FROM PO_STOCKINDENTAUTH_HDR WHERE  AUTOID IN (SELECT MAX(AUTOID) FROM PO_STOCKINDENTAUTH_HDR )"
        gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")
        If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
            Txt_footer.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("UPDFOOTER"))
            Txt_signature.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("UPdsign"))
        End If
    End Function

    Private Sub ssgrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid.Advance

    End Sub

    Private Sub Txt_IndentNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_IndentNo.TextChanged

    End Sub

    Private Sub txt_Docno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Docno.TextChanged

    End Sub

   
    Private Sub cmd_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_export.Click
        Dim sqlstring As String
        Dim _export As New EXPORT
        _export.TABLENAME = "VW_PO_STOCKINDENTAUTH_BILL"
        sqlstring = "select * from VW_PO_STOCKINDENTAUTH_BILL"
        Call _export.export_excel(sqlstring)
        _export.Show()
        Exit Sub
    End Sub

   
    Private Sub btn_auth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_auth.Click
        Dim SSQLSTR, SSQLSTR2 As String
        Dim USERT As Integer
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 1
        End If
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 2
        End If
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 3
        End If
        If USERT = 1 Then
            SSQLSTR2 = " SELECT * FROM PO_STOCKINDENTAUTH_DET WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " select ISNULL(docdate,'') as DOCDATE, ISNULL(docdetails,'') as DOCDETAILS,  ISNULL(storelocationcode,'') as STORELOCATIONCODE, "
                        SSQLSTR2 = SSQLSTR2 & " ISNULL(storelocationname,'') as STORELOCATIONNAME, ISNULL(Opstorelocationcode,'') as OPSTORELOCATIONCODE, ISNULL(Opstorelocationname,'') as OPSTORELOCATIONNAME, "
                        SSQLSTR2 = SSQLSTR2 & " isnull(Itemcode,'') as ITEMCODE, ISNULL(Itemname,'') as ITEMNAME, ISNULL(UoM,'') as UOM, ISNULL(Qty,0) as QTY, ISNULL(rate,0) as RATE, "
                        SSQLSTR2 = SSQLSTR2 & " ISNULL(Amount,0) as AMOUNT FROM PO_STOCKINDENTAUTH_DET"
                        SSQLSTR2 = SSQLSTR2 & " WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE PO_STOCKINDENTAUTH_DET set  ", "docdetails", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM PO_STOCKINDENTAUTH_DET WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " select ISNULL(docdate,'') as DOCDATE, ISNULL(docdetails,'') as DOCDETAILS,  ISNULL(storelocationcode,'') as STORELOCATIONCODE, "
                        SSQLSTR2 = SSQLSTR2 & " ISNULL(storelocationname,'') as STORELOCATIONNAME, ISNULL(Opstorelocationcode,'') as OPSTORELOCATIONCODE, ISNULL(Opstorelocationname,'') as OPSTORELOCATIONNAME, "
                        SSQLSTR2 = SSQLSTR2 & " isnull(Itemcode,'') as ITEMCODE, ISNULL(Itemname,'') as ITEMNAME, ISNULL(UoM,'') as UOM, ISNULL(Qty,0) as QTY, ISNULL(rate,0) as RATE, "
                        SSQLSTR2 = SSQLSTR2 & " ISNULL(Amount,0) as AMOUNT FROM PO_STOCKINDENTAUTH_DET"
                        SSQLSTR2 = SSQLSTR2 & " WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE PO_STOCKINDENTAUTH_DET set  ", "docdetails", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            End If
        ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM PO_STOCKINDENTAUTH_DET WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " select ISNULL(docdate,'') as DOCDATE, ISNULL(docdetails,'') as DOCDETAILS,  ISNULL(storelocationcode,'') as STORELOCATIONCODE, "
                        SSQLSTR2 = SSQLSTR2 & " ISNULL(storelocationname,'') as STORELOCATIONNAME, ISNULL(Opstorelocationcode,'') as OPSTORELOCATIONCODE, ISNULL(Opstorelocationname,'') as OPSTORELOCATIONNAME, "
                        SSQLSTR2 = SSQLSTR2 & " isnull(Itemcode,'') as ITEMCODE, ISNULL(Itemname,'') as ITEMNAME, ISNULL(UoM,'') as UOM, ISNULL(Qty,0) as QTY, ISNULL(rate,0) as RATE, "
                        SSQLSTR2 = SSQLSTR2 & " ISNULL(Amount,0) as AMOUNT FROM PO_STOCKINDENTAUTH_DET"
                        SSQLSTR2 = SSQLSTR2 & " WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE PO_STOCKINDENTAUTH_DET set  ", "docdetails", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                        End If
                    End If
                End If
           
            End If
        Else
            MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Pic_auth1_Click(sender As Object, e As EventArgs) Handles Pic_auth1.Click
        Try

            Dim file As New OpenFileDialog
            file.Filter = " Jpg(*.Jpg) | *.jpg"
            If Trim(Txt_IndentNo.Text) <> "" Then
                If file.ShowDialog = DialogResult.OK Then
                    Pic_auth1.Image = New Bitmap(file.FileName)
                    strPhotoFilePath_auth1 = file.FileName
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
        End Try
    End Sub

    Private Sub Pic_auth2_Click(sender As Object, e As EventArgs) Handles Pic_auth2.Click
        Try

            Dim file As New OpenFileDialog
            file.Filter = " Jpg(*.Jpg) | *.jpg"
            If Trim(Txt_IndentNo.Text) <> "" Then
                If file.ShowDialog = DialogResult.OK Then
                    Pic_auth2.Image = New Bitmap(file.FileName)
                    strPhotoFilePath_auth2 = file.FileName
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, gCompanyname)
        End Try

    End Sub
   
    Public Function SaveFoto(ByVal FilePath As String, ByVal Docdetails As String, ByVal Qurstr As String)
        Try
            '##### IN CASE NO PHOTO SELECTED ##### 
            If Trim(FilePath) = "" Then
                Exit Function
            End If
            '##### ##### ##### ##### ##### ##### #

            Dim cn As New SqlConnection(strcn)
            'Dim cmd As New SqlCommand("update membermaster set " & fieldname & _
            '" = @memimage where mcode = '" & Mcode & "' ", cn)
            Dim cmd As New SqlCommand(Qurstr, cn)
            Dim fsPhotoFile As New FileStream(FilePath, FileMode.Open, FileAccess.Read)
            Dim bytMEMimage(fsPhotoFile.Length() - 1) As Byte
            fsPhotoFile.Read(bytMEMimage, 0, bytMEMimage.Length)
            fsPhotoFile.Close()
            Dim prm As New SqlParameter("@memimage", SqlDbType.VarBinary, _
                bytMEMimage.Length, ParameterDirection.Input, False, _
                0, 0, Nothing, DataRowVersion.Current, bytMEMimage)
            cmd.Parameters.Add(prm)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Sub LoadFoto_DB(ByVal quystr As String, ByVal PIC As PictureBox)
        Try
            Dim cn As New SqlConnection(strcn)
            Dim sssql As String
            'sssql = "SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] ='" & Trim(CARDID.Text) & "' AND [16_DIGIT_CODE] NOT IN ( SELECT [16_DIGIT_CODE] FROM SM_CARDFILE_HDR WHERE [16_digit_code] = '" & Trim(CARDID.Text) & "' AND MEMIMAGE IS NULL)"
            Dim cmd As New SqlCommand(quystr, cn)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "sm_image")
            Dim c As Integer = ds.Tables("SM_IMAGE").Rows.Count
            If c > 0 Then
                Dim bytMEMimage() As Byte = ds.Tables("SM_IMAGE").Rows(c - 1)("memimage")
                Dim stmMEMimage As New MemoryStream(bytMEMimage)
                PIC.Image = Image.FromStream(stmMEMimage)
            Else
                PIC.Image = Nothing
            End If
        Catch ex As Exception
            '            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Resize_Form()
        Dim cControl As Control
        Dim i_i As Integer
        Dim J, K, L, M, n, o, P, Q, R, S, T, U As Integer
        'If (Screen.PrimaryScreen.Bounds.Height = 768) And (Screen.PrimaryScreen.Bounds.Width = 1366) Then
        '    Exit Sub
        'End If
        J = 732
        K = 1016
        Me.ResizeRedraw = True
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        T = CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)
        U = CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Width = U
        Me.Height = T


        With Me
            For i_i = 0 To .Controls.Count - 1
                ' MsgBox(Controls(i_i).Name)
                If TypeOf .Controls(i_i) Is Form Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0
                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If
                ElseIf TypeOf .Controls(i_i) Is Panel Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o

                    For Each cControl In .Controls(i_i).Controls

                        If cControl.Location.X = 0 Then
                            R = 0
                        Else
                            R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                        End If
                        If cControl.Location.Y = 0 Then
                            S = 0
                        Else
                            S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                        End If

                        cControl.Left = R
                        cControl.Top = S


                        If cControl.Size.Width = 0 Then
                            P = 0
                        Else
                            P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
                        End If

                        If cControl.Size.Height = 0 Then
                            Q = 0
                        Else
                            Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
                        End If

                        cControl.Width = P
                        cControl.Height = Q
                    Next
                ElseIf TypeOf .Controls(i_i) Is GroupBox Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        If Controls(i_i).Name = "frmbut" Then
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            If U = 800 Then
                                L = L + 50
                            End If
                            If U = 1280 Then
                                L = L + 50
                            End If
                            If U = 1360 Then
                                L = L + 75
                            End If
                            If U = 1366 Then
                                L = L + 75
                            End If
                        Else
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            ' L = L - 5
                        End If
                    End If

                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o

                    For Each cControl In .Controls(i_i).Controls

                        If cControl.Location.X = 0 Then
                            R = 0
                        Else
                            R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                        End If
                        If cControl.Location.Y = 0 Then
                            S = 0
                        Else
                            S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                        End If

                        cControl.Left = R
                        cControl.Top = S


                        If cControl.Size.Width = 0 Then
                            P = 0
                        Else
                            P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
                        End If

                        If cControl.Size.Height = 0 Then
                            Q = 0
                        Else
                            Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
                        End If

                        cControl.Width = P
                        cControl.Height = Q
                    Next
                ElseIf TypeOf .Controls(i_i) Is Label Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                End If
            Next i_i
        End With
    End Sub
    Private Sub contadd()
        grp_issue2.Controls.Add(lbl_Docno)
        grp_issue2.Controls.Add(lbl_Docdate)
        grp_issue2.Controls.Add(Txt_IndentNo)
        grp_issue2.Controls.Add(cmd_IndentNoHelp)
    End Sub

    Private Sub CMD_BROWSE_Click(sender As Object, e As EventArgs) Handles CMD_BROWSE.Click
        'Dim FRM As New ReportDesigner
        'If txt_Docno.Text.Length > 0 Then
        '    tables = " FROM VW_PO_STOCKINDENTAUTH_BILL WHERE DOCDETAILS ='" & txt_Docno.Text & "' "
        'Else
        '    tables = "FROM VW_PO_STOCKINDENTAUTH_BILL"
        'End If
        'Gheader = "INDENT DETAILS"
        'FRM.DataGridView1.ColumnCount = 2
        'FRM.DataGridView1.Columns(0).Name = "COLUMN NAME"
        'FRM.DataGridView1.Columns(0).Width = 300
        'FRM.DataGridView1.Columns(1).Name = "SIZE"
        'FRM.DataGridView1.Columns(1).Width = 100

        'Dim ROW As String() = New String() {"QUOTATIONNO", "10"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"DOCDETAILS", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"DOCDATE", "5"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"STORELOCATIONNAME", "9"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"OPSTORELOCATIONNAME", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"ITEMCODE", "12"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"STORELOCATIONCODE", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"OPSTORELOCATIONCODE", "12 "}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"ITEMNAME", "6 "}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"UOM", "8"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"QTY", "8"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"AUTH1", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"AUTH2", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"RATE", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"AMOUNT", "10"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"CLSQTY", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"INDENTNO", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"INDENTDATE", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"REMARKS", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"UPDFOOTER", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"UPDSIGN", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"ADDDATE", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"UOM", "15"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"DELIVERYTERMS", "11"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"ADDRESS", "20"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"CITY", "20"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"STATE", "7"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"MOBILENO", "15"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"PINCODE", "11"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"EMAIL", "15"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"ITEMCODE", "11"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"ITEMNAME", "20"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"QTY", "20"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"RATE", "7"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"DISCOUNT", "15"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"VATAMT", "11"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"VAT", "15"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"TOTAL", "11"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"DISCAMT", "20"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"AMOUNT", "20"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"poed", "7"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"pocst", "15"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"pomodvat", "11"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"poptax", "15"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"pooctra", "11"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"poinsurance", "20"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"polst", "20"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ' ''
        ''ROW = New String() {"POADVPERC", "7"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"TINNO", "15"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"PANNO", "11"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"posalet", "15"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"podespmode", "11"}
        ''FRM.DataGridView1.Rows.Add(ROW)
        ''ROW = New String() {"podocsthrough", "20"}
        ''FRM.DataGridView1.Rows.Add(ROW)

        'Dim CHK As New DataGridViewCheckBoxColumn()
        ''Dim CHK As New VIEWHDR
        'FRM.DataGridView1.Columns.Insert(0, CHK)
        'CHK.HeaderText = "CHECK"
        'CHK.Name = "CHK"
        'FRM.ShowDialog(Me)
        Dim obj1 As New VIEWHDR
        Dim sqlstr As String
        Dim childsql As String
        sqlstr = "select Docno,Docdetails,Doctype,Docdate,IndentNo,IndentDate,Storelocationcode,Storelocationname, "
        sqlstr = sqlstr & " Opstorelocationcode, Opstorelocationname, Totalamt,Remarks,Void,VoidReason,Adduser,Adddate,Updateuser,Updatetime,AUTHRZEBY,AUTHRZEDATE,UPDFOOTER,UPDSIGN from PO_STOCKINDENTAUTH_HDR"

        childsql = "select Docno,Docdetails,Docdate,IndentNo,IndentDate,Storelocationcode,Storelocationname,"
        childsql = childsql & " Opstorelocationcode,Opstorelocationname,Itemcode,Itemname,Uom,Qty,Rate,Amount,Clsqty,"
        childsql = childsql & " Dblamt,Dblconv,Highratio,Groupcode,Subgroupcode,Void,Avgqty,Avgrate,Adduser,adddatetime,Updateuser,Updatetime,IND_QTY from PO_STOCKINDENTAUTH_DET"
        'childsql = childsql & " VOID,Adduser,adddatetime,ind_qty from PO_INDENTDET"
        gconnection.getDataSet(sqlstr, "PO_STOCKINDENTAUTH_HDR")
        obj1.LOADGRID(gdataset.Tables("PO_STOCKINDENTAUTH_HDR"), True, "stockissue_indent_authorization", childsql, "docdetails", 2)
        obj1.Show()
    End Sub

    Private Sub ssgrid_KeyUpEvent(sender As Object, e As AxFPSpreadADO._DSpreadEvents_KeyUpEvent) Handles ssgrid.KeyUpEvent

    End Sub
End Class
