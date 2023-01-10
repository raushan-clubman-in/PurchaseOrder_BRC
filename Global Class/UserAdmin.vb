Option Strict Off
Public Class UserAdmin
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
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
    Friend WithEvents gbNew As System.Windows.Forms.GroupBox
    Friend WithEvents gbUsers As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_confirm As System.Windows.Forms.Label
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents Lbl_Forget As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
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
        Me.Lbl_Forget = New System.Windows.Forms.Label
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdClear = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.gbNew.SuspendLayout()
        Me.gbUsers.SuspendLayout()
        CType(Me.Ssgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.OptFP)
        Me.GroupBox1.Controls.Add(Me.OptDU)
        Me.GroupBox1.Controls.Add(Me.OptCR)
        Me.GroupBox1.Controls.Add(Me.OptCP)
        Me.GroupBox1.Controls.Add(Me.OptCU)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'OptFP
        '
        Me.OptFP.BackColor = System.Drawing.Color.Transparent
        Me.OptFP.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFP.ForeColor = System.Drawing.Color.Black
        Me.OptFP.Location = New System.Drawing.Point(568, 13)
        Me.OptFP.Name = "OptFP"
        Me.OptFP.Size = New System.Drawing.Size(176, 19)
        Me.OptFP.TabIndex = 4
        Me.OptFP.Text = "FORGOTTEN PASSWORD"
        '
        'OptDU
        '
        Me.OptDU.BackColor = System.Drawing.Color.Transparent
        Me.OptDU.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDU.ForeColor = System.Drawing.Color.Black
        Me.OptDU.Location = New System.Drawing.Point(448, 13)
        Me.OptDU.Name = "OptDU"
        Me.OptDU.Size = New System.Drawing.Size(120, 19)
        Me.OptDU.TabIndex = 3
        Me.OptDU.Text = "DELETE USER"
        '
        'OptCR
        '
        Me.OptCR.BackColor = System.Drawing.Color.Transparent
        Me.OptCR.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCR.ForeColor = System.Drawing.Color.Black
        Me.OptCR.Location = New System.Drawing.Point(304, 12)
        Me.OptCR.Name = "OptCR"
        Me.OptCR.Size = New System.Drawing.Size(128, 20)
        Me.OptCR.TabIndex = 2
        Me.OptCR.Text = "CHANGE RIGHTS"
        '
        'OptCP
        '
        Me.OptCP.BackColor = System.Drawing.Color.Transparent
        Me.OptCP.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCP.ForeColor = System.Drawing.Color.Black
        Me.OptCP.Location = New System.Drawing.Point(144, 12)
        Me.OptCP.Name = "OptCP"
        Me.OptCP.Size = New System.Drawing.Size(152, 20)
        Me.OptCP.TabIndex = 1
        Me.OptCP.Text = "CHANGE PASSWORD"
        '
        'OptCU
        '
        Me.OptCU.BackColor = System.Drawing.Color.Transparent
        Me.OptCU.Checked = True
        Me.OptCU.Font = New System.Drawing.Font("Century", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCU.ForeColor = System.Drawing.Color.Black
        Me.OptCU.Location = New System.Drawing.Point(16, 14)
        Me.OptCU.Name = "OptCU"
        Me.OptCU.Size = New System.Drawing.Size(113, 17)
        Me.OptCU.TabIndex = 0
        Me.OptCU.TabStop = True
        Me.OptCU.Text = "CREATE USER"
        '
        'gbNew
        '
        Me.gbNew.BackgroundImage = CType(resources.GetObject("gbNew.BackgroundImage"), System.Drawing.Image)
        Me.gbNew.Controls.Add(Me.lbl_confirm)
        Me.gbNew.Controls.Add(Me.txtCPassword)
        Me.gbNew.Controls.Add(Me.lbl_pass)
        Me.gbNew.Controls.Add(Me.Label1)
        Me.gbNew.Controls.Add(Me.txtPassword)
        Me.gbNew.Controls.Add(Me.txtusername)
        Me.gbNew.Location = New System.Drawing.Point(8, 35)
        Me.gbNew.Name = "gbNew"
        Me.gbNew.Size = New System.Drawing.Size(328, 149)
        Me.gbNew.TabIndex = 1
        Me.gbNew.TabStop = False
        '
        'lbl_confirm
        '
        Me.lbl_confirm.AllowDrop = True
        Me.lbl_confirm.BackColor = System.Drawing.Color.Transparent
        Me.lbl_confirm.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirm.ForeColor = System.Drawing.Color.Black
        Me.lbl_confirm.Location = New System.Drawing.Point(0, 112)
        Me.lbl_confirm.Name = "lbl_confirm"
        Me.lbl_confirm.Size = New System.Drawing.Size(168, 16)
        Me.lbl_confirm.TabIndex = 7
        Me.lbl_confirm.Text = "CONFIRM PASSWORD :"
        '
        'txtCPassword
        '
        Me.txtCPassword.BackColor = System.Drawing.Color.Wheat
        Me.txtCPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCPassword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPassword.Location = New System.Drawing.Point(176, 108)
        Me.txtCPassword.MaxLength = 10
        Me.txtCPassword.Name = "txtCPassword"
        Me.txtCPassword.PasswordChar = Microsoft.VisualBasic.ChrW(36)
        Me.txtCPassword.Size = New System.Drawing.Size(144, 23)
        Me.txtCPassword.TabIndex = 3
        Me.txtCPassword.Text = ""
        '
        'lbl_pass
        '
        Me.lbl_pass.AllowDrop = True
        Me.lbl_pass.BackColor = System.Drawing.Color.Transparent
        Me.lbl_pass.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.ForeColor = System.Drawing.Color.Black
        Me.lbl_pass.Location = New System.Drawing.Point(73, 66)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(95, 16)
        Me.lbl_pass.TabIndex = 5
        Me.lbl_pass.Text = "PASSWORD :"
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(65, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "USER NAME :"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Wheat
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPassword.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(176, 64)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Microsoft.VisualBasic.ChrW(36)
        Me.txtPassword.Size = New System.Drawing.Size(144, 23)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Text = ""
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.Wheat
        Me.txtusername.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtusername.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(176, 24)
        Me.txtusername.MaxLength = 10
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(144, 23)
        Me.txtusername.TabIndex = 1
        Me.txtusername.Text = ""
        '
        'gbUsers
        '
        Me.gbUsers.BackgroundImage = CType(resources.GetObject("gbUsers.BackgroundImage"), System.Drawing.Image)
        Me.gbUsers.Controls.Add(Me.lstUsers)
        Me.gbUsers.Location = New System.Drawing.Point(488, 39)
        Me.gbUsers.Name = "gbUsers"
        Me.gbUsers.Size = New System.Drawing.Size(272, 145)
        Me.gbUsers.TabIndex = 2
        Me.gbUsers.TabStop = False
        '
        'lstUsers
        '
        Me.lstUsers.BackColor = System.Drawing.SystemColors.Info
        Me.lstUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstUsers.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUsers.ItemHeight = 16
        Me.lstUsers.Location = New System.Drawing.Point(6, 10)
        Me.lstUsers.Name = "lstUsers"
        Me.lstUsers.Size = New System.Drawing.Size(260, 130)
        Me.lstUsers.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(255, Byte), CType(255, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(744, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "_________________________________________________________________________________" & _
        "___________________________________________________________________"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ssgrid
        '
        Me.Ssgrid.DataSource = Nothing
        Me.Ssgrid.Location = New System.Drawing.Point(8, 208)
        Me.Ssgrid.Name = "Ssgrid"
        Me.Ssgrid.OcxState = CType(resources.GetObject("Ssgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Ssgrid.Size = New System.Drawing.Size(752, 248)
        Me.Ssgrid.TabIndex = 4
        '
        'Lbl_Forget
        '
        Me.Lbl_Forget.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Forget.Font = New System.Drawing.Font("Century", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Forget.ForeColor = System.Drawing.Color.Black
        Me.Lbl_Forget.Location = New System.Drawing.Point(344, 88)
        Me.Lbl_Forget.Name = "Lbl_Forget"
        Me.Lbl_Forget.Size = New System.Drawing.Size(135, 48)
        Me.Lbl_Forget.TabIndex = 8
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(504, 480)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(104, 32)
        Me.cmdExit.TabIndex = 12
        Me.cmdExit.Text = "Exit[F11]"
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDelete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(384, 480)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(104, 32)
        Me.cmdDelete.TabIndex = 13
        Me.cmdDelete.Text = "Delete[F8]"
        '
        'cmdClear
        '
        Me.cmdClear.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.ForeColor = System.Drawing.Color.White
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.Location = New System.Drawing.Point(144, 480)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(104, 32)
        Me.cmdClear.TabIndex = 14
        Me.cmdClear.Text = "Clear[F6]"
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.ForestGreen
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAdd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.ForeColor = System.Drawing.Color.White
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.Location = New System.Drawing.Point(264, 480)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(104, 32)
        Me.cmdAdd.TabIndex = 15
        Me.cmdAdd.Text = "Add [F7]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(112, 464)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(533, 56)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        '
        'UserAdmin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(768, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Lbl_Forget)
        Me.Controls.Add(Me.Ssgrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbNew)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbUsers)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "UserAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USER ADMIN"
        Me.GroupBox1.ResumeLayout(False)
        Me.gbNew.ResumeLayout(False)
        Me.gbUsers.ResumeLayout(False)
        CType(Me.Ssgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub UserAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        UserAdminbool = True
        Me.cmdDelete.Enabled = False
        UserAdminbool = True
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
            Me.Close()
        End If
    End Sub
    Private Sub GetRights()
        Dim i, j, k As Integer
        Dim Sqlstring, Mname, Rights As String
        Dim X() As Char
        Sqlstring = " SELECT ISNULL(RIGHTS,'') AS RIGHTS,ISNULL(U.MODULENAME,'') AS MODULENAME FROM USERADMIN AS U INNER JOIN MODULEMASTER AS M "
        Sqlstring = Sqlstring & " ON U.MAINMODULEID = M.MAINMODULEID AND U.SUBMODULEID = M.SUBMODULEID AND U.SSUBMODULEID=M.SSUBMODULEID "
        Sqlstring = Sqlstring & " WHERE USERNAME = '" & Trim(UserName) & "' AND ISNULL(M.PACKAGENAME,'') ='INV' "
        gconnection.getDataSet(Sqlstring, "RIGHTS")
        If gdataset.Tables("RIGHTS").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("RIGHTS").Rows.Count - 1
                For j = 1 To Ssgrid.DataRowCnt
                    Mname = Nothing
                    Ssgrid.GetText(1, j, Mname)
                    If Trim(Mname) = Trim(gdataset.Tables("RIGHTS").Rows(i).Item("ModuleName")) Then
                        Rights = abcdMINUS(Trim(gdataset.Tables("RIGHTS").Rows(i).Item(0)))
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
        Dim Loopindex, vIndex, l As Long
        Dim vMainname, vMain As String
        Dim vSubname, vSub, Sqlstring As String
        Dim vSsubname, vSsub As String
        Sqlstring = "SELECT ISNULL(ROWID,0) AS ROWID,ISNULL(MAINMODULEID,'') AS MAINMODULEID,ISNULL(MAINMODULENAME,'') AS MAINMODULENAME,ISNULL(SUBMODULEID,'') AS SUBMODULEID,"
        Sqlstring = Sqlstring & "ISNULL(SUBMODULENAME,'') AS SUBMODULENAME,ISNULL(SSUBMODULEID,'') AS SSUBMODULEID,ISNULL(SSUBMODULENAME,'') AS SSUBMODULENAME  FROM MODULEMASTER WHERE PACKAGENAME = 'INV' ORDER BY MAINMODULEID,MAINMODULENAME"
        gconnection.getDataSet(Sqlstring, "USER")
        If gdataset.Tables("USER").Rows.Count > 0 Then
            vMain = Trim(gdataset.Tables("USER").Rows(0).Item("MainModuleId") & "")
            vSub = Trim(gdataset.Tables("USER").Rows(0).Item("subModuleId") & "")
            vSsub = Trim(gdataset.Tables("USER").Rows(0).Item("ssubModuleId") & "")
            Ssgrid.Col = 1
            Ssgrid.Row = 1
            Ssgrid.FontBold = True
            vMain = Trim(gdataset.Tables("USER").Rows(0).Item("MainModuleId") & "")
            Ssgrid.BlockMode = True
            '''************************************************** Ssgrid.Lock = True
            Ssgrid.BlockMode = False
            Ssgrid.SetText(1, 1, "<< " & Trim(gdataset.Tables("USER").Rows(0).Item("MainModuleName") & "") & " Modules  >>")
            Ssgrid.Col = 1
            Ssgrid.Col2 = Ssgrid.MaxCols
            Ssgrid.Row = 1
            Ssgrid.Row2 = 1
            Ssgrid.BlockMode = True
            '''************************************************** Ssgrid.Lock = True
            Ssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
            Ssgrid.BackColor = System.Drawing.Color.Bisque
            Ssgrid.BlockMode = False
            vIndex = vIndex + 2
            For Loopindex = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(Loopindex)
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
                        Sqlstring = "SELECT ISNULL(ROWID,0) AS ROWID,ISNULL(MAINMODULEID,'') AS MAINMODULEID,ISNULL(MAINMODULENAME,'') AS MAINMODULENAME,ISNULL(SUBMODULEID,'') AS SUBMODULEID,"
                        Sqlstring = Sqlstring & "ISNULL(SUBMODULENAME,'') AS SUBMODULENAME,ISNULL(SSUBMODULEID,'') AS SSUBMODULEID,ISNULL(SSUBMODULENAME,'') AS SSUBMODULENAME  FROM MODULEMASTER WHERE PACKAGENAME = 'INV' AND MAINMODULEID ='" & Trim(vMain) & "' AND SUBMODULEID ='" & Trim(vSub) & "' ORDER BY MAINMODULEID,MAINMODULENAME"
                        gconnection.getDataSet(Sqlstring, "SUB")
                        If gdataset.Tables("SUB").Rows.Count > 0 Then
                            Ssgrid.Col = 1
                            Ssgrid.Row = vIndex
                            Ssgrid.Col2 = Ssgrid.MaxCols
                            Ssgrid.Row2 = vIndex
                            Ssgrid.BlockMode = True
                            'Ssgrid.Lock = True
                            Ssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                            Ssgrid.BlockMode = False
                            Ssgrid.FontBold = False
                            Ssgrid.SetText(1, vIndex, Space(10) & Trim(gdataset.Tables("SUB").Rows(0).Item("SubModuleName") & "" & "  ->>"))
                            Ssgrid.Col = 2
                            Ssgrid.Row = vIndex
                            Ssgrid.Col2 = Ssgrid.MaxCols
                            Ssgrid.Row2 = vIndex
                            Ssgrid.BlockMode = True
                            Ssgrid.Lock = True
                            Ssgrid.CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                            Ssgrid.BlockMode = False
                            vIndex = vIndex + 1
                            For l = 0 To gdataset.Tables("SUB").Rows.Count - 1
                                Ssgrid.Col = 1
                                Ssgrid.Row = vIndex
                                Ssgrid.FontBold = False
                                Ssgrid.SetText(1, vIndex, Space(18) & Trim(gdataset.Tables("SUB").Rows(l).Item("sSubModuleName") & ""))
                                Ssgrid.SetText(8, vIndex, Trim(gdataset.Tables("SUB").Rows(l).Item("Rowid") & ""))
                                vIndex = vIndex + 1
                            Next
                            Loopindex = Loopindex + gdataset.Tables("SUB").Rows.Count
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

    Private Sub DeleteOperation()
        Dim qry() As String
        Try
            '''****************************************************** $ DELETE OPERATION $ ***************************''
            If Me.OptDU.Checked = True Then
                ReDim qry(1)
                If Trim(Me.txtusername.Text) <> "" Then
                    qry(0) = "Delete From Master..UserAdmin  where UserName='" & Trim(Me.txtusername.Text) & "' And MainGroup='INV' "
                    qry(1) = "Delete From UserAdmin  where UserName='" & Trim(Me.txtusername.Text) & "' And MainGroup='INV' "
                    gconnection.MoreTrans(qry)
                Else
                    MsgBox("Select The User Name To Be Deleted", MsgBoxStyle.Critical, MyCompanyName)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Exit Sub
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
        cmdAdd.Text = "Add [F7]"
        Ssgrid.ClearRange(2, 2, Ssgrid.MaxCols, Ssgrid.DataRowCnt, False)
        Call getusers()
        Call FillModules()
    End Sub


    Private Function Myvalidate() As Boolean
        Myvalidate = True
        Dim i As Integer = 0
        Dim chk
        If OptCU.Checked = True Then
            If Trim(txtusername.Text & "") = "" Then
                Myvalidate = False
                MsgBox("Username cannot be Blank", MsgBoxStyle.Critical, MyCompanyName)
                If txtusername.Enabled = True Then
                    txtusername.Focus()
                End If
                Exit Function
            End If
            i = gconnection.getvalue("Select Count(*) from UserAdmin where UserName='" & Me.txtusername.Text & "'")
            If Val(i) > 0 Then
                Myvalidate = False
                MsgBox("The User Name Already Exists", MsgBoxStyle.Critical, MyCompanyName)
                txtusername.Focus()
                Exit Function
            End If
            If Trim(txtPassword.Text & "") = "" Then
                Myvalidate = False
                MsgBox("Password cannot be Blank", MsgBoxStyle.Critical, MyCompanyName)
                If txtPassword.Enabled = True Then
                    txtPassword.Focus()
                End If
                Exit Function
            End If
            If Trim(txtCPassword.Text & "") = "" Then
                Myvalidate = False
                MsgBox("Confirm Password cannot be Blank", MsgBoxStyle.Critical, MyCompanyName)
                If txtCPassword.Enabled = True Then
                    txtCPassword.Focus()
                End If
                Exit Function
            End If
            If Me.txtPassword.Text <> Me.txtCPassword.Text Then
                Myvalidate = False
                MsgBox("The Password Mismatched", MsgBoxStyle.Critical, MyCompanyName)
                Me.txtCPassword.Focus()
                Exit Function
            End If
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
        Dim vUserName, Sqlstring As String
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
                MsgBox("Select The User Name For Change The User Rights", MsgBoxStyle.Critical, MyCompanyName)
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
                Ssgrid.Row = Loopindex
                Ssgrid.Col = 1
                Vmain = Ssgrid.Text
                Ssgrid.Col = 2
                vAll = Ssgrid.Text
                Ssgrid.Col = 3
                vADD = Ssgrid.Text
                Ssgrid.Col = 4
                vModify = Ssgrid.Text
                Ssgrid.Col = 5
                vDelete = Ssgrid.Text
                Ssgrid.Col = 6
                vView = Ssgrid.Text
                Ssgrid.Col = 7
                vPrint = Ssgrid.Text
                Ssgrid.Col = 8
                VmId = Ssgrid.Text
                If Trim(Vmain & "") <> "" Then
                    If Val(vAll & "") = 1 Then
                        vDesc = "A"  ''''FOR ALL FACILITY
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
                    ''''*************************** Inserting into userAdmin table
                    If Trim(vDesc & "") <> "" Then
                        Dim Mname As String
                        Sqlstring = " SELECT * FROM MODULEMASTER WHERE ROWID = " & Val(VmId) & ""
                        gconnection.getDataSet(Sqlstring, "MODULE")
                        If gdataset.Tables("MODULE").Rows.Count > 0 Then
                            ReDim Preserve qry(aryindex)
                            With gdataset.Tables("MODULE").Rows(0)
                                If Val(.Item("SsubModuleid")) = 0 Then
                                    Mname = Trim(.Item("submodulename"))
                                Else
                                    Mname = Trim(.Item("ssubmodulename"))
                                End If
                                qry(qry.Length - 1) = "Insert into UserAdmin(UserName,UserPassword,Category,mainmoduleid,submoduleid,ssubmoduleid,Rights,modulename,MainGroup) " & _
                                " Values('" & Trim(vUserName) & "','" & Trim(vUserPassword) & "','U','" & Trim(.Item("MainModuleId") & "") & "','" & Trim(.Item("SubModuleid") & "") & "','" & Trim(.Item("SsubModuleid") & "") & "','" & Trim(abcdADD(vDesc) & "") & "','" & Trim(Mname) & "','INV')"
                                aryindex = aryindex + 1
                            End With
                        End If
                    End If
                    vDesc = ""
                End If
            Next Loopindex
            If qry Is Nothing = False Then
                ReDim Preserve qry(qry.Length)
            Else
                MsgBox("Choose the Rights", MsgBoxStyle.Exclamation, MyCompanyName)
                Me.txtusername.Focus()
                Exit Sub
            End If
            ''''********************************************* Insert into Master
            qry(qry.Length - 1) = "INSERT INTO MASTER..USERADMIN(UserName,UserPassword,Category,MainGroup) " & _
             " values('" & Trim(vUserName) & "','" & Trim(vUserPassword) & "','U','INV')"
            If Me.OptCU.Checked = True Then
                gconnection.MoreTrans(qry)
            ElseIf Me.OptCR.Checked = True Then
                Dim str(qry.Length + 1) As String
                str(0) = "DELETE FROM MASTER..USERADMIN WHERE  UserName='" & Trim(Me.txtusername.Text) & "' AND MainGroup='INV'"
                str(1) = "DELETE FROM MASTER..USERADMIN WHERE  UserName='" & Trim(Me.txtusername.Text) & "' And MainGroup='INV'"
                str.Copy(qry, 0, str, 2, qry.Length)
                gconnection.MoreTrans(str)
                Call ClearOperation()
                Exit Sub
            End If
        End If
        'CHANGE PASSWORD
        '----------------------------
        If Me.OptCP.Checked = True Then
            ReDim qry(1)
            If Trim(Me.txtusername.Text) <> "" Then
                qry(0) = "UPDATE USERADMIN SET userpassword='" & Trim(abcdADD(Me.txtPassword.Text)) & "' where UserName='" & Trim(Me.txtusername.Text) & "' And MainGroup='INV' "
                qry(1) = "UUPDATE MASTER..USERADMIN SET userpassword='" & Trim(abcdADD(Me.txtPassword.Text)) & "' where UserName='" & Trim(Me.txtusername.Text) & "' AND And MainGroup='INV' "
                gconnection.MoreTrans(qry)
                Call ClearOperation()
                Exit Sub
            Else
                MsgBox("Select The User Name For Change The Password", MsgBoxStyle.Critical, MyCompanyName)
                Exit Sub
            End If
        End If
        Call ClearOperation()
    End Sub
    Sub getusers()
        Dim i As Integer
        Dim Sqlstring As String
        Me.lstUsers.Items.Clear()
        Sqlstring = "SELECT DISTINCT ISNULL(USERNAME,'') AS USERNAME FROM USERADMIN WHERE ISNULL(CATEGORY,'') <> 'S' AND MAINGROUP = 'INV'"
        gconnection.getDataSet(Sqlstring, "USER")
        If gdataset.Tables("USER").Rows.Count > 0 Then
            Me.lstUsers.Enabled = True
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                Me.lstUsers.Items.Add(gdataset.Tables("USER").Rows(i).Item(0))
            Next
            Me.lstUsers.SelectedIndex = -1
        Else
            MessageBox.Show("No Users Aviliable", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            gbNew.Enabled = True
            gbUsers.Enabled = False
            txtusername.Text = ""
            txtCPassword.Text = ""
            txtPassword.Text = ""
            txtusername.Enabled = True
            txtPassword.Enabled = True
            txtCPassword.Enabled = True
            cmdDelete.Enabled = False
            cmdAdd.Text = "Add [F7]"
            Ssgrid.ClearRange(2, 2, Ssgrid.MaxCols, Ssgrid.DataRowCnt, False)
            Exit Sub
        End If
    End Sub
    Private Sub lstUsers_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstUsers.Click
        Dim Sqlstring As String
        Try
            If Me.lstUsers.Items.Count > 0 Then
                Sqlstring = "SELECT * FROM USERADMIN WHERE USERNAME = '" & Me.lstUsers.Items.Item(lstUsers.SelectedIndex) & "' AND MAINGROUP = 'INV' "
                gconnection.getDataSet(Sqlstring, "USER")
                If gdataset.Tables("USER").Rows.Count > 0 Then
                    Me.txtusername.Text = Me.lstUsers.Items.Item(lstUsers.SelectedIndex)
                    Me.txtusername.Enabled = False
                    If Me.OptCP.Checked = True Then
                        Me.lbl_pass.Text = "NEW PASSWORD:"
                        Me.lbl_confirm.Text = "CONFIRM NEW PASSWORD:"
                        Me.Ssgrid.Enabled = False
                    Else
                        Me.txtPassword.Enabled = False
                        Me.txtCPassword.Enabled = False

                        If gdataset.Tables("USER").Rows.Count > 0 Then
                            Me.txtPassword.Text = abcdMINUS(gdataset.Tables("USER").Rows(0).Item("UserPassword"))
                            Me.txtCPassword.Text = abcdMINUS(gdataset.Tables("USER").Rows(0).Item("UserPassword"))
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
                            If gdataset.Tables("USER").Rows.Count > 0 Then
                                Me.Lbl_Forget.Text = "The Password :  " & UCase(abcdMINUS(Convert.ToString(gdataset.Tables("USER").Rows(0).Item("UserPassword"))))
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Sub UserDetails(ByVal UserName As String)
        Dim cnt, sscnt, rcnt As Integer
        Dim Vdesc, Sqlstring As String
        Dim vmain As Double
        Sqlstring = "SELECT ISNULL(MODULENAME,0) AS MODULENAME,ISNULL(RIGHTS,'') AS RIGHTS FROM USERADMIN WHERE USERNAME = '" & Trim(UserName) & "' AND MAINGROUP = 'INV' "
        gconnection.getDataSet(Sqlstring, "USER")
        If gdataset.Tables("USER").Rows.Count > 0 Then
            For cnt = 0 To gdataset.Tables("USER").Rows.Count - 1
                If gdataset.Tables("USER").Rows(cnt).Item("ModuleName") <> 0 Then
                    For sscnt = 0 To Ssgrid.DataRowCnt
                        With Ssgrid
                            .Row = sscnt
                            .Col = 8
                            vmain = Val(.Text)
                            If Val(gdataset.Tables("USER").Rows(cnt).Item("ModuleName")) = Val(vmain) Then
                                Vdesc = gdataset.Tables("USER").Rows(cnt).Item("Rights")
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
            MsgBox("Password cannot be Blank", MsgBoxStyle.Critical, MyCompanyName)
            If txtPassword.Enabled = True Then
                txtPassword.Focus()
            End If
            Exit Function
        End If
        If Trim(txtCPassword.Text & "") = "" Then
            MyValidations_ChangePassword = False
            MsgBox("Confirm Password cannot be Blank", MsgBoxStyle.Critical, MyCompanyName)
            If txtCPassword.Enabled = True Then
                txtCPassword.Focus()
            End If
            Exit Function
        End If
        If Me.txtPassword.Text <> Me.txtCPassword.Text Then
            MyValidations_ChangePassword = False
            MsgBox("The Password Mismatched", MsgBoxStyle.Critical, MyCompanyName)
            Me.txtCPassword.Focus()
            Exit Function
        End If
    End Function
    Private Sub OptCU_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptCU.Click
        Me.cmdDelete.Enabled = False
        Me.cmdAdd.Text = "Add[F7]"
        Me.cmdAdd.Enabled = True
        Me.lbl_pass.Text = "PASSWORD :"
        Me.lbl_confirm.Text = "CONFIRM PASSWORD :"
        Me.Lbl_Forget.Text = ""
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
        Me.Lbl_Forget.Text = ""
        Me.txtusername.Enabled = False
        Me.gbUsers.Enabled = True
        Me.lstUsers.Enabled = True
        Me.txtCPassword.Enabled = True
        Me.txtPassword.Enabled = True
        Me.cmdDelete.Enabled = False
        Me.cmdAdd.Text = "Update[F7]"
        Me.cmdAdd.Enabled = True
        Call Me.getusers()
    End Sub
    Private Sub OptCR_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptCR.Click
        If Me.OptCR.Checked = True Then
            Call ClearOperation()
            Me.lbl_pass.Text = "PASSWORD :"
            Me.lbl_confirm.Text = "CONFIRM PASSWORD :"
            Me.Lbl_Forget.Text = ""
            Me.lstUsers.Enabled = True
            Me.Ssgrid.Enabled = True
            Me.gbUsers.Enabled = True
            Me.txtCPassword.Enabled = False
            Me.txtPassword.Enabled = False
            Me.txtusername.Enabled = False
            Ssgrid.Enabled = True
            Me.cmdDelete.Enabled = False
            Me.cmdAdd.Text = "Update[F7]"
            Me.cmdAdd.Enabled = True
            Me.getusers()
        End If
    End Sub
    Private Sub OptDU_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptDU.Click
        If Me.OptDU.Checked = True Then
            Call ClearOperation()
            Me.lbl_pass.Text = "PASSWORD :"
            Me.lbl_confirm.Text = "CONFIRM PASSWORD :"
            Me.Lbl_Forget.Text = ""
            Me.Ssgrid.Enabled = False
            Me.gbUsers.Enabled = True
            Me.lstUsers.Enabled = True
            Me.txtCPassword.Enabled = False
            Me.txtPassword.Enabled = False
            Me.txtusername.Enabled = False
            Me.cmdDelete.Enabled = True
            Me.cmdAdd.Text = "Add [F7]"
            Me.cmdAdd.Enabled = False
            Me.getusers()
        End If
    End Sub
    Private Sub OptFP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OptFP.Click
        If Me.OptFP.Checked = True Then
            Call ClearOperation()
            Me.lbl_pass.Text = "PASSWORD :"
            Me.lbl_confirm.Text = "CONFIRM PASSWORD :"
            Me.Ssgrid.Enabled = False
            Me.gbUsers.Enabled = True
            Me.Lbl_Forget.Text = ""
            Me.lstUsers.Enabled = True
            Me.txtCPassword.Enabled = False
            Me.txtPassword.Enabled = False
            Me.txtusername.Enabled = False
            Me.cmdDelete.Enabled = False
            Me.cmdAdd.Text = "Add(F7)"
            Me.cmdAdd.Enabled = False
            Call Me.getusers()
        End If
    End Sub
    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtPassword.Focus()
        End If
    End Sub
    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtCPassword.Focus()
        End If
    End Sub
    Private Sub txtCPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Ssgrid.Focus()
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        Call ClearOperation()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Call Addoperation()
        Call ClearOperation()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim X As Integer
        X = MessageBox.Show("Are You Sure to Delete The User", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If X = 1 Then
            Call DeleteOperation()
            Call Me.ClearOperation()
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub UserAdmin_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        UserAdminbool = False
    End Sub

    Private Sub OptCU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OptCU.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtusername.Focus()
        End If
    End Sub

    Private Sub OptCP_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OptCP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtusername.Focus()
        End If
    End Sub

    Private Sub OptCP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptCP.CheckedChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class