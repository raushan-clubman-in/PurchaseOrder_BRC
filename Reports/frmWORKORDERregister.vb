Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class frmWORKORDERregister
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
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents opt_Purchasedetails As System.Windows.Forms.RadioButton
    Friend WithEvents opt_Purchasesummary As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents chklst_Supplier As System.Windows.Forms.CheckedListBox
    Friend WithEvents dtp_Fromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Todate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Chk_AllGroup As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLst_Group As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Chk_AllItem As System.Windows.Forms.CheckBox
    Friend WithEvents ChkLst_Item As System.Windows.Forms.CheckedListBox
    Friend WithEvents cbo_Storelocation As System.Windows.Forms.ComboBox
    Friend WithEvents CHK_ITEM As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_itemto As System.Windows.Forms.Button
    Friend WithEvents txt_itemto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXT_FROM As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_ITEMFROM As System.Windows.Forms.Button
    Friend WithEvents Lbl_SubledgerCode As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Opt_purchase As System.Windows.Forms.RadioButton
    Friend WithEvents Opt_Return As System.Windows.Forms.RadioButton
    Friend WithEvents OptAll As System.Windows.Forms.RadioButton
    Friend WithEvents CBO_SELECTALL As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_exprot As System.Windows.Forms.Button
    Friend WithEvents opt_Singlesupplier As System.Windows.Forms.RadioButton
    Friend WithEvents grp_orderby As System.Windows.Forms.GroupBox
    Friend WithEvents rdo_name As System.Windows.Forms.RadioButton
    Friend WithEvents rdo_code As System.Windows.Forms.RadioButton
    Friend WithEvents chk_excel As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Mainstore As System.Windows.Forms.Label
    Friend WithEvents txt_Mainstorecode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_storecode As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_Mainstore As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_validation As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWORKORDERregister))
        Me.lbl_Heading = New System.Windows.Forms.Label()
        Me.Cmd_Print = New System.Windows.Forms.Button()
        Me.Cmd_View = New System.Windows.Forms.Button()
        Me.Cmd_Exit = New System.Windows.Forms.Button()
        Me.Cmd_Clear = New System.Windows.Forms.Button()
        Me.btn_validation = New System.Windows.Forms.Button()
        Me.chk_excel = New System.Windows.Forms.CheckBox()
        Me.cmd_exprot = New System.Windows.Forms.Button()
        Me.opt_Purchasedetails = New System.Windows.Forms.RadioButton()
        Me.opt_Purchasesummary = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Chk_SelectAllSupplier = New System.Windows.Forms.CheckBox()
        Me.chklst_Supplier = New System.Windows.Forms.CheckedListBox()
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbl_Wait = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dtp_Fromdate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtp_Todate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Chk_AllGroup = New System.Windows.Forms.CheckBox()
        Me.ChkLst_Group = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chk_AllItem = New System.Windows.Forms.CheckBox()
        Me.ChkLst_Item = New System.Windows.Forms.CheckedListBox()
        Me.cbo_Storelocation = New System.Windows.Forms.ComboBox()
        Me.CHK_ITEM = New System.Windows.Forms.CheckBox()
        Me.cmd_itemto = New System.Windows.Forms.Button()
        Me.txt_itemto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_FROM = New System.Windows.Forms.TextBox()
        Me.Cmd_ITEMFROM = New System.Windows.Forms.Button()
        Me.Lbl_SubledgerCode = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.opt_Singlesupplier = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.OptAll = New System.Windows.Forms.RadioButton()
        Me.Opt_Return = New System.Windows.Forms.RadioButton()
        Me.Opt_purchase = New System.Windows.Forms.RadioButton()
        Me.CBO_SELECTALL = New System.Windows.Forms.CheckBox()
        Me.grp_orderby = New System.Windows.Forms.GroupBox()
        Me.rdo_name = New System.Windows.Forms.RadioButton()
        Me.rdo_code = New System.Windows.Forms.RadioButton()
        Me.lbl_Mainstore = New System.Windows.Forms.Label()
        Me.txt_Mainstorecode = New System.Windows.Forms.TextBox()
        Me.cmd_storecode = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Mainstore = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.frmbut = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.grp_orderby.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.frmbut.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(196, 69)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(200, 18)
        Me.lbl_Heading.TabIndex = 8
        Me.lbl_Heading.Text = "WORK ORDER  REGISTER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Print.Image = Global.SmartCard.My.Resources.Resources.print
        Me.Cmd_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Print.Location = New System.Drawing.Point(6, 177)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Print.TabIndex = 6
        Me.Cmd_Print.Text = " Print [F10]"
        Me.Cmd_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Print.UseVisualStyleBackColor = False
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_View.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.Black
        Me.Cmd_View.Image = Global.SmartCard.My.Resources.Resources.view
        Me.Cmd_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_View.Location = New System.Drawing.Point(5, 81)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_View.TabIndex = 5
        Me.Cmd_View.Text = " View[F9]"
        Me.Cmd_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_View.UseVisualStyleBackColor = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Exit.Image = Global.SmartCard.My.Resources.Resources._Exit
        Me.Cmd_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Exit.Location = New System.Drawing.Point(4, 247)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Exit.TabIndex = 7
        Me.Cmd_Exit.Text = "Exit[F11]"
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Clear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Clear.Image = Global.SmartCard.My.Resources.Resources.Clear
        Me.Cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Clear.Location = New System.Drawing.Point(5, 17)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Clear.TabIndex = 4
        Me.Cmd_Clear.Text = "Clear[F6]"
        Me.Cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Clear.UseVisualStyleBackColor = False
        '
        'btn_validation
        '
        Me.btn_validation.BackColor = System.Drawing.Color.Transparent
        Me.btn_validation.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_validation.ForeColor = System.Drawing.Color.Black
        Me.btn_validation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_validation.Location = New System.Drawing.Point(832, 12)
        Me.btn_validation.Name = "btn_validation"
        Me.btn_validation.Size = New System.Drawing.Size(134, 56)
        Me.btn_validation.TabIndex = 464
        Me.btn_validation.Text = "Validation"
        Me.btn_validation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_validation.UseVisualStyleBackColor = False
        Me.btn_validation.Visible = False
        '
        'chk_excel
        '
        Me.chk_excel.BackColor = System.Drawing.Color.Transparent
        Me.chk_excel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_excel.Location = New System.Drawing.Point(12, 143)
        Me.chk_excel.Name = "chk_excel"
        Me.chk_excel.Size = New System.Drawing.Size(104, 24)
        Me.chk_excel.TabIndex = 463
        Me.chk_excel.Text = "EXCEL"
        Me.chk_excel.UseVisualStyleBackColor = False
        '
        'cmd_exprot
        '
        Me.cmd_exprot.BackColor = System.Drawing.Color.Transparent
        Me.cmd_exprot.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_exprot.ForeColor = System.Drawing.Color.Black
        Me.cmd_exprot.Location = New System.Drawing.Point(392, 680)
        Me.cmd_exprot.Name = "cmd_exprot"
        Me.cmd_exprot.Size = New System.Drawing.Size(104, 32)
        Me.cmd_exprot.TabIndex = 6
        Me.cmd_exprot.Text = "Export"
        Me.cmd_exprot.UseVisualStyleBackColor = False
        Me.cmd_exprot.Visible = False
        '
        'opt_Purchasedetails
        '
        Me.opt_Purchasedetails.BackColor = System.Drawing.Color.Transparent
        Me.opt_Purchasedetails.Checked = True
        Me.opt_Purchasedetails.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_Purchasedetails.Location = New System.Drawing.Point(8, 48)
        Me.opt_Purchasedetails.Name = "opt_Purchasedetails"
        Me.opt_Purchasedetails.Size = New System.Drawing.Size(96, 25)
        Me.opt_Purchasedetails.TabIndex = 2
        Me.opt_Purchasedetails.TabStop = True
        Me.opt_Purchasedetails.Text = "DETAILS"
        Me.opt_Purchasedetails.UseVisualStyleBackColor = False
        Me.opt_Purchasedetails.Visible = False
        '
        'opt_Purchasesummary
        '
        Me.opt_Purchasesummary.BackColor = System.Drawing.Color.Transparent
        Me.opt_Purchasesummary.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_Purchasesummary.Location = New System.Drawing.Point(7, 18)
        Me.opt_Purchasesummary.Name = "opt_Purchasesummary"
        Me.opt_Purchasesummary.Size = New System.Drawing.Size(104, 21)
        Me.opt_Purchasesummary.TabIndex = 3
        Me.opt_Purchasesummary.Text = "SUMMARY"
        Me.opt_Purchasesummary.UseVisualStyleBackColor = False
        Me.opt_Purchasesummary.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(21, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(317, 24)
        Me.Label4.TabIndex = 423
        Me.Label4.Text = "SUPPLIER SELECTION :"
        '
        'Chk_SelectAllSupplier
        '
        Me.Chk_SelectAllSupplier.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllSupplier.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllSupplier.Location = New System.Drawing.Point(25, 6)
        Me.Chk_SelectAllSupplier.Name = "Chk_SelectAllSupplier"
        Me.Chk_SelectAllSupplier.Size = New System.Drawing.Size(136, 24)
        Me.Chk_SelectAllSupplier.TabIndex = 422
        Me.Chk_SelectAllSupplier.Text = "SELECT ALL "
        Me.Chk_SelectAllSupplier.UseVisualStyleBackColor = False
        '
        'chklst_Supplier
        '
        Me.chklst_Supplier.CheckOnClick = True
        Me.chklst_Supplier.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklst_Supplier.Location = New System.Drawing.Point(21, 54)
        Me.chklst_Supplier.Name = "chklst_Supplier"
        Me.chklst_Supplier.Size = New System.Drawing.Size(317, 324)
        Me.chklst_Supplier.TabIndex = 421
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackColor = System.Drawing.Color.Transparent
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(194, 555)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(657, 50)
        Me.grp_SalebillChecklist.TabIndex = 424
        Me.grp_SalebillChecklist.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(643, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'lbl_Wait
        '
        Me.lbl_Wait.AutoSize = True
        Me.lbl_Wait.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wait.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Wait.Location = New System.Drawing.Point(360, 24)
        Me.lbl_Wait.Name = "lbl_Wait"
        Me.lbl_Wait.Size = New System.Drawing.Size(0, 15)
        Me.lbl_Wait.TabIndex = 387
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.PictureBox5)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Controls.Add(Me.dtp_Fromdate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.dtp_Todate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(193, 543)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(642, 49)
        Me.GroupBox3.TabIndex = 425
        Me.GroupBox3.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(382, 11)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.TabIndex = 491
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(142, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 490
        Me.PictureBox2.TabStop = False
        '
        'dtp_Fromdate
        '
        Me.dtp_Fromdate.CustomFormat = "dd-MM-yyyy"
        Me.dtp_Fromdate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Fromdate.Location = New System.Drawing.Point(179, 16)
        Me.dtp_Fromdate.MaxDate = New Date(9998, 8, 14, 0, 0, 0, 0)
        Me.dtp_Fromdate.MinDate = New Date(2000, 8, 14, 0, 0, 0, 0)
        Me.dtp_Fromdate.Name = "dtp_Fromdate"
        Me.dtp_Fromdate.Size = New System.Drawing.Size(104, 21)
        Me.dtp_Fromdate.TabIndex = 0
        Me.dtp_Fromdate.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(317, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "TO DATE :"
        '
        'dtp_Todate
        '
        Me.dtp_Todate.CustomFormat = "dd-MM-yyyy"
        Me.dtp_Todate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Todate.Location = New System.Drawing.Point(421, 17)
        Me.dtp_Todate.MaxDate = New Date(9998, 8, 14, 0, 0, 0, 0)
        Me.dtp_Todate.MinDate = New Date(2000, 8, 14, 0, 0, 0, 0)
        Me.dtp_Todate.Name = "dtp_Todate"
        Me.dtp_Todate.Size = New System.Drawing.Size(104, 21)
        Me.dtp_Todate.TabIndex = 1
        Me.dtp_Todate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(56, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FROM DATE :"
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(315, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 24)
        Me.Label2.TabIndex = 429
        Me.Label2.Text = "GROUP SELECTION :"
        Me.Label2.Visible = False
        '
        'Chk_AllGroup
        '
        Me.Chk_AllGroup.BackColor = System.Drawing.Color.Transparent
        Me.Chk_AllGroup.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_AllGroup.Location = New System.Drawing.Point(263, 7)
        Me.Chk_AllGroup.Name = "Chk_AllGroup"
        Me.Chk_AllGroup.Size = New System.Drawing.Size(10, 24)
        Me.Chk_AllGroup.TabIndex = 428
        Me.Chk_AllGroup.Text = "SELECT ALL "
        Me.Chk_AllGroup.UseVisualStyleBackColor = False
        Me.Chk_AllGroup.Visible = False
        '
        'ChkLst_Group
        '
        Me.ChkLst_Group.CheckOnClick = True
        Me.ChkLst_Group.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkLst_Group.Location = New System.Drawing.Point(332, 55)
        Me.ChkLst_Group.Name = "ChkLst_Group"
        Me.ChkLst_Group.Size = New System.Drawing.Size(17, 324)
        Me.ChkLst_Group.TabIndex = 427
        Me.ChkLst_Group.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Maroon
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(348, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 24)
        Me.Label3.TabIndex = 432
        Me.Label3.Text = "ITEM SELECTION :"
        Me.Label3.Visible = False
        '
        'Chk_AllItem
        '
        Me.Chk_AllItem.BackColor = System.Drawing.Color.Transparent
        Me.Chk_AllItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_AllItem.Location = New System.Drawing.Point(349, 7)
        Me.Chk_AllItem.Name = "Chk_AllItem"
        Me.Chk_AllItem.Size = New System.Drawing.Size(128, 24)
        Me.Chk_AllItem.TabIndex = 431
        Me.Chk_AllItem.Text = "SELECT ALL "
        Me.Chk_AllItem.UseVisualStyleBackColor = False
        Me.Chk_AllItem.Visible = False
        '
        'ChkLst_Item
        '
        Me.ChkLst_Item.CheckOnClick = True
        Me.ChkLst_Item.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkLst_Item.Location = New System.Drawing.Point(348, 51)
        Me.ChkLst_Item.Name = "ChkLst_Item"
        Me.ChkLst_Item.Size = New System.Drawing.Size(215, 324)
        Me.ChkLst_Item.TabIndex = 430
        Me.ChkLst_Item.Visible = False
        '
        'cbo_Storelocation
        '
        Me.cbo_Storelocation.BackColor = System.Drawing.Color.Wheat
        Me.cbo_Storelocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Storelocation.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.cbo_Storelocation.ItemHeight = 15
        Me.cbo_Storelocation.Location = New System.Drawing.Point(832, 672)
        Me.cbo_Storelocation.Name = "cbo_Storelocation"
        Me.cbo_Storelocation.Size = New System.Drawing.Size(158, 23)
        Me.cbo_Storelocation.TabIndex = 441
        Me.cbo_Storelocation.Visible = False
        '
        'CHK_ITEM
        '
        Me.CHK_ITEM.BackColor = System.Drawing.Color.Transparent
        Me.CHK_ITEM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_ITEM.Location = New System.Drawing.Point(6, 102)
        Me.CHK_ITEM.Name = "CHK_ITEM"
        Me.CHK_ITEM.Size = New System.Drawing.Size(104, 24)
        Me.CHK_ITEM.TabIndex = 443
        Me.CHK_ITEM.Text = "ITEM WISE"
        Me.CHK_ITEM.UseVisualStyleBackColor = False
        Me.CHK_ITEM.Visible = False
        '
        'cmd_itemto
        '
        Me.cmd_itemto.Image = CType(resources.GetObject("cmd_itemto.Image"), System.Drawing.Image)
        Me.cmd_itemto.Location = New System.Drawing.Point(299, 16)
        Me.cmd_itemto.Name = "cmd_itemto"
        Me.cmd_itemto.Size = New System.Drawing.Size(23, 26)
        Me.cmd_itemto.TabIndex = 481
        Me.cmd_itemto.Visible = False
        '
        'txt_itemto
        '
        Me.txt_itemto.BackColor = System.Drawing.Color.Wheat
        Me.txt_itemto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_itemto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_itemto.Location = New System.Drawing.Point(218, 19)
        Me.txt_itemto.MaxLength = 20
        Me.txt_itemto.Name = "txt_itemto"
        Me.txt_itemto.Size = New System.Drawing.Size(80, 21)
        Me.txt_itemto.TabIndex = 480
        Me.txt_itemto.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(190, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 15)
        Me.Label8.TabIndex = 479
        Me.Label8.Text = "TO:"
        Me.Label8.Visible = False
        '
        'TXT_FROM
        '
        Me.TXT_FROM.BackColor = System.Drawing.Color.Wheat
        Me.TXT_FROM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_FROM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_FROM.Location = New System.Drawing.Point(81, 19)
        Me.TXT_FROM.MaxLength = 20
        Me.TXT_FROM.Name = "TXT_FROM"
        Me.TXT_FROM.Size = New System.Drawing.Size(84, 21)
        Me.TXT_FROM.TabIndex = 477
        Me.TXT_FROM.Visible = False
        '
        'Cmd_ITEMFROM
        '
        Me.Cmd_ITEMFROM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ITEMFROM.Image = CType(resources.GetObject("Cmd_ITEMFROM.Image"), System.Drawing.Image)
        Me.Cmd_ITEMFROM.Location = New System.Drawing.Point(166, 16)
        Me.Cmd_ITEMFROM.Name = "Cmd_ITEMFROM"
        Me.Cmd_ITEMFROM.Size = New System.Drawing.Size(23, 26)
        Me.Cmd_ITEMFROM.TabIndex = 478
        Me.Cmd_ITEMFROM.Visible = False
        '
        'Lbl_SubledgerCode
        '
        Me.Lbl_SubledgerCode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_SubledgerCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_SubledgerCode.Location = New System.Drawing.Point(0, 22)
        Me.Lbl_SubledgerCode.Name = "Lbl_SubledgerCode"
        Me.Lbl_SubledgerCode.Size = New System.Drawing.Size(75, 16)
        Me.Lbl_SubledgerCode.TabIndex = 476
        Me.Lbl_SubledgerCode.Text = "ITEM  FROM:"
        Me.Lbl_SubledgerCode.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(270, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.TabIndex = 487
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(274, 30)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox3.TabIndex = 488
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Maroon
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(491, 30)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox4.TabIndex = 489
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Maroon
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(538, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 24)
        Me.Label9.TabIndex = 490
        Me.Label9.Text = "F3"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Maroon
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(315, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 24)
        Me.Label10.TabIndex = 491
        Me.Label10.Text = "F2"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Maroon
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(302, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 24)
        Me.Label11.TabIndex = 492
        Me.Label11.Text = "F4"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Lbl_SubledgerCode)
        Me.GroupBox1.Controls.Add(Me.TXT_FROM)
        Me.GroupBox1.Controls.Add(Me.Cmd_ITEMFROM)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_itemto)
        Me.GroupBox1.Controls.Add(Me.cmd_itemto)
        Me.GroupBox1.Location = New System.Drawing.Point(520, 534)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 56)
        Me.GroupBox1.TabIndex = 493
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.opt_Purchasedetails)
        Me.GroupBox4.Controls.Add(Me.opt_Purchasesummary)
        Me.GroupBox4.Controls.Add(Me.CHK_ITEM)
        Me.GroupBox4.Controls.Add(Me.opt_Singlesupplier)
        Me.GroupBox4.Location = New System.Drawing.Point(858, 445)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(152, 143)
        Me.GroupBox4.TabIndex = 495
        Me.GroupBox4.TabStop = False
        '
        'opt_Singlesupplier
        '
        Me.opt_Singlesupplier.BackColor = System.Drawing.Color.Transparent
        Me.opt_Singlesupplier.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opt_Singlesupplier.Location = New System.Drawing.Point(7, 80)
        Me.opt_Singlesupplier.Name = "opt_Singlesupplier"
        Me.opt_Singlesupplier.Size = New System.Drawing.Size(144, 24)
        Me.opt_Singlesupplier.TabIndex = 500
        Me.opt_Singlesupplier.Text = "SINGLE SUPPLIER"
        Me.opt_Singlesupplier.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.OptAll)
        Me.GroupBox5.Controls.Add(Me.Opt_Return)
        Me.GroupBox5.Controls.Add(Me.Opt_purchase)
        Me.GroupBox5.Location = New System.Drawing.Point(230, 498)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(555, 49)
        Me.GroupBox5.TabIndex = 498
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Visible = False
        '
        'OptAll
        '
        Me.OptAll.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptAll.Location = New System.Drawing.Point(377, 18)
        Me.OptAll.Name = "OptAll"
        Me.OptAll.Size = New System.Drawing.Size(158, 24)
        Me.OptAll.TabIndex = 2
        Me.OptAll.Text = "All"
        '
        'Opt_Return
        '
        Me.Opt_Return.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_Return.Location = New System.Drawing.Point(176, 19)
        Me.Opt_Return.Name = "Opt_Return"
        Me.Opt_Return.Size = New System.Drawing.Size(165, 24)
        Me.Opt_Return.TabIndex = 1
        Me.Opt_Return.Text = "Hire Order Return"
        '
        'Opt_purchase
        '
        Me.Opt_purchase.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opt_purchase.Location = New System.Drawing.Point(16, 15)
        Me.Opt_purchase.Name = "Opt_purchase"
        Me.Opt_purchase.Size = New System.Drawing.Size(154, 32)
        Me.Opt_purchase.TabIndex = 0
        Me.Opt_purchase.Text = "Hire Order"
        '
        'CBO_SELECTALL
        '
        Me.CBO_SELECTALL.BackColor = System.Drawing.Color.Transparent
        Me.CBO_SELECTALL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_SELECTALL.Location = New System.Drawing.Point(-2, 456)
        Me.CBO_SELECTALL.Name = "CBO_SELECTALL"
        Me.CBO_SELECTALL.Size = New System.Drawing.Size(128, 16)
        Me.CBO_SELECTALL.TabIndex = 499
        Me.CBO_SELECTALL.Text = "FOR SELECT ALL"
        Me.CBO_SELECTALL.UseVisualStyleBackColor = False
        Me.CBO_SELECTALL.Visible = False
        '
        'grp_orderby
        '
        Me.grp_orderby.BackColor = System.Drawing.Color.Transparent
        Me.grp_orderby.Controls.Add(Me.rdo_name)
        Me.grp_orderby.Controls.Add(Me.rdo_code)
        Me.grp_orderby.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_orderby.Location = New System.Drawing.Point(880, 430)
        Me.grp_orderby.Name = "grp_orderby"
        Me.grp_orderby.Size = New System.Drawing.Size(112, 65)
        Me.grp_orderby.TabIndex = 500
        Me.grp_orderby.TabStop = False
        Me.grp_orderby.Text = "Order By"
        Me.grp_orderby.Visible = False
        '
        'rdo_name
        '
        Me.rdo_name.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_name.Location = New System.Drawing.Point(16, 40)
        Me.rdo_name.Name = "rdo_name"
        Me.rdo_name.Size = New System.Drawing.Size(96, 19)
        Me.rdo_name.TabIndex = 1
        Me.rdo_name.Text = " Name"
        '
        'rdo_code
        '
        Me.rdo_code.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdo_code.Location = New System.Drawing.Point(16, 16)
        Me.rdo_code.Name = "rdo_code"
        Me.rdo_code.Size = New System.Drawing.Size(88, 18)
        Me.rdo_code.TabIndex = 0
        Me.rdo_code.Text = "Item Code"
        '
        'lbl_Mainstore
        '
        Me.lbl_Mainstore.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Mainstore.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mainstore.Location = New System.Drawing.Point(4, 20)
        Me.lbl_Mainstore.Name = "lbl_Mainstore"
        Me.lbl_Mainstore.Size = New System.Drawing.Size(50, 16)
        Me.lbl_Mainstore.TabIndex = 482
        Me.lbl_Mainstore.Text = "STORE :"
        '
        'txt_Mainstorecode
        '
        Me.txt_Mainstorecode.BackColor = System.Drawing.Color.Wheat
        Me.txt_Mainstorecode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Mainstorecode.Location = New System.Drawing.Point(60, 16)
        Me.txt_Mainstorecode.Name = "txt_Mainstorecode"
        Me.txt_Mainstorecode.Size = New System.Drawing.Size(64, 21)
        Me.txt_Mainstorecode.TabIndex = 484
        '
        'cmd_storecode
        '
        Me.cmd_storecode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_storecode.Image = CType(resources.GetObject("cmd_storecode.Image"), System.Drawing.Image)
        Me.cmd_storecode.Location = New System.Drawing.Point(125, 13)
        Me.cmd_storecode.Name = "cmd_storecode"
        Me.cmd_storecode.Size = New System.Drawing.Size(24, 26)
        Me.cmd_storecode.TabIndex = 485
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(150, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 24)
        Me.Label5.TabIndex = 486
        Me.Label5.Text = "F4"
        Me.Label5.Visible = False
        '
        'txt_Mainstore
        '
        Me.txt_Mainstore.BackColor = System.Drawing.Color.Wheat
        Me.txt_Mainstore.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Mainstore.Enabled = False
        Me.txt_Mainstore.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Mainstore.Location = New System.Drawing.Point(185, 18)
        Me.txt_Mainstore.MaxLength = 15
        Me.txt_Mainstore.Name = "txt_Mainstore"
        Me.txt_Mainstore.ReadOnly = True
        Me.txt_Mainstore.Size = New System.Drawing.Size(148, 21)
        Me.txt_Mainstore.TabIndex = 483
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lbl_Mainstore)
        Me.GroupBox2.Controls.Add(Me.txt_Mainstorecode)
        Me.GroupBox2.Controls.Add(Me.cmd_storecode)
        Me.GroupBox2.Controls.Add(Me.txt_Mainstore)
        Me.GroupBox2.Location = New System.Drawing.Point(307, 539)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 53)
        Me.GroupBox2.TabIndex = 494
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.Cmd_Clear)
        Me.frmbut.Controls.Add(Me.Cmd_Print)
        Me.frmbut.Controls.Add(Me.Cmd_Exit)
        Me.frmbut.Controls.Add(Me.Cmd_View)
        Me.frmbut.Controls.Add(Me.chk_excel)
        Me.frmbut.Location = New System.Drawing.Point(861, 106)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(142, 315)
        Me.frmbut.TabIndex = 13
        Me.frmbut.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.PictureBox4)
        Me.GroupBox6.Controls.Add(Me.PictureBox3)
        Me.GroupBox6.Controls.Add(Me.PictureBox1)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Chk_AllItem)
        Me.GroupBox6.Controls.Add(Me.ChkLst_Item)
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.Chk_AllGroup)
        Me.GroupBox6.Controls.Add(Me.ChkLst_Group)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Chk_SelectAllSupplier)
        Me.GroupBox6.Controls.Add(Me.chklst_Supplier)
        Me.GroupBox6.Location = New System.Drawing.Point(282, 117)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(576, 381)
        Me.GroupBox6.TabIndex = 501
        Me.GroupBox6.TabStop = False
        '
        'frmWORKORDERregister
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.BackgroundImage = Global.SmartCard.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1014, 692)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.btn_validation)
        Me.Controls.Add(Me.grp_orderby)
        Me.Controls.Add(Me.CBO_SELECTALL)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbo_Storelocation)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.frmbut)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmd_exprot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "frmWORKORDERregister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORT [ PURCHASE REGISTER ]"
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.grp_SalebillChecklist.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.grp_orderby.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.frmbut.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Dim sqlstring As String

    Private Sub frmWORKORDERregister_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F9 And Cmd_View.Enabled = True Then
            Call Cmd_View_Click(Cmd_View, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F10 And Cmd_Print.Enabled = True Then
            Call Cmd_Print_Click(Cmd_Print, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(Cmd_Clear, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Then
            Call Cmd_Exit_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(sender, e)
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.F Then
            Me.dtp_Fromdate.Focus()
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.T Then
            Me.dtp_Todate.Focus()
            Exit Sub
        ElseIf e.KeyCode = Keys.F4 Then
            Dim search As New frmListSearch
            search.listbox = chklst_Supplier
            search.Text = "Supplier Search"
            search.ShowDialog(Me)
        ElseIf e.KeyCode = Keys.F1 Then
            Dim search As New frmListSearch
            search.listbox = ChkLst_Item
            search.Text = "Items Search"
            search.ShowDialog(Me)
        ElseIf e.KeyCode = Keys.F2 Then
            Dim search As New frmListSearch
            search.listbox = ChkLst_Group
            search.Text = "Group Search"
            search.ShowDialog(Me)
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Checkdaterangevalidate(Format(dtp_Fromdate.Value, "dd/MMM/yyyy"), Format(dtp_Todate.Value, "dd/MMM/yyyy"))
        If chkdatevalidate = False Then Exit Sub
        gPrint = False
        grp_SalebillChecklist.Top = 611
        grp_SalebillChecklist.Left = 194
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 10
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        Checkdaterangevalidate(dtp_Fromdate.Value, dtp_Todate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = True
        grp_SalebillChecklist.Top = 611
        grp_SalebillChecklist.Left = 194
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 10
        Me.Timer1.Enabled = True
    End Sub
    Private Sub Viewsuppliernamewise()
        Try
            Dim sqlstring, SUPPLIERNAME(), ITEMNAME() As String
            Dim i As Integer
            Dim r As New Rpt_WorkrderRegister
            ' Dim r9 As New Rpt_WorkorderRegister_Supplier
            Dim R9 As New Cry_kga_wor
            Dim rViewer As New Viewer

            Me.Cursor = Cursors.WaitCursor
            If opt_Purchasesummary.Checked = True Then
                sqlstring = " select distinct  * FROM  VIEWWORKORDERREGISTERUMMARY "
                'If ChkLst_Item.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                '    sqlstring = sqlstring & " where  ITEMCODE BETWEEN '"
                '    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
                'Else
                If chklst_Supplier.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
                    For i = 0 To chklst_Supplier.CheckedItems.Count - 1
                        SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                'If ChkLst_Item.CheckedItems.Count <> 0 Then
                '    sqlstring = sqlstring & " AND ITEMCODE IN ("
                '    For i = 0 To ChkLst_Item.CheckedItems.Count - 1
                '        ITEMNAME = Split(ChkLst_Item.CheckedItems(i), "-->")
                '        sqlstring = sqlstring & " '" & Trim(ITEMNAME(0)) & "', "
                '    Next
                '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                '    sqlstring = sqlstring & ")"
                'Else
                '    MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Exit Sub
                'End If
                '  End If
                ' sqlstring = sqlstring & " AND STOREDESC = '" & Trim(txt_Mainstore.Text) & "' AND ISNULL(GRNTYPE,'') = 'HRN' "
                '   sqlstring = sqlstring & " and ISNULL(GRNTYPE,'') = 'HRN' "
                sqlstring = sqlstring & " AND WObDATE BETWEEN"
                sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
                'If rdo_code.Checked = True Then
                '    sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME  "
                'ElseIf rdo_name.Checked = True Then
                '    sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME  "
                'Else
                'm sqlstring = sqlstring & " ORDER BY WODATE,WODETAILS,SUPPLIERNAME  "
                ' End If
                ' If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Purchase Register") = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                gconnection.getDataSet(sqlstring, "VIEWWORKORDERREGISTERUMMARY")
                If gdataset.Tables("VIEWWORKORDERREGISTERUMMARY").Rows.Count > 0 Then
                    If chk_excel.Checked = True Then
                        Dim exp As New exportexcel
                        exp.Show()
                        Call exp.export(sqlstring, "WORK ORDER REGISTER  " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "TO" & Format(dtp_Todate.Value, "dd-MMM-yyyy"), "")
                    Else
                        rViewer.ssql = sqlstring
                        rViewer.Report = r
                        rViewer.TableName = "WORK ORDER REGISTER"

                        Dim textobj1 As TextObject
                        textobj1 = r.ReportDefinition.ReportObjects("Text3")
                        textobj1.Text = MyCompanyName

                        Dim textobj2 As TextObject
                        textobj2 = r.ReportDefinition.ReportObjects("Text13")
                        textobj2.Text = Trim(txt_Mainstore.Text)

                        Dim TXTOBJ3 As TextObject
                        TXTOBJ3 = r.ReportDefinition.ReportObjects("Text17")
                        TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

                        Dim textobj4 As TextObject
                        textobj4 = r.ReportDefinition.ReportObjects("Text21")
                        textobj4.Text = gUsername

                        Dim textobj7 As TextObject
                        textobj7 = r.ReportDefinition.ReportObjects("Text5")
                        textobj7.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode
                        Dim textobj5 As TextObject
                        textobj5 = r.ReportDefinition.ReportObjects("Text7")
                        textobj5.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:pur@kga.in" & ", Web:" & gWebsite
                        Dim TEXTOBJ6 As TextObject
                        TEXTOBJ6 = r.ReportDefinition.ReportObjects("Text23")
                        TEXTOBJ6.Text = "Service Tax:" & gServiceTax & " , Tin No.:" & gTinNo
                        rViewer.Show()
                    End If
                    Me.Cursor = Cursors.Default

                Else
                    MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
                End If
                ' Else
                '    Me.Cursor = Cursors.WaitCursor
                '    Dim heading() As String = {"PURCHASE REGISTER "}
                '    Dim ObjStockPurchaseregistersummary As New rptPurchaseregistersummary
                '    ObjStockPurchaseregistersummary.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
                '    Me.Cursor = Cursors.Default
                ' End If

            ElseIf opt_Singlesupplier.Checked = True Then
                'sqlstring = " select *   from VIEWWORKORDERREGISTERUMMARY "
                ''If ChkLst_Item.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                ''    sqlstring = sqlstring & " where  ITEMCODE BETWEEN '"
                ''    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
                ''Else
                'If chklst_Supplier.CheckedItems.Count <> 0 Then
                '    sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
                '    For i = 0 To chklst_Supplier.CheckedItems.Count - 1
                '        SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
                '        sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
                '    Next
                '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                '    sqlstring = sqlstring & ")"
                'Else
                '    MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '    Exit Sub
                'End If
                ''If ChkLst_Item.CheckedItems.Count <> 0 Then
                ''    sqlstring = sqlstring & " AND ITEMCODE IN ("
                ''    For i = 0 To ChkLst_Item.CheckedItems.Count - 1
                ''        ITEMNAME = Split(ChkLst_Item.CheckedItems(i), "-->")
                ''        sqlstring = sqlstring & " '" & Trim(ITEMNAME(0)) & "', "
                ''    Next
                ''    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                ''    sqlstring = sqlstring & ")"
                ''Else
                ''    MessageBox.Show("Select the Item code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                ''    Exit Sub
                ''End If
                '' End If
                '' sqlstring = sqlstring & " AND STOREDESC = '" & Trim(txt_Mainstore.Text) & "'  AND ISNULL(GRNTYPE,'') = 'HRN'  "
                ''  sqlstring = sqlstring & " AND ISNULL(GRNTYPE,'') = 'HRN'"
                'sqlstring = sqlstring & " AND WObDATE BETWEEN"
                'sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
                '' sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME  "
                ''m sqlstring = sqlstring & " ORDER BY WODATE,WODETAILS,SUPPLIERNAME  "

                ''If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Purchase Register") = MsgBoxResult.Yes Then
                'Me.Cursor = Cursors.WaitCursor
                'gconnection.getDataSet(sqlstring, "VIEWWORKORDERREGISTERUMMARY")
                'If gdataset.Tables("VIEWWORKORDERREGISTERUMMARY").Rows.Count > 0 Then
                '    If chk_excel.Checked = True Then
                '        Dim exp As New exportexcel
                '        exp.Show()
                '        Call exp.export(sqlstring, "WORK ORDER REGISTER  " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "TO" & Format(dtp_Todate.Value, "dd-MMM-yyyy"), "")
                '    Else
                '        rViewer.ssql = sqlstring
                '        rViewer.Report = r9
                '        rViewer.TableName = "WORK ORDER REGISTER"

                '        Dim textobj1 As TextObject
                '        textobj1 = r9.ReportDefinition.ReportObjects("Text3")
                '        textobj1.Text = MyCompanyName

                '        Dim textobj2 As TextObject
                '        textobj2 = r9.ReportDefinition.ReportObjects("Text13")
                '        textobj2.Text = Trim(txt_Mainstore.Text)

                '        Dim TXTOBJ3 As TextObject
                '        TXTOBJ3 = r9.ReportDefinition.ReportObjects("Text17")
                '        TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

                '        Dim textobj4 As TextObject
                '        textobj4 = r9.ReportDefinition.ReportObjects("Text21")
                '        textobj4.Text = gUsername

                '        Dim textobj7 As TextObject
                '        textobj7 = r9.ReportDefinition.ReportObjects("Text22")
                '        textobj7.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode
                '        Dim textobj5 As TextObject
                '        textobj5 = r9.ReportDefinition.ReportObjects("Text23")
                '        textobj5.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:pur@kga.in" & ", Web:" & gWebsite
                '        Dim TEXTOBJ6 As TextObject
                '        TEXTOBJ6 = r9.ReportDefinition.ReportObjects("Text25")
                '        TEXTOBJ6.Text = "Service Tax:" & gServiceTax & " , Tin No.:" & gTinNo
                '        rViewer.Show()
                '    End If
                '    Me.Cursor = Cursors.Default

                'Else
                '    MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
                'End If
                sqlstring = " select *   from view_wo_det "
                If chklst_Supplier.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
                    For i = 0 To chklst_Supplier.CheckedItems.Count - 1
                        SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            
                sqlstring = sqlstring & " AND WObDATE BETWEEN"
                sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "' AND WORKDESC<>'' ORDER BY WODETAILS, WOBDATE"
               
                Me.Cursor = Cursors.WaitCursor
                gconnection.getDataSet(sqlstring, "VIEWWORKORDERREGISTERUMMARY")
                If gdataset.Tables("VIEWWORKORDERREGISTERUMMARY").Rows.Count > 0 Then
                    If chk_excel.Checked = True Then
                        Dim exp As New exportexcel
                        exp.Show()
                        Call exp.export(sqlstring, "WORK ORDER REGISTER  " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "TO" & Format(dtp_Todate.Value, "dd-MMM-yyyy"), "")
                    Else
                        rViewer.ssql = sqlstring
                        rViewer.Report = r9
                        rViewer.TableName = "WORK ORDER REGISTER"

                        Dim textobj1 As TextObject
                        textobj1 = r9.ReportDefinition.ReportObjects("Text11")
                        textobj1.Text = MyCompanyName

                        'Dim textobj2 As TextObject
                        'textobj2 = r9.ReportDefinition.ReportObjects("Text13")
                        'textobj2.Text = Trim(txt_Mainstore.Text)

                        Dim TXTOBJ3 As TextObject
                        TXTOBJ3 = r9.ReportDefinition.ReportObjects("Text15")
                        TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

                        Dim textobj4 As TextObject
                        textobj4 = r9.ReportDefinition.ReportObjects("Text17")
                        textobj4.Text = gUsername

                        Dim textobj7 As TextObject
                        textobj7 = r9.ReportDefinition.ReportObjects("Text12")
                        textobj7.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode
                        Dim textobj5 As TextObject
                        textobj5 = r9.ReportDefinition.ReportObjects("Text13")
                        textobj5.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:pur@kga.in" & ", Web:" & gWebsite
                        Dim TEXTOBJ6 As TextObject
                        TEXTOBJ6 = r9.ReportDefinition.ReportObjects("Text14")
                        TEXTOBJ6.Text = "Service Tax:" & gServiceTax & " , Tin No.:" & gTinNo
                        rViewer.Show()
                    End If
                    Me.Cursor = Cursors.Default

                Else
                    MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
                End If

            ElseIf opt_Purchasedetails.Checked = True Then
                Me.Cursor = Cursors.WaitCursor
                opt_Purchasedetails.Checked = True

                sqlstring = " SELECT * FROM VIEWWORKORDERREGISTERUMMARY "

                'If ChkLst_Item.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
                '    sqlstring = sqlstring & " where ITEMCODE BETWEEN '"
                '    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
                'Else
                If chklst_Supplier.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
                    For i = 0 To chklst_Supplier.CheckedItems.Count - 1
                        SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                '    If ChkLst_Item.CheckedItems.Count <> 0 Then
                '        sqlstring = sqlstring & " AND ITEMCODE IN ("
                '        For i = 0 To ChkLst_Item.CheckedItems.Count - 1
                '            ITEMNAME = Split(ChkLst_Item.CheckedItems(i), "-->")
                '            sqlstring = sqlstring & " '" & Trim(ITEMNAME(0)) & "', "
                '        Next
                '        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                '        sqlstring = sqlstring & ")"
                '    Else
                '        MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '        Exit Sub
                '    End If
                'End If
                ' sqlstring = sqlstring & " AND STOREDESC = '" & Trim(txt_Mainstore.Text) & "' AND ISNULL(GRNTYPE,'') = 'HRN'  "
                ' sqlstring = sqlstring & " AND ISNULL(GRNTYPE,'') = 'HRN'"
                sqlstring = sqlstring & " AND WObDATE BETWEEN"
                sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"

                'If rdo_code.Checked = True Then
                '    sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMCODE  "
                'ElseIf rdo_name.Checked = True Then
                '    sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMNAME  "
                'Else
                'm sqlstring = sqlstring & " ORDER BY WODATE,WODETAILS,SUPPLIERNAME  "
                ' End If
                Dim s As New Rpt_WorkorderRegister_Det

                'If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Purchase Register") = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                gconnection.getDataSet(sqlstring, "VIEWWORKORDERREGISTERUMMARY")

                If gdataset.Tables("VIEWWORKORDERREGISTERUMMARY").Rows.Count > 0 Then
                    If chk_excel.Checked = True Then
                        Dim exp As New exportexcel
                        exp.Show()
                        Call exp.export(sqlstring, "WORK ORDER REGISTER  " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "TO" & Format(dtp_Todate.Value, "dd-MMM-yyyy"), "")
                    Else
                        rViewer.ssql = sqlstring
                        rViewer.Report = s
                        rViewer.TableName = "WORK ORDER REGISTER"

                        Dim textobj1 As TextObject
                        textobj1 = s.ReportDefinition.ReportObjects("Text3")
                        textobj1.Text = MyCompanyName

                        Dim textobj2 As TextObject
                        textobj2 = s.ReportDefinition.ReportObjects("Text16")
                        textobj2.Text = Trim(txt_Mainstore.Text)

                        Dim TXTOBJ3 As TextObject
                        TXTOBJ3 = s.ReportDefinition.ReportObjects("Text17")
                        TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

                        Dim textobj4 As TextObject
                        textobj4 = s.ReportDefinition.ReportObjects("Text22")
                        textobj4.Text = gUsername

                        Dim textobj7 As TextObject
                        textobj7 = s.ReportDefinition.ReportObjects("Text11")
                        textobj7.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode
                        Dim textobj5 As TextObject
                        textobj5 = s.ReportDefinition.ReportObjects("Text14")
                        textobj5.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:pur@kga.in" & ", Web:" & gWebsite
                        Dim TEXTOBJ6 As TextObject
                        TEXTOBJ6 = s.ReportDefinition.ReportObjects("Text15")
                        TEXTOBJ6.Text = "Service Tax:" & gServiceTax & " , Tin No.:" & gTinNo
                        rViewer.Show()
                    End If
                    Me.Cursor = Cursors.Default
                Else
                    MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
                End If
                'Else
                'Me.Cursor = Cursors.WaitCursor
                ' Dim heading() As String = {"PURCHASE REGISTER "}
                ' Dim ObjStockPurchaseregisterReport As New rptStockPurchaseregister
                ' ObjStockPurchaseregisterReport.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
                ' Me.Cursor = Cursors.Default
                'End If
            End If

            'If CHK_ITEM.Checked = True Then

            '    Dim v As New Rpt_PurRegister_Item
            '    Dim vViewer As New Viewer
            '    sqlstring = " SELECT ITEMCODE,ITEMNAME,SUM(qty) AS QTY,(SUM(AMOUNT)/SUM(qty)) AS RATE,SUM(AMOUNT) AS AMOUNT,SUM(TAXAMOUNT) AS TAXAMOUNT, "
            '    sqlstring = sqlstring & " SUM(DISCOUNT) AS DISCOUNT , SUM(OTHCHARGE) AS OTHCHARGE FROM VIEWHIREREGISTERSUMMARY "


            '    'If ChkLst_Item.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
            '    '    sqlstring = sqlstring & " where ITEMNAME BETWEEN '"
            '    '    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
            '    'Else

            '    If chklst_Supplier.CheckedItems.Count <> 0 Then
            '        sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
            '        For i = 0 To chklst_Supplier.CheckedItems.Count - 1
            '            SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
            '            sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
            '        Next
            '        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            '        sqlstring = sqlstring & ")"
            '    Else
            '        MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '        Exit Sub
            '    End If
            '    '    If ChkLst_Item.CheckedItems.Count <> 0 Then
            '    '        sqlstring = sqlstring & " AND ITEMCODE IN ("
            '    '        For i = 0 To ChkLst_Item.CheckedItems.Count - 1
            '    '            ITEMNAME = Split(ChkLst_Item.CheckedItems(i), "-->")
            '    '            sqlstring = sqlstring & " '" & Trim(ITEMNAME(0)) & "', "
            '    '        Next
            '    '        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            '    '        sqlstring = sqlstring & ")"
            '    '    Else
            '    '        MessageBox.Show("Select the Items Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    '        Exit Sub
            '    '    End If
            '    'End If
            '    '    sqlstring = sqlstring & " AND STOREDESC = '" & Trim(txt_Mainstore.Text) & "' AND ISNULL(GRNTYPE,'') = 'HRN' "
            '    sqlstring = sqlstring & " AND ISNULL(GRNTYPE,'') = 'HRN' "
            'sqlstring = sqlstring & " AND GRNDATE BETWEEN"
            'sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
            'sqlstring = sqlstring & " GROUP BY ITEMCODE,ITEMNAME  "
            'If rdo_code.Checked = True Then
            '    sqlstring = sqlstring & " ORDER BY ITEMCODE, ITEMNAME "
            'ElseIf rdo_name.Checked = True Then
            '    sqlstring = sqlstring & " ORDER BY ITEMNAME, ITEMCODE "
            'Else
            '    sqlstring = sqlstring & " ORDER BY ITEMCODE, ITEMNAME "
            'End If
            'Me.Cursor = Cursors.Default
            '' If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Purchase Register") = MsgBoxResult.Yes Then
            'Me.Cursor = Cursors.WaitCursor
            'gconnection.getDataSet(sqlstring, "VIEWHIREREGISTERSUMMARY")
            'If gdataset.Tables("VIEWHIREREGISTERSUMMARY").Rows.Count > 0 Then
            '    If chk_excel.Checked = True Then
            '        Dim exp As New exportexcel
            '        exp.Show()
            '        Call exp.export(sqlstring, "PHIRE ORDER REGISTER  " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "TO" & Format(dtp_Todate.Value, "dd-MMM-yyyy"), "")
            '    Else
            '        vViewer.ssql = sqlstring
            '        vViewer.Report = v
            '        vViewer.TableName = "HIRE ORDER REGISTER"

            '        Dim textobj1 As TextObject
            '        textobj1 = v.ReportDefinition.ReportObjects("Text3")
            '        textobj1.Text = MyCompanyName

            '        Dim textobj2 As TextObject
            '        textobj2 = r.ReportDefinition.ReportObjects("Text13")
            '        textobj2.Text = Trim(txt_Mainstore.Text)

            '        Dim TXTOBJ3 As TextObject
            '        TXTOBJ3 = v.ReportDefinition.ReportObjects("Text17")
            '        TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

            '        Dim textobj4 As TextObject
            '        textobj4 = r.ReportDefinition.ReportObjects("Text14")
            '        textobj4.Text = gUsername

            '        vViewer.Show()
            '    End If
            '    Me.Cursor = Cursors.Default
            'Else
            '    MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
            'End If
            ''End If
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    'Private Sub ViewReturnRegister()
    '    Try
    '        Dim sqlstring, SUPPLIERNAME(), ITEMNAME() As String
    '        Dim i As Integer
    '        Dim r As New Rpt_PurchaseRegister
    '        Dim r9 As New Rpt_PurchaseRegister_Supplier
    '        Dim rViewer As New Viewer

    '        Me.Cursor = Cursors.WaitCursor
    '        If opt_Purchasesummary.Checked = True Then
    '            sqlstring = " select distinct  grndetails , grndate,pono ,Supplierinvno, suppliercode , suppliername ,HIREREASON,FROMDATE,TODATE, totalamount , vatamount , surchargeamt , discountamount , billamount,OVERALLDISCOUNT  from VIEWHIREREGISTERSUMMARY "
    '            'If ChkLst_Item.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
    '            '    sqlstring = sqlstring & " where  ITEMCODE BETWEEN '"
    '            '    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
    '            'Else
    '            If chklst_Supplier.CheckedItems.Count <> 0 Then
    '                sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
    '                For i = 0 To chklst_Supplier.CheckedItems.Count - 1
    '                    SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
    '                    sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
    '                Next
    '                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    '                sqlstring = sqlstring & ")"
    '            Else
    '                MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Exit Sub
    '            End If
    '            'If ChkLst_Item.CheckedItems.Count <> 0 Then
    '            '    sqlstring = sqlstring & " AND ITEMCODE IN ("
    '            '    For i = 0 To ChkLst_Item.CheckedItems.Count - 1
    '            '        ITEMNAME = Split(ChkLst_Item.CheckedItems(i), "-->")
    '            '        sqlstring = sqlstring & " '" & Trim(ITEMNAME(0)) & "', "
    '            '    Next
    '            '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    '            '    sqlstring = sqlstring & ")"
    '            'Else
    '            '    MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            '    Exit Sub
    '            'End If
    '            '  End If
    '            ' sqlstring = sqlstring & " AND STOREDESC = '" & Trim(txt_Mainstore.Text) & "' AND ISNULL(GRNTYPE,'') = 'HRN' "
    '            sqlstring = sqlstring & " and ISNULL(GRNTYPE,'') = 'HRT' "
    '            sqlstring = sqlstring & " AND GRNDATE BETWEEN"
    '            sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
    '            If rdo_code.Checked = True Then
    '                sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME  "
    '            ElseIf rdo_name.Checked = True Then
    '                sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME  "
    '            Else
    '                sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME  "
    '            End If
    '            ' If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Purchase Register") = MsgBoxResult.Yes Then
    '            Me.Cursor = Cursors.WaitCursor
    '            gconnection.getDataSet(sqlstring, "VIEWHIREREGISTERSUMMARY")
    '            If gdataset.Tables("VIEWHIREREGISTERSUMMARY").Rows.Count > 0 Then
    '                If chk_excel.Checked = True Then
    '                    Dim exp As New exportexcel
    '                    exp.Show()
    '                    Call exp.export(sqlstring, "HIRE ORDER REGISTER  " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "TO" & Format(dtp_Todate.Value, "dd-MMM-yyyy"), "")
    '                Else
    '                    rViewer.ssql = sqlstring
    '                    rViewer.Report = r
    '                    rViewer.TableName = "HIRE ORDER REGISTER"

    '                    Dim textobj1 As TextObject
    '                    textobj1 = r.ReportDefinition.ReportObjects("Text3")
    '                    textobj1.Text = MyCompanyName

    '                    Dim textobj2 As TextObject
    '                    textobj2 = r.ReportDefinition.ReportObjects("Text13")
    '                    textobj2.Text = Trim(txt_Mainstore.Text)

    '                    Dim TXTOBJ3 As TextObject
    '                    TXTOBJ3 = r.ReportDefinition.ReportObjects("Text17")
    '                    TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

    '                    Dim textobj4 As TextObject
    '                    textobj4 = r.ReportDefinition.ReportObjects("Text21")
    '                    textobj4.Text = gUsername

    '                    rViewer.Show()
    '                End If
    '                Me.Cursor = Cursors.Default

    '            Else
    '                MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
    '            End If
    '            ' Else
    '            '    Me.Cursor = Cursors.WaitCursor
    '            '    Dim heading() As String = {"PURCHASE REGISTER "}
    '            '    Dim ObjStockPurchaseregistersummary As New rptPurchaseregistersummary
    '            '    ObjStockPurchaseregistersummary.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
    '            '    Me.Cursor = Cursors.Default
    '            ' End If

    '        ElseIf opt_Singlesupplier.Checked = True Then
    '            sqlstring = " select distinct  grndetails , grndate,pono ,Supplierinvno, suppliercode , suppliername ,HIREREASON,FROMDATE,TODATE, totalamount , vatamount , surchargeamt , discountamount , billamount,OVERALLDISCOUNT,GLACCOUNTCODE,GLACCOUNTNAME  from VIEWHIREREGISTERSUMMARY "
    '            'If ChkLst_Item.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
    '            '    sqlstring = sqlstring & " where  ITEMCODE BETWEEN '"
    '            '    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
    '            'Else
    '            If chklst_Supplier.CheckedItems.Count <> 0 Then
    '                sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
    '                For i = 0 To chklst_Supplier.CheckedItems.Count - 1
    '                    SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
    '                    sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
    '                Next
    '                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    '                sqlstring = sqlstring & ")"
    '            Else
    '                MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Exit Sub
    '            End If
    '            'If ChkLst_Item.CheckedItems.Count <> 0 Then
    '            '    sqlstring = sqlstring & " AND ITEMCODE IN ("
    '            '    For i = 0 To ChkLst_Item.CheckedItems.Count - 1
    '            '        ITEMNAME = Split(ChkLst_Item.CheckedItems(i), "-->")
    '            '        sqlstring = sqlstring & " '" & Trim(ITEMNAME(0)) & "', "
    '            '    Next
    '            '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    '            '    sqlstring = sqlstring & ")"
    '            'Else
    '            '    MessageBox.Show("Select the Item code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            '    Exit Sub
    '            'End If
    '            ' End If
    '            ' sqlstring = sqlstring & " AND STOREDESC = '" & Trim(txt_Mainstore.Text) & "'  AND ISNULL(GRNTYPE,'') = 'HRN'  "
    '            sqlstring = sqlstring & " AND ISNULL(GRNTYPE,'') = 'HRT'"
    '            sqlstring = sqlstring & " AND GRNDATE BETWEEN"
    '            sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
    '            sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME  "

    '            'If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Purchase Register") = MsgBoxResult.Yes Then
    '            Me.Cursor = Cursors.WaitCursor
    '            gconnection.getDataSet(sqlstring, "VIEWHIREREGISTERSUMMARY")
    '            If gdataset.Tables("VIEWHIREREGISTERSUMMARY").Rows.Count > 0 Then
    '                If chk_excel.Checked = True Then
    '                    Dim exp As New exportexcel
    '                    exp.Show()
    '                    Call exp.export(sqlstring, "HIRE ORDER REGISTER  " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "TO" & Format(dtp_Todate.Value, "dd-MMM-yyyy"), "")
    '                Else
    '                    rViewer.ssql = sqlstring
    '                    rViewer.Report = r9
    '                    rViewer.TableName = "HIRE ORDER REGISTER"

    '                    Dim textobj1 As TextObject
    '                    textobj1 = r9.ReportDefinition.ReportObjects("Text3")
    '                    textobj1.Text = MyCompanyName

    '                    Dim textobj2 As TextObject
    '                    textobj2 = r9.ReportDefinition.ReportObjects("Text13")
    '                    textobj2.Text = Trim(txt_Mainstore.Text)

    '                    Dim TXTOBJ3 As TextObject
    '                    TXTOBJ3 = r9.ReportDefinition.ReportObjects("Text17")
    '                    TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

    '                    Dim textobj4 As TextObject
    '                    textobj4 = r9.ReportDefinition.ReportObjects("Text21")
    '                    textobj4.Text = gUsername

    '                    rViewer.Show()
    '                End If
    '                Me.Cursor = Cursors.Default

    '            Else
    '                MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
    '            End If

    '        ElseIf opt_Purchasedetails.Checked = True Then
    '            Me.Cursor = Cursors.WaitCursor
    '            opt_Purchasedetails.Checked = True

    '            sqlstring = " SELECT * FROM VIEWHIREREGISTERSUMMARY "

    '            'If ChkLst_Item.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
    '            '    sqlstring = sqlstring & " where ITEMCODE BETWEEN '"
    '            '    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
    '            'Else
    '            If chklst_Supplier.CheckedItems.Count <> 0 Then
    '                sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
    '                For i = 0 To chklst_Supplier.CheckedItems.Count - 1
    '                    SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
    '                    sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
    '                Next
    '                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    '                sqlstring = sqlstring & ")"
    '            Else
    '                MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Exit Sub
    '            End If
    '            '    If ChkLst_Item.CheckedItems.Count <> 0 Then
    '            '        sqlstring = sqlstring & " AND ITEMCODE IN ("
    '            '        For i = 0 To ChkLst_Item.CheckedItems.Count - 1
    '            '            ITEMNAME = Split(ChkLst_Item.CheckedItems(i), "-->")
    '            '            sqlstring = sqlstring & " '" & Trim(ITEMNAME(0)) & "', "
    '            '        Next
    '            '        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    '            '        sqlstring = sqlstring & ")"
    '            '    Else
    '            '        MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            '        Exit Sub
    '            '    End If
    '            'End If
    '            ' sqlstring = sqlstring & " AND STOREDESC = '" & Trim(txt_Mainstore.Text) & "' AND ISNULL(GRNTYPE,'') = 'HRN'  "
    '            sqlstring = sqlstring & " AND ISNULL(GRNTYPE,'') = 'HRT'"
    '            sqlstring = sqlstring & " AND GRNDATE BETWEEN"
    '            sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"

    '            If rdo_code.Checked = True Then
    '                sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMCODE  "
    '            ElseIf rdo_name.Checked = True Then
    '                sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMNAME  "
    '            Else
    '                sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMCODE  "
    '            End If
    '            Dim s As New Rpt_PurchaseRegister_Det

    '            'If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Purchase Register") = MsgBoxResult.Yes Then
    '            Me.Cursor = Cursors.WaitCursor
    '            gconnection.getDataSet(sqlstring, "VIEWHIREREGISTERSUMMARY")

    '            If gdataset.Tables("VIEWHIREREGISTERSUMMARY").Rows.Count > 0 Then
    '                If chk_excel.Checked = True Then
    '                    Dim exp As New exportexcel
    '                    exp.Show()
    '                    Call exp.export(sqlstring, "HIRE ORDER REGISTER  " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "TO" & Format(dtp_Todate.Value, "dd-MMM-yyyy"), "")
    '                Else
    '                    rViewer.ssql = sqlstring
    '                    rViewer.Report = s
    '                    rViewer.TableName = "HIRE ORDER REGISTER"

    '                    Dim textobj1 As TextObject
    '                    textobj1 = s.ReportDefinition.ReportObjects("Text3")
    '                    textobj1.Text = MyCompanyName

    '                    Dim textobj2 As TextObject
    '                    textobj2 = s.ReportDefinition.ReportObjects("Text16")
    '                    textobj2.Text = Trim(txt_Mainstore.Text)

    '                    Dim TXTOBJ3 As TextObject
    '                    TXTOBJ3 = s.ReportDefinition.ReportObjects("Text17")
    '                    TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

    '                    Dim textobj4 As TextObject
    '                    textobj4 = s.ReportDefinition.ReportObjects("Text22")
    '                    textobj4.Text = gUsername

    '                    rViewer.Show()
    '                End If
    '                Me.Cursor = Cursors.Default
    '            Else
    '                MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
    '            End If
    '            'Else
    '            'Me.Cursor = Cursors.WaitCursor
    '            ' Dim heading() As String = {"PURCHASE REGISTER "}
    '            ' Dim ObjStockPurchaseregisterReport As New rptStockPurchaseregister
    '            ' ObjStockPurchaseregisterReport.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
    '            ' Me.Cursor = Cursors.Default
    '            'End If
    '        End If

    '        'If CHK_ITEM.Checked = True Then

    '        '    Dim v As New Rpt_PurRegister_Item
    '        '    Dim vViewer As New Viewer
    '        '    sqlstring = " SELECT ITEMCODE,ITEMNAME,SUM(qty) AS QTY,(SUM(AMOUNT)/SUM(qty)) AS RATE,SUM(AMOUNT) AS AMOUNT,SUM(TAXAMOUNT) AS TAXAMOUNT, "
    '        '    sqlstring = sqlstring & " SUM(DISCOUNT) AS DISCOUNT , SUM(OTHCHARGE) AS OTHCHARGE FROM VIEWHIREREGISTERSUMMARY "


    '        '    'If ChkLst_Item.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
    '        '    '    sqlstring = sqlstring & " where ITEMNAME BETWEEN '"
    '        '    '    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
    '        '    'Else

    '        '    If chklst_Supplier.CheckedItems.Count <> 0 Then
    '        '        sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
    '        '        For i = 0 To chklst_Supplier.CheckedItems.Count - 1
    '        '            SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
    '        '            sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
    '        '        Next
    '        '        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    '        '        sqlstring = sqlstring & ")"
    '        '    Else
    '        '        MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        '        Exit Sub
    '        '    End If
    '        '    '    If ChkLst_Item.CheckedItems.Count <> 0 Then
    '        '    '        sqlstring = sqlstring & " AND ITEMCODE IN ("
    '        '    '        For i = 0 To ChkLst_Item.CheckedItems.Count - 1
    '        '    '            ITEMNAME = Split(ChkLst_Item.CheckedItems(i), "-->")
    '        '    '            sqlstring = sqlstring & " '" & Trim(ITEMNAME(0)) & "', "
    '        '    '        Next
    '        '    '        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    '        '    '        sqlstring = sqlstring & ")"
    '        '    '    Else
    '        '    '        MessageBox.Show("Select the Items Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        '    '        Exit Sub
    '        '    '    End If
    '        '    'End If
    '        '    '    sqlstring = sqlstring & " AND STOREDESC = '" & Trim(txt_Mainstore.Text) & "' AND ISNULL(GRNTYPE,'') = 'HRN' "
    '        '    sqlstring = sqlstring & " AND ISNULL(GRNTYPE,'') = 'HRN' "
    '        '    sqlstring = sqlstring & " AND GRNDATE BETWEEN"
    '        '    sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
    '        '    sqlstring = sqlstring & " GROUP BY ITEMCODE,ITEMNAME  "
    '        '    If rdo_code.Checked = True Then
    '        '        sqlstring = sqlstring & " ORDER BY ITEMCODE, ITEMNAME "
    '        '    ElseIf rdo_name.Checked = True Then
    '        '        sqlstring = sqlstring & " ORDER BY ITEMNAME, ITEMCODE "
    '        '    Else
    '        '        sqlstring = sqlstring & " ORDER BY ITEMCODE, ITEMNAME "
    '        '    End If
    '        '    Me.Cursor = Cursors.Default
    '        '    ' If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Purchase Register") = MsgBoxResult.Yes Then
    '        '    Me.Cursor = Cursors.WaitCursor
    '        '    gconnection.getDataSet(sqlstring, "VIEWHIREREGISTERSUMMARY")
    '        '    If gdataset.Tables("VIEWHIREREGISTERSUMMARY").Rows.Count > 0 Then
    '        '        If chk_excel.Checked = True Then
    '        '            Dim exp As New exportexcel
    '        '            exp.Show()
    '        '            Call exp.export(sqlstring, "PHIRE ORDER REGISTER  " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "TO" & Format(dtp_Todate.Value, "dd-MMM-yyyy"), "")
    '        '        Else
    '        '            vViewer.ssql = sqlstring
    '        '            vViewer.Report = v
    '        '            vViewer.TableName = "HIRE ORDER REGISTER"

    '        '            Dim textobj1 As TextObject
    '        '            textobj1 = v.ReportDefinition.ReportObjects("Text3")
    '        '            textobj1.Text = MyCompanyName

    '        '            Dim textobj2 As TextObject
    '        '            textobj2 = r.ReportDefinition.ReportObjects("Text13")
    '        '            textobj2.Text = Trim(txt_Mainstore.Text)

    '        '            Dim TXTOBJ3 As TextObject
    '        '            TXTOBJ3 = v.ReportDefinition.ReportObjects("Text17")
    '        '            TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

    '        '            Dim textobj4 As TextObject
    '        '            textobj4 = r.ReportDefinition.ReportObjects("Text14")
    '        '            textobj4.Text = gUsername

    '        '            vViewer.Show()
    '        '        End If
    '        '        Me.Cursor = Cursors.Default
    '        '    Else
    '        '        MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
    '        '    End If
    '        '    'End If
    '        'End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Sub
    '    End Try
    'End Sub
    '  Private Sub ViewPurchaseRegister()
    '    Try
    'Dim sqlstring, SUPPLIERNAME(), ITEMNAME() As String
    'Dim i As Integer
    'Dim r As New Rpt_PurchaseRegister
    'Dim r9 As New Rpt_PurchaseRegister_Supplier
    'Dim rViewer As New Viewer

    '        Me.Cursor = Cursors.WaitCursor
    '        If opt_Purchasesummary.Checked = True Then
    '            sqlstring = " select distinct  grndetails , grndate,pono ,Supplierinvno, suppliercode , suppliername ,HIREREASON,FROMDATE,TODATE, totalamount , vatamount , surchargeamt , discountamount , billamount,OVERALLDISCOUNT  from VIEWHIREREGISTERSUMMARY "
    ''If ChkLst_Item.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
    ''    sqlstring = sqlstring & " where  ITEMCODE BETWEEN '"
    ''    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
    ''Else
    '            If chklst_Supplier.CheckedItems.Count <> 0 Then
    '                sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
    '                For i = 0 To chklst_Supplier.CheckedItems.Count - 1
    '                    SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
    '                    sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
    '                Next
    '                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    '                sqlstring = sqlstring & ")"
    '            Else
    '                MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Exit Sub
    '            End If
    ''If ChkLst_Item.CheckedItems.Count <> 0 Then
    ''    sqlstring = sqlstring & " AND ITEMCODE IN ("
    ''    For i = 0 To ChkLst_Item.CheckedItems.Count - 1
    ''        ITEMNAME = Split(ChkLst_Item.CheckedItems(i), "-->")
    ''        sqlstring = sqlstring & " '" & Trim(ITEMNAME(0)) & "', "
    ''    Next
    ''    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    ''    sqlstring = sqlstring & ")"
    ''Else
    ''    MessageBox.Show("Select the Item Code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    ''    Exit Sub
    ''End If
    ''  End If
    '' sqlstring = sqlstring & " AND STOREDESC = '" & Trim(txt_Mainstore.Text) & "' AND ISNULL(GRNTYPE,'') = 'HRN' "
    '            sqlstring = sqlstring & " and ISNULL(GRNTYPE,'') = 'HRN' "
    '            sqlstring = sqlstring & " AND GRNDATE BETWEEN"
    '            sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
    '            If rdo_code.Checked = True Then
    '                sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME  "
    '            ElseIf rdo_name.Checked = True Then
    '                sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME  "
    '            Else
    '                sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME  "
    '            End If
    '' If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Purchase Register") = MsgBoxResult.Yes Then
    '            Me.Cursor = Cursors.WaitCursor
    '            gconnection.getDataSet(sqlstring, "VIEWHIREREGISTERSUMMARY")
    '            If gdataset.Tables("VIEWHIREREGISTERSUMMARY").Rows.Count > 0 Then
    '                If chk_excel.Checked = True Then
    'Dim exp As New exportexcel
    '                    exp.Show()
    '                    Call exp.export(sqlstring, "HIRE ORDER REGISTER  " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "TO" & Format(dtp_Todate.Value, "dd-MMM-yyyy"), "")
    '                Else
    '                    rViewer.ssql = sqlstring
    '                    rViewer.Report = r
    '                    rViewer.TableName = "HIRE ORDER REGISTER"

    'Dim textobj1 As TextObject
    '                    textobj1 = r.ReportDefinition.ReportObjects("Text3")
    '                    textobj1.Text = MyCompanyName

    'Dim textobj2 As TextObject
    '                    textobj2 = r.ReportDefinition.ReportObjects("Text13")
    '                    textobj2.Text = Trim(txt_Mainstore.Text)

    'Dim TXTOBJ3 As TextObject
    '                    TXTOBJ3 = r.ReportDefinition.ReportObjects("Text17")
    '                    TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

    'Dim textobj4 As TextObject
    '                    textobj4 = r.ReportDefinition.ReportObjects("Text21")
    '                    textobj4.Text = gUsername

    '                    rViewer.Show()
    '                End If
    '                Me.Cursor = Cursors.Default

    '            Else
    '                MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
    '            End If
    '' Else
    ''    Me.Cursor = Cursors.WaitCursor
    ''    Dim heading() As String = {"PURCHASE REGISTER "}
    ''    Dim ObjStockPurchaseregistersummary As New rptPurchaseregistersummary
    ''    ObjStockPurchaseregistersummary.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
    ''    Me.Cursor = Cursors.Default
    '' End If

    '        ElseIf opt_Singlesupplier.Checked = True Then
    '            sqlstring = " select distinct  grndetails , grndate,pono ,Supplierinvno, suppliercode , suppliername ,HIREREASON,FROMDATE,TODATE, totalamount , vatamount , surchargeamt , discountamount , billamount,OVERALLDISCOUNT,GLACCOUNTCODE,GLACCOUNTNAME  from VIEWHIREREGISTERSUMMARY "
    ''If ChkLst_Item.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
    ''    sqlstring = sqlstring & " where  ITEMCODE BETWEEN '"
    ''    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
    ''Else
    '            If chklst_Supplier.CheckedItems.Count <> 0 Then
    '                sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
    '                For i = 0 To chklst_Supplier.CheckedItems.Count - 1
    '                    SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
    '                    sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
    '                Next
    '                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    '                sqlstring = sqlstring & ")"
    '            Else
    '                MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Exit Sub
    '            End If
    ''If ChkLst_Item.CheckedItems.Count <> 0 Then
    ''    sqlstring = sqlstring & " AND ITEMCODE IN ("
    ''    For i = 0 To ChkLst_Item.CheckedItems.Count - 1
    ''        ITEMNAME = Split(ChkLst_Item.CheckedItems(i), "-->")
    ''        sqlstring = sqlstring & " '" & Trim(ITEMNAME(0)) & "', "
    ''    Next
    ''    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    ''    sqlstring = sqlstring & ")"
    ''Else
    ''    MessageBox.Show("Select the Item code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    ''    Exit Sub
    ''End If
    '' End If
    '' sqlstring = sqlstring & " AND STOREDESC = '" & Trim(txt_Mainstore.Text) & "'  AND ISNULL(GRNTYPE,'') = 'HRN'  "
    '            sqlstring = sqlstring & " AND ISNULL(GRNTYPE,'') = 'HRN'"
    '            sqlstring = sqlstring & " AND GRNDATE BETWEEN"
    '            sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
    '            sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME  "

    ''If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Purchase Register") = MsgBoxResult.Yes Then
    '            Me.Cursor = Cursors.WaitCursor
    '            gconnection.getDataSet(sqlstring, "VIEWHIREREGISTERSUMMARY")
    '            If gdataset.Tables("VIEWHIREREGISTERSUMMARY").Rows.Count > 0 Then
    '                If chk_excel.Checked = True Then
    'Dim exp As New exportexcel
    '                    exp.Show()
    '                    Call exp.export(sqlstring, "HIRE ORDER REGISTER  " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "TO" & Format(dtp_Todate.Value, "dd-MMM-yyyy"), "")
    '                Else
    '                    rViewer.ssql = sqlstring
    '                    rViewer.Report = r9
    '                    rViewer.TableName = "HIRE ORDER REGISTER"

    'Dim textobj1 As TextObject
    '                    textobj1 = r9.ReportDefinition.ReportObjects("Text3")
    '                    textobj1.Text = MyCompanyName

    'Dim textobj2 As TextObject
    '                    textobj2 = r9.ReportDefinition.ReportObjects("Text13")
    '                    textobj2.Text = Trim(txt_Mainstore.Text)

    'Dim TXTOBJ3 As TextObject
    '                    TXTOBJ3 = r9.ReportDefinition.ReportObjects("Text17")
    '                    TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

    'Dim textobj4 As TextObject
    '                    textobj4 = r9.ReportDefinition.ReportObjects("Text21")
    '                    textobj4.Text = gUsername

    '                    rViewer.Show()
    '                End If
    '                Me.Cursor = Cursors.Default

    '            Else
    '                MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
    '            End If

    '        ElseIf opt_Purchasedetails.Checked = True Then
    '            Me.Cursor = Cursors.WaitCursor
    '            opt_Purchasedetails.Checked = True

    '            sqlstring = " SELECT * FROM VIEWHIREREGISTERSUMMARY "

    ''If ChkLst_Item.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
    ''    sqlstring = sqlstring & " where ITEMCODE BETWEEN '"
    ''    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
    ''Else
    '            If chklst_Supplier.CheckedItems.Count <> 0 Then
    '                sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
    '                For i = 0 To chklst_Supplier.CheckedItems.Count - 1
    '                    SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
    '                    sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
    '                Next
    '                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    '                sqlstring = sqlstring & ")"
    '            Else
    '                MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Exit Sub
    '            End If
    ''    If ChkLst_Item.CheckedItems.Count <> 0 Then
    ''        sqlstring = sqlstring & " AND ITEMCODE IN ("
    ''        For i = 0 To ChkLst_Item.CheckedItems.Count - 1
    ''            ITEMNAME = Split(ChkLst_Item.CheckedItems(i), "-->")
    ''            sqlstring = sqlstring & " '" & Trim(ITEMNAME(0)) & "', "
    ''        Next
    ''        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    ''        sqlstring = sqlstring & ")"
    ''    Else
    ''        MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    ''        Exit Sub
    ''    End If
    ''End If
    '' sqlstring = sqlstring & " AND STOREDESC = '" & Trim(txt_Mainstore.Text) & "' AND ISNULL(GRNTYPE,'') = 'HRN'  "
    '            sqlstring = sqlstring & " AND ISNULL(GRNTYPE,'') = 'HRN'"
    '            sqlstring = sqlstring & " AND GRNDATE BETWEEN"
    '            sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"

    '            If rdo_code.Checked = True Then
    '                sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMCODE  "
    '            ElseIf rdo_name.Checked = True Then
    '                sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMNAME  "
    '            Else
    '                sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMCODE  "
    '            End If
    'Dim s As New Rpt_PurchaseRegister_Det

    ''If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Purchase Register") = MsgBoxResult.Yes Then
    '            Me.Cursor = Cursors.WaitCursor
    '            gconnection.getDataSet(sqlstring, "VIEWHIREREGISTERSUMMARY")

    '            If gdataset.Tables("VIEWHIREREGISTERSUMMARY").Rows.Count > 0 Then
    '                If chk_excel.Checked = True Then
    'Dim exp As New exportexcel
    '                    exp.Show()
    '                    Call exp.export(sqlstring, "HIRE ORDER REGISTER  " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "TO" & Format(dtp_Todate.Value, "dd-MMM-yyyy"), "")
    '                Else
    '                    rViewer.ssql = sqlstring
    '                    rViewer.Report = s
    '                    rViewer.TableName = "HIRE ORDER REGISTER"

    'Dim textobj1 As TextObject
    '                    textobj1 = s.ReportDefinition.ReportObjects("Text3")
    '                    textobj1.Text = MyCompanyName

    'Dim textobj2 As TextObject
    '                    textobj2 = s.ReportDefinition.ReportObjects("Text16")
    '                    textobj2.Text = Trim(txt_Mainstore.Text)

    'Dim TXTOBJ3 As TextObject
    '                    TXTOBJ3 = s.ReportDefinition.ReportObjects("Text17")
    '                    TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

    'Dim textobj4 As TextObject
    '                    textobj4 = s.ReportDefinition.ReportObjects("Text22")
    '                    textobj4.Text = gUsername

    '                    rViewer.Show()
    '                End If
    '                Me.Cursor = Cursors.Default
    '            Else
    '                MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
    '            End If
    ''Else
    ''Me.Cursor = Cursors.WaitCursor
    '' Dim heading() As String = {"PURCHASE REGISTER "}
    '' Dim ObjStockPurchaseregisterReport As New rptStockPurchaseregister
    '' ObjStockPurchaseregisterReport.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
    '' Me.Cursor = Cursors.Default
    ''End If
    '        End If

    ''If CHK_ITEM.Checked = True Then

    ''    Dim v As New Rpt_PurRegister_Item
    ''    Dim vViewer As New Viewer
    ''    sqlstring = " SELECT ITEMCODE,ITEMNAME,SUM(qty) AS QTY,(SUM(AMOUNT)/SUM(qty)) AS RATE,SUM(AMOUNT) AS AMOUNT,SUM(TAXAMOUNT) AS TAXAMOUNT, "
    ''    sqlstring = sqlstring & " SUM(DISCOUNT) AS DISCOUNT , SUM(OTHCHARGE) AS OTHCHARGE FROM VIEWHIREREGISTERSUMMARY "


    ''    'If ChkLst_Item.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
    ''    '    sqlstring = sqlstring & " where ITEMNAME BETWEEN '"
    ''    '    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
    ''    'Else

    ''    If chklst_Supplier.CheckedItems.Count <> 0 Then
    ''        sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
    ''        For i = 0 To chklst_Supplier.CheckedItems.Count - 1
    ''            SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
    ''            sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
    ''        Next
    ''        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    ''        sqlstring = sqlstring & ")"
    ''    Else
    ''        MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    ''        Exit Sub
    ''    End If
    ''    '    If ChkLst_Item.CheckedItems.Count <> 0 Then
    ''    '        sqlstring = sqlstring & " AND ITEMCODE IN ("
    ''    '        For i = 0 To ChkLst_Item.CheckedItems.Count - 1
    ''    '            ITEMNAME = Split(ChkLst_Item.CheckedItems(i), "-->")
    ''    '            sqlstring = sqlstring & " '" & Trim(ITEMNAME(0)) & "', "
    ''    '        Next
    ''    '        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    ''    '        sqlstring = sqlstring & ")"
    ''    '    Else
    ''    '        MessageBox.Show("Select the Items Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    ''    '        Exit Sub
    ''    '    End If
    ''    'End If
    ''    '    sqlstring = sqlstring & " AND STOREDESC = '" & Trim(txt_Mainstore.Text) & "' AND ISNULL(GRNTYPE,'') = 'HRN' "
    ''    sqlstring = sqlstring & " AND ISNULL(GRNTYPE,'') = 'HRN' "
    ''sqlstring = sqlstring & " AND GRNDATE BETWEEN"
    ''sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
    ''sqlstring = sqlstring & " GROUP BY ITEMCODE,ITEMNAME  "
    ''If rdo_code.Checked = True Then
    ''    sqlstring = sqlstring & " ORDER BY ITEMCODE, ITEMNAME "
    ''ElseIf rdo_name.Checked = True Then
    ''    sqlstring = sqlstring & " ORDER BY ITEMNAME, ITEMCODE "
    ''Else
    ''    sqlstring = sqlstring & " ORDER BY ITEMCODE, ITEMNAME "
    ''End If
    ''Me.Cursor = Cursors.Default
    ' '' If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Purchase Register") = MsgBoxResult.Yes Then
    ''Me.Cursor = Cursors.WaitCursor
    ''gconnection.getDataSet(sqlstring, "VIEWHIREREGISTERSUMMARY")
    ''If gdataset.Tables("VIEWHIREREGISTERSUMMARY").Rows.Count > 0 Then
    ''    If chk_excel.Checked = True Then
    ''        Dim exp As New exportexcel
    ''        exp.Show()
    ''        Call exp.export(sqlstring, "PHIRE ORDER REGISTER  " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "TO" & Format(dtp_Todate.Value, "dd-MMM-yyyy"), "")
    ''    Else
    ''        vViewer.ssql = sqlstring
    ''        vViewer.Report = v
    ''        vViewer.TableName = "HIRE ORDER REGISTER"

    ''        Dim textobj1 As TextObject
    ''        textobj1 = v.ReportDefinition.ReportObjects("Text3")
    ''        textobj1.Text = MyCompanyName

    ''        Dim textobj2 As TextObject
    ''        textobj2 = r.ReportDefinition.ReportObjects("Text13")
    ''        textobj2.Text = Trim(txt_Mainstore.Text)

    ''        Dim TXTOBJ3 As TextObject
    ''        TXTOBJ3 = v.ReportDefinition.ReportObjects("Text17")
    ''        TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

    ''        Dim textobj4 As TextObject
    ''        textobj4 = r.ReportDefinition.ReportObjects("Text14")
    ''        textobj4.Text = gUsername

    ''        vViewer.Show()
    ''    End If
    ''    Me.Cursor = Cursors.Default
    ''Else
    ''    MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
    ''End If
    ' ''End If
    ''End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Sub
    '    End Try
    'End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_SalebillChecklist.Top = 1000
            'If Opt_purchase.Checked = True Then
            '    Call ViewPurchaseRegister()
            'ElseIf Opt_Return.Checked = True Then
            '    Call ViewReturnRegister()
            'ElseIf OptAll.Checked = True Then
            '    Call Viewsuppliernamewise()
            '    'ElseIf Chk_pendingpo.Checked = True Then
            '    '    Call pendingpo()
            'Else
            Call Viewsuppliernamewise()
            ' End If


        End If
    End Sub

    Private Sub dtp_Fromdate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Fromdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_Todate.Focus()
        End If
    End Sub

    Private Sub dtp_Todate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Todate.KeyDown
        If e.KeyCode = Keys.Enter Then

            If Format(dtp_Todate.Value, "dd/MM/yyyy") > Format((CDate("31-MAR-" & gFinancialyearEnd)), "dd/MM/yyyy") Then
                MessageBox.Show("Date should be within the Financial year", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
            Cmd_View.Focus()
        End If
    End Sub

    Private Sub frmWORKORDERregister_Recon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Resize_Form()
        Call Fillsuppliername()
        dtp_Fromdate.Value = Format(CDate("01/04/" & gFinancalyearStart), "dd/MM/yyyy")
        dtp_Todate.Value = Format(Now, "dd/MM/yyyy")
        grp_SalebillChecklist.Top = 1000
        Call FillGroupdetails()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Lbl_SubledgerCode.Visible = True
        Label8.Visible = True
        TXT_FROM.Visible = True
        txt_itemto.Visible = True
        Cmd_ITEMFROM.Visible = True
        cmd_itemto.Visible = True
    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='PURCHASE ORDER' AND MODULENAME LIKE '%" & Trim(GmoduleName) & "%' ORDER BY RIGHTS"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.Cmd_View.Enabled = False
        Me.Cmd_Print.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_View.Enabled = True
                    Me.Cmd_Print.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.Cmd_Print.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub Fillsuppliername()
        Dim i As Integer
        chklst_Supplier.Items.Clear()
        ' If gCATHOLIC = "Y" Then
        '  sqlstring = "SELECT DISTINCT ISNULL(SLCODE,'') AS SLCODE,ISNULL(SLNAME,'') AS SLNAME FROM ACCOUNTSSUBLEDGERMASTER WHERE ISNULL(ACCODE,'')='" & Trim(gCreditors) & "'  AND ISNULL(FREeZEFLAG,'') <> 'Y' AND SLCODE IN(select distinct suppliercode from grn_header where isnull(void,'')<>'Y') ORDER BY SLCODE"
        '  Else
         sqlstring = "SELECT DISTINCT ISNULL(vendorcode,'') AS vendorcode,ISNULL(vendorname,'') AS vendorname FROM po_view_vendormaster"
        gconnection.getDataSet(sqlstring, "SUBLEDGERMASTER")
        If gdataset.Tables("SUBLEDGERMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("SUBLEDGERMASTER").Rows.Count - 1
                With gdataset.Tables("SUBLEDGERMASTER").Rows(i)
                    chklst_Supplier.Items.Add(Trim(.Item("vendorcode")) & "-->" & Trim(.Item("vendorname")))
                End With
            Next i
        End If
    End Sub
    Private Sub FillItemdetails()
        Dim i As Integer
        Dim sqlstring As String
        ChkLst_Item.Items.Clear()
        sqlstring = "SELECT DISTINCT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME FROM INVENTORYITEMMASTER where isnull(freeze,'') <> 'Y' ORDER BY ITEMCODE "
        gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER")
        If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("INVENTORYITEMMASTER").Rows.Count - 1
                With gdataset.Tables("INVENTORYITEMMASTER").Rows(i)
                    ChkLst_Item.Items.Add(Trim(CStr(.Item("ITEMCODE"))) & "-->" & Trim(CStr(.Item("ITEMNAME"))))
                End With
            Next
        End If
    End Sub
    Private Sub FillGroupdetails()
        Dim i As Integer
        Dim sqlstring As String
        ChkLst_Group.Items.Clear()
        sqlstring = "SELECT ISNULL(GROUPCODE,'') AS GROUPCODE,ISNULL(GROUPDESC,'') AS GROUPDESC FROM INVENTORYGROUPMASTER  where groupcode in (select groupcode from inventoryitemmaster) ORDER BY GROUPCODE "
        gconnection.getDataSet(sqlstring, "INVENTORYGROUPMASTER")
        If gdataset.Tables("INVENTORYGROUPMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("INVENTORYGROUPMASTER").Rows.Count - 1
                With gdataset.Tables("INVENTORYGROUPMASTER").Rows(i)
                    ChkLst_Group.Items.Add(Trim(CStr(.Item("GROUPDESC"))))
                End With
            Next
        End If
    End Sub
    Private Sub opt_Purchasedetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles opt_Purchasedetails.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmd_View.Focus()
        End If
    End Sub

    Private Sub opt_Purchasesummary_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles opt_Purchasesummary.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmd_View.Focus()
        End If
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        grp_SalebillChecklist.Top = 1000
        opt_Purchasesummary.Checked = True
        Chk_SelectAllSupplier.Checked = False
        dtp_Fromdate.Value = Format(CDate("01/04/" & gFinancalyearStart), "dd/MM/yyyy")

        Chk_AllGroup.Checked = False

        Chk_AllItem.Checked = False
        CBO_SELECTALL.Checked = False
        CHK_ITEM.Checked = False
        txt_Mainstore.Text = ""
        txt_Mainstorecode.Text = ""
        TXT_FROM.Text = ""
        txt_itemto.Text = ""
        Lbl_SubledgerCode.Visible = True
        Label8.Visible = True
        TXT_FROM.Visible = True
        txt_itemto.Visible = True
        Cmd_ITEMFROM.Visible = True
        cmd_itemto.Visible = True
        Call Fillsuppliername()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        dtp_Fromdate.Focus()
    End Sub

    Private Sub Chk_SelectAllSupplier_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_SelectAllSupplier.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllSupplier.Checked = True Then
            For i = 0 To chklst_Supplier.Items.Count - 1
                chklst_Supplier.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklst_Supplier.Items.Count - 1
                chklst_Supplier.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub Chk_SelectAllSupplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_SelectAllSupplier.KeyDown
        If e.KeyCode = Keys.Enter Then
            chklst_Supplier.Focus()
        End If
    End Sub

    Private Sub chklst_Supplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chklst_Supplier.KeyDown
        If e.KeyCode = Keys.Enter Then
            opt_Purchasedetails.Focus()
        End If
    End Sub
    Private Sub ChkLst_Group_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkLst_Group.DoubleClick
        Dim i, J As Integer
        Dim sqlstring, ssql As String
        ssql = ""
        sqlstring = "SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME FROM HRN_DETAILS AS I "
        sqlstring = sqlstring & " WHERE isnull(freeze,'') <> 'Y' " 'and I.GROUPNAME IN ("

        'For J = 0 To ChkLst_Group.CheckedItems.Count - 1
        '    If J = ChkLst_Group.CheckedItems.Count - 1 Then
        '        ssql = ssql & " '" & ChkLst_Group.CheckedItems(J) & "' "
        '    Else
        '        ssql = ssql & " '" & ChkLst_Group.CheckedItems(J) & "', "
        '    End If
        'Next
        If ChkLst_Group.CheckedItems.Count > 0 Then
            sqlstring = sqlstring & ssql & ") ORDER BY ITEMCODE "
            gconnection.getDataSet(sqlstring, "INVENTORYSUBGROUPMASTER")
            If gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows.Count > 0 Then
                ChkLst_Item.Items.Clear()
                For i = 0 To gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows.Count - 1
                    With gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows(i)
                        ChkLst_Item.Items.Add(Trim(.Item("ITEMCODE") & "-->" & .Item("ITEMNAME")))
                    End With
                Next i
            End If
        End If
    End Sub
    Private Sub ChkLst_Group_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkLst_Group.SelectedIndexChanged
        Dim i, J As Integer
        Dim sqlstring, ssql As String
        ssql = ""
        sqlstring = "SELECT DISTINCT ISNULL(I.ITEMCODE,'') AS ITEMCODE,ISNULL(I.ITEMNAME,'') AS ITEMNAME FROM INVENTORYITEMMASTER AS I "
        sqlstring = sqlstring & " WHERE isnull(freeze,'') <> 'Y' and I.GROUPNAME IN ("

        For J = 0 To ChkLst_Group.CheckedItems.Count - 1
            If J = ChkLst_Group.CheckedItems.Count - 1 Then
                ssql = ssql & " '" & ChkLst_Group.CheckedItems(J) & "' "
            Else
                ssql = ssql & " '" & ChkLst_Group.CheckedItems(J) & "', "
            End If
        Next
        If ChkLst_Group.CheckedItems.Count > 0 Then
            sqlstring = sqlstring & ssql & ") ORDER BY ITEMCODE "
            gconnection.getDataSet(sqlstring, "INVENTORYSUBGROUPMASTER")
            If gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows.Count > 0 Then
                ChkLst_Item.Items.Clear()
                For i = 0 To gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows.Count - 1
                    With gdataset.Tables("INVENTORYSUBGROUPMASTER").Rows(i)
                        ChkLst_Item.Items.Add(Trim(.Item("ITEMCODE") & "-->" & .Item("ITEMNAME")))
                    End With
                Next i
            End If
        Else
            ChkLst_Item.Items.Clear()
        End If
    End Sub
    Private Sub Chk_SelectAllGroup_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_AllGroup.CheckedChanged
        Dim i As Integer
        If Chk_AllGroup.Checked = True Then
            For i = 0 To ChkLst_Group.Items.Count - 1
                ChkLst_Group.SetItemChecked(i, True)
            Next
            Call ChkLst_Group_SelectedIndexChanged(sender, e)
        Else
            For i = 0 To ChkLst_Group.Items.Count - 1
                ChkLst_Group.SetItemChecked(i, False)
            Next
            ChkLst_Item.Items.Clear()
        End If
    End Sub
    Private Sub Chk_SelectAllItem_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_AllItem.CheckedChanged
        Dim i As Integer
        If Chk_AllItem.Checked = True Then
            For i = 0 To ChkLst_Item.Items.Count - 1
                ChkLst_Item.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To ChkLst_Item.Items.Count - 1
                ChkLst_Item.SetItemChecked(i, False)
            Next
        End If
    End Sub
    Private Sub FillStore()
        Dim i As Integer
        sqlstring = "SELECT DISTINCT ISNULL(STOREDESC,'') AS STOREDESC FROM GRN_DETAILS ORDER BY STOREDESC ASC"
        gconnection.getDataSet(sqlstring, "STOREMASTER")
        cbo_Storelocation.Items.Clear()
        If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("STOREMASTER").Rows.Count - 1
                cbo_Storelocation.Items.Add(gdataset.Tables("STOREMASTER").Rows(i).Item("STOREDESC"))
            Next i
        End If
    End Sub
    Private Sub cbo_Storelocation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_Storelocation.KeyPress
        If Asc(e.KeyChar) = 13 Then
            dtp_Fromdate.Focus()
        End If
    End Sub

    Private Sub CHK_ITEM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_ITEM.CheckedChanged
        If CHK_ITEM.Checked = True Then
            opt_Purchasedetails.Checked = False
            opt_Purchasesummary.Checked = False
            opt_Singlesupplier.Checked = False
        Else
            opt_Purchasesummary.Checked = True
        End If
    End Sub

    Private Sub Cmd_ITEMFROM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ITEMFROM.Click
        Try
            Dim vform As New ListOperattion1_N
            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim I As Integer
            gSQLString = " SELECT  itemcode,itemname  FROM INVENTORYITEMMASTER "
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y'  "
            M_WhereCondition = M_WhereCondition & " AND storecode = '" & Trim(txt_Mainstorecode.Text) & "'"
            vform.Field = "ITEMCODE,ITEMNAME"
            vform.vFormatstring = "  ITEMCODE                             |                          ITEMNAME                                "
            vform.vCaption = "ITEMMASTER MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                TXT_FROM.Text = Trim(vform.keyfield & "")
                Me.txt_itemto.Focus()
            Else
                Me.TXT_FROM.Focus()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error :Cmd_ITEMFROM_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub TXT_FROM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_FROM.KeyPress
        Try
            getAlphanumeric(e)
            If Asc(e.KeyChar) = 13 Then
                If Trim(TXT_FROM.Text) = "" Then
                    Call Cmd_ITEMFROM_Click(Cmd_ITEMFROM, e)
                Else
                    Call TXT_FROM_Validated(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : TXT_FROM_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub TXT_FROM_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_FROM.Validated
        Try
            Dim sqlstring, itemcode() As String
            Dim i As Integer
            If Trim(TXT_FROM.Text) <> "" Then
                sqlstring = "select ITEMCODE, ITEMNAME from inventoryitemmaster where ITEMCODE = '" & Trim(TXT_FROM.Text) & "'"
                sqlstring = sqlstring & " AND storecode = '" & Trim(txt_Mainstorecode.Text) & "'"

                gconnection.getDataSet(sqlstring, "inventoryitemmaster")
                If gdataset.Tables("inventoryitemmaster").Rows.Count > 0 Then
                    TXT_FROM.Text = Trim(UCase(gdataset.Tables("inventoryitemmaster").Rows(0).Item("ITEMCODE")))
                    txt_itemto.Focus()
                Else
                    TXT_FROM.Text = ""
                    TXT_FROM.Focus()
                End If
            Else
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : TXT_FROM_Validated " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_itemto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_itemto.Click
        Try
            Dim vform As New ListOperattion1_N
            Dim Clsquantity, Itemcode(), Itemcode1, Update(0), Storecode As String
            Dim I As Integer
            gSQLString = " SELECT  itemcode,itemname  FROM INVENTORYITEMMASTER "
            M_WhereCondition = " WHERE ISNULL(FREEZE,'') <> 'Y'  "
            M_WhereCondition = M_WhereCondition & " AND storecode = '" & Trim(txt_Mainstorecode.Text) & "'"

            vform.Field = "ITEMCODE,ITEMNAME"
            vform.vFormatstring = "  ITEMCODE                             |                          ITEMNAME                                "
            vform.vCaption = "ITEMMASTER MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_itemto.Text = Trim(vform.keyfield & "")
                Me.dtp_Fromdate.Focus()
            Else
                Me.txt_itemto.Focus()
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : cmd_itemto_Click " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_itemto_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_itemto.Validated
        Try
            Dim sqlstring, itemcode() As String
            Dim i As Integer
            If Trim(txt_itemto.Text) <> "" Then
                sqlstring = "select ITEMCODE, ITEMNAME from inventoryitemmaster where ITEMCODE = '" & Trim(txt_itemto.Text) & "'"
                sqlstring = sqlstring & " AND storecode = '" & Trim(txt_Mainstorecode.Text) & "'"
                gconnection.getDataSet(sqlstring, "inventoryitemmaster")
                If gdataset.Tables("inventoryitemmaster").Rows.Count > 0 Then
                    txt_itemto.Text = Trim(UCase(gdataset.Tables("inventoryitemmaster").Rows(0).Item("ITEMCODE")))
                    Cmd_Print.Focus()
                Else
                    txt_itemto.Text = ""
                    txt_itemto.Focus()
                End If
            Else
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_itemto_Validated " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_itemto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_itemto.KeyPress
        Try
            getAlphanumeric(e)
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_itemto.Text) = "" Then
                    Call cmd_itemto_Click(cmd_itemto, e)
                Else
                    Call txt_itemto_Validated(sender, e)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_itemto_KeyPress" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_itemto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_itemto.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                Call cmd_itemto_Click(sender, e)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : txt_itemto_KeyDown" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub TXT_FROM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXT_FROM.KeyDown
        Try
            If e.KeyCode = Keys.F4 Then
                Call Cmd_ITEMFROM_Click(sender, e)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Plz Check Error : TXT_FROM_KeyDown" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub cmd_storecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_storecode.Click
        gSQLString = "SELECT DISTINCT(storecode),storedesc FROM storemaster "
        M_WhereCondition = " where freeze <> 'Y' "
        Dim vform As New ListOperattion1_N

        vform.Field = "STOREDESC,STORECODE"
        vform.vFormatstring = "             STORE CODE                   |                   STORE DESCRIPTION                             "
        vform.vCaption = "INVENTORY STORE MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_Mainstorecode.Text = Trim(vform.keyfield & "")
            txt_Mainstore.Text = Trim(vform.keyfield1 & "")
            TXT_FROM.Focus()
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
                dtp_Fromdate.Focus()
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
                    TXT_FROM.Focus()
                End If
            End If
        Catch
            MessageBox.Show("Check The Error", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Private Sub CBO_SELECTALL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CBO_SELECTALL.Checked = True Then
            Lbl_SubledgerCode.Visible = True
            Label8.Visible = True
            TXT_FROM.Visible = True
            txt_itemto.Visible = True
            Cmd_ITEMFROM.Visible = True
            cmd_itemto.Visible = True
            '==== for all===='
            Chk_SelectAllSupplier.Visible = False
            Chk_AllGroup.Visible = False
            Chk_AllItem.Visible = False
            ChkLst_Group.Visible = False
            ChkLst_Item.Visible = False
            chklst_Supplier.Visible = False
            Label2.Visible = False
            Label4.Visible = False
            Label3.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            Label11.Visible = False
            PictureBox1.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            '=====end ========'
            TXT_FROM.Focus()
        Else
            Lbl_SubledgerCode.Visible = False
            Label8.Visible = False
            TXT_FROM.Visible = False
            txt_itemto.Visible = False
            Cmd_ITEMFROM.Visible = False
            cmd_itemto.Visible = False
            '==for alll
            Chk_SelectAllSupplier.Visible = True
            Chk_AllGroup.Visible = True
            Chk_AllItem.Visible = True
            ChkLst_Group.Visible = True
            ChkLst_Item.Visible = True
            chklst_Supplier.Visible = True
            Label2.Visible = True
            Label4.Visible = True
            Label3.Visible = True
            Label9.Visible = True
            Label10.Visible = True
            Label11.Visible = True
            PictureBox1.Visible = True
            PictureBox3.Visible = True
            PictureBox4.Visible = True
            'end
        End If
    End Sub

    Private Sub txt_Mainstorecode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Mainstorecode.GotFocus
        Label5.Visible = True
    End Sub

    Private Sub txt_Mainstorecode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Mainstorecode.LostFocus
        Label5.Visible = False
    End Sub

    Private Sub Cmd_View_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd_View.Enter

    End Sub

    Private Sub Cmd_View_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cmd_View.TabIndexChanged

    End Sub

    Private Sub chklst_Supplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklst_Supplier.SelectedIndexChanged

    End Sub

    Private Sub CBO_SELECTALL_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBO_SELECTALL.CheckedChanged

    End Sub

    Private Sub cmd_exprot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_exprot.Click
        Dim sqlstring As String
        Dim _export As New EXPORT
        _export.TABLENAME = "viewpurchaseregistersummary"
        sqlstring = "select distinct  grndetails , grndate,pono ,Supplierinvno, suppliercode , suppliername , totalamount , vatamount , surchargeamt , discountamount , billamount,OVERALLDISCOUNT  from viewpurchaseregistersummary "
        Call _export.export_excel(sqlstring)
        _export.Show()
        Exit Sub
    End Sub

    Private Sub opt_Purchasesummary_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt_Purchasesummary.CheckedChanged
        If opt_Purchasesummary.Checked = True Then
            CHK_ITEM.Checked = False
            opt_Purchasedetails.Checked = False
            'opt_Purchasesummary.Checked = False
            opt_Singlesupplier.Checked = False
            'Else
            '    opt_Purchasesummary.Checked = True
        End If
    End Sub

    Private Sub opt_Purchasedetails_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt_Purchasedetails.CheckedChanged
        If opt_Purchasedetails.Checked = True Then
            CHK_ITEM.Checked = False
            'opt_Purchasedetails.Checked = False
            opt_Purchasesummary.Checked = False
            opt_Singlesupplier.Checked = False
            'Else
            '    opt_Purchasesummary.Checked = True
        End If
    End Sub

    Private Sub opt_Singlesupplier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opt_Singlesupplier.CheckedChanged
        If opt_Singlesupplier.Checked = True Then
            CHK_ITEM.Checked = False
            opt_Purchasedetails.Checked = False
            opt_Purchasesummary.Checked = False
            'opt_Singlesupplier.Checked = False
            'Else
            '    opt_Purchasesummary.Checked = True
        End If
    End Sub

    Private Sub btn_validation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validation.Click
        System.Diagnostics.Process.Start(AppPath & "/STUDY/PURCHASERETURNREGISTER.XLS")
    End Sub
    'Private Sub pendingpo()
    '    ' Try
    '    Dim sqlstring, SUPPLIERNAME(), ITEMNAME() As String
    '    Dim i As Integer
    '    Dim r As New Rpt_PENDINGPO
    '    'Dim r9 As New Rpt_PurchaseRegister_Supplier
    '    Dim rViewer As New Viewer

    '    Me.Cursor = Cursors.WaitCursor

    '    sqlstring = " SELECT * FROM  view_Pending_PO "
    '    'If ChkLst_Item.CheckedItems.Count = 0 And TXT_FROM.Text <> "" And txt_itemto.Text <> "" Then
    '    '    sqlstring = sqlstring & " where  ITEMCODE BETWEEN '"
    '    '    sqlstring = sqlstring & Trim(TXT_FROM.Text) & "' AND '" & Trim(txt_itemto.Text) & "' "
    '    'Else
    '    'If chklst_Supplier.CheckedItems.Count <> 0 Then
    '    '    sqlstring = sqlstring & " WHERE Suppliercode IN ("
    '    '    For i = 0 To chklst_Supplier.CheckedItems.Count - 1
    '    '        SUPPLIERNAME = Split(chklst_Supplier.CheckedItems(i), "-->")
    '    '        sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
    '    '    Next
    '    '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    '    '    sqlstring = sqlstring & ")"
    '    'Else
    '    '    MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    '    Exit Sub
    '    'End If
    '    'If ChkLst_Item.CheckedItems.Count <> 0 Then
    '    '    sqlstring = sqlstring & " AND ITEMCODE IN ("
    '    '    For i = 0 To ChkLst_Item.CheckedItems.Count - 1
    '    '        ITEMNAME = Split(ChkLst_Item.CheckedItems(i), "-->")
    '    '        sqlstring = sqlstring & " '" & Trim(ITEMNAME(0)) & "', "
    '    '    Next
    '    '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
    '    '    sqlstring = sqlstring & ")"
    '    'Else
    '    '    MessageBox.Show("Select the Item code(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    '    Exit Sub
    '    'End If
    '    'End If
    '    sqlstring = sqlstring & " WHERE podepartment = '" & Trim(txt_Mainstore.Text) & "' "
    '    sqlstring = sqlstring & " AND PODATE BETWEEN"
    '    sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
    '    sqlstring = sqlstring & " ORDER BY AUTOID,ITEMCODE "

    '    'If MsgBox("Click 'YES' for Windows View or 'NO' for Text View", MsgBoxStyle.YesNo, "Purchase Register") = MsgBoxResult.Yes Then
    '    Me.Cursor = Cursors.WaitCursor
    '    gconnection.getDataSet(sqlstring, "viewpurchaseregistersummary")
    '    If gdataset.Tables("viewpurchaseregistersummary").Rows.Count > 0 Then
    '        If chk_excel.Checked = True Then
    '            Dim exp As New exportexcel
    '            exp.Show()
    '            Call exp.export(sqlstring, "PURCHASE REGISTER  " & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "TO" & Format(dtp_Todate.Value, "dd-MMM-yyyy"), "")
    '        Else
    '            rViewer.ssql = sqlstring
    '            rViewer.Report = r
    '            rViewer.TableName = "PURCHASEREGISTER"

    '            Dim textobj1 As TextObject
    '            textobj1 = r.ReportDefinition.ReportObjects("Text3")
    '            textobj1.Text = MyCompanyName

    '            Dim textobj2 As TextObject
    '            textobj2 = r.ReportDefinition.ReportObjects("Text13")
    '            textobj2.Text = Trim(txt_Mainstore.Text)

    '            Dim TXTOBJ3 As TextObject
    '            TXTOBJ3 = r.ReportDefinition.ReportObjects("Text17")
    '            TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""

    '            Dim textobj4 As TextObject
    '            textobj4 = r.ReportDefinition.ReportObjects("Text21")
    '            textobj4.Text = gUsername

    '            rViewer.Show()
    '        End If
    '        Me.Cursor = Cursors.Default
    '    Else
    '        MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
    '    End If
    'End Sub
    Public Sub Resize_Form()
        Dim cControl As Control
        Dim i_i As Integer
        Dim J, K, L, M, n, o, P, Q, R, S, T, U As Integer
        'If (Screen.PrimaryScreen.Bounds.Height = 768) And (Screen.PrimaryScreen.Bounds.Width = 1366) Then
        '    Exit Sub
        'End If
        J = 734
        K = 1034
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
                            'Else
                            '    L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            '    ' L = L - 5
                            'End If

                        ElseIf Controls(i_i).Name = "GroupBox4" Then
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
End Class
