Imports System.Drawing.Color
Imports System.Data.SqlClient
Imports System.Windows.Forms.Screen
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Text.RegularExpressions

Public Class CustomerMaster
    Inherits System.Windows.Forms.Form
    Dim transactionsexists As Boolean
    Friend WithEvents cmd_export As System.Windows.Forms.Button
    Friend WithEvents cmd_rpt As System.Windows.Forms.Button
    Friend WithEvents Lbl_Last As System.Windows.Forms.Label
    Friend WithEvents txt_address1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_address3 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TXT_TINNO As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents cmd_browse As System.Windows.Forms.Button
    Friend WithEvents TxtGSTINNo As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
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
    Friend WithEvents txt_address2 As System.Windows.Forms.TextBox
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
    Friend WithEvents cmd_auth As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerMaster))
        Me.lbl_Heading = New System.Windows.Forms.Label()
        Me.CusCodeHelp = New System.Windows.Forms.Button()
        Me.txtCusName = New System.Windows.Forms.TextBox()
        Me.txtCusCode = New System.Windows.Forms.TextBox()
        Me.lbl_GroupDescription = New System.Windows.Forms.Label()
        Me.lbl_GroupCode = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_TINNO = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPanNo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtShortName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLSTNo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCSTNo = New System.Windows.Forms.TextBox()
        Me.CbxCustomerType = New System.Windows.Forms.ComboBox()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.CmdAdd = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_address3 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_address1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtContPerson = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtPinCode = New System.Windows.Forms.TextBox()
        Me.txtPHNo2 = New System.Windows.Forms.TextBox()
        Me.txtPHNo1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txt_address2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmd_browse = New System.Windows.Forms.Button()
        Me.cmd_export = New System.Windows.Forms.Button()
        Me.cmd_rpt = New System.Windows.Forms.Button()
        Me.cmd_auth = New System.Windows.Forms.Button()
        Me.CmdView = New System.Windows.Forms.Button()
        Me.cmdFreeze = New System.Windows.Forms.Button()
        Me.CmdExit = New System.Windows.Forms.Button()
        Me.lbl_Freeze = New System.Windows.Forms.Label()
        Me.Lbl_Last = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.TxtGSTINNo = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.Color.Black
        Me.lbl_Heading.Location = New System.Drawing.Point(204, 70)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(143, 18)
        Me.lbl_Heading.TabIndex = 7
        Me.lbl_Heading.Text = "VENDOR  MASTER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CusCodeHelp
        '
        Me.CusCodeHelp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CusCodeHelp.Image = CType(resources.GetObject("CusCodeHelp.Image"), System.Drawing.Image)
        Me.CusCodeHelp.Location = New System.Drawing.Point(533, 11)
        Me.CusCodeHelp.Name = "CusCodeHelp"
        Me.CusCodeHelp.Size = New System.Drawing.Size(24, 25)
        Me.CusCodeHelp.TabIndex = 1
        '
        'txtCusName
        '
        Me.txtCusName.BackColor = System.Drawing.Color.Wheat
        Me.txtCusName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCusName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusName.Location = New System.Drawing.Point(137, 40)
        Me.txtCusName.MaxLength = 150
        Me.txtCusName.Name = "txtCusName"
        Me.txtCusName.Size = New System.Drawing.Size(390, 21)
        Me.txtCusName.TabIndex = 2
        '
        'txtCusCode
        '
        Me.txtCusCode.BackColor = System.Drawing.Color.Wheat
        Me.txtCusCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCusCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCusCode.Location = New System.Drawing.Point(137, 12)
        Me.txtCusCode.MaxLength = 10
        Me.txtCusCode.Name = "txtCusCode"
        Me.txtCusCode.Size = New System.Drawing.Size(390, 21)
        Me.txtCusCode.TabIndex = 0
        '
        'lbl_GroupDescription
        '
        Me.lbl_GroupDescription.AutoSize = True
        Me.lbl_GroupDescription.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupDescription.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupDescription.Location = New System.Drawing.Point(26, 40)
        Me.lbl_GroupDescription.Name = "lbl_GroupDescription"
        Me.lbl_GroupDescription.Size = New System.Drawing.Size(91, 15)
        Me.lbl_GroupDescription.TabIndex = 11
        Me.lbl_GroupDescription.Text = "VENDOR NAME" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lbl_GroupDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_GroupCode
        '
        Me.lbl_GroupCode.AutoSize = True
        Me.lbl_GroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupCode.Location = New System.Drawing.Point(26, 12)
        Me.lbl_GroupCode.Name = "lbl_GroupCode"
        Me.lbl_GroupCode.Size = New System.Drawing.Size(90, 15)
        Me.lbl_GroupCode.TabIndex = 9
        Me.lbl_GroupCode.Text = "VENDOR CODE"
        Me.lbl_GroupCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TxtGSTINNo)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.TXT_TINNO)
        Me.GroupBox1.Controls.Add(Me.Label20)
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
        Me.GroupBox1.Location = New System.Drawing.Point(232, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(573, 268)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'TXT_TINNO
        '
        Me.TXT_TINNO.BackColor = System.Drawing.Color.White
        Me.TXT_TINNO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_TINNO.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TINNO.Location = New System.Drawing.Point(137, 205)
        Me.TXT_TINNO.MaxLength = 15
        Me.TXT_TINNO.Name = "TXT_TINNO"
        Me.TXT_TINNO.Size = New System.Drawing.Size(390, 21)
        Me.TXT_TINNO.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(26, 207)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 15)
        Me.Label20.TabIndex = 24
        Me.Label20.Text = "TIN NO"
        '
        'txtPanNo
        '
        Me.txtPanNo.BackColor = System.Drawing.Color.White
        Me.txtPanNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPanNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPanNo.Location = New System.Drawing.Point(137, 114)
        Me.txtPanNo.MaxLength = 20
        Me.txtPanNo.Name = "txtPanNo"
        Me.txtPanNo.Size = New System.Drawing.Size(390, 21)
        Me.txtPanNo.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(26, 116)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 18)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "PAN NO"
        '
        'txtShortName
        '
        Me.txtShortName.BackColor = System.Drawing.Color.White
        Me.txtShortName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtShortName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShortName.Location = New System.Drawing.Point(137, 69)
        Me.txtShortName.MaxLength = 15
        Me.txtShortName.Name = "txtShortName"
        Me.txtShortName.Size = New System.Drawing.Size(390, 21)
        Me.txtShortName.TabIndex = 3
        Me.txtShortName.Visible = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(26, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 23)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "SHORT NAME"
        Me.Label15.Visible = False
        '
        'txtLSTNo
        '
        Me.txtLSTNo.BackColor = System.Drawing.Color.White
        Me.txtLSTNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLSTNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLSTNo.Location = New System.Drawing.Point(137, 178)
        Me.txtLSTNo.MaxLength = 15
        Me.txtLSTNo.Name = "txtLSTNo"
        Me.txtLSTNo.Size = New System.Drawing.Size(390, 21)
        Me.txtLSTNo.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(26, 146)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 23)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "CST NO"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 18)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "LST NO"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "VENDOR TYPE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCSTNo
        '
        Me.txtCSTNo.BackColor = System.Drawing.Color.White
        Me.txtCSTNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCSTNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCSTNo.Location = New System.Drawing.Point(137, 146)
        Me.txtCSTNo.MaxLength = 15
        Me.txtCSTNo.Name = "txtCSTNo"
        Me.txtCSTNo.Size = New System.Drawing.Size(390, 21)
        Me.txtCSTNo.TabIndex = 6
        '
        'CbxCustomerType
        '
        Me.CbxCustomerType.BackColor = System.Drawing.Color.Wheat
        Me.CbxCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxCustomerType.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCustomerType.Location = New System.Drawing.Point(137, 83)
        Me.CbxCustomerType.Name = "CbxCustomerType"
        Me.CbxCustomerType.Size = New System.Drawing.Size(390, 23)
        Me.CbxCustomerType.TabIndex = 4
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.Transparent
        Me.CmdClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.Black
        Me.CmdClear.Image = Global.SmartCard.My.Resources.Resources.Clear
        Me.CmdClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdClear.Location = New System.Drawing.Point(4, 13)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(134, 56)
        Me.CmdClear.TabIndex = 24
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
        Me.CmdAdd.Location = New System.Drawing.Point(3, 76)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(134, 56)
        Me.CmdAdd.TabIndex = 22
        Me.CmdAdd.Text = "Add [F7]"
        Me.CmdAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdAdd.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txt_address3)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txt_address1)
        Me.GroupBox3.Controls.Add(Me.Label14)
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
        Me.GroupBox3.Controls.Add(Me.txt_address2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(226, 366)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(579, 296)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        '
        'txt_address3
        '
        Me.txt_address3.BackColor = System.Drawing.Color.White
        Me.txt_address3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_address3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address3.Location = New System.Drawing.Point(376, 61)
        Me.txt_address3.MaxLength = 50
        Me.txt_address3.Name = "txt_address3"
        Me.txt_address3.Size = New System.Drawing.Size(160, 21)
        Me.txt_address3.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(285, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 23)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "ADDRESS 3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txt_address1
        '
        Me.txt_address1.BackColor = System.Drawing.Color.White
        Me.txt_address1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_address1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address1.Location = New System.Drawing.Point(378, 24)
        Me.txt_address1.MaxLength = 50
        Me.txt_address1.Name = "txt_address1"
        Me.txt_address1.Size = New System.Drawing.Size(158, 21)
        Me.txt_address1.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(284, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 23)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "ADDRESS 1"
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.White
        Me.txtRemarks.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRemarks.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(377, 256)
        Me.txtRemarks.MaxLength = 50
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(160, 21)
        Me.txtRemarks.TabIndex = 21
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(283, 256)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 23)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "REMARKS"
        '
        'txtContPerson
        '
        Me.txtContPerson.BackColor = System.Drawing.Color.White
        Me.txtContPerson.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtContPerson.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContPerson.Location = New System.Drawing.Point(115, 256)
        Me.txtContPerson.MaxLength = 25
        Me.txtContPerson.Name = "txtContPerson"
        Me.txtContPerson.Size = New System.Drawing.Size(160, 21)
        Me.txtContPerson.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 37)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "CONT. PERSON"
        '
        'txtCountry
        '
        Me.txtCountry.BackColor = System.Drawing.Color.White
        Me.txtCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCountry.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCountry.Location = New System.Drawing.Point(115, 144)
        Me.txtCountry.MaxLength = 20
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(160, 21)
        Me.txtCountry.TabIndex = 14
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(11, 144)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 23)
        Me.Label18.TabIndex = 29
        Me.Label18.Text = "COUNTRY"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(376, 224)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(160, 21)
        Me.txtEmail.TabIndex = 19
        '
        'txtFax
        '
        Me.txtFax.BackColor = System.Drawing.Color.White
        Me.txtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(115, 224)
        Me.txtFax.MaxLength = 15
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(160, 21)
        Me.txtFax.TabIndex = 18
        '
        'txtPinCode
        '
        Me.txtPinCode.BackColor = System.Drawing.Color.White
        Me.txtPinCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPinCode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPinCode.Location = New System.Drawing.Point(376, 144)
        Me.txtPinCode.MaxLength = 9
        Me.txtPinCode.Name = "txtPinCode"
        Me.txtPinCode.Size = New System.Drawing.Size(160, 21)
        Me.txtPinCode.TabIndex = 15
        '
        'txtPHNo2
        '
        Me.txtPHNo2.BackColor = System.Drawing.Color.White
        Me.txtPHNo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPHNo2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHNo2.Location = New System.Drawing.Point(376, 184)
        Me.txtPHNo2.MaxLength = 25
        Me.txtPHNo2.Name = "txtPHNo2"
        Me.txtPHNo2.Size = New System.Drawing.Size(160, 21)
        Me.txtPHNo2.TabIndex = 17
        '
        'txtPHNo1
        '
        Me.txtPHNo1.BackColor = System.Drawing.Color.White
        Me.txtPHNo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPHNo1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPHNo1.Location = New System.Drawing.Point(115, 184)
        Me.txtPHNo1.MaxLength = 25
        Me.txtPHNo1.Name = "txtPHNo1"
        Me.txtPHNo1.Size = New System.Drawing.Size(160, 21)
        Me.txtPHNo1.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(283, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 23)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "EMAIL ID"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 23)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "FAX"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(283, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 23)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "PIN CODE NO"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(283, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 23)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Cell No"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 23)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "PHONE NO"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 23)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "ADDRESS 2"
        '
        'txtState
        '
        Me.txtState.BackColor = System.Drawing.Color.White
        Me.txtState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtState.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(377, 104)
        Me.txtState.MaxLength = 20
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(160, 21)
        Me.txtState.TabIndex = 13
        '
        'txtCity
        '
        Me.txtCity.BackColor = System.Drawing.Color.White
        Me.txtCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(115, 104)
        Me.txtCity.MaxLength = 20
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(160, 21)
        Me.txtCity.TabIndex = 12
        '
        'txt_address2
        '
        Me.txt_address2.BackColor = System.Drawing.Color.White
        Me.txt_address2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_address2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address2.Location = New System.Drawing.Point(114, 66)
        Me.txt_address2.MaxLength = 50
        Me.txt_address2.Name = "txt_address2"
        Me.txt_address2.Size = New System.Drawing.Size(160, 21)
        Me.txt_address2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(283, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "STATE"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "CITY"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Wheat
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.Items.AddRange(New Object() {"GOOD", "EXCELLENT"})
        Me.ComboBox1.Location = New System.Drawing.Point(115, 24)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 23)
        Me.ComboBox1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "RATINGS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cmd_browse)
        Me.GroupBox4.Controls.Add(Me.cmd_export)
        Me.GroupBox4.Controls.Add(Me.cmd_rpt)
        Me.GroupBox4.Controls.Add(Me.cmd_auth)
        Me.GroupBox4.Controls.Add(Me.CmdClear)
        Me.GroupBox4.Controls.Add(Me.CmdAdd)
        Me.GroupBox4.Controls.Add(Me.CmdView)
        Me.GroupBox4.Controls.Add(Me.cmdFreeze)
        Me.GroupBox4.Controls.Add(Me.CmdExit)
        Me.GroupBox4.Location = New System.Drawing.Point(861, 70)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(144, 566)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        '
        'cmd_browse
        '
        Me.cmd_browse.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_browse.Location = New System.Drawing.Point(5, 386)
        Me.cmd_browse.Name = "cmd_browse"
        Me.cmd_browse.Size = New System.Drawing.Size(131, 54)
        Me.cmd_browse.TabIndex = 30
        Me.cmd_browse.Text = "Browse"
        Me.cmd_browse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_browse.UseVisualStyleBackColor = True
        '
        'cmd_export
        '
        Me.cmd_export.BackColor = System.Drawing.Color.Transparent
        Me.cmd_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_export.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_export.ForeColor = System.Drawing.Color.Black
        Me.cmd_export.Image = Global.SmartCard.My.Resources.Resources.excel
        Me.cmd_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_export.Location = New System.Drawing.Point(3, 323)
        Me.cmd_export.Name = "cmd_export"
        Me.cmd_export.Size = New System.Drawing.Size(134, 56)
        Me.cmd_export.TabIndex = 29
        Me.cmd_export.Text = "Export"
        Me.cmd_export.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_export.UseVisualStyleBackColor = False
        '
        'cmd_rpt
        '
        Me.cmd_rpt.BackColor = System.Drawing.Color.Transparent
        Me.cmd_rpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_rpt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_rpt.ForeColor = System.Drawing.Color.Black
        Me.cmd_rpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_rpt.Location = New System.Drawing.Point(3, 263)
        Me.cmd_rpt.Name = "cmd_rpt"
        Me.cmd_rpt.Size = New System.Drawing.Size(134, 56)
        Me.cmd_rpt.TabIndex = 28
        Me.cmd_rpt.Text = "Report"
        Me.cmd_rpt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_rpt.UseVisualStyleBackColor = False
        '
        'cmd_auth
        '
        Me.cmd_auth.BackColor = System.Drawing.Color.Transparent
        Me.cmd_auth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_auth.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_auth.ForeColor = System.Drawing.Color.Black
        Me.cmd_auth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_auth.Location = New System.Drawing.Point(5, 446)
        Me.cmd_auth.Name = "cmd_auth"
        Me.cmd_auth.Size = New System.Drawing.Size(134, 56)
        Me.cmd_auth.TabIndex = 27
        Me.cmd_auth.Text = "Authorize"
        Me.cmd_auth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_auth.UseVisualStyleBackColor = False
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.Transparent
        Me.CmdView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CmdView.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.Black
        Me.CmdView.Image = Global.SmartCard.My.Resources.Resources.view
        Me.CmdView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdView.Location = New System.Drawing.Point(3, 200)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(134, 56)
        Me.CmdView.TabIndex = 26
        Me.CmdView.Text = " View[F9]"
        Me.CmdView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdView.UseVisualStyleBackColor = False
        '
        'cmdFreeze
        '
        Me.cmdFreeze.BackColor = System.Drawing.Color.Transparent
        Me.cmdFreeze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdFreeze.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFreeze.ForeColor = System.Drawing.Color.Black
        Me.cmdFreeze.Image = Global.SmartCard.My.Resources.Resources.Delete
        Me.cmdFreeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFreeze.Location = New System.Drawing.Point(3, 139)
        Me.cmdFreeze.Name = "cmdFreeze"
        Me.cmdFreeze.Size = New System.Drawing.Size(134, 56)
        Me.cmdFreeze.TabIndex = 25
        Me.cmdFreeze.Text = "Freeze[F8]"
        Me.cmdFreeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdFreeze.UseVisualStyleBackColor = False
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
        Me.CmdExit.Location = New System.Drawing.Point(5, 505)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(134, 56)
        Me.CmdExit.TabIndex = 23
        Me.CmdExit.Text = "Exit[F11]"
        Me.CmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdExit.UseVisualStyleBackColor = False
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(600, 50)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(139, 16)
        Me.lbl_Freeze.TabIndex = 431
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'Lbl_Last
        '
        Me.Lbl_Last.AutoSize = True
        Me.Lbl_Last.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Last.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Last.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Last.Location = New System.Drawing.Point(163, 114)
        Me.Lbl_Last.Name = "Lbl_Last"
        Me.Lbl_Last.Size = New System.Drawing.Size(63, 15)
        Me.Lbl_Last.TabIndex = 587
        Me.Lbl_Last.Text = "LAST NO :"
        Me.Lbl_Last.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FontDialog1
        '
        Me.FontDialog1.Color = System.Drawing.SystemColors.ControlText
        '
        'TxtGSTINNo
        '
        Me.TxtGSTINNo.BackColor = System.Drawing.Color.White
        Me.TxtGSTINNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtGSTINNo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGSTINNo.Location = New System.Drawing.Point(137, 235)
        Me.TxtGSTINNo.MaxLength = 15
        Me.TxtGSTINNo.Name = "TxtGSTINNo"
        Me.TxtGSTINNo.Size = New System.Drawing.Size(390, 21)
        Me.TxtGSTINNo.TabIndex = 27
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(26, 237)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 15)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "GSTIN NO"
        '
        'CustomerMaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = Global.SmartCard.My.Resources.Resources._111in1024res
        Me.CancelButton = Me.CmdExit
        Me.ClientSize = New System.Drawing.Size(1004, 686)
        Me.Controls.Add(Me.Lbl_Last)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "CustomerMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order Vendor Master"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
                Call autogenerate1()
                sqlstring = ""
                sqlstring = "Insert Into PO_VENDORMASTER(VendorCode,VendorName,Shortname,Panno,castno,lstno,address,address2,address3,city,state,country,pincode,phone1,phone2,fax,email,contactperson,remarks,freeze,adduser,adddatetime, RATINGS,TINNO,CATEGORY,GSTINNO) Values("
                sqlstring = sqlstring & "'" & txtCusCode.Text & "',"
                sqlstring = sqlstring & "'" & txtCusName.Text & "',"
                sqlstring = sqlstring & "'" & txtShortName.Text & "',"
                sqlstring = sqlstring & "'" & txtPanNo.Text & "',"
                sqlstring = sqlstring & "'" & txtCSTNo.Text & "',"
                sqlstring = sqlstring & "'" & txtLSTNo.Text & "',"
                sqlstring = sqlstring & "'" & txt_address1.Text & "',"
                sqlstring = sqlstring & "'" & txt_address2.Text & "',"
                sqlstring = sqlstring & "'" & txt_address3.Text & "',"
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
                sqlstring = sqlstring & ",'" & ComboBox1.Text & "', '" & TXT_TINNO.Text & "','" & CbxCustomerType.Text & "','" & TxtGSTINNo.Text & "')"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
                gconnection.MoreTrans(Insert)
                Me.CmdClear_Click(sender, e)
            ElseIf CmdAdd.Text = "Update [F7]" And Me.lbl_Freeze.Visible = True Then
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
                Array.Clear(Insert, 0, Insert.Length)
                sqlstring = ""
                sqlstring = "UPDATE PO_VENDORMASTER "
                sqlstring = sqlstring & "SET VendorCode = '" & txtCusCode.Text & "',"
                sqlstring = sqlstring & " VendorNAME = '" & txtCusName.Text & "',"
                sqlstring = sqlstring & " SHORTNAME = '" & txtShortName.Text & "',"
                sqlstring = sqlstring & " PANNO = '" & txtPanNo.Text & "',"
                sqlstring = sqlstring & " castNO = '" & txtCSTNo.Text & "',"
                sqlstring = sqlstring & " lstNO = '" & txtLSTNo.Text & "',"
                sqlstring = sqlstring & " address = '" & txt_address1.Text & "',"
                sqlstring = sqlstring & " address2 = '" & txt_address2.Text & "',"
                sqlstring = sqlstring & " address3 = '" & txt_address3.Text & "',"
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
                sqlstring = sqlstring & " UPDATEDATETIME = '" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "', "
                sqlstring = sqlstring & " RATINGS='" & ComboBox1.Text & " ', TINNO='" & TXT_TINNO.Text & "', CATEGORY='" & CbxCustomerType.Text & "',GSTINNO='" & TxtGSTINNo.Text & "' "
                sqlstring = sqlstring & " WHERE VENDORcode = '" & Trim(txtCusCode.Text) & "'"
                'gconnection.dataOperation(2, sqlstring, "PO_VENDORMASTER")
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
                sqlstring = ""
                sqlstring = "UPDATE ACCOUNTSSUBLEDGERMASTER SET SLNAME='" & txtCusName.Text & "', "
                sqlstring = sqlstring & "SLDESC='" & txtCusName.Text & "', CONTACTPERSON='" & txtContPerson.Text & "',"
                sqlstring = sqlstring & "ADDRESS1 = '" & txt_address1.Text & "', ADDRESS2 = '" & txt_address2.Text & "',ADDRESS3='" & txt_address3.Text & "', CITY='" & txtCity.Text & "',"
                sqlstring = sqlstring & "STATE='" & txtState.Text & "', PIN='" & txtPinCode.Text & "', PHONENO='" & txtPHNo1.Text & "', CELLNO='" & txtPHNo2.Text & "',"
                sqlstring = sqlstring & "VATNO='" & txtLSTNo.Text & "', CSTNO='" & txtCSTNo.Text & "', PANNO='" & txtPanNo.Text & "', TINNO='" & TXT_TINNO.Text & "', fax='" & txtFax.Text & "',"
                sqlstring = sqlstring & "EMAILID='" & txtEmail.Text & "', CATEGORY='" & CbxCustomerType.Text & "',GSTINNO='" & TxtGSTINNo.Text & "' WHERE SLCODE='" & Trim(txtCusCode.Text) & "'"
                ReDim Preserve Insert(Insert.Length)
                Insert(Insert.Length - 1) = sqlstring
                gconnection.MoreTrans(Insert)
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
            Call GetLastNo()
            ' Call FILLCATEGORY()
            CbxCustomerType.SelectedIndex = 0
            Call clearform(Me)
            Me.TXT_TINNO.Text = ""
            Me.txt_address1.Text = ""
            Me.txt_address3.Text = ""
            Me.txtCusCode.Text = ""
            Me.txtCusName.Text = ""
            Me.txtShortName.Text = ""
            Me.txtPanNo.Text = ""
            Me.txtCSTNo.Text = ""
            Me.txtLSTNo.Text = ""
            Me.txt_address2.Text = ""
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
            Me.cmdFreeze.Enabled = True
            txtCusCode.ReadOnly = False
            CmdAdd.Enabled = True
            txtCusCode.Focus()
            Call autogenerate1()
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Clear Click")
        End Try
        If Not String.IsNullOrEmpty(gAuditFlg) Then
            If gAuditFlg.ToUpper = "Y" Then
                Me.CmdAdd.Enabled = False
                Me.cmdFreeze.Enabled = False
            End If
        End If
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Try
            Dim a As String
            a = MessageBox.Show("Are you Sure Want to Exit from this Form", MyCompanyName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
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
            'gSQLString = ""
            'gSQLString = "SELECT ISNULL(vendorcode,'') AS vendorcode,ISNULL(vendorname,'') AS vendorname FROM  PO_VIEW_VENDORMASTER"
            'M_WhereCondition = ""
            'Dim vform As New ListOperattion1
            'vform.Field = "VENDORCODE, VENDORNAME"
            'vform.vFormatstring = "    VENDOR CODE        |         VENDOR NAME           "
            'vform.vCaption = "VENDOR MASTER HELP"
            'vform.KeyPos = 0
            'vform.KeyPos1 = 1
            'vform.ShowDialog(Me)
            'If Trim(vform.keyfield & "") <> "" Then
            '    txtCusCode.Text = Trim(vform.keyfield & "")
            '    txtCusName.Text = Trim(vform.keyfield1 & "")
            '    Call txtCusCode_Validated(txtCusCode, e)
            'End If
            'vform.Close()
            'vform = Nothing
            '************************************
            gSQLString = ""
            gSQLString = "SELECT  ISNULL(vendorname,'') AS vendorname,ISNULL(vendorcode,'') AS vendorcode FROM  PO_VIEW_VENDORMASTER "
            M_WhereCondition = ""
            M_ORDERBY = " Order by vendorname, vendorcode "
            Dim vform As New ListOperattion1_N
            vform.Field = " VENDORNAME, VENDORCODE"
            vform.vFormatstring = "                             VENDOR NAME                                        |         VENDOR CODE           "
            vform.vCaption = "VENDOR MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txtCusCode.Text = Trim(vform.keyfield1 & "")
                txtCusName.Text = Trim(vform.keyfield & "")
                Call txtCusCode_Validated(txtCusCode, e)
            End If
            vform.Close()
            vform = Nothing
            M_ORDERBY = ""
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Customer Code Help Click")
        End Try
    End Sub
    Private Sub txtCusCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCusCode.Validated
        Try
            Dim sqlstring As String
            If Trim(txtCusCode.Text) <> "" Then
                sqlstring = "SELECT ISNULL(VENDORCODE,'') AS VENDORCODE, ISNULL(vendortype,'') AS VENDORTYPE,ISNULL(vendorname,'') AS VENDORNAME,ISNULL(shortname,'') AS SHORTNAME,ISNULL(panno,'') AS PANNO,ISNULL(castno,'') AS CASTNO,ISNULL(lstno,'') AS LSTNO,ISNULL(ratings,'') AS RATINGS,ISNULL(licenceno,'') AS LICENCENO,ISNULL(licencedate,'') AS LICENCEDATE,ISNULL(address,'') AS ADDRESS,isnull(address2,'') as address2,isnull(address3,'') as address3,ISNULL(city,'') AS city,ISNULL(state,'') AS state,ISNULL(country,'') AS country,ISNULL(pincode,0) AS pincode,ISNULL(phone1,0) AS phone1,ISNULL(phone2,0) AS phone2,ISNULL(fax,'') AS FAX,ISNULL(email,'') AS email,ISNULL(contactperson,'') AS contactperson,ISNULL(remarks,'') AS remarks,ISNULL(FREEZE,'') AS FREEZE,ISNULL(ADDDATETIME,'') AS ADDDATETIME, ISNULL(TINNO,'') AS TINNO, ISNULL(CATEGORY,'') AS CATEGORY,isnull(gstinno,'') as gstinno FROM PO_VENDORMASTER WHERE VENDORCode='" & Trim(txtCusCode.Text) & "'"
                gconnection.getDataSet(sqlstring, "PO_VENDORMASTER")
                If gdataset.Tables("PO_VENDORMASTER").Rows.Count > 0 Then
                    txtCusCode.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("VendorCode"))
                    txtCusName.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("VendorName"))
                    txtShortName.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("ShortName"))
                    'CbxCustomerType.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("VendorType"))
                    txtPanNo.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("PANNo"))
                    txtLSTNo.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("LSTNo"))
                    txtCSTNo.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("CASTNo"))
                    txt_address1.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Address"))
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
                    txt_address2.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("address2"))
                    txt_address3.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("address3"))
                    ComboBox1.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("RATINGS"))
                    TXT_TINNO.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("TINNO"))
                    CbxCustomerType.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("CATEGORY"))
                    TxtGSTINNo.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("gstinno"))
                    If gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Freeze") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = ""
                        Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("AddDatetime")), "dd-MMM-yyyy")
                        ' Me.cmdFreeze.Text = "UnFreeze[F8]"
                        Me.cmdFreeze.Enabled = False
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.cmdFreeze.Text = "Freeze[F8]"
                    End If

                    txtCusName.Focus()
                    txtCusCode.ReadOnly = True
                    Me.CmdAdd.Text = "Update [F7]"
                Else
                    sqlstring = "SELECT ISNULL(slcode,'') AS VENDORCODE, ISNULL(sldesc,'') AS VENDORNAME, ISNULL(address1,'') AS ADDRESS1, ISNULL(address2,'') AS ADDRESS2,"
                    sqlstring = sqlstring & "ISNULL(address3,'') AS ADDRESS3, ISNULL(city,'') AS CITY, ISNULL(state,'') AS STATE, ISNULL(pin,0) AS PIN, ISNULL(phoneno,0) AS PHONENO,"
                    sqlstring = sqlstring & "ISNULL(PANNO,'')AS PANNO,ISNULL(CSTNO,'')AS CSTNO,ISNULL(cellno,0) AS CELLNO,ISNULL(contactperson,'') AS CONTACTPERSON, ISNULL(FAX,0) AS FAX, ISNULL(TINNO,'') AS TINNO, ISNULL(EMAILID,'') AS EMAIL,ISNULL(CATEGORY,'') AS CATEGORY,isnull(GSTINNo,'') as GSTINNo  from accountssubledgermaster where slcode ='" & Trim(txtCusCode.Text) & "'"
                    gconnection.getDataSet(sqlstring, "subledger")
                    If gdataset.Tables("subledger").Rows.Count > 0 Then
                        txtCusCode.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("VendorCode"))
                        txtCusName.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("VendorName"))
                        txt_address1.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("address1"))
                        txt_address2.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("address2"))
                        txt_address3.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("address3"))
                        txtCity.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("city"))
                        txtState.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("state"))
                        txtPinCode.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("pin"))
                        txtPHNo1.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("phoneno"))
                        txtPHNo2.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("cellno"))
                        txtPanNo.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("panno"))
                        txtCSTNo.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("cstno"))
                        txtContPerson.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("contactperson"))
                        txtFax.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("FAX"))
                        TXT_TINNO.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("TINNO"))
                        txtPanNo.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("PANNO"))
                        txtEmail.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("Email"))
                        CbxCustomerType.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("CATEGORY"))
                        TxtGSTINNo.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("GSTINNo"))
                        txtCusCode.ReadOnly = True
                        CmdAdd.Enabled = False
                        Me.CmdAdd.Text = "Update [F7]"
                    Else  'End If

                        Me.lbl_Freeze.Visible = False
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.CmdAdd.Text = "Add [F7]"
                        Me.txtCusCode.ReadOnly = False
                        Me.txtCusName.Focus()
                    End If

                End If
                'If gUserCategory <> "S" Then
                '    Call GetRights()
                'End If
            Else
                txtCusCode.Focus()
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            If Not String.IsNullOrEmpty(gAuditFlg) Then
                If gAuditFlg.ToUpper = "Y" Then
                    Me.CmdAdd.Enabled = False
                    Me.cmdFreeze.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Customer Code Validated")
        End Try
    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='PURCHASE ORDER' AND MODULENAME LIKE 'PaymentTerms%' ORDER BY RIGHTS"
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
        Me.cmd_rpt.Enabled = False
        Me.cmd_export.Enabled = False
        Me.cmd_auth.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdAdd.Enabled = True
                    Me.cmdFreeze.Enabled = True
                    Me.CmdView.Enabled = True
                    Me.cmd_auth.Enabled = True
                    Me.cmd_export.Enabled = True
                    Me.cmd_rpt.Enabled = True
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
                    Me.cmdFreeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                    Me.cmd_rpt.Enabled = True
                    Me.cmd_export.Enabled = True
                End If
                If Right(x) = "U" Then
                    Me.cmd_auth.Enabled = True
                End If
            Next
        End If


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
                        'Else
                        '    strsql = "UPDATE  PO_VendorMaster "
                        '    strsql = strsql & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
                        '    strsql = strsql & " WHERE Vendorcode = '" & Trim(txtCusCode.Text) & "'"
                        '    gconnection.dataOperation(4, strsql, "PO_VendorMaster")
                        '    Me.CmdClear_Click(sender, e)
                        '    CmdAdd.Text = "Add [F7]"
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
                If CmdAdd.Enabled = True Then
                    Call CmdAdd_Click(CmdAdd, e)
                End If
            End If
            If e.KeyCode = Keys.F8 Then
                If cmdFreeze.Enabled = True Then
                    Call Cmdfreeze_Click(cmdFreeze, e)
                End If
            End If
            If e.KeyCode = Keys.F9 And CmdView.Enabled = True Then
                Call CmdView_Click(CmdView, e)
            End If
            If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
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
                    ' txtShortName.Focus()
                    CbxCustomerType.Focus()
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
                'ComboBox1.Focus()
                TXT_TINNO.Focus()
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

    Private Sub txtAddress1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_address2.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txt_address3.Focus()
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
                txtCountry.Focus()
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
                txtFax.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Phone2 Keydown")
        End Try
    End Sub

    Private Sub txtMobile_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPinCode.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtPHNo1.Focus()
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
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtContPerson.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Clear Keydown")
        End Try
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
        'Try
        '    Dim FrReport As New ReportDesigner
        '    tables = " PO_VENDORMASTER"
        '    Gheader = "VENDOR MASTER"
        '    FrReport.SsGridReport.SetText(2, 1, "VENDORCODE")
        '    FrReport.SsGridReport.SetText(3, 1, 10)
        '    FrReport.SsGridReport.SetText(2, 2, "VENDORNAME")
        '    FrReport.SsGridReport.SetText(3, 2, 30)
        '    FrReport.SsGridReport.SetText(2, 3, "SHORTNAME")
        '    FrReport.SsGridReport.SetText(3, 3, 10)
        '    FrReport.SsGridReport.SetText(2, 4, "RATINGS")
        '    FrReport.SsGridReport.SetText(3, 4, 8)
        '    FrReport.SsGridReport.SetText(2, 5, "CONTACTPERSON")
        '    FrReport.SsGridReport.SetText(3, 5, 17)
        '    FrReport.Show()
        'Catch ex As Exception
        '    MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "View Click")
        'End Try
        Dim FRM As New ReportDesigner
        'If txtCusCode.Text.Length > 0 Then
        '    tables = " FROM PO_VENDORMASTER WHERE VENDORCODE ='" & txtCusCode.Text & "' "
        'Else
        '    tables = "FROM PO_VENDORMASTER "
        'End If

        If CbxCustomerType.Text <> "" Then
            If txtCusCode.Text.Length > 0 Then
                tables = " FROM PO_VIEW_VENDORMASTER WHERE VENDORCODE ='" & txtCusCode.Text & "' And Category='" & CbxCustomerType.Text & "' "
            Else
                tables = "FROM PO_VIEW_VENDORMASTER  Where Category='" & CbxCustomerType.Text & "'"
            End If
        Else
            If txtCusCode.Text.Length > 0 Then
                tables = " FROM PO_VIEW_VENDORMASTER WHERE VENDORCODE ='" & txtCusCode.Text & "' "
            Else
                tables = "FROM PO_VIEW_VENDORMASTER "
            End If
        End If


        
        Gheader = "VENDOR DETAILS"
        FRM.DataGridView1.ColumnCount = 2
        FRM.DataGridView1.Columns(0).Name = "COLUMN NAME"
        FRM.DataGridView1.Columns(0).Width = 300
        FRM.DataGridView1.Columns(1).Name = "SIZE"
        FRM.DataGridView1.Columns(1).Width = 100

        Dim ROW As String() = New String() {"vendorcode", "10"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"SLTYPE", "10"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"vendorname", "30"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"TINNO", "10"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"panno", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"castno", "10"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"lstno", "10"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"Ratings", "10"}
        'FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"address1", "30"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"address2", "30"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"city", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"state", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"country", "10"}
        'FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"phone", "10"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"MOBILE", "10"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"email", "30"}
        FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"Freeze", "7"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"Adduser", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"adddatetime", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"updateuser", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"updatedatetime", "16"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"freezeuser", "15"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"freezedatetime", "18"}
        'FRM.DataGridView1.Rows.Add(ROW)
        Dim CHK As New DataGridViewCheckBoxColumn()
        FRM.DataGridView1.Columns.Insert(0, CHK)
        CHK.HeaderText = "CHECK"
        CHK.Name = "CHK"
        FRM.ShowDialog(Me)
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
                ' txtCusName.Focus()
                txtPanNo.Focus()
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
    Private Sub GetLastNo()
        Dim SQLSTRING As String
        Dim DR As DataRow
        'SQLSTRING = "SELECT Isnull(Max(VENDORCODE),0)as VENDORCODE FROM PO_VENDORMASTER "
        SQLSTRING = "select max(cast(vendorcode as numeric)) as vendorcode from PO_VIEW_VENDORMASTER where isnumeric(vendorcode)=1 and vendorcode like '%[0-9]%'"
        gconnection.getDataSet(SQLSTRING, "membermaster")
        If gdataset.Tables("membermaster").Rows.Count > 0 Then
            Me.Lbl_Last.Text = "Last No IS : " & " " & gdataset.Tables("membermaster").Rows(0).Item(0)
        Else
            Me.Lbl_Last.Text = "Last No" & " " & 0
        End If

    End Sub
    Private Sub CustomerMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Resize_Form()
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
        Call FILLCATEGORY()
        Call GetLastNo()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        If Not String.IsNullOrEmpty(gAuditFlg) Then
            If gAuditFlg.ToUpper = "Y" Then
                Me.CmdAdd.Enabled = False
                Me.cmdFreeze.Enabled = False
            End If
        End If
        Call autogenerate1()

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
        If txtEmail.Text <> "" Then
            getEmail(txtEmail)
            'boolchk = False
            'Exit Function
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
        ' getAlphanumeric(e)
    End Sub

    Private Sub txtPanNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPanNo.KeyPress

    End Sub

    Private Sub txtCSTNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCSTNo.TextChanged

        'Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        'If myRegex.IsMatch(txtCSTNo.Text.Trim) = False Then
        '    MsgBox("Invalid characters found")
        '    txtCSTNo.Text = ""
        '    Exit Sub

        'End If
    End Sub

    Private Sub txtPanNo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPanNo.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            txtCSTNo.Focus()
        End If
    End Sub

    Private Sub txtLSTNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLSTNo.TextChanged
        'Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        'If myRegex.IsMatch(txtLSTNo.Text.Trim) = False Then
        '    MsgBox("Invalid characters found")
        '    txtLSTNo.Text = ""
        '    Exit Sub

        'End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            txt_address1.Focus()
        End If
    End Sub

    Private Sub txtAddress1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_address2.TextChanged

    End Sub

    Private Sub txtCity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCity.TextChanged

    End Sub

    Private Sub txtState_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtState.TextChanged

    End Sub


    Private Sub cmd_rpt_Click(sender As Object, e As EventArgs) Handles cmd_rpt.Click
        gPrint = False
        'If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
        Dim rViewer As New Viewer
        Dim sqlstring, SSQL As String
        Dim r As New Rpt_Vendormaster
        ' Dim r As New CrystalReport1
        'sqlstring = "SELECT * FROM PO_VENDORMASTER order by VENDORCODE "

        If CbxCustomerType.Text <> "" Then
            sqlstring = "SELECT * FROM PO_VIEW_VENDORMASTER Where Category='" & CbxCustomerType.Text & "' order by VENDORCODE "
        Else
            sqlstring = "SELECT * FROM PO_VIEW_VENDORMASTER order by VENDORCODE "
        End If


        ' sqlstring = "SELECT * FROM inventoryitemmaster "
        gconnection.getDataSet(sqlstring, "PO_VENDORMASTER")
        If gdataset.Tables("PO_VENDORMASTER").Rows.Count > 0 Then

            rViewer.ssql = sqlstring
            rViewer.Report = r
            rViewer.TableName = "PO_VENDORMASTER"
            Dim textobj1 As TextObject
            textobj1 = r.ReportDefinition.ReportObjects("Text13")
            textobj1.Text = MyCompanyName
            Dim textobj2 As TextObject
            textobj2 = r.ReportDefinition.ReportObjects("Text21")
            textobj2.Text = gUsername
            rViewer.Show()

        Else
            MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
        End If

        ' Else
        ' PRINTOPERATION()
        '     End If
    End Sub

    Private Sub cmd_export_Click(sender As Object, e As EventArgs) Handles cmd_export.Click
        Dim sqlstring As String
        Dim _export As New EXPORT
        _export.TABLENAME = "PO_VENDORMASTER"
        sqlstring = "select * from PO_VENDORMASTER"
        Call _export.export_excel(sqlstring)
        _export.Show()
        Exit Sub
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
            SSQLSTR2 = " SELECT * FROM PO_VENDORMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM PO_VENDORMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE PO_VENDORMASTER set  ", "VENDORCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM PO_VENDORMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM PO_VENDORMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE PO_VENDORMASTER set  ", "VENDORCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            End If
        ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM PO_VENDORMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM PO_VENDORMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE PO_VENDORMASTER set  ", "VENDORCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                        End If
                    End If
                End If
            Else
                MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub txtPinCode_TextChanged(sender As Object, e As EventArgs) Handles txtPinCode.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(txtPinCode.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            txtPinCode.Text = ""
            Exit Sub

        End If
    End Sub

    Private Sub txtPHNo2_TextChanged(sender As Object, e As EventArgs) Handles txtPHNo2.TextChanged
        'Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        'If myRegex.IsMatch(txtPHNo2.Text.Trim) = False Then
        '    MsgBox("Invalid characters found")
        '    txtPHNo2.Text = ""
        '    Exit Sub

        'End If
    End Sub

  
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub txtEmail_Validated(sender As Object, e As EventArgs) Handles txtEmail.Validated
        ' getEmail(txtEmail)
    End Sub

    Private Sub txtPHNo1_TextChanged(sender As Object, e As EventArgs) Handles txtPHNo1.TextChanged
        'Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        'If myRegex.IsMatch(txtPHNo1.Text.Trim) = False Then
        '    MsgBox("Invalid characters found")
        '    txtPHNo1.Text = ""
        '    Exit Sub

        'End If
    End Sub

    Private Sub txtFax_TextChanged(sender As Object, e As EventArgs) Handles txtFax.TextChanged
        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(txtFax.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            txtFax.Text = ""
            Exit Sub

        End If
    End Sub

    Private Sub txtCountry_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCountry.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtPinCode.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "State Keydown")
        End Try
    End Sub

    Private Sub txtContPerson_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContPerson.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                txtRemarks.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Clear Keydown")
        End Try
    End Sub

    Private Sub txtRemarks_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRemarks.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                CmdAdd.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Clear Keydown")
        End Try
    End Sub

    Private Sub txt_address1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_address1.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            txt_address2.Focus()
        End If
    End Sub

    Private Sub txt_address3_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_address3.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            txtCity.Focus()
        End If
    End Sub
    Public Sub Resize_Form()
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
        If U = 800 Then
            T = T - 50
        End If
        If U = 1280 Then
            T = T - 50
        End If
        If U = 1360 Then
            T = T - 75
        End If
        If U = 1366 Then
            T = T - 75
        End If
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

    Private Sub TXT_TINNO_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_TINNO.KeyDown
        Try
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
                ComboBox1.Focus()
                'TXT_TINNO.Focus()
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "LSTNO Keydown")
        End Try
    End Sub

    Public Sub FILLCATEGORY()
        Dim I As Integer
        gSQLString = "select distinct VGROUP_CODE, VGROUP_DESC from PO_VENDOR_GROUPMASTER order by VGROUP_DESC"
        gconnection.getDataSet(gSQLString, "inventorycategorymaster")
        If gdataset.Tables("inventorycategorymaster").Rows.Count > 0 Then
            For I = 0 To gdataset.Tables("inventorycategorymaster").Rows.Count - 1
                CbxCustomerType.Items.Add(gdataset.Tables("inventorycategorymaster").Rows(I).Item("VGROUP_DESC"))
            Next
        End If

    End Sub

    Private Sub cmd_browse_Click(sender As Object, e As EventArgs) Handles cmd_browse.Click
        Dim obj1 As New VIEWHDR
        Dim sqlstr As String
        Dim childsql As String
        'sqlstr = "SELECT ISNULL(VENDORCODE,'') AS VENDORCODE, ISNULL(vendortype,'') AS VENDORTYPE,ISNULL(vendorname,'') AS VENDORNAME,ISNULL(address,'') AS ADDRESS1,isnull(address2,'') as address2,isnull(address3,'') as address3,ISNULL(city,'') AS city,ISNULL(state,'') AS state,ISNULL(country,'') AS country,ISNULL(pincode,0) AS pincode,ISNULL(phone1,0) AS phone1,ISNULL(phone2,0) AS phone2,ISNULL(fax,'') AS FAX,ISNULL(email,'') AS email,ISNULL(contactperson,'') AS contactperson,ISNULL(panno,'') AS PANNO,ISNULL(lstno,'') AS LSTNO,ISNULL(ratings,'') AS RATINGS,ISNULL(remarks,'') AS remarks, ISNULL(TINNO,'') AS TINNO, ISNULL(CATEGORY,'') AS CATEGORY FROM PO_VENDORMASTER "
        'sqlstr = "SELECT * FROM PO_VIEW_VENDORMASTER"
        sqlstr = "SELECT ISNULL(VENDORCODE,'') AS VENDORCODE, ISNULL(VENDORNAME,'') AS VENDORNAME, ISNULL(ADDRESS1,'') AS ADDRESS1, ISNULL(ADDRESS2,'') AS ADDRESS2,"
        sqlstr = sqlstr & "ISNULL(ADDRESS3,'') AS ADDRESS3, ISNULL(CITY,'') AS CITY, ISNULL(STATE,'') AS STATE, ISNULL(PINCODE,0) AS PINCODE, ISNULL(PHONE,'') AS PHONE,"
        sqlstr = sqlstr & "ISNULL(MOBILE,'') AS MOBILE, ISNULL(FAX,0) AS FAX, ISNULL(EMAIL,'') AS EMAIL, ISNULL(CONTACTPERSON,'') AS CONTACTPERSON, ISNULL(VATNO,'') AS VATNO, "
        sqlstr = sqlstr & "ISNULL(TINNO,'') AS TINNO, ISNULL(PANNO,'') AS PANNO FROM PO_VIEW_VENDORMASTER  ORDER BY Len(VENDORCODE),VENDORCODE "
        'M_ORDERBY = " ORDER BY Len(VENDORCODE),VENDORCODE "
        childsql = "SELECT * FROM VENDOR_POWO_HO "
        gconnection.getDataSet(sqlstr, "vdet")
        If gdataset.Tables("vdet").Rows.Count > 0 Then
            gconnection.getDataSet(sqlstr, "PO_VENDORMASTER")
            obj1.LOADGRID(gdataset.Tables("PO_VENDORMASTER"), True, "VENDOR_POWO_HO", childsql, "vendorcode", 1)
            obj1.Show()
        Else
            sqlstr = "SELECT ISNULL(slcode,'') AS VENDORCODE, ISNULL(sldesc,'') AS VENDORNAME, ISNULL(address1,'') AS ADDRESS1, ISNULL(address2,'') AS ADDRESS2,"
            sqlstr = sqlstr & "ISNULL(address3,'') AS ADDRESS3, ISNULL(city,'') AS CITY, ISNULL(state,'') AS STATE, ISNULL(pin,0) AS PIN, ISNULL(phoneno,0) AS PHONENO,"
            sqlstr = sqlstr & "ISNULL(PANNO,'')AS PANNO,ISNULL(CSTNO,'')AS CSTNO,ISNULL(cellno,0) AS CELLNO,ISNULL(contactperson,'') AS CONTACTPERSON, ISNULL(FAX,0) AS FAX, ISNULL(TINNO,'') AS TINNO, ISNULL(EMAILID,'') AS EMAIL,ISNULL(CATEGORY,'') AS CATEGORY  from accountssubledgermaster"
            childsql = "SELECT * FROM VENDOR_POWO_HO "
            gconnection.getDataSet(sqlstr, "vdet1")
            gconnection.getDataSet(sqlstr, "accountssubledgermaster")
            obj1.LOADGRID(gdataset.Tables("accountssubledgermaster"), True, "VENDOR_POWO_HO", childsql, "VENDORCODE", 1)
            obj1.Show()
        End If
        'sqlstr = sqlstr & " Suppliername,HIREREASON,FROMDATE,TODATE,Totalamount,Surchargeamt,OverallDiscount,VATAMOUNT,Discount,Billamount,Remarks,Void,Adduser,Adddate,Updateuser,Updatetime,updfooter,updname,Grntype,TRANSPORTATION,INDENTDATE from Hrn_header"
        'childsql = "select Grnno,Grndetails,Grndate,Suppliercode,Suppliername,Itemname,Qty,Rate,TAXAMOUNT,Discount,Amount,Adduser,Adddate,UpdateUser,Updatetime,GRNTYPE,UOM from Hrn_details"

        
    End Sub

    Private Sub autogenerate1()
        Dim sqlstring, financalyear As String
        Try
            sqlstring = "select max(cast(vendorcode as numeric))+1 as vendorcode from PO_VIEW_VENDORMASTER where isnumeric(vendorcode)=1 and vendorcode like '%[0-9]%'"
            gconnection.getDataSet(sqlstring, "MaxNoPO_VIEW_VENDORMASTER")
            If gdataset.Tables("MaxNoPO_VIEW_VENDORMASTER").Rows.Count > 0 Then
                txtCusCode.Text = gdataset.Tables("MaxNoPO_VIEW_VENDORMASTER").Rows(0).Item("vendorcode")
                txtCusCode.ReadOnly = True
            End If

        Catch ex As Exception
            MessageBox.Show("Plz Check Error" + ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub txtCusName_Validated(sender As Object, e As EventArgs) Handles txtCusName.Validated
        Try
            Dim sqlstring As String
            If Trim(txtCusName.Text) <> "" Then
                sqlstring = "SELECT ISNULL(VENDORCODE,'') AS VENDORCODE, ISNULL(vendortype,'') AS VENDORTYPE,ISNULL(vendorname,'') AS VENDORNAME,ISNULL(shortname,'') AS SHORTNAME,ISNULL(panno,'') AS PANNO,ISNULL(castno,'') AS CASTNO,ISNULL(lstno,'') AS LSTNO,ISNULL(ratings,'') AS RATINGS,ISNULL(licenceno,'') AS LICENCENO,ISNULL(licencedate,'') AS LICENCEDATE,ISNULL(address,'') AS ADDRESS,isnull(address2,'') as address2,isnull(address3,'') as address3,ISNULL(city,'') AS city,ISNULL(state,'') AS state,ISNULL(country,'') AS country,ISNULL(pincode,0) AS pincode,ISNULL(phone1,0) AS phone1,ISNULL(phone2,0) AS phone2,ISNULL(fax,'') AS FAX,ISNULL(email,'') AS email,ISNULL(contactperson,'') AS contactperson,ISNULL(remarks,'') AS remarks,ISNULL(FREEZE,'') AS FREEZE,ISNULL(ADDDATETIME,'') AS ADDDATETIME, ISNULL(TINNO,'') AS TINNO, ISNULL(CATEGORY,'') AS CATEGORY FROM PO_VENDORMASTER WHERE VENDORNAme='" & Trim(txtCusName.Text) & "'"
                gconnection.getDataSet(sqlstring, "PO_VENDORMASTER")
                If gdataset.Tables("PO_VENDORMASTER").Rows.Count > 0 Then
                    txtCusCode.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("VendorCode"))
                    txtCusName.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("VendorName"))
                    txtShortName.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("ShortName"))
                    'CbxCustomerType.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("VendorType"))
                    txtPanNo.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("PANNo"))
                    txtLSTNo.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("LSTNo"))
                    txtCSTNo.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("CASTNo"))
                    txt_address1.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Address"))
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
                    txt_address2.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("address2"))
                    txt_address3.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("address3"))
                    ComboBox1.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("RATINGS"))
                    TXT_TINNO.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("TINNO"))
                    CbxCustomerType.Text = Trim(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("CATEGORY"))
                    If gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("Freeze") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = ""
                        Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("PO_VENDORMASTER").Rows(0).Item("AddDatetime")), "dd-MMM-yyyy")
                        ' Me.cmdFreeze.Text = "UnFreeze[F8]"
                        Me.cmdFreeze.Enabled = False
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.cmdFreeze.Text = "Freeze[F8]"
                    End If

                    CbxCustomerType.Focus()
                    txtCusCode.ReadOnly = True
                    Me.CmdAdd.Text = "Update [F7]"
                Else
                    sqlstring = "SELECT ISNULL(slcode,'') AS VENDORCODE, ISNULL(sldesc,'') AS VENDORNAME, ISNULL(address1,'') AS ADDRESS1, ISNULL(address2,'') AS ADDRESS2,"
                    sqlstring = sqlstring & "ISNULL(address3,'') AS ADDRESS3, ISNULL(city,'') AS CITY, ISNULL(state,'') AS STATE, ISNULL(pin,0) AS PIN, ISNULL(phoneno,0) AS PHONENO,"
                    sqlstring = sqlstring & "ISNULL(PANNO,'')AS PANNO,ISNULL(CSTNO,'')AS CSTNO,ISNULL(cellno,0) AS CELLNO,ISNULL(contactperson,'') AS CONTACTPERSON, ISNULL(FAX,0) AS FAX, ISNULL(TINNO,'') AS TINNO, ISNULL(EMAILID,'') AS EMAIL,ISNULL(CATEGORY,'') AS CATEGORY  from accountssubledgermaster where slname ='" & Trim(txtCusName.Text) & "' or sldesc='" + Trim(txtCusName.Text) + "'"
                    gconnection.getDataSet(sqlstring, "subledger")
                    If gdataset.Tables("subledger").Rows.Count > 0 Then
                        txtCusCode.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("VendorCode"))
                        txtCusName.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("VendorName"))
                        txt_address1.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("address1"))
                        txt_address2.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("address2"))
                        txt_address3.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("address3"))
                        txtCity.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("city"))
                        txtState.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("state"))
                        txtPinCode.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("pin"))
                        txtPHNo1.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("phoneno"))
                        txtPHNo2.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("cellno"))
                        txtPanNo.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("panno"))
                        txtCSTNo.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("cstno"))
                        txtContPerson.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("contactperson"))
                        txtFax.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("FAX"))
                        TXT_TINNO.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("TINNO"))
                        txtPanNo.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("PANNO"))
                        txtEmail.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("Email"))
                        CbxCustomerType.Text = Trim(gdataset.Tables("subledger").Rows(0).Item("CATEGORY"))
                        txtCusCode.ReadOnly = True
                        CmdAdd.Enabled = False
                        Me.CmdAdd.Text = "Update [F7]"
                    Else  'End If

                        Me.lbl_Freeze.Visible = False
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.CmdAdd.Text = "Add [F7]"
                        Me.txtCusCode.ReadOnly = False
                        Me.CbxCustomerType.Focus()
                    End If

                End If
                'If gUserCategory <> "S" Then
                '    Call GetRights()
                'End If
            Else
                txtCusCode.Focus()
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            If Not String.IsNullOrEmpty(gAuditFlg) Then
                If gAuditFlg.ToUpper = "Y" Then
                    Me.CmdAdd.Enabled = False
                    Me.cmdFreeze.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Customer Code Validated")
        End Try
    End Sub
End Class