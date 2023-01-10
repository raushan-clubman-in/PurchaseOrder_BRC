Imports System.Data.SqlClient
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO


Public Class DatewisePurchaseOrderRegister
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Chklist_DEPTLocation As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_Closure As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Chklist_VCODELocation As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkList_ITEMLocation As System.Windows.Forms.CheckedListBox
    Friend WithEvents Cmb_Closure As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_FromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmb_ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Chk_SelectAllDept As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_SelectAllVcode As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_SelectAllItem As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_validation As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatewisePurchaseOrderRegister))
        Me.Chk_SelectAllDept = New System.Windows.Forms.CheckBox()
        Me.Cmd_Clear = New System.Windows.Forms.Button()
        Me.Cmd_Print = New System.Windows.Forms.Button()
        Me.Cmd_Exit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cmb_FromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cmb_ToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cmd_View = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_validation = New System.Windows.Forms.Button()
        Me.Chklist_DEPTLocation = New System.Windows.Forms.CheckedListBox()
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox()
        Me.lbl_Wait = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Cmb_Closure = New System.Windows.Forms.ComboBox()
        Me.lbl_Closure = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chklist_VCODELocation = New System.Windows.Forms.CheckedListBox()
        Me.Chk_SelectAllVcode = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChkList_ITEMLocation = New System.Windows.Forms.CheckedListBox()
        Me.Chk_SelectAllItem = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Chk_SelectAllDept
        '
        Me.Chk_SelectAllDept.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllDept.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllDept.Location = New System.Drawing.Point(9, 6)
        Me.Chk_SelectAllDept.Name = "Chk_SelectAllDept"
        Me.Chk_SelectAllDept.Size = New System.Drawing.Size(144, 24)
        Me.Chk_SelectAllDept.TabIndex = 0
        Me.Chk_SelectAllDept.Text = "SELECT ALL "
        Me.Chk_SelectAllDept.UseVisualStyleBackColor = False
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Clear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Clear.Image = Global.SmartCard.My.Resources.Resources.Clear
        Me.Cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Clear.Location = New System.Drawing.Point(4, 41)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Clear.TabIndex = 4
        Me.Cmd_Clear.Text = "Clear[F6]"
        Me.Cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Clear.UseVisualStyleBackColor = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Print.Image = Global.SmartCard.My.Resources.Resources.print
        Me.Cmd_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Print.Location = New System.Drawing.Point(3, 190)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Print.TabIndex = 6
        Me.Cmd_Print.Text = " Print [F8]"
        Me.Cmd_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Print.UseVisualStyleBackColor = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Exit.Image = Global.SmartCard.My.Resources.Resources._Exit
        Me.Cmd_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Exit.Location = New System.Drawing.Point(3, 282)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Exit.TabIndex = 7
        Me.Cmd_Exit.Text = "Exit[F11]"
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Cmb_FromDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Cmb_ToDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(233, 581)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(597, 56)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Cmb_FromDate
        '
        Me.Cmb_FromDate.CustomFormat = "dd-MM-yyyy"
        Me.Cmb_FromDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cmb_FromDate.Location = New System.Drawing.Point(136, 16)
        Me.Cmb_FromDate.MaxDate = New Date(9998, 8, 14, 0, 0, 0, 0)
        Me.Cmb_FromDate.MinDate = New Date(2000, 8, 14, 0, 0, 0, 0)
        Me.Cmb_FromDate.Name = "Cmb_FromDate"
        Me.Cmb_FromDate.Size = New System.Drawing.Size(120, 21)
        Me.Cmb_FromDate.TabIndex = 0
        Me.Cmb_FromDate.Value = New Date(2008, 6, 19, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(316, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "TO DATE :"
        '
        'Cmb_ToDate
        '
        Me.Cmb_ToDate.CustomFormat = "dd-MM-yyyy"
        Me.Cmb_ToDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cmb_ToDate.Location = New System.Drawing.Point(404, 17)
        Me.Cmb_ToDate.MaxDate = New Date(9998, 8, 14, 0, 0, 0, 0)
        Me.Cmb_ToDate.MinDate = New Date(2000, 8, 14, 0, 0, 0, 0)
        Me.Cmb_ToDate.Name = "Cmb_ToDate"
        Me.Cmb_ToDate.Size = New System.Drawing.Size(112, 21)
        Me.Cmb_ToDate.TabIndex = 1
        Me.Cmb_ToDate.Value = New Date(2009, 6, 19, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FROM DATE :"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_View.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.Black
        Me.Cmd_View.Image = Global.SmartCard.My.Resources.Resources.view
        Me.Cmd_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_View.Location = New System.Drawing.Point(3, 117)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_View.TabIndex = 5
        Me.Cmd_View.Text = "View [F9]"
        Me.Cmd_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_View.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox4.Controls.Add(Me.Cmd_Print)
        Me.GroupBox4.Controls.Add(Me.Cmd_View)
        Me.GroupBox4.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox4.Location = New System.Drawing.Point(863, 144)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(142, 376)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        '
        'btn_validation
        '
        Me.btn_validation.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_validation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_validation.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_validation.ForeColor = System.Drawing.Color.White
        Me.btn_validation.Image = CType(resources.GetObject("btn_validation.Image"), System.Drawing.Image)
        Me.btn_validation.Location = New System.Drawing.Point(881, 570)
        Me.btn_validation.Name = "btn_validation"
        Me.btn_validation.Size = New System.Drawing.Size(104, 32)
        Me.btn_validation.TabIndex = 8
        Me.btn_validation.Text = "Validation"
        Me.btn_validation.UseVisualStyleBackColor = False
        Me.btn_validation.Visible = False
        '
        'Chklist_DEPTLocation
        '
        Me.Chklist_DEPTLocation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chklist_DEPTLocation.Location = New System.Drawing.Point(1, 54)
        Me.Chklist_DEPTLocation.Name = "Chklist_DEPTLocation"
        Me.Chklist_DEPTLocation.Size = New System.Drawing.Size(204, 349)
        Me.Chklist_DEPTLocation.TabIndex = 1
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackColor = System.Drawing.Color.Transparent
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label1)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(219, 580)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(621, 64)
        Me.grp_SalebillChecklist.TabIndex = 405
        Me.grp_SalebillChecklist.TabStop = False
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
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(601, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'Timer1
        '
        '
        'Cmb_Closure
        '
        Me.Cmb_Closure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Closure.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Closure.Items.AddRange(New Object() {"YES", "NO"})
        Me.Cmb_Closure.Location = New System.Drawing.Point(293, 533)
        Me.Cmb_Closure.Name = "Cmb_Closure"
        Me.Cmb_Closure.Size = New System.Drawing.Size(168, 23)
        Me.Cmb_Closure.TabIndex = 2
        '
        'lbl_Closure
        '
        Me.lbl_Closure.AutoSize = True
        Me.lbl_Closure.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Closure.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Closure.Location = New System.Drawing.Point(196, 538)
        Me.lbl_Closure.Name = "lbl_Closure"
        Me.lbl_Closure.Size = New System.Drawing.Size(68, 15)
        Me.lbl_Closure.TabIndex = 10
        Me.lbl_Closure.Text = "CLOSURE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 705)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(424, 16)
        Me.Label5.TabIndex = 416
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        Me.Label5.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Chocolate
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 24)
        Me.Label2.TabIndex = 420
        Me.Label2.Text = "DEPT LOCATION :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Chocolate
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(209, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 24)
        Me.Label3.TabIndex = 423
        Me.Label3.Text = "VENDOR CODE :"
        '
        'Chklist_VCODELocation
        '
        Me.Chklist_VCODELocation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chklist_VCODELocation.Location = New System.Drawing.Point(209, 54)
        Me.Chklist_VCODELocation.Name = "Chklist_VCODELocation"
        Me.Chklist_VCODELocation.Size = New System.Drawing.Size(223, 349)
        Me.Chklist_VCODELocation.TabIndex = 422
        '
        'Chk_SelectAllVcode
        '
        Me.Chk_SelectAllVcode.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllVcode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllVcode.Location = New System.Drawing.Point(209, 6)
        Me.Chk_SelectAllVcode.Name = "Chk_SelectAllVcode"
        Me.Chk_SelectAllVcode.Size = New System.Drawing.Size(107, 24)
        Me.Chk_SelectAllVcode.TabIndex = 421
        Me.Chk_SelectAllVcode.Text = "SELECT ALL "
        Me.Chk_SelectAllVcode.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Chocolate
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(616, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 24)
        Me.Label4.TabIndex = 426
        Me.Label4.Text = "ITEM CODE :"
        '
        'ChkList_ITEMLocation
        '
        Me.ChkList_ITEMLocation.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkList_ITEMLocation.Location = New System.Drawing.Point(439, 57)
        Me.ChkList_ITEMLocation.Name = "ChkList_ITEMLocation"
        Me.ChkList_ITEMLocation.Size = New System.Drawing.Size(237, 349)
        Me.ChkList_ITEMLocation.TabIndex = 425
        '
        'Chk_SelectAllItem
        '
        Me.Chk_SelectAllItem.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllItem.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllItem.Location = New System.Drawing.Point(436, 6)
        Me.Chk_SelectAllItem.Name = "Chk_SelectAllItem"
        Me.Chk_SelectAllItem.Size = New System.Drawing.Size(120, 24)
        Me.Chk_SelectAllItem.TabIndex = 424
        Me.Chk_SelectAllItem.Text = "SELECT ALL "
        Me.Chk_SelectAllItem.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(197, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(172, 15)
        Me.Label8.TabIndex = 427
        Me.Label8.Text = "PURCHASE ORDER REGISTER"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Chk_SelectAllItem)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Chklist_VCODELocation)
        Me.GroupBox1.Controls.Add(Me.Chk_SelectAllVcode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ChkList_ITEMLocation)
        Me.GroupBox1.Controls.Add(Me.Chklist_DEPTLocation)
        Me.GroupBox1.Controls.Add(Me.Chk_SelectAllDept)
        Me.GroupBox1.Location = New System.Drawing.Point(180, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 422)
        Me.GroupBox1.TabIndex = 428
        Me.GroupBox1.TabStop = False
        '
        'DatewisePurchaseOrderRegister
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackgroundImage = Global.SmartCard.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.btn_validation)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_Closure)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Cmb_Closure)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "DatewisePurchaseOrderRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DATEWISE PURCHASE ORDER REGISTER"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.grp_SalebillChecklist.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim sqlstring As String
    Dim chkbool As Boolean
    Dim gconnection As New GlobalClass
    Dim vconn As New GlobalClass

    Private Sub Reportsform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Resize_Form()
        Call Filldeptname()
        Call FillVendorname()
        Call FillItemname()
        Cmb_FromDate.Value = Format(Now, "dd/MM/yyyy")
        Cmb_ToDate.Value = Format(Now, "dd/MM/yyyy")

        grp_SalebillChecklist.Top = 1000

        Cmb_Closure.SelectedIndex = 1
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
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


    ''''*****************************  To fill Dept Details from STOREMASTER  **************************'''
    Private Sub Filldeptname()
        Dim i As Integer
        Chklist_DEPTLocation.Items.Clear()
        sqlstring = "SELECT DISTINCT ISNULL(STORECODE,'') AS STORECODE,ISNULL(STOREDESC,'') AS STOREDESC  FROM STOREMASTER ORDER BY STORECODE"
        gconnection.getDataSet(sqlstring, "STOREMASTER")
        If gdataset.Tables("STOREMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("STOREMASTER").Rows.Count - 1
                With gdataset.Tables("STOREMASTER").Rows(i)
                    Chklist_DEPTLocation.Items.Add(Trim(.Item("STORECODE")) & "-->" & Trim(.Item("STOREDESC")))
                End With
            Next i
        End If
        Chklist_DEPTLocation.Sorted = True
    End Sub
    Private Sub FillVendorname()
        Dim i As Integer
        Chklist_VCODELocation.Items.Clear()
        'sqlstring = "SELECT DISTINCT ISNULL(SLCODE,'') AS SLCODE,ISNULL(SLNAME,'') AS SLNAME  FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & gCreditors & "' ORDER BY SLCODE"
        sqlstring = "SELECT ISNULL(VENDORCODE,'') AS VENDORCODE, ISNULL(VENDORNAME,'') AS VENDORNAME FROM PO_VIEW_VENDORMASTER"
        gconnection.getDataSet(sqlstring, "ACCOUNTSSUBLEDGERMASTER")
        If gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows.Count - 1
                With gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(i)
                    Chklist_VCODELocation.Items.Add(Trim(.Item("VENDORCODE")) & " -->" & Trim(.Item("VENDORNAME")))
                End With
            Next i
        End If
        Chklist_VCODELocation.Sorted = True
    End Sub
    Private Sub FillItemname()
        Dim i As Integer
        ChkList_ITEMLocation.Items.Clear()
        'sqlstring = "SELECT DISTINCT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME  FROM INVENTORYITEMMASTER ORDER BY ITEMCODE"
        sqlstring = "SELECT DISTINCT ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME,ISNULL(STOCKUOM,'') AS STOCKUOM,ISNULL(PURCHASERATE,0) AS PURCHASERATE FROM PO_VIEW_ITEMMASTER"
        gconnection.getDataSet(sqlstring, "INVENTORYITEMMASTER")
        If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("INVENTORYITEMMASTER").Rows.Count - 1
                With gdataset.Tables("INVENTORYITEMMASTER").Rows(i)
                    ChkList_ITEMLocation.Items.Add(Trim(.Item("ITEMcode")) & "-->" & Trim(.Item("ITEMNAME")))
                End With
            Next i
        End If
        ChkList_ITEMLocation.Sorted = True
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Dim i
        For i = 0 To Chklist_DEPTLocation.Items.Count - 1
            Chklist_DEPTLocation.SetItemChecked(i, False)
        Next i
        For i = 0 To Chklist_VCODELocation.Items.Count - 1
            Chklist_VCODELocation.SetItemChecked(i, False)
        Next i
        For i = 0 To ChkList_ITEMLocation.Items.Count - 1
            ChkList_ITEMLocation.SetItemChecked(i, False)
        Next i
        Chk_SelectAllDept.Checked = False
        Chk_SelectAllVcode.Checked = False
        Chk_SelectAllItem.Checked = False
        Cmb_Closure.SelectedIndex = -1
        Cmb_FromDate.Text = ""
        Cmb_ToDate.Text = ""
        Chklist_DEPTLocation.Focus()
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        If Chklist_DEPTLocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Department(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Chklist_VCODELocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the VendorCode(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ChkList_ITEMLocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the ItemCode(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Checkdaterangevalidate(Cmb_FromDate.Value, Cmb_ToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = False

        grp_SalebillChecklist.Top = 581
        grp_SalebillChecklist.Left = 219

        Me.ProgressBar1.Value = 2
        Me.ProgressBar1.Visible = True
        Me.Timer1.Interval = 25
        Me.Timer1.Enabled = True
    End Sub
    Private Sub Cmd_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Chk_SelectAllDept_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllDept.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllDept.Checked = True Then
            For i = 0 To Chklist_DEPTLocation.Items.Count - 1
                Chklist_DEPTLocation.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_DEPTLocation.Items.Count - 1
                Chklist_DEPTLocation.SetItemChecked(i, False)
            Next
        End If

    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        If Chklist_DEPTLocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Department Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If Chklist_VCODELocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the VendorCode Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If ChkList_ITEMLocation.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Item Location(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Checkdaterangevalidate(Cmb_FromDate.Value, Cmb_ToDate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = True

        grp_SalebillChecklist.Top = 552
        grp_SalebillChecklist.Left = 136

        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 100
        Me.Timer1.Enabled = True
    End Sub
    Private Sub Viewdatewisesaleregister()
        Dim i As Integer
        Dim department(), vendor(), item() As String
        Try
            If MsgBox("VIEW CRYSTAL AMENDMENT REPORT?", MsgBoxStyle.YesNo, "View Amendment Report") = MsgBoxResult.No Then
                Dim sqlstring = "SELECT * FROM po_datewiserpt"

                sqlstring = sqlstring & " WHERE department IN ("
                'For i = 0 To Chklist_DEPTLocation.CheckedItems.Count - 1
                '    sqlstring = sqlstring & " '" & Chklist_DEPTLocation.CheckedItems(i) & "', "
                'Next
                'sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                'sqlstring = sqlstring & ")"
                For i = 0 To Chklist_DEPTLocation.CheckedItems.Count - 1
                    department = Split(Chklist_DEPTLocation.CheckedItems(i), "-->")
                    sqlstring = sqlstring & " '" & Trim(department(1)) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"

                sqlstring = sqlstring & " AND vendorname IN ("
                'For i = 0 To Chklist_VCODELocation.CheckedItems.Count - 1
                '    sqlstring = sqlstring & " '" & Chklist_VCODELocation.CheckedItems(i) & "', "
                'Next
                'sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                'sqlstring = sqlstring & ")"
                For i = 0 To Chklist_VCODELocation.CheckedItems.Count - 1
                    vendor = Split(Chklist_VCODELocation.CheckedItems(i), "-->")
                    sqlstring = sqlstring & " '" & Trim(vendor(1)) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"

                sqlstring = sqlstring & " AND ITEMcode IN ("
                'For i = 0 To ChkList_ITEMLocation.CheckedItems.Count - 1
                '    sqlstring = sqlstring & " '" & ChkList_ITEMLocation.CheckedItems(i) & "', "
                'Next
                'sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                'sqlstring = sqlstring & ")"
                For i = 0 To ChkList_ITEMLocation.CheckedItems.Count - 1
                    item = Split(ChkList_ITEMLocation.CheckedItems(i), "-->")
                    sqlstring = sqlstring & " '" & Trim(item(0)) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"

                sqlstring = sqlstring & " AND CAST(Convert(varchar(11),PODATE,6) AS DATETIME) BETWEEN "
                sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"
                'sqlstring = sqlstring & " AND ACCODE = '" & gCreditors & "' "

                If Cmb_Closure.Text = "YES" Then
                    sqlstring = sqlstring & " AND (SUBSTRING(CLOSURE,1,1)='C' OR SUBSTRING(CLOSURE,1,1)='' OR SUBSTRING(CLOSURE,1,1)='F')"
                Else
                    sqlstring = sqlstring & " AND SUBSTRING(CLOSURE,1,1)='N' "
                End If
                sqlstring = sqlstring & " ORDER BY DEPARTMENT,PODATE,PONO"
                Dim pageheading() As String = {"PURCHASE ORDER REGISTER DATEWISE"}
                Dim ObjDatewisesaleregisterdetails As New Datewisesaleregisterdetails
                ObjDatewisesaleregisterdetails.ReportsDetails(sqlstring, pageheading, Cmb_FromDate.Value, Cmb_ToDate.Value)
            Else
                '***********For crystal view
                Dim sqlstring = "SELECT * FROM po_datewiserpt"

                sqlstring = sqlstring & " WHERE department IN ("
                For i = 0 To Chklist_DEPTLocation.CheckedItems.Count - 1
                    department = Split(Chklist_DEPTLocation.CheckedItems(i), "-->")
                    sqlstring = sqlstring & " '" & Trim(department(1)) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"

                sqlstring = sqlstring & " AND vendorname IN ("
                For i = 0 To Chklist_VCODELocation.CheckedItems.Count - 1
                    vendor = Split(Chklist_VCODELocation.CheckedItems(i), "-->")
                    sqlstring = sqlstring & " '" & Trim(vendor(1)) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"

                sqlstring = sqlstring & " AND ITEMcode IN ("
                For i = 0 To ChkList_ITEMLocation.CheckedItems.Count - 1
                    item = Split(ChkList_ITEMLocation.CheckedItems(i), "-->")
                    sqlstring = sqlstring & " '" & Trim(item(0)) & "', "
                Next
                sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                sqlstring = sqlstring & ")"

                sqlstring = sqlstring & " AND CAST(Convert(varchar(11),PODATE,6) AS DATETIME) BETWEEN "
                sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"

                If Cmb_Closure.Text = "YES" Then
                    sqlstring = sqlstring & " AND (SUBSTRING(CLOSURE,1,1)='C' OR SUBSTRING(CLOSURE,1,1)='' OR SUBSTRING(CLOSURE,1,1)='F')"
                Else
                    sqlstring = sqlstring & " AND SUBSTRING(CLOSURE,1,1)='N' "
                End If
                sqlstring = sqlstring & " ORDER BY DEPARTMENT,PODATE,PONO"
                Dim r1 As New Cry_podatewisereport
                Dim rviewer As New Viewer
                gconnection.getDataSet(sqlstring, "po_datewiserpt")
                If gdataset.Tables("po_datewiserpt").Rows.Count > 0 Then
                    rviewer.ssql = sqlstring
                    rviewer.Report = r1
                    rviewer.TableName = "po_datewiserpt"

                    Dim textobj1 As TextObject
                    textobj1 = r1.ReportDefinition.ReportObjects("Text27")
                    textobj1.Text = MyCompanyName


                    Dim textobj2 As TextObject
                    textobj2 = r1.ReportDefinition.ReportObjects("Text34")
                    textobj2.Text = gUsername


                    Dim TXTOBJ3 As TextObject
                    TXTOBJ3 = r1.ReportDefinition.ReportObjects("Text35")
                    TXTOBJ3.Text = " From  " & Format(Cmb_FromDate.Value, "dd/MM/yyyy") & "  To " & " " & Format(Cmb_ToDate.Value, "dd/MM/yyyy") & ""

                    Dim textobj4 As TextObject
                    textobj4 = r1.ReportDefinition.ReportObjects("Text28")
                    textobj4.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode
                    Dim textobj5 As TextObject
                    textobj5 = r1.ReportDefinition.ReportObjects("Text29")
                    textobj5.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:" & gEmail & ", Web:" & gWebsite
                    Dim TEXTOBJ6 As TextObject
                    TEXTOBJ6 = r1.ReportDefinition.ReportObjects("Text30")
                    TEXTOBJ6.Text = "Service Tax:" & gServiceTax & " , Tin No.:" & gTinNo

                    rviewer.Refresh()
                    rviewer.Show()
                Else
                    MessageBox.Show("NO RECORDS TO DISPLAY")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0

            Me.grp_SalebillChecklist.Top = 1000
            Call Viewdatewisesaleregister()
        End If
    End Sub

    Private Sub Chk_SelectAlldept_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_SelectAllDept.KeyDown
        If e.KeyCode = Keys.Enter Then
            Chklist_DEPTLocation.Focus()
        End If
    End Sub

    Private Sub DatewisePurchaseOrderRegister_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Integer
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F2 Then
            For i = 0 To Chklist_DEPTLocation.Items.Count - 1
                Chklist_DEPTLocation.SetItemChecked(i, True)
            Next i
            For i = 0 To Chklist_VCODELocation.Items.Count - 1
                Chklist_VCODELocation.SetItemChecked(i, True)
            Next i
            For i = 0 To ChkList_ITEMLocation.Items.Count - 1
                ChkList_ITEMLocation.SetItemChecked(i, True)
            Next i
            Chk_SelectAllDept.Checked = True
            Chk_SelectAllVcode.Checked = True
            Chk_SelectAllItem.Checked = True
            Me.Cmb_Closure.Focus()
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 And Cmd_Print.Enabled = True Then
            Call Cmd_Print_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 And Cmd_View.Enabled = True Then
            Call Cmd_View_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Then
            Call Cmd_exit_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.Escape Then
            Call Cmd_exit_Click(sender, e)
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.F Then
            Me.Cmb_FromDate.Focus()
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.T Then
            Me.Cmb_ToDate.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Cmb_FromDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_FromDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmb_ToDate.Focus()
        End If
    End Sub

    Private Sub Cmb_ToDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_ToDate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmd_View.Focus()
        End If
    End Sub

    Private Sub Chk_SelectAllVcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllVcode.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllVcode.Checked = True Then
            For i = 0 To Chklist_VCODELocation.Items.Count - 1
                Chklist_VCODELocation.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_VCODELocation.Items.Count - 1
                Chklist_VCODELocation.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub Chk_SelectAllVcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_SelectAllVcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Chklist_VCODELocation.Focus()
        End If
    End Sub

    Private Sub Chk_SelectAllItem_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_SelectAllItem.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllItem.Checked = True Then
            For i = 0 To ChkList_ITEMLocation.Items.Count - 1
                ChkList_ITEMLocation.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To ChkList_ITEMLocation.Items.Count - 1
                ChkList_ITEMLocation.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub Chk_SelectAllItem_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_SelectAllItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChkList_ITEMLocation.Focus()
        End If
    End Sub

    Private Sub Chklist_DEPTLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chklist_DEPTLocation.SelectedIndexChanged

    End Sub

    Private Sub Cmb_Closure_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Closure.SelectedIndexChanged

    End Sub

    Private Sub Cmb_Closure_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_Closure.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmb_FromDate.Focus()
        End If
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Chklist_VCODELocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chklist_VCODELocation.SelectedIndexChanged

    End Sub

    Private Sub btn_validation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validation.Click
        System.Diagnostics.Process.Start(AppPath & "\STUDY\PURCHASEORDERREGISTER.XLS")
    End Sub
    Public Sub Resize_Form()
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
End Class
