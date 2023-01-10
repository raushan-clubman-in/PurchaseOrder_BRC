Imports System.IO
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Text.RegularExpressions

Public Class PurchaseOrder_SC
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim sqlstring, Sstr As String
    Dim docno, doctype, docno1() As String
    Dim grtot, grvat, totaldiscount As Double
    Dim vconn As New GlobalClass
    Dim Dupchk As Boolean
    Dim i As Integer
    Dim CATEGORY, VENDORLINK As String
    Friend WithEvents TXT_DOCTHROUGH As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txt_MOD As System.Windows.Forms.TextBox
    Friend WithEvents txt_SalesTax As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents TXT_ADVANCEPERC As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_GROSSVALUE As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmd_dos_print As System.Windows.Forms.Button
    Friend WithEvents cmd_auth As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chk_amnd_foll As System.Windows.Forms.CheckBox
    Friend WithEvents CMD_BROWSE As System.Windows.Forms.Button
    Friend WithEvents TXT_SUBJECT As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents cmd_export As System.Windows.Forms.Button
    'Dim gconnection As New GlobalClass
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbl_GroupCode As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Cmd_PONoHelp As System.Windows.Forms.Button
    Friend WithEvents txt_PONo As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Cbo_ApprDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cbo_PODate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cbo_POStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_Approvedby As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_QuotNo As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Vname As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_VcodeHelp As System.Windows.Forms.Button
    Friend WithEvents Txt_Vcode As System.Windows.Forms.TextBox
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdFreeze As System.Windows.Forms.Button
    Friend WithEvents Txt_Insurance As System.Windows.Forms.TextBox
    Friend WithEvents Txt_LST As System.Windows.Forms.TextBox
    Friend WithEvents Txt_MODVat As System.Windows.Forms.TextBox
    Friend WithEvents Txt_PTax As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Octra As System.Windows.Forms.TextBox
    Friend WithEvents Txt_ED As System.Windows.Forms.TextBox
    Friend WithEvents Txt_CST As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Cmb_despatch As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_shipping As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_delivery As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_Encl As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_POTerms As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cmd_POTermsHelp As System.Windows.Forms.Button
    Friend WithEvents Txt_AdvanceAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txt_TotalTax As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Balance As System.Windows.Forms.TextBox
    Friend WithEvents Txt_TotalVat As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents Txt_DeliveryTerms As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_Freight As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_Freight As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Lbl_Marquee As System.Windows.Forms.Label
    Friend WithEvents Group_MC As System.Windows.Forms.GroupBox
    Friend WithEvents Ssgrid_subject As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Ssgrid_reference As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Ssgrid_body As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Cmd_Ok As System.Windows.Forms.Button
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Txt_WarrantyCode As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_WarrantyCodeHelp As System.Windows.Forms.Button
    Friend WithEvents Txt_OtherTermCode As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_OtherTermCodeHelp As System.Windows.Forms.Button
    Friend WithEvents Chk_MC_Form As System.Windows.Forms.CheckBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents TXT_CF As System.Windows.Forms.TextBox
    Friend WithEvents TXT_OVERALLDISC As System.Windows.Forms.TextBox
    Friend WithEvents TXT_DELIVERY As System.Windows.Forms.TextBox
    Friend WithEvents TXT_TRANSPORT As System.Windows.Forms.TextBox
    Friend WithEvents Cbo_Dept1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_dept As System.Windows.Forms.TextBox
    Friend WithEvents cmd_DeptHelp As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Txt_GLAcIn As System.Windows.Forms.TextBox
    Friend WithEvents cmd_GLAcInHelp As System.Windows.Forms.Button
    Friend WithEvents lbl_gldesc As System.Windows.Forms.Label
    Friend WithEvents cbo_warehouse As System.Windows.Forms.ComboBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents grp_freight As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txt_CreditDays As System.Windows.Forms.TextBox
    Friend WithEvents Cbo_Closure As System.Windows.Forms.ComboBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Cmb_CSTForm As System.Windows.Forms.ComboBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents grp_encl As System.Windows.Forms.GroupBox
    Friend WithEvents grp_cstform As System.Windows.Forms.GroupBox
    Friend WithEvents AmendmentGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Grp_amend_Follow As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents FollowupGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Chk_Followup As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Amendment As System.Windows.Forms.CheckBox
    Friend WithEvents Cmd_DeliveryTermHelp As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_PAYMTTERMS_DESC As System.Windows.Forms.TextBox
    Friend WithEvents TXT_DELIVTERMS_DESC As System.Windows.Forms.TextBox
    Friend WithEvents Txt_POValue As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grp_footer As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_signature As System.Windows.Forms.TextBox
    Friend WithEvents Txt_footer As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Chk_item As System.Windows.Forms.CheckBox
    Friend WithEvents txt_docno As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents cmddochelp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PurchaseOrder_SC))
        Me.lbl_Heading = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmddochelp = New System.Windows.Forms.Button()
        Me.txt_docno = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.cmd_DeptHelp = New System.Windows.Forms.Button()
        Me.cbo_dept = New System.Windows.Forms.TextBox()
        Me.Cbo_PODate = New System.Windows.Forms.DateTimePicker()
        Me.Cbo_POStatus = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Cbo_Approvedby = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txt_QuotNo = New System.Windows.Forms.TextBox()
        Me.Cmd_VcodeHelp = New System.Windows.Forms.Button()
        Me.Txt_Vcode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txt_Vname = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Cmd_PONoHelp = New System.Windows.Forms.Button()
        Me.txt_PONo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lbl_GroupCode = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.cbo_warehouse = New System.Windows.Forms.ComboBox()
        Me.Txt_GLAcIn = New System.Windows.Forms.TextBox()
        Me.cmd_GLAcInHelp = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Cbo_Dept1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Cbo_ApprDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CMD_BROWSE = New System.Windows.Forms.Button()
        Me.cmd_dos_print = New System.Windows.Forms.Button()
        Me.cmd_auth = New System.Windows.Forms.Button()
        Me.CmdExit = New System.Windows.Forms.Button()
        Me.cmd_export = New System.Windows.Forms.Button()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.CmdAdd = New System.Windows.Forms.Button()
        Me.CmdFreeze = New System.Windows.Forms.Button()
        Me.CmdView = New System.Windows.Forms.Button()
        Me.CmdPrint = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXT_ADVANCEPERC = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Txt_Insurance = New System.Windows.Forms.TextBox()
        Me.Txt_LST = New System.Windows.Forms.TextBox()
        Me.Txt_MODVat = New System.Windows.Forms.TextBox()
        Me.Txt_PTax = New System.Windows.Forms.TextBox()
        Me.Txt_Octra = New System.Windows.Forms.TextBox()
        Me.Txt_ED = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Txt_CST = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread()
        Me.grp_freight = New System.Windows.Forms.GroupBox()
        Me.Cmb_Freight = New System.Windows.Forms.ComboBox()
        Me.Lbl_Freight = New System.Windows.Forms.Label()
        Me.Cmb_shipping = New System.Windows.Forms.ComboBox()
        Me.Cmb_despatch = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Cmb_delivery = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.grp_encl = New System.Windows.Forms.GroupBox()
        Me.Chk_MC_Form = New System.Windows.Forms.CheckBox()
        Me.Txt_Encl = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txt_POTerms = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cmd_POTermsHelp = New System.Windows.Forms.Button()
        Me.Txt_AdvanceAmt = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_TotalTax = New System.Windows.Forms.TextBox()
        Me.Txt_Balance = New System.Windows.Forms.TextBox()
        Me.Txt_TotalVat = New System.Windows.Forms.TextBox()
        Me.Txt_DeliveryTerms = New System.Windows.Forms.TextBox()
        Me.lbl_Freeze = New System.Windows.Forms.Label()
        Me.grp_cstform = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_CreditDays = New System.Windows.Forms.TextBox()
        Me.Cbo_Closure = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Cmb_CSTForm = New System.Windows.Forms.ComboBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lbl_Marquee = New System.Windows.Forms.Label()
        Me.Group_MC = New System.Windows.Forms.GroupBox()
        Me.Ssgrid_body = New AxFPSpreadADO.AxfpSpread()
        Me.Ssgrid_subject = New AxFPSpreadADO.AxfpSpread()
        Me.Ssgrid_reference = New AxFPSpreadADO.AxfpSpread()
        Me.Txt_OtherTermCode = New System.Windows.Forms.TextBox()
        Me.Cmd_OtherTermCodeHelp = New System.Windows.Forms.Button()
        Me.Txt_WarrantyCode = New System.Windows.Forms.TextBox()
        Me.Cmd_WarrantyCodeHelp = New System.Windows.Forms.Button()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Cmd_Ok = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.TXT_CF = New System.Windows.Forms.TextBox()
        Me.TXT_OVERALLDISC = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TXT_DELIVERY = New System.Windows.Forms.TextBox()
        Me.TXT_TRANSPORT = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.lbl_gldesc = New System.Windows.Forms.Label()
        Me.Grp_amend_Follow = New System.Windows.Forms.GroupBox()
        Me.FollowupGrid = New AxFPSpreadADO.AxfpSpread()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Chk_Followup = New System.Windows.Forms.CheckBox()
        Me.Chk_Amendment = New System.Windows.Forms.CheckBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AmendmentGrid = New AxFPSpreadADO.AxfpSpread()
        Me.Cmd_DeliveryTermHelp = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_amnd_foll = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_POValue = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chk_item = New System.Windows.Forms.CheckBox()
        Me.grp_footer = New System.Windows.Forms.GroupBox()
        Me.Txt_signature = New System.Windows.Forms.TextBox()
        Me.Txt_footer = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TXT_DOCTHROUGH = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txt_MOD = New System.Windows.Forms.TextBox()
        Me.txt_SalesTax = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.TXT_PAYMTTERMS_DESC = New System.Windows.Forms.TextBox()
        Me.TXT_DELIVTERMS_DESC = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TXT_GROSSVALUE = New System.Windows.Forms.TextBox()
        Me.Txt_Remarks = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.TXT_SUBJECT = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_freight.SuspendLayout()
        Me.grp_encl.SuspendLayout()
        Me.grp_cstform.SuspendLayout()
        Me.Group_MC.SuspendLayout()
        CType(Me.Ssgrid_body, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ssgrid_subject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ssgrid_reference, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp_amend_Follow.SuspendLayout()
        CType(Me.FollowupGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AmendmentGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.grp_footer.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.Color.Black
        Me.lbl_Heading.Location = New System.Drawing.Point(188, 80)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(150, 18)
        Me.lbl_Heading.TabIndex = 18
        Me.lbl_Heading.Text = "PURCHASE ORDER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TXT_SUBJECT)
        Me.GroupBox1.Controls.Add(Me.Label58)
        Me.GroupBox1.Controls.Add(Me.cmddochelp)
        Me.GroupBox1.Controls.Add(Me.txt_docno)
        Me.GroupBox1.Controls.Add(Me.Label52)
        Me.GroupBox1.Controls.Add(Me.cmd_DeptHelp)
        Me.GroupBox1.Controls.Add(Me.cbo_dept)
        Me.GroupBox1.Controls.Add(Me.Cbo_PODate)
        Me.GroupBox1.Controls.Add(Me.Cbo_POStatus)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Cbo_Approvedby)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Txt_QuotNo)
        Me.GroupBox1.Controls.Add(Me.Cmd_VcodeHelp)
        Me.GroupBox1.Controls.Add(Me.Txt_Vcode)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Txt_Vname)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Cmd_PONoHelp)
        Me.GroupBox1.Controls.Add(Me.txt_PONo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.lbl_GroupCode)
        Me.GroupBox1.Controls.Add(Me.Label47)
        Me.GroupBox1.Controls.Add(Me.cbo_warehouse)
        Me.GroupBox1.Location = New System.Drawing.Point(180, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(673, 170)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'cmddochelp
        '
        Me.cmddochelp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddochelp.Image = CType(resources.GetObject("cmddochelp.Image"), System.Drawing.Image)
        Me.cmddochelp.Location = New System.Drawing.Point(256, 35)
        Me.cmddochelp.Name = "cmddochelp"
        Me.cmddochelp.Size = New System.Drawing.Size(24, 25)
        Me.cmddochelp.TabIndex = 578
        '
        'txt_docno
        '
        Me.txt_docno.BackColor = System.Drawing.Color.White
        Me.txt_docno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_docno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_docno.Location = New System.Drawing.Point(103, 37)
        Me.txt_docno.MaxLength = 10
        Me.txt_docno.Name = "txt_docno"
        Me.txt_docno.Size = New System.Drawing.Size(152, 20)
        Me.txt_docno.TabIndex = 577
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Transparent
        Me.Label52.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(5, 38)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(95, 14)
        Me.Label52.TabIndex = 576
        Me.Label52.Text = "AUTH. DOC NO.  :"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmd_DeptHelp
        '
        Me.cmd_DeptHelp.Enabled = False
        Me.cmd_DeptHelp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_DeptHelp.Image = CType(resources.GetObject("cmd_DeptHelp.Image"), System.Drawing.Image)
        Me.cmd_DeptHelp.Location = New System.Drawing.Point(256, 62)
        Me.cmd_DeptHelp.Name = "cmd_DeptHelp"
        Me.cmd_DeptHelp.Size = New System.Drawing.Size(24, 25)
        Me.cmd_DeptHelp.TabIndex = 572
        '
        'cbo_dept
        '
        Me.cbo_dept.BackColor = System.Drawing.Color.White
        Me.cbo_dept.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.cbo_dept.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_dept.Location = New System.Drawing.Point(103, 64)
        Me.cbo_dept.MaxLength = 10
        Me.cbo_dept.Name = "cbo_dept"
        Me.cbo_dept.ReadOnly = True
        Me.cbo_dept.Size = New System.Drawing.Size(152, 20)
        Me.cbo_dept.TabIndex = 571
        '
        'Cbo_PODate
        '
        Me.Cbo_PODate.CustomFormat = "dd-MMM-yyyy"
        Me.Cbo_PODate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_PODate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cbo_PODate.Location = New System.Drawing.Point(464, 37)
        Me.Cbo_PODate.Name = "Cbo_PODate"
        Me.Cbo_PODate.Size = New System.Drawing.Size(152, 20)
        Me.Cbo_PODate.TabIndex = 2
        '
        'Cbo_POStatus
        '
        Me.Cbo_POStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_POStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_POStatus.Items.AddRange(New Object() {"RELEASED", "NOT-RELEASED", "CLOSED", "CANCELLED", "AMENDED"})
        Me.Cbo_POStatus.Location = New System.Drawing.Point(464, 118)
        Me.Cbo_POStatus.MaxLength = 25
        Me.Cbo_POStatus.Name = "Cbo_POStatus"
        Me.Cbo_POStatus.Size = New System.Drawing.Size(152, 22)
        Me.Cbo_POStatus.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(359, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 14)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "P.O. STATUS  :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cbo_Approvedby
        '
        Me.Cbo_Approvedby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Approvedby.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Approvedby.Items.AddRange(New Object() {"SECRETARY", "PRESIDENT", "ACCOUNTANT", "CEO", "DRIVING RANGE CHAIRMAN", "ENTERTAINMENT CHAIRMAN", "COURSE CHAIRMAN", "TOURNAMENT CHAIRMAN", "CLUB HOUSE CHAIRMAN", "BAR AND CATERING CHAIRMAN", "HON. TREASURE"})
        Me.Cbo_Approvedby.Location = New System.Drawing.Point(103, 118)
        Me.Cbo_Approvedby.MaxLength = 25
        Me.Cbo_Approvedby.Name = "Cbo_Approvedby"
        Me.Cbo_Approvedby.Size = New System.Drawing.Size(152, 22)
        Me.Cbo_Approvedby.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 14)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "APPROVED BY  :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 14)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "QUOT.  NO.  :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_QuotNo
        '
        Me.Txt_QuotNo.BackColor = System.Drawing.Color.White
        Me.Txt_QuotNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_QuotNo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_QuotNo.Location = New System.Drawing.Point(103, 92)
        Me.Txt_QuotNo.MaxLength = 10
        Me.Txt_QuotNo.Name = "Txt_QuotNo"
        Me.Txt_QuotNo.ReadOnly = True
        Me.Txt_QuotNo.Size = New System.Drawing.Size(152, 20)
        Me.Txt_QuotNo.TabIndex = 3
        Me.Txt_QuotNo.Text = "NA"
        '
        'Cmd_VcodeHelp
        '
        Me.Cmd_VcodeHelp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_VcodeHelp.Image = CType(resources.GetObject("Cmd_VcodeHelp.Image"), System.Drawing.Image)
        Me.Cmd_VcodeHelp.Location = New System.Drawing.Point(619, 61)
        Me.Cmd_VcodeHelp.Name = "Cmd_VcodeHelp"
        Me.Cmd_VcodeHelp.Size = New System.Drawing.Size(24, 25)
        Me.Cmd_VcodeHelp.TabIndex = 21
        '
        'Txt_Vcode
        '
        Me.Txt_Vcode.BackColor = System.Drawing.Color.White
        Me.Txt_Vcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Vcode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Vcode.Location = New System.Drawing.Point(463, 64)
        Me.Txt_Vcode.MaxLength = 10
        Me.Txt_Vcode.Name = "Txt_Vcode"
        Me.Txt_Vcode.ReadOnly = True
        Me.Txt_Vcode.Size = New System.Drawing.Size(153, 20)
        Me.Txt_Vcode.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(359, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 23)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "NAME  :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_Vname
        '
        Me.Txt_Vname.BackColor = System.Drawing.Color.White
        Me.Txt_Vname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Vname.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Vname.Location = New System.Drawing.Point(463, 90)
        Me.Txt_Vname.MaxLength = 50
        Me.Txt_Vname.Name = "Txt_Vname"
        Me.Txt_Vname.ReadOnly = True
        Me.Txt_Vname.Size = New System.Drawing.Size(182, 20)
        Me.Txt_Vname.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(355, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 23)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "VENDOR CODE  :"
        '
        'Cmd_PONoHelp
        '
        Me.Cmd_PONoHelp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_PONoHelp.Image = CType(resources.GetObject("Cmd_PONoHelp.Image"), System.Drawing.Image)
        Me.Cmd_PONoHelp.Location = New System.Drawing.Point(620, 10)
        Me.Cmd_PONoHelp.Name = "Cmd_PONoHelp"
        Me.Cmd_PONoHelp.Size = New System.Drawing.Size(24, 25)
        Me.Cmd_PONoHelp.TabIndex = 1
        '
        'txt_PONo
        '
        Me.txt_PONo.BackColor = System.Drawing.Color.White
        Me.txt_PONo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PONo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PONo.Location = New System.Drawing.Point(464, 13)
        Me.txt_PONo.MaxLength = 25
        Me.txt_PONo.Name = "txt_PONo"
        Me.txt_PONo.Size = New System.Drawing.Size(152, 20)
        Me.txt_PONo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "P.O. DATE :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(5, 68)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(87, 14)
        Me.Label38.TabIndex = 570
        Me.Label38.Text = "DEPARTMENT  :"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_GroupCode
        '
        Me.lbl_GroupCode.AutoSize = True
        Me.lbl_GroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupCode.Location = New System.Drawing.Point(357, 15)
        Me.lbl_GroupCode.Name = "lbl_GroupCode"
        Me.lbl_GroupCode.Size = New System.Drawing.Size(60, 14)
        Me.lbl_GroupCode.TabIndex = 9
        Me.lbl_GroupCode.Text = "P.O.  NO.  :"
        Me.lbl_GroupCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(5, 13)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(74, 14)
        Me.Label47.TabIndex = 576
        Me.Label47.Text = "CATEGORY  :"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbo_warehouse
        '
        Me.cbo_warehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_warehouse.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_warehouse.Location = New System.Drawing.Point(103, 10)
        Me.cbo_warehouse.Name = "cbo_warehouse"
        Me.cbo_warehouse.Size = New System.Drawing.Size(121, 22)
        Me.cbo_warehouse.TabIndex = 5589
        '
        'Txt_GLAcIn
        '
        Me.Txt_GLAcIn.BackColor = System.Drawing.Color.White
        Me.Txt_GLAcIn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_GLAcIn.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_GLAcIn.Location = New System.Drawing.Point(5, 398)
        Me.Txt_GLAcIn.MaxLength = 10
        Me.Txt_GLAcIn.Name = "Txt_GLAcIn"
        Me.Txt_GLAcIn.Size = New System.Drawing.Size(136, 20)
        Me.Txt_GLAcIn.TabIndex = 573
        Me.Txt_GLAcIn.Visible = False
        '
        'cmd_GLAcInHelp
        '
        Me.cmd_GLAcInHelp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_GLAcInHelp.Image = CType(resources.GetObject("cmd_GLAcInHelp.Image"), System.Drawing.Image)
        Me.cmd_GLAcInHelp.Location = New System.Drawing.Point(141, 398)
        Me.cmd_GLAcInHelp.Name = "cmd_GLAcInHelp"
        Me.cmd_GLAcInHelp.Size = New System.Drawing.Size(24, 25)
        Me.cmd_GLAcInHelp.TabIndex = 575
        Me.cmd_GLAcInHelp.Visible = False
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(21, 328)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(120, 23)
        Me.Label46.TabIndex = 574
        Me.Label46.Text = "GL A/C CODE      :"
        Me.Label46.Visible = False
        '
        'Cbo_Dept1
        '
        Me.Cbo_Dept1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Dept1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Dept1.Location = New System.Drawing.Point(48, 274)
        Me.Cbo_Dept1.MaxDropDownItems = 60
        Me.Cbo_Dept1.MaxLength = 40
        Me.Cbo_Dept1.Name = "Cbo_Dept1"
        Me.Cbo_Dept1.Size = New System.Drawing.Size(32, 22)
        Me.Cbo_Dept1.TabIndex = 0
        Me.Cbo_Dept1.Visible = False
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(21, 447)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 23)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "APPROVED DATE :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label13.Visible = False
        '
        'Cbo_ApprDate
        '
        Me.Cbo_ApprDate.CustomFormat = "dd-MMM-yyyy"
        Me.Cbo_ApprDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_ApprDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cbo_ApprDate.Location = New System.Drawing.Point(28, 516)
        Me.Cbo_ApprDate.Name = "Cbo_ApprDate"
        Me.Cbo_ApprDate.Size = New System.Drawing.Size(137, 20)
        Me.Cbo_ApprDate.TabIndex = 6
        Me.Cbo_ApprDate.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.CMD_BROWSE)
        Me.GroupBox4.Controls.Add(Me.cmd_dos_print)
        Me.GroupBox4.Controls.Add(Me.cmd_auth)
        Me.GroupBox4.Controls.Add(Me.CmdExit)
        Me.GroupBox4.Controls.Add(Me.cmd_export)
        Me.GroupBox4.Controls.Add(Me.CmdClear)
        Me.GroupBox4.Controls.Add(Me.CmdAdd)
        Me.GroupBox4.Controls.Add(Me.CmdFreeze)
        Me.GroupBox4.Controls.Add(Me.CmdView)
        Me.GroupBox4.Controls.Add(Me.CmdPrint)
        Me.GroupBox4.Location = New System.Drawing.Point(861, 78)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(145, 608)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        '
        'CMD_BROWSE
        '
        Me.CMD_BROWSE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_BROWSE.Location = New System.Drawing.Point(6, 491)
        Me.CMD_BROWSE.Name = "CMD_BROWSE"
        Me.CMD_BROWSE.Size = New System.Drawing.Size(129, 53)
        Me.CMD_BROWSE.TabIndex = 5607
        Me.CMD_BROWSE.Text = "Browse"
        Me.CMD_BROWSE.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CMD_BROWSE.UseVisualStyleBackColor = True
        '
        'cmd_dos_print
        '
        Me.cmd_dos_print.BackColor = System.Drawing.Color.Transparent
        Me.cmd_dos_print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_dos_print.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_dos_print.ForeColor = System.Drawing.Color.Black
        Me.cmd_dos_print.Image = Global.SmartCard.My.Resources.Resources.print
        Me.cmd_dos_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_dos_print.Location = New System.Drawing.Point(5, 315)
        Me.cmd_dos_print.Name = "cmd_dos_print"
        Me.cmd_dos_print.Size = New System.Drawing.Size(134, 56)
        Me.cmd_dos_print.TabIndex = 5606
        Me.cmd_dos_print.Text = "Dos Print"
        Me.cmd_dos_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_dos_print.UseVisualStyleBackColor = False
        '
        'cmd_auth
        '
        Me.cmd_auth.BackColor = System.Drawing.Color.Transparent
        Me.cmd_auth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_auth.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_auth.ForeColor = System.Drawing.Color.Black
        Me.cmd_auth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_auth.Location = New System.Drawing.Point(5, 437)
        Me.cmd_auth.Name = "cmd_auth"
        Me.cmd_auth.Size = New System.Drawing.Size(134, 48)
        Me.cmd_auth.TabIndex = 5605
        Me.cmd_auth.Text = " Authorize"
        Me.cmd_auth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_auth.UseVisualStyleBackColor = False
        '
        'CmdExit
        '
        Me.CmdExit.BackColor = System.Drawing.Color.Transparent
        Me.CmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdExit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.ForeColor = System.Drawing.Color.Black
        Me.CmdExit.Image = Global.SmartCard.My.Resources.Resources._Exit
        Me.CmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdExit.Location = New System.Drawing.Point(5, 546)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(134, 56)
        Me.CmdExit.TabIndex = 5604
        Me.CmdExit.Text = "Exit[F11]"
        Me.CmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdExit.UseVisualStyleBackColor = False
        '
        'cmd_export
        '
        Me.cmd_export.BackColor = System.Drawing.Color.Transparent
        Me.cmd_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_export.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_export.ForeColor = System.Drawing.Color.Black
        Me.cmd_export.Image = Global.SmartCard.My.Resources.Resources.excel
        Me.cmd_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_export.Location = New System.Drawing.Point(4, 376)
        Me.cmd_export.Name = "cmd_export"
        Me.cmd_export.Size = New System.Drawing.Size(134, 56)
        Me.cmd_export.TabIndex = 5603
        Me.cmd_export.Text = "Export"
        Me.cmd_export.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_export.UseVisualStyleBackColor = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.Transparent
        Me.CmdClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.Black
        Me.CmdClear.Image = Global.SmartCard.My.Resources.Resources.Clear
        Me.CmdClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdClear.Location = New System.Drawing.Point(2, 12)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(134, 56)
        Me.CmdClear.TabIndex = 19
        Me.CmdClear.Text = "Clear[F6]"
        Me.CmdClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdClear.UseVisualStyleBackColor = False
        '
        'CmdAdd
        '
        Me.CmdAdd.BackColor = System.Drawing.Color.Transparent
        Me.CmdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdAdd.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.ForeColor = System.Drawing.Color.Black
        Me.CmdAdd.Image = Global.SmartCard.My.Resources.Resources.save
        Me.CmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAdd.Location = New System.Drawing.Point(1, 71)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(134, 56)
        Me.CmdAdd.TabIndex = 29
        Me.CmdAdd.Text = "Add [F7]"
        Me.CmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdAdd.UseVisualStyleBackColor = False
        '
        'CmdFreeze
        '
        Me.CmdFreeze.BackColor = System.Drawing.Color.Transparent
        Me.CmdFreeze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdFreeze.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdFreeze.ForeColor = System.Drawing.Color.Black
        Me.CmdFreeze.Image = Global.SmartCard.My.Resources.Resources.Delete
        Me.CmdFreeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdFreeze.Location = New System.Drawing.Point(2, 131)
        Me.CmdFreeze.Name = "CmdFreeze"
        Me.CmdFreeze.Size = New System.Drawing.Size(134, 56)
        Me.CmdFreeze.TabIndex = 20
        Me.CmdFreeze.Text = "Freeze[F8]"
        Me.CmdFreeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdFreeze.UseVisualStyleBackColor = False
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.Transparent
        Me.CmdView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdView.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.Black
        Me.CmdView.Image = Global.SmartCard.My.Resources.Resources.view
        Me.CmdView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdView.Location = New System.Drawing.Point(2, 191)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(134, 56)
        Me.CmdView.TabIndex = 21
        Me.CmdView.Text = " View[F9]"
        Me.CmdView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdView.UseVisualStyleBackColor = False
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.Transparent
        Me.CmdPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdPrint.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.Black
        Me.CmdPrint.Image = Global.SmartCard.My.Resources.Resources.print
        Me.CmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdPrint.Location = New System.Drawing.Point(3, 253)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(134, 56)
        Me.CmdPrint.TabIndex = 22
        Me.CmdPrint.Text = "Print[F10]"
        Me.CmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdPrint.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(52, 581)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 5579
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(124, 581)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 5578
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(90, 581)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 5577
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TXT_ADVANCEPERC)
        Me.GroupBox3.Controls.Add(Me.Label57)
        Me.GroupBox3.Controls.Add(Me.Label56)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Txt_Insurance)
        Me.GroupBox3.Controls.Add(Me.Txt_LST)
        Me.GroupBox3.Controls.Add(Me.Txt_MODVat)
        Me.GroupBox3.Controls.Add(Me.Txt_PTax)
        Me.GroupBox3.Controls.Add(Me.Txt_Octra)
        Me.GroupBox3.Controls.Add(Me.Txt_ED)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Txt_CST)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Location = New System.Drawing.Point(179, 466)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(675, 66)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        '
        'TXT_ADVANCEPERC
        '
        Me.TXT_ADVANCEPERC.BackColor = System.Drawing.Color.LightBlue
        Me.TXT_ADVANCEPERC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_ADVANCEPERC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ADVANCEPERC.Location = New System.Drawing.Point(588, 35)
        Me.TXT_ADVANCEPERC.MaxLength = 4
        Me.TXT_ADVANCEPERC.Name = "TXT_ADVANCEPERC"
        Me.TXT_ADVANCEPERC.Size = New System.Drawing.Size(72, 20)
        Me.TXT_ADVANCEPERC.TabIndex = 579
        Me.TXT_ADVANCEPERC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(659, 34)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(24, 23)
        Me.Label57.TabIndex = 578
        Me.Label57.Text = "%"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(526, 37)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(61, 14)
        Me.Label56.TabIndex = 576
        Me.Label56.Text = "ADVANCE:"
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(144, 37)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(24, 23)
        Me.Label36.TabIndex = 575
        Me.Label36.Text = "%"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(337, 37)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(24, 23)
        Me.Label35.TabIndex = 574
        Me.Label35.Text = "%"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(507, 36)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(24, 23)
        Me.Label34.TabIndex = 573
        Me.Label34.Text = "%"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(659, 10)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(15, 23)
        Me.Label33.TabIndex = 572
        Me.Label33.Text = "%"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(507, 9)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(24, 23)
        Me.Label32.TabIndex = 571
        Me.Label32.Text = "%"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(337, 10)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(24, 23)
        Me.Label31.TabIndex = 570
        Me.Label31.Text = "%"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(146, 9)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(24, 23)
        Me.Label30.TabIndex = 569
        Me.Label30.Text = "%"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_Insurance
        '
        Me.Txt_Insurance.BackColor = System.Drawing.Color.LightBlue
        Me.Txt_Insurance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Insurance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Insurance.Location = New System.Drawing.Point(265, 37)
        Me.Txt_Insurance.MaxLength = 4
        Me.Txt_Insurance.Name = "Txt_Insurance"
        Me.Txt_Insurance.Size = New System.Drawing.Size(72, 20)
        Me.Txt_Insurance.TabIndex = 14
        Me.Txt_Insurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_LST
        '
        Me.Txt_LST.BackColor = System.Drawing.Color.LightBlue
        Me.Txt_LST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_LST.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_LST.Location = New System.Drawing.Point(435, 36)
        Me.Txt_LST.MaxLength = 4
        Me.Txt_LST.Name = "Txt_LST"
        Me.Txt_LST.Size = New System.Drawing.Size(72, 20)
        Me.Txt_LST.TabIndex = 15
        Me.Txt_LST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_MODVat
        '
        Me.Txt_MODVat.BackColor = System.Drawing.Color.LightBlue
        Me.Txt_MODVat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_MODVat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MODVat.Location = New System.Drawing.Point(435, 9)
        Me.Txt_MODVat.MaxLength = 4
        Me.Txt_MODVat.Name = "Txt_MODVat"
        Me.Txt_MODVat.Size = New System.Drawing.Size(72, 20)
        Me.Txt_MODVat.TabIndex = 11
        Me.Txt_MODVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_PTax
        '
        Me.Txt_PTax.BackColor = System.Drawing.Color.LightBlue
        Me.Txt_PTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_PTax.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PTax.Location = New System.Drawing.Point(588, 11)
        Me.Txt_PTax.MaxLength = 4
        Me.Txt_PTax.Name = "Txt_PTax"
        Me.Txt_PTax.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PTax.TabIndex = 12
        Me.Txt_PTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_Octra
        '
        Me.Txt_Octra.BackColor = System.Drawing.Color.LightBlue
        Me.Txt_Octra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Octra.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Octra.Location = New System.Drawing.Point(66, 37)
        Me.Txt_Octra.MaxLength = 4
        Me.Txt_Octra.Name = "Txt_Octra"
        Me.Txt_Octra.Size = New System.Drawing.Size(72, 21)
        Me.Txt_Octra.TabIndex = 13
        Me.Txt_Octra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_ED
        '
        Me.Txt_ED.BackColor = System.Drawing.Color.LightBlue
        Me.Txt_ED.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_ED.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ED.Location = New System.Drawing.Point(67, 10)
        Me.Txt_ED.MaxLength = 4
        Me.Txt_ED.Name = "Txt_ED"
        Me.Txt_ED.Size = New System.Drawing.Size(72, 21)
        Me.Txt_ED.TabIndex = 9
        Me.Txt_ED.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(363, 12)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 14)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "MOD VAT  :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(542, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 23)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "P. TAX :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 38)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 14)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "OCTROI  :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(209, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(44, 14)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "CST    :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_CST
        '
        Me.Txt_CST.BackColor = System.Drawing.Color.LightBlue
        Me.Txt_CST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_CST.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CST.Location = New System.Drawing.Point(265, 10)
        Me.Txt_CST.MaxLength = 4
        Me.Txt_CST.Name = "Txt_CST"
        Me.Txt_CST.Size = New System.Drawing.Size(72, 20)
        Me.Txt_CST.TabIndex = 10
        Me.Txt_CST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(390, 35)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(44, 23)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "LST  :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(177, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(84, 23)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "INSURANCE  :"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(22, 10)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 23)
        Me.Label23.TabIndex = 12
        Me.Label23.Text = "E.D.   :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ssgrid
        '
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(196, 287)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(639, 126)
        Me.ssgrid.TabIndex = 8
        '
        'grp_freight
        '
        Me.grp_freight.BackColor = System.Drawing.Color.Transparent
        Me.grp_freight.Controls.Add(Me.Cmb_Freight)
        Me.grp_freight.Controls.Add(Me.Lbl_Freight)
        Me.grp_freight.Controls.Add(Me.Cmb_shipping)
        Me.grp_freight.Controls.Add(Me.Cmb_despatch)
        Me.grp_freight.Controls.Add(Me.Label26)
        Me.grp_freight.Controls.Add(Me.Label28)
        Me.grp_freight.Controls.Add(Me.Cmb_delivery)
        Me.grp_freight.Controls.Add(Me.Label24)
        Me.grp_freight.Location = New System.Drawing.Point(150, 1000)
        Me.grp_freight.Name = "grp_freight"
        Me.grp_freight.Size = New System.Drawing.Size(912, 48)
        Me.grp_freight.TabIndex = 564
        Me.grp_freight.TabStop = False
        '
        'Cmb_Freight
        '
        Me.Cmb_Freight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Freight.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Freight.Items.AddRange(New Object() {"PAID", "TO BE PAID"})
        Me.Cmb_Freight.Location = New System.Drawing.Point(88, 16)
        Me.Cmb_Freight.MaxLength = 25
        Me.Cmb_Freight.Name = "Cmb_Freight"
        Me.Cmb_Freight.Size = New System.Drawing.Size(104, 25)
        Me.Cmb_Freight.TabIndex = 581
        '
        'Lbl_Freight
        '
        Me.Lbl_Freight.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Freight.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Freight.Location = New System.Drawing.Point(16, 16)
        Me.Lbl_Freight.Name = "Lbl_Freight"
        Me.Lbl_Freight.Size = New System.Drawing.Size(80, 16)
        Me.Lbl_Freight.TabIndex = 582
        Me.Lbl_Freight.Text = "FREIGHT :"
        '
        'Cmb_shipping
        '
        Me.Cmb_shipping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_shipping.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_shipping.Items.AddRange(New Object() {"NIL", "CHENNAI", "VIZAG", "OTHERS"})
        Me.Cmb_shipping.Location = New System.Drawing.Point(568, 16)
        Me.Cmb_shipping.MaxLength = 25
        Me.Cmb_shipping.Name = "Cmb_shipping"
        Me.Cmb_shipping.Size = New System.Drawing.Size(104, 25)
        Me.Cmb_shipping.TabIndex = 22
        Me.Cmb_shipping.Visible = False
        '
        'Cmb_despatch
        '
        Me.Cmb_despatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_despatch.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_despatch.Items.AddRange(New Object() {"NIL", "CHENNAI", "VIZAG", "OTHERS"})
        Me.Cmb_despatch.Location = New System.Drawing.Point(328, 16)
        Me.Cmb_despatch.MaxLength = 25
        Me.Cmb_despatch.Name = "Cmb_despatch"
        Me.Cmb_despatch.Size = New System.Drawing.Size(104, 25)
        Me.Cmb_despatch.TabIndex = 21
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(448, 18)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(120, 23)
        Me.Label26.TabIndex = 20
        Me.Label26.Text = "SHIPPING PORT :"
        Me.Label26.Visible = False
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(200, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(128, 23)
        Me.Label28.TabIndex = 12
        Me.Label28.Text = "DESPATCH PORT :"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cmb_delivery
        '
        Me.Cmb_delivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_delivery.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_delivery.Items.AddRange(New Object() {"NIL", "CHENNAI", "VIZAG", "OTHERS"})
        Me.Cmb_delivery.Location = New System.Drawing.Point(800, 16)
        Me.Cmb_delivery.MaxLength = 25
        Me.Cmb_delivery.Name = "Cmb_delivery"
        Me.Cmb_delivery.Size = New System.Drawing.Size(104, 25)
        Me.Cmb_delivery.TabIndex = 23
        Me.Cmb_delivery.Visible = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(688, 18)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(113, 15)
        Me.Label24.TabIndex = 26
        Me.Label24.Text = "DELIVERY PORT :"
        Me.Label24.Visible = False
        '
        'grp_encl
        '
        Me.grp_encl.BackColor = System.Drawing.Color.Transparent
        Me.grp_encl.Controls.Add(Me.Chk_MC_Form)
        Me.grp_encl.Controls.Add(Me.Txt_Encl)
        Me.grp_encl.Controls.Add(Me.Label9)
        Me.grp_encl.Location = New System.Drawing.Point(250, 1000)
        Me.grp_encl.Name = "grp_encl"
        Me.grp_encl.Size = New System.Drawing.Size(912, 40)
        Me.grp_encl.TabIndex = 584
        Me.grp_encl.TabStop = False
        '
        'Chk_MC_Form
        '
        Me.Chk_MC_Form.Appearance = System.Windows.Forms.Appearance.Button
        Me.Chk_MC_Form.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Chk_MC_Form.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_MC_Form.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Chk_MC_Form.Location = New System.Drawing.Point(800, 10)
        Me.Chk_MC_Form.Name = "Chk_MC_Form"
        Me.Chk_MC_Form.Size = New System.Drawing.Size(96, 24)
        Me.Chk_MC_Form.TabIndex = 29
        Me.Chk_MC_Form.Text = "M . C . FORM"
        Me.Chk_MC_Form.UseVisualStyleBackColor = False
        '
        'Txt_Encl
        '
        Me.Txt_Encl.BackColor = System.Drawing.Color.White
        Me.Txt_Encl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Encl.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Encl.Location = New System.Drawing.Point(112, 12)
        Me.Txt_Encl.MaxLength = 50
        Me.Txt_Encl.Name = "Txt_Encl"
        Me.Txt_Encl.Size = New System.Drawing.Size(136, 22)
        Me.Txt_Encl.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 23)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "ENCLOSURES :"
        '
        'Txt_POTerms
        '
        Me.Txt_POTerms.BackColor = System.Drawing.Color.White
        Me.Txt_POTerms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_POTerms.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_POTerms.Location = New System.Drawing.Point(102, 11)
        Me.Txt_POTerms.MaxLength = 25
        Me.Txt_POTerms.Name = "Txt_POTerms"
        Me.Txt_POTerms.Size = New System.Drawing.Size(59, 20)
        Me.Txt_POTerms.TabIndex = 5558
        Me.Txt_POTerms.Text = "CHQ"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(305, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 5562
        Me.Label5.Text = "BALANCE :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(463, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 23)
        Me.Label4.TabIndex = 5561
        Me.Label4.Text = "TOTAL VAT :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cmd_POTermsHelp
        '
        Me.Cmd_POTermsHelp.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_POTermsHelp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_POTermsHelp.Image = CType(resources.GetObject("Cmd_POTermsHelp.Image"), System.Drawing.Image)
        Me.Cmd_POTermsHelp.Location = New System.Drawing.Point(161, 9)
        Me.Cmd_POTermsHelp.Name = "Cmd_POTermsHelp"
        Me.Cmd_POTermsHelp.Size = New System.Drawing.Size(24, 25)
        Me.Cmd_POTermsHelp.TabIndex = 5559
        Me.Cmd_POTermsHelp.UseVisualStyleBackColor = False
        '
        'Txt_AdvanceAmt
        '
        Me.Txt_AdvanceAmt.BackColor = System.Drawing.Color.LightBlue
        Me.Txt_AdvanceAmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_AdvanceAmt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_AdvanceAmt.Location = New System.Drawing.Point(208, 15)
        Me.Txt_AdvanceAmt.MaxLength = 12
        Me.Txt_AdvanceAmt.Name = "Txt_AdvanceAmt"
        Me.Txt_AdvanceAmt.Size = New System.Drawing.Size(96, 20)
        Me.Txt_AdvanceAmt.TabIndex = 5557
        Me.Txt_AdvanceAmt.TabStop = False
        Me.Txt_AdvanceAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(1, 14)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(103, 14)
        Me.Label22.TabIndex = 5556
        Me.Label22.Text = "PAYMENT TERMS :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(130, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 23)
        Me.Label6.TabIndex = 5564
        Me.Label6.Text = "ADVANCE :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_TotalTax
        '
        Me.Txt_TotalTax.BackColor = System.Drawing.Color.LightBlue
        Me.Txt_TotalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_TotalTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_TotalTax.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TotalTax.Location = New System.Drawing.Point(552, 18)
        Me.Txt_TotalTax.MaxLength = 12
        Me.Txt_TotalTax.Name = "Txt_TotalTax"
        Me.Txt_TotalTax.ReadOnly = True
        Me.Txt_TotalTax.Size = New System.Drawing.Size(64, 20)
        Me.Txt_TotalTax.TabIndex = 5568
        Me.Txt_TotalTax.TabStop = False
        Me.Txt_TotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_Balance
        '
        Me.Txt_Balance.BackColor = System.Drawing.Color.LightBlue
        Me.Txt_Balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Balance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Balance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Balance.Location = New System.Drawing.Point(375, 77)
        Me.Txt_Balance.MaxLength = 12
        Me.Txt_Balance.Name = "Txt_Balance"
        Me.Txt_Balance.ReadOnly = True
        Me.Txt_Balance.Size = New System.Drawing.Size(80, 20)
        Me.Txt_Balance.TabIndex = 5569
        Me.Txt_Balance.TabStop = False
        Me.Txt_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_TotalVat
        '
        Me.Txt_TotalVat.BackColor = System.Drawing.Color.LightBlue
        Me.Txt_TotalVat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_TotalVat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_TotalVat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TotalVat.Location = New System.Drawing.Point(375, 43)
        Me.Txt_TotalVat.MaxLength = 12
        Me.Txt_TotalVat.Name = "Txt_TotalVat"
        Me.Txt_TotalVat.ReadOnly = True
        Me.Txt_TotalVat.Size = New System.Drawing.Size(72, 20)
        Me.Txt_TotalVat.TabIndex = 5570
        Me.Txt_TotalVat.TabStop = False
        Me.Txt_TotalVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_DeliveryTerms
        '
        Me.Txt_DeliveryTerms.BackColor = System.Drawing.Color.White
        Me.Txt_DeliveryTerms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_DeliveryTerms.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DeliveryTerms.Location = New System.Drawing.Point(102, 36)
        Me.Txt_DeliveryTerms.MaxLength = 25
        Me.Txt_DeliveryTerms.Name = "Txt_DeliveryTerms"
        Me.Txt_DeliveryTerms.Size = New System.Drawing.Size(59, 20)
        Me.Txt_DeliveryTerms.TabIndex = 22
        Me.Txt_DeliveryTerms.Text = "IMM"
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(605, 53)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(139, 16)
        Me.lbl_Freeze.TabIndex = 5572
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'grp_cstform
        '
        Me.grp_cstform.BackColor = System.Drawing.Color.Transparent
        Me.grp_cstform.Controls.Add(Me.Label10)
        Me.grp_cstform.Controls.Add(Me.Txt_CreditDays)
        Me.grp_cstform.Controls.Add(Me.Cbo_Closure)
        Me.grp_cstform.Controls.Add(Me.Label37)
        Me.grp_cstform.Controls.Add(Me.Cmb_CSTForm)
        Me.grp_cstform.Controls.Add(Me.Label39)
        Me.grp_cstform.Location = New System.Drawing.Point(250, 1000)
        Me.grp_cstform.Name = "grp_cstform"
        Me.grp_cstform.Size = New System.Drawing.Size(912, 38)
        Me.grp_cstform.TabIndex = 5575
        Me.grp_cstform.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(28, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 15)
        Me.Label10.TabIndex = 5579
        Me.Label10.Text = "CREDIT DAYS :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_CreditDays
        '
        Me.Txt_CreditDays.BackColor = System.Drawing.Color.LightBlue
        Me.Txt_CreditDays.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_CreditDays.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CreditDays.Location = New System.Drawing.Point(140, 9)
        Me.Txt_CreditDays.MaxLength = 3
        Me.Txt_CreditDays.Name = "Txt_CreditDays"
        Me.Txt_CreditDays.Size = New System.Drawing.Size(72, 22)
        Me.Txt_CreditDays.TabIndex = 5580
        '
        'Cbo_Closure
        '
        Me.Cbo_Closure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Closure.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Closure.Items.AddRange(New Object() {"CLOSURE", "FORCIBLE"})
        Me.Cbo_Closure.Location = New System.Drawing.Point(780, 6)
        Me.Cbo_Closure.Name = "Cbo_Closure"
        Me.Cbo_Closure.Size = New System.Drawing.Size(104, 25)
        Me.Cbo_Closure.TabIndex = 5578
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(652, 6)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(96, 23)
        Me.Label37.TabIndex = 5577
        Me.Label37.Text = "CLOSURE :"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cmb_CSTForm
        '
        Me.Cmb_CSTForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_CSTForm.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_CSTForm.Items.AddRange(New Object() {"YES", "NO"})
        Me.Cmb_CSTForm.Location = New System.Drawing.Point(492, 7)
        Me.Cmb_CSTForm.MaxLength = 25
        Me.Cmb_CSTForm.Name = "Cmb_CSTForm"
        Me.Cmb_CSTForm.Size = New System.Drawing.Size(104, 25)
        Me.Cmb_CSTForm.TabIndex = 5575
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(260, 9)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(200, 16)
        Me.Label39.TabIndex = 5576
        Me.Label39.Text = "CST FORM REQUIREMENTS :"
        '
        'Lbl_Marquee
        '
        Me.Lbl_Marquee.AutoSize = True
        Me.Lbl_Marquee.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Marquee.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Marquee.ForeColor = System.Drawing.Color.SteelBlue
        Me.Lbl_Marquee.Location = New System.Drawing.Point(1000, 592)
        Me.Lbl_Marquee.Name = "Lbl_Marquee"
        Me.Lbl_Marquee.Size = New System.Drawing.Size(315, 26)
        Me.Lbl_Marquee.TabIndex = 5578
        Me.Lbl_Marquee.Text = "PURCHASE ORDER FORM"
        Me.Lbl_Marquee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lbl_Marquee.Visible = False
        '
        'Group_MC
        '
        Me.Group_MC.BackColor = System.Drawing.Color.DodgerBlue
        Me.Group_MC.BackgroundImage = CType(resources.GetObject("Group_MC.BackgroundImage"), System.Drawing.Image)
        Me.Group_MC.Controls.Add(Me.Ssgrid_body)
        Me.Group_MC.Controls.Add(Me.Ssgrid_subject)
        Me.Group_MC.Controls.Add(Me.Ssgrid_reference)
        Me.Group_MC.Controls.Add(Me.Txt_OtherTermCode)
        Me.Group_MC.Controls.Add(Me.Cmd_OtherTermCodeHelp)
        Me.Group_MC.Controls.Add(Me.Txt_WarrantyCode)
        Me.Group_MC.Controls.Add(Me.Cmd_WarrantyCodeHelp)
        Me.Group_MC.Controls.Add(Me.Label44)
        Me.Group_MC.Controls.Add(Me.Cmd_Ok)
        Me.Group_MC.Controls.Add(Me.Label43)
        Me.Group_MC.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_MC.Location = New System.Drawing.Point(1000, 80)
        Me.Group_MC.Name = "Group_MC"
        Me.Group_MC.Size = New System.Drawing.Size(920, 552)
        Me.Group_MC.TabIndex = 5579
        Me.Group_MC.TabStop = False
        Me.Group_MC.Text = "Management Committee Purchase Order :"
        Me.Group_MC.Visible = False
        '
        'Ssgrid_body
        '
        Me.Ssgrid_body.DataSource = Nothing
        Me.Ssgrid_body.Location = New System.Drawing.Point(32, 328)
        Me.Ssgrid_body.Name = "Ssgrid_body"
        Me.Ssgrid_body.OcxState = CType(resources.GetObject("Ssgrid_body.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ssgrid_body.Size = New System.Drawing.Size(864, 160)
        Me.Ssgrid_body.TabIndex = 437
        '
        'Ssgrid_subject
        '
        Me.Ssgrid_subject.DataSource = Nothing
        Me.Ssgrid_subject.Location = New System.Drawing.Point(32, 24)
        Me.Ssgrid_subject.Name = "Ssgrid_subject"
        Me.Ssgrid_subject.OcxState = CType(resources.GetObject("Ssgrid_subject.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ssgrid_subject.Size = New System.Drawing.Size(864, 144)
        Me.Ssgrid_subject.TabIndex = 2
        '
        'Ssgrid_reference
        '
        Me.Ssgrid_reference.DataSource = Nothing
        Me.Ssgrid_reference.Location = New System.Drawing.Point(32, 176)
        Me.Ssgrid_reference.Name = "Ssgrid_reference"
        Me.Ssgrid_reference.OcxState = CType(resources.GetObject("Ssgrid_reference.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ssgrid_reference.Size = New System.Drawing.Size(864, 144)
        Me.Ssgrid_reference.TabIndex = 435
        '
        'Txt_OtherTermCode
        '
        Me.Txt_OtherTermCode.BackColor = System.Drawing.Color.White
        Me.Txt_OtherTermCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_OtherTermCode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_OtherTermCode.Location = New System.Drawing.Point(552, 514)
        Me.Txt_OtherTermCode.MaxLength = 25
        Me.Txt_OtherTermCode.Name = "Txt_OtherTermCode"
        Me.Txt_OtherTermCode.Size = New System.Drawing.Size(168, 22)
        Me.Txt_OtherTermCode.TabIndex = 5562
        '
        'Cmd_OtherTermCodeHelp
        '
        Me.Cmd_OtherTermCodeHelp.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_OtherTermCodeHelp.Image = CType(resources.GetObject("Cmd_OtherTermCodeHelp.Image"), System.Drawing.Image)
        Me.Cmd_OtherTermCodeHelp.Location = New System.Drawing.Point(728, 514)
        Me.Cmd_OtherTermCodeHelp.Name = "Cmd_OtherTermCodeHelp"
        Me.Cmd_OtherTermCodeHelp.Size = New System.Drawing.Size(24, 25)
        Me.Cmd_OtherTermCodeHelp.TabIndex = 5563
        Me.Cmd_OtherTermCodeHelp.UseVisualStyleBackColor = False
        '
        'Txt_WarrantyCode
        '
        Me.Txt_WarrantyCode.BackColor = System.Drawing.Color.White
        Me.Txt_WarrantyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_WarrantyCode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_WarrantyCode.Location = New System.Drawing.Point(200, 512)
        Me.Txt_WarrantyCode.MaxLength = 25
        Me.Txt_WarrantyCode.Name = "Txt_WarrantyCode"
        Me.Txt_WarrantyCode.Size = New System.Drawing.Size(168, 22)
        Me.Txt_WarrantyCode.TabIndex = 5560
        '
        'Cmd_WarrantyCodeHelp
        '
        Me.Cmd_WarrantyCodeHelp.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_WarrantyCodeHelp.Image = CType(resources.GetObject("Cmd_WarrantyCodeHelp.Image"), System.Drawing.Image)
        Me.Cmd_WarrantyCodeHelp.Location = New System.Drawing.Point(376, 512)
        Me.Cmd_WarrantyCodeHelp.Name = "Cmd_WarrantyCodeHelp"
        Me.Cmd_WarrantyCodeHelp.Size = New System.Drawing.Size(24, 25)
        Me.Cmd_WarrantyCodeHelp.TabIndex = 5561
        Me.Cmd_WarrantyCodeHelp.UseVisualStyleBackColor = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(408, 514)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(137, 19)
        Me.Label44.TabIndex = 441
        Me.Label44.Text = "OTHER TERMS :"
        '
        'Cmd_Ok
        '
        Me.Cmd_Ok.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Ok.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Ok.ForeColor = System.Drawing.Color.White
        Me.Cmd_Ok.Image = CType(resources.GetObject("Cmd_Ok.Image"), System.Drawing.Image)
        Me.Cmd_Ok.Location = New System.Drawing.Point(767, 510)
        Me.Cmd_Ok.Name = "Cmd_Ok"
        Me.Cmd_Ok.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Ok.TabIndex = 439
        Me.Cmd_Ok.Text = "OK [F5]"
        Me.Cmd_Ok.UseVisualStyleBackColor = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(32, 512)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(161, 19)
        Me.Label43.TabIndex = 440
        Me.Label43.Text = "WARRANTY TERM :"
        '
        'TXT_CF
        '
        Me.TXT_CF.BackColor = System.Drawing.Color.LightBlue
        Me.TXT_CF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_CF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CF.Location = New System.Drawing.Point(375, 20)
        Me.TXT_CF.MaxLength = 12
        Me.TXT_CF.Name = "TXT_CF"
        Me.TXT_CF.Size = New System.Drawing.Size(74, 20)
        Me.TXT_CF.TabIndex = 5583
        Me.TXT_CF.TabStop = False
        Me.TXT_CF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_OVERALLDISC
        '
        Me.TXT_OVERALLDISC.BackColor = System.Drawing.Color.LightBlue
        Me.TXT_OVERALLDISC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_OVERALLDISC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_OVERALLDISC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_OVERALLDISC.Location = New System.Drawing.Point(551, 43)
        Me.TXT_OVERALLDISC.MaxLength = 12
        Me.TXT_OVERALLDISC.Name = "TXT_OVERALLDISC"
        Me.TXT_OVERALLDISC.Size = New System.Drawing.Size(75, 20)
        Me.TXT_OVERALLDISC.TabIndex = 5582
        Me.TXT_OVERALLDISC.TabStop = False
        Me.TXT_OVERALLDISC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(329, 14)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(48, 23)
        Me.Label40.TabIndex = 5581
        Me.Label40.Text = "C && F :"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(452, 39)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(96, 32)
        Me.Label41.TabIndex = 5580
        Me.Label41.Text = "OVRALL DISC  :"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TXT_DELIVERY
        '
        Me.TXT_DELIVERY.BackColor = System.Drawing.Color.LightBlue
        Me.TXT_DELIVERY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_DELIVERY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_DELIVERY.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DELIVERY.Location = New System.Drawing.Point(208, 78)
        Me.TXT_DELIVERY.MaxLength = 12
        Me.TXT_DELIVERY.Name = "TXT_DELIVERY"
        Me.TXT_DELIVERY.Size = New System.Drawing.Size(73, 20)
        Me.TXT_DELIVERY.TabIndex = 5587
        Me.TXT_DELIVERY.TabStop = False
        Me.TXT_DELIVERY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXT_TRANSPORT
        '
        Me.TXT_TRANSPORT.BackColor = System.Drawing.Color.LightBlue
        Me.TXT_TRANSPORT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_TRANSPORT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_TRANSPORT.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TRANSPORT.Location = New System.Drawing.Point(208, 44)
        Me.TXT_TRANSPORT.MaxLength = 12
        Me.TXT_TRANSPORT.Name = "TXT_TRANSPORT"
        Me.TXT_TRANSPORT.Size = New System.Drawing.Size(80, 20)
        Me.TXT_TRANSPORT.TabIndex = 5586
        Me.TXT_TRANSPORT.TabStop = False
        Me.TXT_TRANSPORT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(136, 76)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(70, 23)
        Me.Label42.TabIndex = 5585
        Me.Label42.Text = "DELIVERY :"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(124, 43)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(78, 23)
        Me.Label45.TabIndex = 5584
        Me.Label45.Text = "TRANSPRT :"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_gldesc
        '
        Me.lbl_gldesc.AutoSize = True
        Me.lbl_gldesc.BackColor = System.Drawing.Color.Transparent
        Me.lbl_gldesc.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gldesc.ForeColor = System.Drawing.Color.Black
        Me.lbl_gldesc.Location = New System.Drawing.Point(62, 183)
        Me.lbl_gldesc.Name = "lbl_gldesc"
        Me.lbl_gldesc.Size = New System.Drawing.Size(79, 16)
        Me.lbl_gldesc.TabIndex = 5588
        Me.lbl_gldesc.Text = "GL A/C Desc"
        Me.lbl_gldesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_gldesc.Visible = False
        '
        'Grp_amend_Follow
        '
        Me.Grp_amend_Follow.BackColor = System.Drawing.Color.Transparent
        Me.Grp_amend_Follow.Controls.Add(Me.FollowupGrid)
        Me.Grp_amend_Follow.Controls.Add(Me.Label48)
        Me.Grp_amend_Follow.Controls.Add(Me.Chk_Followup)
        Me.Grp_amend_Follow.Controls.Add(Me.Chk_Amendment)
        Me.Grp_amend_Follow.Controls.Add(Me.Label29)
        Me.Grp_amend_Follow.Controls.Add(Me.Label7)
        Me.Grp_amend_Follow.Controls.Add(Me.AmendmentGrid)
        Me.Grp_amend_Follow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_amend_Follow.Location = New System.Drawing.Point(264, 1000)
        Me.Grp_amend_Follow.Name = "Grp_amend_Follow"
        Me.Grp_amend_Follow.Size = New System.Drawing.Size(504, 304)
        Me.Grp_amend_Follow.TabIndex = 5592
        Me.Grp_amend_Follow.TabStop = False
        '
        'FollowupGrid
        '
        Me.FollowupGrid.DataSource = Nothing
        Me.FollowupGrid.Location = New System.Drawing.Point(32, 200)
        Me.FollowupGrid.Name = "FollowupGrid"
        Me.FollowupGrid.OcxState = CType(resources.GetObject("FollowupGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FollowupGrid.Size = New System.Drawing.Size(452, 72)
        Me.FollowupGrid.TabIndex = 570
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.Maroon
        Me.Label48.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label48.Location = New System.Drawing.Point(32, 24)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(448, 24)
        Me.Label48.TabIndex = 5580
        Me.Label48.Text = "AMENDMENT && FOLLOWUP"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Chk_Followup
        '
        Me.Chk_Followup.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Followup.Location = New System.Drawing.Point(192, 176)
        Me.Chk_Followup.Name = "Chk_Followup"
        Me.Chk_Followup.Size = New System.Drawing.Size(16, 16)
        Me.Chk_Followup.TabIndex = 5579
        Me.Chk_Followup.UseVisualStyleBackColor = False
        Me.Chk_Followup.Visible = False
        '
        'Chk_Amendment
        '
        Me.Chk_Amendment.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Amendment.Location = New System.Drawing.Point(192, 56)
        Me.Chk_Amendment.Name = "Chk_Amendment"
        Me.Chk_Amendment.Size = New System.Drawing.Size(16, 16)
        Me.Chk_Amendment.TabIndex = 5578
        Me.Chk_Amendment.UseVisualStyleBackColor = False
        Me.Chk_Amendment.Visible = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(32, 176)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(143, 15)
        Me.Label29.TabIndex = 571
        Me.Label29.Text = "FOLLOW UP DETAILS :"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 15)
        Me.Label7.TabIndex = 569
        Me.Label7.Text = "AMENDMENT DETAILS :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AmendmentGrid
        '
        Me.AmendmentGrid.DataSource = Nothing
        Me.AmendmentGrid.Location = New System.Drawing.Point(32, 72)
        Me.AmendmentGrid.Name = "AmendmentGrid"
        Me.AmendmentGrid.OcxState = CType(resources.GetObject("AmendmentGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AmendmentGrid.Size = New System.Drawing.Size(448, 88)
        Me.AmendmentGrid.TabIndex = 567
        '
        'Cmd_DeliveryTermHelp
        '
        Me.Cmd_DeliveryTermHelp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_DeliveryTermHelp.Image = CType(resources.GetObject("Cmd_DeliveryTermHelp.Image"), System.Drawing.Image)
        Me.Cmd_DeliveryTermHelp.Location = New System.Drawing.Point(162, 33)
        Me.Cmd_DeliveryTermHelp.Name = "Cmd_DeliveryTermHelp"
        Me.Cmd_DeliveryTermHelp.Size = New System.Drawing.Size(24, 25)
        Me.Cmd_DeliveryTermHelp.TabIndex = 5593
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(2, 38)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(101, 14)
        Me.Label27.TabIndex = 22
        Me.Label27.Text = "DELIVERY TERMS:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.chk_amnd_foll)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Txt_POValue)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Chk_item)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.TXT_CF)
        Me.GroupBox2.Controls.Add(Me.TXT_DELIVERY)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Controls.Add(Me.TXT_TRANSPORT)
        Me.GroupBox2.Controls.Add(Me.TXT_OVERALLDISC)
        Me.GroupBox2.Controls.Add(Me.Txt_TotalTax)
        Me.GroupBox2.Controls.Add(Me.Txt_TotalVat)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Txt_Balance)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Txt_AdvanceAmt)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Location = New System.Drawing.Point(181, 582)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(671, 104)
        Me.GroupBox2.TabIndex = 5596
        Me.GroupBox2.TabStop = False
        '
        'chk_amnd_foll
        '
        Me.chk_amnd_foll.BackColor = System.Drawing.Color.Transparent
        Me.chk_amnd_foll.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_amnd_foll.Location = New System.Drawing.Point(6, 24)
        Me.chk_amnd_foll.Name = "chk_amnd_foll"
        Me.chk_amnd_foll.Size = New System.Drawing.Size(109, 39)
        Me.chk_amnd_foll.TabIndex = 5603
        Me.chk_amnd_foll.Text = "Amendment && Followup"
        Me.chk_amnd_foll.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(297, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 23)
        Me.Label3.TabIndex = 5603
        Me.Label3.Text = "TOTAL TAX :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_POValue
        '
        Me.Txt_POValue.BackColor = System.Drawing.Color.Pink
        Me.Txt_POValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_POValue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_POValue.Location = New System.Drawing.Point(551, 72)
        Me.Txt_POValue.MaxLength = 12
        Me.Txt_POValue.Name = "Txt_POValue"
        Me.Txt_POValue.ReadOnly = True
        Me.Txt_POValue.Size = New System.Drawing.Size(107, 20)
        Me.Txt_POValue.TabIndex = 5598
        Me.Txt_POValue.TabStop = False
        Me.Txt_POValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(472, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 32)
        Me.Label2.TabIndex = 5599
        Me.Label2.Text = "P.O. VALUE :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Chk_item
        '
        Me.Chk_item.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_item.Location = New System.Drawing.Point(5, 72)
        Me.Chk_item.Name = "Chk_item"
        Me.Chk_item.Size = New System.Drawing.Size(119, 22)
        Me.Chk_item.TabIndex = 5602
        Me.Chk_item.Text = "FooterUpdation"
        '
        'grp_footer
        '
        Me.grp_footer.BackColor = System.Drawing.Color.Transparent
        Me.grp_footer.Controls.Add(Me.Txt_signature)
        Me.grp_footer.Controls.Add(Me.Txt_footer)
        Me.grp_footer.Controls.Add(Me.Label49)
        Me.grp_footer.Controls.Add(Me.Label50)
        Me.grp_footer.Controls.Add(Me.Label51)
        Me.grp_footer.Location = New System.Drawing.Point(133, 493)
        Me.grp_footer.Name = "grp_footer"
        Me.grp_footer.Size = New System.Drawing.Size(674, 80)
        Me.grp_footer.TabIndex = 5601
        Me.grp_footer.TabStop = False
        '
        'Txt_signature
        '
        Me.Txt_signature.Location = New System.Drawing.Point(120, 48)
        Me.Txt_signature.MaxLength = 79
        Me.Txt_signature.Name = "Txt_signature"
        Me.Txt_signature.Size = New System.Drawing.Size(546, 20)
        Me.Txt_signature.TabIndex = 441
        '
        'Txt_footer
        '
        Me.Txt_footer.Location = New System.Drawing.Point(120, 16)
        Me.Txt_footer.MaxLength = 150
        Me.Txt_footer.Name = "Txt_footer"
        Me.Txt_footer.Size = New System.Drawing.Size(546, 20)
        Me.Txt_footer.TabIndex = 440
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.Transparent
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(8, 48)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(103, 15)
        Me.Label49.TabIndex = 439
        Me.Label49.Text = "FOOTER SIGN:"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Transparent
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(40, 16)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(0, 15)
        Me.Label50.TabIndex = 438
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.Transparent
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(8, 16)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(109, 15)
        Me.Label51.TabIndex = 438
        Me.Label51.Text = "FOOTER NAME:"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.TXT_DOCTHROUGH)
        Me.GroupBox5.Controls.Add(Me.Label55)
        Me.GroupBox5.Controls.Add(Me.txt_MOD)
        Me.GroupBox5.Controls.Add(Me.txt_SalesTax)
        Me.GroupBox5.Controls.Add(Me.Label54)
        Me.GroupBox5.Controls.Add(Me.Label53)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.Cmd_POTermsHelp)
        Me.GroupBox5.Controls.Add(Me.Txt_POTerms)
        Me.GroupBox5.Controls.Add(Me.TXT_PAYMTTERMS_DESC)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.Cmd_DeliveryTermHelp)
        Me.GroupBox5.Controls.Add(Me.Txt_DeliveryTerms)
        Me.GroupBox5.Controls.Add(Me.TXT_DELIVTERMS_DESC)
        Me.GroupBox5.Location = New System.Drawing.Point(180, 529)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(674, 65)
        Me.GroupBox5.TabIndex = 5598
        Me.GroupBox5.TabStop = False
        '
        'TXT_DOCTHROUGH
        '
        Me.TXT_DOCTHROUGH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_DOCTHROUGH.Location = New System.Drawing.Point(583, 14)
        Me.TXT_DOCTHROUGH.Name = "TXT_DOCTHROUGH"
        Me.TXT_DOCTHROUGH.Size = New System.Drawing.Size(80, 20)
        Me.TXT_DOCTHROUGH.TabIndex = 5606
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.Location = New System.Drawing.Point(491, 17)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(90, 14)
        Me.Label55.TabIndex = 5605
        Me.Label55.Text = "Docs Through :"
        '
        'txt_MOD
        '
        Me.txt_MOD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MOD.Location = New System.Drawing.Point(394, 36)
        Me.txt_MOD.Name = "txt_MOD"
        Me.txt_MOD.Size = New System.Drawing.Size(100, 20)
        Me.txt_MOD.TabIndex = 5604
        '
        'txt_SalesTax
        '
        Me.txt_SalesTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SalesTax.Location = New System.Drawing.Point(393, 13)
        Me.txt_SalesTax.Name = "txt_SalesTax"
        Me.txt_SalesTax.Size = New System.Drawing.Size(100, 20)
        Me.txt_SalesTax.TabIndex = 5603
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(296, 39)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(99, 14)
        Me.Label54.TabIndex = 5602
        Me.Label54.Text = "DESPATCH MODE:"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.Location = New System.Drawing.Point(322, 15)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(72, 14)
        Me.Label53.TabIndex = 5601
        Me.Label53.Text = "SALES TAX :"
        '
        'TXT_PAYMTTERMS_DESC
        '
        Me.TXT_PAYMTTERMS_DESC.BackColor = System.Drawing.Color.White
        Me.TXT_PAYMTTERMS_DESC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_PAYMTTERMS_DESC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PAYMTTERMS_DESC.Location = New System.Drawing.Point(187, 11)
        Me.TXT_PAYMTTERMS_DESC.MaxLength = 25
        Me.TXT_PAYMTTERMS_DESC.Name = "TXT_PAYMTTERMS_DESC"
        Me.TXT_PAYMTTERMS_DESC.Size = New System.Drawing.Size(110, 20)
        Me.TXT_PAYMTTERMS_DESC.TabIndex = 5600
        Me.TXT_PAYMTTERMS_DESC.Text = "CHEQUE"
        '
        'TXT_DELIVTERMS_DESC
        '
        Me.TXT_DELIVTERMS_DESC.BackColor = System.Drawing.Color.White
        Me.TXT_DELIVTERMS_DESC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_DELIVTERMS_DESC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DELIVTERMS_DESC.Location = New System.Drawing.Point(187, 36)
        Me.TXT_DELIVTERMS_DESC.MaxLength = 25
        Me.TXT_DELIVTERMS_DESC.Name = "TXT_DELIVTERMS_DESC"
        Me.TXT_DELIVTERMS_DESC.Size = New System.Drawing.Size(110, 20)
        Me.TXT_DELIVTERMS_DESC.TabIndex = 5599
        Me.TXT_DELIVTERMS_DESC.Text = "IMMEDIATELY"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TXT_GROSSVALUE)
        Me.GroupBox6.Controls.Add(Me.Txt_Remarks)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Location = New System.Drawing.Point(181, 438)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(680, 39)
        Me.GroupBox6.TabIndex = 5599
        Me.GroupBox6.TabStop = False
        '
        'TXT_GROSSVALUE
        '
        Me.TXT_GROSSVALUE.BackColor = System.Drawing.Color.LightBlue
        Me.TXT_GROSSVALUE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_GROSSVALUE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_GROSSVALUE.Location = New System.Drawing.Point(582, 11)
        Me.TXT_GROSSVALUE.MaxLength = 4
        Me.TXT_GROSSVALUE.Name = "TXT_GROSSVALUE"
        Me.TXT_GROSSVALUE.Size = New System.Drawing.Size(88, 20)
        Me.TXT_GROSSVALUE.TabIndex = 5605
        Me.TXT_GROSSVALUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_Remarks
        '
        Me.Txt_Remarks.BackColor = System.Drawing.Color.White
        Me.Txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Remarks.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Remarks.Location = New System.Drawing.Point(81, 10)
        Me.Txt_Remarks.MaxLength = 150
        Me.Txt_Remarks.Name = "Txt_Remarks"
        Me.Txt_Remarks.Size = New System.Drawing.Size(491, 20)
        Me.Txt_Remarks.TabIndex = 5604
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(10, 7)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(75, 23)
        Me.Label25.TabIndex = 5603
        Me.Label25.Text = "REMARKS :"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Location = New System.Drawing.Point(180, 270)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(668, 174)
        Me.GroupBox7.TabIndex = 5600
        Me.GroupBox7.TabStop = False
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(11, 149)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(61, 14)
        Me.Label58.TabIndex = 5590
        Me.Label58.Text = "SUBJECT :"
        '
        'TXT_SUBJECT
        '
        Me.TXT_SUBJECT.Location = New System.Drawing.Point(103, 146)
        Me.TXT_SUBJECT.MaxLength = 100
        Me.TXT_SUBJECT.Name = "TXT_SUBJECT"
        Me.TXT_SUBJECT.Size = New System.Drawing.Size(312, 20)
        Me.TXT_SUBJECT.TabIndex = 5591
        '
        'PurchaseOrder_SC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.SmartCard.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 690)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Txt_GLAcIn)
        Me.Controls.Add(Me.Cbo_Dept1)
        Me.Controls.Add(Me.cmd_GLAcInHelp)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.lbl_gldesc)
        Me.Controls.Add(Me.Cbo_ApprDate)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.Lbl_Marquee)
        Me.Controls.Add(Me.Grp_amend_Follow)
        Me.Controls.Add(Me.grp_encl)
        Me.Controls.Add(Me.grp_freight)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grp_cstform)
        Me.Controls.Add(Me.Group_MC)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grp_footer)
        Me.Controls.Add(Me.ssgrid)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "PurchaseOrder_SC"
        Me.Text = "Purchase Order"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_freight.ResumeLayout(False)
        Me.grp_freight.PerformLayout()
        Me.grp_encl.ResumeLayout(False)
        Me.grp_encl.PerformLayout()
        Me.grp_cstform.ResumeLayout(False)
        Me.grp_cstform.PerformLayout()
        Me.Group_MC.ResumeLayout(False)
        Me.Group_MC.PerformLayout()
        CType(Me.Ssgrid_body, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ssgrid_subject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ssgrid_reference, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp_amend_Follow.ResumeLayout(False)
        Me.Grp_amend_Follow.PerformLayout()
        CType(Me.FollowupGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AmendmentGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grp_footer.ResumeLayout(False)
        Me.grp_footer.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub PurchaseOrder_SC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        'ssgrid.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width * 17.57) / 100, (Screen.PrimaryScreen.WorkingArea.Height * 35.57) / 100)
        Resize_Form()
        GroupBox7.Controls.Add(ssgrid)
        ssgrid.Location = New Point(15, 35)
        
        Show()
        Me.AmendmentGrid.Lock = True
        Me.FollowupGrid.Lock = True
        'Txt_POTerms.Text = "001"
        'Txt_DeliveryTerms.Text = "001"
        Me.Cmb_despatch.SelectedIndex = 0
        Me.Cmb_delivery.SelectedIndex = 0
        Me.Cmb_shipping.SelectedIndex = 0
        Me.Cmb_Freight.SelectedIndex = 0
        Me.Cmb_CSTForm.SelectedIndex = 0
        Me.Cbo_Approvedby.SelectedIndex = 0
        Me.Cbo_POStatus.SelectedIndex = 0
        'Me.AmendmentGrid.Visible = False
        'Me.FollowupGrid.Visible = False
        Timer1.Enabled = True
        Timer1.Start()
        'Call FillStore()
        Call FOOTER()
        Call categoryfill()
        Me.txt_docno.Focus()
        Me.grp_footer.Visible = False
        'Me.cbo_warehouse.SelectedIndex = 0
        Call autogenerate()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub
    Private Function categoryfill()
        Try
            Dim I As Integer
            Dim INDEX As Integer
            cbo_warehouse.Items.Clear()
            Sstr = "SELECT DISTINCT CATEGORYDESC FROM INVENTORYCATEGORYMASTER"
            gconnection.getDataSet(Sstr, "INVENTORYITEMMASTER")
            If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count > 0 Then
                For I = 0 To gdataset.Tables("INVENTORYITEMMASTER").Rows.Count - 1
                    cbo_warehouse.Items.Add(gdataset.Tables("INVENTORYITEMMASTER").Rows(I).Item("CATEGORYDESC"))
                Next
                INDEX = cbo_warehouse.FindString(DefaultGRN)
                cbo_warehouse.SelectedIndex = INDEX
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : CATEGORYFILL " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    'Private Sub FillStore()
    '    Dim i As Integer
    '    sqlstring = "SELECT storecode,storedesc FROM STOREMASTER"
    '    gconnection.getDataSet(sqlstring, "STOREMASTER")
    '    Cbo_Dept.Items.Clear()
    '    If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
    '        For i = 0 To gdataset.Tables("STOREMASTER").Rows.Count - 1
    '            Dim temptype As String
    '            Cbo_Dept.Items.Add(gdataset.Tables("STOREMASTER").Rows(i).Item("storedesc"))
    '        Next i
    '        Cbo_Dept.SelectedIndex = -1
    '    End If
    'End Sub

    Private Sub ssgrid_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles ssgrid.Leave
        'If ssgrid.DataRowCnt < 1 Then
        '    ssgrid.Width = 920
        '    ssgrid.Height = 120
        '    Exit Sub
        'End If
        'If ssgrid.DataRowCnt > 1 Then
        '    With ssgrid
        '        .Row = 1
        '        .Col = 1

        '    End With
        'End If
        Dim i, withoutvat, tottax As Double
        Dim quantity, rate, vat, temp, discount As Double
        Dim ed, cst, modvat, ptax, octra, insurance, lst As Double
        ed = cst = modvat = ptax = octra = insurance = lst = vat = 0
        grtot = 0 : grvat = 0 : totaldiscount = 0
        With ssgrid
            ' .Width = 920
            '.Height = 120
            If .DataRowCnt > 1 Then ' For More than 1 item ordering 
                For i = 1 To .DataRowCnt
                    'QTY IN COL-4
                    .Col = 4
                    .Row = i
                    quantity = Val(.Text)
                    'RATE IN COL-6
                    .Col = 6
                    .Row = i
                    rate = Val(.Text)
                    temp = quantity * rate
                    'DISCOUNT IN COL-7
                    .Col = 7
                    .Row = i
                    discount = Val(.Text)
                    discount = (temp * discount) / 100 ' old delete this line
                    totaldiscount = totaldiscount + discount
                    temp = temp - discount
                    'VAT IN COL-8
                    .Col = 8
                    .Row = i
                    vat = (temp * Val(.Text)) / 100
                    'TOTAL IN A ROW COL-9
                    .Col = 9
                    .Row = i
                    grtot = grtot + Val(.Text)
                    grvat = grvat + vat
                    vat = 0
                    temp = 0
                    quantity = 0
                    rate = 0
                Next
                withoutvat = grtot - grvat
            Else ' For Only 1 item ordering
                'QTY IN COL-4
                .Col = 4
                .Row = 1
                quantity = Val(.Text)
                'RATE IN COL-6
                .Col = 6
                .Row = 1
                rate = Val(.Text)
                temp = quantity * rate
                'DISCOUNT IN COL-7
                .Col = 7
                .Row = 1
                discount = Val(.Text)
                discount = (discount * temp) / 100
                totaldiscount = discount
                temp = temp - discount
                .Col = 8
                .Row = 1
                vat = (temp * Val(.Text)) / 100
                .Col = 9
                .Row = 1
                grtot = Val(.Text)
                grvat = vat
                temp = 0
                quantity = 0
                rate = 0
                withoutvat = grtot - grvat
            End If
        End With
        If Val(Me.TXT_OVERALLDISC.Text) > 0 Then
            withoutvat = withoutvat - Val(Me.TXT_OVERALLDISC.Text)
        End If
        '====================TAX CALCULATION======================
        ed = Format((withoutvat * Val(Txt_ED.Text)) / 100, "0.00")
        cst = Format((withoutvat * Val(Txt_CST.Text)) / 100, "0.00")
        modvat = Format((withoutvat * Val(Txt_MODVat.Text)) / 100, "0.00")
        ptax = Format((withoutvat * Val(Txt_PTax.Text)) / 100, "0.00")
        octra = Format((withoutvat * Val(Txt_Octra.Text)) / 100, "0.00")
        insurance = Format((withoutvat * Val(Txt_Insurance.Text)) / 100, "0.00")
        lst = Format((withoutvat * Val(Txt_LST.Text)) / 100, "0.00")
        'TOTAL TAX
        tottax = Format(ed + cst + modvat + ptax + octra + insurance + lst, "0.00")
        '====================PO VALUE CALCULATION======================
        With ssgrid
            '.Width = 920
            '.Height = 120
            grtot = 0
            temp = 0
            TXT_GROSSVALUE.Text = 0
            For i = 1 To .DataRowCnt
                'QTY IN COL-4
                .Col = 9
                .Row = i
                temp = Val(.Text)
                grtot = grtot + temp


                .Col = 10
                .Row = i
                temp = Val(.Text)
                TXT_GROSSVALUE.Text = Val(TXT_GROSSVALUE.Text) + Val(temp)
                TXT_GROSSVALUE.Refresh()

                temp = 0
            Next
        End With
        '=================================================================
        Txt_POValue.Text = Format(Val((grtot + tottax)) + Val(TXT_CF.Text) + Val(TXT_TRANSPORT.Text) + Val(TXT_DELIVERY.Text) - Val(TXT_OVERALLDISC.Text), "0.00")
        Txt_TotalVat.Text = Format(Val(grvat), "0.00")
        Txt_TotalTax.Text = Format(Val(tottax), "0.00")
        Txt_Balance.Text = Format(Val(Txt_POValue.Text) - Val(Txt_AdvanceAmt.Text), "0.00")
    End Sub

    Private Sub ssgrid_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ssgrid.GotFocus
        'With ssgrid
        '    '    .Width = 920
        '    '    .Height = 485
        '    If .ActiveCol = 1 Then
        '        .BackColor = Color.Gold
        '    End If

        'End With
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Call clearform(Me)
        Call FOOTER()
        Me.Txt_POTerms.Text = "CHQ"
        Me.TXT_PAYMTTERMS_DESC.Text = "CHEQUE"
        Me.Txt_DeliveryTerms.Text = "IMM"
        Me.TXT_DELIVTERMS_DESC.Text = "IMMEDIATELY"
        'Call Txt_DeliveryTerms_Validated(sender, e)
        Me.Txt_QuotNo.Text = "NA"
        Me.grp_footer.Visible = False
        txt_docno.Text = ""
        cbo_dept.Text = ""
        Me.CmdFreeze.Enabled = True
        Group_MC.Visible = False
        Me.Txt_WarrantyCode.Text = ""
        Me.Txt_OtherTermCode.Text = ""
        Ssgrid_subject.ClearRange(1, 1, -1, -1, True)
        Ssgrid_reference.ClearRange(1, 1, -1, -1, True)
        Ssgrid_body.ClearRange(1, 1, -1, -1, True)
        Me.Chk_MC_Form.Checked = False
        ' Me.cbo_dept.Clear()
        ' Me.cbo_dept.Text = ""
        'Me.Txt_QuotNo.Clear()
        Me.txt_PONo.Clear()
        Me.Txt_Vcode.Clear()
        'Me.Cbo_Approvedby.SelectedIndex = -1
        Me.Cbo_PODate.Value = DateTime.Now()
        Me.Txt_Vname.Clear()
        Me.Cbo_ApprDate.Value = DateTime.Now()
        Me.Txt_GLAcIn.Clear()
        'Me.Cbo_POStatus.SelectedIndex = -1
        Me.Txt_ED.Clear()
        Me.Txt_CST.Clear()
        Me.Txt_MODVat.Clear()
        Me.Txt_PTax.Clear()
        Me.Txt_Octra.Clear()
        Me.Txt_Insurance.Clear()
        Me.Txt_LST.Clear()
        Me.Txt_POValue.Clear()
        'Me.Txt_POTerms.Clear()
        Me.Txt_TotalVat.Clear()
        Me.Txt_TotalTax.Clear()
        Me.Txt_AdvanceAmt.Clear()
        Me.Txt_Balance.Clear()
        Me.Cbo_Closure.SelectedIndex = -1
        'Me.Txt_DeliveryTerms.Clear()
        Me.Cmb_delivery.SelectedIndex = 0
        Me.Cmb_shipping.SelectedIndex = 0
        Me.Cmb_despatch.SelectedIndex = 0
        Me.Cmb_Freight.SelectedIndex = 0
        Me.Cmb_CSTForm.SelectedIndex = 0
        Me.lbl_Freeze.Visible = False
        Me.lbl_gldesc.Visible = False
        Me.Txt_CreditDays.Clear()
        Me.Txt_Encl.Clear()
        Me.txt_PONo.ReadOnly = False
        Me.Txt_POTerms.ReadOnly = False
        Me.ssgrid.ClearRange(1, 1, -1, -1, True)
        Me.AmendmentGrid.ClearRange(1, 1, -1, -1, True)
        Me.FollowupGrid.ClearRange(1, 1, -1, -1, True)
        Me.AmendmentGrid.Lock = True
        Me.FollowupGrid.Lock = True

        Me.Label24.Visible = False
        Me.Label26.Visible = False
        Me.Cmb_shipping.Visible = False
        Me.Cmb_delivery.Visible = False
        Me.chk_amnd_foll.Checked = False

        Me.CmdFreeze.Enabled = True
        Me.CmdAdd.Text = "Add [F7]"
        Me.CmdAdd.Enabled = True
        Me.TXT_GROSSVALUE.Text = ""
        Me.TXT_CF.Text = ""
        Me.TXT_TRANSPORT.Text = ""
        Me.TXT_OVERALLDISC.Text = ""
        Me.TXT_ADVANCEPERC.Text = ""


        'Me.AmendmentGrid.Visible = False
        'Me.FollowupGrid.Visible = False
        Me.TXT_SUBJECT.Text = ""
        Me.cbo_warehouse.SelectedIndex = 0

        Me.Txt_Remarks.Clear()
        Call autogenerate()
        '  Me.cbo_dept.Focus()
        txt_docno.Focus()
    End Sub
    Private Function Mevalidate() As Boolean
        boolchk = False
        If ssgrid.DataRowCnt < 1 Then
            MessageBox.Show("Items Grid Can't be Blank" & ControlChars.CrLf & "Atleast One Item Should be there", "Purchase Order", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            boolchk = False
            Exit Function
        End If
        Dim i
        For i = 0 To ssgrid.DataRowCnt
            With ssgrid
                .Row = i
                .Col = 2
                If .Text = "" Then
                    MessageBox.Show("Inside the Grid Rows Can't be Blank", "Grid Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    boolchk = False
                    Exit Function
                End If
            End With
        Next
        If Trim(cbo_dept.Text) = "" Then
            MessageBox.Show("Department Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbo_dept.Focus()
            boolchk = False
            Exit Function
        End If
        If Trim(txt_PONo.Text) = "" Then
            MessageBox.Show("PO No can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_PONo.Focus()
            boolchk = False
            Exit Function
        End If
        If Trim(Txt_Vcode.Text) = "" Then
            MessageBox.Show("Vendor Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txt_Vcode.Focus()
            boolchk = False
            Exit Function
        End If
        If Trim(Cbo_Approvedby.Text) = "" Then
            MessageBox.Show("ApprovedBy can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cbo_Approvedby.Focus()
            boolchk = False
            Exit Function
        End If
        If Trim(Cbo_POStatus.Text) = "" Then
            MessageBox.Show("PO Status can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Cbo_POStatus.Focus()
            boolchk = False
            Exit Function
        End If
        If Trim(Txt_POValue.Text) = "" Then
            MessageBox.Show("POValue can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txt_POValue.Focus()
            boolchk = False
            Exit Function
        End If
        If Trim(Txt_POTerms.Text) = "" Then
            MessageBox.Show("POTerms can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txt_POTerms.Focus()
            boolchk = False
            Exit Function
        End If
        If Trim(Txt_DeliveryTerms.Text) = "" Then
            MessageBox.Show("Delivery Terms can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Txt_DeliveryTerms.Focus()
        End If
        'If Trim(Txt_CreditDays.Text) = "" Then
        '    MessageBox.Show("Credit Days can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Txt_CreditDays.Focus()
        '    boolchk = False
        '    Exit Function
        'End If
        boolchk = True
    End Function
    Private Function btn_disable()
        'lock the button wen data operation in progress
        CmdAdd.Enabled = False
        CmdClear.Enabled = False
        CmdFreeze.Enabled = False
        CmdPrint.Enabled = False
        CmdView.Enabled = False
        CmdExit.Enabled = False
    End Function
    Private Function btn_enable()
        'unlock the button wen data operation in progress
        CmdAdd.Enabled = True
        CmdClear.Enabled = True
        CmdFreeze.Enabled = True
        CmdPrint.Enabled = True
        CmdView.Enabled = True
        CmdExit.Enabled = True
    End Function
    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Dim sqlstr As String
        Dim i, j As Integer
        Call Mevalidate()
        If boolchk = False Then Exit Sub
        Dim VoucherType, vamt, Voucherno As String
        Dim Insert(0) As String
        Try
            Call btn_disable()
            If CmdAdd.Text = "Add [F7]" Then
                '----------------------------------PO_HDR BEGINS------------------------------
                sqlstring = ""
                sqlstring = "Insert Into PO_HDR([pono] ,[DOCTYPE] ,auth_docno,[podate] ,[poquotno] ,[povendorcode] ,[podepartment] ,[poapprovedby] ,[poapproveddate],[postatus] ,[poed] ,[pocst],[pomodvat] ,[poptax] ,[pooctra] ,[poinsurance] ,[polst] ,[povalue] ,[pototalvat] ,[pototaltax] ,[pototaldiscount],[poadvance] ,[pobalance] ,[poterms],[podeliveryterms] , [pomcpo], [powarrantyterms] , [pootherterms] , [podespatch] ,[poshipping] ,[podelivery] ,[pocreditdays],[poencl] ,[poremarks] ,[poclosure] , [pofreight], [pocstform], [freeze] ,[adduser] ,[adddatetime],[POOVERALLDISC],[POCF],[POTRANSPORT],[PODELIVERYAMT],[POGLACIN],[UPDsign],[UPDFOOTER],[POSALET],[PODESPMODE],[PODOCSTHROUGH], [CATEGORY],[SUBJECT]) Values("
                sqlstring = sqlstring & "'" & txt_PONo.Text & "',"
                sqlstring = sqlstring & "'" & doctype & "',"
                sqlstring = sqlstring & "'" & Me.txt_docno.Text & "',"
                sqlstring = sqlstring & "'" & Me.Cbo_PODate.Text & "',"
                sqlstring = sqlstring & "'" & Me.Txt_QuotNo.Text & "',"
                sqlstring = sqlstring & "'" & Me.Txt_Vcode.Text & "',"
                sqlstring = sqlstring & "'" & Me.cbo_dept.Text & "',"
                sqlstring = sqlstring & "'" & Me.Cbo_Approvedby.Text & "',"
                sqlstring = sqlstring & "'" & Me.Cbo_ApprDate.Text & "',"
                sqlstring = sqlstring & "'" & Me.Cbo_POStatus.Text & "',"

                sqlstring = sqlstring & Format(Val(Me.Txt_ED.Text), "0.00") & ","
                sqlstring = sqlstring & Format(Val(Me.Txt_CST.Text), "0.00") & ","
                sqlstring = sqlstring & Format(Val(Me.Txt_MODVat.Text), "0.00") & ","
                sqlstring = sqlstring & Format(Val(Me.Txt_PTax.Text), "0.00") & ","
                sqlstring = sqlstring & Format(Val(Me.Txt_Octra.Text), "0.00") & ","
                sqlstring = sqlstring & Format(Val(Me.Txt_Insurance.Text), "0.00") & ","
                sqlstring = sqlstring & Format(Val(Me.Txt_LST.Text), "0.00") & ","

                sqlstring = sqlstring & Format(Val(Me.Txt_POValue.Text), "0.00") & ","
                sqlstring = sqlstring & Format(Val(Me.Txt_TotalVat.Text), "0.00") & ","
                sqlstring = sqlstring & Format(Val(Me.Txt_TotalTax.Text), "0.00") & ","
                sqlstring = sqlstring & Format(Val(totaldiscount), "0.00") & ","
                sqlstring = sqlstring & Format(Val(Me.Txt_AdvanceAmt.Text), "0.00") & ","
                sqlstring = sqlstring & Format(Val(Me.Txt_Balance.Text), "0.00") & ","

                sqlstring = sqlstring & "'" & Txt_POTerms.Text & "',"
                sqlstring = sqlstring & "'" & Txt_DeliveryTerms.Text & "',"

                If Chk_MC_Form.Checked = True Then
                    sqlstring = sqlstring & "'Y',"
                    sqlstring = sqlstring & "'" & Txt_WarrantyCode.Text & "',"
                    sqlstring = sqlstring & "'" & Txt_OtherTermCode.Text & "',"
                Else
                    sqlstring = sqlstring & "'N',"
                    sqlstring = sqlstring & "'',"
                    sqlstring = sqlstring & "'',"
                End If

                sqlstring = sqlstring & "'" & Cmb_despatch.Text & "',"
                sqlstring = sqlstring & "'" & Cmb_shipping.Text & "',"
                sqlstring = sqlstring & "'" & Cmb_delivery.Text & "',"

                sqlstring = sqlstring & Format(Val(Me.Txt_CreditDays.Text), "0.00") & ","
                sqlstring = sqlstring & "'" & Txt_Encl.Text & "',"
                sqlstring = sqlstring & "'" & Replace(Trim(CStr(Txt_Remarks.Text)), "'", "?") & "',"

                sqlstring = sqlstring & "'N'," 'FOR CLOSURE DEFAULT NO
                sqlstring = sqlstring & "'" & Cmb_Freight.Text & "',"
                sqlstring = sqlstring & "'" & Cmb_CSTForm.Text & "',"
                sqlstring = sqlstring & "'N',"

                sqlstring = sqlstring & "'" & Trim(gUsername) & "',"
                sqlstring = sqlstring & "'" & Format(Now, "dd-MMM-yyyy HH:MM:ss") & "',"

                sqlstring = sqlstring & Format(Val(Me.TXT_OVERALLDISC.Text), "0.00") & ","
                sqlstring = sqlstring & Format(Val(Me.TXT_CF.Text), "0.00") & ","
                sqlstring = sqlstring & Format(Val(Me.TXT_TRANSPORT.Text), "0.00") & ","
                sqlstring = sqlstring & Format(Val(Me.TXT_DELIVERY.Text), "0.00") & ","
                sqlstring = sqlstring & " '" & Trim(Me.Txt_GLAcIn.Text) & "',"
                sqlstring = sqlstring & " '" & Trim(Me.Txt_signature.Text) & "',"
                sqlstring = sqlstring & " '" & Trim(Me.Txt_footer.Text) & "',"
                sqlstring = sqlstring & " '" & txt_SalesTax.Text & "',"
                sqlstring = sqlstring & " '" & txt_MOD.Text & "',"
                sqlstring = sqlstring & " '" & TXT_DOCTHROUGH.Text & "','" & cbo_warehouse.Text & "','" & TXT_SUBJECT.Text & "')"
                gconnection.dataOperation(6, sqlstring, "PO_HDR")

                'For Managing Committee Purchase Order
                If Chk_MC_Form.Checked = True Then
                    Call MC_Function(sender, e)
                End If

                '----------------------------------PO_ITEMDETAILS BEGINS------------------------------

                With ssgrid
                    Dim itemcode, uom, quantity, sqlArray() As String
                    Dim sql(Me.ssgrid.DataRowCnt + 20) As String
                    Dim requireddate As Date
                    Dim rate, discount, vat, vattotal, total, Amount, DiscAmt, VatAmt As Double
                    For i = 1 To .DataRowCnt
                        .Col = 1
                        .Row = i
                        itemcode = .Text
                        If Trim(itemcode) <> "" Then
                            sql(i) = "INSERT INTO PO_ITEMDETAILS(PONO,auth_doc,ITEMCODE,UOM,QUANTITY,RATE,DISCOUNT,VAT,TOTAL,amount,DiscAmt,VatAmt) Values("
                            sql(i) = sql(i) & "'" & txt_PONo.Text & "',"
                            sql(i) = sql(i) & "'" & txt_docno.Text & "',"
                            sql(i) = sql(i) & "'" & itemcode & "',"
                            .Col = 3
                            .Row = i
                            uom = .Text
                            sql(i) = sql(i) & "'" & uom & "',"
                            .Col = 4
                            .Row = i
                            quantity = .Text
                            sql(i) = sql(i) & "'" & quantity & "',"
                            .Col = 5
                            .Row = i
                            '  requireddate = .Text
                            ' sql(i) = sql(i) & "'" & Format(requireddate, "dd-MMM-yyyy") & "',"
                            .Col = 6
                            .Row = i
                            rate = .Text
                            sql(i) = sql(i) & Format(Val(rate), "0.00") & ","
                            .Col = 7
                            .Row = i
                            discount = .Text
                            sql(i) = sql(i) & Format(Val(discount), "0.00") & ","
                            .Col = 8
                            .Row = i
                            vat = .Text
                            sql(i) = sql(i) & Format(Val(vat), "0.00") & ","
                            .Col = 9
                            .Row = i
                            discount = (rate * quantity * discount) / 100
                            vattotal = (rate * quantity) - discount
                            total = Nothing
                            total = total + vattotal
                            vattotal = (vattotal * vat) / 100
                            total = total + vattotal
                            'total = Nothing
                            'total = Val(((rate * quantity) + vattotal))
                            vattotal = Nothing
                            sql(i) = sql(i) & Format(Val(total), "0.00") & ","
                            .Col = 10
                            .Row = i
                            Amount = .Text
                            sql(i) = sql(i) & Format(Val(Amount), "0.00") & ","
                            .Col = 11
                            .Row = i
                            DiscAmt = .Text
                            sql(i) = sql(i) & Format(Val(DiscAmt), "0.00") & ","
                            .Col = 12
                            .Row = i
                            VatAmt = .Text
                            sql(i) = sql(i) & Format(Val(VatAmt), "0.00") & ")"

                        End If
                    Next
                    ReDim sqlArray(sql.Length)
                    sqlArray.Copy(sql, sqlArray, sql.Length)
                    vconn.MoreTrans(sqlArray)

                    'If MsgBox("Do You Want To Print The P.O. Form", MsgBoxStyle.YesNo, "Clubman Accounts") = MsgBoxResult.Yes Then
                    '    gPrint = True
                    '    'Call Viewoperation_SCnew()
                    '    Dim laser As New Laser_print
                    '    laser.Show()
                    'Else
                    '    gPrint = False
                    '    '''Call Viewoperation_SCnew()
                    'End If
                    Call CmdClear_Click(sender, e)
                End With
                '----------------------------HDR UPDATE OPERATION====================================
            Else
                If Mid(CmdAdd.Text, 1, 1) = "U" And Me.lbl_Freeze.Visible = True Then
                    MessageBox.Show(" The Freezed Record Cannot Be Updated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False
                ElseIf Mid(CmdAdd.Text, 1, 1) = "U" And Me.lbl_Freeze.Visible = False Then
                    '----------------------------------PO_IMAGEHDR BEGINS------------------------------
                    sqlstring = ""
                    sqlstring = "Insert Into PO_IMAGEHDR ([pono] , [DOCTYPE] ,[auth_docno],[podate] ,[poquotno] ,[povendorcode] ,[podepartment] , [poapprovedby] ,[poapproveddate],[postatus] ,[poed] ,[pocst],	[pomodvat] , [poptax] ,[pooctra] ,[poinsurance] ,[polst] ,[povalue] ,[pototalvat] , [pototaltax] ,[pototaldiscount],[poadvance] ,[pobalance] ,[POOVERALLDISC],[POCF],[POTRANSPORT],[PODELIVERYAMT],[poterms],[podeliveryterms],[powarrantyterms],[pootherterms] ,[podespatch] ,[poshipping] ,[podelivery] ,[pocreditdays],[poencl] ,[poremarks] ,[poclosure] ,[pofreight], [pocstform], [pomcpo], [freeze] , [adduser] ,[adddatetime] ) SELECT [pono] ,[DOCTYPE] ,auth_docno,[podate] ,[poquotno] ,[povendorcode] ,[podepartment] ,[poapprovedby] ,[poapproveddate],[postatus] ,[poed] ,[pocst],	[pomodvat] ,[poptax] ,[pooctra] ,[poinsurance] ,[polst] ,[povalue] ,[pototalvat] ,[pototaltax] ,[pototaldiscount], [poadvance] ,[pobalance] ,[POOVERALLDISC],[POCF],[POTRANSPORT],[PODELIVERYAMT],[poterms],[podeliveryterms],[powarrantyterms],[pootherterms] ,[podespatch] ,[poshipping] ,[podelivery] ,[pocreditdays],[poencl] ,[poremarks] ,[poclosure] ,[pofreight], [pocstform], [pomcpo], [freeze] ,[adduser] ,[adddatetime] from po_hdr where po_hdr.pono= '" & txt_PONo.Text & "' "
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                    gconnection.MoreTrans1(Insert)
                    '=======================UPDATING PO_HDR------------------
                    sqlstring = "UPDATE  PO_HDR "
                    sqlstring = sqlstring & "SET PODate='" & Me.Cbo_PODate.Text & "',"
                    sqlstring = sqlstring & "DOCTYPE='" & doctype & "',"
                    sqlstring = sqlstring & "auth_docno='" & Me.txt_docno.Text & "',"
                    sqlstring = sqlstring & "POQuotno='" & Me.Txt_QuotNo.Text & "',"
                    sqlstring = sqlstring & "POVendorcode='" & Me.Txt_Vcode.Text & "',"
                    sqlstring = sqlstring & "PODepartment='" & Me.cbo_dept.Text & "',"
                    sqlstring = sqlstring & "POApprovedby='" & Me.Cbo_Approvedby.Text & "',"
                    sqlstring = sqlstring & "POApproveddate='" & Me.Cbo_ApprDate.Text & "',"
                    sqlstring = sqlstring & "POGLACIN='" & Me.Txt_GLAcIn.Text & "',"
                    sqlstring = sqlstring & "POStatus='" & Me.Cbo_POStatus.Text & "',"

                    sqlstring = sqlstring & "UPDFOOTER='" & Me.Txt_footer.Text & "',"
                    sqlstring = sqlstring & "UPDsign='" & Me.Txt_signature.Text & "',"

                    sqlstring = sqlstring & "POEd='" & Format(Val(Me.Txt_ED.Text), "0.00") & "',"
                    sqlstring = sqlstring & "POCst='" & Format(Val(Me.Txt_CST.Text), "0.00") & "',"
                    sqlstring = sqlstring & "POModvat='" & Format(Val(Me.Txt_MODVat.Text), "0.00") & "',"
                    sqlstring = sqlstring & "POPtax='" & Format(Val(Me.Txt_PTax.Text), "0.00") & "',"
                    sqlstring = sqlstring & "POOctra='" & Format(Val(Me.Txt_Octra.Text), "0.00") & "',"
                    sqlstring = sqlstring & "POInsurance='" & Format(Val(Me.Txt_Insurance.Text), "0.00") & "',"
                    sqlstring = sqlstring & "POLst='" & Format(Val(Me.Txt_LST.Text), "0.00") & "',"

                    sqlstring = sqlstring & "POValue='" & Format(Val(Me.Txt_POValue.Text), "0.00") & "',"
                    sqlstring = sqlstring & "POTotalvat='" & Format(Val(Me.Txt_TotalVat.Text), "0.00") & "',"
                    sqlstring = sqlstring & "POTotaltax='" & Format(Val(Me.Txt_TotalTax.Text), "0.00") & "',"
                    sqlstring = sqlstring & "POTotaldiscount='" & Format(Val(totaldiscount), "0.00") & "',"
                    sqlstring = sqlstring & "POAdvance='" & Format(Val(Me.Txt_AdvanceAmt.Text), "0.00") & "',"
                    sqlstring = sqlstring & "POBalance='" & Format(Val(Me.Txt_Balance.Text), "0.00") & "',"

                    sqlstring = sqlstring & "POOVERALLDISC=" & Format(Val(Me.TXT_OVERALLDISC.Text), "0.00") & ","
                    sqlstring = sqlstring & "POCF=" & Format(Val(Me.TXT_CF.Text), "0.00") & ","
                    sqlstring = sqlstring & "POTRANSPORT=" & Format(Val(Me.TXT_TRANSPORT.Text), "0.00") & ","
                    sqlstring = sqlstring & "PODELIVERYAMT=" & Format(Val(Me.TXT_DELIVERY.Text), "0.00") & ","

                    sqlstring = sqlstring & "POterms='" & Txt_POTerms.Text & "',"
                    sqlstring = sqlstring & "POdeliveryterms='" & Txt_DeliveryTerms.Text & "',"

                    If Chk_MC_Form.Checked = True Then
                        sqlstring = sqlstring & "POmcpo= 'Y',"
                        sqlstring = sqlstring & "POwarrantyterms='" & Txt_WarrantyCode.Text & "',"
                        sqlstring = sqlstring & "POotherterms='" & Txt_OtherTermCode.Text & "',"
                    Else
                        sqlstring = sqlstring & "POmcpo= 'N',"
                        sqlstring = sqlstring & "POwarrantyterms= '',"
                        sqlstring = sqlstring & "POotherterms= '',"
                    End If

                    sqlstring = sqlstring & "PODespatch='" & Cmb_despatch.Text & "',"
                    sqlstring = sqlstring & "POShipping='" & Cmb_shipping.Text & "',"
                    sqlstring = sqlstring & "PODelivery='" & Cmb_delivery.Text & "',"

                    sqlstring = sqlstring & "POCreditdays='" & Format(Val(Me.Txt_CreditDays.Text), "0.00") & "',"
                    sqlstring = sqlstring & "POEncl='" & Txt_Encl.Text & "',"
                    sqlstring = sqlstring & " PORemarks='" & Replace(Trim(CStr(Txt_Remarks.Text)), "'", "?") & "',"

                    If Cbo_Closure.SelectedIndex = 0 Then
                        sqlstring = sqlstring & "POClosure= 'C',"    ' FOR NORMAL CLOSURE
                    ElseIf Cbo_Closure.SelectedIndex = 1 Then
                        sqlstring = sqlstring & "POClosure= 'F',"    ' FOR FOCIBLE CLOSURE
                    Else
                        sqlstring = sqlstring & "POClosure= 'N',"    ' FOR NORMAL OR PENDING POS
                    End If
                    'sqlstring = sqlstring & "POClosure='" & Cbo_Closure.Text & "',"
                    sqlstring = sqlstring & "POFreight='" & Cmb_Freight.Text & "',"
                    sqlstring = sqlstring & "POCSTForm='" & Cmb_CSTForm.Text & "',"
                    'sqlstring = sqlstring & "freeze= 'Y',"

                    sqlstring = sqlstring & "Updateuser='" & gUsername & "',"
                    sqlstring = sqlstring & "Updatedatetime='" & Format(Now, "dd-MMM-yyyy HH:MM:ss") & "', CATEGORY='" & cbo_warehouse.Text & "', SUBJECT = '" & TXT_SUBJECT.Text & "' "

                    sqlstring = sqlstring & " WHERE PONO = '" & Trim(txt_PONo.Text) & "'"
                    'gconnection.dataOperation(6, sqlstring, "PO_HDR")
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                    gconnection.MoreTrans1(Insert)

                    '-----------------ITEMDETAILS UPDATION-------------------------------------
                    sqlstring = "delete from PO_ITEMDETAILS WHERE PONO='" & txt_PONo.Text & "'"
                    'gconnection.dataOperation(6, sqlstring, "PO_ITEMDETAILS")
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = sqlstring
                    gconnection.MoreTrans1(Insert)
                    sqlstring = ""
                    With ssgrid
                        Dim itemcode, uom, sqlArray() As String
                        Dim sql(Me.ssgrid.DataRowCnt + 20) As String
                        Dim requireddate As Date
                        Dim rate, discount, vat, total, totalvat, quantity, amount, discamt, vatamt As Double
                        For i = 1 To .DataRowCnt
                            .Col = 1
                            .Row = i
                            itemcode = .Text
                            If Trim(itemcode) <> "" Then
                                sql(i) = "INSERT INTO PO_ITEMDETAILS(PONO,auth_doc,ITEMCODE,UOM,QUANTITY,RATE,DISCOUNT,VAT,TOTAL,Amount,DiscAmt,VatAmt) Values("
                                sql(i) = sql(i) & "'" & txt_PONo.Text & "',"
                                sql(i) = sql(i) & "'" & txt_docno.Text & "',"
                                sql(i) = sql(i) & "'" & itemcode & "',"
                                .Col = 3
                                .Row = i
                                uom = .Text
                                sql(i) = sql(i) & "'" & uom & "',"
                                .Col = 4
                                .Row = i
                                quantity = .Text
                                sql(i) = sql(i) & "'" & quantity & "',"
                                .Col = 5
                                .Row = i
                                '  requireddate = .Text

                                ' sql(i) = sql(i) & "'" & Format(requireddate, "dd-MMM-yyyy") & "',"
                                .Col = 6
                                .Row = i
                                rate = .Text
                                sql(i) = sql(i) & Format(Val(rate), "0.00") & ","
                                .Col = 7
                                .Row = i
                                discount = .Text
                                sql(i) = sql(i) & Format(Val(discount), "0.00") & ","
                                .Col = 8
                                .Row = i
                                vat = .Text
                                sql(i) = sql(i) & Format(Val(vat), "0.00") & ","
                                .Col = 9
                                .Row = i
                                total = Nothing
                                'totalvat = ((rate * quantity) * vat) / 100
                                'total = Val((((rate * quantity) + totalvat) - discount))
                                discount = (rate * quantity * discount) / 100
                                totalvat = (rate * quantity) - discount
                                'totalvat = (totalvat * vat) / 100
                                total = (totalvat * vat) / 100
                                total = total + totalvat
                                sql(i) = sql(i) & Format(Val(total), "0.00") & ","
                                .Col = 10
                                .Row = i
                                amount = .Text
                                sql(i) = sql(i) & Format(Val(amount), "0.00") & ","
                                .Col = 11
                                .Row = i
                                discamt = .Text
                                sql(i) = sql(i) & Format(Val(discamt), "0.00") & ","
                                .Col = 12
                                .Row = i
                                vatamt = .Text
                                sql(i) = sql(i) & Format(Val(vatamt), "0.00") & ")"
                            End If
                        Next
                        ReDim sqlArray(sql.Length)
                        sqlArray.Copy(sql, sqlArray, sql.Length)
                        vconn.MoreTrans1(sqlArray)
                    End With
                    '----------------------------AMENDMENT UPDATION--------------------------
                    sqlstring = "delete from PO_AMENDMENT WHERE PONO='" & txt_PONo.Text & "'"
                    gconnection.dataOperation(6, sqlstring, "PO_AMENDMENT")
                    sqlstring = ""
                    With AmendmentGrid
                        Dim sql(Me.AmendmentGrid.DataRowCnt + 20), SqlArray() As String
                        Dim poamendmentno, poamendmentdesc As String
                        Dim poamendmentdate As Date
                        For i = 1 To .DataRowCnt
                            .Col = 1
                            .Row = i
                            poamendmentno = .Text
                            If Trim(poamendmentno <> "") Then
                                sql(i) = "INSERT INTO PO_AMENDMENT(PONO,POAMENDMENTNO,POAMENDMENTDATE,POAMENDMENTDESC) Values("
                                sql(i) = sql(i) & "'" & txt_PONo.Text & "',"
                                sql(i) = sql(i) & "'" & poamendmentno & "',"
                                .Col = 2
                                .Row = i
                                poamendmentdate = .Text
                                sql(i) = sql(i) & "'" & Format(poamendmentdate, "dd-MMM-yyyy") & "',"
                                .Col = 3
                                .Row = i
                                poamendmentdesc = .Text
                                sql(i) = sql(i) & "'" & poamendmentdesc & "' )"
                            End If
                        Next
                        ReDim SqlArray(sql.Length)
                        SqlArray.Copy(sql, SqlArray, sql.Length)
                        vconn.MoreTrans1(SqlArray)
                    End With
                    '----------------------------FOLLOWUP UPDATION-----------------------------
                    sqlstring = "delete from PO_FOLLOWUP WHERE PONO='" & txt_PONo.Text & "'"
                    gconnection.dataOperation(6, sqlstring, "PO_FOLLOWUP")
                    sqlstring = ""
                    With FollowupGrid
                        Dim sql(Me.FollowupGrid.DataRowCnt + 20), SqlArray() As String
                        Dim pofollowupno, pofollowupdesc As String
                        Dim pofollowupdate As Date
                        For i = 1 To .DataRowCnt
                            .Col = 1
                            .Row = i
                            pofollowupno = .Text
                            If Trim(pofollowupno <> "") Then
                                sql(i) = "INSERT INTO PO_FOLLOWUP(PONO,POFOLLOWUPNO,POFOLLOWUPDATE,POFOLLOWUPDESC) Values("
                                sql(i) = sql(i) & "'" & txt_PONo.Text & "',"
                                sql(i) = sql(i) & "'" & pofollowupno & "',"
                                .Col = 2
                                .Row = i
                                pofollowupdate = .Text
                                sql(i) = sql(i) & "'" & Format(pofollowupdate, "dd-MMM-yyyy") & "',"
                                .Col = 3
                                .Row = i
                                pofollowupdesc = .Text
                                sql(i) = sql(i) & "'" & pofollowupdesc & "' )"

                            End If
                        Next

                        'For Managing Committee Purchase Order
                        If Chk_MC_Form.Checked = True Then
                            Call MC_Function(sender, e)
                        End If

                        ReDim SqlArray(sql.Length)
                        SqlArray.Copy(sql, SqlArray, sql.Length)
                        vconn.MoreTrans(SqlArray)

                        'If MsgBox("Do You Want To Print The Voucher", MsgBoxStyle.YesNo, "PURCHASE ORDER") = MsgBoxResult.Yes Then
                        '    gPrint = False
                        '    Call Viewoperation_SCnew()
                        '    Call Viewoperation()
                        'Else
                        '    gPrint = True
                        '    'Call Viewoperation_SCnew()
                        'End If
                    End With
                    Me.CmdClear_Click(sender, e)
                    CmdAdd.Text = "Add [F7]"
                End If
            End If
            Call btn_enable()
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call Me.CmdClear_Click(sender, e)
            Exit Sub
        End Try
    End Sub

    'For Managing Committee Purchase Order Only
    Private Sub MC_Function(ByVal sender As System.Object, ByVal e As System.EventArgs) 'MC - Managing Committee Purchase Order
        Dim MainMenu As Object
        Dim Loopindex As Integer
        Dim SSQL(10), SSQL1(10), SSQL2(10), SqlArray() As String
        Dim Vdesc As Object
        Dim i As Integer
        Try
            If Ssgrid_subject.DataRowCnt > 0 Then
                SSQL(0) = "Delete from PO_OTHERTERMS where Doctype = 'SUBJECT' and Trantype = '" & Trim(txt_PONo.Text) & "' "
                For Loopindex = 1 To Ssgrid_subject.DataRowCnt
                    Vdesc = Nothing
                    Ssgrid_subject.GetText(1, Loopindex, Vdesc)
                    SSQL(Loopindex) = "Insert into PO_OTHERTERMS(doctype,Trantype,Slno,Message) values("
                    SSQL(Loopindex) = SSQL(Loopindex) & " 'SUBJECT','" & Trim(txt_PONo.Text) & "','" & Loopindex & "', '" & Vdesc & "')"
                Next Loopindex
            End If
            ReDim SqlArray(SSQL.Length)
            SqlArray.Copy(SSQL, SqlArray, SSQL.Length)
            gconnection.MoreTrans1(SqlArray)


            If Ssgrid_reference.DataRowCnt > 0 Then
                SSQL1(0) = "Delete from PO_OTHERTERMS where Doctype = 'REFERENCE' and Trantype = '" & Trim(txt_PONo.Text) & "' "
                For Loopindex = 1 To Ssgrid_reference.DataRowCnt
                    Vdesc = Nothing
                    Ssgrid_reference.GetText(1, Loopindex, Vdesc)
                    SSQL1(Loopindex) = "Insert into PO_OTHERTERMS(doctype,Trantype,Slno,Message) values("
                    SSQL1(Loopindex) = SSQL1(Loopindex) & " 'REFERENCE','" & Trim(txt_PONo.Text) & "','" & Loopindex & "', '" & Vdesc & "')"
                Next Loopindex
            End If
            ReDim SqlArray(SSQL1.Length)
            SqlArray.Copy(SSQL1, SqlArray, SSQL1.Length)
            gconnection.MoreTrans1(SqlArray)


            If Ssgrid_body.DataRowCnt > 0 Then
                SSQL2(0) = "Delete from PO_OTHERTERMS where Doctype = 'BODY' and Trantype = '" & Trim(txt_PONo.Text) & "' "
                For Loopindex = 1 To Ssgrid_body.DataRowCnt
                    Vdesc = Nothing
                    Ssgrid_body.GetText(1, Loopindex, Vdesc)
                    SSQL2(Loopindex) = "Insert into PO_OTHERTERMS(doctype,Trantype,Slno,Message) values("
                    SSQL2(Loopindex) = SSQL2(Loopindex) & " 'BODY','" & Trim(txt_PONo.Text) & "','" & Loopindex & "', '" & Vdesc & "')"
                Next Loopindex
            End If
            ReDim SqlArray(SSQL2.Length)
            SqlArray.Copy(SSQL2, SqlArray, SSQL2.Length)
            gconnection.MoreTrans1(SqlArray)

        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmdFreeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdFreeze.Click
        Dim strsql As String
        Call Mevalidate()
        If boolchk = False Then Exit Sub
        If Mid(CmdFreeze.Text, 1, 1) = "F" Then
            strsql = "UPDATE  PO_HDR "
            strsql = strsql & " SET Freeze= 'Y',Freezeuser='" & gUsername & " ', Freezedatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            strsql = strsql & " WHERE PONO = '" & Trim(txt_PONo.Text) & "'"
            gconnection.dataOperation(3, strsql, "PO_HDR")
            Me.CmdClear_Click(sender, e)
            CmdAdd.Text = "Add [F7]"
            'Else
            '    strsql = "UPDATE  PO_HDR "
            '    strsql = strsql & " SET Freeze= 'N',Adduser='" & gUsername & " ',Adddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            '    strsql = strsql & " WHERE PONO = '" & Trim(txt_PONo.Text) & "'"
            '    gconnection.dataOperation(4, strsql, "PO_HDR")
            '    Me.CmdClear_Click(sender, e)
            '    Me.lbl_Freeze.Visible = False
            '    CmdAdd.Text = "Add [F7]"
        End If
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        'gPrint = False
        ''Call Viewoperation_SCnew()
        ''Call Viewoperation()
        ''Dim laser As New Laser_print
        ''laser.Show()
        'Try
        '    ' If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
        '    Dim rViewer As New Viewer
        '    Dim sqlstring, SSQL As String
        '    Dim r As New Rpt_POBill
        '    'sqlstring = "SELECT ISNULL(PONO,'') AS PONO, ISNULL(GRNDETAILS,'') AS GRNDETAILS,GRNDATE, ISNULL(SUPPLIERCODE,'') AS SUPPLIERCODE, ISNULL(SUPPLIERNAME,'') AS SUPPLIERNAME,"
        '    'sqlstring = sqlstring & " ISNULL(SUPPLIERINVNO,'') AS SUPPLIERINVNO,  ISNULL(EXCISEPASSNO,'') AS EXCISEPASSNO,ISNULL(GLACCOUNTCODE,'') AS GLACCOUNTCODE,ISNULL(GLACCOUNTNAME,'') AS GLACCOUNTNAME,"
        '    'sqlstring = sqlstring & " ISNULL(TOTALAMOUNT,0) AS TOTALAMOUNT,ISNULL(VATAMOUNT,0) AS VATAMOUNT,ISNULL(SURCHARGEAMT,0) AS SURCHARGEAMT,ISNULL(DISCOUNT,0) AS DISCOUNT,ISNULL(BILLAMOUNT,0) AS BILLAMOUNT,"
        '    'sqlstring = sqlstring & " ISNULL(ITEMCODE,'') AS ITEMCODE, ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM, ISNULL(QTY,0) AS QTY, ISNULL(RATE,0) AS RATE,ISNULL(REMARKS,'') AS REMARKS, "
        '    'sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT,isnull(discount,0) as ddiscount,isnull(taxper,0) as taxper,isnull(taxamount,0) as taxamount, isnull(OverallDiscount,0) OverallDiscount,ISNULL(UPDFOOTER,'') AS UPDFOOTER,ISNULL(UPDNAME,'') AS UPDNAME "
        '    sqlstring = " SELECT * FROM  VW_PO_POBILL "
        '    sqlstring = sqlstring & " WHERE PONO BETWEEN '" & Trim(txt_PONo.Text) & "' AND '" & Trim(txt_PONo.Text) & "'"
        '    sqlstring = sqlstring & " ORDER BY PONO,PODATE"

        '    gconnection.getDataSet(sqlstring, "VW_PO_POBILL")
        '    If gdataset.Tables("VW_PO_POBILL").Rows.Count > 0 Then
        '        rViewer.ssql = sqlstring
        '        rViewer.Report = r
        '        rViewer.TableName = "VW_PO_POBILL"
        '        Dim textobj1 As TextObject
        '        textobj1 = r.ReportDefinition.ReportObjects("Text13")
        '        textobj1.Text = MyCompanyName

        '        Dim textobj3 As TextObject
        '        textobj3 = r.ReportDefinition.ReportObjects("Text5")
        '        textobj3.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode

        '        Dim textobj2 As TextObject
        '        textobj2 = r.ReportDefinition.ReportObjects("Text30")
        '        textobj2.Text = gUsername
        '        Dim t1 As TextObject
        '        t1 = r.ReportDefinition.ReportObjects("Text54")
        '        t1.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:" & gEmail & ", Web:" & gWebsite
        '        Dim textobj4 As TextObject
        '        textobj4 = r.ReportDefinition.ReportObjects("Text20")
        '        textobj4.Text = "Tin No.:" & gTinNo & ",Service Tax:" & gServiceTax

        '        rViewer.Show()
        '    Else
        '        MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
        '    End If

        '    '''Else
        '    '''    gPrint = False
        '    '''    Call printoperation()
        '    '''End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : View Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
        gPrint = False
        'Call Viewoperation_SCnew()
        'Call Viewoperation()
        'Dim laser As New Laser_print
        'laser.Show()
        Try
            ' If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
            Dim rViewer As New Viewer
            Dim sqlstring, SSQL As String
            Dim PMTTRMS, DLVTRMS As String
            Dim vcode As String
            Dim r As New Rpt_POBill
            'sqlstring = "SELECT ISNULL(PONO,'') AS PONO, ISNULL(GRNDETAILS,'') AS GRNDETAILS,GRNDATE, ISNULL(SUPPLIERCODE,'') AS SUPPLIERCODE, ISNULL(SUPPLIERNAME,'') AS SUPPLIERNAME,"
            'sqlstring = sqlstring & " ISNULL(SUPPLIERINVNO,'') AS SUPPLIERINVNO,  ISNULL(EXCISEPASSNO,'') AS EXCISEPASSNO,ISNULL(GLACCOUNTCODE,'') AS GLACCOUNTCODE,ISNULL(GLACCOUNTNAME,'') AS GLACCOUNTNAME,"
            'sqlstring = sqlstring & " ISNULL(TOTALAMOUNT,0) AS TOTALAMOUNT,ISNULL(VATAMOUNT,0) AS VATAMOUNT,ISNULL(SURCHARGEAMT,0) AS SURCHARGEAMT,ISNULL(DISCOUNT,0) AS DISCOUNT,ISNULL(BILLAMOUNT,0) AS BILLAMOUNT,"
            'sqlstring = sqlstring & " ISNULL(ITEMCODE,'') AS ITEMCODE, ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM, ISNULL(QTY,0) AS QTY, ISNULL(RATE,0) AS RATE,ISNULL(REMARKS,'') AS REMARKS, "
            'sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT,isnull(discount,0) as ddiscount,isnull(taxper,0) as taxper,isnull(taxamount,0) as taxamount, isnull(OverallDiscount,0) OverallDiscount,ISNULL(UPDFOOTER,'') AS UPDFOOTER,ISNULL(UPDNAME,'') AS UPDNAME "
            sqlstring = " SELECT * FROM  VW_PO_POBILL "
            sqlstring = sqlstring & " WHERE PONO BETWEEN '" & Trim(txt_PONo.Text) & "' AND '" & Trim(txt_PONo.Text) & "'"
            sqlstring = sqlstring & " ORDER BY PONO,PODATE"

            gconnection.getDataSet(sqlstring, "VW_PO_POBILL")
            If gdataset.Tables("VW_PO_POBILL").Rows.Count > 0 Then
                vcode = gdataset.Tables("VW_PO_POBILL").Rows(0).Item("suppliercode")
                PMTTRMS = gdataset.Tables("VW_PO_POBILL").Rows(0).Item("PAYMENTTERMS")
                DLVTRMS = gdataset.Tables("VW_PO_POBILL").Rows(0).Item("DELIVERYTERMS")
                Dim POTOTAL As Double
                POTOTAL = gdataset.Tables("VW_PO_POBILL").Rows(0).Item("POTOTAL")
                rViewer.ssql = sqlstring
                rViewer.Report = r
                rViewer.TableName = "VW_PO_POBILL"
                Dim textobj1 As TextObject
                textobj1 = r.ReportDefinition.ReportObjects("Text13")
                textobj1.Text = MyCompanyName

                Dim textobj3 As TextObject
                textobj3 = r.ReportDefinition.ReportObjects("Text5")
                textobj3.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode

                Dim textobj2 As TextObject
                textobj2 = r.ReportDefinition.ReportObjects("Text30")
                textobj2.Text = gUsername
                Dim t1 As TextObject
                t1 = r.ReportDefinition.ReportObjects("Text54")
                t1.Text = "Tel:" & GPHONE & ",40090019 , Fax:" & gFax & ", Email:pur@kga.in" & ", Web:" & gWebsite
                Dim textobj4 As TextObject
                textobj4 = r.ReportDefinition.ReportObjects("Text20")
                textobj4.Text = "Tin No.:" & gTinNo & ",Service Tax:" & gServiceTax & "CST.10986984"
                'If POTOTAL > 25000 Then
                '    Dim T4 As TextObject
                '    T4 = r.ReportDefinition.ReportObjects("Text55")
                '    T4.Text = "ASST. MANAGER PURCHASE"
                '    T4 = r.ReportDefinition.ReportObjects("Text57")
                '    T4.Text = "FINANCE MANAGER"
                '    T4 = r.ReportDefinition.ReportObjects("Text58")
                '    T4.Text = "CHIEF EXECUTIVE OFFICE"
                '    T4 = r.ReportDefinition.ReportObjects("Text59")
                '    T4.Text = "CHAIRMAN"
                '    T4 = r.ReportDefinition.ReportObjects("Text60")
                '    T4.Text = "HON TREASURER"
                '    T4 = r.ReportDefinition.ReportObjects("Text79")
                '    T4.Text = "_____________________________"
                '    T4 = r.ReportDefinition.ReportObjects("Text80")
                '    T4.Text = "_____________________________"
                '    T4 = r.ReportDefinition.ReportObjects("Text81")
                '    T4.Text = "______________________________"
                '    T4 = r.ReportDefinition.ReportObjects("Text82")
                '    T4.Text = "_______________________________"
                '    T4 = r.ReportDefinition.ReportObjects("Text83")
                '    T4.Text = "_____________________________"
                'ElseIf POTOTAL <= 25000 Then
                '    Dim T4 As TextObject
                '    T4 = r.ReportDefinition.ReportObjects("Text55")
                '    T4.Text = "ASST. MANAGER PURCHASE"
                '    T4 = r.ReportDefinition.ReportObjects("Text57")
                '    T4.Text = "FINANCE MANAGER"
                '    T4 = r.ReportDefinition.ReportObjects("Text58")
                '    T4.Text = "CHIEF EXECUTIVE OFFICE"
                '    T4 = r.ReportDefinition.ReportObjects("Text79")
                '    T4.Text = "----------------"
                '    T4 = r.ReportDefinition.ReportObjects("Text80")
                '    T4.Text = "----------------"
                '    T4 = r.ReportDefinition.ReportObjects("Text81")
                '    T4.Text = "----------------"
                'End If
                If Val(POTOTAL) < 25000.0 Then
                    Dim TXTOBJ7 As TextObject
                    TXTOBJ7 = r.ReportDefinition.ReportObjects("Text113")
                    TXTOBJ7.Text = ""
                    TXTOBJ7 = r.ReportDefinition.ReportObjects("Text112")
                    TXTOBJ7.Text = ""
                    TXTOBJ7 = r.ReportDefinition.ReportObjects("Text114")
                    TXTOBJ7.Text = ""
                    TXTOBJ7 = r.ReportDefinition.ReportObjects("Text115")
                    TXTOBJ7.Text = ""
                    TXTOBJ7 = r.ReportDefinition.ReportObjects("Text116")
                    TXTOBJ7.Text = ""
                End If
                If Val(POTOTAL) < 100000.0 Then
                    Dim TXTOBJ7 As TextObject
                    TXTOBJ7 = r.ReportDefinition.ReportObjects("Text112")
                    TXTOBJ7.Text = ""
                    TXTOBJ7 = r.ReportDefinition.ReportObjects("Text114")
                    TXTOBJ7.Text = ""
                    TXTOBJ7 = r.ReportDefinition.ReportObjects("Text115")
                    TXTOBJ7.Text = ""
                    TXTOBJ7 = r.ReportDefinition.ReportObjects("Text116")
                    TXTOBJ7.Text = ""
                End If




                If MyCompanyName = "Karnataka Golf Association" Then
                    Dim tc As TextObject
                    tc = r.ReportDefinition.ReportObjects("Text28")
                    tc.Text = ""
                End If
                Dim t5 As TextObject
                Dim TT As TextObject
                Dim vat, VATAMT As String
                Dim tet, TET1 As String
                't5 = r.ReportDefinition.ReportObjects("Text11")
                t5 = r.ReportDefinition.ReportObjects("Text88")
                TT = r.ReportDefinition.ReportObjects("Text89")
                ''M09042014*****************************
                ''sqlstring = "select distinct vat from vw_po_pobill"
                'sqlstring = "select VAT,SUM(ISNULL(RATE,0)-ISNULL(DISCAMT,0)) ONAMT FROM PO_ITEMDETAILS  WHERE PONO = '" & Trim(txt_PONo.Text) & "' GROUP BY VAT"
                'gconnection.getDataSet(sqlstring, "vw_po_pobill")
                'If gdataset.Tables("vw_po_pobill").Rows.Count > 0 Then
                '    't5.Text = "ADD:- VAT @"
                '    t5.Text = "ADD:- "
                '    For i = 0 To gdataset.Tables("vw_po_pobill").Rows.Count - 1

                '        vat = gdataset.Tables("vw_po_pobill").Rows(i).Item("vat") & " % ON " & gdataset.Tables("vw_po_pobill").Rows(i).Item("ONAMT")
                '        If tet = "" Then
                '            tet = vat
                '        Else
                '            'tet = tet & "," & vat
                '            tet = tet & vbNewLine & vat
                '        End If

                '    Next
                '    't5.Text = t5.Text & tet & " EXTRA"
                '    't5.Text = t5.Text & tet & " EXTRA"
                '    t5.Text = t5.Text & tet & ""
                'End If
                ''M09042014*****************************
                't5.Text = "ADD:- VAT @" & vat & "EXTRA"
                't5.Text = vat

                sqlstring = "SELECT SUM(VATAMT) AS VATAMT, VAT FROM PO_ITEMDETAILS WHERE pono='" & Trim(txt_PONo.Text) & "' GROUP BY VAT"
                gconnection.getDataSet(sqlstring, "vw_po_pobill")
                If gdataset.Tables("vw_po_pobill").Rows.Count > 0 Then
                    For i = 0 To gdataset.Tables("vw_po_pobill").Rows.Count - 1
                        vat = gdataset.Tables("vw_po_pobill").Rows(i).Item("VAT")
                        VATAMT = gdataset.Tables("vw_po_pobill").Rows(i).Item("VATAMT")
                        If tet = "" Then
                            tet = vat
                            TET1 = VATAMT
                        Else
                            tet = tet & vbNewLine & vat
                            TET1 = TET1 & vbNewLine & VATAMT
                        End If
                    Next
                    t5.Text = t5.Text & tet & ""
                    TT.Text = TT.Text & TET1 & ""
                End If

                sqlstring = " SELECT ISNULL(POED,0) AS ED, ISNULL(POCST,0) AS CST, ISNULL(pomodvat,0)AS POMODVAT, ISNULL(poptax,0) AS POPTAX,ISNULL(MODVATVAL,0) AS MODVATVAL, isnull(quot_date,'') as quot_date, isnull(poquotno,'') as poquotno, isnull(ser_ch,0) as ser_Ch, ISNULL(WARRANTY,'') AS WARRANTY  FROM PO_HDR WHERE pono='" & Trim(txt_PONo.Text) & "' "
                gconnection.getDataSet(sqlstring, "PO_HDR")
                If gdataset.Tables("PO_HDR").Rows.Count > 0 Then
                    Dim TMT As TextObject
                    Dim quotno As String
                    TMT = r.ReportDefinition.ReportObjects("Text11")
                    TMT.Text = gdataset.Tables("PO_HDR").Rows(0).Item("MODVATVAL")
                    TMT = r.ReportDefinition.ReportObjects("Text76")
                    TMT.Text = gdataset.Tables("PO_HDR").Rows(0).Item("ED")
                    TMT = r.ReportDefinition.ReportObjects("Text77")
                    TMT.Text = gdataset.Tables("PO_HDR").Rows(0).Item("CST")
                    TMT = r.ReportDefinition.ReportObjects("Text78")
                    TMT.Text = gdataset.Tables("PO_HDR").Rows(0).Item("POMODVAT")
                    TMT = r.ReportDefinition.ReportObjects("Text91")
                    TMT.Text = gdataset.Tables("PO_HDR").Rows(0).Item("POPTAX")
                    quotno = gdataset.Tables("po_hdr").Rows(0).Item("poquotno")
                    If quotno = "NA" Then
                        TMT = r.ReportDefinition.ReportObjects("Text102")
                        TMT.Text = ""
                    Else
                        TMT = r.ReportDefinition.ReportObjects("Text102")
                        TMT.Text = gdataset.Tables("po_hdr").Rows(0).Item("quot_date")
                    End If
                    TMT = r.ReportDefinition.ReportObjects("Text103")
                    TMT.Text = "SERVICE CH."
                    TMT = r.ReportDefinition.ReportObjects("Text104")
                    TMT.Text = gdataset.Tables("po_hdr").Rows(0).Item("ser_ch")
                    TMT = r.ReportDefinition.ReportObjects("Text106")
                    TMT.Text = gdataset.Tables("po_hdr").Rows(0).Item("WARRANTY")
                End If
                '***********INSERT INTO REPORT PAYMENT MODE AND DELVERY MODE*************
                sqlstring = ""
                sqlstring = "SELECT PAYMENTTERMCODE,PAYMENTTERMDESC FROM PO_PAYMENTTERMS WHERE PAYMENTTERMCODE='" & PMTTRMS & "'"
                gconnection.getDataSet(sqlstring, "PMT")
                If gdataset.Tables("PMT").Rows.Count > 0 Then
                    Dim PMT As TextObject
                    PMT = r.ReportDefinition.ReportObjects("Text67")
                    PMT.Text = gdataset.Tables("PMT").Rows(0).Item("PAYMENTTERMDESC")
                End If
                sqlstring = ""
                sqlstring = "SELECT DELIVERYTERMCODE, DELIVERYTERMDESC FROM PO_DELIVERYTERMS WHERE DELIVERYTERMCODE='" & DLVTRMS & "'"
                gconnection.getDataSet(sqlstring, "DVT")
                If gdataset.Tables("DVT").Rows.Count > 0 Then
                    Dim DVT As TextObject
                    DVT = r.ReportDefinition.ReportObjects("Text37")
                    DVT.Text = gdataset.Tables("DVT").Rows(0).Item("DELIVERYTERMDESC")
                End If

                '*************insert into report vendor details****************
                sqlstring = ""
                sqlstring = "select ISNULL(address,'') as address1,ISNULL(address2,'') as address2,ISNULL(address3,'') as address3,"
                sqlstring = sqlstring & "ISNULL(city,'') as city,ISNULL(pincode,0) as pincode,  ISNULL(email,'') as email, ISNULL(phone1,'') as phone1, ISNULL(phone2,'') as phone2, isnull(fax,0) as fax,"
                sqlstring = sqlstring & "ISNULL(contactperson,'') as contactperson, ISNULL(tinno,'') as tinno, ISNULL(panno,'') as panno from po_vendormaster where vendorcode='" & vcode & "'"
                gconnection.getDataSet(sqlstring, "vdetails")
                If gdataset.Tables("vdetails").Rows.Count > 0 Then
                    Dim vadd As TextObject
                    Dim city As String
                    vadd = r.ReportDefinition.ReportObjects("Text92")
                    vadd.Text = gdataset.Tables("vdetails").Rows(0).Item("address1")
                    vadd = r.ReportDefinition.ReportObjects("Text93")
                    vadd.Text = gdataset.Tables("vdetails").Rows(0).Item("address2")
                    vadd = r.ReportDefinition.ReportObjects("Text94")
                    vadd.Text = gdataset.Tables("vdetails").Rows(0).Item("address3")
                    vadd = r.ReportDefinition.ReportObjects("Text95")
                    city = gdataset.Tables("vdetails").Rows(0).Item("city") & "-" & gdataset.Tables("vdetails").Rows(0).Item("pincode")
                    vadd.Text = city
                    vadd = r.ReportDefinition.ReportObjects("Text96")
                    vadd.Text = gdataset.Tables("vdetails").Rows(0).Item("email")
                    vadd = r.ReportDefinition.ReportObjects("Text97")
                    vadd.Text = gdataset.Tables("vdetails").Rows(0).Item("phone1")
                    vadd = r.ReportDefinition.ReportObjects("Text98")
                    vadd.Text = gdataset.Tables("vdetails").Rows(0).Item("phone2")
                    vadd = r.ReportDefinition.ReportObjects("Text105")
                    vadd.Text = gdataset.Tables("vdetails").Rows(0).Item("fax")
                    vadd = r.ReportDefinition.ReportObjects("Text99")
                    vadd.Text = gdataset.Tables("vdetails").Rows(0).Item("contactperson")
                    vadd = r.ReportDefinition.ReportObjects("Text100")
                    vadd.Text = gdataset.Tables("vdetails").Rows(0).Item("tinno")
                    vadd = r.ReportDefinition.ReportObjects("Text101")
                    vadd.Text = gdataset.Tables("vdetails").Rows(0).Item("panno")

                Else
                    sqlstring = "select ISNULL(address1,'') as address1,ISNULL(address2,'') as address2,ISNULL(address3,'') as address3,"
                    sqlstring = sqlstring & "ISNULL(city,'') as city,ISNULL(pin,0) as pincode,  ISNULL(emailid,'') as email, ISNULL(cellno,'') as phone1, ISNULL(phoneno,'') as phone2, "
                    sqlstring = sqlstring & "ISNULL(contactperson,'') as contactperson, ISNULL(tinno,'') as tinno, ISNULL(panno,'') as panno,isnull(fax,0) as fax from ACCOUNTSSUBLEDGERMASTER where slcode='" & vcode & "'"
                    gconnection.getDataSet(sqlstring, "vdet")
                    If gdataset.Tables("vdet").Rows.Count > 0 Then
                        Dim vadd As TextObject
                        Dim city As String
                        vadd = r.ReportDefinition.ReportObjects("Text92")
                        vadd.Text = gdataset.Tables("vdet").Rows(0).Item("address1")
                        vadd = r.ReportDefinition.ReportObjects("Text93")
                        vadd.Text = gdataset.Tables("vdet").Rows(0).Item("address2")
                        vadd = r.ReportDefinition.ReportObjects("Text94")
                        vadd.Text = gdataset.Tables("vdet").Rows(0).Item("address3")
                        vadd = r.ReportDefinition.ReportObjects("Text95")
                        city = gdataset.Tables("vdet").Rows(0).Item("city") & "-" & gdataset.Tables("vdet").Rows(0).Item("pincode")
                        vadd.Text = city
                        vadd = r.ReportDefinition.ReportObjects("Text96")
                        vadd.Text = gdataset.Tables("vdet").Rows(0).Item("email")
                        vadd = r.ReportDefinition.ReportObjects("Text97")
                        vadd.Text = gdataset.Tables("vdet").Rows(0).Item("phone1")
                        vadd = r.ReportDefinition.ReportObjects("Text98")
                        vadd.Text = gdataset.Tables("vdet").Rows(0).Item("phone2")
                        vadd = r.ReportDefinition.ReportObjects("Text105")
                        vadd.Text = gdataset.Tables("vdet").Rows(0).Item("fax")
                        vadd = r.ReportDefinition.ReportObjects("Text99")
                        vadd.Text = gdataset.Tables("vdet").Rows(0).Item("contactperson")
                        vadd = r.ReportDefinition.ReportObjects("Text100")
                        vadd.Text = gdataset.Tables("vdet").Rows(0).Item("tinno")
                        vadd = r.ReportDefinition.ReportObjects("Text101")
                        vadd.Text = gdataset.Tables("vdet").Rows(0).Item("panno")

                    End If
                End If
                '********************************************************************

                rViewer.Show()
            Else
                MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
            End If

            '''Else
            '''    gPrint = False
            '''    Call printoperation()
            '''End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : View Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try


    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If MsgBox("Are you Sure Want to Exit from this Form", MessageBoxButtons.YesNo + MessageBoxIcon.Asterisk, "Action Confirm") = vbYes Then
            Me.Close()
        End If
    End Sub
    Private Sub Cmd_VcodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_VcodeHelp.Click
        Dim sqlstring As String
        Dim vform As New ListOperattion1_N
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
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_Vcode.Text = Trim(vform.keyfield & "")
            Txt_Vname.Text = Trim(vform.keyfield1 & "")
            Txt_Vcode.Focus()
        End If
        vform.Close()
        vform = Nothing
        Cbo_Approvedby.Focus()
    End Sub
    Private Sub Cbo_Dept_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cbo_Dept1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_PONo.Focus()
        End If
    End Sub
    Private Sub Txt_Vcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_Vcode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cmd_VcodeHelp_Click(sender, e)
        End If
    End Sub

    Private Sub Txt_Vcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Vcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Txt_Vcode.Text = "" Then
                Cmd_VcodeHelp_Click(sender, e)
            Else
                Txt_Vcode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub Txt_Vcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Vcode.Validated
        Dim j As Integer
        If Trim(Txt_Vcode.Text) <> "" Then
            'sqlstring = "SELECT SLCODE,SLNAME,FREEZEFLAG FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & gCreditors & "' AND SLCODE='" & Trim(Txt_Vcode.Text) & "'"
            sqlstring = "SELECT ISNULL(VENDORCODE,0) AS VENDORCODE, ISNULL(VENDORNAME,'') AS VENDORNAME FROM PO_VIEW_VENDORMASTER WHERE VENDORCODE = '" & Trim(Txt_Vcode.Text) & "' "
            gconnection.getDataSet(sqlstring, "ACCOUNTSSUBLEDGERMASTER")
            If gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows.Count > 0 Then
                Txt_Vcode.Text = Trim(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"))
                Txt_Vname.Text = Trim(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORNAME"))
                Me.Cbo_Approvedby.Focus()
            Else
                Me.Cmd_VcodeHelp_Click(sender, e)
                'Me.Txt_Vname.Focus()
            End If
        End If
    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='PURCHASE ORDER' AND MODULENAME LIKE 'Purchase Order%' ORDER BY RIGHTS"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.CmdAdd.Enabled = False
        Me.CmdFreeze.Enabled = False
        Me.CmdView.Enabled = False
        Me.CmdPrint.Enabled = False
        Me.cmd_export.Enabled = False
        Me.cmd_auth.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdAdd.Enabled = True
                    Me.CmdFreeze.Enabled = True
                    Me.CmdView.Enabled = True
                    Me.cmd_auth.Enabled = True
                    Me.cmd_export.Enabled = True
                    Me.CmdPrint.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.CmdAdd.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.CmdAdd.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.CmdAdd.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.CmdFreeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                    'Me.cmd_rpt.Enabled = True
                    Me.cmd_export.Enabled = True
                End If
                If Right(x) = "U" Then
                    Me.cmd_auth.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.CmdPrint.Enabled = True
                End If
            Next
        End If


    End Sub

    Private Sub Cbo_Approvedby_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cbo_Approvedby.KeyPress
        If Asc(e.KeyChar) = 13 Then
            'Me.Txt_GLAcIn.Focus()
            Me.Cbo_POStatus.Focus()
        End If
    End Sub

    Private Sub Cbo_ApprDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cbo_ApprDate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.Cbo_POStatus.Focus()
        End If
    End Sub

    Private Sub Cbo_POStatus_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cbo_POStatus.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.ssgrid.Focus()
            Me.ssgrid.SetActiveCell(1, 1)
        End If
    End Sub

    Private Sub FillMenu()
        Dim vform As New List_Operation
        Dim K As Integer
        Dim SqlQuery As String
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        'gSQLString = "SELECT DISTINCT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(STOCKUOM,'') AS STOCKUOM , isnull(clstock,0) clstock ,ISNULL(PURCHASERATE,0) AS PURCHASERATE FROM PO_VIEW_ITEMMASTER "
        'If Trim(search) = " " Then
        '    M_WhereCondition = ""
        'Else
        '    M_WhereCondition = " WHERE ITEMCODE LIKE '" & Trim(search) & "%' "
        'End If

        'VenuJD-----------------For RSI Club having vendor validate...
        If VENDORLINK = "Y" Then
            gSQLString = "SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM, ISNULL(I.PURCHASERATE,0) AS PURCHASERATE ,ISNULL(v.vendorcode,'') AS VENDORCODE,ISNULL(a.slcode,'') AS SLCODE FROM PO_VIEW_ITEMMASTER I,INVENTORYITEMMASTER M, inv_vendormaster v, ACCOUNTSSUBLEDGERMASTER a"
            If Trim(search) = " " Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = " WHERE I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(M.FREEZE,'') <> 'Y' AND M.CATEGORY = '" & Trim(cbo_warehouse.Text) & "' and  M.STORECODE= 'MNS' AND v.vendorcode = a.slcode And v.itemcode = I.itemcode AND V.VENDORCODE = '" & Trim(Txt_Vcode.Text) & "'"
            End If
            vform.Field = " I.ITEMNAME,I.ITEMCODE "
        Else
            gSQLString = "SELECT DISTINCT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(STOCKUOM,'') AS STOCKUOM ,ISNULL(PURCHASERATE,0) AS PURCHASERATE FROM PO_VIEW_ITEMMASTER "
            If Trim(search) = " " Then
                M_WhereCondition = ""
            Else
                M_WhereCondition = " WHERE ITEMCODE LIKE '" & Trim(search) & "%' "
            End If
            vform.Field = " ITEMNAME,ITEMCODE "
        End If

        vform.vFormatstring = "    ITEMCODE    |                     ITEMNAME                    |  STOCKUOM  | PURCHASERATE |"
        vform.vCaption = "PURCHASE ORDER ITEM CODE HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.KeyPos2 = 2
        vform.Keypos3 = 3
        'vform.keypos4 = 4
        ' vform.keypos4 = 5
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            ssgrid.Col = 1
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield)
            Call check_Duplicate(vform.keyfield)
            If Dupchk = True Then
                ssgrid.Focus()
                Exit Sub
            End If
            ssgrid.Col = 2
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield1)
            'ssgrid.Col = 3
            'ssgrid.Row = ssgrid.ActiveRow
            'ssgrid.TypeComboBoxString = Trim(vform.keyfield2)
            'ssgrid.Text = Trim(vform.keyfield2)
            ssgrid.SetText(5, ssgrid.ActiveRow, Format(Now.Today, "dd/MM/yyyy"))
            ssgrid.Col = 6
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield3)
            ssgrid.Col = 7
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(0.0)
            ssgrid.Col = 8
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(0.0)

            ssgrid.Col = 3
            '  SqlQuery = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & Trim(vform.keyfield) & "' and STORECODE='" & txt_Storecode.Text & "'"
            SqlQuery = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & Trim(vform.keyfield) & "' "
            gconnection.getDataSet(SqlQuery, "InventoryItemUOM")
            If gdataset.Tables("InventoryItemUOM").Rows.Count > 1 Then
                Call FillTransUOM(Trim(vform.keyfield))
            ElseIf gdataset.Tables("InventoryItemUOM").Rows.Count = 1 Then
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.TypeComboBoxString = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
                ssgrid.Text = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
            Else
                ssgrid.Row = ssgrid.ActiveRow
                ssgrid.Text = Trim(vform.keyfield2)
            End If
            ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
            'ssgrid.Focus()
        Else
            ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
            Exit Sub
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub FillTransUOM(ByVal itemcode As String)
        'gSQLString = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & itemcode & "'  and STORECODE='" & txt_Storecode.Text & "' "
        gSQLString = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & itemcode & "'   "

        If Trim(search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " AND  Tranuom LIKE '" & Trim(search) & "%'"
        End If
        Dim vform1 As New ListOperattion1_N
        vform1.Field = "TRANUOM"
        vform1.vFormatstring = "     TRANS UOM                                                                                                   "
        vform1.vCaption = " PURCHASE UOMMASTER HELP"
        vform1.KeyPos = 0
        vform1.ShowDialog(Me)
        If Trim(vform1.keyfield & "") <> "" Then
            ssgrid.Col = 3
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform1.keyfield & "")
            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
            ssgrid.Focus()
        End If
        vform1.Close()
        vform1 = Nothing
    End Sub
    Private Sub FillMenuUOM()
        Dim vform As New List_Operation
        Dim K As Integer
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        gSQLString = "SELECT DISTINCT ISNULL(UOMCODE,'') AS UOMCODE,ISNULL(UOMDESC,'') AS UOMDESC FROM UOMMASTER "
        If Trim(search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " WHERE UOMCODE LIKE '" & Trim(search) & "%' "
        End If
        vform.Field = " UOMDESC,UOMCODE "
        vform.vFormatstring = "    UOMCODE    |                     UOMDESC                    "
        vform.vCaption = "UOM MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            ssgrid.Col = 3
            ssgrid.Row = ssgrid.ActiveRow
            ssgrid.Text = Trim(vform.keyfield1)
            ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
            ssgrid.Focus()
        Else
            ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
            Exit Sub
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub ssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
        If e.keyCode = Keys.Tab Then
            Me.Txt_Remarks.Focus()
            Exit Sub
        End If
        Dim i, j, K As Integer
        Dim sqlstring, Itemcode, Itemdesc, sqlstring9 As String

        sqlstring9 = "select isnull(VENDORLINK,'N') as VENDORLINK from invsetup"
        gconnection.getDataSet(sqlstring9, "invsetup")
        If gdataset.Tables("invsetup").Rows.Count > 0 Then
            VENDORLINK = gdataset.Tables("invsetup").Rows(0).Item("VENDORLINK")
        End If

        With ssgrid
            If e.keyCode = Keys.Enter Then
                i = ssgrid.ActiveRow
                If ssgrid.ActiveCol = 1 Then
                    ssgrid.Col = 1
                    ssgrid.Row = i
                    If ssgrid.Lock = False Then
                        Dim temp As String
                        temp = "0.00"
                        ssgrid.Col = 4
                        temp = ssgrid.Text
                        ssgrid.Col = 1
                        If Val(temp) = 0 Then
                            If Trim(ssgrid.Text) = "" Then
                                Call FillMenu() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
                            Else
                                Itemcode = Trim(ssgrid.Text)
                                Call check_Duplicate(Itemcode)
                                If Dupchk = True Then
                                    ssgrid.Focus()
                                    Exit Sub
                                End If
                                'ssgrid.ClearRange(1, ssgrid.ActiveRow, 10, ssgrid.ActiveRow, True)
                                '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''

                                'sqlstring = "SELECT DISTINCT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(STOCKUOM,'') AS STOCKUOM,ISNULL(PURCHASERATE,0) AS PURCHASERATE FROM PO_VIEW_ITEMMASTER "
                                'sqlstring = sqlstring & " WHERE ITEMCODE ='" & Trim(Itemcode) & "' "
                                If VENDORLINK = "Y" Then
                                    sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, ISNULL(v.vendorcode,'') AS VENDORCODE,ISNULL(a.slcode,'') AS SLCODE FROM PO_VIEW_ITEMMASTER I, INVENTORYITEMMASTER M, inv_vendormaster v, ACCOUNTSSUBLEDGERMASTER a"
                                    sqlstring = sqlstring & " WHERE I.ITEMCODE ='" & Trim(Itemcode) & "' AND ISNULL(M.FREEZE,'') <> 'Y' AND M.CATEGORY = '" & Trim(cbo_warehouse.Text) & "' and  M.STORECODE= 'MNS' AND v.vendorcode = a.slcode And v.itemcode = I.itemcode AND V.VENDORCODE = '" & Trim(Txt_Vcode.Text) & "'"
                                Else
                                    sqlstring = "SELECT DISTINCT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(STOCKUOM,'') AS STOCKUOM,ISNULL(PURCHASERATE,0) AS PURCHASERATE FROM PO_VIEW_ITEMMASTER "
                                    sqlstring = sqlstring & " WHERE ITEMCODE ='" & Trim(Itemcode) & "' "
                                End If
                                gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER")
                                If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count > 0 Then
                                    ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
                                    ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMNAME")))
                                    'ssgrid.SetText(3, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM")))
                                    ssgrid.SetText(5, i, Format(Now.Today, "dd/MM/yyyy"))
                                    ssgrid.SetText(6, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("PURCHASERATE")))
                                    ssgrid.SetText(7, i, Trim(0.0))
                                    ssgrid.SetText(8, i, Trim(0.0))
                                    ssgrid.Col = 3
                                    Dim SqlQuery As String
                                    ssgrid.Row = ssgrid.ActiveRow
                                    SqlQuery = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")) & "'  "
                                    gconnection.getDataSet(SqlQuery, "InventoryItemUOM")
                                    If gdataset.Tables("InventoryItemUOM").Rows.Count > 1 Then
                                        Call FillTransUOM(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
                                    ElseIf gdataset.Tables("InventoryItemUOM").Rows.Count = 1 Then
                                        ssgrid.Row = ssgrid.ActiveRow
                                        ssgrid.TypeComboBoxString = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
                                        ssgrid.Text = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
                                    Else
                                        ssgrid.Row = ssgrid.ActiveRow
                                        ssgrid.Text = Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM")))
                                    End If
                                    ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                                    'ssgrid.SetActiveCell(2, ssgrid.ActiveRow)
                                    ssgrid.Focus()
                                Else
                                    MessageBox.Show("Specified ITEM CODE not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                    ssgrid.Col = 1
                                    ssgrid.Row = i
                                    ssgrid.Text = ""
                                    ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
                                    ssgrid.Focus()
                                    Exit Sub
                                End If
                            End If
                        Else
                            ssgrid.SetActiveCell(3, i)
                            Call SelectText()
                        End If
                    Else
                        .SetActiveCell(1, .ActiveRow)
                    End If
                    'ElseIf ssgrid.ActiveCol = 3 Then
                    '    ssgrid.Col = 3
                    '    ssgrid.Row = i
                    '    If ssgrid.Lock = False Then
                    '        If Trim(ssgrid.Text) = "" Then
                    '            Call FillMenuUOM() ''' IT WILL SHOW A POPUP MENU FOR UOM CODE
                    '        Else
                    '            Itemcode = Trim(ssgrid.Text)
                    '            sqlstring = "SELECT DISTINCT ISNULL(UOMCODE,'') AS UOMCODE,ISNULL(UOMDESC,'') AS UOMDESC FROM UOMMASTER"
                    '            sqlstring = sqlstring & " WHERE UOMCODE ='" & Trim(Itemcode) & "'"
                    '            gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER")
                    '            If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count > 0 Then
                    '                ssgrid.SetText(3, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("UOMCODE")))
                    '                ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
                    '                ssgrid.Focus()
                    '            Else
                    '                MessageBox.Show("Specified Uom not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    '                ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
                    '                ssgrid.Text = ""
                    '                ssgrid.Focus()
                    '                Exit Sub
                    '            End If
                    '        End If
                    '    Else
                    '        .SetActiveCell(3, .ActiveRow)
                    '    End If
                ElseIf .ActiveCol = 4 Then
                    .Col = 4
                    .Row = .ActiveRow
                    If .Lock = False Then
                        If Val(.Text) = 0 Then
                            .SetActiveCell(3, .ActiveRow)
                        Else
                            Call GRIDCALCULATION() '''--> Calculate total amount
                            .SetActiveCell(5, .ActiveRow)
                            Call SelectText()
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 5 Then
                    .Col = 5
                    .Row = .ActiveRow
                    If .Lock = False Then
                        'If CDate(.Text) < Now.Date.Today Then
                        '    MsgBox("Required Date Can't be Less than Current Date!", MsgBoxStyle.MsgBoxSetForeground, MyCompanyName)
                        '    .SetActiveCell(4, .ActiveRow)
                        'Else
                        .SetActiveCell(5, .ActiveRow)
                        .SelText = .Text
                        'End If
                    End If
                ElseIf ssgrid.ActiveCol = 6 Then
                    .Col = 6
                    .Row = .ActiveRow
                    If .Lock = False Then
                        If Val(.Text) < 0 Then
                            .SetActiveCell(5, ssgrid.ActiveRow)
                        Else
                            Dim A As System.EventArgs
                            Call GRIDCALCULATION() '''--> Calculate total amount
                            Call ssgrid_Leave(ssgrid, A)
                            .SetActiveCell(6, .ActiveRow)
                            Call SelectText()
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 7 Then
                    .Col = 7
                    .Row = .ActiveRow
                    If .Lock = False Then
                        If Val(.Text) < 0 Then
                            .SetActiveCell(6, ssgrid.ActiveRow)
                        Else
                            Call GRIDCALCULATION() '''--> Calculate total amount
                            .SetActiveCell(7, .ActiveRow)
                            Call SelectText()
                        End If
                    End If
                ElseIf ssgrid.ActiveCol = 8 Then
                    Call GRIDCALCULATION()
                    .SetActiveCell(0, .ActiveRow + 1)
                End If
                'MAN
                ssgrid.Col = 6
                ssgrid.Row = i
                ssgrid.Lock = False
                Dim U As System.EventArgs
                Call ssgrid_Leave(ssgrid.Text, U) ' P.O value calculation
            ElseIf e.keyCode = Keys.F3 Then
                .DeleteRows(.ActiveRow, 1)
                .SetActiveCell(1, .ActiveRow)
            End If
        End With
    End Sub
    Private Function check_Duplicate(ByVal Itemcode As String)
        Dim i As Integer
        Dupchk = False
        ssgrid.Col = 1
        For i = 1 To ssgrid.DataRowCnt
            ssgrid.Row = i
            If i <> ssgrid.ActiveRow Then
                If Trim(ssgrid.Text) = Itemcode Then
                    MsgBox("Item Already exists", MsgBoxStyle.Critical, "Duplicate")
                    Dupchk = True
                End If
            End If
        Next
    End Function
    Function SelectText()
        SendKeys.Send("Space") '''-->Select text in cell
        SendKeys.Send("{Home}")
        SendKeys.Send("+{End}")
    End Function
    Function GRIDCALCULATION()
        With ssgrid
            Dim temp, temp1, total, temp_discount As Double
            temp = Nothing
            .Col = 4 ' QTY
            .Row = .ActiveRow
            temp = Val(.Text)
            .Col = 6 ' RATE
            .Row = .ActiveRow
            temp1 = Val(.Text)
            total = temp * temp1 ' QTY * RATE
            .Col = 10 'Amount column
            .Row = .ActiveRow
            .Text = Val(total)
            temp = Nothing
            temp1 = Nothing

            '.Col = 8 ' VAT
            '.Row = .ActiveRow
            'temp = Val(.Text)
            'temp1 = (total * temp) / 100 ' TEMP1 = VAT
            'total = total + temp1 ' TOTAL = TOTAL + VAT

            .Col = 7 ' DISCOUNT
            .Row = .ActiveRow
            temp_discount = Val(.Text) ' old temp
            temp_discount = (total * temp_discount) / 100 ' calculating total discount for the %
            total = total - temp_discount ' TOTAL - DISCOUNT 'old total - temp
            temp = Nothing

            .Col = 8 ' VAT
            .Row = .ActiveRow
            temp = Val(.Text)
            temp1 = (total * temp) / 100 ' TEMP1 = VAT
            total = total + temp1 ' TOTAL = TOTAL + VAT
            .Col = 9
            .Text = Val(total)
            .Col = 11
            .Text = Val(temp_discount)
            .Col = 12
            .Text = Val(temp1)
            temp = Nothing
            temp1 = Nothing
            total = Nothing
            temp_discount = Nothing
        End With
    End Function

    Private Sub Txt_ED_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_ED.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Format(Val(Txt_ED.Text), "0.00") > 100 Then
                MsgBox("PERCENTAGE SHOULD BE LESS THAN 100")
                Txt_ED.Text = ""
                Txt_ED.Focus()
                Exit Sub
            End If
            Call ssgrid_Leave(sender, e)
            Txt_CST.Focus()
        End If
    End Sub

    Private Sub Txt_CST_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_CST.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Format(Val(Txt_CST.Text), "0.00") > 100 Then
                MsgBox("PERCENTAGE SHOULD BE LESS THAN 100")
                Txt_CST.Text = ""
                Txt_CST.Focus()
                Exit Sub
            End If
            Call ssgrid_Leave(sender, e)
            Txt_MODVat.Focus()
        End If
    End Sub

    Private Sub Txt_MODVat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_MODVat.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Format(Val(Txt_MODVat.Text), "0.00") > 100 Then
                MsgBox("PERCENTAGE SHOULD BE LESS THAN 100")
                Txt_MODVat.Text = ""
                Txt_MODVat.Focus()
                Exit Sub
            End If
            Call ssgrid_Leave(sender, e)
            Txt_PTax.Focus()
        End If
    End Sub

    Private Sub Txt_Octra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Octra.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Format(Val(Txt_Octra.Text), "0.00") > 100 Then
                MsgBox("PERCENTAGE SHOULD BE LESS THAN 100")
                Txt_Octra.Text = ""
                Txt_Octra.Focus()
                Exit Sub
            End If
            Call ssgrid_Leave(sender, e)
            Txt_Insurance.Focus()
        End If
    End Sub

    Private Sub Txt_PTax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PTax.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Format(Val(Txt_PTax.Text), "0.00") > 100 Then
                MsgBox("PERCENTAGE SHOULD BE LESS THAN 100")
                Txt_PTax.Text = ""
                Txt_PTax.Focus()
                Exit Sub
            End If
            Call ssgrid_Leave(sender, e)
            Txt_Octra.Focus()
        End If
    End Sub

    Private Sub Txt_Insurance_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Insurance.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Format(Val(Txt_Insurance.Text), "0.00") > 100 Then
                MsgBox("PERCENTAGE SHOULD BE LESS THAN 100")
                Txt_Insurance.Text = ""
                Txt_Insurance.Focus()
                Exit Sub
            End If
            Call ssgrid_Leave(sender, e)
            Txt_LST.Focus()
        End If
    End Sub

    Private Sub Txt_LST_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_LST.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Format(Val(Txt_LST.Text), "0.00") > 100 Then
                MsgBox("PERCENTAGE SHOULD BE LESS THAN 100")
                Txt_LST.Text = ""
                Txt_LST.Focus()
                Exit Sub
            End If
            Call ssgrid_Leave(sender, e)
            TXT_ADVANCEPERC.Focus()
            'Txt_POTerms.Focus()
        End If
    End Sub

    Private Sub Txt_DeliveryTerms_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If Txt_DeliveryTerms.Text = "" Then
                Cmd_DeliveryTermHelp_Click_1(sender, e)
            Else
                Txt_DeliveryTerms_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub Txt_POTerms_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If Txt_POTerms.Text = "" Then
                Cmd_POTermsHelp_Click_1(sender, e)
            Else
                Txt_POTerms_Validated1(sender, e)
            End If
        End If
    End Sub

    Private Sub Txt_DespatchPort_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_despatch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.Cmb_shipping.Focus()
        End If
    End Sub


    Private Sub Txt_ShippingPort_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_shipping.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.Cmb_delivery.Focus()
        End If
    End Sub

    Private Sub Txt_DeliveryPort_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_delivery.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.Txt_CreditDays.Focus()
        End If
    End Sub

    Private Sub Txt_CreditDays_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_CreditDays.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Txt_CreditDays.Text <> "" Then
                Txt_CreditDays_Validated(sender, e)
            Else
                Me.Txt_CreditDays.Focus()
            End If
            Me.Txt_Encl.Focus()
        End If
    End Sub

    Private Sub Txt_Encl_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Me.Txt_Remarks.Focus()
        End If
    End Sub

    Private Sub Txt_Remarks_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            AmendmentGrid.Focus()
            AmendmentGrid.SetActiveCell(1, 1)

        End If
    End Sub

    Private Sub AmendmentGrid_KeyDownEvent(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles AmendmentGrid.KeyDownEvent
        If e.keyCode = Keys.Tab Then
            FollowupGrid.Focus()
            Exit Sub
        End If
        With AmendmentGrid
            If e.keyCode = Keys.Enter Then
                AmendmentGrid.Row = AmendmentGrid.ActiveRow
                If AmendmentGrid.ActiveCol = 1 Then
                    AmendmentGrid.Col = 1
                    AmendmentGrid.Lock = False
                    If AmendmentGrid.Text <> "" Then
                        AmendmentGrid.SetActiveCell(2, .ActiveRow)
                    Else
                        AmendmentGrid.SetActiveCell(1, .ActiveRow)
                    End If
                ElseIf AmendmentGrid.ActiveCol = 2 Then
                    AmendmentGrid.Col = 2
                    AmendmentGrid.Lock = False
                    If AmendmentGrid.Text <> "" Then
                        AmendmentGrid.SetActiveCell(3, .ActiveRow)
                    Else
                        AmendmentGrid.SetActiveCell(2, .ActiveRow)
                    End If
                ElseIf AmendmentGrid.ActiveCol = 3 Then
                    AmendmentGrid.Col = 3
                    AmendmentGrid.Lock = False
                    If AmendmentGrid.Text <> "" Then
                        AmendmentGrid.SetActiveCell(1, .ActiveRow + 1)
                    Else
                        AmendmentGrid.SetActiveCell(3, .ActiveRow)
                    End If
                End If
            ElseIf e.keyCode = Keys.F3 Then
                .DeleteRows(.ActiveRow, 1)
                .SetActiveCell(1, .ActiveRow)
            End If
        End With
    End Sub

    Private Sub Txt_AdvanceAmt_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Call ssgrid_Leave(sender, e)
            Txt_POTerms.Focus()
        End If
    End Sub

    Private Sub txt_PONo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_PONo.Validated
        Dim sqlstring, financalyear As String
        Dim voucherno As String
        Dim CreditDebit As String
        Dim i, j As Integer
        Dim amount As Double
        Dim accounthead, slhead, costhead As String

        PoNumber = Nothing

        If Trim(Me.txt_PONo.Text) <> "" Then
            'voucherno = VOUCHERNOVALIDATE()
            'sqlstring = "Select * From JournalEntry Where VoucherNo='" & voucherno & "' and VoucherType='" & Trim(Me.Txt_VoucherPrefix.Text) & "' Order By OppAccountCode,CreditDebit"
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialyearEnd, 3, 4)
            If Val(Me.txt_PONo.Text) > 0 Then
                'Me.txt_PONo.Text = "PUR" & "/" & Format(Val(Me.txt_PONo.Text), "000000") & "/" & financalyear
                Me.txt_PONo.Text = doctype & "/" & Format(Val(Me.txt_PONo.Text), "000000") & "/" & financalyear
            End If
            Call VOUCHERNOVALIDATIONS(Me.txt_PONo.Text, "PUR")
            PoNumber = Trim(Me.txt_PONo.Text)
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            'GetRights()
        End If
    End Sub
    Function FillMatter()
        Dim MainMenu As Object
        Dim ADODB As Object
        Dim Loopindex As Integer
        Dim vtype As String
        Dim i As Integer
        Dim bill As New DataTable
        Dim bill1 As New DataTable
        Dim dt As New DataTable
        Dim TNAME As String
        TNAME = "MESSAGE"
        sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(txt_PONo.Text) & "' and DOCTYPE='SUBJECT' order by slno"
        bill = gconnection.GetValues(sqlstring)
        If bill.Rows.Count > 0 Then
            Loopindex = 0
            Ssgrid_subject.ClearRange(1, 1, -1, -1, True)
            Ssgrid_subject.Focus()
            For i = 0 To bill.Rows.Count - 1
                Loopindex = Loopindex + 1
                Ssgrid_subject.SetText(1, Loopindex, bill.Rows(i).Item("MESSAGE"))
            Next
        End If
        bill.Clear()
        sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(txt_PONo.Text) & "' and DOCTYPE='REFERENCE' order by slno"
        bill = gconnection.GetValues(sqlstring)
        If bill.Rows.Count > 0 Then
            Loopindex = 0
            Ssgrid_reference.ClearRange(1, 1, -1, -1, True)
            Ssgrid_reference.Focus()
            For i = 0 To bill.Rows.Count - 1
                Loopindex = Loopindex + 1
                Ssgrid_reference.SetText(1, Loopindex, bill.Rows(i).Item("MESSAGE"))
            Next
        End If
        bill.Clear()
        sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(txt_PONo.Text) & "' and DOCTYPE='BODY' order by slno"
        bill = gconnection.GetValues(sqlstring)
        If bill.Rows.Count > 0 Then
            Loopindex = 0
            Ssgrid_body.ClearRange(1, 1, -1, -1, True)
            Ssgrid_body.Focus()
            For i = 0 To bill.Rows.Count - 1
                Loopindex = Loopindex + 1
                Ssgrid_body.SetText(1, Loopindex, bill.Rows(i).Item("MESSAGE"))
            Next
        End If
    End Function
    Private Sub VOUCHERNOVALIDATIONS(ByVal VoucherNo As String, ByVal VoucherType As String)
        Dim I, J, K As Integer
        Dim strsql, itemcode, Remarks, cat As String
        Dim e As System.EventArgs
        If Trim(txt_PONo.Text) <> "" Then
            strsql = "SELECT isnull(auth_docno,'') as auth_docno,ISNULL(POADVPERC,0) AS POADVPERC,ISNULL(SUBJECT,'') AS SUBJECT, ISNULL(CATEGORY,'') AS CATEGORY,*  FROM PO_HDR WHERE pono='" & Trim(txt_PONo.Text) & "'"
            gconnection.getDataSet(strsql, "PO_HDR")
            If gdataset.Tables("PO_HDR").Rows.Count > 0 Then
                txt_PONo.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PONO"))
                If Trim(gdataset.Tables("PO_HDR").Rows(0).Item("DOCTYPE")) = "DRY" Then
                    cbo_warehouse.Text = "DRY RATION"
                ElseIf Trim(gdataset.Tables("PO_HDR").Rows(0).Item("DOCTYPE")) = "GDN" Then
                    cbo_warehouse.Text = "GODOWN"
                End If
                Me.CmdAdd.Text = "Update[F7]"
                CAT = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("DOCTYPE"))
                cbo_warehouse.Text = CAT
                cbo_warehouse.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("CATEGORY"))
                TXT_SUBJECT.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("SUBJECT"))
                cbo_warehouse.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("CATEGORY"))
                TXT_ADVANCEPERC.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POADVPERC"))
                txt_MOD.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PODESPMODE"))
                TXT_DOCTHROUGH.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PODOCSTHROUGH"))
                txt_SalesTax.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POSALET"))
                Cbo_PODate.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PODATE"))
                cbo_dept.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PODepartment"))
                txt_docno.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("auth_docno"))
                Txt_QuotNo.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POquotno"))
                Txt_Vcode.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("povendorcode"))
                Txt_footer.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("updfooter"))
                Txt_signature.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("updsign"))


                strsql = "SELECT ISNULL(VENDORCODE,0) AS VENDORCODE, ISNULL(VENDORNAME,'') AS VENDORNAME FROM PO_VIEW_VENDORMASTER WHERE VENDORCODE = '" & Trim(Txt_Vcode.Text) & "' "
                'strsql = "SELECT slname FROM accountssubledgermaster WHERE slcode='" & Trim(Txt_Vcode.Text) & "'"
                gconnection.getDataSet(strsql, "accountssubledgermaster")
                Txt_Vname.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("vendorname"))

                Cbo_Approvedby.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POapprovedby"))
                Cbo_ApprDate.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POapproveddate"))

                Txt_GLAcIn.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POGLACIN"))
                Call Txt_GLAcIn_Validated(Me.Txt_GLAcIn.Text, e)

                Cbo_POStatus.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POstatus"))
                Txt_ED.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POed"))
                Txt_CST.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POcst"))
                Txt_MODVat.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POmodvat"))
                Txt_PTax.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POptax"))
                Txt_Octra.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POoctra"))
                Txt_Insurance.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POinsurance"))
                Txt_LST.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POlst"))
                Txt_POValue.Text = Trim(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POvalue"), "0.00"))
                Txt_TotalVat.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POtotalvat"))
                Txt_TotalTax.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POtotaltax"))
                Txt_AdvanceAmt.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POadvance"))

                TXT_OVERALLDISC.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POOVERALLDISC"))
                TXT_CF.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"))
                TXT_TRANSPORT.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"))
                TXT_DELIVERY.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"))

                Txt_Balance.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PObalance"))
                Txt_POTerms.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POterms"))
                If Trim(Txt_POTerms.Text) <> "" Then
                    sqlstring = "SELECT ISNULL(PAYMENTTERMCODE,0) AS PAYMENTTERMCODE,ISNULL(PAYMENTTERMDESC,'') AS PAYMENTTERMDESC FROM PO_PAYMENTTERMS WHERE PAYMENTTERMCODE = '" & Txt_POTerms.Text & "' "
                    gconnection.getDataSet(sqlstring, "PO_PAYMENTTERMS")
                    If gdataset.Tables("PO_PAYMENTTERMS").Rows.Count > 0 Then
                        Txt_POTerms.Text = Trim(gdataset.Tables("PO_PAYMENTTERMS").Rows(0).Item("PAYMENTTERMCODE"))
                        TXT_PAYMTTERMS_DESC.Text = Trim(gdataset.Tables("PO_PAYMENTTERMS").Rows(0).Item("PAYMENTTERMDESC"))
                    End If
                End If

                Txt_DeliveryTerms.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POdeliveryterms"))
                If Trim(Txt_DeliveryTerms.Text) <> "" Then
                    sqlstring = "SELECT ISNULL(DELIVERYTERMCODE,0) AS DELIVERYTERMCODE,ISNULL(DELIVERYTERMDESC,'') AS DELIVERYTERMDESC FROM PO_DELIVERYTERMS where deliverytermcode = '" & Txt_DeliveryTerms.Text & "' "
                    gconnection.getDataSet(sqlstring, "PO_DELIVERYTERMS")
                    If gdataset.Tables("PO_DELIVERYTERMS").Rows.Count > 0 Then
                        Txt_DeliveryTerms.Text = Trim(gdataset.Tables("PO_DELIVERYTERMS").Rows(0).Item("DELIVERYTERMCODE"))
                        TXT_DELIVTERMS_DESC.Text = Trim(gdataset.Tables("PO_DELIVERYTERMS").Rows(0).Item("DELIVERYTERMDESC"))
                        Me.Txt_AdvanceAmt.Focus()
                    End If
                End If

                Cmb_despatch.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POdespatch"))
                Cmb_shipping.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POshipping"))
                Cmb_delivery.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POdelivery"))
                Txt_CreditDays.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POcreditdays"))
                Txt_Encl.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POencl"))

                Remarks = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POremarks"))
                Txt_Remarks.Text = Replace(Remarks, "?", "'")
                If gdataset.Tables("PO_HDR").Rows(0).Item("POclosure") = "C" Then
                    Cbo_Closure.SelectedIndex = 0
                    CmdFreeze.Enabled = False
                    CmdAdd.Enabled = False
                ElseIf gdataset.Tables("PO_HDR").Rows(0).Item("POclosure") = "F" Then
                    Cbo_Closure.SelectedIndex = 1
                Else
                    Cbo_Closure.SelectedIndex = -1
                End If

                'For Managing Committee Purchase Order Starts Retrieve Here
                If gdataset.Tables("PO_HDR").Rows(0).Item("pomcpo") = "Y" Then
                    Me.Chk_MC_Form.Checked = True
                    Me.Txt_WarrantyCode.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POwarrantyterms"))
                    Me.Txt_OtherTermCode.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POotherterms"))
                    Call FillMatter()
                Else
                    Me.Chk_MC_Form.Checked = False
                    Me.Txt_WarrantyCode.Text = ""
                    Me.Txt_OtherTermCode.Text = ""
                End If
                'For Managing Committee Purchase Order Ends

                'Cbo_Closure.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POclosure"))
                Cmb_Freight.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POfreight"))
                Cmb_CSTForm.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POcstform"))
                'Cbo_PODate.Focus()
                txt_PONo.ReadOnly = True
                If gdataset.Tables("PO_HDR").Rows(0).Item("Freeze") = "Y" Then
                    Me.lbl_Freeze.Visible = True
                    Me.lbl_Freeze.Text = ""
                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("PO_HDR").Rows(0).Item("AddDatetime")), "dd-MMM-yyyy")
                    Me.CmdFreeze.Enabled = False
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.CmdFreeze.Text = "Freeze[F8]"
                End If
                Me.CmdAdd.Text = "Update[F7]"
                Me.AmendmentGrid.Lock = False
                Me.FollowupGrid.Lock = False
                '----------------------ITEMDETAILS RETRIEVE----------------------------
                strsql = "SELECT * FROM PO_ITEMDETAILS WHERE pono='" & Trim(txt_PONo.Text) & "' ORDER BY AUTOID "
                gconnection.getDataSet(strsql, "PO_ITEMDETAILS")
                If gdataset.Tables("PO_ITEMDETAILS").Rows.Count > 0 Then
                    Dim count, temp, tcode As String
                    For I = 0 To gdataset.Tables("PO_ITEMDETAILS").Rows.Count - 1
                        tcode = gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("itemcode")
                        'LIN
                        strsql = "SELECT itemcode,itemname,STOCKuom FROM PO_VIEW_ITEMMASTER "
                        strsql = strsql & "WHERE itemcode='" & Trim(tcode) & "' "
                        gconnection.getDataSet(strsql, "inventoryitemmaster")
                        count = gdataset.Tables("PO_ITEMDETAILS").Rows.Count
                        With ssgrid
                            .Row = I + 1
                            .Col = 1
                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("itemcode")

                            .Col = 2
                            .Text = gdataset.Tables("inventoryitemmaster").Rows(0).Item("itemname")

                            .Col = 3
                            .Text = gdataset.Tables("inventoryitemmaster").Rows(0).Item("STOCKUOM")

                            .Col = 4
                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("quantity")

                            '.Col = 5
                            'Dim a As DateTime
                            'a = Trim(gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("requireddate"))
                            '.CellType = FPSpreadADO.CellTypeConstants.CellTypeDate
                            '.SetText(.Col, .Row, a)
                            .Col = 6
                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("rate")
                            .CellType = FPSpreadADO.CellTypeConstants.CellTypeFloat
                            .Col = 7
                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("discount")

                            .Col = 8
                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("vat")

                            .Col = 9
                            'Dim ttotal, vattotal, rate, qty, vat As Double
                            'rate = gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("rate")
                            'qty = gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("quantity")
                            'vat = gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("vat")
                            'vattotal = (rate * qty) - gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("discount")
                            'vattotal = (vattotal * vat) / 100
                            'vattotal = vattotal + gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("total")
                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("total")
                            '.Text = Val(vattotal)
                            'vattotal = Nothing
                            'ttotal = 0 : vattotal = 0 : rate = 0 : qty = 0 : vat = 0
                            .Col = 10
                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("Amount")
                            .Col = 11
                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("DiscAmt")
                            .Col = 12
                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(I).Item("VatAmt")
                        End With
                    Next
                End If
                '----------------------------AMENDMENT RETRIEVE-------------------

                strsql = "SELECT poamendmentno,poamendmentdate,poamendmentdesc FROM PO_AMENDMENT WHERE PONO='" & Trim(txt_PONo.Text) & "' "
                gconnection.getDataSet(strsql, "PO_AMENDMENT")
                If gdataset.Tables("PO_AMENDMENT").Rows.Count > 0 Then
                    For I = 0 To gdataset.Tables("PO_AMENDMENT").Rows.Count - 1
                        With AmendmentGrid
                            .Row = I + 1
                            .Col = 1
                            .Text = gdataset.Tables("PO_AMENDMENT").Rows(I).Item("poamendmentno")

                            .Col = 2
                            Dim a As DateTime
                            a = Trim(gdataset.Tables("PO_AMENDMENT").Rows(I).Item("poamendmentdate"))
                            .CellType = FPSpreadADO.CellTypeConstants.CellTypeDate
                            .SetText(.Col, .Row, a)
                            .Col = 3
                            .Text = gdataset.Tables("PO_AMENDMENT").Rows(0).Item("poamendmentdesc")
                        End With
                    Next
                End If


                '-------------------------FOLLOWUP RETRIEVE----------------------------
                strsql = "SELECT pofollowupno,pofollowupdate,pofollowupdesc FROM PO_FOLLOWUP WHERE PONO='" & Trim(txt_PONo.Text) & "' "
                Dim count2 As String

                gconnection.getDataSet(strsql, "PO_FOLLOWUP")
                If gdataset.Tables("PO_FOLLOWUP").Rows.Count > 0 Then
                    For I = 0 To gdataset.Tables("PO_FOLLOWUP").Rows.Count - 1
                        With FollowupGrid
                            .Row = I + 1
                            .Col = 1
                            .Text = gdataset.Tables("PO_FOLLOWUP").Rows(I).Item("pofollowupno")

                            .Col = 2
                            Dim a As DateTime
                            a = Trim(gdataset.Tables("PO_FOLLOWUP").Rows(I).Item("pofollowupdate"))
                            .CellType = FPSpreadADO.CellTypeConstants.CellTypeDate
                            .SetText(.Col, .Row, a)
                            .Col = 3
                            .Text = gdataset.Tables("PO_FOLLOWUP").Rows(0).Item("pofollowupdesc")
                        End With
                    Next
                End If
            Else
                Me.lbl_Freeze.Visible = False
                Me.lbl_Freeze.Text = "Record Freezed  On "
                Me.CmdAdd.Text = "Add [F7]"
                txt_PONo.ReadOnly = False
                Txt_QuotNo.Focus()
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Else
            Txt_QuotNo.Focus()
        End If
    End Sub

    Private Sub txt_PONo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PONo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_PONo.Text) = "" Then
                Call Cmd_PONoHelp_Click(Cmd_PONoHelp, e)
            Else
                Call txt_PONo_Validated(sender, e)
                Txt_QuotNo.Focus()
            End If
        End If
    End Sub
    Private Sub Txt_DeliveryTerms_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim j As Integer
        If Trim(Txt_DeliveryTerms.Text) <> "" Then
            sqlstring = "SELECT ISNULL(DELIVERYTERMCODE,0) AS DELIVERYTERMCODE,ISNULL(DELIVERYTERMDESC,'') AS DELIVERYTERMDESC FROM PO_DELIVERYTERMS where deliverytermcode = '" & Txt_DeliveryTerms.Text & "' "
            gconnection.getDataSet(sqlstring, "PO_DELIVERYTERMS")
            If gdataset.Tables("PO_DELIVERYTERMS").Rows.Count > 0 Then
                Txt_DeliveryTerms.Text = Trim(gdataset.Tables("PO_DELIVERYTERMS").Rows(0).Item("DELIVERYTERMCODE"))
                TXT_DELIVTERMS_DESC.Text = Trim(gdataset.Tables("PO_DELIVERYTERMS").Rows(0).Item("DELIVERYTERMDESC"))
                Me.Txt_AdvanceAmt.Focus()
            Else
                Me.Cmd_DeliveryTermHelp_Click_1(sender, e)
            End If
        Else
            Me.Txt_AdvanceAmt.Focus()
        End If
    End Sub

    Private Sub txt_PONo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_PONo.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call Cmd_PONoHelp_Click(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub Txt_QuotNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_QuotNo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.Txt_Vcode.Focus()
        End If
    End Sub
    Private Sub autogenerate_Inv()
        Try
            Dim sqlstring, financalyear As String
            Dim month As String
            Dim CATLEN As Integer

            month = UCase(Format(Now, "MMM"))
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 3, 2)

            sqlstring = "SELECT ISNULL(CATEGORY,'') AS CATEGORY FROM INVENTORYITEMMASTER WHERE ISNULL(CATEGORY,'')='" & Trim(cbo_warehouse.Text & "") & "' GROUP BY CATEGORY"
            gconnection.getDataSet(sqlstring, "CATEGORY")
            If gdataset.Tables("CATEGORY").Rows.Count > 0 Then
                CATEGORY = Mid(Trim(gdataset.Tables("CATEGORY").Rows(0).Item("CATEGORY") & ""), 1, 3)
                CATLEN = Len(Trim(CATEGORY))
            Else
                CATLEN = 3
                CATEGORY = month
            End If
            sqlstring = "SELECT MAX(Cast(SUBSTRING(PONO," & CATLEN & "+2,6) As Numeric)) FROM PO_HDR WHERE SUBSTRING(PONO,1," & CATLEN & ")='" & CATEGORY & "'  " 'AND ISNULL(GRNTYPE,'')='GRN'"
            '        sqlstring = "SELECT MAX(Cast(SUBSTRING(GRNNO,1,6) As Numeric)) FROM GRN_HEADER"
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_PONo.Text = CATEGORY & "/" & "000001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_PONo.Text = CATEGORY & "/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_PONo.Text = CATEGORY & "/000001/" & financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : autogenerate" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub autogenerate()
        Dim sqlstring, financalyear As String
        Try
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialyearEnd, 3, 4)
            sqlstring = " SELECT MAX(Cast(SUBSTRING(POno,5,6) As Numeric)) FROM PO_HDR "
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_PONo.Text = "PUR/000001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_PONo.Text = "PUR/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_PONo.Text = "PUR/000001/" & financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        Catch ex As Exception
            Exit Sub
        Finally
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End Try
    End Sub
    Private Sub autogenerate_sc()
        Dim sqlstring, financalyear As String
        Try
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialyearEnd, 3, 4)
            docno = doctype
            sqlstring = " SELECT MAX(Cast(SUBSTRING(POno,5,6) As Numeric)) FROM PO_HDR WHERE doctype='" & docno & "'"
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_PONo.Text = docno & "/000001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_PONo.Text = docno & "/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_PONo.Text = docno & "/000001/" & financalyear
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        Catch ex As Exception
            Exit Sub
        Finally
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End Try
    End Sub

    Private Sub Cmb_delivery_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_delivery.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Me.Txt_CreditDays.Focus()
        End If
    End Sub

    Private Sub Txt_Remarks_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Me.AmendmentGrid.Focus()
        End If
    End Sub

    Private Sub Txt_CreditDays_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Val(Txt_CreditDays.Text) > 365 Then
            MessageBox.Show("Days Should Not Exceed 365", "PurchaseOrder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Txt_CreditDays.Text = ""
            Me.Txt_CreditDays.Focus()
        Else
            Me.Txt_Encl.Focus()
        End If
    End Sub

    Private Sub FollowupGrid_KeyDownEvent(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles FollowupGrid.KeyDownEvent
        If e.keyCode = Keys.Tab Then
            Me.CmdAdd.Focus()
            Exit Sub
        End If
        With FollowupGrid
            If e.keyCode = Keys.Enter Then
                FollowupGrid.Row = FollowupGrid.ActiveRow
                If FollowupGrid.ActiveCol = 1 Then
                    FollowupGrid.Col = 1
                    If FollowupGrid.Text <> "" Then
                        FollowupGrid.SetActiveCell(2, .ActiveRow)
                    Else
                        FollowupGrid.SetActiveCell(1, .ActiveRow)
                    End If
                ElseIf FollowupGrid.ActiveCol = 2 Then
                    FollowupGrid.Col = 2
                    If FollowupGrid.Text <> "" Then
                        FollowupGrid.SetActiveCell(3, .ActiveRow)
                    Else
                        FollowupGrid.SetActiveCell(2, .ActiveRow)
                    End If
                ElseIf FollowupGrid.ActiveCol = 3 Then
                    FollowupGrid.Col = 3
                    If FollowupGrid.Text <> "" Then
                        FollowupGrid.SetActiveCell(1, .ActiveRow + 1)
                    Else
                        FollowupGrid.SetActiveCell(3, .ActiveRow)
                    End If
                End If
            ElseIf e.keyCode = Keys.F3 Then
                .DeleteRows(.ActiveRow, 1)
                .SetActiveCell(1, .ActiveRow)
            End If
        End With
    End Sub

    Private Sub Cmb_CSTForm_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Me.Txt_Encl.Focus()
        End If
    End Sub

    Private Sub Txt_Encl_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_Encl.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Me.Txt_Remarks.Focus()
        End If
    End Sub

    Private Sub Txt_Remarks_KeyDown1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Me.CmdAdd.Focus()
        End If
    End Sub

    Private Sub PurchaseOrder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Group_MC.Visible = True Then
            If e.KeyCode = Keys.F1 Then
                Ssgrid_subject.SetActiveCell(1, 1)
                Ssgrid_subject.Focus()
                Exit Sub
            End If
            If e.KeyCode = Keys.F2 Then
                Ssgrid_reference.SetActiveCell(1, 1)
                Ssgrid_reference.Focus()
                Exit Sub
            End If
            If e.KeyCode = Keys.F3 Then
                Ssgrid_body.SetActiveCell(1, 1)
                Ssgrid_body.Focus()
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F6 Then
            Call Me.CmdClear_Click(CmdClear, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F7 And CmdAdd.Enabled = True Then
            Call Me.CmdAdd_Click(CmdAdd, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F8 And CmdFreeze.Enabled = True Then
            Call CmdFreeze_Click(CmdFreeze, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F9 And CmdView.Enabled = True Then
            Call CmdView_Click(CmdView, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F10 And CmdPrint.Enabled = True Then
            Call CmdPrint_Click(CmdPrint, e)
            Exit Sub
        End If
        'If e.KeyCode = Keys.F11 Then
        '    Call cmd_dos_print_Click(cmd_dos_print, e)
        '    Exit Sub
        'End If
        If e.KeyCode = Keys.F2 Then
            Call Me.CmdClear_Click(CmdClear, e)
            Me.txt_PONo.Clear()
            Me.txt_PONo.Focus()
            Exit Sub
        End If
        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            If Grp_amend_Follow.Visible = True Then
                chk_amnd_foll.Checked = False
            Else
                Call CmdExit_Click(CmdExit, e)
                Exit Sub
            End If
            If e.KeyCode = Keys.ControlKey & Keys.E Or e.KeyCode = Keys.Escape Or Keys.F12 Then
                Me.Close()
            End If
        End If
    End Sub
    'gSQLString = "SELECT ISNULL(deliverytermcode,'') AS DELIVERYTERMCODE,ISNULL(deliverytermdesc,'') AS               DELIVERYTERMDESC FROM PO_deliveryterms"
    '    M_WhereCondition = " "
    'Dim vform As New List_Operation
    '    vform.Field = "DELIVERYTERMCODE,DELIVERYTERMDESC"
    '    vform.vFormatstring = "         DELIVERYTERM CODE              |                  DELIVERYTERM DESCRIPTION                   "
    '    vform.vCaption = "DELIVERY MASTER HELP"
    '    vform.KeyPos = 0
    '    vform.KeyPos1 = 1
    '    vform.ShowDialog(Me)
    '    If Trim(vform.keyfield & "") <> "" Then
    '        txtdeliverycode.Text = Trim(vform.keyfield & "")
    '        Call txt_deliverycode_Validated(txtdeliverycode, e)
    '    End If
    '    vform.Close()
    '    vform = Nothing
    '    Cmd_Freeze.Enabled = True
    Private Sub Cmd_PONoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_PONoHelp.Click
        gSQLString = "SELECT ISNULL(pono,'') AS PONO,ISNULL(podate,'')AS PODATE,ISNULL(podepartment,'') AS PODEPARTMENT FROM PO_HDR"
        M_WhereCondition = " "
        Dim vform As New ListOperattion1_N
        vform.Field = "PONO,PODATE,PODEPARTMENT"
        vform.vFormatstring = "         PONO    |        PODATE         |        PODEPARTMENT                   "
        vform.vCaption = "PURCHASE MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_PONo.Text = Trim(vform.keyfield & "")
            Call txt_PONo_Validated(txt_PONo.Text, e)
        End If
        vform.Close()
        vform = Nothing
        'txt_PONo.Focus()
        CmdFreeze.Enabled = True
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        'Dim laser As New Laser_print
        'laser.Show()
        gPrint = True
        'Call Viewoperation_SCnew()
        'Call Viewoperation()
        'Dim laser As New Laser_print
        'laser.Show()
        Try
            ' If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
            Dim rViewer As New Viewer
            Dim sqlstring, SSQL As String
            Dim r As New Rpt_POBill
            'sqlstring = "SELECT ISNULL(PONO,'') AS PONO, ISNULL(GRNDETAILS,'') AS GRNDETAILS,GRNDATE, ISNULL(SUPPLIERCODE,'') AS SUPPLIERCODE, ISNULL(SUPPLIERNAME,'') AS SUPPLIERNAME,"
            'sqlstring = sqlstring & " ISNULL(SUPPLIERINVNO,'') AS SUPPLIERINVNO,  ISNULL(EXCISEPASSNO,'') AS EXCISEPASSNO,ISNULL(GLACCOUNTCODE,'') AS GLACCOUNTCODE,ISNULL(GLACCOUNTNAME,'') AS GLACCOUNTNAME,"
            'sqlstring = sqlstring & " ISNULL(TOTALAMOUNT,0) AS TOTALAMOUNT,ISNULL(VATAMOUNT,0) AS VATAMOUNT,ISNULL(SURCHARGEAMT,0) AS SURCHARGEAMT,ISNULL(DISCOUNT,0) AS DISCOUNT,ISNULL(BILLAMOUNT,0) AS BILLAMOUNT,"
            'sqlstring = sqlstring & " ISNULL(ITEMCODE,'') AS ITEMCODE, ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM, ISNULL(QTY,0) AS QTY, ISNULL(RATE,0) AS RATE,ISNULL(REMARKS,'') AS REMARKS, "
            'sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT,isnull(discount,0) as ddiscount,isnull(taxper,0) as taxper,isnull(taxamount,0) as taxamount, isnull(OverallDiscount,0) OverallDiscount,ISNULL(UPDFOOTER,'') AS UPDFOOTER,ISNULL(UPDNAME,'') AS UPDNAME "
            sqlstring = " SELECT * FROM  VW_PO_POBILL "
            sqlstring = sqlstring & " WHERE PONO BETWEEN '" & Trim(txt_PONo.Text) & "' AND '" & Trim(txt_PONo.Text) & "'"
            sqlstring = sqlstring & " ORDER BY PONO,PODATE"

            gconnection.getDataSet(sqlstring, "VW_PO_POBILL")
            If gdataset.Tables("VW_PO_POBILL").Rows.Count > 0 Then
                rViewer.ssql = sqlstring
                rViewer.Report = r
                rViewer.TableName = "VW_PO_POBILL"
                Dim textobj1 As TextObject
                textobj1 = r.ReportDefinition.ReportObjects("Text13")
                textobj1.Text = MyCompanyName

                Dim textobj2 As TextObject
                textobj2 = r.ReportDefinition.ReportObjects("Text30")
                textobj2.Text = gUsername
                rViewer.Show()
            Else
                MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
            End If

            '''Else
            '''    gPrint = False
            '''    Call printoperation()
            '''End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : View Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Txt_AdvanceAmt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        getNumeric(e)
    End Sub
    Private Sub ssgrid_EnterRow(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_EnterRowEvent) Handles ssgrid.EnterRow
        With ssgrid
            .Col = 6
            .Row = .ActiveRow
            .Text = "0.00"
            .Col = 7
            .Text = "0.00"
            .Col = 8
            .Text = "0.00"

        End With
        'With ssgrid
        '    '    .Width = 920
        '    '    .Height = 485
        '    If .ActiveCol = 1 Then
        '        .Col = 1
        '        .Row = .ActiveRow
        '        .BackColor = Color.Gold
        '    End If
        'End With
    End Sub
    Private Sub ssgrid_LeaveRow(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveRowEvent) Handles ssgrid.LeaveRow
        Dim itemname, quantity, rate As String
        With ssgrid
            .GetText(4, .ActiveRow, quantity)
            .GetText(6, .ActiveRow, rate)
            If rate = "" Or rate = 0 Then
                .SetActiveCell(6, .ActiveRow)
            ElseIf quantity = "" Or quantity = 0 Then
                .SetActiveCell(4, .ActiveRow)
            End If
        End With
    End Sub
    Private Sub Cmb_despatch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_despatch.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Cmb_shipping.Visible = True Then
                Me.Cmb_shipping.Focus()
            Else
                Me.Txt_CreditDays.Focus()
            End If
        End If
    End Sub

    Private Sub Cmb_shipping_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_shipping.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmb_delivery.Focus()
        End If
    End Sub

    Private Sub Viewoperation()
        If Me.txt_PONo.Text = "" Then
            MsgBox("Please give PO no", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.ssgrid.DataRowCnt = 0 Then
            MsgBox("No details to view or print", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.Txt_Vcode.Text = "" Then
            MsgBox("Please give Vendor Code", MsgBoxStyle.Information)
            Exit Sub
        End If
        Randomize()
        Dim PAGENO, ROWCOUNT, I As Integer
        Dim SSQL, SSQL1 As String
        Dim SLCODE As String
        Dim VSQL As String

        Dim j, intPageLength As Int16
        Dim intDescriptionLength, intStartIndex, intDescLenIndex, intDescMaxLen As Int16
        Dim strSpaceBefore, strSpaceAfter As String
        strSpaceBefore = ""
        strSpaceAfter = ""
        intDescMaxLen = 66
        intPageLength = 80

        Dim SLNAME, ADDRESS1, ADDRESS2, ADDRESS3 As String
        vOutfile = Mid("CON" & (Rnd() * 800000), 1, 8)
        'vOutfile = Me.txt_PONo.Text & "-" & Mid("CON" & (Rnd() * 800000), 1, 8)
        VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        Filewrite = File.AppendText(VFilePath)
        printfile = VFilePath
        PAGENO = 1 : ROWCOUNT = 0
        Dim VREF As Boolean = False

        Dim STR, NARRATION As String

        Dim rate, vat, ltotal, gtotal, temp As Double
        Dim lqty, gqty As Double

        SSQL = "Select P.PONO,P.PODATE,P.POVENDORCODE,P.PODEPARTMENT,P.POAPPROVEDBY,P.POAPPROVEDDATE,P.POSTATUS,P.POVALUE,P.POADVANCE,P.POTOTALVAT,P.POTOTALTAX,P.POTOTALDISCOUNT,P.POADVANCE,P.POBALANCE,P.POTERMS,P.PODELIVERYTERMS,P.PODESPATCH,P.POSHIPPING,P.PODELIVERY,P.POCREDITDAYS,P.POENCL,P.POREMARKS,P.POCLOSURE,P.POFREIGHT,P.POCSTFORM, P.FREEZE"
        SSQL = SSQL & " from PO_HDR P "
        SSQL = SSQL & " where isnull(FREEZE,'')<>'Y'   AND P.PONO = '" & Trim(txt_PONo.Text) & "' "
        vconn.getDataSet(SSQL, "PO_HDR")

        Dim vcaption1 As String
        vcaption1 = ""

        If gdataset.Tables("PO_HDR").Rows.Count > 0 Then
            I = 0
            'PRINTING HEADER
            If Me.Chk_MC_Form.Checked = False Then
                Call subPrintVoucherHeader("PURCHASE ORDER VOUCHER", 80)
                ROWCOUNT = 7
            End If
            With gdataset.Tables("PO_HDR").Rows(I)
                If VREF = False Then

                    STR = "SELECT ISNULL(VENDORCODE,0) AS VENDORCODE, ISNULL(VENDORNAME,'') AS VENDORNAME, ADDRESS, CITY, STATE  FROM PO_VIEW_VENDORMASTER WHERE VENDORCODE = '" & Trim(Txt_Vcode.Text) & "' "
                    vconn.getDataSet(STR, "ACCOUNTSSUBLEDGERMASTER")

                    STR = "select ACCODE, ACDESC from accountsglaccountmaster WHERE ACCODE = '" & Txt_GLAcIn.Text & "'"
                    vconn.getDataSet(STR, "GLACIN")
                    Dim GLACIN, GLACCODE As String

                    If gdataset.Tables("GLACIN").Rows.Count > 0 Then
                        GLACIN = gdataset.Tables("GLACIN").Rows(0).Item("ACDESC")
                        GLACCODE = gdataset.Tables("GLACIN").Rows(0).Item("ACCODE")
                    End If
                    Filewrite.Write(Chr(27) & "E")
                    SSQL = Chr(27) & Chr(45) & Chr(49) & "P.O. NO. : " & Trim(txt_PONo.Text) & Chr(27) & Chr(45) & Chr(48)
                    SSQL = SSQL & Space(22)
                    SSQL = SSQL & "         DATE : " & Mid(Trim(Cbo_PODate.Text), 1, 20) & Space(20 - Len(Mid(Trim(Cbo_PODate.Text), 1, 20)))
                    Filewrite.WriteLine(SSQL)
                    Filewrite.Write(Chr(27) & "F")
                    Filewrite.WriteLine()
                    ROWCOUNT = ROWCOUNT + 2

                    If Chk_MC_Form.Checked = False Then
                        If gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).IsNull("VENDORNAME") = False Then
                            SSQL = Chr(27) & "E"
                            SSQL = SSQL & Mid(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"), 1, 6) & " : " & Space(6 - Len(Mid(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"), 1, 6))) & Space(2)
                            SSQL = SSQL & (gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORNAME"))
                            SSQL = SSQL & Space(15) & "Inventory: " & GLACIN
                            SSQL = SSQL & Chr(27) & "F"
                        Else
                            SSQL = Space(48)
                            SSQL = SSQL & "DATE        : " & Mid(Trim(Format(DateValue(Cbo_PODate.Text), "dd/MM/yyyy")), 1, 20) & Space(20 - Len(Mid(Trim(Cbo_PODate.Text), 1, 20)))
                        End If
                        Filewrite.WriteLine(SSQL)
                        Filewrite.WriteLine(Space(44) & "GL AC : " & GLACCODE & Chr(27) & "F")
                        ROWCOUNT = ROWCOUNT + 2
                    Else
                        SSQL = Chr(27) & "E"
                        Filewrite.WriteLine("To")
                        SSQL = SSQL & Mid(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"), 1, 6) & " : " & Space(6 - Len(Mid(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"), 1, 6))) & Space(2)
                        SSQL = SSQL & (gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORNAME"))
                        SSQL = SSQL & Space(15) & "Inventory: " & GLACIN
                        SSQL = SSQL & Chr(27) & "F"

                        Filewrite.Write(Chr(27) & "E")
                        Filewrite.WriteLine(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("ADDRESS"))
                        Filewrite.WriteLine(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("CITY"))
                        Filewrite.WriteLine(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("STATE"))
                        Filewrite.Write(Chr(27) & "F")

                        Filewrite.WriteLine(SSQL)
                        Filewrite.WriteLine()
                        ROWCOUNT = ROWCOUNT + 6
                    End If

                    If Me.Chk_MC_Form.Checked = True Then
                        Filewrite.WriteLine(Space(30) & "KIND ATTN: ")
                        Filewrite.WriteLine("Dear Sirs,")
                        Filewrite.WriteLine()
                        ROWCOUNT = ROWCOUNT + 3

                        Dim bill As DataTable
                        Dim Loopindex As Integer
                        sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(txt_PONo.Text) & "' and DOCTYPE='SUBJECT' order by slno"
                        bill = gconnection.GetValues(sqlstring)
                        If bill.Rows.Count > 0 Then
                            Filewrite.Write("SUB:   ")
                            Loopindex = 0
                            For I = 0 To bill.Rows.Count - 1
                                Loopindex = Loopindex + 1
                                Filewrite.WriteLine(bill.Rows(I).Item("MESSAGE"))
                                ROWCOUNT = ROWCOUNT + 1
                            Next
                            Filewrite.WriteLine()
                            ROWCOUNT = ROWCOUNT + 1
                        End If
                        bill.Clear()
                        sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(txt_PONo.Text) & "' and DOCTYPE='REFERENCE' order by slno"
                        bill = gconnection.GetValues(sqlstring)
                        If bill.Rows.Count > 0 Then
                            Filewrite.Write("REF:   ")
                            Loopindex = 0
                            For I = 0 To bill.Rows.Count - 1
                                Loopindex = Loopindex + 1
                                Filewrite.WriteLine(bill.Rows(I).Item("MESSAGE"))
                                ROWCOUNT = ROWCOUNT + 1
                            Next
                            Filewrite.WriteLine()
                            ROWCOUNT = ROWCOUNT + 1
                        End If
                        bill.Clear()
                        sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(txt_PONo.Text) & "' and DOCTYPE='BODY' order by slno"
                        bill = gconnection.GetValues(sqlstring)
                        If bill.Rows.Count > 0 Then
                            Loopindex = 0
                            For I = 0 To bill.Rows.Count - 1
                                Loopindex = Loopindex + 1
                                Filewrite.WriteLine(Space(7) & bill.Rows(I).Item("MESSAGE"))
                                ROWCOUNT = ROWCOUNT + 1
                            Next
                            Filewrite.WriteLine()
                            ROWCOUNT = ROWCOUNT + 1
                        End If
                        bill.Clear()
                    End If

                    If Chk_MC_Form.Checked = False Then
                        Filewrite.WriteLine("              " & Chr(27) & "E" & "SUB : " & Chr(27) & "F" & "PURCHASE ORDER FOR FOLLOWING MATERIAL - REG. - ")
                        Filewrite.WriteLine("               FOR THE DEPARTMENT OF '" & cbo_dept.Text & "' ")
                        Filewrite.WriteLine()
                        ROWCOUNT = ROWCOUNT + 2
                        Filewrite.WriteLine("PLEASE SUPPLY THE FOLLOWING MATERIAL AT THE EARLIEST: ")
                        Filewrite.WriteLine()
                        ROWCOUNT = ROWCOUNT + 3
                    End If
                    Filewrite.WriteLine(StrDup(80, "-"))
                    Filewrite.WriteLine("NO.     ITEM DESCRIPTION " & Space(19) & "  RATE  " & Space(2) & " QTY    VAT   QTY*RATE+VAT- ")
                    Filewrite.WriteLine("                         " & Space(19) & "        " & Space(2) & "              DISCOUNT(Rs.) ")
                    Filewrite.WriteLine(StrDup(80, "-"))
                    ROWCOUNT = ROWCOUNT + 3
                    VREF = True
                End If

                'SSQL = "SELECT isnull(discount,0) as discount,* FROM PO_ITEMDETAILS WHERE PONO = '" & txt_PONo.Text & "' "
                SSQL = "SELECT AUTOID,SUM(discount) as discount,ISNULL(PONO,'') AS PONO,ISNULL(ITEMCODE,'') AS ITEMCODE, ISNULL(QUANTITY,0) AS QUANTITY,ISNULL(REQUIREDDATE,'') AS REQUIREDDATE,ISNULL(RATE,0) AS RATE,ISNULL(VAT,0) AS VAT, ISNULL(TOTAL,0) AS TOTAL FROM PO_ITEMDETAILS WHERE PONO = '" & txt_PONo.Text & "' GROUP BY AUTOID,PONO,ITEMCODE,QUANTITY,REQUIREDDATE,RATE,VAT,TOTAL ORDER BY AUTOID "
                vconn.getDataSet(SSQL, "PO_ITEMDETAILS")

                If gdataset.Tables("PO_ITEMDETAILS").Rows.Count > 0 Then
                    For j = 0 To gdataset.Tables("PO_ITEMDETAILS").Rows.Count - 1
                        ltotal = lqty = 0
                        ROWCOUNT = ROWCOUNT + 1
                        If ROWCOUNT > 58 Then
                            Filewrite.WriteLine(StrDup(80, "-"))
                            Filewrite.WriteLine(Chr(12))
                            PAGENO = PAGENO + 1
                            Call subPrintVoucherHeader("PURCHASE ORDER", 80)
                            Filewrite.WriteLine(StrDup(80, "-"))
                            ROWCOUNT = 6
                        End If
                        'adding rate + tax
                        rate = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE")
                        vat = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("VAT")
                        temp = rate * vat / 100
                        'ltotal = rate + temp
                        ltotal = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("TOTAL")
                        lqty = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("QUANTITY")
                        'Dim vattotal As Double
                        'vattotal = rate * lqty
                        'vattotal = (vattotal * vat) / 100
                        rate = 0 : vat = 0 : temp = 0
                        If gdataset.Tables("PO_ITEMDETAILS").Rows(j).IsNull("ITEMCODE") = False Then
                            'ITEMCODE
                            SSQL = Space(2 - Len(Mid(Format(j + 1, ""), 1, 2))) & Mid(Format(j + 1, ""), 1, 2) & " "
                            'ITEM NAME RETRIEVAL
                            SSQL1 = "SELECT * FROM PO_VIEW_ITEMMASTER WHERE ITEMCODE = '" & gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("ITEMCODE") & "' "
                            vconn.getDataSet(SSQL1, "INVENTORYITEMMASTER")
                            'ITEM NAME
                            SSQL = SSQL & Space(6)
                            SSQL = SSQL & Mid(gdataset.Tables("INVENTORYITEMMASTER").Rows(0).Item("ITEMNAME"), 1, 35) & Space(35 - Len(Mid(gdataset.Tables("INVENTORYITEMMASTER").Rows(0).Item("ITEMNAME"), 1, 35)))
                            'RATE
                            SSQL = SSQL & Space(1)
                            SSQL = SSQL & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE"), 1, 8) & Space(8 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE"), 1, 8)))
                            'QUANTITY
                            'SSQL = SSQL & Space(2)
                            SSQL = SSQL & Space(6 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("QUANTITY"), 1, 6))) & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("QUANTITY"), 1, 6)
                            'VAT
                            SSQL = SSQL & Space(2)
                            SSQL = SSQL & Space(6 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("VAT"), 1, 6))) & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("VAT"), 1, 6)
                            'RATE
                            SSQL = SSQL & Space(2)
                            SSQL = SSQL & Space(10 - Len(Mid(Format(ltotal, "0.00"), 1, 10))) & Mid(Format(ltotal, "0.00"), 1, 10) & " "
                            gtotal = gtotal + ltotal
                            'vattotal = Nothing
                            gqty = gqty + lqty
                            Filewrite.WriteLine(SSQL)
                        Else
                            SSQL = Space(53)
                        End If
                    Next j
                End If
                'FOR MINIMUM 10 BLANK LINES IN THE ITEM DETAILS SECTION    
                If gdataset.Tables("PO_ITEMDETAILS").Rows.Count < 10 Then
                    j = 0
                    j = gdataset.Tables("PO_ITEMDETAILS").Rows.Count
                    j = 10 - j
                    Dim K
                    For K = 0 To j
                        Filewrite.WriteLine()
                    Next
                End If

                Dim povalue As Double
                Dim ADVamt As Double


                povalue = Val(gdataset.Tables("PO_HDR").Rows(0).Item("POVALUE")) '- Val(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"))
                Filewrite.WriteLine("TOTAL VALUE    : " & Space(10 - Len(Mid(Format(povalue, "0.00"), 1, 10))) & Mid(Format(povalue, "0.00"), 1, 10) & " ")
                Filewrite.WriteLine("TOTAL VAT      : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"), "0.00"), 1, 10) & " ")
                Filewrite.WriteLine("TOTAL DISCOUNT : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALDISCOUNT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALDISCOUNT"), "0.00"), 1, 10) & " ")
                Filewrite.WriteLine("TOTAL ADVANCE  : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00"), 1, 10) & " ")
                ADVamt = Format(povalue, "0.00") - Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00")
                Filewrite.WriteLine("BALANCE AMOUNT : " & Space(10 - Len(Mid(Format(ADVamt, "0.00"), 1, 10))) & Mid(Format(ADVamt, "0.00"), 1, 10))
                'Filewrite.WriteLine("TOTAL DISCOUNT : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_ITEMDETAILS").Rows(0).Item("DISCOUNT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_ITEMDETAILS").Rows(0).Item("DISCOUNT"), "0.00"), 1, 10) & " ")
                'Filewrite.WriteLine("TOTAL DISCOUNT : " & Space(10 - Len(Mid(Format(discounttotal, "0.00"), 1, 10))) & Mid(Format(discounttotal, "0.00"), 1, 10) & " ")

                ROWCOUNT = ROWCOUNT + 4

                If gdataset.Tables("PO_HDR").Rows(0).IsNull("poremarks") = False Then
                    NARRATION = gdataset.Tables("PO_HDR").Rows(0).Item("poremarks")
                Else
                    NARRATION = ""
                End If
            End With

            Filewrite.WriteLine()
            If Len(NARRATION) > 0 Then
                intDescriptionLength = Split(Len(NARRATION) / intDescMaxLen, ".")(0)
                intDescriptionLength = intDescriptionLength + 1
                intStartIndex = 1
                intDescLenIndex = intDescMaxLen
                For j = 1 To intDescriptionLength
                    If j = 1 Then
                        Filewrite.Write("Narration : ")
                        strSpaceBefore = ""
                    Else
                        strSpaceBefore = Space(12)
                    End If
                    If j = intDescriptionLength Then
                        Filewrite.WriteLine(strSpaceBefore & Trim(Mid(Trim(NARRATION), intStartIndex, intDescMaxLen)) & Space((intDescMaxLen + 1) - Len(Trim(Mid(Trim(NARRATION), intStartIndex, intDescMaxLen)))) & strSpaceAfter)
                    Else
                        If Mid(NARRATION, intDescLenIndex, 1) = " " Then
                            Filewrite.WriteLine(strSpaceBefore & Trim(Mid(NARRATION, intStartIndex, intDescMaxLen)) & "- " & strSpaceAfter)
                        Else
                            Filewrite.WriteLine(strSpaceBefore & Trim(Mid(Trim(NARRATION), intStartIndex, intDescMaxLen)) & "-" & strSpaceAfter)
                        End If
                    End If
                    ROWCOUNT = ROWCOUNT + 1
                    intStartIndex = intStartIndex + intDescMaxLen
                    intDescLenIndex = intDescLenIndex + intDescMaxLen
                Next
            End If
        Else
            MsgBox("NO RECORD TO VIEW ", MsgBoxStyle.Information)
            Exit Sub
        End If

        Filewrite.WriteLine(StrDup(80, "-"))
        Filewrite.Write(Space(9) & Chr(27) & "E" & "TOTAL : " & Chr(27) & "F")
        Filewrite.Write(Space(32) & Space(10 - Len(Mid(Format(gqty, "0.00"), 1, 10))) & Mid(Format(gqty, "0.00"), 1, 10))
        Filewrite.Write(Space(8))
        Filewrite.WriteLine(Space(2) & Space(10 - Len(Mid(Format(gtotal, "0.00"), 1, 10))) & Mid(Format(gtotal, "0.00"), 1, 10))
        Filewrite.WriteLine(StrDup(80, "-"))

        SSQL = " SELECT * FROM PO_PAYMENTTERMS WHERE PAYMENTTERMCODE = '" & Txt_POTerms.Text & "' "
        vconn.getDataSet(SSQL, "PO_PAYMENTTERMS")
        SSQL = " SELECT * FROM PO_DELIVERYTERMS WHERE DELIVERYTERMCODE = '" & Txt_DeliveryTerms.Text & "' "
        vconn.getDataSet(SSQL, "PO_DELIVERYTERMS")
        SSQL = " SELECT * FROM PO_WARRANTYTERMS WHERE WARRANTYTERMCODE = '" & Txt_WarrantyCode.Text & "' "
        vconn.getDataSet(SSQL, "PO_WARRANTYTERMS")
        If Chk_MC_Form.Checked = True Then
            Filewrite.WriteLine("TERMS & CONDITIONS: ")
            Filewrite.WriteLine()
            Filewrite.WriteLine("#. TERMS OF PAYMENT  : " & gdataset.Tables("PO_PAYMENTTERMS").Rows(0).Item("PAYMENTTERMDESC"))
            Filewrite.WriteLine("#. TERMS OF DELIVERY : " & gdataset.Tables("PO_DELIVERYTERMS").Rows(0).Item("DELIVERYTERMDESC"))
            If gdataset.Tables("PO_WARRANTYTERMS").Rows.Count > 0 Then
                Filewrite.WriteLine("#. TERMS OF WARRANTY : " & gdataset.Tables("PO_WARRANTYTERMS").Rows(0).Item("WARRANTYTERMDESC"))
            End If
            ROWCOUNT = ROWCOUNT + 5
            If Trim(Txt_OtherTermCode.Text) <> "" Then
                Dim bill As DataTable
                Dim loop1, temp1 As Integer
                Dim Othertermcode(10), TextValue As String
                loop1 = 0
                TextValue = Trim(Me.Txt_OtherTermCode.Text)
                For I = 0 To Me.Txt_OtherTermCode.Text.Length - 1
                    If Me.Txt_OtherTermCode.Text.Chars(I) = "," Then
                        If loop1 = 0 Then
                            Othertermcode(loop1) = TextValue.Substring(0, I)
                            loop1 = loop1 + 1
                            temp1 = I
                        Else
                            Othertermcode(loop1) = TextValue.Substring(temp1 + 2, I)
                            loop1 = loop1 + 1
                            temp1 = I
                        End If
                    End If
                Next
                Filewrite.Write("#. OTHER TERMS       : ")
                For I = 0 To loop1
                    sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(Othertermcode(I)) & "' and DOCTYPE='OTHERTERMS' order by slno"
                    bill = gconnection.GetValues(sqlstring)
                    If bill.Rows.Count > 0 Then
                        For j = 0 To bill.Rows.Count - 1
                            Filewrite.WriteLine(Space(3) & bill.Rows(j).Item("MESSAGE"))
                            ROWCOUNT = ROWCOUNT + 1
                        Next j
                    End If
                    bill.Clear()
                Next I
                Filewrite.WriteLine()
                ROWCOUNT = ROWCOUNT + 1
            End If
        Else
            If IsDBNull(gdataset.Tables("PO_PAYMENTTERMS").Rows(0).IsNull("PAYMENTTERMCODE")) = False Then
                Filewrite.WriteLine(" PAYMENT TERMS  : " & gdataset.Tables("PO_PAYMENTTERMS").Rows(0).Item("PAYMENTTERMDESC"))
            Else
                Filewrite.WriteLine()
            End If
            If IsDBNull(gdataset.Tables("PO_DELIVERYTERMS").Rows(0).IsNull("DELIVERYTERMCODE")) = False Then
                Filewrite.WriteLine(" DELIVERY TERMS : " & gdataset.Tables("PO_DELIVERYTERMS").Rows(0).Item("DELIVERYTERMDESC"))
            Else
                Filewrite.WriteLine()
            End If
        End If

        Filewrite.WriteLine()
        Filewrite.WriteLine()
        Filewrite.WriteLine()
        Filewrite.WriteLine()
        If Chk_MC_Form.Checked = False Then
            vconn.subPrintVoucherFooter(80, PAGENO)
        Else
            Filewrite.WriteLine("Thanking you,")
            Filewrite.WriteLine()
            Filewrite.WriteLine("Yours sincerly,")
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            'Filewrite.WriteLine("E.RAJENDER KUMAR")
            'Filewrite.WriteLine(" Hon. Secretary")
        End If

        Filewrite.WriteLine(Chr(12))
        Filewrite.Close()
        If gPrint = False Then
            OpenTextFile(vOutfile)
        Else
            PrintTextFile1(VFilePath)
        End If
    End Sub

    Public Sub subPrintVoucherHeader(ByVal strCaption As String, ByVal intLength As Int16)
        Dim SSQL1 As String
        Filewrite.WriteLine()
        'Filewrite.Write(Space(30))
        Filewrite.WriteLine(Chr(27) & "E" & Trim(Mid(gCompanyname, 1, 80)) & Chr(27) & "F")
        SSQL1 = ""
        SSQL1 = "SELECT ISNULL(ADD1,'') AS ADD1, ISNULL(ADD2,'') AS ADD2, ISNULL(PINCODE,'') AS PINCODE FROM MASTER..CLUBMASTER WHERE DATAFILE = '" & gDatabase & "' "
        vconn.getDataSet(SSQL1, "CLUBMASTER")
        SSQL1 = ""
        'Filewrite.Write(Space(30))
        Filewrite.WriteLine(Chr(27) & "E" & Trim(Mid(gdataset.Tables("CLUBMASTER").Rows(0).Item("ADD1"), 1, 80)) & Chr(27) & "F")
        'Filewrite.Write(Space(30))
        Filewrite.Write(Chr(27) & "E" & Trim(Mid(gdataset.Tables("CLUBMASTER").Rows(0).Item("ADD2"), 1, 80)))
        Filewrite.Write("   ")
        Filewrite.WriteLine(Trim(Mid(gdataset.Tables("CLUBMASTER").Rows(0).Item("PINCODE"), 1, 80)) & Chr(27) & "F")
        Filewrite.WriteLine()
        Filewrite.Write(Space(30))
        Filewrite.WriteLine(Chr(27) & "E" & Trim(Mid("PURCHASE ORDER", 1, 80)) & Chr(27) & "F")
        Filewrite.Write(Space(28))
        Filewrite.WriteLine(StrDup(18, "-"))
    End Sub

    Private Sub Txt_AdvanceAmt_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_AdvanceAmt.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            If Val(Me.Txt_AdvanceAmt.Text) > Val(Me.Txt_POValue.Text) Then
                MessageBox.Show("Advance Amount Can't be Greater than P.O. Value", "Advance Validation", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.TXT_TRANSPORT.Focus()
            End If
            Call ssgrid_Leave(sender, e)
            'Me.Txt_POTerms.Focus()
            Me.TXT_TRANSPORT.Focus()
        End If
    End Sub

    Private Sub Txt_POTerms_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_POTerms.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cmd_POTermsHelp_Click_1(sender, e)
        End If
        If e.KeyCode = Keys.Enter Then
            If Txt_POTerms.Text = "" Then
                Call Cmd_POTermsHelp_Click_1(sender, e)
            Else
                Call Txt_POTerms_Validated1(Txt_POTerms, e)
            End If
        End If
    End Sub
    Private Sub Txt_DeliveryTerms_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_DeliveryTerms.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call Cmd_DeliveryTermHelp_Click_1(sender, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            If Txt_DeliveryTerms.Text = "" Then
                Call Cmd_DeliveryTermHelp_Click_1(sender, e)
            Else
                Call Txt_DeliveryTerms_Validated(sender, e)
            End If
        End If
        If e.KeyCode = Keys.Tab Then
            Me.Cmb_Freight.Focus()
        End If
    End Sub
    Private Sub Txt_POTerms_Validated1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_POTerms.Validated
        Dim j As Integer
        If Trim(Txt_POTerms.Text) <> "" Then
            sqlstring = "SELECT ISNULL(PAYMENTTERMCODE,0) AS PAYMENTTERMCODE,ISNULL(PAYMENTTERMDESC,'') AS PAYMENTTERMDESC FROM PO_PAYMENTTERMS WHERE PAYMENTTERMCODE = '" & Txt_POTerms.Text & "' "
            gconnection.getDataSet(sqlstring, "PO_PAYMENTTERMS")
            If gdataset.Tables("PO_PAYMENTTERMS").Rows.Count > 0 Then
                Txt_POTerms.Text = Trim(gdataset.Tables("PO_PAYMENTTERMS").Rows(0).Item("PAYMENTTERMCODE"))
                TXT_PAYMTTERMS_DESC.Text = Trim(gdataset.Tables("PO_PAYMENTTERMS").Rows(0).Item("PAYMENTTERMDESC"))
                'Me.Txt_POTerms.ReadOnly = True
                Me.Txt_DeliveryTerms.Focus()
            Else
                Me.Cmd_OtherTermCodeHelp_Click(sender, e)
            End If
        Else
            Me.Txt_POTerms.Focus()
        End If
    End Sub
    Private Sub Cmb_Freight_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_Freight.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Me.Cmb_despatch.Focus()
        End If
    End Sub
    Private Sub Txt_CreditDays_KeyDown1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Me.Cmb_CSTForm.Focus()
        End If
    End Sub

    Private Sub Cmb_despatch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_despatch.SelectedIndexChanged
        If Cmb_despatch.SelectedIndex > 0 Then
            Label24.Visible = True
            Label26.Visible = True
            Cmb_shipping.Visible = True
            Cmb_delivery.Visible = True
        Else
            Label24.Visible = False
            Label26.Visible = False
            Cmb_shipping.Visible = False
            Cmb_delivery.Visible = False
        End If
    End Sub

    Private Sub Cbo_Dept_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_Dept1.GotFocus
        Me.cbo_dept.Width = 272
    End Sub

    Private Sub Cbo_Dept_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_Dept1.LostFocus
        Me.cbo_dept.Width = 152
    End Sub

    Private Sub Cbo_Dept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_Dept1.SelectedIndexChanged
        Me.cbo_dept.ForeColor = ForeColor.OliveDrab
    End Sub

    Private Sub Cbo_Approvedby_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_Approvedby.SelectedIndexChanged
        Me.Cbo_Approvedby.ForeColor = ForeColor.OliveDrab
    End Sub

    Private Sub Cbo_POStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_POStatus.SelectedIndexChanged
        Me.Cbo_POStatus.ForeColor = ForeColor.OliveDrab
    End Sub

    Private Sub ssgrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid.LeaveCell
        Dim itemname, quantity, rate As String
        With ssgrid
            .Col = .ActiveCol
            If .Col = 4 Then
                .Col = 2
                .Row = .ActiveRow
                If .Text <> "" Then
                    .GetText(4, .ActiveRow, quantity)
                    If quantity = "" Or quantity = 0 Then
                        '  .SetActiveCell(4, .ActiveRow)
                    Else
                        Call GRIDCALCULATION()
                    End If
                End If
            End If
            If .Col = 6 Then
                .Col = 2
                .Row = .ActiveRow
                If .Text <> "" Then
                    .GetText(6, .ActiveRow, rate)
                    If rate = "" Or rate = 0 Then
                        .SetActiveCell(6, .ActiveRow)
                    Else
                        Call GRIDCALCULATION()
                    End If
                End If
            End If
            'If .ActiveCol = 1 Then
            '    .Col = 1
            '    .Row = .ActiveRow
            '    .BackColor = Color.White
            'End If
        End With
    End Sub

    Private Sub Chk_Amendment_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Amendment.CheckedChanged
        If Chk_Amendment.Checked = True Then
            Me.AmendmentGrid.Visible = True
        Else
            Me.AmendmentGrid.Visible = False
        End If
    End Sub

    Private Sub Chk_Followup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Followup.CheckedChanged
        If Chk_Followup.Checked = True Then
            Me.FollowupGrid.Visible = True
        Else
            Me.FollowupGrid.Visible = False
        End If
    End Sub

    Private Function Marquee(ByVal MyText As String, ByVal Num As Integer) As String
        Dim Tx As String
        Static n As Integer
        Static n2 As Integer
        Tx = Space(Num)
        n = n + n2
        If n > Num - Len(MyText) Then n2 = -1
        If n < 1 Then n = 2 : n2 = 1
        Mid$(Tx, n, Len(MyText)) = MyText
        Marquee = Tx
    End Function

    'Private Sub Timer1_Tick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    'Lbl_Marquee.Text = Marquee("NIZAM CLUB PURCHASE ORDER!", 48) 
    'End Sub

    Private Sub Cmd_POTermsHelp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_POTermsHelp.Click
        Dim sqlstring As String
        Dim vform As New ListOperattion1_N
        gSQLString = "SELECT ISNULL(PAYMENTTERMCODE,0) AS PAYMENTTERMCODE,ISNULL(PAYMENTTERMDESC,'') AS PAYMENTTERMDESC FROM PO_PAYMENTTERMS "
        M_WhereCondition = ""
        vform.Field = " PAYMENTTERMCODE, PAYMENTTERMDESC "
        vform.vFormatstring = "     PAYMENTTERM CODE     |                   PAYMENTTERMDESC               "
        vform.vCaption = "PAYMENTTERM MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_POTerms.Text = Trim(vform.keyfield & "")
            TXT_PAYMTTERMS_DESC.Text = Trim(vform.keyfield1 & "")
            Call Txt_POTerms_Validated1(Txt_POTerms, e)
        End If
        vform.Close()
        vform = Nothing
        Me.Txt_DeliveryTerms.Focus()
    End Sub

    Private Sub Cmd_DeliveryTermHelp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_DeliveryTermHelp.Click
        Dim sqlstring As String
        Dim vform As New ListOperattion1_N
        gSQLString = "SELECT ISNULL(DELIVERYTERMCODE,0) AS DELIVERYTERMCODE,ISNULL(DELIVERYTERMDESC,'') AS DELIVERYTERMDESC FROM PO_DELIVERYTERMS "
        M_WhereCondition = ""
        vform.Field = " DELIVERYTERMCODE, DELIVERYTERMDESC "
        vform.vFormatstring = "     DELIVERYTERM CODE     |                   DELIVERYTERMDESC        "
        vform.vCaption = "DELIVERYTERM MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_DeliveryTerms.Text = Trim(vform.keyfield & "")
            TXT_DELIVTERMS_DESC.Text = Trim(vform.keyfield1 & "")
            Call Txt_DeliveryTerms_Validated(Txt_DeliveryTerms, e)
        End If
        vform.Close()
        vform = Nothing
        Me.txt_SalesTax.Focus()
        'Me.Txt_AdvanceAmt.Focus()
    End Sub

    Private Sub Txt_POTerms_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_POTerms.Leave
        Call Txt_POTerms_Validated1(Txt_POTerms, e)
    End Sub

    Private Sub Txt_DeliveryTerms_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_DeliveryTerms.Leave
        Call Txt_DeliveryTerms_Validated(Txt_DeliveryTerms, e)
    End Sub

    Private Sub Chk_MC_Form_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_MC_Form.CheckedChanged
        If Chk_MC_Form.Checked = True Then
            Group_MC.Visible = True
            Show()
            Ssgrid_subject.SetActiveCell(1, 1)
            Ssgrid_subject.Focus()
        Else
            Group_MC.Visible = False
        End If
    End Sub

    Private Sub Cmd_Ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Ok.Click
        Me.Group_MC.Visible = False
    End Sub

    Private Sub Cmd_WarrantyCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_WarrantyCodeHelp.Click
        Dim sqlstring As String
        Dim vform As New List_Operation
        gSQLString = "SELECT ISNULL(WARRANTYTERMCODE,0) AS WARRANTYTERMCODE,ISNULL(WARRANTYTERMDESC,'') AS WARRANTYTERMDESC FROM PO_WARRANTYTERMS "
        M_WhereCondition = ""
        vform.Field = " WARRANTYTERMCODE, WARRANTYTERMDESC "
        vform.vFormatstring = "     WARRANTYTERM CODE     |                   WARRANTYTERM DESC               "
        vform.vCaption = "WARRANTYTERM MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_WarrantyCode.Text = Trim(vform.keyfield & "")
        End If
        vform.Close()
        vform = Nothing
        Me.Txt_OtherTermCode.Focus()
    End Sub

    Private Sub Txt_WarrantyCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_WarrantyCode.Validated
        Dim j As Integer
        If Trim(Txt_WarrantyCode.Text) <> "" Then
            sqlstring = ""
            sqlstring = "SELECT ISNULL(WARRANTYTERMCODE,0) AS WARRANTYTERMCODE,ISNULL(WARRANTYTERMDESC,'') AS WARRANTYTERMDESC FROM PO_WARRANTYTERMS WHERE WARRANTYTERMCODE = '" & Txt_WarrantyCode.Text & "' "
            gconnection.getDataSet(sqlstring, "PO_WARRANTYTERMS")
            If gdataset.Tables("PO_WARRANTYTERMS").Rows.Count > 0 Then
                Me.Txt_WarrantyCode.Text = Trim(gdataset.Tables("PO_WARRANTYTERMS").Rows(0).Item("WARRANTYTERMCODE"))
                Me.Txt_OtherTermCode.Focus()
            End If
        Else
            Me.Txt_WarrantyCode.Focus()
        End If
    End Sub

    Private Sub Txt_WarrantyCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_WarrantyCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cmd_WarrantyCodeHelp_Click(sender, e)
        End If
        If e.KeyCode = Keys.Enter Then
            If Txt_WarrantyCode.Text = "" Then
                Cmd_WarrantyCodeHelp_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub Cmd_OtherTermCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_OtherTermCodeHelp.Click
        Dim sqlstring As String
        Dim vform As New List_Operation
        gSQLString = "SELECT ISNULL(TRANTYPE,0) AS TRANTYPE,ISNULL(MESSAGE,'') AS MESSAGE FROM PO_OTHERTERMS "
        M_WhereCondition = " WHERE DOCTYPE = 'OTHERTERMS' "
        vform.Field = " TRANTYPE, MESSAGE "
        vform.vFormatstring = "     OTHER TERM CODE |                     MESSAGE                      "
        vform.vCaption = "OTHERTERM MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            If Txt_OtherTermCode.Text <> "" Then
                Txt_OtherTermCode.Text = Txt_OtherTermCode.Text + "," + Trim(vform.keyfield & "")
            Else
                Txt_OtherTermCode.Text = Trim(vform.keyfield & "")
            End If
        End If
        vform.Close()
        vform = Nothing
        Me.Cmd_Ok.Focus()
    End Sub
    Private Sub Txt_OtherTermCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_OtherTermCode.Validated
        Dim j As Integer
        If Trim(Txt_WarrantyCode.Text) <> "" Then
            sqlstring = ""
            sqlstring = " SELECT ISNULL(TRANTYPE,0) AS TRANTYPE,ISNULL(MESSAGE,'') AS MESSAGE FROM PO_OTHERTERMS WHERE DOCTYPE = 'OTHERTERMS' AND TRANTYPE = '" & Txt_OtherTermCode.Text & "' "
            gconnection.getDataSet(sqlstring, "PO_OTHERTERMS")
            If gdataset.Tables("PO_OTHERTERMS").Rows.Count > 0 Then
                Me.Txt_WarrantyCode.Text = Trim(gdataset.Tables("PO_OTHERTERMS").Rows(0).Item("TRANTYPE"))
                Me.Cmd_Ok.Focus()
            End If
        Else
            Me.Txt_OtherTermCode.Focus()
        End If
    End Sub

    Private Sub Txt_OtherTermCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_OtherTermCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Cmd_OtherTermCodeHelp_Click(sender, e)
        End If
        If e.KeyCode = Keys.Enter Then
            If Txt_OtherTermCode.Text = "" Then
                Cmd_OtherTermCodeHelp_Click(sender, e)
            End If
        End If
    End Sub
    Private Sub cmd_dos_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gPrint = True
        Call Viewoperation_SCnew()
    End Sub
    Private Sub TXT_OVERALLDISC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_OVERALLDISC.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call ssgrid_Leave(sender, e)
            Me.CmdAdd.Focus()
        End If
    End Sub
    Private Sub TXT_CF_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_CF.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call ssgrid_Leave(sender, e)
            Me.TXT_DELIVERY.Focus()
        End If
    End Sub

    Private Sub TXT_TRANSPORT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_TRANSPORT.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call ssgrid_Leave(sender, e)
            Me.TXT_CF.Focus()
        End If
    End Sub

    Private Sub TXT_DELIVERY_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_DELIVERY.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Call ssgrid_Leave(sender, e)
            Me.TXT_OVERALLDISC.Focus()
        End If
    End Sub

    Private Sub cmd_DeptHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_DeptHelp.Click
        gSQLString = "SELECT isnull(STORECODE,'') AS STORECODE , ISNULL(STOREDESC,'') AS STOREDESC FROM STOREMASTER "
        M_WhereCondition = " WHERE STORESTATUS = 'M' "
        Dim vform As New ListOperattion1_N
        vform.Field = "STOREDESC,STORECODE"
        vform.vFormatstring = "  STORECODE   |        STORE DESCRIPTION                 "
        vform.vCaption = "DEPARTMENT HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            cbo_dept.Text = Trim(vform.keyfield1 & "")
            Call cbo_dept_Validated(txt_PONo.Text, e)
        End If
        vform.Close()
        vform = Nothing
        'txt_PONo.Focus()
    End Sub
    Private Sub cbo_dept_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_dept.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If cbo_dept.Text = "" Then
                Call cmd_DeptHelp_Click(cbo_dept, e)
            Else
                Call cbo_dept_Validated(cbo_dept, e)
            End If
        End If
    End Sub

    Private Sub cmd_GLAcInhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_GLAcInHelp.Click
        Try
            Dim vform As New List_Operation
            gSQLString = "SELECT accode,acdesc FROM accountsglaccountmaster"
            M_WhereCondition = " WHERE ACCODE IN (SELECT ACCODE FROM ACCOUNTSGLACCOUNTMASTER WHERE ISNULL(SUBGROUP,'')='INVENTORIES') "
            vform.Field = "ACDESC,ACCODE"
            vform.vFormatstring = "  ACCODE                              |                      ACDESC                                "
            vform.vCaption = "GLACCOUNT MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                Txt_GLAcIn.Text = Trim(vform.keyfield & "")
                lbl_gldesc.Text = Trim(vform.keyfield1 & "")
                lbl_gldesc.Visible = True
                Call Txt_GLAcIn_Validated(Txt_GLAcIn, e)
            Else
                Me.Txt_GLAcIn.Focus()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Cmd_GLAcHelp_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Txt_GLAcIn_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_GLAcIn.Validated
        Try
            Dim sqlstring As String
            If Trim(Txt_GLAcIn.Text) <> "" Then
                sqlstring = "select accode, acdesc from accountsglaccountmaster where accode = '" & Trim(Txt_GLAcIn.Text) & "'"
                gconnection.getDataSet(sqlstring, "accountsglaccountmaster")
                If gdataset.Tables("accountsglaccountmaster").Rows.Count > 0 Then
                    Txt_GLAcIn.Text = gdataset.Tables("accountsglaccountmaster").Rows(0).Item("accode")
                    lbl_gldesc.Text = gdataset.Tables("accountsglaccountmaster").Rows(0).Item("acdesc")
                    lbl_gldesc.Visible = True
                    Cbo_POStatus.Focus()
                Else
                    Txt_GLAcIn.Text = ""
                    Txt_GLAcIn.Focus()
                End If
                gdataset.Tables("accountsglaccountmaster").Dispose()
            Else
                Txt_GLAcIn.Text = ""
                'Txt_GLAcIn.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Txt_GLAcIn_Validated " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Txt_GLAcIn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_GLAcIn.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(Txt_GLAcIn.Text) = "" Then
                Call cmd_GLAcInhelp_Click(sender, e)
            Else
                Call Txt_GLAcIn_Validated(Txt_GLAcIn.Text, e)
                Me.Cbo_POStatus.Focus()
            End If
        End If
    End Sub
    Private Sub Txt_GLAcIn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_GLAcIn.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_GLAcInhelp_Click(sender, e)
        End If
    End Sub
    Private Sub Viewoperation_SC()
        If Me.txt_PONo.Text = "" Then
            MsgBox("Please give PO no", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.ssgrid.DataRowCnt = 0 Then
            MsgBox("No details to view or print", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.Txt_Vcode.Text = "" Then
            MsgBox("Please give Vendor Code", MsgBoxStyle.Information)
            Exit Sub
        End If
        Randomize()
        Dim PAGENO, ROWCOUNT, I As Integer
        Dim SSQL, SSQL1 As String
        Dim SLCODE As String
        Dim VSQL As String

        Dim j, intPageLength As Int16
        Dim intDescriptionLength, intStartIndex, intDescLenIndex, intDescMaxLen As Int16
        Dim strSpaceBefore, strSpaceAfter As String
        strSpaceBefore = ""
        strSpaceAfter = ""
        intDescMaxLen = 66
        intPageLength = 80

        Dim SLNAME, ADDRESS1, ADDRESS2, ADDRESS3 As String
        SSQL1 = "SELECT ISNULL(ADD1,'') AS ADD1, ISNULL(ADD2,'') AS ADD2, ISNULL(PINCODE,'') AS PINCODE FROM MASTER..CLUBMASTER WHERE DATAFILE = '" & gDatabase & "' "
        vconn.getDataSet(SSQL1, "CLUBMASTER")
        SSQL1 = ""
        vOutfile = Mid("CON" & (Rnd() * 800000), 1, 8)
        'vOutfile = Me.txt_PONo.Text & "-" & Mid("CON" & (Rnd() * 800000), 1, 8)
        VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        Filewrite = File.AppendText(VFilePath)
        printfile = VFilePath
        PAGENO = 1 : ROWCOUNT = 0
        Dim VREF As Boolean = False

        Dim STR, NARRATION As String

        Dim rate, vat, ltotal, gtotal, temp As Double
        Dim lqty, gqty As Double

        SSQL = "Select P.PONO,P.PODATE,P.POVENDORCODE,P.PODEPARTMENT,P.POAPPROVEDBY,P.POAPPROVEDDATE,P.POSTATUS,"
        SSQL = SSQL & " P.POVALUE,P.POADVANCE,P.POTOTALVAT,P.POTOTALTAX,P.POTOTALDISCOUNT,P.POADVANCE,P.POBALANCE,"
        SSQL = SSQL & " P.POTERMS,P.PODELIVERYTERMS,P.PODESPATCH,P.POSHIPPING,P.PODELIVERY,P.POCREDITDAYS,P.POENCL,"
        SSQL = SSQL & " P.POREMARKS,P.POCLOSURE,P.POFREIGHT,P.POCSTFORM, P.FREEZE,P.POOVERALLDISC,P.PODELIVERYAMT,P.POCF,P.POTRANSPORT"
        SSQL = SSQL & " from PO_HDR P "
        SSQL = SSQL & " where isnull(FREEZE,'')<>'Y'   AND P.PONO = '" & Trim(txt_PONo.Text) & "' "
        vconn.getDataSet(SSQL, "PO_HDR")

        Dim vcaption1 As String
        vcaption1 = ""

        If gdataset.Tables("PO_HDR").Rows.Count > 0 Then
            I = 0
            'PRINTING HEADER
            'If Me.Chk_MC_Form.Checked = False Then
            '    Call subPrintVoucherHeader("PURCHASE ORDER VOUCHER", 80)
            '    ROWCOUNT = 7
            'End If
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Filewrite.Write(Chr(27) & "E")
            Filewrite.WriteLine(Space(27) & Trim(gCompanyname))
            Filewrite.WriteLine(Space(30) & " PURCHASE ORDER ")
            With gdataset.Tables("PO_HDR").Rows(I)
                ROWCOUNT = ROWCOUNT + 3
                If VREF = False Then

                    STR = "SELECT ISNULL(VENDORCODE,0) AS VENDORCODE, ISNULL(VENDORNAME,'') AS VENDORNAME, ADDRESS, CITY, STATE  FROM PO_VIEW_VENDORMASTER WHERE VENDORCODE = '" & Trim(Txt_Vcode.Text) & "' "
                    vconn.getDataSet(STR, "ACCOUNTSSUBLEDGERMASTER")

                    STR = "select ACCODE, ACDESC from accountsglaccountmaster WHERE ACCODE = '" & Txt_GLAcIn.Text & "'"
                    vconn.getDataSet(STR, "GLACIN")
                    Dim GLACIN As String
                    If gdataset.Tables("GLACIN").Rows.Count > 0 Then
                        GLACIN = gdataset.Tables("GLACIN").Rows(0).Item("ACDESC")
                    End If

                    SSQL = "P.O. NO. : " & Trim(txt_PONo.Text)
                    SSQL = SSQL & Space(22)
                    SSQL = SSQL & "         DATE : " & Mid(Trim(Cbo_PODate.Text), 1, 20) & Space(20 - Len(Mid(Trim(Cbo_PODate.Text), 1, 20)))
                    Filewrite.WriteLine(SSQL)
                    Filewrite.WriteLine(Space(52) & "TO")
                    ROWCOUNT = ROWCOUNT + 2

                    Filewrite.Write(Trim(Mid(gCompanyname, 1, 52)))
                    Filewrite.Write(Space(52 - Len(Trim(Mid(gCompanyname, 1, 52)))))
                    If gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).IsNull("VENDORNAME") = False Then
                        Filewrite.WriteLine(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORNAME"))
                    End If
                    Filewrite.Write(Mid(gdataset.Tables("CLUBMASTER").Rows(0).Item("ADD1"), 1, 52))
                    Filewrite.Write(Space(52 - Len(Mid(Trim(gdataset.Tables("CLUBMASTER").Rows(0).Item("ADD1")), 1, 52))))
                    Filewrite.WriteLine("Vendor Code    : " & gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"))
                    'Filewrite.Write(Space(30))
                    Filewrite.Write(gdataset.Tables("CLUBMASTER").Rows(0).Item("ADD2") & "  " & gdataset.Tables("CLUBMASTER").Rows(0).Item("PINCODE"))
                    Filewrite.WriteLine(Chr(27) & "F")
                    Filewrite.WriteLine("TEL NO: 27804840 (EXT-28)" & Space(14) & Chr(27) & "E Inventory: " & GLACIN & Chr(27) & "F")
                    Filewrite.WriteLine()
                    ROWCOUNT = ROWCOUNT + 5
                    'If Chk_MC_Form.Checked = False Then
                    '    If gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).IsNull("VENDORNAME") = False Then
                    '        SSQL = Chr(27) & "E"
                    '        SSQL = SSQL & Mid(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"), 1, 6) & " : " & Space(6 - Len(Mid(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"), 1, 6))) & Space(2)
                    '        SSQL = SSQL & (gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORNAME"))
                    '        SSQL = SSQL & Space(15) & "Inventory: " & GLACIN
                    '        SSQL = SSQL & Chr(27) & "F"
                    '    Else
                    '        SSQL = Space(48)
                    '        SSQL = SSQL & "DATE        : " & Mid(Trim(Format(DateValue(Cbo_PODate.Text), "dd/MM/yyyy")), 1, 20) & Space(20 - Len(Mid(Trim(Cbo_PODate.Text), 1, 20)))
                    '    End If
                    '    Filewrite.WriteLine(SSQL)
                    '    Filewrite.WriteLine()
                    '    ROWCOUNT = ROWCOUNT + 2
                    'Else
                    '    SSQL = Chr(27) & "E"
                    '    Filewrite.WriteLine("To")
                    '    SSQL = SSQL & Mid(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"), 1, 6) & " : " & Space(6 - Len(Mid(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"), 1, 6))) & Space(2)
                    '    SSQL = SSQL & (gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORNAME"))
                    '    SSQL = SSQL & Space(15) & "Inventory: " & GLACIN
                    '    SSQL = SSQL & Chr(27) & "F"

                    '    Filewrite.Write(Chr(27) & "E")
                    '    Filewrite.WriteLine(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("ADDRESS"))
                    '    Filewrite.WriteLine(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("CITY"))
                    '    Filewrite.WriteLine(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("STATE"))
                    '    Filewrite.Write(Chr(27) & "F")

                    '    Filewrite.WriteLine(SSQL)
                    '    Filewrite.WriteLine()
                    '    ROWCOUNT = ROWCOUNT + 6
                    'End If

                    If Me.Chk_MC_Form.Checked = True Then
                        Filewrite.WriteLine(Space(30) & "KIND ATTN: ")
                        Filewrite.WriteLine("Dear Sirs,")
                        Filewrite.WriteLine()
                        ROWCOUNT = ROWCOUNT + 3

                        Dim bill As DataTable
                        Dim Loopindex As Integer
                        sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(txt_PONo.Text) & "' and DOCTYPE='SUBJECT' order by slno"
                        bill = gconnection.GetValues(sqlstring)
                        If bill.Rows.Count > 0 Then
                            Filewrite.Write("SUB:   ")
                            Loopindex = 0
                            For I = 0 To bill.Rows.Count - 1
                                Loopindex = Loopindex + 1
                                Filewrite.WriteLine(bill.Rows(I).Item("MESSAGE"))
                                ROWCOUNT = ROWCOUNT + 1
                            Next
                            Filewrite.WriteLine()
                            ROWCOUNT = ROWCOUNT + 1
                        End If
                        bill.Clear()
                        sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(txt_PONo.Text) & "' and DOCTYPE='REFERENCE' order by slno"
                        bill = gconnection.GetValues(sqlstring)
                        If bill.Rows.Count > 0 Then
                            Filewrite.Write("REF:   ")
                            Loopindex = 0
                            For I = 0 To bill.Rows.Count - 1
                                Loopindex = Loopindex + 1
                                Filewrite.WriteLine(bill.Rows(I).Item("MESSAGE"))
                                ROWCOUNT = ROWCOUNT + 1
                            Next
                            Filewrite.WriteLine()
                            ROWCOUNT = ROWCOUNT + 1
                        End If
                        bill.Clear()
                        sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(txt_PONo.Text) & "' and DOCTYPE='BODY' order by slno"
                        bill = gconnection.GetValues(sqlstring)
                        If bill.Rows.Count > 0 Then
                            Loopindex = 0
                            For I = 0 To bill.Rows.Count - 1
                                Loopindex = Loopindex + 1
                                Filewrite.WriteLine(Space(7) & bill.Rows(I).Item("MESSAGE"))
                                ROWCOUNT = ROWCOUNT + 1
                            Next
                            Filewrite.WriteLine()
                            ROWCOUNT = ROWCOUNT + 1
                        End If
                        bill.Clear()
                    End If

                    If Chk_MC_Form.Checked = False Then
                        Filewrite.WriteLine("              " & Chr(27) & "E" & "SUB : " & Chr(27) & "F" & "PURCHASE ORDER FOR FOLLOWING MATERIAL - REG. - ")
                        Filewrite.WriteLine("               FOR THE DEPARTMENT OF '" & cbo_dept.Text & "' ")
                        Filewrite.WriteLine()
                        ROWCOUNT = ROWCOUNT + 2
                        Filewrite.WriteLine("PLEASE SUPPLY THE FOLLOWING MATERIAL AT THE EARLIEST: ")
                        Filewrite.WriteLine()
                        ROWCOUNT = ROWCOUNT + 3
                    End If
                    Filewrite.WriteLine(StrDup(80, "-"))
                    'Filewrite.WriteLine("NO.     ITEM DESCRIPTION " & Space(19) & "  RATE  " & Space(2) & " QTY    VAT   QTY*RATE+VAT- ")
                    'Filewrite.WriteLine("                         " & Space(19) & "        " & Space(2) & "              DISCOUNT(Rs.) ")
                    Filewrite.WriteLine("NO.     ITEM DESCRIPTION " & Space(19) & "  RATE  " & Space(2) & " QTY    VAT   GROSS ")
                    Filewrite.WriteLine(StrDup(80, "-"))
                    ROWCOUNT = ROWCOUNT + 3
                    VREF = True
                End If

                'SSQL = "SELECT isnull(discount,0) as discount,* FROM PO_ITEMDETAILS WHERE PONO = '" & txt_PONo.Text & "' "
                SSQL = "SELECT AUTOID,SUM(discount) as discount,ISNULL(PONO,'') AS PONO,ISNULL(ITEMCODE,'') AS ITEMCODE, "
                SSQL = SSQL & " ISNULL(QUANTITY,0) AS QUANTITY,ISNULL(REQUIREDDATE,'') AS REQUIREDDATE,ISNULL(RATE,0) AS RATE,"
                SSQL = SSQL & " ISNULL(VAT,0) AS VAT, ISNULL(TOTAL,0) AS TOTAL , ISNULL(AMOUNT,0) AMOUNT , ISNULL(DISCAMT,0) DISCAMT , ISNULL(VATAMT,0) VATAMT "
                SSQL = SSQL & " FROM PO_ITEMDETAILS WHERE PONO = '" & txt_PONo.Text & "'"
                SSQL = SSQL & " GROUP BY AUTOID,PONO,ITEMCODE,QUANTITY,REQUIREDDATE,RATE,VAT,TOTAL,AMOUNT,DISCAMT,VATAMT ORDER BY AUTOID "
                vconn.getDataSet(SSQL, "PO_ITEMDETAILS")

                If gdataset.Tables("PO_ITEMDETAILS").Rows.Count > 0 Then
                    For j = 0 To gdataset.Tables("PO_ITEMDETAILS").Rows.Count - 1
                        ltotal = lqty = 0
                        ROWCOUNT = ROWCOUNT + 1
                        If ROWCOUNT > 58 Then
                            Filewrite.WriteLine(StrDup(80, "-"))
                            Filewrite.WriteLine(Chr(12))
                            PAGENO = PAGENO + 1
                            Call subPrintVoucherHeader("PURCHASE ORDER", 80)
                            Filewrite.WriteLine(StrDup(80, "-"))
                            ROWCOUNT = 6
                        End If
                        'adding rate + tax
                        rate = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE")
                        vat = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("VAT")
                        temp = rate * vat / 100
                        'ltotal = rate + temp
                        'ltotal = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("TOTAL")
                        ltotal = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("AMOUNT")
                        lqty = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("QUANTITY")
                        'Dim vattotal As Double
                        'vattotal = rate * lqty
                        'vattotal = (vattotal * vat) / 100
                        rate = 0 : vat = 0 : temp = 0
                        If gdataset.Tables("PO_ITEMDETAILS").Rows(j).IsNull("ITEMCODE") = False Then
                            'ITEMCODE
                            SSQL = Space(2 - Len(Mid(Format(j + 1, ""), 1, 2))) & Mid(Format(j + 1, ""), 1, 2) & " "
                            'ITEM NAME RETRIEVAL
                            SSQL1 = "SELECT * FROM PO_VIEW_ITEMMASTER WHERE ITEMCODE = '" & gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("ITEMCODE") & "' "
                            vconn.getDataSet(SSQL1, "INVENTORYITEMMASTER")
                            'ITEM NAME
                            SSQL = SSQL & Space(6)
                            SSQL = SSQL & Mid(gdataset.Tables("INVENTORYITEMMASTER").Rows(0).Item("ITEMNAME"), 1, 35) & Space(35 - Len(Mid(gdataset.Tables("INVENTORYITEMMASTER").Rows(0).Item("ITEMNAME"), 1, 35)))
                            'RATE
                            SSQL = SSQL & Space(1)
                            SSQL = SSQL & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE"), 1, 8) & Space(8 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE"), 1, 8)))
                            'QUANTITY
                            'SSQL = SSQL & Space(2)
                            SSQL = SSQL & Space(6 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("QUANTITY"), 1, 6))) & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("QUANTITY"), 1, 6)
                            'VAT
                            SSQL = SSQL & Space(2)
                            SSQL = SSQL & Space(6 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("VAT"), 1, 6))) & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("VAT"), 1, 6)
                            'RATE
                            SSQL = SSQL & Space(2)
                            SSQL = SSQL & Space(10 - Len(Mid(Format(ltotal, "0.00"), 1, 10))) & Mid(Format(ltotal, "0.00"), 1, 10) & " "
                            gtotal = gtotal + ltotal
                            'vattotal = Nothing
                            gqty = gqty + lqty
                            Filewrite.WriteLine(SSQL)
                        Else
                            SSQL = Space(53)
                        End If
                    Next j
                End If
                'FOR MINIMUM 10 BLANK LINES IN THE ITEM DETAILS SECTION    
                If gdataset.Tables("PO_ITEMDETAILS").Rows.Count < 10 Then
                    j = 0
                    j = gdataset.Tables("PO_ITEMDETAILS").Rows.Count
                    j = 10 - j
                    Dim K
                    For K = 0 To j
                        Filewrite.WriteLine()
                    Next
                End If

                'Dim povalue, ADVamt, totDiscnt As Double
                'povalue = Val(gdataset.Tables("PO_HDR").Rows(0).Item("POVALUE")) '- Val(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"))
                'Filewrite.WriteLine("TOTAL VALUE    : " & Space(10 - Len(Mid(Format(povalue, "0.00"), 1, 10))) & Mid(Format(povalue, "0.00"), 1, 10) & " ")
                'Filewrite.WriteLine("TOTAL VAT      : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"), "0.00"), 1, 10) & " ")
                'totDiscnt = Format(Val(gdataset.Tables("PO_HDR").Rows(0).Item("POOVERALLDISC")) + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALDISCOUNT")), "0.00")
                'Filewrite.WriteLine("TOTAL DISCOUNT : " & Space(10 - Len(Mid(Format(totDiscnt, "0.00"), 1, 10))) & Mid(Format(totDiscnt, "0.00"), 1, 10) & " ")
                'Filewrite.WriteLine("TOTAL ADVANCE  : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00"), 1, 10) & " ")
                'Filewrite.WriteLine("DELIVERY       : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"), "0.00"), 1, 10) & " ")
                'Filewrite.WriteLine("C & F          : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"), "0.00"), 1, 10) & " ")
                'Filewrite.WriteLine("TRANSPORT      : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"), "0.00"), 1, 10) & " ")
                'ADVamt = Format(povalue, "0.00") - Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00")
                'Filewrite.WriteLine("BALANCE AMOUNT : " & Space(10 - Len(Mid(Format(ADVamt, "0.00"), 1, 10))) & Mid(Format(ADVamt, "0.00"), 1, 10))
                'Filewrite.WriteLine("TOTAL DISCOUNT : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_ITEMDETAILS").Rows(0).Item("DISCOUNT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_ITEMDETAILS").Rows(0).Item("DISCOUNT"), "0.00"), 1, 10) & " ")
                'Filewrite.WriteLine("TOTAL DISCOUNT : " & Space(10 - Len(Mid(Format(discounttotal, "0.00"), 1, 10))) & Mid(Format(discounttotal, "0.00"), 1, 10) & " ")

                ROWCOUNT = ROWCOUNT + 4

                If gdataset.Tables("PO_HDR").Rows(0).IsNull("poremarks") = False Then
                    NARRATION = gdataset.Tables("PO_HDR").Rows(0).Item("poremarks")
                Else
                    NARRATION = ""
                End If
            End With

            Filewrite.WriteLine()
            If Len(NARRATION) > 0 Then
                intDescriptionLength = Split(Len(NARRATION) / intDescMaxLen, ".")(0)
                intDescriptionLength = intDescriptionLength + 1
                intStartIndex = 1
                intDescLenIndex = intDescMaxLen
                For j = 1 To intDescriptionLength
                    If j = 1 Then
                        Filewrite.Write("Narration : ")
                        strSpaceBefore = ""
                    Else
                        strSpaceBefore = Space(12)
                    End If
                    If j = intDescriptionLength Then
                        Filewrite.WriteLine(strSpaceBefore & Trim(Mid(Trim(NARRATION), intStartIndex, intDescMaxLen)) & Space((intDescMaxLen + 1) - Len(Trim(Mid(Trim(NARRATION), intStartIndex, intDescMaxLen)))) & strSpaceAfter)
                    Else
                        If Mid(NARRATION, intDescLenIndex, 1) = " " Then
                            Filewrite.WriteLine(strSpaceBefore & Trim(Mid(NARRATION, intStartIndex, intDescMaxLen)) & "- " & strSpaceAfter)
                        Else
                            Filewrite.WriteLine(strSpaceBefore & Trim(Mid(Trim(NARRATION), intStartIndex, intDescMaxLen)) & "-" & strSpaceAfter)
                        End If
                    End If
                    ROWCOUNT = ROWCOUNT + 1
                    intStartIndex = intStartIndex + intDescMaxLen
                    intDescLenIndex = intDescLenIndex + intDescMaxLen
                Next
            End If
        Else
            MsgBox("NO RECORD TO VIEW ", MsgBoxStyle.Information)
            Exit Sub
        End If

        Filewrite.WriteLine(StrDup(80, "-"))
        Filewrite.Write(Space(9) & Chr(27) & "E" & "TOTAL : " & Chr(27) & "F")
        Filewrite.Write(Space(32) & Space(10 - Len(Mid(Format(gqty, "0.00"), 1, 10))) & Mid(Format(gqty, "0.00"), 1, 10))
        Filewrite.Write(Space(8))
        Filewrite.WriteLine(Space(2) & Space(10 - Len(Mid(Format(gtotal, "0.00"), 1, 10))) & Mid(Format(gtotal, "0.00"), 1, 10))
        Filewrite.WriteLine(StrDup(80, "-"))



        SSQL = " SELECT * FROM PO_PAYMENTTERMS WHERE PAYMENTTERMCODE = '" & Txt_POTerms.Text & "' "
        vconn.getDataSet(SSQL, "PO_PAYMENTTERMS")
        SSQL = " SELECT * FROM PO_DELIVERYTERMS WHERE DELIVERYTERMCODE = '" & Txt_DeliveryTerms.Text & "' "
        vconn.getDataSet(SSQL, "PO_DELIVERYTERMS")
        SSQL = " SELECT * FROM PO_WARRANTYTERMS WHERE WARRANTYTERMCODE = '" & Txt_WarrantyCode.Text & "' "
        vconn.getDataSet(SSQL, "PO_WARRANTYTERMS")
        If Chk_MC_Form.Checked = True Then
            Filewrite.WriteLine("TERMS & CONDITIONS: ")
            Filewrite.WriteLine()
            Filewrite.WriteLine("#. TERMS OF PAYMENT  : " & gdataset.Tables("PO_PAYMENTTERMS").Rows(0).Item("PAYMENTTERMDESC"))
            Filewrite.WriteLine("#. TERMS OF DELIVERY : " & gdataset.Tables("PO_DELIVERYTERMS").Rows(0).Item("DELIVERYTERMDESC"))
            If gdataset.Tables("PO_WARRANTYTERMS").Rows.Count > 0 Then
                Filewrite.WriteLine("#. TERMS OF WARRANTY : " & gdataset.Tables("PO_WARRANTYTERMS").Rows(0).Item("WARRANTYTERMDESC"))
            End If
            ROWCOUNT = ROWCOUNT + 5
            If Trim(Txt_OtherTermCode.Text) <> "" Then
                Dim bill As DataTable
                Dim loop1, temp1 As Integer
                Dim Othertermcode(10), TextValue As String
                loop1 = 0
                TextValue = Trim(Me.Txt_OtherTermCode.Text)
                For I = 0 To Me.Txt_OtherTermCode.Text.Length - 1
                    If Me.Txt_OtherTermCode.Text.Chars(I) = "," Then
                        If loop1 = 0 Then
                            Othertermcode(loop1) = TextValue.Substring(0, I)
                            loop1 = loop1 + 1
                            temp1 = I
                        Else
                            Othertermcode(loop1) = TextValue.Substring(temp1 + 2, I)
                            loop1 = loop1 + 1
                            temp1 = I
                        End If
                    End If
                Next
                Filewrite.Write("#. OTHER TERMS       : ")
                For I = 0 To loop1
                    sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(Othertermcode(I)) & "' and DOCTYPE='OTHERTERMS' order by slno"
                    bill = gconnection.GetValues(sqlstring)
                    If bill.Rows.Count > 0 Then
                        For j = 0 To bill.Rows.Count - 1
                            Filewrite.WriteLine(Space(3) & bill.Rows(j).Item("MESSAGE"))
                            ROWCOUNT = ROWCOUNT + 1
                        Next j
                    End If
                    bill.Clear()
                Next I
                Filewrite.WriteLine()
                ROWCOUNT = ROWCOUNT + 1
            End If
        Else
            If gdataset.Tables("PO_PAYMENTTERMS").Rows(0).IsNull("PAYMENTTERMCODE") = False Then
                Filewrite.WriteLine(" PAYMENT TERMS  : " & gdataset.Tables("PO_PAYMENTTERMS").Rows(0).Item("PAYMENTTERMDESC"))
            Else
                Filewrite.WriteLine()
            End If
            If gdataset.Tables("PO_DELIVERYTERMS").Rows(0).IsNull("DELIVERYTERMCODE") = False Then
                Filewrite.WriteLine(" DELIVERY TERMS : " & gdataset.Tables("PO_DELIVERYTERMS").Rows(0).Item("DELIVERYTERMDESC"))
            Else
                Filewrite.WriteLine()
            End If
        End If

        Dim povalue, ADVamt, totDiscnt As Double
        povalue = Val(gdataset.Tables("PO_HDR").Rows(0).Item("POVALUE")) '- Val(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"))

        Filewrite.Write(Chr(27) & "E" & Space(53))
        Filewrite.WriteLine("TOTAL VAT      : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"), "0.00"), 1, 10) & " ")
        totDiscnt = Format(Val(gdataset.Tables("PO_HDR").Rows(0).Item("POOVERALLDISC")) + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALDISCOUNT")), "0.00")
        Filewrite.Write(Space(53))
        Filewrite.WriteLine("TOTAL DISCOUNT : " & Space(10 - Len(Mid(Format(totDiscnt, "0.00"), 1, 10))) & Mid(Format(totDiscnt, "0.00"), 1, 10) & " ")
        Filewrite.Write(Space(53))
        Filewrite.WriteLine("DELIVERY       : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"), "0.00"), 1, 10) & " ")
        Filewrite.Write(Space(53))
        Filewrite.WriteLine("C & F          : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"), "0.00"), 1, 10) & " ")
        Filewrite.Write(Space(53))
        Filewrite.WriteLine("TRANSPORT      : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"), "0.00"), 1, 10) & " ")

        If (Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00")) <> "0.00" Then
            Filewrite.Write(Space(53))
            Filewrite.WriteLine("TOTAL ADVANCE  : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00"), 1, 10) & " ")
        End If
        ADVamt = Format(povalue, "0.00") - Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00")
        If (Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00")) <> "0.00" Then
            Filewrite.Write(Space(53))
            Filewrite.WriteLine("BALANCE AMOUNT : " & Space(10 - Len(Mid(Format(ADVamt, "0.00"), 1, 10))) & Mid(Format(ADVamt, "0.00"), 1, 10))
        End If
        povalue = Val(gdataset.Tables("PO_HDR").Rows(0).Item("POVALUE")) '- Val(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"))
        Filewrite.Write(Space(53))
        Filewrite.WriteLine("TOTAL VALUE    : " & Space(10 - Len(Mid(Format(povalue, "0.00"), 1, 10))) & Mid(Format(povalue, "0.00"), 1, 10) & " ")
        Filewrite.Write(Chr(27) & "F" & Space(53))

        For I = 0 To 14
            Filewrite.WriteLine()
        Next
        If Chk_MC_Form.Checked = False Then
            Call subPrintVoucherFooter1(80, PAGENO)
        Else
            Filewrite.WriteLine("Thanking you,")
            Filewrite.WriteLine()
            Filewrite.WriteLine("Yours sincerly,")
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            'Filewrite.WriteLine("E.RAJENDER KUMAR")
            'Filewrite.WriteLine(" Hon. Secretary")
        End If

        Filewrite.WriteLine(Chr(12))
        Filewrite.Close()
        If gPrint = False Then
            OpenTextFile(vOutfile)
        Else
            PrintTextFile1(VFilePath)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_warehouse.SelectedIndexChanged



        Try
            Call FOOTER()
            If CmdAdd.Text = "Add [F7]" Then
                If Mid(UCase(gCompanyname), 1, 6) = "KARNAT" Then
                    doctype = "PUR"
                    Call autogenerate()
                Else
                    doctype = Trim(cbo_warehouse.Text)
                    Call autogenerate_Inv()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try


        'VenuJD     19-11-2011  --Blocked for RSI Club
        'Try
        '    Dim i As Integer
        '    If CmdAdd.Text = "Add [F7]" Then
        '        If UCase(cbo_warehouse.Text) = "DRY RATION" Then
        '            doctype = "DRY"
        '        ElseIf UCase(cbo_warehouse.Text) = "GODOWN" Then
        '            doctype = "GDN"
        '        ElseIf UCase(cbo_warehouse.Text) = "NAA" Then
        '            doctype = "NAA"
        '        Else
        '            doctype = "LIQ"
        '        End If
        '        Call autogenerate_sc()
        '    Else
        '        'If cbo_Tostore.Text <> VSTORENAME Then
        '        '    sqlstring = "SELECT Storecode FROM StoreMaster Where Storedesc='" & Trim(cbo_Tostore.SelectedItem) & "'"
        '        '    gconnection.getDataSet(sqlstring, "StoreMaster")
        '        '    If gdataset.Tables("StoreMaster").Rows.Count > 0 Then
        '        '        txt_Tostorecode.Text = Trim(gdataset.Tables("StoreMaster").Rows(i).Item("Storecode"))
        '        '        txt_Tostorecode.ReadOnly = True
        '        '    End If
        '        '    doctype = Trim(txt_Tostorecode.Text)
        '        '    Call autogenerate()
        '        'Else
        '        '    txt_Docno.Text = VSTRDOCNO
        '        '    txt_Tostorecode.Text = VSTORECODE
        '        'End If
        '    End If
        '    Call FOOTER()
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub cbo_dept_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_dept.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_DeptHelp_Click(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub cbo_dept_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_dept.Validated
        Dim j As Integer
        If Trim(cbo_dept.Text) <> "" Then
            'sqlstring = "SELECT SLCODE,SLNAME,FREEZEFLAG FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & gCreditors & "' AND SLCODE='" & Trim(Txt_Vcode.Text) & "'"
            sqlstring = "SELECT isnull(STORECODE,'') AS STORECODE , ISNULL(STOREDESC,'') AS STOREDESC FROM STOREMASTER where storedesc = '" & cbo_dept.Text & "'"
            gconnection.getDataSet(sqlstring, "storecode1")
            If gdataset.Tables("storecode1").Rows.Count > 0 Then
                'Txt_Vcode.Text = Trim(gdataset.Tables("storecode1").Rows(0).Item("STORECODE"))
                cbo_dept.Text = Trim(gdataset.Tables("storecode1").Rows(0).Item("STOREdesc"))
                Me.Txt_QuotNo.Focus()
            Else
                cbo_dept.Text = ""
                Me.cbo_dept.Focus()
            End If
        End If
    End Sub

    Private Sub Cbo_PODate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cbo_PODate.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Cbo_POStatus.Focus()
        End If
    End Sub
    Private Sub chk_amnd_foll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If chk_amnd_foll.Checked Then
            AmendmentGrid.Lock = False
            FollowupGrid.Lock = False
            Grp_amend_Follow.Visible = True
            Grp_amend_Follow.Top = 150
            Grp_amend_Follow.Left = 250
        Else
            Grp_amend_Follow.Visible = False
            Grp_amend_Follow.Top = 250
            Grp_amend_Follow.Left = 1000
        End If
    End Sub
    Private Sub Txt_Remarks_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            Txt_ED.Focus()
        End If
    End Sub
    Private Sub cbo_dept_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_dept.GotFocus
        cbo_dept.BackColor = Color.Gold
    End Sub

    Private Sub cbo_dept_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_dept.LostFocus
        cbo_dept.BackColor = Color.White
    End Sub

    Private Sub Txt_AdvanceAmt_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_AdvanceAmt.GotFocus
        Txt_AdvanceAmt.BackColor = Color.Gold
    End Sub

    Private Sub Txt_AdvanceAmt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_AdvanceAmt.LostFocus
        Txt_AdvanceAmt.BackColor = Color.LightBlue
    End Sub

    Private Sub TXT_CF_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_CF.GotFocus
        TXT_CF.BackColor = Color.Gold
    End Sub

    Private Sub TXT_CF_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_CF.LostFocus
        TXT_CF.BackColor = Color.LightBlue
    End Sub

    Private Sub TXT_DELIVERY_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_DELIVERY.GotFocus
        TXT_DELIVERY.BackColor = Color.Gold
    End Sub

    Private Sub TXT_DELIVERY_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_DELIVERY.LostFocus
        TXT_DELIVERY.BackColor = Color.LightBlue
    End Sub

    Private Sub Txt_CST_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_CST.GotFocus
        Txt_CST.BackColor = Color.Gold
    End Sub

    Private Sub Txt_CST_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_CST.LostFocus
        Txt_CST.BackColor = Color.LightBlue
    End Sub

    Private Sub Txt_MODVat_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_MODVat.GotFocus
        Txt_MODVat.BackColor = Color.Gold
    End Sub

    Private Sub Txt_MODVat_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_MODVat.LostFocus
        Txt_MODVat.BackColor = Color.LightBlue
    End Sub

    Private Sub Txt_PTax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_PTax.GotFocus
        Txt_PTax.BackColor = Color.Gold
    End Sub

    Private Sub Txt_PTax_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_PTax.LostFocus
        Txt_PTax.BackColor = Color.LightBlue
    End Sub

    Private Sub Txt_Octra_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Octra.GotFocus
        Txt_Octra.BackColor = Color.Gold
    End Sub

    Private Sub Txt_Octra_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Octra.LostFocus
        Txt_Octra.BackColor = Color.LightBlue
    End Sub

    Private Sub Txt_Insurance_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Insurance.GotFocus
        Txt_Insurance.BackColor = Color.Gold
    End Sub

    Private Sub Txt_LST_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_LST.GotFocus
        Txt_LST.BackColor = Color.Gold
    End Sub

    Private Sub Txt_LST_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_LST.LostFocus
        Txt_LST.BackColor = Color.LightBlue
    End Sub

    Private Sub Txt_POTerms_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_POTerms.GotFocus
        Txt_POTerms.BackColor = Color.Gold
    End Sub

    Private Sub Txt_POTerms_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_POTerms.LostFocus
        Txt_POTerms.BackColor = Color.LightBlue
    End Sub

    Private Sub Txt_DeliveryTerms_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_DeliveryTerms.GotFocus
        Txt_DeliveryTerms.BackColor = Color.Gold
    End Sub

    Private Sub Txt_DeliveryTerms_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_DeliveryTerms.LostFocus
        Txt_DeliveryTerms.BackColor = Color.White
    End Sub

    Private Sub Txt_ED_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_ED.GotFocus
        Txt_ED.BackColor = Color.Gold
    End Sub

    Private Sub Txt_ED_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_ED.LostFocus
        Txt_ED.BackColor = Color.LightBlue
    End Sub
    Private Sub Txt_Remarks_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Txt_Remarks.BackColor = Color.Gold
    End Sub

    Private Sub Txt_Remarks_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        Txt_Remarks.BackColor = Color.LightBlue
    End Sub

    Private Sub TXT_TRANSPORT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_TRANSPORT.GotFocus
        TXT_TRANSPORT.BackColor = Color.Gold
    End Sub

    Private Sub TXT_TRANSPORT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_TRANSPORT.LostFocus
        TXT_TRANSPORT.BackColor = Color.LightBlue
    End Sub

    Private Sub TXT_OVERALLDISC_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_OVERALLDISC.GotFocus
        TXT_OVERALLDISC.BackColor = Color.Gold
    End Sub

    Private Sub TXT_OVERALLDISC_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_OVERALLDISC.LostFocus
        TXT_OVERALLDISC.BackColor = Color.LightBlue
    End Sub

    Private Sub cbo_warehouse_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_warehouse.GotFocus
        cbo_warehouse.BackColor = Color.Gold
    End Sub

    Private Sub cbo_warehouse_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbo_warehouse.LostFocus
        cbo_warehouse.BackColor = Color.White
    End Sub

    Private Sub Txt_QuotNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_QuotNo.GotFocus
        Txt_QuotNo.BackColor = Color.Gold
    End Sub

    Private Sub Txt_QuotNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_QuotNo.LostFocus
        Txt_QuotNo.BackColor = Color.White
    End Sub

    Private Sub txt_PONo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_PONo.GotFocus
        txt_PONo.BackColor = Color.Gold
    End Sub

    Private Sub txt_PONo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_PONo.LostFocus
        txt_PONo.BackColor = Color.White
    End Sub

    Private Sub Txt_Vcode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Vcode.GotFocus
        Txt_Vcode.BackColor = Color.Gold
    End Sub

    Private Sub Txt_Vcode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Vcode.LostFocus
        Txt_Vcode.BackColor = Color.White
    End Sub

    Private Sub Cbo_Approvedby_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo_Approvedby.GotFocus
        Cbo_Approvedby.BackColor = Color.Gold
    End Sub

    Private Sub Cbo_Approvedby_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo_Approvedby.LostFocus
        Cbo_Approvedby.BackColor = Color.White
    End Sub

    Private Sub Cbo_POStatus_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo_POStatus.GotFocus
        Cbo_POStatus.BackColor = Color.Gold
    End Sub

    Private Sub Cbo_POStatus_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo_POStatus.LostFocus
        Cbo_POStatus.BackColor = Color.White
    End Sub

    Private Sub Txt_GLAcIn_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_GLAcIn.GotFocus
        Txt_GLAcIn.BackColor = Color.Gold
    End Sub

    Private Sub Txt_GLAcIn_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_GLAcIn.LostFocus
        Txt_GLAcIn.BackColor = Color.White
    End Sub

    Private Sub Txt_Insurance_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Insurance.LostFocus
        Txt_Insurance.BackColor = Color.LightBlue
    End Sub

    Private Sub cbo_warehouse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_warehouse.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbo_dept.Focus()
        End If
    End Sub

    Private Sub Viewoperation_SCnew()
        If Me.txt_PONo.Text = "" Then
            MsgBox("Please give PO no", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.ssgrid.DataRowCnt = 0 Then
            MsgBox("No details to view or print", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Me.Txt_Vcode.Text = "" Then
            MsgBox("Please give Vendor Code", MsgBoxStyle.Information)
            Exit Sub
        End If
        Randomize()
        Dim PAGENO, ROWCOUNT, I As Integer
        Dim SSQL, SSQL1 As String
        Dim SLCODE As String
        Dim VSQL As String

        Dim j, intPageLength As Int16
        Dim intDescriptionLength, intStartIndex, intDescLenIndex, intDescMaxLen As Int16
        Dim strSpaceBefore, strSpaceAfter As String
        strSpaceBefore = ""
        strSpaceAfter = ""
        intDescMaxLen = 66
        intPageLength = 80

        Dim SLNAME, ADDRESS1, ADDRESS2, ADDRESS3 As String
        SSQL1 = "SELECT ISNULL(ADD1,'') AS ADD1, ISNULL(ADD2,'') AS ADD2, ISNULL(PINCODE,'') AS PINCODE FROM MASTER..CLUBMASTER WHERE DATAFILE = '" & gDatabase & "' "
        vconn.getDataSet(SSQL1, "CLUBMASTER")
        SSQL1 = ""
        vOutfile = Mid("CON" & (Rnd() * 800000), 1, 8)
        'vOutfile = Me.txt_PONo.Text & "-" & Mid("CON" & (Rnd() * 800000), 1, 8)
        VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        Filewrite = File.AppendText(VFilePath)
        printfile = VFilePath
        PAGENO = 1 : ROWCOUNT = 0
        Dim VREF As Boolean = False

        Dim STR, NARRATION As String

        Dim rate, vat, ltotal, gtotal, temp As Double
        Dim lqty, gqty As Double

        SSQL = "Select P.PONO,P.PODATE,P.POVENDORCODE,P.PODEPARTMENT,P.POAPPROVEDBY,P.POAPPROVEDDATE,P.POSTATUS,"
        SSQL = SSQL & " P.POVALUE,P.POADVANCE,P.POTOTALVAT,P.POTOTALTAX,P.POTOTALDISCOUNT,P.POADVANCE,P.POBALANCE,"
        SSQL = SSQL & " P.POTERMS,P.PODELIVERYTERMS,P.PODESPATCH,P.POSHIPPING,P.PODELIVERY,P.POCREDITDAYS,P.POENCL,"
        SSQL = SSQL & " P.POREMARKS,P.POCLOSURE,P.POFREIGHT,P.POCSTFORM, P.FREEZE,P.POOVERALLDISC,P.PODELIVERYAMT,P.POCF,P.POTRANSPORT"
        SSQL = SSQL & " from PO_HDR P "
        SSQL = SSQL & " where isnull(FREEZE,'')<>'Y'   AND P.PONO = '" & Trim(txt_PONo.Text) & "' "
        vconn.getDataSet(SSQL, "PO_HDR")

        Dim vcaption1 As String
        vcaption1 = ""

        If gdataset.Tables("PO_HDR").Rows.Count > 0 Then
            I = 0
            'PRINTING HEADER
            'If Me.Chk_MC_Form.Checked = False Then
            '    Call subPrintVoucherHeader("PURCHASE ORDER VOUCHER", 80)
            '    ROWCOUNT = 7
            'End If
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Filewrite.Write(Chr(27) & "E")
            Filewrite.WriteLine(Space(34) & Trim(gCompanyname))
            Filewrite.WriteLine()
            Filewrite.WriteLine(Space(37) & " PURCHASE ORDER ")
            Filewrite.WriteLine()
            With gdataset.Tables("PO_HDR").Rows(I)
                ROWCOUNT = ROWCOUNT + 7
                If VREF = False Then

                    STR = "SELECT ISNULL(VENDORCODE,0) AS VENDORCODE, ISNULL(VENDORNAME,'') AS VENDORNAME, ADDRESS, CITY, STATE  FROM PO_VIEW_VENDORMASTER WHERE VENDORCODE = '" & Trim(Txt_Vcode.Text) & "' "
                    vconn.getDataSet(STR, "ACCOUNTSSUBLEDGERMASTER")

                    STR = "select ACCODE, ACDESC from accountsglaccountmaster WHERE ACCODE = '" & Txt_GLAcIn.Text & "'"
                    vconn.getDataSet(STR, "GLACIN")
                    Dim GLACCODE, GLACIN As String
                    If gdataset.Tables("GLACIN").Rows.Count > 0 Then
                        GLACIN = gdataset.Tables("GLACIN").Rows(0).Item("ACDESC")
                        GLACCODE = gdataset.Tables("GLACIN").Rows(0).Item("ACCODE")
                    End If

                    SSQL = "P.O. NO. : " & Chr(27) & Chr(45) & Chr(49) & Trim(txt_PONo.Text) & Chr(27) & Chr(45) & Chr(48)
                    SSQL = SSQL & Space(22)
                    SSQL = SSQL & "         DATE : " & Mid(Trim(Cbo_PODate.Text), 1, 20) & Space(20 - Len(Mid(Trim(Cbo_PODate.Text), 1, 20)))
                    Filewrite.WriteLine(SSQL)
                    Filewrite.WriteLine()
                    Filewrite.WriteLine(Space(52) & "TO")
                    ROWCOUNT = ROWCOUNT + 3

                    Filewrite.Write(Trim(Mid(gCompanyname, 1, 52)))
                    Filewrite.Write(Space(52 - Len(Trim(Mid(gCompanyname, 1, 52)))))
                    If gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).IsNull("VENDORNAME") = False Then
                        Filewrite.WriteLine(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORNAME"))
                    End If
                    Filewrite.Write(Mid(gdataset.Tables("CLUBMASTER").Rows(0).Item("ADD1"), 1, 52))
                    Filewrite.Write(Space(52 - Len(Mid(Trim(gdataset.Tables("CLUBMASTER").Rows(0).Item("ADD1")), 1, 52))))
                    Filewrite.WriteLine("Vendor Code    : " & gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"))
                    'Filewrite.Write(Space(30))
                    Filewrite.Write(gdataset.Tables("CLUBMASTER").Rows(0).Item("ADD2") & "  " & gdataset.Tables("CLUBMASTER").Rows(0).Item("PINCODE"))
                    Filewrite.WriteLine(Chr(27) & "F")
                    Filewrite.WriteLine("TEL NO: 27804840 (EXT-28)" & Space(14) & Chr(27) & "E Inventory: " & GLACIN)
                    Filewrite.WriteLine(Space(43) & "GL AC : " & GLACCODE & Chr(27) & "F")
                    ROWCOUNT = ROWCOUNT + 5
                    'If Chk_MC_Form.Checked = False Then
                    '    If gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).IsNull("VENDORNAME") = False Then
                    '        SSQL = Chr(27) & "E"
                    '        SSQL = SSQL & Mid(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"), 1, 6) & " : " & Space(6 - Len(Mid(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"), 1, 6))) & Space(2)
                    '        SSQL = SSQL & (gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORNAME"))
                    '        SSQL = SSQL & Space(15) & "Inventory: " & GLACIN
                    '        SSQL = SSQL & Chr(27) & "F"
                    '    Else
                    '        SSQL = Space(48)
                    '        SSQL = SSQL & "DATE        : " & Mid(Trim(Format(DateValue(Cbo_PODate.Text), "dd/MM/yyyy")), 1, 20) & Space(20 - Len(Mid(Trim(Cbo_PODate.Text), 1, 20)))
                    '    End If
                    '    Filewrite.WriteLine(SSQL)
                    '    Filewrite.WriteLine()
                    '    ROWCOUNT = ROWCOUNT + 2
                    'Else
                    '    SSQL = Chr(27) & "E"
                    '    Filewrite.WriteLine("To")
                    '    SSQL = SSQL & Mid(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"), 1, 6) & " : " & Space(6 - Len(Mid(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"), 1, 6))) & Space(2)
                    '    SSQL = SSQL & (gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORNAME"))
                    '    SSQL = SSQL & Space(15) & "Inventory: " & GLACIN
                    '    SSQL = SSQL & Chr(27) & "F"

                    '    Filewrite.Write(Chr(27) & "E")
                    '    Filewrite.WriteLine(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("ADDRESS"))
                    '    Filewrite.WriteLine(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("CITY"))
                    '    Filewrite.WriteLine(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("STATE"))
                    '    Filewrite.Write(Chr(27) & "F")

                    '    Filewrite.WriteLine(SSQL)
                    '    Filewrite.WriteLine()
                    '    ROWCOUNT = ROWCOUNT + 6
                    'End If

                    If Me.Chk_MC_Form.Checked = True Then
                        Filewrite.WriteLine(Space(30) & "KIND ATTN: ")
                        Filewrite.WriteLine("Dear Sirs,")
                        Filewrite.WriteLine()
                        ROWCOUNT = ROWCOUNT + 3

                        Dim bill As DataTable
                        Dim Loopindex As Integer
                        sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(txt_PONo.Text) & "' and DOCTYPE='SUBJECT' order by slno"
                        bill = gconnection.GetValues(sqlstring)
                        If bill.Rows.Count > 0 Then
                            Filewrite.Write("SUB:   ")
                            Loopindex = 0
                            For I = 0 To bill.Rows.Count - 1
                                Loopindex = Loopindex + 1
                                Filewrite.WriteLine(bill.Rows(I).Item("MESSAGE"))
                                ROWCOUNT = ROWCOUNT + 1
                            Next
                            Filewrite.WriteLine()
                            ROWCOUNT = ROWCOUNT + 1
                        End If
                        bill.Clear()
                        sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(txt_PONo.Text) & "' and DOCTYPE='REFERENCE' order by slno"
                        bill = gconnection.GetValues(sqlstring)
                        If bill.Rows.Count > 0 Then
                            Filewrite.Write("REF:   ")
                            Loopindex = 0
                            For I = 0 To bill.Rows.Count - 1
                                Loopindex = Loopindex + 1
                                Filewrite.WriteLine(bill.Rows(I).Item("MESSAGE"))
                                ROWCOUNT = ROWCOUNT + 1
                            Next
                            Filewrite.WriteLine()
                            ROWCOUNT = ROWCOUNT + 1
                        End If
                        bill.Clear()
                        sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(txt_PONo.Text) & "' and DOCTYPE='BODY' order by slno"
                        bill = gconnection.GetValues(sqlstring)
                        If bill.Rows.Count > 0 Then
                            Loopindex = 0
                            For I = 0 To bill.Rows.Count - 1
                                Loopindex = Loopindex + 1
                                Filewrite.WriteLine(Space(7) & bill.Rows(I).Item("MESSAGE"))
                                ROWCOUNT = ROWCOUNT + 1
                            Next
                            Filewrite.WriteLine()
                            ROWCOUNT = ROWCOUNT + 1
                        End If
                        bill.Clear()
                    End If

                    If Chk_MC_Form.Checked = False Then
                        Filewrite.Write(Chr(27) & "E" & "SUB : " & Chr(27) & "F" & "PURCHASE ORDER FOR FOLLOWING MATERIAL - REG. - ")
                        Filewrite.WriteLine(" FOR THE DEPARTMENT OF '" & cbo_dept.Text & "' ")
                        Filewrite.WriteLine()
                        Filewrite.WriteLine()
                        ROWCOUNT = ROWCOUNT + 3
                        Filewrite.WriteLine("PLEASE SUPPLY THE FOLLOWING MATERIAL AT THE EARLIEST: ")
                        Filewrite.WriteLine()
                        ROWCOUNT = ROWCOUNT + 3
                    End If
                    Filewrite.WriteLine(StrDup(88, "-"))
                    'Filewrite.WriteLine("NO.     ITEM DESCRIPTION " & Space(19) & "  RATE  " & Space(2) & " QTY    VAT   QTY*RATE+VAT- ")
                    'Filewrite.WriteLine("                         " & Space(19) & "        " & Space(2) & "              DISCOUNT(Rs.) ")
                    Filewrite.WriteLine("NO. CODE    ITEM DESCRIPTION " & Space(12) & " UOM       QTY     RATE DISC%  VAT %    GROSS ")
                    Filewrite.WriteLine(StrDup(88, "-"))
                    ROWCOUNT = ROWCOUNT + 3
                    VREF = True
                End If

                'SSQL = "SELECT isnull(discount,0) as discount,* FROM PO_ITEMDETAILS WHERE PONO = '" & txt_PONo.Text & "' "
                SSQL = "SELECT AUTOID,SUM(discount) as discount,ISNULL(PONO,'') AS PONO,ISNULL(ITEMCODE,'') AS ITEMCODE, "
                SSQL = SSQL & " ISNULL(QUANTITY,0) AS QUANTITY,ISNULL(REQUIREDDATE,'') AS REQUIREDDATE,ISNULL(RATE,0) AS RATE,"
                SSQL = SSQL & " ISNULL(VAT,0) AS VAT, ISNULL(TOTAL,0) AS TOTAL , ISNULL(AMOUNT,0) AMOUNT , ISNULL(DISCAMT,0) DISCAMT , ISNULL(VATAMT,0) VATAMT ,ISNULL(UOM,'') UOM"
                SSQL = SSQL & " FROM PO_ITEMDETAILS WHERE PONO = '" & txt_PONo.Text & "'"
                SSQL = SSQL & " GROUP BY AUTOID,PONO,ITEMCODE,QUANTITY,REQUIREDDATE,RATE,VAT,TOTAL,AMOUNT,DISCAMT,VATAMT,UOM ORDER BY AUTOID "
                vconn.getDataSet(SSQL, "PO_ITEMDETAILS")

                If gdataset.Tables("PO_ITEMDETAILS").Rows.Count > 0 Then
                    For j = 0 To gdataset.Tables("PO_ITEMDETAILS").Rows.Count - 1
                        ltotal = lqty = 0
                        ROWCOUNT = ROWCOUNT + 1
                        If ROWCOUNT > 58 Then
                            Filewrite.WriteLine(StrDup(88, "-"))
                            Filewrite.WriteLine(Chr(12))
                            PAGENO = PAGENO + 1
                            Call subPrintVoucherHeader("PURCHASE ORDER", 80)
                            Filewrite.WriteLine(StrDup(88, "-"))
                            ROWCOUNT = 6
                        End If
                        'adding rate + tax
                        rate = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE")
                        vat = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("VAT")
                        temp = rate * vat / 100
                        'ltotal = rate + temp
                        'ltotal = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("TOTAL")
                        ltotal = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("AMOUNT")
                        lqty = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("QUANTITY")
                        'Dim vattotal As Double
                        'vattotal = rate * lqty
                        'vattotal = (vattotal * vat) / 100
                        rate = 0 : vat = 0 : temp = 0
                        If gdataset.Tables("PO_ITEMDETAILS").Rows(j).IsNull("ITEMCODE") = False Then
                            'SL NO.
                            SSQL = Space(2 - Len(Mid(Format(j + 1, ""), 1, 2))) & Mid(Format(j + 1, ""), 1, 2) & " "
                            'ITEM NAME RETRIEVAL
                            SSQL1 = "SELECT * FROM PO_VIEW_ITEMMASTER WHERE ITEMCODE = '" & gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("ITEMCODE") & "' "
                            vconn.getDataSet(SSQL1, "INVENTORYITEMMASTER")

                            'ITEM CODE
                            SSQL = SSQL & gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("ITEMCODE") & Space(8 - Len(Trim(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("ITEMCODE"))))
                            'ITEM NAME
                            'SSQL = SSQL & Space(6)
                            SSQL = SSQL & Mid(gdataset.Tables("INVENTORYITEMMASTER").Rows(0).Item("ITEMNAME"), 1, 30) & Space(30 - Len(Mid(gdataset.Tables("INVENTORYITEMMASTER").Rows(0).Item("ITEMNAME"), 1, 30)))

                            'UOM
                            SSQL = SSQL & Space(1)
                            SSQL = SSQL & Space(5 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("UOM"), 1, 5))) & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("UOM"), 1, 5)

                            'QUANTITY
                            SSQL = SSQL & Space(1)
                            SSQL = SSQL & Space(7 - Len(Mid(Format(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("QUANTITY"), "0.000"), 1, 7))) & Mid(Format(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("QUANTITY"), "0.000"), 1, 7)

                            'RATE
                            SSQL = SSQL & Space(1)
                            SSQL = SSQL & Space(8 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE"), 1, 8))) & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE"), 1, 8)

                            'DISCOUNT
                            SSQL = SSQL & Space(1)
                            SSQL = SSQL & Space(5 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("DISCOUNT"), 1, 5))) & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("DISCOUNT"), 1, 5)

                            'VAT
                            SSQL = SSQL & Space(2)
                            SSQL = SSQL & Space(5 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("VAT"), 1, 5))) & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("VAT"), 1, 5)
                            'RATE
                            'SSQL = SSQL & Space(2)
                            SSQL = SSQL & Space(10 - Len(Mid(Format(ltotal, "##,##0.00"), 1, 10))) & Mid(Format(ltotal, "##,##0.00"), 1, 10) & " "
                            gtotal = gtotal + ltotal
                            'vattotal = Nothing
                            gqty = gqty + lqty
                            Filewrite.WriteLine(SSQL)
                        Else
                            SSQL = Space(60)
                        End If
                    Next j
                End If
                'FOR MINIMUM 10 BLANK LINES IN THE ITEM DETAILS SECTION    
                If gdataset.Tables("PO_ITEMDETAILS").Rows.Count < 10 Then
                    j = 0
                    j = gdataset.Tables("PO_ITEMDETAILS").Rows.Count
                    j = 10 - j
                    Dim K
                    For K = 0 To j
                        Filewrite.WriteLine()
                    Next
                End If

                'Dim povalue, ADVamt, totDiscnt As Double
                'povalue = Val(gdataset.Tables("PO_HDR").Rows(0).Item("POVALUE")) '- Val(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"))
                'Filewrite.WriteLine("TOTAL VALUE    : " & Space(10 - Len(Mid(Format(povalue, "0.00"), 1, 10))) & Mid(Format(povalue, "0.00"), 1, 10) & " ")
                'Filewrite.WriteLine("TOTAL VAT      : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"), "0.00"), 1, 10) & " ")
                'totDiscnt = Format(Val(gdataset.Tables("PO_HDR").Rows(0).Item("POOVERALLDISC")) + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALDISCOUNT")), "0.00")
                'Filewrite.WriteLine("TOTAL DISCOUNT : " & Space(10 - Len(Mid(Format(totDiscnt, "0.00"), 1, 10))) & Mid(Format(totDiscnt, "0.00"), 1, 10) & " ")
                'Filewrite.WriteLine("TOTAL ADVANCE  : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00"), 1, 10) & " ")
                'Filewrite.WriteLine("DELIVERY       : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"), "0.00"), 1, 10) & " ")
                'Filewrite.WriteLine("C & F          : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"), "0.00"), 1, 10) & " ")
                'Filewrite.WriteLine("TRANSPORT      : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"), "0.00"), 1, 10) & " ")
                'ADVamt = Format(povalue, "0.00") - Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00")
                'Filewrite.WriteLine("BALANCE AMOUNT : " & Space(10 - Len(Mid(Format(ADVamt, "0.00"), 1, 10))) & Mid(Format(ADVamt, "0.00"), 1, 10))
                'Filewrite.WriteLine("TOTAL DISCOUNT : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_ITEMDETAILS").Rows(0).Item("DISCOUNT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_ITEMDETAILS").Rows(0).Item("DISCOUNT"), "0.00"), 1, 10) & " ")
                'Filewrite.WriteLine("TOTAL DISCOUNT : " & Space(10 - Len(Mid(Format(discounttotal, "0.00"), 1, 10))) & Mid(Format(discounttotal, "0.00"), 1, 10) & " ")

                ROWCOUNT = ROWCOUNT + 4

                If gdataset.Tables("PO_HDR").Rows(0).IsNull("poremarks") = False Then
                    NARRATION = gdataset.Tables("PO_HDR").Rows(0).Item("poremarks")
                Else
                    NARRATION = ""
                End If
            End With

            Filewrite.WriteLine()
            If Len(NARRATION) > 0 Then
                intDescriptionLength = Split(Len(NARRATION) / intDescMaxLen, ".")(0)
                intDescriptionLength = intDescriptionLength + 1
                intStartIndex = 1
                intDescLenIndex = intDescMaxLen
                For j = 1 To intDescriptionLength
                    If j = 1 Then
                        Filewrite.Write("Narration : ")
                        strSpaceBefore = ""
                    Else
                        strSpaceBefore = Space(12)
                    End If
                    If j = intDescriptionLength Then
                        Filewrite.WriteLine(strSpaceBefore & Trim(Mid(Trim(NARRATION), intStartIndex, intDescMaxLen)) & Space((intDescMaxLen + 1) - Len(Trim(Mid(Trim(NARRATION), intStartIndex, intDescMaxLen)))) & strSpaceAfter)
                    Else
                        If Mid(NARRATION, intDescLenIndex, 1) = " " Then
                            Filewrite.WriteLine(strSpaceBefore & Trim(Mid(NARRATION, intStartIndex, intDescMaxLen)) & "- " & strSpaceAfter)
                        Else
                            Filewrite.WriteLine(strSpaceBefore & Trim(Mid(Trim(NARRATION), intStartIndex, intDescMaxLen)) & "-" & strSpaceAfter)
                        End If
                    End If
                    ROWCOUNT = ROWCOUNT + 1
                    intStartIndex = intStartIndex + intDescMaxLen
                    intDescLenIndex = intDescLenIndex + intDescMaxLen
                Next
            End If
        Else
            MsgBox("NO RECORD TO VIEW ", MsgBoxStyle.Information)
            Exit Sub
        End If

        Filewrite.WriteLine(StrDup(88, "-"))
        Filewrite.Write(Space(17) & Chr(27) & "E" & "TOTAL : " & Chr(27) & "F")
        Filewrite.Write(Space(20) & Space(10 - Len(Mid(Format(gqty, "0.000"), 1, 10))) & Mid(Format(gqty, "0.000"), 1, 10))
        Filewrite.Write(Space(20))
        Filewrite.WriteLine(Space(2) & Space(10 - Len(Mid(Format(gtotal, "##,##0.00"), 1, 10))) & Mid(Format(gtotal, "##,##0.00"), 1, 10))
        Filewrite.WriteLine(StrDup(88, "-"))



        SSQL = " SELECT * FROM PO_PAYMENTTERMS WHERE PAYMENTTERMCODE = '" & Txt_POTerms.Text & "' "
        vconn.getDataSet(SSQL, "PO_PAYMENTTERMS")
        SSQL = " SELECT * FROM PO_DELIVERYTERMS WHERE DELIVERYTERMCODE = '" & Txt_DeliveryTerms.Text & "' "
        vconn.getDataSet(SSQL, "PO_DELIVERYTERMS")
        SSQL = " SELECT * FROM PO_WARRANTYTERMS WHERE WARRANTYTERMCODE = '" & Txt_WarrantyCode.Text & "' "
        vconn.getDataSet(SSQL, "PO_WARRANTYTERMS")
        If Chk_MC_Form.Checked = True Then
            Filewrite.WriteLine("TERMS & CONDITIONS: ")
            Filewrite.WriteLine()
            Filewrite.WriteLine("#. TERMS OF PAYMENT  : " & gdataset.Tables("PO_PAYMENTTERMS").Rows(0).Item("PAYMENTTERMDESC"))
            Filewrite.WriteLine("#. TERMS OF DELIVERY : " & gdataset.Tables("PO_DELIVERYTERMS").Rows(0).Item("DELIVERYTERMDESC"))
            If gdataset.Tables("PO_WARRANTYTERMS").Rows.Count > 0 Then
                Filewrite.WriteLine("#. TERMS OF WARRANTY : " & gdataset.Tables("PO_WARRANTYTERMS").Rows(0).Item("WARRANTYTERMDESC"))
            End If
            ROWCOUNT = ROWCOUNT + 5
            If Trim(Txt_OtherTermCode.Text) <> "" Then
                Dim bill As DataTable
                Dim loop1, temp1 As Integer
                Dim Othertermcode(10), TextValue As String
                loop1 = 0
                TextValue = Trim(Me.Txt_OtherTermCode.Text)
                For I = 0 To Me.Txt_OtherTermCode.Text.Length - 1
                    If Me.Txt_OtherTermCode.Text.Chars(I) = "," Then
                        If loop1 = 0 Then
                            Othertermcode(loop1) = TextValue.Substring(0, I)
                            loop1 = loop1 + 1
                            temp1 = I
                        Else
                            Othertermcode(loop1) = TextValue.Substring(temp1 + 2, I)
                            loop1 = loop1 + 1
                            temp1 = I
                        End If
                    End If
                Next
                Filewrite.Write("#. OTHER TERMS       : ")
                For I = 0 To loop1
                    sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(Othertermcode(I)) & "' and DOCTYPE='OTHERTERMS' order by slno"
                    bill = gconnection.GetValues(sqlstring)
                    If bill.Rows.Count > 0 Then
                        For j = 0 To bill.Rows.Count - 1
                            Filewrite.WriteLine(Space(3) & bill.Rows(j).Item("MESSAGE"))
                            ROWCOUNT = ROWCOUNT + 1
                        Next j
                    End If
                    bill.Clear()
                Next I
                Filewrite.WriteLine()
                ROWCOUNT = ROWCOUNT + 1
            End If
        Else
            If gdataset.Tables("PO_PAYMENTTERMS").Rows(0).IsNull("PAYMENTTERMCODE") = False Then
                Filewrite.WriteLine(" PAYMENT TERMS  : " & gdataset.Tables("PO_PAYMENTTERMS").Rows(0).Item("PAYMENTTERMDESC"))
            Else
                Filewrite.WriteLine()
            End If
            If gdataset.Tables("PO_DELIVERYTERMS").Rows(0).IsNull("DELIVERYTERMCODE") = False Then
                Filewrite.WriteLine(" DELIVERY TERMS : " & gdataset.Tables("PO_DELIVERYTERMS").Rows(0).Item("DELIVERYTERMDESC"))
            Else
                Filewrite.WriteLine()
            End If
        End If

        Dim povalue, ADVamt, totDiscnt As Double
        povalue = Val(gdataset.Tables("PO_HDR").Rows(0).Item("POVALUE")) '- Val(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"))

        Filewrite.Write(Chr(27) & "E" & Space(60))
        Filewrite.WriteLine("TOTAL VAT      : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"), "##,##0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"), "##,##0.00"), 1, 10) & " ")
        totDiscnt = Format(Val(gdataset.Tables("PO_HDR").Rows(0).Item("POOVERALLDISC")) + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALDISCOUNT")), "0.00")
        Filewrite.Write(Space(60))
        Filewrite.WriteLine("TOTAL DISCOUNT : " & Space(10 - Len(Mid(Format(totDiscnt, "##,##0.00"), 1, 10))) & Mid(Format(totDiscnt, "##,##0.00"), 1, 10) & " ")
        Filewrite.Write(Space(60))
        Filewrite.WriteLine("DELIVERY       : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"), "##,##0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"), "##,##0.00"), 1, 10) & " ")
        Filewrite.Write(Space(60))
        Filewrite.WriteLine("C & F          : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"), "##,##0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"), "0.00"), 1, 10) & " ")
        Filewrite.Write(Space(60))
        Filewrite.WriteLine("TRANSPORT      : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"), "##,##0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"), "##,##0.00"), 1, 10) & " ")

        If (Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00")) <> "0.00" Then
            Filewrite.Write(Space(60))
            Filewrite.WriteLine("TOTAL ADVANCE  : " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "##,##0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "##,##0.00"), 1, 10) & " ")
        End If
        ADVamt = Format(povalue, "0.00") - Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00")
        If (Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00")) <> "0.00" Then
            Filewrite.Write(Space(60))
            Filewrite.WriteLine("BALANCE AMOUNT : " & Space(10 - Len(Mid(Format(ADVamt, "##,##0.00"), 1, 10))) & Mid(Format(ADVamt, "##,##0.00"), 1, 10))
        End If
        povalue = Val(gdataset.Tables("PO_HDR").Rows(0).Item("POVALUE")) '- Val(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"))
        Filewrite.Write(Space(60))
        Filewrite.WriteLine("TOTAL VALUE    : " & Space(10 - Len(Mid(Format(povalue, "0.00"), 1, 10))) & Mid(Format(povalue, "##,##0.00"), 1, 10) & " ")
        Filewrite.Write(Chr(27) & "F" & Space(60))

        For I = 0 To 11
            Filewrite.WriteLine()
        Next
        If Chk_MC_Form.Checked = False Then
            Call subPrintVoucherFooter1(88, PAGENO)
        Else
            Filewrite.WriteLine("Thanking you,")
            Filewrite.WriteLine()
            Filewrite.WriteLine("Yours sincerly,")
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            'Filewrite.WriteLine("E.RAJENDER KUMAR")
            'Filewrite.WriteLine(" Hon. Secretary")
        End If

        Filewrite.WriteLine(Chr(12))
        Filewrite.Close()
        If gPrint = False Then
            OpenTextFile(vOutfile)
        Else
            PrintTextFile1(VFilePath)
            OpenTextFile(vOutfile)
        End If
    End Sub
    Private Sub Txt_footer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_footer.KeyPress
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
    Public Sub subPrintVoucherFooter1(ByVal intLength As Int16, ByVal INTPAGENO As Integer)
        Dim strFoot As String

        ssql = "Select P.PONO,isnull(UPDFOOTER,'') as UPDFOOTER,isnull(UPDsign,'') as UPDsign"
        ssql = ssql & " from PO_HDR P "
        ssql = ssql & " where isnull(FREEZE,'')<>'Y'   AND P.PONO = '" & Trim(txt_PONo.Text) & "' "
        vconn.getDataSet(ssql, "PO_HDR")
        If gdataset.Tables("PO_HDR").Rows.Count > 0 And gdataset.Tables("PO_HDR").Rows(0).Item("UPDFOOTER") <> "" Then
            Filewrite.WriteLine(Space(8) & gdataset.Tables("PO_HDR").Rows(0).Item("UPDFOOTER"))
        Else
            Filewrite.WriteLine(Space(8) & "Store keeper" & Space(15) & "Asst. Manager Purchase" & Space(10) & "       Secretary      ")
        End If
        'Filewrite.WriteLine(Space(57) & "  For Secunderabad Club   ")

        'strFoot = "User :- " & gUsername & Space(((intLength / 2) - 5) - Len("USER :- " & gUsername))
        'strFoot = strFoot & Space(intLength - (Len(strFoot) + 22)) & CStr(Format(DateValue(Now()), "dd/MMM/yyyy")) & " " & Trim(Now.ToShortTimeString()) & Chr(12)
        Filewrite.WriteLine()
        Filewrite.WriteLine(strFoot)
        'ssql = Space(38)
        'ssql = ssql & "PAGE NO. : " & INTPAGENO
        'Filewrite.WriteLine(ssql)
    End Sub
    Private Sub Txt_signature_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_signature.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Chk_item.Focus()
        End If
    End Sub
    Public Function FOOTER()
        '    sqlstring = "SELECT isnull(UPDFOOTER,'') as UPDFOOTER,isnull(UPDsign,'') as UPDsign FROM PO_HDR WHERE  AUTOID IN (SELECT MAX(AUTOID) FROM PO_HDR where podepartment = '" & Trim(cbo_warehouse.Text) & "')"
        '    gconnection.getDataSet(sqlstring, "PO_HDR")
        '    If gdataset.Tables("PO_HDR").Rows.Count > 0 Then
        '        Txt_footer.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("UPDFOOTER"))
        '        Txt_signature.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("UPdsign"))
        '    End If
    End Function


    Private Sub cmddochelp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmddochelp.Click
        Try
            gSQLString = "SELECT docdetails,docdate,IndentNo FROM PO_STOCKINDENTAUTH_HDR WHERE "
            M_WhereCondition = " docdetails IN ( SELECT docdetails FROM po_quationinvitation WHERE ISNULL(APPROVED,'')='Y') "
            Dim vform As New ListOperattion1_N
            vform.Field = "DOCDETAILS,DOCDATE,IndentNo"
            vform.vFormatstring = "       DOC NO            |         DOC DATE   | INDENTNO                                                        "
            vform.vCaption = "AUTHORIZED INDENT  NO HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_docno.Text = Trim(vform.keyfield & "")
                ssgrid.ClearRange(1, 1, -1, -1, True)
                Call txt_docno_Validated(txt_docno, e)

            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_docno_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txt_docno.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_docno.Text) = "" Then
                    Call cmddochelp_Click(cmddochelp, e)
                Else
                    txt_docno_Validated(txt_docno, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub



    Private Sub txt_docno_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles txt_docno.Validated
        Dim j, i As Integer
        Dim dt As New DataTable
        Dim vString, sqlstring, VSTRDOCNO As String
        Dim vTypeseqno, Clsquantity, vGroupseqno As Double
        If Trim(txt_docno.Text) <> "" Then
            Try

                sqlstring = " SELECT auth_docno FROM PO_HDR WHERE auth_docno='" & txt_docno.Text & "' AND ISNULL(FREEZE,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "INDENTVAL")
                If gdataset.Tables("INDENTVAL").Rows.Count > 0 Then
                    MessageBox.Show("THIS DOCNO HAD BEEN PROCESSED ALREADY")
                    txt_docno.Focus()
                    txt_docno.Text = ""
                    Exit Sub
                End If


                sqlstring = "SELECT ISNULL(H.DOCDETAILS,'') AS DOCDETAILS,H.DOCDATE AS DOCDATE,H.INDENTNO INDENTNO, H.INDENTDATE AS INDENTDATE, "
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONCODE,'') AS STORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.STORELOCATIONNAME,'') AS STORELOCATIONNAME,ISNULL(H.OPSTORELOCATIONCODE,'') AS OPSTORELOCATIONCODE,"
                sqlstring = sqlstring & " ISNULL(H.OPSTORELOCATIONNAME,'') AS OPSTORELOCATIONNAME,ISNULL(H.TOTALAMT,0) AS TOTALAMT,ISNULL(H.REMARKS,'') AS REMARKS,"
                sqlstring = sqlstring & " ISNULL(H.VOID,'') AS VOID,ISNULL(H.VOIDREASON,'') AS VOIDREASON,ISNULL(H.ADDUSER,'') AS ADDUSER,ADDDATE,ISNULL(H.UPDATEUSER,'') AS UPDATEUSER,UPDATETIME,ISNULL(H.UPDFOOTER,'') AS UPDFOOTER,ISNULL(H.UPDSIGN,'') AS UPDSIGN,ISNULL(AUTHRZEBY,'') AS AUTHRZEBY,ISNULL(AUTHRZEDATE,'') AS AUTHRZEDATE"
                sqlstring = sqlstring & " FROM PO_STOCKINDENTAUTH_HDR AS H WHERE DOCNO='" & Trim(txt_docno.Text) & "'OR DOCDETAILS='" & Trim(txt_docno.Text) & "' "
                gconnection.getDataSet(sqlstring, "STOCKISSUEHEADER")
                '''************************************************* SELECT RECORD FROM STOCKISSUEHEADER *********************************************''''                
                If gdataset.Tables("STOCKISSUEHEADER").Rows.Count > 0 Then
                    'CmdAdd.Text = "Update[F7]"
                    Me.txt_docno.ReadOnly = True
                    VSTRDOCNO = Trim(txt_docno.Text)
                    txt_docno.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("DOCDETAILS") & "")
                    cbo_dept.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("STORELOCATIONCODE"))
                    Cbo_Approvedby.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("AUTHRZEBY"))
                    ' cmb_approvedby.DropDownStyle = ComboBoxStyle.DropDownList                  
                    Txt_Remarks.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("REMARKS"))
                    Txt_footer.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("UPDFOOTER"))
                    Txt_signature.Text = Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("UPDSIGN"))
                    If gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("VOID") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(CDate(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("ADDDATE")), "dd-MMM-yyyy")
                        Me.CmdFreeze.Enabled = False
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.CmdFreeze.Enabled = True
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.CmdFreeze.Text = "Void[F8]"
                    End If
                    If Trim(gdataset.Tables("STOCKISSUEHEADER").Rows(0).Item("VOID")) = "Y" Then
                        CmdAdd.Enabled = False
                        CmdFreeze.Enabled = False
                    End If
                    'Sqlstr = "SELECT AUTH1 as memimage FROM PO_STOCKINDENTAUTH_HDR WHERE DOCDETAILS='" & Trim(txt_docno.Text) & "' "
                    'LoadFoto_DB(Sqlstr, Pic_auth1)
                    'Sqlstr = "SELECT AUTH2 as memimage FROM PO_STOCKINDENTAUTH_HDR WHERE DOCDETAILS='" & Trim(txt_docno.Text) & "' "
                    'LoadFoto_DB(Sqlstr, Pic_auth2)
                    sqlstring = " SELECT  DOCDETAILS,QUOTNO,APPROVED,SUPPLIERCODE,SUPPLIERNAME  FROM po_quationinvitation WHERE ISNULL(APPROVED,'')='Y' AND  DOCDETAILS ='" & Trim(txt_docno.Text) & "' "
                    gconnection.getDataSet(sqlstring, "QUOTNO")
                    If gdataset.Tables("QUOTNO").Rows.Count > 0 Then
                        Txt_QuotNo.Text = Trim(gdataset.Tables("QUOTNO").Rows(0).Item("QUOTNO") & "")
                        Txt_Vcode.Text = Trim(gdataset.Tables("QUOTNO").Rows(0).Item("SUPPLIERCODE") & "")
                        Txt_Vname.Text = Trim(gdataset.Tables("QUOTNO").Rows(0).Item("SUPPLIERNAME") & "")
                    End If
                    ' '''************************************************* SELECT RECORD FROM STOCKISSUEDETAILS *********************************************''''                
                    Dim strsql As String
                    Dim STRITEMCODE, STRITEMUOM As String
                    sqlstring = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM,ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE ,"
                    sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT,ISNULL(DBLAMT,0) AS DBLAMT,ISNULL(DBLCONV,'') AS DBLCONV,ISNULL(HIGHRATIO,0) AS HIGHRATIO,"
                    sqlstring = sqlstring & " ISNULL(GROUPCODE,'') AS GROUPCODE,ISNULL(SUBGROUPCODE,'') AS SUBGROUPCODE FROM PO_STOCKINDENTAUTH_DET WHERE  DOCDETAILS ='" & Trim(txt_docno.Text) & "' ORDER BY AUTOID"
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
                            ' ssgrid.SetText(12, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("QTY")), "0.000"))
                            ssgrid.SetText(6, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("RATE")), "0.00"))
                            ssgrid.SetText(9, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("AMOUNT")), "0.00"))
                            ssgrid.SetText(7, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("DBLAMT")), "0.000"))
                            ssgrid.SetText(8, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("HIGHRATIO")), "0.000"))
                            'ssgrid.SetText(9, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("HIGHRATIO")), "0.00"))
                            'ssgrid.SetText(10, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("GROUPCODE")))
                            ssgrid.SetText(10, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("AMOUNT")), "0.00"))
                            ssgrid.SetText(11, i, Format(Val(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("DBLAMT")), "0.000"))
                            'ssgrid.SetText(11, i, Trim(gdataset.Tables("STOCKISSUEDETAILSALL").Rows(j).Item("SUBGROUPCODE")))
                            'Clsquantity = ClosingQuantity(STRITEMCODE, "MNS")
                            Dim ISSDATE As Date
                            '   ISSDATE = Format(CDate(dtp_Docdate.Value), "dd-MMM-yyyy")
                            'Clsquantity = ClosingQuantity_Date(STRITEMCODE, Trim(txt_Mainstorecode.Text), STRITEMUOM, ISSDATE)
                            ssgrid.SetText(13, i, Clsquantity)
                            j = j + 1


                        Next
                    End If
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                    ssgrid.SetActiveCell(1, 1)
                    Call GRIDCALCULATION()
                    Dim U As System.EventArgs
                    Call ssgrid_Leave(ssgrid.Text, U)

                End If

            Catch ex As Exception
                MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub cmd_export_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmd_export.Click
        Dim sqlstring As String
        Dim _export As New EXPORT
        _export.TABLENAME = "VW_PO_POBILL"
        sqlstring = "select * from VW_PO_POBILL  "
        Call _export.export_excel(sqlstring)
        _export.Show()
        Exit Sub
    End Sub

    Private Sub cmd_auth_Click(ByVal sender As Object, ByVal e As EventArgs)
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
            SSQLSTR2 = " SELECT * FROM PO_HDR WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM PO_HDR WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE PO_HDR set  ", "PONO", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM PO_HDR WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM PO_HDR WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE PO_HDR set  ", "PONO", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            End If
        ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM PO_HDR WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM PO_HDR WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE PO_HDR set  ", "PONO", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                        End If
                    End If
                End If
            Else
                MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Txt_ED_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_ED.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(Txt_ED.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            Txt_ED.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub Txt_CST_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_CST.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(Txt_CST.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            Txt_CST.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub Txt_MODVat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_MODVat.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(Txt_MODVat.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            Txt_MODVat.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub Txt_PTax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_PTax.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(Txt_PTax.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            Txt_PTax.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub Txt_Octra_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Octra.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(Txt_Octra.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            Txt_Octra.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub Txt_Insurance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Insurance.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(Txt_Insurance.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            Txt_Insurance.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub Txt_LST_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_LST.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(Txt_LST.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            Txt_LST.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub Txt_AdvanceAmt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_AdvanceAmt.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(Txt_AdvanceAmt.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            Txt_AdvanceAmt.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub TXT_CF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CF.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(TXT_CF.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            TXT_CF.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub Txt_TotalTax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_TotalTax.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(Txt_TotalTax.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            Txt_TotalTax.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub TXT_TRANSPORT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_TRANSPORT.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(TXT_TRANSPORT.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            TXT_TRANSPORT.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub Txt_TotalVat_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_TotalVat.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(Txt_TotalVat.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            Txt_TotalVat.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub TXT_DELIVERY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_DELIVERY.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(TXT_DELIVERY.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            TXT_DELIVERY.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub Txt_Balance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Balance.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(Txt_Balance.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            Txt_Balance.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub Txt_POValue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_POValue.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(Txt_POValue.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            Txt_POValue.Text = ""
            Exit Sub
        ElseIf TXT_ADVANCEPERC.Text <> "" Then
            Txt_AdvanceAmt.Text = Math.Round((Val(Txt_POValue.Text) * Val(TXT_ADVANCEPERC.Text)) / 100)
        End If
    End Sub

    Private Sub TXT_OVERALLDISC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_OVERALLDISC.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(TXT_OVERALLDISC.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            TXT_OVERALLDISC.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub TXT_GROSSVALUE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(TXT_GROSSVALUE.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            TXT_GROSSVALUE.Text = ""
            Exit Sub
        End If
    End Sub

    Private Sub txt_SalesTax_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_SalesTax.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Me.txt_MOD.Focus()
        End If
    End Sub

    Private Sub txt_MOD_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_MOD.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Me.TXT_DOCTHROUGH.Focus()
        End If
    End Sub

    Private Sub TXT_DOCTHROUGH_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_DOCTHROUGH.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Me.Txt_AdvanceAmt.Focus()
        End If
    End Sub

    Private Sub TXT_ADVANCEPERC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_ADVANCEPERC.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Format(Val(TXT_ADVANCEPERC.Text), "0.00") > 100 Then
                MsgBox("PERCENTAGE SHOULD BE LESS THAN 100")
                TXT_ADVANCEPERC.Text = ""
                TXT_ADVANCEPERC.Focus()
                Exit Sub
            End If
            'Call ssgrid_Leave(sender, e)
            Txt_POTerms.Focus()
        End If
    End Sub
    Private Sub Resize_Form()
        Dim cControl As Control
        Dim i_i As Integer
        Dim J, K, L, M, n, o, P, Q, R, S, T, U As Integer
        'If (Screen.PrimaryScreen.Bounds.Height = 768) And (Screen.PrimaryScreen.Bounds.Width = 1366) Then
        '    Exit Sub
        'End If
        J = 728
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
                        If Controls(i_i).Name = "GroupBox4" Then
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

    Private Sub CmdExit_Click_1(sender As Object, e As EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub

    Private Sub chk_amnd_foll_CheckedChanged1(sender As Object, e As EventArgs) Handles chk_amnd_foll.CheckedChanged
        If chk_amnd_foll.Checked = True Then
            'ssgrid.SendToBack()
            'GroupBox7.Controls.Add(ssgrid)
            'ssgrid.Location = New Point(100, 90)
            GroupBox7.Controls.Add(AmendmentGrid)
            AmendmentGrid.Location = New Point(1, 1)
            
        ElseIf chk_amnd_foll.Checked = False Then
            AmendmentGrid.Visible = False
        End If
      
    End Sub

    Private Sub ssgrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid.Advance

    End Sub

    Private Sub CMD_BROWSE_Click(sender As Object, e As EventArgs) Handles CMD_BROWSE.Click
        'Dim FRM As New ReportDesigner
        'If txt_docno.Text.Length > 0 Then
        '    tables = " FROM VW_PO_POBILL WHERE PONO ='" & txt_PONo.Text & "' "
        'Else
        '    tables = "FROM VW_PO_POBILL"
        'End If
        'Gheader = "PURCHASE ORDER DETAILS"
        'FRM.DataGridView1.ColumnCount = 2
        'FRM.DataGridView1.Columns(0).Name = "COLUMN NAME"
        'FRM.DataGridView1.Columns(0).Width = 300
        'FRM.DataGridView1.Columns(1).Name = "SIZE"
        'FRM.DataGridView1.Columns(1).Width = 100

        'Dim ROW As String() = New String() {"PONO", "10"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"PODATE", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"INDENTNO", "5"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"INDENTDATE", "9"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"SUPPLIERCODE", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"SUPPLIERNAME", "12"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"AUTH_DOCNO", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"QUOTNO", "12 "}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"DEPARTMENT", "6 "}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"APPROVEDBY", "8"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"POSTATUS", "8"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"POTOTAL", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"TOT_VAT", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"TOT_TAX", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"TOT_DISCOUNT", "10"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"ADVANCE", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"overalldisc", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"POTRANSPORT", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"POCF", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"POTRANSPORT", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"PODELIVERYAMT", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"PAYMENTTERMS", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"POREMARKS", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"DELIVERYTERMS", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"ADDRESS", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"CITY", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"STATE", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"MOBILENO", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"PINCODE", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"EMAIL", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"ITEMCODE", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"ITEMNAME", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"QTY", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"RATE", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"DISCOUNT", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"VATAMT", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"VAT", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"TOTAL", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"DISCAMT", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"AMOUNT", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"poed", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"pocst", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"pomodvat", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"poptax", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"pooctra", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"poinsurance", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"polst", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        ''
        'ROW = New String() {"POADVPERC", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"TINNO", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"PANNO", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"posalet", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"podespmode", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"podocsthrough", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)

        'Dim CHK As New DataGridViewCheckBoxColumn()
        ''Dim CHK As New VIEWHDR
        'FRM.DataGridView1.Columns.Insert(0, CHK)
        'CHK.HeaderText = "CHECK"
        'CHK.Name = "CHK"
        'FRM.ShowDialog(Me)
        Dim obj1 As New VIEWHDR
        Dim sqlstr As String
        Dim childsql As String
        sqlstr = "SELECT [pono] ,[DOCTYPE] ,auth_docno,[podate] ,[poquotno] ,h.[povendorcode],v.vendorname ,[podepartment] ,[poapprovedby] ,[poapproveddate],"
        sqlstr = sqlstr & "[postatus] ,[poed] ,[pocst],[pomodvat] ,[poptax] ,[pooctra] ,[poinsurance] ,[polst] ,[povalue] ,[pototalvat] ,[pototaltax] ,"
        sqlstr = sqlstr & "[pototaldiscount],[poadvance] ,[pobalance] ,[poterms],[podeliveryterms] , [pomcpo], [powarrantyterms] , [pootherterms] , "
        sqlstr = sqlstr & "[podespatch] ,[poshipping] ,[podelivery] ,[pocreditdays],[poencl] ,[poremarks] ,[poclosure] , [pofreight], [pocstform], "
        sqlstr = sqlstr & " h.[freeze] ,h.[adduser] ,h.[adddatetime],[POOVERALLDISC],[POCF],[POTRANSPORT],[PODELIVERYAMT],[POGLACIN],[UPDsign],[UPDFOOTER],"
        sqlstr = sqlstr & " [POSALET],[PODESPMODE],[PODOCSTHROUGH]  from PO_HDR h, [PO_VIEW_VENDORMASTER] v "
        sqlstr = sqlstr & "where v.vendorcode=h.povendorcode and h.freeze<>'Y' order by pono,PODATE"
        'childsql = "select  PONO,auth_doc,p.ITEMCODE,v.itemname,UOM,QUANTITY,RATE,DISCOUNT,VAT,TOTAL,amount,DiscAmt,VatAmt from PO_ITEMDETAILS p, view_item v  where p.itemcode=v.itemcode"
        childsql = "select * from po_browse_itemdetails "
        gconnection.getDataSet(sqlstr, "PO_HDR")
        obj1.LOADGRID(gdataset.Tables("PO_HDR"), True, "PurchaseOrder_SC", childsql, "pono", 1)
        obj1.Show()
    End Sub
End Class