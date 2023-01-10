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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectAllVcode As System.Windows.Forms.CheckBox
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
    Friend WithEvents Chklist_PONo As System.Windows.Forms.CheckedListBox
    Friend WithEvents Cbo_Dept As System.Windows.Forms.ComboBox
    Friend WithEvents Cbo_Option As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_validation As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptAmendment))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Chklist_PONo = New System.Windows.Forms.CheckedListBox
        Me.Chk_SelectAllVcode = New System.Windows.Forms.CheckBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.grp_SalebillChecklist = New System.Windows.Forms.GroupBox
        Me.lbl_Wait = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Cmb_FromDate = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Cmb_ToDate = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cbo_Dept = New System.Windows.Forms.ComboBox
        Me.Cbo_Option = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.btn_validation = New System.Windows.Forms.Button
        Me.grp_SalebillChecklist.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Chocolate
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(360, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(320, 24)
        Me.Label3.TabIndex = 439
        Me.Label3.Text = "P.O. NUMBER :"
        '
        'Chklist_PONo
        '
        Me.Chklist_PONo.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chklist_PONo.Location = New System.Drawing.Point(360, 96)
        Me.Chklist_PONo.Name = "Chklist_PONo"
        Me.Chklist_PONo.Size = New System.Drawing.Size(320, 246)
        Me.Chklist_PONo.TabIndex = 438
        '
        'Chk_SelectAllVcode
        '
        Me.Chk_SelectAllVcode.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectAllVcode.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectAllVcode.Location = New System.Drawing.Point(360, 48)
        Me.Chk_SelectAllVcode.Name = "Chk_SelectAllVcode"
        Me.Chk_SelectAllVcode.Size = New System.Drawing.Size(144, 24)
        Me.Chk_SelectAllVcode.TabIndex = 437
        Me.Chk_SelectAllVcode.Text = "SELECT ALL "
        '
        'Timer1
        '
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(144, 472)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 18)
        Me.Label5.TabIndex = 435
        Me.Label5.Text = "Press F2 to select all / Press ENTER key to navigate"
        '
        'grp_SalebillChecklist
        '
        Me.grp_SalebillChecklist.BackgroundImage = CType(resources.GetObject("grp_SalebillChecklist.BackgroundImage"), System.Drawing.Image)
        Me.grp_SalebillChecklist.Controls.Add(Me.lbl_Wait)
        Me.grp_SalebillChecklist.Controls.Add(Me.Label1)
        Me.grp_SalebillChecklist.Controls.Add(Me.ProgressBar1)
        Me.grp_SalebillChecklist.Location = New System.Drawing.Point(48, 992)
        Me.grp_SalebillChecklist.Name = "grp_SalebillChecklist"
        Me.grp_SalebillChecklist.Size = New System.Drawing.Size(712, 64)
        Me.grp_SalebillChecklist.TabIndex = 434
        Me.grp_SalebillChecklist.TabStop = False
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
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(8, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(696, 32)
        Me.ProgressBar1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Cmb_FromDate)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Cmb_ToDate)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(80, 352)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(552, 56)
        Me.GroupBox3.TabIndex = 430
        Me.GroupBox3.TabStop = False
        '
        'Cmb_FromDate
        '
        Me.Cmb_FromDate.CustomFormat = "dd-MM-yyyy"
        Me.Cmb_FromDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cmb_FromDate.Location = New System.Drawing.Point(136, 16)
        Me.Cmb_FromDate.MaxDate = New Date(9998, 8, 14, 0, 0, 0, 0)
        Me.Cmb_FromDate.MinDate = New Date(2000, 8, 14, 0, 0, 0, 0)
        Me.Cmb_FromDate.Name = "Cmb_FromDate"
        Me.Cmb_FromDate.Size = New System.Drawing.Size(120, 26)
        Me.Cmb_FromDate.TabIndex = 0
        Me.Cmb_FromDate.Value = New Date(2008, 6, 19, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(344, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 22)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "TO DATE :"
        '
        'Cmb_ToDate
        '
        Me.Cmb_ToDate.CustomFormat = "dd-MM-yyyy"
        Me.Cmb_ToDate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cmb_ToDate.Location = New System.Drawing.Point(432, 16)
        Me.Cmb_ToDate.MaxDate = New Date(9998, 8, 14, 0, 0, 0, 0)
        Me.Cmb_ToDate.MinDate = New Date(2000, 8, 14, 0, 0, 0, 0)
        Me.Cmb_ToDate.Name = "Cmb_ToDate"
        Me.Cmb_ToDate.Size = New System.Drawing.Size(112, 26)
        Me.Cmb_ToDate.TabIndex = 1
        Me.Cmb_ToDate.Value = New Date(2009, 6, 19, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "FROM DATE :"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.btn_validation)
        Me.GroupBox4.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox4.Controls.Add(Me.Cmd_Print)
        Me.GroupBox4.Controls.Add(Me.Cmd_View)
        Me.GroupBox4.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 408)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(648, 56)
        Me.GroupBox4.TabIndex = 433
        Me.GroupBox4.TabStop = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(528, 16)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 7
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(288, 16)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 6
        Me.Cmd_Print.Text = " Print [F8]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(152, 16)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 5
        Me.Cmd_View.Text = "View [F9]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(16, 16)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 4
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cbo_Dept
        '
        Me.Cbo_Dept.BackColor = System.Drawing.Color.Wheat
        Me.Cbo_Dept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Dept.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Dept.Items.AddRange(New Object() {"DEPOSIT", "TRANSFER", "REFUND"})
        Me.Cbo_Dept.Location = New System.Drawing.Point(32, 168)
        Me.Cbo_Dept.Name = "Cbo_Dept"
        Me.Cbo_Dept.Size = New System.Drawing.Size(248, 30)
        Me.Cbo_Dept.TabIndex = 0
        '
        'Cbo_Option
        '
        Me.Cbo_Option.BackColor = System.Drawing.Color.Wheat
        Me.Cbo_Option.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Option.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Option.Items.AddRange(New Object() {"AMENDMENT", "FOLLOW-UP"})
        Me.Cbo_Option.Location = New System.Drawing.Point(32, 232)
        Me.Cbo_Option.Name = "Cbo_Option"
        Me.Cbo_Option.Size = New System.Drawing.Size(248, 30)
        Me.Cbo_Option.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 23)
        Me.Label2.TabIndex = 442
        Me.Label2.Text = "DEPARTMENT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 23)
        Me.Label4.TabIndex = 443
        Me.Label4.Text = "OPTIONS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(120, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(482, 31)
        Me.Label8.TabIndex = 444
        Me.Label8.Text = "AMENDMENT / FOLLOW-UP REGISTER"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_validation
        '
        Me.btn_validation.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_validation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_validation.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_validation.ForeColor = System.Drawing.Color.White
        Me.btn_validation.Image = CType(resources.GetObject("btn_validation.Image"), System.Drawing.Image)
        Me.btn_validation.Location = New System.Drawing.Point(408, 16)
        Me.btn_validation.Name = "btn_validation"
        Me.btn_validation.Size = New System.Drawing.Size(104, 32)
        Me.btn_validation.TabIndex = 8
        Me.btn_validation.Text = "Validation"
        '
        'rptAmendment
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(696, 502)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Cbo_Option)
        Me.Controls.Add(Me.Cbo_Dept)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Chklist_PONo)
        Me.Controls.Add(Me.Chk_SelectAllVcode)
        Me.Controls.Add(Me.grp_SalebillChecklist)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "rptAmendment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AMENDMENT / FOLLOW-UP REPORT"
        Me.grp_SalebillChecklist.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    Dim gconnection As New GlobalClass

    Private Sub rptAmendment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        sqlstring = "SELECT storecode,storedesc FROM STOREMASTER"
        gconnection.getDataSet(sqlstring, "STOREMASTER")
        Cbo_Dept.Items.Clear()
        If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("STOREMASTER").Rows.Count - 1
                Dim temptype As String
                Cbo_Dept.Items.Add(gdataset.Tables("STOREMASTER").Rows(i).Item("storedesc"))
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
        Try
            Dim sqlstring = " "
            If Cbo_Option.SelectedIndex = 0 Then
                sqlstring = "SELECT * FROM PO_VW_AMENDEMNTREPORT "
            ElseIf Cbo_Option.SelectedIndex = 1 Then
                sqlstring = "SELECT * FROM PO_VW_FOLLOWUP "
            End If
            sqlstring = sqlstring & " WHERE PONO IN ("
            For i = 0 To Chklist_PONo.CheckedItems.Count - 1
                sqlstring = sqlstring & " '" & Chklist_PONo.CheckedItems(i) & "', "
            Next
            sqlstring = Mid(sqlstring, 1, Len(sqlstring) - 2)
            sqlstring = sqlstring & ")"

            sqlstring = sqlstring & " AND CAST(Convert(varchar(11),PODATE,6) AS DATETIME) BETWEEN "
            sqlstring = sqlstring & " '" & Format(Cmb_FromDate.Value, "dd-MMM-yyyy") & "' AND ' " & Format(Cmb_ToDate.Value, "dd-MMM-yyyy") & "'"

            sqlstring = sqlstring & " ORDER BY PONO,PODATE"
            Dim pageheading() As String = {"AMENDMENT / FOLLOW-UP REGISTER"}
            Dim ObjrptViewAmendmentReport As New rptViewAmendmentReport
            ObjrptViewAmendmentReport.ReportsDetails(sqlstring, pageheading, Cmb_FromDate.Value, Cmb_ToDate.Value)
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
        If e.KeyCode = Keys.F8 Then
            Call Cmd_Print_Click(sender, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F9 Then
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

    Private Sub Cbo_Option_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_Option.SelectedIndexChanged
        Call Cbo_Dept_SelectedIndexChanged(sender, e)
    End Sub

    Private Sub Cbo_Dept_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_Dept.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cbo_Option.Focus()
        End If
    End Sub

    Private Sub Cbo_Option_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_Option.KeyDown
        If e.KeyCode = Keys.Enter Then
            Chk_SelectAllVcode.Focus()
        End If
    End Sub

    Private Sub Chk_SelectAllVcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chk_SelectAllVcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Chklist_PONo.Focus()
        End If
    End Sub

    Private Sub Chklist_PONo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Chklist_PONo.KeyDown
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

    Private Sub Cbo_Dept_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cbo_Dept.SelectedIndexChanged
        Dim i As Integer
        Chklist_PONo.Items.Clear()
        'RETRIVE FROM VIEW PO_VW_AMENDMENT -- ponO  podate   podepartment   amendmentno     apono     amendmentdesc
        If Cbo_Option.SelectedIndex = 0 Then
            sqlstring = "select  DISTINCT PONO, PODEPARTMENT from po_vw_amendment WHERE PODEPARTMENT = '" & Cbo_Dept.Text & "' ORDER BY PONO"
        ElseIf Cbo_Option.SelectedIndex = 1 Then
            sqlstring = "select  DISTINCT PONO, PODEPARTMENT from po_vw_followup WHERE PODEPARTMENT = '" & Cbo_Dept.Text & "' ORDER BY PONO"
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

    Private Sub Chk_SelectAllVcode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectAllVcode.CheckedChanged
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
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='Purchase Order' AND MODULENAME LIKE 'Amendment- Follow-up Register%' ORDER BY RIGHTS"
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
End Class
