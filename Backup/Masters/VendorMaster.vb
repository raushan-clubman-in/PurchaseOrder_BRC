Imports System.Drawing.Color
Imports System.Data.SqlClient
Imports System.Windows.Forms.Screen
Public Class CustomerMaster
    Inherits System.Windows.Forms.Form
    Dim transactionsexists As Boolean
    Dim gconnection As New GlobalClass
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
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents lbl_GroupDescription As System.Windows.Forms.Label
    Friend WithEvents lbl_GroupCode As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCusName As System.Windows.Forms.TextBox
    Friend WithEvents txtCusCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCSTNo As System.Windows.Forms.TextBox
    Friend WithEvents txtLSTNo As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtPHNo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPHNo1 As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents CusCodeHelp As System.Windows.Forms.Button
    'Friend WithEvents FPTransactionStart As AxFPSpreadADO.AxfpSpread
    Friend WithEvents cmdFreeze As System.Windows.Forms.Button
    Friend WithEvents CbxCustomerType As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtPanNo As System.Windows.Forms.TextBox
    Friend WithEvents txtShortName As System.Windows.Forms.TextBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents txtContPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents txtPinCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerMaster))
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.CusCodeHelp = New System.Windows.Forms.Button
        Me.txtCusName = New System.Windows.Forms.TextBox
        Me.txtCusCode = New System.Windows.Forms.TextBox
        Me.lbl_GroupDescription = New System.Windows.Forms.Label
        Me.lbl_GroupCode = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPanNo = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtShortName = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtLSTNo = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCSTNo = New System.Windows.Forms.TextBox
        Me.CbxCustomerType = New System.Windows.Forms.ComboBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtContPerson = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCountry = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.txtPinCode = New System.Windows.Forms.TextBox
        Me.txtPHNo2 = New System.Windows.Forms.TextBox
        Me.txtPHNo1 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtState = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.CmdView = New System.Windows.Forms.Button
        Me.cmdFreeze = New System.Windows.Forms.Button
        Me.CmdExit = New System.Windows.Forms.Button
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_Heading.Location = New System.Drawing.Point(376, 16)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(234, 31)
        Me.lbl_Heading.TabIndex = 7
        Me.lbl_Heading.Text = "VENDOR  MASTER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CusCodeHelp
        '
        Me.CusCodeHelp.Image = CType(resources.GetObject("CusCodeHelp.Image"), System.Drawing.Image)
        Me.CusCodeHelp.Location = New System.Drawing.Point(304, 30)
        Me.CusCodeHelp.Name = "CusCodeHelp"
        Me.CusCodeHelp.Size = New System.Drawing.Size(24, 25)
        Me.CusCodeHelp.TabIndex = 1
        '
        'txtCusName
        '
        Me.txtCusName.BackColor = System.Drawing.Color.Wheat
        Me.txtCusName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCusName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusName.Location = New System.Drawing.Point(168, 72)
        Me.txtCusName.MaxLength = 50
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(160, 22)
        Me.txtCusName.TabIndex = 2
        Me.txtCusName.Text = ""
        '
        'txtCusCode
        '
        Me.txtCusCode.BackColor = System.Drawing.Color.Wheat
        Me.txtCusCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCusCode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusCode.Location = New System.Drawing.Point(168, 30)
        Me.txtCusCode.MaxLength = 10
        Me.txtCusCode.Name = "txtCusCode"
        Me.txtCusCode.Size = New System.Drawing.Size(160, 22)
        Me.txtCusCode.TabIndex = 0
        Me.txtCusCode.Text = ""
        '
        'lbl_GroupDescription
        '
        Me.lbl_GroupDescription.AutoSize = True
        Me.lbl_GroupDescription.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupDescription.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupDescription.Location = New System.Drawing.Point(24, 72)
        Me.lbl_GroupDescription.Name = "lbl_GroupDescription"
        Me.lbl_GroupDescription.Size = New System.Drawing.Size(128, 18)
        Me.lbl_GroupDescription.TabIndex = 11
        Me.lbl_GroupDescription.Text = "VENDOR NAME     :"
        Me.lbl_GroupDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_GroupCode
        '
        Me.lbl_GroupCode.AutoSize = True
        Me.lbl_GroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupCode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupCode.Location = New System.Drawing.Point(24, 30)
        Me.lbl_GroupCode.Name = "lbl_GroupCode"
        Me.lbl_GroupCode.Size = New System.Drawing.Size(129, 18)
        Me.lbl_GroupCode.TabIndex = 9
        Me.lbl_GroupCode.Text = "VENDOR CODE      :"
        Me.lbl_GroupCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtPanNo)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtShortName)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtLSTNo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lbl_GroupCode)
        Me.GroupBox1.Controls.Add(Me.txtCusName)
        Me.GroupBox1.Controls.Add(Me.CusCodeHelp)
        Me.GroupBox1.Controls.Add(Me.lbl_GroupDescription)
        Me.GroupBox1.Controls.Add(Me.txtCSTNo)
        Me.GroupBox1.Controls.Add(Me.txtCusCode)
        Me.GroupBox1.Controls.Add(Me.CbxCustomerType)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 296)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'txtPanNo
        '
        Me.txtPanNo.BackColor = System.Drawing.Color.White
        Me.txtPanNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPanNo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPanNo.Location = New System.Drawing.Point(168, 192)
        Me.txtPanNo.MaxLength = 15
        Me.txtPanNo.Name = "txtPanNo"
        Me.txtPanNo.Size = New System.Drawing.Size(160, 22)
        Me.txtPanNo.TabIndex = 5
        Me.txtPanNo.Text = ""
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(76, 194)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 18)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "PAN NO  :"
        '
        'txtShortName
        '
        Me.txtShortName.BackColor = System.Drawing.Color.White
        Me.txtShortName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtShortName.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShortName.Location = New System.Drawing.Point(168, 112)
        Me.txtShortName.MaxLength = 15
        Me.txtShortName.Name = "txtShortName"
        Me.txtShortName.Size = New System.Drawing.Size(160, 22)
        Me.txtShortName.TabIndex = 3
        Me.txtShortName.Text = ""
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(24, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 23)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "SHORT NAME        :"
        '
        'txtLSTNo
        '
        Me.txtLSTNo.BackColor = System.Drawing.Color.White
        Me.txtLSTNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLSTNo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLSTNo.Location = New System.Drawing.Point(168, 256)
        Me.txtLSTNo.MaxLength = 15
        Me.txtLSTNo.Name = "txtLSTNo"
        Me.txtLSTNo.Size = New System.Drawing.Size(160, 22)
        Me.txtLSTNo.TabIndex = 7
        Me.txtLSTNo.Text = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(81, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 23)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "CST NO :"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(79, 257)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "LST NO  :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "VENDOR TYPE  :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCSTNo
        '
        Me.txtCSTNo.BackColor = System.Drawing.Color.White
        Me.txtCSTNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCSTNo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCSTNo.Location = New System.Drawing.Point(168, 224)
        Me.txtCSTNo.MaxLength = 15
        Me.txtCSTNo.Name = "txtCSTNo"
        Me.txtCSTNo.Size = New System.Drawing.Size(160, 22)
        Me.txtCSTNo.TabIndex = 6
        Me.txtCSTNo.Text = ""
        '
        'CbxCustomerType
        '
        Me.CbxCustomerType.BackColor = System.Drawing.Color.Wheat
        Me.CbxCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCustomerType.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCustomerType.Location = New System.Drawing.Point(168, 152)
        Me.CbxCustomerType.Name = "CbxCustomerType"
        Me.CbxCustomerType.Size = New System.Drawing.Size(160, 23)
        Me.CbxCustomerType.TabIndex = 4
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(24, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 24
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdAdd
        '
        Me.CmdAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdAdd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.ForeColor = System.Drawing.Color.White
        Me.CmdAdd.Image = CType(resources.GetObject("CmdAdd.Image"), System.Drawing.Image)
        Me.CmdAdd.Location = New System.Drawing.Point(168, 16)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(104, 32)
        Me.CmdAdd.TabIndex = 22
        Me.CmdAdd.Text = "Add [F7]"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txtRemarks)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtContPerson)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtCountry)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtEmail)
        Me.GroupBox3.Controls.Add(Me.txtFax)
        Me.GroupBox3.Controls.Add(Me.txtPinCode)
        Me.GroupBox3.Controls.Add(Me.txtPHNo2)
        Me.GroupBox3.Controls.Add(Me.txtPHNo1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtState)
        Me.GroupBox3.Controls.Add(Me.txtCity)
        Me.GroupBox3.Controls.Add(Me.txtAddress1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(360, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(592, 296)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.White
        Me.txtRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemarks.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(408, 256)
        Me.txtRemarks.MaxLength = 50
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(160, 22)
        Me.txtRemarks.TabIndex = 21
        Me.txtRemarks.Text = ""
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(323, 256)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 23)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "REMARKS :"
        '
        'txtContPerson
        '
        Me.txtContPerson.BackColor = System.Drawing.Color.White
        Me.txtContPerson.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContPerson.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContPerson.Location = New System.Drawing.Point(128, 256)
        Me.txtContPerson.MaxLength = 25
        Me.txtContPerson.Name = "txtContPerson"
        Me.txtContPerson.Size = New System.Drawing.Size(160, 22)
        Me.txtContPerson.TabIndex = 20
        Me.txtContPerson.Text = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 23)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "CONT. PERSON :"
        '
        'txtCountry
        '
        Me.txtCountry.BackColor = System.Drawing.Color.White
        Me.txtCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCountry.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.Location = New System.Drawing.Point(128, 144)
        Me.txtCountry.MaxLength = 20
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(160, 22)
        Me.txtCountry.TabIndex = 14
        Me.txtCountry.Text = ""
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(32, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 23)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "COUNTRY :"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(407, 224)
        Me.txtEmail.MaxLength = 25
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(160, 22)
        Me.txtEmail.TabIndex = 19
        Me.txtEmail.Text = ""
        '
        'txtFax
        '
        Me.txtFax.BackColor = System.Drawing.Color.White
        Me.txtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFax.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(128, 224)
        Me.txtFax.MaxLength = 15
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(160, 22)
        Me.txtFax.TabIndex = 18
        Me.txtFax.Text = ""
        '
        'txtPinCode
        '
        Me.txtPinCode.BackColor = System.Drawing.Color.White
        Me.txtPinCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPinCode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPinCode.Location = New System.Drawing.Point(407, 144)
        Me.txtPinCode.MaxLength = 9
        Me.txtPinCode.Name = "txtPinCode"
        Me.txtPinCode.Size = New System.Drawing.Size(160, 22)
        Me.txtPinCode.TabIndex = 15
        Me.txtPinCode.Text = ""
        '
        'txtPHNo2
        '
        Me.txtPHNo2.BackColor = System.Drawing.Color.White
        Me.txtPHNo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPHNo2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHNo2.Location = New System.Drawing.Point(407, 184)
        Me.txtPHNo2.MaxLength = 15
        Me.txtPHNo2.Name = "txtPHNo2"
        Me.txtPHNo2.Size = New System.Drawing.Size(160, 22)
        Me.txtPHNo2.TabIndex = 17
        Me.txtPHNo2.Text = ""
        '
        'txtPHNo1
        '
        Me.txtPHNo1.BackColor = System.Drawing.Color.White
        Me.txtPHNo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPHNo1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHNo1.Location = New System.Drawing.Point(128, 184)
        Me.txtPHNo1.MaxLength = 15
        Me.txtPHNo1.Name = "txtPHNo1"
        Me.txtPHNo1.Size = New System.Drawing.Size(160, 22)
        Me.txtPHNo1.TabIndex = 16
        Me.txtPHNo1.Text = ""
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(331, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 23)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "EMAIL ID :"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 23)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "FAX :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(304, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 23)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "PIN CODE NO  :"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(314, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 23)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "PHONE NO2 :"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 23)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "PHONE NO 1 :"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 23)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "ADDRESS1 :"
        '
        'txtState
        '
        Me.txtState.BackColor = System.Drawing.Color.White
        Me.txtState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtState.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(408, 104)
        Me.txtState.MaxLength = 20
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(160, 22)
        Me.txtState.TabIndex = 13
        Me.txtState.Text = ""
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCity.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(128, 104)
        Me.txtCity.MaxLength = 20
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(160, 22)
        Me.txtCity.TabIndex = 12
        Me.txtCity.Text = ""
        '
        'txtAddress1
        '
        Me.txtAddress1.BackColor = System.Drawing.Color.White
        Me.txtAddress1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress1.Location = New System.Drawing.Point(127, 64)
        Me.txtAddress1.MaxLength = 50
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(441, 22)
        Me.txtAddress1.TabIndex = 11
        Me.txtAddress1.Text = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(347, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "STATE :"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "CITY :"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Wheat
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"GOOD", "EXCELLENT"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 23)
        Me.ComboBox1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "RATINGS  :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.CmdClear)
        Me.GroupBox4.Controls.Add(Me.CmdAdd)
        Me.GroupBox4.Controls.Add(Me.CmdView)
        Me.GroupBox4.Controls.Add(Me.cmdFreeze)
        Me.GroupBox4.Controls.Add(Me.CmdExit)
        Me.GroupBox4.Location = New System.Drawing.Point(72, 376)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(840, 64)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(448, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 26
        Me.CmdView.Text = " View[F9]"
        '
        'cmdFreeze
        '
        Me.cmdFreeze.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdFreeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFreeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFreeze.ForeColor = System.Drawing.Color.White
        Me.cmdFreeze.Image = CType(resources.GetObject("cmdFreeze.Image"), System.Drawing.Image)
        Me.cmdFreeze.Location = New System.Drawing.Point(312, 16)
        Me.cmdFreeze.Name = "cmdFreeze"
        Me.cmdFreeze.Size = New System.Drawing.Size(104, 32)
        Me.cmdFreeze.TabIndex = 25
        Me.cmdFreeze.Text = "Freeze[F8]"
        '
        'CmdExit
        '
        Me.CmdExit.BackColor = System.Drawing.Color.ForestGreen
        Me.CmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdExit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.ForeColor = System.Drawing.Color.White
        Me.CmdExit.Image = CType(resources.GetObject("CmdExit.Image"), System.Drawing.Image)
        Me.CmdExit.Location = New System.Drawing.Point(728, 16)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(104, 32)
        Me.CmdExit.TabIndex = 23
        Me.CmdExit.Text = "Exit[F12]"
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(16, 16)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 431
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(584, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "VALIDATION"
        '
        'CustomerMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.CmdExit
        Me.ClientSize = New System.Drawing.Size(958, 451)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "CustomerMaster"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order Vendor Master"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub txtCusCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCusCode.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                Call CusCodeHelp_Clck(txtCusCode, e)
                Me.txtShortName.Focus()
            ElseIf Trim(txtCusCode.Text) = "" And e.KeyCode = Keys.Enter Then
                Call CusCodeHelp_Clck(txtCusCode.Text, e)
                Me.txtShortName.Focus()
            ElseIf Trim(txtCusCode.Text) <> "" And e.KeyCode = Keys.Enter Then
                Call txtCusCode_Validated(txtCusCode, e)
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Customer Code Keydown")
        End Try
    End Sub
    Private Sub txtCustomeType_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                If Trim(CbxCustomerType.Text) = "" Then
                    CbxCustomerType.Focus()
                    MsgBox(" Customer Type Cannot Be Null", MsgBoxStyle.Information, "INPUT ERROR ALERT")
                Else
                    txtCusName.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Customer Type Keydown")
        End Try
    End Sub

    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Dim sqlstring As String
        Dim I, j As Integer
        If Mevalidate() = False Then Exit Sub
        Dim Insert(0) As String
        If txtPinCode.Text = Nothing Then
            txtPinCode.Text = 0
        End If
        Try
            If CmdAdd.Text = "Add [F7]" Then
                sqlstring = ""
                sqlstring = "Insert Into PO_VENDORMASTER(VendorCode,VendorName,Shortname,Panno,castno,lstno,address,city,state,country,pincode,phone1,phone2,fax,email,contactperson,remarks,freeze,adduser,adddatetime) Values("
                sqlstring = sqlstring & "'" & txtCusCode.Text & "',"
                sqlstring = sqlstring & "'" & txtCusName.Text & "',"
                sqlstring = sqlstring & "'" & txtShortName.Text & "',"
                sqlstring = sqlstring & "'" & txtPanNo.Text & "',"
                sqlstring = sqlstring & "'" & txtCSTNo.Text & "',"
                sqlstring = sqlstring & "'" & txtLSTNo.Text & "',"
                sqlstring = sqlstring & "'" & txtAddress1.Text & "',"
                sqlstring = sqlstring & "'" & txtCity.Text & "',"
                sqlstring = sqlstring & "'" & txtState.Text & "',"
                sqlstring = sqlstring & "'" & txtCountry.Text & "',"
                sqlstring = sqlstring & "'" & txtPinCode.Text & "',"
                sqlstring = sqlstring & "'" & txtPHNo1.Text & "',"
                sqlstring = sqlstring & "'" & txtPHNo2.Text & "',"
                sqlstring = sqlstring & "'" & txtFax.Text & "',"
                sqlstring = sqlstring & "'" & txtEmail.Text & "',"
                sqlstring = sqlstring & "'" & txtContPerson.Text & "',"
                sqlstring = sqlstring & "'" & txtRemarks.Text & "',"
                sqlstring = sqlstring & "'N" & "',"
                sqlstring = sqlstring & "'" & gUsername & "',"
                sqlstring = sqlstring & "'" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                sqlstring = sqlstring & ")"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
                gconnection.MoreTrans(Insert)
                Me.CmdClear_Click(sender, e)
            ElseIf CmdAdd.Text = "Update[F7]" And Me.lbl_Freeze.Visible = True Then
                If Mid(Me.CmdAdd.Text, 1, 1) = "U" And Me.lbl_Freeze.Visible = True Then
                    MessageBox.Show(" The Freezed Record Cannot Be Updated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False
                End If
                If boolchk = False Then
                    Call clearform(Me)
                    Me.CmdClear_Click(sender, e)
                    Exit Sub
                End If
            Else
                sqlstring = ""
                sqlstring = "UPDATE PO_VENDORMASTER "
                sqlstring = sqlstring & "SET VendorCode = '" & txtCusCode.Text & "',"
                sqlstring = sqlstring & " VendorNAME = '" & txtCusName.Text & "',"
                sqlstring = sqlstring & " SHORTNAME = '" & txtShortName.Text & "',"
                sqlstring = sqlstring & " PANNO = '" & txtPanNo.Text & "',"
                sqlstring = sqlstring & " castNO = '" & txtCSTNo.Text & "',"
                sqlstring = sqlstring & " lstNO = '" & txtLSTNo.Text & "',"
                sqlstring = sqlstring & " address = '" & txtAddress1.Text & "',"
                sqlstring = sqlstring & " city = '" & txtCity.Text & "',"
                sqlstring = sqlstring & " state = '" & txtState.Text & "',"
                sqlstring = sqlstring & " country = '" & txtCountry.Text & "',"
                sqlstring = sqlstring & " PINCODE = '" & txtPinCode.Text & "',"
                sqlstring = sqlstring & " PHONE1 = '" & txtPHNo1.Text & "',"
                sqlstring = sqlstring & " PHONE2 = '" & txtPHNo2.Text & "',"
                sqlstring = sqlstring & " FAX = '" & txtFax.Text & "',"
                sqlstring = sqlstring & " EMAIL = '" & txtEmail.Text & "',"
                sqlstring = sqlstring & " contactperson = '" & txtContPerson.Text & "',"
                sqlstring = sqlstring & " REMARKS = '" & txtRemarks.Text & "',"
                sqlstring = sqlstring & " UPDATEUSER = '" & gUsername & "',"
                sqlstring = sqlstring & " UPDATEDATETIME = '" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "' "
                sqlstring = sqlstring & " WHERE VENDORcode = '" & Trim(txtCusCode.Text) & "'"
                gconnection.dataOperation(2, sqlstring, "PO_VENDORMASTER")
                Me.CmdClear_Click(sender, e)
                Me.CmdAdd.Text = "Add [F7]"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Call Me.CmdClear_Click(sender, e)
            Exit Sub
        End Try
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            Call clearform(Me)
            Me.txtCusCode.Text = ""
            Me.txtCusName.Text = ""
            Me.txtShortName.Text = ""
            Me.txtPanNo.Text = ""
            Me.txtCSTNo.Text = ""
            Me.txtLSTNo.Text = ""
            Me.txtAddress1.Text = ""
            Me.txtCity.Text = ""
            Me.txtState.Text = ""
            Me.txtCountry.Text = ""
            Me.txtPinCode.Text = ""
            Me.txtPHNo1.Text = ""
            Me.txtPHNo2.Text = ""
            Me.txtFax.Text = ""
            Me.txtEmail.Text = ""
            Me.txtContPerson.Text = ""
            Me.txtRemarks.Text = ""
            Me.CmdAdd.Text = "Add [F7]"
            Me.cmdFreeze.Text = "Freeze[F8]"
            Me.lbl_Freeze.Text = "Record Freezed  On "
            Me.lbl_Freeze.Visible = False
            txtCusCode.ReadOnly = False
            txtCusCode.Focus()
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Clear Click")
        End Try
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Try
            Dim a As String
            a = MessageBox.Show("Are you Sure Want to Exit from this Form", "Action Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
            If a = vbYes Then
                Me.Close()
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Exit Click")
        End Try
    End Sub

    Private Sub CusCodeHelp_Clck(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CusCodeHelp.Click
        Try
            gSQLString = ""
            gSQLString = "SELECT ISNULL(vendorcode,'') AS vendorcode,ISNULL(vendorname,'') AS vendorname FROM  PO_VendorMaster"
            M_WhereCondition = ""
            Dim vform As New List_Operation
            vform.Field = "VENDORCODE, VENDORNAME"
            vform.vFormatstring = "    VENDOR CODE        |         VENDOR NAME           "
            vform.vCaption = "VENDOR MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txtCusCode.Text = Trim(vform.keyfield & "")
                txtCusName.Text = Trim(vform.keyfield1 & "")
                Call txtCusCode_Validated(txtCusCode, e)
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Customer Code Help Click")
        End Try
    End Sub
    Private Sub txtCusCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCusCode.Validated
        Try
            Dim sqlstring As String
            If Trim(txtCusCode.Text) <> "" Then
                sqlstring = "SELECT ISNULL(VENDORCODE,'') AS VENDORCODE, ISNULL(vendortype,'') AS VENDORTYPE,ISNULL(vendorname,'') AS VENDORNAME,ISNULL(shortname,'') AS SHORTNAME,ISNULL(panno,'') AS PANNO,ISNULL(castno,'') AS CASTNO,ISNULL(lstno,'') AS LSTNO,ISNULL(ratings,'') AS RATINGS,ISNULL(licenceno,'') AS LICENCENO,ISNULL(licencedate,'') AS LICENCEDATE,ISNULL(address,'') AS ADDRESS,ISNULL(city,'') AS city,ISNULL(state,'') AS state,ISNULL(country,'') AS country,ISNULL(pincode,0) AS pincode,ISNULL(phone1,'') AS phone1,ISNULL(phone2,'') AS phone2,ISNULL(fax,'') AS FAX,ISNULL(email,'') AS email,ISNULL(contactperson,'') AS contactperson,ISNULL(remarks,'') AS remarks,ISNULL(FREEZE,'') AS FREEZE,ISNULL(ADDDATETIME,'') AS ADDDATETIME FROM PO_VENDORMASTER WHERE VENDORCode='" & Trim(txtCusCode.Text) & "'"
                gconnection.getDataSet(sqlstring, "PO_VENDORMASTER")
                If gdataset.Tables("PO_VENDORMASTER").Rows.Count > 0 Then
                    txtCusCode.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("VendorCode"))
                    txtCusName.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("VendorName"))
                    txtShortName.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("ShortName"))
                    'CbxCustomerType.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("VendorType"))
                    txtPanNo.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("PANNo"))
                    txtLSTNo.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("LSTNo"))
                    txtCSTNo.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("CASTNo"))
                    txtAddress1.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Address"))
                    txtCity.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("City"))
                    txtState.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("State"))
                    txtCountry.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Country"))
                    txtPinCode.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Pincode"))
                    txtPHNo1.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Phone1"))
                    txtPHNo2.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Phone2"))
                    txtPinCode.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Pincode"))
                    txtFax.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Fax"))
                    txtEmail.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Email"))
                    txtContPerson.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Contactperson"))
                    txtRemarks.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Remarks"))

                    If gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Freeze") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = ""
                        Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("AddDatetime")), "dd-MMM-yyyy")
                        Me.cmdFreeze.Text = "UnFreeze[F8]"
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.cmdFreeze.Text = "Freeze[F8]"
                    End If

                    txtCusName.Focus()
                    txtCusCode.ReadOnly = True
                    Me.CmdAdd.Text = "Update [F7]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.CmdAdd.Text = "Add [F7]"
                    Me.txtCusCode.ReadOnly = False
                    Me.txtCusName.Focus()
                End If
                If gUserCategory <> "S" Then
                    Call GetRights()
                End If
            Else
                txtCusCode.Focus()
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Customer Code Validated")
        End Try
    End Sub
    Private Sub GetRights()
        Try
            Dim i, j, k, x As Integer
            Dim vmain, vsmod, vssmod As Long
            Dim ssql, SQLSTRING As String
            Dim M1 As New MainMenu
            Dim chstr As String
            SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='Purchase Order' AND MODULENAME LIKE 'Vendor Master%' ORDER BY RIGHTS"
            gconnection.getDataSet(SQLSTRING, "USER")
            If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                    With gdataset.Tables("USER").Rows(i)
                        chstr = abcdMINUS(.Item("RIGHTS"))
                    End With
                Next
            End If
            Me.CmdAdd.Enabled = False
            Me.cmdFreeze.Enabled = False
            Me.CmdView.Enabled = False
            'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
            If Len(chstr) > 0 Then
                Dim Right() As Char
                Right = chstr.ToCharArray
                For x = 0 To Right.Length - 1
                    If Right(x) = "A" Then
                        Me.CmdAdd.Enabled = True
                        Me.CmdView.Enabled = True
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
                    If Right(x) = "V" Then
                        Me.CmdView.Enabled = True
                    End If
                Next
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Get Rights")
        End Try
    End Sub

    Private Sub Cmdfreeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFreeze.Click
        Try
            Dim strsql
            strsql = ""
            If Trim(txtCusCode.Text) <> "" Then
                gdataset.Clear()
                strsql = "SELECT * FROM PO_VendorMaster WHERE VendorCode='" & Trim(txtCusCode.Text) & "'"
                gconnection.getDataSet(strsql, "PO_VendorMaster")
                If gdataset.Tables("PO_VendorMaster").Rows.Count > 0 Then
                    If Mevalidate() = False Then Exit Sub
                    strsql = ""
                    If Mid(cmdFreeze.Text, 1, 1) = "F" Then
                        strsql = "UPDATE  PO_VendorMaster "
                        strsql = strsql & " SET Freeze= 'Y',Freezeuser='" & gUsername & " ', Freezedatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                        strsql = strsql & " WHERE Vendorcode = '" & Trim(txtCusCode.Text) & "'"
                        gconnection.dataOperation(3, strsql, "PO_VendorMaster")
                        Me.CmdClear_Click(sender, e)
                        CmdAdd.Text = "Add [F7]"
                    Else
                        strsql = "UPDATE  PO_VendorMaster "
                        strsql = strsql & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                        strsql = strsql & " WHERE Vendorcode = '" & Trim(txtCusCode.Text) & "'"
                        gconnection.dataOperation(4, strsql, "PO_VendorMaster")
                        Me.CmdClear_Click(sender, e)
                        CmdAdd.Text = "Add [F7]"
                    End If
                Else
                    MsgBox("Record Not Found", MsgBoxStyle.Critical, "Freeze Record")
                End If
            Else
                MsgBox("No Record Selected To Freeze", MsgBoxStyle.Critical, "Freeze Record")
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Freeze Click")
        End Try
    End Sub
    Private Function datavalidate()
        Try
            If Trim(txtCusCode.Text) = "" Then
                MsgBox(" Customer Code Cannot Be Null", MsgBoxStyle.Information, "INPUT ERROR ALERT")
                txtCusCode.Focus()
                datavalidate = False
            ElseIf Trim(txtCusName.Text) = "" Then
                MsgBox("Customer Name  Cannot Be Null", MsgBoxStyle.Information, "INPUT ERROR ALERT")
                txtCusName.Focus()
                datavalidate = False
            ElseIf Trim(CbxCustomerType.Text) = "" Then
                MsgBox("Customer Type Cannot Be Null", MsgBoxStyle.Information, "INPUT ERROR ALERT")
                CbxCustomerType.Focus()
                datavalidate = False
            Else
                datavalidate = True
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Data Validate")
        End Try
    End Function

    Private Sub CustomerMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                Call CmdClear_Click(CmdClear, e)
            End If
            If e.KeyCode = Keys.F7 Then
                Call CmdAdd_Click(CmdAdd, e)
            End If
            If e.KeyCode = Keys.F8 Then
                Call Cmdfreeze_Click(cmdFreeze, e)
            End If
            If e.KeyCode = Keys.F9 Then
                Call CmdView_Click(CmdView, e)
            End If
            If e.KeyCode = Keys.F12 Or e.KeyCode = Keys.Escape Then
                Call CmdExit_Click(CmdExit, e)
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Customer Master KeyDown")
        End Try
    End Sub
    Private Sub txtCusName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCusName.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                If Trim(txtCusName.Text) = "" Then
                    MsgBox(" Customer Name Cannot Be Null", MsgBoxStyle.Information, "INPUT ERROR ALERT")
                    txtCusName.Focus()
                Else
                    txtShortName.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Customer Name Keydown")
        End Try
    End Sub
    Private Sub txtTinNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtLSTNo.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Tin No Keydown")
        End Try
    End Sub
    Private Sub txtLSTNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLSTNo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                ComboBox1.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "LSTNO Keydown")
        End Try
    End Sub

    Private Sub txtCSTNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCSTNo.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtLSTNo.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "CSTNO Keydown")
        End Try
    End Sub

    Private Sub txtAddress1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAddress1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtCity.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Address1 Keydown")
        End Try
    End Sub

    Private Sub txtAddress2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtCity.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Address2 Keydown")
        End Try
    End Sub

    Private Sub txtCity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCity.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtState.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "City Keydown")
        End Try
    End Sub
    Private Sub txtState_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtState.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtPinCode.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "State Keydown")
        End Try
    End Sub
    Private Sub txtPinCode_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtPHNo1.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Pincode Keydown")
        End Try
    End Sub
    Private Sub txtPHNo1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPHNo1.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtPHNo2.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Phone1 Keydown")
        End Try
    End Sub
    Private Sub txtPHNo2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPHNo2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtPinCode.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Phone2 Keydown")
        End Try
    End Sub

    Private Sub txtMobile_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPinCode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtFax.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Mobile Keydown")
        End Try
    End Sub
    Private Sub txtFax_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFax.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtEmail.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Fax Keydown")
        End Try
    End Sub
    Private Sub txtEmail_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtEmail.KeyDown
        'Try
        '    If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
        '        If Trim(txtEmail.Text) = "" Then
        '            FPTransactionStart.Focus()
        '        Else
        'getEmail(txtEmail)
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Mail Keydown")
        'End Try
    End Sub
    Private Sub CmdClear_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmdClear.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                CmdAdd.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Clear Keydown")
        End Try
    End Sub

    Private Sub CmdAdd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmdAdd.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                cmdFreeze.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Add Keydown")
        End Try
    End Sub


    Private Sub cmdFreeze_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmdFreeze.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                CmdView.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Freeze Keydown")
        End Try
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            Dim FrReport As New ReportDesigner
            tables = " PO_VENDORMASTER"
            Gheader = "VENDOR MASTER"
            FrReport.SsGridReport.SetText(2, 1, "VENDORCODE")
            FrReport.SsGridReport.SetText(3, 1, 10)
            FrReport.SsGridReport.SetText(2, 2, "VENDORNAME")
            FrReport.SsGridReport.SetText(3, 2, 30)
            FrReport.SsGridReport.SetText(2, 3, "SHORTNAME")
            FrReport.SsGridReport.SetText(3, 3, 10)
            FrReport.SsGridReport.SetText(2, 4, "RATINGS")
            FrReport.SsGridReport.SetText(3, 4, 8)
            FrReport.SsGridReport.SetText(2, 5, "CONTACTPERSON")
            FrReport.SsGridReport.SetText(3, 5, 17)
            FrReport.Show()
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "View Click")
        End Try
    End Sub
    Function reportsource()
        'Dim sqlcond As String
        'sqlstring = "select * from vw_CusMaster"
        'Try
        '    gloobj.Connection()
        '    gcommand = New SqlCommand(sqlstring, con)
        '    gcommand.ExecuteNonQuery()
        'Catch ex As Exception
        '    MsgBox(Err.Description & ex.Source & "Error in Operation", MsgBoxStyle.Information, Application.ProductName)
        'End Try
    End Function

    Private Sub CmdView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CmdView.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                CmdExit.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "View Keydown")
        End Try
    End Sub

    Private Sub CmdGridView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    gridquery = " select isnull(CustomerCode,''),isnull(CustomerType,''),isnull(CustomerName,''),isnull(TINNo,''),isnull(LSTNo,''),isnull(CSTNo,''),isnull(Address1,''),"
        '    gridquery = gridquery & "isnull(Phone1,''),isnull(Pincode,''),isnull(freezeflag,'N')"
        '    gridquery = gridquery & "from PISCustomermaster order by adddate,updatedate"
        '    tabname = "PISCustomerMaster"
        '    totrepcols = 10
        '    repcols(0) = "CUSTOMER CODE"
        '    repcols(1) = "CUSTOMER TYPE"
        '    repcols(2) = "CUSTOMER NAME"
        '    repcols(3) = "TINNO"
        '    repcols(4) = "LSTNo"
        '    repcols(5) = "CSTNo"
        '    repcols(6) = "ADDRESS1"
        '    repcols(7) = "PHONE1"
        '    repcols(8) = "PINCODE"
        '    repcols(9) = "FREEZEFLAG"
        '    reporthead = "CUSTOMER LIST AS ON " & Format(Date.Now, "dd/MMM/yyyy")
        '    gconnection.getDataSet(gridquery, tabname)
        '    If gdataset.Tables(tabname).Rows.Count <= 0 Then
        '        showgridfrm = False
        '        MsgBox("DATA NOT AVAILABLE", MsgBoxStyle.Information, "RECORD NOT FOUND")
        '        Exit Sub
        '    Else
        '        showgridfrm = True
        '    End If
        '    Dim gview As New GridView
        '    If showgridfrm = True Then
        '        gview.Show()
        '    End If
        'Catch ex As Exception
        '    MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "GridView Click")
        'End Try
    End Sub
    Private Sub CbxCustomerType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbxCustomerType.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtCusName.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "customer Type Keydown")
        End Try
    End Sub
    Private Sub txtPHNo1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPHNo1.KeyPress
        Try
            NumberCheck(e)
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Phone1 Keypress")
        End Try
    End Sub
    Private Sub txtPHNo2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPHNo2.KeyPress
        Try
            NumberCheck(e)
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Phone2 Keypress")
        End Try
    End Sub

    Private Sub txtMobile_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPinCode.KeyPress
        Try
            NumberCheck(e)
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Mobile Keypress")
        End Try
    End Sub
    Private Sub txtFax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFax.KeyPress
        Try
            NumberCheck(e)
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Fax Keypress")
        End Try
    End Sub
    Private Sub txtPinCode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            NumberCheck(e)
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Pincode Keypress")
        End Try
    End Sub
    Public Function NumberCheck(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 65 To 127
                e.Handled = True
            Case 33 To 38
                e.Handled = True
            Case 40 To 44
                e.Handled = True
            Case 58 To 64
                e.Handled = True
        End Select
    End Function
    Private Sub CbxCustomerType_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbxCustomerType.GotFocus
        'Try
        '    Dim TOTROW As Integer
        '    If Trim(txtCusCode.Text) = "" Then
        '        MsgBox(" Customer Code Cannot Be Null", MsgBoxStyle.Information, "INPUT ERROR ALERT")
        '        txtCusCode.Focus()
        '    Else
        '        gdataset.Clear()
        '        sqlstring = "SELECT * FROM PISCusTransactionStartMaster where customercode='" & Trim(txtCusCode.Text) & "' and isnull(FreezeFlag,'N') <> 'Y' "
        '        gconnection.getDataSet(sqlstring, "PISCusTransactionStartMaster")
        '        FPTransactionStart.ClearRange(-1, -1, 1, 1, True)
        '        If gdataset.Tables("PISCusTransactionStartMaster").Rows.Count > 0 Then
        '            transactionsexists = True
        '            Dim TotalRow As Integer
        '            TotalRow = gdataset.Tables("PISCusTransactionStartMaster").Rows.Count
        '            Dim rowno As Integer
        '            For rowno = 0 To TotalRow - 1
        '                FPTransactionStart.SetText(1, rowno + 1, Trim(gdataset.Tables("PISCusTransactionStartMaster").Rows(rowno).Item("TransactionCode")))
        '                FPTransactionStart.SetText(2, rowno + 1, Trim(gdataset.Tables("PISCusTransactionStartMaster").Rows(rowno).Item("Transaction")))
        '                FPTransactionStart.SetText(3, rowno + 1, Trim(gdataset.Tables("PISCusTransactionStartMaster").Rows(rowno).Item("Prefix")))
        '                FPTransactionStart.SetText(4, rowno + 1, Trim(gdataset.Tables("PISCusTransactionStartMaster").Rows(rowno).Item("StartNo")))
        '            Next
        '        End If
        '        If transactionsexists = False Then
        '            gdataset.Clear()
        '            sqlstring = "SELECT * FROM PISTransactionMaster WHERE SUBSTRING(TRANSACTIONCODE,1,1)<>'C'"
        '            gconnection.getDataSet(sqlstring, "PISTransactionMaster")
        '            FPTransactionStart.ClearRange(-1, -1, 1, 1, True)
        '            Dim row As Integer
        '            TOTROW = gdataset.Tables("PISTransactionMaster").Rows.Count
        '            FPTransactionStart.MaxRows = TOTROW
        '            If gdataset.Tables("PISTransactionMaster").Rows.Count > 0 Then
        '                For row = 0 To TOTROW - 1
        '                    FPTransactionStart.SetText(1, row + 1, Trim(gdataset.Tables("PISTransactionMaster").Rows(row).Item("TransactionCode")))
        '                    FPTransactionStart.SetText(2, row + 1, Trim(gdataset.Tables("PISTransactionMaster").Rows(row).Item("TransactionDesc")))
        '                Next
        '            End If
        '        End If
        '    End If
        'Catch ex As Exception
        '    MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Customer Type Gotfocus")
        'End Try
    End Sub
    Private Sub CustomerMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        '    gdataset.Clear()
        '    sqlstring = "SELECT * FROM PISTransactionMaster WHERE SUBSTRING(TRANSACTIONCODE,1,1)<>'C'"
        '    gconnection.getDataSet(sqlstring, "PISTransactionMaster")
        '    FPTransactionStart.ClearRange(-1, -1, 1, 1, True)
        '    Dim row As Integer
        '    totrow = gdataset.Tables("PISTransactionMaster").Rows.Count
        '    FPTransactionStart.MaxRows = totrow
        'Catch ex As Exception
        '    MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Customer Master Load")
        'End Try
        If gUserCategory <> "S" Then
            Call GetRights()
        End If

    End Sub

    'Private Sub FPTransactionStart_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles FPTransactionStart.KeyDownEvent
    '    Try
    '        If FPTransactionStart.ActiveRow = totrow And FPTransactionStart.ActiveCol = FPTransactionStart.MaxCols Then
    '            CmdAdd.Focus()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "FpTransactionStartKeydown")
    '    End Try
    'End Sub

    'Private Sub txtTinNo_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Try
    '    '    txtTinNo.BackColor = Color.Red
    '    '    txtTinNo.ForeColor = Color.White
    '    'Catch ex As Exception
    '    '    MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "TINNO Gotfocus")
    '    'End Try
    'End Sub
    'Private Sub txtCusCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCusCode.GotFocus
    '    Try
    '        txtCity.BackColor = Color.Red
    '        txtCity.ForeColor = Color.White
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "City Gotfocus")
    '    End Try
    'End Sub
    'Private Sub txtLSTNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLSTNo.GotFocus
    '    Try
    '        txtLSTNo.BackColor = Color.Red
    '        txtLSTNo.ForeColor = Color.White
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "LST No Gotfocus")
    '    End Try
    'End Sub

    'Private Sub txtCSTNo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCSTNo.GotFocus
    '    Try
    '        txtCSTNo.BackColor = Color.Red
    '        txtCSTNo.ForeColor = Color.White
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "CST NO Gotfocus")
    '    End Try
    'End Sub

    'Private Sub txtAddress1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress1.GotFocus
    '    Try
    '        txtAddress1.BackColor = Color.Red
    '        txtAddress1.ForeColor = Color.White
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Address1 Gotfocus")
    '    End Try
    'End Sub

    'Private Sub txtAddress2_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Try
    '    '    txtAddress2.BackColor = Color.Red
    '    '    txtAddress2.ForeColor = Color.White
    '    'Catch ex As Exception
    '    '    MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Address2 Gotfucus")
    '    'End Try
    'End Sub
    'Private Sub txtCity_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCity.GotFocus
    '    Try
    '        txtCity.BackColor = Color.Red
    '        txtCity.ForeColor = Color.White
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "City Gotfocus")
    '    End Try
    'End Sub

    'Private Sub txtState_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtState.GotFocus
    '    Try
    '        txtState.BackColor = Color.Red
    '        txtState.ForeColor = Color.White
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "State Gotfocus")
    '    End Try
    'End Sub
    'Private Sub txtPinCode_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Try
    '    '    txtPinCode.BackColor = Color.Red
    '    '    txtPinCode.ForeColor = Color.White
    '    'Catch ex As Exception
    '    '    MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Pincode Gotfocus")
    '    'End Try
    'End Sub

    'Private Sub txtPHNo1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPHNo1.GotFocus
    '    Try
    '        txtPHNo1.BackColor = Color.Red
    '        txtPHNo1.ForeColor = Color.White
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Phone1 Gotfocus")
    '    End Try
    'End Sub

    'Private Sub txtPHNo2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPHNo2.GotFocus
    '    Try
    '        txtPHNo2.BackColor = Color.Red
    '        txtPHNo2.ForeColor = Color.White
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Phone2 Gotfocus")
    '    End Try
    'End Sub

    'Private Sub txtMobile_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPinCode.GotFocus
    '    Try
    '        txtPinCode.BackColor = Color.Red
    '        txtPinCode.ForeColor = Color.White
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "MobileNo Gotfocus")
    '    End Try
    'End Sub

    'Private Sub txtFax_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFax.GotFocus
    '    Try
    '        txtFax.BackColor = Color.Red
    '        txtFax.ForeColor = Color.White
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Fax Gotfocus")
    '    End Try
    'End Sub

    'Private Sub txtEmail_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.GotFocus
    '    Try
    '        txtEmail.BackColor = Color.Red
    '        txtEmail.ForeColor = Color.White
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Email Gotfocus")
    '    End Try
    'End Sub

    'Private Sub txtEmail_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEmail.LostFocus
    '    Try
    '        txtEmail.BackColor = System.Drawing.Color.White
    '        txtEmail.ForeColor = System.Drawing.Color.Black
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "EMail Lostfocus")
    '    End Try
    'End Sub

    'Private Sub txtFax_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFax.LostFocus
    '    Try
    '        txtFax.BackColor = System.Drawing.Color.White
    '        txtFax.ForeColor = System.Drawing.Color.Black
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Fax Lostfocus")
    '    End Try
    'End Sub

    'Private Sub txtMobile_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPinCode.LostFocus
    '    Try
    '        txtPinCode.BackColor = System.Drawing.Color.White
    '        txtPinCode.ForeColor = System.Drawing.Color.Black
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Mobile Lostfocus")
    '    End Try
    'End Sub

    'Private Sub txtPHNo2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPHNo2.LostFocus
    '    Try
    '        txtPHNo2.BackColor = System.Drawing.Color.White
    '        txtPHNo2.ForeColor = System.Drawing.Color.Black
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Phone2 Lostfocus")
    '    End Try
    'End Sub

    'Private Sub txtPHNo1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPHNo1.LostFocus
    '    Try
    '        txtPHNo1.BackColor = System.Drawing.Color.White
    '        txtPHNo1.ForeColor = System.Drawing.Color.Black
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Phone1 Lostfocus")
    '    End Try
    'End Sub

    'Private Sub txtTinNo_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Try
    '    '    txtTinNo.BackColor = System.Drawing.Color.White
    '    '    txtTinNo.ForeColor = System.Drawing.Color.Black
    '    'Catch ex As Exception
    '    '    MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "TinNo Lostfocus")
    '    'End Try
    'End Sub

    'Private Sub txtLSTNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLSTNo.LostFocus
    '    Try
    '        txtLSTNo.BackColor = System.Drawing.Color.White
    '        txtLSTNo.ForeColor = System.Drawing.Color.Black
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "LSTNo Lostfocus")
    '    End Try
    'End Sub

    'Private Sub txtAddress1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddress1.LostFocus
    '    Try
    '        txtAddress1.BackColor = System.Drawing.Color.White
    '        txtAddress1.ForeColor = System.Drawing.Color.Black
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Address1 Lostfocus")
    '    End Try
    'End Sub

    'Private Sub txtAddress2_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    'Try
    '    '    txtAddress2.BackColor = System.Drawing.Color.White
    '    '    txtAddress2.ForeColor = System.Drawing.Color.Black
    '    'Catch ex As Exception
    '    '    MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Address2 Lostfocus")
    '    'End Try
    'End Sub

    'Private Sub txtCity_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCity.LostFocus
    '    Try
    '        txtCity.BackColor = System.Drawing.Color.White
    '        txtCity.ForeColor = System.Drawing.Color.Black
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "City Lostfocus")
    '    End Try
    'End Sub

    'Private Sub txtcuscode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCusCode.LostFocus
    '    Try
    '        txtCusCode.BackColor = System.Drawing.Color.White
    '        txtCusCode.ForeColor = System.Drawing.Color.Black
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "state Lostfocus")
    '    End Try
    'End Sub

    'Private Sub txtCSTNo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCSTNo.LostFocus
    '    Try
    '        txtCSTNo.BackColor = System.Drawing.Color.White
    '        txtCSTNo.ForeColor = System.Drawing.Color.Black
    '    Catch ex As Exception
    '        MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "CSTNo Lostfocus")
    '    End Try
    'End Sub
    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call CmdClear_Click(sender, e)
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call CmdAdd_Click(sender, e)
    End Sub
    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Cmdfreeze_Click(sender, e)
    End Sub
    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call CmdView_Click(sender, e)
    End Sub
    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call CmdGridView_Click(sender, e)
    End Sub
    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call CmdExit_Click(sender, e)
    End Sub
    Private Function Mevalidate() As Boolean
        Mevalidate = False
        If txtCusCode.Text = "" Then
            MessageBox.Show("Vendor Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCusCode.Focus()
            boolchk = False
            Exit Function
        End If
        If txtCusName.Text = "" Then
            MessageBox.Show("Vendor Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCusName.Focus()
            boolchk = False
            Exit Function
        End If
        Mevalidate = True
    End Function

    Private Sub txtCusName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCusName.TextChanged

    End Sub

    Private Sub txtCusCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCusCode.TextChanged

    End Sub

    Private Sub txtShortName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtShortName.KeyDown

    End Sub

    Private Sub txtShortName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtShortName.TextChanged

    End Sub

    Private Sub txtShortName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtShortName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPanNo.Focus()
        End If
    End Sub

    Private Sub txtPanNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPanNo.TextChanged

    End Sub

    Private Sub txtPanNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPanNo.KeyPress

    End Sub

    Private Sub txtCSTNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCSTNo.TextChanged

    End Sub

    Private Sub txtPanNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPanNo.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            txtCSTNo.Focus()
        End If
    End Sub

    Private Sub txtLSTNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLSTNo.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            txtAddress1.Focus()
        End If
    End Sub

    Private Sub txtAddress1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddress1.TextChanged

    End Sub

    Private Sub txtCity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCity.TextChanged

    End Sub

    Private Sub txtState_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtState.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start(AppPath & "\STUDY\VENDORMASTER.XLS")
    End Sub
End Class