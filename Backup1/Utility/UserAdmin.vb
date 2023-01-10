Option Strict Off
Public Class UserAdmin
    Inherits System.Windows.Forms.Form
    Dim vClass As New GlobalClass
    Dim conn As New GlobalClass
    Dim UserName As String
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
    Friend WithEvents OptCU As System.Windows.Forms.RadioButton
    Friend WithEvents OptCP As System.Windows.Forms.RadioButton
    Friend WithEvents OptCR As System.Windows.Forms.RadioButton
    Friend WithEvents OptDU As System.Windows.Forms.RadioButton
    Friend WithEvents OptFP As System.Windows.Forms.RadioButton
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCPassword As System.Windows.Forms.TextBox
    Friend WithEvents lstUsers As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Ssgrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents gbNew As System.Windows.Forms.GroupBox
    Friend WithEvents gbUsers As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_confirm As System.Windows.Forms.Label
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents Lbl_Forget As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(UserAdmin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.OptFP = New System.Windows.Forms.RadioButton
        Me.OptDU = New System.Windows.Forms.RadioButton
        Me.OptCR = New System.Windows.Forms.RadioButton
        Me.OptCP = New System.Windows.Forms.RadioButton
        Me.OptCU = New System.Windows.Forms.RadioButton
        Me.gbNew = New System.Windows.Forms.GroupBox
        Me.lbl_confirm = New System.Windows.Forms.Label
        Me.txtCPassword = New System.Windows.Forms.TextBox
        Me.lbl_pass = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.gbUsers = New System.Windows.Forms.GroupBox
        Me.lstUsers = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Ssgrid = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdClear = New System.Windows.Forms.Button
        Me.Lbl_Forget = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.gbNew.SuspendLayout()
        Me.gbUsers.SuspendLayout()
        CType(Me.Ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.OptFP)
        Me.GroupBox1.Controls.Add(Me.OptDU)
        Me.GroupBox1.Controls.Add(Me.OptCR)
        Me.GroupBox1.Controls.Add(Me.OptCP)
        Me.GroupBox1.Controls.Add(Me.OptCU)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'OptFP
        '
        Me.OptFP.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OptFP.Location = New System.Drawing.Point(528, 13)
        Me.OptFP.Name = "OptFP"
        Me.OptFP.Size = New System.Drawing.Size(162, 19)
        Me.OptFP.TabIndex = 4
        Me.OptFP.Text = "Forgotten Password"
        '
        'OptDU
        '
        Me.OptDU.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OptDU.Location = New System.Drawing.Point(408, 13)
        Me.OptDU.Name = "OptDU"
        Me.OptDU.Size = New System.Drawing.Size(122, 19)
        Me.OptDU.TabIndex = 3
        Me.OptDU.Text = "Delete User"
        '
        'OptCR
        '
        Me.OptCR.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OptCR.Location = New System.Drawing.Point(272, 12)
        Me.OptCR.Name = "OptCR"
        Me.OptCR.Size = New System.Drawing.Size(128, 20)
        Me.OptCR.TabIndex = 2
        Me.OptCR.Text = "Change Rights"
        '
        'OptCP
        '
        Me.OptCP.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OptCP.Location = New System.Drawing.Point(109, 12)
        Me.OptCP.Name = "OptCP"
        Me.OptCP.Size = New System.Drawing.Size(146, 20)
        Me.OptCP.TabIndex = 1
        Me.OptCP.Text = "Change Password"
        '
        'OptCU
        '
        Me.OptCU.BackColor = System.Drawing.SystemColors.Desktop
        Me.OptCU.Checked = True
        Me.OptCU.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OptCU.Location = New System.Drawing.Point(7, 14)
        Me.OptCU.Name = "OptCU"
        Me.OptCU.Size = New System.Drawing.Size(97, 17)
        Me.OptCU.TabIndex = 0
        Me.OptCU.TabStop = True
        Me.OptCU.Text = "Create User"
        '
        'gbNew
        '
        Me.gbNew.Controls.Add(Me.lbl_confirm)
        Me.gbNew.Controls.Add(Me.txtCPassword)
        Me.gbNew.Controls.Add(Me.lbl_pass)
        Me.gbNew.Controls.Add(Me.Label1)
        Me.gbNew.Controls.Add(Me.txtPassword)
        Me.gbNew.Controls.Add(Me.txtusername)
        Me.gbNew.Location = New System.Drawing.Point(8, 35)
        Me.gbNew.Name = "gbNew"
        Me.gbNew.Size = New System.Drawing.Size(280, 93)
        Me.gbNew.TabIndex = 1
        Me.gbNew.TabStop = False
        '
        'lbl_confirm
        '
        Me.lbl_confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirm.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.lbl_confirm.Location = New System.Drawing.Point(9, 68)
        Me.lbl_confirm.Name = "lbl_confirm"
        Me.lbl_confirm.Size = New System.Drawing.Size(135, 16)
        Me.lbl_confirm.TabIndex = 7
        Me.lbl_confirm.Text = "Confirm Password"
        '
        'txtCPassword
        '
        Me.txtCPassword.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.txtCPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCPassword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPassword.Location = New System.Drawing.Point(152, 64)
        Me.txtCPassword.MaxLength = 10
        Me.txtCPassword.Name = "txtCPassword"
        Me.txtCPassword.PasswordChar = Microsoft.VisualBasic.ChrW(36)
        Me.txtCPassword.Size = New System.Drawing.Size(112, 23)
        Me.txtCPassword.TabIndex = 3
        Me.txtCPassword.Text = ""
        '
        'lbl_pass
        '
        Me.lbl_pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.lbl_pass.Location = New System.Drawing.Point(9, 44)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(95, 16)
        Me.lbl_pass.TabIndex = 5
        Me.lbl_pass.Text = "Password"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "User Name"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(152, 40)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(36)
        Me.txtPassword.Size = New System.Drawing.Size(112, 23)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = ""
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtusername.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(152, 16)
        Me.txtusername.MaxLength = 10
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(112, 23)
        Me.txtusername.TabIndex = 1
        Me.txtusername.Text = ""
        '
        'gbUsers
        '
        Me.gbUsers.Controls.Add(Me.lstUsers)
        Me.gbUsers.Location = New System.Drawing.Point(450, 39)
        Me.gbUsers.Name = "gbUsers"
        Me.gbUsers.Size = New System.Drawing.Size(256, 106)
        Me.gbUsers.TabIndex = 2
        Me.gbUsers.TabStop = False
        '
        'lstUsers
        '
        Me.lstUsers.BackColor = System.Drawing.SystemColors.Info
        Me.lstUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstUsers.Location = New System.Drawing.Point(4, 8)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(248, 93)
        Me.lstUsers.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(255, Byte), CType(255, Byte))
        Me.Label4.Location = New System.Drawing.Point(-8, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(736, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "_________________________________________________________________________________" & _
        "___________________________________________________________________"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ssgrid
        '
        Me.Ssgrid.DataSource = Nothing
        Me.Ssgrid.Location = New System.Drawing.Point(25, 168)
        Me.Ssgrid.Name = "Ssgrid"
        Me.Ssgrid.OcxState = CType(resources.GetObject("Ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ssgrid.Size = New System.Drawing.Size(656, 248)
        Me.Ssgrid.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdExit)
        Me.GroupBox4.Controls.Add(Me.cmdDelete)
        Me.GroupBox4.Controls.Add(Me.cmdAdd)
        Me.GroupBox4.Controls.Add(Me.cmdClear)
        Me.GroupBox4.Location = New System.Drawing.Point(188, 416)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(344, 40)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Aquamarine
        Me.cmdExit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.Location = New System.Drawing.Point(264, 13)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(76, 23)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "Exit [F11]"
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.Aquamarine
        Me.cmdDelete.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.Location = New System.Drawing.Point(178, 13)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(86, 23)
        Me.cmdDelete.TabIndex = 2
        Me.cmdDelete.Text = "Delete [F8]"
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.Aquamarine
        Me.cmdAdd.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Location = New System.Drawing.Point(87, 13)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(91, 23)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "Add [F7]"
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.Aquamarine
        Me.cmdClear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Location = New System.Drawing.Point(5, 13)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(82, 23)
        Me.cmdClear.TabIndex = 0
        Me.cmdClear.Text = "Clear [F6]"
        '
        'Lbl_Forget
        '
        Me.Lbl_Forget.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Forget.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
        Me.Lbl_Forget.Location = New System.Drawing.Point(304, 64)
        Me.Lbl_Forget.Name = "Lbl_Forget"
        Me.Lbl_Forget.Size = New System.Drawing.Size(135, 48)
        Me.Lbl_Forget.TabIndex = 8
        '
        'UserAdmin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(712, 462)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lbl_Forget)
        Me.Controls.Add(Me.Ssgrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbNew)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbUsers)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "UserAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserAdmin"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbNew.ResumeLayout(False)
        Me.gbUsers.ResumeLayout(False)
        CType(Me.Ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub UserAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmdDelete.Enabled = False
        Call FillModules()
    End Sub
    Private Sub UserAdmin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call ClearOperation()
        ElseIf e.KeyCode = Keys.F7 And cmdAdd.Enabled = True Then
            Call Addoperation()
        ElseIf e.KeyCode = Keys.F8 And cmdDelete.Enabled = True Then
            Call DeleteOperation()
        ElseIf e.KeyCode = Keys.F11 Then
            Me.Dispose(True)
        End If
    End Sub
    Private Sub GetRights()
        Dim ssql As String
        Dim i As Integer
        Dim j As Integer
        Dim Mname As String
        Dim Rights As String
        Dim ds As New DataSet
        Dim k As Integer
        Dim X() As Char
       
        ssql = " select Rights,U.ModuleName From UserAdmin U Inner Join ModuleMAster M "
        ssql = ssql & " On U.MainModuleId=M.MainModuleId and U.SubModuleId=M.SubModuleId and U.SsubModuleId=M.SsubModuleId "
        ssql = ssql & "where UserName='" & UserName & "' and M.PackageName='Purchase Order' "
        ds = conn.getdata(ssql, "Rights")
        If ds.Tables(0).Rows.Count > 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                For j = 1 To Ssgrid.DataRowCnt
                    Mname = Nothing
                    Ssgrid.GetText(1, j, Mname)
                    If Trim(Mname) = Trim(ds.Tables(0).Rows(i).Item("ModuleName")) Then
                        Rights = abcdMINUS(Trim(ds.Tables(0).Rows(i).Item(0)))
                        X = Rights.ToCharArray
                        For k = 0 To X.Length - 1
                            If X(k) = "A" Then Ssgrid.SetText(2, j, 1)
                            If X(k) = "S" Then Ssgrid.SetText(3, j, 1)
                            If X(k) = "M" Then Ssgrid.SetText(4, j, 1)
                            If X(k) = "D" Then Ssgrid.SetText(5, j, 1)
                            If X(k) = "V" Then Ssgrid.SetText(6, j, 1)
                            If X(k) = "P" Then Ssgrid.SetText(7, j, 1)
                        Next k
                        Exit For
                    End If
                Next j
            Next i
        End If
    End Sub
    Private Sub FillModules()
        Dim vDs As New DataSet
        Dim Loopindex, vIndex As Long
        Dim vMainname, vMain As String
        Dim vSubname, vSub As String
        Dim vSsubname, vSsub As String
        vDs = vClass.getdata("Select rowid,isnull(MainModuleId,'') AS MainModuleId,isnull(MainModuleName,'') as MainModuleName,isnull(subModuleId,'') as subModuleId,isnull(subModuleName,'') as subModuleName,isnull(ssubModuleId,'') as ssubModuleId,isnull(ssubModuleName,'') as ssubModuleName  from ModuleMaster where PackageName='Purchase Order' Order by MainModuleId,MainModuleName", "User")
        If vDs.Tables(0).Rows.Count - 1 > 0 Then
            vMain = Trim(vDs.Tables(0).Rows(0).Item("MainModuleId") & "")
            vSub = Trim(vDs.Tables(0).Rows(0).Item("subModuleId") & "")
            vSsub = Trim(vDs.Tables(0).Rows(0).Item("ssubModuleId") & "")
            Ssgrid.Col = 1
            Ssgrid.Row = 1
            Ssgrid.FontBold = True
            vMain = Trim(vDs.Tables(0).Rows(0).Item("MainModuleId") & "")
            Ssgrid.BlockMode = True
            'Ssgrid.Lock = True
            Ssgrid.BlockMode = False
            Ssgrid.SetText(1, 1, "<< " & Trim(vDs.Tables(0).Rows(0).Item("MainModuleName") & "") & " Modules  >>")
            Ssgrid.Col = 1
            Ssgrid.Col2 = Ssgrid.MaxCols
            Ssgrid.Row = 1
            Ssgrid.Row2 = 1
            Ssgrid.BlockMode = True
            'Ssgrid.Lock = True
            Ssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
            Ssgrid.BackColor = System.Drawing.Color.Bisque
            Ssgrid.BlockMode = False
            vIndex = vIndex + 2
            For Loopindex = 0 To vDs.Tables(0).Rows.Count - 1
                With vDs.Tables(0).Rows(Loopindex)
                    If Trim(vMain & "") <> Trim(.Item("MainModuleId") & "") Then
                        Ssgrid.Col = 1
                        Ssgrid.Row = vIndex
                        Ssgrid.FontBold = True
                        vMain = Trim(.Item("MainModuleId") & "")
                        Ssgrid.Col = 1
                        Ssgrid.Row = vIndex
                        Ssgrid.Col2 = Ssgrid.MaxCols
                        Ssgrid.Row2 = vIndex
                        Ssgrid.BlockMode = True
                        'Ssgrid.Lock = True
                        Ssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                        Ssgrid.BackColor = System.Drawing.Color.Bisque
                        Ssgrid.BlockMode = False
                        Ssgrid.SetText(1, vIndex, "<< " & Trim(.Item("MainModuleName") & "") & " Modules >>")
                        vIndex = vIndex + 1
                    End If
                    If vSsub <> Trim(.Item("SsubModuleID") & "") Then
                        vSsub = Trim(.Item("ssubModuleId") & "")
                        vSub = Trim(.Item("subModuleId") & "")
                        vMain = Trim(.Item("mainModuleId") & "")
                        Dim l As Long
                        Dim ds1 As New DataSet
                        ds1 = conn.getdata("Select rowid,isnull(MainModuleId,'') AS MainModuleId,isnull(MainModuleName,'') as MainModuleName,isnull(subModuleId,'') as subModuleId,isnull(subModuleName,'') as subModuleName,isnull(ssubModuleId,'') as ssubModuleId,isnull(ssubModuleName,'') as ssubModuleName  from ModuleMaster  where PackageName='Purchase Order' and mainModuleid ='" & vMain & "' and subModuleid ='" & vSub & "'", "sub")
                        If ds1.Tables(0).Rows.Count - 1 > 0 Then
                            Ssgrid.Col = 1
                            Ssgrid.Row = vIndex
                            Ssgrid.Col2 = Ssgrid.MaxCols
                            Ssgrid.Row2 = vIndex
                            Ssgrid.BlockMode = True
                            'Ssgrid.Lock = True
                            Ssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                            Ssgrid.BlockMode = False
                            Ssgrid.FontBold = False
                            Ssgrid.SetText(1, vIndex, Space(10) & Trim(ds1.Tables(0).Rows(0).Item("SubModuleName") & "" & "  ->>"))
                            Ssgrid.Col = 2
                            Ssgrid.Row = vIndex
                            Ssgrid.Col2 = Ssgrid.MaxCols
                            Ssgrid.Row2 = vIndex
                            Ssgrid.BlockMode = True
                            Ssgrid.Lock = True
                            Ssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                            Ssgrid.BlockMode = False
                            vIndex = vIndex + 1
                            For l = 0 To ds1.Tables(0).Rows.Count - 1
                                Ssgrid.Col = 1
                                Ssgrid.Row = vIndex
                                Ssgrid.FontBold = False
                                Ssgrid.SetText(1, vIndex, Space(18) & Trim(ds1.Tables(0).Rows(l).Item("sSubModuleName") & ""))
                                Ssgrid.SetText(8, vIndex, Trim(ds1.Tables(0).Rows(l).Item("Rowid") & ""))
                                vIndex = vIndex + 1
                            Next
                            Loopindex = Loopindex + ds1.Tables(0).Rows.Count
                            vSsub = Trim(.Item("ssubModuleId") & "")
                            vSub = Trim(.Item("subModuleId") & "")
                            vMain = Trim(.Item("mainModuleId") & "")
                            Loopindex = Loopindex - 1
                        Else
                            Ssgrid.Col = 1
                            Ssgrid.Row = vIndex
                            Ssgrid.FontBold = False
                            Ssgrid.SetText(1, vIndex, Space(10) & Trim(.Item("SubModuleName") & ""))
                            Ssgrid.SetText(8, vIndex, Trim(.Item("Rowid") & ""))
                            vIndex = vIndex + 1
                            vSsub = Trim(.Item("ssubModuleId") & "")
                            vSub = Trim(.Item("subModuleId") & "")
                            vMain = Trim(.Item("mainModuleId") & "")
                        End If
                    Else
                        Ssgrid.Col = 1
                        Ssgrid.Row = vIndex
                        Ssgrid.FontBold = False
                        Ssgrid.SetText(1, vIndex, Space(10) & Trim(.Item("SubModuleName") & ""))
                        Ssgrid.SetText(8, vIndex, Trim(.Item("Rowid") & ""))
                        vIndex = vIndex + 1
                        vSsub = Trim(.Item("ssubModuleId") & "")
                        vSub = Trim(.Item("subModuleId") & "")
                        vMain = Trim(.Item("mainModuleId") & "")
                    End If
                End With
            Next
        End If
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Dispose(True)
    End Sub
    Private Sub DeleteOperation()
        Dim qry() As String
        Try
            'DELETE OPERATION
            If Me.OptDU.Checked = True Then
                ReDim qry(1)
                If Trim(Me.txtusername.Text) <> "" Then
                    qry(0) = "Delete From Master..UserAdmin  where UserName='" & Trim(Me.txtusername.Text) & "' And MainGroup='Purchase Order' "
                    qry(1) = "Delete From UserAdmin  where UserName='" & Trim(Me.txtusername.Text) & "' And MainGroup='Purchase Order' "
                    conn.MoreTrans(qry)
                Else
                    MsgBox("Select The User Name To Be Deleted", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ClearOperation()
        gbNew.Enabled = True
        gbUsers.Enabled = False
        txtusername.Text = ""
        txtCPassword.Text = ""
        txtPassword.Text = ""
        txtusername.Enabled = True
        txtPassword.Enabled = True
        txtCPassword.Enabled = True
        cmdDelete.Enabled = False
        cmdAdd.Text = "&Add [F7]"
        Ssgrid.ClearRange(2, 2, Ssgrid.MaxCols, Ssgrid.DataRowCnt, False)
        Call getusers()
        Call FillModules()
    End Sub
    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        Call ClearOperation()
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Call Addoperation()
        ClearOperation()
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim x = MsgBox("Are You Sure to Delete The User", MsgBoxStyle.YesNo, "Cane Agri")
        If x = vbYes Then
            Call DeleteOperation()
            Call Me.ClearOperation()
        End If
    End Sub
    Private Function Myvalidate() As Boolean
        Myvalidate = True
        Dim i As Integer = 0
        Dim chk
        If OptCU.Checked = True Then
            If Trim(txtusername.Text & "") = "" Then
                Myvalidate = False
                MsgBox("Username cannot be Blank", MsgBoxStyle.Critical)
                If txtusername.Enabled = True Then
                    txtusername.Focus()
                End If
                Exit Function
            End If
            i = vClass.getvalue("Select Count(*) from UserAdmin where UserName='" & Me.txtusername.Text & "'")
            If Val(i) > 0 Then
                Myvalidate = False
                MsgBox("The User Name Already Exists", MsgBoxStyle.Critical)
                txtusername.Focus()
                Exit Function
            End If
            If Trim(txtPassword.Text & "") = "" Then
                Myvalidate = False
                MsgBox("Password cannot be Blank", MsgBoxStyle.Critical)
                If txtPassword.Enabled = True Then
                    txtPassword.Focus()
                End If
                Exit Function
            End If
            If Trim(txtCPassword.Text & "") = "" Then
                Myvalidate = False
                MsgBox("Confirm Password cannot be Blank", MsgBoxStyle.Critical)
                If txtCPassword.Enabled = True Then
                    txtCPassword.Focus()
                End If
                Exit Function
            End If
            If Me.txtPassword.Text <> Me.txtCPassword.Text Then
                Myvalidate = False
                MsgBox("The Password Mismatched", MsgBoxStyle.Critical)
                Me.txtCPassword.Focus()
                Exit Function
            End If
            ''''For i = 1 To Me.Ssgrid.DataRowCnt
            ''''    Dim j As Integer = 2
            ''''    For j = 2 To 7
            ''''        Ssgrid.GetText(j, i, chk)
            ''''        If Val(chk) = 1 Then Exit For
            ''''    Next
            ''''    If Val(chk) = 1 Then Exit For
            ''''Next
            ''''If Val(chk) = 0 Then
            ''''    Myvalidate = False
            ''''    MsgBox("No Rights has been assigned To The User", MsgBoxStyle.Critical)
            ''''    Exit Function
            ''''End If
        End If
    End Function
    Private Sub Ssgrid_ButtonClicked(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_ButtonClickedEvent) Handles Ssgrid.ButtonClicked
        If Ssgrid.ActiveCol = 2 Then
            Call fillrights1(Ssgrid.ActiveRow, Ssgrid.ActiveCol)
        Else
            Call fillrights(Ssgrid.ActiveRow, Ssgrid.ActiveCol)
        End If
    End Sub
    Sub fillrights(ByVal Vrow As Integer, ByVal vcol As Integer)
        Dim vAll, v1
        Ssgrid.GetText(2, Vrow, vAll)
        Ssgrid.GetText(vcol, Vrow, v1)
        If Val(vAll) = 1 Then
            If Val(v1) = 1 Then
                vAll = 0
                Ssgrid.Col = 2
                Ssgrid.Row = Vrow
                Ssgrid.Text = vAll
            End If
        Else
            Exit Sub
        End If
    End Sub
    Sub fillrights1(ByVal Vrow As Integer, ByVal vcol As Integer)
        Dim vAll, vadd, v1, v2, v3, v4, v5
        Ssgrid.GetText(2, Vrow, vAll)
        Ssgrid.GetText(3, Vrow, v1)
        Ssgrid.GetText(4, Vrow, v2)
        Ssgrid.GetText(5, Vrow, v3)
        Ssgrid.GetText(6, Vrow, v4)
        Ssgrid.GetText(7, Vrow, v5)
        vadd = 0
        If Val(vAll) = 1 Then
            If Val(v2) = 1 Then
                Ssgrid.SetText(4, Vrow, Val(vadd))
            End If
            If Val(v1) = 1 Then
                Ssgrid.SetText(3, Vrow, Val(vadd))
            End If
            If Val(v3) = 1 Then
                Ssgrid.SetText(5, Vrow, Val(vadd))
            End If
            If Val(v4) = 1 Then
                Ssgrid.SetText(6, Vrow, Val(vadd))
            End If
            If Val(v5) = 1 Then
                Ssgrid.SetText(7, Vrow, Val(vadd))
            End If
        Else
            Exit Sub
        End If
    End Sub
    Public Sub Addoperation()
        Dim i As Integer
        Dim vUserName As String
        Dim vUserPassword As String
        Dim Loopindex As Integer
        Dim vMainIndex As Integer
        Dim vIndex As Integer
        Dim vsplit() As String
        Dim vModuleId As String
        Dim vMainMenu As String, ssql As String
        Dim qry() As String
        If OptCU.Checked = True Then
            If Me.Myvalidate() = False Then Exit Sub
        End If
        If Me.OptCR.Checked = True Then
            If Trim(Me.txtusername.Text) <> "" Then
            Else
                MsgBox("Select The User Name For Change The User Rights", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        If Me.OptCP.Checked = True Then
            If Me.MyValidations_ChangePassword = False Then
                Exit Sub
            End If
        End If
        '-----------------NEW USER AND CHANGE RIGHTS----------------------------

        If OptCU.Checked = True Or Me.OptCR.Checked = True Then
            vUserName = Trim(txtusername.Text)
            vUserPassword = abcdADD(Trim(txtPassword.Text))  'GetPass(Trim(txtPassword))
            'Inserting User Admin -----------------
            'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
            'SMCDVP
            Dim Vmain, VmId, vAll, vADD, vModify, vCancel, vDelete, vView, vPrint
            Dim vMain1 As String
            Dim aryindex As Integer = 0
            Dim vSubIndex As Integer, vDesc As String
            For Loopindex = 1 To Ssgrid.DataRowCnt
                With Ssgrid
                    .Row = Loopindex
                    .Col = 1
                    Vmain = .Text
                    .Col = 2
                    vAll = .Text
                    .Col = 3
                    vADD = .Text
                    .Col = 4
                    vModify = .Text
                    .Col = 5
                    vDelete = .Text
                    .Col = 6
                    vView = .Text
                    .Col = 7
                    vPrint = .Text
                    .Col = 8
                    VmId = .Text
                End With
                If Trim(Vmain & "") <> "" Then
                    If Val(vAll & "") = 1 Then
                        vDesc = "A"  ' for All
                    Else
                        If Val(vADD & "") = 1 Then
                            vDesc = "S"
                        End If
                        If Val(vModify & "") = 1 Then
                            vDesc = vDesc & "M"
                        End If
                        If Val(vCancel & "") = 1 Then
                            vDesc = vDesc & "C"
                        End If
                        If Val(vDelete & "") = 1 Then
                            vDesc = vDesc & "D"
                        End If
                        If Val(vView & "") = 1 Then
                            vDesc = vDesc & "V"
                        End If
                        If Val(vPrint & "") = 1 Then
                            vDesc = vDesc & "P"
                        End If
                    End If
                    'Inserting into userAdmin table
                    If Trim(vDesc & "") <> "" Then
                        Dim ds As New DataSet
                        Dim Mname As String
                        ds = conn.getdata("Select * from ModuleMaster Where rowid=" & Val(VmId & ""), "Module")
                        ReDim Preserve qry(aryindex)
                        With ds.Tables(0).Rows(0)
                            If Val(.Item("SsubModuleid")) = 0 Then
                                Mname = Trim(.Item("submodulename"))
                            Else
                                Mname = Trim(.Item("ssubmodulename"))
                            End If
                            qry(qry.Length - 1) = "Insert into UserAdmin(UserName,UserPassword,Category,mainmoduleid,submoduleid,ssubmoduleid,Rights,modulename,MainGroup) " & _
                            " Values('" & Trim(vUserName) & "','" & Trim(vUserPassword) & "','U','" & Trim(.Item("MainModuleId") & "") & "','" & Trim(.Item("SubModuleid") & "") & "','" & Trim(.Item("SsubModuleid") & "") & "','" & Trim(abcdADD(vDesc) & "") & "','" & Trim(Mname) & "','Purchase Order')"
                            aryindex = aryindex + 1
                        End With
                    End If
                    vDesc = ""
                End If
            Next Loopindex
            If qry Is Nothing = False Then
                ReDim Preserve qry(qry.Length)
            Else
                MsgBox("Choose the Rights")
                Me.txtusername.Focus()
                Exit Sub
            End If
            'Insert into Master
            qry(qry.Length - 1) = "Insert into Master..UserAdmin(UserName,UserPassword,Category,MainGroup) " & _
             " values('" & Trim(vUserName) & "','" & Trim(vUserPassword) & "','U','Purchase Order')"
            If Me.OptCU.Checked = True Then
                conn.MoreTrans(qry)
            ElseIf Me.OptCR.Checked = True Then
                Dim str(qry.Length + 1) As String
                str(0) = "Delete From Master..UserAdmin  where UserName='" & Trim(Me.txtusername.Text) & "' AND MainGroup='Purchase Order'"
                str(1) = "Delete From UserAdmin  where UserName='" & Trim(Me.txtusername.Text) & "' And MainGroup='Purchase Order'"
                str.Copy(qry, 0, str, 2, qry.Length)
                conn.MoreTrans(str)
                Call ClearOperation()
                Exit Sub
            End If
        End If
        'CHANGE PASSWORD
        '----------------------------
        If Me.OptCP.Checked = True Then
            ReDim qry(1)
            If Trim(Me.txtusername.Text) <> "" Then
                qry(0) = "Update UserAdmin Set userpassword='" & Trim(abcdADD(Me.txtPassword.Text)) & "' where UserName='" & Trim(Me.txtusername.Text) & "' And MainGroup='Purchase Order' "
                qry(1) = "Update Master..UserAdmin Set userpassword='" & Trim(abcdADD(Me.txtPassword.Text)) & "' where UserName='" & Trim(Me.txtusername.Text) & "' AND And MainGroup='Purchase Order' "
                conn.MoreTrans(qry)
                Call ClearOperation()
                Exit Sub
            Else
                MsgBox("Select The User Name For Change The Password", MsgBoxStyle.Critical)
                Exit Sub
            End If
        End If
        Call ClearOperation()
    End Sub
    Sub getusers()
        Dim ds As New DataSet
        Dim i As Integer
        Me.lstUsers.Items.Clear()
        ds = conn.getdata("Select distinct UserName from useradmin WHERE IsNull(Category,'') <> 'S' and MainGroup='Purchase Order'", "User")
        If ds.Tables(0).Rows.Count > 0 Then
            'If Me.lstUsers.Items.Count > 0 Then Me.lstUsers.Items.Clear()
            Me.lstUsers.Enabled = True
            'Me.lstUsers.DataSource = ds
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Me.lstUsers.Items.Add(ds.Tables(0).Rows(i).Item(0))
            Next
            Me.lstUsers.SelectedIndex = -1
        Else
            MsgBox("No Users Aviliable", MsgBoxStyle.Information, "Purchase Order")
            ' Me.ClearOperation()
            Exit Sub
        End If
    End Sub
    Private Sub lstUsers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstUsers.Click


        If Me.lstUsers.Items.Count > 0 Then
            Dim ds As New DataSet
            ds = conn.getdata("Select * from useradmin where username='" & Me.lstUsers.Items.Item(lstUsers.SelectedIndex) & "' And MainGroup='Purchase Order' ", "User")
            Me.txtusername.Text = Me.lstUsers.Items.Item(lstUsers.SelectedIndex)

            'UserDetails(Trim(Me.txtusername.Text))
            Me.txtusername.Enabled = False

            If Me.OptCP.Checked = True Then
                Me.lbl_pass.Text = "New Password"
                Me.lbl_confirm.Text = "Confirm New Password"
                Me.Ssgrid.Enabled = False
            Else
                Me.txtPassword.Enabled = False
                Me.txtCPassword.Enabled = False

                If ds.Tables(0).Rows.Count > 0 Then
                    Me.txtPassword.Text = abcdMINUS(ds.Tables(0).Rows(0).Item("UserPassword"))
                    Me.txtCPassword.Text = abcdMINUS(ds.Tables(0).Rows(0).Item("UserPassword"))
                End If

                If Me.OptDU.Checked = True Or Me.OptFP.Checked = True Then
                    Me.Ssgrid.Enabled = False
                End If

                If Me.OptCR.Checked = True Then
                    Ssgrid.Enabled = True
                    UserName = Me.lstUsers.GetItemText(Me.lstUsers.SelectedItem)
                    Call GetRights()
                End If

                If Me.OptFP.Checked = True Then
                    If ds.Tables(0).Rows.Count > 0 Then
                        Me.Lbl_Forget.Text = "The Password :  " & UCase(abcdMINUS(Convert.ToString(ds.Tables(0).Rows(0).Item("UserPassword"))))
                    End If
                End If
            End If
        End If
    End Sub
    Sub UserDetails(ByVal UserName As String)
        Dim ds As New DataSet
        Dim cnt, sscnt, rcnt As Integer
        Dim Vdesc As String
        Dim vmain As Double
        ds = conn.getdata("Select isnull(ModuleName,0) as ModuleName,Isnull(Rights,'') as Rights From UserAdmin where UserName='" & UserName & "' And MainGroup='Purchase Order'", "User")
        If ds.Tables(0).Rows.Count > 0 Then
            For cnt = 0 To ds.Tables(0).Rows.Count - 1
                If ds.Tables(0).Rows(cnt).Item("ModuleName") <> 0 Then
                    For sscnt = 0 To Ssgrid.DataRowCnt
                        With Ssgrid
                            .Row = sscnt
                            .Col = 8
                            vmain = Val(.Text)
                            If Val(ds.Tables(0).Rows(cnt).Item("ModuleName")) = Val(vmain) Then
                                Vdesc = ds.Tables(0).Rows(cnt).Item("Rights")
                                Vdesc = abcdMINUS(Vdesc)
                                For rcnt = 1 To Len(Vdesc)
                                    If Trim(Mid(Vdesc, rcnt, 1) & "") = "A" Then
                                        Ssgrid.Col = 2
                                        Ssgrid.Action = 0
                                        Ssgrid.SetText(2, sscnt, 1)
                                        Exit For
                                    End If
                                    If Trim(Mid(Vdesc, rcnt, 1) & "") = "S" Then
                                        Ssgrid.Col = 3
                                        Ssgrid.Action = 0
                                        Ssgrid.SetText(3, sscnt, 1)
                                    End If
                                    If Trim(Mid(Vdesc, rcnt, 1) & "") = "M" Then
                                        Ssgrid.Col = 4
                                        Ssgrid.Action = 0
                                        Ssgrid.SetText(4, sscnt, 1)
                                    End If
                                    If Trim(Mid(Vdesc, rcnt, 1) & "") = "D" Then
                                        Ssgrid.Col = 5
                                        Ssgrid.Action = 0
                                        Ssgrid.SetText(5, sscnt, 1)
                                    End If
                                    If Trim(Mid(Vdesc, rcnt, 1) & "") = "V" Then
                                        Ssgrid.Col = 6
                                        Ssgrid.Action = 0
                                        Ssgrid.SetText(6, sscnt, 1)
                                    End If
                                    If Trim(Mid(Vdesc, rcnt, 1) & "") = "P" Then
                                        Ssgrid.Col = 7
                                        Ssgrid.Action = 0
                                        Ssgrid.SetText(7, sscnt, 1)
                                    End If
                                Next
                            End If
                        End With
                    Next
                End If
            Next
        End If
    End Sub
    Function MyValidations_ChangePassword() As Boolean
        MyValidations_ChangePassword = True
        If Trim(txtPassword.Text & "") = "" Then
            MyValidations_ChangePassword = False
            MsgBox("Password cannot be Blank", MsgBoxStyle.Critical)
            If txtPassword.Enabled = True Then
                txtPassword.Focus()
            End If
            Exit Function
        End If
        If Trim(txtCPassword.Text & "") = "" Then
            MyValidations_ChangePassword = False
            MsgBox("Confirm Password cannot be Blank", MsgBoxStyle.Critical)
            If txtCPassword.Enabled = True Then
                txtCPassword.Focus()
            End If
            Exit Function
        End If
        If Me.txtPassword.Text <> Me.txtCPassword.Text Then
            MyValidations_ChangePassword = False
            MsgBox("The Password Mismatched", MsgBoxStyle.Critical)
            Me.txtCPassword.Focus()
            Exit Function
        End If
    End Function
    Private Sub OptCU_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptCU.Click
        cmdDelete.Enabled = False
        cmdAdd.Text = "&Add(F7)"
        cmdAdd.Enabled = True
        Me.lbl_pass.Text = "Password"
        Me.lbl_confirm.Text = "Confirm Password"
        Lbl_Forget.Text = ""
        If Me.lstUsers.Items.Count > 0 Then
            Me.lstUsers.DataSource = Nothing
            Me.lstUsers.Items.Clear()
            Call ClearOperation()
        End If
        Me.Ssgrid.Enabled = True
        OptCU.Checked = True
        OptCU.Focus()
    End Sub
    Private Sub OptCP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptCP.Click
        OptCU.Checked = False
        OptFP.Checked = False
        OptDU.Checked = False
        OptCR.Checked = False
        Call ClearOperation()
        Lbl_Forget.Text = ""
        Me.txtusername.Enabled = False
        gbUsers.Enabled = True
        Me.lstUsers.Enabled = True
        Me.txtCPassword.Enabled = True
        Me.txtPassword.Enabled = True
        cmdDelete.Enabled = False
        cmdAdd.Text = "Update(F7)"
        cmdAdd.Enabled = True
        Call Me.getusers()
    End Sub
    Private Sub OptCR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptCR.Click
        If Me.OptCR.Checked = True Then
            Call ClearOperation()
            Me.lbl_pass.Text = "Password"
            Me.lbl_confirm.Text = "Confirm Password"
            Lbl_Forget.Text = ""
            Me.lstUsers.Enabled = True
            Me.Ssgrid.Enabled = True
            Me.gbUsers.Enabled = True
            Me.txtCPassword.Enabled = False
            Me.txtPassword.Enabled = False
            Me.txtusername.Enabled = False
            Ssgrid.Enabled = True
            cmdDelete.Enabled = False
            cmdAdd.Text = "Update(F7)"
            cmdAdd.Enabled = True
            Me.getusers()
        End If
    End Sub
    Private Sub OptDU_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptDU.Click
        If Me.OptDU.Checked = True Then
            Call ClearOperation()
            Me.lbl_pass.Text = "Password"
            Me.lbl_confirm.Text = "Confirm Password"
            Lbl_Forget.Text = ""
            Me.Ssgrid.Enabled = False
            Me.gbUsers.Enabled = True
            lstUsers.Enabled = True
            Me.txtCPassword.Enabled = False
            Me.txtPassword.Enabled = False
            Me.txtusername.Enabled = False
            cmdDelete.Enabled = True
            cmdAdd.Text = "&Add(F7)"
            cmdAdd.Enabled = False
            Me.getusers()
        End If
    End Sub
    Private Sub OptFP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptFP.Click
        If Me.OptFP.Checked = True Then
            Call ClearOperation()
            Me.lbl_pass.Text = "Password"
            Me.lbl_confirm.Text = "Confirm Password"
            Me.Ssgrid.Enabled = False
            Me.gbUsers.Enabled = True
            Lbl_Forget.Text = ""
            lstUsers.Enabled = True
            Me.txtCPassword.Enabled = False
            Me.txtPassword.Enabled = False
            Me.txtusername.Enabled = False
            cmdDelete.Enabled = False
            cmdAdd.Text = "&Add(F7)"
            cmdAdd.Enabled = False
            Call Me.getusers()
        End If
    End Sub
    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            txtPassword.Focus()
        End If
    End Sub
    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            txtCPassword.Focus()
        End If
    End Sub
    Private Sub txtCPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPassword.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.Chr(13) Then
            Ssgrid.Focus()
        End If
    End Sub
End Class