Option Strict Off
Option Explicit On 
Imports Microsoft.VisualBasic
Friend Class CompanyList1
	Inherits System.Windows.Forms.Form
#Region "Windows Form Designer generated code "
	Public Sub New()
		MyBase.New()
		If m_vb6FormDefInstance Is Nothing Then
			If m_InitializingDefInstance Then
				m_vb6FormDefInstance = Me
			Else
				Try 
					'For the start-up form, the first instance created is the default instance.
					If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
						m_vb6FormDefInstance = Me
					End If
                Catch
                    Exit Sub
                End Try
			End If
		End If
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents fgrdCompanyList As AxMSFlexGridLib.AxMSFlexGrid
	Public WithEvents ImgPro1 As System.Windows.Forms.PictureBox
	Public WithEvents ImgPro2 As System.Windows.Forms.PictureBox
	Public WithEvents ImgQuit1 As System.Windows.Forms.PictureBox
	Public WithEvents ImgQuit2 As System.Windows.Forms.PictureBox
	Public WithEvents ImgDel1 As System.Windows.Forms.PictureBox
	Public WithEvents ImgDel2 As System.Windows.Forms.PictureBox
	Public WithEvents ImgMod1 As System.Windows.Forms.PictureBox
	Public WithEvents ImgMod2 As System.Windows.Forms.PictureBox
	Public WithEvents ImgAdd1 As System.Windows.Forms.PictureBox
	Public WithEvents ImgAdd2 As System.Windows.Forms.PictureBox
	Public WithEvents lblAddress1 As System.Windows.Forms.Label
	Public WithEvents lblAddress4 As System.Windows.Forms.Label
	Public WithEvents lblAddress3 As System.Windows.Forms.Label
	Public WithEvents lblAddress2 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CompanyList1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ImgQuit1 = New System.Windows.Forms.PictureBox()
        Me.ImgQuit2 = New System.Windows.Forms.PictureBox()
        Me.fgrdCompanyList = New AxMSFlexGridLib.AxMSFlexGrid()
        Me.ImgPro1 = New System.Windows.Forms.PictureBox()
        Me.ImgPro2 = New System.Windows.Forms.PictureBox()
        Me.ImgDel1 = New System.Windows.Forms.PictureBox()
        Me.ImgDel2 = New System.Windows.Forms.PictureBox()
        Me.ImgMod1 = New System.Windows.Forms.PictureBox()
        Me.ImgMod2 = New System.Windows.Forms.PictureBox()
        Me.ImgAdd1 = New System.Windows.Forms.PictureBox()
        Me.ImgAdd2 = New System.Windows.Forms.PictureBox()
        Me.lblAddress1 = New System.Windows.Forms.Label()
        Me.lblAddress4 = New System.Windows.Forms.Label()
        Me.lblAddress3 = New System.Windows.Forms.Label()
        Me.lblAddress2 = New System.Windows.Forms.Label()
        CType(Me.ImgQuit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgQuit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgrdCompanyList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgPro1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgPro2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgDel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgDel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMod1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgMod2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgAdd1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImgAdd2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImgQuit1
        '
        Me.ImgQuit1.Image = CType(resources.GetObject("ImgQuit1.Image"), System.Drawing.Image)
        Me.ImgQuit1.Location = New System.Drawing.Point(730, 542)
        Me.ImgQuit1.Name = "ImgQuit1"
        Me.ImgQuit1.Size = New System.Drawing.Size(59, 55)
        Me.ImgQuit1.TabIndex = 3
        Me.ImgQuit1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgQuit1, "Click and Exit")
        '
        'ImgQuit2
        '
        Me.ImgQuit2.Image = CType(resources.GetObject("ImgQuit2.Image"), System.Drawing.Image)
        Me.ImgQuit2.Location = New System.Drawing.Point(730, 542)
        Me.ImgQuit2.Name = "ImgQuit2"
        Me.ImgQuit2.Size = New System.Drawing.Size(59, 55)
        Me.ImgQuit2.TabIndex = 4
        Me.ImgQuit2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.ImgQuit2, "Click and Exit")
        '
        'fgrdCompanyList
        '
        Me.fgrdCompanyList.Location = New System.Drawing.Point(60, 160)
        Me.fgrdCompanyList.Name = "fgrdCompanyList"
        Me.fgrdCompanyList.OcxState = CType(resources.GetObject("fgrdCompanyList.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fgrdCompanyList.Size = New System.Drawing.Size(576, 144)
        Me.fgrdCompanyList.TabIndex = 0
        '
        'ImgPro1
        '
        Me.ImgPro1.Image = CType(resources.GetObject("ImgPro1.Image"), System.Drawing.Image)
        Me.ImgPro1.Location = New System.Drawing.Point(667, 196)
        Me.ImgPro1.Name = "ImgPro1"
        Me.ImgPro1.Size = New System.Drawing.Size(82, 30)
        Me.ImgPro1.TabIndex = 1
        Me.ImgPro1.TabStop = False
        '
        'ImgPro2
        '
        Me.ImgPro2.Image = CType(resources.GetObject("ImgPro2.Image"), System.Drawing.Image)
        Me.ImgPro2.Location = New System.Drawing.Point(667, 196)
        Me.ImgPro2.Name = "ImgPro2"
        Me.ImgPro2.Size = New System.Drawing.Size(82, 30)
        Me.ImgPro2.TabIndex = 2
        Me.ImgPro2.TabStop = False
        '
        'ImgDel1
        '
        Me.ImgDel1.Image = CType(resources.GetObject("ImgDel1.Image"), System.Drawing.Image)
        Me.ImgDel1.Location = New System.Drawing.Point(667, 360)
        Me.ImgDel1.Name = "ImgDel1"
        Me.ImgDel1.Size = New System.Drawing.Size(82, 30)
        Me.ImgDel1.TabIndex = 5
        Me.ImgDel1.TabStop = False
        '
        'ImgDel2
        '
        Me.ImgDel2.Image = CType(resources.GetObject("ImgDel2.Image"), System.Drawing.Image)
        Me.ImgDel2.Location = New System.Drawing.Point(667, 360)
        Me.ImgDel2.Name = "ImgDel2"
        Me.ImgDel2.Size = New System.Drawing.Size(82, 30)
        Me.ImgDel2.TabIndex = 6
        Me.ImgDel2.TabStop = False
        '
        'ImgMod1
        '
        Me.ImgMod1.Image = CType(resources.GetObject("ImgMod1.Image"), System.Drawing.Image)
        Me.ImgMod1.Location = New System.Drawing.Point(667, 305)
        Me.ImgMod1.Name = "ImgMod1"
        Me.ImgMod1.Size = New System.Drawing.Size(82, 30)
        Me.ImgMod1.TabIndex = 7
        Me.ImgMod1.TabStop = False
        '
        'ImgMod2
        '
        Me.ImgMod2.Image = CType(resources.GetObject("ImgMod2.Image"), System.Drawing.Image)
        Me.ImgMod2.Location = New System.Drawing.Point(667, 304)
        Me.ImgMod2.Name = "ImgMod2"
        Me.ImgMod2.Size = New System.Drawing.Size(82, 30)
        Me.ImgMod2.TabIndex = 8
        Me.ImgMod2.TabStop = False
        '
        'ImgAdd1
        '
        Me.ImgAdd1.Image = CType(resources.GetObject("ImgAdd1.Image"), System.Drawing.Image)
        Me.ImgAdd1.Location = New System.Drawing.Point(667, 251)
        Me.ImgAdd1.Name = "ImgAdd1"
        Me.ImgAdd1.Size = New System.Drawing.Size(82, 30)
        Me.ImgAdd1.TabIndex = 9
        Me.ImgAdd1.TabStop = False
        '
        'ImgAdd2
        '
        Me.ImgAdd2.Image = CType(resources.GetObject("ImgAdd2.Image"), System.Drawing.Image)
        Me.ImgAdd2.Location = New System.Drawing.Point(667, 252)
        Me.ImgAdd2.Name = "ImgAdd2"
        Me.ImgAdd2.Size = New System.Drawing.Size(82, 30)
        Me.ImgAdd2.TabIndex = 10
        Me.ImgAdd2.TabStop = False
        '
        'lblAddress1
        '
        Me.lblAddress1.AutoSize = True
        Me.lblAddress1.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAddress1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress1.ForeColor = System.Drawing.Color.White
        Me.lblAddress1.Location = New System.Drawing.Point(114, 330)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAddress1.Size = New System.Drawing.Size(56, 16)
        Me.lblAddress1.TabIndex = 4
        Me.lblAddress1.Text = "lblAdd1"
        '
        'lblAddress4
        '
        Me.lblAddress4.AutoSize = True
        Me.lblAddress4.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAddress4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress4.ForeColor = System.Drawing.Color.White
        Me.lblAddress4.Location = New System.Drawing.Point(114, 406)
        Me.lblAddress4.Name = "lblAddress4"
        Me.lblAddress4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAddress4.Size = New System.Drawing.Size(57, 16)
        Me.lblAddress4.TabIndex = 3
        Me.lblAddress4.Text = "lblState"
        '
        'lblAddress3
        '
        Me.lblAddress3.AutoSize = True
        Me.lblAddress3.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAddress3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress3.ForeColor = System.Drawing.Color.White
        Me.lblAddress3.Location = New System.Drawing.Point(114, 382)
        Me.lblAddress3.Name = "lblAddress3"
        Me.lblAddress3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAddress3.Size = New System.Drawing.Size(46, 16)
        Me.lblAddress3.TabIndex = 2
        Me.lblAddress3.Text = "lblcity"
        '
        'lblAddress2
        '
        Me.lblAddress2.AutoSize = True
        Me.lblAddress2.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAddress2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress2.ForeColor = System.Drawing.Color.White
        Me.lblAddress2.Location = New System.Drawing.Point(114, 354)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAddress2.Size = New System.Drawing.Size(56, 16)
        Me.lblAddress2.TabIndex = 1
        Me.lblAddress2.Text = "lblAdd2"
        '
        'CompanyList1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.fgrdCompanyList)
        Me.Controls.Add(Me.ImgPro1)
        Me.Controls.Add(Me.ImgPro2)
        Me.Controls.Add(Me.ImgQuit1)
        Me.Controls.Add(Me.ImgQuit2)
        Me.Controls.Add(Me.ImgDel1)
        Me.Controls.Add(Me.ImgDel2)
        Me.Controls.Add(Me.ImgMod1)
        Me.Controls.Add(Me.ImgMod2)
        Me.Controls.Add(Me.ImgAdd1)
        Me.Controls.Add(Me.ImgAdd2)
        Me.Controls.Add(Me.lblAddress1)
        Me.Controls.Add(Me.lblAddress4)
        Me.Controls.Add(Me.lblAddress3)
        Me.Controls.Add(Me.lblAddress2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "CompanyList1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ImgQuit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgQuit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgrdCompanyList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgPro1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgPro2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgDel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgDel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMod1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgMod2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgAdd1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImgAdd2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region 
#Region "Upgrade Support "
	Private Shared m_vb6FormDefInstance As CompanyList1
	Private Shared m_InitializingDefInstance As Boolean
	Public Shared Property DefInstance() As CompanyList1
		Get
			If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
				m_InitializingDefInstance = True
				m_vb6FormDefInstance = New CompanyList1()
				m_InitializingDefInstance = False
			End If
			DefInstance = m_vb6FormDefInstance
		End Get
		Set
			m_vb6FormDefInstance = Value
		End Set
	End Property
#End Region 
	Dim vAddress() As String
    Dim gconnection As New GlobalClass
	Private Sub ImgQuit2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ImgQuit2.Click
        Dim FrontConnection As Object
        Dim vAns As Double
        vAns = MsgBox("Do want to Exit", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "CLUB MAN")
        If vAns = MsgBoxResult.Yes Then
            Me.Close()
            End
        End If
        FrontConnection = Nothing
    End Sub

    Private Sub CompanyList1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = eventArgs.X
        Dim y As Single = eventArgs.Y
        ImgPro1.Visible = True
        ImgPro2.Visible = False
        ImgAdd1.Visible = True
        ImgAdd2.Visible = False
        ImgMod1.Visible = True
        ImgMod2.Visible = False
        ImgQuit1.Visible = True
        ImgQuit2.Visible = False
        ImgDel1.Visible = True
        ImgDel2.Visible = False
    End Sub

    Private Sub ImgMod2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ImgMod2.Click
        Dim CompanyDetails As Object
        Dim vCompanyname As Object
        vCompanyname = Trim(fgrdCompanyList.get_TextMatrix(fgrdCompanyList.Row, 0))
        Me.Hide()
        CompanyDetails.Show()
    End Sub

    Private Sub ImgAdd2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ImgAdd2.Click
        Dim CompanyDetails As Object
        Me.Close()
        CompanyList1.DefInstance = Nothing
        CompanyDetails.Show()
    End Sub

    Private Sub ImgPro1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles ImgPro1.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = eventArgs.X
        Dim y As Single = eventArgs.Y
        ImgPro1.Visible = False
        ImgPro2.Visible = True
    End Sub

    Private Sub ImgPro2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ImgPro2.Click
        Call fgrdCompanyList_Click1()
    End Sub

    Private Sub fgrdCompanyList_Click1()
        Dim MainMenu As Object
        Dim gLogo As Object
        Dim gMainScreen As Object
        Dim FrontConnection As Object
        Dim GetfrontConnection As Object
        Dim gAddress As Object
        Dim vCompanyname As Object
        Dim gFinancialyearEnding As Object
        Dim gFinancialyearStart As Object
        'Dim gCompanyname As Object
        Dim ADODB As Object
        Dim vDate As Date
        If Trim(fgrdCompanyList.get_TextMatrix(fgrdCompanyList.Row, 0)) <> "" Then
            gCompanyname = Trim(fgrdCompanyList.get_TextMatrix(fgrdCompanyList.Row, 0))
            gFinancialyearStart = Format(CDate(fgrdCompanyList.get_TextMatrix(fgrdCompanyList.Row, 1)), "dd/MM/yyyy")
            gFinancialyearEnding = Format(CDate(fgrdCompanyList.get_TextMatrix(fgrdCompanyList.Row, 2)), "dd/MM/yyyy")
            gFinancalyearStart = Year(gFinancialyearStart)
            gFinancialyearEnd = Year(gFinancialyearEnding)
            gFinancialyearEnd = Year(gFinancialyearEnding)
            gDatabase = Trim(fgrdCompanyList.get_TextMatrix(fgrdCompanyList.Row, 7))
            vCompanyname = Trim(fgrdCompanyList.get_TextMatrix(fgrdCompanyList.Row, 0))
            Me.Hide()
            Dim mdiacc As New Main_MDI
            mdiacc.Show()
        End If
    End Sub

    Private Sub fgrdCompanyList_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSFlexGridLib.DMSFlexGridEvents_KeyPressEvent) Handles fgrdCompanyList.KeyPressEvent
        If eventArgs.keyAscii = System.Windows.Forms.Keys.Return Then
            Call fgrdCompanyList_Click1()
        End If
    End Sub

    Private Sub fgrdCompanyList_RowColChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles fgrdCompanyList.RowColChange
        lblAddress1.Text = Trim(fgrdCompanyList.get_TextMatrix(fgrdCompanyList.Row, 3))
        lblAddress2.Text = Trim(fgrdCompanyList.get_TextMatrix(fgrdCompanyList.Row, 4))
        lblAddress3.Text = Trim(fgrdCompanyList.get_TextMatrix(fgrdCompanyList.Row, 5))
        lblAddress4.Text = Trim(fgrdCompanyList.get_TextMatrix(fgrdCompanyList.Row, 6))
    End Sub

    Private Sub CompanyList1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim adLockPessimistic As Object
        Dim adOpenKeyset As Object
        Dim gUserCategory As Object
        Dim SQLSTRING As String
        lblAddress1.Text = ""
        lblAddress2.Text = ""
        lblAddress3.Text = ""
        lblAddress4.Text = ""
        Dim LoopIndex As Integer
        If gUserCategory <> "S" Then
            ImgMod1.Enabled = False
            ImgMod2.Enabled = False
            ImgAdd1.Enabled = False
            ImgAdd2.Enabled = False
            ImgDel1.Enabled = False
            ImgDel2.Enabled = False
        End If
        SQLSTRING = "SELECT ISNULL(COMPANYNAME,'') AS COMPANYNAME,ISNULL(FROMDATE,GETDATE()) AS FROMDATE,ISNULL(TODATE,GETDATE()) AS TODATE,ISNULL(SHORTNAME,'') AS SHORTNAME,ISNULL(DATAFILE,'') AS DATAFILE, "
        SQLSTRING = SQLSTRING & " ISNULL(ADD1,'') AS ADD1,ISNULL(ADD2,'') AS ADD2,ISNULL(CITY,'') AS CITY,ISNULL(STATE,'') AS STATE,ISNULL(PINCODE,'') AS PINCODE,ISNULL(PHONE1,'') AS PHONE1,ISNULL(FAX,'') AS FAX, ISNULL (AUDITFLG,'N') AS AUDITFLG FROM CLUBMASTER WHERE ISNULL(ACTIVE,'')='Y' ORDER BY SNO"
        gconnection.getCompanyinfo(SQLSTRING, "CLUBMASTER")
        If gdataset.Tables("CLUBMASTER").Rows.Count > 0 Then
            If fgrdCompanyList.Rows < gdataset.Tables("CLUBMASTER").Rows.Count - 1 Then
                fgrdCompanyList.Rows = gdataset.Tables("CLUBMASTER").Rows.Count + 3
            End If
            For LoopIndex = 0 To gdataset.Tables("CLUBMASTER").Rows.Count - 1
                With gdataset.Tables("CLUBMASTER").Rows(LoopIndex)
                    fgrdCompanyList.set_TextMatrix(LoopIndex + 1, 0, Trim(.Item("COMPANYNAME")))
                    fgrdCompanyList.set_TextMatrix(LoopIndex + 1, 1, Format(.Item("FROMDATE"), "dd/MM/yyyy"))
                    fgrdCompanyList.set_TextMatrix(LoopIndex + 1, 2, Format(.Item("TODATE"), "dd/MM/yyyy"))
                    fgrdCompanyList.set_TextMatrix(LoopIndex + 1, 3, Trim(.Item("ADD1")))
                    fgrdCompanyList.set_TextMatrix(LoopIndex + 1, 4, Trim(.Item("ADD2")))
                    fgrdCompanyList.set_TextMatrix(LoopIndex + 1, 5, Trim(.Item("CITY")))
                    fgrdCompanyList.set_TextMatrix(LoopIndex + 1, 5, Trim(.Item("STATE")))
                    fgrdCompanyList.set_TextMatrix(LoopIndex + 1, 7, Trim(CStr(.Item("DATAFILE"))))
                    fgrdCompanyList.set_TextMatrix(LoopIndex + 1, 5, Trim(.Item("PHONE1")))
                    fgrdCompanyList.set_TextMatrix(LoopIndex + 1, 5, Trim(.Item("FAX")))
                End With
            Next LoopIndex
        End If
        Call fgrdCompanyList_RowColChange(fgrdCompanyList, New System.EventArgs)
    End Sub

    Private Sub ImgQuit1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles ImgQuit1.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = eventArgs.X
        Dim y As Single = eventArgs.Y
        ImgQuit1.Visible = False
        ImgQuit2.Visible = True
    End Sub

    Private Sub ImgMod1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles ImgMod1.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = eventArgs.X
        Dim y As Single = eventArgs.Y
        ImgMod1.Visible = False
        ImgMod2.Visible = True
    End Sub

    Private Sub ImgAdd1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles ImgAdd1.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = eventArgs.X
        Dim y As Single = eventArgs.Y
        ImgAdd1.Visible = False
        ImgAdd2.Visible = True
    End Sub

    Private Sub ImgDel1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles ImgDel1.MouseMove
        Dim Button As Short = eventArgs.Button \ &H100000
        Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
        Dim X As Single = eventArgs.X
        Dim y As Single = eventArgs.Y
        ImgDel1.Visible = False
        ImgDel2.Visible = True
    End Sub

    Private Sub ImgPro1_Click(sender As Object, e As EventArgs) Handles ImgPro1.Click

    End Sub
End Class