Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System.IO

Public Class rptAmendment
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grp_SalebillChecklist As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmb_FromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cmb_ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Cbo_Option As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_Dept As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Chklist_PONo As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chk_SelectAllVcode As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPenPO As System.Windows.Forms.RadioButton
    Friend WithEvents rbPenAuth As System.Windows.Forms.RadioButton
    Friend WithEvents rbPenItems As System.Windows.Forms.RadioButton
    Friend WithEvents rbPenGRN As System.Windows.Forms.RadioButton
    Friend WithEvents rbPO As System.Windows.Forms.RadioButton
    Friend WithEvents rbIndent As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPenItemsPOGRN As System.Windows.Forms.RadioButton
    Friend WithEvents rbpenPOGRN As System.Windows.Forms.RadioButton
    Friend WithEvents btn_validation As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rptAmendment))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox()
        Me.lbl_Wait = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cmb_FromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cmb_ToDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Cmd_Exit = New System.Windows.Forms.Button()
        Me.Cmd_Print = New System.Windows.Forms.Button()
        Me.Cmd_View = New System.Windows.Forms.Button()
        Me.Cmd_Clear = New System.Windows.Forms.Button()
        Me.btn_validation = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cbo_Option = New System.Windows.Forms.ComboBox()
        Me.Cbo_Dept = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Chklist_PONo = New System.Windows.Forms.CheckedListBox()
        Me.Chk_SelectAllVcode = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rbPenItems = New System.Windows.Forms.RadioButton()
        Me.rbPenGRN = New System.Windows.Forms.RadioButton()
        Me.rbPenPO = New System.Windows.Forms.RadioButton()
        Me.rbPenAuth = New System.Windows.Forms.RadioButton()
        Me.rbPO = New System.Windows.Forms.RadioButton()
        Me.rbIndent = New System.Windows.Forms.RadioButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.rbPenItemsPOGRN = New System.Windows.Forms.RadioButton()
        Me.rbpenPOGRN = New System.Windows.Forms.RadioButton()
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(223, 669)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(375, 18)
        Me.Label5.TabIndex = 435
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        Me.Label5.Visible = False
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label1)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(58, 1145)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(854, 73)
        Me.grp_SalebillChecklist.TabIndex = 434
        Me.grp_SalebillChecklist.TabStop = False
        '
        'lbl_Wait
        '
        Me.lbl_Wait.AutoSize = True
        Me.lbl_Wait.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wait.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Wait.Location = New System.Drawing.Point(432, 28)
        Me.lbl_Wait.Name = "lbl_Wait"
        Me.lbl_Wait.Size = New System.Drawing.Size(0, 19)
        Me.lbl_Wait.TabIndex = 387
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(346, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 0
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 18)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(835, 37)
        Me.ProgressBar1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Cmb_FromDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Cmb_ToDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(312, 549)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(662, 65)
        Me.GroupBox3.TabIndex = 430
        Me.GroupBox3.TabStop = False
        '
        'Cmb_FromDate
        '
        Me.Cmb_FromDate.CustomFormat = "dd-MM-yyyy"
        Me.Cmb_FromDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cmb_FromDate.Location = New System.Drawing.Point(149, 18)
        Me.Cmb_FromDate.MaxDate = New Date(9998, 8, 14, 0, 0, 0, 0)
        Me.Cmb_FromDate.MinDate = New Date(2000, 8, 14, 0, 0, 0, 0)
        Me.Cmb_FromDate.Name = "Cmb_FromDate"
        Me.Cmb_FromDate.Size = New System.Drawing.Size(144, 25)
        Me.Cmb_FromDate.TabIndex = 0
        Me.Cmb_FromDate.Value = New Date(2008, 6, 19, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(386, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "TO DATE :"
        '
        'Cmb_ToDate
        '
        Me.Cmb_ToDate.CustomFormat = "dd-MM-yyyy"
        Me.Cmb_ToDate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cmb_ToDate.Location = New System.Drawing.Point(497, 18)
        Me.Cmb_ToDate.MaxDate = New Date(9998, 8, 14, 0, 0, 0, 0)
        Me.Cmb_ToDate.MinDate = New Date(2000, 8, 14, 0, 0, 0, 0)
        Me.Cmb_ToDate.Name = "Cmb_ToDate"
        Me.Cmb_ToDate.Size = New System.Drawing.Size(134, 25)
        Me.Cmb_ToDate.TabIndex = 1
        Me.Cmb_ToDate.Value = New Date(2009, 6, 19, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FROM DATE :"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox4.Controls.Add(Me.Cmd_Print)
        Me.GroupBox4.Controls.Add(Me.Cmd_View)
        Me.GroupBox4.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox4.Location = New System.Drawing.Point(902, 129)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(179, 485)
        Me.GroupBox4.TabIndex = 433
        Me.GroupBox4.TabStop = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Exit.Image = Global.SmartCard.My.Resources.Resources._Exit
        Me.Cmd_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Exit.Location = New System.Drawing.Point(11, 369)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(161, 65)
        Me.Cmd_Exit.TabIndex = 7
        Me.Cmd_Exit.Text = "Exit[F11]"
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Print.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Print.Image = Global.SmartCard.My.Resources.Resources.print
        Me.Cmd_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Print.Location = New System.Drawing.Point(8, 256)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(161, 65)
        Me.Cmd_Print.TabIndex = 6
        Me.Cmd_Print.Text = " Print [F8]"
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
        Me.Cmd_View.Location = New System.Drawing.Point(10, 147)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(160, 64)
        Me.Cmd_View.TabIndex = 5
        Me.Cmd_View.Text = "View [F9]"
        Me.Cmd_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_View.UseVisualStyleBackColor = False
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Clear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Clear.Image = Global.SmartCard.My.Resources.Resources.Clear
        Me.Cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Clear.Location = New System.Drawing.Point(8, 44)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(161, 64)
        Me.Cmd_Clear.TabIndex = 4
        Me.Cmd_Clear.Text = "Clear[F6]"
        Me.Cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Clear.UseVisualStyleBackColor = False
        '
        'btn_validation
        '
        Me.btn_validation.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_validation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_validation.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_validation.ForeColor = System.Drawing.Color.White
        Me.btn_validation.Image = CType(resources.GetObject("btn_validation.Image"), System.Drawing.Image)
        Me.btn_validation.Location = New System.Drawing.Point(1055, 695)
        Me.btn_validation.Name = "btn_validation"
        Me.btn_validation.Size = New System.Drawing.Size(125, 37)
        Me.btn_validation.TabIndex = 8
        Me.btn_validation.Text = "Validation"
        Me.btn_validation.UseVisualStyleBackColor = False
        Me.btn_validation.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(228, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(369, 22)
        Me.Label8.TabIndex = 444
        Me.Label8.Text = "AMENDMENT / FOLLOW-UP REGISTER"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Cbo_Option)
        Me.GroupBox1.Controls.Add(Me.Cbo_Dept)
        Me.GroupBox1.Location = New System.Drawing.Point(226, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 182)
        Me.GroupBox1.TabIndex = 445
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 18)
        Me.Label4.TabIndex = 447
        Me.Label4.Text = "OPTIONS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 446
        Me.Label2.Text = "DEPARTMENT"
        '
        'Cbo_Option
        '
        Me.Cbo_Option.BackColor = System.Drawing.Color.Wheat
        Me.Cbo_Option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Option.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Option.Items.AddRange(New Object() {"AMENDMENT", "FOLLOW-UP"})
        Me.Cbo_Option.Location = New System.Drawing.Point(22, 135)
        Me.Cbo_Option.Name = "Cbo_Option"
        Me.Cbo_Option.Size = New System.Drawing.Size(297, 26)
        Me.Cbo_Option.TabIndex = 445
        '
        'Cbo_Dept
        '
        Me.Cbo_Dept.BackColor = System.Drawing.Color.Wheat
        Me.Cbo_Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Dept.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Dept.Items.AddRange(New Object() {"DEPOSIT", "TRANSFER", "REFUND"})
        Me.Cbo_Dept.Location = New System.Drawing.Point(22, 62)
        Me.Cbo_Dept.Name = "Cbo_Dept"
        Me.Cbo_Dept.Size = New System.Drawing.Size(297, 26)
        Me.Cbo_Dept.TabIndex = 444
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Chklist_PONo)
        Me.GroupBox2.Controls.Add(Me.Chk_SelectAllVcode)
        Me.GroupBox2.Location = New System.Drawing.Point(584, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 376)
        Me.GroupBox2.TabIndex = 446
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Chocolate
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(294, 28)
        Me.Label3.TabIndex = 442
        Me.Label3.Text = "P.O. NUMBER :"
        '
        'Chklist_PONo
        '
        Me.Chklist_PONo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chklist_PONo.Location = New System.Drawing.Point(18, 75)
        Me.Chklist_PONo.Name = "Chklist_PONo"
        Me.Chklist_PONo.Size = New System.Drawing.Size(294, 264)
        Me.Chklist_PONo.TabIndex = 441
        '
        'Chk_SelectAllVcode
        '
        Me.Chk_SelectAllVcode.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllVcode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllVcode.Location = New System.Drawing.Point(18, 20)
        Me.Chk_SelectAllVcode.Name = "Chk_SelectAllVcode"
        Me.Chk_SelectAllVcode.Size = New System.Drawing.Size(173, 27)
        Me.Chk_SelectAllVcode.TabIndex = 440
        Me.Chk_SelectAllVcode.Text = "SELECT ALL "
        Me.Chk_SelectAllVcode.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(226, 339)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(327, 169)
        Me.GroupBox5.TabIndex = 448
        Me.GroupBox5.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox6.Controls.Add(Me.rbPenItems)
        Me.GroupBox6.Controls.Add(Me.rbPenGRN)
        Me.GroupBox6.Controls.Add(Me.rbPenPO)
        Me.GroupBox6.Controls.Add(Me.rbPenAuth)
        Me.GroupBox6.Location = New System.Drawing.Point(0, 16)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(328, 152)
        Me.GroupBox6.TabIndex = 448
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Visible = False
        '
        'rbPenItems
        '
        Me.rbPenItems.AutoSize = True
        Me.rbPenItems.Location = New System.Drawing.Point(16, 85)
        Me.rbPenItems.Name = "rbPenItems"
        Me.rbPenItems.Size = New System.Drawing.Size(273, 22)
        Me.rbPenItems.TabIndex = 3
        Me.rbPenItems.Text = "PENDING ITEMS INDENT Vs. GRN"
        Me.rbPenItems.UseVisualStyleBackColor = True
        '
        'rbPenGRN
        '
        Me.rbPenGRN.AutoSize = True
        Me.rbPenGRN.Location = New System.Drawing.Point(16, 66)
        Me.rbPenGRN.Name = "rbPenGRN"
        Me.rbPenGRN.Size = New System.Drawing.Size(233, 22)
        Me.rbPenGRN.TabIndex = 2
        Me.rbPenGRN.Text = "INDENT PENDING FOR GRN"
        Me.rbPenGRN.UseVisualStyleBackColor = True
        '
        'rbPenPO
        '
        Me.rbPenPO.AutoSize = True
        Me.rbPenPO.Location = New System.Drawing.Point(16, 45)
        Me.rbPenPO.Name = "rbPenPO"
        Me.rbPenPO.Size = New System.Drawing.Size(221, 22)
        Me.rbPenPO.TabIndex = 1
        Me.rbPenPO.Text = "INDENT PENDING FOR PO"
        Me.rbPenPO.UseVisualStyleBackColor = True
        '
        'rbPenAuth
        '
        Me.rbPenAuth.AutoSize = True
        Me.rbPenAuth.Checked = True
        Me.rbPenAuth.Location = New System.Drawing.Point(16, 23)
        Me.rbPenAuth.Name = "rbPenAuth"
        Me.rbPenAuth.Size = New System.Drawing.Size(323, 22)
        Me.rbPenAuth.TabIndex = 0
        Me.rbPenAuth.TabStop = True
        Me.rbPenAuth.Text = "INDENT PENDING FOR AUTHORIGATION"
        Me.rbPenAuth.UseVisualStyleBackColor = True
        '
        'rbPO
        '
        Me.rbPO.AutoSize = True
        Me.rbPO.Checked = True
        Me.rbPO.Location = New System.Drawing.Point(22, 21)
        Me.rbPO.Name = "rbPO"
        Me.rbPO.Size = New System.Drawing.Size(171, 22)
        Me.rbPO.TabIndex = 449
        Me.rbPO.TabStop = True
        Me.rbPO.Text = "PURCHASE ORDER"
        Me.rbPO.UseVisualStyleBackColor = True
        '
        'rbIndent
        '
        Me.rbIndent.AutoSize = True
        Me.rbIndent.Location = New System.Drawing.Point(200, 18)
        Me.rbIndent.Name = "rbIndent"
        Me.rbIndent.Size = New System.Drawing.Size(86, 22)
        Me.rbIndent.TabIndex = 450
        Me.rbIndent.Text = "INDENT"
        Me.rbIndent.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rbPO)
        Me.GroupBox7.Controls.Add(Me.rbIndent)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(226, 315)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(327, 50)
        Me.GroupBox7.TabIndex = 451
        Me.GroupBox7.TabStop = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.rbPenItemsPOGRN)
        Me.GroupBox8.Controls.Add(Me.rbpenPOGRN)
        Me.GroupBox8.Location = New System.Drawing.Point(224, 359)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(329, 149)
        Me.GroupBox8.TabIndex = 452
        Me.GroupBox8.TabStop = False
        '
        'rbPenItemsPOGRN
        '
        Me.rbPenItemsPOGRN.AutoSize = True
        Me.rbPenItemsPOGRN.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPenItemsPOGRN.Location = New System.Drawing.Point(23, 48)
        Me.rbPenItemsPOGRN.Name = "rbPenItemsPOGRN"
        Me.rbPenItemsPOGRN.Size = New System.Drawing.Size(238, 22)
        Me.rbPenItemsPOGRN.TabIndex = 1
        Me.rbPenItemsPOGRN.TabStop = True
        Me.rbPenItemsPOGRN.Text = "PENDING ITEMS PO Vs. GRN"
        Me.rbPenItemsPOGRN.UseVisualStyleBackColor = True
        '
        'rbpenPOGRN
        '
        Me.rbpenPOGRN.AutoSize = True
        Me.rbpenPOGRN.Checked = True
        Me.rbpenPOGRN.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbpenPOGRN.Location = New System.Drawing.Point(23, 23)
        Me.rbpenPOGRN.Name = "rbpenPOGRN"
        Me.rbpenPOGRN.Size = New System.Drawing.Size(198, 22)
        Me.rbpenPOGRN.TabIndex = 0
        Me.rbpenPOGRN.TabStop = True
        Me.rbpenPOGRN.Text = "PO PENDING FOR GRN"
        Me.rbpenPOGRN.UseVisualStyleBackColor = True
        '
        'rptAmendment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackgroundImage = Global.SmartCard.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1149, 730)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_validation)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "rptAmendment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMENDMENT / FOLLOW-UP REPORT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.grp_SalebillChecklist.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim sqlstring As String
    Dim gconnection As New GlobalClass
    Dim DEPT() As String
    Private Sub rptAmendment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Resize_Form()
        Call FillStore()
        'grp_SalebillChecklist.Top = 1000
        Cmb_FromDate.Value = Format(Now, "dd/MM/yyyy")
        Cmb_ToDate.Value = Format(Now, "dd/MM/yyyy")
        Cbo_Option.SelectedIndex = 0
        Cbo_Dept.SelectedIndex = -1
        Cbo_Dept.Focus()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub FillStore()
        Dim i As Integer
        sqlstring = ""
        sqlstring = "SELECT storecode,storedesc FROM STOREMASTER WHERE STORESTATUS='M'"
        gconnection.getDataSet(sqlstring, "STOREMASTER")
        Cbo_Dept.Items.Clear()
        If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("STOREMASTER").Rows.Count - 1
                Dim temptype As String
                Cbo_Dept.Items.Add(gdataset.Tables("STOREMASTER").Rows(i).Item("storecode") & "-->" & gdataset.Tables("STOREMASTER").Rows(i).Item("storedesc"))
            Next i
            Cbo_Dept.SelectedIndex = -1
        End If
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0
            Me.grp_SalebillChecklist.Top = 1000
            Call ViewAMENDMENTregister()
        End If
    End Sub
    Private Sub ViewAMENDMENTregister()
        Dim i As Integer
        Dim rViewer As New Viewer
        Dim sqlstring = " "
        Try
            ' If MsgBox("VIEW CRYSTAL AMENDMENT REPORT?", MsgBoxStyle.YesNo, "View Amendment Report") = MsgBoxResult.No Then
            sqlstring = " "
            ' If rbPO.Checked = True Then
            '    If Cbo_Option.SelectedIndex = 0 Then
            '        sqlstring = "SELECT * FROM PO_VW_AMENDEMNTREPORT "
            '    ElseIf Cbo_Option.SelectedIndex = 1 Then
            '        sqlstring = "SELECT * FROM PO_VW_FOLLOWUP "
            '    End If
            '    sqlstring = sqlstring & " WHERE PONO IN ("
            '    For i = 0 To Chklist_PONo.CheckedItems.Count - 1
            '        sqlstring = sqlstring & " '" & Chklist_PONo.CheckedItems(i) & "', "
            '    Next
            '    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            '    sqlstring = sqlstring & ")"


            '    sqlstring = sqlstring & " AND CAST(Convert(varchar(11),PODATE,6) AS DATETIME) BETWEEN "

            '    sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"

            '    sqlstring = sqlstring & " ORDER BY PONO,PODATE"
            '    Dim pageheading() As String = {"AMENDMENT / FOLLOW-UP REGISTER"}
            '    Dim ObjrptViewAmendmentReport As New rptViewAmendmentReport
            '    ObjrptViewAmendmentReport.ReportsDetails(sqlstring, pageheading, Cmb_FromDate.Value, Cmb_ToDate.Value)
            'Else

            '    Dim r As New Cry_amendmentreport
            '    Dim R1 As New Cry_amendmentreport1

            '    If Cbo_Option.SelectedIndex = 0 Then
            '        sqlstring = "SELECT * FROM PO_VW_AMENDEMNTREPORT "
            '        sqlstring = sqlstring & " WHERE PONO IN ("
            '        For i = 0 To Chklist_PONo.CheckedItems.Count - 1
            '            sqlstring = sqlstring & " '" & Chklist_PONo.CheckedItems(i) & "', "
            '        Next
            '        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            '        sqlstring = sqlstring & ")"


            '        sqlstring = sqlstring & " AND CAST(Convert(varchar(11),PODATE,6) AS DATETIME) BETWEEN "

            '        sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"

            '        sqlstring = sqlstring & " ORDER BY PONO,PODATE"
            '        gconnection.getDataSet(sqlstring, "PO_VW_AMENDEMNTREPORT")
            '        If gdataset.Tables("PO_VW_AMENDEMNTREPORT").Rows.Count > 0 Then
            '            rViewer.ssql = sqlstring
            '            rViewer.Report = r
            '            rViewer.TableName = "PO_VW_AMENDEMNTREPORT"

            '            Dim textobj1 As TextObject
            '            textobj1 = r.ReportDefinition.ReportObjects("Text6")
            '            textobj1.Text = MyCompanyName


            '            Dim textobj2 As TextObject
            '            textobj2 = r.ReportDefinition.ReportObjects("Text21")
            '            textobj2.Text = gUsername


            '            Dim TXTOBJ3 As TextObject
            '            TXTOBJ3 = r.ReportDefinition.ReportObjects("Text11")
            '            TXTOBJ3.Text = " From  " & Format(Cmb_FromDate.Value, "dd/MM/yyyy") & "  To " & " " & Format(Cmb_ToDate.Value, "dd/MM/yyyy") & ""

            '            Dim textobj4 As TextObject
            '            textobj4 = r.ReportDefinition.ReportObjects("Text7")
            '            textobj4.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode
            '            Dim textobj5 As TextObject
            '            textobj5 = r.ReportDefinition.ReportObjects("Text8")
            '            textobj5.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:" & gEmail & ", Web:" & gWebsite
            '            Dim TEXTOBJ6 As TextObject
            '            TEXTOBJ6 = r.ReportDefinition.ReportObjects("Text9")
            '            TEXTOBJ6.Text = "Service Tax:" & gServiceTax & " , Tin No.:" & gTinNo

            '            rViewer.Refresh()
            '            rViewer.Show()

            '            'Else
            '            '    MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
            '        End If
            '    ElseIf Cbo_Option.SelectedIndex = 1 Then
            '        sqlstring = "SELECT * FROM PO_VW_FOLLOWUP "
            '        sqlstring = sqlstring & " WHERE PONO IN ("
            '        For i = 0 To Chklist_PONo.CheckedItems.Count - 1
            '            sqlstring = sqlstring & " '" & Chklist_PONo.CheckedItems(i) & "', "
            '        Next
            '        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            '        sqlstring = sqlstring & ")"


            '        sqlstring = sqlstring & " AND CAST(Convert(varchar(11),PODATE,6) AS DATETIME) BETWEEN "

            '        sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"

            '        sqlstring = sqlstring & " ORDER BY PONO,PODATE"
            '        gconnection.getDataSet(sqlstring, "PO_VW_FOLLOWUP")
            '        If gdataset.Tables("PO_VW_FOLLOWUP").Rows.Count > 0 Then
            '            rViewer.ssql = sqlstring
            '            rViewer.Report = R1
            '            rViewer.TableName = "PO_VW_FOLLOWUP"

            '            Dim textobj1 As TextObject
            '            textobj1 = R1.ReportDefinition.ReportObjects("Text6")
            '            textobj1.Text = MyCompanyName


            '            Dim textobj2 As TextObject
            '            textobj2 = R1.ReportDefinition.ReportObjects("Text21")
            '            textobj2.Text = gUsername


            '            Dim TXTOBJ3 As TextObject
            '            TXTOBJ3 = R1.ReportDefinition.ReportObjects("Text11")
            '            TXTOBJ3.Text = " From  " & Format(Cmb_FromDate.Value, "dd/MM/yyyy") & "  To " & " " & Format(Cmb_ToDate.Value, "dd/MM/yyyy") & ""

            '            Dim textobj4 As TextObject
            '            textobj4 = R1.ReportDefinition.ReportObjects("Text7")
            '            textobj4.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode
            '            Dim textobj5 As TextObject
            '            textobj5 = R1.ReportDefinition.ReportObjects("Text8")
            '            textobj5.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:" & gEmail & ", Web:" & gWebsite
            '            Dim TEXTOBJ6 As TextObject
            '            TEXTOBJ6 = R1.ReportDefinition.ReportObjects("Text9")
            '            TEXTOBJ6.Text = "Service Tax:" & gServiceTax & " , Tin No.:" & gTinNo

            '            rViewer.Refresh()
            '            rViewer.Show()

            '        Else
            '            MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
            '        End If
            '    End If
            If rbPO.Checked = True Then
                If rbpenPOGRN.Checked = True Then
                    Dim SViewer As New Viewer
                    Dim S As New Rpt_Pending_Purchase
                    sqlstring = " SELECT pono,podate,podepartment,povendorcode,itemcode,ITEMNAME,quantity,rate,amount,vatamt,discamt, VENDORNAME"
                    sqlstring = sqlstring & " from INV_PENDING_PURCHASE WHERE pono IN( "
                    For i = 0 To Chklist_PONo.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & Chklist_PONo.CheckedItems(i) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                    sqlstring = sqlstring & " AND CAST(Convert(varchar(11),podate,6) AS DATETIME) BETWEEN "
                    sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"

                    sqlstring = sqlstring & " order by podate, Itemname "

                    gconnection.getDataSet(sqlstring, "INV_PENDING_PURCHASE")
                    If gdataset.Tables("INV_PENDING_PURCHASE").Rows.Count > 0 Then
                        SViewer.ssql = sqlstring
                        SViewer.Report = S
                        SViewer.TableName = "INV_PENDING_PURCHASE"

                        Dim textobj1 As TextObject
                        textobj1 = S.ReportDefinition.ReportObjects("Text3")
                        textobj1.Text = MyCompanyName
                        Dim TXTOBJ2 As TextObject
                        TXTOBJ2 = S.ReportDefinition.ReportObjects("Text21")
                        TXTOBJ2.Text = gUsername
                        Dim TXTOBJ3 As TextObject
                        TXTOBJ3 = S.ReportDefinition.ReportObjects("Text17")
                        TXTOBJ3.Text = " From  " & Format(Cmb_FromDate.Value, "dd/MM/yyyy") & "  To " & " " & Format(Cmb_ToDate.Value, "dd/MM/yyyy") & ""

                        Dim textobj7 As TextObject
                        textobj7 = S.ReportDefinition.ReportObjects("Text2")
                        textobj7.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode
                        Dim textobj5 As TextObject
                        textobj5 = S.ReportDefinition.ReportObjects("Text4")
                        textobj5.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:pur@kga.in" & ", Web:" & gWebsite
                        Dim TEXTOBJ6 As TextObject
                        TEXTOBJ6 = S.ReportDefinition.ReportObjects("Text7")
                        TEXTOBJ6.Text = "Service Tax:" & gServiceTax & " , Tin No.:" & gTinNo
                        SViewer.Refresh()
                        SViewer.Show()

                    Else
                        MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
                    End If
                Else
                    Dim r2 As New Cry_PENDITEMSPOVsGRN
                    sqlstring = "SELECT * FROM Vw_POGRNITEMS_pending "
                    sqlstring = sqlstring & " WHERE pendingqty<>0 and  pono IN ("
                    For i = 0 To Chklist_PONo.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & Chklist_PONo.CheckedItems(i) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"


                    'sqlstring = sqlstring & " AND CAST(Convert(varchar(11),INDENT_DATE,6) AS DATETIME) BETWEEN "

                    'sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"

                    'sqlstring = sqlstring & " ORDER BY PONO,PODATE"
                    gconnection.getDataSet(sqlstring, "Vw_POGRNITEMS_pending")
                    If gdataset.Tables("Vw_POGRNITEMS_pending").Rows.Count > 0 Then
                        rViewer.ssql = sqlstring
                        rViewer.Report = r2
                        rViewer.TableName = "Vw_POGRNITEMS_pending"

                        Dim textobj1 As TextObject
                        textobj1 = r2.ReportDefinition.ReportObjects("Text14")
                        textobj1.Text = MyCompanyName


                        Dim textobj2 As TextObject
                        textobj2 = r2.ReportDefinition.ReportObjects("Text32")
                        textobj2.Text = gUsername


                        Dim TXTOBJ3 As TextObject
                        TXTOBJ3 = r2.ReportDefinition.ReportObjects("Text12")
                        TXTOBJ3.Text = " From  " & Format(Cmb_FromDate.Value, "dd/MM/yyyy") & "  To " & " " & Format(Cmb_ToDate.Value, "dd/MM/yyyy") & ""

                        Dim textobj4 As TextObject
                        textobj4 = r2.ReportDefinition.ReportObjects("Text15")
                        textobj4.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode
                        Dim textobj5 As TextObject
                        textobj5 = r2.ReportDefinition.ReportObjects("Text16")
                        textobj5.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:" & gEmail & ", Web:" & gWebsite
                        Dim TEXTOBJ6 As TextObject
                        TEXTOBJ6 = r2.ReportDefinition.ReportObjects("Text17")
                        TEXTOBJ6.Text = "Service Tax:" & gServiceTax & " , Tin No.:" & gTinNo

                        rViewer.Refresh()
                        rViewer.Show()

                    Else
                        MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
                    End If
                End If
            End If
            
            If rbIndent.Checked = True Then
                If rbPenAuth.Checked = True Or rbPenPO.Checked = True Then
                    Dim r2 As New Cry_PENDINGINDENT
                    sqlstring = "SELECT * FROM Vw_pending_auth "
                    sqlstring = sqlstring & " WHERE  INDENT_NO IN ("
                    For i = 0 To Chklist_PONo.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & Chklist_PONo.CheckedItems(i) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"


                    sqlstring = sqlstring & " AND CAST(Convert(varchar(11),INDENT_DATE,6) AS DATETIME) BETWEEN "

                    sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"

                    'sqlstring = sqlstring & " ORDER BY PONO,PODATE"
                    gconnection.getDataSet(sqlstring, "Vw_pending_auth")
                    If gdataset.Tables("Vw_pending_auth").Rows.Count > 0 Then
                        rViewer.ssql = sqlstring
                        rViewer.Report = r2
                        rViewer.TableName = "Vw_pending_auth"

                        Dim textobj1 As TextObject
                        textobj1 = r2.ReportDefinition.ReportObjects("Text6")
                        textobj1.Text = MyCompanyName


                        Dim textobj2 As TextObject
                        textobj2 = r2.ReportDefinition.ReportObjects("Text21")
                        textobj2.Text = gUsername


                        Dim TXTOBJ3 As TextObject
                        TXTOBJ3 = r2.ReportDefinition.ReportObjects("Text11")
                        TXTOBJ3.Text = " From  " & Format(Cmb_FromDate.Value, "dd/MM/yyyy") & "  To " & " " & Format(Cmb_ToDate.Value, "dd/MM/yyyy") & ""

                        Dim textobj4 As TextObject
                        textobj4 = r2.ReportDefinition.ReportObjects("Text7")
                        textobj4.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode
                        Dim textobj5 As TextObject
                        textobj5 = r2.ReportDefinition.ReportObjects("Text8")
                        textobj5.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:" & gEmail & ", Web:" & gWebsite
                        Dim TEXTOBJ6 As TextObject
                        TEXTOBJ6 = r2.ReportDefinition.ReportObjects("Text9")
                        TEXTOBJ6.Text = "Service Tax:" & gServiceTax & " , Tin No.:" & gTinNo

                        rViewer.Refresh()
                        rViewer.Show()

                    Else
                        MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
                    End If
                ElseIf rbPenGRN.Checked = True Then
                    Dim r2 As New Cry_PENDINGINDENT
                    sqlstring = "SELECT * FROM Vw_pending_auth "
                    sqlstring = sqlstring & " WHERE INDENT_NO IN ("
                    For i = 0 To Chklist_PONo.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & Chklist_PONo.CheckedItems(i) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"


                    sqlstring = sqlstring & " AND CAST(Convert(varchar(11),INDENT_DATE,6) AS DATETIME) BETWEEN "

                    sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"

                    'sqlstring = sqlstring & " ORDER BY PONO,PODATE"
                    gconnection.getDataSet(sqlstring, "Vw_pending_auth")
                    If gdataset.Tables("Vw_pending_auth").Rows.Count > 0 Then
                        rViewer.ssql = sqlstring
                        rViewer.Report = r2
                        rViewer.TableName = "Vw_pending_auth"

                        Dim textobj1 As TextObject
                        textobj1 = r2.ReportDefinition.ReportObjects("Text6")
                        textobj1.Text = MyCompanyName


                        Dim textobj2 As TextObject
                        textobj2 = r2.ReportDefinition.ReportObjects("Text21")
                        textobj2.Text = gUsername


                        Dim TXTOBJ3 As TextObject
                        TXTOBJ3 = r2.ReportDefinition.ReportObjects("Text11")
                        TXTOBJ3.Text = " From  " & Format(Cmb_FromDate.Value, "dd/MM/yyyy") & "  To " & " " & Format(Cmb_ToDate.Value, "dd/MM/yyyy") & ""

                        Dim textobj4 As TextObject
                        textobj4 = r2.ReportDefinition.ReportObjects("Text7")
                        textobj4.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode
                        Dim textobj5 As TextObject
                        textobj5 = r2.ReportDefinition.ReportObjects("Text8")
                        textobj5.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:" & gEmail & ", Web:" & gWebsite
                        Dim TEXTOBJ6 As TextObject
                        TEXTOBJ6 = r2.ReportDefinition.ReportObjects("Text9")
                        TEXTOBJ6.Text = "Service Tax:" & gServiceTax & " , Tin No.:" & gTinNo

                        rViewer.Refresh()
                        rViewer.Show()

                    Else
                        MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
                    End If
                ElseIf rbPenItems.Checked = True Then
                    Dim r2 As New Cry_PENDINGITEMGRN
                    sqlstring = "SELECT * FROM Vw_INDGRNITEMS "
                    sqlstring = sqlstring & " WHERE pendingqty<>0 and  INDENT_NO IN ("
                    For i = 0 To Chklist_PONo.CheckedItems.Count - 1
                        sqlstring = sqlstring & " '" & Chklist_PONo.CheckedItems(i) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"


                    sqlstring = sqlstring & " AND CAST(Convert(varchar(11),INDENT_DATE,6) AS DATETIME) BETWEEN "

                    sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"

                    'sqlstring = sqlstring & " ORDER BY PONO,PODATE"
                    gconnection.getDataSet(sqlstring, "Vw_INDGRNITEMS")
                    If gdataset.Tables("Vw_INDGRNITEMS").Rows.Count > 0 Then
                        rViewer.ssql = sqlstring
                        rViewer.Report = r2
                        rViewer.TableName = "Vw_INDGRNITEMS"

                        Dim textobj1 As TextObject
                        textobj1 = r2.ReportDefinition.ReportObjects("Text14")
                        textobj1.Text = MyCompanyName


                        Dim textobj2 As TextObject
                        textobj2 = r2.ReportDefinition.ReportObjects("Text32")
                        textobj2.Text = gUsername


                        Dim TXTOBJ3 As TextObject
                        TXTOBJ3 = r2.ReportDefinition.ReportObjects("Text12")
                        TXTOBJ3.Text = " From  " & Format(Cmb_FromDate.Value, "dd/MM/yyyy") & "  To " & " " & Format(Cmb_ToDate.Value, "dd/MM/yyyy") & ""

                        Dim textobj4 As TextObject
                        textobj4 = r2.ReportDefinition.ReportObjects("Text15")
                        textobj4.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode
                        Dim textobj5 As TextObject
                        textobj5 = r2.ReportDefinition.ReportObjects("Text16")
                        textobj5.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:" & gEmail & ", Web:" & gWebsite
                        Dim TEXTOBJ6 As TextObject
                        TEXTOBJ6 = r2.ReportDefinition.ReportObjects("Text17")
                        TEXTOBJ6.Text = "Service Tax:" & gServiceTax & " , Tin No.:" & gTinNo

                        rViewer.Refresh()
                        rViewer.Show()

                    Else
                        MsgBox("NO RECORDS TO DISPLAY", MsgBoxStyle.OkOnly)
                    End If
                End If
            End If
            

            ' End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub rptAmendment_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click_1(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F2 Then
            Dim i
            For i = 0 To Chklist_PONo.Items.Count - 1
                Chklist_PONo.SetItemChecked(i, True)
            Next i
            Chk_SelectAllVcode.Checked = True
            Me.Cmd_View.Focus()
            Exit Sub
        End If
        If e.KeyCode = Keys.F8 And Cmd_Print.Enabled = True Then
            Call Cmd_Print_Click(sender, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F9 And Cmd_View.Enabled = True Then
            Call Cmd_View_Click(sender, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F11 Then
            Call Cmd_Exit_Click(sender, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(sender, e)
            Exit Sub
        End If
        If e.Alt = True And e.KeyCode = Keys.F Then
            Me.Cmb_FromDate.Focus()
            Exit Sub
        End If
        If e.Alt = True And e.KeyCode = Keys.T Then
            Me.Cmb_ToDate.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Cbo_Option_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Cbo_Dept_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Cbo_Dept_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Cbo_Option.Focus()
        End If
    End Sub

    Private Sub Cbo_Option_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Chk_SelectAllVcode.Focus()
        End If
    End Sub

    Private Sub Chk_SelectAllVcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Chklist_PONo.Focus()
        End If
    End Sub

    Private Sub Chklist_PONo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Cmb_FromDate.Focus()
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

    Private Sub Cbo_Dept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        Chklist_PONo.Items.Clear()
        'RETRIVE FROM VIEW PO_VW_AMENDMENT -- ponO  podate   podepartment   amendmentno     apono     amendmentdesc
        If Cbo_Dept.Text <> "" Then
            DEPT = Split(Cbo_Dept.Text, "-->")

            'If Cbo_Option.SelectedIndex = 0 Then
            '    sqlstring = "select  DISTINCT PONO, PODEPARTMENT from po_vw_amendment WHERE PODEPARTMENT = '" & DEPT(1) & "' ORDER BY PONO"
            'ElseIf Cbo_Option.SelectedIndex = 1 Then
            '    sqlstring = "select  DISTINCT PONO, PODEPARTMENT from po_vw_followup WHERE PODEPARTMENT = '" & DEPT(1) & "' ORDER BY PONO"
            'End If
            If rbpenPOGRN.Checked = True Then
                sqlstring = "select DISTINCT PONO from Vw_PO_GRN WHERE PODEPARTMENT = '" & DEPT(1) & "' AND POTYPE='PO' AND CAST(Convert(varchar(11),PODATE,6) AS DATETIME) BETWEEN "
                sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "' ORDER BY PONO"
            ElseIf rbPenItemsPOGRN.Checked = True Then
                sqlstring = "select  DISTINCT PONO from Vw_POGRNITEMS_pending WHERE PODEPARTMENT = '" & DEPT(1) & "' AND PENDINGQTY<>0  AND CAST(Convert(varchar(11),PODATE,6) AS DATETIME) BETWEEN "
                sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "' ORDER BY PONO"
            End If
            gconnection.getDataSet(sqlstring, "PO_HDR")
            If gdataset.Tables("PO_HDR").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("PO_HDR").Rows.Count - 1
                    With gdataset.Tables("PO_HDR").Rows(i)
                        Chklist_PONo.Items.Add(Trim(.Item("PONO")))
                    End With
                Next i
            End If
            Chklist_PONo.Sorted = True
        End If
        
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        If Cbo_Dept.SelectedIndex = -1 Then
            MessageBox.Show("Select the Department", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cbo_Dept.Focus()
            Exit Sub
        End If
        If Chklist_PONo.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the P.O. No(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Chklist_PONo.Focus()
            Exit Sub
        End If

        gPrint = False

        'grp_SalebillChecklist.Top = 504
        'grp_SalebillChecklist.Left = 136

        'Me.ProgressBar1.Value = 2

        Me.Timer1.Interval = 100
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Cmd_Clear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        Cbo_Dept.SelectedIndex = -1
        Cbo_Option.SelectedIndex = 0
        Dim i As Integer
        For i = 0 To (Chklist_PONo.Items.Count - 1)
            Chklist_PONo.SetItemChecked(i, False)
        Next
        Cmb_FromDate.Text = Now.Today
        Cmb_ToDate.Text = Now.Today
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        gPrint = True

        'grp_SalebillChecklist.Top = 504
        'grp_SalebillChecklist.Left = 136

        'Me.ProgressBar1.Value = 2

        Me.Timer1.Interval = 100
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Chk_SelectAllVcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        If Chk_SelectAllVcode.Checked = True Then
            For i = 0 To Chklist_PONo.Items.Count - 1
                Chklist_PONo.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_PONo.Items.Count - 1
                Chklist_PONo.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub Cmd_Exit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
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
            Call ViewAMENDMENTregister()
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

    Private Sub btn_validation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validation.Click
        System.Diagnostics.Process.Start(AppPath & "\STUDY\AMENDMENTFOLLOWUPREGISTER.XLS")
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

    Private Sub Cbo_Dept_SelectedIndexChanged1(sender As Object, e As EventArgs) Handles Cbo_Dept.SelectedIndexChanged
        check_indent_type()
    End Sub

    Private Sub Cbo_Dept_Validated(sender As Object, e As EventArgs) Handles Cbo_Dept.Validated
        Dim i As Integer
        Chklist_PONo.Items.Clear()
        If Cbo_Dept.Text <> "" Then
            DEPT = Split(Cbo_Dept.Text, "-->")
            'If Cbo_Option.SelectedIndex = 0 Then
            '    sqlstring = "select  DISTINCT PONO, PODEPARTMENT from po_vw_amendment WHERE PODEPARTMENT = '" & DEPT(1) & "' ORDER BY PONO"
            'ElseIf Cbo_Option.SelectedIndex = 1 Then
            '    sqlstring = "select  DISTINCT PONO, PODEPARTMENT from po_vw_followup WHERE PODEPARTMENT = '" & DEPT(1) & "' ORDER BY PONO"
            'End If
            If rbpenPOGRN.Checked = True Then
                sqlstring = "select dIStIncT PONO from Vw_PO_GRN WHERE PODEPARTMENT = '" & DEPT(1) & "' AND POTYPE='PO' AND CAST(Convert(varchar(11),PODATE,6) AS DATETIME) BETWEEN "
                sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "' ORDER BY PONO"
            ElseIf rbPenItemsPOGRN.Checked = True Then
                sqlstring = "select  DISTINCT PONO from Vw_POGRNITEMS_pending WHERE PODEPARTMENT = '" & DEPT(1) & "' AND PENDINGQTY<>0  AND CAST(Convert(varchar(11),PODATE,6) AS DATETIME) BETWEEN "
                sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "' ORDER BY PONO"
            End If
            gconnection.getDataSet(sqlstring, "PO_HDR")
            If gdataset.Tables("PO_HDR").Rows.Count - 1 >= 0 Then
                For i = 0 To gdataset.Tables("PO_HDR").Rows.Count - 1
                    With gdataset.Tables("PO_HDR").Rows(i)
                        Chklist_PONo.Items.Add(Trim(.Item("PONO")))
                    End With
                Next i
            End If
        End If
        'RETRIVE FROM VIEW PO_VW_AMENDMENT -- ponO  podate   podepartment   amendmentno     apono     amendmentdesc
        
        Chklist_PONo.Sorted = True
    End Sub

    Private Sub Chk_SelectAllVcode_CheckedChanged1(sender As Object, e As EventArgs) Handles Chk_SelectAllVcode.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllVcode.Checked = True Then
            For i = 0 To Chklist_PONo.Items.Count - 1
                Chklist_PONo.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To Chklist_PONo.Items.Count - 1
                Chklist_PONo.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)
      
    End Sub

    Private Sub Cbo_Option_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles Cbo_Option.SelectedIndexChanged

    End Sub

    Private Sub rbIndent_CheckedChanged(sender As Object, e As EventArgs) Handles rbIndent.CheckedChanged
        'If rbIndent.Checked = True Then
        '    GroupBox6.Visible = True
        '    Label3.Text = "INDENT NO :"
        'Else
        '    GroupBox6.Visible = False
        '    Label3.Text = "P.O. NUMBER :"
        'End If
        'If rbPenAuth.Checked = True Then

        'End If
        check_indent_type()
    End Sub

    Private Sub check_indent_type()
        Dim i As Integer

        If Cbo_Dept.Text <> "" Then

            If rbIndent.Checked = True Then
                GroupBox6.Visible = True
                Label3.Text = "INDENT NO :"
                Chklist_PONo.Items.Clear()
                GroupBox8.Visible = False
            Else
                Chklist_PONo.Items.Clear()
                GroupBox6.Visible = False
                Label3.Text = "P.O. NUMBER :"
                GroupBox8.Visible = True
                DEPT = Split(Cbo_Dept.Text, "-->")
                'If Cbo_Option.SelectedIndex = 0 Then
                '    sqlstring = "select  DISTINCT PONO, PODEPARTMENT from po_vw_amendment WHERE PODEPARTMENT = '" & DEPT(1) & "' ORDER BY PONO"
                'ElseIf Cbo_Option.SelectedIndex = 1 Then
                '    sqlstring = "select  DISTINCT PONO, PODEPARTMENT from po_vw_followup WHERE PODEPARTMENT = '" & DEPT(1) & "' ORDER BY PONO"
                'End If INV_PENDING_PURCHASE
                If rbpenPOGRN.Checked = True Then
                    'sqlstring = "select PONO from Vw_PO_GRN WHERE PODEPARTMENT = '" & DEPT(1) & "' AND POTYPE='PO' AND CAST(Convert(varchar(11),PODATE,6) AS DATETIME) BETWEEN "
                    sqlstring = "select dIStIncT PONO from INV_PENDING_PURCHASE WHERE PODEPARTMENT = '" & DEPT(1) & "'  AND CAST(Convert(varchar(11),PODATE,6) AS DATETIME) BETWEEN "
                    sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "' ORDER BY PONO"
                ElseIf rbPenItemsPOGRN.Checked = True Then
                    sqlstring = "select  DISTINCT PONO from Vw_POGRNITEMS_pending ORDER BY PONO"
                End If
                If sqlstring <> "" Then
                    gconnection.getDataSet(sqlstring, "PO_HDR")
                    If gdataset.Tables("PO_HDR").Rows.Count - 1 >= 0 Then
                        For i = 0 To gdataset.Tables("PO_HDR").Rows.Count - 1
                            With gdataset.Tables("PO_HDR").Rows(i)
                                Chklist_PONo.Items.Add(Trim(.Item("PONO")))
                            End With
                        Next i
                    End If

                End If
                '
                Chklist_PONo.Sorted = True
            End If
            If rbIndent.Checked = True And rbPenAuth.Checked = True Then
                DEPT = Split(Cbo_Dept.Text, "-->")
                'RETRIVE FROM VIEW PO_VW_AMENDMENT -- ponO  podate   podepartment   amendmentno     apono     amendmentdesc
                sqlstring = "select DISTINCT INDENT_NO from PO_INDENTHDR where  fromstorecode='" & DEPT(0) & "' and INDENT_NO not IN  (SELECT DISTINCT INDENTNO FROM PO_STOCKINDENTAUTH_HDR WHERE Storelocationcode='" & DEPT(0) & "') AND CAST(Convert(varchar(11),INDENT_DATE,6) AS DATETIME) BETWEEN "

                sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"
                gconnection.getDataSet(sqlstring, "PO_INDENTHDR")
                If gdataset.Tables("PO_INDENTHDR").Rows.Count - 1 >= 0 Then
                    For i = 0 To gdataset.Tables("PO_INDENTHDR").Rows.Count - 1
                        With gdataset.Tables("PO_INDENTHDR").Rows(i)
                            Chklist_PONo.Items.Add(Trim(.Item("INDENT_NO")))
                        End With
                    Next i
                End If
                Chklist_PONo.Sorted = True
            ElseIf rbIndent.Checked = True And rbPenPO.Checked = True Then
                sqlstring = "select DISTINCT IndentNo from PO_STOCKINDENTAUTH_HDR where  Storelocationcode='" & DEPT(0) & "' and Docdetails not IN  (SELECT DISTINCT auth_docno FROM PO_HDR WHERE Storelocationcode='" & DEPT(0) & "') AND CAST(Convert(varchar(11),DOCDATE,6) AS DATETIME) BETWEEN "
                sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"
                gconnection.getDataSet(sqlstring, "PO_INDENTHDR")
                If gdataset.Tables("PO_INDENTHDR").Rows.Count - 1 >= 0 Then
                    For i = 0 To gdataset.Tables("PO_INDENTHDR").Rows.Count - 1
                        With gdataset.Tables("PO_INDENTHDR").Rows(i)
                            Chklist_PONo.Items.Add(Trim(.Item("IndentNo")))
                        End With
                    Next i
                End If
                Chklist_PONo.Sorted = True
            ElseIf rbIndent.Checked = True And rbPenGRN.Checked = True Then
                sqlstring = "select distinct indent_no from Vw_Indent_GRN where indtype='ind' and  fromstorecode='" & DEPT(0) & "'  AND CAST(Convert(varchar(11),indent_date,6) AS DATETIME) BETWEEN "
                sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"
                gconnection.getDataSet(sqlstring, "PO_INDENTHDR")
                If gdataset.Tables("PO_INDENTHDR").Rows.Count - 1 >= 0 Then
                    For i = 0 To gdataset.Tables("PO_INDENTHDR").Rows.Count - 1
                        With gdataset.Tables("PO_INDENTHDR").Rows(i)
                            Chklist_PONo.Items.Add(Trim(.Item("indent_no")))
                        End With
                    Next i
                End If
                Chklist_PONo.Sorted = True
            ElseIf rbIndent.Checked = True And rbPenItems.Checked = True Then
                sqlstring = "select distinct indent_no from Vw_INDGRNITEMS WHERE pendingqty<>0 and   store='" & DEPT(0) & "' AND  CAST(Convert(varchar(11),indent_date,6) AS DATETIME) BETWEEN "
                sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"
                gconnection.getDataSet(sqlstring, "PO_INDENTHDR")
                If gdataset.Tables("PO_INDENTHDR").Rows.Count - 1 >= 0 Then
                    For i = 0 To gdataset.Tables("PO_INDENTHDR").Rows.Count - 1
                        With gdataset.Tables("PO_INDENTHDR").Rows(i)
                            Chklist_PONo.Items.Add(Trim(.Item("indent_no")))
                        End With
                    Next i
                End If
                Chklist_PONo.Sorted = True
            End If
        End If
        
    End Sub


    Private Sub rbPO_CheckedChanged(sender As Object, e As EventArgs) Handles rbPO.CheckedChanged
        check_indent_type()
    End Sub

    Private Sub rbPenAuth_CheckedChanged(sender As Object, e As EventArgs) Handles rbPenAuth.CheckedChanged
        check_indent_type()
    End Sub

    Private Sub rbPenPO_CheckedChanged(sender As Object, e As EventArgs) Handles rbPenPO.CheckedChanged
        check_indent_type()
    End Sub

    Private Sub rbPenGRN_CheckedChanged(sender As Object, e As EventArgs) Handles rbPenGRN.CheckedChanged
        check_indent_type()
    End Sub

    Private Sub rbPenItems_CheckedChanged(sender As Object, e As EventArgs) Handles rbPenItems.CheckedChanged
        check_indent_type()
    End Sub

    Private Sub rbpenPOGRN_CheckedChanged(sender As Object, e As EventArgs) Handles rbpenPOGRN.CheckedChanged
        check_indent_type()
    End Sub

    Private Sub rbPenItemsPOGRN_CheckedChanged(sender As Object, e As EventArgs) Handles rbPenItemsPOGRN.CheckedChanged
        check_indent_type()
    End Sub
End Class
