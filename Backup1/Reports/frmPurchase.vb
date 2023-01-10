Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class FRM_PURCHASE
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
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents frmbut As System.Windows.Forms.GroupBox
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents dtp_Fromdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_Todate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents chklst_Group As System.Windows.Forms.CheckedListBox
    Friend WithEvents chklst_Supplier As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_validation As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRM_PURCHASE))
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.frmbut = New System.Windows.Forms.GroupBox
        Me.opt_Purchasedetails = New System.Windows.Forms.RadioButton
        Me.opt_Purchasesummary = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Chk_SelectAllSupplier = New System.Windows.Forms.CheckBox
        Me.chklst_Group = New System.Windows.Forms.CheckedListBox
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dtp_Fromdate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtp_Todate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.chklst_Supplier = New System.Windows.Forms.CheckedListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CheckSupplier = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btn_validation = New System.Windows.Forms.Button
        Me.frmbut.SuspendLayout()
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(448, 600)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 6
        Me.Cmd_Print.Text = " Print [F10]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(312, 600)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 5
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(736, 600)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 7
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(176, 600)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 4
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'frmbut
        '
        Me.frmbut.BackColor = System.Drawing.Color.Transparent
        Me.frmbut.Controls.Add(Me.btn_validation)
        Me.frmbut.Location = New System.Drawing.Point(152, 584)
        Me.frmbut.Name = "frmbut"
        Me.frmbut.Size = New System.Drawing.Size(712, 56)
        Me.frmbut.TabIndex = 13
        Me.frmbut.TabStop = False
        '
        'opt_Purchasedetails
        '
        Me.opt_Purchasedetails.BackColor = System.Drawing.Color.Transparent
        Me.opt_Purchasedetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.opt_Purchasedetails.Location = New System.Drawing.Point(328, 488)
        Me.opt_Purchasedetails.Name = "opt_Purchasedetails"
        Me.opt_Purchasedetails.Size = New System.Drawing.Size(128, 16)
        Me.opt_Purchasedetails.TabIndex = 2
        Me.opt_Purchasedetails.Text = "DETAILS"
        '
        'opt_Purchasesummary
        '
        Me.opt_Purchasesummary.BackColor = System.Drawing.Color.Transparent
        Me.opt_Purchasesummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.opt_Purchasesummary.Location = New System.Drawing.Point(576, 488)
        Me.opt_Purchasesummary.Name = "opt_Purchasesummary"
        Me.opt_Purchasesummary.Size = New System.Drawing.Size(120, 16)
        Me.opt_Purchasesummary.TabIndex = 3
        Me.opt_Purchasesummary.Text = "SUMMARY"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Chocolate
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(80, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(408, 24)
        Me.Label4.TabIndex = 423
        Me.Label4.Text = "DEPARTMENT SELECTION :"
        '
        'Chk_SelectAllSupplier
        '
        Me.Chk_SelectAllSupplier.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllSupplier.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllSupplier.Location = New System.Drawing.Point(88, 64)
        Me.Chk_SelectAllSupplier.Name = "Chk_SelectAllSupplier"
        Me.Chk_SelectAllSupplier.Size = New System.Drawing.Size(136, 24)
        Me.Chk_SelectAllSupplier.TabIndex = 422
        Me.Chk_SelectAllSupplier.Text = "SELECT ALL "
        '
        'chklst_Group
        '
        Me.chklst_Group.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklst_Group.Location = New System.Drawing.Point(80, 112)
        Me.chklst_Group.Name = "chklst_Group"
        Me.chklst_Group.Size = New System.Drawing.Size(408, 356)
        Me.chklst_Group.TabIndex = 421
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(152, 512)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(712, 64)
        Me.grp_SalebillChecklist.TabIndex = 424
        Me.grp_SalebillChecklist.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(696, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'lbl_Wait
        '
        Me.lbl_Wait.AutoSize = True
        Me.lbl_Wait.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Wait.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Wait.Location = New System.Drawing.Point(360, 24)
        Me.lbl_Wait.Name = "lbl_Wait"
        Me.lbl_Wait.Size = New System.Drawing.Size(0, 18)
        Me.lbl_Wait.TabIndex = 387
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(288, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 18)
        Me.Label1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.dtp_Fromdate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.dtp_Todate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(152, 512)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(712, 64)
        Me.GroupBox3.TabIndex = 425
        Me.GroupBox3.TabStop = False
        '
        'dtp_Fromdate
        '
        Me.dtp_Fromdate.CustomFormat = "dd-MM-yyyy"
        Me.dtp_Fromdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Fromdate.Location = New System.Drawing.Point(184, 24)
        Me.dtp_Fromdate.MaxDate = New Date(9998, 8, 14, 0, 0, 0, 0)
        Me.dtp_Fromdate.MinDate = New Date(2000, 8, 14, 0, 0, 0, 0)
        Me.dtp_Fromdate.Name = "dtp_Fromdate"
        Me.dtp_Fromdate.Size = New System.Drawing.Size(144, 26)
        Me.dtp_Fromdate.TabIndex = 0
        Me.dtp_Fromdate.Value = New Date(2006, 9, 14, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(400, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "TO DATE :"
        '
        'dtp_Todate
        '
        Me.dtp_Todate.CustomFormat = "dd-MM-yyyy"
        Me.dtp_Todate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_Todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Todate.Location = New System.Drawing.Point(504, 24)
        Me.dtp_Todate.MaxDate = New Date(9998, 8, 14, 0, 0, 0, 0)
        Me.dtp_Todate.MinDate = New Date(2000, 8, 14, 0, 0, 0, 0)
        Me.dtp_Todate.Name = "dtp_Todate"
        Me.dtp_Todate.Size = New System.Drawing.Size(144, 26)
        Me.dtp_Todate.TabIndex = 1
        Me.dtp_Todate.Value = New Date(2006, 8, 14, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(56, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FROM DATE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(152, 648)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 18)
        Me.Label5.TabIndex = 426
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'Timer1
        '
        '
        'chklst_Supplier
        '
        Me.chklst_Supplier.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklst_Supplier.Location = New System.Drawing.Point(520, 112)
        Me.chklst_Supplier.Name = "chklst_Supplier"
        Me.chklst_Supplier.Size = New System.Drawing.Size(408, 356)
        Me.chklst_Supplier.TabIndex = 427
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Chocolate
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(520, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(408, 24)
        Me.Label2.TabIndex = 429
        Me.Label2.Text = "VENDOR SELECTION :"
        '
        'CheckSupplier
        '
        Me.CheckSupplier.BackColor = System.Drawing.Color.Transparent
        Me.CheckSupplier.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckSupplier.Location = New System.Drawing.Point(528, 64)
        Me.CheckSupplier.Name = "CheckSupplier"
        Me.CheckSupplier.Size = New System.Drawing.Size(136, 24)
        Me.CheckSupplier.TabIndex = 428
        Me.CheckSupplier.Text = "SELECT ALL "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(352, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(388, 31)
        Me.Label8.TabIndex = 430
        Me.Label8.Text = "PURCHASE REGISTER REPORT"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_validation
        '
        Me.btn_validation.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_validation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_validation.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_validation.ForeColor = System.Drawing.Color.White
        Me.btn_validation.Image = CType(resources.GetObject("btn_validation.Image"), System.Drawing.Image)
        Me.btn_validation.Location = New System.Drawing.Point(440, 16)
        Me.btn_validation.Name = "btn_validation"
        Me.btn_validation.Size = New System.Drawing.Size(104, 32)
        Me.btn_validation.TabIndex = 8
        Me.btn_validation.Text = "Validation"
        '
        'FRM_PURCHASE
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(992, 708)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckSupplier)
        Me.Controls.Add(Me.chklst_Supplier)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chk_SelectAllSupplier)
        Me.Controls.Add(Me.chklst_Group)
        Me.Controls.Add(Me.opt_Purchasesummary)
        Me.Controls.Add(Me.opt_Purchasedetails)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.frmbut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FRM_PURCHASE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORT [ PURCHASE REGISTER ]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.frmbut.ResumeLayout(False)
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Dim sqlstring As String

    Private Sub frmPurchaseregister_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i
        If e.KeyCode = Keys.F9 Then
            Call Cmd_View_Click(Cmd_View, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F2 Then
            For i = 0 To chklst_Group.Items.Count - 1
                chklst_Group.SetItemChecked(i, True)
                Chk_SelectAllSupplier.Checked = True
            Next i
            For i = 0 To chklst_Supplier.Items.Count - 1
                chklst_Supplier.SetItemChecked(i, True)
                CheckSupplier.Checked = True
            Next i
            Me.dtp_Fromdate.Focus()
        ElseIf e.KeyCode = Keys.F10 Then
            Call Cmd_Print_Click(Cmd_Print, e)
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
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        If chklst_Group.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Group Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If chklst_Supplier.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Checkdaterangevalidate(Format(dtp_Fromdate.Value, "dd/MMM/yyyy"), Format(dtp_Todate.Value, "dd/MMM/yyyy"))
        If chkdatevalidate = False Then Exit Sub
        gPrint = False
        grp_SalebillChecklist.Top = 512
        grp_SalebillChecklist.Left = 152
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 25
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        If chklst_Group.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Group Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If chklst_Supplier.CheckedItems.Count = 0 Then
            MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Checkdaterangevalidate(dtp_Fromdate.Value, dtp_Todate.Value)
        If chkdatevalidate = False Then Exit Sub
        gPrint = True
        grp_SalebillChecklist.Top = 512
        grp_SalebillChecklist.Left = 152
        Me.ProgressBar1.Value = 2
        Me.Timer1.Interval = 100
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Viewsuppliernamewise()
        Try
            Dim sqlstring, DEPARTMENT() As String
            Dim i As Integer
            If opt_Purchasesummary.Checked = True Then
                sqlstring = " SELECT * FROM PO_VIEW_PORDERSUMMARY "
                If chklst_Group.CheckedItems.Count <> 0 Then
                    'sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
                    sqlstring = sqlstring & " WHERE PODEPARTMENT IN ("
                    For i = 0 To chklst_Group.CheckedItems.Count - 1
                        DEPARTMENT = Split(chklst_Group.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & Trim(DEPARTMENT(0)) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Department Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                If chklst_Supplier.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " And VENDORCODE IN ("
                    For i = 0 To chklst_Supplier.CheckedItems.Count - 1
                        DEPARTMENT = Split(chklst_Supplier.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & Trim(DEPARTMENT(0)) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                sqlstring = sqlstring & " AND PODATE BETWEEN"
                sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
                sqlstring = sqlstring & " ORDER BY PODATE,pono,PODEPARTMENT,VENDORNAME,ITEMCODE  "
                Dim heading() As String = {"PURCHASE REGISTER SUMMARY"}
                Dim ObjPurchaseregistersummary As New rptPurchaseregistersummary
                ObjPurchaseregistersummary.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
                'Else
                '    opt_Purchasedetails.Checked = True
                '    sqlstring = " SELECT * FROM VIEWPURCHASEREGISTERSUMMARY "
                '    If chklst_Group.CheckedItems.Count <> 0 Then
                '        'sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
                '        sqlstring = sqlstring & " WHERE SUBSTRING(GRNDETAILS,5,3) IN (SELECT GROUPPREFIX FROM inventoryGROUPMASTER WHERE GROUPCODE IN ("
                '        For i = 0 To chklst_Group.CheckedItems.Count - 1
                '            SUPPLIERNAME = Split(chklst_Group.CheckedItems(i), "-->")
                '            sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
                '        Next
                '        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                '        sqlstring = sqlstring & "))"
                '    Else
                '        MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '        Exit Sub
                '    End If
                '    If chklst_Supplier.CheckedItems.Count <> 0 Then
                '        sqlstring = sqlstring & " And SUPPLIERCODE IN ("
                '        'sqlstring = sqlstring & " WHERE SUBSTRING(GRNDETAILS,5,3) IN (SELECT GROUPPREFIX FROM inventoryGROUPMASTER WHERE GROUPCODE IN ("
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
                '    sqlstring = sqlstring & " AND GRNDATE BETWEEN"
                '    sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
                '    sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMCODE  "
                '    'gconnection.getDataSet(sqlstring, "GRIDVIEW")
                '    'gridviewstatus = "Purchasereisterreport"
                '    'Dim griddesign As New GridDesign
                '    'griddesign.FormBorderStyle = FormBorderStyle.FixedDialog
                '    'griddesign.MdiParent = MDIParentobj
                '    'Me.Close()
                '    'griddesign.Show()
                '    Dim heading() As String = {"PURCHASE REGISTER "}
                '    Dim ObjStockPurchaseregisterReport As New rptStockPurchaseregister
                '    ObjStockPurchaseregisterReport.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

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
            If MsgBox("Click YES for 'Windows View' or NO for 'TEXT View'", MsgBoxStyle.YesNo, "STOCK SUMMARY") = MsgBoxResult.Yes Then
                Call Viewsuppliernamewise_crystal()
            Else
                Call Viewsuppliernamewise()
            End If

        End If
    End Sub
    Private Sub Viewsuppliernamewise_crystal()
        Try
            Dim sqlstring, DEPARTMENT() As String
            Dim i As Integer
            Dim rViewer As New Viewer
            Dim r As New rpt_Purchase_summary

            If opt_Purchasesummary.Checked = True Then
                sqlstring = " SELECT distinct pono,podate,vendorcode,podepartment,vendorname,povalue,pototalvat,pototaltax,poadvance,pobalance FROM PO_VIEW_PORDERSUMMARY  "
                If chklst_Group.CheckedItems.Count <> 0 Then
                    'sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
                    sqlstring = sqlstring & " WHERE PODEPARTMENT IN ("
                    For i = 0 To chklst_Group.CheckedItems.Count - 1
                        DEPARTMENT = Split(chklst_Group.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & Trim(DEPARTMENT(0)) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Department Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                If chklst_Supplier.CheckedItems.Count <> 0 Then
                    sqlstring = sqlstring & " And VENDORCODE IN ("
                    For i = 0 To chklst_Supplier.CheckedItems.Count - 1
                        DEPARTMENT = Split(chklst_Supplier.CheckedItems(i), "-->")
                        sqlstring = sqlstring & " '" & Trim(DEPARTMENT(0)) & "', "
                    Next
                    sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                    sqlstring = sqlstring & ")"
                Else
                    MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
                sqlstring = sqlstring & " AND PODATE BETWEEN"
                sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
                sqlstring = sqlstring & " ORDER BY PODATE,pono,PODEPARTMENT,VENDORNAME  "

                rViewer.ssql = sqlstring

                rViewer.Report = r
                rViewer.TableName = "STOCKSUMMARY"

                Dim textobj1 As TextObject
                textobj1 = r.ReportDefinition.ReportObjects("Text13")
                textobj1.Text = MyCompanyName
                Dim TXTOBJ2 As TextObject
                TXTOBJ2 = r.ReportDefinition.ReportObjects("Text16")
                TXTOBJ2.Text = " Prepared By : " & gUsername
                Dim TXTOBJ3 As TextObject
                TXTOBJ3 = r.ReportDefinition.ReportObjects("Text17")
                TXTOBJ3.Text = " From  " & Format(dtp_Fromdate.Value, "dd/MM/yyyy") & "  To " & " " & Format(dtp_Todate.Value, "dd/MM/yyyy") & ""
                rViewer.Show()

                'Dim heading() As String = {"PURCHASE REGISTER SUMMARY"}
                'Dim ObjPurchaseregistersummary As New rptPurchaseregistersummary
                'ObjPurchaseregistersummary.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
                'Else
                '    opt_Purchasedetails.Checked = True
                '    sqlstring = " SELECT * FROM VIEWPURCHASEREGISTERSUMMARY "
                '    If chklst_Group.CheckedItems.Count <> 0 Then
                '        'sqlstring = sqlstring & " WHERE SUPPLIERCODE IN ("
                '        sqlstring = sqlstring & " WHERE SUBSTRING(GRNDETAILS,5,3) IN (SELECT GROUPPREFIX FROM inventoryGROUPMASTER WHERE GROUPCODE IN ("
                '        For i = 0 To chklst_Group.CheckedItems.Count - 1
                '            SUPPLIERNAME = Split(chklst_Group.CheckedItems(i), "-->")
                '            sqlstring = sqlstring & " '" & Trim(SUPPLIERNAME(0)) & "', "
                '        Next
                '        sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
                '        sqlstring = sqlstring & "))"
                '    Else
                '        MessageBox.Show("Select the Supplier Name(s)", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                '        Exit Sub
                '    End If
                '    If chklst_Supplier.CheckedItems.Count <> 0 Then
                '        sqlstring = sqlstring & " And SUPPLIERCODE IN ("
                '        'sqlstring = sqlstring & " WHERE SUBSTRING(GRNDETAILS,5,3) IN (SELECT GROUPPREFIX FROM inventoryGROUPMASTER WHERE GROUPCODE IN ("
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
                '    sqlstring = sqlstring & " AND GRNDATE BETWEEN"
                '    sqlstring = sqlstring & " '" & Format(dtp_Fromdate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(dtp_Todate.Value, "dd-MMM-yyyy") & "'"
                '    sqlstring = sqlstring & " ORDER BY GRNDATE,GRNDETAILS,SUPPLIERNAME,ITEMCODE  "
                '    'gconnection.getDataSet(sqlstring, "GRIDVIEW")
                '    'gridviewstatus = "Purchasereisterreport"
                '    'Dim griddesign As New GridDesign
                '    'griddesign.FormBorderStyle = FormBorderStyle.FixedDialog
                '    'griddesign.MdiParent = MDIParentobj
                '    'Me.Close()
                '    'griddesign.Show()
                '    Dim heading() As String = {"PURCHASE REGISTER "}
                '    Dim ObjStockPurchaseregisterReport As New rptStockPurchaseregister
                '    ObjStockPurchaseregisterReport.Reportdetails(sqlstring, heading, dtp_Fromdate.Value, dtp_Todate.Value)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub dtp_Fromdate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Fromdate.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_Todate.Focus()
        End If
    End Sub

    Private Sub dtp_Todate_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Todate.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cmd_View.Focus()
        End If
    End Sub

    Private Sub frmPurchaseregister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Fillsuppliername()
        Call Fillgroup()
        dtp_Fromdate.Value = Format(Now, "dd/MM/yyyy")
        dtp_Todate.Value = Format(Now, "dd/MM/yyyy")
        opt_Purchasesummary.Checked = True
        grp_SalebillChecklist.Top = 1000
        opt_Purchasedetails.Visible = False
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
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='Purchase Order' AND MODULENAME LIKE 'Purchase Register Summary%' ORDER BY RIGHTS"
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

    '''******************************  To fill POS details from SupplierName  *******************************'''
    Private Sub Fillgroup()
        Dim i As Integer
        chklst_Group.Items.Clear()
        'sqlstring = "SELECT DISTINCT ISNULL(SLCODE,'') AS SLCODE,ISNULL(SLNAME,'') AS SLNAME FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & Trim(gCreditors) & "' AND ISNULL(FREeZEFLAG,'') <> 'Y'"
        'sqlstring = "SELECT DISTINCT ISNULL(GROUPCODE,'') AS SLCODE,ISNULL(GROUPdesc,'') AS SLNAME FROM inventorygroupmaster "
        sqlstring = "SELECT storecode,storedesc FROM STOREMASTER"
        gconnection.getDataSet(sqlstring, "SUBLEDGERMASTER")
        If gdataset.Tables("SUBLEDGERMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("SUBLEDGERMASTER").Rows.Count - 1
                With gdataset.Tables("SUBLEDGERMASTER").Rows(i)
                    'chklst_Group.Items.Add(Trim(.Item("StoreCODE")) & "-->" & Trim(.Item("Storedesc")))
                    chklst_Group.Items.Add(Trim(.Item("StoreDESC"))) '& "-->" & Trim(.Item("Storedesc")))
                End With
            Next i
        End If
        chklst_Group.Sorted = True
    End Sub

    Private Sub Fillsuppliername()
        Dim i As Integer
        chklst_Supplier.Items.Clear()
        'sqlstring = "SELECT DISTINCT ISNULL(SLCODE,'') AS SLCODE,ISNULL(SLNAME,'') AS SLNAME FROM ACCOUNTSSUBLEDGERMASTER WHERE ACCODE = '" & Trim(gCreditors) & "' AND ISNULL(FREeZEFLAG,'') <> 'Y'"
        sqlstring = "SELECT ISNULL(VENDORCODE,0) AS VENDORCODE, ISNULL(VENDORNAME,'') AS VENDORNAME FROM PO_VIEW_VENDORMASTER "
        gconnection.getDataSet(sqlstring, "SUBLEDGERMASTER")
        If gdataset.Tables("SUBLEDGERMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("SUBLEDGERMASTER").Rows.Count - 1
                With gdataset.Tables("SUBLEDGERMASTER").Rows(i)
                    chklst_Supplier.Items.Add(Trim(.Item("VENDORCODE")) & "-->" & Trim(.Item("VENDORNAME")))
                End With
            Next i
        End If
        chklst_Supplier.Sorted = True
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
        chklst_Group.Items.Clear()
        chklst_Supplier.Items.Clear()
        grp_SalebillChecklist.Top = 1000
        opt_Purchasedetails.Checked = True
        Chk_SelectAllSupplier.Checked = False
        CheckSupplier.Checked = False
        Call Fillgroup()
        Call Fillsuppliername()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        dtp_Fromdate.Focus()
    End Sub

    Private Sub Chk_SelectAllSupplier_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_SelectAllSupplier.CheckedChanged
        Dim i As Integer
        If Chk_SelectAllSupplier.Checked = True Then
            For i = 0 To chklst_Group.Items.Count - 1
                chklst_Group.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklst_Group.Items.Count - 1
                chklst_Group.SetItemChecked(i, False)
            Next
        End If
    End Sub

    Private Sub Chk_SelectAllSupplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_SelectAllSupplier.KeyDown
        If e.KeyCode = Keys.Enter Then
            chklst_Group.Focus()
        End If
    End Sub


    Private Sub CheckSupplier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckSupplier.CheckedChanged
        Dim i As Integer
        If CheckSupplier.Checked = True Then
            For i = 0 To chklst_Supplier.Items.Count - 1
                chklst_Supplier.SetItemChecked(i, True)
            Next
        Else
            For i = 0 To chklst_Supplier.Items.Count - 1
                chklst_Supplier.SetItemChecked(i, False)
            Next
        End If
    End Sub


    Private Sub CheckSupplier_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CheckSupplier.KeyDown
        If e.KeyCode = Keys.Enter Then
            opt_Purchasedetails.Focus()
        End If
    End Sub

    Private Sub btn_validation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_validation.Click
        System.Diagnostics.Process.Start(AppPath & "\STUDY\PURCHASEREGISTERREPORT.XLS")
    End Sub
End Class
