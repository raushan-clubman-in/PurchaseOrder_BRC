Imports System.IO
Public Class SC_Issuemaster
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
    Friend WithEvents lbl_CardCode As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Txt_Cardcode As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_Transtype As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_Fancycode As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Memberage As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Membername As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Subcode As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Membercode As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_Validto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmb_Validfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmb_Dateofbirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Txt_Amount As System.Windows.Forms.TextBox
    Friend WithEvents cmdCardCode As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmdMembercode As System.Windows.Forms.Button
    Friend WithEvents GridIssuemaster As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(SC_Issuemaster))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridIssuemaster = New AxFPSpreadADO.AxfpSpread
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.Txt_Cardcode = New System.Windows.Forms.TextBox
        Me.lbl_CardCode = New System.Windows.Forms.Label
        Me.cmdCardCode = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Cmb_Transtype = New System.Windows.Forms.ComboBox
        Me.Txt_Fancycode = New System.Windows.Forms.TextBox
        Me.Txt_Memberage = New System.Windows.Forms.TextBox
        Me.Txt_Membername = New System.Windows.Forms.TextBox
        Me.Txt_Subcode = New System.Windows.Forms.TextBox
        Me.Txt_Membercode = New System.Windows.Forms.TextBox
        Me.Cmb_Validto = New System.Windows.Forms.DateTimePicker
        Me.Cmb_Validfrom = New System.Windows.Forms.DateTimePicker
        Me.Cmb_Dateofbirth = New System.Windows.Forms.DateTimePicker
        Me.Txt_Amount = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CmdMembercode = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridIssuemaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GridIssuemaster)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 336)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(928, 224)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'GridIssuemaster
        '
        Me.GridIssuemaster.ContainingControl = Me
        Me.GridIssuemaster.DataSource = Nothing
        Me.GridIssuemaster.Location = New System.Drawing.Point(8, 16)
        Me.GridIssuemaster.Name = "GridIssuemaster"
        Me.GridIssuemaster.OcxState = CType(resources.GetObject("GridIssuemaster.OcxState"), System.Windows.Forms.AxHost.State)
        Me.GridIssuemaster.Size = New System.Drawing.Size(912, 200)
        Me.GridIssuemaster.TabIndex = 16
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(415, 638)
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
        Me.GroupBox2.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox2.Controls.Add(Me.Cmd_View)
        Me.GroupBox2.Controls.Add(Me.Cmd_Add)
        Me.GroupBox2.Location = New System.Drawing.Point(136, 576)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 56)
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
        Me.Cmd_Clear.Location = New System.Drawing.Point(8, 16)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 449
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(496, 16)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 452
        Me.Cmd_Print.Text = " Print [F10]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(616, 16)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 451
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(376, 16)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 450
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(128, 16)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 453
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 640)
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
        Me.lbl_Heading.Location = New System.Drawing.Point(368, 40)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(365, 31)
        Me.lbl_Heading.TabIndex = 7
        Me.lbl_Heading.Text = "SMART CARD ISSUE MASTER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Cardcode
        '
        Me.Txt_Cardcode.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Cardcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Cardcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cardcode.Location = New System.Drawing.Point(287, 88)
        Me.Txt_Cardcode.MaxLength = 18
        Me.Txt_Cardcode.Name = "Txt_Cardcode"
        Me.Txt_Cardcode.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Cardcode.TabIndex = 0
        Me.Txt_Cardcode.Text = ""
        '
        'lbl_CardCode
        '
        Me.lbl_CardCode.AutoSize = True
        Me.lbl_CardCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CardCode.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CardCode.Location = New System.Drawing.Point(112, 96)
        Me.lbl_CardCode.Name = "lbl_CardCode"
        Me.lbl_CardCode.Size = New System.Drawing.Size(91, 19)
        Me.lbl_CardCode.TabIndex = 419
        Me.lbl_CardCode.Text = "CARD CODE"
        '
        'cmdCardCode
        '
        Me.cmdCardCode.Image = CType(resources.GetObject("cmdCardCode.Image"), System.Drawing.Image)
        Me.cmdCardCode.Location = New System.Drawing.Point(478, 88)
        Me.cmdCardCode.Name = "cmdCardCode"
        Me.cmdCardCode.Size = New System.Drawing.Size(23, 26)
        Me.cmdCardCode.TabIndex = 420
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(112, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.TabIndex = 432
        Me.Label11.Text = "FANCY CODE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(552, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 19)
        Me.Label12.TabIndex = 433
        Me.Label12.Text = "SUB CODE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(552, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 19)
        Me.Label13.TabIndex = 434
        Me.Label13.Text = "MEMBER CODE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 19)
        Me.Label1.TabIndex = 440
        Me.Label1.Text = "VALID TO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(552, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 19)
        Me.Label2.TabIndex = 439
        Me.Label2.Text = "NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(552, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 19)
        Me.Label3.TabIndex = 438
        Me.Label3.Text = "AGE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(552, 256)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 437
        Me.Label4.Text = "DATE OF BIRTH"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(552, 296)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 19)
        Me.Label6.TabIndex = 436
        Me.Label6.Text = "BALANCE"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(112, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 19)
        Me.Label7.TabIndex = 435
        Me.Label7.Text = "VALID FROM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(112, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 19)
        Me.Label8.TabIndex = 441
        Me.Label8.Text = "TRANSACTION TYPE"
        '
        'Cmb_Transtype
        '
        Me.Cmb_Transtype.BackColor = System.Drawing.Color.Wheat
        Me.Cmb_Transtype.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Transtype.Items.AddRange(New Object() {"CASH", "CREDIT", "BOTH"})
        Me.Cmb_Transtype.Location = New System.Drawing.Point(287, 248)
        Me.Cmb_Transtype.Name = "Cmb_Transtype"
        Me.Cmb_Transtype.Size = New System.Drawing.Size(192, 27)
        Me.Cmb_Transtype.TabIndex = 6
        '
        'Txt_Fancycode
        '
        Me.Txt_Fancycode.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Fancycode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Fancycode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Fancycode.Location = New System.Drawing.Point(288, 128)
        Me.Txt_Fancycode.MaxLength = 10
        Me.Txt_Fancycode.Name = "Txt_Fancycode"
        Me.Txt_Fancycode.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Fancycode.TabIndex = 2
        Me.Txt_Fancycode.Text = ""
        '
        'Txt_Memberage
        '
        Me.Txt_Memberage.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Memberage.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Memberage.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Memberage.Location = New System.Drawing.Point(712, 208)
        Me.Txt_Memberage.MaxLength = 2
        Me.Txt_Memberage.Name = "Txt_Memberage"
        Me.Txt_Memberage.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Memberage.TabIndex = 12
        Me.Txt_Memberage.Text = ""
        '
        'Txt_Membername
        '
        Me.Txt_Membername.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Membername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Membername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Membername.Location = New System.Drawing.Point(712, 168)
        Me.Txt_Membername.MaxLength = 30
        Me.Txt_Membername.Name = "Txt_Membername"
        Me.Txt_Membername.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Membername.TabIndex = 11
        Me.Txt_Membername.Text = ""
        '
        'Txt_Subcode
        '
        Me.Txt_Subcode.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Subcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Subcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Subcode.Location = New System.Drawing.Point(712, 128)
        Me.Txt_Subcode.MaxLength = 6
        Me.Txt_Subcode.Name = "Txt_Subcode"
        Me.Txt_Subcode.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Subcode.TabIndex = 10
        Me.Txt_Subcode.Text = ""
        '
        'Txt_Membercode
        '
        Me.Txt_Membercode.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Membercode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Membercode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Membercode.Location = New System.Drawing.Point(712, 88)
        Me.Txt_Membercode.MaxLength = 10
        Me.Txt_Membercode.Name = "Txt_Membercode"
        Me.Txt_Membercode.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Membercode.TabIndex = 9
        Me.Txt_Membercode.Text = ""
        '
        'Cmb_Validto
        '
        Me.Cmb_Validto.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Validto.CalendarMonthBackground = System.Drawing.Color.White
        Me.Cmb_Validto.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.Cmb_Validto.CustomFormat = "dd/MM/yyyy"
        Me.Cmb_Validto.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Validto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cmb_Validto.Location = New System.Drawing.Point(288, 208)
        Me.Cmb_Validto.Name = "Cmb_Validto"
        Me.Cmb_Validto.Size = New System.Drawing.Size(184, 26)
        Me.Cmb_Validto.TabIndex = 5
        '
        'Cmb_Validfrom
        '
        Me.Cmb_Validfrom.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Validfrom.CalendarMonthBackground = System.Drawing.Color.White
        Me.Cmb_Validfrom.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.Cmb_Validfrom.CustomFormat = "dd/MM/yyyy"
        Me.Cmb_Validfrom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Validfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cmb_Validfrom.Location = New System.Drawing.Point(288, 168)
        Me.Cmb_Validfrom.Name = "Cmb_Validfrom"
        Me.Cmb_Validfrom.Size = New System.Drawing.Size(184, 26)
        Me.Cmb_Validfrom.TabIndex = 4
        '
        'Cmb_Dateofbirth
        '
        Me.Cmb_Dateofbirth.CalendarFont = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Dateofbirth.CalendarMonthBackground = System.Drawing.Color.White
        Me.Cmb_Dateofbirth.CalendarTitleForeColor = System.Drawing.Color.AliceBlue
        Me.Cmb_Dateofbirth.CustomFormat = "dd/MM/yyyy"
        Me.Cmb_Dateofbirth.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Dateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cmb_Dateofbirth.Location = New System.Drawing.Point(712, 248)
        Me.Cmb_Dateofbirth.Name = "Cmb_Dateofbirth"
        Me.Cmb_Dateofbirth.Size = New System.Drawing.Size(184, 26)
        Me.Cmb_Dateofbirth.TabIndex = 13
        '
        'Txt_Amount
        '
        Me.Txt_Amount.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Amount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Amount.Enabled = False
        Me.Txt_Amount.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Amount.Location = New System.Drawing.Point(712, 288)
        Me.Txt_Amount.MaxLength = 10
        Me.Txt_Amount.Name = "Txt_Amount"
        Me.Txt_Amount.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Amount.TabIndex = 14
        Me.Txt_Amount.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Wheat
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(288, 288)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(189, 26)
        Me.TextBox1.TabIndex = 442
        Me.TextBox1.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(120, 296)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 19)
        Me.Label9.TabIndex = 443
        Me.Label9.Text = "AMOUNT"
        '
        'CmdMembercode
        '
        Me.CmdMembercode.Image = CType(resources.GetObject("CmdMembercode.Image"), System.Drawing.Image)
        Me.CmdMembercode.Location = New System.Drawing.Point(904, 88)
        Me.CmdMembercode.Name = "CmdMembercode"
        Me.CmdMembercode.Size = New System.Drawing.Size(23, 26)
        Me.CmdMembercode.TabIndex = 444
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(392, 592)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 454
        Me.Cmd_Freeze.Text = "Freeze [F8]"
        '
        'SC_Issuemaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1014, 716)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cmd_Freeze)
        Me.Controls.Add(Me.CmdMembercode)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txt_Amount)
        Me.Controls.Add(Me.Cmb_Dateofbirth)
        Me.Controls.Add(Me.Cmb_Validfrom)
        Me.Controls.Add(Me.Cmb_Validto)
        Me.Controls.Add(Me.Txt_Membercode)
        Me.Controls.Add(Me.Txt_Subcode)
        Me.Controls.Add(Me.Txt_Membername)
        Me.Controls.Add(Me.Txt_Memberage)
        Me.Controls.Add(Me.Txt_Fancycode)
        Me.Controls.Add(Me.Cmb_Transtype)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Txt_Cardcode)
        Me.Controls.Add(Me.lbl_CardCode)
        Me.Controls.Add(Me.cmdCardCode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "SC_Issuemaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMART CARD ACCESS CONTROL"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GridIssuemaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim gconnection As New GlobalClass
    Private Sub SC_Issuemaster(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ssql As String
        Cmb_Transtype.SelectedIndex = 0
        Call FillGroupdetails()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        GroupMasterbool = True
    End Sub
    Private Sub FillGroupdetails()
        Dim i As Integer
        Dim sqlstring As String
        sqlstring = "SELECT ISNULL(POSCODE,'') AS POSCODE,ISNULL(POSDESC,'') AS POSDESC FROM POSMASTER ORDER BY POSCODE "
        gconnection.getDataSet(sqlstring, "POSMASTER")
        If gdataset.Tables("POSMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("POSMASTER").Rows.Count - 1
                With GridIssuemaster
                    .Col = 1
                    .Row = i + 1
                    .SetText(1, i + 1, Trim(gdataset.Tables("POSMASTER").Rows(i).Item("POSDESC")))
                End With
            Next
        End If
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
    End Sub
    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call clearform(Me)
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add [F7]"
        Txt_Cardcode.Text = ""
        'Txt_Activationflag.Text = ""
        Txt_Fancycode.Text = ""
        'Txt_Password.Text = ""
        Cmb_Transtype.SelectedIndex = 0
        'Txt_Chargedvalue.Text = ""
        Txt_Membercode.Text = ""
        Txt_Subcode.Text = ""
        Txt_Membername.Text = ""
        Txt_Memberage.Text = ""
        Txt_Amount.Text = ""
        'Txt_Balance.Text = ""
        GridIssuemaster.ClearRange(1, 1, -1, -1, True)
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Call FillGroupdetails()
        Txt_Cardcode.Focus()
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strSQL As String
        If Cmd_Add.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            'strSQL = " INSERT INTO inventorygroupmaster (Groupcode,Groupdesc,Freeze,Adduser,Adddate)"
            'strSQL = strSQL & "VALUES ( '" & Trim(txt_GroupCode.Text) & "','" & Replace(Trim(txt_GroupDesc.Text), "'", "") & "',"
            strSQL = strSQL & "'N','" & Trim(gUsername) & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
            gconnection.dataOperation(1, strSQL, "inventorygroupmaster")
            Me.Cmd_Clear_Click(sender, e)
        ElseIf Cmd_Add.Text = "Update[F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
                If Me.lbl_Freeze.Visible = True Then
                    MessageBox.Show(" The Frezzed Record Can Not Be Update", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False
                End If
            End If
            strSQL = "UPDATE  inventorygroupmaster "
            'strSQL = strSQL & " SET Groupdesc='" & Replace(Trim(txt_GroupDesc.Text), "'", "") & "',"
            strSQL = strSQL & "Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm") & "',freeze='N'"
            'strSQL = strSQL & " WHERE Groupcode = '" & Trim(txt_GroupCode.Text) & "'"
            gconnection.dataOperation(2, strSQL, "inventorygroupmaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  inventorygroupmaster "
            sqlstring = sqlstring & " SET Freeze= 'Y',Adduser='" & gUsername & " ', Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            'sqlstring = sqlstring & " WHERE Groupcode = '" & Trim(txt_GroupCode.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "inventorygroupmaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        Else
            sqlstring = "UPDATE  inventorygroupmaster "
            sqlstring = sqlstring & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            'sqlstring = sqlstring & " WHERE Groupcode = '" & Trim(txt_GroupCode.Text) & "'"
            gconnection.dataOperation(4, sqlstring, "inventorygroupmaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim FrReport As New ReportDesigner
        tables = " From inventorygroupmaster"
        Gheader = "GROUP MASTER"
        'FrReport.SsGridReport.SetText(2, 1, "GROUPCODE")
        'FrReport.SsGridReport.SetText(3, 1, 15)
        'FrReport.SsGridReport.SetText(2, 2, "GROUPDESC")
        'FrReport.SsGridReport.SetText(3, 2, 35)
        'FrReport.SsGridReport.SetText(2, 3, "FREEZE")
        'FrReport.SsGridReport.SetText(3, 3, 5)
        'FrReport.Show()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Group_Master_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub txt_GroupCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.F4 Then
            'If cmdGroupCode.Enabled = True Then
            'search = Trim(txt_GroupCode.Text)
            'Call cmdGroupCode_Click(cmdGroupCode, e)
            'End If
        End If
    End Sub

    Private Sub txt_GroupDesc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Cmd_Add.Focus()
        End If
    End Sub

    Private Sub cmdGroupCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        gSQLString = "SELECT ISNULL(GROUPCODE,'') AS GROUPCODE,ISNULL(GROUPDESC,'') AS GROUPDESC FROM INVENTORYGROUPMASTER"
        M_WhereCondition = " "
        Dim vform As New List_Operation
        vform.Field = "GROUPCODE,GROUPDESC"
        vform.vFormatstring = "         GROUP CODE              |                  GROUP DESCRIPTION                   "
        vform.vCaption = "GROUP MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            '            txt_GroupCode.Text = Trim(vform.keyfield & "")
            '           Call txt_GroupCode_Validated(txt_GroupCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_GroupCode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Trim(txt_GroupCode.Text) <> "" Then
        'sqlstring = "SELECT * FROM inventorygroupmaster WHERE Groupcode='" & Trim(txt_GroupCode.Text) & "'"
        gconnection.getDataSet(sqlstring, "inventorygroupmaster")
        If gdataset.Tables("inventorygroupmaster").Rows.Count > 0 Then
            '   txt_GroupCode.Text = Trim(gdataset.Tables("inventorygroupmaster").Rows(0).Item("Groupcode"))
            '                txt_GroupDesc.Text = Trim(gdataset.Tables("inventorygroupmaster").Rows(0).Item("Groupdesc"))
            '                txt_GroupDesc.Focus()
            '  txt_GroupCode.ReadOnly = True
            If gdataset.Tables("inventorygroupmaster").Rows(0).Item("Freeze") = "Y" Then
                Me.lbl_Freeze.Visible = True
                Me.lbl_Freeze.Text = ""
                Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("inventorygroupmaster").Rows(0).Item("AddDate")), "dd-MMM-yyyy")
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
            ' txt_GroupCode.ReadOnly = False
            'txt_GroupDesc.Focus()
        End If
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        'Else
        'txt_GroupCode.Text = ""
        'txt_GroupDesc.Focus()
        'End If
    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check  Group Code Can't be blank *********************'''
        'If Trim(txt_GroupCode.Text) = "" Then
        '    MessageBox.Show(" Group Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    txt_GroupCode.Focus()
        '    Exit Sub
        'End If
        '''********** Check  Group desc Can't be blank *********************'''
        'If Trim(txt_GroupDesc.Text) = "" Then
        MessageBox.Show(" Group Desc can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'txt_GroupDesc.Focus()
        Exit Sub
        'End If
        boolchk = True
    End Sub

    Private Sub Group_Master_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        GroupMasterbool = False
    End Sub

    Private Sub Txt_Cardcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Cardcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Txt_Fancycode.Focus()
        End If
    End Sub

    Private Sub Txt_Fancycode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Fancycode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Txt_Membercode.Focus()
        End If
    End Sub

    Private Sub Cmb_Validfrom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_Validfrom.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Cmb_Validto.Focus()
        End If
    End Sub
    Private Sub Txt_MemberCode_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Trim(Txt_MemberCode.Text) <> "" Then
            sqlstring = "SELECT mcode,mname,ISNULL(TERMINATION, '') AS TERMINATION FROM Membermaster WHERE mcode='" & Trim(Txt_MemberCode.Text) & "'"
            gconnection.getDataSet(sqlstring, "membermaster")
            If gdataset.Tables("membermaster").Rows.Count > 0 Then
                Txt_MemberCode.Text = Trim(gdataset.Tables("membermaster").Rows(0).Item("mcode"))
                Txt_Membername.Text = Trim(gdataset.Tables("membermaster").Rows(0).Item("mname"))
                'dtp_Docdate.Focus()
                Txt_MemberCode.ReadOnly = True
                If gdataset.Tables("membermaster").Rows(0).Item("TERMINATION") = "Y" Then
                    Me.lbl_Freeze.Text = "Member Terminated"
                End If
            Else
                Txt_MemberCode.ReadOnly = False
                'dtp_Docdate.Focus()
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Else
            Txt_MemberCode.Text = ""
            'dtp_Docdate.Focus()
        End If
    End Sub
    Private Sub Cmb_Validto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_Validto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Cmb_Transtype.Focus()
        End If
    End Sub

    Private Sub Txt_Membercode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Membercode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Txt_Membercode.Text = "" Then
                Call CmdMembercode_Click(sender, e)
            Else
                Txt_MemberCode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub Txt_Subcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Subcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Cmb_Validfrom.Focus()
        End If
    End Sub

    Private Sub Cmb_Dateofbirth_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_Dateofbirth.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Txt_Amount.Focus()
        End If
    End Sub

    Private Sub Txt_Amount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Amount.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            'Txt_Balance.Focus()
        End If
    End Sub

    Private Sub Cmb_Transtype_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_Transtype.KeyPress
        If Asc(e.KeyChar) = 13 Then
            GridIssuemaster.Focus()
            GridIssuemaster.SetActiveCell(1, 1)
        End If
    End Sub

    Private Sub Cmb_Transtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Transtype.SelectedIndexChanged

    End Sub

    Private Sub CmdMembercode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdMembercode.Click
        Dim sqlstring As String
        Dim vform As New ListOperattion1
        gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM Membermaster "
        If Trim(search) = " " Then
            M_WhereCondition = ""
        Else
            M_WhereCondition = " Where Isnull(Termination,'') = '' "
        End If
        vform.Field = " MNAME,MCODE "
        vform.vFormatstring = "                 MEMBER CODE            |                 MEMBER NAME                                "
        vform.vCaption = "MEMBER MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_Membercode.Text = Trim(vform.keyfield & "")
            Txt_Membername.Text = Trim(vform.keyfield1 & "")
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub Txt_Membercode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_Membercode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call CmdMembercode_Click(sender, e)
        End If
    End Sub
End Class
