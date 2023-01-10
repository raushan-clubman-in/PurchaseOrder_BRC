Imports System.Data
Imports System.Data.SqlClient
Imports System.io
Public Class OtherTerms
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim vtype As String
    Dim SSQL As String
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim sqlstring As String
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
    Friend WithEvents ssgrid1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents CmdDel As System.Windows.Forms.Button
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents lbl_GroupCode As System.Windows.Forms.Label
    Friend WithEvents Txt_Othertermcode As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_OtherTerm_HelpCode As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OtherTerms))
        Me.ssgrid1 = New AxFPSpreadADO.AxfpSpread
        Me.CmdExit = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.CmdDel = New System.Windows.Forms.Button
        Me.CmdSave = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.Txt_Othertermcode = New System.Windows.Forms.TextBox
        Me.lbl_GroupCode = New System.Windows.Forms.Label
        Me.Cmd_OtherTerm_HelpCode = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ssgrid1
        '
        Me.ssgrid1.DataSource = Nothing
        Me.ssgrid1.Location = New System.Drawing.Point(32, 120)
        Me.ssgrid1.Name = "ssgrid1"
        Me.ssgrid1.OcxState = CType(resources.GetObject("ssgrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid1.Size = New System.Drawing.Size(544, 160)
        Me.ssgrid1.TabIndex = 1
        '
        'CmdExit
        '
        Me.CmdExit.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdExit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.ForeColor = System.Drawing.Color.White
        Me.CmdExit.Image = CType(resources.GetObject("CmdExit.Image"), System.Drawing.Image)
        Me.CmdExit.Location = New System.Drawing.Point(544, 16)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(104, 32)
        Me.CmdExit.TabIndex = 30
        Me.CmdExit.Text = "Exit[F11]"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(8, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 3
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(328, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 27
        Me.CmdView.Text = "List View [F9]"
        '
        'CmdDel
        '
        Me.CmdDel.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdDel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDel.ForeColor = System.Drawing.Color.White
        Me.CmdDel.Image = CType(resources.GetObject("CmdDel.Image"), System.Drawing.Image)
        Me.CmdDel.Location = New System.Drawing.Point(216, 16)
        Me.CmdDel.Name = "CmdDel"
        Me.CmdDel.Size = New System.Drawing.Size(104, 32)
        Me.CmdDel.TabIndex = 28
        Me.CmdDel.Text = "Freeze[F8]"
        '
        'CmdSave
        '
        Me.CmdSave.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSave.ForeColor = System.Drawing.Color.White
        Me.CmdSave.Image = CType(resources.GetObject("CmdSave.Image"), System.Drawing.Image)
        Me.CmdSave.Location = New System.Drawing.Point(112, 16)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(104, 32)
        Me.CmdSave.TabIndex = 2
        Me.CmdSave.Text = "Add[F7]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.CmdSave)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.Controls.Add(Me.CmdDel)
        Me.GroupBox2.Controls.Add(Me.CmdExit)
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 312)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 56)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbl_Heading.Location = New System.Drawing.Point(152, 24)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(310, 31)
        Me.lbl_Heading.TabIndex = 430
        Me.lbl_Heading.Text = "OTHER TERMS  MASTER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Othertermcode
        '
        Me.Txt_Othertermcode.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Othertermcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Othertermcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Othertermcode.Location = New System.Drawing.Point(276, 75)
        Me.Txt_Othertermcode.MaxLength = 10
        Me.Txt_Othertermcode.Name = "Txt_Othertermcode"
        Me.Txt_Othertermcode.Size = New System.Drawing.Size(189, 26)
        Me.Txt_Othertermcode.TabIndex = 0
        Me.Txt_Othertermcode.Text = ""
        '
        'lbl_GroupCode
        '
        Me.lbl_GroupCode.AutoSize = True
        Me.lbl_GroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupCode.Location = New System.Drawing.Point(88, 80)
        Me.lbl_GroupCode.Name = "lbl_GroupCode"
        Me.lbl_GroupCode.Size = New System.Drawing.Size(182, 22)
        Me.lbl_GroupCode.TabIndex = 431
        Me.lbl_GroupCode.Text = "OTHER TERM  CODE :"
        '
        'Cmd_OtherTerm_HelpCode
        '
        Me.Cmd_OtherTerm_HelpCode.Image = CType(resources.GetObject("Cmd_OtherTerm_HelpCode.Image"), System.Drawing.Image)
        Me.Cmd_OtherTerm_HelpCode.Location = New System.Drawing.Point(468, 75)
        Me.Cmd_OtherTerm_HelpCode.Name = "Cmd_OtherTerm_HelpCode"
        Me.Cmd_OtherTerm_HelpCode.Size = New System.Drawing.Size(23, 26)
        Me.Cmd_OtherTerm_HelpCode.TabIndex = 432
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(160, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 17)
        Me.Label1.TabIndex = 433
        Me.Label1.Text = "Don't Use Single Quote (') anywhere in the Form."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Menu
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(432, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "VALIDATE"
        '
        'OtherTerms
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(664, 390)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.Txt_Othertermcode)
        Me.Controls.Add(Me.lbl_GroupCode)
        Me.Controls.Add(Me.Cmd_OtherTerm_HelpCode)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ssgrid1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "OtherTerms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Other Terms Master"
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub rem1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        ssgrid1.ClearRange(1, 1, -1, -1, True)
        Me.Txt_Othertermcode.Focus()
    End Sub

    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='Purchase Order' AND MODULENAME LIKE 'Other Terms%'"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.CmdSave.Enabled = False
        Me.CmdDel.Enabled = False
        Me.CmdView.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdSave.Enabled = True
                    Me.CmdDel.Enabled = True
                    Me.CmdView.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.CmdSave.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.CmdSave.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.CmdSave.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.CmdDel.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub DeleteOperation()
        Dim MainMenu As Object
        Dim vAns As String
        vAns = CStr(MsgBox("Do you want to Delete", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, Me.Text))
        If vAns = CStr(MsgBoxResult.No) Then
            Exit Sub
        End If
        SSQL = "Delete from PO_OTHERTERMS where TRANTYPE ='" & Trim(Txt_Othertermcode.Text) & "' AND DOCTYPE = 'OTHERTERMS' "
        gconnection.dataOperation(6, SSQL, "PO_OTHERTERMS")
        MsgBox("Record Deleted Successfully", MsgBoxStyle.Information, Me.Text)
        Call ClearOperation()
        Exit Sub
    End Sub
    Private Sub CmdDel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call DeleteOperation()
    End Sub
    Private Sub CmdClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClearOperation()
    End Sub
    Private Sub CmdSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call AddOperation()
    End Sub
    Private Sub rem1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call ClearOperation()
        End If
        If e.KeyCode = Keys.F7 Then
            Call AddOperation()
        End If
        If e.KeyCode = Keys.F8 Then
            Call DeleteOperation()
        End If
        If e.KeyCode = Keys.F9 Then
            Call CmdView_Click(sender, e)
        End If
        If e.KeyCode = Keys.F11 Then
            Me.Close()
        End If
    End Sub
    Private Sub ClearOperation()
        ssgrid1.ClearRange(1, 1, ssgrid1.MaxCols, ssgrid1.MaxRows, True)
        Me.Txt_Othertermcode.Text = ""
        CmdDel.Enabled = False
        CmdSave.Text = "Add(F7)"
        Me.Txt_Othertermcode.Focus()
    End Sub
    Private Sub AddOperation()
        Dim MainMenu As Object
        Dim Loopindex As Integer
        Dim SSQL(10), SqlArray() As String
        Dim Vdesc As Object
        If ssgrid1.DataRowCnt = 0 Then
            MsgBox("Grid Details cannot be Blank", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If
        SSQL(0) = "Delete from PO_OTHERTERMS where Doctype = 'OTHERTERMS' and Trantype = '" & Trim(Txt_Othertermcode.Text) & "' "
        For Loopindex = 1 To ssgrid1.DataRowCnt
            Vdesc = Nothing
            ssgrid1.GetText(1, Loopindex, Vdesc)
            SSQL(Loopindex) = "Insert into PO_OTHERTERMS(doctype,Trantype,Slno,Message) values("
            SSQL(Loopindex) = SSQL(Loopindex) & " 'OTHERTERMS','" & Trim(Txt_Othertermcode.Text) & "','" & Loopindex & "', '" & Vdesc & "')"
        Next Loopindex

        ReDim SqlArray(SSQL.Length)
        SqlArray.Copy(SSQL, SqlArray, SSQL.Length)
        gconnection.MoreTrans1(SqlArray)

        If Mid(CmdSave.Text, 1, 1) = "A" Then
            MsgBox("Record Saved Successfully", MsgBoxStyle.Information)
        Else
            MsgBox("Record Updated Successfully", MsgBoxStyle.Information)
        End If
        Call ClearOperation()
    End Sub

    Private Sub ssgrid1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid1.KeyDownEvent
        If e.keyCode = Keys.Enter Then
            With ssgrid1
                .Row = .ActiveRow
                .Col = 1
                ssgrid1.SetActiveCell(1, ssgrid1.ActiveRow + 1)
            End With
        End If
        If e.keyCode = Keys.F3 Then
            ssgrid1.Row = ssgrid1.ActiveRow
            ssgrid1.Action = 5
        End If
        If e.keyCode = Keys.F4 Then
            ssgrid1.Row = ssgrid1.ActiveRow
            ssgrid1.Action = 7
        End If
    End Sub
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Dim FrReport As New ReportDesigner
        tables = " PO_OTHERTERMS "
        Gheader = "OTHER TERMS"
        FrReport.SsGridReport.SetText(2, 1, "MESSAGE")
        FrReport.SsGridReport.SetText(3, 1, 79)
        FrReport.Show()
    End Sub
    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Hide()
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        ClearOperation()
    End Sub
    Private Sub CmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDel.Click
        DeleteOperation()
    End Sub
    Private Sub CmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        AddOperation()
    End Sub

    Private Sub Cmd_OtherTerm_HelpCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_OtherTerm_HelpCode.Click
        gSQLString = " SELECT ISNULL(TRANTYPE,'') AS TRANTYPE,ISNULL(DOCTYPE,'') AS DOCTYPE FROM PO_OTHERTERMS "
        M_WhereCondition = " WHERE DOCTYPE = 'OTHERTERMS' "
        Dim vform As New List_Operation
        vform.Field = "TRANTYPE,DOCTYPE"
        vform.vFormatstring = "     OTHERTERM CODE              |             OTHERTERM DESCRIPTION  "
        vform.vCaption = "OTHER TERM MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            Txt_Othertermcode.Text = Trim(vform.keyfield & "")
            Call Txt_Othertermcode_Validated(Txt_Othertermcode, e)
        End If
        vform.Close()
        vform = Nothing
        'CmdDel.Enabled = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub

    Private Sub Txt_Othertermcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Othertermcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Me.Txt_Othertermcode.Text <> "" Then
                Call FillMatter()
            Else
                ssgrid1.SetActiveCell(1, 1)
            End If
        End If
    End Sub

    Private Sub Txt_Othertermcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Othertermcode.Validated
        If Me.Txt_Othertermcode.Text <> "" Then
            Call FillMatter()
        End If
        If gUserCategory <> "S" Then
            Call GetRights()
        End If

    End Sub

    Private Sub Txt_Othertermcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_Othertermcode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call Cmd_OtherTerm_HelpCode_Click(sender, e)
        End If
    End Sub

    Function FillMatter()
        Dim MainMenu As Object
        Dim ADODB As Object
        Dim Loopindex As Integer
        Dim vtype As String
        Dim i As Integer
        Dim bill As New DataTable
        Dim bill1 As New DataTable
        Dim dt As New DataTable
        Dim TNAME As String
        TNAME = "MESSAGE"
        sqlstring = "Select * from PO_OTHERTERMS where Trantype='" & Trim(Txt_Othertermcode.Text) & "' and DOCTYPE='OTHERTERMS' order by slno"
        bill = gconnection.GetValues(sqlstring)
        If bill.Rows.Count > 0 Then
            Loopindex = 0
            ssgrid1.ClearRange(1, 1, -1, -1, True)
            ssgrid1.Focus()
            For i = 0 To bill.Rows.Count - 1
                Loopindex = Loopindex + 1
                ssgrid1.SetText(1, Loopindex, bill.Rows(i).Item("MESSAGE"))
            Next
            CmdDel.Enabled = True
            CmdSave.Text = "Update(F7)"
            ssgrid1.SetActiveCell(1, 1)
        Else
            ssgrid1.ClearRange(1, 1, -1, -1, True)
            Show()
            ssgrid1.Focus()
            ssgrid1.SetActiveCell(1, 1)
        End If
    End Function

    Private Sub Cmd_OtherTerm_HelpCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmd_OtherTerm_HelpCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Cmd_OtherTerm_HelpCode_Click(sender, e)
        End If
    End Sub

    Private Sub Txt_Othertermcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Othertermcode.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start(AppPath & "\STUDY\OTHERTERMMASTER.XLS")
    End Sub
End Class