Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.IO
Public Class Form1
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Username As System.Windows.Forms.TextBox
    Friend WithEvents Cbo_Usertype As System.Windows.Forms.ComboBox
    Friend WithEvents Cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents Cmd_Login As System.Windows.Forms.Button
    Friend WithEvents Cmd_Turnoff As System.Windows.Forms.Button
    Friend WithEvents CHK_CHANGEPWD As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TXT_NEWPASSWORD As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Cmd_Turnoff = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.TXT_NEWPASSWORD = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Cmd_Cancel = New System.Windows.Forms.Button
        Me.Cmd_Login = New System.Windows.Forms.Button
        Me.Txt_Password = New System.Windows.Forms.TextBox
        Me.Txt_Username = New System.Windows.Forms.TextBox
        Me.CHK_CHANGEPWD = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.Label5 = New System.Windows.Forms.Label
        Me.Cbo_Usertype = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
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
        'TXT_NEWPASSWORD
        '
        Me.TXT_NEWPASSWORD.BackColor = System.Drawing.Color.Wheat
        Me.TXT_NEWPASSWORD.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.TXT_NEWPASSWORD.ForeColor = System.Drawing.Color.Blue
        Me.TXT_NEWPASSWORD.Location = New System.Drawing.Point(504, 448)
        Me.TXT_NEWPASSWORD.MaxLength = 12
        Me.TXT_NEWPASSWORD.Name = "TXT_NEWPASSWORD"
        Me.TXT_NEWPASSWORD.PasswordChar = Microsoft.VisualBasic.ChrW(50)
        Me.TXT_NEWPASSWORD.Size = New System.Drawing.Size(134, 22)
        Me.TXT_NEWPASSWORD.TabIndex = 601
        Me.TXT_NEWPASSWORD.Text = ""
        Me.TXT_NEWPASSWORD.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(368, 448)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 18)
        Me.Label9.TabIndex = 600
        Me.Label9.Text = "NEW PASSWORD :"
        Me.Label9.Visible = False
        '
        'Cmd_Cancel
        '
        Me.Cmd_Cancel.BackColor = System.Drawing.Color.White
        Me.Cmd_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Cancel.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Cancel.Image = CType(resources.GetObject("Cmd_Cancel.Image"), System.Drawing.Image)
        Me.Cmd_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Cancel.Location = New System.Drawing.Point(480, 376)
        Me.Cmd_Cancel.Name = "Cmd_Cancel"
        Me.Cmd_Cancel.Size = New System.Drawing.Size(89, 24)
        Me.Cmd_Cancel.TabIndex = 3
        Me.Cmd_Cancel.Text = "Cancel"
        '
        'Cmd_Login
        '
        Me.Cmd_Login.BackColor = System.Drawing.Color.White
        Me.Cmd_Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Login.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Login.Image = CType(resources.GetObject("Cmd_Login.Image"), System.Drawing.Image)
        Me.Cmd_Login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Login.Location = New System.Drawing.Point(360, 376)
        Me.Cmd_Login.Name = "Cmd_Login"
        Me.Cmd_Login.Size = New System.Drawing.Size(83, 24)
        Me.Cmd_Login.TabIndex = 2
        Me.Cmd_Login.Text = "Login"
        '
        'Txt_Password
        '
        Me.Txt_Password.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Password.Font = New System.Drawing.Font("Wingdings", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Txt_Password.ForeColor = System.Drawing.Color.Blue
        Me.Txt_Password.Location = New System.Drawing.Point(448, 336)
        Me.Txt_Password.MaxLength = 12
        Me.Txt_Password.Name = "Txt_Password"
        Me.Txt_Password.PasswordChar = Microsoft.VisualBasic.ChrW(50)
        Me.Txt_Password.Size = New System.Drawing.Size(134, 22)
        Me.Txt_Password.TabIndex = 1
        Me.Txt_Password.Text = ""
        '
        'Txt_Username
        '
        Me.Txt_Username.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Username.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Username.ForeColor = System.Drawing.Color.Blue
        Me.Txt_Username.Location = New System.Drawing.Point(448, 288)
        Me.Txt_Username.MaxLength = 10
        Me.Txt_Username.Name = "Txt_Username"
        Me.Txt_Username.Size = New System.Drawing.Size(134, 22)
        Me.Txt_Username.TabIndex = 0
        Me.Txt_Username.Text = ""
        '
        'CHK_CHANGEPWD
        '
        Me.CHK_CHANGEPWD.BackColor = System.Drawing.Color.Transparent
        Me.CHK_CHANGEPWD.Location = New System.Drawing.Point(480, 424)
        Me.CHK_CHANGEPWD.Name = "CHK_CHANGEPWD"
        Me.CHK_CHANGEPWD.Size = New System.Drawing.Size(120, 16)
        Me.CHK_CHANGEPWD.TabIndex = 599
        Me.CHK_CHANGEPWD.Text = "Change Password"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(296, 104)
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
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(608, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Invalid User"
        Me.Label5.Visible = False
        '
        'Cbo_Usertype
        '
        Me.Cbo_Usertype.BackColor = System.Drawing.Color.Wheat
        Me.Cbo_Usertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Usertype.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_Usertype.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(64, Byte), CType(0, Byte))
        Me.Cbo_Usertype.Items.AddRange(New Object() {"ADMINISTRATOR", "USER"})
        Me.Cbo_Usertype.Location = New System.Drawing.Point(432, 232)
        Me.Cbo_Usertype.Name = "Cbo_Usertype"
        Me.Cbo_Usertype.Size = New System.Drawing.Size(149, 23)
        Me.Cbo_Usertype.TabIndex = 1
        Me.Cbo_Usertype.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(328, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "LOGIN AS :"
        Me.Label6.Visible = False
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
        Me.Label7.Text = "Copyrights Reserved 2004 by Database Software"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1036, 780)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cbo_Usertype)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cmd_Turnoff)
        Me.Controls.Add(Me.Txt_Username)
        Me.Controls.Add(Me.Txt_Password)
        Me.Controls.Add(Me.Cmd_Login)
        Me.Controls.Add(Me.Cmd_Cancel)
        Me.Controls.Add(Me.CHK_CHANGEPWD)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXT_NEWPASSWORD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        'Dim rectGrBrush As New LinearGradientBrush( _
        '       New Point(0, 0), _
        '       New Point(15, 0), _
        '       Color.FromArgb(255, 1, 61, 150), _
        '       Color.FromArgb(255, 1, 61, 150))
        'Dim lineGrBrush As New LinearGradientBrush( _
        '       New Point(0, 0), _
        '       New Point(15, 0), _
        '       Color.FromArgb(255, 255, 255, 255), _
        '       Color.FromArgb(255, 255, 255, 255))
        'Dim rectpen As New Pen(rectGrBrush)
        'e.Graphics.FillRectangle(rectGrBrush, 0, 0, 1100, 80)
        'Dim linepen As New Pen(lineGrBrush)
        'e.Graphics.FillRectangle(lineGrBrush, 0, 80, 1100, 2)
        'Dim pBrush As New LinearGradientBrush( _
        '       New Point(0, 0), _
        '       New Point(1100, 0), _
        '       Color.FromArgb(200, 99, 158, 248), _
        '       Color.FromArgb(255, 15, 92, 244))
        'Dim path As New GraphicsPath
        'e.Graphics.FillRectangle(pBrush, New Rectangle(0, 82, 1100, 600))
        'Dim linepen1 As New Pen(lineGrBrush)
        'e.Graphics.FillRectangle(lineGrBrush, 0, 680, 1100, 2)
        'e.Graphics.FillRectangle(rectGrBrush, 0, 682, 1100, 90)
        'e.Graphics.FillRectangle(lineGrBrush, 500, 100, 1, 550)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cbo_Usertype.SelectedIndex = 0
        AppPath = Application.StartupPath
        If Dir(AppPath & "\Reports", FileAttribute.Directory) = "" Then
            MkDir(AppPath & "\Reports")
        End If
        Call GetPrinter()
        Call GetServer()
        Call GetEXCELPATH()
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
        If (Trim(Cbo_Usertype.Text) = "") Then
            ErrorProvider1.SetError(Cbo_Usertype, "Please Select Login")
        Else
            ErrorProvider1.SetError(Cbo_Usertype, "")
        End If

        ''''Try
        ''''    If Me.Cbo_Usertype.Text = "USER" Then
        ''''        'SQLSTRING = "SELECT * FROM USERADMIN WHERE  USERNAME = '" & Trim(UCase(Txt_Username.Text)) & "' and USERPASSWORD ='" & Trim(GetPassword(UCase(Txt_Password.Text))) & "' AND MAINGROUP = 'Purchase Order' AND CATEGORY  = 'U'"
        ''''        SQLSTRING = "SELECT * FROM USERADMIN WHERE  USERNAME = '" & Trim(UCase(Txt_Username.Text)) & "' and USERPASSWORD ='" & Trim(GetPassword(UCase(Txt_Password.Text))) & "'  AND CATEGORY  = 'U'"
        ''''    Else
        ''''        SQLSTRING = "SELECT * FROM USERADMIN WHERE  USERNAME = '" & Trim(UCase(Txt_Username.Text)) & "' and USERPASSWORD ='" & Trim(GetPassword(UCase(Txt_Password.Text))) & "' AND CATEGORY = 'S'"
        ''''    End If
        ''''    gconnection.getCompanyinfo(SQLSTRING, "ClubMaster")
        ''''    If gdataset.Tables("ClubMaster").Rows.Count > 0 Then
        ''''        gUsername = Trim(Txt_Username.Text)
        ''''        gUserCategory = gdataset.Tables("ClubMaster").Rows(0).Item("CATEGORY")
        ''''        Dim Objwelcome As New Welcome
        ''''        Me.Hide()
        ''''        Objwelcome.Show()
        ''''    Else
        ''''        MessageBox.Show("Invalid Username Or Password !!! Contact System Admin", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ''''        Label5.Visible = True
        ''''        Me.Txt_Password.Text = ""
        ''''        Me.Txt_Password.Focus()
        ''''        Exit Sub
        ''''    End If
        ''''Catch ex As Exception
        ''''    MessageBox.Show("Create Table UserAdmin In Master database", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ''''    Exit Sub
        ''''End Try

        Try


            SQLSTRING = "SELECT * FROM USERADMIN WHERE  USERNAME = '" & Trim(UCase(Txt_Username.Text)) & "' and USERPASSWORD ='" & Trim(GetPassword(UCase(Txt_Password.Text))) & "' AND CATEGORY <> 'S' "
            gconnection.getCompanyinfo(SQLSTRING, "ClubMaster")
            If gdataset.Tables("ClubMaster").Rows.Count > 0 Then
                gUsername = Trim(Txt_Username.Text)
                gUserCategory = gdataset.Tables("ClubMaster").Rows(0).Item("CATEGORY")
                If gUserCategory = "U" Then
                    Dim Objwelcome As New Welcome
                    Me.Hide()
                    Objwelcome.Show()
                    'ElseIf gUserCategory = "O" Then 'for Operator User Type Only
                    '    Dim Objwelcome As New Operator_MainMenu
                    '    Me.Hide()
                    '    Objwelcome.Show()
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
            MessageBox.Show("Create Table UserAdmin In Master database", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
    Public Sub GetServer()
        Dim ServerConn As New OleDb.OleDbConnection
        Dim servercmd As New OleDb.OleDbDataAdapter
        Dim getserver As New DataSet
        Dim sql, ssql As String
        Try
            sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
            sql = sql & AppPath & "\DBS_KEY.MDB"
            ServerConn.ConnectionString = sql
            ServerConn.Open()
            ssql = "SELECT SERVER,username,password,productkey,DATABASE FROM DBSKEY"
            servercmd = New OleDb.OleDbDataAdapter(ssql, ServerConn)
            servercmd.Fill(getserver)
            If getserver.Tables(0).Rows.Count > 0 Then
                gserver = Trim(getserver.Tables(0).Rows(0).Item(0) & "")
                ggusername = Trim(getserver.Tables(0).Rows(0).Item(1) & "")
                'ggpassword = abcdMINUS(Trim(getserver.Tables(0).Rows(0).Item(2) & ""))
                ggpassword = Trim(getserver.Tables(0).Rows(0).Item(2) & "")
                ggproductkey = abcdMINUS(Trim(getserver.Tables(0).Rows(0).Item(3) & ""))
                gDatabase = Trim(getserver.Tables(0).Rows(0).Item("DATABASE") & "")
                If Trim(gDatabase) <> "" Then
                    ShowCompany = False
                Else
                    ShowCompany = True
                End If
                'If Trim(ggproductkey) <> Trim(Environment.MachineName) Then
                '    MsgBox("Please Contact Your Software Developers for Reconfigure the Software........")
                '    Call Randomize()
                '    AppPath = Application.StartupPath
                '    vOutfile = Mid("Sys" & (Rnd() * 800000), 1, 8)
                '    VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
                '    Filewrite = File.AppendText(VFilePath)

                '    printfile = VFilePath
                '    Filewrite.WriteLine(abcdADD(Trim(Environment.MachineName)))
                '    '                    Filewrite.WriteLine(abcdADD(Trim(ggusername)))
                '    Filewrite.Close()
                '    End
                'End If

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
        Try
            sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
            sql = sql & AppPath & "\DBS_KEY.MDB"
            PrinterConn.ConnectionString = sql
            PrinterConn.Open()
            ssql = "SELECT COMPUTERNAME ,PRINTERNAME FROM PrinterSetup"
            Printercmd = New OleDb.OleDbDataAdapter(ssql, PrinterConn)
            Printercmd.Fill(GetPrinter)
            If GetPrinter.Tables(0).Rows.Count > 0 Then
                computername = Trim(GetPrinter.Tables(0).Rows(0).Item(0) & "")
                Printername = Trim(GetPrinter.Tables(0).Rows(0).Item(1) & "")
            Else
                computername = ""
                Printername = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Failed To Connect To Computer Printer", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Finally
            PrinterConn.Close()
        End Try
    End Sub
    Private Sub Cbo_Usertype_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_Usertype.KeyDown
        If e.KeyCode = Keys.Enter Then
            Txt_Username.Focus()
        End If
    End Sub

    Private Sub CHK_CHANGEPWD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_CHANGEPWD.CheckedChanged
        If CHK_CHANGEPWD.Checked = True Then
            Label9.Visible = True
            TXT_NEWPASSWORD.Visible = True
            TXT_NEWPASSWORD.Focus()
        Else
            Label9.Visible = False
            TXT_NEWPASSWORD.Visible = False
            Txt_Password.Focus()
        End If
    End Sub
End Class
