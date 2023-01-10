Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class PO_HireOrder
    Inherits System.Windows.Forms.Form
    Dim VCONN As New GlobalClass
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
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents dtp_Excisepassdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Supplierinvno As System.Windows.Forms.Label
    Friend WithEvents lbl_Supplierinvdate As System.Windows.Forms.Label
    Friend WithEvents lbl_Excisepassno As System.Windows.Forms.Label
    Friend WithEvents lbl_Excisepassdate As System.Windows.Forms.Label
    Friend WithEvents txt_Totalamt As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents lbl_Suppliercode As System.Windows.Forms.Label
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents txt_Discountamt As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Suppliercodehelp As System.Windows.Forms.Button
    Friend WithEvents txt_Excisepassno As System.Windows.Forms.TextBox
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents cbo_Storelocation As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_Supplierinvdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Creditdays As System.Windows.Forms.Label
    Friend WithEvents lbl_Grn As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdValueby As System.Windows.Forms.Button
    Friend WithEvents OptPercentage As System.Windows.Forms.RadioButton
    Friend WithEvents OptValue As System.Windows.Forms.RadioButton
    Friend WithEvents txtChangeValue As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRoundoff As System.Windows.Forms.Button
    Friend WithEvents OptNearest As System.Windows.Forms.RadioButton
    Friend WithEvents OptNone As System.Windows.Forms.RadioButton
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents grp_StockGrndetails As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_StockGrndetails As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_StockGrnprint As System.Windows.Forms.Button
    Friend WithEvents Cmd_StockGrnView As System.Windows.Forms.Button
    Friend WithEvents Cmd_StockGrnexit As System.Windows.Forms.Button
    Friend WithEvents Cmd_StockGrnClear As System.Windows.Forms.Button
    Friend WithEvents grp_Billingdetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grp_Excisedetails As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Suppliercode As System.Windows.Forms.TextBox
    Friend WithEvents txt_Suppliername As System.Windows.Forms.TextBox
    Friend WithEvents txt_Supplierinvno As System.Windows.Forms.TextBox
    Friend WithEvents txt_Trucknumber As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Stockindate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Trucknumber As System.Windows.Forms.Label
    Friend WithEvents lbl_Stockindate As System.Windows.Forms.Label
    Friend WithEvents ssgrid_billdetails As AxFPSpreadADO.AxfpSpread
    Friend WithEvents ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Cmd_ToDocno As System.Windows.Forms.Button
    Friend WithEvents Cmd_FromDocno As System.Windows.Forms.Button
    Friend WithEvents txt_ToDocno As System.Windows.Forms.TextBox
    Friend WithEvents txt_FromDocno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ToDocno As System.Windows.Forms.Label
    Friend WithEvents lbl_FromDocno As System.Windows.Forms.Label
    Friend WithEvents lbl_Surchargeamt As System.Windows.Forms.Label
    Friend WithEvents lbl_Billamount As System.Windows.Forms.Label
    Friend WithEvents txt_Surchargeamt As System.Windows.Forms.TextBox
    Friend WithEvents txt_Billamount As System.Windows.Forms.TextBox
    Friend WithEvents cmd_print As System.Windows.Forms.Button
    Friend WithEvents txt_StoreDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXT_OVERALLdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Txt_footer As System.Windows.Forms.TextBox
    Friend WithEvents Txt_signature As System.Windows.Forms.TextBox
    Friend WithEvents grp_footer As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dtp_Hodate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Hodate As System.Windows.Forms.Label
    Friend WithEvents lbl_Hono As System.Windows.Forms.Label
    Friend WithEvents txt_Hono As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fromdate As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents LBL_TODATE As System.Windows.Forms.Label
    Friend WithEvents dtp_frmdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_todate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_Honohelp As System.Windows.Forms.Button
    Friend WithEvents HO_Indentno As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PO_HireOrder))
        Me.cmd_Honohelp = New System.Windows.Forms.Button
        Me.dtp_Excisepassdate = New System.Windows.Forms.DateTimePicker
        Me.txt_Totalamt = New System.Windows.Forms.TextBox
        Me.txt_Remarks = New System.Windows.Forms.TextBox
        Me.lbl_Remarks = New System.Windows.Forms.Label
        Me.lbl_Suppliercode = New System.Windows.Forms.Label
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmd_print = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.dtp_Hodate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.lbl_Supplierinvno = New System.Windows.Forms.Label
        Me.lbl_Hodate = New System.Windows.Forms.Label
        Me.lbl_Hono = New System.Windows.Forms.Label
        Me.txt_Discountamt = New System.Windows.Forms.TextBox
        Me.cmd_Suppliercodehelp = New System.Windows.Forms.Button
        Me.cbo_Storelocation = New System.Windows.Forms.ComboBox
        Me.lbl_Supplierinvdate = New System.Windows.Forms.Label
        Me.lbl_Excisepassno = New System.Windows.Forms.Label
        Me.lbl_Excisepassdate = New System.Windows.Forms.Label
        Me.dtp_Supplierinvdate = New System.Windows.Forms.DateTimePicker
        Me.txt_Excisepassno = New System.Windows.Forms.TextBox
        Me.lbl_Creditdays = New System.Windows.Forms.Label
        Me.lbl_Grn = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdRoundoff = New System.Windows.Forms.Button
        Me.OptNearest = New System.Windows.Forms.RadioButton
        Me.OptNone = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdValueby = New System.Windows.Forms.Button
        Me.OptPercentage = New System.Windows.Forms.RadioButton
        Me.OptValue = New System.Windows.Forms.RadioButton
        Me.txtChangeValue = New System.Windows.Forms.TextBox
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.grp_StockGrndetails = New System.Windows.Forms.GroupBox
        Me.lbl_StockGrndetails = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Cmd_StockGrnprint = New System.Windows.Forms.Button
        Me.Cmd_StockGrnView = New System.Windows.Forms.Button
        Me.Cmd_StockGrnexit = New System.Windows.Forms.Button
        Me.Cmd_StockGrnClear = New System.Windows.Forms.Button
        Me.lbl_FromDocno = New System.Windows.Forms.Label
        Me.txt_FromDocno = New System.Windows.Forms.TextBox
        Me.Cmd_FromDocno = New System.Windows.Forms.Button
        Me.txt_ToDocno = New System.Windows.Forms.TextBox
        Me.Cmd_ToDocno = New System.Windows.Forms.Button
        Me.lbl_ToDocno = New System.Windows.Forms.Label
        Me.grp_Billingdetails = New System.Windows.Forms.GroupBox
        Me.ssgrid_billdetails = New AxFPSpreadADO.AxfpSpread
        Me.Label2 = New System.Windows.Forms.Label
        Me.grp_Excisedetails = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_Trucknumber = New System.Windows.Forms.TextBox
        Me.dtp_Stockindate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Trucknumber = New System.Windows.Forms.Label
        Me.lbl_Stockindate = New System.Windows.Forms.Label
        Me.txt_Suppliercode = New System.Windows.Forms.TextBox
        Me.txt_Suppliername = New System.Windows.Forms.TextBox
        Me.txt_Hono = New System.Windows.Forms.TextBox
        Me.txt_Supplierinvno = New System.Windows.Forms.TextBox
        Me.ssgrid = New AxFPSpreadADO.AxfpSpread
        Me.lbl_Surchargeamt = New System.Windows.Forms.Label
        Me.lbl_Billamount = New System.Windows.Forms.Label
        Me.txt_Surchargeamt = New System.Windows.Forms.TextBox
        Me.txt_Billamount = New System.Windows.Forms.TextBox
        Me.txt_StoreDesc = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TXT_OVERALLdiscount = New System.Windows.Forms.TextBox
        Me.grp_footer = New System.Windows.Forms.GroupBox
        Me.Txt_signature = New System.Windows.Forms.TextBox
        Me.Txt_footer = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.HO_Indentno = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.lbl_fromdate = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.dtp_todate = New System.Windows.Forms.DateTimePicker
        Me.dtp_frmdate = New System.Windows.Forms.DateTimePicker
        Me.LBL_TODATE = New System.Windows.Forms.Label
        Me.frmbut.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grp_StockGrndetails.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.grp_Billingdetails.SuspendLayout()
        CType(Me.ssgrid_billdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Excisedetails.SuspendLayout()
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_footer.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_Honohelp
        '
        Me.cmd_Honohelp.Image = CType(resources.GetObject("cmd_Honohelp.Image"), System.Drawing.Image)
        Me.cmd_Honohelp.Location = New System.Drawing.Point(344, 16)
        Me.cmd_Honohelp.Name = "cmd_Honohelp"
        Me.cmd_Honohelp.Size = New System.Drawing.Size(23, 26)
        Me.cmd_Honohelp.TabIndex = 24
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
        'txt_Totalamt
        '
        Me.txt_Totalamt.BackColor = System.Drawing.Color.Wheat
        Me.txt_Totalamt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Totalamt.Enabled = False
        Me.txt_Totalamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Totalamt.Location = New System.Drawing.Point(800, 528)
        Me.txt_Totalamt.MaxLength = 15
        Me.txt_Totalamt.Name = "txt_Totalamt"
        Me.txt_Totalamt.ReadOnly = True
        Me.txt_Totalamt.Size = New System.Drawing.Size(104, 22)
        Me.txt_Totalamt.TabIndex = 0
        Me.txt_Totalamt.Text = ""
        Me.txt_Totalamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Remarks
        '
        Me.txt_Remarks.BackColor = System.Drawing.Color.White
        Me.txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(88, 24)
        Me.txt_Remarks.MaxLength = 200
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(456, 32)
        Me.txt_Remarks.TabIndex = 14
        Me.txt_Remarks.Text = ""
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AutoSize = True
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.Location = New System.Drawing.Point(8, 24)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(78, 18)
        Me.lbl_Remarks.TabIndex = 43
        Me.lbl_Remarks.Text = "REMARKS :"
        '
        'lbl_Suppliercode
        '
        Me.lbl_Suppliercode.AutoSize = True
        Me.lbl_Suppliercode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Suppliercode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Suppliercode.Location = New System.Drawing.Point(48, 24)
        Me.lbl_Suppliercode.Name = "lbl_Suppliercode"
        Me.lbl_Suppliercode.Size = New System.Drawing.Size(124, 18)
        Me.lbl_Suppliercode.TabIndex = 28
        Me.lbl_Suppliercode.Text = "SUPPLIER CODE  :"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.Button1)
        Me.frmbut.Controls.Add(Me.cmd_print)
        Me.frmbut.Controls.Add(Me.Cmd_Exit)
        Me.frmbut.Location = New System.Drawing.Point(56, 632)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(872, 56)
        Me.frmbut.TabIndex = 44
        Me.frmbut.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(616, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Validation"
        '
        'cmd_print
        '
        Me.cmd_print.BackColor = System.Drawing.Color.Transparent
        Me.cmd_print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_print.ForeColor = System.Drawing.Color.Black
        Me.cmd_print.Location = New System.Drawing.Point(360, 16)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(104, 32)
        Me.cmd_print.TabIndex = 14
        Me.cmd_print.Text = "Print [F10]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Exit.Location = New System.Drawing.Point(752, 16)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 15
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'dtp_Hodate
        '
        Me.dtp_Hodate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Hodate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_Hodate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_Hodate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Hodate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Hodate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Hodate.Location = New System.Drawing.Point(568, 16)
        Me.dtp_Hodate.Name = "dtp_Hodate"
        Me.dtp_Hodate.Size = New System.Drawing.Size(120, 26)
        Me.dtp_Hodate.TabIndex = 3
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(384, 32)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(161, 29)
        Me.lbl_Heading.TabIndex = 21
        Me.lbl_Heading.Text = "HIRE ORDER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(432, 72)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(200, 25)
        Me.lbl_Freeze.TabIndex = 47
        Me.lbl_Freeze.Text = "Record Void  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'lbl_Supplierinvno
        '
        Me.lbl_Supplierinvno.AutoSize = True
        Me.lbl_Supplierinvno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Supplierinvno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Supplierinvno.Location = New System.Drawing.Point(104, 56)
        Me.lbl_Supplierinvno.Name = "lbl_Supplierinvno"
        Me.lbl_Supplierinvno.Size = New System.Drawing.Size(68, 18)
        Me.lbl_Supplierinvno.TabIndex = 26
        Me.lbl_Supplierinvno.Text = "QUT. NO :"
        '
        'lbl_Hodate
        '
        Me.lbl_Hodate.AutoSize = True
        Me.lbl_Hodate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hodate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Hodate.Location = New System.Drawing.Point(472, 24)
        Me.lbl_Hodate.Name = "lbl_Hodate"
        Me.lbl_Hodate.Size = New System.Drawing.Size(71, 18)
        Me.lbl_Hodate.TabIndex = 25
        Me.lbl_Hodate.Text = "HO DATE :"
        '
        'lbl_Hono
        '
        Me.lbl_Hono.AutoSize = True
        Me.lbl_Hono.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Hono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Hono.Location = New System.Drawing.Point(104, 24)
        Me.lbl_Hono.Name = "lbl_Hono"
        Me.lbl_Hono.Size = New System.Drawing.Size(56, 18)
        Me.lbl_Hono.TabIndex = 23
        Me.lbl_Hono.Text = "HO NO :"
        '
        'txt_Discountamt
        '
        Me.txt_Discountamt.BackColor = System.Drawing.Color.White
        Me.txt_Discountamt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Discountamt.Enabled = False
        Me.txt_Discountamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Discountamt.Location = New System.Drawing.Point(712, 528)
        Me.txt_Discountamt.MaxLength = 15
        Me.txt_Discountamt.Name = "txt_Discountamt"
        Me.txt_Discountamt.Size = New System.Drawing.Size(80, 22)
        Me.txt_Discountamt.TabIndex = 1
        Me.txt_Discountamt.Text = ""
        Me.txt_Discountamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmd_Suppliercodehelp
        '
        Me.cmd_Suppliercodehelp.Image = CType(resources.GetObject("cmd_Suppliercodehelp.Image"), System.Drawing.Image)
        Me.cmd_Suppliercodehelp.Location = New System.Drawing.Point(256, 16)
        Me.cmd_Suppliercodehelp.Name = "cmd_Suppliercodehelp"
        Me.cmd_Suppliercodehelp.Size = New System.Drawing.Size(23, 26)
        Me.cmd_Suppliercodehelp.TabIndex = 29
        '
        'cbo_Storelocation
        '
        Me.cbo_Storelocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Storelocation.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Storelocation.Location = New System.Drawing.Point(784, 1000)
        Me.cbo_Storelocation.Name = "cbo_Storelocation"
        Me.cbo_Storelocation.Size = New System.Drawing.Size(192, 23)
        Me.cbo_Storelocation.TabIndex = 8
        '
        'lbl_Supplierinvdate
        '
        Me.lbl_Supplierinvdate.AutoSize = True
        Me.lbl_Supplierinvdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Supplierinvdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Supplierinvdate.Location = New System.Drawing.Point(424, 56)
        Me.lbl_Supplierinvdate.Name = "lbl_Supplierinvdate"
        Me.lbl_Supplierinvdate.Size = New System.Drawing.Size(126, 18)
        Me.lbl_Supplierinvdate.TabIndex = 27
        Me.lbl_Supplierinvdate.Text = "PARTY INV. DATE :"
        '
        'lbl_Excisepassno
        '
        Me.lbl_Excisepassno.AutoSize = True
        Me.lbl_Excisepassno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Excisepassno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Excisepassno.Location = New System.Drawing.Point(64, 88)
        Me.lbl_Excisepassno.Name = "lbl_Excisepassno"
        Me.lbl_Excisepassno.Size = New System.Drawing.Size(164, 21)
        Me.lbl_Excisepassno.TabIndex = 5
        Me.lbl_Excisepassno.Text = "EXCISE PASS NO       :"
        '
        'lbl_Excisepassdate
        '
        Me.lbl_Excisepassdate.AutoSize = True
        Me.lbl_Excisepassdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Excisepassdate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Excisepassdate.Location = New System.Drawing.Point(64, 128)
        Me.lbl_Excisepassdate.Name = "lbl_Excisepassdate"
        Me.lbl_Excisepassdate.Size = New System.Drawing.Size(168, 21)
        Me.lbl_Excisepassdate.TabIndex = 6
        Me.lbl_Excisepassdate.Text = "EXCISE PASS DATE   :"
        '
        'dtp_Supplierinvdate
        '
        Me.dtp_Supplierinvdate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Supplierinvdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Supplierinvdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Supplierinvdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Supplierinvdate.Location = New System.Drawing.Point(568, 48)
        Me.dtp_Supplierinvdate.Name = "dtp_Supplierinvdate"
        Me.dtp_Supplierinvdate.Size = New System.Drawing.Size(128, 26)
        Me.dtp_Supplierinvdate.TabIndex = 6
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
        Me.txt_Excisepassno.Text = ""
        '
        'lbl_Creditdays
        '
        Me.lbl_Creditdays.AutoSize = True
        Me.lbl_Creditdays.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Creditdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Creditdays.Location = New System.Drawing.Point(520, 104)
        Me.lbl_Creditdays.Name = "lbl_Creditdays"
        Me.lbl_Creditdays.Size = New System.Drawing.Size(109, 18)
        Me.lbl_Creditdays.TabIndex = 32
        Me.lbl_Creditdays.Text = "CREDIT DAYS  :"
        Me.lbl_Creditdays.Visible = False
        '
        'lbl_Grn
        '
        Me.lbl_Grn.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Grn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grn.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Grn.Location = New System.Drawing.Point(8, 632)
        Me.lbl_Grn.Name = "lbl_Grn"
        Me.lbl_Grn.Size = New System.Drawing.Size(160, 24)
        Me.lbl_Grn.TabIndex = 45
        Me.lbl_Grn.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(72, 1000)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 128)
        Me.GroupBox1.TabIndex = 352
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
        Me.txtChangeValue.Size = New System.Drawing.Size(92, 20)
        Me.txtChangeValue.TabIndex = 3
        Me.txtChangeValue.Text = ""
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Clear.Location = New System.Drawing.Point(64, 648)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 17
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.Black
        Me.Cmd_View.Location = New System.Drawing.Point(536, 648)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 15
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Freeze.Location = New System.Drawing.Point(304, 648)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 13
        Me.Cmd_Freeze.Text = "Void[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Add.Location = New System.Drawing.Point(184, 648)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 12
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'grp_StockGrndetails
        '
        Me.grp_StockGrndetails.BackgroundImage = CType(resources.GetObject("grp_StockGrndetails.BackgroundImage"), System.Drawing.Image)
        Me.grp_StockGrndetails.Controls.Add(Me.lbl_StockGrndetails)
        Me.grp_StockGrndetails.Controls.Add(Me.GroupBox5)
        Me.grp_StockGrndetails.Controls.Add(Me.lbl_FromDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.txt_FromDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.Cmd_FromDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.txt_ToDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.Cmd_ToDocno)
        Me.grp_StockGrndetails.Controls.Add(Me.lbl_ToDocno)
        Me.grp_StockGrndetails.Location = New System.Drawing.Point(222, 1000)
        Me.grp_StockGrndetails.Name = "grp_StockGrndetails"
        Me.grp_StockGrndetails.Size = New System.Drawing.Size(514, 238)
        Me.grp_StockGrndetails.TabIndex = 361
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
        Me.Cmd_StockGrnprint.Image = CType(resources.GetObject("Cmd_StockGrnprint.Image"), System.Drawing.Image)
        Me.Cmd_StockGrnprint.Location = New System.Drawing.Point(256, 16)
        Me.Cmd_StockGrnprint.Name = "Cmd_StockGrnprint"
        Me.Cmd_StockGrnprint.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnprint.TabIndex = 25
        Me.Cmd_StockGrnprint.Text = "Print [F10]"
        '
        'Cmd_StockGrnView
        '
        Me.Cmd_StockGrnView.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnView.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnView.Image = CType(resources.GetObject("Cmd_StockGrnView.Image"), System.Drawing.Image)
        Me.Cmd_StockGrnView.Location = New System.Drawing.Point(128, 16)
        Me.Cmd_StockGrnView.Name = "Cmd_StockGrnView"
        Me.Cmd_StockGrnView.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnView.TabIndex = 13
        Me.Cmd_StockGrnView.Text = "View [F9]"
        '
        'Cmd_StockGrnexit
        '
        Me.Cmd_StockGrnexit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnexit.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnexit.Image = CType(resources.GetObject("Cmd_StockGrnexit.Image"), System.Drawing.Image)
        Me.Cmd_StockGrnexit.Location = New System.Drawing.Point(376, 16)
        Me.Cmd_StockGrnexit.Name = "Cmd_StockGrnexit"
        Me.Cmd_StockGrnexit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnexit.TabIndex = 15
        Me.Cmd_StockGrnexit.Text = "Exit[F11]"
        '
        'Cmd_StockGrnClear
        '
        Me.Cmd_StockGrnClear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_StockGrnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_StockGrnClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_StockGrnClear.ForeColor = System.Drawing.Color.White
        Me.Cmd_StockGrnClear.Image = CType(resources.GetObject("Cmd_StockGrnClear.Image"), System.Drawing.Image)
        Me.Cmd_StockGrnClear.Location = New System.Drawing.Point(8, 16)
        Me.Cmd_StockGrnClear.Name = "Cmd_StockGrnClear"
        Me.Cmd_StockGrnClear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_StockGrnClear.TabIndex = 24
        Me.Cmd_StockGrnClear.Text = "Clear[F6]"
        '
        'lbl_FromDocno
        '
        Me.lbl_FromDocno.AutoSize = True
        Me.lbl_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FromDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FromDocno.Location = New System.Drawing.Point(38, 67)
        Me.lbl_FromDocno.Name = "lbl_FromDocno"
        Me.lbl_FromDocno.Size = New System.Drawing.Size(135, 22)
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
        Me.txt_FromDocno.Text = ""
        '
        'Cmd_FromDocno
        '
        Me.Cmd_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_FromDocno.Image = CType(resources.GetObject("Cmd_FromDocno.Image"), System.Drawing.Image)
        Me.Cmd_FromDocno.Location = New System.Drawing.Point(392, 64)
        Me.Cmd_FromDocno.Name = "Cmd_FromDocno"
        Me.Cmd_FromDocno.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_FromDocno.TabIndex = 38
        '
        'txt_ToDocno
        '
        Me.txt_ToDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_ToDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ToDocno.Location = New System.Drawing.Point(184, 112)
        Me.txt_ToDocno.Name = "txt_ToDocno"
        Me.txt_ToDocno.Size = New System.Drawing.Size(208, 29)
        Me.txt_ToDocno.TabIndex = 5
        Me.txt_ToDocno.Text = ""
        '
        'Cmd_ToDocno
        '
        Me.Cmd_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_ToDocno.Image = CType(resources.GetObject("Cmd_ToDocno.Image"), System.Drawing.Image)
        Me.Cmd_ToDocno.Location = New System.Drawing.Point(392, 112)
        Me.Cmd_ToDocno.Name = "Cmd_ToDocno"
        Me.Cmd_ToDocno.Size = New System.Drawing.Size(23, 29)
        Me.Cmd_ToDocno.TabIndex = 39
        '
        'lbl_ToDocno
        '
        Me.lbl_ToDocno.AutoSize = True
        Me.lbl_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ToDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ToDocno.Location = New System.Drawing.Point(64, 114)
        Me.lbl_ToDocno.Name = "lbl_ToDocno"
        Me.lbl_ToDocno.Size = New System.Drawing.Size(109, 22)
        Me.lbl_ToDocno.TabIndex = 3
        Me.lbl_ToDocno.Text = "TO GRN NO :"
        '
        'grp_Billingdetails
        '
        Me.grp_Billingdetails.BackColor = System.Drawing.SystemColors.Control
        Me.grp_Billingdetails.BackgroundImage = CType(resources.GetObject("grp_Billingdetails.BackgroundImage"), System.Drawing.Image)
        Me.grp_Billingdetails.Controls.Add(Me.ssgrid_billdetails)
        Me.grp_Billingdetails.Controls.Add(Me.Label2)
        Me.grp_Billingdetails.Location = New System.Drawing.Point(16, 1000)
        Me.grp_Billingdetails.Name = "grp_Billingdetails"
        Me.grp_Billingdetails.Size = New System.Drawing.Size(664, 310)
        Me.grp_Billingdetails.TabIndex = 364
        Me.grp_Billingdetails.TabStop = False
        '
        'ssgrid_billdetails
        '
        Me.ssgrid_billdetails.ContainingControl = Me
        Me.ssgrid_billdetails.DataSource = Nothing
        Me.ssgrid_billdetails.Location = New System.Drawing.Point(25, 50)
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
        'grp_Excisedetails
        '
        Me.grp_Excisedetails.BackgroundImage = CType(resources.GetObject("grp_Excisedetails.BackgroundImage"), System.Drawing.Image)
        Me.grp_Excisedetails.Controls.Add(Me.Label5)
        Me.grp_Excisedetails.Controls.Add(Me.txt_Trucknumber)
        Me.grp_Excisedetails.Controls.Add(Me.dtp_Stockindate)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Trucknumber)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Stockindate)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Excisepassno)
        Me.grp_Excisedetails.Controls.Add(Me.txt_Excisepassno)
        Me.grp_Excisedetails.Controls.Add(Me.lbl_Excisepassdate)
        Me.grp_Excisedetails.Controls.Add(Me.dtp_Excisepassdate)
        Me.grp_Excisedetails.Location = New System.Drawing.Point(216, 1000)
        Me.grp_Excisedetails.Name = "grp_Excisedetails"
        Me.grp_Excisedetails.Size = New System.Drawing.Size(512, 206)
        Me.grp_Excisedetails.TabIndex = 366
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
        Me.txt_Trucknumber.Text = ""
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
        Me.lbl_Trucknumber.Size = New System.Drawing.Size(162, 21)
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
        Me.lbl_Stockindate.Size = New System.Drawing.Size(163, 21)
        Me.lbl_Stockindate.TabIndex = 4
        Me.lbl_Stockindate.Text = "STOCK IN DATE        :"
        '
        'txt_Suppliercode
        '
        Me.txt_Suppliercode.BackColor = System.Drawing.Color.Wheat
        Me.txt_Suppliercode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Suppliercode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Suppliercode.Location = New System.Drawing.Point(184, 16)
        Me.txt_Suppliercode.MaxLength = 50
        Me.txt_Suppliercode.Name = "txt_Suppliercode"
        Me.txt_Suppliercode.Size = New System.Drawing.Size(72, 22)
        Me.txt_Suppliercode.TabIndex = 4
        Me.txt_Suppliercode.Text = ""
        '
        'txt_Suppliername
        '
        Me.txt_Suppliername.BackColor = System.Drawing.Color.Wheat
        Me.txt_Suppliername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Suppliername.Enabled = False
        Me.txt_Suppliername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Suppliername.Location = New System.Drawing.Point(568, 16)
        Me.txt_Suppliername.MaxLength = 50
        Me.txt_Suppliername.Name = "txt_Suppliername"
        Me.txt_Suppliername.Size = New System.Drawing.Size(256, 22)
        Me.txt_Suppliername.TabIndex = 5
        Me.txt_Suppliername.Text = ""
        '
        'txt_Hono
        '
        Me.txt_Hono.BackColor = System.Drawing.Color.Wheat
        Me.txt_Hono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Hono.Location = New System.Drawing.Point(184, 16)
        Me.txt_Hono.MaxLength = 50
        Me.txt_Hono.Name = "txt_Hono"
        Me.txt_Hono.Size = New System.Drawing.Size(160, 22)
        Me.txt_Hono.TabIndex = 2
        Me.txt_Hono.Text = ""
        '
        'txt_Supplierinvno
        '
        Me.txt_Supplierinvno.BackColor = System.Drawing.Color.Wheat
        Me.txt_Supplierinvno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Supplierinvno.Location = New System.Drawing.Point(184, 48)
        Me.txt_Supplierinvno.MaxLength = 50
        Me.txt_Supplierinvno.Name = "txt_Supplierinvno"
        Me.txt_Supplierinvno.Size = New System.Drawing.Size(168, 22)
        Me.txt_Supplierinvno.TabIndex = 5
        Me.txt_Supplierinvno.Text = ""
        '
        'ssgrid
        '
        Me.ssgrid.DataSource = Nothing
        Me.ssgrid.Location = New System.Drawing.Point(24, 320)
        Me.ssgrid.Name = "ssgrid"
        Me.ssgrid.OcxState = CType(resources.GetObject("ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid.Size = New System.Drawing.Size(928, 176)
        Me.ssgrid.TabIndex = 9
        '
        'lbl_Surchargeamt
        '
        Me.lbl_Surchargeamt.AutoSize = True
        Me.lbl_Surchargeamt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Surchargeamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Surchargeamt.Location = New System.Drawing.Point(8, 16)
        Me.lbl_Surchargeamt.Name = "lbl_Surchargeamt"
        Me.lbl_Surchargeamt.Size = New System.Drawing.Size(132, 18)
        Me.lbl_Surchargeamt.TabIndex = 369
        Me.lbl_Surchargeamt.Text = "OTHER CHARGES  :"
        '
        'lbl_Billamount
        '
        Me.lbl_Billamount.AutoSize = True
        Me.lbl_Billamount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Billamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Billamount.Location = New System.Drawing.Point(256, 24)
        Me.lbl_Billamount.Name = "lbl_Billamount"
        Me.lbl_Billamount.Size = New System.Drawing.Size(98, 18)
        Me.lbl_Billamount.TabIndex = 370
        Me.lbl_Billamount.Text = "BILL AMOUNT "
        '
        'txt_Surchargeamt
        '
        Me.txt_Surchargeamt.BackColor = System.Drawing.Color.White
        Me.txt_Surchargeamt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Surchargeamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Surchargeamt.Location = New System.Drawing.Point(144, 16)
        Me.txt_Surchargeamt.MaxLength = 15
        Me.txt_Surchargeamt.Name = "txt_Surchargeamt"
        Me.txt_Surchargeamt.Size = New System.Drawing.Size(104, 22)
        Me.txt_Surchargeamt.TabIndex = 10
        Me.txt_Surchargeamt.Text = ""
        Me.txt_Surchargeamt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Billamount
        '
        Me.txt_Billamount.BackColor = System.Drawing.Color.Wheat
        Me.txt_Billamount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Billamount.Enabled = False
        Me.txt_Billamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Billamount.Location = New System.Drawing.Point(256, 48)
        Me.txt_Billamount.MaxLength = 15
        Me.txt_Billamount.Name = "txt_Billamount"
        Me.txt_Billamount.ReadOnly = True
        Me.txt_Billamount.Size = New System.Drawing.Size(96, 22)
        Me.txt_Billamount.TabIndex = 373
        Me.txt_Billamount.Text = ""
        Me.txt_Billamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_StoreDesc
        '
        Me.txt_StoreDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_StoreDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_StoreDesc.Enabled = False
        Me.txt_StoreDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StoreDesc.Location = New System.Drawing.Point(184, 80)
        Me.txt_StoreDesc.MaxLength = 50
        Me.txt_StoreDesc.Name = "txt_StoreDesc"
        Me.txt_StoreDesc.Size = New System.Drawing.Size(168, 22)
        Me.txt_StoreDesc.TabIndex = 429
        Me.txt_StoreDesc.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 18)
        Me.Label6.TabIndex = 436
        Me.Label6.Text = "OVERALL DISC :"
        '
        'TXT_OVERALLdiscount
        '
        Me.TXT_OVERALLdiscount.BackColor = System.Drawing.Color.White
        Me.TXT_OVERALLdiscount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_OVERALLdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_OVERALLdiscount.Location = New System.Drawing.Point(144, 48)
        Me.TXT_OVERALLdiscount.MaxLength = 15
        Me.TXT_OVERALLdiscount.Name = "TXT_OVERALLdiscount"
        Me.TXT_OVERALLdiscount.Size = New System.Drawing.Size(104, 22)
        Me.TXT_OVERALLdiscount.TabIndex = 11
        Me.TXT_OVERALLdiscount.Text = ""
        Me.TXT_OVERALLdiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grp_footer
        '
        Me.grp_footer.BackColor = System.Drawing.Color.Transparent
        Me.grp_footer.Controls.Add(Me.Txt_signature)
        Me.grp_footer.Controls.Add(Me.Txt_footer)
        Me.grp_footer.Controls.Add(Me.Label9)
        Me.grp_footer.Controls.Add(Me.Label7)
        Me.grp_footer.Controls.Add(Me.Label8)
        Me.grp_footer.Location = New System.Drawing.Point(32, 432)
        Me.grp_footer.Name = "grp_footer"
        Me.grp_footer.Size = New System.Drawing.Size(920, 80)
        Me.grp_footer.TabIndex = 437
        Me.grp_footer.TabStop = False
        '
        'Txt_signature
        '
        Me.Txt_signature.Location = New System.Drawing.Point(120, 48)
        Me.Txt_signature.MaxLength = 79
        Me.Txt_signature.Name = "Txt_signature"
        Me.Txt_signature.Size = New System.Drawing.Size(776, 20)
        Me.Txt_signature.TabIndex = 441
        Me.Txt_signature.Text = ""
        '
        'Txt_footer
        '
        Me.Txt_footer.Location = New System.Drawing.Point(120, 16)
        Me.Txt_footer.MaxLength = 150
        Me.Txt_footer.Name = "Txt_footer"
        Me.Txt_footer.Size = New System.Drawing.Size(776, 20)
        Me.Txt_footer.TabIndex = 440
        Me.Txt_footer.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 17)
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
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 438
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 17)
        Me.Label8.TabIndex = 438
        Me.Label8.Text = "FOOTER NAME:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 536)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(208, 23)
        Me.Label10.TabIndex = 464
        Me.Label10.Text = "[F3 DELETE A ROW IN GRID]"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.lbl_Hono)
        Me.GroupBox4.Controls.Add(Me.txt_Hono)
        Me.GroupBox4.Controls.Add(Me.cmd_Honohelp)
        Me.GroupBox4.Controls.Add(Me.dtp_Hodate)
        Me.GroupBox4.Controls.Add(Me.lbl_Hodate)
        Me.GroupBox4.Location = New System.Drawing.Point(64, 72)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(848, 56)
        Me.GroupBox4.TabIndex = 465
        Me.GroupBox4.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.lbl_Suppliercode)
        Me.GroupBox6.Controls.Add(Me.txt_Suppliercode)
        Me.GroupBox6.Controls.Add(Me.cmd_Suppliercodehelp)
        Me.GroupBox6.Controls.Add(Me.txt_Suppliername)
        Me.GroupBox6.Controls.Add(Me.txt_Supplierinvno)
        Me.GroupBox6.Controls.Add(Me.lbl_Supplierinvno)
        Me.GroupBox6.Controls.Add(Me.lbl_Supplierinvdate)
        Me.GroupBox6.Controls.Add(Me.dtp_Supplierinvdate)
        Me.GroupBox6.Controls.Add(Me.txt_StoreDesc)
        Me.GroupBox6.Location = New System.Drawing.Point(64, 128)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(848, 112)
        Me.GroupBox6.TabIndex = 466
        Me.GroupBox6.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(64, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 18)
        Me.Label12.TabIndex = 432
        Me.Label12.Text = "HIRE REASON :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(432, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 18)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "SUPPLIER NAME :"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.HO_Indentno)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Location = New System.Drawing.Point(944, 72)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(272, 56)
        Me.GroupBox7.TabIndex = 467
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Visible = False
        '
        'HO_Indentno
        '
        Me.HO_Indentno.BackColor = System.Drawing.Color.Wheat
        Me.HO_Indentno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HO_Indentno.Location = New System.Drawing.Point(104, 24)
        Me.HO_Indentno.MaxLength = 50
        Me.HO_Indentno.Name = "HO_Indentno"
        Me.HO_Indentno.Size = New System.Drawing.Size(128, 22)
        Me.HO_Indentno.TabIndex = 46
        Me.HO_Indentno.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(16, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 18)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "INDENT NO. :"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.lbl_Surchargeamt)
        Me.GroupBox8.Controls.Add(Me.Label6)
        Me.GroupBox8.Controls.Add(Me.txt_Surchargeamt)
        Me.GroupBox8.Controls.Add(Me.TXT_OVERALLdiscount)
        Me.GroupBox8.Controls.Add(Me.lbl_Billamount)
        Me.GroupBox8.Controls.Add(Me.txt_Billamount)
        Me.GroupBox8.Location = New System.Drawing.Point(592, 552)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(360, 80)
        Me.GroupBox8.TabIndex = 468
        Me.GroupBox8.TabStop = False
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.Label20)
        Me.GroupBox9.Controls.Add(Me.txt_Remarks)
        Me.GroupBox9.Controls.Add(Me.lbl_Remarks)
        Me.GroupBox9.Location = New System.Drawing.Point(32, 552)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(552, 80)
        Me.GroupBox9.TabIndex = 469
        Me.GroupBox9.TabStop = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 24)
        Me.Label20.TabIndex = 476
        Me.Label20.Text = "ALT+ R"
        '
        'lbl_fromdate
        '
        Me.lbl_fromdate.AutoSize = True
        Me.lbl_fromdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fromdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fromdate.Location = New System.Drawing.Point(80, 16)
        Me.lbl_fromdate.Name = "lbl_fromdate"
        Me.lbl_fromdate.Size = New System.Drawing.Size(91, 18)
        Me.lbl_fromdate.TabIndex = 471
        Me.lbl_fromdate.Text = "FROM DATE :"
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.dtp_todate)
        Me.GroupBox10.Controls.Add(Me.dtp_frmdate)
        Me.GroupBox10.Controls.Add(Me.LBL_TODATE)
        Me.GroupBox10.Controls.Add(Me.lbl_fromdate)
        Me.GroupBox10.Location = New System.Drawing.Point(64, 240)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(848, 56)
        Me.GroupBox10.TabIndex = 472
        Me.GroupBox10.TabStop = False
        '
        'dtp_todate
        '
        Me.dtp_todate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_todate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_todate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_todate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_todate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_todate.Location = New System.Drawing.Point(568, 16)
        Me.dtp_todate.Name = "dtp_todate"
        Me.dtp_todate.Size = New System.Drawing.Size(120, 26)
        Me.dtp_todate.TabIndex = 474
        '
        'dtp_frmdate
        '
        Me.dtp_frmdate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_frmdate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_frmdate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_frmdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_frmdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_frmdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_frmdate.Location = New System.Drawing.Point(184, 16)
        Me.dtp_frmdate.Name = "dtp_frmdate"
        Me.dtp_frmdate.Size = New System.Drawing.Size(120, 26)
        Me.dtp_frmdate.TabIndex = 473
        '
        'LBL_TODATE
        '
        Me.LBL_TODATE.AutoSize = True
        Me.LBL_TODATE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_TODATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TODATE.Location = New System.Drawing.Point(480, 16)
        Me.LBL_TODATE.Name = "LBL_TODATE"
        Me.LBL_TODATE.Size = New System.Drawing.Size(70, 18)
        Me.LBL_TODATE.TabIndex = 472
        Me.LBL_TODATE.Text = "TO DATE :"
        '
        'PO_HireOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(1014, 732)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.grp_Billingdetails)
        Me.Controls.Add(Me.lbl_Creditdays)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.txt_Totalamt)
        Me.Controls.Add(Me.txt_Discountamt)
        Me.Controls.Add(Me.grp_StockGrndetails)
        Me.Controls.Add(Me.grp_Excisedetails)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Freeze)
        Me.Controls.Add(Me.Cmd_Add)
        Me.Controls.Add(Me.cbo_Storelocation)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Grn)
        Me.Controls.Add(Me.ssgrid)
        Me.Controls.Add(Me.grp_footer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "PO_HireOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HIRE ORDER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.frmbut.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.grp_StockGrndetails.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.grp_Billingdetails.ResumeLayout(False)
        CType(Me.ssgrid_billdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Excisedetails.ResumeLayout(False)
        CType(Me.ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_footer.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public i, TotalCount, billrow As Integer
    Dim GRNno(), sqlstring, Gr As String
    Dim gconnection As New GlobalClass
    Dim vsearch, vitem, accountcode, sstr As String
    Public Listbox As System.Windows.Forms.ListBox
    Dim boolchk, costcentercodestatus, slcodestatus, blnchkupdateclsbal As Boolean
    Dim PO, doctype As String
    Dim CATEGORY As String
    Dim tmpsalrate As Double
    Dim icode1 As String
    Dim Real, Real1 As Double
    Dim scode As String
    Dim VENDORLINK, GRNRATEONLINE, currentuom As String
    Dim CLQTY As Integer
    Private Sub PO_HireOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            GRNCumPurchaseBillTransbool = True
            Call FillGRNTYPE()
            Call categoryfill()
            'Call FillStore()
            'Call CreateListBox()
            'Call FillBillterms()
            'Call Fillbilldetails()
            'Call FOOTER()
            'Call GridLock()
            'CMB_CATEGORY.SelectedIndex = 0
            grp_StockGrndetails.Top = 1000
            grp_Excisedetails.Top = 1000
            grp_footer.Visible = False

            'DISABLE GLACCOUNT
            ssgrid.Top = 300
            'ssgrid.Top = 192
            ssgrid.Left = 10
            ssgrid.Height = 225
            'ssgrid.Height = 312

            ssgrid.Focus()
            ssgrid.SetActiveCell(1, 1)
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            'dtp_Grndate.Focus()
            Show()
            'If gpaymentcode = "Y" Then
            '    cbo_Billingterms.Visible = True
            '    lbl_Billterms.Visible = True
            'Else
            '    cbo_Billingterms.Visible = False
            '    lbl_Billterms.Visible = False
            'End If
            'txt_Grnno.Text = ""
            'Call autogenerate()
            'If gpocode = "Y" Then
            '    Txt_PONo.Enabled = True
            '    cmd_PONOhelp.Enabled = True
            '    Txt_PONo.Focus()
            'Else
            '    txt_Grnno.Focus()
            '    Txt_PONo.Enabled = False
            '    cmd_PONOhelp.Enabled = False
            'End If
            'If GACCPOST = "Y" Then
            '    cmd_Post.Visible = True
            'Else
            '    cmd_Post.Visible = False
            'End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : LOAD " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Function categoryfill()
        'Try
        '    Dim I As Integer
        '    Dim INDEX As Integer
        '    'CMB_CATEGORY.Items.Clear()
        '    sstr = "SELECT DISTINCT CATEGORY FROM INVENTORYITEMMASTER"
        '    gconnection.getDataSet(sstr, "INVENTORYITEMMASTER")
        '    If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count > 0 Then
        '        For I = 0 To gdataset.Tables("INVENTORYITEMMASTER").Rows.Count - 1
        '            CMB_CATEGORY.Items.Add(gdataset.Tables("INVENTORYITEMMASTER").Rows(I).Item("CATEGORY"))
        '        Next
        '        'INDEX = CMB_CATEGORY.FindString(DefaultGRN)
        '        'CMB_CATEGORY.SelectedIndex = INDEX
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : CATEGORYFILL " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Function
        'End Try
    End Function
    Private Sub FillGRNTYPE()
        Dim Sqlstring As String
        Sqlstring = "SELECT ISNULL(GRNTYPE,'') AS GRNTYPE FROM INVSETUP"
        gconnection.getDataSet(Sqlstring, "INVSETUP")
        If gdataset.Tables("INVSETUP").Rows.Count > 0 Then
            DefaultGRN = Trim(gdataset.Tables("INVSETUP").Rows(0).Item("GRNTYPE"))
        Else
            DefaultGRN = "NA"
        End If
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Try
            Dim TEMP As String
            'TEMP = Trim(CMB_CATEGORY.Text)
            Call clearform(Me)
            'CMB_CATEGORY.Text = TEMP
            'Call FOOTER()
            'Call autogenerate()
            'Call FillStore()
            'Call FillBillterms()
            'Call Fillbilldetails()
            grp_footer.Visible = False
            Me.lbl_Freeze.Visible = False
            Me.lbl_Freeze.Text = "Record Void  On "
            ssgrid.ClearRange(1, 1, -1, -1, True)
            ssgrid_billdetails.ClearRange(1, 1, -1, -1, True)
            'CMB_CATEGORY.Enabled = True
            Me.Cmd_Freeze.Text = "Void[F8]"
            Cmd_Add.Text = "Add [F7]"
            txt_StoreDesc.Text = ""
            'txt_Grnno.Enabled = True
            'txt_Grnno.ReadOnly = False
            txt_Remarks.Text = ""
            txt_Totalamt.Text = ""
            txt_Discountamt.Text = ""
            txt_Excisepassno.Text = ""
            txt_Trucknumber.Text = ""
            txt_Supplierinvno.Text = ""
            txt_Suppliercode.Text = ""
            txt_Suppliername.Text = ""
            txt_Suppliercode.ReadOnly = False
            grp_StockGrndetails.Top = 1000

            Cmd_Add.Enabled = True
            Cmd_Freeze.Enabled = True
            grp_StockGrndetails.Top = 1000
            grp_Excisedetails.Top = 1000
            ssgrid.Top = 272
            ssgrid.Left = 10
            ssgrid.Height = 255
            'dtp_Grndate.Value = DateValue(Now)
            dtp_Supplierinvdate.Value = DateValue(Now)
            dtp_Excisepassdate.Value = DateValue(Now)
            ssgrid.Focus()
            ssgrid.SetActiveCell(1, 1)
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            Call FillGRNTYPE()

            TXT_OVERALLdiscount.Text = ""
            txt_Billamount.Text = ""
            txt_Surchargeamt.Text = ""
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : CMD CLEAR" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub GetRights()
        Try
            Dim i, j, k, x As Integer
            Dim vmain, vsmod, vssmod As Long
            Dim ssql, SQLSTRING As String
            Dim M1 As New MainMenu
            Dim chstr As String
            SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='INVENTORY' AND MODULENAME LIKE '%" & Trim(GmoduleName) & "%' ORDER BY RIGHTS"
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
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : GETRIGHTS " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub cmd_lock()
        Me.Cmd_Add.Enabled = False
        Me.Cmd_Clear.Enabled = False
        Me.Cmd_Freeze.Enabled = False
        Me.Cmd_View.Enabled = False
        Me.cmd_print.Enabled = False
        Me.Cmd_Exit.Enabled = False
    End Sub
    Private Sub cmd_unlock()
        Me.Cmd_Add.Enabled = True
        Me.Cmd_Clear.Enabled = True
        Me.Cmd_Freeze.Enabled = True
        Me.Cmd_View.Enabled = True
        Me.cmd_print.Enabled = True
        Me.Cmd_Exit.Enabled = True
    End Sub
    Function SRound(ByVal Real) As Integer
        Dim tmp As Integer
        tmp = Val(Real)
        If Real - tmp >= 0.0001 Then
            Real1 = tmp + 1
        Else
            Real1 = tmp
        End If
    End Function

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        'Try
        '    Dim Totalamount, Taxamount, Calamount, Caltax, CalBilamount, BillAmount, Batchno, Avgrate, Avgquantity As Double
        '    Dim dblBasic, dblDiscount, dblExcise, dblVAT, dblSurchase, dblTranportation, dblOthpostcharge, dblOthNegcharge As Double
        '    Dim Qty, Amount, totQty, discount As Double
        '    Dim sqlstring, varchk, Typecode() As String
        '    Dim Insert(0) As String
        '    Dim i As Integer
        '    scode = Trim(CStr(txt_Storecode.Text))
        '    Call checkValidation() '''--->Check Validation
        '    If boolchk = False Then Exit Sub
        '    Me.txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
        '    grp_Billingdetails.Top = 1000
        '    For i = 1 To ssgrid_billdetails.DataRowCnt
        '        ssgrid_billdetails.Row = i
        '        ssgrid_billdetails.Col = 1
        '        If Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "BAS" Then
        '            ssgrid_billdetails.Col = 4
        '            If Val(ssgrid_billdetails.Text) > 0 Then
        '                dblBasic = dblBasic + Format(Val(ssgrid_billdetails.Text), "0.00")
        '            End If
        '        ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "DIS" Then
        '            ssgrid_billdetails.Col = 4
        '            If Val(ssgrid_billdetails.Text) > 0 Then
        '                dblDiscount = dblDiscount + Format(Val(ssgrid_billdetails.Text), "0.00")
        '            End If
        '        ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "EXC" Then
        '            ssgrid_billdetails.Col = 4
        '            If Val(ssgrid_billdetails.Text) > 0 Then
        '                dblExcise = dblExcise + Format(Val(ssgrid_billdetails.Text), "0.00")
        '            End If
        '        ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "V.A" Then
        '            ssgrid_billdetails.Col = 4
        '            If Val(ssgrid_billdetails.Text) > 0 Then
        '                dblVAT = dblVAT + Format(Val(ssgrid_billdetails.Text), "0.00")
        '            End If
        '        ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "SUR" Then
        '            ssgrid_billdetails.Col = 4
        '            If Val(ssgrid_billdetails.Text) > 0 Then
        '                dblSurchase = dblSurchase + Format(Val(ssgrid_billdetails.Text), "0.00")
        '            End If
        '        ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "TRA" Then
        '            ssgrid_billdetails.Col = 4
        '            If Val(ssgrid_billdetails.Text) > 0 Then
        '                dblTranportation = dblTranportation + Format(Val(ssgrid_billdetails.Text), "0.00")
        '            End If
        '        ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 14, 6) = "ES (+)" Then
        '            ssgrid_billdetails.Col = 4
        '            If Val(ssgrid_billdetails.Text) > 0 Then
        '                dblOthpostcharge = dblOthpostcharge + Format(Val(ssgrid_billdetails.Text), "0.00")
        '            End If
        '        ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 14, 6) = "ES (-)" Then
        '            ssgrid_billdetails.Col = 4
        '            If Val(ssgrid_billdetails.Text) > 0 Then
        '                dblOthNegcharge = dblOthNegcharge + Format(Val(ssgrid_billdetails.Text), "0.00")
        '            End If
        '        ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "BIL" Then
        '            ssgrid_billdetails.Col = 4
        '            If Val(ssgrid_billdetails.Text) > 0 Then
        '                BillAmount = BillAmount + Format(Val(ssgrid_billdetails.Text), "0.00")
        '            End If
        '        End If
        '    Next i
        '    '''**************************************** $ COMPLETE CALCUTATION FOR BASIC AMOUNT  $ **************************************
        '    '''*********************************************************** Case-1 : Add [F7] ***************************************************'''
        '    If Mid(CStr(Cmd_Add.Text), 1, 1) = "A" Then
        '        GRNno = Split(Trim(txt_Grnno.Text), "/")
        '        Typecode = Split(Trim(cbo_Billingterms.Text), " ")
        '        '''*********************************************************** INSERT INTO GRN_HEADER *******************************************'''
        '        sqlstring = "INSERT INTO Grn_header(Grnno,Grndetails,Grndate,POno,Supplierinvno,Supplierdate,Suppliercode,"
        '        sqlstring = sqlstring & " Suppliername,Typecode,Typedesc,Excisepassno,Excisedate,Stockindate,Trucknumber,Creditdays,Glaccountcode,Glaccountname,"
        '        sqlstring = sqlstring & " Slcode,Slname,Costcentercode,Costcentername,Totalamount,VATamount,Surchargeamt,OverallDiscount,Discount,Billamount,Remarks,Void,Adduser,Adddate,Updateuser,Updatetime,STORECODE, STOREDESC,updfooter,updname,Grntype)"
        '        sqlstring = sqlstring & " VALUES ('" & CStr(GRNno(2)) & "','" & Trim(CStr(txt_Grnno.Text)) & "',"
        '        sqlstring = sqlstring & " '" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "',"
        '        sqlstring = sqlstring & " '" & Trim(Txt_PONo.Text) & "',"
        '        sqlstring = sqlstring & " '" & Trim(CStr(txt_Supplierinvno.Text)) & "','" & Format(CDate(dtp_Supplierinvdate.Value), "dd-MMM-yyyy") & "', "
        '        sqlstring = sqlstring & " '" & Trim(CStr(txt_Suppliercode.Text)) & "','" & Trim(CStr(txt_Suppliername.Text)) & "','" & Trim(CStr(Typecode(0))) & "','" & Trim(CStr(Typecode(2))) & "',"
        '        sqlstring = sqlstring & " '" & Trim(CStr(txt_Excisepassno.Text)) & "','" & Format(CDate(dtp_Excisepassdate.Value), "dd-MMM-yyyy ") & "','" & Format(CDate(dtp_Stockindate.Value), "dd-MMM-yyyy") & "',"
        '        sqlstring = sqlstring & " '" & Trim(CStr(txt_Trucknumber.Text)) & "'," & Val(txt_Creditdays.Text) & ",'" & Trim(CStr(Txt_GLAcIn.Text)) & "','" & Trim(CStr(Txt_GLAcDesc.Text)) & "', "
        '        sqlstring = sqlstring & " '" & Trim(CStr(Txt_Slcode.Text)) & "','" & Trim(CStr(Txt_SlDesc.Text)) & "','" & Trim(CStr(Txt_CostCenterCode.Text)) & "','" & Trim(CStr(Txt_CostCenterDesc.Text)) & "',"
        '        sqlstring = sqlstring & " " & Format(Val(txt_Totalamt.Text), "0.00") & "," & Format(Val(txt_Vatamount.Text), "0.00") & "," & Format(Val(txt_Surchargeamt.Text), "0.00") & "," & Format(Val(TXT_OVERALLdiscount.Text), "0.00") & "," & Format(Val(txt_Discountamt.Text), "0.00") & ","
        '        sqlstring = sqlstring & " " & Format(Val(txt_Billamount.Text), "0.00") & ","
        '        sqlstring = sqlstring & " '" & Trim(CStr(txt_Remarks.Text)) & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
        '        sqlstring = sqlstring & " '" & Trim(CStr(txt_Storecode.Text)) & "','" & Trim(CStr(txt_StoreDesc.Text)) & "',"
        '        sqlstring = sqlstring & " '" & Trim(CStr(Txt_footer.Text)) & "','" & Trim(CStr(Txt_signature.Text)) & "','GRN')"
        '        Insert(0) = sqlstring
        '        '''******************************************************** UPDATE FOOTER IN GRNHEADER **********************************'''
        '        sqlstring = "UPDATE Grn_header SET "
        '        sqlstring = sqlstring & " updfooter = '" & Trim(Txt_footer.Text) & "', updname = '" & Trim(Txt_signature.Text) & "' "
        '        sqlstring = sqlstring & " WHERE Grndetails='" & Trim(txt_Grnno.Text) & "' "
        '        '''******************************************************** END **********************************'''

        '        '''******************************************************** INSERT INTO GRN_DETAILS **********************************'''
        '        For i = 1 To ssgrid.DataRowCnt
        '            ssgrid.Row = i
        '            ssgrid.Col = 1
        '            Avgrate = CalAverageRate(Trim(ssgrid.Text))
        '            Avgquantity = CalAverageQuantity(Trim(ssgrid.Text))
        '            sqlstring = "INSERT INTO Grn_details(Grnno,Grndetails,Grndate,POno,Suppliercode,Suppliername,Itemcode,Itemname,"
        '            sqlstring = sqlstring & " UOM,Qty,Rate,Discount,Profitper,TaxPer,TaxAmount,Amount,Salerate,Dblamount,DblUOM,Highratio,Voiditem,Avgqty,Avgrate,Category,Adduser,Adddate,UpdateUser,Updatetime,STORECODE,STOREDESC,othcharge,GrnType,FREEQTY)"
        '            sqlstring = sqlstring & " VALUES('" & CStr(GRNno(2)) & "','" & Trim(txt_Grnno.Text) & "','" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy ") & "',"
        '            sqlstring = sqlstring & " '" & Trim(Txt_PONo.Text) & "',"
        '            sqlstring = sqlstring & " '" & Trim(txt_Suppliercode.Text) & "','" & Trim(txt_Suppliername.Text) & "',"
        '            ssgrid.Col = 1
        '            sqlstring = sqlstring & " '" & Trim(ssgrid.Text) & "',"
        '            ssgrid.Col = 2
        '            sqlstring = sqlstring & " '" & Trim(ssgrid.Text) & "',"
        '            ssgrid.Col = 3
        '            sqlstring = sqlstring & " '" & Trim(ssgrid.Text) & "',"
        '            ssgrid.Col = 4
        '            sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.000") & ","
        '            ssgrid.Col = 5
        '            sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
        '            ssgrid.Col = 6
        '            sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","

        '            ssgrid.Col = 7
        '            sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.000") & ","

        '            ssgrid.Col = 8
        '            sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.000") & ","
        '            ssgrid.Col = 9
        '            sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","

        '            ssgrid.Col = 10
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
        '            ssgrid.Col = 11
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
        '            ssgrid.Col = 12
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
        '            ssgrid.Col = 13
        '            sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
        '            ssgrid.Col = 14
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
        '            sqlstring = sqlstring & "'N'," & Format(Val(Avgquantity), "0.000") & "," & Format(Val(Avgrate), "0.00") & ",'" & Trim(CMB_CATEGORY.Text) & "',"
        '            sqlstring = sqlstring & "'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "',"
        '            sqlstring = sqlstring & "'" & Trim(txt_Storecode.Text) & "','" & Trim(txt_StoreDesc.Text) & "',"
        '            ssgrid.Col = 17
        '            sqlstring = sqlstring & Val(ssgrid.Text) & ",'GRN',"
        '            ssgrid.Col = 18
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ")"

        '            ReDim Preserve Insert(Insert.Length)
        '            Insert(Insert.Length - 1) = sqlstring
        '            '''********************************************* UPDATE PURCHASE RATE IN INVENTORYITEMMASTER *************************'''
        '            ssgrid.Col = 5
        '            ssgrid.Row = i
        '            sqlstring = "UPDATE INVENTORYITEMMASTER SET PURCHASERATE = " & Format(Val(ssgrid.Text), "0.00") & " "
        '            ssgrid.Col = 1
        '            ssgrid.Row = i
        '            sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '            ReDim Preserve Insert(Insert.Length)
        '            Insert(Insert.Length - 1) = sqlstring
        '            '''VENUJD********************************************* UPDATEING CLOSING STOCK IN INVENTORYITEMMASTER *************************'''
        '            CLQTY = 0
        '            ssgrid.Col = 1
        '            ssgrid.Row = i
        '            sqlstring = "select (QTY * b.convvalue) as QTY from GRN_DETAILS,INVENTORY_TRANSCONVERSION B,INVENTORYITEMMASTER i WHERE GRNDETAILS ='" & txt_Grnno.Text & "' AND i.ITEMCODE ='" & Trim(ssgrid.Text) & "' AND i.STORECODE = '" & Trim(txt_Storecode.Text) & "' AND i.STOCKUOM = B.TRANSUOM  AND  uom = B.BASEUOM"
        '            gconnection.getDataSet(sqlstring, "GRN_DETAILS1")

        '            If gdataset.Tables("GRN_DETAILS1").Rows.Count > 0 Then
        '                CLQTY = gdataset.Tables("GRN_DETAILS1").Rows(0).Item("QTY")
        '            End If

        '            ssgrid.Col = 3
        '            ssgrid.Row = i
        '            currentuom = Trim(ssgrid.Text)
        '            ssgrid.Col = 4
        '            ssgrid.Row = i
        '            sqlstring = "UPDATE INVENTORYITEMMASTER SET CLOSINGQTY = (ISNULL(CLOSINGQTY,0) - " & Format(Val(CLQTY), "0.00") & ") + (" & Format(Val(ssgrid.Text), "0.00") & " * B.CONVVALUE)  FROM INVENTORY_TRANSCONVERSION B "
        '            ssgrid.Col = 1
        '            ssgrid.Row = i
        '            sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "' AND STORECODE = '" & Trim(txt_Storecode.Text) & "' AND STOCKUOM = B.TRANSUOM AND  '" & Trim(currentuom) & "' = B.BASEUOM"
        '            ReDim Preserve Insert(Insert.Length)
        '            Insert(Insert.Length - 1) = sqlstring
        '            '''********************************************* UPDATE PROFIT PERCENTAGE IN INVENTORYITEMMASTER *************************'''
        '            ssgrid.Col = 7
        '            ssgrid.Row = i
        '            sqlstring = "UPDATE INVENTORYITEMMASTER SET Profitper = " & Format(Val(ssgrid.Text), "0.00") & " "
        '            ssgrid.Col = 1
        '            ssgrid.Row = i
        '            sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '            ReDim Preserve Insert(Insert.Length)
        '            Insert(Insert.Length - 1) = sqlstring
        '            '''********************************************* UPDATE SaleRate INVENTORYITEMMASTER *************************'''
        '            sqlstring = "select GRNRATEONLINE from invsetup"
        '            gconnection.getDataSet(sqlstring, "invsetup")
        '            If gdataset.Tables("invsetup").Rows.Count > 0 Then
        '                GRNRATEONLINE = gdataset.Tables("invsetup").Rows(0).Item("GRNRATEONLINE")
        '            End If
        '            If GRNRATEONLINE = "Y" Then
        '                'ssgrid.Col = 1
        '                'ssgrid.Row = i
        '                'icode1 = Trim(ssgrid.Text)
        '                'If (CMB_CATEGORY.Text) = "BAR" Then
        '                '    If Mid(Trim(CStr(icode1)), 1, 2) = "B0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W1" Or Mid(Trim(CStr(icode1)), 1, 2) = "W2" Or Mid(Trim(CStr(icode1)), 1, 2) = "W3" Or Mid(Trim(CStr(icode1)), 1, 1) = "G" Or Mid(Trim(CStr(icode1)), 1, 2) = "L0" Or Mid(Trim(CStr(icode1)), 1, 1) = "R" Or Mid(Trim(CStr(icode1)), 1, 1) = "V" Then
        '                '        ssgrid.Col = 11
        '                '        ssgrid.Row = i
        '                '        Real = Trim(ssgrid.Text) / 12.5
        '                '        Call SRound(Real)
        '                '        sqlstring = "UPDATE INVENTORYITEMMASTER SET Salerate = " & Real1 & " "
        '                '        ssgrid.Col = 1
        '                '        ssgrid.Row = i
        '                '        sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '                '    Else
        '                '        ssgrid.Col = 11
        '                '        ssgrid.Row = i
        '                '        sqlstring = "UPDATE INVENTORYITEMMASTER SET Salerate = " & Format(Val(ssgrid.Text), "0.00") & " "
        '                '        ssgrid.Col = 1
        '                '        ssgrid.Row = i
        '                '        sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '                '    End If
        '                'Else
        '                ssgrid.Col = 11
        '                ssgrid.Row = i
        '                sqlstring = "UPDATE INVENTORYITEMMASTER SET Salerate = " & Format(Val(ssgrid.Text), "0.00") & " "
        '                ssgrid.Col = 1
        '                ssgrid.Row = i
        '                sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '                'End If
        '                ReDim Preserve Insert(Insert.Length)
        '                Insert(Insert.Length - 1) = sqlstring
        '                '''********************************************* UPDATE SaleRate ITEMMASTER *************************'''
        '                'If (CMB_CATEGORY.Text) = "BAR" Then
        '                '    If Mid(Trim(CStr(icode1)), 1, 2) = "B0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W1" Or Mid(Trim(CStr(icode1)), 1, 2) = "W2" Or Mid(Trim(CStr(icode1)), 1, 2) = "W3" Or Mid(Trim(CStr(icode1)), 1, 1) = "G" Or Mid(Trim(CStr(icode1)), 1, 2) = "L0" Or Mid(Trim(CStr(icode1)), 1, 1) = "R" Or Mid(Trim(CStr(icode1)), 1, 1) = "V" Then
        '                '        ssgrid.Col = 11
        '                '        ssgrid.Row = i
        '                '        Real = Trim(ssgrid.Text) / 12.5
        '                '        Call SRound(Real)
        '                '        sqlstring = "UPDATE ITEMMASTER SET Baseratestd = " & Real1 & " "
        '                '        ssgrid.Col = 1
        '                '        ssgrid.Row = i
        '                '        sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '                '    Else
        '                '        ssgrid.Col = 11
        '                '        ssgrid.Row = i
        '                '        sqlstring = "UPDATE ITEMMASTER SET Baseratestd = " & Format(Val(ssgrid.Text), "0.00") & " "
        '                '        ssgrid.Col = 1
        '                '        ssgrid.Row = i
        '                '        sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '                '    End If
        '                'Else
        '                ssgrid.Col = 11
        '                ssgrid.Row = i
        '                sqlstring = "UPDATE ITEMMASTER SET Baseratestd = " & Format(Val(ssgrid.Text), "0.00") & " "
        '                ssgrid.Col = 1
        '                ssgrid.Row = i
        '                sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '                'End If
        '                ReDim Preserve Insert(Insert.Length)
        '                Insert(Insert.Length - 1) = sqlstring
        '                '''********************************************* UPDATE SaleRate RATEMASTER *************************'''
        '                Dim uom, itemcode, peguom As String
        '                Dim srate, prate As Double
        '                Dim vdate, vstring As Date
        '                peguom = "PEG"
        '                ssgrid.Col = 11
        '                ssgrid.Row = i
        '                srate = Trim(ssgrid.Text)
        '                ssgrid.Col = 3
        '                ssgrid.Row = i
        '                uom = Trim(ssgrid.Text)
        '                ssgrid.Col = 1
        '                ssgrid.Row = i
        '                itemcode = Trim(ssgrid.Text)
        '                ssgrid.Col = 5
        '                ssgrid.Row = i
        '                prate = Trim(ssgrid.Text)

        '                sqlstring = "SELECT Startingdate FROM Ratemaster WHERE ItemCode='" & (itemcode) & "' "
        '                sqlstring = sqlstring & " AND  ISNULL(endingdate,'') =''"
        '                vstring = gconnection.getvalue(sqlstring)
        '                vstring = Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy")

        '                vstring = Format(vstring, "dd-MMM-yyyy")
        '                If vstring = Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") Then
        '                    vDate = DateAdd(DateInterval.Day, -1, CDate(dtp_Grndate.Value))
        '                    sqlstring = "UPDATE Ratemaster SET Endingdate='" & Format(vdate, "dd-MMM-yyyy") & "' where ItemCode='" & (itemcode) & "' And  EndingDate is Null "
        '                Else
        '                    vdate = DateAdd(DateInterval.Day, -1, CDate(dtp_Grndate.Value))
        '                    sqlstring = "UPDATE Ratemaster SET Endingdate='" & Format(vdate, "dd-MMM-yyyy") & "' where ItemCode='" & (itemcode) & "' And  EndingDate is Null "
        '                End If
        '                ReDim Preserve Insert(Insert.Length)
        '                Insert(Insert.Length - 1) = sqlstring
        '                'If (CMB_CATEGORY.Text) = "BAR" Then
        '                '    If Mid(Trim(CStr(icode1)), 1, 2) = "B0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W1" Or Mid(Trim(CStr(icode1)), 1, 2) = "W2" Or Mid(Trim(CStr(icode1)), 1, 2) = "W3" Or Mid(Trim(CStr(icode1)), 1, 1) = "G" Or Mid(Trim(CStr(icode1)), 1, 2) = "L0" Or Mid(Trim(CStr(icode1)), 1, 1) = "R" Or Mid(Trim(CStr(icode1)), 1, 1) = "V" Then
        '                '        Real = Val(srate) / 12.5
        '                '        Call SRound(Real)
        '                '        sqlstring = " INSERT INTO RateMaster(WithEffectFrom,ItemCodeseqno,ItemCode,UOM,ItemRate,purcahseRate,"
        '                '        sqlstring = sqlstring & " Startingdate,Freeze,AddUserId,AddDateTime)"
        '                '        sqlstring = sqlstring & " VALUES('" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "',0,"
        '                '        sqlstring = sqlstring & " '" & Trim(itemcode) & "','" & Trim(peguom) & "',"
        '                '        sqlstring = sqlstring & " " & Real1 & "," & (Format(Val(prate), "0.00")) & ","
        '                '        sqlstring = sqlstring & " '" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "')"
        '                '    Else
        '                '        sqlstring = " INSERT INTO RateMaster(WithEffectFrom,ItemCodeseqno,ItemCode,UOM,ItemRate,purcahseRate,"
        '                '        sqlstring = sqlstring & " Startingdate,Freeze,AddUserId,AddDateTime)"
        '                '        sqlstring = sqlstring & " VALUES('" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "',0,"
        '                '        sqlstring = sqlstring & " '" & Trim(itemcode) & "','" & Trim(uom) & "',"
        '                '        sqlstring = sqlstring & " " & Format(Val(srate), "0.00") & "," & Format(Val(prate), "0.00") & ","
        '                '        sqlstring = sqlstring & " '" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "')"
        '                '    End If
        '                'Else
        '                sqlstring = " INSERT INTO RateMaster(WithEffectFrom,ItemCodeseqno,ItemCode,UOM,ItemRate,purcahseRate,"
        '                sqlstring = sqlstring & " Startingdate,Freeze,AddUserId,AddDateTime)"
        '                sqlstring = sqlstring & " VALUES('" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "',0,"
        '                sqlstring = sqlstring & " '" & Trim(itemcode) & "','" & Trim(uom) & "',"
        '                sqlstring = sqlstring & " " & Format(Val(srate), "0.00") & "," & Format(Val(prate), "0.00") & ","
        '                sqlstring = sqlstring & " '" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "')"
        '                'End If
        '                ReDim Preserve Insert(Insert.Length)
        '                Insert(Insert.Length - 1) = sqlstring
        '            End If
        '            '''********************************************* UPDATE COMPLETE ******************************************************'''
        '        Next i
        '        '''************************************************* INSERT BILLING DETAILS INTO GRN_BILLTERMS ****************************'''
        '        For i = 1 To ssgrid_billdetails.DataRowCnt
        '            ssgrid_billdetails.Row = i
        '            sqlstring = "INSERT INTO Grn_billterms(Grndetails,Grndate,Billterms,Percentage,Taxcode,Amount,"
        '            sqlstring = sqlstring & " Slno,Formula,Signs,Accode,Acdesc)"
        '            sqlstring = sqlstring & " VALUES('" & Trim(txt_Grnno.Text) & "','" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy ") & "',"
        '            ssgrid_billdetails.Col = 1
        '            sqlstring = sqlstring & "'" & Trim(ssgrid_billdetails.Text) & "',"
        '            ssgrid_billdetails.Col = 2
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid_billdetails.Text), "0.00") & ","
        '            ssgrid_billdetails.Col = 3
        '            sqlstring = sqlstring & "'" & Trim(ssgrid_billdetails.Text) & "',"
        '            ssgrid_billdetails.Col = 4
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid_billdetails.Text), "0.00") & ","
        '            ssgrid_billdetails.Col = 5
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid_billdetails.Text), "0.00") & ","
        '            ssgrid_billdetails.Col = 6
        '            sqlstring = sqlstring & "'" & Trim(ssgrid_billdetails.Text) & "',"
        '            'ssgrid_billdetails.Col = 7
        '            'sqlstring = sqlstring & "'" & Trim(ssgrid_billdetails.Text) & "',"
        '            ssgrid_billdetails.Col = 8
        '            sqlstring = sqlstring & "'" & Trim(ssgrid_billdetails.Text) & "',"
        '            ssgrid_billdetails.Col = 9
        '            sqlstring = sqlstring & "'" & Trim(ssgrid_billdetails.Text) & "',"
        '            ssgrid_billdetails.Col = 10
        '            sqlstring = sqlstring & "'" & Replace(Trim(ssgrid_billdetails.Text), "'", "") & "')"
        '            ReDim Preserve Insert(Insert.Length)
        '            Insert(Insert.Length - 1) = sqlstring
        '        Next i
        '        '''****************************************** UPDATE COMPLETE *********************************************
        '        Call cmd_lock()
        '        gconnection.MoreTrans(Insert)
        '        'Call Grn_Triggers(txt_Grnno.Text, scode)
        '        Call cmd_unlock()
        '        If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
        '            If Trim(txt_Grnno.Text) <> "" Then
        '                txt_FromDocno.Text = Trim(txt_Grnno.Text)
        '                txt_ToDocno.Text = Trim(txt_Grnno.Text)
        '            End If
        '            'Call cmd_print_Click(Cmd_View, e)
        '            Call Cmd_View_Click(Cmd_View, e)
        '            ''If MessageBox.Show(" Need TO Post To Accounts ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
        '            ''    Call cmd_Post_Click(sender, e)
        '            ''Else
        '            Call Cmd_Clear_Click(sender, e)
        '            ''End If

        '        Else
        '            ''If MessageBox.Show(" Need TO Post To Accounts ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
        '            ''    Call cmd_Post_Click(sender, e)
        '            ''Else
        '            Call Cmd_Clear_Click(sender, e)
        '            ''End If
        '        End If
        '        '''*********************************************************** Case-2 : Update [F7] *******************************************'''
        '    ElseIf Mid(CStr(Cmd_Add.Text), 1, 1) = "U" Then
        '        GRNno = Split(Trim(txt_Grnno.Text), "/")
        '        'Call Calculate()
        '        Me.txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
        '        '''**************************************** $ COMPLETE CALCUTATION FOR BASIC AMOUNT  $ **************************************
        '        '****************************************** $ CALCULATE BILLAMT,BASIC,DISCOUNT,EXCISEAMT,VAT,SURCHARGE,ETC $ ************************************
        '        grp_Billingdetails.Top = 1000
        '        For i = 1 To ssgrid_billdetails.DataRowCnt - 1
        '            ssgrid_billdetails.Row = i
        '            ssgrid_billdetails.Col = 1
        '            If Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "BAS" Then
        '                ssgrid_billdetails.Col = 4
        '                If Val(ssgrid_billdetails.Text) > 0 Then
        '                    dblBasic = dblBasic + Format(Val(ssgrid_billdetails.Text), "0.00")
        '                End If
        '            ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "DIS" Then
        '                ssgrid_billdetails.Col = 4
        '                If Val(ssgrid_billdetails.Text) > 0 Then
        '                    dblDiscount = dblDiscount + Format(Val(ssgrid_billdetails.Text), "0.00")
        '                End If
        '            ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "EXC" Then
        '                ssgrid_billdetails.Col = 4
        '                If Val(ssgrid_billdetails.Text) > 0 Then
        '                    dblExcise = dblExcise + Format(Val(ssgrid_billdetails.Text), "0.00")
        '                End If
        '            ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "V.A" Then
        '                ssgrid_billdetails.Col = 4
        '                If Val(ssgrid_billdetails.Text) > 0 Then
        '                    dblVAT = dblVAT + Format(Val(ssgrid_billdetails.Text), "0.00")
        '                End If
        '            ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "SUR" Then
        '                ssgrid_billdetails.Col = 4
        '                If Val(ssgrid_billdetails.Text) > 0 Then
        '                    dblSurchase = dblSurchase + Format(Val(ssgrid_billdetails.Text), "0.00")
        '                End If
        '            ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "TRA" Then
        '                ssgrid_billdetails.Col = 4
        '                If Val(ssgrid_billdetails.Text) > 0 Then
        '                    dblTranportation = dblTranportation + Format(Val(ssgrid_billdetails.Text), "0.00")
        '                End If
        '            ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 14, 6) = "ES (+)" Then
        '                ssgrid_billdetails.Col = 4
        '                If Val(ssgrid_billdetails.Text) > 0 Then
        '                    dblOthpostcharge = dblOthpostcharge + Format(Val(ssgrid_billdetails.Text), "0.00")
        '                End If
        '            ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 14, 6) = "ES (-)" Then
        '                ssgrid_billdetails.Col = 4
        '                If Val(ssgrid_billdetails.Text) > 0 Then
        '                    dblOthNegcharge = dblOthNegcharge + Format(Val(ssgrid_billdetails.Text), "0.00")
        '                End If
        '            ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "BIL" Then
        '                ssgrid_billdetails.Col = 4
        '                If Val(ssgrid_billdetails.Text) > 0 Then
        '                    BillAmount = BillAmount + Format(Val(ssgrid_billdetails.Text), "0.00")
        '                End If
        '            End If
        '        Next i
        '        Me.txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
        '        GRNno = Split(Trim(txt_Grnno.Text), "/")
        '        Typecode = Split(Trim(cbo_Billingterms.Text), " ")
        '        '''********************************************************** UPDATING OPENING STOCK ****************************************************'''
        '        Dim strsql As String
        '        Dim vitemcode, vclsstock, vcurqty, vgrnqty, vdiff, vnetclosing, VDBLAMT, VHIGHRATIO
        '        Dim closingbalance As Double
        '        Dim j, k As Int16
        '        blnchkupdateclsbal = True
        '        For i = 1 To ssgrid.DataRowCnt
        '            ssgrid.Row = i
        '            ssgrid.Col = 1
        '            vitemcode = ssgrid.Text
        '            ssgrid.Col = 4
        '            vcurqty = ssgrid.Text
        '            ssgrid.Col = 16
        '            vclsstock = ssgrid.Text
        '            ssgrid.Col = 15
        '            vgrnqty = ssgrid.Text
        '            ssgrid.Col = 14
        '            VHIGHRATIO = ssgrid.Text
        '            '''******************************** CALCULATION THE STOCK OPENING STOCK **************************'''
        '            vdiff = Val(vgrnqty) - Val(vcurqty)
        '            vnetclosing = Val(vclsstock) - Val(vdiff)
        '            If Val(vnetclosing) < 0 Then
        '                If Mid(CStr(Cmd_Add.Text), 1, 1) = "U" Then
        '                    MessageBox.Show(" InSufficient Stock For Updation ...", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                    ssgrid.Col = 4
        '                    ssgrid.Row = i
        '                    ssgrid.Text = ""
        '                    ssgrid.SetActiveCell(4, i)
        '                    ssgrid.Focus()
        '                    Exit Sub
        '                End If
        '            Else
        '            End If
        '        Next
        '        '''********************************************************** UPDATE GRN_HEADER *********************************************************'''
        '        sqlstring = "UPDATE Grn_header SET Grndate='" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "',"
        '        sqlstring = sqlstring & " Supplierinvno='" & Trim(CStr(txt_Supplierinvno.Text)) & "',Supplierdate='" & Format(CDate(dtp_Supplierinvdate.Value), "dd-MMM-yyyy") & "',"
        '        sqlstring = sqlstring & " Suppliercode='" & Trim(CStr(txt_Suppliercode.Text)) & "',Suppliername='" & Trim(CStr(txt_Suppliername.Text)) & "',Typecode = '" & Trim(CStr(Typecode(0))) & "',Typedesc = '" & Trim(CStr(Typecode(2))) & "',"
        '        sqlstring = sqlstring & " Excisepassno='" & Trim(CStr(txt_Excisepassno.Text)) & "',Excisedate='" & Format(CDate(dtp_Excisepassdate.Value), "dd-MMM-yyyy") & "',Stockindate ='" & Format(CDate(dtp_Stockindate.Value), "dd-MMM-yyyy") & "', "
        '        sqlstring = sqlstring & " Trucknumber ='" & Trim(CStr(txt_Trucknumber.Text)) & "' ,Creditdays=" & Val(txt_Creditdays.Text) & ",Glaccountcode = '" & Trim(CStr(Txt_GLAcIn.Text)) & "',Glaccountname ='" & Trim(CStr(Txt_GLAcDesc.Text)) & "', "
        '        sqlstring = sqlstring & " Slcode = '" & Trim(CStr(Txt_Slcode.Text)) & "',Slname='" & Trim(CStr(Txt_SlDesc.Text)) & "',Costcentercode ='" & Trim(CStr(Txt_CostCenterCode.Text)) & "',Costcentername ='" & Trim(CStr(Txt_CostCenterDesc.Text)) & "',"
        '        sqlstring = sqlstring & " Totalamount=" & Format(Val(txt_Totalamt.Text), "0.00") & ",VATamount = " & Format(Val(txt_Vatamount.Text), "0.00") & ",Surchargeamt = " & Format(Val(txt_Surchargeamt.Text), "0.00") & " ,Discount=" & Format(Val(txt_Discountamt.Text), "0.00") & ","
        '        sqlstring = sqlstring & " Overalldiscount=" & Format(Val(TXT_OVERALLdiscount.Text), "0.00") & ","
        '        sqlstring = sqlstring & " Billamount = " & Format(Val(txt_Billamount.Text), "0.00") & ","
        '        sqlstring = sqlstring & " Remarks = '" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "") & "',Updateuser='" & Trim(gUsername) & "',Updatetime='" & Format(Now, "dd-MMM-yyyy hh:mm") & "',"
        '        sqlstring = sqlstring & " STORECODE = '" & Trim(txt_Storecode.Text) & "', STOREDESC = '" & Trim(txt_StoreDesc.Text) & "', "
        '        sqlstring = sqlstring & " updfooter = '" & Trim(Txt_footer.Text) & "', updname = '" & Trim(Txt_signature.Text) & "',GrnType='GRN' "
        '        sqlstring = sqlstring & " WHERE Grndetails='" & Trim(txt_Grnno.Text) & "' "
        '        Insert(0) = sqlstring
        '        '''********************************************************* DELETE FROM GRN_DETAILS *****************************************************'''
        '        sqlstring = "DELETE FROM Grn_details WHERE Grndetails='" & Trim(txt_Grnno.Text) & "' "
        '        ReDim Preserve Insert(Insert.Length)
        '        Insert(Insert.Length - 1) = sqlstring
        '        '''******************************************************** INSERT INTO GRN_DETAILS ******************************************************'''
        '        For i = 1 To ssgrid.DataRowCnt
        '            ssgrid.Row = i
        '            ssgrid.Col = 1
        '            Avgrate = CalAverageRate(Trim(ssgrid.Text))
        '            Avgquantity = CalAverageQuantity(Trim(ssgrid.Text))
        '            sqlstring = "INSERT INTO Grn_details(Grnno,Grndetails,Grndate,Suppliercode,Suppliername,Itemcode,Itemname,"
        '            sqlstring = sqlstring & " UOM,Qty,Rate,Discount,Profitper,TaxPer,TaxAmount,Amount,Salerate,Dblamount,DblUOM,Highratio,Voiditem,Avgqty,Avgrate,Category,Adduser,Adddate,UpdateUser,Updatetime,STORECODE,STOREDESC,pono,othcharge,GRNType,FREEQTY)"
        '            sqlstring = sqlstring & " VALUES('" & CStr(GRNno(2)) & "','" & Trim(txt_Grnno.Text) & "','" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy ") & "',"
        '            sqlstring = sqlstring & " '" & Trim(txt_Suppliercode.Text) & "','" & Trim(txt_Suppliername.Text) & "',"
        '            ssgrid.Col = 1
        '            sqlstring = sqlstring & " '" & Trim(ssgrid.Text) & "',"
        '            ssgrid.Col = 2
        '            sqlstring = sqlstring & " '" & Trim(ssgrid.Text) & "',"
        '            ssgrid.Col = 3
        '            sqlstring = sqlstring & " '" & Trim(ssgrid.Text) & "',"
        '            ssgrid.Col = 4
        '            sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.000") & ","
        '            ssgrid.Col = 5
        '            sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
        '            ssgrid.Col = 6
        '            sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
        '            ssgrid.Col = 7
        '            sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
        '            ssgrid.Col = 8
        '            sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
        '            ssgrid.Col = 9
        '            sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.00") & ","
        '            ssgrid.Col = 10
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
        '            ssgrid.Col = 11
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
        '            ssgrid.Col = 12
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
        '            ssgrid.Col = 13
        '            sqlstring = sqlstring & "'" & Trim(ssgrid.Text) & "',"
        '            ssgrid.Col = 14
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid.Text), "0.00") & ","
        '            sqlstring = sqlstring & "'N'," & Format(Val(Avgquantity), "0.000") & "," & Format(Val(Avgrate), "0.00") & ",'" & Trim(CMB_CATEGORY.Text) & "',"
        '            sqlstring = sqlstring & "'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "', "
        '            sqlstring = sqlstring & "'" & Trim(txt_Storecode.Text) & "','" & Trim(txt_StoreDesc.Text) & "','" & Txt_PONo.Text & "', "
        '            ssgrid.Col = 17
        '            sqlstring = sqlstring & Val(ssgrid.Text) & ",'GRN',"
        '            ssgrid.Col = 18
        '            sqlstring = sqlstring & " " & Format(Val(ssgrid.Text), "0.000") & ")"
        '            ReDim Preserve Insert(Insert.Length)
        '            Insert(Insert.Length - 1) = sqlstring
        '            '''********************************************* UPDATE PURCHASE RATE IN INVENTORYITEMMASTER *************************'''
        '            ssgrid.Col = 5
        '            ssgrid.Row = i
        '            sqlstring = "UPDATE INVENTORYITEMMASTER SET PURCHASERATE = " & Format(Val(ssgrid.Text), "0.00") & " "
        '            ssgrid.Col = 1
        '            ssgrid.Row = i
        '            sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '            ReDim Preserve Insert(Insert.Length)
        '            Insert(Insert.Length - 1) = sqlstring
        '            '''********************************************* UPDATE CLOSING STOCK IN INVENTORYITEMMASTER *************************'''
        '            CLQTY = 0
        '            ssgrid.Col = 1
        '            ssgrid.Row = i
        '            sqlstring = "select (QTY * b.convvalue) as QTY from GRN_DETAILS,INVENTORY_TRANSCONVERSION B,INVENTORYITEMMASTER i WHERE GRNDETAILS ='" & txt_Grnno.Text & "' AND i.ITEMCODE ='" & Trim(ssgrid.Text) & "' AND i.STORECODE = '" & Trim(txt_Storecode.Text) & "' AND i.STOCKUOM = B.TRANSUOM AND  uom = B.BASEUOM"
        '            gconnection.getDataSet(sqlstring, "GRN_DETAILS1")
        '            If gdataset.Tables("GRN_DETAILS1").Rows.Count > 0 Then
        '                CLQTY = gdataset.Tables("GRN_DETAILS1").Rows(0).Item("QTY")
        '            End If

        '            ssgrid.Col = 3
        '            ssgrid.Row = i
        '            currentuom = Trim(ssgrid.Text)
        '            ssgrid.Col = 4
        '            ssgrid.Row = i
        '            sqlstring = "UPDATE INVENTORYITEMMASTER SET CLOSINGQTY = (ISNULL(CLOSINGQTY,0) - " & Format(Val(CLQTY), "0.00") & ") + (" & Format(Val(ssgrid.Text), "0.00") & " * B.CONVVALUE)  FROM INVENTORY_TRANSCONVERSION B "
        '            ssgrid.Col = 1
        '            ssgrid.Row = i
        '            sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "' AND STORECODE = '" & Trim(txt_Storecode.Text) & "' AND STOCKUOM = B.TRANSUOM AND  '" & Trim(currentuom) & "' = B.BASEUOM"
        '            ReDim Preserve Insert(Insert.Length)
        '            Insert(Insert.Length - 1) = sqlstring
        '            '''********************************************* UPDATE PROFIT PERCENTAGE IN INVENTORYITEMMASTER *************************'''
        '            ssgrid.Col = 7
        '            ssgrid.Row = i
        '            sqlstring = "UPDATE INVENTORYITEMMASTER SET Profitper = " & Format(Val(ssgrid.Text), "0.00") & " "
        '            ssgrid.Col = 1
        '            ssgrid.Row = i
        '            sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '            ReDim Preserve Insert(Insert.Length)
        '            Insert(Insert.Length - 1) = sqlstring
        '            '''********************************************* UPDATE SaleRate in INVENTORYITEMMASTER *************************'''
        '            'If (CMB_CATEGORY.Text) = "BAR" Then
        '            '    If Mid(Trim(CStr(icode1)), 1, 2) = "B0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W1" Or Mid(Trim(CStr(icode1)), 1, 2) = "W2" Or Mid(Trim(CStr(icode1)), 1, 2) = "W3" Or Mid(Trim(CStr(icode1)), 1, 1) = "G" Or Mid(Trim(CStr(icode1)), 1, 2) = "L0" Or Mid(Trim(CStr(icode1)), 1, 1) = "R" Or Mid(Trim(CStr(icode1)), 1, 1) = "V" Then
        '            '        ssgrid.Col = 11
        '            '        ssgrid.Row = i
        '            '        Real = Trim(ssgrid.Text) / 12.5
        '            '        Call SRound(Real)
        '            '        sqlstring = "UPDATE INVENTORYITEMMASTER SET Salerate = " & Real1 & " "
        '            '        ssgrid.Col = 1
        '            '        ssgrid.Row = i
        '            '        sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '            '    Else
        '            '        ssgrid.Col = 11
        '            '        ssgrid.Row = i
        '            '        sqlstring = "UPDATE INVENTORYITEMMASTER SET Salerate = " & Format(Val(ssgrid.Text), "0.00") & " "
        '            '        ssgrid.Col = 1
        '            '        ssgrid.Row = i
        '            '        sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '            '    End If
        '            'Else
        '            ssgrid.Col = 11
        '            ssgrid.Row = i
        '            sqlstring = "UPDATE INVENTORYITEMMASTER SET Salerate = " & Format(Val(ssgrid.Text), "0.00") & " "
        '            ssgrid.Col = 1
        '            ssgrid.Row = i
        '            sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '            'End If
        '            ReDim Preserve Insert(Insert.Length)
        '            Insert(Insert.Length - 1) = sqlstring
        '            '''********************************************* UPDATE SaleRate ITEMMASTER *************************'''
        '            sqlstring = "select GRNRATEONLINE from invsetup"
        '            gconnection.getDataSet(sqlstring, "invsetup")
        '            If gdataset.Tables("invsetup").Rows.Count > 0 Then
        '                GRNRATEONLINE = gdataset.Tables("invsetup").Rows(0).Item("GRNRATEONLINE")
        '            End If
        '            If GRNRATEONLINE = "Y" Then
        '                'If (CMB_CATEGORY.Text) = "BAR" Then
        '                '    If Mid(Trim(CStr(icode1)), 1, 2) = "B0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W1" Or Mid(Trim(CStr(icode1)), 1, 2) = "W2" Or Mid(Trim(CStr(icode1)), 1, 2) = "W3" Or Mid(Trim(CStr(icode1)), 1, 1) = "G" Or Mid(Trim(CStr(icode1)), 1, 2) = "L0" Or Mid(Trim(CStr(icode1)), 1, 1) = "R" Or Mid(Trim(CStr(icode1)), 1, 1) = "V" Then
        '                '        ssgrid.Col = 11
        '                '        ssgrid.Row = i
        '                '        Real = Trim(ssgrid.Text) / 12.5
        '                '        Call SRound(Real)
        '                '        sqlstring = "UPDATE ITEMMASTER SET Baseratestd = " & Real1 & " "
        '                '        ssgrid.Col = 1
        '                '        ssgrid.Row = i
        '                '        sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '                '    Else
        '                '        ssgrid.Col = 11
        '                '        ssgrid.Row = i
        '                '        sqlstring = "UPDATE ITEMMASTER SET Baseratestd = " & Format(Val(ssgrid.Text), "0.00") & " "
        '                '        ssgrid.Col = 1
        '                '        ssgrid.Row = i
        '                '        sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '                '    End If
        '                'Else
        '                ssgrid.Col = 11
        '                ssgrid.Row = i
        '                sqlstring = "UPDATE ITEMMASTER SET Baseratestd = " & Format(Val(ssgrid.Text), "0.00") & " "
        '                ssgrid.Col = 1
        '                ssgrid.Row = i
        '                sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "'"
        '                'End If
        '                ReDim Preserve Insert(Insert.Length)
        '                Insert(Insert.Length - 1) = sqlstring
        '                '''********************************************* UPDATE SaleRate RATEMASTER *************************'''
        '                Dim uom, itemcode, peguom As String
        '                Dim srate, prate As Double
        '                Dim vdate, vstring As Date
        '                peguom = "PEG"
        '                ssgrid.Col = 11
        '                ssgrid.Row = i
        '                srate = Trim(ssgrid.Text)
        '                ssgrid.Col = 3
        '                ssgrid.Row = i
        '                uom = Trim(ssgrid.Text)
        '                ssgrid.Col = 1
        '                ssgrid.Row = i
        '                itemcode = Trim(ssgrid.Text)
        '                ssgrid.Col = 5
        '                ssgrid.Row = i
        '                prate = Trim(ssgrid.Text)

        '                sqlstring = "SELECT Startingdate FROM Ratemaster WHERE ItemCode='" & (itemcode) & "' and uom = '" & Trim(uom) & "'"
        '                sqlstring = sqlstring & " AND  ISNULL(endingdate,'') =''"
        '                vstring = gconnection.getvalue(sqlstring)
        '                vstring = Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy")

        '                vstring = Format(vstring, "dd-MMM-yyyy")
        '                If vstring = Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") Then
        '                    vDate = DateAdd(DateInterval.Day, -1, CDate(dtp_Grndate.Value))
        '                    'sqlstring = "UPDATE Ratemaster SET Endingdate='" & Format(vdate, "dd-MMM-yyyy") & "',Startingdate='" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "', itemrate = " & Format(Val(sale), "0.00") & ",uom = '" & Trim(uom) & "',AddUserId='" & Trim(gUsername) & "',AddDateTime='" & Format(Now, "dd-MMM-yyyy") & "' where ItemCode='" & (itemcode) & "' And EndingDate is Null "
        '                    sqlstring = "UPDATE Ratemaster SET Endingdate='" & Format(vdate, "dd-MMM-yyyy") & "' where ItemCode='" & (itemcode) & "' And  EndingDate is Null "
        '                Else
        '                    vdate = DateAdd(DateInterval.Day, -1, CDate(dtp_Grndate.Value))
        '                    sqlstring = "UPDATE Ratemaster SET Endingdate='" & Format(vdate, "dd-MMM-yyyy") & "' where ItemCode='" & (itemcode) & "' And  EndingDate is Null "
        '                    'sqlstring = "UPDATE Ratemaster SET Endingdate='" & Format(vdate, "dd-MMM-yyyy") & "',Startingdate='" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "', itemrate = " & Format(Val(sale), "0.00") & ",uom = '" & Trim(uom) & "',AddUserId='" & Trim(gUsername) & "',AddDateTime='" & Format(Now, "dd-MMM-yyyy") & "' where ItemCode='" & (itemcode) & "' And  EndingDate is Null "
        '                End If
        '                ReDim Preserve Insert(Insert.Length)
        '                Insert(Insert.Length - 1) = sqlstring

        '                'If (CMB_CATEGORY.Text) = "BAR" Then
        '                '    If Mid(Trim(CStr(icode1)), 1, 2) = "B0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W1" Or Mid(Trim(CStr(icode1)), 1, 2) = "W2" Or Mid(Trim(CStr(icode1)), 1, 2) = "W3" Or Mid(Trim(CStr(icode1)), 1, 1) = "G" Or Mid(Trim(CStr(icode1)), 1, 2) = "L0" Or Mid(Trim(CStr(icode1)), 1, 1) = "R" Or Mid(Trim(CStr(icode1)), 1, 1) = "V" Then
        '                '        Real = Trim(srate) / 12.5
        '                '        Call SRound(Real)
        '                '        sqlstring = " INSERT INTO RateMaster(WithEffectFrom,ItemCodeseqno,ItemCode,UOM,ItemRate,purcahseRate,"
        '                '        sqlstring = sqlstring & " Startingdate,Freeze,AddUserId,AddDateTime)"
        '                '        sqlstring = sqlstring & " VALUES('" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "',0,"
        '                '        sqlstring = sqlstring & " '" & Trim(itemcode) & "','" & Trim(peguom) & "',"
        '                '        sqlstring = sqlstring & " " & Real1 & "," & (Format(Val(prate), "0.00")) & ","
        '                '        sqlstring = sqlstring & " '" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "')"
        '                '    Else
        '                '        sqlstring = " INSERT INTO RateMaster(WithEffectFrom,ItemCodeseqno,ItemCode,UOM,ItemRate,purcahseRate,"
        '                '        sqlstring = sqlstring & " Startingdate,Freeze,AddUserId,AddDateTime)"
        '                '        sqlstring = sqlstring & " VALUES('" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "',0,"
        '                '        sqlstring = sqlstring & " '" & Trim(itemcode) & "','" & Trim(uom) & "',"
        '                '        sqlstring = sqlstring & " " & Format(Val(srate), "0.00") & "," & Format(Val(prate), "0.00") & ","
        '                '        sqlstring = sqlstring & " '" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "')"
        '                '    End If
        '                'Else
        '                sqlstring = " INSERT INTO RateMaster(WithEffectFrom,ItemCodeseqno,ItemCode,UOM,ItemRate,purcahseRate,"
        '                sqlstring = sqlstring & " Startingdate,Freeze,AddUserId,AddDateTime)"
        '                sqlstring = sqlstring & " VALUES('" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "',0,"
        '                sqlstring = sqlstring & " '" & Trim(itemcode) & "','" & Trim(uom) & "',"
        '                sqlstring = sqlstring & " " & Format(Val(srate), "0.00") & "," & Format(Val(prate), "0.00") & ","
        '                sqlstring = sqlstring & " '" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy") & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy") & "')"
        '                'End If
        '                ReDim Preserve Insert(Insert.Length)
        '                Insert(Insert.Length - 1) = sqlstring
        '            End If
        '            '''********************************************* UPDATE COMPLETE ******************************************************'''
        '        Next i
        '        '''********************************************************* DELETE FROM GRN_DETAILS *****************************************************'''
        '        sqlstring = "DELETE FROM Grn_billterms WHERE Grndetails='" & Trim(txt_Grnno.Text) & "' "
        '        ReDim Preserve Insert(Insert.Length)
        '        Insert(Insert.Length - 1) = sqlstring
        '        '''************************************************* INSERT BILLING DETAILS INTO GRN_BILLTERMS ****************************'''
        '        For i = 1 To ssgrid_billdetails.DataRowCnt
        '            ssgrid_billdetails.Row = i
        '            sqlstring = "INSERT INTO Grn_billterms(Grndetails,Grndate,Billterms,Percentage,Taxcode,Amount,"
        '            sqlstring = sqlstring & " Slno,Formula,Signs,Accode,Acdesc)"
        '            sqlstring = sqlstring & " VALUES('" & Trim(txt_Grnno.Text) & "','" & Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy ") & "',"
        '            ssgrid_billdetails.Col = 1
        '            sqlstring = sqlstring & "'" & Trim(ssgrid_billdetails.Text) & "',"
        '            ssgrid_billdetails.Col = 2
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid_billdetails.Text), "0.00") & ","
        '            ssgrid_billdetails.Col = 3
        '            sqlstring = sqlstring & "'" & Trim(ssgrid_billdetails.Text) & "',"
        '            ssgrid_billdetails.Col = 4
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid_billdetails.Text), "0.00") & ","
        '            ssgrid_billdetails.Col = 5
        '            sqlstring = sqlstring & "" & Format(Val(ssgrid_billdetails.Text), "0.00") & ","
        '            ssgrid_billdetails.Col = 6
        '            sqlstring = sqlstring & "'" & Trim(ssgrid_billdetails.Text) & "',"
        '            'ssgrid_billdetails.Col = 7
        '            'sqlstring = sqlstring & "'" & Trim(ssgrid_billdetails.Text) & "',"
        '            ssgrid_billdetails.Col = 8
        '            sqlstring = sqlstring & "'" & Trim(ssgrid_billdetails.Text) & "',"
        '            ssgrid_billdetails.Col = 9
        '            sqlstring = sqlstring & "'" & Trim(ssgrid_billdetails.Text) & "',"
        '            ssgrid_billdetails.Col = 10
        '            sqlstring = sqlstring & "'" & Replace(Trim(ssgrid_billdetails.Text), "'", "") & "')"
        '            ReDim Preserve Insert(Insert.Length)
        '            Insert(Insert.Length - 1) = sqlstring
        '        Next i
        '        ''''***************************************** COMPLETE ACCOUNT POSTING FOR BILLDETAILS SECTIONS ****************************'''
        '        '''****************************************** UPDATE Complete *********************************************
        '        Call cmd_lock() ' Untill transaction completes
        '        gconnection.MoreTrans(Insert)
        '        'Call Grn_Triggers(txt_Grnno.Text, scode)
        '        Call cmd_unlock()
        '        If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
        '            If Trim(txt_Grnno.Text) <> "" Then
        '                txt_FromDocno.Text = Trim(txt_Grnno.Text)
        '                txt_ToDocno.Text = Trim(txt_Grnno.Text)
        '            End If
        '            Call Cmd_View_Click(Cmd_View, e)
        '            Call Cmd_Clear_Click(sender, e)
        '        Else
        '            Call Cmd_Clear_Click(sender, e)
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : CMD_ADD_CLEAR" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub checkupdate_clsbal()
        Try
            Dim vclsstock, vcurqty, vgrnqty, vdiff, vnetclosing As Double
            Dim strsql, vitemcode As String
            Dim i, j, k As Integer
            blnchkupdateclsbal = True
            For i = 1 To ssgrid.DataRowCnt
                ssgrid.Row = i
                ssgrid.Col = 1
                vitemcode = Trim(ssgrid.Text)
                ssgrid.Col = 4
                vcurqty = Val(ssgrid.Text)
                ssgrid.Col = 16
                vclsstock = Val(ssgrid.Text)
                ssgrid.Col = 15
                vgrnqty = Val(ssgrid.Text)
                ''********************************** CALCULATION OF STOCK ********************************'''
                vdiff = Val(vgrnqty) - Val(vcurqty)
                vnetclosing = Val(vclsstock) - Val(vdiff)
                If vnetclosing < 0 Then
                    If Mid(CStr(Cmd_Add.Text), 1, 1) = "A" Then
                        MessageBox.Show(" Insufficient Stock For Updation ...", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        ssgrid.Col = 4
                        ssgrid.Row = i
                        ssgrid.Focus()
                        blnchkupdateclsbal = False
                        Exit Sub
                    End If
                End If
            Next i
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : CHECKUPDATE_CLBAL" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        'Try
        '    Dim vclsstock, vcurqty, vgrnqty, vdiff, vnetclosing As Double
        '    Dim strsql, vitemcode As String
        '    Call checkValidation() ''-->Check Validation
        '    Dim insert(0) As String
        '    scode = Trim(txt_Storecode.Text)
        '    For i = 1 To ssgrid.DataRowCnt
        '        ssgrid.Row = i
        '        ssgrid.Col = 1
        '        vitemcode = Trim(ssgrid.Text)
        '        ssgrid.Col = 4
        '        vcurqty = Val(ssgrid.Text)
        '        ssgrid.Col = 16
        '        vclsstock = Val(ssgrid.Text)
        '        ssgrid.Col = 15
        '        vgrnqty = Val(ssgrid.Text)
        '        ''********************************** CALCULATION OF STOCK ********************************'''
        '        vdiff = Val(vgrnqty) - Val(vcurqty)
        '        vnetclosing = Val(vclsstock) - Val(vcurqty)
        '        If Val(vnetclosing) < 0 Then
        '            If Mid(CStr(Cmd_Add.Text), 1, 1) = "U" Then
        '                MessageBox.Show("Sorry!There will be Negative Stock on Itemcod  :  " & vitemcode & "if  deleted...", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '                ssgrid.Col = 4
        '                ssgrid.Row = i
        '                ssgrid.Focus()
        '                boolchk = False
        '                Exit Sub
        '            End If
        '        End If
        '    Next i
        '    If boolchk = False Then Exit Sub
        '    If Mid(Me.Cmd_Freeze.Text, 1, 1) = "V" Or Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
        '        If MsgBox("Are you Sure to Freeze the Record..", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
        '            Exit Sub
        '        End If
        '        sqlstring = "INSERT INTO GRN_HEADER_DEL( Grnno , Grndetails , Grndate , POno , Supplierinvno , Supplierdate , Suppliercode , Suppliername , Typecode , Typedesc , Excisepassno , Excisedate , Stockindate , Trucknumber , Creditdays , Glaccountcode , Glaccountname , Slcode , Slname , Costcentercode , Costcentername , Totalamount , VATamount , Surchargeamt , Discount , Billamount , Remarks , Void , Adduser , Adddate , Updateuser , Updatetime , POSTINGFLAG , category , tdssectioncode , TDSFLAG , TDSPERCENTAGE , TDSAMOUNT , storecode , storedesc )"
        '        sqlstring = sqlstring & " SELECT Grnno , Grndetails , Grndate , POno , Supplierinvno , Supplierdate , Suppliercode , Suppliername , Typecode , Typedesc , Excisepassno , Excisedate , Stockindate , Trucknumber , Creditdays , Glaccountcode , Glaccountname , Slcode , Slname , Costcentercode , Costcentername , Totalamount , VATamount , Surchargeamt , Discount , Billamount , Remarks , Void , Adduser , Adddate , Updateuser , Updatetime , POSTINGFLAG , category , tdssectioncode , TDSFLAG , TDSPERCENTAGE , TDSAMOUNT , storecode , storedesc"
        '        sqlstring = sqlstring & " FROM GRN_HEADER A"
        '        sqlstring = sqlstring & " WHERE A.Grndetails = '" & Trim(txt_Grnno.Text) & "' "
        '        sqlstring = sqlstring & " AND A.PONO = '" & Trim(Txt_PONo.Text) & "' "
        '        insert(0) = sqlstring

        '        sqlstring = " DELETE FROM GRN_HEADER "
        '        sqlstring = sqlstring & " WHERE Grndetails = '" & Trim(txt_Grnno.Text) & "' "
        '        sqlstring = sqlstring & " AND PONO = '" & Trim(Txt_PONo.Text) & "' "
        '        ReDim Preserve insert(insert.Length)
        '        insert(insert.Length - 1) = sqlstring
        '        '''***************************************** DELETE the GRNNO in Complete **********************************'''
        '        '''***************************************** DELETE the GRNNO in Grn_details **************************'''
        '        For i = 1 To ssgrid.DataRowCnt
        '            With ssgrid

        '                'UPDATING CLOSING STOCK IN INVENTORYITEMMASTER - START --***VENUJD
        '                CLQTY = 0
        '                ssgrid.Col = 1
        '                ssgrid.Row = i
        '                sqlstring = "select (QTY * b.convvalue) as QTY from GRN_DETAILS,INVENTORY_TRANSCONVERSION B,INVENTORYITEMMASTER i WHERE GRNDETAILS ='" & txt_Grnno.Text & "' AND i.ITEMCODE ='" & Trim(ssgrid.Text) & "' AND i.STORECODE = '" & Trim(txt_Storecode.Text) & "' AND i.STOCKUOM = B.TRANSUOM AND  uom = B.BASEUOM"
        '                gconnection.getDataSet(sqlstring, "GRN_DETAILS1")
        '                If gdataset.Tables("GRN_DETAILS1").Rows.Count > 0 Then
        '                    CLQTY = gdataset.Tables("GRN_DETAILS1").Rows(0).Item("QTY")
        '                End If

        '                ssgrid.Col = 3
        '                ssgrid.Row = i
        '                currentuom = Trim(ssgrid.Text)
        '                ssgrid.Col = 4
        '                ssgrid.Row = i
        '                sqlstring = "UPDATE INVENTORYITEMMASTER SET CLOSINGQTY = (ISNULL(CLOSINGQTY,0) - " & Format(Val(CLQTY), "0.00") & ")   "
        '                ssgrid.Col = 1
        '                ssgrid.Row = i
        '                sqlstring = sqlstring & "WHERE ITEMCODE = '" & Trim(ssgrid.Text) & "' AND STORECODE = '" & Trim(txt_Storecode.Text) & "' "
        '                ReDim Preserve insert(insert.Length)
        '                insert(insert.Length - 1) = sqlstring
        '                'UPDATING CLOSING STOCK IN INVENTORYITEMMASTER - END --***VENUJD

        '                sqlstring = "INSERT INTO GRN_DETAILS_DEL( Grnno , Grndetails , Grndate , POno , Suppliercode , Suppliername , Itemcode , Itemname , UOM , Qty , Rate , Discount , Amount , Dblamount , DblUOM , Highratio , Avgqty , voiditem , Adduser , Adddate , Updateuser , Updatetime , category , taxpercentage , storecode , storedesc , taxper , taxamount ) "
        '                sqlstring = sqlstring & " SELECT Grnno , Grndetails , Grndate , POno , Suppliercode , Suppliername , Itemcode , Itemname , UOM , Qty , Rate , Discount , Amount , Dblamount , DblUOM , Highratio , Avgqty , voiditem , Adduser , Adddate , Updateuser , Updatetime , category , taxpercentage , storecode , storedesc , taxper , taxamount"
        '                sqlstring = sqlstring & " FROM GRN_DETAILS A"
        '                sqlstring = sqlstring & " WHERE A.Grndetails = '" & Trim(txt_Grnno.Text) & "'"
        '                sqlstring = sqlstring & " AND A.PONO = '" & Trim(Txt_PONo.Text) & "' "
        '                ReDim Preserve insert(insert.Length)
        '                insert(insert.Length - 1) = sqlstring

        '                sqlstring = " DELETE FROM GRN_DETAILS "
        '                sqlstring = sqlstring & " WHERE Grndetails = '" & Trim(txt_Grnno.Text) & "' "
        '                sqlstring = sqlstring & " AND PONO = '" & Trim(Txt_PONo.Text) & "' "
        '                ReDim Preserve insert(insert.Length)
        '                insert(insert.Length - 1) = sqlstring
        '            End With
        '        Next i
        '        '''***************************************** DELETE the GRNNO is Complete **********************************'''
        '        '''***************************************** DELETE the GRNNO in Grn_header **************************'''
        '        Call cmd_lock() ' Untill transaction completes
        '        gconnection.MoreTrans(insert)

        '        'If MessageBox.Show(" Need TO Post To Accounts ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
        '        '    Call cmd_Post_Click(sender, e)
        '        'End If

        '        Call Grn_Triggers(txt_Grnno.Text, scode)
        '        Call cmd_unlock()
        '        If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
        '            If Trim(txt_Grnno.Text) <> "" Then
        '                txt_FromDocno.Text = Trim(txt_Grnno.Text)
        '                txt_ToDocno.Text = Trim(txt_Grnno.Text)
        '            End If
        '            Call cmd_print_Click(Cmd_View, e)
        '            'If MessageBox.Show(" Need TO Post To Accounts ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
        '            '    Call cmd_Post_Click(sender, e)
        '            'End If
        '            Call Cmd_Clear_Click(sender, e)
        '        Else
        '            'If MessageBox.Show(" Need TO Post To Accounts ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
        '            '    Call cmd_Post_Click(sender, e)
        '            'End If

        '            Call Cmd_Clear_Click(sender, e)
        '        End If
        '    End If

        '    '''****************************************** UPDATE Complete *********************************************
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : CMD_FREEZE" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Function printoperation()
        'Try
        '    Dim i As Integer
        '    Dim objGrncumpurchase As New rptGrncumpurchaseNote
        '    Dim sqlstring = "SELECT ISNULL(G.PONO,'') AS PONO, ISNULL(G.GRNDETAILS,'') AS GRNDETAILS,G.GRNDATE, ISNULL(G.SUPPLIERCODE,'') AS SUPPLIERCODE, ISNULL(G.SUPPLIERNAME,'') AS SUPPLIERNAME,"
        '    sqlstring = sqlstring & " ISNULL(G.SUPPLIERINVNO,'') AS SUPPLIERINVNO,  ISNULL(G.EXCISEPASSNO,'') AS EXCISEPASSNO,ISNULL(G.GLACCOUNTCODE,'') AS GLACCOUNTCODE,ISNULL(G.GLACCOUNTNAME,'') AS GLACCOUNTNAME,"
        '    sqlstring = sqlstring & " ISNULL(G.TOTALAMOUNT,0) AS TOTALAMOUNT,ISNULL(VATAMOUNT,0) AS VATAMOUNT,ISNULL(G.SURCHARGEAMT,0) AS SURCHARGEAMT,ISNULL(G.DISCOUNT,0) AS DISCOUNT,ISNULL(G.BILLAMOUNT,0) AS BILLAMOUNT,"
        '    sqlstring = sqlstring & " ISNULL(D.ITEMCODE,'') AS ITEMCODE, ISNULL(D.ITEMNAME,'') AS ITEMNAME,ISNULL(D.UOM,'') AS UOM, ISNULL(D.QTY,0) AS QTY, ISNULL(D.RATE,0) AS RATE,ISNULL(G.REMARKS,'') AS REMARKS, "
        '    sqlstring = sqlstring & " ISNULL(D.AMOUNT,0) AS AMOUNT,isnull(d.discount,0) as ddiscount,isnull(d.taxper,0) as taxper,isnull(d.taxamount,0) as taxamount, isnull(g.OverallDiscount,0) OverallDiscount,ISNULL(UPDFOOTER,'') AS UPDFOOTER,ISNULL(UPDNAME,'') AS UPDNAME "
        '    sqlstring = sqlstring & " FROM GRN_HEADER AS G INNER JOIN GRN_DETAILS AS D ON G.GRNDETAILS = D.GRNDETAILS "
        '    sqlstring = sqlstring & " WHERE G.GRNDETAILS BETWEEN '" & Trim(txt_Grnno.Text) & "' AND '" & Trim(txt_Grnno.Text) & "'"
        '    sqlstring = sqlstring & " ORDER BY D.AUTOID ,G.GRNDETAILS,G.GRNDATE"
        '    Dim heading() As String = {"GRN CUM PURCHASE BILL"}
        '    objGrncumpurchase.ReportDetails_sc(sqlstring, heading, txt_Grnno.Text, txt_Grnno.Text)
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Printoperation " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Function
        'End Try
    End Function
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        'Try
        '    ' If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
        '    Dim rViewer As New Viewer
        '    Dim sqlstring, SSQL As String
        '    Dim r As New Rpt_GrnBill
        '    sqlstring = "SELECT ISNULL(PONO,'') AS PONO, ISNULL(GRNDETAILS,'') AS GRNDETAILS,GRNDATE, ISNULL(SUPPLIERCODE,'') AS SUPPLIERCODE, ISNULL(SUPPLIERNAME,'') AS SUPPLIERNAME,"
        '    sqlstring = sqlstring & " ISNULL(SUPPLIERINVNO,'') AS SUPPLIERINVNO,  ISNULL(EXCISEPASSNO,'') AS EXCISEPASSNO,ISNULL(GLACCOUNTCODE,'') AS GLACCOUNTCODE,ISNULL(GLACCOUNTNAME,'') AS GLACCOUNTNAME,"
        '    sqlstring = sqlstring & " ISNULL(TOTALAMOUNT,0) AS TOTALAMOUNT,ISNULL(VATAMOUNT,0) AS VATAMOUNT,ISNULL(SURCHARGEAMT,0) AS SURCHARGEAMT,ISNULL(DISCOUNT,0) AS DISCOUNT,ISNULL(BILLAMOUNT,0) AS BILLAMOUNT,"
        '    sqlstring = sqlstring & " ISNULL(ITEMCODE,'') AS ITEMCODE, ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM, ISNULL(QTY,0) AS QTY, ISNULL(RATE,0) AS RATE,ISNULL(REMARKS,'') AS REMARKS, "
        '    sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT,isnull(discount,0) as ddiscount,isnull(taxper,0) as taxper,isnull(taxamount,0) as taxamount, isnull(OverallDiscount,0) OverallDiscount,ISNULL(UPDFOOTER,'') AS UPDFOOTER,ISNULL(UPDNAME,'') AS UPDNAME "
        '    sqlstring = sqlstring & " FROM VW_INV_GRNBILL "
        '    sqlstring = sqlstring & " WHERE GRNDETAILS BETWEEN '" & Trim(txt_Grnno.Text) & "' AND '" & Trim(txt_Grnno.Text) & "'"
        '    sqlstring = sqlstring & " ORDER BY AUTOID ,GRNDETAILS,GRNDATE"

        '    gconnection.getDataSet(sqlstring, "VW_INV_GRNBILL")
        '    If gdataset.Tables("VW_INV_GRNBILL").Rows.Count > 0 Then
        '        rViewer.ssql = sqlstring
        '        rViewer.Report = r
        '        rViewer.TableName = "VW_INV_GRNBILL"
        '        Dim textobj1 As TextObject
        '        textobj1 = r.ReportDefinition.ReportObjects("Text13")
        '        textobj1.Text = MyCompanyName

        '        Dim textobj2 As TextObject
        '        textobj2 = r.ReportDefinition.ReportObjects("Text30")
        '        textobj2.Text = gUsername
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
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Exit Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Grnno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Hono.KeyPress
        'Try
        '    If Asc(e.KeyChar) = 13 Then
        '        If Trim(txt_Grnno.Text) = "" Then
        '            Call cmd_Grnnohelp_Click(cmd_Grnnohelp, e)
        '        Else
        '            txt_Grnno_Validated(txt_Grnno, e)
        '            dtp_Grndate.Focus()
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Grnno Key Press " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub dtp_Grndate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hodate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                txt_Suppliercode.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Grn Date Keypress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Supplierinvno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Supplierinvno.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                dtp_Supplierinvdate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Supplier Invno Keypress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub dtp_Supplierinvdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Supplierinvdate.KeyPress
        'Try
        '    If Asc(e.KeyChar) = 13 Then
        '        txt_Storecode.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : dtp_Supplierinvdate_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Suppliercode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Suppliercode.KeyPress
        'Try
        '    If Asc(e.KeyChar) = 13 Then
        '        If Trim(txt_Suppliercode.Text) = "" Then
        '            Call cmd_Suppliercodehelp_Click(cmd_Suppliercodehelp, e)
        '        Else
        '            Call txt_Suppliercode_Validated(txt_Suppliercode, e)
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Suppliercode_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Suppliername_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Suppliername.KeyPress
        'Try
        '    If Asc(e.KeyChar) = 13 Then
        '        If slcodestatus = True Then
        '            Txt_Slcode.Focus()
        '        Else
        '            ssgrid.Focus()
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Suppliername_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Excisepassno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Excisepassno.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                dtp_Excisepassdate.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_Excisepassno_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub dtp_Excisepassdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Excisepassdate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                txt_Trucknumber.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : dtp_Excisepassdate_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cbo_Storelocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_Storelocation.KeyPress
        'Try
        '    If Asc(e.KeyChar) = 13 Then
        '        txt_Creditdays.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : cbo_Storelocation_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Creditdays_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            getNumeric(e)
            If Asc(e.KeyChar) = 13 Then
                ssgrid.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_Creditdays_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Totalamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Totalamt.KeyPress
        'Try
        '    getNumeric(e)
        '    If Asc(e.KeyChar) = 13 Then
        '        txt_Vatamount.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Totalamt_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Billamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            getNumeric(e)
            If Asc(e.KeyChar) = 13 Then
                Cmd_Add.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_Billamt_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_Grnnohelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Honohelp.Click
        'Try
        '    Dim cat As String
        '    'cat = substring(CMB_CATEGORY.Text, 1, 3)

        '    gSQLString = "SELECT Grndetails,Grndate,SUPPLIERNAME FROM Grn_header"
        '    M_WhereCondition = " Where Isnull(GRNTYPE,'')='GRN'  AND ISNULL(GRNDETAILS,'') LIKE '%" & Trim(CATEGORY) & "%'"
        '    Dim vform As New List_Operation
        '    vform.Field = "GRNDETAILS,GRNDATE,SUPPLIERNAME"
        '    vform.vFormatstring1 = "       GRN NO             |         GRN DATE     |     SUPPLIERNAME                                       "
        '    vform.vCaption = "GRN CUM PURCHASE BILL HELP"
        '    vform.KeyPos = 0
        '    vform.KeyPos1 = 1
        '    vform.KeyPos2 = 2
        '    vform.ShowDialog(Me)
        '    If Trim(vform.keyfield & "") <> "" Then
        '        txt_Grnno.Text = Trim(vform.keyfield & "")
        '        Call txt_Grnno_Validated(txt_Grnno.Text, e)
        '        Call Grid_lock()
        '    End If
        '    vform.Close()
        '    vform = Nothing
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : cmd_Grnnohelp_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub txt_Grnno_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Hono.Validated
        'Dim I, J, K As Integer
        'Dim vString, sqlstring As String
        'Dim GRNDATE As Date
        'Dim vTypeseqno, Clsquantity As Double
        'Dim vGroupseqno As Double
        'Dim dt As New DataTable
        'If Trim(txt_Grnno.Text) <> "" Then
        '    Try
        '        sqlstring = "SELECT  ISNULL(GRNNO,'') AS GRNNO,ISNULL(GRNDETAILS,'') AS GRNDETAILS,ISNULL(PONO,'') AS PONO,GRNDATE,ISNULL(SUPPLIERINVNO,'') AS SUPPLIERINVNO,"
        '        sqlstring = sqlstring & " SUPPLIERDATE,ISNULL(SUPPLIERCODE,'') AS SUPPLIERCODE,ISNULL(SUPPLIERNAME,'') AS SUPPLIERNAME,ISNULL(TYPECODE,'') AS TYPECODE,"
        '        sqlstring = sqlstring & " ISNULL(TYPEDESC,'') AS TYPEDESC, ISNULL(EXCISEPASSNO,'') AS EXCISEPASSNO,EXCISEDATE,STOCKINDATE,ISNULL(TRUCKNUMBER,'') AS TRUCKNUMBER,"
        '        sqlstring = sqlstring & " ISNULL(CREDITDAYS,0) AS CREDITDAYS,ISNULL(GLACCOUNTCODE,'') AS GLACCOUNTCODE,ISNULL(GLACCOUNTNAME,'') AS GLACCOUNTNAME,"
        '        sqlstring = sqlstring & " ISNULL(SLCODE,'') AS SLCODE,ISNULL(SLNAME,'') AS SLNAME,ISNULL(COSTCENTERCODE,'') AS COSTCENTERCODE,ISNULL(COSTCENTERNAME,'') AS COSTCENTERNAME,"
        '        sqlstring = sqlstring & " ISNULL(TOTALAMOUNT,0) AS TOTALAMOUNT,ISNULL(VATAMOUNT,0) AS VATAMOUNT,ISNULL(SURCHARGEAMT,0) AS SURCHARGEAMT,ISNULL(DISCOUNT,0) AS DISCOUNT,ISNULL(BILLAMOUNT,0) AS BILLAMOUNT,ISNULL(REMARKS,'') AS REMARKS,"
        '        sqlstring = sqlstring & " ISNULL(VOID,'') AS VOID,ISNULL(ADDUSER,'') AS ADDUSER,ADDDATE,ISNULL(UPDATEUSER,'') AS UPDATEUSER,UPDATETIME,"
        '        sqlstring = sqlstring & " ISNULL(STORECODE,'') STORECODE , ISNULL(STOREDESC,'MAINSTORE') STOREDESC, ISNULL(OVERALLDISCOUNT,0) OVERALLDISCOUNT,ISNULL(UPDFOOTER,'') UPDFOOTER,ISNULL(UPDNAME,'') UPDNAME FROM GRN_HEADER"
        '        sqlstring = sqlstring & " WHERE (GRNNO = '" & Format(Val(txt_Grnno.Text), "0000") & "' OR Grndetails='" & Trim(txt_Grnno.Text) & "') "
        '        sqlstring = sqlstring & " and  rtrim(substring(grndetails,5,2)) = '" & Mid(doctype, 1, 2) & "'  and  isnull(GrnType,'')='GRN'"
        '        gconnection.getDataSet(sqlstring, "GRNHEADER")
        '        '''************************************************* SELECT record from Grn_header *********************************************''''                
        '        If gdataset.Tables("GRNHEADER").Rows.Count > 0 Then
        '            Call GridUnLock()
        '            Cmd_Add.Text = "Update[F7]"
        '            Me.txt_Grnno.ReadOnly = True
        '            txt_Grnno.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("GRNDETAILS"))
        '            Txt_PONo.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("PONO"))
        '            dtp_Grndate.Value = Format(CDate(gdataset.Tables("GRNHEADER").Rows(0).Item("GRNDATE")), "dd-MMM-yyyy")
        '            txt_Supplierinvno.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("SUPPLIERINVNO"))
        '            dtp_Supplierinvdate.Value = Format(CDate(gdataset.Tables("GRNHEADER").Rows(0).Item("SUPPLIERDATE")), "dd-MMM-yyyy")
        '            txt_Suppliercode.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("SUPPLIERCODE"))
        '            txt_Suppliername.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("SUPPLIERNAME"))
        '            cbo_Billingterms.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("TYPECODE")) & "  " & Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("TYPEDESC"))
        '            txt_Excisepassno.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("EXCISEPASSNO"))
        '            dtp_Excisepassdate.Value = Format(CDate(gdataset.Tables("GRNHEADER").Rows(0).Item("EXCISEDATE")), "dd-MMM-yyyy")
        '            dtp_Stockindate.Value = Format(CDate(gdataset.Tables("GRNHEADER").Rows(0).Item("STOCKINDATE")), "dd-MMM-yyyy")
        '            txt_Trucknumber.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("TRUCKNUMBER"))
        '            txt_Creditdays.Text = Format(Val(gdataset.Tables("GRNHEADER").Rows(0).Item("CREDITDAYS")), "0")
        '            Txt_GLAcIn.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("GLACCOUNTCODE"))
        '            Txt_GLAcDesc.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("GLACCOUNTNAME"))
        '            Txt_Slcode.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("SLCODE"))
        '            Txt_SlDesc.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("SLNAME"))
        '            txt_Totalamt.Text = Format(Val(gdataset.Tables("GRNHEADER").Rows(0).Item("TOTALAMOUNT")), "0.00")
        '            txt_Storecode.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("STORECODE"))
        '            txt_StoreDesc.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("STOREDESC"))
        '            Txt_footer.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("UPDFOOTER"))
        '            Txt_signature.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("UPDNAME"))
        '            If Trim(Txt_Slcode.Text) <> "" Then
        '                grp_grnposting.Top = 218
        '                grp_grnposting.Width = 848
        '                grp_grnposting.Height = 80
        '                ssgrid.Left = 10
        '                ssgrid.Top = 312
        '                ssgrid.Height = 200
        '                Lbl_SubledgerCode.Visible = True
        '                Lbl_SubledgerName.Visible = True
        '                Txt_Slcode.Visible = True
        '                Cmd_SlCodeHelp.Visible = True
        '                Txt_SlDesc.Visible = True
        '            Else
        '                grp_grnposting.Top = 218
        '                grp_grnposting.Height = 48
        '                grp_grnposting.Width = 848
        '                ssgrid.Top = 272
        '                ssgrid.Left = 10
        '                ssgrid.Height = 255
        '                'ssgrid.Height = 264
        '            End If
        '            Txt_CostCenterCode.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("COSTCENTERCODE"))
        '            Txt_CostCenterDesc.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("COSTCENTERNAME"))
        '            If Trim(Txt_CostCenterCode.Text) <> "" And Trim(Txt_Slcode.Text) <> "" Then
        '                Lbl_CostCenterCode.Visible = True
        '                Lbl_CostCenterDesc.Visible = True
        '                Txt_CostCenterCode.Visible = True
        '                Txt_CostCenterDesc.Visible = True

        '                grp_grnposting.Top = 218
        '                grp_grnposting.Height = 120
        '                grp_grnposting.Width = 848
        '                ssgrid.Top = 344
        '                ssgrid.Left = 10
        '                ssgrid.Height = 200
        '                lbl_Creditdays.Top = 280
        '                lbl_Creditdays.Left = 504
        '                txt_Creditdays.Top = 280
        '                txt_Creditdays.Left = 672
        '            ElseIf Trim(Txt_CostCenterCode.Text) = "" And Trim(Txt_Slcode.Text) <> "" Then
        '                grp_grnposting.Top = 218
        '                grp_grnposting.Width = 848
        '                grp_grnposting.Height = 80
        '                ssgrid.Left = 10
        '                ssgrid.Top = 272
        '                ssgrid.Height = 224
        '                Lbl_SubledgerCode.Visible = True
        '                Lbl_SubledgerName.Visible = True
        '                Txt_Slcode.Visible = True
        '                Cmd_SlCodeHelp.Visible = True
        '                Txt_SlDesc.Visible = True
        '            Else
        '                grp_grnposting.Top = 218
        '                grp_grnposting.Height = 48
        '                grp_grnposting.Width = 848
        '                ssgrid.Top = 272
        '                ssgrid.Left = 10
        '                ssgrid.Height = 255
        '            End If
        '            TXT_OVERALLdiscount.Text = Format(Val(gdataset.Tables("GRNHEADER").Rows(0).Item("OVERALLdiscount")), "0.00")
        '            txt_Discountamt.Text = Format(Val(gdataset.Tables("GRNHEADER").Rows(0).Item("DISCOUNT")), "0.00")
        '            txt_Vatamount.Text = Format(Val(gdataset.Tables("GRNHEADER").Rows(0).Item("VATAMOUNT")), "0.00")
        '            txt_Surchargeamt.Text = Format(Val(gdataset.Tables("GRNHEADER").Rows(0).Item("SURCHARGEAMT")), "0.00")
        '            txt_Billamount.Text = Format(Val(gdataset.Tables("GRNHEADER").Rows(0).Item("BILLAMOUNT")), "0.00")
        '            txt_Remarks.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("REMARKS"))
        '            If Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("VOID")) = "Y" Then
        '                Cmd_Add.Enabled = False
        '                Cmd_Freeze.Enabled = False
        '            End If
        '            '''************************************************* SELECT record from Grn_details *********************************************''''                
        '            Dim vtmpitemcode, strsql As String
        '            sqlstring = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM,"
        '            sqlstring = sqlstring & " ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE,ISNULL(DISCOUNT,0) AS DISCOUNT,ISNULL(PROFITPER,0) AS PROFITPER,ISNULL(TAXPER,0) AS TAXPER,ISNULL(TAXAMOUNT,0) AS TAXAMOUNT,ISNULL(AMOUNT,0) AS AMOUNT,ISNULL(SALERATE,0) AS SALERATE,ISNULL(CATEGORY,'')AS CATEGORY,"
        '            sqlstring = sqlstring & " ISNULL(DBLAMOUNT,0) AS DBLAMOUNT,ISNULL(DBLUOM,'') AS DBLUOM,ISNULL(HIGHRATIO,0) AS HIGHRATIO,ISNULL(VOIDITEM,'') AS VOIDITEM , isnull(OTHCHARGE,0) AS OTHCHARGE,ISNULL(FREEQTY,0) AS FREEQTY FROM GRN_DETAILS WHERE  GRNDETAILS ='" & Trim(txt_Grnno.Text) & "'"
        '            sqlstring = sqlstring & " ORDER BY AUTOID "
        '            gconnection.getDataSet(sqlstring, "GRNDETAILS")
        '            If gdataset.Tables("GRNDETAILS").Rows.Count > 0 Then
        '                For I = 1 To gdataset.Tables("GRNDETAILS").Rows.Count
        '                    ssgrid.SetText(1, I, Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("ITEMCODE")))
        '                    vtmpitemcode = Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("ITEMCODE"))
        '                    ssgrid.SetText(2, I, Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("ITEMNAME")))
        '                    ssgrid.Col = 3
        '                    ssgrid.Row = I
        '                    ssgrid.TypeComboBoxString = Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("UOM"))
        '                    ssgrid.Text = Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("UOM"))
        '                    ssgrid.SetText(4, I, Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("QTY")))
        '                    ssgrid.SetText(5, I, Format(Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("RATE")), "0.00"))
        '                    ssgrid.SetText(6, I, Format(Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("DISCOUNT")), "0.00"))
        '                    ssgrid.SetText(7, I, Format(Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("PROFITPER")), "0.00"))
        '                    ssgrid.SetText(8, I, Format(Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("TAXPER")), "0.00"))
        '                    ssgrid.SetText(9, I, Format(Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("TAXAMOUNT")), "0.00"))
        '                    ssgrid.SetText(10, I, Format(Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("AMOUNT")), "0.00"))
        '                    ssgrid.SetText(11, I, Format(Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("SALERATE")), "0.00"))
        '                    ssgrid.SetText(12, I, Format(Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("DBLAMOUNT")), "0.00"))
        '                    ssgrid.SetText(13, I, Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("DBLUOM")))
        '                    'ssgrid.SetText(14, I, Format(Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("HIGHRATIO")), "0.00"))
        '                    ssgrid.SetText(15, I, Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("QTY")))
        '                    ssgrid.SetText(17, I, Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("othcharge")))
        '                    ssgrid.SetText(18, I, Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("FREEQTY")))
        '                    GRNDATE = Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy")
        '                    'It's getting so late so commanded

        '                    Clsquantity = ClosingQuantity_Date(vtmpitemcode, Trim(txt_Storecode.Text), Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("UOM")), GRNDATE)
        '                    Clsquantity = ClosingQuantity(vtmpitemcode, GetMainStore())
        '                    ssgrid.SetText(16, I, Clsquantity)
        '                    CMB_CATEGORY.Text = gdataset.Tables("GRNDETAILS").Rows(J).Item("CATEGORY")
        '                    J = J + 1
        '                Next
        '            End If
        '            TotalCount = gdataset.Tables("GRNDETAILS").Rows.Count
        '            ssgrid.SetActiveCell(1, 1)
        '            sqlstring = "SELECT ISNULL(BillTerms,'') AS BillTerms,ISNULL(Percentage,0) AS Percentage,ISNULL(TaxCode,'') AS Taxcode,ISNULL(Amount,0) AS Amount,ISNULL(SlNo,0) AS SlNo,ISNULL(Formula,'')AS Formula,"
        '            sqlstring = sqlstring & "ISNULL(Signs,'') AS Signs,ISNULL(Accode,'') AS Accode,ISNULL(Acdesc,'') AS Acdesc FROM grn_billterms WHERE  Grndetails='" & Trim(txt_Grnno.Text) & "' ORDER BY AUTOID"
        '            gconnection.getDataSet(sqlstring, "grn_billterms")
        '            If gdataset.Tables("grn_billterms").Rows.Count > 0 Then
        '                For I = 1 To gdataset.Tables("grn_billterms").Rows.Count
        '                    ssgrid_billdetails.SetText(1, I, Trim(gdataset.Tables("grn_billterms").Rows(K).Item("BillTerms")))
        '                    ssgrid_billdetails.SetText(2, I, Format(Val(gdataset.Tables("grn_billterms").Rows(K).Item("Percentage")), "0.00"))
        '                    ssgrid_billdetails.SetText(3, I, Trim(gdataset.Tables("grn_billterms").Rows(K).Item("Taxcode")))
        '                    ssgrid_billdetails.SetText(4, I, Format(Val(gdataset.Tables("grn_billterms").Rows(K).Item("Amount")), "0.00"))
        '                    ssgrid_billdetails.SetText(5, I, Format(Val(gdataset.Tables("grn_billterms").Rows(K).Item("SlNo")), "0"))
        '                    ssgrid_billdetails.SetText(6, I, Trim(gdataset.Tables("grn_billterms").Rows(K).Item("Formula")))
        '                    ssgrid_billdetails.SetText(7, I, Trim(gdataset.Tables("grn_billterms").Rows(K).Item("Signs")))
        '                    ssgrid_billdetails.SetText(8, I, Trim(gdataset.Tables("grn_billterms").Rows(K).Item("Accode")))
        '                    ssgrid_billdetails.SetText(9, I, Trim(gdataset.Tables("grn_billterms").Rows(K).Item("Acdesc")))
        '                    K = K + 1
        '                Next
        '            End If
        '            If gUserCategory <> "S" Then
        '                Call GetRights()
        '            End If
        '        End If
        '    Catch ex As Exception
        '        MessageBox.Show("Enter valid GRN No : txt_Grnno_Validated" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '        Exit Sub
        '    End Try
        'End If
    End Sub
    '    Private Sub cmd_Suppliercodehelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Suppliercodehelp.Click
    '        Try
    '            gSQLString = "SELECT SLCODE,SLNAME FROM accountssubledgermaster "
    '            M_WhereCondition = " WHERE ACCODE IN ('" & Trim(gCreditors) & "') "
    '            Dim vform As New ListOperattion1
    '            vform.Field = "SLNAME,SLCODE"
    '            vform.vFormatstring = "       SLCODE                    |                      SLNAME                                                                                                          "
    '            vform.vCaption = "SUB LEDGER MASTER HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                txt_Suppliercode.Text = Trim(vform.keyfield & "")
    '                Call txt_Suppliercode_Validated(txt_Suppliercode, e)
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : cmd_Suppliercodehelp_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub


    '    Private Sub txt_Grnno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Hono.KeyDown
    '        Try
    '            If e.KeyCode = Keys.F4 Then
    '                If cmd_Grnnohelp.Enabled = True Then
    '                    search = Trim(txt_Grnno.Text)
    '                    Call cmd_Grnnohelp_Click(cmd_Grnnohelp, e)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Grnno_KeyDown" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub


    '    Private Sub PO_HireOrder_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
    '        Try
    '            If e.KeyCode = Keys.F6 Then
    '                Call Cmd_Clear_Click(Cmd_Clear, e)
    '                Exit Sub
    '            ElseIf e.KeyCode = Keys.F8 Then
    '                Call Cmd_Freeze_Click(Cmd_Freeze, e)
    '                Exit Sub
    '            ElseIf e.KeyCode = Keys.F2 Then
    '                txt_Grnno.Text = ""
    '                txt_Grnno.Focus()
    '                Exit Sub
    '            ElseIf e.KeyCode = Keys.F7 Then
    '                Call Cmd_Add_Click(Cmd_Add, e)
    '                Exit Sub
    '            ElseIf e.KeyCode = Keys.F9 Then
    '                Call Cmd_View_Click(Cmd_View, e)
    '                Exit Sub
    '            ElseIf e.KeyCode = Keys.F11 Then
    '                Call Cmd_Exit_Click(Cmd_Exit, e)
    '                Exit Sub
    '            ElseIf e.KeyCode = Keys.F12 Then
    '                Call billingterms()
    '                Exit Sub
    '            ElseIf e.KeyCode = Keys.Escape Then
    '                If grp_Excisedetails.Top = 104 Then
    '                    grp_Excisedetails.Top = 1000
    '                    dtp_Supplierinvdate.Focus()
    '                    Exit Sub
    '                ElseIf grp_Billingdetails.Top = 144 Then
    '                    grp_Billingdetails.Top = 1000
    '                    txt_Remarks.Focus()
    '                    Exit Sub
    '                ElseIf grp_StockGrndetails.Top = 176 Then
    '                    grp_StockGrndetails.Top = 1000
    '                    Cmd_View.Focus()
    '                    Exit Sub
    '                Else
    '                    Call Cmd_Exit_Click(Cmd_Exit, e)
    '                    Exit Sub
    '                End If
    '            ElseIf e.Alt = True And e.KeyCode = Keys.R Then
    '                Me.txt_Remarks.Focus()
    '                Exit Sub
    '            ElseIf e.Alt = True And e.KeyCode = Keys.D Then
    '                Me.txt_Discountamt.Focus()
    '                Exit Sub
    '            ElseIf e.Alt = True And e.KeyCode = Keys.G Then
    '                Me.ssgrid.Focus()
    '                Me.ssgrid.SetActiveCell(1, 1)
    '                Exit Sub
    '            ElseIf e.Alt = True And e.KeyCode = Keys.V Then
    '                Me.txt_Vatamount.Focus()
    '                Exit Sub
    '            ElseIf e.Alt = True And e.KeyCode = Keys.N Then
    '                Me.txt_Grnno.Focus()
    '                Exit Sub
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : PO_HireOrder_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub autogenerate()
    '        Try
    '            Dim sqlstring, financalyear As String
    '            Dim month As String
    '            Dim CATLEN As Integer

    '            month = UCase(Format(Now, "MMM"))
    '            gcommand = New SqlCommand
    '            financalyear = Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 3, 2)

    '            sqlstring = "SELECT ISNULL(CATEGORY,'') AS CATEGORY FROM INVENTORYITEMMASTER WHERE ISNULL(CATEGORY,'')='" & Trim(CMB_CATEGORY.Text & "") & "' GROUP BY CATEGORY"
    '            gconnection.getDataSet(sqlstring, "CATEGORY")
    '            If gdataset.Tables("CATEGORY").Rows.Count > 0 Then
    '                CATEGORY = Mid(Trim(gdataset.Tables("CATEGORY").Rows(0).Item("CATEGORY") & ""), 1, 3)
    '                CATLEN = Len(Trim(CATEGORY))
    '            Else
    '                CATLEN = 3
    '                CATEGORY = month
    '            End If
    '            sqlstring = "SELECT MAX(Cast(SUBSTRING(GRNNO,1,6) As Numeric)) FROM GRN_HEADER WHERE SUBSTRING(GRNDETAILS,5," & CATLEN & ")='" & CATEGORY & "'  AND ISNULL(GRNTYPE,'')='GRN'"
    '            '        sqlstring = "SELECT MAX(Cast(SUBSTRING(GRNNO,1,6) As Numeric)) FROM GRN_HEADER"
    '            gconnection.openConnection()
    '            gcommand.CommandText = sqlstring
    '            gcommand.CommandType = CommandType.Text
    '            gcommand.Connection = gconnection.Myconn
    '            gdreader = gcommand.ExecuteReader
    '            If gdreader.Read Then
    '                If gdreader(0) Is System.DBNull.Value Then
    '                    txt_Grnno.Text = "GRN/" & CATEGORY & "/" & "0001/" & financalyear
    '                    gdreader.Close()
    '                    gcommand.Dispose()
    '                    gconnection.closeConnection()
    '                Else
    '                    txt_Grnno.Text = "GRN/" & CATEGORY & "/" & Format(gdreader(0) + 1, "0000") & "/" & financalyear
    '                    gdreader.Close()
    '                    gcommand.Dispose()
    '                    gconnection.closeConnection()
    '                End If
    '            Else
    '                txt_Grnno.Text = "GRN/" & CATEGORY & "/0001/" & financalyear
    '                gdreader.Close()
    '                gcommand.Dispose()
    '                gconnection.closeConnection()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : autogenerate" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub Calculate()
    '        Try
    '            Dim ValQty, ValRate, ValDiscount, VarTotal As Double
    '            Dim ValHighratio, ValItemamount, ValDblamount As Double
    '            Dim VALTAXPER, VALTAXAMOUNT, VALPROFITPER As Double
    '            Dim VALSAL1, VALSAL2, VALSAL, ValOthchrg As Double
    '            Dim i As Integer
    '            If ssgrid.ActiveCol = 1 Or ssgrid.ActiveCol = 2 Or ssgrid.ActiveCol = 3 Or ssgrid.ActiveCol = 4 Or ssgrid.ActiveCol = 5 Or ssgrid.ActiveCol = 6 Or ssgrid.ActiveCol = 7 Or ssgrid.ActiveCol = 8 Then
    '                i = ssgrid.ActiveRow
    '                ssgrid.Col = 4
    '                ssgrid.Row = i
    '                ValQty = Val(ssgrid.Text)
    '                ssgrid.Col = 5
    '                ssgrid.Row = i
    '                ValRate = Val(ssgrid.Text)
    '                ssgrid.Col = 6
    '                ssgrid.Row = i
    '                ValDiscount = Val(ssgrid.Text)
    '                ssgrid.Col = 7
    '                ssgrid.Row = i
    '                VALPROFITPER = Val(ssgrid.Text)
    '                ssgrid.Col = 8
    '                ssgrid.Row = i
    '                VALTAXPER = Val(ssgrid.Text)

    '                ssgrid.Col = 14
    '                ssgrid.Row = i
    '                ValHighratio = Val(ssgrid.Text())

    '                'ssgrid.Col = 17
    '                'ssgrid.Row = i
    '                'ValOthchrg = Val(ssgrid.Text())

    '                ValItemamount = Format(Val(ValQty) * Val(ValRate), "0.00")
    '                ValDblamount = Format(Val(ValQty) * Val(ValHighratio), "0.00")
    '                VALTAXAMOUNT = (ValItemamount - ValDiscount) * (VALTAXPER / 100)
    '                '************** FOR RSI CLUB ********************
    '                VALSAL1 = ((ValItemamount + VALTAXAMOUNT + ValOthchrg) - (ValDiscount)) / ValQty
    '                VALSAL2 = ((((ValItemamount + VALTAXAMOUNT + ValOthchrg) - (ValDiscount)) / ValQty) * (VALPROFITPER)) / 100
    '                VALSAL = Val(VALSAL1) + Val(VALSAL2)
    '                Dim a, b As String

    '                ssgrid.Col = 1
    '                ssgrid.Row = i
    '                icode1 = Trim(ssgrid.Text)
    '                If Mid(Trim(CStr(icode1)), 1, 2) = "B0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W1" Or Mid(Trim(CStr(icode1)), 1, 2) = "W2" Or Mid(Trim(CStr(icode1)), 1, 2) = "W3" Or Mid(Trim(CStr(icode1)), 1, 1) = "G" Or Mid(Trim(CStr(icode1)), 1, 2) = "L0" Or Mid(Trim(CStr(icode1)), 1, 1) = "R" Or Mid(Trim(CStr(icode1)), 1, 1) = "V" Then
    '                    Real = VALSAL / 12.5
    '                    'Call SRound(Real)
    '                    'Label21.Text = "PEG RATE = " & Format(Math.Round(Val(a)))
    '                    'Label21.Text = "PEG RATE = " & Real1
    '                    If Val(VALSAL) = 0 Then
    '                        ssgrid.SetText(11, i, "")
    '                    Else
    '                        ssgrid.SetText(11, i, Val(Real))
    '                    End If
    '                    'Real = VALSAL / 25
    '                    'Call SRound(Real)
    '                    'Label22.Text = "SMALL RATE = " & Real1
    '                Else
    '                    If Val(VALSAL) = 0 Then
    '                        ssgrid.SetText(11, i, "")
    '                    Else
    '                        ssgrid.SetText(11, i, Val(VALSAL))
    '                    End If
    '                End If
    '                If Val(ValItemamount) = 0 Then
    '                    ssgrid.SetText(10, i, "")
    '                    ssgrid.SetText(12, i, "")
    '                Else
    '                    ssgrid.SetText(10, i, Val(ValItemamount))
    '                    ssgrid.SetText(12, i, Val(ValDblamount))
    '                End If
    '                If Val(VALTAXAMOUNT) = 0 Then
    '                    ssgrid.SetText(9, i, "")
    '                Else
    '                    ssgrid.SetText(9, i, Val(VALTAXAMOUNT))
    '                End If
    '                'If Val(VALSAL) = 0 Then
    '                '    ssgrid.SetText(11, i, "")
    '                'Else
    '                '    ssgrid.SetText(11, i, Val(VALSAL))
    '                'End If

    '                Me.txt_Totalamt.Text = 0
    '                Me.txt_Vatamount.Text = 0
    '                Me.txt_Discountamt.Text = 0
    '                Me.txt_Billamount.Text = 0
    '                ValDiscount = 0 : VarTotal = 0 : VALTAXAMOUNT = 0
    '                For i = 1 To ssgrid.DataRowCnt
    '                    ssgrid.Col = 6
    '                    ssgrid.Row = i
    '                    ValDiscount = Val(ssgrid.Text)
    '                    ssgrid.Col = 9
    '                    ssgrid.Row = i
    '                    VALTAXAMOUNT = Val(ssgrid.Text)

    '                    ssgrid.Col = 10
    '                    ssgrid.Row = i
    '                    VarTotal = Val(ssgrid.Text)

    '                    Me.txt_Discountamt.Text = Format(Val(Me.txt_Discountamt.Text) + Val(ValDiscount), "0.00")
    '                    Me.txt_Vatamount.Text = Format(Val(Me.txt_Vatamount.Text) + Val(VALTAXAMOUNT), "0.00")
    '                    Me.txt_Totalamt.Text = Format(Val(Me.txt_Totalamt.Text) + Val(VarTotal), "0.00")
    '                    Me.txt_Billamount.Text = Format((Val(Me.txt_Totalamt.Text) + Val(Me.txt_Vatamount.Text)) - Val(Me.txt_Discountamt.Text), "0.00")


    '                Next i
    '                '                Me.txt_Billamount.Text = Format(Val(Me.txt_Totalamt.Text) - Val(Me.TXT_OVERALLdiscount.Text))
    '                Me.txt_Billamount.Text = Format((Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text)) - (Val(txt_Discountamt.Text) + Val(TXT_OVERALLdiscount.Text)), "0.00")
    '                i = i - 1
    '            End If
    '            Call calc_billamt()

    '            Dim Oth_grossAmt, tempSurcharge As Double
    '            Dim x As Integer
    '            For x = 1 To ssgrid.DataRowCnt
    '                ValDiscount = 0 : VarTotal = 0 : VALTAXAMOUNT = 0 : tempSurcharge = 0 : Oth_grossAmt = 0
    '                ssgrid.Col = 6
    '                ssgrid.Row = x
    '                ValDiscount = Val(ssgrid.Text)
    '                ssgrid.Col = 9
    '                ssgrid.Row = x
    '                VALTAXAMOUNT = Val(ssgrid.Text)

    '                ssgrid.Col = 10
    '                ssgrid.Row = x
    '                VarTotal = Val(ssgrid.Text)

    '                'Othercharges col in grid
    '                ssgrid.Col = 17
    '                ssgrid.Row = x
    '                tempSurcharge = Val(txt_Surchargeamt.Text) / Val(txt_Totalamt.Text)
    '                tempSurcharge = tempSurcharge - (Val(TXT_OVERALLdiscount.Text) / Val(txt_Totalamt.Text))
    '                Oth_grossAmt = (VarTotal) * tempSurcharge
    '                If Val(txt_Surchargeamt.Text) <> 0 Or Val(TXT_OVERALLdiscount.Text) <> 0 Then
    '                    ssgrid.Text = Oth_grossAmt
    '                Else
    '                    ssgrid.Text = "0.00"
    '                End If
    '            Next x

    '            Dim checkother, diffamt As Double
    '            checkother = 0 : diffamt = 0

    '            For x = 1 To ssgrid.DataRowCnt
    '                ValDiscount = 0 : VarTotal = 0 : VALTAXAMOUNT = 0 : tempSurcharge = 0 : Oth_grossAmt = 0
    '                ssgrid.Col = 6
    '                ssgrid.Row = x
    '                ValDiscount = Val(ssgrid.Text)
    '                ssgrid.Col = 9
    '                ssgrid.Row = x
    '                VALTAXAMOUNT = Val(ssgrid.Text)

    '                ssgrid.Col = 10
    '                ssgrid.Row = x
    '                VarTotal = Val(ssgrid.Text)

    '                ssgrid.Col = 17
    '                ssgrid.Row = x
    '                checkother = checkother + Val(ssgrid.Text)

    '                If x = ssgrid.DataRowCnt Then
    '                    If checkother <> Val(txt_Surchargeamt.Text) - Val(TXT_OVERALLdiscount.Text) Then
    '                        diffamt = checkother - (Val(txt_Surchargeamt.Text) - Val(TXT_OVERALLdiscount.Text))
    '                        ssgrid.Text = ssgrid.Text - diffamt
    '                    End If
    '                End If
    '            Next x

    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Calculate" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub checkValidation()
    '        Try
    '            boolchk = False
    '            '''**************************************** Check DATEVALIDATION *******************************************''
    '            Call Checkdatevalidate(Format(dtp_Grndate.Value, "dd-MMM-yyyy"))
    '            If chkdatevalidate = False Then Exit Sub
    '            '''**************************************** Check GRN NO. can't be blank *******************************************''
    '            If Trim(txt_Grnno.Text) = "" Then
    '                MessageBox.Show("GRN NO. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '                txt_Grnno.Focus()
    '                Exit Sub
    '            End If
    '            '''**************************************** Check SUPPLIER INVOICENO. can't be blank *******************************************''
    '            If Trim(txt_Supplierinvno.Text) = "" Then
    '                MessageBox.Show("Supplier Invoice no. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '                txt_Supplierinvno.Focus()
    '                Exit Sub
    '            End If
    '            '''**************************************** Check SUPPLIER CODE can't be blank *******************************************''
    '            If Trim(txt_Suppliercode.Text) = "" Then
    '                MessageBox.Show("Supplier Code Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '                txt_Suppliercode.Focus()
    '                Exit Sub
    '            End If
    '            '''**************************************** Check SUPPLIER NAME can't be blank *******************************************''
    '            If Trim(txt_Suppliername.Text) = "" Then
    '                MessageBox.Show("Supplier Name Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '                txt_Suppliername.Focus()
    '                Exit Sub
    '            End If

    '            sqlstring = "SELECT ISNULL(CATEGORY,'') AS CATEGORY FROM INVENTORYITEMMASTER WHERE ISNULL(CATEGORY,'')='" & Trim(CMB_CATEGORY.Text & "") & "' GROUP BY CATEGORY"
    '            gconnection.getDataSet(sqlstring, "CATEGORY")
    '            If gdataset.Tables("CATEGORY").Rows.Count <= 0 Then
    '                MsgBox("Select Valid Category....", MsgBoxStyle.OKOnly, "Category")
    '                CMB_CATEGORY.Focus()
    '            End If

    '            '''**************************************** Check TOTAL AMOUNT can't be blank *******************************************''
    '            If Trim(txt_Totalamt.Text) = "" Then
    '                MessageBox.Show("Total Amount Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '                txt_Totalamt.Focus()
    '                Exit Sub
    '            End If
    '            '''**************************************** Check BILL AMOUNT can't be blank *******************************************''
    '            'DISABLE GLACCOUNT

    '            'If Trim(Txt_GLAcIn.Text) = "" Then
    '            '    MessageBox.Show("GLAcin cannot be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            '    Txt_GLAcIn.Focus()
    '            '    Exit Sub
    '            'End If

    '            If Trim(Txt_Slcode.Text) = "" And slcodestatus = True Then
    '                MessageBox.Show("Slcode cannot be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '                Txt_GLAcIn.Focus()
    '                Exit Sub
    '            End If
    '            If Trim(Txt_CostCenterCode.Text) = "" And costcentercodestatus = True Then
    '                MessageBox.Show("Costcentercode cannot be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '                Txt_GLAcIn.Focus()
    '                Exit Sub
    '            End If
    '            '''********************************************* Check ssgrid value can't be blank ********************************************'''
    '            For i = 1 To ssgrid.DataRowCnt
    '                ssgrid.Row = i
    '                ssgrid.Col = 1
    '                If Trim(ssgrid.Text) = "" Then
    '                    MessageBox.Show("Item Code can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '                    ssgrid.Focus()
    '                    Exit Sub
    '                End If
    '                ssgrid.Col = 2
    '                If Trim(ssgrid.Text) = "" Then
    '                    MessageBox.Show("Item Description can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '                    ssgrid.SetActiveCell(2, ssgrid.ActiveRow)
    '                    ssgrid.Focus()
    '                    Exit Sub
    '                End If
    '                ssgrid.Col = 3
    '                If Trim(ssgrid.Text) = "" Then
    '                    MessageBox.Show("UOM can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '                    ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                    ssgrid.Focus()
    '                    Exit Sub
    '                End If
    '                ssgrid.Col = 4
    '                If Val(ssgrid.Text) = 0 Then
    '                    MessageBox.Show("Quantity can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '                    ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                    ssgrid.Focus()
    '                    Exit Sub
    '                End If
    '                ssgrid.Col = 5
    '                If Val(ssgrid.Text) = 0 Then
    '                    MessageBox.Show("Rate can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '                    ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
    '                    ssgrid.Focus()
    '                    Exit Sub
    '                End If
    '                ssgrid.Col = 10
    '                If Val(ssgrid.Text) = 0 Then
    '                    MessageBox.Show("Amount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '                    ssgrid.SetActiveCell(9, ssgrid.ActiveRow)
    '                    ssgrid.Focus()
    '                    Exit Sub
    '                End If
    '            Next
    '            If Cmd_Add.Text = "Update[F7]" And Me.lbl_Grn.Text = "Bill Generated" Then
    '                If Me.ssgrid.DataRowCnt > TotalCount Then
    '                    MsgBox("GRN Has Been Generated You Can Not Add More Item", MsgBoxStyle.Exclamation, MyCompanyName)
    '                    Exit Sub
    '                End If
    '            End If

    '            ''''**********ACCOUNTS POSTING VALIDATION -VENUJD
    '            sqlstring = "SELECT ISNULL(POSTINGFLAG,'') AS POSTINGFLAG FROM GRN_HEADER WHERE ISNULL(GRNDETAILS,'')='" & Trim(txt_Grnno.Text & "") & "' "
    '            gconnection.getDataSet(sqlstring, "GRN_HEADER")
    '            If gdataset.Tables("grn_header").Rows.Count > 0 Then
    '                If gdataset.Tables("GRN_HEADER").Rows(0).Item("POSTINGFLAG") = "Y" Then
    '                    MsgBox("SORRY ACCOUNTS POSTING DONE....", MsgBoxStyle.OKOnly, "GRN_HEADER")
    '                    Exit Sub
    '                End If
    '            End If
    '            ''''**********check if the bill is matched
    '            Dim strsql As String
    '            strsql = "select count(*) as count from matching where avoucherno='" & Trim(txt_Grnno.Text) & "' "
    '            gconnection.getDataSet(strsql, "matching")
    '            If gdataset.Tables("matching").Rows.Count > 0 Then
    '                If gdataset.Tables("matching").Rows(0).Item("Count") >= 1 Then
    '                    MsgBox("Bill is Already Matched ..." & vbCrLf & "You Cannot Modify the Bill", MsgBoxStyle.Exclamation, MyCompanyName)
    '                    boolchk = False
    '                    Exit Sub
    '                End If
    '            End If
    '            boolchk = True
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : checkValidation" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub FillMenu()
    '        Try
    '            Dim vform As New ListOperattion1
    '            Dim K As Integer
    '            '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
    '            gSQLString = "SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, "
    '            gSQLString = gSQLString & " ISNULL(CONVVALUE,0) AS CONVUOM FROM INVENTORYITEMMASTER I"
    '            If Trim(search) = " " Then
    '                M_WhereCondition = ""
    '            Else
    '                M_WhereCondition = " WHERE I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE='" & txt_Storecode.Text & "'"
    '            End If
    '            vform.Field = " ITEMNAME,ITEMCODE"
    '            vform.vFormatstring = "    ITEMCODE    |                     ITEMNAME                    |  STOCKUOM  | PURCHASERATE | CONVUOM | HIGHRATIO |"
    '            vform.vCaption = "INVENTORY ITEM CODE HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.KeyPos2 = 2
    '            vform.Keypos3 = 3
    '            vform.keypos4 = 4
    '            'vform.Keypos5 = 5
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                ssgrid.Col = 1
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield)
    '                ssgrid.Col = 2
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield1)
    '                ssgrid.Col = 3
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.TypeComboBoxString = Trim(vform.keyfield2)
    '                ssgrid.Text = Trim(vform.keyfield2)
    '                ssgrid.Col = 5
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Format(Val(vform.keyfield3), "0.00")
    '                ssgrid.Col = 13
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield4)
    '                ssgrid.Col = 14
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Format(Val(vform.keyfield5), "0.00")
    '                ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                ssgrid.Focus()
    '            Else
    '                ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
    '                Exit Sub
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : FillMenu" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub FillMenuItem()
    '        Try
    '            Dim vform As New ListOperattion1
    '            Dim K As Integer
    '            Dim ssql As String
    '            '''******************************************************** $ FILL THE ITEMDESC,ITEMCODE INTO SSGRID ********** 
    '            gSQLString = "SELECT DISTINCT ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.ITEMCODE,'') AS ITEMCODE,"
    '            gSQLString = gSQLString & "ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, "
    '            gSQLString = gSQLString & " ISNULL(CONVVALUE,0) AS CONVVALUE FROM INVENTORYITEMMASTER AS I"
    '            If Trim(search) = " " Then
    '                M_WhereCondition = ""
    '            Else
    '                M_WhereCondition = " WHERE I.ITEMNAME LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'  AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "'"
    '            End If
    '            vform.Field = "I.ITEMNAME,I.ITEMCODE"
    '            vform.vFormatstring = "                     ITEMNAME                |   ITEMCODE    | STOCKUOM  |PURCHASERATE | CONVUOM | HIGHRATIO |"
    '            vform.vCaption = "INVENTORY ITEM CODE HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.KeyPos2 = 2
    '            vform.Keypos3 = 3
    '            vform.keypos4 = 4
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                ssgrid.Col = 1
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield1)
    '                ssgrid.Col = 2
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield)
    '                ssgrid.Col = 3
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.TypeComboBoxString = Trim(vform.keyfield2)
    '                ssgrid.Text = Trim(vform.keyfield2)
    '                ssgrid.Col = 5
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Format(Val(vform.keyfield3), "0.00")
    '                ssgrid.Col = 13
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield4)
    '                ssgrid.Col = 14
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Format(Val(vform.keyfield5), "0.00")
    '                ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                ssgrid.Focus()
    '            Else
    '                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '                Exit Sub
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : FillMenuItem" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_Totalamt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Totalamt.LostFocus
    '        Try
    '            txt_Totalamt.Text = Format(Val(txt_Totalamt.Text), "0.00")
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Totalamt_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Discountamt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Discountamt.LostFocus
    '        Try
    '            If Val(txt_Discountamt.Text) <> 0 Then
    '                txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
    '            End If
    '            txt_Discountamt.Text = Format(Val(txt_Discountamt.Text), "0.00")
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Discountamt_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Supplierinvno_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Supplierinvno.LostFocus
    '        Try
    '            Call supplerinvno()
    '            txt_Supplierinvno.BackColor = Color.Wheat
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Supplierinvno_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub supplerinvno()
    '        Try
    '            If Trim(txt_Supplierinvno.Text) = "" Then
    '                txt_Supplierinvno.Text = Trim(txt_Grnno.Text)
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : supplerinvno" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub FillStore()
    '        Try
    '            Dim i As Integer
    '            sqlstring = "SELECT distinct(Storedesc) FROM StoreMaster ORDER BY Storedesc ASC"
    '            gconnection.getDataSet(sqlstring, "StoreMaster")
    '            cbo_Storelocation.Items.Clear()
    '            cbo_Storelocation.Sorted = True
    '            If gdataset.Tables("StoreMaster").Rows.Count > 0 Then
    '                For i = 0 To gdataset.Tables("StoreMaster").Rows.Count - 1
    '                    cbo_Storelocation.Items.Add(gdataset.Tables("StoreMaster").Rows(i).Item("Storedesc"))
    '                Next i
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : FillStore" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Public Function CreateListBox()
    '        Try
    '            Listbox = New System.Windows.Forms.ListBox
    '            Listbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    '            Listbox.Location = New System.Drawing.Point(1000, 1000)
    '            Listbox.Name = "ListViewHelp"
    '            Listbox.Size = New System.Drawing.Size(10, 10)
    '            Listbox.TabIndex = 29
    '            Listbox.ScrollAlwaysVisible = False
    '            Listbox.HorizontalScrollbar = False
    '            Me.Controls.Add(Listbox)
    '            Listbox.BringToFront()
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : CreateListBox" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Function
    '        End Try
    '    End Function
    '    Public Function TextBoxKeydownevent(ByVal e As System.Windows.Forms.KeyEventArgs, ByVal ObjTextBox As TextBox)
    '        If e.KeyCode = Keys.Down Then
    '            Try
    '                Listbox.SelectedIndex = Listbox.SelectedIndex + 1
    '            Catch ex As Exception
    '                Listbox.SelectedIndex = 0
    '            End Try
    '        End If
    '        If e.KeyCode = Keys.Up Then
    '            Try
    '                Listbox.SelectedIndex = Listbox.SelectedIndex - 1
    '            Catch ex As Exception
    '                Listbox.SelectedIndex = Listbox.Items.Count - 1
    '            End Try
    '        End If
    '        If e.KeyCode = Keys.Enter Then
    '            ObjTextBox.Text = Listbox.SelectedItem()
    '            Listbox.Location = New System.Drawing.Point(1000, 1000)
    '        End If
    '        If e.KeyCode = Keys.Escape Then
    '            Listbox.Location = New System.Drawing.Point(1000, 1000)
    '            ObjTextBox.Focus()
    '        End If
    '    End Function
    '    Public Function TextBoxTextchangeevent(ByVal e As System.EventArgs, ByVal ObjTextBox As TextBox, ByVal Sqlstring As String, ByVal Tablename As String, ByVal ds As DataSet)
    '        Try
    '            gadapter = New SqlDataAdapter(Sqlstring, gconnection.Myconn)
    '            If ds.Tables.Contains(Tablename) = True Then
    '                ds.Tables.Remove(Tablename)
    '            End If
    '            gadapter.Fill(ds, Tablename)
    '            Call TextBoxHelp(ObjTextBox, Tablename, ds)
    '        Catch ex As Exception
    '            Exit Function
    '        End Try
    '    End Function
    '    Public Function TextBoxHelp(ByVal ObjTextBox As TextBox, ByVal Tablename As String, ByVal ds As DataSet)
    '        Dim drow As DataRow
    '        Listbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
    '        Listbox.Location = New System.Drawing.Point(ObjTextBox.Left, ObjTextBox.Top + ObjTextBox.Height)
    '        Listbox.Size = New System.Drawing.Size(ObjTextBox.Width, 100)
    '        Listbox.Items.Clear()
    '        If ds.Tables(Tablename).Rows.Count > 0 Then
    '            For Each drow In ds.Tables(Tablename).Rows
    '                Listbox.Items.Add(drow.Item(1))
    '            Next
    '        End If
    '        Try
    '            Listbox.SelectedIndex = 0
    '        Catch ex As Exception
    '        End Try
    '    End Function
    '    Public Function FOOTER()
    '        sqlstring = "SELECT isnull(UPDFOOTER,'') as UPDFOOTER, isnull(UPDNAME,'') as UPDNAME  FROM Grn_header WHERE  AUTOID IN (SELECT MAX(AUTOID) FROM Grn_header)"
    '        gconnection.getDataSet(sqlstring, "Grn_header")
    '        If gdataset.Tables("Grn_header").Rows.Count > 0 Then
    '            Txt_footer.Text = Trim(gdataset.Tables("Grn_header").Rows(0).Item("UPDFOOTER"))
    '            Txt_signature.Text = Trim(gdataset.Tables("Grn_header").Rows(0).Item("UPDNAME"))
    '        End If
    '    End Function
    '    Private Sub txt_Suppliername_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Suppliername.Validated
    '        Try
    '            If Trim(txt_Suppliername.Text) <> "" Then
    '                sqlstring = "SELECT SLCODE,SLNAME FROM accountssubledgermaster WHERE ACCODE = '" & Trim(gCreditors) & "'AND SLNAME='" & Trim(txt_Suppliername.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "accountssubledgermaster")
    '                If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
    '                    txt_Suppliername.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("SLNAME"))
    '                    txt_Suppliercode.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("SLCODE"))
    '                    txt_Excisepassno.Focus()
    '                    txt_Suppliercode.ReadOnly = True
    '                Else
    '                    txt_Suppliercode.Text = ""
    '                    txt_Suppliercode.ReadOnly = False
    '                    txt_Suppliername.Focus()
    '                End If
    '            Else
    '                txt_Suppliercode.Text = ""
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Suppliername_Validated" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub


    '    Private Sub Cmd_StockGrnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_StockGrnClear.Click
    '        Try
    '            Me.txt_FromDocno.Text = ""
    '            Me.txt_ToDocno.Text = ""
    '            Me.txt_FromDocno.ReadOnly = False
    '            Me.txt_FromDocno.ReadOnly = False
    '            Me.txt_FromDocno.Focus()
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_StockGrnClear_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_StockGrnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_StockGrnView.Click
    '        Try
    '            Dim i As Integer
    '            Dim objGrncumpurchase As New rptGrncumpurchase
    '            gPrint = False
    '            If Trim(txt_FromDocno.Text) = "" Then
    '                MessageBox.Show("From Grn No. can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
    '                Exit Sub
    '            ElseIf Trim(txt_ToDocno.Text) = "" Then
    '                MessageBox.Show("To Grn No. can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
    '                Exit Sub
    '            End If
    '            sqlstring = " SELECT * FROM VIEWPURCHASEREGISTERSUMMARY "
    '            sqlstring = sqlstring & " WHERE GRNDETAILS BETWEEN '" & Trim(txt_FromDocno.Text) & "' AND '" & Trim(txt_ToDocno.Text) & "'"
    '            sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMCODE  "
    '            Dim heading() As String = {"GRN CUM PURCHASE BILL"}
    '            Dim ObjStockPurchaseregisterReport As New rptStockPurchaseregister
    '            ObjStockPurchaseregisterReport.Reportdetails(sqlstring, heading, Now, Now)
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_StockGrnView_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_StockGrnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_StockGrnprint.Click
    '        Try
    '            gPrint = True
    '            Dim i As Integer
    '            Dim objGrncumpurchase As New rptGrncumpurchase
    '            If Trim(txt_FromDocno.Text) = "" Then
    '                MessageBox.Show("From Grn No. can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
    '                Exit Sub
    '            ElseIf Trim(txt_ToDocno.Text) = "" Then
    '                MessageBox.Show("To Grn No. can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
    '                Exit Sub
    '            End If
    '            sqlstring = " SELECT * FROM VIEWPURCHASEREGISTERSUMMARY "
    '            sqlstring = sqlstring & " WHERE GRNDETAILS BETWEEN '" & Trim(txt_FromDocno.Text) & "' AND '" & Trim(txt_ToDocno.Text) & "'"
    '            sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMCODE  "
    '            Dim heading() As String = {"GRN CUM PURCHASE BILL"}
    '            Dim ObjStockPurchaseregisterReport As New rptStockPurchaseregister
    '            ObjStockPurchaseregisterReport.Reportdetails(sqlstring, heading, Now, Now)
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_StockGrnprint_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_StockGrnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_StockGrnexit.Click
    '        Try
    '            txt_FromDocno.Text = ""
    '            txt_ToDocno.Text = ""
    '            grp_StockGrndetails.Top = 1000
    '            Cmd_Clear_Click(Cmd_Clear, e)
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_StockGrnexit_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_FromDocno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_FromDocno.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                If Trim(txt_FromDocno.Text) = "" Then
    '                    Call Cmd_FromDocno_Click(Cmd_FromDocno, e)
    '                Else
    '                    txt_FromDocno_Validated(txt_FromDocno, e)
    '                    txt_ToDocno.Focus()
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_FromDocno_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_ToDocno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ToDocno.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                If Trim(txt_ToDocno.Text) = "" Then
    '                    Call Cmd_ToDocno_Click(Cmd_ToDocno, e)
    '                Else
    '                    txt_ToDocno_Validated(txt_ToDocno, e)
    '                    Cmd_StockGrnView.Focus()
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_ToDocno_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_FromDocno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_FromDocno.Click
    '        Try
    '            gSQLString = "SELECT GRNDETAILS,GRNDATE FROM Grn_header"
    '            M_WhereCondition = " "
    '            Dim vform As New List_Operation
    '            vform.Field = "GRNDETAILS,GRNDATE"
    '            vform.vFormatstring1 = "          GRN CODE              |         GRN DATE                             "
    '            vform.vCaption = "GRN CUM PURCHASE BILL HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                txt_FromDocno.Text = Trim(vform.keyfield & "")
    '                txt_ToDocno.Focus()
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_FromDocno_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_ToDocno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ToDocno.Click
    '        Try
    '            gSQLString = "SELECT GRNDETAILS,GRNDATE FROM Grn_header"
    '            M_WhereCondition = " "
    '            Dim vform As New List_Operation
    '            vform.Field = "GRNDETAILS,GRNDATE"
    '            vform.vFormatstring1 = "          GRN CODE              |         GRN DATE                             "
    '            vform.vCaption = "GRN CUM PURCHASE BILL HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                txt_ToDocno.Text = Trim(vform.keyfield & "")
    '                Cmd_StockGrnView.Focus()
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_ToDocno_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_GLAcHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Dim vform As New ListOperattion1
    '            gSQLString = "SELECT accode,acdesc FROM accountsglaccountmaster"
    '            M_WhereCondition = ""
    '            vform.Field = "ACDESC,ACCODE"
    '            vform.vFormatstring = "  ACCODE                              |                      ACDESC                                                                                                     "
    '            vform.vCaption = "GLACCOUNT MASTER HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                Txt_GLAcIn.Text = Trim(vform.keyfield & "")
    '                Txt_GLAcDesc.Text = Trim(vform.keyfield1 & "")
    '                Call Glaccountvalidate()
    '            Else
    '                Me.Txt_GLAcIn.Focus()
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_GLAcHelp_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub Glaccountvalidate()
    '        Try
    '            Dim sqlstring As String
    '            If Trim(Txt_GLAcIn.Text) <> "" Then
    '                sqlstring = "SELECT slcode,slname FROM accountssubledgermaster WHERE accode = '" & Trim(Txt_GLAcIn.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "accountssubledgermaster")
    '                If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
    '                    Lbl_SubledgerCode.Visible = True
    '                    Lbl_SubledgerName.Visible = True
    '                    Txt_Slcode.Visible = True
    '                    Cmd_SlCodeHelp.Visible = True
    '                    Txt_SlDesc.Visible = True
    '                    slcodestatus = True
    '                    grp_grnposting.Top = 218
    '                    grp_grnposting.Height = 80
    '                    ssgrid.Left = 10
    '                    ssgrid.Top = 272
    '                    ssgrid.Height = 224
    '                    Txt_Slcode.Focus()
    '                Else
    '                    Lbl_SubledgerCode.Visible = False
    '                    Lbl_SubledgerName.Visible = False
    '                    Txt_Slcode.Visible = False
    '                    Cmd_SlCodeHelp.Visible = False
    '                    Txt_SlDesc.Visible = False
    '                    slcodestatus = False
    '                    grp_grnposting.Top = 218
    '                    grp_grnposting.Height = 48
    '                    grp_grnposting.Width = 848
    '                    ssgrid.Top = 272
    '                    ssgrid.Left = 10
    '                    ssgrid.Height = 250
    '                    ssgrid.Focus()
    '                    Txt_CostCenterCode.Focus()
    '                End If
    '                gdataset.Tables("accountssubledgermaster").Dispose()
    '                Call Costcentervalidate()
    '            Else
    '                Txt_GLAcIn.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Glaccountvalidate" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub Costcentervalidate()
    '        Try
    '            Dim SQLSTRING As String
    '            Dim DR As DataRow
    '            Dim i As Integer
    '            If Trim(Txt_GLAcIn.Text) <> "" Then
    '                SQLSTRING = "SELECT PRIMARYGROUPCODE FROM ACCOUNTTAGGING WHERE GLACCODE = '" & Trim(Txt_GLAcIn.Text) & "'"
    '                gconnection.getDataSet(SQLSTRING, "MASTER1")
    '                If gdataset.Tables("MASTER1").Rows.Count > 0 Then
    '                    Lbl_CostCenterCode.Visible = True
    '                    Lbl_CostCenterDesc.Visible = True
    '                    Txt_CostCenterCode.Visible = True
    '                    Txt_CostCenterDesc.Visible = True
    '                    Cmd_CostCenterCodeHelp.Visible = True
    '                    costcentercodestatus = True
    '                    grp_grnposting.Top = 218
    '                    grp_grnposting.Width = 848
    '                    grp_grnposting.Height = 120
    '                    ssgrid.Top = 344
    '                    ssgrid.Left = 10
    '                    ssgrid.Height = 195
    '                    lbl_Creditdays.Top = 280
    '                    lbl_Creditdays.Left = 504
    '                    txt_Creditdays.Top = 280
    '                    txt_Creditdays.Left = 672
    '                    Gr = Nothing
    '                    For Each DR In gdataset.Tables("MASTER1").Rows
    '                        If Trim(Gr) = "" Then
    '                            Gr = "'" & Trim(DR("PRIMARYGROUPCODE")) & "'"
    '                        Else
    '                            Gr = Gr & ",'" & Trim(DR("PRIMARYGROUPCODE")) & "'"
    '                        End If
    '                    Next
    '                Else
    '                    Lbl_CostCenterCode.Visible = False
    '                    Lbl_CostCenterDesc.Visible = False
    '                    Txt_CostCenterCode.Visible = False
    '                    Txt_CostCenterDesc.Visible = False
    '                    Cmd_CostCenterCodeHelp.Visible = False
    '                    costcentercodestatus = False
    '                    If slcodestatus = True Then
    '                        grp_grnposting.Top = 218
    '                        grp_grnposting.Height = 80
    '                        ssgrid.Left = 65
    '                        ssgrid.Top = 272
    '                        ssgrid.Height = 215
    '                        Txt_Slcode.Focus()
    '                    Else
    '                        grp_grnposting.Height = 48
    '                        grp_grnposting.Width = 848
    '                        ssgrid.Top = 272
    '                        ssgrid.Left = 10
    '                        ssgrid.Height = 255
    '                        ssgrid.Focus()
    '                    End If
    '                End If
    '            Else
    '                Txt_GLAcIn.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Costcentervalidate" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_GLAcIn_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Dim sqlstring As String
    '            If Trim(Txt_GLAcIn.Text) <> "" Then
    '                sqlstring = "select accode, acdesc from accountsglaccountmaster where accode = '" & Trim(Txt_GLAcIn.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "accountsglaccountmaster")
    '                If gdataset.Tables("accountsglaccountmaster").Rows.Count > 0 Then
    '                    Txt_GLAcDesc.Text = Trim(UCase(gdataset.Tables("accountsglaccountmaster").Rows(0).Item("acdesc")))
    '                    If slcodestatus = True Then
    '                        Txt_Slcode.Focus()
    '                    Else
    '                        Txt_CostCenterCode.Focus()
    '                    End If
    '                Else
    '                    Txt_GLAcIn.Text = ""
    '                    Txt_GLAcDesc.Text = ""
    '                End If
    '                gdataset.Tables("accountsglaccountmaster").Dispose()
    '                Call Glaccountvalidate()
    '            Else
    '                Txt_GLAcIn.Text = ""
    '                'Txt_GLAcIn.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_GLAcIn_Validated " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_Slcode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Dim sqlstring As String
    '            If Trim(Txt_Slcode.Text) <> "" Then
    '                sqlstring = "SELECT slcode, sldesc from accountssubledgermaster WHERE accode = '" & Trim(Txt_GLAcIn.Text) & "' and slcode = '" & Trim(Txt_Slcode.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "accountssubledgermaster")
    '                If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
    '                    Txt_Slcode.Text = Trim(UCase(gdataset.Tables("accountssubledgermaster").Rows(0).Item("slcode")))
    '                    Txt_SlDesc.Text = Trim(UCase(gdataset.Tables("accountssubledgermaster").Rows(0).Item("sldesc")))
    '                    If costcentercodestatus = True Then
    '                        Txt_CostCenterCode.Focus()
    '                    Else
    '                        ssgrid.Focus()
    '                    End If
    '                Else
    '                    Txt_Slcode.Text = ""
    '                    Txt_SlDesc.Text = ""
    '                End If
    '                gdataset.Tables("accountssubledgermaster").Dispose()
    '            Else
    '                Txt_Slcode.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_Slcode_Validated" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_CostCenterCode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Dim sqlstring As String
    '            If Trim(Txt_CostCenterCode.Text) <> "" Then
    '                sqlstring = "SELECT COSTCENTERCODE,COSTCENTERDESC from accountscostcentermaster where COSTCENTERCODE = '" & Trim(Txt_CostCenterCode.Text) & "' And PRIMARYGROUPCODE IN (" & Gr & ")"
    '                gconnection.getDataSet(sqlstring, "accountscostcentermaster")
    '                If gdataset.Tables("accountscostcentermaster").Rows.Count > 0 Then
    '                    Txt_CostCenterDesc.Text = Trim(UCase(gdataset.Tables("accountscostcentermaster").Rows(0).Item("COSTCENTERDESC")))
    '                    ssgrid.Focus()
    '                    ssgrid.SetActiveCell(1, 1)
    '                Else
    '                    Txt_CostCenterDesc.Text = ""
    '                    Txt_CostCenterCode.Text = ""
    '                End If
    '                gdataset.Tables("accountscostcentermaster").Dispose()
    '            Else
    '                Txt_CostCenterCode.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_CostCenterCode_Validated" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub Cmd_CostCenterCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Dim vform As New ListOperattion1
    '            gSQLString = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER"
    '            M_WhereCondition = " WHERE PRIMARYGROUPCODE IN (" & Gr & ")"
    '            vform.Field = "COSTCENTERCODE"
    '            vform.Field = "COSTCENTERDESC"
    '            vform.vFormatstring = "  COSTCENTERCODE                   |                          COSTCENTERDESC                                "
    '            vform.vCaption = "COSTCENTER MASTER HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                Txt_CostCenterCode.Text = Trim(vform.keyfield & "")
    '                Txt_CostCenterDesc.Text = Trim(vform.keyfield1 & "")
    '                ssgrid.Focus()
    '                ssgrid.SetActiveCell(1, 1)
    '            Else
    '                Me.Txt_Slcode.Focus()
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_CostCenterCodeHelp_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_SlCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            Dim vform As New ListOperattion1
    '            gSQLString = "SELECT slcode,sldesc FROM accountssubledgermaster"
    '            M_WhereCondition = " WHERE accode = '" & Trim(Txt_GLAcIn.Text) & "'"
    '            vform.Field = "SLCODE"
    '            vform.Field = "SLDESC"
    '            vform.vFormatstring = "  SLCODE                             |                          SLDESC                                "
    '            vform.vCaption = "SUBLEDGER MASTER HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                Txt_Slcode.Text = Trim(vform.keyfield & "")
    '                Txt_SlDesc.Text = Trim(vform.keyfield1 & "")
    '                Me.Txt_CostCenterCode.Focus()
    '            Else
    '                Me.Txt_GLAcIn.Focus()
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Cmd_SlCodeHelp_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_GLAcIn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '        Try
    '            If e.KeyCode = Keys.F4 Then
    '                Call Cmd_GLAcHelp_Click(sender, e)
    '                Exit Sub
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_GLAcIn_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_Slcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '        Try
    '            If e.KeyCode = Keys.F4 Then
    '                Call Cmd_SlCodeHelp_Click(sender, e)
    '                Exit Sub
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_Slcode_KeyDown" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_CostCenterCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '        Try
    '            If e.KeyCode = Keys.F4 Then
    '                Call Cmd_CostCenterCodeHelp_Click(sender, e)
    '                Exit Sub
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_CostCenterCode_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_GLAcIn_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            getAlphanumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                If Trim(Txt_GLAcIn.Text) = "" Then
    '                    Call Cmd_GLAcHelp_Click(Cmd_GLAcHelp, e)
    '                Else
    '                    Call Txt_GLAcIn_Validated(sender, e)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_GLAcIn_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_Slcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            getAlphanumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                If Trim(Txt_Slcode.Text) = "" Then
    '                    Call Cmd_SlCodeHelp_Click(Cmd_SlCodeHelp, e)
    '                    ssgrid.Focus()
    '                Else
    '                    Call Txt_Slcode_Validated(Txt_Slcode, e)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_Slcode_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Txt_CostCenterCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            getAlphanumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                If Trim(Txt_CostCenterCode.Text) = "" Then
    '                    Call Cmd_CostCenterCodeHelp_Click(Cmd_CostCenterCodeHelp, e)
    '                Else
    '                    Call Txt_CostCenterCode_Validated(sender, e)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Txt_CostCenterCode_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Suppliercode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Suppliercode.KeyDown
    '        Try
    '            If e.KeyCode = Keys.F4 Then
    '                Call cmd_Suppliercodehelp_Click(cmd_Suppliercodehelp, e)
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Suppliercode_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Suppliercode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Suppliercode.Validated
    '        Try
    '            If Trim(txt_Suppliercode.Text) <> "" Then
    '                sqlstring = "SELECT SLCODE,SLNAME,isnull(creditperiod,0) as creditperiod FROM accountssubledgermaster WHERE ACCODE IN ("
    '                sqlstring = sqlstring & "'" & Trim(gCreditors) & "') AND SLCODE='" & Trim(txt_Suppliercode.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "accountssubledgermaster")
    '                If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
    '                    txt_Suppliername.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("SLNAME"))
    '                    txt_Suppliercode.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("SLCODE"))
    '                    txt_Creditdays.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("creditperiod"))
    '                    txt_Suppliername.ReadOnly = True
    '                    If gpaymentcode = "Y" Then
    '                        cbo_Billingterms.Focus()
    '                    Else
    '                        txt_Supplierinvno.Focus()
    '                    End If

    '                Else
    '                    txt_Suppliercode.Text = ""
    '                    txt_Suppliercode.Text = ""
    '                    txt_Suppliername.ReadOnly = False
    '                    txt_Suppliercode.Focus()
    '                End If
    '            Else
    '                txt_Suppliercode.Text = ""
    '                txt_Suppliername.Text = ""
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Suppliercode_Validated" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub dtp_Stockindate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Stockindate.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                txt_Excisepassno.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : dtp_Stockindate_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Trucknumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Trucknumber.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                grp_Excisedetails.Top = 1000
    '                txt_Storecode.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Trucknumber_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Trucknumber_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Trucknumber.LostFocus
    '        Try
    '            grp_Excisedetails.Top = 1000
    '            txt_Storecode.Focus()
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Trucknumber_LostFocus " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub dtp_Supplierinvdate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_Supplierinvdate.LostFocus
    '        Try
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : dtp_Supplierinvdate_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub cbo_Billingterms_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            Call Blank(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                'DISABLE GLACCOUNT
    '                txt_Storecode.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : cbo_Billingterms_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub FillBillterms()
    '        Try
    '            Dim i As Integer
    '            sqlstring = "SELECT DISTINCT ISNULL(TYPECODE,'') + '  ' +ISNULL(TYPEDESC,'') AS TYPEDESC  FROM PURCHASEBILLTERMS WHERE  ISNULL(FREEZE,'')<>'Y'"
    '            gconnection.getDataSet(sqlstring, "PURCHASEBILLTERMS")
    '            cbo_Billingterms.Items.Clear()
    '            If gdataset.Tables("PURCHASEBILLTERMS").Rows.Count > 0 Then
    '                For i = 0 To gdataset.Tables("PURCHASEBILLTERMS").Rows.Count - 1
    '                    cbo_Billingterms.Items.Add(gdataset.Tables("PURCHASEBILLTERMS").Rows(i).Item("Typedesc"))
    '                    cbo_Billingterms.Text = gdataset.Tables("PURCHASEBILLTERMS").Rows(i).Item("Typedesc")
    '                Next i
    '            Else
    '                cbo_Billingterms.Text = ""
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : FillBillterms " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub billingterms()
    '        Try
    '            Dim per As Double
    '            Call FillBillterms()
    '            Call Fillbilldetails()
    '            grp_Billingdetails.Top = 144
    '            grp_Billingdetails.Left = 160
    '            ssgrid_billdetails.Col = 4
    '            ssgrid_billdetails.Row = 1
    '            ssgrid_billdetails.Text = Format(Val(txt_Totalamt.Text), "0.00")
    '            ssgrid_billdetails.Focus()
    '            ssgrid_billdetails.SetActiveCell(2, 2)
    '            ssgrid_billdetails.Col = 4
    '            ssgrid_billdetails.Row = 2
    '            ssgrid_billdetails.Text = Format(Val(txt_Discountamt.Text), "0.00")
    '            per = (Val(txt_Discountamt.Text) * 100) / Val(txt_Totalamt.Text)
    '            ssgrid_billdetails.Col = 2
    '            ssgrid_billdetails.Row = 2
    '            ssgrid_billdetails.Text = per
    '            ssgrid_billdetails.Col = 4
    '            ssgrid_billdetails.Row = billrow
    '            ssgrid_billdetails.Text = Format(Val(txt_Totalamt.Text), "0.00")
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : billingterms" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_Remarks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Remarks.KeyPress
    '        Try
    '            If Asc(e.KeyChar) = 13 Then
    '                'Call billingterms()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Remarks_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub Fillbilldetails()
    '        Try
    '            Dim i, j As Integer
    '            Dim typecode() As String
    '            typecode = Split(Trim(cbo_Billingterms.Text), "  ")
    '            sqlstring = "SELECT ISNuLL(Billdescription,'') As Billdescription,ISNULL(slno,0) AS SLNO,FORMULA,SIGNS,ISNULL(Accode,'') AS ACCODE ,ISNULL(Acdesc,'') AS ACDESC FROM purchasebillterms WHERE  Typecode = '" & Trim(typecode(0)) & "' AND ISNULL(Freeze,'')<>'Y'"
    '            gconnection.getDataSet(sqlstring, "purchasebillterms")
    '            j = 2
    '            If gdataset.Tables("purchasebillterms").Rows.Count > 0 Then
    '                ssgrid_billdetails.SetText(1, 1, "BASIC" & "  " & ":")
    '                ssgrid_billdetails.Col = 1
    '                ssgrid_billdetails.Row = 1
    '                ssgrid_billdetails.Lock = True
    '                ssgrid_billdetails.Col = 2
    '                ssgrid_billdetails.Row = 1
    '                ssgrid_billdetails.Lock = True
    '                ssgrid_billdetails.Col = 3
    '                ssgrid_billdetails.Row = 1
    '                ssgrid_billdetails.Lock = True
    '                For i = 0 To gdataset.Tables("purchasebillterms").Rows.Count - 1 Step 1
    '                    ssgrid_billdetails.SetText(1, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("Billdescription")) & "  " & ":")
    '                    ssgrid_billdetails.SetText(5, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("SLNO")))
    '                    ssgrid_billdetails.SetText(6, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("FORMULA")))
    '                    ssgrid_billdetails.SetText(7, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("SIGNS")))
    '                    ssgrid_billdetails.SetText(8, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("ACCODE")))
    '                    ssgrid_billdetails.SetText(9, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("ACDESC")))
    '                    j = j + 1
    '                Next i
    '                ssgrid_billdetails.SetText(1, j, "BILL AMOUNT" & "  " & ":")
    '                billrow = j
    '                ssgrid_billdetails.Col = 1
    '                ssgrid_billdetails.Row = j
    '                ssgrid_billdetails.Lock = True
    '                ssgrid_billdetails.Col = 2
    '                ssgrid_billdetails.Row = j
    '                ssgrid_billdetails.Lock = True
    '                ssgrid_billdetails.Col = 3
    '                ssgrid_billdetails.Row = j
    '                ssgrid_billdetails.Lock = True
    '                ssgrid_billdetails.SetActiveCell(2, 2)
    '            Else
    '                'SHAN
    '                Call FillBillterms()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : Fillbilldetails " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub billingtermsrefresh(ByVal Activerow As Integer)
    '        Try
    '            Dim Totalamount, Taxamount, Calamount, Caltax, CalBilamount, BillAmount, Batchno, Avgrate, Avgquantity As Double
    '            Dim dblBasic, dblDiscount, dblExcise, dblVAT, dblSurchase, dblTranportation, dblOthpostcharge, dblOthNegcharge As Double
    '            Dim Sign, Formula, slno As String
    '            Dim Formule() As Char
    '            Dim II, J As Integer
    '            Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
    '            Dim per As Double

    '            ssgrid_billdetails.Row = 1
    '            ssgrid_billdetails.Col = 4
    '            amt = Val(ssgrid_billdetails.Text)

    '            ssgrid_billdetails.Col = 4
    '            ssgrid_billdetails.Row = ssgrid_billdetails.DataRowCnt
    '            ssgrid_billdetails.Text = amt

    '            dblBasic = Format(Val(ssgrid_billdetails.Text), "0.00")

    '            For i = 2 To ssgrid_billdetails.DataRowCnt - 1
    '                ssgrid_billdetails.Row = i
    '                ssgrid_billdetails.Col = 7
    '                Sign = ssgrid_billdetails.Text

    '                ssgrid_billdetails.Col = 4
    '                Gramt = Val(ssgrid_billdetails.Text)

    '                If Sign = "+" Then
    '                    ssgrid_billdetails.Col = 4
    '                    ssgrid_billdetails.Row = ssgrid_billdetails.DataRowCnt
    '                    ssgrid_billdetails.Text = Format(Val(ssgrid_billdetails.Text) + Val(Gramt), "0.00")
    '                End If

    '                If Sign = "-" Then
    '                    ssgrid_billdetails.Col = 4
    '                    ssgrid_billdetails.Row = ssgrid_billdetails.DataRowCnt
    '                    Bamt = ssgrid_billdetails.Text
    '                    ssgrid_billdetails.Text = Format(Val(ssgrid_billdetails.Text) - Val(Gramt), "0.00")
    '                End If

    '                ssgrid_billdetails.Row = i
    '                ssgrid_billdetails.Col = 1
    '                If Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "BAS" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblBasic = dblBasic + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "DIS" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblDiscount = dblDiscount + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "EXC" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblExcise = dblExcise + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "V.A" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblVAT = dblVAT + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "SUR" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblSurchase = dblSurchase + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "TRA" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblTranportation = dblTranportation + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 12, 6) = "ES (+)" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblOthpostcharge = dblOthpostcharge + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 12, 6) = "ES (-)" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        dblOthNegcharge = dblOthNegcharge + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 1, 3) = "BIL" Then
    '                    ssgrid_billdetails.Col = 4
    '                    If Val(ssgrid_billdetails.Text) > 0 Then
    '                        BillAmount = BillAmount + Format(Val(ssgrid_billdetails.Text), "0.00")
    '                    End If
    '                End If
    '            Next i

    '            ssgrid_billdetails.Col = 4
    '            ssgrid_billdetails.Row = ssgrid_billdetails.DataRowCnt
    '            BillAmount = Format(Val(ssgrid_billdetails.Text), "0.00")

    '            txt_Totalamt.Text = Format(dblBasic, "0.00")
    '            txt_Vatamount.Text = Format(dblVAT + dblExcise, "0.00")
    '            txt_Surchargeamt.Text = Format(dblSurchase + dblOthpostcharge + dblTranportation, "0.00")
    '            txt_Discountamt.Text = Format(dblDiscount + dblOthNegcharge, "0.00")
    '            txt_Billamount.Text = Format(BillAmount, "0.00")
    '            ssgrid_billdetails.Row = Activerow
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : billingtermsrefresh " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub billingtermstaxamount(ByVal Activerow)
    '        'new
    '        Try
    '            Dim Sign, Formula, slno As String
    '            Dim Formule() As Char
    '            Dim II, J As Integer
    '            Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
    '            Dim per As Double
    '            Dim K As Integer
    '            For K = 2 To Activerow
    '                ssgrid_billdetails.Row = 1
    '                ssgrid_billdetails.Col = 4
    '                amt = Val(ssgrid_billdetails.Text)

    '                ssgrid_billdetails.Row = K
    '                ssgrid_billdetails.Col = 2
    '                per = Val(ssgrid_billdetails.Text)
    '                ssgrid_billdetails.Col = 7
    '                Sign = ssgrid_billdetails.Text

    '                ssgrid_billdetails.Col = 6
    '                Formula = ssgrid_billdetails.Text
    '                Formule = Formula.ToCharArray

    '                Gtot = 0
    '                ssgrid_billdetails.Row = K
    '                ssgrid_billdetails.Col = 2
    '                per = Val(ssgrid_billdetails.Text)

    '                For II = 1 To Formule.Length - 1
    '                    For J = 2 To ssgrid_billdetails.DataRowCnt
    '                        ssgrid_billdetails.Col = 5
    '                        ssgrid_billdetails.Row = J
    '                        If Trim(Formule(II)) = Trim(ssgrid_billdetails.Text) Then
    '                            ssgrid_billdetails.Col = 4
    '                            Gtot = Gtot + Val(ssgrid_billdetails.Text)
    '                            Exit For
    '                        End If
    '                    Next J
    '                Next II
    '                Camt = ((Gtot + amt) * per) / 100
    '                ssgrid_billdetails.Col = 4
    '                ssgrid_billdetails.Row = K
    '                If Camt > 0 Then
    '                    ssgrid_billdetails.Text = Format(Val(Camt), "0.00")
    '                Else
    '                    ssgrid_billdetails.Text = 0.0
    '                End If
    '            Next K
    '            Call billingtermsrefresh(Activerow)

    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : billingtermstaxamount" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '        'end new
    '    End Sub
    '    Private Sub BillingTermsTaxPercentage(ByVal Activerow)
    '        'new
    '        Try
    '            Dim Sign, Formula, slno, Billdesc() As String
    '            Dim Formule() As Char
    '            Dim II, J As Integer
    '            Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
    '            Dim per As Double


    '            ssgrid_billdetails.Row = 1
    '            ssgrid_billdetails.Col = 4
    '            amt = Val(ssgrid_billdetails.Text)

    '            ssgrid_billdetails.Col = 4
    '            ssgrid_billdetails.Row = billrow
    '            ssgrid_billdetails.Text = Format(amt, "0.00")

    '            ssgrid_billdetails.Row = Activerow
    '            ssgrid_billdetails.Col = 2
    '            per = Val(ssgrid_billdetails.Text)
    '            ssgrid_billdetails.Col = 7
    '            Sign = ssgrid_billdetails.Text

    '            ssgrid_billdetails.Col = 6
    '            Formula = ssgrid_billdetails.Text
    '            Formule = Formula.ToCharArray

    '            Gtot = 0
    '            For II = 1 To Formule.Length - 1
    '                For J = 2 To ssgrid_billdetails.DataRowCnt
    '                    ssgrid_billdetails.Col = 5
    '                    ssgrid_billdetails.Row = J
    '                    If Trim(Formule(II)) = Trim(ssgrid_billdetails.Text) Then
    '                        ssgrid_billdetails.Col = 4
    '                        Gtot = Gtot + Val(ssgrid_billdetails.Text)
    '                        Exit For
    '                    End If
    '                Next J
    '            Next II


    '            ssgrid_billdetails.Col = 1
    '            ssgrid_billdetails.Row = Activerow
    '            Billdesc = Split(Trim(ssgrid_billdetails.Text), ":")

    '            sqlstring = "SELECT Tax FROM purchasebillterms WHERE Billdescription = '" & Trim(Billdesc(0)) & "'AND ISNULL(FREEZE,'N') <> 'Y' "
    '            gconnection.getDataSet(sqlstring, "purchasebillterms")
    '            If gdataset.Tables("purchasebillterms").Rows.Count > 0 Then
    '                If gdataset.Tables("purchasebillterms").Rows(0).Item("Tax") & "" <> "Y" Then
    '                    GrTot = Gtot + amt
    '                    ssgrid_billdetails.Row = Activerow
    '                    ssgrid_billdetails.Col = 2
    '                    If Gtot > 0 Then
    '                        ssgrid_billdetails.Col = 4
    '                        Gtot = Val(ssgrid_billdetails.Text)
    '                        ssgrid_billdetails.Col = 2
    '                        ssgrid_billdetails.Text = Format((Gtot / amt) * 100, "0.00")
    '                    Else
    '                        If GrTot > 0 Then
    '                            ssgrid_billdetails.Col = 4
    '                            Gtot = Val(ssgrid_billdetails.Text)
    '                            ssgrid_billdetails.Col = 2
    '                            ssgrid_billdetails.Text = Format((Gtot / amt) * 100, "0.00")
    '                        Else
    '                            ssgrid_billdetails.Text = 0.0
    '                        End If
    '                    End If
    '                    Call billingtermsrefresh(Activerow)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : BillingTermsTaxPercentage" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub ssgrid_billdetails_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid_billdetails.KeyDownEvent
    '        Try
    '            Dim Taxcode, Billdesc(), Sqlstring As String

    '            Dim Sign, Formula, slno As String
    '            Dim Formule() As Char
    '            Dim II, J As Integer
    '            Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
    '            Dim per As Double
    '            If e.keyCode = Keys.Enter Or e.keyCode = Keys.Tab Then
    '                If ssgrid_billdetails.ActiveCol = 1 Then
    '                    ssgrid_billdetails.Col = 1
    '                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                    If Trim(ssgrid_billdetails.Text) <> "" Then
    '                        ssgrid_billdetails.SetActiveCell(1, ssgrid_billdetails.ActiveRow)
    '                    End If
    '                ElseIf ssgrid_billdetails.ActiveCol = 2 Then
    '                    ssgrid_billdetails.Col = 1
    '                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                    Billdesc = Split(Trim(ssgrid_billdetails.Text), ":")

    '                    Sqlstring = "SELECT Tax FROM purchasebillterms WHERE Billdescription = '" & Trim(Billdesc(0)) & "'AND ISNULL(FREEZE,'N') <> 'Y' "
    '                    gconnection.getDataSet(Sqlstring, "purchasebillterms")
    '                    If gdataset.Tables("purchasebillterms").Rows.Count > 0 Then
    '                        If gdataset.Tables("purchasebillterms").Rows(0).Item("Tax") & "" = "Y" Then
    '                            ssgrid_billdetails.Col = 2
    '                            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                            ssgrid_billdetails.Lock = True
    '                            ssgrid_billdetails.Text = "0.00"
    '                            ssgrid_billdetails.Col = 3
    '                            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                            ssgrid_billdetails.Text = ""
    '                            ssgrid_billdetails.Lock = False
    '                            ssgrid_billdetails.SetActiveCell(2, ssgrid_billdetails.ActiveRow)
    '                        Else
    '                            ssgrid_billdetails.Col = 2
    '                            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                            If Val(ssgrid_billdetails.Text) = 0 Then
    '                                ssgrid_billdetails.Text = "0.00"
    '                                ssgrid_billdetails.Col = 4
    '                                ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                                ssgrid_billdetails.Text = "0.00"
    '                                ssgrid_billdetails.Lock = False
    '                                ssgrid_billdetails.SetActiveCell(3, ssgrid_billdetails.ActiveRow)
    '                            Else
    '                                ssgrid_billdetails.Col = 4
    '                                ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                                Call billingtermsrefresh(ssgrid_billdetails.ActiveRow)
    '                                ssgrid_billdetails.Lock = False
    '                                ssgrid_billdetails.SetActiveCell(3, ssgrid_billdetails.ActiveRow)
    '                            End If
    '                        End If
    '                        Call billingtermstaxamount(ssgrid_billdetails.ActiveRow)
    '                    End If
    '                ElseIf ssgrid_billdetails.ActiveCol = 3 Then
    '                    ssgrid_billdetails.Col = 1
    '                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                    Billdesc = Split(Trim(ssgrid_billdetails.Text), ":")
    '                    Sqlstring = "SELECT Tax FROM purchasebillterms WHERE Billdescription = '" & Trim(Billdesc(0)) & "'AND ISNULL(FREEZE,'N') <> 'Y' "
    '                    gconnection.getDataSet(Sqlstring, "purchasebillterms")
    '                    If gdataset.Tables("purchasebillterms").Rows.Count > 0 Then
    '                        If gdataset.Tables("purchasebillterms").Rows(0).Item("Tax") & "" = "Y" Then
    '                            ssgrid_billdetails.Col = 3
    '                            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                            If Trim(ssgrid_billdetails.Text) = "" Then
    '                                Call FillTaxmaster() '''---> Show Taxcode,Taxpercentage 
    '                                Exit Sub
    '                            Else
    '                                Taxcode = Trim(ssgrid.Text)
    '                                Sqlstring = "SELECT Taxcode,Taxdesc,Taxpercentage,Typeoftax,GLACCOUNTIN,GLACCOUNTDESC  FROM AccountsTaxMaster WHERE Taxcode = '" & Trim(Taxcode) & "'AND ISNULL(FREEZEFLAG,'N') <> 'Y' "
    '                                gconnection.getDataSet(Sqlstring, "AccountsTaxMaster")
    '                                If gdataset.Tables("AccountsTaxMaster").Rows.Count = 0 Then
    '                                    Sqlstring = "SELECT Taxcode,Taxdesc,Taxpercentage,Typeoftax,GLACCOUNTIN,GLACCOUNTDESC  FROM AccountsTaxMaster WHERE Taxcode = '" & Trim(Taxcode) & "'AND ISNULL(FREEZEFLAG,'N') <> 'Y' "
    '                                    gconnection.getDataSet(Sqlstring, "AccountsTaxMaster")
    '                                End If
    '                                If gdataset.Tables("AccountsTaxMaster").Rows.Count > 0 Then
    '                                    ssgrid_billdetails.Col = 2
    '                                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                                    ssgrid_billdetails.Text = Trim(gdataset.Tables("AccountsTaxMaster").Rows(0).Item("Taxpercentage") & "")
    '                                    ssgrid_billdetails.Col = 3
    '                                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                                    ssgrid_billdetails.Text = Trim(gdataset.Tables("AccountsTaxMaster").Rows(0).Item("Taxcode") & "")
    '                                    ssgrid_billdetails.Col = 8
    '                                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                                    ssgrid_billdetails.Text = Trim(gdataset.Tables("AccountsTaxMaster").Rows(0).Item("GLACCOUNTIN") & "")
    '                                    ssgrid_billdetails.Col = 9
    '                                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                                    ssgrid_billdetails.Text = Trim(gdataset.Tables("AccountsTaxMaster").Rows(0).Item("GLACCOUNTDESC") & "")
    '                                    gdataset.Tables("AccountsTaxMaster").Dispose()
    '                                Else
    '                                    Call FillTaxmaster() '''---> Show Taxcode,Taxpercentage 
    '                                End If
    '                            End If
    '                        End If
    '                        Call billingtermstaxamount(ssgrid_billdetails.ActiveRow)
    '                    End If
    '                ElseIf ssgrid_billdetails.ActiveCol = 4 Then
    '                    ssgrid_billdetails.Col = 4
    '                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                    Call BillingTermsTaxPercentage(ssgrid_billdetails.ActiveRow)
    '                    ssgrid_billdetails.SetActiveCell(1, ssgrid_billdetails.ActiveRow + 1)
    '                End If
    '            End If

    '            If e.keyCode = Keys.F4 Then
    '                If ssgrid_billdetails.ActiveCol = 3 Then
    '                    If ssgrid_billdetails.Lock = False Then
    '                        search = Nothing
    '                        ssgrid.GetText(2, ssgrid.ActiveRow, search)
    '                        Dim vform As New List_Operation
    '                        gSQLString = "SELECT Taxcode,Taxdesc,Taxpercentage,Typeoftax,GLACCOUNTIN,GLACCOUNTDESC  FROM AccountsTaxMaster"
    '                        M_WhereCondition = " WHERE  ISNULL(FREEZEFLAG,'N') <> 'Y'"
    '                        vform.Field = "TAXCODE,TAXDESC"
    '                        vform.vFormatstring1 = "           TAXCODE            |                  TAX DESCRIPTION         |       TAXPERCENTAGE       |   TYPE OF TAX  | GLACCOUNTIN  |  GLACCOUNTDESC  "
    '                        vform.vCaption = "TAX MASTER HELP"
    '                        vform.KeyPos = 0
    '                        vform.KeyPos1 = 1
    '                        vform.KeyPos2 = 2
    '                        vform.Keypos3 = 3
    '                        vform.keypos4 = 4
    '                        vform.Keypos5 = 5
    '                        vform.ShowDialog(Me)
    '                        If Trim(vform.keyfield & "") <> "" Then
    '                            ssgrid_billdetails.SetText(3, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield & ""))
    '                            ssgrid_billdetails.SetText(2, ssgrid_billdetails.ActiveRow, Val(vform.keyfield2))
    '                            ssgrid_billdetails.SetText(8, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield4))
    '                            ssgrid_billdetails.SetText(9, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield5))
    '                            Call billingtermsrefresh(ssgrid_billdetails.ActiveRow)
    '                            ssgrid_billdetails.SetActiveCell(3, ssgrid_billdetails.ActiveRow)
    '                            Taxcode = Trim(vform.keyfield & "")
    '                        Else
    '                            ssgrid_billdetails.SetActiveCell(ssgrid_billdetails.ActiveCol, ssgrid_billdetails.ActiveRow)
    '                            ssgrid_billdetails.SetText(ssgrid_billdetails.ActiveCol, ssgrid_billdetails.ActiveRow, "")
    '                            Taxcode = ""
    '                        End If
    '                        vform.Close()
    '                        vform = Nothing
    '                        Call BillingTermsTaxPercentage(ssgrid_billdetails.ActiveRow)
    '                    End If
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : ssgrid_billdetails_KeyDownEvent " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub FillTaxmaster()
    '        Try
    '            Dim ACHEAD As String
    '            search = Nothing
    '            ssgrid.GetText(2, ssgrid.ActiveRow, search)
    '            Dim vform As New List_Operation
    '            gSQLString = "SELECT Taxcode,Taxdesc,Taxpercentage,Typeoftax,GLACCOUNTIN,GLACCOUNTDESC  FROM AccountsTaxMaster"
    '            M_WhereCondition = " WHERE  ISNULL(FREEZEFLAG,'N') <> 'Y'"
    '            vform.Field = "TAXCODE,TAXDESC"
    '            vform.vFormatstring1 = "           TAXCODE       |             TAX DESCRIPTION         |    TAXPERCENTAGE       |   TYPE OF TAX  | GLACCOUNTIN  |  GLACCOUNTDESC  "
    '            vform.vCaption = "TAX MASTER HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.KeyPos2 = 2
    '            vform.Keypos3 = 3
    '            vform.keypos4 = 4
    '            vform.Keypos5 = 5
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                ssgrid_billdetails.SetText(3, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield & ""))
    '                ssgrid_billdetails.SetText(2, ssgrid_billdetails.ActiveRow, Val(vform.keyfield2))
    '                ssgrid_billdetails.SetText(8, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield4))
    '                ssgrid_billdetails.SetText(9, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield5))
    '                Call billingtermsrefresh(ssgrid_billdetails.ActiveRow)
    '                ssgrid_billdetails.SetActiveCell(3, ssgrid_billdetails.ActiveRow)
    '                ACHEAD = Trim(vform.keyfield & "")
    '            Else
    '                ssgrid_billdetails.SetActiveCell(ssgrid_billdetails.ActiveCol, ssgrid_billdetails.ActiveRow)
    '                ssgrid_billdetails.SetText(ssgrid_billdetails.ActiveCol, ssgrid_billdetails.ActiveRow, "")
    '                ssgrid_billdetails.SetActiveCell(2, ssgrid_billdetails.ActiveRow)
    '                ACHEAD = ""
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : FillTaxmaster " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub ssgrid_billdetails_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid_billdetails.LeaveCell
    '        Try
    '            Dim Taxcode, Billdesc(), Sqlstring As String
    '            Dim Sign, Formula, slno As String
    '            Dim Formule() As Char
    '            Dim II, J As Integer
    '            Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
    '            Dim per As Double
    '            If ssgrid_billdetails.ActiveCol = 1 Then
    '                ssgrid_billdetails.Col = 1
    '                ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
    '                If Trim(ssgrid_billdetails.Text) <> "" Then
    '                    ssgrid_billdetails.SetActiveCell(2, ssgrid_billdetails.ActiveRow)
    '                Else
    '                    ssgrid_billdetails.SetActiveCell(2, ssgrid_billdetails.ActiveRow)
    '                End If
    '            ElseIf ssgrid_billdetails.ActiveCol = 2 Then
    '                Call billingtermstaxamount(ssgrid_billdetails.ActiveRow)
    '            ElseIf ssgrid_billdetails.ActiveCol = 3 Then
    '                Call billingtermsrefresh(ssgrid_billdetails.ActiveRow)
    '            ElseIf ssgrid_billdetails.ActiveCol >= 4 Then
    '                Call BillingTermsTaxPercentage(ssgrid_billdetails.ActiveRow)
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : ssgrid_billdetails_LeaveCell " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub GridLock()
    '        Try
    '            Dim Row, Col As Integer
    '            ssgrid.Col = 11
    '            ssgrid.Row = ssgrid.ActiveRow
    '            For Row = 1 To 50
    '                For Col = 1 To 11
    '                    ssgrid.Row = Row
    '                    ssgrid.Col = Col
    '                    ssgrid.Lock = True
    '                Next
    '            Next
    '            ssgrid.Row = 1
    '            For Col = 1 To 11
    '                ssgrid.Col = Col
    '                ssgrid.Lock = False
    '            Next
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : GridLock " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub GridUnLock()
    '        Try
    '            Dim i, j As Integer
    '            For i = 1 To 100
    '                For j = 1 To 11
    '                    ssgrid.Col = j
    '                    ssgrid.Row = i
    '                    ssgrid.Lock = False
    '                Next j
    '            Next i
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error :  GridUnLock" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub ssgrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid.KeyDownEvent
    '        Dim ItemQty, ItemAmount, Salerate, ItemRate, Highratio, Dblamount As Double
    '        Dim sqlstring, Itemcode, Itemdesc As String
    '        Dim focusbool As Boolean
    '        Dim VaritemDesc As String
    '        Dim i, j, K As Integer
    '        search = Nothing
    '        sqlstring = "select VENDORLINK from invsetup"
    '        gconnection.getDataSet(sqlstring, "invsetup")
    '        If gdataset.Tables("invsetup").Rows.Count > 0 Then
    '            VENDORLINK = gdataset.Tables("invsetup").Rows(0).Item("VENDORLINK")
    '        End If
    '        Try
    '            If e.keyCode = Keys.Enter Then
    '                i = ssgrid.ActiveRow
    '                If ssgrid.ActiveCol = 1 Then
    '                    ssgrid.Col = 2
    '                    ssgrid.Row = i
    '                    VaritemDesc = Trim(ssgrid.Text)
    '                    ssgrid.Col = 1
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Trim(ssgrid.Text) = "" Then
    '                            Call FillMenuNew()
    '                            'Call FillMenu() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
    '                        ElseIf Trim(ssgrid.Text) <> "" Then
    '                            If VaritemDesc = "" Then
    '                                Itemcode = Trim(ssgrid.Text)
    '                                ssgrid.ClearRange(1, ssgrid.ActiveRow, 17, ssgrid.ActiveRow, True)
    '                                '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
    '                                'sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, ISNULL(I.BASERATE,0) AS BASERATE,"
    '                                'sqlstring = sqlstring & " ISNULL(O.CONVUOM,'') AS CONVUOM,ISNULL(O.HIGHRATIO,0) AS HIGHRATIO FROM INVENTORYITEMMASTER AS I INNER JOIN OPENINGSTOCK  AS O ON O.ITEMCODE = I.ITEMCODE "
    '                                'sqlstring = sqlstring & " WHERE I.ITEMCODE ='" & Trim(Itemcode) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'  AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' AND STORECODE='" & txt_Storecode.Text & "'"

    '                                '********* FOR RSI CLUB ****************
    '                                If VENDORLINK = "Y" Then
    '                                    sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, ISNULL(I.Profitper,0) AS Profitper, ISNULL(I.CONVVALUE,0) AS CONVUOM, ISNULL(v.vendorcode,'') AS VENDORCODE,ISNULL(a.slcode,'') AS SLCODE FROM INVENTORYITEMMASTER I, inv_vendormaster v, ACCOUNTSSUBLEDGERMASTER a"
    '                                    sqlstring = sqlstring & " WHERE I.ITEMCODE ='" & Trim(Itemcode) & "' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE= '" & txt_Storecode.Text & "' AND v.vendorcode = a.slcode And v.itemcode = I.itemcode AND V.VENDORCODE = '" & Trim(txt_Suppliercode.Text) & "'"
    '                                Else
    '                                    sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, ISNULL(I.Profitper,0) AS Profitper, ISNULL(I.CONVVALUE,0) AS CONVUOM FROM INVENTORYITEMMASTER I"
    '                                    sqlstring = sqlstring & " WHERE I.ITEMCODE ='" & Trim(Itemcode) & "' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE= '" & txt_Storecode.Text & "' "
    '                                End If
    '                                gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER")
    '                                If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count > 0 Then
    '                                    ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
    '                                    ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMNAME")))
    '                                    ssgrid.Col = 3
    '                                    ssgrid.SetText(5, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("PURCHASERATE")), "0.00"))
    '                                    ssgrid.SetText(7, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("PROFITPER")))
    '                                    ssgrid.SetText(12, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("CONVUOM")))
    '                                    'ssgrid.SetText(13, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("HIGHRATIO")), "0.00"))
    '                                    ssgrid.Col = 3
    '                                    Dim SqlQuery As String
    '                                    ssgrid.Row = ssgrid.ActiveRow
    '                                    SqlQuery = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")) & "'  "
    '                                    gconnection.getDataSet(SqlQuery, "InventoryItemUOM")
    '                                    If gdataset.Tables("InventoryItemUOM").Rows.Count > 1 Then
    '                                        Call FillTransUOM(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
    '                                    ElseIf gdataset.Tables("InventoryItemUOM").Rows.Count = 1 Then
    '                                        ssgrid.Row = ssgrid.ActiveRow
    '                                        ssgrid.TypeComboBoxString = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
    '                                        ssgrid.Text = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
    '                                    Else
    '                                        ssgrid.Row = ssgrid.ActiveRow
    '                                        ssgrid.Text = Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM")))
    '                                    End If
    '                                    ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                                    ssgrid.Focus()
    '                                Else
    '                                    MessageBox.Show("Specified ITEM CODE not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                    ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
    '                                    ssgrid.Text = ""
    '                                    ssgrid.Focus()
    '                                    Exit Sub
    '                                End If
    '                            End If
    '                        End If
    '                    Else
    '                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 2 Then
    '                    ssgrid.Col = 2
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Trim(ssgrid.Text) = "" Then
    '                            Call FillMenuItemNew() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
    '                        Else
    '                            ssgrid.Col = 4
    '                            ssgrid.Row = i
    '                            If Trim(ssgrid.Text) = "" Then
    '                                Itemdesc = Trim(ssgrid.Text)
    '                                ssgrid.ClearRange(1, ssgrid.ActiveRow, 17, ssgrid.ActiveRow, True)
    '                                '''****************************** $ TO fill ITEMCODE,ITEMDESC  $ **************************************'''
    '                                'sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, "
    '                                'sqlstring = sqlstring & " ISNULL(O.CONVUOM,'') AS CONVUOM,ISNULL(O.HIGHRATIO,0) AS HIGHRATIO FROM INVENTORYITEMMASTER AS I INNER JOIN OPENINGSTOCK  AS O ON O.ITEMCODE = I.ITEMCODE "
    '                                'sqlstring = sqlstring & " WHERE I.ITEMNAME ='" & Trim(Itemdesc) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'  AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "'"


    '                                '********* FOR RSI CLUB ****************
    '                                If VENDORLINK = "Y" Then
    '                                    sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE,ISNULL(I.PROFITPER,0) AS PROFITPER, ISNULL(I.CONVVALUE,0) AS CONVUOM, ISNULL(v.vendorcode,'') AS VENDORCODE,ISNULL(a.slcode,'') AS SLCODE FROM INVENTORYITEMMASTER I, inv_vendormaster v, ACCOUNTSSUBLEDGERMASTER a"
    '                                    sqlstring = sqlstring & " WHERE I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE= '" & txt_Storecode.Text & "' AND v.vendorcode = a.slcode And v.itemcode = I.itemcode AND V.VENDORCODE = '" & Trim(txt_Suppliercode.Text) & "'"
    '                                Else
    '                                    sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE,ISNULL(I.PROFITPER,0) AS PROFITPER, ISNULL(I.CONVVALUE,0) AS CONVUOM FROM INVENTORYITEMMASTER I"
    '                                    sqlstring = sqlstring & " WHERE I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE= '" & txt_Storecode.Text & "' "
    '                                End If
    '                                gconnection.getDataSet(sqlstring, "inventoryitemMaster")
    '                                If gdataset.Tables("inventoryitemMaster").Rows.Count > 0 Then
    '                                    ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
    '                                    ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMNAME")))
    '                                    ssgrid.Col = 3
    '                                    ssgrid.SetText(5, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("PURCHASERATE")), "0.00"))
    '                                    ssgrid.SetText(7, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("PROFITPER")))
    '                                    ssgrid.SetText(12, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("CONVUOM")))
    '                                    'ssgrid.SetText(13, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("HIGHRATIO")), "0.00"))
    '                                    Dim sqlQuery As String
    '                                    sqlQuery = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE"))) & "'   "
    '                                    gconnection.getDataSet(sqlQuery, "InventoryItemUOM")
    '                                    If gdataset.Tables("InventoryItemUOM").Rows.Count > 1 Then
    '                                        Call FillTransUOM(Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE"))))
    '                                    ElseIf gdataset.Tables("InventoryItemUOM").Rows.Count = 1 Then
    '                                        ssgrid.Row = ssgrid.ActiveRow
    '                                        ssgrid.TypeComboBoxString = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
    '                                        ssgrid.Text = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
    '                                    Else
    '                                        ssgrid.Row = ssgrid.ActiveRow
    '                                        ssgrid.Text = Trim(Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM"))))
    '                                    End If
    '                                    ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                                    ssgrid.Focus()
    '                                Else
    '                                    MessageBox.Show("Specified ITEM DESCRIPTION not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '                                    ssgrid.Text = ""
    '                                    ssgrid.Focus()
    '                                    Exit Sub
    '                                End If
    '                            End If
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 3 Then
    '                    ssgrid.Col = 3
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Trim(ssgrid.Text) = "" Then
    '                            ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                        Else
    '                            ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 4 Then
    '                    ssgrid.Col = 4
    '                    ssgrid.Row = i
    '                    ItemQty = Val(ssgrid.Text)
    '                    If ssgrid.Lock = False Then
    '                        If ssgrid.Lock = False Then
    '                            If Val(ssgrid.Text) = 0 Then
    '                                ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                            Else
    '                                Call Calculate() '''--> Calculate total amount
    '                                ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                                ssgrid.Focus()
    '                            End If
    '                        End If
    '                    Else
    '                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 5 Then
    '                    ssgrid.Col = 5
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Val(ssgrid.Text) = 0 Then
    '                            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                        Else
    '                            Call Calculate() '''--> Calculate total amount
    '                            ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
    '                            ssgrid.Focus()
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 6 Then
    '                    ssgrid.Col = 6
    '                    ssgrid.Row = i
    '                    Call Calculate() '''--> Calculate total amount
    '                    ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
    '                    ssgrid.Focus()
    '                ElseIf ssgrid.ActiveCol = 7 Then
    '                    ssgrid.Col = 7
    '                    ssgrid.Row = i
    '                    'Call Calculate() '''--> Calculate total amount
    '                    ssgrid.SetActiveCell(7, ssgrid.ActiveRow)
    '                    ssgrid.Focus()
    '                ElseIf ssgrid.ActiveCol = 8 Then
    '                    ssgrid.Col = 8
    '                    ssgrid.Row = i
    '                    Call Calculate() '''--> Calculate total amount
    '                    ssgrid.SetActiveCell(8, ssgrid.ActiveRow)
    '                    ssgrid.Focus()

    '                ElseIf ssgrid.ActiveCol = 9 Then
    '                    ssgrid.Col = 9
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Val(ssgrid.Text) = 0 Then
    '                            Call Calculate() '''--> Calculate total amount
    '                            ssgrid.Col = 9
    '                            ssgrid.Row = ssgrid.ActiveRow
    '                            ssgrid.Text = "0.00"
    '                            ssgrid.Row = ssgrid.ActiveRow + 1
    '                            ssgrid.Col = 1
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 2
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 3
    '                            If Mid(Cmd_Add.Text, 1, 1) = "A" Then
    '                                ssgrid.Lock = False
    '                            Else
    '                                If ssgrid.Lock = False Then
    '                                    ssgrid.Lock = False
    '                                End If
    '                            End If
    '                            ssgrid.Col = 4
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 5
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 6
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 7
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 8
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 9
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 10
    '                            ssgrid.Lock = False
    '                            ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
    '                        Else
    '                            Call Calculate() '''--> Calculate total amount
    '                            If Mid(Cmd_Add.Text, 1, 1) = "A" Then
    '                                ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
    '                            Else
    '                                ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
    '                            End If
    '                            'ssgrid.Row = ssgrid.ActiveRow + 1
    '                            ssgrid.Col = 1
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 2
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 3
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 4
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 5
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 6
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 7
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 8
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 9
    '                            ssgrid.Lock = False
    '                            ssgrid.Col = 10
    '                            ssgrid.Lock = False
    '                            ssgrid.SetActiveCell(11, ssgrid.ActiveRow)

    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 10 Then
    '                    ssgrid.Col = 10
    '                    ssgrid.Row = i
    '                    ItemAmount = Val(ssgrid.Text)
    '                    If ssgrid.Lock = False Then
    '                        If Trim(ssgrid.Text) = "" Then
    '                            ssgrid.SetActiveCell(9, ssgrid.ActiveRow)
    '                        Else
    '                            ssgrid.Col = 4
    '                            ItemQty = Val(ssgrid.Text)
    '                            ItemRate = Val(ItemAmount) / Val(ItemQty)
    '                            ssgrid.SetText(5, ssgrid.ActiveRow, ItemRate)
    '                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 11 Then
    '                    '''ssgrid.Col = 11
    '                    '''ssgrid.Row = i
    '                    ''''If ssgrid.Text < Val(tmpsalrate) - 1 Or ssgrid.Text > Val(tmpsalrate) + 1 Then
    '                    '''' MsgBox("Round off Rate should be With in +/- Rs.1")
    '                    ''''  Else
    '                    '''If ssgrid.Lock = False Then
    '                    '''    If Val(ssgrid.Text) = 0 Then
    '                    '''        ssgrid.SetActiveCell(10, ssgrid.ActiveRow)
    '                    '''    Else
    '                    '''        'Call Calculate() '''--> Calculate total amount
    '                    '''        Call Calculate1()
    '                    '''        ssgrid.SetActiveCell(18, ssgrid.ActiveRow)
    '                    '''        ssgrid.Lock = True
    '                    '''        ssgrid.Focus()
    '                    '''    End If
    '                    '''End If
    '                    '''' End If

    '                    'UPTO FREE QUANTITY --***VENUJD

    '                    ssgrid.Col = 11
    '                    ssgrid.Row = i
    '                    'If ssgrid.Text < Val(tmpsalrate) - 1 Or ssgrid.Text > Val(tmpsalrate) + 1 Then
    '                    ' MsgBox("Round off Rate should be With in +/- Rs.1")
    '                    '  Else
    '                    If ssgrid.Lock = False Then
    '                        'If Val(ssgrid.Text) = 0 Then
    '                        '    ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
    '                        'Else
    '                        'Call Calculate() '''--> Calculate total amount
    '                        Call Calculate1()
    '                        ssgrid.SetActiveCell(18, ssgrid.ActiveRow)
    '                        ssgrid.Lock = True
    '                        ssgrid.Focus()
    '                        'End If
    '                    End If
    '                    ' End If
    '                ElseIf ssgrid.ActiveCol = 12 Then
    '                    ssgrid.Col = 11
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Trim(ssgrid.Text) = "" Then
    '                            ssgrid.SetActiveCell(10, ssgrid.ActiveRow)
    '                        Else
    '                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 13 Then
    '                    ssgrid.Col = 13
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Trim(ssgrid.Text) = "" Then
    '                            ssgrid.SetActiveCell(12, ssgrid.ActiveRow)
    '                        Else
    '                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 14 Then
    '                    ssgrid.Col = 3
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        If Val(ssgrid.Text) = 0 Then
    '                            ssgrid.SetActiveCell(13, ssgrid.ActiveRow)
    '                        Else
    '                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
    '                        End If
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 18 Then
    '                    ssgrid.Col = 18
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        'If Trim(ssgrid.Text) = "" Then
    '                        ssgrid.SetActiveCell(18, ssgrid.ActiveRow)
    '                        ' Else
    '                        'ssgrid.SetActiveCell(0.5, ssgrid.ActiveRow + 1)
    '                        ' End If
    '                    End If
    '                    ssgrid.SetActiveCell(19, ssgrid.ActiveRow)
    '                End If
    '            ElseIf e.keyCode = Keys.F4 Then
    '                If ssgrid.ActiveCol = 1 Then
    '                    ssgrid.Col = 1
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        ssgrid.Col = 1
    '                        ssgrid.Row = ssgrid.ActiveRow
    '                        search = Trim(ssgrid.Text)
    '                        Call FillMenu()
    '                    End If
    '                ElseIf ssgrid.ActiveCol = 2 Then
    '                    ssgrid.Col = 2
    '                    ssgrid.Row = i
    '                    If ssgrid.Lock = False Then
    '                        ssgrid.Col = 2
    '                        ssgrid.Row = ssgrid.ActiveRow
    '                        search = Trim(ssgrid.Text)
    '                        Call FillMenuItem()
    '                    End If
    '                End If
    '            ElseIf e.keyCode = Keys.F3 Then
    '                ssgrid.Col = ssgrid.ActiveCol
    '                ssgrid.Row = i
    '                ssgrid.Row = ssgrid.ActiveRow
    '                'ssgrid.ClearRange(1, ssgrid.ActiveRow, 19, ssgrid.ActiveRow, True)
    '                ssgrid.DeleteRows(ssgrid.ActiveRow, 1)
    '                Call Calculate()
    '                ssgrid.ClearRange(1, ssgrid.ActiveRow, 19, ssgrid.ActiveRow, True)
    '                ssgrid.Row = ssgrid.ActiveRow
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
    '                ssgrid.Col = 7
    '                ssgrid.Lock = False
    '                ssgrid.Col = 8
    '                ssgrid.Lock = False
    '                ssgrid.Col = 9
    '                ssgrid.Lock = False
    '                ssgrid.Col = 10
    '                ssgrid.Lock = False
    '                ssgrid.Col = 11
    '                ssgrid.Lock = False
    '                ssgrid.Col = 12
    '                ssgrid.Lock = False
    '                ssgrid.Col = 13
    '                ssgrid.Lock = False
    '                ssgrid.Col = 14
    '                ssgrid.Lock = False
    '                ssgrid.Col = 15
    '                ssgrid.Lock = False
    '                ssgrid.Col = 16
    '                ssgrid.Lock = False
    '                ssgrid.Col = 17
    '                ssgrid.Lock = False

    '                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : ssgrid_KeyDownEvent " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub Calculate1()
    '        Dim pp, sr, r, x, y, z As Double
    '        Dim i As Integer
    '        i = ssgrid.ActiveRow
    '        ssgrid.Col = 11
    '        ssgrid.Row = i
    '        sr = Val(ssgrid.Text)
    '        ssgrid.Col = 5
    '        ssgrid.Row = i
    '        r = Val(ssgrid.Text)
    '        If Mid(Trim(CStr(icode1)), 1, 2) = "B0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W0" Or Mid(Trim(CStr(icode1)), 1, 2) = "W1" Or Mid(Trim(CStr(icode1)), 1, 2) = "W2" Or Mid(Trim(CStr(icode1)), 1, 2) = "W3" Or Mid(Trim(CStr(icode1)), 1, 1) = "G" Or Mid(Trim(CStr(icode1)), 1, 2) = "L0" Or Mid(Trim(CStr(icode1)), 1, 1) = "R" Or Mid(Trim(CStr(icode1)), 1, 1) = "V" Then
    '            x = (sr * 12.5) - r
    '            y = x / r
    '            z = y * 100
    '        Else
    '            x = sr - r
    '            y = x / r
    '            z = y * 100
    '        End If
    '        If Val(z) = 0 Then
    '            ssgrid.SetText(7, i, "")
    '        Else
    '            ssgrid.SetText(7, i, Val(z))
    '        End If
    '        ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
    '    End Sub
    '    Private Sub FillMenuItemNew()
    '        Try
    '            Dim vform As New ListOperattion1
    '            Dim K As Integer
    '            Dim ssql As String
    '            '''******************************************************** $ FILL THE ITEMDESC,ITEMCODE INTO SSGRID ********** 
    '            'gSQLString = "SELECT DISTINCT ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.ITEMCODE,'') AS ITEMCODE,"
    '            'gSQLString = gSQLString & "ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, "
    '            'gSQLString = gSQLString & " ISNULL(CONVVALUE,0) AS CONVVALUE FROM INVENTORYITEMMASTER AS I"
    '            'If Trim(search) = " " Then
    '            '    M_WhereCondition = ""
    '            'Else
    '            '    M_WhereCondition = " WHERE I.ITEMNAME LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'  AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "'"
    '            'End If
    '            If VENDORLINK = "Y" Then
    '                gSQLString = "SELECT DISTINCT ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE,ISNULL(I.PROFITPER,0) AS PROFITPER, ISNULL(CONVVALUE,0) AS CONVUOM, ISNULL(v.vendorcode,'') AS VENDORCODE,ISNULL(a.slcode,'') AS SLCODE FROM INVENTORYITEMMASTER I, inv_vendormaster v, ACCOUNTSSUBLEDGERMASTER a"
    '                If Trim(search) = " " Then
    '                    M_WhereCondition = ""
    '                Else
    '                    M_WhereCondition = " WHERE I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE= '" & txt_Storecode.Text & "' AND v.vendorcode = a.slcode And v.itemcode = I.itemcode AND V.VENDORCODE = '" & Trim(txt_Suppliercode.Text) & "'"
    '                End If
    '            Else
    '                gSQLString = "SELECT DISTINCT ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE,ISNULL(I.PROFITPER,0) AS PROFITPER, ISNULL(CONVVALUE,0) AS CONVUOM FROM INVENTORYITEMMASTER I"
    '                If Trim(search) = " " Then
    '                    M_WhereCondition = ""
    '                Else
    '                    M_WhereCondition = " WHERE I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE= '" & txt_Storecode.Text & "' "
    '                End If
    '            End If
    '            vform.Field = "I.ITEMNAME,I.ITEMCODE"
    '            vform.vFormatstring = "                     ITEMNAME                |   ITEMCODE    | STOCKUOM  |PURCHASERATE |PROFITPER | CONVUOM | VENDORCODE |"
    '            vform.vCaption = "INVENTORY ITEM CODE HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.KeyPos2 = 2
    '            vform.Keypos3 = 3
    '            vform.keypos4 = 4
    '            vform.Keypos5 = 5
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                ssgrid.Col = 1
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield1)
    '                ssgrid.Col = 2
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield)
    '                ssgrid.Col = 3
    '                Dim SqlQuery As String
    '                ssgrid.Row = ssgrid.ActiveRow
    '                SqlQuery = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK   WHERE Itemcode ='" & Trim(vform.keyfield1) & "'  and STORECODE='" & txt_Storecode.Text & "'"
    '                gconnection.getDataSet(SqlQuery, "InventoryItemUOM")
    '                If gdataset.Tables("InventoryItemUOM").Rows.Count > 1 Then
    '                    Call FillTransUOM(Trim(vform.keyfield1))
    '                ElseIf gdataset.Tables("InventoryItemUOM").Rows.Count = 1 Then
    '                    ssgrid.Row = ssgrid.ActiveRow
    '                    ssgrid.TypeComboBoxString = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
    '                    ssgrid.Text = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
    '                Else
    '                    ssgrid.Row = ssgrid.ActiveRow
    '                    ssgrid.Text = Trim(vform.keyfield2)
    '                End If
    '                ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                ssgrid.Focus()
    '                ''
    '                ''ssgrid.TypeComboBoxString = Trim(vform.keyfield2)
    '                ''ssgrid.Text = Trim(vform.keyfield2)
    '                ssgrid.Col = 5
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Format(Val(vform.keyfield3), "0.00")
    '                ssgrid.Col = 7
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield4)
    '                ssgrid.Col = 13
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield5)
    '                ssgrid.Col = 14
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Format(Val(vform.keyfield6), "0.00")
    '                ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                ssgrid.Focus()
    '            Else
    '                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '                Exit Sub
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : FillMenuItem" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub FillMenuNew()
    '        Try
    '            Dim vform As New ListOperattion1
    '            Dim K As Integer
    '            Dim SqlQuery As String
    '            '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 

    '            '''gSQLString = "SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, "
    '            '''gSQLString = gSQLString & " ISNULL(CONVVALUE,0) AS CONVUOM FROM INVENTORYITEMMASTER I"
    '            '''If Trim(search) = " " Then
    '            '''    M_WhereCondition = ""
    '            '''Else
    '            '''    M_WhereCondition = " WHERE I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE='" & txt_Storecode.Text & "'" 
    '            '''End If

    '            '''****************** FOR RSI CLUB ************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
    '            'VenuJD 24JUNE11
    '            If VENDORLINK = "Y" Then
    '                gSQLString = "SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, ISNULL(I.Profitper,0) AS Profitper, ISNULL(CONVVALUE,0) AS CONVUOM, ISNULL(v.vendorcode,'') AS VENDORCODE,ISNULL(a.slcode,'') AS SLCODE FROM INVENTORYITEMMASTER I, inv_vendormaster v, ACCOUNTSSUBLEDGERMASTER a"
    '                If Trim(search) = " " Then
    '                    M_WhereCondition = ""
    '                Else
    '                    M_WhereCondition = " WHERE I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE= '" & txt_Storecode.Text & "' AND v.vendorcode = a.slcode And v.itemcode = I.itemcode AND V.VENDORCODE = '" & Trim(txt_Suppliercode.Text) & "'"
    '                End If
    '            Else
    '                gSQLString = "SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, ISNULL(I.Profitper,0) AS Profitper, ISNULL(CONVVALUE,0) AS CONVUOM FROM INVENTORYITEMMASTER I"
    '                If Trim(search) = " " Then
    '                    M_WhereCondition = ""
    '                Else
    '                    M_WhereCondition = " WHERE I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE= '" & txt_Storecode.Text & "' "
    '                End If
    '            End If
    '            vform.Field = " I.ITEMNAME, I.ITEMCODE"
    '            vform.vFormatstring = "    ITEMCODE    |                     ITEMNAME                    |  STOCKUOM  | PURCHASERATE |PROFITPER | CONVUOM | VENDORCODE |"
    '            vform.vCaption = "INVENTORY ITEM CODE HELP"
    '            vform.KeyPos = 0
    '            vform.KeyPos1 = 1
    '            vform.KeyPos2 = 2
    '            vform.Keypos3 = 3
    '            vform.keypos4 = 4
    '            vform.Keypos5 = 5
    '            vform.ShowDialog(Me)
    '            If Trim(vform.keyfield & "") <> "" Then
    '                ssgrid.Col = 1
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield)
    '                ssgrid.Col = 2
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield1)
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ''ssgrid.TypeComboBoxString = Trim(vform.keyfield2)
    '                ''ssgrid.Text = Trim(vform.keyfield2)
    '                ssgrid.Col = 5
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Format(Val(vform.keyfield3), "0.00")
    '                ssgrid.Col = 7
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield4)
    '                ssgrid.Col = 13
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Trim(vform.keyfield5)
    '                ssgrid.Col = 14
    '                ssgrid.Row = ssgrid.ActiveRow
    '                ssgrid.Text = Format(Val(vform.keyfield6), "0.00")
    '                ssgrid.Col = 3
    '                '  SqlQuery = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & Trim(vform.keyfield) & "' and STORECODE='" & txt_Storecode.Text & "'"
    '                SqlQuery = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & Trim(vform.keyfield) & "' "
    '                gconnection.getDataSet(SqlQuery, "InventoryItemUOM")
    '                If gdataset.Tables("InventoryItemUOM").Rows.Count > 1 Then
    '                    Call FillTransUOM(Trim(vform.keyfield))
    '                ElseIf gdataset.Tables("InventoryItemUOM").Rows.Count = 1 Then
    '                    ssgrid.Row = ssgrid.ActiveRow
    '                    ssgrid.TypeComboBoxString = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
    '                    ssgrid.Text = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
    '                Else
    '                    ssgrid.Row = ssgrid.ActiveRow
    '                    ssgrid.Text = Trim(vform.keyfield2)
    '                End If
    '                ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
    '                ssgrid.Focus()
    '            Else
    '                ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
    '                Exit Sub
    '            End If
    '            vform.Close()
    '            vform = Nothing
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : FillMenu" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub FillTransUOM(ByVal itemcode As String)
    '        'gSQLString = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & itemcode & "'  and STORECODE='" & txt_Storecode.Text & "' "
    '        gSQLString = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & itemcode & "'   "

    '        If Trim(search) = " " Then
    '            M_WhereCondition = ""
    '        Else
    '            M_WhereCondition = " AND  Tranuom LIKE '" & Trim(search) & "%'"
    '        End If
    '        Dim vform1 As New ListOperattion1
    '        vform1.Field = "TRANUOM"
    '        vform1.vFormatstring = "     TRANS UOM                                                                                                   "
    '        vform1.vCaption = " PURCHASE UOMMASTER HELP"
    '        vform1.KeyPos = 0
    '        vform1.ShowDialog(Me)
    '        If Trim(vform1.keyfield & "") <> "" Then
    '            ssgrid.Col = 3
    '            ssgrid.Row = ssgrid.ActiveRow
    '            ssgrid.Text = Trim(vform1.keyfield & "")
    '            ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '            ssgrid.Focus()
    '        End If
    '        vform1.Close()
    '        vform1 = Nothing
    '    End Sub
    '    Private Sub ssgrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid.LeaveCell
    '        Dim ItemQty, ItemAmount, ItemRate, Highratio, Dblamount, DblQty As Double
    '        Dim sqlstring, Itemcode, Itemdesc As String
    '        Dim discount, quantity, Salerate As Double
    '        Dim focusbool As Boolean
    '        Dim i, j As Integer
    '        Dim vitemdesc As String
    '        search = Nothing
    '        Try
    '            Call GridUnLock()
    '            i = ssgrid.ActiveRow
    '            If ssgrid.ActiveCol = 2 Then
    '                ssgrid.Col = 2
    '                ssgrid.Row = i
    '                vitemdesc = Trim(ssgrid.Text)
    '                ssgrid.Col = 4
    '                ssgrid.Row = i
    '                DblQty = Val(ssgrid.Text)
    '                ssgrid.Col = 2
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Trim(ssgrid.Text) <> "" Then
    '                        If vitemdesc = "" Then
    '                            If Val(DblQty) = 0 Then
    '                                Itemdesc = Trim(ssgrid.Text)
    '                                ssgrid.ClearRange(1, ssgrid.ActiveRow, 12, ssgrid.ActiveRow, True)
    '                                '''****************************** $ TO fill ITEMCODE,ITEMDESC  $ **************************************'''
    '                                'sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, "
    '                                'sqlstring = sqlstring & " ISNULL(O.CONVUOM,'') AS CONVUOM,ISNULL(O.HIGHRATIO,0) AS HIGHRATIO FROM INVENTORYITEMMASTER AS I INNER JOIN OPENINGSTOCK  AS O ON O.ITEMCODE = I.ITEMCODE "
    '                                'sqlstring = sqlstring & " WHERE I.ITEMNAME ='" & Trim(Itemdesc) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'"
    '                                sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE,ISNULL(I.BASERATE,0) AS BASERATE, ISNULL(I.CONVVALUE,0) AS CONVUOM, ISNULL(v.vendorcode,'') AS VENDORCODE,ISNULL(a.slcode,'') AS SLCODE FROM INVENTORYITEMMASTER I, inv_vendormaster v, ACCOUNTSSUBLEDGERMASTER a"
    '                                sqlstring = sqlstring & " WHERE I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE= '" & txt_Storecode.Text & "' AND v.vendorcode = a.slcode And v.itemcode = I.itemcode AND V.VENDORCODE = '" & Trim(txt_Suppliercode.Text) & "'"

    '                                gconnection.getDataSet(sqlstring, "inventoryitemMaster")
    '                                If gdataset.Tables("inventoryitemMaster").Rows.Count > 0 Then
    '                                    ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
    '                                    ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMNAME")))
    '                                    ssgrid.SetText(3, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM")))
    '                                    ssgrid.SetText(5, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("PURCHASERATE")), "0.00"))
    '                                    ssgrid.SetText(13, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("CONVUOM")))
    '                                    'ssgrid.SetText(14, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("HIGHRATIO")), "0.00"))
    '                                    ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                                    ssgrid.Focus()
    '                                Else
    '                                    MessageBox.Show("Specified ITEM DESCRIPTION not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '                                    ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
    '                                    ssgrid.Text = ""
    '                                    ssgrid.Focus()
    '                                    Exit Sub
    '                                End If
    '                            End If
    '                        End If
    '                    End If
    '                End If
    '            ElseIf ssgrid.ActiveCol = 3 Then
    '                ssgrid.Col = 3
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Trim(ssgrid.Text) = "" Then
    '                        ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                    Else
    '                        ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                    End If
    '                End If
    '            ElseIf ssgrid.ActiveCol = 4 Then
    '                ssgrid.Col = 4
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Val(ssgrid.Text) = 0 Then
    '                        ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
    '                    Else
    '                        Call Calculate() '''--> Calculate total amount
    '                        ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
    '                    End If
    '                End If
    '            ElseIf ssgrid.ActiveCol = 5 Then
    '                ssgrid.Col = 5
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    Call Calculate() '''--> Calculate total amount
    '                    ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
    '                Else
    '                    ssgrid.SetActiveCell(5, i)
    '                End If
    '            ElseIf ssgrid.ActiveCol = 6 Then
    '                ssgrid.Col = 6
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    Call Calculate() '''--> Calculate total amount
    '                    ssgrid.SetActiveCell(7, ssgrid.ActiveRow)

    '                Else
    '                    ssgrid.SetActiveCell(6, i)
    '                End If
    '            ElseIf ssgrid.ActiveCol = 7 Then
    '                ssgrid.Col = 8
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    'Call Calculate() '''--> Calculate total amount
    '                    ssgrid.SetActiveCell(8, ssgrid.ActiveRow)
    '                Else
    '                    ssgrid.SetActiveCell(7, i)
    '                End If

    '            ElseIf ssgrid.ActiveCol = 8 Then
    '                ssgrid.Col = 8
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    Call Calculate() '''--> Calculate total amount
    '                    ssgrid.SetActiveCell(9, ssgrid.ActiveRow)
    '                Else
    '                    ssgrid.SetActiveCell(8, i)
    '                End If
    '            ElseIf ssgrid.ActiveCol = 9 Then
    '                ssgrid.Col = 9
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Val(ssgrid.Text) = 0 Then
    '                        Call Calculate() '''--> Calculate total amount
    '                        ssgrid.Col = 9
    '                        ssgrid.Row = ssgrid.ActiveRow
    '                        ssgrid.Text = "0.00"
    '                        ssgrid.Row = ssgrid.ActiveRow + 1
    '                        ssgrid.Col = 1
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 2
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 3
    '                        If Mid(Cmd_Add.Text, 1, 1) = "A" Then
    '                            ssgrid.Lock = False
    '                        Else
    '                            If ssgrid.Lock = False Then
    '                                ssgrid.Lock = False
    '                            End If
    '                        End If

    '                        ssgrid.Col = 4
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 5
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 6
    '                        ssgrid.Lock = False
    '                        'ssgrid.Col = 7
    '                        'ssgrid.Lock = False
    '                        ssgrid.Col = 8
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 9
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 10
    '                        ssgrid.Lock = False

    '                        ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
    '                    Else
    '                        Call Calculate() '''--> Calculate total amount
    '                        If Mid(Cmd_Add.Text, 1, 1) = "A" Then
    '                            ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
    '                        Else
    '                            ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
    '                        End If

    '                        'ssgrid.Row = ssgrid.ActiveRow + 1
    '                        ssgrid.Col = 1
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 2
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 3
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 4
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 5
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 6
    '                        ssgrid.Lock = False
    '                        'ssgrid.Col = 7
    '                        'ssgrid.Lock = False
    '                        ssgrid.Col = 8
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 9
    '                        ssgrid.Lock = False
    '                        ssgrid.Col = 10
    '                        ssgrid.Lock = False
    '                        'If Mid(Cmd_Add.Text, 1, 1) = "A" Then
    '                        ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
    '                        'Else
    '                        '    ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
    '                        'End If

    '                    End If
    '                End If
    '            ElseIf ssgrid.ActiveCol = 10 Then
    '                ssgrid.Col = 10
    '                ssgrid.Row = i
    '                ItemAmount = Format(ssgrid.Text, "0.00")
    '                If ssgrid.Lock = False Then
    '                    If Trim(ssgrid.Text) = "" Then
    '                        ssgrid.SetActiveCell(10, ssgrid.ActiveRow)
    '                    Else
    '                        ssgrid.Col = 4
    '                        ItemQty = Format(ssgrid.Text, "0.00")
    '                        ItemRate = ItemAmount / ItemQty
    '                        ssgrid.Text = Format(ItemRate, "0.00")
    '                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
    '                    End If
    '                End If
    '            ElseIf ssgrid.ActiveCol = 11 Then
    '                ssgrid.Col = 11
    '                ssgrid.Row = i
    '                tmpsalrate = ssgrid.Text
    '                If ssgrid.Lock = False Then
    '                    'Call Calculate() '''--> Calculate total amount
    '                    Call Calculate1()
    '                    ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
    '                    If ssgrid.Lock = True Then
    '                        ssgrid.SetActiveCell(1, i + 1)
    '                    End If
    '                Else
    '                    ssgrid.SetActiveCell(0, i)
    '                End If

    '            ElseIf ssgrid.ActiveCol = 12 Then
    '                ssgrid.Col = 12
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Trim(ssgrid.Text) = "" Then
    '                        ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
    '                    Else
    '                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
    '                    End If
    '                End If
    '            ElseIf ssgrid.ActiveCol = 13 Then
    '                ssgrid.Col = 13
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Trim(ssgrid.Text) = "" Then
    '                        ssgrid.SetActiveCell(13, ssgrid.ActiveRow)
    '                    Else
    '                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
    '                    End If
    '                End If
    '            ElseIf ssgrid.ActiveCol = 14 Then
    '                ssgrid.Col = 3
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Trim(ssgrid.Text) = "" Then
    '                        ssgrid.SetActiveCell(14, ssgrid.ActiveRow)
    '                    Else
    '                        ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
    '                    End If
    '                End If


    '            ElseIf ssgrid.ActiveCol = 18 Then
    '                ssgrid.Col = 18
    '                ssgrid.Row = i
    '                If ssgrid.Lock = False Then
    '                    If Trim(ssgrid.Text) = "" Then
    '                        ssgrid.SetActiveCell(18, ssgrid.ActiveRow)
    '                    Else
    '                        ssgrid.SetActiveCell(19, ssgrid.ActiveRow)
    '                    End If
    '                End If

    '                'ssgrid.SetActiveCell(1, ssgrid.ActiveRow + 1)
    '            End If

    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : ssgrid_LeaveCell " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Vatamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Vatamount_TextChanged " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Vatamount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        Try
    '            Call getNumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                txt_Surchargeamt.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Vatamount_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Surchargeamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Surchargeamt.KeyPress
    '        Try
    '            Call getNumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                TXT_OVERALLdiscount.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Surchargeamt_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Discountamt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Discountamt.KeyPress
    '        Try
    '            Call getNumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                Cmd_Add.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Discountamt_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Surchargeamt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Surchargeamt.TextChanged
    '        Try
    '            If Val(txt_Surchargeamt.Text) <> 0 Then
    '                txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Surchargeamt_TextChanged" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_Discountamt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Discountamt.TextChanged
    '        Try
    '            If Val(txt_Discountamt.Text) <> 0 Then
    '                txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Discountamt_TextChanged" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Vatamount_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Try
    '            txt_Vatamount.Text = Format(Val(txt_Vatamount.Text), "0.00")
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Vatamount_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub txt_Surchargeamt_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Surchargeamt.LostFocus
    '        Try
    '            txt_Surchargeamt.Text = Format(Val(txt_Surchargeamt.Text), "0.00")
    '            If Val(txt_Surchargeamt.Text) <> 0 Then
    '                txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Surchargeamt_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub PO_HireOrder_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
    '        Try
    '            GRNCumPurchaseBillTransbool = False
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : PO_HireOrder_Closed" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_FromDocno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_FromDocno.KeyDown
    '        Try
    '            If e.KeyCode = Keys.F4 Then
    '                If Cmd_FromDocno.Enabled = True Then
    '                    search = Trim(txt_FromDocno.Text)
    '                    Call Cmd_FromDocno_Click(Cmd_FromDocno, e)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_FromDocno_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_ToDocno_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ToDocno.KeyDown
    '        Try
    '            If e.KeyCode = Keys.F4 Then
    '                If Cmd_ToDocno.Enabled = True Then
    '                    search = Trim(txt_ToDocno.Text)
    '                    Call Cmd_ToDocno_Click(Cmd_ToDocno, e)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_ToDocno_KeyDown" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_FromDocno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FromDocno.Validated
    '        If Trim(txt_FromDocno.Text) <> "" Then
    '            Try
    '                sqlstring = "SELECT  ISNULL(GRNNO,'') AS GRNNO,ISNULL(GRNDETAILS,'') AS GRNDETAILS"
    '                sqlstring = sqlstring & " FROM GRN_HEADER WHERE GRNNO = '" & Format(Val(txt_FromDocno.Text), "0000") & "' OR GRNDETAILS='" & Trim(txt_FromDocno.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "GRNHEADER")
    '                If gdataset.Tables("GRNHEADER").Rows.Count > 0 Then
    '                    Me.txt_FromDocno.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("GRNDETAILS"))
    '                    Me.txt_FromDocno.ReadOnly = True
    '                End If
    '            Catch
    '                Exit Sub
    '            End Try
    '        End If
    '    End Sub

    '    Private Sub txt_ToDocno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ToDocno.Validated
    '        If Trim(txt_ToDocno.Text) <> "" Then
    '            Try
    '                sqlstring = "SELECT  ISNULL(GRNNO,'') AS GRNNO,ISNULL(GRNDETAILS,'') AS GRNDETAILS"
    '                sqlstring = sqlstring & " FROM GRN_HEADER WHERE GRNNO = '" & Format(Val(txt_ToDocno.Text), "0000") & "' OR GRNDETAILS='" & Trim(txt_ToDocno.Text) & "'"
    '                gconnection.getDataSet(sqlstring, "GRNHEADER")
    '                If gdataset.Tables("GRNHEADER").Rows.Count > 0 Then
    '                    Me.txt_ToDocno.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("GRNDETAILS"))
    '                    Me.txt_ToDocno.ReadOnly = True
    '                End If
    '            Catch
    '                Exit Sub
    '            End Try
    '        End If
    '    End Sub
    '    Private Sub CMB_CATEGORY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMB_CATEGORY.SelectedIndexChanged
    '        Try
    '            Call FOOTER()
    '            If Cmd_Add.Text = "Add [F7]" Then
    '                doctype = Trim(CMB_CATEGORY.Text)
    '                Call autogenerate()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
    '        Try
    '            gPrint = True
    '            'Call printoperation()
    '            Dim rViewer As New Viewer
    '            Dim sqlstring, SSQL As String
    '            Dim r As New Rpt_GrnBill
    '            sqlstring = "SELECT ISNULL(PONO,'') AS PONO, ISNULL(GRNDETAILS,'') AS GRNDETAILS,GRNDATE, ISNULL(SUPPLIERCODE,'') AS SUPPLIERCODE, ISNULL(SUPPLIERNAME,'') AS SUPPLIERNAME,"
    '            sqlstring = sqlstring & " ISNULL(SUPPLIERINVNO,'') AS SUPPLIERINVNO,  ISNULL(EXCISEPASSNO,'') AS EXCISEPASSNO,ISNULL(GLACCOUNTCODE,'') AS GLACCOUNTCODE,ISNULL(GLACCOUNTNAME,'') AS GLACCOUNTNAME,"
    '            sqlstring = sqlstring & " ISNULL(TOTALAMOUNT,0) AS TOTALAMOUNT,ISNULL(VATAMOUNT,0) AS VATAMOUNT,ISNULL(SURCHARGEAMT,0) AS SURCHARGEAMT,ISNULL(DISCOUNT,0) AS DISCOUNT,ISNULL(BILLAMOUNT,0) AS BILLAMOUNT,"
    '            sqlstring = sqlstring & " ISNULL(ITEMCODE,'') AS ITEMCODE, ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM, ISNULL(QTY,0) AS QTY, ISNULL(RATE,0) AS RATE,ISNULL(REMARKS,'') AS REMARKS, "
    '            sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT,isnull(discount,0) as ddiscount,isnull(taxper,0) as taxper,isnull(taxamount,0) as taxamount, isnull(OverallDiscount,0) OverallDiscount,ISNULL(UPDFOOTER,'') AS UPDFOOTER,ISNULL(UPDNAME,'') AS UPDNAME "
    '            sqlstring = sqlstring & " FROM VW_INV_GRNBILL "
    '            sqlstring = sqlstring & " WHERE GRNDETAILS BETWEEN '" & Trim(txt_Grnno.Text) & "' AND '" & Trim(txt_Grnno.Text) & "'"
    '            sqlstring = sqlstring & " ORDER BY AUTOID ,GRNDETAILS,GRNDATE"

    '            gconnection.getDataSet(sqlstring, "VW_INV_GRNBILL")
    '            If gdataset.Tables("VW_INV_GRNBILL").Rows.Count > 0 Then
    '                rViewer.ssql = sqlstring
    '                rViewer.Report = r
    '                rViewer.TableName = "VW_INV_GRNBILL"
    '                Dim textobj1 As TextObject
    '                textobj1 = r.ReportDefinition.ReportObjects("Text13")
    '                textobj1.Text = MyCompanyName

    '                Dim textobj2 As TextObject
    '                textobj2 = r.ReportDefinition.ReportObjects("Text30")
    '                textobj2.Text = gUsername
    '                rViewer.Show()
    '            Else
    '                MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : cmd_print_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub CMB_CATEGORY_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CMB_CATEGORY.KeyDown
    '        Try
    '            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
    '                Call autogenerate()
    '                'dtp_Grndate.Focus()
    '                If gpocode = "Y" Then
    '                    Txt_PONo.Enabled = True
    '                    cmd_PONOhelp.Enabled = True
    '                    Txt_PONo.Focus()
    '                Else
    '                    txt_Grnno.Focus()
    '                    Txt_PONo.Enabled = False
    '                    cmd_PONOhelp.Enabled = False
    '                End If
    '                'Txt_PONo.Focus()
    '                CMB_CATEGORY.Enabled = False
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : CMB_CATEGORY_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub Cmd_Storecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        gSQLString = "SELECT DISTINCT(storecode),storedesc FROM storemaster "
    '        M_WhereCondition = " where freeze <> 'Y' "
    '        Dim vform As New ListOperattion1
    '        vform.Field = "STOREDESC,STORECODE"
    '        vform.vFormatstring = "         STORE CODE              |                  STORE DESCRIPTION                                                                                                   "
    '        vform.vCaption = "INVENTORY STORE MASTER HELP"
    '        vform.KeyPos = 0
    '        vform.KeyPos1 = 1
    '        vform.ShowDialog(Me)
    '        If Trim(vform.keyfield & "") <> "" Then
    '            txt_Storecode.Text = Trim(vform.keyfield & "")
    '            txt_StoreDesc.Text = Trim(vform.keyfield1 & "")
    '            'Txt_GLAcIn.Focus()
    '            ssgrid.Focus()
    '        End If
    '        vform.Close()
    '        vform = Nothing
    '    End Sub
    '    Private Sub txt_Storecode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim I, J, K As Integer
    '        Dim vString, sqlstring, Strsql1 As String
    '        Dim GRNDATE As Date
    '        Dim vTypeseqno, Clsquantity As Double
    '        Dim vGroupseqno As Double
    '        Dim dt As New DataTable
    '        Try
    '            J = 0
    '            If Mid(CStr(Cmd_Add.Text), 1, 1) = "U" Then
    '                Strsql1 = "Select Storecode from Grn_Header  WHERE  GRNDETAILS ='" & Trim(txt_Grnno.Text) & "'"
    '                gconnection.getDataSet(Strsql1, "StrDetails")
    '                If gdataset.Tables("StrDetails").Rows.Count > 0 Then
    '                    If Trim(txt_Storecode.Text) = Trim(gdataset.Tables("StrDetails").Rows(J).Item("StoreCode")) Then
    '                        sqlstring = "SELECT * FROM storemaster WHERE storecode='" & Trim(txt_Storecode.Text) & "'"
    '                        gconnection.getDataSet(sqlstring, "storemaster")
    '                        If gdataset.Tables("storemaster").Rows.Count > 0 Then
    '                            txt_Storecode.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storecode"))
    '                            txt_StoreDesc.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storedesc"))
    '                        End If
    '                    Else
    '                        sqlstring = "SELECT * FROM storemaster WHERE storecode='" & Trim(txt_Storecode.Text) & "'"
    '                        gconnection.getDataSet(sqlstring, "storemaster")
    '                        If gdataset.Tables("storemaster").Rows.Count > 0 Then
    '                            txt_StoreDesc.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storedesc"))
    '                        End If
    '                        Dim vtmpitemcode, strsql, OldStore As String
    '                        OldStore = Trim(gdataset.Tables("StrDetails").Rows(J).Item("StoreCode"))
    '                        sqlstring = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM,"
    '                        sqlstring = sqlstring & " ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE,ISNULL(DISCOUNT,0) AS DISCOUNT,ISNULL(TAXPER,0) AS TAXPER,ISNULL(TAXAMOUNT,0) AS TAXAMOUNT,ISNULL(AMOUNT,0) AS AMOUNT,ISNULL(CATEGORY,'')AS CATEGORY,"
    '                        sqlstring = sqlstring & " ISNULL(DBLAMOUNT,0) AS DBLAMOUNT,ISNULL(DBLUOM,'') AS DBLUOM,ISNULL(HIGHRATIO,0) AS HIGHRATIO,ISNULL(VOIDITEM,'') AS VOIDITEM , isnull(OTHCHARGE,0) AS OTHCHARGE FROM GRN_DETAILS WHERE  GRNDETAILS ='" & Trim(txt_Grnno.Text) & "'"
    '                        sqlstring = sqlstring & " ORDER BY AUTOID "
    '                        gconnection.getDataSet(sqlstring, "GRNDETAILS")
    '                        If gdataset.Tables("GRNDETAILS").Rows.Count > 0 Then
    '                            For I = 1 To gdataset.Tables("GRNDETAILS").Rows.Count
    '                                vtmpitemcode = Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("ITEMCODE"))
    '                                GRNDATE = Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy")
    '                                Clsquantity = ClosingQuantity_Date(vtmpitemcode, OldStore, Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("UOM")), GRNDATE)
    '                                If Val(Clsquantity) - Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("Qty")) < 0 Then
    '                                    MsgBox("Sorry!There is Negative Stock for ItemCode :  " & UCase(vtmpitemcode) & "   If Changing Store  ")
    '                                    Cmd_Clear_Click(sender, e)
    '                                End If
    '                                J = J + 1
    '                            Next
    '                        End If
    '                    End If
    '                End If
    '            Else
    '                If Trim(txt_Storecode.Text) <> "" Then
    '                    sqlstring = "SELECT * FROM storemaster WHERE storecode='" & Trim(txt_Storecode.Text) & "'"
    '                    gconnection.getDataSet(sqlstring, "storemaster")
    '                    If gdataset.Tables("storemaster").Rows.Count > 0 Then
    '                        txt_Storecode.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storecode"))
    '                        txt_StoreDesc.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storedesc"))
    '                        Txt_GLAcIn.Focus()
    '                    End If
    '                End If
    '            End If

    '        Catch
    '            MessageBox.Show("Check The Error", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub txt_Storecode_KeyPress1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        If Asc(e.KeyChar) = 13 Then
    '            If Trim(txt_Storecode.Text) = "" Then
    '                Call Cmd_Storecode_Click(Cmd_Storecode, e)
    '            Else
    '                Call txt_Storecode_Validated(sender, e)
    '                ssgrid.Focus()
    '                '  Txt_GLAcIn.Focus()
    '            End If
    '        End If
    '    End Sub
    '    Private Sub txt_Storecode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
    '        If e.KeyCode = Keys.F4 Then
    '            If Cmd_Storecode.Enabled = True Then
    '                Call Cmd_Storecode_Click(Cmd_Storecode, e)
    '            End If
    '        End If
    '    End Sub

    '    Private Sub cmd_PONOhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        gSQLString = "SELECT ISNULL(pono,'') AS PONO,ISNULL(podate,'')AS PODATE,ISNULL(podepartment,'') AS PODEPARTMENT FROM PO_HDR"
    '        M_WhereCondition = " WHERE FREEZE <> 'Y' "
    '        Dim vform As New List_Operation
    '        vform.Field = "PONO,PODATE,PODEPARTMENT"
    '        vform.vFormatstring1 = "         PONO            |        PODATE         |        PODEPARTMENT                                   "
    '        vform.vCaption = "PURCHASE MASTER HELP"
    '        vform.KeyPos = 0
    '        vform.KeyPos1 = 1
    '        vform.ShowDialog(Me)

    '        If Trim(vform.keyfield & "") <> "" Then
    '            Txt_PONo.Text = Trim(vform.keyfield & "")
    '            gSQLString = "select * from grn_header where pono = '" & Trim(Txt_PONo.Text) & "'"
    '            gconnection.getDataSet(gSQLString, "GrnHdr")
    '            If gdataset.Tables("GrnHdr").Rows.Count > 0 Then
    '                Txt_PONo.Text = Trim(gdataset.Tables("GrnHdr").Rows(0).Item("pono"))
    '                txt_Grnno.Text = Trim(gdataset.Tables("GrnHdr").Rows(0).Item("grndetails"))
    '                Call txt_Grnno_Validated(txt_Grnno.Text, e)
    '                txt_Grnno.Focus()
    '            Else
    '                Call Txt_PONo_Validated(Txt_PONo.Text, e)
    '                Call Calculate()
    '            End If
    '        End If
    '        'Call Grid_lock()
    '        vform.Close()
    '        vform = Nothing
    '        'txt_PONo.Focus()
    '        Cmd_Freeze.Enabled = True
    '    End Sub
    '    Private Sub Txt_PONo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim strsql As String
    '        Dim totAmt, Discnt, itemRate, itemQty, tempDisc As Double
    '        Dim sqlstring, financalyear As String
    '        Dim voucherno As String
    '        Dim CreditDebit As String
    '        Dim i, j As Integer
    '        Dim amount As Double
    '        Dim accounthead, slhead, costhead As String

    '        PoNumber = Nothing

    '        If Trim(Me.Txt_PONo.Text) <> "" Then
    '            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialyearEnd, 3, 4)
    '            If Val(Me.Txt_PONo.Text) > 0 Then
    '                Me.Txt_PONo.Text = doctype & "/" & Format(Val(Me.Txt_PONo.Text), "000000") & "/" & financalyear
    '            End If
    '            PoNumber = Trim(Me.Txt_PONo.Text)
    '        End If

    '        strsql = " select * from grn_header where pono = '" & Trim(Me.Txt_PONo.Text) & "' "
    '        gconnection.getDataSet(strsql, "grnhdrchk")
    '        If gdataset.Tables("grnhdrchk").Rows.Count > 0 Then
    '            Me.txt_Grnno.Text = Trim(gdataset.Tables("grnhdrchk").Rows(0).Item("grndetails"))
    '            Call txt_Grnno_Validated(txt_Grnno.Text, e)
    '            txt_Grnno.Focus()
    '        ElseIf Trim(Txt_PONo.Text) <> "" Then
    '            strsql = "SELECT * FROM PO_HDR WHERE pono='" & Trim(Txt_PONo.Text) & "'"
    '            strsql = strsql & " AND FREEZE <> 'Y' "
    '            gconnection.getDataSet(strsql, "PO_HDR")
    '            If gdataset.Tables("PO_HDR").Rows.Count > 0 Then
    '                Txt_PONo.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PONO"))
    '                txt_Remarks.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POremarks"))
    '                'Cbo_PODate.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PODATE"))

    '                strsql = " SELECT * FROM STOREMASTER WHERE STOREDESC = '" & Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PODepartment")) & "'"
    '                gconnection.getDataSet(strsql, "STORECOD")
    '                If gdataset.Tables("storecod").Rows.Count > 0 Then
    '                    txt_Storecode.Text = Trim(gdataset.Tables("storecod").Rows(0).Item("storecode"))
    '                    txt_StoreDesc.Text = Trim(gdataset.Tables("storecod").Rows(0).Item("storedesc"))
    '                End If
    '                txt_Supplierinvno.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POquotno"))
    '                txt_Suppliercode.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("povendorcode"))

    '                strsql = "SELECT ISNULL(VENDORCODE,0) AS VENDORCODE, ISNULL(VENDORNAME,'') AS VENDORNAME FROM PO_VIEW_VENDORMASTER WHERE VENDORCODE = '" & Trim(txt_Suppliercode.Text) & "' "
    '                gconnection.getDataSet(strsql, "accountssubledgermaster")
    '                txt_Suppliername.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("vendorname"))
    '                Txt_PONo.ReadOnly = True
    '                If gdataset.Tables("PO_HDR").Rows(0).Item("Freeze") = "Y" Then
    '                    Me.lbl_Freeze.Visible = True
    '                    Me.lbl_Freeze.Text = ""
    '                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("PO_HDR").Rows(0).Item("AddDatetime")), "dd-MMM-yyyy")
    '                    Me.Cmd_Freeze.Text = "UnFreeze[F8]"
    '                Else
    '                    Me.lbl_Freeze.Visible = False
    '                    Me.lbl_Freeze.Text = "Record Freezed  On "
    '                    Me.Cmd_Freeze.Text = "Freeze[F8]"
    '                End If
    '                'Me.Cmd_Add.Text = "Update[F7]"

    '                '----------------------ITEMDETAILS RETRIEVE----------------------------
    '                strsql = "SELECT * FROM PO_ITEMDETAILS WHERE pono='" & Trim(Txt_PONo.Text) & "' ORDER BY AUTOID "
    '                gconnection.getDataSet(strsql, "PO_ITEMDETAILS")
    '                If gdataset.Tables("PO_ITEMDETAILS").Rows.Count > 0 Then
    '                    Dim count, temp, tcode As String
    '                    For i = 0 To gdataset.Tables("PO_ITEMDETAILS").Rows.Count - 1
    '                        tcode = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("itemcode")
    '                        'LIN
    '                        strsql = "SELECT itemcode,itemname,STOCKuom FROM PO_VIEW_ITEMMASTER "
    '                        strsql = strsql & "WHERE itemcode='" & Trim(tcode) & "' "
    '                        gconnection.getDataSet(strsql, "inventoryitemmaster")
    '                        count = gdataset.Tables("PO_ITEMDETAILS").Rows.Count
    '                        With ssgrid
    '                            .Row = i + 1
    '                            .Col = 1
    '                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("itemcode")

    '                            .Col = 2
    '                            .Text = gdataset.Tables("inventoryitemmaster").Rows(0).Item("itemname")

    '                            .Col = 3
    '                            .Text = gdataset.Tables("inventoryitemmaster").Rows(0).Item("STOCKUOM")

    '                            .Col = 4
    '                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("quantity")
    '                            itemQty = .Text

    '                            .Col = 5
    '                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("rate")
    '                            .CellType = FPSpreadADO.CellTypeConstants.CellTypeFloat
    '                            itemRate = .Text

    '                            .Col = 6
    '                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("DISCAMT")
    '                            Discnt = Discnt + .Text

    '                            '.Col = 7
    '                            '.Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("vat")
    '                            .Col = 8
    '                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("vat")

    '                            .Col = 10
    '                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("total")
    '                            totAmt = totAmt + gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("AMOUNT")
    '                            .Col = 9
    '                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("VATAMT")
    '                            .Col = 10
    '                            .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("AMOUNT")
    '                        End With
    '                    Next
    '                    txt_Discountamt.Text = Format(Val(Discnt), "0.00") ' + Val(Trim(gdataset.Tables("PO_HDR").Rows(0).Item("pototaldiscount"))), "0.00")
    '                    TXT_OVERALLdiscount.Text = Format(Val(Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POoveralldisc"))), "0.00")
    '                    'txt_Totalamt.Text = Format(Val(totAmt), "0.00")
    '                    Dim OTHER_taxes As Double
    '                    OTHER_taxes = 0
    '                    OTHER_taxes = OTHER_taxes + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POED")) * totAmt / 100
    '                    OTHER_taxes = OTHER_taxes + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POCST")) * totAmt / 100
    '                    OTHER_taxes = OTHER_taxes + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POMODVAT")) * totAmt / 100
    '                    OTHER_taxes = OTHER_taxes + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POPTAX")) * totAmt / 100
    '                    OTHER_taxes = OTHER_taxes + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POOCTRA")) * totAmt / 100
    '                    OTHER_taxes = OTHER_taxes + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POINSURANCE")) * totAmt / 100
    '                    OTHER_taxes = OTHER_taxes + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POLST")) * totAmt / 100

    '                    txt_Surchargeamt.Text = Format(Val(Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"))) + Val(Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"))) + Val(Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"))) + Val(OTHER_taxes), "0.00")
    '                    Discnt = 0 : totAmt = 0
    '                End If
    '            End If
    '            txt_Grnno.Focus()
    '        End If
    '    End Sub
    '    Private Sub Txt_PONo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '        If Asc(e.KeyChar) = 13 Then
    '            If Txt_PONo.Text = "" Then
    '                Call cmd_PONOhelp_Click(Txt_PONo, e)
    '            Else
    '                Call Txt_PONo_Validated(Txt_PONo, e)
    '                Call Calculate()
    '            End If
    '        End If
    '    End Sub
    '    Private Function Grid_lock()
    '        Dim i, j As Integer
    '        For i = 1 To ssgrid.DataRowCnt
    '            ssgrid.Row = i
    '            For j = 1 To ssgrid.MaxCols
    '                ssgrid.Col = j
    '                ssgrid.Lock = True
    '            Next
    '        Next
    '    End Function

    '    Private Sub TXT_OVERALLdiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_OVERALLdiscount.TextChanged
    '        Try
    '            If Val(TXT_OVERALLdiscount.Text) <> 0 Then
    '                txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_OverallDiscount_TextChanged" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub TXT_OVERALLdiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_OVERALLdiscount.KeyPress
    '        Try
    '            Call getNumeric(e)
    '            If Asc(e.KeyChar) = 13 Then
    '                Cmd_Add.Focus()
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_Discountamt_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub

    '    Private Sub TXT_OVERALLdiscount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_OVERALLdiscount.LostFocus
    '        Try
    '            TXT_OVERALLdiscount.Text = Format(Val(TXT_OVERALLdiscount.Text), "0.00")
    '            If Val(TXT_OVERALLdiscount.Text) <> 0 Then
    '                txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
    '            End If
    '        Catch ex As Exception
    '            MessageBox.Show("Plz Check Error : txt_OverallDiscount_lostfocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
    '            Exit Sub
    '        End Try
    '    End Sub
    '    Private Sub calc_billamt()
    '        txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
    '    End Sub
    '    Private Sub Txt_PONo_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Txt_PONo.BackColor = Color.Gold
    '    End Sub

    '    Private Sub Txt_PONo_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Txt_PONo.BackColor = Color.Wheat
    '    End Sub

    '    Private Sub txt_Grnno_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Hono.GotFocus
    '        txt_Grnno.BackColor = Color.Gold
    '        Label14.Visible = True
    '    End Sub

    '    Private Sub txt_Grnno_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Hono.LostFocus
    '        txt_Grnno.BackColor = Color.Wheat
    '        Label14.Visible = False
    '    End Sub

    '    Private Sub txt_Supplierinvno_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Supplierinvno.GotFocus
    '        txt_Supplierinvno.BackColor = Color.Gold
    '    End Sub

    '    Private Sub txt_Suppliername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Suppliername.GotFocus
    '        txt_Suppliername.BackColor = Color.Gold
    '    End Sub

    '    Private Sub txt_Suppliername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Suppliername.LostFocus
    '        txt_Suppliername.BackColor = Color.Wheat
    '    End Sub

    '    Private Sub txt_Storecode_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        txt_Storecode.BackColor = Color.Gold
    '        Label15.Visible = True
    '    End Sub

    '    Private Sub txt_Storecode_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        txt_Storecode.BackColor = Color.Wheat
    '        Label15.Visible = False
    '    End Sub

    '    Private Sub Txt_GLAcIn_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Txt_GLAcIn.BackColor = Color.Gold
    '        Label17.Visible = True
    '    End Sub

    '    Private Sub Txt_GLAcIn_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Txt_GLAcIn.BackColor = Color.Wheat
    '        Label17.Visible = False
    '    End Sub

    '    Private Sub Txt_Slcode_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Txt_Slcode.BackColor = Color.Gold
    '        Label18.Visible = True
    '    End Sub

    '    Private Sub Txt_Slcode_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Txt_Slcode.BackColor = Color.Wheat
    '        Label18.Visible = False
    '    End Sub

    '    Private Sub Txt_CostCenterCode_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Txt_CostCenterCode.BackColor = Color.Gold
    '        Label19.Visible = True
    '    End Sub

    '    Private Sub Txt_CostCenterCode_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Txt_CostCenterCode.BackColor = Color.Wheat
    '        Label19.Visible = False
    '    End Sub

    '    Private Sub cmd_Post_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        Dim STRSQL As String
    '        Call checkValidation() '''--->Check Validation
    '        ' Call billingterms()
    '        If boolchk = False Then Exit Sub
    '        Me.Cursor = Cursors.WaitCursor
    '        STRSQL = "EXEC PJV_POSTING_DIR " & "'" & Trim(txt_Grnno.Text) & "','P'"
    '        VCONN.dataOperation(6, STRSQL, "ACCOUNTPOSTING")
    '        Me.Cursor = Cursors.Default
    '        MsgBox("ACCOUNT POSTING DONE SUCCESSFULLY", MsgBoxStyle.Exclamation, "SUCCESS")
    '        Call Cmd_Clear_Click(sender, e)
    '    End Sub

    '    Private Sub Chk_item_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        If Chk_item.Checked = True Then
    '            grp_footer.Visible = True
    '            Txt_footer.Focus()
    '        Else
    '            grp_footer.Visible = False
    '        End If
    '    End Sub

    '    Private Sub Txt_footer_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_footer.KeyPress
    '        If Asc(e.KeyChar) = 13 Then
    '            If Trim(Txt_footer.Text) <> "" Then
    '                Txt_signature.Focus()
    '            Else
    '                Txt_footer.Focus()
    '            End If
    '        End If
    '    End Sub

    '    Private Sub Txt_signature_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_signature.KeyPress
    '        If Asc(e.KeyChar) = 13 Then
    '            Chk_item.Focus()
    '        End If
    '    End Sub

    '    Private Sub txt_Suppliercode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Suppliercode.GotFocus
    '        txt_Suppliercode.BackColor = Color.Gold
    '        Label16.Visible = True
    '    End Sub

    '    Private Sub txt_Suppliercode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Suppliercode.LostFocus
    '        txt_Suppliercode.BackColor = Color.Wheat
    '        Label16.Visible = False
    '    End Sub

    '    Private Sub ssgrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid.Advance

    '    End Sub

    '    Private Sub Txt_GLAcIn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    End Sub

    '    Private Sub txt_Storecode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    End Sub

    '    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start(AppPath & "\STUDY\HIREORDER.XLS")
    End Sub
End Class
