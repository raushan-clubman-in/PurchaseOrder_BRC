Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Data.SqlClient
Public Class Loginform
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Username As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents Cmd_Login As System.Windows.Forms.Button
    Friend WithEvents Cmd_Turnoff As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TXT_NEWPASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CHK_CHANGEPWD As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Loginform))
        Me.Cmd_Turnoff = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Cmd_Cancel = New System.Windows.Forms.Button
        Me.Cmd_Login = New System.Windows.Forms.Button
        Me.Txt_Password = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txt_Username = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.TXT_NEWPASSWORD = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CHK_CHANGEPWD = New System.Windows.Forms.CheckBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cmd_Turnoff
        '
        Me.Cmd_Turnoff.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Turnoff.Image = CType(resources.GetObject("Cmd_Turnoff.Image"), System.Drawing.Image)
        Me.Cmd_Turnoff.Location = New System.Drawing.Point(40, 696)
        Me.Cmd_Turnoff.Name = "Cmd_Turnoff"
        Me.Cmd_Turnoff.Size = New System.Drawing.Size(24, 24)
        Me.Cmd_Turnoff.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(80, 704)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Turn off Application"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CHK_CHANGEPWD)
        Me.Panel1.Controls.Add(Me.TXT_NEWPASSWORD)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Cmd_Cancel)
        Me.Panel1.Controls.Add(Me.Cmd_Login)
        Me.Panel1.Controls.Add(Me.Txt_Password)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Txt_Username)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(568, 272)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 152)
        Me.Panel1.TabIndex = 0
        '
        'Cmd_Cancel
        '
        Me.Cmd_Cancel.BackColor = System.Drawing.Color.White
        Me.Cmd_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Cancel.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Cancel.Image = CType(resources.GetObject("Cmd_Cancel.Image"), System.Drawing.Image)
        Me.Cmd_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Cancel.Location = New System.Drawing.Point(160, 120)
        Me.Cmd_Cancel.Name = "Cmd_Cancel"
        Me.Cmd_Cancel.Size = New System.Drawing.Size(89, 24)
        Me.Cmd_Cancel.TabIndex = 3
        Me.Cmd_Cancel.Text = "  CANCEL"
        '
        'Cmd_Login
        '
        Me.Cmd_Login.BackColor = System.Drawing.Color.White
        Me.Cmd_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Login.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Login.Image = CType(resources.GetObject("Cmd_Login.Image"), System.Drawing.Image)
        Me.Cmd_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Login.Location = New System.Drawing.Point(64, 120)
        Me.Cmd_Login.Name = "Cmd_Login"
        Me.Cmd_Login.Size = New System.Drawing.Size(83, 24)
        Me.Cmd_Login.TabIndex = 2
        Me.Cmd_Login.Text = "  LOGIN"
        '
        'Txt_Password
        '
        Me.Txt_Password.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Password.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Txt_Password.ForeColor = System.Drawing.Color.Blue
        Me.Txt_Password.Location = New System.Drawing.Point(148, 49)
        Me.Txt_Password.MaxLength = 20
        Me.Txt_Password.Name = "Txt_Password"
        Me.Txt_Password.PasswordChar = Microsoft.VisualBasic.ChrW(50)
        Me.Txt_Password.Size = New System.Drawing.Size(134, 22)
        Me.Txt_Password.TabIndex = 1
        Me.Txt_Password.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(9, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PASSWORD :"
        '
        'Txt_Username
        '
        Me.Txt_Username.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Username.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Username.ForeColor = System.Drawing.Color.Blue
        Me.Txt_Username.Location = New System.Drawing.Point(148, 16)
        Me.Txt_Username.MaxLength = 15
        Me.Txt_Username.Name = "Txt_Username"
        Me.Txt_Username.Size = New System.Drawing.Size(134, 22)
        Me.Txt_Username.TabIndex = 0
        Me.Txt_Username.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "USER NAME :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(104, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(392, 128)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "WELCOME TO     CLUBMAN"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(704, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Invalid User"
        Me.Label5.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(568, 248)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(304, 152)
        Me.Panel2.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(8, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "LOGIN HERE"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(625, 704)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(432, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Copyrights Reserved 2004-2010  by Database Software"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(128, 368)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(320, 368)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(136, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'TXT_NEWPASSWORD
        '
        Me.TXT_NEWPASSWORD.BackColor = System.Drawing.Color.Wheat
        Me.TXT_NEWPASSWORD.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.TXT_NEWPASSWORD.ForeColor = System.Drawing.Color.Blue
        Me.TXT_NEWPASSWORD.Location = New System.Drawing.Point(152, 96)
        Me.TXT_NEWPASSWORD.MaxLength = 20
        Me.TXT_NEWPASSWORD.Name = "TXT_NEWPASSWORD"
        Me.TXT_NEWPASSWORD.PasswordChar = Microsoft.VisualBasic.ChrW(50)
        Me.TXT_NEWPASSWORD.Size = New System.Drawing.Size(134, 22)
        Me.TXT_NEWPASSWORD.TabIndex = 6
        Me.TXT_NEWPASSWORD.Text = ""
        Me.TXT_NEWPASSWORD.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "NEW PASSWORD :"
        Me.Label6.Visible = False
        '
        'CHK_CHANGEPWD
        '
        Me.CHK_CHANGEPWD.BackColor = System.Drawing.Color.Transparent
        Me.CHK_CHANGEPWD.Location = New System.Drawing.Point(168, 72)
        Me.CHK_CHANGEPWD.Name = "CHK_CHANGEPWD"
        Me.CHK_CHANGEPWD.Size = New System.Drawing.Size(120, 16)
        Me.CHK_CHANGEPWD.TabIndex = 598
        Me.CHK_CHANGEPWD.Text = "Change Password"
        '
        'Loginform
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1036, 780)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmd_Turnoff)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loginform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loginform"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim rectGrBrush As New LinearGradientBrush( _
               New Point(0, 0), _
               New Point(15, 0), _
               Color.FromArgb(255, 1, 61, 150), _
               Color.FromArgb(255, 1, 61, 150))
        Dim lineGrBrush As New LinearGradientBrush( _
               New Point(0, 0), _
               New Point(15, 0), _
               Color.FromArgb(255, 255, 255, 255), _
               Color.FromArgb(255, 255, 255, 255))
        Dim rectpen As New Pen(rectGrBrush)
        e.Graphics.FillRectangle(rectGrBrush, 0, 0, 1100, 80)
        Dim linepen As New Pen(lineGrBrush)
        e.Graphics.FillRectangle(lineGrBrush, 0, 80, 1100, 2)
        Dim pBrush As New LinearGradientBrush( _
               New Point(0, 0), _
               New Point(1100, 0), _
               Color.FromArgb(200, 99, 158, 248), _
               Color.FromArgb(255, 15, 92, 244))
        Dim path As New GraphicsPath
        e.Graphics.FillRectangle(pBrush, New Rectangle(0, 82, 1100, 600))
        Dim linepen1 As New Pen(lineGrBrush)
        e.Graphics.FillRectangle(lineGrBrush, 0, 680, 1100, 2)
        e.Graphics.FillRectangle(rectGrBrush, 0, 682, 1100, 90)
        e.Graphics.FillRectangle(lineGrBrush, 500, 100, 1, 550)
    End Sub
    Private Sub Loginform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Cbo_Usertype.SelectedIndex = 0
        AppPath = Application.StartupPath
        If Dir(AppPath & "\Reports", FileAttribute.Directory) = "" Then
            MkDir(AppPath & "\Reports")
        End If
        Call GetPrinter()
        Call GetServer()
        Call GetEXCELPATH()
        Call GetPHOTOPATH()
        Me.Txt_Username.Focus()

    End Sub

    Private Sub Txt_Username_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_Username.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_Password.Focus()
        End If
    End Sub

    Private Sub Txt_Password_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Trim(Txt_Password.Text) = "" Then
                Txt_Password.Focus()
            Else
                Cmd_Login.Focus()
            End If
        End If
    End Sub
    Private Sub Cmd_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Login.Click
        Dim SQLSTRING As String
        If (Trim(Txt_Username.Text) = "") Then
            ErrorProvider1.SetError(Txt_Username, "Please enter User name")
        Else
            ErrorProvider1.SetError(Txt_Username, "")
        End If
        If (Trim(Txt_Password.Text) = "") Then
            ErrorProvider1.SetError(Txt_Password, "Please enter Password")
        Else
            ErrorProvider1.SetError(Txt_Password, "")
        End If
        Try


            SQLSTRING = "SELECT * FROM USERADMIN WHERE  USERNAME = '" & Trim(UCase(Txt_Username.Text)) & "' and USERPASSWORD ='" & Trim(GetPassword(UCase(Txt_Password.Text))) & "'"
            gconnection.getCompanyinfo(SQLSTRING, "ClubMaster")
            If gdataset.Tables("ClubMaster").Rows.Count > 0 Then
                gUsername = Trim(Txt_Username.Text)
                gPoSUsername = Trim(Mid(Trim(Txt_Username.Text), 1, 5))
                gUserCategory = gdataset.Tables("ClubMaster").Rows(0).Item("CATEGORY")

                'new one
                If CHK_CHANGEPWD.Checked = True And Trim(TXT_NEWPASSWORD.Text) <> "" Then
                    Dim vstr As String
                    vstr = abcdADD(UCase(Trim(TXT_NEWPASSWORD.Text)))

                    SQLSTRING = "UPDATE MASTER..USERADMIN SET USERPASSWORD='" & Trim(vstr) & "' WHERE USERNAME='" & Trim(Txt_Username.Text) & "'"
                    gconnection.getCompanyinfo(SQLSTRING, "USERUPDATE")

                    SQLSTRING = "UPDATE " & Trim(gDatabase) & "..USERADMIN SET USERPASSWORD='" & Trim(vstr) & "' WHERE USERNAME='" & Trim(Txt_Username.Text) & "'"
                    gconnection.getCompanyinfo(SQLSTRING, "USERUPDATE1")
                End If

                If gUserCategory = "U" Then
                    Dim Objwelcome As New Welcome
                    Me.Hide()
                    Objwelcome.Show()
                ElseIf gUserCategory = "O" Then 'for Operator User Type Only
                    Dim Objwelcome As New Operator_MainMenu
                    Me.Hide()
                    Objwelcome.Show()
                Else
                    Dim Objwelcome As New Welcome
                    Me.Hide()
                    Objwelcome.Show()
                End If
            Else
                SQLSTRING = "SELECT * FROM USERADMIN WHERE  USERNAME = '" & Trim(UCase(Txt_Username.Text)) & "' and USERPASSWORD ='" & Trim(GetPassword(UCase(Txt_Password.Text))) & "' AND  CATEGORY = 'S' "
                gconnection.getCompanyinfo(SQLSTRING, "ClubMaster")
                If gdataset.Tables("ClubMaster").Rows.Count > 0 Then
                    gUsername = Trim(Txt_Username.Text)
                    gPoSUsername = Trim(Mid(Trim(Txt_Username.Text), 1, 5))
                    gUserCategory = gdataset.Tables("ClubMaster").Rows(0).Item("CATEGORY")
                    Dim Objwelcome As New Welcome
                    Me.Hide()
                    Objwelcome.Show()
                Else
                    MessageBox.Show("Invalid Username Or Password !!! Contact System Admin", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Label5.Visible = True
                    Me.Txt_Password.Text = ""
                    Me.Txt_Password.Focus()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Create Table UserAdmin In Master database" & Err.Description, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Cancel.Click
        Txt_Username.Text = ""
        Txt_Password.Text = ""
        Label5.Visible = False
        ErrorProvider1.Dispose()
        Txt_Username.Focus()
    End Sub
    Private Sub Cmd_Turnoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Turnoff.Click
        Me.Close()
    End Sub
    Public Sub GetServer1()
        Dim ServerConn As New OleDb.OleDbConnection
        Dim servercmd As New OleDb.OleDbDataAdapter
        Dim getserver As New DataSet
        Dim sql, ssql As String
        Try
            sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
            sql = sql & AppPath & "\DBS_KEY.MDB"
            ServerConn.ConnectionString = sql
            ServerConn.Open()
            ssql = "SELECT SERVER, UserName, Password, Company_ID,Database FROM DBSKEY"
            servercmd = New OleDb.OleDbDataAdapter(ssql, ServerConn)
            servercmd.Fill(getserver)
            If getserver.Tables(0).Rows.Count > 0 Then
                gserver = Trim(getserver.Tables(0).Rows(0).Item(0) & "")
                strDataSqlUsr = Trim(getserver.Tables(0).Rows(0).Item(1) & "")
                strDataSqlPwd = abcdMINUS(Trim(getserver.Tables(0).Rows(0).Item(2) & ""))
                gDatabase = Trim(getserver.Tables(0).Rows(0).Item(4) & "")
            Else
                gserver = Environment.MachineName
            End If
        Catch ex As Exception
            MessageBox.Show("Failed To Connect Server", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Finally
            ServerConn.Close()
        End Try
    End Sub
    Public Sub GetServer()
        Dim ServerConn As New OleDb.OleDbConnection
        Dim servercmd As New OleDb.OleDbDataAdapter
        Dim getserver As New DataSet
        Dim sql, ssql As String
        sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
        sql = sql & AppPath & "\DBS_KEY.MDB"
        ServerConn.ConnectionString = sql
        Try
            ServerConn.Open()
            'Mk Kannan
            'Begin
            'UserName and Password is Added on 06 Oct'07
            ssql = "SELECT SERVER, UserName, Password, Company_ID,database FROM DBSKEY"
            'End
            servercmd = New OleDb.OleDbDataAdapter(ssql, ServerConn)
            servercmd.Fill(getserver)
            If getserver.Tables(0).Rows.Count > 0 Then
                gserver = Trim(getserver.Tables(0).Rows(0).Item(0) & "")
                'Mk Kannan
                'Begin
                'UserName and Password is Added on 06 Oct'07
                strDataSqlUsr = Trim(getserver.Tables(0).Rows(0).Item(1) & "")
                strDataSqlPwd = abcdMINUS(Trim(getserver.Tables(0).Rows(0).Item(2) & ""))
                'End
                'Mk Kannan
                'Begin
                'Company ID is Added on 10 Dec'07
                strCompany_ID = Trim(getserver.Tables(0).Rows(0).Item(3) & "")
                gDatabase = Trim(getserver.Tables(0).Rows(0).Item(4) & "")
                'End
            Else
                MessageBox.Show("Failed to connect to Data Source")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to data source")
            MsgBox(ex.Message)
        Finally
            ServerConn.Close()
        End Try
    End Sub
    Public Sub GetEXCELPATH()
        Dim ExcelConn As New OleDb.OleDbConnection
        Dim Excelcmd As New OleDb.OleDbDataAdapter
        Dim getexcel As New DataSet
        Dim sql, ssql As String
        Try
            sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
            sql = sql & AppPath & "\DBS_KEY.MDB"
            ExcelConn.ConnectionString = sql
            ExcelConn.Open()
            ssql = "SELECT PATH FROM EXCELPATH"
            Excelcmd = New OleDb.OleDbDataAdapter(ssql, ExcelConn)
            Excelcmd.Fill(getexcel)
            If getexcel.Tables(0).Rows.Count > 0 Then
                strexcelpath = Trim(getexcel.Tables(0).Rows(0).Item(0) & "")
            Else
                strexcelpath = Environment.SystemDirectory & "\Excel.exe"
            End If
        Catch ex As Exception
            MessageBox.Show("Failed To Find Microsoft Excel Path", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Finally
            ExcelConn.Close()
        End Try
    End Sub
    Public Sub GetPrinter()
        Dim PrinterConn As New OleDb.OleDbConnection
        Dim Printercmd As New OleDb.OleDbDataAdapter
        Dim GetPrinter As New DataSet
        Dim sql, ssql As String
        Dim i As Integer
        Try
            sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
            sql = sql & AppPath & "\DBS_KEY.MDB"
            PrinterConn.ConnectionString = sql
            PrinterConn.Open()
            ssql = " SELECT COMPUTERNAME, PRINTERNAME FROM PrinterSetup "
            Printercmd = New OleDb.OleDbDataAdapter(ssql, PrinterConn)
            Printercmd.Fill(GetPrinter)
            If GetPrinter.Tables(0).Rows.Count > 0 Then
                For i = 0 To GetPrinter.Tables(0).Rows.Count - 1
                    computername = Trim(GetPrinter.Tables(0).Rows(i).Item(0) & "")
                    Printername = Trim(GetPrinter.Tables(0).Rows(i).Item(1) & "")
                    'If Trim(GetPrinter.Tables(0).Rows(i).Item(2)) = "Y" Then
                    '    Kot_Computername = Trim(GetPrinter.Tables(0).Rows(i).Item(0) & "")
                    '    Kot_Printername = Trim(GetPrinter.Tables(0).Rows(i).Item(1) & "")
                    'Else

                    'End If
                Next
            Else
                computername = ""
                Printername = ""
            End If
        Catch ex As Exception
            'MessageBox.Show("Failed To Connect To Computer Printer", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            MessageBox.Show("Failed To Connect To Computer Printer" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        Finally
            PrinterConn.Close()
        End Try
    End Sub
    Public Sub GetPHOTOPATH()
        Dim PHOTOConn As New OleDb.OleDbConnection
        Dim PHOTOcmd As New OleDb.OleDbDataAdapter
        Dim getPHOTO As New DataSet
        Dim sql, ssql As String
        Try
            sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
            sql = sql & AppPath & "\DBS_KEY.MDB"
            PHOTOConn.ConnectionString = sql
            PHOTOConn.Open()
            ssql = "SELECT PATH FROM SCPHOTOPATH"
            PHOTOcmd = New OleDb.OleDbDataAdapter(ssql, PHOTOConn)
            PHOTOcmd.Fill(getPHOTO)
            If getPHOTO.Tables(0).Rows.Count > 0 Then
                STRPHOTOPATH = Trim(getPHOTO.Tables(0).Rows(0).Item(0) & "")
            Else
                MessageBox.Show("PLS PROVIDE PHOTO PATH IN DBS KEY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("PLS PROVIDE PHOTO PATH IN DBS KEY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Finally
            PHOTOConn.Close()
        End Try
    End Sub

    Private Sub Cbo_Usertype_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Txt_Username.Focus()
        End If
    End Sub


    Private Sub CHK_CHANGEPWD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_CHANGEPWD.CheckedChanged
        If CHK_CHANGEPWD.Checked = True Then
            Label6.Visible = True
            TXT_NEWPASSWORD.Visible = True
            TXT_NEWPASSWORD.Focus()
        Else
            Label6.Visible = False
            TXT_NEWPASSWORD.Visible = False
            Txt_Password.Focus()
        End If
    End Sub
End Class
