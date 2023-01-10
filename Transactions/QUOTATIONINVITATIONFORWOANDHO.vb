Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class QUOTATIONINVITATIONFORWOANDHO
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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtp_invitdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_invitedby As System.Windows.Forms.ComboBox
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Billterms As System.Windows.Forms.Label
    Friend WithEvents lbl_Suppliercode As System.Windows.Forms.Label
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents chk_excel As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_Print As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_FREEZE As System.Windows.Forms.Button
    Friend WithEvents cmd_Add As System.Windows.Forms.Button
    Friend WithEvents grp_StockGrndetails As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_StockGrndetails As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_StockGrnprint As System.Windows.Forms.Button
    Friend WithEvents Cmd_StockGrnView As System.Windows.Forms.Button
    Friend WithEvents Cmd_StockGrnexit As System.Windows.Forms.Button
    Friend WithEvents Cmd_StockGrnClear As System.Windows.Forms.Button
    Friend WithEvents lbl_FromDocno As System.Windows.Forms.Label
    Friend WithEvents txt_FromDocno As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_FromDocno As System.Windows.Forms.Button
    Friend WithEvents txt_ToDocno As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_ToDocno As System.Windows.Forms.Button
    Friend WithEvents lbl_ToDocno As System.Windows.Forms.Label
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents lbl_Grndate As System.Windows.Forms.Label
    Friend WithEvents lbl_Grnno As System.Windows.Forms.Label
    Friend WithEvents dtp_Indentdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Grn As System.Windows.Forms.Label
    Friend WithEvents cbo_Storelocation As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRoundoff As System.Windows.Forms.Button
    Friend WithEvents OptNearest As System.Windows.Forms.RadioButton
    Friend WithEvents OptNone As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdValueby As System.Windows.Forms.Button
    Friend WithEvents OptPercentage As System.Windows.Forms.RadioButton
    Friend WithEvents OptValue As System.Windows.Forms.RadioButton
    Friend WithEvents txtChangeValue As System.Windows.Forms.TextBox
    Friend WithEvents cmd_View As System.Windows.Forms.Button
    Friend WithEvents grp_Grngroup1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TXT_FROMSTORECODE As System.Windows.Forms.TextBox
    Friend WithEvents txt_FromStorename As System.Windows.Forms.TextBox
    Friend WithEvents txt_storecode As System.Windows.Forms.TextBox
    Friend WithEvents txt_IndentNo As System.Windows.Forms.TextBox
    Friend WithEvents txt_Totalamount As System.Windows.Forms.TextBox
    Friend WithEvents txt_storeDesc As System.Windows.Forms.TextBox
    Friend WithEvents cbo_type As System.Windows.Forms.ComboBox
    Friend WithEvents CHK_WAR As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Chk_item As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_fromStorecodeHelp As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmd_indentnoHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_storecode As System.Windows.Forms.Button
    Friend WithEvents grp_Billingdetails As System.Windows.Forms.GroupBox
    Friend WithEvents ssgrid_billdetails As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents grp_Excisedetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Trucknumber As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Stockindate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Trucknumber As System.Windows.Forms.Label
    Friend WithEvents lbl_Stockindate As System.Windows.Forms.Label
    Friend WithEvents lbl_Excisepassno As System.Windows.Forms.Label
    Friend WithEvents txt_Excisepassno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Excisepassdate As System.Windows.Forms.Label
    Friend WithEvents dtp_Excisepassdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents grp_footer As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_signature As System.Windows.Forms.TextBox
    Friend WithEvents Txt_footer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents spssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents cmd_auth As System.Windows.Forms.Button
    Friend WithEvents TXT_DOCNO As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_export As System.Windows.Forms.Button
    Friend WithEvents TXT_QUOTNO As System.Windows.Forms.TextBox
    Friend WithEvents cmd_qutnohelp As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTP_QTODATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents CMB_QUOTTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents CMD_BROWSE As System.Windows.Forms.Button
    Friend WithEvents DTP_DOCDATE As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QUOTATIONINVITATIONFORWOANDHO))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtp_invitdate = New System.Windows.Forms.DateTimePicker()
        Me.cmb_invitedby = New System.Windows.Forms.ComboBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_Billterms = New System.Windows.Forms.Label()
        Me.lbl_Suppliercode = New System.Windows.Forms.Label()
        Me.frmbut = New System.Windows.Forms.GroupBox()
        Me.CMD_BROWSE = New System.Windows.Forms.Button()
        Me.cmd_export = New System.Windows.Forms.Button()
        Me.cmd_auth = New System.Windows.Forms.Button()
        Me.cmd_Print = New System.Windows.Forms.Button()
        Me.cmd_Exit = New System.Windows.Forms.Button()
        Me.cmd_Clear = New System.Windows.Forms.Button()
        Me.Cmd_FREEZE = New System.Windows.Forms.Button()
        Me.cmd_Add = New System.Windows.Forms.Button()
        Me.cmd_View = New System.Windows.Forms.Button()
        Me.chk_excel = New System.Windows.Forms.CheckBox()
        Me.grp_StockGrndetails = New System.Windows.Forms.GroupBox()
        Me.lbl_StockGrndetails = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Cmd_StockGrnprint = New System.Windows.Forms.Button()
        Me.Cmd_StockGrnView = New System.Windows.Forms.Button()
        Me.Cmd_StockGrnexit = New System.Windows.Forms.Button()
        Me.Cmd_StockGrnClear = New System.Windows.Forms.Button()
        Me.lbl_FromDocno = New System.Windows.Forms.Label()
        Me.txt_FromDocno = New System.Windows.Forms.TextBox()
        Me.Cmd_FromDocno = New System.Windows.Forms.Button()
        Me.txt_ToDocno = New System.Windows.Forms.TextBox()
        Me.Cmd_ToDocno = New System.Windows.Forms.Button()
        Me.lbl_ToDocno = New System.Windows.Forms.Label()
        Me.lbl_Heading = New System.Windows.Forms.Label()
        Me.lbl_Grndate = New System.Windows.Forms.Label()
        Me.lbl_Grnno = New System.Windows.Forms.Label()
        Me.dtp_Indentdate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Grn = New System.Windows.Forms.Label()
        Me.cbo_Storelocation = New System.Windows.Forms.ComboBox()
        Me.lbl_Freeze = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdRoundoff = New System.Windows.Forms.Button()
        Me.OptNearest = New System.Windows.Forms.RadioButton()
        Me.OptNone = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdValueby = New System.Windows.Forms.Button()
        Me.OptPercentage = New System.Windows.Forms.RadioButton()
        Me.OptValue = New System.Windows.Forms.RadioButton()
        Me.txtChangeValue = New System.Windows.Forms.TextBox()
        Me.grp_Grngroup1 = New System.Windows.Forms.GroupBox()
        Me.CMB_QUOTTYPE = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTP_QTODATE = New System.Windows.Forms.DateTimePicker()
        Me.cmd_qutnohelp = New System.Windows.Forms.Button()
        Me.TXT_QUOTNO = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DTP_DOCDATE = New System.Windows.Forms.DateTimePicker()
        Me.txt_IndentNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txt_storecode = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmd_storecode = New System.Windows.Forms.Button()
        Me.txt_storeDesc = New System.Windows.Forms.TextBox()
        Me.cmd_indentnoHelp = New System.Windows.Forms.Button()
        Me.TXT_DOCNO = New System.Windows.Forms.TextBox()
        Me.cmd_fromStorecodeHelp = New System.Windows.Forms.Button()
        Me.TXT_FROMSTORECODE = New System.Windows.Forms.TextBox()
        Me.txt_FromStorename = New System.Windows.Forms.TextBox()
        Me.cbo_type = New System.Windows.Forms.ComboBox()
        Me.txt_Totalamount = New System.Windows.Forms.TextBox()
        Me.CHK_WAR = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.lbl_Remarks = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Chk_item = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grp_Billingdetails = New System.Windows.Forms.GroupBox()
        Me.ssgrid_billdetails = New AxFPSpreadADO.AxfpSpread()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread()
        Me.grp_Excisedetails = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Trucknumber = New System.Windows.Forms.TextBox()
        Me.dtp_Stockindate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Trucknumber = New System.Windows.Forms.Label()
        Me.lbl_Stockindate = New System.Windows.Forms.Label()
        Me.lbl_Excisepassno = New System.Windows.Forms.Label()
        Me.txt_Excisepassno = New System.Windows.Forms.TextBox()
        Me.lbl_Excisepassdate = New System.Windows.Forms.Label()
        Me.dtp_Excisepassdate = New System.Windows.Forms.DateTimePicker()
        Me.grp_footer = New System.Windows.Forms.GroupBox()
        Me.Txt_signature = New System.Windows.Forms.TextBox()
        Me.Txt_footer = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.spssgrid = New AxFPSpreadADO.AxfpSpread()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.frmbut.SuspendLayout()
        Me.grp_StockGrndetails.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grp_Grngroup1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.grp_Billingdetails.SuspendLayout()
        CType(Me.ssgrid_billdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Excisedetails.SuspendLayout()
        Me.grp_footer.SuspendLayout()
        CType(Me.spssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(7, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 15)
        Me.Label15.TabIndex = 524
        Me.Label15.Text = "INVITED BY :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 15)
        Me.Label11.TabIndex = 522
        Me.Label11.Text = "INVITATION DATE :"
        '
        'dtp_invitdate
        '
        Me.dtp_invitdate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_invitdate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_invitdate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_invitdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_invitdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_invitdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_invitdate.Location = New System.Drawing.Point(116, 49)
        Me.dtp_invitdate.Name = "dtp_invitdate"
        Me.dtp_invitdate.Size = New System.Drawing.Size(94, 21)
        Me.dtp_invitdate.TabIndex = 525
        '
        'cmb_invitedby
        '
        Me.cmb_invitedby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_invitedby.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_invitedby.Items.AddRange(New Object() {"MANAGER", "MC.MEMBERS", "AC.MANAGER"})
        Me.cmb_invitedby.Location = New System.Drawing.Point(87, 14)
        Me.cmb_invitedby.Name = "cmb_invitedby"
        Me.cmb_invitedby.Size = New System.Drawing.Size(124, 23)
        Me.cmb_invitedby.TabIndex = 523
        '
        'txt_qty
        '
        Me.txt_qty.BackColor = System.Drawing.Color.Wheat
        Me.txt_qty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_qty.Enabled = False
        Me.txt_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(75, 404)
        Me.txt_qty.MaxLength = 15
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_qty.Size = New System.Drawing.Size(88, 26)
        Me.txt_qty.TabIndex = 510
        Me.txt_qty.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 509
        Me.Label1.Text = "ISSUE STORE :"
        Me.Label1.Visible = False
        '
        'lbl_Billterms
        '
        Me.lbl_Billterms.AutoSize = True
        Me.lbl_Billterms.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Billterms.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Billterms.Location = New System.Drawing.Point(8, 43)
        Me.lbl_Billterms.Name = "lbl_Billterms"
        Me.lbl_Billterms.Size = New System.Drawing.Size(93, 15)
        Me.lbl_Billterms.TabIndex = 517
        Me.lbl_Billterms.Text = "QUOTATION NO"
        '
        'lbl_Suppliercode
        '
        Me.lbl_Suppliercode.AutoSize = True
        Me.lbl_Suppliercode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Suppliercode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Suppliercode.Location = New System.Drawing.Point(8, 74)
        Me.lbl_Suppliercode.Name = "lbl_Suppliercode"
        Me.lbl_Suppliercode.Size = New System.Drawing.Size(48, 15)
        Me.lbl_Suppliercode.TabIndex = 493
        Me.lbl_Suppliercode.Text = "WO NO"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.CMD_BROWSE)
        Me.frmbut.Controls.Add(Me.cmd_export)
        Me.frmbut.Controls.Add(Me.cmd_auth)
        Me.frmbut.Controls.Add(Me.cmd_Print)
        Me.frmbut.Controls.Add(Me.cmd_Exit)
        Me.frmbut.Controls.Add(Me.cmd_Clear)
        Me.frmbut.Controls.Add(Me.Cmd_FREEZE)
        Me.frmbut.Controls.Add(Me.cmd_Add)
        Me.frmbut.Controls.Add(Me.cmd_View)
        Me.frmbut.Location = New System.Drawing.Point(860, 89)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(146, 583)
        Me.frmbut.TabIndex = 494
        Me.frmbut.TabStop = False
        '
        'CMD_BROWSE
        '
        Me.CMD_BROWSE.Location = New System.Drawing.Point(7, 460)
        Me.CMD_BROWSE.Name = "CMD_BROWSE"
        Me.CMD_BROWSE.Size = New System.Drawing.Size(134, 59)
        Me.CMD_BROWSE.TabIndex = 508
        Me.CMD_BROWSE.Text = "Browse"
        Me.CMD_BROWSE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CMD_BROWSE.UseVisualStyleBackColor = True
        '
        'cmd_export
        '
        Me.cmd_export.BackColor = System.Drawing.Color.Transparent
        Me.cmd_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_export.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_export.ForeColor = System.Drawing.Color.Black
        Me.cmd_export.Image = Global.SmartCard.My.Resources.Resources.excel
        Me.cmd_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_export.Location = New System.Drawing.Point(7, 334)
        Me.cmd_export.Name = "cmd_export"
        Me.cmd_export.Size = New System.Drawing.Size(134, 56)
        Me.cmd_export.TabIndex = 507
        Me.cmd_export.Text = "Export"
        Me.cmd_export.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_export.UseVisualStyleBackColor = False
        '
        'cmd_auth
        '
        Me.cmd_auth.BackColor = System.Drawing.Color.Transparent
        Me.cmd_auth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_auth.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_auth.ForeColor = System.Drawing.Color.Black
        Me.cmd_auth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_auth.Location = New System.Drawing.Point(7, 398)
        Me.cmd_auth.Name = "cmd_auth"
        Me.cmd_auth.Size = New System.Drawing.Size(134, 56)
        Me.cmd_auth.TabIndex = 505
        Me.cmd_auth.Text = "Authorize"
        Me.cmd_auth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_auth.UseVisualStyleBackColor = False
        '
        'cmd_Print
        '
        Me.cmd_Print.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_Print.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Print.ForeColor = System.Drawing.Color.Black
        Me.cmd_Print.Image = Global.SmartCard.My.Resources.Resources.print
        Me.cmd_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Print.Location = New System.Drawing.Point(7, 272)
        Me.cmd_Print.Name = "cmd_Print"
        Me.cmd_Print.Size = New System.Drawing.Size(134, 56)
        Me.cmd_Print.TabIndex = 384
        Me.cmd_Print.Text = "Print[F10]"
        Me.cmd_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Print.UseVisualStyleBackColor = False
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.Black
        Me.cmd_Exit.Image = Global.SmartCard.My.Resources.Resources._Exit
        Me.cmd_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Exit.Location = New System.Drawing.Point(7, 524)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(134, 56)
        Me.cmd_Exit.TabIndex = 382
        Me.cmd_Exit.Text = "Exit[F11]"
        Me.cmd_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Exit.UseVisualStyleBackColor = False
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_Clear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.Black
        Me.cmd_Clear.Image = Global.SmartCard.My.Resources.Resources.Clear
        Me.cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Clear.Location = New System.Drawing.Point(7, 15)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(134, 56)
        Me.cmd_Clear.TabIndex = 378
        Me.cmd_Clear.Text = "Clear[F6]"
        Me.cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Clear.UseVisualStyleBackColor = False
        '
        'Cmd_FREEZE
        '
        Me.Cmd_FREEZE.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_FREEZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_FREEZE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_FREEZE.ForeColor = System.Drawing.Color.Black
        Me.Cmd_FREEZE.Image = Global.SmartCard.My.Resources.Resources.Delete
        Me.Cmd_FREEZE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_FREEZE.Location = New System.Drawing.Point(7, 145)
        Me.Cmd_FREEZE.Name = "Cmd_FREEZE"
        Me.Cmd_FREEZE.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_FREEZE.TabIndex = 380
        Me.Cmd_FREEZE.Text = "Void[F8]"
        Me.Cmd_FREEZE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_FREEZE.UseVisualStyleBackColor = False
        '
        'cmd_Add
        '
        Me.cmd_Add.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_Add.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Add.ForeColor = System.Drawing.Color.Black
        Me.cmd_Add.Image = Global.SmartCard.My.Resources.Resources.save
        Me.cmd_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Add.Location = New System.Drawing.Point(7, 79)
        Me.cmd_Add.Name = "cmd_Add"
        Me.cmd_Add.Size = New System.Drawing.Size(134, 56)
        Me.cmd_Add.TabIndex = 379
        Me.cmd_Add.Text = "Add [F7]"
        Me.cmd_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Add.UseVisualStyleBackColor = False
        '
        'cmd_View
        '
        Me.cmd_View.BackColor = System.Drawing.Color.Transparent
        Me.cmd_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_View.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_View.ForeColor = System.Drawing.Color.Black
        Me.cmd_View.Image = Global.SmartCard.My.Resources.Resources.view
        Me.cmd_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_View.Location = New System.Drawing.Point(7, 208)
        Me.cmd_View.Name = "cmd_View"
        Me.cmd_View.Size = New System.Drawing.Size(134, 56)
        Me.cmd_View.TabIndex = 504
        Me.cmd_View.Text = " View[F9]"
        Me.cmd_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_View.UseVisualStyleBackColor = False
        '
        'chk_excel
        '
        Me.chk_excel.BackColor = System.Drawing.Color.Transparent
        Me.chk_excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_excel.Location = New System.Drawing.Point(910, 678)
        Me.chk_excel.Name = "chk_excel"
        Me.chk_excel.Size = New System.Drawing.Size(72, 24)
        Me.chk_excel.TabIndex = 464
        Me.chk_excel.Text = "EXCEL"
        Me.chk_excel.UseVisualStyleBackColor = False
        Me.chk_excel.Visible = False
        '
        'grp_StockGrndetails
        '
        Me.grp_StockGrndetails.Controls.Add(Me.lbl_StockGrndetails)
        Me.grp_StockGrndetails.Controls.Add(Me.GroupBox5)
        Me.grp_StockGrndetails.Controls.Add(Me.lbl_FromDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.txt_FromDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.Cmd_FromDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.txt_ToDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.Cmd_ToDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.lbl_ToDocno)
        Me.grp_StockGrndetails.Location = New System.Drawing.Point(200, 976)
        Me.grp_StockGrndetails.Name = "grp_StockGrndetails"
        Me.grp_StockGrndetails.Size = New System.Drawing.Size(514, 238)
        Me.grp_StockGrndetails.TabIndex = 498
        Me.grp_StockGrndetails.TabStop = False
        '
        'lbl_StockGrndetails
        '
        Me.lbl_StockGrndetails.BackColor = System.Drawing.Color.Maroon
        Me.lbl_StockGrndetails.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StockGrndetails.ForeColor = System.Drawing.Color.White
        Me.lbl_StockGrndetails.Location = New System.Drawing.Point(0, 7)
        Me.lbl_StockGrndetails.Name = "lbl_StockGrndetails"
        Me.lbl_StockGrndetails.Size = New System.Drawing.Size(520, 25)
        Me.lbl_StockGrndetails.TabIndex = 26
        Me.lbl_StockGrndetails.Text = "GRN CHECKLIST"
        Me.lbl_StockGrndetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Cmd_StockGrnprint)
        Me.GroupBox5.Controls.Add(Me.Cmd_StockGrnView)
        Me.GroupBox5.Controls.Add(Me.Cmd_StockGrnexit)
        Me.GroupBox5.Controls.Add(Me.Cmd_StockGrnClear)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 168)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(496, 56)
        Me.GroupBox5.TabIndex = 25
        Me.GroupBox5.TabStop = False
        '
        'Cmd_StockGrnprint
        '
        Me.Cmd_StockGrnprint.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnprint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnprint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnprint.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnprint.Location = New System.Drawing.Point(256, 16)
        Me.Cmd_StockGrnprint.Name = "Cmd_StockGrnprint"
        Me.Cmd_StockGrnprint.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnprint.TabIndex = 25
        Me.Cmd_StockGrnprint.Text = "Print [F10]"
        Me.Cmd_StockGrnprint.UseVisualStyleBackColor = False
        '
        'Cmd_StockGrnView
        '
        Me.Cmd_StockGrnView.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnView.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnView.Location = New System.Drawing.Point(128, 16)
        Me.Cmd_StockGrnView.Name = "Cmd_StockGrnView"
        Me.Cmd_StockGrnView.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnView.TabIndex = 13
        Me.Cmd_StockGrnView.Text = "View [F9]"
        Me.Cmd_StockGrnView.UseVisualStyleBackColor = False
        '
        'Cmd_StockGrnexit
        '
        Me.Cmd_StockGrnexit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnexit.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnexit.Location = New System.Drawing.Point(376, 16)
        Me.Cmd_StockGrnexit.Name = "Cmd_StockGrnexit"
        Me.Cmd_StockGrnexit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnexit.TabIndex = 15
        Me.Cmd_StockGrnexit.Text = "Exit[F11]"
        Me.Cmd_StockGrnexit.UseVisualStyleBackColor = False
        '
        'Cmd_StockGrnClear
        '
        Me.Cmd_StockGrnClear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnClear.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnClear.Location = New System.Drawing.Point(8, 16)
        Me.Cmd_StockGrnClear.Name = "Cmd_StockGrnClear"
        Me.Cmd_StockGrnClear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnClear.TabIndex = 24
        Me.Cmd_StockGrnClear.Text = "Clear[F6]"
        Me.Cmd_StockGrnClear.UseVisualStyleBackColor = False
        '
        'lbl_FromDocno
        '
        Me.lbl_FromDocno.AutoSize = True
        Me.lbl_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FromDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FromDocno.Location = New System.Drawing.Point(38, 67)
        Me.lbl_FromDocno.Name = "lbl_FromDocno"
        Me.lbl_FromDocno.Size = New System.Drawing.Size(135, 19)
        Me.lbl_FromDocno.TabIndex = 2
        Me.lbl_FromDocno.Text = "FROM GRN NO :"
        '
        'txt_FromDocno
        '
        Me.txt_FromDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_FromDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromDocno.Location = New System.Drawing.Point(184, 64)
        Me.txt_FromDocno.Name = "txt_FromDocno"
        Me.txt_FromDocno.Size = New System.Drawing.Size(208, 29)
        Me.txt_FromDocno.TabIndex = 4
        '
        'Cmd_FromDocno
        '
        Me.Cmd_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_FromDocno.Location = New System.Drawing.Point(392, 64)
        Me.Cmd_FromDocno.Name = "Cmd_FromDocno"
        Me.Cmd_FromDocno.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_FromDocno.TabIndex = 38
        Me.Cmd_FromDocno.UseVisualStyleBackColor = False
        '
        'txt_ToDocno
        '
        Me.txt_ToDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_ToDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ToDocno.Location = New System.Drawing.Point(184, 112)
        Me.txt_ToDocno.Name = "txt_ToDocno"
        Me.txt_ToDocno.Size = New System.Drawing.Size(208, 29)
        Me.txt_ToDocno.TabIndex = 5
        '
        'Cmd_ToDocno
        '
        Me.Cmd_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_ToDocno.Location = New System.Drawing.Point(392, 112)
        Me.Cmd_ToDocno.Name = "Cmd_ToDocno"
        Me.Cmd_ToDocno.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_ToDocno.TabIndex = 39
        Me.Cmd_ToDocno.UseVisualStyleBackColor = False
        '
        'lbl_ToDocno
        '
        Me.lbl_ToDocno.AutoSize = True
        Me.lbl_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ToDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ToDocno.Location = New System.Drawing.Point(64, 114)
        Me.lbl_ToDocno.Name = "lbl_ToDocno"
        Me.lbl_ToDocno.Size = New System.Drawing.Size(108, 19)
        Me.lbl_ToDocno.TabIndex = 3
        Me.lbl_ToDocno.Text = "TO GRN NO :"
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(186, 81)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(329, 18)
        Me.lbl_Heading.TabIndex = 489
        Me.lbl_Heading.Text = "QUOTATION INVITATION FOR WORK ORDER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Grndate
        '
        Me.lbl_Grndate.AutoSize = True
        Me.lbl_Grndate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Grndate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grndate.Location = New System.Drawing.Point(425, 104)
        Me.lbl_Grndate.Name = "lbl_Grndate"
        Me.lbl_Grndate.Size = New System.Drawing.Size(80, 15)
        Me.lbl_Grndate.TabIndex = 492
        Me.lbl_Grndate.Text = "INDENT DATE"
        Me.lbl_Grndate.Visible = False
        '
        'lbl_Grnno
        '
        Me.lbl_Grnno.AutoSize = True
        Me.lbl_Grnno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Grnno.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grnno.Location = New System.Drawing.Point(6, 102)
        Me.lbl_Grnno.Name = "lbl_Grnno"
        Me.lbl_Grnno.Size = New System.Drawing.Size(84, 15)
        Me.lbl_Grnno.TabIndex = 491
        Me.lbl_Grnno.Text = "DEPARTMENT"
        Me.lbl_Grnno.Visible = False
        '
        'dtp_Indentdate
        '
        Me.dtp_Indentdate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Indentdate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_Indentdate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_Indentdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Indentdate.Enabled = False
        Me.dtp_Indentdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Indentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Indentdate.Location = New System.Drawing.Point(553, 102)
        Me.dtp_Indentdate.Name = "dtp_Indentdate"
        Me.dtp_Indentdate.Size = New System.Drawing.Size(89, 21)
        Me.dtp_Indentdate.TabIndex = 484
        Me.dtp_Indentdate.Visible = False
        '
        'lbl_Grn
        '
        Me.lbl_Grn.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Grn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grn.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Grn.Location = New System.Drawing.Point(376, 596)
        Me.lbl_Grn.Name = "lbl_Grn"
        Me.lbl_Grn.Size = New System.Drawing.Size(160, 24)
        Me.lbl_Grn.TabIndex = 495
        Me.lbl_Grn.Visible = False
        '
        'cbo_Storelocation
        '
        Me.cbo_Storelocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Storelocation.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Storelocation.Location = New System.Drawing.Point(760, 976)
        Me.cbo_Storelocation.Name = "cbo_Storelocation"
        Me.cbo_Storelocation.Size = New System.Drawing.Size(192, 23)
        Me.cbo_Storelocation.TabIndex = 488
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(499, 51)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(312, 25)
        Me.lbl_Freeze.TabIndex = 496
        Me.lbl_Freeze.Text = "Record Void  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 976)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 128)
        Me.GroupBox1.TabIndex = 497
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.cmdRoundoff)
        Me.GroupBox2.Controls.Add(Me.OptNearest)
        Me.GroupBox2.Controls.Add(Me.OptNone)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(264, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 88)
        Me.GroupBox2.TabIndex = 353
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rounded Off"
        '
        'cmdRoundoff
        '
        Me.cmdRoundoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRoundoff.ForeColor = System.Drawing.Color.Blue
        Me.cmdRoundoff.Location = New System.Drawing.Point(136, 16)
        Me.cmdRoundoff.Name = "cmdRoundoff"
        Me.cmdRoundoff.Size = New System.Drawing.Size(56, 39)
        Me.cmdRoundoff.TabIndex = 2
        Me.cmdRoundoff.Text = "Round Off"
        '
        'OptNearest
        '
        Me.OptNearest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptNearest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptNearest.Location = New System.Drawing.Point(24, 44)
        Me.OptNearest.Name = "OptNearest"
        Me.OptNearest.Size = New System.Drawing.Size(85, 16)
        Me.OptNearest.TabIndex = 2
        Me.OptNearest.Text = "Nearest Rs"
        '
        'OptNone
        '
        Me.OptNone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptNone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptNone.Location = New System.Drawing.Point(24, 18)
        Me.OptNone.Name = "OptNone"
        Me.OptNone.Size = New System.Drawing.Size(88, 16)
        Me.OptNone.TabIndex = 1
        Me.OptNone.Text = "None"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdValueby)
        Me.GroupBox3.Controls.Add(Me.OptPercentage)
        Me.GroupBox3.Controls.Add(Me.OptValue)
        Me.GroupBox3.Controls.Add(Me.txtChangeValue)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(8, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 88)
        Me.GroupBox3.TabIndex = 352
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Discount Amount"
        '
        'cmdValueby
        '
        Me.cmdValueby.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdValueby.ForeColor = System.Drawing.Color.Blue
        Me.cmdValueby.Location = New System.Drawing.Point(191, 16)
        Me.cmdValueby.Name = "cmdValueby"
        Me.cmdValueby.Size = New System.Drawing.Size(48, 40)
        Me.cmdValueby.TabIndex = 3
        Me.cmdValueby.Text = "Value Chg"
        '
        'OptPercentage
        '
        Me.OptPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptPercentage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptPercentage.Location = New System.Drawing.Point(10, 56)
        Me.OptPercentage.Name = "OptPercentage"
        Me.OptPercentage.Size = New System.Drawing.Size(87, 16)
        Me.OptPercentage.TabIndex = 2
        Me.OptPercentage.Text = "Percentage"
        '
        'OptValue
        '
        Me.OptValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptValue.Location = New System.Drawing.Point(10, 24)
        Me.OptValue.Name = "OptValue"
        Me.OptValue.Size = New System.Drawing.Size(80, 16)
        Me.OptValue.TabIndex = 1
        Me.OptValue.Text = "Value"
        '
        'txtChangeValue
        '
        Me.txtChangeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChangeValue.Location = New System.Drawing.Point(100, 56)
        Me.txtChangeValue.MaxLength = 10
        Me.txtChangeValue.Name = "txtChangeValue"
        Me.txtChangeValue.Size = New System.Drawing.Size(92, 21)
        Me.txtChangeValue.TabIndex = 3
        '
        'grp_Grngroup1
        '
        Me.grp_Grngroup1.BackColor = System.Drawing.Color.Transparent
        Me.grp_Grngroup1.Controls.Add(Me.CMB_QUOTTYPE)
        Me.grp_Grngroup1.Controls.Add(Me.PictureBox3)
        Me.grp_Grngroup1.Controls.Add(Me.Label4)
        Me.grp_Grngroup1.Controls.Add(Me.DTP_QTODATE)
        Me.grp_Grngroup1.Controls.Add(Me.cmd_qutnohelp)
        Me.grp_Grngroup1.Controls.Add(Me.TXT_QUOTNO)
        Me.grp_Grngroup1.Controls.Add(Me.PictureBox1)
        Me.grp_Grngroup1.Controls.Add(Me.Label12)
        Me.grp_Grngroup1.Controls.Add(Me.Label13)
        Me.grp_Grngroup1.Controls.Add(Me.lbl_Billterms)
        Me.grp_Grngroup1.Controls.Add(Me.DTP_DOCDATE)
        Me.grp_Grngroup1.Controls.Add(Me.lbl_Suppliercode)
        Me.grp_Grngroup1.Controls.Add(Me.txt_IndentNo)
        Me.grp_Grngroup1.Controls.Add(Me.Label3)
        Me.grp_Grngroup1.Controls.Add(Me.lbl_Grnno)
        Me.grp_Grngroup1.Controls.Add(Me.PictureBox2)
        Me.grp_Grngroup1.Controls.Add(Me.txt_storecode)
        Me.grp_Grngroup1.Controls.Add(Me.Label16)
        Me.grp_Grngroup1.Controls.Add(Me.cmd_storecode)
        Me.grp_Grngroup1.Controls.Add(Me.lbl_Grndate)
        Me.grp_Grngroup1.Controls.Add(Me.txt_storeDesc)
        Me.grp_Grngroup1.Controls.Add(Me.dtp_Indentdate)
        Me.grp_Grngroup1.Controls.Add(Me.cmd_indentnoHelp)
        Me.grp_Grngroup1.Location = New System.Drawing.Point(181, 106)
        Me.grp_Grngroup1.Name = "grp_Grngroup1"
        Me.grp_Grngroup1.Size = New System.Drawing.Size(680, 104)
        Me.grp_Grngroup1.TabIndex = 490
        Me.grp_Grngroup1.TabStop = False
        '
        'CMB_QUOTTYPE
        '
        Me.CMB_QUOTTYPE.FormattingEnabled = True
        Me.CMB_QUOTTYPE.Items.AddRange(New Object() {"WORK ORDER", "HIRE ORDER"})
        Me.CMB_QUOTTYPE.Location = New System.Drawing.Point(115, 12)
        Me.CMB_QUOTTYPE.Name = "CMB_QUOTTYPE"
        Me.CMB_QUOTTYPE.Size = New System.Drawing.Size(155, 23)
        Me.CMB_QUOTTYPE.TabIndex = 523
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(513, 35)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox3.TabIndex = 522
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(423, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 521
        Me.Label4.Text = "QUO. DATE"
        '
        'DTP_QTODATE
        '
        Me.DTP_QTODATE.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_QTODATE.CalendarMonthBackground = System.Drawing.Color.White
        Me.DTP_QTODATE.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.DTP_QTODATE.CustomFormat = "dd/MM/yyyy"
        Me.DTP_QTODATE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_QTODATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_QTODATE.Location = New System.Drawing.Point(552, 39)
        Me.DTP_QTODATE.Name = "DTP_QTODATE"
        Me.DTP_QTODATE.Size = New System.Drawing.Size(92, 21)
        Me.DTP_QTODATE.TabIndex = 520
        '
        'cmd_qutnohelp
        '
        Me.cmd_qutnohelp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_qutnohelp.Image = CType(resources.GetObject("cmd_qutnohelp.Image"), System.Drawing.Image)
        Me.cmd_qutnohelp.Location = New System.Drawing.Point(245, 39)
        Me.cmd_qutnohelp.Name = "cmd_qutnohelp"
        Me.cmd_qutnohelp.Size = New System.Drawing.Size(24, 26)
        Me.cmd_qutnohelp.TabIndex = 519
        '
        'TXT_QUOTNO
        '
        Me.TXT_QUOTNO.BackColor = System.Drawing.Color.Wheat
        Me.TXT_QUOTNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_QUOTNO.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_QUOTNO.Location = New System.Drawing.Point(115, 41)
        Me.TXT_QUOTNO.MaxLength = 50
        Me.TXT_QUOTNO.Name = "TXT_QUOTNO"
        Me.TXT_QUOTNO.Size = New System.Drawing.Size(128, 21)
        Me.TXT_QUOTNO.TabIndex = 518
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(514, 67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 510
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 15)
        Me.Label12.TabIndex = 482
        Me.Label12.Text = "QUOT.TYPE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(423, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 15)
        Me.Label13.TabIndex = 481
        Me.Label13.Text = "DOC DATE"
        '
        'DTP_DOCDATE
        '
        Me.DTP_DOCDATE.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_DOCDATE.CalendarMonthBackground = System.Drawing.Color.White
        Me.DTP_DOCDATE.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.DTP_DOCDATE.CustomFormat = "dd/MM/yyyy"
        Me.DTP_DOCDATE.Enabled = False
        Me.DTP_DOCDATE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP_DOCDATE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_DOCDATE.Location = New System.Drawing.Point(552, 71)
        Me.DTP_DOCDATE.Name = "DTP_DOCDATE"
        Me.DTP_DOCDATE.Size = New System.Drawing.Size(92, 21)
        Me.DTP_DOCDATE.TabIndex = 479
        '
        'txt_IndentNo
        '
        Me.txt_IndentNo.BackColor = System.Drawing.Color.Wheat
        Me.txt_IndentNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_IndentNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_IndentNo.Location = New System.Drawing.Point(113, 72)
        Me.txt_IndentNo.MaxLength = 50
        Me.txt_IndentNo.Name = "txt_IndentNo"
        Me.txt_IndentNo.Size = New System.Drawing.Size(128, 21)
        Me.txt_IndentNo.TabIndex = 483
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(272, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 24)
        Me.Label3.TabIndex = 474
        Me.Label3.Text = "F4"
        Me.Label3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(515, 98)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox2.TabIndex = 473
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'txt_storecode
        '
        Me.txt_storecode.BackColor = System.Drawing.Color.Wheat
        Me.txt_storecode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_storecode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_storecode.Location = New System.Drawing.Point(113, 100)
        Me.txt_storecode.MaxLength = 50
        Me.txt_storecode.Name = "txt_storecode"
        Me.txt_storecode.ReadOnly = True
        Me.txt_storecode.Size = New System.Drawing.Size(48, 21)
        Me.txt_storecode.TabIndex = 485
        Me.txt_storecode.Visible = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(191, 99)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 24)
        Me.Label16.TabIndex = 472
        Me.Label16.Text = "F4"
        Me.Label16.Visible = False
        '
        'cmd_storecode
        '
        Me.cmd_storecode.Enabled = False
        Me.cmd_storecode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_storecode.Image = CType(resources.GetObject("cmd_storecode.Image"), System.Drawing.Image)
        Me.cmd_storecode.Location = New System.Drawing.Point(165, 95)
        Me.cmd_storecode.Name = "cmd_storecode"
        Me.cmd_storecode.Size = New System.Drawing.Size(24, 26)
        Me.cmd_storecode.TabIndex = 502
        Me.cmd_storecode.Visible = False
        '
        'txt_storeDesc
        '
        Me.txt_storeDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_storeDesc.Enabled = False
        Me.txt_storeDesc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_storeDesc.Location = New System.Drawing.Point(225, 101)
        Me.txt_storeDesc.MaxLength = 50
        Me.txt_storeDesc.Name = "txt_storeDesc"
        Me.txt_storeDesc.ReadOnly = True
        Me.txt_storeDesc.Size = New System.Drawing.Size(193, 21)
        Me.txt_storeDesc.TabIndex = 487
        Me.txt_storeDesc.Visible = False
        '
        'cmd_indentnoHelp
        '
        Me.cmd_indentnoHelp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_indentnoHelp.Image = CType(resources.GetObject("cmd_indentnoHelp.Image"), System.Drawing.Image)
        Me.cmd_indentnoHelp.Location = New System.Drawing.Point(243, 68)
        Me.cmd_indentnoHelp.Name = "cmd_indentnoHelp"
        Me.cmd_indentnoHelp.Size = New System.Drawing.Size(24, 26)
        Me.cmd_indentnoHelp.TabIndex = 503
        '
        'TXT_DOCNO
        '
        Me.TXT_DOCNO.BackColor = System.Drawing.Color.Wheat
        Me.TXT_DOCNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_DOCNO.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DOCNO.Location = New System.Drawing.Point(18, 143)
        Me.TXT_DOCNO.MaxLength = 50
        Me.TXT_DOCNO.Name = "TXT_DOCNO"
        Me.TXT_DOCNO.ReadOnly = True
        Me.TXT_DOCNO.Size = New System.Drawing.Size(128, 21)
        Me.TXT_DOCNO.TabIndex = 480
        Me.TXT_DOCNO.Visible = False
        '
        'cmd_fromStorecodeHelp
        '
        Me.cmd_fromStorecodeHelp.Enabled = False
        Me.cmd_fromStorecodeHelp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_fromStorecodeHelp.Image = CType(resources.GetObject("cmd_fromStorecodeHelp.Image"), System.Drawing.Image)
        Me.cmd_fromStorecodeHelp.Location = New System.Drawing.Point(126, 256)
        Me.cmd_fromStorecodeHelp.Name = "cmd_fromStorecodeHelp"
        Me.cmd_fromStorecodeHelp.Size = New System.Drawing.Size(24, 26)
        Me.cmd_fromStorecodeHelp.TabIndex = 508
        Me.cmd_fromStorecodeHelp.Visible = False
        '
        'TXT_FROMSTORECODE
        '
        Me.TXT_FROMSTORECODE.BackColor = System.Drawing.Color.Wheat
        Me.TXT_FROMSTORECODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_FROMSTORECODE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FROMSTORECODE.Location = New System.Drawing.Point(75, 261)
        Me.TXT_FROMSTORECODE.MaxLength = 50
        Me.TXT_FROMSTORECODE.Name = "TXT_FROMSTORECODE"
        Me.TXT_FROMSTORECODE.ReadOnly = True
        Me.TXT_FROMSTORECODE.Size = New System.Drawing.Size(48, 21)
        Me.TXT_FROMSTORECODE.TabIndex = 486
        Me.TXT_FROMSTORECODE.Visible = False
        '
        'txt_FromStorename
        '
        Me.txt_FromStorename.BackColor = System.Drawing.Color.Wheat
        Me.txt_FromStorename.Enabled = False
        Me.txt_FromStorename.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromStorename.Location = New System.Drawing.Point(18, 299)
        Me.txt_FromStorename.MaxLength = 50
        Me.txt_FromStorename.Name = "txt_FromStorename"
        Me.txt_FromStorename.ReadOnly = True
        Me.txt_FromStorename.Size = New System.Drawing.Size(160, 21)
        Me.txt_FromStorename.TabIndex = 507
        Me.txt_FromStorename.Visible = False
        '
        'cbo_type
        '
        Me.cbo_type.BackColor = System.Drawing.Color.Wheat
        Me.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_type.Items.AddRange(New Object() {"REVENUE", "CAPITAL", "FINISHED GOOD", "INTERMEDIATE GOOD", "RAW MATERIAL", "SERVICE"})
        Me.cbo_type.Location = New System.Drawing.Point(6, 184)
        Me.cbo_type.Name = "cbo_type"
        Me.cbo_type.Size = New System.Drawing.Size(129, 28)
        Me.cbo_type.TabIndex = 516
        Me.cbo_type.Visible = False
        '
        'txt_Totalamount
        '
        Me.txt_Totalamount.BackColor = System.Drawing.Color.Wheat
        Me.txt_Totalamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Totalamount.Enabled = False
        Me.txt_Totalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Totalamount.Location = New System.Drawing.Point(59, 404)
        Me.txt_Totalamount.MaxLength = 15
        Me.txt_Totalamount.Name = "txt_Totalamount"
        Me.txt_Totalamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_Totalamount.Size = New System.Drawing.Size(104, 26)
        Me.txt_Totalamount.TabIndex = 506
        Me.txt_Totalamount.Visible = False
        '
        'CHK_WAR
        '
        Me.CHK_WAR.BackColor = System.Drawing.Color.Transparent
        Me.CHK_WAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_WAR.Location = New System.Drawing.Point(48, 40)
        Me.CHK_WAR.Name = "CHK_WAR"
        Me.CHK_WAR.Size = New System.Drawing.Size(64, 24)
        Me.CHK_WAR.TabIndex = 515
        Me.CHK_WAR.Text = "WAR"
        Me.CHK_WAR.UseVisualStyleBackColor = False
        Me.CHK_WAR.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.txt_Remarks)
        Me.GroupBox4.Controls.Add(Me.lbl_Remarks)
        Me.GroupBox4.Location = New System.Drawing.Point(181, 642)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(680, 47)
        Me.GroupBox4.TabIndex = 514
        Me.GroupBox4.TabStop = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(576, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 24)
        Me.Label20.TabIndex = 477
        Me.Label20.Text = "ALT+ R"
        '
        'txt_Remarks
        '
        Me.txt_Remarks.BackColor = System.Drawing.Color.White
        Me.txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Remarks.Location = New System.Drawing.Point(89, 16)
        Me.txt_Remarks.MaxLength = 200
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(481, 23)
        Me.txt_Remarks.TabIndex = 14
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AutoSize = True
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.Location = New System.Drawing.Point(16, 16)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(70, 15)
        Me.lbl_Remarks.TabIndex = 43
        Me.lbl_Remarks.Text = "REMARKS :"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(639, 556)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 20)
        Me.Label10.TabIndex = 513
        Me.Label10.Text = "[F3 DELETE A ROW IN GRID]"
        '
        'Chk_item
        '
        Me.Chk_item.BackColor = System.Drawing.Color.Transparent
        Me.Chk_item.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_item.Location = New System.Drawing.Point(32, 584)
        Me.Chk_item.Name = "Chk_item"
        Me.Chk_item.Size = New System.Drawing.Size(120, 24)
        Me.Chk_item.TabIndex = 512
        Me.Chk_item.Text = "FooterUpdation"
        Me.Chk_item.UseVisualStyleBackColor = False
        Me.Chk_item.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(464, -112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 90)
        Me.Button1.TabIndex = 505
        Me.Button1.Text = "Print[F10]"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'grp_Billingdetails
        '
        Me.grp_Billingdetails.BackColor = System.Drawing.SystemColors.Control
        Me.grp_Billingdetails.Controls.Add(Me.ssgrid_billdetails)
        Me.grp_Billingdetails.Controls.Add(Me.Label2)
        Me.grp_Billingdetails.Location = New System.Drawing.Point(0, 976)
        Me.grp_Billingdetails.Name = "grp_Billingdetails"
        Me.grp_Billingdetails.Size = New System.Drawing.Size(664, 310)
        Me.grp_Billingdetails.TabIndex = 499
        Me.grp_Billingdetails.TabStop = False
        '
        'ssgrid_billdetails
        '
        Me.ssgrid_billdetails.DataSource = Nothing
        Me.ssgrid_billdetails.Location = New System.Drawing.Point(24, 48)
        Me.ssgrid_billdetails.Name = "ssgrid_billdetails"
        Me.ssgrid_billdetails.OcxState = CType(resources.GetObject("ssgrid_billdetails.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid_billdetails.Size = New System.Drawing.Size(608, 248)
        Me.ssgrid_billdetails.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(661, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "BILLING DETAILS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ssgrid
        '
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(190, 218)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(792, 221)
        Me.ssgrid.TabIndex = 501
        '
        'grp_Excisedetails
        '
        Me.grp_Excisedetails.Controls.Add(Me.Label5)
        Me.grp_Excisedetails.Controls.Add(Me.txt_Trucknumber)
        Me.grp_Excisedetails.Controls.Add(Me.dtp_Stockindate)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Trucknumber)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Stockindate)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Excisepassno)
        Me.grp_Excisedetails.Controls.Add(Me.txt_Excisepassno)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Excisepassdate)
        Me.grp_Excisedetails.Controls.Add(Me.dtp_Excisepassdate)
        Me.grp_Excisedetails.Location = New System.Drawing.Point(192, 976)
        Me.grp_Excisedetails.Name = "grp_Excisedetails"
        Me.grp_Excisedetails.Size = New System.Drawing.Size(512, 206)
        Me.grp_Excisedetails.TabIndex = 500
        Me.grp_Excisedetails.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(506, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "EXCISE DETAILS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Trucknumber
        '
        Me.txt_Trucknumber.BackColor = System.Drawing.Color.White
        Me.txt_Trucknumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Trucknumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Trucknumber.Location = New System.Drawing.Point(240, 168)
        Me.txt_Trucknumber.MaxLength = 15
        Me.txt_Trucknumber.Name = "txt_Trucknumber"
        Me.txt_Trucknumber.Size = New System.Drawing.Size(216, 26)
        Me.txt_Trucknumber.TabIndex = 3
        '
        'dtp_Stockindate
        '
        Me.dtp_Stockindate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Stockindate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Stockindate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Stockindate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Stockindate.Location = New System.Drawing.Point(240, 48)
        Me.dtp_Stockindate.Name = "dtp_Stockindate"
        Me.dtp_Stockindate.Size = New System.Drawing.Size(216, 26)
        Me.dtp_Stockindate.TabIndex = 0
        '
        'lbl_Trucknumber
        '
        Me.lbl_Trucknumber.AutoSize = True
        Me.lbl_Trucknumber.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Trucknumber.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Trucknumber.Location = New System.Drawing.Point(64, 168)
        Me.lbl_Trucknumber.Name = "lbl_Trucknumber"
        Me.lbl_Trucknumber.Size = New System.Drawing.Size(165, 17)
        Me.lbl_Trucknumber.TabIndex = 7
        Me.lbl_Trucknumber.Text = "TRUCK NUMBER      :"
        '
        'lbl_Stockindate
        '
        Me.lbl_Stockindate.AutoSize = True
        Me.lbl_Stockindate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Stockindate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Stockindate.Location = New System.Drawing.Point(64, 48)
        Me.lbl_Stockindate.Name = "lbl_Stockindate"
        Me.lbl_Stockindate.Size = New System.Drawing.Size(164, 17)
        Me.lbl_Stockindate.TabIndex = 4
        Me.lbl_Stockindate.Text = "STOCK IN DATE        :"
        '
        'lbl_Excisepassno
        '
        Me.lbl_Excisepassno.AutoSize = True
        Me.lbl_Excisepassno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Excisepassno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Excisepassno.Location = New System.Drawing.Point(64, 88)
        Me.lbl_Excisepassno.Name = "lbl_Excisepassno"
        Me.lbl_Excisepassno.Size = New System.Drawing.Size(162, 17)
        Me.lbl_Excisepassno.TabIndex = 5
        Me.lbl_Excisepassno.Text = "EXCISE PASS NO       :"
        '
        'txt_Excisepassno
        '
        Me.txt_Excisepassno.BackColor = System.Drawing.Color.White
        Me.txt_Excisepassno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Excisepassno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Excisepassno.Location = New System.Drawing.Point(240, 88)
        Me.txt_Excisepassno.MaxLength = 15
        Me.txt_Excisepassno.Name = "txt_Excisepassno"
        Me.txt_Excisepassno.Size = New System.Drawing.Size(216, 26)
        Me.txt_Excisepassno.TabIndex = 1
        '
        'lbl_Excisepassdate
        '
        Me.lbl_Excisepassdate.AutoSize = True
        Me.lbl_Excisepassdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Excisepassdate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Excisepassdate.Location = New System.Drawing.Point(64, 128)
        Me.lbl_Excisepassdate.Name = "lbl_Excisepassdate"
        Me.lbl_Excisepassdate.Size = New System.Drawing.Size(164, 17)
        Me.lbl_Excisepassdate.TabIndex = 6
        Me.lbl_Excisepassdate.Text = "EXCISE PASS DATE   :"
        '
        'dtp_Excisepassdate
        '
        Me.dtp_Excisepassdate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Excisepassdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Excisepassdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Excisepassdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Excisepassdate.Location = New System.Drawing.Point(240, 128)
        Me.dtp_Excisepassdate.Name = "dtp_Excisepassdate"
        Me.dtp_Excisepassdate.Size = New System.Drawing.Size(216, 26)
        Me.dtp_Excisepassdate.TabIndex = 2
        '
        'grp_footer
        '
        Me.grp_footer.BackColor = System.Drawing.Color.Transparent
        Me.grp_footer.Controls.Add(Me.Txt_signature)
        Me.grp_footer.Controls.Add(Me.Txt_footer)
        Me.grp_footer.Controls.Add(Me.Label9)
        Me.grp_footer.Controls.Add(Me.Label7)
        Me.grp_footer.Controls.Add(Me.Label8)
        Me.grp_footer.Location = New System.Drawing.Point(218, 283)
        Me.grp_footer.Name = "grp_footer"
        Me.grp_footer.Size = New System.Drawing.Size(538, 80)
        Me.grp_footer.TabIndex = 511
        Me.grp_footer.TabStop = False
        '
        'Txt_signature
        '
        Me.Txt_signature.Location = New System.Drawing.Point(120, 48)
        Me.Txt_signature.MaxLength = 79
        Me.Txt_signature.Name = "Txt_signature"
        Me.Txt_signature.Size = New System.Drawing.Size(696, 21)
        Me.Txt_signature.TabIndex = 441
        '
        'Txt_footer
        '
        Me.Txt_footer.Location = New System.Drawing.Point(120, 16)
        Me.Txt_footer.MaxLength = 150
        Me.Txt_footer.Name = "Txt_footer"
        Me.Txt_footer.Size = New System.Drawing.Size(696, 21)
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
        'spssgrid
        '
        Me.spssgrid.DataSource = Nothing
        Me.spssgrid.Location = New System.Drawing.Point(186, 469)
        Me.spssgrid.Name = "spssgrid"
        Me.spssgrid.OcxState = CType(resources.GetObject("spssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.spssgrid.Size = New System.Drawing.Size(451, 165)
        Me.spssgrid.TabIndex = 526
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.cmb_invitedby)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.dtp_invitdate)
        Me.GroupBox6.Location = New System.Drawing.Point(642, 455)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(219, 81)
        Me.GroupBox6.TabIndex = 527
        Me.GroupBox6.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Location = New System.Drawing.Point(181, 453)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(461, 189)
        Me.GroupBox7.TabIndex = 528
        Me.GroupBox7.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Location = New System.Drawing.Point(181, 203)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(675, 251)
        Me.GroupBox8.TabIndex = 529
        Me.GroupBox8.TabStop = False
        '
        'QUOTATIONINVITATIONFORWOANDHO
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.BackgroundImage = Global.SmartCard.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.spssgrid)
        Me.Controls.Add(Me.chk_excel)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.TXT_DOCNO)
        Me.Controls.Add(Me.txt_Totalamount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.grp_StockGrndetails)
        Me.Controls.Add(Me.lbl_Grn)
        Me.Controls.Add(Me.cbo_Storelocation)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbo_type)
        Me.Controls.Add(Me.CHK_WAR)
        Me.Controls.Add(Me.cmd_fromStorecodeHelp)
        Me.Controls.Add(Me.txt_FromStorename)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TXT_FROMSTORECODE)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Chk_item)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grp_Billingdetails)
        Me.Controls.Add(Me.ssgrid)
        Me.Controls.Add(Me.grp_Excisedetails)
        Me.Controls.Add(Me.grp_Grngroup1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.grp_footer)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "QUOTATIONINVITATIONFORWOANDHO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUOTATIONINVITATIONFORWOANDHO"
        Me.frmbut.ResumeLayout(False)
        Me.grp_StockGrndetails.ResumeLayout(False)
        Me.grp_StockGrndetails.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grp_Grngroup1.ResumeLayout(False)
        Me.grp_Grngroup1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grp_Billingdetails.ResumeLayout(False)
        CType(Me.ssgrid_billdetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Excisedetails.ResumeLayout(False)
        Me.grp_Excisedetails.PerformLayout()
        Me.grp_footer.ResumeLayout(False)
        Me.grp_footer.PerformLayout()
        CType(Me.spssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Public i, TotalCount, billrow As Integer
    Dim GRNno(), QU_NO(), sqlstring, Gr As String
    Dim gconnection As New GlobalClass
    Dim vsearch, vitem, accountcode, sstr As String
    Dim docno, transferdocno, doctype, docno1() As String
    Public Listbox As System.Windows.Forms.ListBox
    Dim boolchk, costcentercodestatus, slcodestatus, blnchkupdateclsbal, Dupchk As Boolean
    Dim CATEGORY As String

    Private Sub QUOTATIONINVITATIONFORWOANDHO_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                Call cmd_Clear_Click(cmd_Clear, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                '  txt_Docno.Text = ""
                'txt_Docno.Focus()
                Exit Sub
            ElseIf e.KeyCode = Keys.F8 Then
                Call Cmd_FREEZE_Click(Cmd_FREEZE, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F7 Then
                Call cmd_Add_Click(cmd_Add, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F9 Then
                Call Cmd_View_Click(cmd_View, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F10 Then
                Call cmd_print_Click(cmd_Print, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                'If grp_Stockissue.Top = 176 Then
                '    grp_Stockissue.Top = 1000
                '    Cmd_View.Focus()
                '    Exit Sub
                'Else
                Call cmd_Exit_Click(cmd_Exit, e)
                ' Exit Sub
            End If
            If e.Alt = True And e.KeyCode = Keys.R Then
                Me.txt_Remarks.Focus()
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.A Then
                '  Me.txt_Totalamount.Focus()
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.S Then
                Me.spssgrid.Focus()
                Me.spssgrid.SetActiveCell(1, 1)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub QUOTATIONINVITATIONFORWOANDHO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Resize_Form()
        GroupBox8.Controls.Add(ssgrid)
        ssgrid.Location = New Point(40, 7)
        GroupBox7.Controls.Add(spssgrid)
        spssgrid.Location = New Point(50, 7)
        'ssgrid.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width * 18.35) / 100, (Screen.PrimaryScreen.WorkingArea.Height * 35.55) / 100)
        'spssgrid.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width * 18.35) / 100, (Screen.PrimaryScreen.WorkingArea.Height * 63.89) / 100)
        cbo_type.SelectedIndex = 0
        CMB_QUOTTYPE.SelectedIndex = 0
        ' Call FOOTER()
        ' grp_footer.Visible = False
        Call autogenerate()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        If Not String.IsNullOrEmpty(gAuditFlg) Then
            If gAuditFlg.ToUpper = "Y" Then
                Me.cmd_Add.Enabled = False
                Me.Cmd_FREEZE.Enabled = False
            End If
        End If
        '  DTP_QTODATE.Value = Today.Date
        CMB_QUOTTYPE.SelectedIndex = 0
        If gindentno = "Y" Then
            txt_storecode.Show()
            txt_storecode.Focus()
            Me.cmd_Clear_Click(sender, e)
        Else
            txt_IndentNo.Select()
        End If
    End Sub
    Public Function FOOTER()
        sqlstring = "SELECT isnull(UPDFOOTER,'') as UPDFOOTER,isnull(UPDsign,'') as UPDsign FROM PO_INDENTHDR WHERE  AUTOID IN (SELECT MAX(AUTOID) FROM PO_INDENTHDR )"
        gconnection.getDataSet(sqlstring, "INVENTORY_INDENTHDR")
        If gdataset.Tables("INVENTORY_INDENTHDR").Rows.Count > 0 Then
            Txt_footer.Text = Trim(gdataset.Tables("INVENTORY_INDENTHDR").Rows(0).Item("UPDFOOTER"))
            Txt_signature.Text = Trim(gdataset.Tables("INVENTORY_INDENTHDR").Rows(0).Item("UPdsign"))
        End If
    End Function
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='PURCHASE ORDER' AND MODULENAME LIKE 'Enquiry Upload%' ORDER BY RIGHTS"
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
        Me.cmd_auth.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Me.cmd_auth.Enabled = True
                    Me.cmd_export.Enabled = True
                    Me.cmd_Print.Enabled = True
                    Exit Sub
                End If

                If Right(x) = "D" Then
                    Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.cmd_View.Enabled = True
                    'Me.cmd_rpt.Enabled = True
                    Me.cmd_export.Enabled = True
                End If
                If Right(x) = "U" Then
                    Me.cmd_auth.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.cmd_Print.Enabled = True
                End If
            Next
        End If


    End Sub
    Private Sub cmd_auth_Click(sender As Object, e As EventArgs) Handles cmd_auth.Click
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
            SSQLSTR2 = " SELECT * FROM po_quationinvitation WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM po_quationinvitation WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE po_quationinvitation set  ", "quotno", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM po_quationinvitation WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM po_quationinvitation WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE po_quationinvitation set  ", "quotno", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            End If
        ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM po_quationinvitation WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM po_quationinvitation WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE po_quationinvitation set  ", "quotno", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                        End If
                    End If
                End If
            Else
                MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub cmd_Clear_Click(sender As Object, e As EventArgs) Handles cmd_Clear.Click
        Try
            Call clearform(Me)
            '  Call FillStore() '''-->Fill Store Desc
            'Call FillMainstore() '''-->Fill Main Store
            Me.DTP_DOCDATE.Value = Format(Now, "dd/MM/yyyy")
            Me.dtp_Indentdate.Value = Format(Now, "dd/MM/yyyy")
            Call FOOTER()
            grp_footer.Visible = False
            TXT_DOCNO.Text = ""
            Call autogenerate()
            txt_IndentNo.Text = ""
            txt_IndentNo.ReadOnly = False
            Me.lbl_Freeze.Visible = False
            '  CMB_QUOTTYPE.SelectedIndex = 0
            Me.lbl_Freeze.Text = "Record Void  On "
            TXT_QUOTNO.ReadOnly = False
            '  cmb_approvedby.SelectedIndex = 0
            ssgrid.ClearRange(1, 1, -1, -1, True)
            spssgrid.ClearRange(1, 1, -1, -1, True)
            Me.Cmd_FREEZE.Text = "Void [F8]"
            Cmd_FREEZE.Enabled = True
            cmd_Add.Text = "Add [F7]"
            txt_storecode.Text = ""
            txt_storeDesc.Text = ""
            txt_Remarks.Text = ""
            ssgrid.SetActiveCell(1, 1)
            'grp_Stockissue.Top = 1000
            cmd_Add.Enabled = True
            Cmd_FREEZE.Enabled = True
            TXT_DOCNO.Enabled = True
            TXT_DOCNO.ReadOnly = False
            txt_IndentNo.ReadOnly = False

            Me.Cmd_FREEZE.Enabled = True
            TXT_FROMSTORECODE.ReadOnly = True
            TXT_FROMSTORECODE.Enabled = True
            'txt_Tostorecode.Enabled = True
            'dtp_Indentdate.Enabled = True
            txt_qty.Enabled = True
            txt_Totalamount.Enabled = True

            ssgrid.Focus()
            ssgrid.SetActiveCell(1, 1)
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            If Not String.IsNullOrEmpty(gAuditFlg) Then
                If gAuditFlg.ToUpper = "Y" Then
                    Me.cmd_Add.Enabled = False
                    Me.Cmd_FREEZE.Enabled = False
                End If
            End If
            Show()
            txt_IndentNo.Focus()
            gPrint = False
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub DOCNO_INDNO_VALIDATE()
        Dim j, i As Integer
        Dim dt As New DataTable
        Dim vString, sqlstring, remarks, SSQL, SSQL1 As String
        Dim vTypeseqno, Clsquantity, vGroupseqno, Totqty, TOTAMT As Double

        'TOTALQTY = 0
        'SSQL = "SELECT SUM(QTY) AS QTY"
        'SSQL = SSQL & " FROM PO_INDENTDET WHERE  INDENT_NO ='" & Trim(Txt_IndentNo.Text) & "'"
        'gconnection.getDataSet(SSQL, "STOCKISSUEHEADER1")
        'If gdataset.Tables("STOCKISSUEHEADER1").Rows.Count > 0 Then
        '    TOTALQTY = Trim(gdataset.Tables("STOCKISSUEHEADER1").Rows(0).Item("QTY"))
        'End If

        'ISSUEQTY = 0
        'SSQL1 = "SELECT SUM(QTY) AS QTY"
        'SSQL1 = SSQL1 & " FROM PO_STOCKINDENTAUTH_DET WHERE  INDENTNO ='" & Trim(Txt_IndentNo.Text) & "'"
        'gconnection.getDataSet(SSQL1, "STOCKISSUEHEADER11")
        'If gdataset.Tables("STOCKISSUEHEADER11").Rows.Count > 0 Then
        '    ISSUEQTY = Trim(gdataset.Tables("STOCKISSUEHEADER11").Rows(0).Item("QTY"))
        'End If

        If Trim(txt_IndentNo.Text) <> "" Then
            Dim VSTRDOCNO As String
            Try
                sqlstring = "SELECT ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE AS DOCDATE,H.INDENTNO INDENTNO, H.INDENTDATE AS INDENTDATE, "
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONNAME,'') AS STORELOCATIONNAME,ISNULL(H.OPSTORELOCATIONCODE,'') AS OPSTORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.OPSTORELOCATIONNAME,'') AS OPSTORELOCATIONNAME,ISNULL(H.TOTALAMT,0) AS TOTALAMT,ISNULL(H.REMARKS,'') AS REMARKS,"
                sqlstring = sqlstring & " ISNULL(H.VOID,'') AS VOID,ISNULL(H.VOIDREASON,'') AS VOIDREASON,ISNULL(H.ADDUSER,'') AS ADDUSER,ADDDATE,ISNULL(H.UPDATEUSER,'') AS UPDATEUSER,UPDATETIME"
                sqlstring = sqlstring & " FROM PO_STOCKINDENTAUTH_HDR AS H WHERE INDENTNO='" & Trim(txt_IndentNo.Text) & "'"
                gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")
                '''************************************************* SELECT RECORD FROM STOCKISSUEHEADER *********************************************''''                
                If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
                    'Cmd_Add.Text = "Update[F7]"
                    Me.TXT_DOCNO.ReadOnly = True
                    VSTRDOCNO = Trim(TXT_DOCNO.Text)
                    TXT_DOCNO.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDETAILS") & "")
                    DTP_DOCDATE.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDATE")), "dd-MM-yyyy")
                    txt_IndentNo.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("INDENTNO") & "")
                    dtp_Indentdate.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("INDENTDATE")), "dd-MM-yyyy")
                    DTP_DOCDATE.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDATE")), "dd-MM-yyyy")
                    'TXT_FROMSTORECODE.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONCODE"))
                    ' txt_FromStorename.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONNAME"))
                    txt_storecode.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONCODE"))
                    txt_storeDesc.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONNAME"))
                    'txt_Tostorecode.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONCODE"))
                    'cbo_Tostore.DropDownStyle = ComboBoxStyle.DropDown
                    '  VSTORECODE = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONCODE"))
                    '  VSTORENAME = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONNAME"))
                    ' cbo_Tostore.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("OPSTORELOCATIONNAME"))
                    ' cbo_Tostore.DropDownStyle = ComboBoxStyle.DropDownList
                    ' txt_Totalamount.Text = Format(Val(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("TOTALAMT")), "0.00")
                    remarks = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("REMARKS"))
                    txt_Remarks.Text = Replace(remarks, "?", "'")
                    If gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("VOID") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("ADDDATE")), "dd-MMM-yyyy")
                        Me.Cmd_FREEZE.Enabled = False
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.Cmd_FREEZE.Enabled = True
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.Cmd_FREEZE.Text = "Void[F8]"
                    End If
                    If Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("VOID")) = "Y" Then
                        cmd_Add.Enabled = False
                        Cmd_FREEZE.Enabled = False
                    End If
                    '''************************************************* SELECT RECORD FROM STOCKISSUEDETAILS *********************************************''''                
                    ' If TOTALQTY <> ISSUEQTY Then
                    Dim strsql As String
                    Dim STRITEMCODE As String
                    sqlstring = "SELECT ISNULL(A.ITEMCODE,'') AS ITEMCODE,ISNULL(A.ITEMNAME,'') AS ITEMNAME,ISNULL(A.UOM,'') AS UOM,(SUM(B.ISSQTY) ) AS QTY,ISNULL(A.RATE,0) AS RATE ,"
                    sqlstring = sqlstring & "( (SUM(B.ISSQTY)) * A.RATE ) AS AMOUNT,ISNULL(A.DBLAMT,0) AS DBLAMT,ISNULL(A.DBLCONV,'') AS DBLCONV,ISNULL(A.HIGHRATIO,0) AS HIGHRATIO,"
                    sqlstring = sqlstring & " ISNULL(A.GROUPCODE,'') AS GROUPCODE,ISNULL(A.SUBGROUPCODE,'') AS SUBGROUPCODE FROM PO_BREAK_ISSUE A, PO_BREAK_INDENT B WHERE   A.INDENTNO='" & Trim(txt_IndentNo.Text) & "' AND "
                    sqlstring = sqlstring & "A.ITEMCODE=B.ITEMCODE AND A.INDENTNO=B.INDENTNO   "
                    sqlstring = sqlstring & " GROUP BY A.itemcode,A.itemname,A.UOM,A.RATE,A.DBLAMT,A.DBLCONV,A.HIGHRATIO,A.GROUPCODE,A.SUBGROUPCODE,A.INDENTNO " ''HAVING (SUM(B.ISSQTY)- SUM(A.ISSQTY)) >0"

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
                            Clsquantity = ClosingQuantity(STRITEMCODE, Trim(TXT_FROMSTORECODE.Text))
                            ssgrid.SetText(13, i, Clsquantity)
                            Totqty = Totqty + Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("qty")), "0.00")
                            TOTAMT = TOTAMT + Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("AMOUNT")), "0.00")
                            j = j + 1
                        Next
                        txt_qty.Text = Totqty
                        txt_Totalamount.Text = TOTAMT
                    End If
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                    If Not String.IsNullOrEmpty(gAuditFlg) Then
                        If gAuditFlg.ToUpper = "Y" Then
                            Me.cmd_Add.Enabled = False
                            Me.Cmd_FREEZE.Enabled = False
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
    Private Sub cmd_indentnoHelp_Click(sender As Object, e As EventArgs) Handles cmd_indentnoHelp.Click
        Try

            gSQLString = "SELECT WOdetails,WOBdate FROM PO_WORKORDERBOOK WHERE "
            M_WhereCondition = " ISNULL(VOID,'')<>'Y' AND OTYPE='" & CMB_QUOTTYPE.Text & "' "
            Dim vform As New ListOperattion1_N
            vform.Field = "WODETAILS,WOBDATE"
            vform.vFormatstring = "       WODETAILS                  |     WOBDATE                                                          "
            vform.vCaption = "ORDER NO HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_IndentNo.Text = Trim(vform.keyfield & "")
                ssgrid.ClearRange(1, 1, -1, -1, True)
                spssgrid.ClearRange(1, 1, -1, -1, True)
                Call txt_IndentNo_Validated(txt_IndentNo, e)
                DTP_DOCDATE.Focus()
                txt_IndentNo.ReadOnly = True
                TXT_QUOTNO.ReadOnly = True
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_IndentNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_IndentNo.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_IndentNo.Text) = "" Then
                    Call cmd_indentnoHelp_Click(cmd_indentnoHelp, e)
                Else
                    txt_IndentNo_Validated(txt_IndentNo, e)
                    spssgrid.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Grnno Key Press " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_IndentNo_Validated(sender As Object, e As EventArgs) Handles txt_IndentNo.Validated
        Try
            Dim Clsquantity, TotAmount, Totqty As Double
            Dim i, j, k As Integer
            Dim SSQL, remark As String

            If Trim(txt_IndentNo.Text) <> "" Then

                sqlstring = " SELECT DOCDETAILS FROM po_quationinvitation WHERE DOCDETAILS='" & txt_IndentNo.Text & "' AND ISNULL(VOID,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "INDENTVAL")
                If gdataset.Tables("INDENTVAL").Rows.Count > 0 Then
                    MessageBox.Show("THIS ORDER HAD BEEN PROCESSED ALREADY")
                    txt_IndentNo.Focus()
                    txt_IndentNo.Text = ""
                    Exit Sub
                End If


                sqlstring = "SELECT  ISNULL(WODETAILS,'') AS WODETAILS,WObDATE,"
                sqlstring = sqlstring & " ISNULL(SUPPLIERCODE,'') AS SUPPLIERCODE,ISNULL(SUPPLIERNAME,'') AS SUPPLIERNAME,ORDERSUBJECT,REQUESTEDBY,APPROVEDBY,REMARKS,VOID,UPDATEDATE"
                sqlstring = sqlstring & " FROM PO_WorkOrderBook"
                sqlstring = sqlstring & " WHERE (WO_NO = '" & Format(Val(txt_IndentNo.Text), "0000") & "'  OR WODETAILS = '" & Trim(txt_IndentNo.Text) & "') AND ISNULL(VOID,'')<>'Y' ORDER BY AUTOID "
                'sqlstring = sqlstring & " and  rtrim(substring(grndetails,5,2)) = '" & Mid(doctype, 1, 2) & "'  and  isnull(GrnType,'')='GRN'"
                gconnection.getDataSet(sqlstring, "PO_WorkOrderBook")
                '        '''************************************************* SELECT record from PO_WorkOrderBook *********************************************''''                
                If gdataset.Tables("PO_WorkOrderBook").Rows.Count > 0 Then
                    cmd_Add.Text = "Update[F7]"
                    ' Cmd_Add.Enabled = False
                    Me.txt_IndentNo.ReadOnly = True
                    'txt_WHOno.Text = Trim(gdataset.Tables("PO_WorkOrderBook").Rows(0).Item("WO_NO"))
                    txt_IndentNo.Text = Trim(gdataset.Tables("PO_WorkOrderBook").Rows(0).Item("WODETAILS"))
                    DTP_DOCDATE.Value = Format(CDate(gdataset.Tables("PO_WorkOrderBook").Rows(0).Item("WObDATE")), "dd-MMM-yyyy")
                    txt_Remarks.Text = Trim(gdataset.Tables("PO_WorkOrderBook").Rows(0).Item("REMARKS"))
                    'If gdataset.Tables("PO_WorkOrderBook").Rows(0).Item("VOID") = "Y" Then
                    '    Me.lbl_Freeze.Visible = True
                    '    Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(CDate(gdataset.Tables("PO_WorkOrderBook").Rows(0).Item("UPDATEDATE")), "dd-MMM-yyyy")
                    '    Me.Cmd_FREEZE.Enabled = True
                    '    Me.cmd_Add.Enabled = False
                    '    ' Me.Cmd_Freeze.Text = "UnVoid[F8]"
                    '    Cmd_FREEZE.Enabled = False
                    'Else
                    '    Me.lbl_Freeze.Visible = False
                    '    Me.Cmd_FREEZE.Enabled = True
                    '    Me.lbl_Freeze.Text = "Record Void  On "
                    '    Me.Cmd_FREEZE.Text = "Void[F8]"
                    'End If

                    sqlstring = "SELECT ISNULL(WODATE,'') AS WODATE ,ISNULL(WORKDESC,'') AS WORKDESC,"
                    sqlstring = sqlstring & "ISNULL(UNIT,'')AS unit,ISNULL(SINO,0) AS SINO,ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE,ISNULL(AMOUNT,0) AS AMOUNT "
                    sqlstring = sqlstring & " FROM PO_WorkOrderBook_DET WHERE  (WO_NO = '" & Format(Val(txt_IndentNo.Text), "0000") & "'  OR WODETAILS = '" & Trim(txt_IndentNo.Text) & "')  "
                    sqlstring = sqlstring & " ORDER BY AUTOID "
                    gconnection.getDataSet(sqlstring, "GRNDETAILS")
                    If gdataset.Tables("GRNDETAILS").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("GRNDETAILS").Rows.Count
                            ssgrid.SetText(1, i, Trim(gdataset.Tables("GRNDETAILS").Rows(j).Item("sino")))
                            ssgrid.SetText(2, i, Trim(gdataset.Tables("GRNDETAILS").Rows(j).Item("WORKDESC")))
                            ssgrid.SetText(3, i, Trim(gdataset.Tables("GRNDETAILS").Rows(j).Item("UNIT")))
                            ssgrid.SetText(4, i, Format(Val(gdataset.Tables("GRNDETAILS").Rows(j).Item("QTY")), "0.00"))
                            ssgrid.SetText(5, i, Format(Val(gdataset.Tables("GRNDETAILS").Rows(j).Item("RATE")), "0.00"))
                            ssgrid.SetText(6, i, Format(Val(gdataset.Tables("GRNDETAILS").Rows(j).Item("AMOUNT")), "0.00"))
                            j = j + 1
                        Next
                    End If
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                    If Not String.IsNullOrEmpty(gAuditFlg) Then
                        If gAuditFlg.ToUpper = "Y" Then
                            Me.cmd_Add.Enabled = False
                            Me.Cmd_FREEZE.Enabled = False
                        End If
                    End If
                    ' cbo_Tostore.Enabled = False
                    ' txt_Tostorecode.Enabled = False
                    dtp_Indentdate.Enabled = False
                    txt_qty.Enabled = False
                    txt_Totalamount.Enabled = False
                    ssgrid.SetActiveCell(1, 1)
                Else
                    MsgBox("NOT A VAILD INDENT NO", MsgBoxStyle.Question)
                    txt_IndentNo.Text = ""
                    txt_IndentNo.Focus()
                End If
            End If
            ' End If
            Call Grid_lock()
        Catch ex As Exception
            MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
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
                    ssgrid.Lock = True
                Next Z
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_storecode_Click(sender As Object, e As EventArgs) Handles cmd_storecode.Click
        gSQLString = "SELECT DISTINCT(storecode),storedesc FROM storemaster "
        M_WhereCondition = " where freeze <> 'Y' and isnull(storestatus,'')='M'"
        Dim vform As New ListOperattion1_N
        vform.Field = "STOREDESC,STORECODE"
        vform.vFormatstring = "         STORE CODE              |                  STORE DESCRIPTION                                                                                                   "
        vform.vCaption = " STORE MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TXT_FROMSTORECODE.Text = Trim(vform.keyfield & "")
            txt_FromStorename.Text = Trim(vform.keyfield1 & "")
            ' cbo_Tostore.Focus()
            ssgrid.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub ssgrid_Advance(sender As Object, e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid.Advance

    End Sub

    Private Sub ssgrid_LeaveCell(sender As Object, e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid.LeaveCell
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
    Private Sub Calculate()
        Try
            Dim ValQty, ValRate, ValDiscount, VarTotal, clsquantiy, Varqty As Double
            Dim ValHighratio, ValItemamount, ValDblamount, Calqty As Double
            Dim Itemcode As String
            Dim i, j As Integer
            If ssgrid.ActiveCol = 1 Or ssgrid.ActiveCol = 2 Or ssgrid.ActiveCol = 3 Or ssgrid.ActiveCol = 4 Or ssgrid.ActiveCol = 5 Or ssgrid.ActiveCol = 6 Then
                '  lbl_closingqty.Text = ""
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
                '  clsquantiy = ClosingQuantity(Trim(Itemcode), Trim(txt_Mainstorecode.Text))
                ssgrid.Col = 2
                ssgrid.Row = i
                '  lbl_closingqty.Text = UCase(Trim(ssgrid.Text)) & " CLOSING QTY : " & Format(Val(clsquantiy - Calqty), "0.000")
                Me.txt_Totalamount.Text = 0
                VarTotal = 0
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Col = 6
                    ssgrid.Row = i
                    VarTotal = Val(ssgrid.Text)
                    Me.txt_Totalamount.Text = Format(Val(Me.txt_Totalamount.Text) + Val(VarTotal), "0.00")
                Next i
                i = i - 1

                Me.txt_qty.Text = 0
                Varqty = 0
                For i = 1 To ssgrid.DataRowCnt
                    ssgrid.Col = 4
                    ssgrid.Row = i
                    Varqty = Val(ssgrid.Text)
                    Me.txt_qty.Text = Format(Val(Me.txt_qty.Text) + Val(Varqty), "0.00")
                Next i
                i = i - 1
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_Exit_Click(sender As Object, e As EventArgs) Handles cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub spssgrid_Advance(sender As Object, e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles spssgrid.Advance

    End Sub
    Private Function fillsubledger()
        Dim sqlstring As String
        Dim vform As New List_Operation
        'gSQLString = "SELECT ISNULL(SLCODE,0) AS SLCODE, ISNULL(SLNAME,'') AS SLNAME FROM ACCOUNTSSUBLEDGERMASTER "
        gSQLString = "SELECT ISNULL(VENDORCODE,'') AS VENDORCODE, ISNULL(VENDORNAME,'') AS VENDORNAME FROM PO_VIEW_VENDORMASTER "
        If Trim(search) = " " Then
            'M_WhereCondition = " WHERE ACCODE= '" & gCreditors & "' "
            M_WhereCondition = " "
        Else
            M_WhereCondition = " "
        End If
        vform.Field = " VENDORNAME,VENDORCODE "
        vform.vFormatstring = "     VENDOR CODE     |                   VENDOR NAME                   "
        vform.vCaption = "VENDOR MASTER HELP"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1
        'vform.ShowDialog(Me)
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        ' vform.KeyPos2 = 2
        'vform.Keypos3 = 3
        'vform.keypos4 = 4
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Call check_Duplicate(Trim(vform.keyfield))
            If Dupchk = True Then
                Exit Function
            End If
            'Call GridUOM(ssgrid.ActiveRow) '''---> Fill the UOM feild
            spssgrid.Col = 1
            spssgrid.Row = spssgrid.ActiveRow
            spssgrid.Text = Trim(vform.keyfield)
            spssgrid.Col = 2
            spssgrid.Row = spssgrid.ActiveRow
            spssgrid.Text = Trim(vform.keyfield1)
            'If Trim(vform.keyfield & "") <> "" Then
            '    spssgrid.Text = Trim(vform.keyfield & "")
            '    spssgrid.Text = Trim(vform.keyfield1 & "")
            '    'txt_Suppliercode.Focus()
            '    ' dtp_Scheduleddate.Focus()
            'End If
            vform.Close()
            vform = Nothing
            spssgrid.SetActiveCell(2, spssgrid.ActiveRow)
        Else
            MessageBox.Show(" Specified Record Not Found ")
            spssgrid.SetActiveCell(1, ssgrid.ActiveRow)
            Exit Function
        End If
    End Function
    Private Function check_Duplicate(ByVal Itemcode As String)
        Dim i As Integer
        Dupchk = False
        spssgrid.Col = 1
        For i = 1 To spssgrid.DataRowCnt
            spssgrid.Row = i
            If i <> spssgrid.ActiveRow Then
                If Trim(spssgrid.Text) = Itemcode Then
                    MsgBox("Supplier Already exists", MsgBoxStyle.Critical, "Duplicate")
                    Dupchk = True
                End If
            End If
        Next
    End Function

    Private Sub spssgrid_KeyDownEvent(sender As Object, e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles spssgrid.KeyDownEvent
        '  For i = 1 To spssgrid.DataRowCnt
        If e.keyCode = Keys.Enter Then
            i = spssgrid.ActiveRow
            Dim j As Integer
            If spssgrid.ActiveCol = 1 Then

                'If spssgrid.Lock = False Then
                Dim temp, TEMP1 As String
                temp = ""
                TEMP1 = ""
                spssgrid.Col = 1
                spssgrid.Row = i
                temp = Trim(spssgrid.Text)

                '  If Trim(temp) = "" Then
                If Trim(spssgrid.Text) = "" Then
                    Call fillsubledger()
                Else
                    ' Itemcode = Trim(spssgrid.Text)
                    spssgrid.ClearRange(1, spssgrid.ActiveRow, 3, spssgrid.ActiveRow, True)
                    ''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
                    'sqlstring = " SELECT DISTINCT  ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM ,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE,ISNULL(I.SALERATE,0) AS SALERATE"
                    'sqlstring = sqlstring & " FROM INVENTORYITEMMASTER AS I "
                    'sqlstring = sqlstring & " WHERE I.ITEMCODE ='" & Trim(Itemcode) & "'  AND ISNULL(I.FREEZE,'') <> 'Y' AND ISNULL(I.STORECODE,'')='" & Trim(TXT_FROMSTORECODE.Text) & "'"
                    sqlstring = "SELECT ISNULL(VENDORCODE,'') AS VENDORCODE, ISNULL(VENDORNAME,'') AS VENDORNAME FROM PO_VIEW_VENDORMASTER"
                    sqlstring = sqlstring & " WHERE VENDORCODE ='" & Trim(temp) & "' "
                    gconnection.getDataSet(sqlstring, "subledger")
                    If gdataset.Tables("subledger").Rows.Count > 0 Then
                        Call check_Duplicate(Trim(gdataset.Tables("subledger").Rows(j).Item("VENDORCODE")))
                        If Dupchk = True Then
                            spssgrid.Col = 1
                            spssgrid.Row = spssgrid.ActiveRow
                            spssgrid.Text = ""
                            spssgrid.SetActiveCell(0, spssgrid.ActiveRow)
                            spssgrid.Focus()
                            Exit Sub
                        End If
                        spssgrid.SetText(1, i, Trim(gdataset.Tables("subledger").Rows(j).Item("VENDORCODE")))
                        spssgrid.SetText(2, i, Trim(gdataset.Tables("subledger").Rows(j).Item("VENDORNAME")))
                        spssgrid.SetActiveCell(2, spssgrid.ActiveRow)
                    Else
                        MessageBox.Show("Specified SUBLEDGER CODE not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        spssgrid.SetActiveCell(0, spssgrid.ActiveRow)
                        spssgrid.Text = ""
                        spssgrid.Focus()
                        Exit Sub
                    End If
                End If
                ' Else
                ' spssgrid.SetActiveCell(1, spssgrid.ActiveRow)
                ' Call SelectText()
                '  End If
                'Else
                ' spssgrid.SetActiveCell(1, spssgrid.ActiveRow)
                'End If

            End If
            '  i = i + 1
        ElseIf e.keyCode = Keys.F3 Then
            spssgrid.Col = spssgrid.ActiveCol
            i = spssgrid.ActiveRow
            spssgrid.Row = i
            ' If ssgrid.Lock = False Then
            With spssgrid
                .Row = .ActiveRow
                .ClearRange(1, .ActiveRow, 3, .ActiveRow, True)
                .DeleteRows(.ActiveRow, 1)
                ' Call Calculate()
                .SetActiveCell(1, spssgrid.ActiveRow)
                .Focus()
            End With
            ' End If
        End If
        ' Next i
    End Sub
    Private Sub checkValidation()
        Try
            boolchk = False
            ''**************************************** Check DATEVALIDATION *******************************************''
            Call Checkdatevalidate(Format(DTP_QTODATE.Value, "dd-MMM-yyyy"))
            If chkdatevalidate = False Then Exit Sub
            ''**************************************** Check GRN NO. can't be blank *******************************************''
            If DateDiff(DateInterval.Day, DTP_QTODATE.Value, dtp_invitdate.Value) < 0 Then
                MessageBox.Show("Quotation Date cannot be greater than Invited Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                chkdatevalidate = False
                Exit Sub
            End If
            If DateDiff(DateInterval.Day, DTP_DOCDATE.Value, DTP_QTODATE.Value) < 0 Then
                MessageBox.Show("Document Date cannot be greater than Quotation Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                chkdatevalidate = False
                Exit Sub
            End If
            If Trim(txt_IndentNo.Text) = "" Then
                MessageBox.Show("INDENT NO. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_IndentNo.Focus()
                Exit Sub
            End If
            ''**************************************** Check Storecode can't be blank *******************************************''
            'If Trim(txt_storecode.Text) = "" Then
            '    MessageBox.Show("Storecode. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '    txt_storecode.Focus()
            '    Exit Sub
            'End If
            If Trim(TXT_QUOTNO.Text) = "" Then
                MessageBox.Show("Quotation No. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                TXT_QUOTNO.Focus()
                Exit Sub
            End If
            If Trim(cmb_invitedby.Text) = "" Then
                MessageBox.Show("Invited By Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                cmb_invitedby.Focus()
                Exit Sub
            End If
            ''**************************************** Check storedesc can't be blank *******************************************''
            'If Trim(txt_storeDesc.Text) = "" Then
            '    MessageBox.Show("StoreDesc Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '    txt_storeDesc.Focus()
            '    Exit Sub
            'End If
            ''**************************************** Check Type can't be blank *******************************************''
            ''If Trim(cbo_type.Text) = "" Then
            ''    MessageBox.Show("Product Type Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            ''    cbo_type.Focus()
            ''    Exit Sub
            ''End If
            ''********************************************* Check ssgrid value can't be blank ********************************************'''
            'For i = 1 To ssgrid.DataRowCnt
            '    ssgrid.Row = i
            '    ssgrid.Col = 1
            '    If Trim(ssgrid.Text) = "" Then
            '        MessageBox.Show("Item Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '        ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
            '        ssgrid.Focus()
            '        Exit Sub
            '    End If
            '    ssgrid.Col = 2
            '    If Trim(ssgrid.Text) = "" Then
            '        MessageBox.Show("Item Description can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '        ssgrid.SetActiveCell(2, ssgrid.ActiveRow)
            '        ssgrid.Focus()
            '        Exit Sub
            '    End If
            '    ssgrid.Col = 3
            '    If Trim(ssgrid.Text) = "" Then
            '        MessageBox.Show("UOM can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '        ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
            '        ssgrid.Focus()
            '        Exit Sub
            '    End If
            '    ssgrid.Col = 4
            '    If Val(ssgrid.Text) = 0 Then
            '        MessageBox.Show("Quantity can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '        ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
            '        ssgrid.Focus()
            '        Exit Sub
            '    End If
            '    ssgrid.Col = 5
            '    If Val(ssgrid.Text) = 0 Then
            '        MessageBox.Show("Rate can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '        ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
            '        ssgrid.Focus()
            '        Exit Sub
            '    End If
            '    ssgrid.Col = 6
            '    If Val(ssgrid.Text) = 0 Then
            '        MessageBox.Show("Amount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '        ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
            '        ssgrid.Focus()
            '        Exit Sub
            '    End If
            'Next
            spssgrid.Row = 1
            spssgrid.Col = 1
            If Trim(spssgrid.Text) = "" Then
                MessageBox.Show("Supplier Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                spssgrid.SetActiveCell(1, spssgrid.ActiveRow)
                spssgrid.Focus()
                Exit Sub
            End If
            For i = 1 To spssgrid.DataRowCnt
                spssgrid.Row = i
                spssgrid.Col = 1
                If Trim(spssgrid.Text) = "" Then
                    MessageBox.Show("Supplier Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    spssgrid.SetActiveCell(1, spssgrid.ActiveRow)
                    spssgrid.Focus()
                    Exit Sub
                End If
                spssgrid.Col = 2
                If Trim(spssgrid.Text) = "" Then
                    MessageBox.Show("Supplier Name can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    spssgrid.SetActiveCell(2, spssgrid.ActiveRow)
                    spssgrid.Focus()
                    Exit Sub
                End If
                spssgrid.Col = 3
                If Trim(spssgrid.Text) = "" Then
                    MessageBox.Show("Select can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                    spssgrid.SetActiveCell(3, spssgrid.ActiveRow)
                    spssgrid.Focus()
                    Exit Sub
                End If
            Next
            boolchk = True
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : checkValidation" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmd_Add_Click(sender As Object, e As EventArgs) Handles cmd_Add.Click
        Try

            Dim sqlstring, selct, Insert(0) As String
            Dim dblval, dblqty As Double
            Dim i, j As Integer
            Call checkValidation() ''--->Check Validation
            If boolchk = False Then Exit Sub
            If cmd_Add.Text = "Add [F7]" Then
                docno1 = Split(Trim(txt_IndentNo.Text), "/")
                QU_NO = Split(Trim(TXT_QUOTNO.Text), "/")
                For i = 1 To spssgrid.DataRowCnt
                    sqlstring = "INSERT INTO po_quationinvitation(QUOTYPE,Docno,QU_NO,quotNo,QUOdate,Docdetails,Doctype,Docdate,IndentNo,IndentDate,Storelocationcode,Storelocationname, "
                    sqlstring = sqlstring & " Opstorelocationcode, Opstorelocationname,invitedby,invitdate,suppliercode,suppliername,selectsupplier, Remarks,Void,VoidReason,Adduser,Adddate,Updateuser,Updatetime)"
                    sqlstring = sqlstring & " VALUES ('" & Trim(CMB_QUOTTYPE.Text) & "','" & CStr(docno1(1)) & "','" & CStr(QU_NO(1)) & "','" & Trim(TXT_QUOTNO.Text) & "','" & Format(CDate(DTP_QTODATE.Value), "dd-MMM-yyyy") & "','" & Trim(txt_IndentNo.Text) & "','" & Trim(docno) & "',"
                    'sqlstring = sqlstring & " VALUES ('" & Trim(txt_Docno.Text) & "','" & Trim(txt_Docno.Text) & "','" & Trim(docno) & "',"
                    sqlstring = sqlstring & " '" & Format(CDate(DTP_DOCDATE.Value), "dd-MMM-yyyy") & "','" & Trim(txt_IndentNo.Text) & "','" & Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy") & "',"
                    sqlstring = sqlstring & " '" & Trim(txt_storecode.Text) & "','" & Trim(txt_storeDesc.Text) & "','" & Trim(TXT_FROMSTORECODE.Text) & "', "
                    sqlstring = sqlstring & " '" & Trim(txt_FromStorename.Text) & "' ,'" & Trim(cmb_invitedby.Text) & "','" & Format(CDate(dtp_invitdate.Value), "dd-MMM-yyyy") & "',"
                    'sqlstring = sqlstring & ""
                    spssgrid.Col = 1
                    spssgrid.Row = i
                    sqlstring = sqlstring & "'" & Trim(spssgrid.Text) & "',"
                    spssgrid.Col = 2
                    spssgrid.Row = i
                    sqlstring = sqlstring & "'" & Trim(spssgrid.Text) & "',"
                    spssgrid.Col = 3
                    spssgrid.Row = i
                    If Trim(spssgrid.Text) = "YES" Then
                        selct = "Y"
                    Else
                        selct = "N"
                    End If
                    sqlstring = sqlstring & "'" & Trim(selct) & "',"
                    sqlstring = sqlstring & " '" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "' ,'N','" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "',"
                    sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                    sqlstring = sqlstring & " '','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                    'Insert(0) = sqlstring
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                Next

            ElseIf Mid(cmd_Add.Text, 1, 1) = "U" Then
                docno1 = Split(Trim(txt_IndentNo.Text), "/")
                QU_NO = Split(Trim(TXT_QUOTNO.Text), "/")
                'sqlstring = " SELECT auth_docno FROM PO_HDR WHERE auth_docno='" & TXT_DOCNO.Text & "' AND ISNULL(freeze,'')<>'Y'"
                'gconnection.getDataSet(sqlstring, "docVAL")
                'If gdataset.Tables("docVAL").Rows.Count > 0 Then
                '    MessageBox.Show("This document Has Been Processed,You Cannot do any modification")
                '    Exit Sub
                'End If

                sqlstring = "DELETE FROM  po_quationinvitation WHERE quotNo= '" & TXT_QUOTNO.Text & "' AND DOCDETAILS='" & txt_IndentNo.Text & "'"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring

                For i = 1 To spssgrid.DataRowCnt
                    sqlstring = "INSERT INTO po_quationinvitation(QUOTYPE,Docno,QU_NO,quotNo,QUOdate,Docdetails,Doctype,Docdate,IndentNo,IndentDate,Storelocationcode,Storelocationname, "
                    sqlstring = sqlstring & " Opstorelocationcode, Opstorelocationname,invitedby,invitdate,suppliercode,suppliername,selectsupplier, Remarks,Void,VoidReason,Adduser,Adddate,Updateuser,Updatetime)"
                    sqlstring = sqlstring & " VALUES ('" & Trim(CMB_QUOTTYPE.Text) & "','" & CStr(docno1(1)) & "','" & CStr(QU_NO(1)) & "','" & Trim(TXT_QUOTNO.Text) & "','" & Format(CDate(DTP_QTODATE.Value), "dd-MMM-yyyy") & "','" & Trim(txt_IndentNo.Text) & "','" & Trim(docno) & "',"
                    'sqlstring = sqlstring & " VALUES ('" & Trim(txt_Docno.Text) & "','" & Trim(txt_Docno.Text) & "','" & Trim(docno) & "',"
                    sqlstring = sqlstring & " '" & Format(CDate(DTP_DOCDATE.Value), "dd-MMM-yyyy") & "','" & Trim(txt_IndentNo.Text) & "','" & Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy") & "',"
                    sqlstring = sqlstring & " '" & Trim(txt_storecode.Text) & "','" & Trim(txt_storeDesc.Text) & "','" & Trim(TXT_FROMSTORECODE.Text) & "', "
                    sqlstring = sqlstring & " '" & Trim(txt_FromStorename.Text) & "' ,'" & Trim(cmb_invitedby.Text) & "','" & Format(CDate(dtp_invitdate.Value), "dd-MMM-yyyy") & "',"
                    'sqlstring = sqlstring & ""
                    spssgrid.Col = 1
                    spssgrid.Row = i
                    sqlstring = sqlstring & "'" & Trim(spssgrid.Text) & "',"
                    spssgrid.Col = 2
                    spssgrid.Row = i
                    sqlstring = sqlstring & "'" & Trim(spssgrid.Text) & "',"
                    spssgrid.Col = 3
                    spssgrid.Row = i
                    If Trim(spssgrid.Text) = "YES" Then
                        selct = "Y"
                    Else
                        selct = "N"
                    End If
                    sqlstring = sqlstring & "'" & Trim(selct) & "',"
                    sqlstring = sqlstring & " '" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "' ,'N','" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "?") & "',"
                    sqlstring = sqlstring & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
                    sqlstring = sqlstring & " '','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                    'Insert(0) = sqlstring
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                Next

            End If
            gconnection.MoreTrans(Insert)
            cmd_Clear_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_FREEZE_Click(sender As Object, e As EventArgs) Handles Cmd_FREEZE.Click
        Try
            Dim i As Integer
            Dim insert(0), strsql As String
            Call checkValidation() ''-->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_FREEZE.Text, 1, 1) = "V" Then

                If MsgBox("Are you Sure to Freeze the Record..", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                    Exit Sub
                End If
                ''***************************************** Void the DOCNO is Complete **********************************'''
                sqlstring = "INSERT INTO po_quationinvitation_DEL( Docno , Docdetails , Doctype , Docdate , IndentNo , IndentDate , Storelocationcode , Storelocationname , Opstorelocationcode , Opstorelocationname , Totalamt , Remarks , Void , Voidreason , Adduser , Adddate , Updateuser , Updatetime )                                        "
                sqlstring = sqlstring & " SELECT Docno , Docdetails , Doctype , Docdate , IndentNo , IndentDate , Storelocationcode , Storelocationname , Opstorelocationcode , Opstorelocationname , Totalamt , Remarks , Void , Voidreason , Adduser , Adddate , Updateuser , Updatetime"
                sqlstring = sqlstring & " FROM po_quationinvitation A"
                sqlstring = sqlstring & " WHERE A.DOCDETAILS = '" & Trim(txt_IndentNo.Text) & "' "
                ' sqlstring = sqlstring & " AND Docdetails = '" & Trim(TXT_DOCNO.Text) & "'"
                sqlstring = sqlstring & " AND quotNo = '" & Trim(TXT_QUOTNO.Text) & "'"
                insert(0) = sqlstring

                sqlstring = " DELETE FROM po_quationinvitation "
                sqlstring = sqlstring & " WHERE DOCDETAILS = '" & Trim(txt_IndentNo.Text) & "' "
                ' sqlstring = sqlstring & " AND Docdetails = '" & Trim(TXT_DOCNO.Text) & "'"
                sqlstring = sqlstring & " AND quotNo = '" & Trim(TXT_QUOTNO.Text) & "'"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = sqlstring
            End If
            gconnection.MoreTrans(insert)
            cmd_Clear_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub

        End Try
    End Sub
    Private Sub autogenerate()
        Try
            Dim DOCTYE As String
            If Mid(CMB_QUOTTYPE.Text, 1, 1) = "W" Then
                DOCTYE = "WQ"
            ElseIf Mid(CMB_QUOTTYPE.Text, 1, 1) = "H" Then
                DOCTYE = "HQ"
            End If
            Dim sqlstring, financalyear As String
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialyearEnd, 3, 4)
            docno = doctype
            'sqlstring = "SELECT MAX(SUBSTRING(quotNo,1,5)) FROM po_quationinvitation" ' WHERE doctype='" & docno & "'"
            sqlstring = " SELECT ISNULL(MAX(ISNULL(qu_No,'')),0) FROM po_quationinvitation  WHERE QUOTYPE='" & CMB_QUOTTYPE.Text & "' "
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    TXT_QUOTNO.Text = DOCTYE & "/" & "00001"
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    TXT_QUOTNO.Text = DOCTYE & "/" & Format(gdreader(0) + 1, "00000")
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                TXT_QUOTNO.Text = DOCTYE & "/" & "00001"
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub



    Private Sub cmd_qutnohelp_Click(sender As Object, e As EventArgs) Handles cmd_qutnohelp.Click
        Try
            gSQLString = "SELECT DISTINCT quotNo,indentno,indentdate,docdetails,docdate FROM po_quationinvitation WHERE "
            M_WhereCondition = " ISNULL(VOID,'')<>'Y' AND QUOTYPE='" & CMB_QUOTTYPE.Text & "' "
            Dim vform As New ListOperattion1_N
            vform.Field = "QUOTNO,QUODATE,DOCDETAILS,DOCDATE"
            vform.vFormatstring = "   QUOTNO |  QUODATE   |  DOCDETAILS   | DOCDATE                                                         "
            vform.vCaption = "QUOTATION NO HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                TXT_QUOTNO.Text = Trim(vform.keyfield & "")
                ssgrid.ClearRange(1, 1, -1, -1, True)
                spssgrid.ClearRange(1, 1, -1, -1, True)
                Call TXT_QUOTNO_Validated(TXT_QUOTNO, e)
                'dtp_Indentdate.Focus()
                cmd_Add.Text = "Update [F7]"
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub TXT_QUOTNO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_QUOTNO.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(TXT_QUOTNO.Text) = "" Then
                    Call cmd_qutnohelp_Click(cmd_qutnohelp, e)
                Else
                    TXT_QUOTNO_Validated(TXT_QUOTNO, e)
                    spssgrid.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Grnno Key Press " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub TXT_QUOTNO_Validated(sender As Object, e As EventArgs) Handles TXT_QUOTNO.Validated
        Dim j, i As Integer
        Dim dt As New DataTable
        Dim sqlstring, remarks As String



        If Trim(TXT_QUOTNO.Text) <> "" Then
            Dim VSTRDOCNO As String
            Try
                sqlstring = "SELECT ISNULL(QUOTYPE,'') AS QUOTYPE,ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE AS DOCDATE, "
                sqlstring = sqlstring & " ISNULL(QUOdate,'') AS  QUOdate,ISNULL(invitedby,'') AS invitedby,ISNULL(invitdate,'') AS invitdate,"
                sqlstring = sqlstring & " ISNULL(H.OPSTORELOCATIONNAME,'') AS OPSTORELOCATIONNAME,ISNULL(H.TOTALAMT,0) AS TOTALAMT,ISNULL(H.REMARKS,'') AS REMARKS,"
                sqlstring = sqlstring & " ISNULL(H.VOID,'') AS VOID,ISNULL(H.VOIDREASON,'') AS VOIDREASON,ISNULL(H.ADDUSER,'') AS ADDUSER,ADDDATE,ISNULL(H.UPDATEUSER,'') AS UPDATEUSER,UPDATETIME"
                sqlstring = sqlstring & " FROM po_quationinvitation AS H WHERE quotNo='" & Trim(TXT_QUOTNO.Text) & "'"
                gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")
                ''************************************************* SELECT RECORD FROM STOCKISSUEHEADER *********************************************''''                
                If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
                    'Cmd_Add.Text = "Update[F7]"
                    Me.TXT_DOCNO.ReadOnly = True
                    VSTRDOCNO = Trim(TXT_DOCNO.Text)
                    CMB_QUOTTYPE.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("QUOTYPE") & "")
                    txt_IndentNo.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDETAILS") & "")
                    ' TXT_DOCNO.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDETAILS") & "")
                    DTP_QTODATE.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("QUOdate")), "dd-MM-yyyy")
                    DTP_DOCDATE.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDATE")), "dd-MM-yyyy")
                    cmb_invitedby.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("invitedby") & "")
                    dtp_invitdate.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("invitdate")), "dd-MM-yyyy")
                    ' dtp_Indentdate.Value = Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("INDENTDATE")), "dd-MM-yyyy")
                    remarks = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("REMARKS"))
                    txt_Remarks.Text = Replace(remarks, "?", "'")
                    If gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("VOID") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("ADDDATE")), "dd-MMM-yyyy")
                        Me.Cmd_FREEZE.Enabled = False
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.Cmd_FREEZE.Enabled = True
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.Cmd_FREEZE.Text = "Void[F8]"
                    End If
                    If Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("VOID")) = "Y" Then
                        cmd_Add.Enabled = False
                        Cmd_FREEZE.Enabled = False
                    End If
                    ''************************************************* SELECT RECORD FROM STOCKISSUEDETAILS *********************************************''''                
                    ' If TOTALQTY <> ISSUEQTY Then


                    sqlstring = "SELECT ISNULL(WODATE,'') AS WODATE ,ISNULL(WORKDESC,'') AS WORKDESC,"
                    sqlstring = sqlstring & "ISNULL(UNIT,'')AS unit,ISNULL(SINO,0) AS SINO,ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE,ISNULL(AMOUNT,0) AS AMOUNT "
                    sqlstring = sqlstring & " FROM PO_WorkOrderBook_DET WHERE  (WO_NO = '" & Format(Val(txt_IndentNo.Text), "0000") & "'  OR WODETAILS = '" & Trim(txt_IndentNo.Text) & "')  "
                    sqlstring = sqlstring & " ORDER BY AUTOID "
                    gconnection.getDataSet(sqlstring, "GRNDETAILS")
                    If gdataset.Tables("GRNDETAILS").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("GRNDETAILS").Rows.Count
                            ssgrid.SetText(1, i, Trim(gdataset.Tables("GRNDETAILS").Rows(j).Item("sino")))
                            ssgrid.SetText(2, i, Trim(gdataset.Tables("GRNDETAILS").Rows(j).Item("WORKDESC")))
                            ssgrid.SetText(3, i, Trim(gdataset.Tables("GRNDETAILS").Rows(j).Item("UNIT")))
                            ssgrid.SetText(4, i, Format(Val(gdataset.Tables("GRNDETAILS").Rows(j).Item("QTY")), "0.00"))
                            ssgrid.SetText(5, i, Format(Val(gdataset.Tables("GRNDETAILS").Rows(j).Item("RATE")), "0.00"))
                            ssgrid.SetText(6, i, Format(Val(gdataset.Tables("GRNDETAILS").Rows(j).Item("AMOUNT")), "0.00"))
                            j = j + 1
                        Next
                    End If
                 
                    sqlstring = " SELECT ISNULL(SUPPLIERCODE,'') AS SUPPLIERCODE,ISNULL(SUPPLIERNAME,'') AS SUPPLIERNAME,"
                    sqlstring = sqlstring & "ISNULL(SELECTSUPPLIER,'') AS SELECTSUPPLIER FROM po_quationinvitation"
                    sqlstring = sqlstring & " WHERE QUOTNO =  '" & Trim(TXT_QUOTNO.Text) & "' AND DOCDETAILS='" & Trim(txt_IndentNo.Text) & "'"
                    gconnection.getDataSet(sqlstring, "supplier")
                    Dim selct As String
                    Dim k As Integer
                    If gdataset.Tables("supplier").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("supplier").Rows.Count
                            spssgrid.SetText(1, i, Trim(gdataset.Tables("supplier").Rows(k).Item("SUPPLIERCODE")))
                            ' STRITEMCODE = Trim(gdataset.Tables("supplier").Rows(j).Item("ITEMCODE"))
                            spssgrid.SetText(2, i, Trim(gdataset.Tables("supplier").Rows(k).Item("SUPPLIERNAME")))
                            spssgrid.Col = 3
                            spssgrid.Row = i
                            selct = ""
                            selct = Trim(gdataset.Tables("supplier").Rows(k).Item("SELECTSUPPLIER"))
                            If selct = "Y" Then
                                spssgrid.SetText(3, i, "YES")
                            ElseIf selct = "N" Then
                                spssgrid.SetText(3, i, "NO")
                            End If
                            k = k + 1
                        Next
                    End If
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                    If Not String.IsNullOrEmpty(gAuditFlg) Then
                        If gAuditFlg.ToUpper = "Y" Then
                            Me.cmd_Add.Enabled = False
                            Me.Cmd_FREEZE.Enabled = False
                        End If
                    End If
                    ' TotalCount = gdataset.Tables("STOCKISSUEDETAILSALL").Rows.Count
                    spssgrid.SetActiveCell(1, 1)
                    cmd_Add.Text = "Update [F7]"
                    TXT_QUOTNO.ReadOnly = True
                    txt_IndentNo.ReadOnly = True
                End If
            Catch ex As Exception
                MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub cmd_Print_Click(sender As Object, e As EventArgs) Handles cmd_Print.Click
        Try
            'If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
            Dim rViewer As New Viewer
            Dim sqlstring, SSQL, FROMSTORE As String
            Dim r As New Rpt_Quoinvit
            'sqlstring = "SELECT TOP 100 PERCENT docdetails, docdate, storelocationname, "
            'sqlstring = sqlstring & " opstorelocationname, itemcode,storelocationcode,opstorelocationcode, "
            'sqlstring = sqlstring & " itemname, uom,qty, rate, amount ,clsqty, indentno , indentdate,remarks,UPDFOOTER,UPDSIGN,ADDDATE"
            'sqlstring = sqlstring & " FROM VW_PO_STOCKINDENTAUTH_BILL "
            sqlstring = "SELECT * from  po_quationinvitation "
            sqlstring = sqlstring & " WHERE quotno = '" & Trim(TXT_QUOTNO.Text) & "' and DOCDETAILS= '" & Trim(txt_IndentNo.Text) & "'"
            sqlstring = sqlstring & " ORDER BY quotno"

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

    Private Sub cmd_View_Click(sender As Object, e As EventArgs) Handles cmd_View.Click
        Try
            'If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
            Dim rViewer As New Viewer
            Dim sqlstring, SSQL, FROMSTORE As String
            'Dim r As New Rpt_Quoinvit
            Dim R As New Rpt_WOBBill2
            'sqlstring = "SELECT TOP 100 PERCENT docdetails, docdate, storelocationname, "
            'sqlstring = sqlstring & " opstorelocationname, itemcode,storelocationcode,opstorelocationcode, "
            'sqlstring = sqlstring & " itemname, uom,qty, rate, amount ,clsqty, indentno , indentdate,remarks,UPDFOOTER,UPDSIGN,ADDDATE"
            'sqlstring = sqlstring & " FROM VW_PO_STOCKINDENTAUTH_BILL "
            'MANISH
            'sqlstring = "SELECT * from  po_quationinvitation "
            'sqlstring = sqlstring & " WHERE quotno = '" & Trim(TXT_QUOTNO.Text) & "' and DOCDETAILS= '" & Trim(txt_IndentNo.Text) & "'"
            'sqlstring = sqlstring & " ORDER BY quotno"
            sqlstring = "SELECT * FROM VW_PO_WOBBILL1 WHERE QUOTNO='" & Trim(TXT_QUOTNO.Text) & "' "
            sqlstring = sqlstring & " "
            gconnection.getDataSet(sqlstring, "VW_PO_WOBBILL1")
            If gdataset.Tables("VW_PO_WOBBILL1").Rows.Count > 0 Then
                If chk_excel.Checked = True Then
                    Dim exp As New exportexcel
                    exp.Show()
                    Call exp.export(sqlstring, "STOCK ISSUE ", "")
                Else
                    rViewer.ssql = sqlstring
                    rViewer.Report = R
                    rViewer.TableName = "VW_PO_WOBBILL1"
                    Dim textobj1 As TextObject
                    textobj1 = R.ReportDefinition.ReportObjects("Text11")
                    textobj1.Text = MyCompanyName

                    Dim TXTOBJ2 As TextObject
                    TXTOBJ2 = R.ReportDefinition.ReportObjects("Text9")
                    TXTOBJ2.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode

                    Dim txtobj3 As TextObject
                    txtobj3 = R.ReportDefinition.ReportObjects("Text3")
                    txtobj3.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:" & gEmail & ", Web:" & gWebsite

                    Dim txt As TextObject
                    txt = R.ReportDefinition.ReportObjects("Text30")
                    txt.Text = gUsername
                    rViewer.Show()
                End If
            Else
                MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
            End If
         
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_export_Click(sender As Object, e As EventArgs) Handles cmd_export.Click
        Dim sqlstring As String
        Dim _export As New EXPORT
        _export.TABLENAME = "vw_po_quationinvitation  "
        sqlstring = "select * from vw_po_quationinvitation  WHERE QUOTYPE='" & CMB_QUOTTYPE.Text & "'"
        Call _export.export_excel(sqlstring)
        _export.Show()
        Exit Sub
    End Sub

    Private Sub CMB_QUOTTYPE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_QUOTTYPE.SelectedIndexChanged
        Call cmd_Clear_Click(sender, e)
    End Sub
    Private Sub Resize_Form()
        Dim cControl As Control
        Dim i_i As Integer
        Dim J, K, L, M, n, o, P, Q, R, S, T, U As Integer
        'If (Screen.PrimaryScreen.Bounds.Height = 768) And (Screen.PrimaryScreen.Bounds.Width = 1366) Then
        '    Exit Sub
        'End If
        J = 768
        K = 1024
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

    Private Sub CMD_BROWSE_Click(sender As Object, e As EventArgs) Handles CMD_BROWSE.Click
        'Dim FRM As New ReportDesigner
        'If txt_IndentNo.Text.Length > 0 Then
        '    tables = " FROM VW_PO_WOBBILL1 WHERE DOCDETAILS ='" & TXT_QUOTNO.Text & "' "
        'Else
        '    tables = "FROM VW_PO_WOBBILL1"
        'End If
        'Gheader = "WORK ORDER DETAILS"
        'FRM.DataGridView1.ColumnCount = 2
        'FRM.DataGridView1.Columns(0).Name = "COLUMN NAME"
        'FRM.DataGridView1.Columns(0).Width = 300
        'FRM.DataGridView1.Columns(1).Name = "SIZE"
        'FRM.DataGridView1.Columns(1).Width = 100

        'Dim ROW As String() = New String() {"DOCDETAILS", "10"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"QUOTNO", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"QUOTATIONNO", "5"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"VENDORCODE", "9"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"VENDORNAME", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"ADDRESS", "12"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"CITY", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"STATE", "12 "}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"SLTYPE", "6 "}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"PINCODE", "8"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"PHONE", "8"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"MOBILE", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"FAX", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"EMAIL", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"CONTACTPERSON", "10"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"INDENTNO", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"SUPPLIERCODE", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"ORDERSUBJECT", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"SUPPLIERNAME", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"INVITEDBY", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"INVITDATE", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"QTY", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"QUOTYPE", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"WORKDESC", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"REQUESTEDBY", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"APPROVEDBY", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"REMARKS", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"UNIT", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
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
        sqlstr = "SELECT QUOTYPE,Docno,QU_NO,quotNo,QUOdate,Docdetails,Doctype,Docdate,IndentNo,IndentDate,Storelocationcode,Storelocationname, "
        sqlstr = sqlstr & " Opstorelocationcode, Opstorelocationname,invitedby,invitdate,suppliercode,suppliername,selectsupplier, Remarks,Void,VoidReason,Adduser,Adddate,Updateuser,Updatetime from po_quationinvitation"
        'sqlstr = sqlstr & " Suppliername,HIREREASON,FROMDATE,TODATE,Totalamount,Surchargeamt,OverallDiscount,VATAMOUNT,Discount,Billamount,Remarks,Void,Adduser,Adddate,Updateuser,Updatetime,updfooter,updname,Grntype from Hrn_header WHERE GRNTYPE='HRT'"
        childsql = "SELECT  ISNULL(WODETAILS,'') AS WODETAILS,WObDATE,"
        childsql = childsql & " ISNULL(SUPPLIERCODE,'') AS SUPPLIERCODE,ISNULL(SUPPLIERNAME,'') AS SUPPLIERNAME,ORDERSUBJECT,REQUESTEDBY,APPROVEDBY,REMARKS,VOID,UPDATEDATE"
        childsql = childsql & " FROM PO_WorkOrderBook"

        gconnection.getDataSet(sqlstr, "po_quationinvitation")
        obj1.LOADGRID(gdataset.Tables("po_quationinvitation"), True, "QUOTATIONINVITATIONFORWOANDHO", childsql, "WODETAILS", 1)
        obj1.Show()
    End Sub
End Class
