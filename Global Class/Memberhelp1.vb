Option Strict Off
Option Explicit On 
Imports Microsoft.VisualBasic
Imports VB = Microsoft.VisualBasic

Friend Class Memberhelp1
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdGetDetails As System.Windows.Forms.Button
	Public WithEvents vaDependents As AxFPSpreadADO.AxfpSpread
    Public WithEvents FraDependents As System.Windows.Forms.GroupBox
	Public WithEvents cmdDependents As System.Windows.Forms.Button
	Public WithEvents txtMembers As System.Windows.Forms.Button
	Public WithEvents cmdprint As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents txtSales As System.Windows.Forms.TextBox
	Public WithEvents txtReceipts As System.Windows.Forms.TextBox
	Public WithEvents TxtBalance As System.Windows.Forms.TextBox
    Public WithEvents sSgrid As AxFPSpreadADO.AxfpSpread
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents lbltotal As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents fraDetails As System.Windows.Forms.GroupBox
	Public WithEvents txtSelection As System.Windows.Forms.TextBox
	Public WithEvents optMCode As System.Windows.Forms.RadioButton
	Public WithEvents optAccName As System.Windows.Forms.RadioButton
	Public WithEvents OptCompany As System.Windows.Forms.RadioButton
	Public WithEvents OptOthers As System.Windows.Forms.RadioButton
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents OptPermanent As System.Windows.Forms.RadioButton
	Public WithEvents Optcommunication As System.Windows.Forms.RadioButton
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents ChkLast As System.Windows.Forms.CheckBox
	Public WithEvents fgrdSelectionList As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents lbladd3 As System.Windows.Forms.Label
	Public WithEvents lblAmount As System.Windows.Forms.Label
    Public WithEvents PImage As System.Windows.Forms.PictureBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents lblType As System.Windows.Forms.Label
	Public WithEvents lblname As System.Windows.Forms.Label
	Public WithEvents lbladd1 As System.Windows.Forms.Label
	Public WithEvents lbladd2 As System.Windows.Forms.Label
	Public WithEvents lblcity As System.Windows.Forms.Label
	Public WithEvents lblstate As System.Windows.Forms.Label
	Public WithEvents lblpin As System.Windows.Forms.Label
	Public WithEvents lblphone1 As System.Windows.Forms.Label
	Public WithEvents lblphone2 As System.Windows.Forms.Label
	Public WithEvents lblcellno As System.Windows.Forms.Label
	Public WithEvents lblEmail As System.Windows.Forms.Label
    Public WithEvents lblmcode As System.Windows.Forms.Label
	Public WithEvents lblSelection As System.Windows.Forms.Label
	Public WithEvents lblCompany As System.Windows.Forms.Label
	Public WithEvents lbltermination As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Shape1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
    Friend WithEvents Mskfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Mskto As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Memberhelp1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdGetDetails = New System.Windows.Forms.Button
        Me.fraDetails = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Mskfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Mskto = New System.Windows.Forms.DateTimePicker
        Me.FraDependents = New System.Windows.Forms.GroupBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.vaDependents = New AxFPSpreadADO.AxfpSpread
        Me.cmdDependents = New System.Windows.Forms.Button
        Me.txtMembers = New System.Windows.Forms.Button
        Me.cmdprint = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me.txtSales = New System.Windows.Forms.TextBox
        Me.txtReceipts = New System.Windows.Forms.TextBox
        Me.TxtBalance = New System.Windows.Forms.TextBox
        Me.lbltotal = New System.Windows.Forms.Label
        Me.sSgrid = New AxFPSpreadADO.AxfpSpread
        Me.txtSelection = New System.Windows.Forms.TextBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.optMCode = New System.Windows.Forms.RadioButton
        Me.optAccName = New System.Windows.Forms.RadioButton
        Me.OptCompany = New System.Windows.Forms.RadioButton
        Me.OptOthers = New System.Windows.Forms.RadioButton
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.OptPermanent = New System.Windows.Forms.RadioButton
        Me.Optcommunication = New System.Windows.Forms.RadioButton
        Me.ChkLast = New System.Windows.Forms.CheckBox
        Me.fgrdSelectionList = New AxMSFlexGridLib.AxMSFlexGrid
        Me.lbladd3 = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.PImage = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
        Me.lblname = New System.Windows.Forms.Label
        Me.lbladd1 = New System.Windows.Forms.Label
        Me.lbladd2 = New System.Windows.Forms.Label
        Me.lblcity = New System.Windows.Forms.Label
        Me.lblstate = New System.Windows.Forms.Label
        Me.lblpin = New System.Windows.Forms.Label
        Me.lblphone1 = New System.Windows.Forms.Label
        Me.lblphone2 = New System.Windows.Forms.Label
        Me.lblcellno = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblmcode = New System.Windows.Forms.Label
        Me.lblSelection = New System.Windows.Forms.Label
        Me.lblCompany = New System.Windows.Forms.Label
        Me.lbltermination = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Shape1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.fraDetails.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.FraDependents.SuspendLayout()
        CType(Me.vaDependents, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sSgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.fgrdSelectionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Exit (Esc)"
        Me.ToolTip1.SetToolTip(Me.Label5, "Click here")
        '
        'cmdGetDetails
        '
        Me.cmdGetDetails.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cmdGetDetails.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetDetails.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetDetails.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdGetDetails.Location = New System.Drawing.Point(24, 248)
        Me.cmdGetDetails.Name = "cmdGetDetails"
        Me.cmdGetDetails.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetDetails.Size = New System.Drawing.Size(163, 24)
        Me.cmdGetDetails.TabIndex = 40
        Me.cmdGetDetails.Text = "<<MORE DETAILS>>"
        '
        'fraDetails
        '
        Me.fraDetails.BackColor = System.Drawing.Color.Transparent
        Me.fraDetails.Controls.Add(Me.GroupBox1)
        Me.fraDetails.Controls.Add(Me.FraDependents)
        Me.fraDetails.Controls.Add(Me.cmdDependents)
        Me.fraDetails.Controls.Add(Me.txtMembers)
        Me.fraDetails.Controls.Add(Me.cmdprint)
        Me.fraDetails.Controls.Add(Me.Command1)
        Me.fraDetails.Controls.Add(Me.txtSales)
        Me.fraDetails.Controls.Add(Me.txtReceipts)
        Me.fraDetails.Controls.Add(Me.TxtBalance)
        Me.fraDetails.Controls.Add(Me.Label5)
        Me.fraDetails.Controls.Add(Me.lbltotal)
        Me.fraDetails.Controls.Add(Me.sSgrid)
        Me.fraDetails.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraDetails.ForeColor = System.Drawing.Color.Black
        Me.fraDetails.Location = New System.Drawing.Point(16, 404)
        Me.fraDetails.Name = "fraDetails"
        Me.fraDetails.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDetails.Size = New System.Drawing.Size(960, 272)
        Me.fraDetails.TabIndex = 10
        Me.fraDetails.TabStop = False
        Me.fraDetails.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Mskfrom)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Mskto)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 40)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label6.Location = New System.Drawing.Point(216, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "FROM :"
        '
        'Mskfrom
        '
        Me.Mskfrom.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mskfrom.CustomFormat = "dd/MM/yyyy"
        Me.Mskfrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mskfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Mskfrom.Location = New System.Drawing.Point(104, 13)
        Me.Mskfrom.Name = "Mskfrom"
        Me.Mskfrom.Size = New System.Drawing.Size(104, 22)
        Me.Mskfrom.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(56, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "PERIOD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label7.Location = New System.Drawing.Point(75, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(27, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "TO :"
        '
        'Mskto
        '
        Me.Mskto.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mskto.CustomFormat = "dd/MM/yyyy"
        Me.Mskto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mskto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Mskto.Location = New System.Drawing.Point(264, 13)
        Me.Mskto.Name = "Mskto"
        Me.Mskto.Size = New System.Drawing.Size(104, 22)
        Me.Mskto.TabIndex = 49
        '
        'FraDependents
        '
        Me.FraDependents.BackColor = System.Drawing.Color.FromArgb(CType(138, Byte), CType(163, Byte), CType(168, Byte))
        Me.FraDependents.BackgroundImage = CType(resources.GetObject("FraDependents.BackgroundImage"), System.Drawing.Image)
        Me.FraDependents.Controls.Add(Me.LinkLabel1)
        Me.FraDependents.Controls.Add(Me.vaDependents)
        Me.FraDependents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FraDependents.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.FraDependents.Location = New System.Drawing.Point(8, 48)
        Me.FraDependents.Name = "FraDependents"
        Me.FraDependents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FraDependents.Size = New System.Drawing.Size(944, 216)
        Me.FraDependents.TabIndex = 46
        Me.FraDependents.TabStop = False
        Me.FraDependents.Text = "DEPENDENT NAME "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(8, 184)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel1.TabIndex = 48
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "BACK"
        '
        'vaDependents
        '
        Me.vaDependents.ContainingControl = Me
        Me.vaDependents.DataSource = Nothing
        Me.vaDependents.Location = New System.Drawing.Point(8, 16)
        Me.vaDependents.Name = "vaDependents"
        Me.vaDependents.OcxState = CType(resources.GetObject("vaDependents.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vaDependents.Size = New System.Drawing.Size(928, 160)
        Me.vaDependents.TabIndex = 47
        '
        'cmdDependents
        '
        Me.cmdDependents.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cmdDependents.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDependents.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDependents.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDependents.Location = New System.Drawing.Point(814, 16)
        Me.cmdDependents.Name = "cmdDependents"
        Me.cmdDependents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDependents.Size = New System.Drawing.Size(120, 25)
        Me.cmdDependents.TabIndex = 44
        Me.cmdDependents.Text = "DEPENDENTS"
        '
        'txtMembers
        '
        Me.txtMembers.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.txtMembers.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtMembers.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMembers.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMembers.Location = New System.Drawing.Point(681, 16)
        Me.txtMembers.Name = "txtMembers"
        Me.txtMembers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMembers.Size = New System.Drawing.Size(120, 26)
        Me.txtMembers.TabIndex = 43
        Me.txtMembers.Text = "TOTAL MEMBERS"
        '
        'cmdprint
        '
        Me.cmdprint.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cmdprint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdprint.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdprint.Location = New System.Drawing.Point(548, 16)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdprint.Size = New System.Drawing.Size(120, 25)
        Me.cmdprint.TabIndex = 42
        Me.cmdprint.Text = "PRINT"
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(415, 16)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(120, 25)
        Me.Command1.TabIndex = 41
        Me.Command1.Text = "GET DETAILS"
        '
        'txtSales
        '
        Me.txtSales.AcceptsReturn = True
        Me.txtSales.AutoSize = False
        Me.txtSales.BackColor = System.Drawing.Color.Wheat
        Me.txtSales.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSales.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSales.Location = New System.Drawing.Point(672, 240)
        Me.txtSales.MaxLength = 0
        Me.txtSales.Name = "txtSales"
        Me.txtSales.ReadOnly = True
        Me.txtSales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSales.Size = New System.Drawing.Size(95, 24)
        Me.txtSales.TabIndex = 13
        Me.txtSales.Text = ""
        Me.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReceipts
        '
        Me.txtReceipts.AcceptsReturn = True
        Me.txtReceipts.AutoSize = False
        Me.txtReceipts.BackColor = System.Drawing.Color.Wheat
        Me.txtReceipts.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReceipts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceipts.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtReceipts.Location = New System.Drawing.Point(528, 240)
        Me.txtReceipts.MaxLength = 0
        Me.txtReceipts.Name = "txtReceipts"
        Me.txtReceipts.ReadOnly = True
        Me.txtReceipts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtReceipts.Size = New System.Drawing.Size(101, 24)
        Me.txtReceipts.TabIndex = 12
        Me.txtReceipts.Text = ""
        Me.txtReceipts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtBalance
        '
        Me.TxtBalance.AcceptsReturn = True
        Me.TxtBalance.AutoSize = False
        Me.TxtBalance.BackColor = System.Drawing.Color.Wheat
        Me.TxtBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBalance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBalance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtBalance.Location = New System.Drawing.Point(816, 240)
        Me.TxtBalance.MaxLength = 0
        Me.TxtBalance.Name = "TxtBalance"
        Me.TxtBalance.ReadOnly = True
        Me.TxtBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtBalance.Size = New System.Drawing.Size(93, 24)
        Me.TxtBalance.TabIndex = 11
        Me.TxtBalance.Text = ""
        Me.TxtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BackColor = System.Drawing.Color.Transparent
        Me.lbltotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(352, 240)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltotal.Size = New System.Drawing.Size(120, 18)
        Me.lbltotal.TabIndex = 19
        Me.lbltotal.Text = "TOTAL AMOUNT :"
        '
        'sSgrid
        '
        Me.sSgrid.ContainingControl = Me
        Me.sSgrid.DataSource = Nothing
        Me.sSgrid.Location = New System.Drawing.Point(8, 64)
        Me.sSgrid.Name = "sSgrid"
        Me.sSgrid.OcxState = CType(resources.GetObject("sSgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sSgrid.Size = New System.Drawing.Size(928, 160)
        Me.sSgrid.TabIndex = 45
        '
        'txtSelection
        '
        Me.txtSelection.AcceptsReturn = True
        Me.txtSelection.AutoSize = False
        Me.txtSelection.BackColor = System.Drawing.Color.Wheat
        Me.txtSelection.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSelection.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelection.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSelection.Location = New System.Drawing.Point(120, 72)
        Me.txtSelection.MaxLength = 25
        Me.txtSelection.Name = "txtSelection"
        Me.txtSelection.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSelection.Size = New System.Drawing.Size(233, 24)
        Me.txtSelection.TabIndex = 9
        Me.txtSelection.Text = ""
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(138, Byte), CType(163, Byte), CType(168, Byte))
        Me.Frame1.BackgroundImage = CType(resources.GetObject("Frame1.BackgroundImage"), System.Drawing.Image)
        Me.Frame1.Controls.Add(Me.optMCode)
        Me.Frame1.Controls.Add(Me.optAccName)
        Me.Frame1.Controls.Add(Me.OptCompany)
        Me.Frame1.Controls.Add(Me.OptOthers)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(120, 25)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(416, 35)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        '
        'optMCode
        '
        Me.optMCode.BackColor = System.Drawing.Color.Transparent
        Me.optMCode.Checked = True
        Me.optMCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMCode.Location = New System.Drawing.Point(4, 12)
        Me.optMCode.Name = "optMCode"
        Me.optMCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMCode.Size = New System.Drawing.Size(88, 15)
        Me.optMCode.TabIndex = 8
        Me.optMCode.TabStop = True
        Me.optMCode.Text = "CODE"
        '
        'optAccName
        '
        Me.optAccName.BackColor = System.Drawing.Color.Transparent
        Me.optAccName.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAccName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAccName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAccName.Location = New System.Drawing.Point(107, 13)
        Me.optAccName.Name = "optAccName"
        Me.optAccName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAccName.Size = New System.Drawing.Size(88, 15)
        Me.optAccName.TabIndex = 7
        Me.optAccName.TabStop = True
        Me.optAccName.Text = "NAME"
        '
        'OptCompany
        '
        Me.OptCompany.BackColor = System.Drawing.Color.Transparent
        Me.OptCompany.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptCompany.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCompany.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptCompany.Location = New System.Drawing.Point(197, 14)
        Me.OptCompany.Name = "OptCompany"
        Me.OptCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptCompany.Size = New System.Drawing.Size(99, 15)
        Me.OptCompany.TabIndex = 6
        Me.OptCompany.TabStop = True
        Me.OptCompany.Text = "COMPANY"
        '
        'OptOthers
        '
        Me.OptOthers.BackColor = System.Drawing.Color.Transparent
        Me.OptOthers.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptOthers.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptOthers.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptOthers.Location = New System.Drawing.Point(328, 14)
        Me.OptOthers.Name = "OptOthers"
        Me.OptOthers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptOthers.Size = New System.Drawing.Size(88, 15)
        Me.OptOthers.TabIndex = 5
        Me.OptOthers.TabStop = True
        Me.OptOthers.Text = "OTHERS"
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(138, Byte), CType(163, Byte), CType(168, Byte))
        Me.Frame2.BackgroundImage = CType(resources.GetObject("Frame2.BackgroundImage"), System.Drawing.Image)
        Me.Frame2.Controls.Add(Me.OptPermanent)
        Me.Frame2.Controls.Add(Me.Optcommunication)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(544, 16)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(424, 40)
        Me.Frame2.TabIndex = 1
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "ADDRESS"
        '
        'OptPermanent
        '
        Me.OptPermanent.BackColor = System.Drawing.Color.FromArgb(CType(138, Byte), CType(163, Byte), CType(168, Byte))
        Me.OptPermanent.BackgroundImage = CType(resources.GetObject("OptPermanent.BackgroundImage"), System.Drawing.Image)
        Me.OptPermanent.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptPermanent.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPermanent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptPermanent.Location = New System.Drawing.Point(40, 16)
        Me.OptPermanent.Name = "OptPermanent"
        Me.OptPermanent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptPermanent.Size = New System.Drawing.Size(136, 17)
        Me.OptPermanent.TabIndex = 3
        Me.OptPermanent.TabStop = True
        Me.OptPermanent.Text = "PERMANENT"
        '
        'Optcommunication
        '
        Me.Optcommunication.BackColor = System.Drawing.Color.FromArgb(CType(138, Byte), CType(163, Byte), CType(168, Byte))
        Me.Optcommunication.BackgroundImage = CType(resources.GetObject("Optcommunication.BackgroundImage"), System.Drawing.Image)
        Me.Optcommunication.Cursor = System.Windows.Forms.Cursors.Default
        Me.Optcommunication.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Optcommunication.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Optcommunication.Location = New System.Drawing.Point(240, 12)
        Me.Optcommunication.Name = "Optcommunication"
        Me.Optcommunication.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Optcommunication.Size = New System.Drawing.Size(168, 19)
        Me.Optcommunication.TabIndex = 2
        Me.Optcommunication.TabStop = True
        Me.Optcommunication.Text = "COMMUNICATION"
        '
        'ChkLast
        '
        Me.ChkLast.BackColor = System.Drawing.Color.FromArgb(CType(138, Byte), CType(163, Byte), CType(168, Byte))
        Me.ChkLast.BackgroundImage = CType(resources.GetObject("ChkLast.BackgroundImage"), System.Drawing.Image)
        Me.ChkLast.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkLast.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkLast.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkLast.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkLast.Location = New System.Drawing.Point(18, 10)
        Me.ChkLast.Name = "ChkLast"
        Me.ChkLast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkLast.Size = New System.Drawing.Size(152, 16)
        Me.ChkLast.TabIndex = 0
        Me.ChkLast.Text = "PREVIOUS YEAR"
        Me.ChkLast.Visible = False
        '
        'fgrdSelectionList
        '
        Me.fgrdSelectionList.ContainingControl = Me
        Me.fgrdSelectionList.Location = New System.Drawing.Point(24, 24)
        Me.fgrdSelectionList.Name = "fgrdSelectionList"
        Me.fgrdSelectionList.OcxState = CType(resources.GetObject("fgrdSelectionList.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fgrdSelectionList.Size = New System.Drawing.Size(464, 216)
        Me.fgrdSelectionList.TabIndex = 21
        '
        'lbladd3
        '
        Me.lbladd3.AutoSize = True
        Me.lbladd3.BackColor = System.Drawing.Color.Transparent
        Me.lbladd3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbladd3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd3.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbladd3.Location = New System.Drawing.Point(8, 172)
        Me.lbladd3.Name = "lbladd3"
        Me.lbladd3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbladd3.Size = New System.Drawing.Size(54, 18)
        Me.lbladd3.TabIndex = 49
        Me.lbladd3.Text = "lblAdd3"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAmount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(384, 256)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAmount.Size = New System.Drawing.Size(87, 22)
        Me.lblAmount.TabIndex = 39
        Me.lblAmount.Text = "lblAmount"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PImage
        '
        Me.PImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.PImage.Location = New System.Drawing.Point(424, 120)
        Me.PImage.Name = "PImage"
        Me.PImage.Size = New System.Drawing.Size(106, 122)
        Me.PImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PImage.TabIndex = 51
        Me.PImage.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(163, 22)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "As on Outstanding :"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(64, Byte), CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(8, 16)
        Me.lblType.Name = "lblType"
        Me.lblType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblType.Size = New System.Drawing.Size(59, 22)
        Me.lblType.TabIndex = 37
        Me.lblType.Text = "lbltype"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblname.Location = New System.Drawing.Point(8, 106)
        Me.lblname.Name = "lblname"
        Me.lblname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblname.Size = New System.Drawing.Size(55, 18)
        Me.lblname.TabIndex = 36
        Me.lblname.Text = "lblname"
        '
        'lbladd1
        '
        Me.lbladd1.AutoSize = True
        Me.lbladd1.BackColor = System.Drawing.Color.Transparent
        Me.lbladd1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbladd1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbladd1.Location = New System.Drawing.Point(8, 132)
        Me.lbladd1.Name = "lbladd1"
        Me.lbladd1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbladd1.Size = New System.Drawing.Size(54, 18)
        Me.lbladd1.TabIndex = 35
        Me.lbladd1.Text = "lblAdd1"
        '
        'lbladd2
        '
        Me.lbladd2.AutoSize = True
        Me.lbladd2.BackColor = System.Drawing.Color.Transparent
        Me.lbladd2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbladd2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd2.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbladd2.Location = New System.Drawing.Point(8, 152)
        Me.lbladd2.Name = "lbladd2"
        Me.lbladd2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbladd2.Size = New System.Drawing.Size(54, 18)
        Me.lbladd2.TabIndex = 34
        Me.lbladd2.Text = "lblAdd2"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.BackColor = System.Drawing.Color.Transparent
        Me.lblcity.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcity.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblcity.Location = New System.Drawing.Point(8, 193)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcity.Size = New System.Drawing.Size(44, 18)
        Me.lblcity.TabIndex = 33
        Me.lblcity.Text = "lblcity"
        '
        'lblstate
        '
        Me.lblstate.AutoSize = True
        Me.lblstate.BackColor = System.Drawing.Color.Transparent
        Me.lblstate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblstate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstate.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblstate.Location = New System.Drawing.Point(8, 216)
        Me.lblstate.Name = "lblstate"
        Me.lblstate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblstate.Size = New System.Drawing.Size(52, 18)
        Me.lblstate.TabIndex = 32
        Me.lblstate.Text = "lblstate"
        '
        'lblpin
        '
        Me.lblpin.AutoSize = True
        Me.lblpin.BackColor = System.Drawing.Color.Transparent
        Me.lblpin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblpin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpin.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblpin.Location = New System.Drawing.Point(8, 237)
        Me.lblpin.Name = "lblpin"
        Me.lblpin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblpin.Size = New System.Drawing.Size(41, 18)
        Me.lblpin.TabIndex = 31
        Me.lblpin.Text = "lblpin"
        '
        'lblphone1
        '
        Me.lblphone1.AutoSize = True
        Me.lblphone1.BackColor = System.Drawing.Color.Transparent
        Me.lblphone1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblphone1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblphone1.Location = New System.Drawing.Point(8, 259)
        Me.lblphone1.Name = "lblphone1"
        Me.lblphone1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblphone1.Size = New System.Drawing.Size(68, 18)
        Me.lblphone1.TabIndex = 30
        Me.lblphone1.Text = "lblphone1"
        '
        'lblphone2
        '
        Me.lblphone2.AutoSize = True
        Me.lblphone2.BackColor = System.Drawing.Color.Transparent
        Me.lblphone2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblphone2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone2.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblphone2.Location = New System.Drawing.Point(200, 262)
        Me.lblphone2.Name = "lblphone2"
        Me.lblphone2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblphone2.Size = New System.Drawing.Size(68, 18)
        Me.lblphone2.TabIndex = 29
        Me.lblphone2.Text = "lblphone2"
        '
        'lblcellno
        '
        Me.lblcellno.AutoSize = True
        Me.lblcellno.BackColor = System.Drawing.Color.Transparent
        Me.lblcellno.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcellno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcellno.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblcellno.Location = New System.Drawing.Point(8, 284)
        Me.lblcellno.Name = "lblcellno"
        Me.lblcellno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcellno.Size = New System.Drawing.Size(61, 18)
        Me.lblcellno.TabIndex = 28
        Me.lblcellno.Text = "lblCellno"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(8, 307)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEmail.Size = New System.Drawing.Size(56, 18)
        Me.lblEmail.TabIndex = 27
        Me.lblEmail.Text = "lblEmail"
        '
        'lblmcode
        '
        Me.lblmcode.AutoSize = True
        Me.lblmcode.BackColor = System.Drawing.Color.Transparent
        Me.lblmcode.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmcode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmcode.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(64, Byte), CType(0, Byte))
        Me.lblmcode.Location = New System.Drawing.Point(8, 46)
        Me.lblmcode.Name = "lblmcode"
        Me.lblmcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmcode.Size = New System.Drawing.Size(78, 22)
        Me.lblmcode.TabIndex = 26
        Me.lblmcode.Text = "lblmcode"
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.BackColor = System.Drawing.Color.Transparent
        Me.lblSelection.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSelection.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelection.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.lblSelection.Location = New System.Drawing.Point(24, 74)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSelection.Size = New System.Drawing.Size(70, 18)
        Me.lblSelection.TabIndex = 25
        Me.lblSelection.Text = "SEARCH :"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCompany.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCompany.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(128, Byte), CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(8, 76)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCompany.Size = New System.Drawing.Size(143, 22)
        Me.lblCompany.TabIndex = 24
        Me.lblCompany.Text = "lblCompanyname"
        '
        'lbltermination
        '
        Me.lbltermination.AutoSize = True
        Me.lbltermination.BackColor = System.Drawing.Color.Transparent
        Me.lbltermination.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltermination.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltermination.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lbltermination.Location = New System.Drawing.Point(24, 120)
        Me.lbltermination.Name = "lbltermination"
        Me.lbltermination.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltermination.Size = New System.Drawing.Size(119, 22)
        Me.lbltermination.TabIndex = 23
        Me.lbltermination.Text = "lblTermination"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "MEMBER "
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.Transparent
        Me.Shape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Shape1.Location = New System.Drawing.Point(16, 8)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(960, 392)
        Me.Shape1.TabIndex = 53
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.lblEmail)
        Me.GroupBox2.Controls.Add(Me.lblmcode)
        Me.GroupBox2.Controls.Add(Me.lblCompany)
        Me.GroupBox2.Controls.Add(Me.lblname)
        Me.GroupBox2.Controls.Add(Me.lbladd3)
        Me.GroupBox2.Controls.Add(Me.lblType)
        Me.GroupBox2.Controls.Add(Me.lbladd1)
        Me.GroupBox2.Controls.Add(Me.lbladd2)
        Me.GroupBox2.Controls.Add(Me.lblcity)
        Me.GroupBox2.Controls.Add(Me.lblstate)
        Me.GroupBox2.Controls.Add(Me.lblpin)
        Me.GroupBox2.Controls.Add(Me.lblphone1)
        Me.GroupBox2.Controls.Add(Me.lblphone2)
        Me.GroupBox2.Controls.Add(Me.lblcellno)
        Me.GroupBox2.Location = New System.Drawing.Point(544, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 328)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.fgrdSelectionList)
        Me.GroupBox3.Controls.Add(Me.cmdGetDetails)
        Me.GroupBox3.Controls.Add(Me.lblAmount)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(512, 288)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'Memberhelp1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1030, 682)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fraDetails)
        Me.Controls.Add(Me.txtSelection)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.lbltermination)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.ChkLast)
        Me.Controls.Add(Me.PImage)
        Me.Controls.Add(Me.Shape1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(5, 56)
        Me.Name = "Memberhelp1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.fraDetails.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.FraDependents.ResumeLayout(False)
        CType(Me.vaDependents, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sSgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        CType(Me.fgrdSelectionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As Memberhelp1
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As Memberhelp1
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New Memberhelp1()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
    '***************************************************  Modified On 11/04/2007 **************************************
    Dim Vconn As New GlobalClass
    Dim FormUnload As Boolean
    Dim vTotal As Double
    Dim VRowCount As Short
    Dim SideLedgerName, MemberCode, vMemAcc, vUser, vSql, gPicture As String
    Private Sub ChkLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ChkLast.CheckStateChanged
        Dim gConnection As Object
        If ChkLast.CheckState = 1 Then
            vUser = Trim(gDatabase)
        Else
            vUser = Trim(gDatabase)
        End If
    End Sub
    Private Sub ChkLast_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ChkLast.Leave
        Call ChkLast_CheckStateChanged(eventSender, eventArgs)
    End Sub
    Private Sub cmdDependents_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDependents.Click
        Dim adOpenDynamic, MainMenu, DoubleApostrophe, ADODB As Object
        Dim loopindex As Integer
        Dim ssql As String
        If lblmcode.Text <> "" Then
            ssql = "SELECT ISNULL(DNAME,'') AS DNAME,ISNULL(RELATIONSHIP,'') AS RELATIONSHIP,ISNULL(DOB,'') AS DOB,ISNULL(AGE,0) AS AGE,ISNULL(SEX,'') AS SEX,ISNULL(BG,'') AS BG,"
            ssql = ssql & " ISNULL(PHOTO,'') AS PHOTO FROM " & Trim(vUser) & "..DEPENDENTMASTER WHERE MCODE = '" & Trim(lblmcode.Text) & "'"
            Vconn.getCompanyinfo(ssql, "DEPENDENTMASTER")
            If gdataset.Tables("DEPENDENTMASTER").Rows.Count > 0 Then
                For loopindex = 0 To gdataset.Tables("DEPENDENTMASTER").Rows.Count - 1
                    vaDependents.SetText(1, loopindex + 1, Trim(gdataset.Tables("DEPENDENTMASTER").Rows(loopindex).Item("dname")))
                    vaDependents.SetText(2, loopindex + 1, Trim(gdataset.Tables("DEPENDENTMASTER").Rows(loopindex).Item("Relationship")))
                    If Format((gdataset.Tables("DEPENDENTMASTER").Rows(loopindex).Item("DOB")), "dd-MMM-yyyy") <> "01-Jan-1900" Then
                        vaDependents.SetText(3, loopindex + 1, Format((gdataset.Tables("DEPENDENTMASTER").Rows(loopindex).Item("DOB")), "dd-MMM-yyyy"))
                    Else
                        vaDependents.SetText(3, loopindex + 1, "Not Provided")
                    End If
                    vaDependents.SetText(4, loopindex + 1, Trim(gdataset.Tables("DEPENDENTMASTER").Rows(loopindex).Item("Sex")))
                    vaDependents.SetText(5, loopindex + 1, Trim(gdataset.Tables("DEPENDENTMASTER").Rows(loopindex).Item("AGE")))
                    vSql = "SELECT ISNULL(PHOTOIMAGE,'') AS PHOTOIMAGE FROM " & Trim(vUser) & "..PHOTOADDING WHERE MCODE = '" & Trim(lblmcode.Text) & "'"
                    Vconn.getDataSet(vSql, "PHOTOADDING")
                    If gdataset.Tables("PHOTOADDING").Rows.Count > 0 Then
                        If Trim(gdataset.Tables("PHOTOADDING").Rows(0).Item("PHOTOIMAGE") & "") <> "" Then
                            vaDependents.Col = 6
                            vaDependents.TypeButtonText = "YES"
                        Else
                            vaDependents.Col = 6
                            vaDependents.TypeButtonText = "NO"
                        End If
                        vaDependents.SetText(7, loopindex + 1, Trim(gdataset.Tables("DEPENDENTMASTER").Rows(loopindex).Item("PHOTOIMAGE")))
                    End If
                Next
                FraDependents.Visible = True
            Else
                MsgBox("Dependent Details are not there", MsgBoxStyle.Information, Trim(MyCompanyName))
                Exit Sub
            End If
        End If
    End Sub
    Private Sub CmdGetDetails_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGetDetails.Click
        fraDetails.Visible = True
        FraDependents.Visible = False
        TxtBalance.Text = ""
        txtReceipts.Text = ""
        TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        txtSales.Text = ""
        mskfrom.Focus()
    End Sub
    Private Sub CmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdprint.Click
        Call PrintOperation()
    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        TxtBalance.Text = ""
        txtReceipts.Text = ""
        txtSales.Text = ""
        TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        'BLOCKJOURNALENTRY***********************************************************************
        'Call FillGrid1()
        sSgrid.Focus()
    End Sub
    Private Sub fgrdSelectionList_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles fgrdSelectionList.ClickEvent
        If fgrdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 0) <> "" Then
            SideLedgerName = fgrdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 0)
            MemberCode = fgrdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 1)
        End If
    End Sub
    Private Sub fgrdSelectionList_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles fgrdSelectionList.Enter
        Call fgrdSelectionList_RowColChange(fgrdSelectionList, New System.EventArgs)
        sSgrid.ClearRange(1, 1, -1, -1, True)
        TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        TxtBalance.Text = ""
        txtReceipts.Text = ""
        txtSales.Text = ""
        fraDetails.Visible = False
        FraDependents.Visible = False
    End Sub
    Private Sub fgrdSelectionList_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_KeyPressEvent) Handles fgrdSelectionList.KeyPressEvent
        If eventArgs.keyAscii = System.Windows.Forms.Keys.Return Then
            Call fgrdSelectionList_ClickEvent(fgrdSelectionList, New System.EventArgs)
            If cmdGetDetails.Visible = True Then
                cmdGetDetails.Focus()
            End If
        End If
    End Sub
    Private Sub fgrdSelectionList_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles fgrdSelectionList.RowColChange
        Dim adLockPessimistic, adOpenDynamic, DoubleApostrophe, MainMenu, ADODB As Object
        Dim vPartyNameAddress(), vMemberCode, Vdesc, ssql As String
        Dim vBal, vCredits, vDebits As Double
        ssql = "SELECT ISNULL(TERMINATION,'') AS TERMINATE FROM MEMBERMASTER WHERE MCODE = '" & (fgrdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 1)) & "'"
        Vconn.getDataSet(ssql, "MEMBERMASTER")
        If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "U" Then
                lbltermination.Text = "DEFAULTER"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "L" Then
                lbltermination.Text = "LEFT"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "D" Then
                lbltermination.Text = "DEAD"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "F" Then
                lbltermination.Text = "FREEZED"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "Y" Then
                lbltermination.Text = "TERMINATED"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "P" Then
                lbltermination.Text = "POSTED"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "B" Then
                lbltermination.Text = "BLOCKED"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "K" Then
                lbltermination.Text = "BLACK LISTED"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "" Then
                lbltermination.Text = "NORMAL"
            End If
        End If
        gPicture = ""
        If OptOthers.Checked Then
            If OptPermanent.Checked = True Then
                ssql = "SELECT ISNULL(PNAME,'') AS PNAME,ISNULL(PADD1,'') AS PADD1,ISNULL(PADD2,'') AS PADD2,ISNULL(PADD3,'') AS PADD3,ISNULL(PCITY,'') AS PCITY,"
                ssql = ssql & "ISNULL(PSTATE,'') AS PSTATE,ISNULL(PPINCODE,'') AS PPINCODE,ISNULL(PPHONE1,'') AS PPHONE1,ISNULL(PPHONE2,'') AS PPHONE2,ISNULL(PFAXNO,'') AS PFAXNO,ISNULL(PEMAIL,'') AS PEMAIL,ISNULL(PMOBILE,'') AS PMOBILE FROM ADDRESSSEARCH WHERE PNAME='" & Trim(fgrdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 0)) & "'"
                Vconn.getDataSet(ssql, "AddressSearch")
                If gdataset.Tables("AddressSearch").Rows.Count > 0 Then
                    lblname.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("Pname") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("Pname")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("Pname")), " ")
                    lbladd1.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("padd1") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("padd1")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("padd1")), " ")
                    lbladd2.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("padd2") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("padd2")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("padd2")), " ")
                    lbladd3.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("padd3") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("padd3")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("padd3")), " ")
                    lblcity.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("pcity") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("pcity")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("pcity")), " ")
                    lblstate.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("pstate") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("pstate")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("pstate")), " ")
                    lblpin.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("ppincode") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("ppincode")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("ppincode")), " ")
                    lblphone1.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("pphone1") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("pphone1")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("pphone1")), " ")
                    lblphone2.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("pphone2") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("pphone2")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("pphone2")), " ")
                    lblcellno.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("pMobile") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("pMobile")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("pMobile")), " ") & " Fax:" & IIf(gdataset.Tables("AddressSearch").Rows(0).Item("pMobile") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("pFaxno")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("pFaxno")), " ")
                    lblEmail.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("pemail") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("pemail")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("pemail")), " ")
                End If
            End If
            If Optcommunication.Checked = True Then
                ssql = "SELECT ISNULL(PNAME,'') AS PNAME,ISNULL(CADD1,'') AS CADD1,ISNULL(CADD2,'') AS CADD2,ISNULL(CADD3,'') AS CADD3,ISNULL(CCITY,'') AS CCITY,"
                ssql = ssql & "ISNULL(CSTATE,'') AS CSTATE,ISNULL(CPINCODE,'') AS CPINCODE,ISNULL(cPHONE1,'') AS CPHONE1,ISNULL(CPHONE2,'') AS CPHONE2,ISNULL(CFAXNO,'') AS CFAXNO,ISNULL(PEMAIL,'') AS CEMAIL,ISNULL(CMOBILE,'') AS CMOBILE FROM ADDRESSSEARCH WHERE PNAME='" & Trim(fgrdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 0)) & "'"
                Vconn.getDataSet(ssql, "AddressSearch")
                If gdataset.Tables("AddressSearch").Rows.Count > 0 Then
                    lblname.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("Pname") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("Pname")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("Pname")), " ")
                    lbladd1.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cadd1") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cadd1")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cadd1")), " ")
                    lbladd2.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cadd2") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cadd2")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cadd2")), " ")
                    lbladd3.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cadd3") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cadd3")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cadd3")), " ")
                    lblcity.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("ccity") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("ccity")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("ccity")), " ")
                    lblstate.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cstate") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cstate")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cstate")), " ")
                    lblpin.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cpincode") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cpincode")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cpincode")), " ")
                    lblphone1.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cphone1") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cphone1")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cphone1")), " ")
                    lblphone2.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cphone2") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cphone2")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cphone2")), " ")
                    lblcellno.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cMobile") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cMobile")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cMobile")), " ") & " Fax:" & IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cMobile") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cFaxno")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cFaxno")), " ")
                    lblEmail.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cemail") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cemail")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cemail")), " ")
                End If
            End If
        End If
        If fgrdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 1) <> "" And OptOthers.Checked = False Then
            vSql = "SELECT ISNULL(SUBCODE,'') AS SUBCODE,ISNULL(SUBNAME,'') AS SUBNAME,ISNULL(ACCODE,'') AS ACCODE,ISNULL(ACDESC,'') AS ACDESC,ISNULL(TERMINATE,'') AS TERMINATE,ISNULL(CLOSINGBAL,0) AS CLOSINGBAL"
            vSql = vSql & " FROM " & Trim(vUser) & "..SUBLEDGERLIST1 WHERE SUBCODE ='" & Trim(fgrdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 1)) & "'"
            Vconn.getDataSet(vSql, "SUBLEDGERLIST1")
            If gdataset.Tables("SUBLEDGERLIST1").Rows.Count > 0 Then
                lblmcode.Text = IIf(CStr(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("Subcode")) <> "" Or Not IsDBNull(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode")), Trim(CStr(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode"))), " ")
                lblname.Text = IIf(CStr(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubName")) <> "" Or Not IsDBNull(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubName")), Trim(CStr(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubName"))), " ")
                FraDependents.Visible = False
                fraDetails.Visible = False
                vSql = "SELECT ISNULL(PHOTOIMAGE,'') AS PHOTOIMAGE FROM " & Trim(vUser) & "..PHOTOADDING WHERE MCODE='" & Trim(lblmcode.Text) & "'"
                Vconn.getDataSet(vSql, "PHOTOADDING")
                If gdataset.Tables("PHOTOADDING").Rows.Count > 0 Then
                    Vdesc = Trim(gdataset.Tables("PHOTOADDING").Rows(0).Item(0) & "")
                End If
                If Trim(Vdesc) <> "" Then
                    gPicture = Trim(Vdesc & "")
                End If
                vMemberCode = gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode")
                vMemberCode = IIf(CStr(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode")) <> "" Or Not IsDBNull(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode")), Trim(CStr(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode"))), " ")
                vBal = Val(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("ClosingBal") & "")
                If vBal > 0 Then
                    lblAmount.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF0000)
                    lblAmount.Text = Format(vBal, "0.00")
                Else
                    lblAmount.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
                    lblAmount.Text = Format(vBal, "0.00")
                End If
            End If
            If OptPermanent.Checked = True Then
                ssql = "SELECT ISNULL(M.MCODE,'') AS MCODE,ISNULL(M.COMPANY,'') AS COMPANY,ISNULL(M.TERMINATION,'') AS TERMINATION,ISNULL(M.CON_MCODE,'') AS CON_MCODE,ISNULL(M.MNAME,'') AS MNAME,"
                ssql = ssql & "ISNULL(M.PADD1,'') AS PADD1,ISNULL(M.PHOTO,'') AS PHOTO,ISNULL(M.PADD2,'') AS PADD2,ISNULL(M.PADD3,'') AS PADD3,ISNULL(M.PCITY,'') AS PCITY,ISNULL(M.PSTATE,'') AS PSTATE,ISNULL(M.PPIN,'') AS PPIN,ISNULL(M.PPHONE1,'') AS PPHONE1,ISNULL(M.PPHONE2,'') AS PPHONE2,ISNULL(M.PCELL,'') AS PCELL,"
                ssql = ssql & "ISNULL(M.PEMAIL,'') AS PEMAIL,ISNULL(T.MEMBERTYPE,'') AS MEMBERTYPE FROM " & Trim(vUser) & "..MEMBERMASTER AS M LEFT OUTER JOIN  " & Trim(vUser & "") & "..MEMBERTYPE AS T ON M.MEMBERTYPECODE = T.MEMBERTYPE WHERE   MCODE ='" & Trim(vMemberCode) & "'"
                Vconn.getDataSet(ssql, "MemberMaster")
                If gdataset.Tables("MemberMaster").Rows.Count > 0 Then
                    lblType.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Membertype") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Membertype")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("Membertype")), " ")
                    lblmcode.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Mcode") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Mcode")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("Mcode")), " ")
                    lblCompany.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Company") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Company")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("company")), " ")
                    lblname.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Mname") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Mname")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("Mname")), " ")
                    lbladd1.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("padd1") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("padd1")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("padd1")), " ")
                    lbladd2.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("padd2") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("padd2")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("padd2")), " ")
                    lbladd3.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("padd3") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("padd3")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("padd3")), " ")
                    lblcity.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("pcity") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("pcity")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("pcity")), " ")
                    lblstate.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("pstate") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("pstate")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("pstate")), " ")
                    lblpin.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("ppin") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("ppin")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("ppin")), " ")
                    lblphone1.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("pphone1") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("pphone1")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("pphone1")), " ")
                    lblphone2.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("pphone2") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("pphone2")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("pphone2")), " ")
                    lblcellno.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("pcell") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("pcell")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("pcell")), " ")
                    lblEmail.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("pemail") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("pemail")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("pemail")), " ")
                End If

            End If
            If Optcommunication.Checked = True Then
                ssql = "SELECT ISNULL(M.MCODE,'') AS MCODE,ISNULL(M.TERMINATION,'') as TERMINATION,ISNULL(M.CON_MCODE,'') as CON_MCODE,ISNULL(M.MNAME,'') AS MNAME,ISNULL(M.COMPANY,'') AS COMPANY,ISNULL(M.CADD1,'') AS CADD1,ISNULL(M.PHOTO,'') AS PHOTO,ISNULL(M.CADD2,'') as CADD2,ISNULL(M.CADD3,'') As CADD3,ISNULL(M.CCITY,'') AS CCITY,"
                ssql = ssql & "ISNULL(M.CSTATE,'') AS CSTATE,ISNULL(M.CPIN,'') AS CPIN,ISNULL(M.CPHONE1,'') AS CPHONE1,ISNULL(M.CPHONE2,'') As CPHONE2,ISNULL(M.CCELL,'') AS CCELL,ISNULL(M.CEMAIL,'') as CEMAIL,ISNULL(T.MEMBERTYPE,'') AS MEMBERTYPE FROM " & Trim(vUser & "") & "..MEMBERMASTER AS M LEFT OUTER JOIN " & Trim(vUser & "") & "..MEMBERTYPE AS T ON M.MEMBERTYPECODE = T.MEMBERTYPE WHERE   MCODE ='" & Trim(vMemberCode) & "' "
                Vconn.getDataSet(ssql, "MemberMaster")
                If gdataset.Tables("MemberMaster").Rows.Count > 0 Then
                    If gdataset.Tables("MemberMaster").Rows(0).Item("Termination") = "C" Then
                        lbltermination.Text = "CONVERTED - " & Trim(gdataset.Tables("MemberMaster").Rows(0).Item("CON_MCODE") & "")
                    End If
                    lblType.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Membertype") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Membertype")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("Membertype")), " ")
                    lblmcode.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Mcode") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Mcode")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("Mcode")), " ")
                    lblCompany.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Company") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Company")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("company")), " ")
                    lblname.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Mname") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Mname")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("Mname")), " ")
                    lbladd1.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cadd1") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cadd1")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cadd1")), " ")
                    lbladd2.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cadd2") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cadd2")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cadd2")), " ")
                    lbladd3.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cadd3") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cadd3")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cadd3")), " ")
                    lblcity.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("ccity") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("ccity")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("ccity")), " ")
                    lblstate.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cstate") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cstate")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cstate")), " ")
                    lblpin.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cpin") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cpin")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cpin")), " ")
                    lblphone1.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cphone1") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cphone1")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cphone1")), " ")
                    lblphone2.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cphone2") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cphone2")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cphone2")), " ")
                    lblcellno.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("ccell") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("ccell")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("ccell")), " ")
                    lblEmail.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cEmail") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cemail")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cemail")), " ")
                End If
            End If
        End If
    End Sub
    Private Sub Memberhelp1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim SideLedgerList As Object
        If KeyAscii = System.Windows.Forms.Keys.Escape Then
            Me.Close()
            SideLedgerList = Nothing
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub MyFillGrid1()
        Dim SQLSTRING As String
        Dim gCompanyname As Object
        If OptOthers.Checked Then
            SQLSTRING = "SELECT ISNULL(PNAME,'') AS PNAME FROM ADDRESSSEARCH WHERE PNAME LIKE '" & (Trim(txtSelection.Text)) & "%' ORDER BY PNAME"
        Else
            If optMCode.Checked = True Then
                SQLSTRING = "SELECT ISNULL(SUBNAME,'') AS SUBNAME,ISNULL(SUBCODE,'') AS SUBCODE FROM " & Trim(vUser & "") & "..SUBLEDGERLIST1 "
                SQLSTRING = SQLSTRING & " WHERE   SUBCODE LIKE '" & (Trim(txtSelection.Text)) & "%' "
                SQLSTRING = SQLSTRING & " AND ACCODE='" & Trim(gDebitors) & "' ORDER BY SUBCODE "
            ElseIf optAccName.Checked Then
                SQLSTRING = "SELECT ISNULL(SUBNAME,'') AS SUBNAME,ISNULL(SUBCODE,'') AS SUBCODE FROM " & Trim(vUser & "") & "..SUBLEDGERLIST1 "
                SQLSTRING = SQLSTRING & " WHERE   SUBNAME LIKE '" & (Trim(txtSelection.Text)) & "%' "
                SQLSTRING = SQLSTRING & " AND ACCODE='" & Trim(gDebitors) & "' ORDER BY SUBCODE "
            ElseIf OptCompany.Checked Then
                SQLSTRING = "SELECT ISNULL(COMPANY,'') AS COMPANY,ISNULL(MCODE,'') AS MCODE FROM " & Trim(vUser & "") & "..MEMBERMASTER WHERE UPPER(COMPANY) LIKE '" & (Trim(txtSelection.Text)) & "%' ORDER BY COMPANY,MCODE"
            End If
        End If
        Vconn.getDataSet(SQLSTRING, "SubledgerList1")
        Dim loopindex As Integer
        If gdataset.Tables("SubledgerList1").Rows.Count > 0 Then
            If fgrdSelectionList.Rows < gdataset.Tables("SubledgerList1").Rows.Count - 1 Then
                fgrdSelectionList.Rows = gdataset.Tables("SubledgerList1").Rows.Count + 3
            End If
            For loopindex = 0 To gdataset.Tables("SubledgerList1").Rows.Count - 1
                fgrdSelectionList.set_TextMatrix(loopindex + 1, 0, CStr(gdataset.Tables("SubledgerList1").Rows(loopindex).Item("SubName")))
                fgrdSelectionList.set_TextMatrix(loopindex + 1, 1, CStr(gdataset.Tables("SubledgerList1").Rows(loopindex).Item("SubCode")))
            Next
        Else
            lblAmount.Text = ""
            MsgBox("Details not found.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "" & gCompanyname)
            txtSelection.Text = ""
            txtSelection.Focus()
            FormUnload = True
        End If
    End Sub
    Private Sub GetMemAcc()
        Dim adLockPessimistic, adOpenDynamic, MainMenu, ADODB As Object
        vSql = "SELECT ISNULL(SLCODE,'') AS SLCODE FROM " & Trim(vUser & "") & "..ACCOUNTSSUBLEDGERMASTER WHERE SLCODE ='" & Trim(lblmcode.Text) & "'"
        Vconn.getDataSet(vSql, "ACCOUNTSSUBLEDGERMASTER")
        If gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows.Count > 0 Then
            vMemAcc = Trim(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("SLCODE") & "")
        End If
    End Sub
    Private Sub Memberhelp1_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        If FormUnload Then
            Me.Hide()
        End If
    End Sub
    Private Sub Memberhelp1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim gConnection As Object
        lblType.Text = ""
        lblname.Text = ""
        lblmcode.Text = ""
        lbladd1.Text = ""
        lbladd2.Text = ""
        lbladd3.Text = ""
        lblcity.Text = ""
        lblstate.Text = ""
        lblpin.Text = ""
        lblphone1.Text = ""
        lblphone2.Text = ""
        lblcellno.Text = ""
        lblEmail.Text = ""
        lblAmount.Text = ""
        lblCompany.Text = ""
        gPicture = ""
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        lbltermination.Text = ""
        Me.Text = "Member Details"
        Optcommunication.Checked = True
        vUser = gDatabase
        txtSelection.Focus()
    End Sub

    Private Sub Label5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label5.Click
        Me.Close()
        Memberhelp1.DefInstance = Nothing
    End Sub
   
    Private Sub mskfrom_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim DateBoxBlocking As Object
        'Call DateBoxBlocking(mskfrom)
    End Sub
    'Private Sub MskFrom_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSMask.MaskEdBoxEvents_KeyPressEvent)
    '    If eventArgs.keyAscii = System.Windows.Forms.Keys.Return Then
    '        Mskto.Focus()
    '    End If
    'End Sub
    'Private Sub mskTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '    Dim DateBoxBlocking As Object
    '    'Call DateBoxBlocking(mskTo)
    'End Sub
    'Private Sub Mskto_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSMask.MaskEdBoxEvents_KeyPressEvent)
    '    If eventArgs.keyAscii = System.Windows.Forms.Keys.Return Then
    '        Command1.Focus()
    '    End If
    'End Sub
    Private Sub optAccName_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAccName.CheckedChanged
        If eventSender.Checked Then
            cmdGetDetails.Visible = True
            Label3.Visible = True
        End If
    End Sub

    Private Sub optAccName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optAccName.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            cmdGetDetails.Visible = True
            Label3.Visible = True
            txtSelection.Focus()
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub Optcommunication_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Optcommunication.CheckedChanged
        If eventSender.Checked Then
            Call fgrdSelectionList_RowColChange(fgrdSelectionList, New System.EventArgs)
        End If
    End Sub

    Private Sub OptCommunication_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Optcommunication.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            fgrdSelectionList.Focus()
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub OptCompany_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptCompany.CheckedChanged
        If eventSender.Checked Then
            cmdGetDetails.Visible = True
            Label3.Visible = True
        End If
    End Sub

    Private Sub OptMcode_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optMCode.CheckedChanged
        If eventSender.Checked Then
            cmdGetDetails.Visible = True
            Label3.Visible = True
        End If
    End Sub
    Private Sub optMCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optMCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            cmdGetDetails.Visible = True
            Label3.Visible = True
            txtSelection.Focus()
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub OptOthers_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptOthers.CheckedChanged
        If eventSender.Checked Then
            cmdGetDetails.Visible = False
            Label3.Visible = False
        End If
    End Sub

    Private Sub OptPermanent_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptPermanent.CheckedChanged
        If eventSender.Checked Then
            Call fgrdSelectionList_RowColChange(fgrdSelectionList, New System.EventArgs)
        End If
    End Sub

    Private Sub OptPermanent_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles OptPermanent.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            fgrdSelectionList.Focus()
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub PImage_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PImage.DoubleClick
        If Dir("\Program Files\Internet Explorer\Iexplore.exe") <> "" And gPicture <> "" Then
            Call Shell("\Program Files\Internet Explorer\Iexplore.exe " & Application.StartupPath & "\Photos\" & gPicture, AppWinStyle.MaximizedFocus)
        End If
    End Sub
    Private Sub txtMembers_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMembers.Click
        Dim OpenTextFile, gPrint, gCompanyname, DoubleApostrophe, MainMenu As Object
        Dim ssql, VOutputfile, vOutputfile1, vCaption, vType, SSQL1 As String
        Dim vTtotal, vLtotal, I As Integer
        Dim vLen, vLen1 As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        vOutputfile1 = Mid("TME" & CStr(Int(Rnd() * 5000)), 1, 8)
        SSQL1 = " SELECT * FROM SYSOBJECTS WHERE TYPE = 'U' AND NAME = '" & Trim(vOutputfile1) & "'"
        Vconn.getDataSet(SSQL1, "SYSOBJECTS")
        If gdataset.Tables("SYSOBJECTS").Rows.Count > 0 Then
            SSQL1 = "DROP TABLE  " & vOutputfile1 & ""
            gcommand = New SqlClient.SqlCommand(SSQL1, Vconn.Myconn)
            Vconn.openConnection()
            gcommand.ExecuteNonQuery()
            Vconn.closeConnection()
            SSQL1 = "CREATE TABLE " & vOutputfile1 & " (MemberType varchar(30),Termination numeric(5) default 0,Live numeric(5) default 0)"
            gcommand = New SqlClient.SqlCommand(SSQL1, Vconn.Myconn)
            Vconn.openConnection()
            gcommand.ExecuteNonQuery()
            Vconn.closeConnection()
            ssql = "SELECT * FROM MEMBERTYPE ORDER BY MEMBERTYPE"
            Vconn.getDataSet(ssql, "membertype")
            If gdataset.Tables("membertype").Rows.Count > 0 Then
                For I = 0 To gdataset.Tables("membertype").Rows.Count - 1
                    vLen = Len(gdataset.Tables("membertype").Rows(I).Item("membertype"))
                    If CStr(gdataset.Tables("membertype").Rows(I).Item("membertype")) = "LTT" Then
                        vType = gdataset.Tables("membertype").Rows(I).Item("Membertype")
                    End If
                    If CStr(gdataset.Tables("membertype").Rows(I).Item("membertype")) <> "LTT" Then
                        ssql = "SELECT COUNT(*) FROM MEMBERMASTER WHERE MEMBERTYPECODE='" & (Trim(CStr(gdataset.Tables("membertype").Rows(I).Item("Membertype")))) & "' and (Isnull(Termination,'') =' ' or Isnull(Termination,'') ='' or Isnull(Termination,'') ='N')   AND MCODE<>' ' "
                        Vconn.getDataSet(ssql, "MEMBERMASTER")
                        If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                            ssql = "INSERT INTO " & vOutputfile1 & " (MemberType,Live) VALUES('" & (gdataset.Tables("membertype").Rows(I).Item("Membertype")) & "'," & gdataset.Tables("membertype").Rows(0).Item(0) & ")"
                            gcommand = New SqlClient.SqlCommand(ssql, Vconn.Myconn)
                            Vconn.openConnection()
                            gcommand.ExecuteNonQuery()
                            Vconn.closeConnection()
                        End If
                        ssql = "SELECT COUNT(*) FROM MEMBERMASTER WHERE MEMBERTYPECODE='" & (Trim(CStr(gdataset.Tables("membertype").Rows(I).Item("Membertype")))) & "' and (Isnull(Termination,'') <>' ') AND MCODE<>' ' "
                        Vconn.getDataSet(ssql, "MEMBERMASTER")
                        If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                            ssql = "UPDATE " & vOutputfile1 & " SET TERMINATION = " & gdataset.Tables("membertype").Rows(I).Item(0) & " WHERE MEMBERTYPE ='" & Trim(gdataset.Tables("membertype").Rows(I).Item("Membertype")) & "'"
                            gcommand = New SqlClient.SqlCommand(ssql, Vconn.Myconn)
                            Vconn.openConnection()
                            gcommand.ExecuteNonQuery()
                            Vconn.closeConnection()
                        End If
                    End If
                Next
            End If
            Randomize()
            FileClose()
            VOutputfile = Mid("TMEM" & CStr(Int(Rnd() * 5000)), 1, 8)
            FileOpen(1, AppPath & "\Reports\" & VOutputfile & ".txt", OpenMode.Output)
            vCaption = "Total Members as " & Format(Today, "dd/MM/yyyy")
            PrintLine(1)
            PrintLine(1)
            PrintLine(1, Trim(gCompanyname & ""))
            PrintLine(1, vCaption)
            PrintLine(1, New String("-", 71))
            PrintLine(1, "|Type of Member                |Not Normal|Live Members|Total Members|")
            PrintLine(1, New String("-", 71))
            ssql = "SELECT * FROM  " & vOutputfile1 & " ORDER BY MEMBERTYPE"
            Vconn.getDataSet(ssql, "MEMBERTYPE")
            If gdataset.Tables("MEMBERTYPE").Rows.Count > 0 Then
                For I = 0 To gdataset.Tables("MEMBERTYPE").Rows.Count - 1
                    PrintLine(1, "|" & Trim(gdataset.Tables("MEMBERTYPE").Rows(I).Item("MemberType") & "") & Space(30 - Len(Trim(gdataset.Tables("MEMBERTYPE").Rows(I).Item("MemberType") & ""))) & "|" & Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination"), "0") & Space(11 - Len(Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination"), "0"))) & "|" & Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live"), "0") & Space(12 - Len(Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live"), "0"))) & "|" & Format(CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination")) + CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live")), "0") & Space(13 - Len(Format(CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination")) + CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live")), "0"))) & "|")
                    vLtotal = vLtotal + Val(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live") & "")
                    vTtotal = vTtotal + Val(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination") & "")
                Next
            End If
            PrintLine(1, New String("-", 71))
            PrintLine(1, "|" & "TOTAL" & Space(30 - Len("TOTAL")) & "|" & Format(vTtotal, "0") & Space(11 - Len(Format(vTtotal, "0"))) & "|" & Format(vLtotal, "0") & Space(12 - Len(Format(vLtotal, "0"))) & "|" & Format(vTtotal + vLtotal, "0") & Space(13 - Len(Format(vLtotal + vTtotal, "0"))) & "|")
            PrintLine(1, New String("-", 71))
            FileClose(1)
            gPrint = False
            ssql = "DROP TABLE  " & vOutputfile1 & ""
            gcommand = New SqlClient.SqlCommand(ssql, Vconn.Myconn)
            Vconn.openConnection()
            gcommand.ExecuteNonQuery()
            Vconn.closeConnection()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            'Call OpenTextFile(vOutputfile1)
        Else
            SSQL1 = "CREATE TABLE " & vOutputfile1 & " (MemberType varchar(30),Termination numeric(5) default 0,Live numeric(5) default 0)"
            gcommand = New SqlClient.SqlCommand(SSQL1, Vconn.Myconn)
            Vconn.openConnection()
            gcommand.ExecuteNonQuery()
            Vconn.closeConnection()
            ssql = "SELECT * FROM MEMBERTYPE ORDER BY MEMBERTYPE"
            Vconn.getDataSet(ssql, "membertype")
            If gdataset.Tables("membertype").Rows.Count > 0 Then
                For I = 0 To gdataset.Tables("membertype").Rows.Count - 1
                    vLen = Len(gdataset.Tables("membertype").Rows(I).Item("membertype"))
                    If CStr(gdataset.Tables("membertype").Rows(I).Item("membertype")) = "LTT" Then
                        vType = gdataset.Tables("membertype").Rows(I).Item("Membertype")
                    End If
                    If CStr(gdataset.Tables("membertype").Rows(I).Item("membertype")) <> "LTT" Then
                        ssql = "SELECT COUNT(*) FROM MEMBERMASTER WHERE MEMBERTYPECODE='" & (Trim(CStr(gdataset.Tables("membertype").Rows(I).Item("Membertype")))) & "' and (Isnull(Termination,'') =' ' or Isnull(Termination,'') ='' or Isnull(Termination,'') ='N')   AND MCODE<>' ' "
                        Vconn.getDataSet(ssql, "MEMBERMASTER")
                        If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                            ssql = "INSERT INTO " & vOutputfile1 & " (MemberType,Live) VALUES('" & (gdataset.Tables("membertype").Rows(I).Item("Membertype")) & "'," & gdataset.Tables("membertype").Rows(0).Item(0) & ")"
                            gcommand = New SqlClient.SqlCommand(ssql, Vconn.Myconn)
                            Vconn.openConnection()
                            gcommand.ExecuteNonQuery()
                            Vconn.closeConnection()
                        End If
                        ssql = "SELECT COUNT(*) FROM MEMBERMASTER WHERE MEMBERTYPECODE='" & (Trim(CStr(gdataset.Tables("membertype").Rows(I).Item("Membertype")))) & "' and (Isnull(Termination,'') <>' ') AND MCODE<>' ' "
                        Vconn.getDataSet(ssql, "MEMBERMASTER")
                        If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                            ssql = "UPDATE " & vOutputfile1 & " SET TERMINATION = " & gdataset.Tables("membertype").Rows(I).Item(0) & " WHERE MEMBERTYPE ='" & DoubleApostrophe(gdataset.Tables("membertype").Rows(I).Item("Membertype")) & "'"
                            gcommand = New SqlClient.SqlCommand(ssql, Vconn.Myconn)
                            Vconn.openConnection()
                            gcommand.ExecuteNonQuery()
                            Vconn.closeConnection()
                        End If
                    End If
                Next
            End If
            Randomize()
            FileClose()
            VOutputfile = Mid("TMEM" & CStr(Int(Rnd() * 5000)), 1, 8)
            FileOpen(1, AppPath & "\Reports\" & VOutputfile & ".txt", OpenMode.Output)
            vCaption = "Total Members as " & Format(Today, "dd/MM/yyyy")
            PrintLine(1)
            PrintLine(1)
            PrintLine(1, Trim(gCompanyname & ""))
            PrintLine(1, vCaption)
            PrintLine(1, New String("-", 71))
            PrintLine(1, "|Type of Member                |Not Normal|Live Members|Total Members|")
            PrintLine(1, New String("-", 71))
            ssql = "SELECT * FROM  " & vOutputfile1 & " ORDER BY MEMBERTYPE"
            Vconn.getDataSet(ssql, "MEMBERTYPE")
            If gdataset.Tables("MEMBERTYPE").Rows.Count > 0 Then
                For I = 0 To gdataset.Tables("MEMBERTYPE").Rows.Count - 1
                    PrintLine(1, "|" & Trim(gdataset.Tables("MEMBERTYPE").Rows(I).Item("MemberType") & "") & Space(30 - Len(Trim(gdataset.Tables("MEMBERTYPE").Rows(I).Item("MemberType") & ""))) & "|" & Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination"), "0") & Space(11 - Len(Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination"), "0"))) & "|" & Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live"), "0") & Space(12 - Len(Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live"), "0"))) & "|" & Format(CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination")) + CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live")), "0") & Space(13 - Len(Format(CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination")) + CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live")), "0"))) & "|")
                    vLtotal = vLtotal + Val(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live") & "")
                    vTtotal = vTtotal + Val(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination") & "")
                Next
            End If
            PrintLine(1, New String("-", 71))
            PrintLine(1, "|" & "TOTAL" & Space(30 - Len("TOTAL")) & "|" & Format(vTtotal, "0") & Space(11 - Len(Format(vTtotal, "0"))) & "|" & Format(vLtotal, "0") & Space(12 - Len(Format(vLtotal, "0"))) & "|" & Format(vTtotal + vLtotal, "0") & Space(13 - Len(Format(vLtotal + vTtotal, "0"))) & "|")
            PrintLine(1, New String("-", 71))
            FileClose(1)
            gPrint = False
            ssql = "DROP TABLE  " & vOutputfile1 & ""
            gcommand = New SqlClient.SqlCommand(ssql, Vconn.Myconn)
            Vconn.openConnection()
            gcommand.ExecuteNonQuery()
            Vconn.closeConnection()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            'Call OpenTextFile(vOutputfile1)
        End If
    End Sub

    Private Sub txtSelection_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSelection.TextChanged
        If Trim(txtSelection.Text) <> "" Then
            Call txtSelection_Leave(eventSender, eventArgs)
        End If
    End Sub
    Private Sub txtSelection_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSelection.Enter
        'Call ClearGrid(SSGrid)
        TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&H80FF)
        TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        TxtBalance.Text = ""
        txtReceipts.Text = ""
        txtSales.Text = ""
        fraDetails.Visible = False
        FraDependents.Visible = False
    End Sub
    Private Sub txtSelection_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSelection.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim SideLedgerList As Object
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            fgrdSelectionList.Focus()
        End If
        If KeyAscii = System.Windows.Forms.Keys.Escape Then
            'Unload(SideLedgerList)
            SideLedgerList = Nothing
        End If
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtSelection_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSelection.Leave
        Try
            Dim vFormatstring As String
            If OptOthers.Checked Then
                fgrdSelectionList.Clear()
                'Call MyFillGrid1()
            Else
                vFormatstring = "MEMBER NAME                                                               | MEMBER CODE "
                fgrdSelectionList.Clear()
                fgrdSelectionList.FormatString = vFormatstring
                'Call MyFillGrid1()
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub FillGrid1()
        Dim MainMenu As Object
        ' Dim gDebtors As Object
        Dim ADODB As Object
        Dim sstr As String
        Dim loopindex, i As Integer
        If IsDate(Mskfrom.Value) = False Then
            MsgBox("From date format is wrong", MsgBoxStyle.Critical, Me.Text)
            Mskfrom.Focus()
            Exit Sub
        End If
        If IsDate(Mskto.Value) = False Then
            MsgBox("To date format is wrong", MsgBoxStyle.Critical, Me.Text)
            Mskto.Focus()
            Exit Sub
        End If
        If DateDiff(Microsoft.VisualBasic.DateInterval.Day, CDate(Mskfrom.Value), CDate(Mskto.Value)) < 0 Then
            MsgBox("From date should be Less then To date !!", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If
        If lblmcode.Text = "" Then
            MsgBox("Member Code should visible", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If
        sSgrid.ClearRange(1, 1, -1, -1, True)
        TxtBalance.Text = ""
        txtReceipts.Text = ""
        TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        txtSales.Text = ""
        Call GetMemAcc()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        vTotal = 0
        Call GetOpBal()
        sstr = "SELECT * FROM  " & Trim(vUser & "") & "..JOURNALENTRY WHERE ACCOUNTCODE =  '" & Trim(gDebitors) & "' AND SLCODE= '" & Trim(vMemAcc) & "' AND  VOUCHERDATE >= '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND VOUCHERDATE <= '" & Format(Mskto.Value, "dd/MMM/yyyy") & "'"
        sstr = sstr & "  AND ISNULL(VOID,'') <> 'Y' AND ISNULL(VOID,'') <> 'C' ORDER BY VOUCHERDATE,VOUCHERNO"
        Vconn.getDataSet(sstr, "Journalentry")
        loopindex = 2
        If gdataset.Tables("Journalentry").Rows.Count > 0 Then

            For i = 0 To gdataset.Tables("Journalentry").Rows.Count - 1
                sSgrid.SetText(1, loopindex, gdataset.Tables("Journalentry").Rows(i).Item("Voucherno"))
                sSgrid.SetText(2, loopindex, Format(gdataset.Tables("Journalentry").Rows(i).Item("voucherdate"), "dd/MM/yyyy"))
                sSgrid.SetText(3, loopindex, gdataset.Tables("Journalentry").Rows(i).Item("vouchercategory"))

                If UCase(CStr(gdataset.Tables("Journalentry").Rows(i).Item("Creditdebit"))) = "CREDIT" Then
                    If CDbl(gdataset.Tables("Journalentry").Rows(i).Item("Receiptno")) > 0 Then
                        sSgrid.SetText(1, loopindex, gdataset.Tables("Journalentry").Rows(i).Item("Receiptno"))
                    Else
                        sSgrid.SetText(1, loopindex, gdataset.Tables("Journalentry").Rows(i).Item("Voucherno"))
                    End If
                    sSgrid.Col = 4
                    sSgrid.Row = loopindex
                    sSgrid.Text = Format(gdataset.Tables("Journalentry").Rows(i).Item("Amount"), "0.00")

                    txtReceipts.Text = Format(Val(txtReceipts.Text) + Val(CStr(gdataset.Tables("Journalentry").Rows(i).Item("Amount"))), "0.00")
                    vTotal = vTotal - Val(gdataset.Tables("Journalentry").Rows(i).Item("Amount") & "")
                Else
                    sSgrid.Col = 5
                    sSgrid.Row = loopindex
                    sSgrid.Text = Format(gdataset.Tables("Journalentry").Rows(i).Item("Amount"), "0.00")

                    txtSales.Text = Format(Val(txtSales.Text) + Val(CStr(gdataset.Tables("Journalentry").Rows(i).Item("Amount"))), "0.00")
                    vTotal = vTotal + Val(gdataset.Tables("Journalentry").Rows(i).Item("Amount") & "")
                End If

                sSgrid.SetText(6, loopindex, vTotal)
                loopindex = loopindex + 1
                If loopindex > 50 Then
                    sSgrid.MaxRows = sSgrid.MaxRows + 1
                End If
            Next
        Else
            MsgBox("There is no Transactions", MsgBoxStyle.Information, Me.Text)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If
        Call GetTotal()
        Me.Cursor = System.Windows.Forms.Cursors.Default
        TxtBalance.Text = CStr(Val(txtSales.Text) - Val(txtReceipts.Text))
        TxtBalance.Text = Format(Val(TxtBalance.Text), "0.00")
        If Val(TxtBalance.Text) < 0 Then
            TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&H80FF)
        End If
    End Sub
    Private Sub GetOpBal()
        Dim i As Integer
        Dim MainMenu As Object
        Dim ADODB As Object
        Dim ssql As String
        Dim vReceipts, vSales As Double
        Dim vopbal As Double
        ssql = "SELECT ISNULL(CREDITDEBIT,'') AS  CREDITDEBIT,SUM(AMOUNT) AS AMT FROM " & Trim(vUser & "") & "..OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "' AND VOUCHERDATE < '" & Format(Mskfrom.Value, "dd-MMM-yyyy") & "' GROUP BY CREDITDEBIT"
        Vconn.getDataSet(ssql, "Outstanding")
        If gdataset.Tables("Outstanding").Rows.Count > 0 Then
            vopbal = 0
            For i = 0 To gdataset.Tables("Outstanding").Rows.Count - 1
                If UCase(CStr(gdataset.Tables("Outstanding").Rows(i).Item("Creditdebit"))) = "CREDIT" Then
                    vReceipts = Val(gdataset.Tables("Outstanding").Rows(i).Item("Amt") & "")
                ElseIf UCase(CStr(gdataset.Tables("Outstanding").Rows(i).Item("Creditdebit"))) = "DEBIT" Then
                    vSales = Val(gdataset.Tables("Outstanding").Rows(i).Item("Amt") & "")
                End If
            Next
        End If
        vopbal = vSales - vReceipts
        If sSgrid.DataRowCnt = 0 Then
            If vopbal >= 0 Then
                sSgrid.SetText(3, 1, "Opening Balance  -->")
                sSgrid.SetText(5, 1, Format(vopbal, "0.00"))
                sSgrid.SetText(6, 1, Format(vopbal, "0.00"))
                'vTotal = vTotal + vopbal
                vTotal = vTotal + vopbal
            ElseIf vopbal <= 0 Then
                vopbal = -(vopbal)
                sSgrid.SetText(3, 1, "Opening Balance  -->")
                sSgrid.SetText(4, 1, Format(vopbal, "0.00"))
                sSgrid.SetText(6, 1, Format(vopbal, "0.00"))
                'vTotal = vTotal - vopbal
                vTotal = vTotal - vopbal
            End If
        End If
        Call GetTotal()
    End Sub
    Private Sub GetTotal()
        txtReceipts.Text = ""
        txtSales.Text = ""
        Dim vReceipts, vSales As Double
        Dim loopindex As Integer
        For loopindex = 1 To sSgrid.DataRowCnt
            sSgrid.Col = 4
            sSgrid.Row = loopindex
            vReceipts = Val(sSgrid.Text)

            sSgrid.Col = 5
            sSgrid.Row = loopindex
            vSales = Val(sSgrid.Text)


            If Val(vReceipts) > 0 Then
                txtReceipts.Text = Format(Val(txtReceipts.Text) + Val(vReceipts), "0.00")
            End If
            If Val(vSales) > 0 Then
                txtSales.Text = Format(Val(txtSales.Text) + Val(vSales), "0.00")
            End If
        Next loopindex
        TxtBalance.Text = ""
        If Val(txtReceipts.Text) > 0 Or Val(txtSales.Text) > 0 Then
            TxtBalance.Text = Format(Val(txtSales.Text) - Val(txtReceipts.Text), "0.00")
        End If
        If Val(TxtBalance.Text) < 0 Then
            TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&H80FF)
        End If
    End Sub
    Private Sub PrintOperation()
        Dim PrintTextFile As Object
        Dim OpenTextFile As Object
        Dim gPrint As Object
        Dim gUserName As Object
        Dim gDemo As Object
        Dim gCompanyname As Object
        Randomize()
        Dim ssql As String
        Dim VOutputfile As String
        Dim vSales, vDescription, vBillNo, vbilldate, vReceipts, vBalance As Object
        Dim vPageNumber As Integer
        Dim VRowCount As Integer
        Dim loopindex As Double
        Dim vCaption As String
        Dim vMCode As String
        Dim vMembername As String
        VOutputfile = Mid("MSTA" & CStr(Int(Rnd() * 5000)), 1, 8)
        If sSgrid.DataRowCnt = 0 Then
            MsgBox("Empty Details cannot be Print", MsgBoxStyle.Information, "Member Statement")
            Exit Sub
        End If
        vMCode = Trim(lblmcode.Text & "")
        vMembername = Trim(lblname.Text & "")
        FileClose()
        FileOpen(1, Application.StartupPath & "\Reports\" & VOutputfile & ".txt", OpenMode.Output)
        vPageNumber = 1
        vCaption = "SALES & RECEIPTS FROM " & Format(Mskfrom.Value, "dd/MM/yyyy") & " To " & Format(Mskto.Value, "dd/MM/yyyy")
        PrintLine(1, Space(55) & "PAGE NO : " & vPageNumber)
        PrintLine(1, Space(55) & "DATE :" & Format(Today, "dd/MM/yyyy"))
        PrintLine(1, Chr(14) & Chr(15) & Trim(gCompanyname) & Chr(18))
        PrintLine(1, Chr(14) & Chr(15) & Trim(vMCode) & " - " & Trim(vMembername) & IIf(lblCompany.Text <> "", "   Company : " & Trim(lblCompany.Text), "") & Chr(18))
        PrintLine(1, vCaption)
        PrintLine(1, New String("-", 75))
        PrintLine(1, "BILL/RECPT       DATE         DESCRIPTION        RECEIPTS          SALES        BALANCE")
        PrintLine(1, New String("-", 75))
        VRowCount = 8
        If gDemo = True Then
            PrintLine(1, "Demo copy")
            VRowCount = VRowCount + 1
        End If
        For loopindex = 1 To sSgrid.DataRowCnt
            sSgrid.GetText(1, loopindex, vBillNo)
            sSgrid.GetText(2, loopindex, vbilldate)
            sSgrid.GetText(3, loopindex, vDescription)
            sSgrid.GetText(4, loopindex, vReceipts)
            sSgrid.GetText(5, loopindex, vSales)
            sSgrid.GetText(6, loopindex, vBalance)
            PrintLine(1, Mid(Trim(vBillNo), 1, 8) & Space(10 - Len(Mid(Trim(vBillNo), 1, 8))) & Format(vbilldate, "dd/MM/yyyy") & Space(11 - Len(Format(vbilldate, "dd/MM/yyyy"))) & Mid(Trim(vDescription), 1, 23) & Space(24 - Len(Mid(Trim(vDescription), 1, 23))) & Space(10 - Len(Format(vReceipts, "0.00"))) & Format(vReceipts, "0.00") & Space(10 - Len(Format(vSales, "0.00"))) & Format(vSales, "0.00") & Space(10 - Len(Format(vBalance, "0.00"))) & Format(vBalance, "0.00"))
            VRowCount = VRowCount + 1
            If VRowCount > 60 Then
                vPageNumber = vPageNumber + 1
                PrintLine(1, Chr(12))
                VRowCount = 0
                GoTo Header
            End If
        Next loopindex
        PrintLine(1, New String("-", 75))
        PrintLine(1, Space(43) & Space(12 - Len(Format(txtReceipts.Text, "0.00"))) & Format(txtReceipts.Text, "0.00") & Space(10 - Len(Format(txtSales.Text, "0.00"))) & Format(txtSales.Text, "0.00") & Space(10 - Len(Format(TxtBalance.Text, "0.00"))) & Format(TxtBalance.Text, "0.00"))
        PrintLine(1, New String("-", 75))
        PrintLine(1, gUserName & Space(5) & Format(Now, "dd/MM/yyyy hh:mm:ss Am/Pm") & Chr(12))
        FileClose(1)
        gPrint = True
        If gPrint = False Then
            'OpenTextFile(VFilePath)
        Else
            'PrintTextFile(VFilePath)
        End If
        Exit Sub
Header:
        PrintLine(1, Space(55) & "PAGE NO : " & vPageNumber)
        PrintLine(1, Space(55) & "DATE  : " & Format(Today, "dd/MM/yyyy"))
        PrintLine(1, Chr(14) & Chr(15) & Trim(gCompanyname) & Chr(18))
        PrintLine(1, Chr(14) & Chr(15) & Trim(vMCode) & " - " & Trim(vMembername) & Chr(18))
        PrintLine(1, vCaption)
        PrintLine(1, New String("-", 75))
        PrintLine(1, "BILL/RECPT       DATE         DESCRIPTION        RECEIPTS          SALES        BALANCE")
        PrintLine(1, New String("-", 75))
        VRowCount = 8
        If gDemo = True Then
            PrintLine(1, "Demo Copy")
            VRowCount = VRowCount + 1
        End If
        Return
    End Sub
    Private Sub vaDependents_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles vaDependents.KeyDownEvent
        Dim vphoto As Object
        If eventArgs.keyCode = System.Windows.Forms.Keys.Down Then
            vaDependents.GetText(7, vaDependents.ActiveRow + 1, vphoto)
            If Trim(vphoto & "") <> "" Then
                If Dir(Application.StartupPath & "\Photos\" & vphoto) <> "" Then
                    PImage.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\Photos\" & vphoto)
                Else
                    PImage.Image = System.Drawing.Image.FromFile("")
                    vaDependents.SetText(7, vaDependents.ActiveRow + 1, "NO")
                End If
            End If
        End If
        If eventArgs.keyCode = System.Windows.Forms.Keys.Up Then
            vaDependents.GetText(7, vaDependents.ActiveRow - 1, vphoto)
            If Trim(vphoto & "") <> "" Then
                If Dir(Application.StartupPath & "\Photos\" & vphoto) <> "" Then
                    PImage.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\Photos\" & vphoto)
                Else
                    PImage.Image = System.Drawing.Image.FromFile("")
                    vaDependents.SetText(7, vaDependents.ActiveRow - 1, "NO")
                End If
            End If
        End If
    End Sub

    Private Sub MyFillGrid()
        Dim gCompanyname As Object
        Dim adLockOptimistic As Object
        Dim adOpenDynamic As Object
        Dim MainMenu As Object
        Dim gDebtors As Object
        Dim ADODB As Object
        If OptOthers.Checked Then
            vSql = "SELECT ISNULL(PNAME,'') AS PNAME FROM ADDRESSSEARCH WHERE PNAME LIKE '" & (Trim(txtSelection.Text)) & "%' ORDER BY PNAME"
        Else
            If optMCode.Checked = True Then
                vSql = "SELECT ISNULL(SUBNAME,'') AS SUBNAME,ISNULL(SUBCODE,'') AS SUBCODE FROM " & Trim(vUser & "") & "..SUBLEDGERLIST1 "
                vSql = vSql & " WHERE   SUBCODE LIKE '" & (Trim(txtSelection.Text)) & "%' "
                vSql = vSql & " AND ACCODE='" & Trim(gDebitors) & "' ORDER BY SUBCODE "
            ElseIf optAccName.Checked Then
                vSql = "SELECT ISNULL(SUBNAME,'') AS SUBNAME,ISNULL(SUBCODE,'') AS SUBCODE FROM " & Trim(vUser & "") & "..SUBLEDGERLIST1 "
                vSql = vSql & " WHERE   SUBNAME LIKE '" & (Trim(txtSelection.Text)) & "%' "
                vSql = vSql & " AND ACCODE='" & Trim(gDebitors) & "' ORDER BY SUBCODE "
            ElseIf OptCompany.Checked Then
                vSql = "SELECT ISNULL(COMPANY,'') AS COMPANY,ISNULL(MCODE,'') AS MCODE FROM " & Trim(vUser & "") & "..MEMBERMASTER WHERE UPPER(COMPANY) LIKE '" & (Trim(txtSelection.Text)) & "%' ORDER BY COMPANY,MCODE"
            End If
        End If
        Vconn.getDataSet(vSql, "SubledgerList1")
        Dim loopindex As Integer
        If gdataset.Tables("SubledgerList1").Rows.Count > 0 Then
            If fgrdSelectionList.Rows < gdataset.Tables("SubledgerList1").Rows.Count - 1 Then
                fgrdSelectionList.Rows = gdataset.Tables("SubledgerList1").Rows.Count + 3
            End If
            For loopindex = 0 To gdataset.Tables("SubledgerList1").Rows.Count - 1
                fgrdSelectionList.set_TextMatrix(loopindex + 1, 0, CStr(gdataset.Tables("SubledgerList1").Rows(loopindex).Item("SubName")))
                fgrdSelectionList.set_TextMatrix(loopindex + 1, 1, CStr(gdataset.Tables("SubledgerList1").Rows(loopindex).Item("SubCode")))
            Next
        Else
            lblAmount.Text = ""
            MsgBox("Details not found.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "" & gCompanyname)
            FormUnload = True
        End If
    End Sub

    Private Sub Mskfrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Mskfrom.KeyDown
        If e.KeyCode = Keys.Enter Then
            Mskto.Focus()
        End If
    End Sub

    Private Sub Mskto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Mskto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Command1.Focus()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FraDependents.Visible = False
    End Sub
End Class