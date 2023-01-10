Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class PO_WorkOrderIndent
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
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents dtp_Excisepassdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Excisepassno As System.Windows.Forms.Label
    Friend WithEvents lbl_Excisepassdate As System.Windows.Forms.Label
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents lbl_Suppliercode As System.Windows.Forms.Label
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents cmd_Suppliercodehelp As System.Windows.Forms.Button
    Friend WithEvents txt_Excisepassno As System.Windows.Forms.TextBox
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents cbo_Storelocation As System.Windows.Forms.ComboBox
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
    Friend WithEvents txt_Trucknumber As System.Windows.Forms.TextBox
    Friend WithEvents dtp_Stockindate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Trucknumber As System.Windows.Forms.Label
    Friend WithEvents lbl_Stockindate As System.Windows.Forms.Label
    Friend WithEvents ssgrid_billdetails As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Cmd_ToDocno As System.Windows.Forms.Button
    Friend WithEvents Cmd_FromDocno As System.Windows.Forms.Button
    Friend WithEvents txt_ToDocno As System.Windows.Forms.TextBox
    Friend WithEvents txt_FromDocno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ToDocno As System.Windows.Forms.Label
    Friend WithEvents lbl_FromDocno As System.Windows.Forms.Label
    Friend WithEvents cmd_print As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmd_Wonohelp As System.Windows.Forms.Button
    Friend WithEvents lbl_Wodate As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtp_Indentdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Indentno As System.Windows.Forms.Label
    Friend WithEvents txt_Indentno As System.Windows.Forms.TextBox
    Friend WithEvents cmb_reqby As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_approvedby As System.Windows.Forms.ComboBox
    Friend WithEvents txt_wrkdesc As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtp_completiondate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PO_WorkOrderIndent))
        Me.cmd_Wonohelp = New System.Windows.Forms.Button()
        Me.dtp_Excisepassdate = New System.Windows.Forms.DateTimePicker()
        Me.txt_Remarks = New System.Windows.Forms.TextBox()
        Me.lbl_Remarks = New System.Windows.Forms.Label()
        Me.lbl_Suppliercode = New System.Windows.Forms.Label()
        Me.cmd_print = New System.Windows.Forms.Button()
        Me.dtp_Indentdate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Heading = New System.Windows.Forms.Label()
        Me.lbl_Freeze = New System.Windows.Forms.Label()
        Me.lbl_Wodate = New System.Windows.Forms.Label()
        Me.lbl_Indentno = New System.Windows.Forms.Label()
        Me.cmd_Suppliercodehelp = New System.Windows.Forms.Button()
        Me.cbo_Storelocation = New System.Windows.Forms.ComboBox()
        Me.lbl_Excisepassno = New System.Windows.Forms.Label()
        Me.lbl_Excisepassdate = New System.Windows.Forms.Label()
        Me.txt_Excisepassno = New System.Windows.Forms.TextBox()
        Me.lbl_Creditdays = New System.Windows.Forms.Label()
        Me.lbl_Grn = New System.Windows.Forms.Label()
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
        Me.Cmd_Clear = New System.Windows.Forms.Button()
        Me.Cmd_View = New System.Windows.Forms.Button()
        Me.Cmd_Freeze = New System.Windows.Forms.Button()
        Me.Cmd_Add = New System.Windows.Forms.Button()
        Me.Cmd_Exit = New System.Windows.Forms.Button()
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
        Me.grp_Billingdetails = New System.Windows.Forms.GroupBox()
        Me.ssgrid_billdetails = New AxFPSpreadADO.AxfpSpread()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grp_Excisedetails = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Trucknumber = New System.Windows.Forms.TextBox()
        Me.dtp_Stockindate = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Trucknumber = New System.Windows.Forms.Label()
        Me.lbl_Stockindate = New System.Windows.Forms.Label()
        Me.txt_Suppliercode = New System.Windows.Forms.TextBox()
        Me.txt_Suppliername = New System.Windows.Forms.TextBox()
        Me.txt_Indentno = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txt_wrkdesc = New System.Windows.Forms.TextBox()
        Me.dtp_completiondate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_reqby = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_approvedby = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grp_StockGrndetails.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.grp_Billingdetails.SuspendLayout()
        CType(Me.ssgrid_billdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_Excisedetails.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_Wonohelp
        '
        Me.cmd_Wonohelp.Image = CType(resources.GetObject("cmd_Wonohelp.Image"), System.Drawing.Image)
        Me.cmd_Wonohelp.Location = New System.Drawing.Point(293, 20)
        Me.cmd_Wonohelp.Name = "cmd_Wonohelp"
        Me.cmd_Wonohelp.Size = New System.Drawing.Size(26, 33)
        Me.cmd_Wonohelp.TabIndex = 2
        '
        'dtp_Excisepassdate
        '
        Me.dtp_Excisepassdate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Excisepassdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Excisepassdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Excisepassdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Excisepassdate.Location = New System.Drawing.Point(274, 162)
        Me.dtp_Excisepassdate.Name = "dtp_Excisepassdate"
        Me.dtp_Excisepassdate.Size = New System.Drawing.Size(247, 30)
        Me.dtp_Excisepassdate.TabIndex = 2
        '
        'txt_Remarks
        '
        Me.txt_Remarks.BackColor = System.Drawing.Color.White
        Me.txt_Remarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Remarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Remarks.Location = New System.Drawing.Point(101, 30)
        Me.txt_Remarks.MaxLength = 200
        Me.txt_Remarks.Multiline = True
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(612, 41)
        Me.txt_Remarks.TabIndex = 11
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AutoSize = True
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.Location = New System.Drawing.Point(9, 30)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(102, 19)
        Me.lbl_Remarks.TabIndex = 43
        Me.lbl_Remarks.Text = "REMARKS :"
        '
        'lbl_Suppliercode
        '
        Me.lbl_Suppliercode.AutoSize = True
        Me.lbl_Suppliercode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Suppliercode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Suppliercode.Location = New System.Drawing.Point(18, 28)
        Me.lbl_Suppliercode.Name = "lbl_Suppliercode"
        Me.lbl_Suppliercode.Size = New System.Drawing.Size(160, 19)
        Me.lbl_Suppliercode.TabIndex = 28
        Me.lbl_Suppliercode.Text = "SUPPLIER CODE  :"
        Me.lbl_Suppliercode.Visible = False
        '
        'cmd_print
        '
        Me.cmd_print.BackColor = System.Drawing.Color.Transparent
        Me.cmd_print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_print.ForeColor = System.Drawing.Color.Black
        Me.cmd_print.Image = Global.SmartCard.My.Resources.Resources.print
        Me.cmd_print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_print.Location = New System.Drawing.Point(3, 239)
        Me.cmd_print.Name = "cmd_print"
        Me.cmd_print.Size = New System.Drawing.Size(155, 64)
        Me.cmd_print.TabIndex = 15
        Me.cmd_print.Text = "Print [F10]"
        Me.cmd_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_print.UseVisualStyleBackColor = False
        '
        'dtp_Indentdate
        '
        Me.dtp_Indentdate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Indentdate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_Indentdate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_Indentdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Indentdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Indentdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Indentdate.Location = New System.Drawing.Point(487, 22)
        Me.dtp_Indentdate.Name = "dtp_Indentdate"
        Me.dtp_Indentdate.Size = New System.Drawing.Size(137, 30)
        Me.dtp_Indentdate.TabIndex = 3
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(216, 103)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(229, 24)
        Me.lbl_Heading.TabIndex = 21
        Me.lbl_Heading.Text = "WORK ORDER INDENT"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(494, 142)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(228, 32)
        Me.lbl_Freeze.TabIndex = 47
        Me.lbl_Freeze.Text = "Record Void  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'lbl_Wodate
        '
        Me.lbl_Wodate.AutoSize = True
        Me.lbl_Wodate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wodate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Wodate.Location = New System.Drawing.Point(368, 28)
        Me.lbl_Wodate.Name = "lbl_Wodate"
        Me.lbl_Wodate.Size = New System.Drawing.Size(129, 19)
        Me.lbl_Wodate.TabIndex = 25
        Me.lbl_Wodate.Text = "INDENT DATE :"
        '
        'lbl_Indentno
        '
        Me.lbl_Indentno.AutoSize = True
        Me.lbl_Indentno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Indentno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Indentno.Location = New System.Drawing.Point(9, 20)
        Me.lbl_Indentno.Name = "lbl_Indentno"
        Me.lbl_Indentno.Size = New System.Drawing.Size(111, 19)
        Me.lbl_Indentno.TabIndex = 23
        Me.lbl_Indentno.Text = "INDENT NO :"
        '
        'cmd_Suppliercodehelp
        '
        Me.cmd_Suppliercodehelp.Image = CType(resources.GetObject("cmd_Suppliercodehelp.Image"), System.Drawing.Image)
        Me.cmd_Suppliercodehelp.Location = New System.Drawing.Point(293, 22)
        Me.cmd_Suppliercodehelp.Name = "cmd_Suppliercodehelp"
        Me.cmd_Suppliercodehelp.Size = New System.Drawing.Size(26, 32)
        Me.cmd_Suppliercodehelp.TabIndex = 5
        Me.cmd_Suppliercodehelp.Visible = False
        '
        'cbo_Storelocation
        '
        Me.cbo_Storelocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Storelocation.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Storelocation.Location = New System.Drawing.Point(896, 1267)
        Me.cbo_Storelocation.Name = "cbo_Storelocation"
        Me.cbo_Storelocation.Size = New System.Drawing.Size(219, 27)
        Me.cbo_Storelocation.TabIndex = 8
        '
        'lbl_Excisepassno
        '
        Me.lbl_Excisepassno.AutoSize = True
        Me.lbl_Excisepassno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Excisepassno.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Excisepassno.Location = New System.Drawing.Point(73, 111)
        Me.lbl_Excisepassno.Name = "lbl_Excisepassno"
        Me.lbl_Excisepassno.Size = New System.Drawing.Size(206, 22)
        Me.lbl_Excisepassno.TabIndex = 5
        Me.lbl_Excisepassno.Text = "EXCISE PASS NO       :"
        '
        'lbl_Excisepassdate
        '
        Me.lbl_Excisepassdate.AutoSize = True
        Me.lbl_Excisepassdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Excisepassdate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Excisepassdate.Location = New System.Drawing.Point(73, 162)
        Me.lbl_Excisepassdate.Name = "lbl_Excisepassdate"
        Me.lbl_Excisepassdate.Size = New System.Drawing.Size(209, 22)
        Me.lbl_Excisepassdate.TabIndex = 6
        Me.lbl_Excisepassdate.Text = "EXCISE PASS DATE   :"
        '
        'txt_Excisepassno
        '
        Me.txt_Excisepassno.BackColor = System.Drawing.Color.White
        Me.txt_Excisepassno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Excisepassno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Excisepassno.Location = New System.Drawing.Point(274, 111)
        Me.txt_Excisepassno.MaxLength = 15
        Me.txt_Excisepassno.Name = "txt_Excisepassno"
        Me.txt_Excisepassno.Size = New System.Drawing.Size(247, 30)
        Me.txt_Excisepassno.TabIndex = 1
        '
        'lbl_Creditdays
        '
        Me.lbl_Creditdays.AutoSize = True
        Me.lbl_Creditdays.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Creditdays.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Creditdays.Location = New System.Drawing.Point(594, 182)
        Me.lbl_Creditdays.Name = "lbl_Creditdays"
        Me.lbl_Creditdays.Size = New System.Drawing.Size(150, 20)
        Me.lbl_Creditdays.TabIndex = 32
        Me.lbl_Creditdays.Text = "CREDIT DAYS  :"
        Me.lbl_Creditdays.Visible = False
        '
        'lbl_Grn
        '
        Me.lbl_Grn.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Grn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Grn.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Grn.Location = New System.Drawing.Point(9, 780)
        Me.lbl_Grn.Name = "lbl_Grn"
        Me.lbl_Grn.Size = New System.Drawing.Size(183, 31)
        Me.lbl_Grn.TabIndex = 45
        Me.lbl_Grn.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(82, 1267)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(549, 162)
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
        Me.GroupBox2.Location = New System.Drawing.Point(302, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 112)
        Me.GroupBox2.TabIndex = 353
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Rounded Off"
        '
        'cmdRoundoff
        '
        Me.cmdRoundoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRoundoff.ForeColor = System.Drawing.Color.Blue
        Me.cmdRoundoff.Location = New System.Drawing.Point(155, 20)
        Me.cmdRoundoff.Name = "cmdRoundoff"
        Me.cmdRoundoff.Size = New System.Drawing.Size(64, 50)
        Me.cmdRoundoff.TabIndex = 2
        Me.cmdRoundoff.Text = "Round Off"
        '
        'OptNearest
        '
        Me.OptNearest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptNearest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptNearest.Location = New System.Drawing.Point(27, 56)
        Me.OptNearest.Name = "OptNearest"
        Me.OptNearest.Size = New System.Drawing.Size(98, 20)
        Me.OptNearest.TabIndex = 2
        Me.OptNearest.Text = "Nearest Rs"
        '
        'OptNone
        '
        Me.OptNone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptNone.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptNone.Location = New System.Drawing.Point(27, 23)
        Me.OptNone.Name = "OptNone"
        Me.OptNone.Size = New System.Drawing.Size(101, 20)
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
        Me.GroupBox3.Location = New System.Drawing.Point(9, 25)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(284, 112)
        Me.GroupBox3.TabIndex = 352
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Discount Amount"
        '
        'cmdValueby
        '
        Me.cmdValueby.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdValueby.ForeColor = System.Drawing.Color.Blue
        Me.cmdValueby.Location = New System.Drawing.Point(218, 20)
        Me.cmdValueby.Name = "cmdValueby"
        Me.cmdValueby.Size = New System.Drawing.Size(55, 51)
        Me.cmdValueby.TabIndex = 3
        Me.cmdValueby.Text = "Value Chg"
        '
        'OptPercentage
        '
        Me.OptPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptPercentage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptPercentage.Location = New System.Drawing.Point(11, 71)
        Me.OptPercentage.Name = "OptPercentage"
        Me.OptPercentage.Size = New System.Drawing.Size(100, 20)
        Me.OptPercentage.TabIndex = 2
        Me.OptPercentage.Text = "Percentage"
        '
        'OptValue
        '
        Me.OptValue.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OptValue.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptValue.Location = New System.Drawing.Point(11, 30)
        Me.OptValue.Name = "OptValue"
        Me.OptValue.Size = New System.Drawing.Size(92, 21)
        Me.OptValue.TabIndex = 1
        Me.OptValue.Text = "Value"
        '
        'txtChangeValue
        '
        Me.txtChangeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtChangeValue.Location = New System.Drawing.Point(114, 71)
        Me.txtChangeValue.MaxLength = 10
        Me.txtChangeValue.Name = "txtChangeValue"
        Me.txtChangeValue.Size = New System.Drawing.Size(105, 26)
        Me.txtChangeValue.TabIndex = 3
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Clear.Image = Global.SmartCard.My.Resources.Resources.Clear
        Me.Cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Clear.Location = New System.Drawing.Point(2, 27)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(155, 63)
        Me.Cmd_Clear.TabIndex = 12
        Me.Cmd_Clear.Text = "Clear[F6]"
        Me.Cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Clear.UseVisualStyleBackColor = False
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.Black
        Me.Cmd_View.Image = Global.SmartCard.My.Resources.Resources.view
        Me.Cmd_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_View.Location = New System.Drawing.Point(2, 314)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(155, 63)
        Me.Cmd_View.TabIndex = 16
        Me.Cmd_View.Text = " View[F9]"
        Me.Cmd_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_View.UseVisualStyleBackColor = False
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Freeze.Image = Global.SmartCard.My.Resources.Resources.Delete
        Me.Cmd_Freeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Freeze.Location = New System.Drawing.Point(3, 168)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(155, 64)
        Me.Cmd_Freeze.TabIndex = 14
        Me.Cmd_Freeze.Text = "Void[F8]"
        Me.Cmd_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Freeze.UseVisualStyleBackColor = False
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Add.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Add.Image = Global.SmartCard.My.Resources.Resources.save
        Me.Cmd_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Add.Location = New System.Drawing.Point(0, 98)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(154, 63)
        Me.Cmd_Add.TabIndex = 13
        Me.Cmd_Add.Text = "Add [F7]"
        Me.Cmd_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Add.UseVisualStyleBackColor = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Exit.Image = Global.SmartCard.My.Resources.Resources._Exit
        Me.Cmd_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Exit.Location = New System.Drawing.Point(1, 385)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(154, 63)
        Me.Cmd_Exit.TabIndex = 17
        Me.Cmd_Exit.Text = "Exit[F11]"
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Exit.UseVisualStyleBackColor = False
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
        Me.grp_StockGrndetails.Location = New System.Drawing.Point(254, 1267)
        Me.grp_StockGrndetails.Name = "grp_StockGrndetails"
        Me.grp_StockGrndetails.Size = New System.Drawing.Size(587, 301)
        Me.grp_StockGrndetails.TabIndex = 361
        Me.grp_StockGrndetails.TabStop = False
        '
        'lbl_StockGrndetails
        '
        Me.lbl_StockGrndetails.BackColor = System.Drawing.Color.Maroon
        Me.lbl_StockGrndetails.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StockGrndetails.ForeColor = System.Drawing.Color.White
        Me.lbl_StockGrndetails.Location = New System.Drawing.Point(0, 9)
        Me.lbl_StockGrndetails.Name = "lbl_StockGrndetails"
        Me.lbl_StockGrndetails.Size = New System.Drawing.Size(594, 32)
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
        Me.GroupBox5.Location = New System.Drawing.Point(9, 213)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(567, 71)
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
        Me.Cmd_StockGrnprint.Location = New System.Drawing.Point(293, 20)
        Me.Cmd_StockGrnprint.Name = "Cmd_StockGrnprint"
        Me.Cmd_StockGrnprint.Size = New System.Drawing.Size(118, 41)
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
        Me.Cmd_StockGrnView.Image = CType(resources.GetObject("Cmd_StockGrnView.Image"), System.Drawing.Image)
        Me.Cmd_StockGrnView.Location = New System.Drawing.Point(146, 20)
        Me.Cmd_StockGrnView.Name = "Cmd_StockGrnView"
        Me.Cmd_StockGrnView.Size = New System.Drawing.Size(119, 41)
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
        Me.Cmd_StockGrnexit.Image = CType(resources.GetObject("Cmd_StockGrnexit.Image"), System.Drawing.Image)
        Me.Cmd_StockGrnexit.Location = New System.Drawing.Point(430, 20)
        Me.Cmd_StockGrnexit.Name = "Cmd_StockGrnexit"
        Me.Cmd_StockGrnexit.Size = New System.Drawing.Size(119, 41)
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
        Me.Cmd_StockGrnClear.Image = CType(resources.GetObject("Cmd_StockGrnClear.Image"), System.Drawing.Image)
        Me.Cmd_StockGrnClear.Location = New System.Drawing.Point(9, 20)
        Me.Cmd_StockGrnClear.Name = "Cmd_StockGrnClear"
        Me.Cmd_StockGrnClear.Size = New System.Drawing.Size(119, 41)
        Me.Cmd_StockGrnClear.TabIndex = 24
        Me.Cmd_StockGrnClear.Text = "Clear[F6]"
        Me.Cmd_StockGrnClear.UseVisualStyleBackColor = False
        '
        'lbl_FromDocno
        '
        Me.lbl_FromDocno.AutoSize = True
        Me.lbl_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_FromDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FromDocno.Location = New System.Drawing.Point(43, 85)
        Me.lbl_FromDocno.Name = "lbl_FromDocno"
        Me.lbl_FromDocno.Size = New System.Drawing.Size(165, 23)
        Me.lbl_FromDocno.TabIndex = 2
        Me.lbl_FromDocno.Text = "FROM GRN NO :"
        '
        'txt_FromDocno
        '
        Me.txt_FromDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_FromDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FromDocno.Location = New System.Drawing.Point(210, 81)
        Me.txt_FromDocno.Name = "txt_FromDocno"
        Me.txt_FromDocno.Size = New System.Drawing.Size(238, 35)
        Me.txt_FromDocno.TabIndex = 4
        '
        'Cmd_FromDocno
        '
        Me.Cmd_FromDocno.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_FromDocno.Image = CType(resources.GetObject("Cmd_FromDocno.Image"), System.Drawing.Image)
        Me.Cmd_FromDocno.Location = New System.Drawing.Point(448, 81)
        Me.Cmd_FromDocno.Name = "Cmd_FromDocno"
        Me.Cmd_FromDocno.Size = New System.Drawing.Size(26, 37)
        Me.Cmd_FromDocno.TabIndex = 38
        Me.Cmd_FromDocno.UseVisualStyleBackColor = False
        '
        'txt_ToDocno
        '
        Me.txt_ToDocno.BackColor = System.Drawing.Color.Wheat
        Me.txt_ToDocno.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ToDocno.Location = New System.Drawing.Point(210, 142)
        Me.txt_ToDocno.Name = "txt_ToDocno"
        Me.txt_ToDocno.Size = New System.Drawing.Size(238, 35)
        Me.txt_ToDocno.TabIndex = 5
        '
        'Cmd_ToDocno
        '
        Me.Cmd_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_ToDocno.Image = CType(resources.GetObject("Cmd_ToDocno.Image"), System.Drawing.Image)
        Me.Cmd_ToDocno.Location = New System.Drawing.Point(448, 142)
        Me.Cmd_ToDocno.Name = "Cmd_ToDocno"
        Me.Cmd_ToDocno.Size = New System.Drawing.Size(26, 37)
        Me.Cmd_ToDocno.TabIndex = 39
        Me.Cmd_ToDocno.UseVisualStyleBackColor = False
        '
        'lbl_ToDocno
        '
        Me.lbl_ToDocno.AutoSize = True
        Me.lbl_ToDocno.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ToDocno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ToDocno.Location = New System.Drawing.Point(73, 144)
        Me.lbl_ToDocno.Name = "lbl_ToDocno"
        Me.lbl_ToDocno.Size = New System.Drawing.Size(135, 23)
        Me.lbl_ToDocno.TabIndex = 3
        Me.lbl_ToDocno.Text = "TO GRN NO :"
        '
        'grp_Billingdetails
        '
        Me.grp_Billingdetails.BackColor = System.Drawing.SystemColors.Control
        Me.grp_Billingdetails.BackgroundImage = CType(resources.GetObject("grp_Billingdetails.BackgroundImage"), System.Drawing.Image)
        Me.grp_Billingdetails.Controls.Add(Me.ssgrid_billdetails)
        Me.grp_Billingdetails.Controls.Add(Me.Label2)
        Me.grp_Billingdetails.Location = New System.Drawing.Point(18, 1267)
        Me.grp_Billingdetails.Name = "grp_Billingdetails"
        Me.grp_Billingdetails.Size = New System.Drawing.Size(759, 392)
        Me.grp_Billingdetails.TabIndex = 364
        Me.grp_Billingdetails.TabStop = False
        '
        'ssgrid_billdetails
        '
        Me.ssgrid_billdetails.DataSource = Nothing
        Me.ssgrid_billdetails.Location = New System.Drawing.Point(29, 63)
        Me.ssgrid_billdetails.Name = "ssgrid_billdetails"
        Me.ssgrid_billdetails.OcxState = CType(resources.GetObject("ssgrid_billdetails.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid_billdetails.Size = New System.Drawing.Size(868, 393)
        Me.ssgrid_billdetails.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(756, 31)
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
        Me.grp_Excisedetails.Location = New System.Drawing.Point(247, 1267)
        Me.grp_Excisedetails.Name = "grp_Excisedetails"
        Me.grp_Excisedetails.Size = New System.Drawing.Size(585, 261)
        Me.grp_Excisedetails.TabIndex = 366
        Me.grp_Excisedetails.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Maroon
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(579, 31)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "EXCISE DETAILS"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Trucknumber
        '
        Me.txt_Trucknumber.BackColor = System.Drawing.Color.White
        Me.txt_Trucknumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Trucknumber.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Trucknumber.Location = New System.Drawing.Point(274, 213)
        Me.txt_Trucknumber.MaxLength = 15
        Me.txt_Trucknumber.Name = "txt_Trucknumber"
        Me.txt_Trucknumber.Size = New System.Drawing.Size(247, 30)
        Me.txt_Trucknumber.TabIndex = 3
        '
        'dtp_Stockindate
        '
        Me.dtp_Stockindate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Stockindate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_Stockindate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Stockindate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Stockindate.Location = New System.Drawing.Point(274, 61)
        Me.dtp_Stockindate.Name = "dtp_Stockindate"
        Me.dtp_Stockindate.Size = New System.Drawing.Size(247, 30)
        Me.dtp_Stockindate.TabIndex = 0
        '
        'lbl_Trucknumber
        '
        Me.lbl_Trucknumber.AutoSize = True
        Me.lbl_Trucknumber.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Trucknumber.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Trucknumber.Location = New System.Drawing.Point(73, 213)
        Me.lbl_Trucknumber.Name = "lbl_Trucknumber"
        Me.lbl_Trucknumber.Size = New System.Drawing.Size(203, 22)
        Me.lbl_Trucknumber.TabIndex = 7
        Me.lbl_Trucknumber.Text = "TRUCK NUMBER      :"
        '
        'lbl_Stockindate
        '
        Me.lbl_Stockindate.AutoSize = True
        Me.lbl_Stockindate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Stockindate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Stockindate.Location = New System.Drawing.Point(73, 61)
        Me.lbl_Stockindate.Name = "lbl_Stockindate"
        Me.lbl_Stockindate.Size = New System.Drawing.Size(205, 22)
        Me.lbl_Stockindate.TabIndex = 4
        Me.lbl_Stockindate.Text = "STOCK IN DATE        :"
        '
        'txt_Suppliercode
        '
        Me.txt_Suppliercode.BackColor = System.Drawing.Color.Wheat
        Me.txt_Suppliercode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Suppliercode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Suppliercode.Location = New System.Drawing.Point(174, 24)
        Me.txt_Suppliercode.MaxLength = 50
        Me.txt_Suppliercode.Name = "txt_Suppliercode"
        Me.txt_Suppliercode.Size = New System.Drawing.Size(119, 26)
        Me.txt_Suppliercode.TabIndex = 4
        Me.txt_Suppliercode.Visible = False
        '
        'txt_Suppliername
        '
        Me.txt_Suppliername.BackColor = System.Drawing.Color.Wheat
        Me.txt_Suppliername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Suppliername.Enabled = False
        Me.txt_Suppliername.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Suppliername.Location = New System.Drawing.Point(173, 65)
        Me.txt_Suppliername.MaxLength = 50
        Me.txt_Suppliername.Name = "txt_Suppliername"
        Me.txt_Suppliername.Size = New System.Drawing.Size(292, 26)
        Me.txt_Suppliername.TabIndex = 7
        Me.txt_Suppliername.Visible = False
        '
        'txt_Indentno
        '
        Me.txt_Indentno.BackColor = System.Drawing.Color.Wheat
        Me.txt_Indentno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Indentno.Location = New System.Drawing.Point(110, 20)
        Me.txt_Indentno.MaxLength = 50
        Me.txt_Indentno.Name = "txt_Indentno"
        Me.txt_Indentno.Size = New System.Drawing.Size(183, 26)
        Me.txt_Indentno.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.lbl_Indentno)
        Me.GroupBox4.Controls.Add(Me.txt_Indentno)
        Me.GroupBox4.Controls.Add(Me.cmd_Wonohelp)
        Me.GroupBox4.Controls.Add(Me.dtp_Indentdate)
        Me.GroupBox4.Controls.Add(Me.lbl_Wodate)
        Me.GroupBox4.Location = New System.Drawing.Point(223, 177)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(737, 71)
        Me.GroupBox4.TabIndex = 465
        Me.GroupBox4.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.txt_wrkdesc)
        Me.GroupBox6.Controls.Add(Me.dtp_completiondate)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.txt_Suppliercode)
        Me.GroupBox6.Controls.Add(Me.lbl_Suppliercode)
        Me.GroupBox6.Controls.Add(Me.cmd_Suppliercodehelp)
        Me.GroupBox6.Controls.Add(Me.txt_Suppliername)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.cmb_reqby)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.cmb_approvedby)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Location = New System.Drawing.Point(223, 267)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(737, 302)
        Me.GroupBox6.TabIndex = 466
        Me.GroupBox6.TabStop = False
        '
        'txt_wrkdesc
        '
        Me.txt_wrkdesc.BackColor = System.Drawing.Color.White
        Me.txt_wrkdesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_wrkdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_wrkdesc.Location = New System.Drawing.Point(174, 174)
        Me.txt_wrkdesc.MaxLength = 200
        Me.txt_wrkdesc.Multiline = True
        Me.txt_wrkdesc.Name = "txt_wrkdesc"
        Me.txt_wrkdesc.Size = New System.Drawing.Size(455, 111)
        Me.txt_wrkdesc.TabIndex = 10
        '
        'dtp_completiondate
        '
        Me.dtp_completiondate.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_completiondate.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_completiondate.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.dtp_completiondate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_completiondate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_completiondate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_completiondate.Location = New System.Drawing.Point(569, 24)
        Me.dtp_completiondate.Name = "dtp_completiondate"
        Me.dtp_completiondate.Size = New System.Drawing.Size(137, 26)
        Me.dtp_completiondate.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(405, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 19)
        Me.Label1.TabIndex = 476
        Me.Label1.Text = "COMPLETION DATE :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(21, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 19)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "SUPPLIER NAME :"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(51, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 19)
        Me.Label12.TabIndex = 432
        Me.Label12.Text = "WORK DESC :"
        '
        'cmb_reqby
        '
        Me.cmb_reqby.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_reqby.Items.AddRange(New Object() {"PRESIDENT", "HON. SECRETARY", "HON. TREASURER", "CAPTAIN", "CEO", "CLUB HOUSE", "COURSE", "DRIVING RANGE", "ENTERTAINMEMT", "TOURNAMENT", "BAR/CATERING"})
        Me.cmb_reqby.Location = New System.Drawing.Point(177, 120)
        Me.cmb_reqby.Name = "cmb_reqby"
        Me.cmb_reqby.Size = New System.Drawing.Size(165, 27)
        Me.cmb_reqby.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(421, 125)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(139, 19)
        Me.Label15.TabIndex = 478
        Me.Label15.Text = "APPROVED BY :"
        '
        'cmb_approvedby
        '
        Me.cmb_approvedby.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_approvedby.Items.AddRange(New Object() {"PRESIDENT", "HON. SECRETARY", "HON. TREASURER", "CAPTAIN", "CEO", "CLUB HOUSE", "COURSE", "DRIVING RANGE", "ENTERTAINMEMT", "TOURNAMENT", "BAR/CATERING"})
        Me.cmb_approvedby.Location = New System.Drawing.Point(549, 122)
        Me.cmb_approvedby.Name = "cmb_approvedby"
        Me.cmb_approvedby.Size = New System.Drawing.Size(164, 27)
        Me.cmb_approvedby.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 19)
        Me.Label4.TabIndex = 476
        Me.Label4.Text = "REQUESTED BY :"
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.Label20)
        Me.GroupBox9.Controls.Add(Me.txt_Remarks)
        Me.GroupBox9.Controls.Add(Me.lbl_Remarks)
        Me.GroupBox9.Location = New System.Drawing.Point(223, 603)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(737, 101)
        Me.GroupBox9.TabIndex = 469
        Me.GroupBox9.TabStop = False
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(9, 51)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 30)
        Me.Label20.TabIndex = 476
        Me.Label20.Text = "ALT+ R"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.Button1)
        Me.GroupBox7.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox7.Controls.Add(Me.Cmd_Add)
        Me.GroupBox7.Controls.Add(Me.cmd_print)
        Me.GroupBox7.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox7.Controls.Add(Me.Cmd_View)
        Me.GroupBox7.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox7.Location = New System.Drawing.Point(986, 119)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(157, 565)
        Me.GroupBox7.TabIndex = 470
        Me.GroupBox7.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(5, 437)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 63)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Browse"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'PO_WorkOrderIndent
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.BackgroundImage = Global.SmartCard.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1344, 717)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grp_Billingdetails)
        Me.Controls.Add(Me.lbl_Creditdays)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.grp_StockGrndetails)
        Me.Controls.Add(Me.grp_Excisedetails)
        Me.Controls.Add(Me.cbo_Storelocation)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Grn)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "PO_WorkOrderIndent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WORK ORDER INDENT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grp_StockGrndetails.ResumeLayout(False)
        Me.grp_StockGrndetails.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.grp_Billingdetails.ResumeLayout(False)
        CType(Me.ssgrid_billdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_Excisedetails.ResumeLayout(False)
        Me.grp_Excisedetails.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Dim ssgrid, txt_Grnno As String
    Private Sub PO_WorkOrderIndent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.DoubleBuffered = True
            Resize_Form()
            GRNCumPurchaseBillTransbool = True
            Call FillGRNTYPE()
            Call categoryfill()
            Call FillStore()
            Call CreateListBox()
            Call FillBillterms()
            Call Fillbilldetails()
            Call FOOTER()
            Call GridLock()
            'CMB_CATEGORY.SelectedIndex = 0
            grp_StockGrndetails.Top = 1000
            grp_Excisedetails.Top = 1000
            'grp_footer.Visible = False

            'DISABLE GLACCOUNT
            'ssgrid.Top = 272
            'ssgrid.Top = 192
            'ssgrid.Left = 10
            'ssgrid.Height = 255
            'ssgrid.Height = 312

            'ssgrid.Focus()
            'ssgrid.SetActiveCell(1, 1)
            Call autogenerate1()
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            If Not String.IsNullOrEmpty(gAuditFlg) Then
                If gAuditFlg.ToUpper = "Y" Then
                    Me.Cmd_Add.Enabled = False
                    Me.Cmd_Freeze.Enabled = False
                End If
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
        '    CMB_CATEGORY.Items.Clear()
        '    sstr = "SELECT DISTINCT CATEGORY FROM INVENTORYITEMMASTER"
        '    gconnection.getDataSet(sstr, "INVENTORYITEMMASTER")
        '    If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count > 0 Then
        '        For I = 0 To gdataset.Tables("INVENTORYITEMMASTER").Rows.Count - 1
        '            CMB_CATEGORY.Items.Add(gdataset.Tables("INVENTORYITEMMASTER").Rows(I).Item("CATEGORY"))
        '        Next
        '        INDEX = CMB_CATEGORY.FindString(DefaultGRN)
        '        CMB_CATEGORY.SelectedIndex = INDEX
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
            Me.txt_Indentno.Text = ""
            Me.txt_wrkdesc.Text = ""
            Call FOOTER()
            Call autogenerate()
            Call FillStore()
            Call FillBillterms()
            Call Fillbilldetails()
            'grp_footer.Visible = False
            Me.lbl_Freeze.Visible = False
            Me.lbl_Freeze.Text = "Record Void  On "
            'ssgrid.ClearRange(1, 1, -1, -1, True)
            ssgrid_billdetails.ClearRange(1, 1, -1, -1, True)
            'CMB_CATEGORY.Enabled = True
            Me.Cmd_Freeze.Text = "Void[F8]"
            Cmd_Add.Text = "Add [F7]"
            'txt_StoreDesc.Text = ""
            'txt_Grnno.Enabled = True
            'txt_Grnno.ReadOnly = False
            txt_Remarks.Text = ""
            'txt_Totalamt.Text = ""
            'txt_Discountamt.Text = ""
            txt_Excisepassno.Text = ""
            txt_Trucknumber.Text = ""
            'txt_Supplierinvno.Text = ""
            txt_Suppliercode.Text = ""
            txt_Suppliername.Text = ""
            txt_Suppliercode.ReadOnly = False
            grp_StockGrndetails.Top = 1000

            Cmd_Add.Enabled = True
            Cmd_Freeze.Enabled = True
            grp_StockGrndetails.Top = 1000
            grp_Excisedetails.Top = 1000
            'ssgrid.Top = 272
            'ssgrid.Left = 10
            'ssgrid.Height = 255
            'dtp_Grndate.Value = DateValue(Now)
            'dtp_Supplierinvdate.Value = DateValue(Now)
            dtp_Excisepassdate.Value = DateValue(Now)
            'ssgrid.Focus()
            'ssgrid.SetActiveCell(1, 1)
            Call autogenerate1()
            cmb_reqby.SelectedIndex = 0
            cmb_approvedby.SelectedIndex = 0
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            If Not String.IsNullOrEmpty(gAuditFlg) Then
                If gAuditFlg.ToUpper = "Y" Then
                    Me.Cmd_Add.Enabled = False
                    Me.Cmd_Freeze.Enabled = False
                End If
            End If
            Call FillGRNTYPE()

            'TXT_OVERALLdiscount.Text = ""
            'txt_Billamount.Text = ""
            'txt_Surchargeamt.Text = ""
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : CMD CLEAR" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='PURCHASE ORDER' AND MODULENAME LIKE 'Work Order Indent%' ORDER BY RIGHTS"
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
        'Me.cmd_export.Enabled = False
        '.cmd_auth.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
                    'Me.cmd_auth.Enabled = True
                    'Me.cmd_export.Enabled = True
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
                    ' Me.cmd_export.Enabled = True
                End If
                If Right(x) = "U" Then
                    ' Me.cmd_auth.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.cmd_Print.Enabled = True
                End If
            Next
        End If


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
        Try
            Dim Totalamount, Taxamount, Calamount, Caltax, CalBilamount, BillAmount, Batchno, Avgrate, Avgquantity As Double
            Dim dblBasic, dblDiscount, dblExcise, dblVAT, dblSurchase, dblTranportation, dblOthpostcharge, dblOthNegcharge As Double
            Dim Qty, Amount, totQty, discount As Double
            Dim sqlstring, varchk, Typecode() As String
            Dim Insert(0) As String
            Dim i As Integer
            'scode = Trim(CStr(txt_Storecode.Text))
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            'Me.txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
            grp_Billingdetails.Top = 1000

            '''**************************************** $ COMPLETE CALCUTATION FOR BASIC AMOUNT  $ **************************************
            '''*********************************************************** Case-1 : Add [F7] ***************************************************'''
            If Mid(CStr(Cmd_Add.Text), 1, 1) = "A" Then
                'GRNno = Split(Trim(txt_Grnno.Text), "/")
                'Typecode = Split(Trim(cbo_Billingterms.Text), " ")
                '''*********************************************************** INSERT INTO PO_WORKINDENT *******************************************'''
                sqlstring = "INSERT INTO PO_WORKINDENT(INDENT_NO,INDENTDATE,WORKDESC,REQUESTEDBY,APPROVEDBY,SUPPLIERCODE,SUPPLIERNAME,COMPLETIONDATE,REMARKS,VOID,ADDUSER,ADDDATE,UPDATEUSER,UPDATEDATE)"
                sqlstring = sqlstring & " VALUES ('" & Trim(CStr(txt_Indentno.Text)) & "',"
                sqlstring = sqlstring & " '" & Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy") & "',"
                sqlstring = sqlstring & " '" & Trim(txt_wrkdesc.Text) & "','" & Trim(CStr(cmb_reqby.Text)) & "','" & Trim(CStr(cmb_approvedby.Text)) & "',"
                sqlstring = sqlstring & " '" & Trim(CStr(txt_Suppliercode.Text)) & "','" & Trim(CStr(txt_Suppliername.Text)) & "',"
                sqlstring = sqlstring & " '" & Format(CDate(dtp_completiondate.Value), "dd-MMM-yyyy ") & "',"
                sqlstring = sqlstring & " '" & Trim(CStr(txt_Remarks.Text)) & "','N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "','','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                Insert(0) = sqlstring
                '    '''****************************************** UPDATE COMPLETE *********************************************

                gconnection.MoreTrans(Insert)

                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Call Cmd_View_Click(Cmd_View, e)
                    Call Cmd_Clear_Click(sender, e)
                    
                Else
                    
                    Call Cmd_Clear_Click(sender, e)

                End If




                '    If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                '        If Trim(txt_Grnno.Text) <> "" Then
                '            txt_FromDocno.Text = Trim(txt_Grnno.Text)
                '            txt_ToDocno.Text = Trim(txt_Grnno.Text)
                '        End If
                '        'Call cmd_print_Click(Cmd_View, e)
                '        Call Cmd_View_Click(Cmd_View, e)
                '        ''If MessageBox.Show(" Need TO Post To Accounts ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                '        ''    Call cmd_Post_Click(sender, e)
                '        ''Else
                '        Call Cmd_Clear_Click(sender, e)
                '        ''End If

                '    Else
                '        ''If MessageBox.Show(" Need TO Post To Accounts ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                '        ''    Call cmd_Post_Click(sender, e)
                '        ''Else
                '        Call Cmd_Clear_Click(sender, e)
                '        ''End If
                '    End If
                '    '''*********************************************************** Case-2 : Update [F7] *******************************************'''
            ElseIf Mid(CStr(Cmd_Add.Text), 1, 1) = "U" Then

                '    '''********************************************************** UPDATE PO_WORKINDENT *********************************************************'''
                sqlstring = "UPDATE PO_WORKINDENT SET INDENTDATE='" & Format(CDate(dtp_Indentdate.Value), "dd-MMM-yyyy") & "',COMPLETIONDATE='" & Format(CDate(dtp_completiondate.Value), "dd-MMM-yyyy") & "',"
                sqlstring = sqlstring & " WORKDESC='" & Trim(CStr(txt_wrkdesc.Text)) & "',"
                sqlstring = sqlstring & " Suppliercode='" & Trim(CStr(txt_Suppliercode.Text)) & "',Suppliername='" & Trim(CStr(txt_Suppliername.Text)) & "',"
                sqlstring = sqlstring & " REQUESTEDBY='" & Trim(CStr(cmb_reqby.Text)) & "',APPROVEDBY ='" & Trim(CStr(cmb_approvedby.Text)) & "',"
                sqlstring = sqlstring & " Remarks = '" & Replace(Trim(CStr(txt_Remarks.Text)), "'", "") & "',Updateuser='" & Trim(gUsername) & "'"
                sqlstring = sqlstring & " WHERE INDENT_NO='" & Trim(txt_Indentno.Text) & "' "
                Insert(0) = sqlstring

                '    '''****************************************** UPDATE Complete *********************************************
                gconnection.MoreTrans(Insert)
                If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                    Call Cmd_View_Click(Cmd_View, e)
                    Call Cmd_Clear_Click(sender, e)
                Else
                    Call Cmd_Clear_Click(sender, e)
                End If


                'Call Cmd_Clear_Click(sender, e)
                '    If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                '        If Trim(txt_Grnno.Text) <> "" Then
                '            txt_FromDocno.Text = Trim(txt_Grnno.Text)
                '            txt_ToDocno.Text = Trim(txt_Grnno.Text)
                '        End If
                '        Call Cmd_View_Click(Cmd_View, e)
                '        Call Cmd_Clear_Click(sender, e)
                '    Else
                '        Call Cmd_Clear_Click(sender, e)
                '    End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : CMD_ADD_CLEAR" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Try
            Call checkValidation() ''-->Check Validation
            Dim insert(0) As String
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_Freeze.Text, 1, 1) = "V" Then

                If MsgBox("Are you Sure to Freeze the Record..", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                    Exit Sub
                End If

                '''*****************************************Checking if this indent is already Issued or Not **************************'''
                Dim Sqlstring = "Select * from PO_WORKORDER  where IndentNo='" & Trim(txt_Indentno.Text) & "'"
                gconnection.getDataSet(Sqlstring, "INDENTISSUE")
                If gdataset.Tables("INDENTISSUE").Rows.Count > 0 Then
                    MsgBox("Sorry ! This Indent Stock  is Already Issued............")
                    Exit Sub
                End If

                Sqlstring = "Select * from PO_HIREORDER_DET  where IndentNo='" & Trim(txt_Indentno.Text) & "'"
                gconnection.getDataSet(Sqlstring, "INDENTISSUE")
                If gdataset.Tables("INDENTISSUE").Rows.Count > 0 Then
                    MsgBox("Sorry ! This Indent Stock  is Already Issued............")
                    Exit Sub
                End If

                '''***************************************** Checking if this indent is already Issued or Not  **************************'''
                '''***************************************** Void the INDENT in PO_WORKINDENT **************************'''
                Sqlstring = "UPDATE  PO_WORKINDENT "
                Sqlstring = Sqlstring & " SET Void= 'Y',"
                Sqlstring = Sqlstring & " UPDATEuser='" & Trim(gUsername) & " ',"
                Sqlstring = Sqlstring & " UPdatetime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                Sqlstring = Sqlstring & " WHERE INDENT_NO = '" & Trim(txt_Indentno.Text) & "'"
                insert(0) = Sqlstring
                '''***************************************** Void the INDENT in Complete **********************************'''
                '''***************************************** Void the INDENT in INDENT_header **************************'''

                gconnection.MoreTrans(insert)
                Me.Cmd_Clear_Click(sender, e)
                Cmd_Add.Text = "Add [F7]"

            ElseIf Mid(Me.Cmd_Freeze.Text, 1, 1) = "U" Then

                If MsgBox("Are you Sure to UnFreeze the Record..", MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then
                    Exit Sub
                End If

                '''***************************************** UnVoid the INDENT in IND_header **************************'''
                Sqlstring = "UPDATE  PO_WORKINDENT "
                Sqlstring = Sqlstring & " SET Void= 'N',"
                Sqlstring = Sqlstring & " UPDATEuser='" & Trim(gUsername) & " ',"
                Sqlstring = Sqlstring & " UPdatetime ='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                Sqlstring = Sqlstring & " WHERE INDENT_NO = '" & Trim(txt_Indentno.Text) & "'"
                insert(0) = Sqlstring
                '''***************************************** UnVoid the INDENT in Complete **********************************'''
                '''***************************************** UnVoid the INDENT in INDENT_header **************************'''
                gconnection.MoreTrans(insert)
                Me.Cmd_Clear_Click(sender, e)
                Cmd_Add.Text = "Add [F7]"
                '''****************************************** UPDATE Complete *********************************************

            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : CMD_FREEZE" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
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
        Try
            ' If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
            Dim rViewer As New Viewer
            Dim sqlstring, SSQL As String
            Dim r As New Crys_wo_indent
            'sqlstring = "SELECT ISNULL(PONO,'') AS PONO, ISNULL(GRNDETAILS,'') AS GRNDETAILS,GRNDATE, ISNULL(SUPPLIERCODE,'') AS SUPPLIERCODE, ISNULL(SUPPLIERNAME,'') AS SUPPLIERNAME,"
            'sqlstring = sqlstring & " ISNULL(SUPPLIERINVNO,'') AS SUPPLIERINVNO,  ISNULL(EXCISEPASSNO,'') AS EXCISEPASSNO,ISNULL(GLACCOUNTCODE,'') AS GLACCOUNTCODE,ISNULL(GLACCOUNTNAME,'') AS GLACCOUNTNAME,"
            'sqlstring = sqlstring & " ISNULL(TOTALAMOUNT,0) AS TOTALAMOUNT,ISNULL(VATAMOUNT,0) AS VATAMOUNT,ISNULL(SURCHARGEAMT,0) AS SURCHARGEAMT,ISNULL(DISCOUNT,0) AS DISCOUNT,ISNULL(BILLAMOUNT,0) AS BILLAMOUNT,"
            'sqlstring = sqlstring & " ISNULL(ITEMCODE,'') AS ITEMCODE, ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM, ISNULL(QTY,0) AS QTY, ISNULL(RATE,0) AS RATE,ISNULL(REMARKS,'') AS REMARKS, "
            'sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT,isnull(discount,0) as ddiscount,isnull(taxper,0) as taxper,isnull(taxamount,0) as taxamount, isnull(OverallDiscount,0) OverallDiscount,ISNULL(UPDFOOTER,'') AS UPDFOOTER,ISNULL(UPDNAME,'') AS UPDNAME "
            'sqlstring = sqlstring & " FROM VW_INV_GRNBILL "
            'sqlstring = sqlstring & " WHERE GRNDETAILS BETWEEN '" & Trim(txt_Indentno.Text) & "' AND '" & Trim(txt_Grnno.Text) & "'"
            'sqlstring = sqlstring & " ORDER BY AUTOID ,GRNDETAILS,GRNDATE"
            sqlstring = "select * from PO_WORKINDENT where INDENT_NO = '" & txt_Indentno.Text & "'"
            gconnection.getDataSet(sqlstring, "VW_INV_GRNBILL")
            If gdataset.Tables("VW_INV_GRNBILL").Rows.Count > 0 Then
                rViewer.ssql = sqlstring
                rViewer.Report = r
                rViewer.TableName = "VW_INV_GRNBILL"
                Dim textobj1 As TextObject
                textobj1 = r.ReportDefinition.ReportObjects("Text4")
                textobj1.Text = MyCompanyName

                Dim textobj2 As TextObject
                textobj2 = r.ReportDefinition.ReportObjects("Text10")
                textobj2.Text = gUsername

                Dim t1 As TextObject
                t1 = r.ReportDefinition.ReportObjects("Text5")
                t1.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode
                If gCompanyShortName = "KGA" Then
                    Dim t2 As TextObject
                    t2 = r.ReportDefinition.ReportObjects("Text6")
                    t2.Text = "Tel:" & GPHONE & ",40090019, Fax:" & gFax & ", Email:pur@kga.in" & ", Web:" & gWebsite
                Else
                    Dim t2 As TextObject
                    t2 = r.ReportDefinition.ReportObjects("Text6")
                    t2.Text = "Tel:" & GPHONE & ", Fax:" & gFax & ", Email:" & gEmail & ", Web:" & gWebsite
                End If
             
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

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Exit Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Grnno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Indentno.KeyPress
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

    Private Sub dtp_Grndate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Indentdate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                txt_Suppliercode.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Grn Date Keypress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Supplierinvno_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Try
        '    If Asc(e.KeyChar) = 13 Then
        '        dtp_Supplierinvdate.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Supplier Invno Keypress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub dtp_Supplierinvdate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_Suppliercode.Text) = "" Then
                    Call cmd_Suppliercodehelp_Click(cmd_Suppliercodehelp, e)
                Else
                    Call txt_Suppliercode_Validated(txt_Suppliercode, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_Suppliercode_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
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
        'Try
        '    getNumeric(e)
        '    If Asc(e.KeyChar) = 13 Then
        '        ssgrid.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Creditdays_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Totalamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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
    Private Sub txt_Indentno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Indentno.Validated

        Dim j, i As Integer
        Dim dt As New DataTable
        Dim vString, sqlstring, remarks As String
        Dim vTypeseqno, Clsquantity, vGroupseqno As Double
        Try
            If Trim(txt_Indentno.Text) <> "" Then
                sqlstring = " SELECT ISNULL(H.INDENT_NO,'') AS INDENT_NO,H.INDENTDATE AS INDENTDATE,ISNULL(H.SUPPLIERCODE,'') AS SUPPLIERCODE,ISNULL(H.SUPPLIERNAME,'') AS SUPPLIERNAME, "
                sqlstring = sqlstring & " ISNULL(H.WORKDESC,'') AS WORKDESC,ISNULL(H.REQUESTEDBY,'') AS REQUESTEDBY,ISNULL(H.APPROVEDBY,'') AS APPROVEDBY,H.COMPLETIONDATE AS COMPLETIONDATE,"
                sqlstring = sqlstring & " ISNULL(H.REMARKS,'') AS REMARKS, ISNULL(H.VOID,'') AS VOID,"
                sqlstring = sqlstring & " ISNULL(H.ADDUSER,'') AS ADDUSER  "
                sqlstring = sqlstring & " FROM PO_WORKINDENT AS H "
                sqlstring = sqlstring & " WHERE INDENT_NO='" & txt_Indentno.Text & "'"
                gconnection.getDataSet(sqlstring, "PO_WORKINDENT")
                '''************************************************* SELECT RECORD FROM INDENTHDR *********************************************''''                
                If gdataset.Tables("PO_WORKINDENT").Rows.Count > 0 Then
                    Cmd_Add.Text = "Update[F7]"
                    Me.txt_Indentno.ReadOnly = True
                    'VSTRDOCNO = Trim(txt_Docno.Text)
                    txt_Indentno.Text = Trim(gdataset.Tables("PO_WORKINDENT").Rows(0).Item("INDENT_NO") & "")
                    dtp_Indentdate.Value = Format(CDate(gdataset.Tables("PO_WORKINDENT").Rows(0).Item("INDENTDATE")), "dd-MM-yyyy")
                    dtp_completiondate.Value = Format(CDate(gdataset.Tables("PO_WORKINDENT").Rows(0).Item("COMPLETIONDATE")), "dd-MM-yyyy")
                    txt_wrkdesc.Text = Trim(gdataset.Tables("PO_WORKINDENT").Rows(0).Item("WORKDESC") & "")
                    'Call TXT_FROMSTORECODE_Validated(txt_Indentno.Text, e)
                    cmb_reqby.Text = Trim(gdataset.Tables("PO_WORKINDENT").Rows(0).Item("REQUESTEDBY"))
                    cmb_approvedby.Text = Trim(gdataset.Tables("PO_WORKINDENT").Rows(0).Item("APPROVEDBY"))
                    txt_Suppliercode.Text = Trim(gdataset.Tables("PO_WORKINDENT").Rows(0).Item("SUPPLIERCODE"))
                    txt_Suppliername.Text = Trim(gdataset.Tables("PO_WORKINDENT").Rows(0).Item("SUPPLIERNAME"))
                    remarks = Trim(gdataset.Tables("PO_WORKINDENT").Rows(0).Item("REMARKS"))
                    txt_Remarks.Text = Replace(remarks, "?", "'")
                    If gdataset.Tables("PO_WORKINDENT").Rows(0).Item("VOID") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = Me.lbl_Freeze.Text & Format(CDate(gdataset.Tables("PO_WORKINDENT").Rows(0).Item("UPDATETIME")), "dd-MMM-yyyy")
                        Me.Cmd_Freeze.Enabled = True
                        Me.Cmd_Add.Enabled = False
                        Me.Cmd_Freeze.Text = "UnVoid[F8]"
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.Cmd_Freeze.Enabled = True
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.Cmd_Freeze.Text = "Void[F8]"
                    End If
                    '''************************************************* SELECT RECORD FROM INDENTDETAILS *********************************************''''                
                    If gUserCategory <> "S" Then
                        Call GetRights()
                    End If
                    If Not String.IsNullOrEmpty(gAuditFlg) Then
                        If gAuditFlg.ToUpper = "Y" Then
                            Me.Cmd_Add.Enabled = False
                            Me.Cmd_Freeze.Enabled = False
                        End If
                    End If

                Else
                    dtp_Indentdate.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Enter valid DOC No :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_Indentno_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Indentno.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                If cmd_Wonohelp.Enabled = True Then
                    search = Trim(txt_Indentno.Text)
                    Call cmd_Wonohelp_Click(cmd_Wonohelp, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_Grnno_KeyDown" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub


    Private Sub PO_WorkOrderIndent_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                Call Cmd_Clear_Click(Cmd_Clear, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F8 Then
                Call Cmd_Freeze_Click(Cmd_Freeze, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F2 Then
                'txt_Grnno.Text = ""
                'txt_Grnno.Focus()
                'Exit Sub
            ElseIf e.KeyCode = Keys.F7 Then
                Call Cmd_Add_Click(Cmd_Add, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F9 Then
                Call Cmd_View_Click(Cmd_View, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F11 Then
                Call Cmd_Exit_Click(Cmd_Exit, e)
                Exit Sub
            ElseIf e.KeyCode = Keys.F12 Then
                Call billingterms()
                Exit Sub
            ElseIf e.KeyCode = Keys.Escape Then
                If grp_Excisedetails.Top = 104 Then
                    grp_Excisedetails.Top = 1000
                    'dtp_Supplierinvdate.Focus()
                    Exit Sub
                ElseIf grp_Billingdetails.Top = 144 Then
                    grp_Billingdetails.Top = 1000
                    txt_Remarks.Focus()
                    Exit Sub
                ElseIf grp_StockGrndetails.Top = 176 Then
                    grp_StockGrndetails.Top = 1000
                    Cmd_View.Focus()
                    Exit Sub
                Else
                    Call Cmd_Exit_Click(Cmd_Exit, e)
                    Exit Sub
                End If
            ElseIf e.Alt = True And e.KeyCode = Keys.R Then
                Me.txt_Remarks.Focus()
                Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.D Then
                'Me.txt_Discountamt.Focus()
                'Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.G Then
                'Me.ssgrid.Focus()
                'Me.ssgrid.SetActiveCell(1, 1)
                'Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.V Then
                'Me.txt_Vatamount.Focus()
                'Exit Sub
            ElseIf e.Alt = True And e.KeyCode = Keys.N Then
                ' Me.txt_Grnno.Focus()
                ' Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : PO_WorkOrderIndent_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub autogenerate()
        'Try
        '    Dim sqlstring, financalyear As String
        '    Dim month As String
        '    Dim CATLEN As Integer

        '    month = UCase(Format(Now, "MMM"))
        '    gcommand = New SqlCommand
        '    financalyear = Mid(gFinancalyearStart, 3, 2) & "-" & Mid(gFinancialyearEnd, 3, 2)

        '    sqlstring = "SELECT ISNULL(CATEGORY,'') AS CATEGORY FROM INVENTORYITEMMASTER WHERE ISNULL(CATEGORY,'')='" & Trim(CMB_CATEGORY.Text & "") & "' GROUP BY CATEGORY"
        '    gconnection.getDataSet(sqlstring, "CATEGORY")
        '    If gdataset.Tables("CATEGORY").Rows.Count > 0 Then
        '        CATEGORY = Mid(Trim(gdataset.Tables("CATEGORY").Rows(0).Item("CATEGORY") & ""), 1, 3)
        '        CATLEN = Len(Trim(CATEGORY))
        '    Else
        '        CATLEN = 3
        '        CATEGORY = month
        '    End If
        '    sqlstring = "SELECT MAX(Cast(SUBSTRING(GRNNO,1,6) As Numeric)) FROM GRN_HEADER WHERE SUBSTRING(GRNDETAILS,5," & CATLEN & ")='" & CATEGORY & "'  AND ISNULL(GRNTYPE,'')='GRN'"
        '    '        sqlstring = "SELECT MAX(Cast(SUBSTRING(GRNNO,1,6) As Numeric)) FROM GRN_HEADER"
        '    gconnection.openConnection()
        '    gcommand.CommandText = sqlstring
        '    gcommand.CommandType = CommandType.Text
        '    gcommand.Connection = gconnection.Myconn
        '    gdreader = gcommand.ExecuteReader
        '    If gdreader.Read Then
        '        If gdreader(0) Is System.DBNull.Value Then
        '            txt_Grnno.Text = "GRN/" & CATEGORY & "/" & "0001/" & financalyear
        '            gdreader.Close()
        '            gcommand.Dispose()
        '            gconnection.closeConnection()
        '        Else
        '            txt_Grnno.Text = "GRN/" & CATEGORY & "/" & Format(gdreader(0) + 1, "0000") & "/" & financalyear
        '            gdreader.Close()
        '            gcommand.Dispose()
        '            gconnection.closeConnection()
        '        End If
        '    Else
        '        txt_Grnno.Text = "GRN/" & CATEGORY & "/0001/" & financalyear
        '        gdreader.Close()
        '        gcommand.Dispose()
        '        gconnection.closeConnection()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : autogenerate" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub checkValidation()
        Try
            boolchk = False
            '    '''**************************************** Check DATEVALIDATION *******************************************''
            Call Checkdatevalidate(Format(dtp_Indentdate.Value, "dd-MMM-yyyy"))
            If chkdatevalidate = False Then Exit Sub
            '    '''**************************************** Check INDENT NO. can't be blank *******************************************''
            If Trim(txt_Indentno.Text) = "" Then
                MessageBox.Show("INDENT NO. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_Indentno.Focus()
                Exit Sub
            End If
            '    '''**************************************** Check SUPPLIER INVOICENO. can't be blank *******************************************''
            '    If Trim(txt_Supplierinvno.Text) = "" Then
            '        MessageBox.Show("Supplier Invoice no. Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '        txt_Supplierinvno.Focus()
            '        Exit Sub
            '    End If
            '    '''**************************************** Check SUPPLIER CODE can't be blank *******************************************''
            'If Trim(txt_Suppliercode.Text) = "" Then
            '    MessageBox.Show("Supplier Code Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            '    txt_Suppliercode.Focus()
            '    Exit Sub
            'End If
            '    '''**************************************** Check SUPPLIER NAME can't be blank *******************************************''
            If Trim(txt_wrkdesc.Text) = "" Then
                MessageBox.Show("WORKDESC Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                txt_wrkdesc.Focus()
                Exit Sub
            End If



            '    If Cmd_Add.Text = "Update[F7]" And Me.lbl_Grn.Text = "Bill Generated" Then
            '        If Me.ssgrid.DataRowCnt > TotalCount Then
            '            MsgBox("GRN Has Been Generated You Can Not Add More Item", MsgBoxStyle.Exclamation, MyCompanyName)
            '            Exit Sub
            '        End If
            '    End If


            boolchk = True
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : checkValidation" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub FillMenu()
        'Try
        '    Dim vform As New ListOperattion1
        '    Dim K As Integer
        '    '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        '    gSQLString = "SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, "
        '    gSQLString = gSQLString & " ISNULL(CONVVALUE,0) AS CONVUOM FROM INVENTORYITEMMASTER I"
        '    If Trim(search) = " " Then
        '        M_WhereCondition = ""
        '    Else
        '        M_WhereCondition = " WHERE I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE='" & txt_Storecode.Text & "'"
        '    End If
        '    vform.Field = " ITEMNAME,ITEMCODE"
        '    vform.vFormatstring = "    ITEMCODE    |                     ITEMNAME                    |  STOCKUOM  | PURCHASERATE | CONVUOM | HIGHRATIO |"
        '    vform.vCaption = "INVENTORY ITEM CODE HELP"
        '    vform.KeyPos = 0
        '    vform.KeyPos1 = 1
        '    vform.KeyPos2 = 2
        '    vform.Keypos3 = 3
        '    vform.keypos4 = 4
        '    'vform.Keypos5 = 5
        '    vform.ShowDialog(Me)
        '    If Trim(vform.keyfield & "") <> "" Then
        '        ssgrid.Col = 1
        '        ssgrid.Row = ssgrid.ActiveRow
        '        ssgrid.Text = Trim(vform.keyfield)
        '        ssgrid.Col = 2
        '        ssgrid.Row = ssgrid.ActiveRow
        '        ssgrid.Text = Trim(vform.keyfield1)
        '        ssgrid.Col = 3
        '        ssgrid.Row = ssgrid.ActiveRow
        '        ssgrid.TypeComboBoxString = Trim(vform.keyfield2)
        '        ssgrid.Text = Trim(vform.keyfield2)
        '        ssgrid.Col = 5
        '        ssgrid.Row = ssgrid.ActiveRow
        '        ssgrid.Text = Format(Val(vform.keyfield3), "0.00")
        '        ssgrid.Col = 13
        '        ssgrid.Row = ssgrid.ActiveRow
        '        ssgrid.Text = Trim(vform.keyfield4)
        '        ssgrid.Col = 14
        '        ssgrid.Row = ssgrid.ActiveRow
        '        ssgrid.Text = Format(Val(vform.keyfield5), "0.00")
        '        ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
        '        ssgrid.Focus()
        '    Else
        '        ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
        '        Exit Sub
        '    End If
        '    vform.Close()
        '    vform = Nothing
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : FillMenu" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub FillMenuItem()
        'Try
        '    Dim vform As New ListOperattion1
        '    Dim K As Integer
        '    Dim ssql As String
        '    '''******************************************************** $ FILL THE ITEMDESC,ITEMCODE INTO SSGRID ********** 
        '    gSQLString = "SELECT DISTINCT ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.ITEMCODE,'') AS ITEMCODE,"
        '    gSQLString = gSQLString & "ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, "
        '    gSQLString = gSQLString & " ISNULL(CONVVALUE,0) AS CONVVALUE FROM INVENTORYITEMMASTER AS I"
        '    If Trim(search) = " " Then
        '        M_WhereCondition = ""
        '    Else
        '        M_WhereCondition = " WHERE I.ITEMNAME LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y'  AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "'"
        '    End If
        '    vform.Field = "I.ITEMNAME,I.ITEMCODE"
        '    vform.vFormatstring = "                     ITEMNAME                |   ITEMCODE    | STOCKUOM  |PURCHASERATE | CONVUOM | HIGHRATIO |"
        '    vform.vCaption = "INVENTORY ITEM CODE HELP"
        '    vform.KeyPos = 0
        '    vform.KeyPos1 = 1
        '    vform.KeyPos2 = 2
        '    vform.Keypos3 = 3
        '    vform.keypos4 = 4
        '    vform.ShowDialog(Me)
        '    If Trim(vform.keyfield & "") <> "" Then
        '        ssgrid.Col = 1
        '        ssgrid.Row = ssgrid.ActiveRow
        '        ssgrid.Text = Trim(vform.keyfield1)
        '        ssgrid.Col = 2
        '        ssgrid.Row = ssgrid.ActiveRow
        '        ssgrid.Text = Trim(vform.keyfield)
        '        ssgrid.Col = 3
        '        ssgrid.Row = ssgrid.ActiveRow
        '        ssgrid.TypeComboBoxString = Trim(vform.keyfield2)
        '        ssgrid.Text = Trim(vform.keyfield2)
        '        ssgrid.Col = 5
        '        ssgrid.Row = ssgrid.ActiveRow
        '        ssgrid.Text = Format(Val(vform.keyfield3), "0.00")
        '        ssgrid.Col = 13
        '        ssgrid.Row = ssgrid.ActiveRow
        '        ssgrid.Text = Trim(vform.keyfield4)
        '        ssgrid.Col = 14
        '        ssgrid.Row = ssgrid.ActiveRow
        '        ssgrid.Text = Format(Val(vform.keyfield5), "0.00")
        '        ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
        '        ssgrid.Focus()
        '    Else
        '        ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
        '        Exit Sub
        '    End If
        '    vform.Close()
        '    vform = Nothing
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : FillMenuItem" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub txt_Totalamt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    txt_Totalamt.Text = Format(Val(txt_Totalamt.Text), "0.00")
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Totalamt_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Discountamt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If Val(txt_Discountamt.Text) <> 0 Then
        '        txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
        '    End If
        '    txt_Discountamt.Text = Format(Val(txt_Discountamt.Text), "0.00")
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Discountamt_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Supplierinvno_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Call supplerinvno()
        '    txt_Supplierinvno.BackColor = Color.Wheat
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Supplierinvno_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub supplerinvno()
        'Try
        '    If Trim(txt_Supplierinvno.Text) = "" Then
        '        txt_Supplierinvno.Text = Trim(txt_Grnno.Text)
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : supplerinvno" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub FillStore()
        Try
            Dim i As Integer
            sqlstring = "SELECT distinct(Storedesc) FROM StoreMaster ORDER BY Storedesc ASC"
            gconnection.getDataSet(sqlstring, "StoreMaster")
            cbo_Storelocation.Items.Clear()
            cbo_Storelocation.Sorted = True
            If gdataset.Tables("StoreMaster").Rows.Count > 0 Then
                For i = 0 To gdataset.Tables("StoreMaster").Rows.Count - 1
                    cbo_Storelocation.Items.Add(gdataset.Tables("StoreMaster").Rows(i).Item("Storedesc"))
                Next i
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : FillStore" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Public Function CreateListBox()
        Try
            Listbox = New System.Windows.Forms.ListBox
            Listbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Listbox.Location = New System.Drawing.Point(1000, 1000)
            Listbox.Name = "ListViewHelp"
            Listbox.Size = New System.Drawing.Size(10, 10)
            Listbox.TabIndex = 29
            Listbox.ScrollAlwaysVisible = False
            Listbox.HorizontalScrollbar = False
            Me.Controls.Add(Listbox)
            Listbox.BringToFront()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : CreateListBox" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Public Function TextBoxKeydownevent(ByVal e As System.Windows.Forms.KeyEventArgs, ByVal ObjTextBox As TextBox)
        If e.KeyCode = Keys.Down Then
            Try
                Listbox.SelectedIndex = Listbox.SelectedIndex + 1
            Catch ex As Exception
                Listbox.SelectedIndex = 0
            End Try
        End If
        If e.KeyCode = Keys.Up Then
            Try
                Listbox.SelectedIndex = Listbox.SelectedIndex - 1
            Catch ex As Exception
                Listbox.SelectedIndex = Listbox.Items.Count - 1
            End Try
        End If
        If e.KeyCode = Keys.Enter Then
            ObjTextBox.Text = Listbox.SelectedItem()
            Listbox.Location = New System.Drawing.Point(1000, 1000)
        End If
        If e.KeyCode = Keys.Escape Then
            Listbox.Location = New System.Drawing.Point(1000, 1000)
            ObjTextBox.Focus()
        End If
    End Function
    Public Function TextBoxTextchangeevent(ByVal e As System.EventArgs, ByVal ObjTextBox As TextBox, ByVal Sqlstring As String, ByVal Tablename As String, ByVal ds As DataSet)
        Try
            gadapter = New SqlDataAdapter(Sqlstring, gconnection.Myconn)
            If ds.Tables.Contains(Tablename) = True Then
                ds.Tables.Remove(Tablename)
            End If
            gadapter.Fill(ds, Tablename)
            Call TextBoxHelp(ObjTextBox, Tablename, ds)
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Public Function TextBoxHelp(ByVal ObjTextBox As TextBox, ByVal Tablename As String, ByVal ds As DataSet)
        Dim drow As DataRow
        Listbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Listbox.Location = New System.Drawing.Point(ObjTextBox.Left, ObjTextBox.Top + ObjTextBox.Height)
        Listbox.Size = New System.Drawing.Size(ObjTextBox.Width, 100)
        Listbox.Items.Clear()
        If ds.Tables(Tablename).Rows.Count > 0 Then
            For Each drow In ds.Tables(Tablename).Rows
                Listbox.Items.Add(drow.Item(1))
            Next
        End If
        Try
            Listbox.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Function
    Public Function FOOTER()
        'sqlstring = "SELECT isnull(UPDFOOTER,'') as UPDFOOTER, isnull(UPDNAME,'') as UPDNAME  FROM Grn_header WHERE  AUTOID IN (SELECT MAX(AUTOID) FROM Grn_header)"
        'gconnection.getDataSet(sqlstring, "Grn_header")
        'If gdataset.Tables("Grn_header").Rows.Count > 0 Then
        '    Txt_footer.Text = Trim(gdataset.Tables("Grn_header").Rows(0).Item("UPDFOOTER"))
        '    Txt_signature.Text = Trim(gdataset.Tables("Grn_header").Rows(0).Item("UPDNAME"))
        'End If
    End Function
    Private Sub txt_Suppliername_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Suppliername.Validated
        Try
            If Trim(txt_Suppliername.Text) <> "" Then
                sqlstring = "SELECT SLCODE,SLNAME FROM accountssubledgermaster WHERE ACCODE = '" & Trim(gCreditors) & "'AND SLNAME='" & Trim(txt_Suppliername.Text) & "'"
                gconnection.getDataSet(sqlstring, "accountssubledgermaster")
                If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
                    txt_Suppliername.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("SLNAME"))
                    txt_Suppliercode.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("SLCODE"))
                    txt_Excisepassno.Focus()
                    txt_Suppliercode.ReadOnly = True
                Else
                    txt_Suppliercode.Text = ""
                    txt_Suppliercode.ReadOnly = False
                    txt_Suppliername.Focus()
                End If
            Else
                txt_Suppliercode.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_Suppliername_Validated" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub


    Private Sub Cmd_StockGrnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_StockGrnClear.Click
        Try
            Me.txt_FromDocno.Text = ""
            Me.txt_ToDocno.Text = ""
            Me.txt_FromDocno.ReadOnly = False
            Me.txt_FromDocno.ReadOnly = False
            Me.txt_FromDocno.Focus()
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Cmd_StockGrnClear_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_StockGrnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_StockGrnView.Click
        'Try
        '    Dim i As Integer
        '    Dim objGrncumpurchase As New rptGrncumpurchase
        '    gPrint = False
        '    If Trim(txt_FromDocno.Text) = "" Then
        '        MessageBox.Show("From Grn No. can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        '        Exit Sub
        '    ElseIf Trim(txt_ToDocno.Text) = "" Then
        '        MessageBox.Show("To Grn No. can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        '        Exit Sub
        '    End If
        '    sqlstring = " SELECT * FROM VIEWPURCHASEREGISTERSUMMARY "
        '    sqlstring = sqlstring & " WHERE GRNDETAILS BETWEEN '" & Trim(txt_FromDocno.Text) & "' AND '" & Trim(txt_ToDocno.Text) & "'"
        '    sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMCODE  "
        '    Dim heading() As String = {"GRN CUM PURCHASE BILL"}
        '    Dim ObjStockPurchaseregisterReport As New rptStockPurchaseregister
        '    ObjStockPurchaseregisterReport.Reportdetails(sqlstring, heading, Now, Now)
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Cmd_StockGrnView_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub Cmd_StockGrnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_StockGrnprint.Click
        'Try
        '    gPrint = True
        '    Dim i As Integer
        '    Dim objGrncumpurchase As New rptGrncumpurchase
        '    If Trim(txt_FromDocno.Text) = "" Then
        '        MessageBox.Show("From Grn No. can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        '        Exit Sub
        '    ElseIf Trim(txt_ToDocno.Text) = "" Then
        '        MessageBox.Show("To Grn No. can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
        '        Exit Sub
        '    End If
        '    sqlstring = " SELECT * FROM VIEWPURCHASEREGISTERSUMMARY "
        '    sqlstring = sqlstring & " WHERE GRNDETAILS BETWEEN '" & Trim(txt_FromDocno.Text) & "' AND '" & Trim(txt_ToDocno.Text) & "'"
        '    sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMCODE  "
        '    Dim heading() As String = {"GRN CUM PURCHASE BILL"}
        '    Dim ObjStockPurchaseregisterReport As New rptStockPurchaseregister
        '    ObjStockPurchaseregisterReport.Reportdetails(sqlstring, heading, Now, Now)
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Cmd_StockGrnprint_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub Cmd_StockGrnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_StockGrnexit.Click
        Try
            txt_FromDocno.Text = ""
            txt_ToDocno.Text = ""
            grp_StockGrndetails.Top = 1000
            Cmd_Clear_Click(Cmd_Clear, e)
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Cmd_StockGrnexit_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
            MessageBox.Show("Plz Check Error : txt_FromDocno_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
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
                    Cmd_StockGrnView.Focus()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_ToDocno_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_FromDocno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_FromDocno.Click
        'Try
        '    gSQLString = "SELECT GRNDETAILS,GRNDATE FROM Grn_header"
        '    M_WhereCondition = " "
        '    Dim vform As New List_Operation
        '    vform.Field = "GRNDETAILS,GRNDATE"
        '    vform.vFormatstring1 = "          GRN CODE              |         GRN DATE                             "
        '    vform.vCaption = "GRN CUM PURCHASE BILL HELP"
        '    vform.KeyPos = 0
        '    vform.KeyPos1 = 1
        '    vform.ShowDialog(Me)
        '    If Trim(vform.keyfield & "") <> "" Then
        '        txt_FromDocno.Text = Trim(vform.keyfield & "")
        '        txt_ToDocno.Focus()
        '    End If
        '    vform.Close()
        '    vform = Nothing
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Cmd_FromDocno_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub Cmd_ToDocno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ToDocno.Click
        'Try
        '    gSQLString = "SELECT GRNDETAILS,GRNDATE FROM Grn_header"
        '    M_WhereCondition = " "
        '    Dim vform As New List_Operation
        '    vform.Field = "GRNDETAILS,GRNDATE"
        '    vform.vFormatstring1 = "          GRN CODE              |         GRN DATE                             "
        '    vform.vCaption = "GRN CUM PURCHASE BILL HELP"
        '    vform.KeyPos = 0
        '    vform.KeyPos1 = 1
        '    vform.ShowDialog(Me)
        '    If Trim(vform.keyfield & "") <> "" Then
        '        txt_ToDocno.Text = Trim(vform.keyfield & "")
        '        Cmd_StockGrnView.Focus()
        '    End If
        '    vform.Close()
        '    vform = Nothing
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Cmd_ToDocno_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub Cmd_GLAcHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim vform As New ListOperattion1
        '    gSQLString = "SELECT accode,acdesc FROM accountsglaccountmaster"
        '    M_WhereCondition = ""
        '    vform.Field = "ACDESC,ACCODE"
        '    vform.vFormatstring = "  ACCODE                              |                      ACDESC                                                                                                     "
        '    vform.vCaption = "GLACCOUNT MASTER HELP"
        '    vform.KeyPos = 0
        '    vform.KeyPos1 = 1
        '    vform.ShowDialog(Me)
        '    If Trim(vform.keyfield & "") <> "" Then
        '        Txt_GLAcIn.Text = Trim(vform.keyfield & "")
        '        Txt_GLAcDesc.Text = Trim(vform.keyfield1 & "")
        '        Call Glaccountvalidate()
        '    Else
        '        Me.Txt_GLAcIn.Focus()
        '    End If
        '    vform.Close()
        '    vform = Nothing
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Cmd_GLAcHelp_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub Glaccountvalidate()
        'Try
        '    Dim sqlstring As String
        '    If Trim(Txt_GLAcIn.Text) <> "" Then
        '        sqlstring = "SELECT slcode,slname FROM accountssubledgermaster WHERE accode = '" & Trim(Txt_GLAcIn.Text) & "'"
        '        gconnection.getDataSet(sqlstring, "accountssubledgermaster")
        '        If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
        '            Lbl_SubledgerCode.Visible = True
        '            Lbl_SubledgerName.Visible = True
        '            Txt_Slcode.Visible = True
        '            Cmd_SlCodeHelp.Visible = True
        '            Txt_SlDesc.Visible = True
        '            slcodestatus = True
        '            grp_grnposting.Top = 218
        '            grp_grnposting.Height = 80
        '            ssgrid.Left = 10
        '            ssgrid.Top = 272
        '            ssgrid.Height = 224
        '            Txt_Slcode.Focus()
        '        Else
        '            Lbl_SubledgerCode.Visible = False
        '            Lbl_SubledgerName.Visible = False
        '            Txt_Slcode.Visible = False
        '            Cmd_SlCodeHelp.Visible = False
        '            Txt_SlDesc.Visible = False
        '            slcodestatus = False
        '            grp_grnposting.Top = 218
        '            grp_grnposting.Height = 48
        '            grp_grnposting.Width = 848
        '            ssgrid.Top = 272
        '            ssgrid.Left = 10
        '            ssgrid.Height = 250
        '            ssgrid.Focus()
        '            Txt_CostCenterCode.Focus()
        '        End If
        '        gdataset.Tables("accountssubledgermaster").Dispose()
        '        Call Costcentervalidate()
        '    Else
        '        Txt_GLAcIn.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Glaccountvalidate" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub Costcentervalidate()
        'Try
        '    Dim SQLSTRING As String
        '    Dim DR As DataRow
        '    Dim i As Integer
        '    If Trim(Txt_GLAcIn.Text) <> "" Then
        '        SQLSTRING = "SELECT PRIMARYGROUPCODE FROM ACCOUNTTAGGING WHERE GLACCODE = '" & Trim(Txt_GLAcIn.Text) & "'"
        '        gconnection.getDataSet(SQLSTRING, "MASTER1")
        '        If gdataset.Tables("MASTER1").Rows.Count > 0 Then
        '            Lbl_CostCenterCode.Visible = True
        '            Lbl_CostCenterDesc.Visible = True
        '            Txt_CostCenterCode.Visible = True
        '            Txt_CostCenterDesc.Visible = True
        '            Cmd_CostCenterCodeHelp.Visible = True
        '            costcentercodestatus = True
        '            grp_grnposting.Top = 218
        '            grp_grnposting.Width = 848
        '            grp_grnposting.Height = 120
        '            ssgrid.Top = 344
        '            ssgrid.Left = 10
        '            ssgrid.Height = 195
        '            lbl_Creditdays.Top = 280
        '            lbl_Creditdays.Left = 504
        '            txt_Creditdays.Top = 280
        '            txt_Creditdays.Left = 672
        '            Gr = Nothing
        '            For Each DR In gdataset.Tables("MASTER1").Rows
        '                If Trim(Gr) = "" Then
        '                    Gr = "'" & Trim(DR("PRIMARYGROUPCODE")) & "'"
        '                Else
        '                    Gr = Gr & ",'" & Trim(DR("PRIMARYGROUPCODE")) & "'"
        '                End If
        '            Next
        '        Else
        '            Lbl_CostCenterCode.Visible = False
        '            Lbl_CostCenterDesc.Visible = False
        '            Txt_CostCenterCode.Visible = False
        '            Txt_CostCenterDesc.Visible = False
        '            Cmd_CostCenterCodeHelp.Visible = False
        '            costcentercodestatus = False
        '            If slcodestatus = True Then
        '                grp_grnposting.Top = 218
        '                grp_grnposting.Height = 80
        '                ssgrid.Left = 65
        '                ssgrid.Top = 272
        '                ssgrid.Height = 215
        '                Txt_Slcode.Focus()
        '            Else
        '                grp_grnposting.Height = 48
        '                grp_grnposting.Width = 848
        '                ssgrid.Top = 272
        '                ssgrid.Left = 10
        '                ssgrid.Height = 255
        '                ssgrid.Focus()
        '            End If
        '        End If
        '    Else
        '        Txt_GLAcIn.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Costcentervalidate" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub Txt_GLAcIn_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim sqlstring As String
        '    If Trim(Txt_GLAcIn.Text) <> "" Then
        '        sqlstring = "select accode, acdesc from accountsglaccountmaster where accode = '" & Trim(Txt_GLAcIn.Text) & "'"
        '        gconnection.getDataSet(sqlstring, "accountsglaccountmaster")
        '        If gdataset.Tables("accountsglaccountmaster").Rows.Count > 0 Then
        '            Txt_GLAcDesc.Text = Trim(UCase(gdataset.Tables("accountsglaccountmaster").Rows(0).Item("acdesc")))
        '            If slcodestatus = True Then
        '                Txt_Slcode.Focus()
        '            Else
        '                Txt_CostCenterCode.Focus()
        '            End If
        '        Else
        '            Txt_GLAcIn.Text = ""
        '            Txt_GLAcDesc.Text = ""
        '        End If
        '        gdataset.Tables("accountsglaccountmaster").Dispose()
        '        Call Glaccountvalidate()
        '    Else
        '        Txt_GLAcIn.Text = ""
        '        'Txt_GLAcIn.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Txt_GLAcIn_Validated " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub Txt_Slcode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim sqlstring As String
        '    If Trim(Txt_Slcode.Text) <> "" Then
        '        sqlstring = "SELECT slcode, sldesc from accountssubledgermaster WHERE accode = '" & Trim(Txt_GLAcIn.Text) & "' and slcode = '" & Trim(Txt_Slcode.Text) & "'"
        '        gconnection.getDataSet(sqlstring, "accountssubledgermaster")
        '        If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
        '            Txt_Slcode.Text = Trim(UCase(gdataset.Tables("accountssubledgermaster").Rows(0).Item("slcode")))
        '            Txt_SlDesc.Text = Trim(UCase(gdataset.Tables("accountssubledgermaster").Rows(0).Item("sldesc")))
        '            If costcentercodestatus = True Then
        '                Txt_CostCenterCode.Focus()
        '            Else
        '                ssgrid.Focus()
        '            End If
        '        Else
        '            Txt_Slcode.Text = ""
        '            Txt_SlDesc.Text = ""
        '        End If
        '        gdataset.Tables("accountssubledgermaster").Dispose()
        '    Else
        '        Txt_Slcode.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Txt_Slcode_Validated" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub Txt_CostCenterCode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim sqlstring As String
        '    If Trim(Txt_CostCenterCode.Text) <> "" Then
        '        sqlstring = "SELECT COSTCENTERCODE,COSTCENTERDESC from accountscostcentermaster where COSTCENTERCODE = '" & Trim(Txt_CostCenterCode.Text) & "' And PRIMARYGROUPCODE IN (" & Gr & ")"
        '        gconnection.getDataSet(sqlstring, "accountscostcentermaster")
        '        If gdataset.Tables("accountscostcentermaster").Rows.Count > 0 Then
        '            Txt_CostCenterDesc.Text = Trim(UCase(gdataset.Tables("accountscostcentermaster").Rows(0).Item("COSTCENTERDESC")))
        '            ssgrid.Focus()
        '            ssgrid.SetActiveCell(1, 1)
        '        Else
        '            Txt_CostCenterDesc.Text = ""
        '            Txt_CostCenterCode.Text = ""
        '        End If
        '        gdataset.Tables("accountscostcentermaster").Dispose()
        '    Else
        '        Txt_CostCenterCode.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Txt_CostCenterCode_Validated" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub Cmd_CostCenterCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim vform As New ListOperattion1
        '    gSQLString = "SELECT COSTCENTERCODE,COSTCENTERDESC FROM ACCOUNTSCOSTCENTERMASTER"
        '    M_WhereCondition = " WHERE PRIMARYGROUPCODE IN (" & Gr & ")"
        '    vform.Field = "COSTCENTERCODE"
        '    vform.Field = "COSTCENTERDESC"
        '    vform.vFormatstring = "  COSTCENTERCODE                   |                          COSTCENTERDESC                                "
        '    vform.vCaption = "COSTCENTER MASTER HELP"
        '    vform.KeyPos = 0
        '    vform.KeyPos1 = 1
        '    vform.ShowDialog(Me)
        '    If Trim(vform.keyfield & "") <> "" Then
        '        Txt_CostCenterCode.Text = Trim(vform.keyfield & "")
        '        Txt_CostCenterDesc.Text = Trim(vform.keyfield1 & "")
        '        ssgrid.Focus()
        '        ssgrid.SetActiveCell(1, 1)
        '    Else
        '        Me.Txt_Slcode.Focus()
        '    End If
        '    vform.Close()
        '    vform = Nothing
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Cmd_CostCenterCodeHelp_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub Cmd_SlCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '    Try
        '        Dim vform As New ListOperattion1
        '        gSQLString = "SELECT slcode,sldesc FROM accountssubledgermaster"
        '        M_WhereCondition = " WHERE accode = '" & Trim(Txt_GLAcIn.Text) & "'"
        '        vform.Field = "SLCODE"
        '        vform.Field = "SLDESC"
        '        vform.vFormatstring = "  SLCODE                             |                          SLDESC                                "
        '        vform.vCaption = "SUBLEDGER MASTER HELP"
        '        vform.KeyPos = 0
        '        vform.KeyPos1 = 1
        '        vform.ShowDialog(Me)
        '        If Trim(vform.keyfield & "") <> "" Then
        '            Txt_Slcode.Text = Trim(vform.keyfield & "")
        '            Txt_SlDesc.Text = Trim(vform.keyfield1 & "")
        '            Me.Txt_CostCenterCode.Focus()
        '        Else
        '            Me.Txt_GLAcIn.Focus()
        '        End If
        '        vform.Close()
        '        vform = Nothing
        '    Catch ex As Exception
        '        MessageBox.Show("Plz Check Error : Cmd_SlCodeHelp_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '        Exit Sub
        '    End Try
        'End Sub

        'Private Sub Txt_GLAcIn_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        '    Try
        '        If e.KeyCode = Keys.F4 Then
        '            Call Cmd_GLAcHelp_Click(sender, e)
        '            Exit Sub
        '        End If
        '    Catch ex As Exception
        '        MessageBox.Show("Plz Check Error : Txt_GLAcIn_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '        Exit Sub
        '    End Try
    End Sub

    Private Sub Txt_Slcode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.F4 Then
                Call Cmd_SlCodeHelp_Click(sender, e)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Txt_Slcode_KeyDown" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Txt_CostCenterCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.F4 Then
                Call Cmd_CostCenterCodeHelp_Click(sender, e)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : Txt_CostCenterCode_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Txt_GLAcIn_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Try
        '    getAlphanumeric(e)
        '    If Asc(e.KeyChar) = 13 Then
        '        If Trim(Txt_GLAcIn.Text) = "" Then
        '            Call Cmd_GLAcHelp_Click(Cmd_GLAcHelp, e)
        '        Else
        '            Call Txt_GLAcIn_Validated(sender, e)
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Txt_GLAcIn_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub Txt_Slcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Try
        '    getAlphanumeric(e)
        '    If Asc(e.KeyChar) = 13 Then
        '        If Trim(Txt_Slcode.Text) = "" Then
        '            Call Cmd_SlCodeHelp_Click(Cmd_SlCodeHelp, e)
        '            ssgrid.Focus()
        '        Else
        '            Call Txt_Slcode_Validated(Txt_Slcode, e)
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Txt_Slcode_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub Txt_CostCenterCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Try
        '    getAlphanumeric(e)
        '    If Asc(e.KeyChar) = 13 Then
        '        If Trim(Txt_CostCenterCode.Text) = "" Then
        '            Call Cmd_CostCenterCodeHelp_Click(Cmd_CostCenterCodeHelp, e)
        '        Else
        '            Call Txt_CostCenterCode_Validated(sender, e)
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Txt_CostCenterCode_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Suppliercode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Suppliercode.KeyDown
        'Try
        '    If e.KeyCode = Keys.F4 Then
        '        Call cmd_Suppliercodehelp_Click(cmd_Suppliercodehelp, e)
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Suppliercode_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Suppliercode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Suppliercode.Validated
        'Try
        '    If Trim(txt_Suppliercode.Text) <> "" Then
        '        sqlstring = "SELECT SLCODE,SLNAME,isnull(creditperiod,0) as creditperiod FROM accountssubledgermaster WHERE ACCODE IN ("
        '        sqlstring = sqlstring & "'" & Trim(gCreditors) & "') AND SLCODE='" & Trim(txt_Suppliercode.Text) & "'"
        '        gconnection.getDataSet(sqlstring, "accountssubledgermaster")
        '        If gdataset.Tables("accountssubledgermaster").Rows.Count > 0 Then
        '            txt_Suppliername.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("SLNAME"))
        '            txt_Suppliercode.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("SLCODE"))
        '            txt_Creditdays.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("creditperiod"))
        '            txt_Suppliername.ReadOnly = True
        '            If gpaymentcode = "Y" Then
        '                cbo_Billingterms.Focus()
        '            Else
        '                txt_Supplierinvno.Focus()
        '            End If

        '        Else
        '            txt_Suppliercode.Text = ""
        '            txt_Suppliercode.Text = ""
        '            txt_Suppliername.ReadOnly = False
        '            txt_Suppliercode.Focus()
        '        End If
        '    Else
        '        txt_Suppliercode.Text = ""
        '        txt_Suppliername.Text = ""
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Suppliercode_Validated" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub dtp_Stockindate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Stockindate.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                txt_Excisepassno.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : dtp_Stockindate_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Trucknumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Trucknumber.KeyPress
        'Try
        '    If Asc(e.KeyChar) = 13 Then
        '        grp_Excisedetails.Top = 1000
        '        txt_Storecode.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Trucknumber_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Trucknumber_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Trucknumber.LostFocus
        'Try
        '    grp_Excisedetails.Top = 1000
        '    txt_Storecode.Focus()
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Trucknumber_LostFocus " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub dtp_Supplierinvdate_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : dtp_Supplierinvdate_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cbo_Billingterms_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Try
        '    Call Blank(e)
        '    If Asc(e.KeyChar) = 13 Then
        '        'DISABLE GLACCOUNT
        '        txt_Storecode.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : cbo_Billingterms_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub FillBillterms()
        'Try
        '    Dim i As Integer
        '    sqlstring = "SELECT DISTINCT ISNULL(TYPECODE,'') + '  ' +ISNULL(TYPEDESC,'') AS TYPEDESC  FROM PURCHASEBILLTERMS WHERE  ISNULL(FREEZE,'')<>'Y'"
        '    gconnection.getDataSet(sqlstring, "PURCHASEBILLTERMS")
        '    cbo_Billingterms.Items.Clear()
        '    If gdataset.Tables("PURCHASEBILLTERMS").Rows.Count > 0 Then
        '        For i = 0 To gdataset.Tables("PURCHASEBILLTERMS").Rows.Count - 1
        '            cbo_Billingterms.Items.Add(gdataset.Tables("PURCHASEBILLTERMS").Rows(i).Item("Typedesc"))
        '            cbo_Billingterms.Text = gdataset.Tables("PURCHASEBILLTERMS").Rows(i).Item("Typedesc")
        '        Next i
        '    Else
        '        cbo_Billingterms.Text = ""
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : FillBillterms " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub billingterms()
        'Try
        '    Dim per As Double
        '    Call FillBillterms()
        '    Call Fillbilldetails()
        '    grp_Billingdetails.Top = 144
        '    grp_Billingdetails.Left = 160
        '    ssgrid_billdetails.Col = 4
        '    ssgrid_billdetails.Row = 1
        '    ssgrid_billdetails.Text = Format(Val(txt_Totalamt.Text), "0.00")
        '    ssgrid_billdetails.Focus()
        '    ssgrid_billdetails.SetActiveCell(2, 2)
        '    ssgrid_billdetails.Col = 4
        '    ssgrid_billdetails.Row = 2
        '    ssgrid_billdetails.Text = Format(Val(txt_Discountamt.Text), "0.00")
        '    per = (Val(txt_Discountamt.Text) * 100) / Val(txt_Totalamt.Text)
        '    ssgrid_billdetails.Col = 2
        '    ssgrid_billdetails.Row = 2
        '    ssgrid_billdetails.Text = per
        '    ssgrid_billdetails.Col = 4
        '    ssgrid_billdetails.Row = billrow
        '    ssgrid_billdetails.Text = Format(Val(txt_Totalamt.Text), "0.00")
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : billingterms" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub txt_Remarks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Remarks.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                'Call billingterms()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_Remarks_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub Fillbilldetails()
        'Try
        '    Dim i, j As Integer
        '    Dim typecode() As String
        '    typecode = Split(Trim(cbo_Billingterms.Text), "  ")
        '    sqlstring = "SELECT ISNuLL(Billdescription,'') As Billdescription,ISNULL(slno,0) AS SLNO,FORMULA,SIGNS,ISNULL(Accode,'') AS ACCODE ,ISNULL(Acdesc,'') AS ACDESC FROM purchasebillterms WHERE  Typecode = '" & Trim(typecode(0)) & "' AND ISNULL(Freeze,'')<>'Y'"
        '    gconnection.getDataSet(sqlstring, "purchasebillterms")
        '    j = 2
        '    If gdataset.Tables("purchasebillterms").Rows.Count > 0 Then
        '        ssgrid_billdetails.SetText(1, 1, "BASIC" & "  " & ":")
        '        ssgrid_billdetails.Col = 1
        '        ssgrid_billdetails.Row = 1
        '        ssgrid_billdetails.Lock = True
        '        ssgrid_billdetails.Col = 2
        '        ssgrid_billdetails.Row = 1
        '        ssgrid_billdetails.Lock = True
        '        ssgrid_billdetails.Col = 3
        '        ssgrid_billdetails.Row = 1
        '        ssgrid_billdetails.Lock = True
        '        For i = 0 To gdataset.Tables("purchasebillterms").Rows.Count - 1 Step 1
        '            ssgrid_billdetails.SetText(1, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("Billdescription")) & "  " & ":")
        '            ssgrid_billdetails.SetText(5, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("SLNO")))
        '            ssgrid_billdetails.SetText(6, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("FORMULA")))
        '            ssgrid_billdetails.SetText(7, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("SIGNS")))
        '            ssgrid_billdetails.SetText(8, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("ACCODE")))
        '            ssgrid_billdetails.SetText(9, j, Trim(gdataset.Tables("purchasebillterms").Rows(i).Item("ACDESC")))
        '            j = j + 1
        '        Next i
        '        ssgrid_billdetails.SetText(1, j, "BILL AMOUNT" & "  " & ":")
        '        billrow = j
        '        ssgrid_billdetails.Col = 1
        '        ssgrid_billdetails.Row = j
        '        ssgrid_billdetails.Lock = True
        '        ssgrid_billdetails.Col = 2
        '        ssgrid_billdetails.Row = j
        '        ssgrid_billdetails.Lock = True
        '        ssgrid_billdetails.Col = 3
        '        ssgrid_billdetails.Row = j
        '        ssgrid_billdetails.Lock = True
        '        ssgrid_billdetails.SetActiveCell(2, 2)
        '    Else
        '        'SHAN
        '        Call FillBillterms()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : Fillbilldetails " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub billingtermsrefresh(ByVal Activerow As Integer)
        'Try
        '    Dim Totalamount, Taxamount, Calamount, Caltax, CalBilamount, BillAmount, Batchno, Avgrate, Avgquantity As Double
        '    Dim dblBasic, dblDiscount, dblExcise, dblVAT, dblSurchase, dblTranportation, dblOthpostcharge, dblOthNegcharge As Double
        '    Dim Sign, Formula, slno As String
        '    Dim Formule() As Char
        '    Dim II, J As Integer
        '    Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
        '    Dim per As Double

        '    ssgrid_billdetails.Row = 1
        '    ssgrid_billdetails.Col = 4
        '    amt = Val(ssgrid_billdetails.Text)

        '    ssgrid_billdetails.Col = 4
        '    ssgrid_billdetails.Row = ssgrid_billdetails.DataRowCnt
        '    ssgrid_billdetails.Text = amt

        '    dblBasic = Format(Val(ssgrid_billdetails.Text), "0.00")

        '    For i = 2 To ssgrid_billdetails.DataRowCnt - 1
        '        ssgrid_billdetails.Row = i
        '        ssgrid_billdetails.Col = 7
        '        Sign = ssgrid_billdetails.Text

        '        ssgrid_billdetails.Col = 4
        '        Gramt = Val(ssgrid_billdetails.Text)

        '        If Sign = "+" Then
        '            ssgrid_billdetails.Col = 4
        '            ssgrid_billdetails.Row = ssgrid_billdetails.DataRowCnt
        '            ssgrid_billdetails.Text = Format(Val(ssgrid_billdetails.Text) + Val(Gramt), "0.00")
        '        End If

        '        If Sign = "-" Then
        '            ssgrid_billdetails.Col = 4
        '            ssgrid_billdetails.Row = ssgrid_billdetails.DataRowCnt
        '            Bamt = ssgrid_billdetails.Text
        '            ssgrid_billdetails.Text = Format(Val(ssgrid_billdetails.Text) - Val(Gramt), "0.00")
        '        End If

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
        '        ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 12, 6) = "ES (+)" Then
        '            ssgrid_billdetails.Col = 4
        '            If Val(ssgrid_billdetails.Text) > 0 Then
        '                dblOthpostcharge = dblOthpostcharge + Format(Val(ssgrid_billdetails.Text), "0.00")
        '            End If
        '        ElseIf Mid(Trim(CStr(ssgrid_billdetails.Text)), 12, 6) = "ES (-)" Then
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

        '    ssgrid_billdetails.Col = 4
        '    ssgrid_billdetails.Row = ssgrid_billdetails.DataRowCnt
        '    BillAmount = Format(Val(ssgrid_billdetails.Text), "0.00")

        '    txt_Totalamt.Text = Format(dblBasic, "0.00")
        '    txt_Vatamount.Text = Format(dblVAT + dblExcise, "0.00")
        '    txt_Surchargeamt.Text = Format(dblSurchase + dblOthpostcharge + dblTranportation, "0.00")
        '    txt_Discountamt.Text = Format(dblDiscount + dblOthNegcharge, "0.00")
        '    txt_Billamount.Text = Format(BillAmount, "0.00")
        '    ssgrid_billdetails.Row = Activerow
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : billingtermsrefresh " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub billingtermstaxamount(ByVal Activerow)
        'new
        Try
            Dim Sign, Formula, slno As String
            Dim Formule() As Char
            Dim II, J As Integer
            Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
            Dim per As Double
            Dim K As Integer
            For K = 2 To Activerow
                ssgrid_billdetails.Row = 1
                ssgrid_billdetails.Col = 4
                amt = Val(ssgrid_billdetails.Text)

                ssgrid_billdetails.Row = K
                ssgrid_billdetails.Col = 2
                per = Val(ssgrid_billdetails.Text)
                ssgrid_billdetails.Col = 7
                Sign = ssgrid_billdetails.Text

                ssgrid_billdetails.Col = 6
                Formula = ssgrid_billdetails.Text
                Formule = Formula.ToCharArray

                Gtot = 0
                ssgrid_billdetails.Row = K
                ssgrid_billdetails.Col = 2
                per = Val(ssgrid_billdetails.Text)

                For II = 1 To Formule.Length - 1
                    For J = 2 To ssgrid_billdetails.DataRowCnt
                        ssgrid_billdetails.Col = 5
                        ssgrid_billdetails.Row = J
                        If Trim(Formule(II)) = Trim(ssgrid_billdetails.Text) Then
                            ssgrid_billdetails.Col = 4
                            Gtot = Gtot + Val(ssgrid_billdetails.Text)
                            Exit For
                        End If
                    Next J
                Next II
                Camt = ((Gtot + amt) * per) / 100
                ssgrid_billdetails.Col = 4
                ssgrid_billdetails.Row = K
                If Camt > 0 Then
                    ssgrid_billdetails.Text = Format(Val(Camt), "0.00")
                Else
                    ssgrid_billdetails.Text = 0.0
                End If
            Next K
            Call billingtermsrefresh(Activerow)

        Catch ex As Exception
            MessageBox.Show("Plz Check Error : billingtermstaxamount" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
        'end new
    End Sub
    Private Sub BillingTermsTaxPercentage(ByVal Activerow)
        'new
        Try
            Dim Sign, Formula, slno, Billdesc() As String
            Dim Formule() As Char
            Dim II, J As Integer
            Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
            Dim per As Double


            ssgrid_billdetails.Row = 1
            ssgrid_billdetails.Col = 4
            amt = Val(ssgrid_billdetails.Text)

            ssgrid_billdetails.Col = 4
            ssgrid_billdetails.Row = billrow
            ssgrid_billdetails.Text = Format(amt, "0.00")

            ssgrid_billdetails.Row = Activerow
            ssgrid_billdetails.Col = 2
            per = Val(ssgrid_billdetails.Text)
            ssgrid_billdetails.Col = 7
            Sign = ssgrid_billdetails.Text

            ssgrid_billdetails.Col = 6
            Formula = ssgrid_billdetails.Text
            Formule = Formula.ToCharArray

            Gtot = 0
            For II = 1 To Formule.Length - 1
                For J = 2 To ssgrid_billdetails.DataRowCnt
                    ssgrid_billdetails.Col = 5
                    ssgrid_billdetails.Row = J
                    If Trim(Formule(II)) = Trim(ssgrid_billdetails.Text) Then
                        ssgrid_billdetails.Col = 4
                        Gtot = Gtot + Val(ssgrid_billdetails.Text)
                        Exit For
                    End If
                Next J
            Next II


            ssgrid_billdetails.Col = 1
            ssgrid_billdetails.Row = Activerow
            Billdesc = Split(Trim(ssgrid_billdetails.Text), ":")

            sqlstring = "SELECT Tax FROM purchasebillterms WHERE Billdescription = '" & Trim(Billdesc(0)) & "'AND ISNULL(FREEZE,'N') <> 'Y' "
            gconnection.getDataSet(sqlstring, "purchasebillterms")
            If gdataset.Tables("purchasebillterms").Rows.Count > 0 Then
                If gdataset.Tables("purchasebillterms").Rows(0).Item("Tax") & "" <> "Y" Then
                    GrTot = Gtot + amt
                    ssgrid_billdetails.Row = Activerow
                    ssgrid_billdetails.Col = 2
                    If Gtot > 0 Then
                        ssgrid_billdetails.Col = 4
                        Gtot = Val(ssgrid_billdetails.Text)
                        ssgrid_billdetails.Col = 2
                        ssgrid_billdetails.Text = Format((Gtot / amt) * 100, "0.00")
                    Else
                        If GrTot > 0 Then
                            ssgrid_billdetails.Col = 4
                            Gtot = Val(ssgrid_billdetails.Text)
                            ssgrid_billdetails.Col = 2
                            ssgrid_billdetails.Text = Format((Gtot / amt) * 100, "0.00")
                        Else
                            ssgrid_billdetails.Text = 0.0
                        End If
                    End If
                    Call billingtermsrefresh(Activerow)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : BillingTermsTaxPercentage" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub ssgrid_billdetails_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid_billdetails.KeyDownEvent
        'Try
        '    Dim Taxcode, Billdesc(), Sqlstring As String

        '    Dim Sign, Formula, slno As String
        '    Dim Formule() As Char
        '    Dim II, J As Integer
        '    Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
        '    Dim per As Double
        '    If e.keyCode = Keys.Enter Or e.keyCode = Keys.Tab Then
        '        If ssgrid_billdetails.ActiveCol = 1 Then
        '            ssgrid_billdetails.Col = 1
        '            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
        '            If Trim(ssgrid_billdetails.Text) <> "" Then
        '                ssgrid_billdetails.SetActiveCell(1, ssgrid_billdetails.ActiveRow)
        '            End If
        '        ElseIf ssgrid_billdetails.ActiveCol = 2 Then
        '            ssgrid_billdetails.Col = 1
        '            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
        '            Billdesc = Split(Trim(ssgrid_billdetails.Text), ":")

        '            Sqlstring = "SELECT Tax FROM purchasebillterms WHERE Billdescription = '" & Trim(Billdesc(0)) & "'AND ISNULL(FREEZE,'N') <> 'Y' "
        '            gconnection.getDataSet(Sqlstring, "purchasebillterms")
        '            If gdataset.Tables("purchasebillterms").Rows.Count > 0 Then
        '                If gdataset.Tables("purchasebillterms").Rows(0).Item("Tax") & "" = "Y" Then
        '                    ssgrid_billdetails.Col = 2
        '                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
        '                    ssgrid_billdetails.Lock = True
        '                    ssgrid_billdetails.Text = "0.00"
        '                    ssgrid_billdetails.Col = 3
        '                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
        '                    ssgrid_billdetails.Text = ""
        '                    ssgrid_billdetails.Lock = False
        '                    ssgrid_billdetails.SetActiveCell(2, ssgrid_billdetails.ActiveRow)
        '                Else
        '                    ssgrid_billdetails.Col = 2
        '                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
        '                    If Val(ssgrid_billdetails.Text) = 0 Then
        '                        ssgrid_billdetails.Text = "0.00"
        '                        ssgrid_billdetails.Col = 4
        '                        ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
        '                        ssgrid_billdetails.Text = "0.00"
        '                        ssgrid_billdetails.Lock = False
        '                        ssgrid_billdetails.SetActiveCell(3, ssgrid_billdetails.ActiveRow)
        '                    Else
        '                        ssgrid_billdetails.Col = 4
        '                        ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
        '                        Call billingtermsrefresh(ssgrid_billdetails.ActiveRow)
        '                        ssgrid_billdetails.Lock = False
        '                        ssgrid_billdetails.SetActiveCell(3, ssgrid_billdetails.ActiveRow)
        '                    End If
        '                End If
        '                Call billingtermstaxamount(ssgrid_billdetails.ActiveRow)
        '            End If
        '        ElseIf ssgrid_billdetails.ActiveCol = 3 Then
        '            ssgrid_billdetails.Col = 1
        '            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
        '            Billdesc = Split(Trim(ssgrid_billdetails.Text), ":")
        '            Sqlstring = "SELECT Tax FROM purchasebillterms WHERE Billdescription = '" & Trim(Billdesc(0)) & "'AND ISNULL(FREEZE,'N') <> 'Y' "
        '            gconnection.getDataSet(Sqlstring, "purchasebillterms")
        '            If gdataset.Tables("purchasebillterms").Rows.Count > 0 Then
        '                If gdataset.Tables("purchasebillterms").Rows(0).Item("Tax") & "" = "Y" Then
        '                    ssgrid_billdetails.Col = 3
        '                    ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
        '                    If Trim(ssgrid_billdetails.Text) = "" Then
        '                        Call FillTaxmaster() '''---> Show Taxcode,Taxpercentage 
        '                        Exit Sub
        '                    Else
        '                        Taxcode = Trim(ssgrid.Text)
        '                        Sqlstring = "SELECT Taxcode,Taxdesc,Taxpercentage,Typeoftax,GLACCOUNTIN,GLACCOUNTDESC  FROM AccountsTaxMaster WHERE Taxcode = '" & Trim(Taxcode) & "'AND ISNULL(FREEZEFLAG,'N') <> 'Y' "
        '                        gconnection.getDataSet(Sqlstring, "AccountsTaxMaster")
        '                        If gdataset.Tables("AccountsTaxMaster").Rows.Count = 0 Then
        '                            Sqlstring = "SELECT Taxcode,Taxdesc,Taxpercentage,Typeoftax,GLACCOUNTIN,GLACCOUNTDESC  FROM AccountsTaxMaster WHERE Taxcode = '" & Trim(Taxcode) & "'AND ISNULL(FREEZEFLAG,'N') <> 'Y' "
        '                            gconnection.getDataSet(Sqlstring, "AccountsTaxMaster")
        '                        End If
        '                        If gdataset.Tables("AccountsTaxMaster").Rows.Count > 0 Then
        '                            ssgrid_billdetails.Col = 2
        '                            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
        '                            ssgrid_billdetails.Text = Trim(gdataset.Tables("AccountsTaxMaster").Rows(0).Item("Taxpercentage") & "")
        '                            ssgrid_billdetails.Col = 3
        '                            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
        '                            ssgrid_billdetails.Text = Trim(gdataset.Tables("AccountsTaxMaster").Rows(0).Item("Taxcode") & "")
        '                            ssgrid_billdetails.Col = 8
        '                            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
        '                            ssgrid_billdetails.Text = Trim(gdataset.Tables("AccountsTaxMaster").Rows(0).Item("GLACCOUNTIN") & "")
        '                            ssgrid_billdetails.Col = 9
        '                            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
        '                            ssgrid_billdetails.Text = Trim(gdataset.Tables("AccountsTaxMaster").Rows(0).Item("GLACCOUNTDESC") & "")
        '                            gdataset.Tables("AccountsTaxMaster").Dispose()
        '                        Else
        '                            Call FillTaxmaster() '''---> Show Taxcode,Taxpercentage 
        '                        End If
        '                    End If
        '                End If
        '                Call billingtermstaxamount(ssgrid_billdetails.ActiveRow)
        '            End If
        '        ElseIf ssgrid_billdetails.ActiveCol = 4 Then
        '            ssgrid_billdetails.Col = 4
        '            ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
        '            Call BillingTermsTaxPercentage(ssgrid_billdetails.ActiveRow)
        '            ssgrid_billdetails.SetActiveCell(1, ssgrid_billdetails.ActiveRow + 1)
        '        End If
        '    End If

        '    If e.keyCode = Keys.F4 Then
        '        If ssgrid_billdetails.ActiveCol = 3 Then
        '            If ssgrid_billdetails.Lock = False Then
        '                search = Nothing
        '                ssgrid.GetText(2, ssgrid.ActiveRow, search)
        '                Dim vform As New List_Operation
        '                gSQLString = "SELECT Taxcode,Taxdesc,Taxpercentage,Typeoftax,GLACCOUNTIN,GLACCOUNTDESC  FROM AccountsTaxMaster"
        '                M_WhereCondition = " WHERE  ISNULL(FREEZEFLAG,'N') <> 'Y'"
        '                vform.Field = "TAXCODE,TAXDESC"
        '                vform.vFormatstring1 = "           TAXCODE            |                  TAX DESCRIPTION         |       TAXPERCENTAGE       |   TYPE OF TAX  | GLACCOUNTIN  |  GLACCOUNTDESC  "
        '                vform.vCaption = "TAX MASTER HELP"
        '                vform.KeyPos = 0
        '                vform.KeyPos1 = 1
        '                vform.KeyPos2 = 2
        '                vform.Keypos3 = 3
        '                vform.keypos4 = 4
        '                vform.Keypos5 = 5
        '                vform.ShowDialog(Me)
        '                If Trim(vform.keyfield & "") <> "" Then
        '                    ssgrid_billdetails.SetText(3, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield & ""))
        '                    ssgrid_billdetails.SetText(2, ssgrid_billdetails.ActiveRow, Val(vform.keyfield2))
        '                    ssgrid_billdetails.SetText(8, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield4))
        '                    ssgrid_billdetails.SetText(9, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield5))
        '                    Call billingtermsrefresh(ssgrid_billdetails.ActiveRow)
        '                    ssgrid_billdetails.SetActiveCell(3, ssgrid_billdetails.ActiveRow)
        '                    Taxcode = Trim(vform.keyfield & "")
        '                Else
        '                    ssgrid_billdetails.SetActiveCell(ssgrid_billdetails.ActiveCol, ssgrid_billdetails.ActiveRow)
        '                    ssgrid_billdetails.SetText(ssgrid_billdetails.ActiveCol, ssgrid_billdetails.ActiveRow, "")
        '                    Taxcode = ""
        '                End If
        '                vform.Close()
        '                vform = Nothing
        '                Call BillingTermsTaxPercentage(ssgrid_billdetails.ActiveRow)
        '            End If
        '        End If
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : ssgrid_billdetails_KeyDownEvent " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub FillTaxmaster()
        'Try
        '    Dim ACHEAD As String
        '    search = Nothing
        '    ssgrid.GetText(2, ssgrid.ActiveRow, search)
        '    Dim vform As New List_Operation
        '    gSQLString = "SELECT Taxcode,Taxdesc,Taxpercentage,Typeoftax,GLACCOUNTIN,GLACCOUNTDESC  FROM AccountsTaxMaster"
        '    M_WhereCondition = " WHERE  ISNULL(FREEZEFLAG,'N') <> 'Y'"
        '    vform.Field = "TAXCODE,TAXDESC"
        '    vform.vFormatstring1 = "           TAXCODE       |             TAX DESCRIPTION         |    TAXPERCENTAGE       |   TYPE OF TAX  | GLACCOUNTIN  |  GLACCOUNTDESC  "
        '    vform.vCaption = "TAX MASTER HELP"
        '    vform.KeyPos = 0
        '    vform.KeyPos1 = 1
        '    vform.KeyPos2 = 2
        '    vform.Keypos3 = 3
        '    vform.keypos4 = 4
        '    vform.Keypos5 = 5
        '    vform.ShowDialog(Me)
        '    If Trim(vform.keyfield & "") <> "" Then
        '        ssgrid_billdetails.SetText(3, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield & ""))
        '        ssgrid_billdetails.SetText(2, ssgrid_billdetails.ActiveRow, Val(vform.keyfield2))
        '        ssgrid_billdetails.SetText(8, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield4))
        '        ssgrid_billdetails.SetText(9, ssgrid_billdetails.ActiveRow, Trim(vform.keyfield5))
        '        Call billingtermsrefresh(ssgrid_billdetails.ActiveRow)
        '        ssgrid_billdetails.SetActiveCell(3, ssgrid_billdetails.ActiveRow)
        '        ACHEAD = Trim(vform.keyfield & "")
        '    Else
        '        ssgrid_billdetails.SetActiveCell(ssgrid_billdetails.ActiveCol, ssgrid_billdetails.ActiveRow)
        '        ssgrid_billdetails.SetText(ssgrid_billdetails.ActiveCol, ssgrid_billdetails.ActiveRow, "")
        '        ssgrid_billdetails.SetActiveCell(2, ssgrid_billdetails.ActiveRow)
        '        ACHEAD = ""
        '    End If
        '    vform.Close()
        '    vform = Nothing
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : FillTaxmaster " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub ssgrid_billdetails_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssgrid_billdetails.LeaveCell
        Try
            Dim Taxcode, Billdesc(), Sqlstring As String
            Dim Sign, Formula, slno As String
            Dim Formule() As Char
            Dim II, J As Integer
            Dim Camt, amt, Bamt, Gramt, GrTot, Gtot As Double
            Dim per As Double
            If ssgrid_billdetails.ActiveCol = 1 Then
                ssgrid_billdetails.Col = 1
                ssgrid_billdetails.Row = ssgrid_billdetails.ActiveRow
                If Trim(ssgrid_billdetails.Text) <> "" Then
                    ssgrid_billdetails.SetActiveCell(2, ssgrid_billdetails.ActiveRow)
                Else
                    ssgrid_billdetails.SetActiveCell(2, ssgrid_billdetails.ActiveRow)
                End If
            ElseIf ssgrid_billdetails.ActiveCol = 2 Then
                Call billingtermstaxamount(ssgrid_billdetails.ActiveRow)
            ElseIf ssgrid_billdetails.ActiveCol = 3 Then
                Call billingtermsrefresh(ssgrid_billdetails.ActiveRow)
            ElseIf ssgrid_billdetails.ActiveCol >= 4 Then
                Call BillingTermsTaxPercentage(ssgrid_billdetails.ActiveRow)
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : ssgrid_billdetails_LeaveCell " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub GridLock()
        'Try
        '    Dim Row, Col As Integer
        '    ssgrid.Col = 11
        '    ssgrid.Row = ssgrid.ActiveRow
        '    For Row = 1 To 50
        '        For Col = 1 To 11
        '            ssgrid.Row = Row
        '            ssgrid.Col = Col
        '            ssgrid.Lock = True
        '        Next
        '    Next
        '    ssgrid.Row = 1
        '    For Col = 1 To 11
        '        ssgrid.Col = Col
        '        ssgrid.Lock = False
        '    Next
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : GridLock " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub GridUnLock()
        'Try
        '    Dim i, j As Integer
        '    For i = 1 To 100
        '        For j = 1 To 11
        '            ssgrid.Col = j
        '            ssgrid.Row = i
        '            ssgrid.Lock = False
        '        Next j
        '    Next i
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error :  GridUnLock" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub ssgrid_KeyDownEvent(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent)
        'Dim ItemQty, ItemAmount, Salerate, ItemRate, Highratio, Dblamount As Double
        'Dim sqlstring, Itemcode, Itemdesc As String
        'Dim focusbool As Boolean
        'Dim VaritemDesc As String
        'Dim i, j, K As Integer
        'search = Nothing
        'sqlstring = "select VENDORLINK from invsetup"
        'gconnection.getDataSet(sqlstring, "invsetup")
        'If gdataset.Tables("invsetup").Rows.Count > 0 Then
        '    VENDORLINK = gdataset.Tables("invsetup").Rows(0).Item("VENDORLINK")
        'End If
        'Try
        '    If e.keyCode = Keys.Enter Then
        '        i = ssgrid.ActiveRow
        '        If ssgrid.ActiveCol = 1 Then
        '            ssgrid.Col = 2
        '            ssgrid.Row = i
        '            VaritemDesc = Trim(ssgrid.Text)
        '            ssgrid.Col = 1
        '            ssgrid.Row = i
        '            If ssgrid.Lock = False Then
        '                If Trim(ssgrid.Text) = "" Then
        '                    Call FillMenuNew()
        '                    'Call FillMenu() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
        '                ElseIf Trim(ssgrid.Text) <> "" Then
        '                    If VaritemDesc = "" Then
        '                        Itemcode = Trim(ssgrid.Text)
        '                        ssgrid.ClearRange(1, ssgrid.ActiveRow, 17, ssgrid.ActiveRow, True)
        '                        '''****************************** $ TO fill ITEMCODE,ITEMDESC,ITEMTYPE  $ **************************************'''
        '                        'sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, ISNULL(I.BASERATE,0) AS BASERATE,"
        '                        'sqlstring = sqlstring & " ISNULL(O.CONVUOM,'') AS CONVUOM,ISNULL(O.HIGHRATIO,0) AS HIGHRATIO FROM INVENTORYITEMMASTER AS I INNER JOIN OPENINGSTOCK  AS O ON O.ITEMCODE = I.ITEMCODE "
        '                        'sqlstring = sqlstring & " WHERE I.ITEMCODE ='" & Trim(Itemcode) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'  AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' AND STORECODE='" & txt_Storecode.Text & "'"

        '                        '********* FOR RSI CLUB ****************
        '                        If VENDORLINK = "Y" Then
        '                            sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, ISNULL(I.Profitper,0) AS Profitper, ISNULL(I.CONVVALUE,0) AS CONVUOM, ISNULL(v.vendorcode,'') AS VENDORCODE,ISNULL(a.slcode,'') AS SLCODE FROM INVENTORYITEMMASTER I, inv_vendormaster v, ACCOUNTSSUBLEDGERMASTER a"
        '                            sqlstring = sqlstring & " WHERE I.ITEMCODE ='" & Trim(Itemcode) & "' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE= '" & txt_Storecode.Text & "' AND v.vendorcode = a.slcode And v.itemcode = I.itemcode AND V.VENDORCODE = '" & Trim(txt_Suppliercode.Text) & "'"
        '                        Else
        '                            sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, ISNULL(I.Profitper,0) AS Profitper, ISNULL(I.CONVVALUE,0) AS CONVUOM FROM INVENTORYITEMMASTER I"
        '                            sqlstring = sqlstring & " WHERE I.ITEMCODE ='" & Trim(Itemcode) & "' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE= '" & txt_Storecode.Text & "' "
        '                        End If
        '                        gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER")
        '                        If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count > 0 Then
        '                            ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
        '                            ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMNAME")))
        '                            ssgrid.Col = 3
        '                            ssgrid.SetText(5, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("PURCHASERATE")), "0.00"))
        '                            ssgrid.SetText(7, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("PROFITPER")))
        '                            ssgrid.SetText(12, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("CONVUOM")))
        '                            'ssgrid.SetText(13, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("HIGHRATIO")), "0.00"))
        '                            ssgrid.Col = 3
        '                            Dim SqlQuery As String
        '                            ssgrid.Row = ssgrid.ActiveRow
        '                            SqlQuery = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")) & "'  "
        '                            gconnection.getDataSet(SqlQuery, "InventoryItemUOM")
        '                            If gdataset.Tables("InventoryItemUOM").Rows.Count > 1 Then
        '                                Call FillTransUOM(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
        '                            ElseIf gdataset.Tables("InventoryItemUOM").Rows.Count = 1 Then
        '                                ssgrid.Row = ssgrid.ActiveRow
        '                                ssgrid.TypeComboBoxString = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
        '                                ssgrid.Text = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
        '                            Else
        '                                ssgrid.Row = ssgrid.ActiveRow
        '                                ssgrid.Text = Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM")))
        '                            End If
        '                            ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
        '                            ssgrid.Focus()
        '                        Else
        '                            MessageBox.Show("Specified ITEM CODE not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '                            ssgrid.SetActiveCell(0, ssgrid.ActiveRow)
        '                            ssgrid.Text = ""
        '                            ssgrid.Focus()
        '                            Exit Sub
        '                        End If
        '                    End If
        '                End If
        '            Else
        '                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
        '            End If
        '        ElseIf ssgrid.ActiveCol = 2 Then
        '            ssgrid.Col = 2
        '            ssgrid.Row = i
        '            If ssgrid.Lock = False Then
        '                If Trim(ssgrid.Text) = "" Then
        '                    Call FillMenuItemNew() ''' IT WILL SHOW A POPUP MENU FOR ITEM CODE
        '                Else
        '                    ssgrid.Col = 4
        '                    ssgrid.Row = i
        '                    If Trim(ssgrid.Text) = "" Then
        '                        Itemdesc = Trim(ssgrid.Text)
        '                        ssgrid.ClearRange(1, ssgrid.ActiveRow, 17, ssgrid.ActiveRow, True)
        '                        '''****************************** $ TO fill ITEMCODE,ITEMDESC  $ **************************************'''
        '                        'sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE, "
        '                        'sqlstring = sqlstring & " ISNULL(O.CONVUOM,'') AS CONVUOM,ISNULL(O.HIGHRATIO,0) AS HIGHRATIO FROM INVENTORYITEMMASTER AS I INNER JOIN OPENINGSTOCK  AS O ON O.ITEMCODE = I.ITEMCODE "
        '                        'sqlstring = sqlstring & " WHERE I.ITEMNAME ='" & Trim(Itemdesc) & "'  AND ISNULL(I.FREEZE,'') <> 'Y'  AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "'"


        '                        '********* FOR RSI CLUB ****************
        '                        If VENDORLINK = "Y" Then
        '                            sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE,ISNULL(I.PROFITPER,0) AS PROFITPER, ISNULL(I.CONVVALUE,0) AS CONVUOM, ISNULL(v.vendorcode,'') AS VENDORCODE,ISNULL(a.slcode,'') AS SLCODE FROM INVENTORYITEMMASTER I, inv_vendormaster v, ACCOUNTSSUBLEDGERMASTER a"
        '                            sqlstring = sqlstring & " WHERE I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE= '" & txt_Storecode.Text & "' AND v.vendorcode = a.slcode And v.itemcode = I.itemcode AND V.VENDORCODE = '" & Trim(txt_Suppliercode.Text) & "'"
        '                        Else
        '                            sqlstring = " SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME,ISNULL(I.STOCKUOM,'') AS STOCKUOM,ISNULL(I.PURCHASERATE,0) AS PURCHASERATE,ISNULL(I.PROFITPER,0) AS PROFITPER, ISNULL(I.CONVVALUE,0) AS CONVUOM FROM INVENTORYITEMMASTER I"
        '                            sqlstring = sqlstring & " WHERE I.ITEMCODE LIKE '" & Trim(search) & "%' AND ISNULL(I.FREEZE,'') <> 'Y' AND CATEGORY = '" & Trim(CMB_CATEGORY.Text) & "' and  I.STORECODE= '" & txt_Storecode.Text & "' "
        '                        End If
        '                        gconnection.getDataSet(sqlstring, "inventoryitemMaster")
        '                        If gdataset.Tables("inventoryitemMaster").Rows.Count > 0 Then
        '                            ssgrid.SetText(1, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE")))
        '                            ssgrid.SetText(2, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMNAME")))
        '                            ssgrid.Col = 3
        '                            ssgrid.SetText(5, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("PURCHASERATE")), "0.00"))
        '                            ssgrid.SetText(7, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("PROFITPER")))
        '                            ssgrid.SetText(12, i, Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("CONVUOM")))
        '                            'ssgrid.SetText(13, i, Format(Val(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("HIGHRATIO")), "0.00"))
        '                            Dim sqlQuery As String
        '                            sqlQuery = "SELECT ISNULL(Tranuom,'') AS Tranuom  FROM  INVITEM_TRANSUOM_LINK  WHERE Itemcode ='" & Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE"))) & "'   "
        '                            gconnection.getDataSet(sqlQuery, "InventoryItemUOM")
        '                            If gdataset.Tables("InventoryItemUOM").Rows.Count > 1 Then
        '                                Call FillTransUOM(Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("ITEMCODE"))))
        '                            ElseIf gdataset.Tables("InventoryItemUOM").Rows.Count = 1 Then
        '                                ssgrid.Row = ssgrid.ActiveRow
        '                                ssgrid.TypeComboBoxString = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
        '                                ssgrid.Text = Trim(gdataset.Tables("InventoryItemUOM").Rows(0).Item("Tranuom"))
        '                            Else
        '                                ssgrid.Row = ssgrid.ActiveRow
        '                                ssgrid.Text = Trim(Trim(Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(j).Item("STOCKUOM"))))
        '                            End If
        '                            ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
        '                            ssgrid.Focus()
        '                        Else
        '                            MessageBox.Show("Specified ITEM DESCRIPTION not found", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '                            ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
        '                            ssgrid.Text = ""
        '                            ssgrid.Focus()
        '                            Exit Sub
        '                        End If
        '                    End If
        '                End If
        '            End If
        '        ElseIf ssgrid.ActiveCol = 3 Then
        '            ssgrid.Col = 3
        '            ssgrid.Row = i
        '            If ssgrid.Lock = False Then
        '                If Trim(ssgrid.Text) = "" Then
        '                    ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
        '                Else
        '                    ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
        '                End If
        '            End If
        '        ElseIf ssgrid.ActiveCol = 4 Then
        '            ssgrid.Col = 4
        '            ssgrid.Row = i
        '            ItemQty = Val(ssgrid.Text)
        '            If ssgrid.Lock = False Then
        '                If ssgrid.Lock = False Then
        '                    If Val(ssgrid.Text) = 0 Then
        '                        ssgrid.SetActiveCell(3, ssgrid.ActiveRow)
        '                    Else
        '                        Call Calculate() '''--> Calculate total amount
        '                        ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
        '                        ssgrid.Focus()
        '                    End If
        '                End If
        '            Else
        '                ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
        '            End If
        '        ElseIf ssgrid.ActiveCol = 5 Then
        '            ssgrid.Col = 5
        '            ssgrid.Row = i
        '            If ssgrid.Lock = False Then
        '                If Val(ssgrid.Text) = 0 Then
        '                    ssgrid.SetActiveCell(4, ssgrid.ActiveRow)
        '                Else
        '                    Call Calculate() '''--> Calculate total amount
        '                    ssgrid.SetActiveCell(5, ssgrid.ActiveRow)
        '                    ssgrid.Focus()
        '                End If
        '            End If
        '        ElseIf ssgrid.ActiveCol = 6 Then
        '            ssgrid.Col = 6
        '            ssgrid.Row = i
        '            Call Calculate() '''--> Calculate total amount
        '            ssgrid.SetActiveCell(6, ssgrid.ActiveRow)
        '            ssgrid.Focus()
        '        ElseIf ssgrid.ActiveCol = 7 Then
        '            ssgrid.Col = 7
        '            ssgrid.Row = i
        '            'Call Calculate() '''--> Calculate total amount
        '            ssgrid.SetActiveCell(7, ssgrid.ActiveRow)
        '            ssgrid.Focus()
        '        ElseIf ssgrid.ActiveCol = 8 Then
        '            ssgrid.Col = 8
        '            ssgrid.Row = i
        '            Call Calculate() '''--> Calculate total amount
        '            ssgrid.SetActiveCell(8, ssgrid.ActiveRow)
        '            ssgrid.Focus()

        '        ElseIf ssgrid.ActiveCol = 9 Then
        '            ssgrid.Col = 9
        '            ssgrid.Row = i
        '            If ssgrid.Lock = False Then
        '                If Val(ssgrid.Text) = 0 Then
        '                    Call Calculate() '''--> Calculate total amount
        '                    ssgrid.Col = 9
        '                    ssgrid.Row = ssgrid.ActiveRow
        '                    ssgrid.Text = "0.00"
        '                    ssgrid.Row = ssgrid.ActiveRow + 1
        '                    ssgrid.Col = 1
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 2
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 3
        '                    If Mid(Cmd_Add.Text, 1, 1) = "A" Then
        '                        ssgrid.Lock = False
        '                    Else
        '                        If ssgrid.Lock = False Then
        '                            ssgrid.Lock = False
        '                        End If
        '                    End If
        '                    ssgrid.Col = 4
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 5
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 6
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 7
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 8
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 9
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 10
        '                    ssgrid.Lock = False
        '                    ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
        '                Else
        '                    Call Calculate() '''--> Calculate total amount
        '                    If Mid(Cmd_Add.Text, 1, 1) = "A" Then
        '                        ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
        '                    Else
        '                        ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
        '                    End If
        '                    'ssgrid.Row = ssgrid.ActiveRow + 1
        '                    ssgrid.Col = 1
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 2
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 3
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 4
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 5
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 6
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 7
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 8
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 9
        '                    ssgrid.Lock = False
        '                    ssgrid.Col = 10
        '                    ssgrid.Lock = False
        '                    ssgrid.SetActiveCell(11, ssgrid.ActiveRow)

        '                End If
        '            End If
        '        ElseIf ssgrid.ActiveCol = 10 Then
        '            ssgrid.Col = 10
        '            ssgrid.Row = i
        '            ItemAmount = Val(ssgrid.Text)
        '            If ssgrid.Lock = False Then
        '                If Trim(ssgrid.Text) = "" Then
        '                    ssgrid.SetActiveCell(9, ssgrid.ActiveRow)
        '                Else
        '                    ssgrid.Col = 4
        '                    ItemQty = Val(ssgrid.Text)
        '                    ItemRate = Val(ItemAmount) / Val(ItemQty)
        '                    ssgrid.SetText(5, ssgrid.ActiveRow, ItemRate)
        '                    ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
        '                End If
        '            End If
        '        ElseIf ssgrid.ActiveCol = 11 Then
        '            '''ssgrid.Col = 11
        '            '''ssgrid.Row = i
        '            ''''If ssgrid.Text < Val(tmpsalrate) - 1 Or ssgrid.Text > Val(tmpsalrate) + 1 Then
        '            '''' MsgBox("Round off Rate should be With in +/- Rs.1")
        '            ''''  Else
        '            '''If ssgrid.Lock = False Then
        '            '''    If Val(ssgrid.Text) = 0 Then
        '            '''        ssgrid.SetActiveCell(10, ssgrid.ActiveRow)
        '            '''    Else
        '            '''        'Call Calculate() '''--> Calculate total amount
        '            '''        Call Calculate1()
        '            '''        ssgrid.SetActiveCell(18, ssgrid.ActiveRow)
        '            '''        ssgrid.Lock = True
        '            '''        ssgrid.Focus()
        '            '''    End If
        '            '''End If
        '            '''' End If

        '            'UPTO FREE QUANTITY --***VENUJD

        '            ssgrid.Col = 11
        '            ssgrid.Row = i
        '            'If ssgrid.Text < Val(tmpsalrate) - 1 Or ssgrid.Text > Val(tmpsalrate) + 1 Then
        '            ' MsgBox("Round off Rate should be With in +/- Rs.1")
        '            '  Else
        '            If ssgrid.Lock = False Then
        '                'If Val(ssgrid.Text) = 0 Then
        '                '    ssgrid.SetActiveCell(11, ssgrid.ActiveRow)
        '                'Else
        '                'Call Calculate() '''--> Calculate total amount
        '                Call Calculate1()
        '                ssgrid.SetActiveCell(18, ssgrid.ActiveRow)
        '                ssgrid.Lock = True
        '                ssgrid.Focus()
        '                'End If
        '            End If
        '            ' End If
        '        ElseIf ssgrid.ActiveCol = 12 Then
        '            ssgrid.Col = 11
        '            ssgrid.Row = i
        '            If ssgrid.Lock = False Then
        '                If Trim(ssgrid.Text) = "" Then
        '                    ssgrid.SetActiveCell(10, ssgrid.ActiveRow)
        '                Else
        '                    ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
        '                End If
        '            End If
        '        ElseIf ssgrid.ActiveCol = 13 Then
        '            ssgrid.Col = 13
        '            ssgrid.Row = i
        '            If ssgrid.Lock = False Then
        '                If Trim(ssgrid.Text) = "" Then
        '                    ssgrid.SetActiveCell(12, ssgrid.ActiveRow)
        '                Else
        '                    ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
        '                End If
        '            End If
        '        ElseIf ssgrid.ActiveCol = 14 Then
        '            ssgrid.Col = 3
        '            ssgrid.Row = i
        '            If ssgrid.Lock = False Then
        '                If Val(ssgrid.Text) = 0 Then
        '                    ssgrid.SetActiveCell(13, ssgrid.ActiveRow)
        '                Else
        '                    ssgrid.SetActiveCell(0, ssgrid.ActiveRow + 1)
        '                End If
        '            End If
        '        ElseIf ssgrid.ActiveCol = 18 Then
        '            ssgrid.Col = 18
        '            ssgrid.Row = i
        '            If ssgrid.Lock = False Then
        '                'If Trim(ssgrid.Text) = "" Then
        '                ssgrid.SetActiveCell(18, ssgrid.ActiveRow)
        '                ' Else
        '                'ssgrid.SetActiveCell(0.5, ssgrid.ActiveRow + 1)
        '                ' End If
        '            End If
        '            ssgrid.SetActiveCell(19, ssgrid.ActiveRow)
        '        End If
        '    ElseIf e.keyCode = Keys.F4 Then
        '        If ssgrid.ActiveCol = 1 Then
        '            ssgrid.Col = 1
        '            ssgrid.Row = i
        '            If ssgrid.Lock = False Then
        '                ssgrid.Col = 1
        '                ssgrid.Row = ssgrid.ActiveRow
        '                search = Trim(ssgrid.Text)
        '                Call FillMenu()
        '            End If
        '        ElseIf ssgrid.ActiveCol = 2 Then
        '            ssgrid.Col = 2
        '            ssgrid.Row = i
        '            If ssgrid.Lock = False Then
        '                ssgrid.Col = 2
        '                ssgrid.Row = ssgrid.ActiveRow
        '                search = Trim(ssgrid.Text)
        '                Call FillMenuItem()
        '            End If
        '        End If
        '    ElseIf e.keyCode = Keys.F3 Then
        '        ssgrid.Col = ssgrid.ActiveCol
        '        ssgrid.Row = i
        '        ssgrid.Row = ssgrid.ActiveRow
        '        'ssgrid.ClearRange(1, ssgrid.ActiveRow, 19, ssgrid.ActiveRow, True)
        '        ssgrid.DeleteRows(ssgrid.ActiveRow, 1)
        '        Call Calculate()
        '        ssgrid.ClearRange(1, ssgrid.ActiveRow, 19, ssgrid.ActiveRow, True)
        '        ssgrid.Row = ssgrid.ActiveRow
        '        ssgrid.Col = 1
        '        ssgrid.Lock = False
        '        ssgrid.Col = 2
        '        ssgrid.Lock = False
        '        ssgrid.Col = 3
        '        ssgrid.Lock = False
        '        ssgrid.Col = 4
        '        ssgrid.Lock = False
        '        ssgrid.Col = 5
        '        ssgrid.Lock = False
        '        ssgrid.Col = 6
        '        ssgrid.Lock = False
        '        ssgrid.Col = 7
        '        ssgrid.Lock = False
        '        ssgrid.Col = 8
        '        ssgrid.Lock = False
        '        ssgrid.Col = 9
        '        ssgrid.Lock = False
        '        ssgrid.Col = 10
        '        ssgrid.Lock = False
        '        ssgrid.Col = 11
        '        ssgrid.Lock = False
        '        ssgrid.Col = 12
        '        ssgrid.Lock = False
        '        ssgrid.Col = 13
        '        ssgrid.Lock = False
        '        ssgrid.Col = 14
        '        ssgrid.Lock = False
        '        ssgrid.Col = 15
        '        ssgrid.Lock = False
        '        ssgrid.Col = 16
        '        ssgrid.Lock = False
        '        ssgrid.Col = 17
        '        ssgrid.Lock = False

        '        ssgrid.SetActiveCell(1, ssgrid.ActiveRow)
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : ssgrid_KeyDownEvent " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Vatamount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_Vatamount_TextChanged " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Vatamount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Try
        '    Call getNumeric(e)
        '    If Asc(e.KeyChar) = 13 Then
        '        txt_Surchargeamt.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Vatamount_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Surchargeamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'Try
        '    Call getNumeric(e)
        '    If Asc(e.KeyChar) = 13 Then
        '        TXT_OVERALLdiscount.Focus()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Surchargeamt_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Discountamt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            Call getNumeric(e)
            If Asc(e.KeyChar) = 13 Then
                Cmd_Add.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_Discountamt_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Surchargeamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If Val(txt_Surchargeamt.Text) <> 0 Then
        '        txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Surchargeamt_TextChanged" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub txt_Discountamt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If Val(txt_Discountamt.Text) <> 0 Then
        '        txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Discountamt_TextChanged" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Vatamount_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    txt_Vatamount.Text = Format(Val(txt_Vatamount.Text), "0.00")
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Vatamount_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub txt_Surchargeamt_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    txt_Surchargeamt.Text = Format(Val(txt_Surchargeamt.Text), "0.00")
        '    If Val(txt_Surchargeamt.Text) <> 0 Then
        '        txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_Surchargeamt_LostFocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub PO_WorkOrderIndent_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        'Try
        '    GRNCumPurchaseBillTransbool = False
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : PO_WorkOrderIndent_Closed" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
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
            MessageBox.Show("Plz Check Error : txt_FromDocno_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
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
            MessageBox.Show("Plz Check Error : txt_ToDocno_KeyDown" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_FromDocno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_FromDocno.Validated
        If Trim(txt_FromDocno.Text) <> "" Then
            Try
                sqlstring = "SELECT  ISNULL(GRNNO,'') AS GRNNO,ISNULL(GRNDETAILS,'') AS GRNDETAILS"
                sqlstring = sqlstring & " FROM GRN_HEADER WHERE GRNNO = '" & Format(Val(txt_FromDocno.Text), "0000") & "' OR GRNDETAILS='" & Trim(txt_FromDocno.Text) & "'"
                gconnection.getDataSet(sqlstring, "GRNHEADER")
                If gdataset.Tables("GRNHEADER").Rows.Count > 0 Then
                    Me.txt_FromDocno.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("GRNDETAILS"))
                    Me.txt_FromDocno.ReadOnly = True
                End If
            Catch
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txt_ToDocno_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ToDocno.Validated
        If Trim(txt_ToDocno.Text) <> "" Then
            Try
                sqlstring = "SELECT  ISNULL(GRNNO,'') AS GRNNO,ISNULL(GRNDETAILS,'') AS GRNDETAILS"
                sqlstring = sqlstring & " FROM GRN_HEADER WHERE GRNNO = '" & Format(Val(txt_ToDocno.Text), "0000") & "' OR GRNDETAILS='" & Trim(txt_ToDocno.Text) & "'"
                gconnection.getDataSet(sqlstring, "GRNHEADER")
                If gdataset.Tables("GRNHEADER").Rows.Count > 0 Then
                    Me.txt_ToDocno.Text = Trim(gdataset.Tables("GRNHEADER").Rows(0).Item("GRNDETAILS"))
                    Me.txt_ToDocno.ReadOnly = True
                End If
            Catch
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub CMB_CATEGORY_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Call FOOTER()
        '    If Cmd_Add.Text = "Add [F7]" Then
        '        doctype = Trim(CMB_CATEGORY.Text)
        '        Call autogenerate()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub cmd_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_print.Click
        'Try
        '    gPrint = True
        '    'Call printoperation()
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
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : cmd_print_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try

        Try
            ' If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
            Dim rViewer As New Viewer
            Dim sqlstring, SSQL As String
            Dim r As New Crys_wo_indent
            'sqlstring = "SELECT ISNULL(PONO,'') AS PONO, ISNULL(GRNDETAILS,'') AS GRNDETAILS,GRNDATE, ISNULL(SUPPLIERCODE,'') AS SUPPLIERCODE, ISNULL(SUPPLIERNAME,'') AS SUPPLIERNAME,"
            'sqlstring = sqlstring & " ISNULL(SUPPLIERINVNO,'') AS SUPPLIERINVNO,  ISNULL(EXCISEPASSNO,'') AS EXCISEPASSNO,ISNULL(GLACCOUNTCODE,'') AS GLACCOUNTCODE,ISNULL(GLACCOUNTNAME,'') AS GLACCOUNTNAME,"
            'sqlstring = sqlstring & " ISNULL(TOTALAMOUNT,0) AS TOTALAMOUNT,ISNULL(VATAMOUNT,0) AS VATAMOUNT,ISNULL(SURCHARGEAMT,0) AS SURCHARGEAMT,ISNULL(DISCOUNT,0) AS DISCOUNT,ISNULL(BILLAMOUNT,0) AS BILLAMOUNT,"
            'sqlstring = sqlstring & " ISNULL(ITEMCODE,'') AS ITEMCODE, ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM, ISNULL(QTY,0) AS QTY, ISNULL(RATE,0) AS RATE,ISNULL(REMARKS,'') AS REMARKS, "
            'sqlstring = sqlstring & " ISNULL(AMOUNT,0) AS AMOUNT,isnull(discount,0) as ddiscount,isnull(taxper,0) as taxper,isnull(taxamount,0) as taxamount, isnull(OverallDiscount,0) OverallDiscount,ISNULL(UPDFOOTER,'') AS UPDFOOTER,ISNULL(UPDNAME,'') AS UPDNAME "
            'sqlstring = sqlstring & " FROM VW_INV_GRNBILL "
            'sqlstring = sqlstring & " WHERE GRNDETAILS BETWEEN '" & Trim(txt_Indentno.Text) & "' AND '" & Trim(txt_Grnno.Text) & "'"
            'sqlstring = sqlstring & " ORDER BY AUTOID ,GRNDETAILS,GRNDATE"
            sqlstring = "select * from PO_WORKINDENT where INDENT_NO = '" & txt_Indentno.Text & "'"
            gconnection.getDataSet(sqlstring, "VW_INV_GRNBILL")
            If gdataset.Tables("VW_INV_GRNBILL").Rows.Count > 0 Then
                rViewer.ssql = sqlstring
                rViewer.Report = r
                rViewer.TableName = "VW_INV_GRNBILL"
                Dim textobj1 As TextObject
                textobj1 = r.ReportDefinition.ReportObjects("Text4")
                textobj1.Text = MyCompanyName

                Dim textobj2 As TextObject
                textobj2 = r.ReportDefinition.ReportObjects("Text10")
                textobj2.Text = gUsername

                Dim t1 As TextObject
                t1 = r.ReportDefinition.ReportObjects("Text5")
                t1.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode
                Dim t2 As TextObject
                t2 = r.ReportDefinition.ReportObjects("Text6")
                t2.Text = "Tel:" & GPHONE & ",40090019, Fax:" & gFax & ", Email:pur@kga.in" & ", Web:" & gWebsite
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
    Private Sub CMB_CATEGORY_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Try
        '    If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
        '        Call autogenerate()
        '        'dtp_Grndate.Focus()
        '        If gpocode = "Y" Then
        '            Txt_PONo.Enabled = True
        '            cmd_PONOhelp.Enabled = True
        '            Txt_PONo.Focus()
        '        Else
        '            txt_Grnno.Focus()
        '            Txt_PONo.Enabled = False
        '            cmd_PONOhelp.Enabled = False
        '        End If
        '        'Txt_PONo.Focus()
        '        CMB_CATEGORY.Enabled = False
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : CMB_CATEGORY_KeyDown " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub Cmd_Storecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'gSQLString = "SELECT DISTINCT(storecode),storedesc FROM storemaster "
        'M_WhereCondition = " where freeze <> 'Y' "
        'Dim vform As New ListOperattion1
        'vform.Field = "STOREDESC,STORECODE"
        'vform.vFormatstring = "         STORE CODE              |                  STORE DESCRIPTION                                                                                                   "
        'vform.vCaption = "INVENTORY STORE MASTER HELP"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1
        'vform.ShowDialog(Me)
        'If Trim(vform.keyfield & "") <> "" Then
        '    txt_Storecode.Text = Trim(vform.keyfield & "")
        '    txt_StoreDesc.Text = Trim(vform.keyfield1 & "")
        '    'Txt_GLAcIn.Focus()
        '    ssgrid.Focus()
        'End If
        'vform.Close()
        'vform = Nothing
    End Sub
    Private Sub txt_Storecode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim I, J, K As Integer
        'Dim vString, sqlstring, Strsql1 As String
        'Dim GRNDATE As Date
        'Dim vTypeseqno, Clsquantity As Double
        'Dim vGroupseqno As Double
        'Dim dt As New DataTable
        'Try
        '    J = 0
        '    If Mid(CStr(Cmd_Add.Text), 1, 1) = "U" Then
        '        Strsql1 = "Select Storecode from Grn_Header  WHERE  GRNDETAILS ='" & Trim(txt_Grnno.Text) & "'"
        '        gconnection.getDataSet(Strsql1, "StrDetails")
        '        If gdataset.Tables("StrDetails").Rows.Count > 0 Then
        '            If Trim(txt_Storecode.Text) = Trim(gdataset.Tables("StrDetails").Rows(J).Item("StoreCode")) Then
        '                sqlstring = "SELECT * FROM storemaster WHERE storecode='" & Trim(txt_Storecode.Text) & "'"
        '                gconnection.getDataSet(sqlstring, "storemaster")
        '                If gdataset.Tables("storemaster").Rows.Count > 0 Then
        '                    txt_Storecode.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storecode"))
        '                    txt_StoreDesc.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storedesc"))
        '                End If
        '            Else
        '                sqlstring = "SELECT * FROM storemaster WHERE storecode='" & Trim(txt_Storecode.Text) & "'"
        '                gconnection.getDataSet(sqlstring, "storemaster")
        '                If gdataset.Tables("storemaster").Rows.Count > 0 Then
        '                    txt_StoreDesc.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storedesc"))
        '                End If
        '                Dim vtmpitemcode, strsql, OldStore As String
        '                OldStore = Trim(gdataset.Tables("StrDetails").Rows(J).Item("StoreCode"))
        '                sqlstring = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(UOM,'') AS UOM,"
        '                sqlstring = sqlstring & " ISNULL(QTY,0) AS QTY,ISNULL(RATE,0) AS RATE,ISNULL(DISCOUNT,0) AS DISCOUNT,ISNULL(TAXPER,0) AS TAXPER,ISNULL(TAXAMOUNT,0) AS TAXAMOUNT,ISNULL(AMOUNT,0) AS AMOUNT,ISNULL(CATEGORY,'')AS CATEGORY,"
        '                sqlstring = sqlstring & " ISNULL(DBLAMOUNT,0) AS DBLAMOUNT,ISNULL(DBLUOM,'') AS DBLUOM,ISNULL(HIGHRATIO,0) AS HIGHRATIO,ISNULL(VOIDITEM,'') AS VOIDITEM , isnull(OTHCHARGE,0) AS OTHCHARGE FROM GRN_DETAILS WHERE  GRNDETAILS ='" & Trim(txt_Grnno.Text) & "'"
        '                sqlstring = sqlstring & " ORDER BY AUTOID "
        '                gconnection.getDataSet(sqlstring, "GRNDETAILS")
        '                If gdataset.Tables("GRNDETAILS").Rows.Count > 0 Then
        '                    For I = 1 To gdataset.Tables("GRNDETAILS").Rows.Count
        '                        vtmpitemcode = Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("ITEMCODE"))
        '                        GRNDATE = Format(CDate(dtp_Grndate.Value), "dd-MMM-yyyy")
        '                        Clsquantity = ClosingQuantity_Date(vtmpitemcode, OldStore, Trim(gdataset.Tables("GRNDETAILS").Rows(J).Item("UOM")), GRNDATE)
        '                        If Val(Clsquantity) - Val(gdataset.Tables("GRNDETAILS").Rows(J).Item("Qty")) < 0 Then
        '                            MsgBox("Sorry!There is Negative Stock for ItemCode :  " & UCase(vtmpitemcode) & "   If Changing Store  ")
        '                            Cmd_Clear_Click(sender, e)
        '                        End If
        '                        J = J + 1
        '                    Next
        '                End If
        '            End If
        '        End If
        '    Else
        '        If Trim(txt_Storecode.Text) <> "" Then
        '            sqlstring = "SELECT * FROM storemaster WHERE storecode='" & Trim(txt_Storecode.Text) & "'"
        '            gconnection.getDataSet(sqlstring, "storemaster")
        '            If gdataset.Tables("storemaster").Rows.Count > 0 Then
        '                txt_Storecode.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storecode"))
        '                txt_StoreDesc.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storedesc"))
        '                Txt_GLAcIn.Focus()
        '            End If
        '        End If
        '    End If

        'Catch
        '    MessageBox.Show("Check The Error", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub txt_Storecode_KeyPress1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Asc(e.KeyChar) = 13 Then
        '    If Trim(txt_Storecode.Text) = "" Then
        '        Call Cmd_Storecode_Click(Cmd_Storecode, e)
        '    Else
        '        Call txt_Storecode_Validated(sender, e)
        '        ssgrid.Focus()
        '        '  Txt_GLAcIn.Focus()
        '    End If
        'End If
    End Sub
    Private Sub txt_Storecode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.F4 Then
        '    If Cmd_Storecode.Enabled = True Then
        '        Call Cmd_Storecode_Click(Cmd_Storecode, e)
        '    End If
        'End If
    End Sub

    Private Sub cmd_PONOhelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'gSQLString = "SELECT ISNULL(pono,'') AS PONO,ISNULL(podate,'')AS PODATE,ISNULL(podepartment,'') AS PODEPARTMENT FROM PO_HDR"
        'M_WhereCondition = " WHERE FREEZE <> 'Y' "
        'Dim vform As New List_Operation
        'vform.Field = "PONO,PODATE,PODEPARTMENT"
        'vform.vFormatstring1 = "         PONO            |        PODATE         |        PODEPARTMENT                                   "
        'vform.vCaption = "PURCHASE MASTER HELP"
        'vform.KeyPos = 0
        'vform.KeyPos1 = 1
        'vform.ShowDialog(Me)

        'If Trim(vform.keyfield & "") <> "" Then
        '    Txt_PONo.Text = Trim(vform.keyfield & "")
        '    gSQLString = "select * from grn_header where pono = '" & Trim(Txt_PONo.Text) & "'"
        '    gconnection.getDataSet(gSQLString, "GrnHdr")
        '    If gdataset.Tables("GrnHdr").Rows.Count > 0 Then
        '        Txt_PONo.Text = Trim(gdataset.Tables("GrnHdr").Rows(0).Item("pono"))
        '        txt_Grnno.Text = Trim(gdataset.Tables("GrnHdr").Rows(0).Item("grndetails"))
        '        Call txt_Grnno_Validated(txt_Grnno.Text, e)
        '        txt_Grnno.Focus()
        '    Else
        '        Call Txt_PONo_Validated(Txt_PONo.Text, e)
        '        Call Calculate()
        '    End If
        'End If
        ''Call Grid_lock()
        'vform.Close()
        'vform = Nothing
        ''txt_PONo.Focus()
        'Cmd_Freeze.Enabled = True
    End Sub
    Private Sub Txt_PONo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim strsql As String
        'Dim totAmt, Discnt, itemRate, itemQty, tempDisc As Double
        'Dim sqlstring, financalyear As String
        'Dim voucherno As String
        'Dim CreditDebit As String
        'Dim i, j As Integer
        'Dim amount As Double
        'Dim accounthead, slhead, costhead As String

        'PoNumber = Nothing

        'If Trim(Me.Txt_PONo.Text) <> "" Then
        '    financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialyearEnd, 3, 4)
        '    If Val(Me.Txt_PONo.Text) > 0 Then
        '        Me.Txt_PONo.Text = doctype & "/" & Format(Val(Me.Txt_PONo.Text), "000000") & "/" & financalyear
        '    End If
        '    PoNumber = Trim(Me.Txt_PONo.Text)
        'End If

        'strsql = " select * from grn_header where pono = '" & Trim(Me.Txt_PONo.Text) & "' "
        'gconnection.getDataSet(strsql, "grnhdrchk")
        'If gdataset.Tables("grnhdrchk").Rows.Count > 0 Then
        '    Me.txt_Grnno.Text = Trim(gdataset.Tables("grnhdrchk").Rows(0).Item("grndetails"))
        '    Call txt_Grnno_Validated(txt_Grnno.Text, e)
        '    txt_Grnno.Focus()
        'ElseIf Trim(Txt_PONo.Text) <> "" Then
        '    strsql = "SELECT * FROM PO_HDR WHERE pono='" & Trim(Txt_PONo.Text) & "'"
        '    strsql = strsql & " AND FREEZE <> 'Y' "
        '    gconnection.getDataSet(strsql, "PO_HDR")
        '    If gdataset.Tables("PO_HDR").Rows.Count > 0 Then
        '        Txt_PONo.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PONO"))
        '        txt_Remarks.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POremarks"))
        '        'Cbo_PODate.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PODATE"))

        '        strsql = " SELECT * FROM STOREMASTER WHERE STOREDESC = '" & Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PODepartment")) & "'"
        '        gconnection.getDataSet(strsql, "STORECOD")
        '        If gdataset.Tables("storecod").Rows.Count > 0 Then
        '            txt_Storecode.Text = Trim(gdataset.Tables("storecod").Rows(0).Item("storecode"))
        '            txt_StoreDesc.Text = Trim(gdataset.Tables("storecod").Rows(0).Item("storedesc"))
        '        End If
        '        txt_Supplierinvno.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POquotno"))
        '        txt_Suppliercode.Text = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("povendorcode"))

        '        strsql = "SELECT ISNULL(VENDORCODE,0) AS VENDORCODE, ISNULL(VENDORNAME,'') AS VENDORNAME FROM PO_VIEW_VENDORMASTER WHERE VENDORCODE = '" & Trim(txt_Suppliercode.Text) & "' "
        '        gconnection.getDataSet(strsql, "accountssubledgermaster")
        '        txt_Suppliername.Text = Trim(gdataset.Tables("accountssubledgermaster").Rows(0).Item("vendorname"))
        '        Txt_PONo.ReadOnly = True
        '        If gdataset.Tables("PO_HDR").Rows(0).Item("Freeze") = "Y" Then
        '            Me.lbl_Freeze.Visible = True
        '            Me.lbl_Freeze.Text = ""
        '            Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("PO_HDR").Rows(0).Item("AddDatetime")), "dd-MMM-yyyy")
        '            Me.Cmd_Freeze.Text = "UnFreeze[F8]"
        '        Else
        '            Me.lbl_Freeze.Visible = False
        '            Me.lbl_Freeze.Text = "Record Freezed  On "
        '            Me.Cmd_Freeze.Text = "Freeze[F8]"
        '        End If
        '        'Me.Cmd_Add.Text = "Update[F7]"

        '        '----------------------ITEMDETAILS RETRIEVE----------------------------
        '        strsql = "SELECT * FROM PO_ITEMDETAILS WHERE pono='" & Trim(Txt_PONo.Text) & "' ORDER BY AUTOID "
        '        gconnection.getDataSet(strsql, "PO_ITEMDETAILS")
        '        If gdataset.Tables("PO_ITEMDETAILS").Rows.Count > 0 Then
        '            Dim count, temp, tcode As String
        '            For i = 0 To gdataset.Tables("PO_ITEMDETAILS").Rows.Count - 1
        '                tcode = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("itemcode")
        '                'LIN
        '                strsql = "SELECT itemcode,itemname,STOCKuom FROM PO_VIEW_ITEMMASTER "
        '                strsql = strsql & "WHERE itemcode='" & Trim(tcode) & "' "
        '                gconnection.getDataSet(strsql, "inventoryitemmaster")
        '                count = gdataset.Tables("PO_ITEMDETAILS").Rows.Count
        '                With ssgrid
        '                    .Row = i + 1
        '                    .Col = 1
        '                    .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("itemcode")

        '                    .Col = 2
        '                    .Text = gdataset.Tables("inventoryitemmaster").Rows(0).Item("itemname")

        '                    .Col = 3
        '                    .Text = gdataset.Tables("inventoryitemmaster").Rows(0).Item("STOCKUOM")

        '                    .Col = 4
        '                    .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("quantity")
        '                    itemQty = .Text

        '                    .Col = 5
        '                    .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("rate")
        '                    .CellType = FPSpreadADO.CellTypeConstants.CellTypeFloat
        '                    itemRate = .Text

        '                    .Col = 6
        '                    .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("DISCAMT")
        '                    Discnt = Discnt + .Text

        '                    '.Col = 7
        '                    '.Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("vat")
        '                    .Col = 8
        '                    .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("vat")

        '                    .Col = 10
        '                    .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("total")
        '                    totAmt = totAmt + gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("AMOUNT")
        '                    .Col = 9
        '                    .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("VATAMT")
        '                    .Col = 10
        '                    .Text = gdataset.Tables("PO_ITEMDETAILS").Rows(i).Item("AMOUNT")
        '                End With
        '            Next
        '            txt_Discountamt.Text = Format(Val(Discnt), "0.00") ' + Val(Trim(gdataset.Tables("PO_HDR").Rows(0).Item("pototaldiscount"))), "0.00")
        '            TXT_OVERALLdiscount.Text = Format(Val(Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POoveralldisc"))), "0.00")
        '            'txt_Totalamt.Text = Format(Val(totAmt), "0.00")
        '            Dim OTHER_taxes As Double
        '            OTHER_taxes = 0
        '            OTHER_taxes = OTHER_taxes + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POED")) * totAmt / 100
        '            OTHER_taxes = OTHER_taxes + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POCST")) * totAmt / 100
        '            OTHER_taxes = OTHER_taxes + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POMODVAT")) * totAmt / 100
        '            OTHER_taxes = OTHER_taxes + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POPTAX")) * totAmt / 100
        '            OTHER_taxes = OTHER_taxes + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POOCTRA")) * totAmt / 100
        '            OTHER_taxes = OTHER_taxes + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POINSURANCE")) * totAmt / 100
        '            OTHER_taxes = OTHER_taxes + Val(gdataset.Tables("PO_HDR").Rows(0).Item("POLST")) * totAmt / 100

        '            txt_Surchargeamt.Text = Format(Val(Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"))) + Val(Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"))) + Val(Trim(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"))) + Val(OTHER_taxes), "0.00")
        '            Discnt = 0 : totAmt = 0
        '        End If
        '    End If
        '    txt_Grnno.Focus()
        'End If
    End Sub
    Private Sub Txt_PONo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Asc(e.KeyChar) = 13 Then
        '    If Txt_PONo.Text = "" Then
        '        Call cmd_PONOhelp_Click(Txt_PONo, e)
        '    Else
        '        Call Txt_PONo_Validated(Txt_PONo, e)
        '        Call Calculate()
        '    End If
        'End If
    End Sub
    Private Function Grid_lock()
        'Dim i, j As Integer
        'For i = 1 To ssgrid.DataRowCnt
        '    ssgrid.Row = i
        '    For j = 1 To ssgrid.MaxCols
        '        ssgrid.Col = j
        '        ssgrid.Lock = True
        '    Next
        'Next
    End Function

    Private Sub TXT_OVERALLdiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    If Val(TXT_OVERALLdiscount.Text) <> 0 Then
        '        txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_OverallDiscount_TextChanged" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub

    Private Sub TXT_OVERALLdiscount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            Call getNumeric(e)
            If Asc(e.KeyChar) = 13 Then
                Cmd_Add.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_Discountamt_KeyPress " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub TXT_OVERALLdiscount_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    TXT_OVERALLdiscount.Text = Format(Val(TXT_OVERALLdiscount.Text), "0.00")
        '    If Val(TXT_OVERALLdiscount.Text) <> 0 Then
        '        txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show("Plz Check Error : txt_OverallDiscount_lostfocus" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    Exit Sub
        'End Try
    End Sub
    Private Sub calc_billamt()
        'txt_Billamount.Text = Format(Val(txt_Totalamt.Text) + Val(txt_Vatamount.Text) + Val(txt_Surchargeamt.Text) - Val(txt_Discountamt.Text) - Val(TXT_OVERALLdiscount.Text), "0.00")
    End Sub
    Private Sub Txt_PONo_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Txt_PONo.BackColor = Color.Gold
    End Sub

    Private Sub Txt_PONo_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Txt_PONo.BackColor = Color.Wheat
    End Sub

    Private Sub txt_Grnno_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Indentno.GotFocus
        'txt_Grnno.BackColor = Color.Gold
        'Label14.Visible = True
    End Sub

    Private Sub txt_Grnno_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Indentno.LostFocus
        'txt_Grnno.BackColor = Color.Wheat
        'Label14.Visible = False
    End Sub

    Private Sub txt_Supplierinvno_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'txt_Supplierinvno.BackColor = Color.Gold
    End Sub

    Private Sub txt_Suppliername_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Suppliername.GotFocus
        txt_Suppliername.BackColor = Color.Gold
    End Sub

    Private Sub txt_Suppliername_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Suppliername.LostFocus
        txt_Suppliername.BackColor = Color.Wheat
    End Sub

    Private Sub txt_Storecode_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'txt_Storecode.BackColor = Color.Gold
        'Label15.Visible = True
    End Sub

    Private Sub txt_Storecode_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'txt_Storecode.BackColor = Color.Wheat
        'Label15.Visible = False
    End Sub

    Private Sub Txt_GLAcIn_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Txt_GLAcIn.BackColor = Color.Gold
        'Label17.Visible = True
    End Sub

    Private Sub Txt_GLAcIn_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Txt_GLAcIn.BackColor = Color.Wheat
        'Label17.Visible = False
    End Sub

    Private Sub Txt_Slcode_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Txt_Slcode.BackColor = Color.Gold
        'Label18.Visible = True
    End Sub

    Private Sub Txt_Slcode_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Txt_Slcode.BackColor = Color.Wheat
        'Label18.Visible = False
    End Sub

    Private Sub Txt_CostCenterCode_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Txt_CostCenterCode.BackColor = Color.Gold
        'Label19.Visible = True
    End Sub

    Private Sub Txt_CostCenterCode_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Txt_CostCenterCode.BackColor = Color.Wheat
        'Label19.Visible = False
    End Sub

    Private Sub cmd_Post_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim STRSQL As String
        'Call checkValidation() '''--->Check Validation
        '' Call billingterms()
        'If boolchk = False Then Exit Sub
        'Me.Cursor = Cursors.WaitCursor
        'STRSQL = "EXEC PJV_POSTING_DIR " & "'" & Trim(txt_Grnno.Text) & "','P'"
        'VCONN.dataOperation(6, STRSQL, "ACCOUNTPOSTING")
        'Me.Cursor = Cursors.Default
        'MsgBox("ACCOUNT POSTING DONE SUCCESSFULLY", MsgBoxStyle.Exclamation, "SUCCESS")
        'Call Cmd_Clear_Click(sender, e)
    End Sub

    Private Sub Chk_item_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Chk_item.Checked = True Then
        '    grp_footer.Visible = True
        '    Txt_footer.Focus()
        'Else
        '    grp_footer.Visible = False
        'End If
    End Sub

    Private Sub Txt_footer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Asc(e.KeyChar) = 13 Then
        '    If Trim(Txt_footer.Text) <> "" Then
        '        Txt_signature.Focus()
        '    Else
        '        Txt_footer.Focus()
        '    End If
        'End If
    End Sub

    Private Sub Txt_signature_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        'If Asc(e.KeyChar) = 13 Then
        '    Chk_item.Focus()
        'End If
    End Sub

    Private Sub txt_Suppliercode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Suppliercode.GotFocus
        txt_Suppliercode.BackColor = Color.Gold
        'Label16.Visible = True
    End Sub

    Private Sub txt_Suppliercode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Suppliercode.LostFocus
        txt_Suppliercode.BackColor = Color.Wheat
        'Label16.Visible = False
    End Sub

    Private Sub cmd_Wonohelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Wonohelp.Click
        Try
            Dim cat As String
            'cat = substring(CMB_CATEGORY.Text, 1, 3)

            gSQLString = "SELECT INDENT_NO,INDENTDATE,SUPPLIERNAME FROM PO_WORKINDENT"
            'M_WhereCondition = " Where ISNULL(INDENTNO,'') LIKE '%" & Trim(vform.keyfield & "") & "%'"
            Dim vform As New List_Operation
            vform.Field = "INDENT_NO,INDENTDATE,SUPPLIERNAME"
            vform.vFormatstring = "       INDENT_NO             |         INDENTDATE     |     SUPPLIERNAME                                       "
            vform.vCaption = "INDENT HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.KeyPos2 = 2
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_Indentno.Text = Trim(vform.keyfield & "")
                Call txt_Indentno_Validated(txt_Indentno.Text, e)
                Call Grid_lock()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : cmd_Grnnohelp_Click" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub


    Private Sub txt_Indentno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Indentno.TextChanged

    End Sub

    Private Sub cmd_Suppliercodehelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Suppliercodehelp.Click
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
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_Suppliercode.Text = Trim(vform.keyfield & "")
            txt_Suppliername.Text = Trim(vform.keyfield1 & "")
            txt_Suppliercode.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub btn_validation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start(AppPath & "\STUDY\WORKORDERINDENT.XLS")
    End Sub
    Private Sub Resize_Form()
        Dim cControl As Control
        Dim i_i As Integer
        Dim J, K, L, M, n, o, P, Q, R, S, T, U As Integer
        'If (Screen.PrimaryScreen.Bounds.Height = 768) And (Screen.PrimaryScreen.Bounds.Width = 1366) Then
        '    Exit Sub
        'End If
        J = 768
        K = 1366
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
                        If Controls(i_i).Name = "GroupBox7" Then
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim FRM As New ReportDesigner
        If txt_Indentno.Text.Length > 0 Then
            tables = " FROM VW_PO_STOCKINDENTAUTH_BILL WHERE DOCDETAILS ='" & txt_Indentno.Text & "' "
        Else
            tables = "FROM VW_PO_STOCKINDENTAUTH_BILL"
        End If
        Gheader = "INDENT DETAILS"
        FRM.DataGridView1.ColumnCount = 2
        FRM.DataGridView1.Columns(0).Name = "COLUMN NAME"
        FRM.DataGridView1.Columns(0).Width = 300
        FRM.DataGridView1.Columns(1).Name = "SIZE"
        FRM.DataGridView1.Columns(1).Width = 100

        Dim ROW As String() = New String() {"QUOTATIONNO", "10"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"DOCDETAILS", "20"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"DOCDATE", "5"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"STORELOCATIONNAME", "9"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"OPSTORELOCATIONNAME", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"ITEMCODE", "12"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"STORELOCATIONCODE", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"OPSTORELOCATIONCODE", "12 "}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"ITEMNAME", "6 "}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"UOM", "8"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"QTY", "8"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"AUTH1", "7"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"AUTH2", "7"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"RATE", "7"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"AMOUNT", "10"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"CLSQTY", "11"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"INDENTNO", "20"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"INDENTDATE", "20"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"REMARKS", "20"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"UPDFOOTER", "7"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"UPDSIGN", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"ADDDATE", "11"}
        FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"UOM", "15"}
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

        Dim CHK As New DataGridViewCheckBoxColumn()
        'Dim CHK As New VIEWHDR
        FRM.DataGridView1.Columns.Insert(0, CHK)
        CHK.HeaderText = "CHECK"
        CHK.Name = "CHK"
        FRM.ShowDialog(Me)
    End Sub


    Private Sub autogenerate1()
        Dim sqlstring, financalyear As String
        Try
            gcommand = New SqlCommand
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialyearEnd, 3, 4)
            sqlstring = " SELECT MAX(Cast(SUBSTRING(INDENT_NO,5,6) As Numeric)) FROM PO_WORKINDENT "
            gconnection.openConnection()
            gcommand.CommandText = sqlstring
            gcommand.CommandType = CommandType.Text
            gcommand.Connection = gconnection.Myconn
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is System.DBNull.Value Then
                    txt_IndentNo.Text = "IND/000001/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    txt_IndentNo.Text = "IND/" & Format(gdreader(0) + 1, "000000") & "/" & financalyear
                    gdreader.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
            Else
                txt_IndentNo.Text = "IND/000001/" & financalyear
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
End Class
