Public Class Main_MDI
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnu_Masters As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_Transaction As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_Reports As System.Windows.Forms.MenuItem
    Friend WithEvents mnu_Utility As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_Calculator As System.Windows.Forms.MenuItem
    Friend WithEvents submnu_Notepad As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_Rpt_Amendment As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_Quit As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_WarrantyTerms As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents Mnu_OtherTerms As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_MDI))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnu_Masters = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.Mnu_WarrantyTerms = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.Mnu_OtherTerms = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem50 = New System.Windows.Forms.MenuItem()
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.MenuItem54 = New System.Windows.Forms.MenuItem()
        Me.MenuItem55 = New System.Windows.Forms.MenuItem()
        Me.mnu_Transaction = New System.Windows.Forms.MenuItem()
        Me.MenuItem24 = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem53 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.mnu_Reports = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.Mnu_Rpt_Amendment = New System.Windows.Forms.MenuItem()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItem29 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem51 = New System.Windows.Forms.MenuItem()
        Me.MenuItem52 = New System.Windows.Forms.MenuItem()
        Me.mnu_Utility = New System.Windows.Forms.MenuItem()
        Me.submnu_Calculator = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.submnu_Notepad = New System.Windows.Forms.MenuItem()
        Me.MenuItem13 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.Mnu_Quit = New System.Windows.Forms.MenuItem()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_Masters, Me.mnu_Transaction, Me.mnu_Reports, Me.mnu_Utility, Me.MenuItem16, Me.Mnu_Quit})
        '
        'mnu_Masters
        '
        Me.mnu_Masters.Index = 0
        Me.mnu_Masters.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem7, Me.MenuItem5, Me.MenuItem10, Me.Mnu_WarrantyTerms, Me.MenuItem15, Me.Mnu_OtherTerms, Me.MenuItem14, Me.MenuItem8, Me.MenuItem2, Me.MenuItem50, Me.MenuItem49, Me.MenuItem3, Me.MenuItem41, Me.MenuItem42, Me.MenuItem47, Me.MenuItem48, Me.MenuItem54, Me.MenuItem55})
        Me.mnu_Masters.Text = "&Masters"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "PaymentTerms"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 1
        Me.MenuItem7.Text = "-"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.Text = "DeliveryTerms"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 3
        Me.MenuItem10.Text = "-"
        '
        'Mnu_WarrantyTerms
        '
        Me.Mnu_WarrantyTerms.Index = 4
        Me.Mnu_WarrantyTerms.Text = "Warranty Terms"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 5
        Me.MenuItem15.Text = "-"
        '
        'Mnu_OtherTerms
        '
        Me.Mnu_OtherTerms.Index = 6
        Me.Mnu_OtherTerms.Text = "Other Terms"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 7
        Me.MenuItem14.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 8
        Me.MenuItem8.Text = "ItemMaster"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 9
        Me.MenuItem2.Text = "-"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 10
        Me.MenuItem50.Text = "Vendor Group Master"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 11
        Me.MenuItem49.Text = "-"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 12
        Me.MenuItem3.Text = "Vendor Master"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 13
        Me.MenuItem41.Text = "-"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 14
        Me.MenuItem42.Text = "Vendor Category Link"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 15
        Me.MenuItem47.Text = "-"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 16
        Me.MenuItem48.Text = "Category Master"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 17
        Me.MenuItem54.Text = "Department Master"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 18
        Me.MenuItem55.Text = "Designation Master"
        '
        'mnu_Transaction
        '
        Me.mnu_Transaction.Index = 1
        Me.mnu_Transaction.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem24, Me.MenuItem25, Me.MenuItem26, Me.MenuItem27, Me.MenuItem1, Me.MenuItem40, Me.MenuItem37, Me.MenuItem19, Me.MenuItem22, Me.MenuItem38, Me.MenuItem21, Me.MenuItem34, Me.MenuItem35, Me.MenuItem36, Me.MenuItem53, Me.MenuItem39, Me.MenuItem20})
        Me.mnu_Transaction.Text = "&Transactions"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 0
        Me.MenuItem24.Text = "Po Indent"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 1
        Me.MenuItem25.Text = "Indent Authorization"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 2
        Me.MenuItem26.Text = "Quotation Invitation"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 3
        Me.MenuItem27.Text = "Quotation Verification"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 4
        Me.MenuItem1.Text = "Purchase Order"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 5
        Me.MenuItem40.Text = "Purchase Order Direct"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 6
        Me.MenuItem37.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 7
        Me.MenuItem19.Text = "Hire Order"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 8
        Me.MenuItem22.Text = "Hire Order Return"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 9
        Me.MenuItem38.Text = "-"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 10
        Me.MenuItem21.Text = "Work Order Indent"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 11
        Me.MenuItem34.Text = "Project : Tender BOQ"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 12
        Me.MenuItem35.Text = "Enquiry Upload"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 13
        Me.MenuItem36.Text = "Work Order"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 14
        Me.MenuItem53.Text = "Service Order"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 15
        Me.MenuItem39.Text = "-"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 16
        Me.MenuItem20.Text = "Payment Tracking For Work Order"
        '
        'mnu_Reports
        '
        Me.mnu_Reports.Index = 2
        Me.mnu_Reports.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem43, Me.MenuItem45, Me.MenuItem44, Me.MenuItem46, Me.MenuItem9, Me.MenuItem11, Me.Mnu_Rpt_Amendment, Me.MenuItem12, Me.MenuItem6, Me.MenuItem28, Me.MenuItem29, Me.MenuItem30, Me.MenuItem31, Me.MenuItem32, Me.MenuItem33, Me.MenuItem51, Me.MenuItem52})
        Me.mnu_Reports.Text = "Re&ports"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 0
        Me.MenuItem43.Text = "Purchase Order Report"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 1
        Me.MenuItem45.Text = "Work Order Report"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 2
        Me.MenuItem44.Text = "Hire Order Report"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 3
        Me.MenuItem46.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 4
        Me.MenuItem9.Text = "Datewise P.O. Register"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 5
        Me.MenuItem11.Text = "-"
        '
        'Mnu_Rpt_Amendment
        '
        Me.Mnu_Rpt_Amendment.Index = 6
        Me.Mnu_Rpt_Amendment.Text = "Amendment- Follow-up Register"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 7
        Me.MenuItem12.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 8
        Me.MenuItem6.Text = "Purchase Register Report"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 9
        Me.MenuItem28.Text = "Indent Register"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 10
        Me.MenuItem29.Text = "Hire Order / Return  Register"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 11
        Me.MenuItem30.Text = "Work Order Register"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 12
        Me.MenuItem31.Text = "Quotation Register"
        Me.MenuItem31.Visible = False
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 13
        Me.MenuItem32.Text = "Pending Purchase Order"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 14
        Me.MenuItem33.Text = "Quotation Register"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 15
        Me.MenuItem51.Text = "Category Wise Purchase Order Report"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 16
        Me.MenuItem52.Text = "Vender Purchase Details"
        '
        'mnu_Utility
        '
        Me.mnu_Utility.Index = 3
        Me.mnu_Utility.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.submnu_Calculator, Me.MenuItem23, Me.submnu_Notepad, Me.MenuItem13})
        Me.mnu_Utility.Text = "&Utility"
        '
        'submnu_Calculator
        '
        Me.submnu_Calculator.Index = 0
        Me.submnu_Calculator.Shortcut = System.Windows.Forms.Shortcut.CtrlL
        Me.submnu_Calculator.Text = "Calculator"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.Text = "-"
        '
        'submnu_Notepad
        '
        Me.submnu_Notepad.Index = 2
        Me.submnu_Notepad.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.submnu_Notepad.Text = "Note Pad"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 3
        Me.MenuItem13.Text = "-"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 4
        Me.MenuItem16.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem17, Me.MenuItem18})
        Me.MenuItem16.Text = "&Administrator"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 0
        Me.MenuItem17.Text = "Select Company"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 1
        Me.MenuItem18.Text = "User Admin"
        '
        'Mnu_Quit
        '
        Me.Mnu_Quit.Index = 5
        Me.Mnu_Quit.Text = "Quit"
        '
        'Main_MDI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1024, 575)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Main_MDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PURCHASE ORDER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Private Sub Main_MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sqlstring As String
        MDIParentobj = Me
        AppPath = Application.StartupPath
        AppPath = Application.StartupPath
        If Dir(AppPath & "\Reports", FileAttribute.Directory) = "" Then
            MkDir(AppPath & "\Reports")
        End If
        '  Call updation()
        Call Clearfiles()
        Call FillCompanyinfo()
        If gCompanyShortName = "SATC" Then
            'Me.MenuItem36.Text = "Service Order"
            'Me.MenuItem36.Text = "Work Order"
            Me.MenuItem53.Visible = True
        Else
            Me.MenuItem53.Visible = False
        End If
        If gCompanyShortName = "CATH" Then
            Me.MenuItem24.Visible = False
            Me.MenuItem25.Visible = False
            Me.MenuItem26.Visible = False
            Me.MenuItem27.Visible = False
            Me.MenuItem1.Visible = False
            Me.MenuItem40.Visible = False
            Me.MenuItem19.Visible = False
            Me.MenuItem22.Visible = False
            Me.MenuItem34.Visible = False
            Me.MenuItem35.Visible = False
            Me.MenuItem53.Visible = False
            Me.MenuItem20.Visible = False
            Me.MenuItem43.Visible = False
            Me.MenuItem44.Visible = False
            Me.MenuItem9.Visible = False
            Me.Mnu_Rpt_Amendment.Visible = False
            Me.MenuItem6.Visible = False
            Me.MenuItem28.Visible = False
            Me.MenuItem29.Visible = False
            Me.MenuItem31.Visible = False
            Me.MenuItem32.Visible = False
            Me.MenuItem33.Visible = False
            Me.MenuItem51.Visible = False
            Me.MenuItem52.Visible = False
        End If

        Call GetAccountcode()
        '  Call Activateuseradmin()
        Me.IsMdiContainer = True
    End Sub
    Public Sub Clearfiles()
        AppPath = Application.StartupPath
        Shell("CLEAR.BAT", AppWinStyle.Hide)
    End Sub
    Private Sub Activateuseradmin()
        Dim totmenu As Integer = 0
        Dim i, j, k, ckhmn, ckhmn1 As Integer
        Call menublock()
        For i = 0 To MainMenu1.MenuItems.Count - 2
            ckhmn1 = MainMenu1.MenuItems(i).MenuItems.Count()
            If ckhmn1 <> 0 Then
                For j = 0 To MainMenu1.MenuItems(i).MenuItems.Count() - 1
                    ckhmn = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count()
                    If ckhmn <> 0 Then
                        For k = 0 To MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count() - 1
                            totmenu = totmenu + 1
                        Next
                    Else
                        totmenu = totmenu + 1
                    End If
                Next
            Else
                totmenu = totmenu + 1
            End If
        Next
        gconnection.getDataSet("SELECT COUNT(*) FROM  modulemaster WHERE PackageName='Purchase Order'", "chk")
        If gdataset.Tables("chk").Rows.Count <> totmenu Then
            gconnection.ExcuteStoreProcedure("DELETE FROM modulemaster WHERE PackageName='Purchase Order'")
            Call checkmenulist()
        End If
        If gUserCategory = "S" Or gUserCategory = "A" Then
            Call menuclear()
        Else
            Call relemenu()
        End If
    End Sub
    Sub menuclear()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        vmain = MainMenu1.MenuItems.Count
        For i = 0 To vmain - 2
            vsmod = MainMenu1.MenuItems(i).MenuItems.Count
            If vsmod <> 0 Then
                For j = 0 To vsmod - 1
                    vssmod = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count
                    If vssmod <> 0 Then
                        For k = 0 To vssmod - 1
                            MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = True
                        Next
                    Else
                        MainMenu1.MenuItems(i).MenuItems(j).Enabled = True
                    End If
                Next
            Else
                MainMenu1.MenuItems(i).Enabled = True
            End If
        Next
    End Sub
    Sub menublock()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        vmain = MainMenu1.MenuItems.Count
        For i = 0 To vmain - 2
            vsmod = MainMenu1.MenuItems(i).MenuItems.Count
            If vsmod <> 0 Then
                For j = 0 To vsmod - 1
                    vssmod = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count
                    If vssmod <> 0 Then
                        For k = 0 To vssmod - 1
                            MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Enabled = False
                        Next
                    Else
                        MainMenu1.MenuItems(i).MenuItems(j).Enabled = False
                    End If
                Next
            Else
                MainMenu1.MenuItems(i).Enabled = False
            End If
        Next
    End Sub
    Sub relemenu()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql As String
        Dim ds As New DataSet
        Dim chstr As String
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        gconnection.getDataSet("SELECT * FROM USERADMIN WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='PURCHASE ORDER'", "user")
        If gdataset.Tables("user").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("user").Rows.Count - 1
                With gdataset.Tables("user").Rows(i)
                    If Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" And Trim(.Item("ssubmoduleid") & "") <> "" Then
                        a = .Item("mainmoduleid")
                        b = Val(.Item("submoduleid"))
                        c = Val(.Item("ssubmoduleid"))
                        Menu.MenuItems(a).MenuItems(b).MenuItems(c).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" Then
                        a = gdataset.Tables("user").Rows(i).Item("mainmoduleid")
                        b = Val(gdataset.Tables("user").Rows(i).Item("submoduleid"))
                        Menu.MenuItems(a).MenuItems(b).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" Then
                        Menu.MenuItems((.Item("mainmoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    End If
                End With
            Next
        End If
    End Sub
    Public Sub checkmenulist()
        Dim i, j, k, x As Integer
        Dim vsql() As String
        Dim vmain, vsmod, vssmod As Long
        x = 0
        ReDim vsql(x)
        vmain = MainMenu1.MenuItems.Count
        If vmain <> 0 Then
            For i = 0 To vmain - 2
                vsmod = MainMenu1.MenuItems(i).MenuItems.Count
                If vsmod <> 0 Then
                    For j = 0 To vsmod - 1
                        vssmod = MainMenu1.MenuItems(i).MenuItems(j).MenuItems.Count
                        If vssmod <> 0 Then
                            For k = 0 To vssmod - 1
                                If MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Visible = True Then
                                    If Trim(MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Text) <> "-" Then
                                        vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName) values "
                                        vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(MainMenu1.MenuItems(i).Text.Replace("&", "") & "") & "',"
                                        vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & j & "','" & Trim(MainMenu1.MenuItems(i).MenuItems(j).Text.Replace("&", "") & "") & "',"
                                        vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & k & "','" & Trim(MainMenu1.MenuItems(i).MenuItems(j).MenuItems(k).Text.Replace("&", "") & "") & "','Purchase Order')"
                                        ReDim Preserve vsql(vsql.Length)
                                    End If
                                End If
                            Next
                        Else
                            If MainMenu1.MenuItems(i).MenuItems(j).Visible = True Then
                                If Trim(MainMenu1.MenuItems(i).MenuItems(j).Text) <> "-" Then
                                    vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName ) values "
                                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(MainMenu1.MenuItems(i).Text.Replace("&", "") & "") & "',"
                                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'" & j & "','" & Trim(MainMenu1.MenuItems(i).MenuItems(j).Text.Replace("&", "") & "") & "',"
                                    vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','','Purchase Order')"
                                    ReDim Preserve vsql(vsql.Length)
                                End If
                            End If
                        End If
                    Next
                Else
                    If MainMenu1.MenuItems(i).Visible = True Then
                        If MainMenu1.MenuItems(i).Text = True Then
                            vsql(vsql.Length - 1) = "insert into Modulemaster(Mainmoduleid,MainModulename,SubModuleid,SubModulename,SsubModuleid,SsubModuleName,PackageName) values "
                            vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & " ('" & i & "','" & Trim(MainMenu1.MenuItems(i).Text.Replace("&", "") & "") & "',"
                            vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','',"
                            vsql(vsql.Length - 1) = vsql(vsql.Length - 1) & "'','','Purchase Order')"
                            ReDim Preserve vsql(vsql.Length)
                        End If
                    End If
                End If
            Next
            ReDim Preserve vsql(vsql.Length - 2)
            gconnection.MoreTrans1(vsql)
        End If
    End Sub
    Private Sub GetAccountcode()
        Dim sqlstring As String
        sqlstring = "SELECT ISNULL(SDRSCODE,'') AS SDRSCODE,ISNULL(SCRSCODE,'') AS SCRSCODE FROM ACCOUNTSSETUP "
        gconnection.getDataSet(sqlstring, "ACCOUNTSSETUP")
        If gdataset.Tables("ACCOUNTSSETUP").Rows.Count > 0 Then
            gDebitors = Trim(UCase(gdataset.Tables("ACCOUNTSSETUP").Rows(0).Item("SDRSCODE")))
            gCreditors = Trim(UCase(gdataset.Tables("ACCOUNTSSETUP").Rows(0).Item("SCRSCODE")))
        Else
            gDebitors = ""
            gCreditors = ""
        End If


        sqlstring = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'CLOSINGQTY'"
        gconnection.getDataSet(sqlstring, "INV_WEIGHTED_VIEW1")
        If gdataset.Tables("INV_WEIGHTED_VIEW1").Rows.Count > 0 Then
            gInventoryVersion = "N"
        Else
            gInventoryVersion = "O"
        End If
    End Sub
    Public Sub FillCompanyinfo()
        Dim sqlstring As String
        Try
            If Trim(gDatabase) <> "" Then
                sqlstring = " SELECT ISNULL(CompanyName,'') AS CompanyName,ISNULL(SHORTNAME,'') AS SHORTNAME,ISNULL(Fromdate,getdate()) AS Fromdate,ISNULL(Todate,getdate()) AS Todate,ISNULL(Add1,'') AS Add1,ISNULL(Add2,'') AS Add2,"
                sqlstring = sqlstring & " ISNULL(City,'') AS City,ISNULL(State,'') AS State,ISNULL(Pincode,'') AS Pincode,ISNULL(Datafile,'')AS Datafile,ISNULL(PHONE1,'')+','+ISNULL(PHONE2,'')AS PHONE,ISNULL(TINNO,'') AS TINNO, ISNULL(FAX,'') AS FAX, ISNULL(EMAIL,'') AS EMAIL, ISNULL(WEBSITE,'') AS WEBSITE, ISNULL(SERVICETAX,'') AS SERVICETAX, ISNULL(AUDITFLG,'N') AS AUDITFLG ,isnull(GSTINNO,'') as GSTINNO   FROM ClubMaster WHERE DATAFILE = '" & Trim(gDatabase) & "'"
            Else
                sqlstring = " SELECT ISNULL(CompanyName,'') AS CompanyName,ISNULL(SHORTNAME,'') AS SHORTNAME,ISNULL(Fromdate,getdate()) AS Fromdate,ISNULL(Todate,getdate()) AS Todate,ISNULL(Add1,'') AS Add1,ISNULL(Add2,'') AS Add2,"
                sqlstring = sqlstring & " ISNULL(City,'') AS City,ISNULL(State,'') AS State,ISNULL(Pincode,'') AS Pincode,ISNULL(Datafile,'') AS Datafile,ISNULL(PHONE1,'')+','+ISNULL(PHONE2,'')AS PHONE,ISNULL(TINNO,'') AS TINNO, ISNULL(FAX,'') AS FAX, ISNULL(EMAIL,'') AS EMAIL, ISNULL(WEBSITE,'') AS WEBSITE, ISNULL(SERVICETAX,'') AS SERVICETAX, ISNULL (AUDITFLG,'N') AUDITFLG,isnull(GSTINNO,'') as GSTINNO FROM ClubMaster "
            End If
            gconnection.getCompanyinfo(sqlstring, "ClubMaster")
            If gdataset.Tables("ClubMaster").Rows.Count > 0 Then
                MyCompanyName = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("CompanyName")))
                gCompanyShortName = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("SHORTNAME")))
                Address1 = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Add1")))
                Address2 = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Add2")))
                gCity = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("City")))
                gState = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("State")))
                gPincode = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Pincode")))
                gDatabase = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Datafile")))
                GPHONE = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("PHONE")))
                gTinNo = Trim(CStr(gdataset.Tables("Clubmaster").Rows(0).Item("TINNO")))
                gFax = Trim(CStr(gdataset.Tables("Clubmaster").Rows(0).Item("FAX")))
                gEmail = Trim(CStr(gdataset.Tables("Clubmaster").Rows(0).Item("EMAIL")))
                gWebsite = Trim(CStr(gdataset.Tables("Clubmaster").Rows(0).Item("WEBSITE")))
                gServiceTax = Trim(CStr(gdataset.Tables("Clubmaster").Rows(0).Item("SERVICETAX")))
                gGSTINCode = Trim(CStr(gdataset.Tables("Clubmaster").Rows(0).Item("GSTINNO")))
                gAuditFlg = Trim(CStr(gdataset.Tables("Clubmaster").Rows(0).Item("AuditFlg")))
                Me.Text = MyCompanyName & " [" & "PURCHASE ORDER SYSTEM" & " ] " & Space(10) & " USERNAME: " & gUsername & Space(10) & " " & gFinancalyearStart & "-" & gFinancialyearEnd

                If Mid(MyCompanyName, 1, 3) = "HIN" Then
                    PrintTaxheading1 = "C.F"
                    PrintTaxheading2 = "CHARGES"
                Else
                    PrintTaxheading1 = "SALES"
                    PrintTaxheading2 = "TAX"
                End If
            Else
                MessageBox.Show("Plz. Contact to your Computer Administrator ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub submnu_Calculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_Calculator.Click
        GmoduleName = "Calculator"
        Shell(Environment.SystemDirectory & "\calc.exe", AppWinStyle.NormalFocus)
        submnu_Calculator.Checked = True
        submnu_Notepad.Checked = False
    End Sub

    Private Sub submnu_Notepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submnu_Notepad.Click
        GmoduleName = "Note Pad"
        Shell(Environment.SystemDirectory & "\notepad.exe", AppWinStyle.NormalFocus)
        submnu_Calculator.Checked = False
        submnu_Notepad.Checked = True
    End Sub


    Private Sub submnu_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Public Sub GetServer()
        Dim ServerConn As New OleDb.OleDbConnection
        Dim servercmd As New OleDb.OleDbDataAdapter
        Dim getserver As New DataSet
        Dim sql, ssql As String
        sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
        sql = sql & AppPath & "DBS_KEY.MDB"
        ServerConn.ConnectionString = sql
        Try
            ServerConn.Open()
            ssql = "SELECT SERVER,database FROM DBSKEY"
            servercmd = New OleDb.OleDbDataAdapter(ssql, ServerConn)
            servercmd.Fill(getserver)
            If getserver.Tables(0).Rows.Count > 0 Then
                gserver = abcdMINUS(Trim(getserver.Tables(0).Rows(0).Item(0)))
                gDatabase = abcdMINUS(Trim(getserver.Tables(0).Rows(0).Item(1)))
            Else
                MessageBox.Show("Failed to connect to data source")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to data source")
            MsgBox(ex.Message)
        Finally
            ServerConn.Close()
        End Try
    End Sub

    Private Function DuplicateForm(ByVal FormName As String) As Boolean
        DuplicateForm = False
        Dim i As Integer
        If Me.MdiChildren Is Nothing Then
            Exit Function
        End If
        For i = 0 To Me.MdiChildren.Length - 1
            If Me.MdiChildren(i).Name = FormName Then
                GmoduleName = FormName
                DuplicateForm = True
                Exit Function
            End If
        Next i
    End Function

    Private Sub mnu_Administrator_Select(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If UserAdminbool = False Then
            'submnu_Useradmin.Checked = False
        End If
    End Sub

    Private Sub Mnu_Quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_Quit.Click
        Dim sht As New shutdown
        sht.MdiParent = Me
        sht.Show()
    End Sub


    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim PO_Vendor As New CustomerMaster
        PO_Vendor.MdiParent = Me
        PO_Vendor.Show()
    End Sub

    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim PO_Quotation As New Quotation
        PO_Quotation.MdiParent = Me
        PO_Quotation.Show()
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        GmoduleName = "PaymentTerms"
        Dim PO_paymentterm As New paymentterms
        PO_paymentterm.MdiParent = Me
        PO_paymentterm.Show()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        GmoduleName = "DeliveryTerms"
        Dim PO_deliveryterm As New deliveryterms
        PO_deliveryterm.MdiParent = Me
        PO_deliveryterm.Show()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        GmoduleName = "itemmaster"
        Dim PO_itemmaster As New itemmaster
        PO_itemmaster.MdiParent = Me
        PO_itemmaster.Show()
        'GmoduleName = "itemmaster"
        'Dim PO_itemmaster As New Item_Master
        'PO_itemmaster.MdiParent = Me
        'PO_itemmaster.Show()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        GmoduleName = "Datewise P.O. Register"
        Dim PO_purchaseorderrpt As New DatewisePurchaseOrderRegister
        PO_purchaseorderrpt.MdiParent = Me
        PO_purchaseorderrpt.Show()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        GmoduleName = "Purchase Order"
        Dim PO_Order As New PurchaseOrder_SCOLD
        PO_Order.MdiParent = Me
        PO_Order.Show()
    End Sub

    Private Sub Mnu_Rpt_Amendment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_Rpt_Amendment.Click
        GmoduleName = "Amendment- Follow-up Register"
        Dim PO_RptAmendment As New rptAmendment
        PO_RptAmendment.MdiParent = Me
        PO_RptAmendment.Show()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        GmoduleName = "Vendor Master"
        Dim PO_CustomerMaster As New CustomerMaster
        PO_CustomerMaster.MdiParent = Me
        PO_CustomerMaster.Show()
    End Sub

    Private Sub MenuItem4_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles MenuItem4.DrawItem
        Dim Ic As New Icon(AppPath & "\icons\Flag.ico")
        DrawItems(e, MenuItem4, Ic)
    End Sub

    Private Sub MenuItem4_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles MenuItem4.MeasureItem
        MeasureItems(e, MenuItem4)
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        GmoduleName = "Purchase Register Report"
        Dim PO_POSummary As New FRM_PURCHASE
        PO_POSummary.MdiParent = Me
        PO_POSummary.Show()
    End Sub

    Private Sub MenuItem1_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles MenuItem1.DrawItem
        Dim Ic As New Icon(AppPath & "\icons\Flag.ico")
        DrawItems(e, MenuItem1, Ic)
    End Sub

    Private Sub MenuItem1_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles MenuItem1.MeasureItem
        MeasureItems(e, MenuItem1)
    End Sub

    Private Sub MenuItem9_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles MenuItem9.DrawItem
        Dim Ic As New Icon(AppPath & "\icons\Flag.ico")
        DrawItems(e, MenuItem9, Ic)
    End Sub

    Private Sub MenuItem9_MeasureItem(ByVal sender As Object, ByVal e As System.Windows.Forms.MeasureItemEventArgs) Handles MenuItem9.MeasureItem
        MeasureItems(e, MenuItem9)
    End Sub

    Private Sub Mnu_UserAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim PO_UserAdmin As New UserAdmin
        PO_UserAdmin.MdiParent = Me
        PO_UserAdmin.Show()
    End Sub

    Private Sub Mnu_WarrantyTerms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_WarrantyTerms.Click
        GmoduleName = "Warranty Terms"
        Dim PO_WarrantyTerms As New Warrantyterms
        PO_WarrantyTerms.MdiParent = Me
        PO_WarrantyTerms.Show()
    End Sub

    Private Sub Mnu_OtherTerms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_OtherTerms.Click
        GmoduleName = "Other Terms"
        Dim PO_OtherTerms As New OtherTerms
        PO_OtherTerms.MdiParent = Me
        PO_OtherTerms.Show()
    End Sub
    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Obj_laser As New Laser_print
        Obj_laser.MdiParent = Me
        Obj_laser.Show()
    End Sub
    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        Main_MDI.ActiveForm.Hide()
        Dim cmp As New CompanyList1
        cmp.Show()
    End Sub
    Private Sub Main_MDI_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        End
    End Sub
    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Dim PO_UserAdmin As New UserAdmin
        PO_UserAdmin.MdiParent = Me
        PO_UserAdmin.Show()
    End Sub
    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        GmoduleName = "Hire Order"
        Dim Hire_Order As New PO_HireOrder
        Hire_Order.MdiParent = Me
        Hire_Order.Show()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        GmoduleName = "Payment Tracking For Work Order"
        Dim Work_Order As New PO_WorkOrder
        Work_Order.MdiParent = Me
        Work_Order.Show()
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        GmoduleName = "Work Order Indent"
        Dim Work_OrderIndent As New PO_WorkOrderIndent
        Work_OrderIndent.MdiParent = Me
        Work_OrderIndent.Show()
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        GmoduleName = "Hire Order Return"
        Dim Hire_OrderReturn As New PO_HireOrder_RET
        Hire_OrderReturn.MdiParent = Me
        Hire_OrderReturn.Show()
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        GmoduleName = "Po Indent"
        Dim sti As New PO_StockIndent
        sti.MdiParent = Me
        sti.Show()
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        GmoduleName = "Indent Authorization"
        Dim stiA As New StockIssue_Indent_authorization
        stiA.MdiParent = Me
        stiA.Show()
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        GmoduleName = "Quotation Invitation"
        Dim QUOT As New QUOTATIONINVITATION
        QUOT.MdiParent = Me
        QUOT.Show()
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        GmoduleName = "Quatation Verification"
        Dim QT As New quotationuploaddownload
        QT.MdiParent = Me
        QT.Show()
    End Sub

    Private Sub MenuItem28_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        GmoduleName = "Indent Register"
        Dim IR As New Indent_Register
        IR.MdiParent = Me
        IR.Show()
    End Sub

    Private Sub MenuItem29_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem29.Click
        GmoduleName = "Hire Order / Return  Register"
        Dim IR As New frmHIREORDERregister
        IR.MdiParent = Me
        IR.Show()
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem30.Click
        GmoduleName = "Work Order Register"
        Dim IR As New frmWORKORDERregister
        IR.MdiParent = Me
        IR.Show()
    End Sub

    Private Sub MenuItem31_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem31.Click
        GmoduleName = "Quotation Register"
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem32.Click
        GmoduleName = "Pending Purchase Order"
        Dim IR As New PendingPO
        IR.MdiParent = Me
        IR.Show()
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem33.Click
        GmoduleName = "Quotation Register"
        Dim IR As New frmQUOTATIONregister
        IR.MdiParent = Me
        IR.Show()
    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        GmoduleName = "Project : Tender BOQ"
        Dim IR As New PO_ProjectTenderBOQ
        IR.MdiParent = Me
        IR.Show()
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem35.Click
        GmoduleName = "Enquiry Upload"
        Dim IR As New QUOTATIONINVITATIONFORWOANDHO
        IR.MdiParent = Me
        IR.Show()
    End Sub

    Private Sub MenuItem36_Click(ByVal sender As Object, ByVal e As EventArgs) Handles MenuItem36.Click
        GmoduleName = "Work Order"
        Dim WO As New po_workorderbook1
        WO.formType = "WO"
        'If gCompanyShortName = "SATC" Then
        '    WO.formType = "SO"
        'Else

        'End If
        WO.MdiParent = Me
        WO.Show()
    End Sub

    Private Sub mnu_Reports_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnu_Reports.Click

    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        GmoduleName = "Purchase Order"
        Dim PO_Order As New PurchaseOrder_SCnew
        PO_Order.MdiParent = Me
        PO_Order.Show()
    End Sub

    Private Sub MenuItem42_Click(sender As Object, e As EventArgs) Handles MenuItem42.Click
        GmoduleName = "Vendor Category Link"
        Dim vcl As New VENDOR_CATEGORY_LINK
        vcl.MdiParent = Me
        vcl.Show()
    End Sub

    Private Sub MenuItem43_Click(sender As Object, e As EventArgs) Handles MenuItem43.Click
        GmoduleName = "Purchase Order Report"
        Dim por As New po_report
        por.MdiParent = Me
        por.Show()
    End Sub

    Private Sub MenuItem45_Click(sender As Object, e As EventArgs) Handles MenuItem45.Click
        GmoduleName = "Work Order Report"
        Dim wor As New WO_REPORT
        wor.MdiParent = Me
        wor.Show()
    End Sub

    Private Sub MenuItem44_Click(sender As Object, e As EventArgs) Handles MenuItem44.Click
        GmoduleName = "Hire Order Report"
        Dim hor As New HO_DETAILS
        hor.MdiParent = Me
        hor.Show()
    End Sub

    Private Sub MenuItem48_Click(sender As Object, e As EventArgs) Handles MenuItem48.Click
        GmoduleName = "Category Master"
        Dim CM As New category_master
        CM.MdiParent = Me
        CM.Show()
    End Sub

    Private Sub MenuItem50_Click(sender As Object, e As EventArgs) Handles MenuItem50.Click
        GmoduleName = "Vendor Group Master"
        Dim CM1 As New vendor_group_master
        CM1.MdiParent = Me
        CM1.Show()
    End Sub

    Private Sub MenuItem51_Click(sender As Object, e As EventArgs) Handles MenuItem51.Click
        GmoduleName = "Category Wise Purchase Order"
        Dim CM1 As New categorywise_po_report
        CM1.MdiParent = Me
        CM1.Show()
    End Sub

    Public Sub updation()
        Dim str1 As String
        Try
            str1 = " ALTER          view [dbo].[PO_VIEW_VENDORMASTER]    "
            str1 = str1 & " AS "
            str1 = str1 & " select isnull(slcode,'') as vendorcode,isnull(slname,'') as vendorname,                  "
            str1 = str1 & " isnull(ADDRESS1,'')AS ADDRESS1, isnull(ADDRESS2,'') as address2, isnull(address3,'') AS ADDRESS3, isnull(city,'') AS CITY,   isnull(pin,'') + ' ' + isnull(state,'') as state,ISNULL(SLTYPE,'') AS SLTYPE,              "
            str1 = str1 & " '' AS PINCODE,'' AS PHONE ,ISNULL(CELLNO,'') AS MOBILE,'' AS FAX,'' AS EMAIL,contactperson AS CONTACTPERSON ,ISNULL(VATNO,'')AS VATNO,ISNULL(CSTNO ,'') AS CSTNO,ISNULL(TINNO,'')AS TINNO,ISNULL(PANNO,'')AS PANNO,category as category "
            str1 = str1 & " from accountssubledgermaster where SLTYPE ='SUPPLIER' and isnull(freezeflag,'')<>'y'   And slcode Not in ('101')       "
            str1 = str1 & " union    "
            str1 = str1 & " select isnull(vendorcode,'') as vendorcode,isnull(vendorname,'') as vendorname,                  "
            str1 = str1 & " isnull(ADDRESS,'')ADDRESS1,isnull(ADDRESS2,'') AS ADDRESS2, isnull(address3,'')as address3, isnull(CITY,'') as city, isnull(state,'') as state,              "
            str1 = str1 & "  '' AS SLTYPE,ISNULL(cast(PINCODE as varchar(20)),'') AS PINCODE,ISNULL(cast(PHONE1 as varchar(35)),'') AS PHONE,ISNULL(cast(PHONE2 as varchar(35)),'') AS MOBILE,               "
            str1 = str1 & "  ISNULL(cast(FAX as varchar(20)),'') AS FAX,ISNULL(EMAIL,'') AS EMAIL,ISNULL(CONTACTPERSON,'') AS CONTACTPERSON  ,''AS VATNO,ISNULL(CASTNO ,'') AS CSTNO,ISNULL(TINNO,'')AS TINNO,ISNULL(PANNO,'')AS PANNO, category                   "
            str1 = str1 & " from po_vendormaster where isnull(freeze,'')<>'y' "
            gconnection.dataOperation1(6, str1, "item")


            str1 = " alter VIEW [dbo].[VIEW_HO_REPORT]  "
            str1 = str1 & " AS  "
            str1 = str1 & " SELECT ISNULL(GRNNO,'') AS GRNNO, ISNULL(GRNDETAILS,'') AS GRNDETAILS, ISNULL(GRNDATE,'') AS GRNDATE,  "
            str1 = str1 & " ISNULL(SUPPLIERCODE,'') SUPPLIERCODE, ISNULL(SUPPLIERNAME,'') AS SUPPLIERNAME, ISNULL(Billamount,0)  AS TOTALAMOUNT "
            str1 = str1 & " FROM HRN_HEADER"
            gconnection.dataOperation1(6, str1, "item")


            ''***** 
            'str1 = "   ALTER    VIEW [dbo].[VW_PO_POBILL]                     "
            'str1 = str1 & " AS                     "
            'str1 = str1 & " SELECT distinct isnull(d.ITEMCODE,'') as ITEMCODE,D.autoid,                       "
            'str1 = str1 & " ISNULL(G.PONO,'') AS PONO,G.PODATE,                   "
            'str1 = str1 & " ISNULL(G.DOCTYPE,'') AS CATEGORY,                  "
            'str1 = str1 & " ISNULL(S.INDENTNO,'') AS INDENTNO,                  "
            'str1 = str1 & " ISNULL(S.INDENTDATE,'') AS INDENTDATE,                  "
            'str1 = str1 & " ISNULL(POVENDORCODE,'') AS SUPPLIERCODE,isnull(a.vendorname,'') as SUPPLIERNAME,        "
            'str1 = str1 & " isnull(g.AUTH_DOCNO,'') as AUTH_DOCNO, isnull(g.POQUOTNO,'') as QUOTNO,                  "
            'str1 = str1 & " isnull(g.PODEPARTMENT,'') as DEPARTMENT, isnull(g.POAPPROVEDBY,'') as APPROVEDBY,                    "
            'str1 = str1 & " isnull(g.POSTATUS,'') as POSTATUS,isnull(G.POVALUE,0) as POTOTAL,                  "
            'str1 = str1 & " isnull(G.POTOTALVAT,0) as TOT_VAT, isnull(G.POTOTALTAX,0) as TOT_TAX,                  "
            'str1 = str1 & " isnull(G.POTOTALDISCOUNT,0) as TOT_DISCOUNT, isnull(G.POADVANCE,0) as ADVANCE,                  "
            'str1 = str1 & " isnull(G.POoveralldisc,0) as overalldisc,  isnull(G.POCF,0) as POCF,                  "
            'str1 = str1 & " isnull(G.POTRANSPORT,0) as POTRANSPORT, isnull(G.PODELIVERYAMT,0) as PODELIVERYAMT,                  "
            'str1 = str1 & " isnull(G.POTERMS,'') as PAYMENTTERMS,                  "
            'str1 = str1 & " isnull(POREMARKS,'') as POREMARKS, isnull(G.PODELIVERYTERMS,'') as DELIVERYTERMS,                  "
            ''str1 = str1 & " --isnull(A.ADDRESS1,'') as ADDRESS, ISNULL(A.ADDRESS2,'') AS ADDRESS2, ISNULL(A.ADDRESS3,'') AS ADDRESS3,   isnull(A.CITY,'') as CITY,   isnull(A.STATE,'') as STATE,                   "
            ''str1 = str1 & " -- isnull(A.MOBILE,0) as MOBILENO,    isnull(A.PINCODE,0) as PINCODE,  isnull(A.EMAIL,'') as EMAIL,                    "
            'str1 = str1 & " "
            'str1 = str1 & " isnull(P.ITEMNAME,'') as ITEMNAME,                    "
            'str1 = str1 & " isnull(D.UOM,'') as UOM,ISNULL(D.QUANTITY,0) AS QTY, ISNULL(D.RATE,0) AS RATE,                  "
            'str1 = str1 & " ISNULL(D.DISCOUNT,0) AS DISCOUNT,ISNULL(D.VATAMT,0) AS VATAMT,ISNULL(D.VAT,0) AS VAT,ISNULL(D.TOTAL,0) AS TOTAL,                "
            'str1 = str1 & " ISNULL(D.DISCAMT,0) AS DISCAMT,                  "
            'str1 = str1 & " ISNULL(D.AMOUNT,0) AS AMOUNT,ISNULL(D.TOTAL,0) AS AMOUNT1,  "
            'str1 = str1 & " isnull(g.FREEZE,'') as FREEZE,                   "
            'str1 = str1 & " isnull(g.ADDUSER,'') as ADDUSER,                    "
            'str1 = str1 & " ISNULL(g.AdddateTIME,'') AS ADDDATE ,isnull(g.UPDATEUSER,'') as UPDATEUSER, ISNULL(g.UPDATedateTIME,'') AS UPDATETIME, ISNULL(SUBJECT,'') AS SUBJECT,               "
            ''str1 = str1 & " --ISNULL(A.FAX,'') AS FAX, ISNULL(CSTNO,'') AS CSTNO, ISNULL(TINNO,'') AS TINNO, ISNULL(PANNO,'') AS PANNO,ISNULL(CONTACTPERSON,'') AS CONTACTPERSON,              "
            'str1 = str1 & " ISNULL(pocst,0) AS POCST, ISNULL(poed,0) AS POED, ISNULL(pomodvat,0) AS POMODVAT, ISNULL(poptax,0) AS POPTAX, ISNULL(pooctra,0) AS POOCTRA,              "
            'str1 = str1 & " ISNULL(poinsurance,0) AS POINSURANCE, ISNULL(polst,0) AS POLST, ISNULL(POADVPERC,0) AS POADVPERC, ISNULL(POSALET,'') AS POSALET,              "
            'str1 = str1 & " ISNULL(PODESPMODE,'') AS PODESPMODE, ISNULL(PODOCSTHROUGH,'') AS PODOCSTHROUGH              "
            'str1 = str1 & " FROM po_HDR AS G                  "
            'str1 = str1 & " INNER JOIN po_ITEMdetAILS AS D ON G.PONO = D.PONO                   "
            'str1 = str1 & " LEFT OUTER JOIN PO_VIEW_ITEMMASTER AS P ON D.ITEMCODE = P.ITEMCODE                   "
            'str1 = str1 & " LEFT OUTER JOIN  PO_VIEW_VENDORMASTER AS A ON G.POVENDORCODE = A.VENDORCODE                "
            'str1 = str1 & " LEFT OUTER JOIN  PO_STOCKINDENTAUTH_HDR AS S ON G.AUTH_DOCNO = S.DOCDETAILS"
            'gconnection.dataOperation1(6, str1, "item")

            str1 = "CREATE      view [dbo].[PO_VIEW_ITEMMASTER_BROWSE]          "

            str1 = str1 & " as           "

            str1 = str1 & " select distinct isnull(itemcode,'') as itemcode,isnull(itemname,'') as itemname,isnull(receiveuom,'')           "
            str1 = str1 & " as stockuom,ISNULL(purchaserate,0) AS purchaserate ,  0 as clstock, ADDUSER, ADDDATE, FREEZE"
            str1 = str1 & " from inventoryitemmaster  where isnull(freeze,'') <> 'Y' and storecode in ('mns','ls','cs')  "
            str1 = str1 & " union    "

            str1 = str1 & " select isnull(itemcode,'') as itemcode,isnull(itemname,'') as itemname,isnull(uom,'') as           "
            str1 = str1 & " stockuom, ISNULL(currentofferrate,0) AS currentofferrate , 0 AS  clstock, ADDUSER,ADDDATETIME AS ADDDATE,FREEZE from po_itemmaster   "
            str1 = str1 & " where itemcode not in (select itemcode from inventoryitemmaster)"
            ' gconnection.dataOperation1(6, str1, "item")


            '***** 
            str1 = "   ALTER    VIEW [dbo].[VW_PO_POBILL]                     "
            str1 = str1 & " AS                     "
            str1 = str1 & " SELECT distinct isnull(d.ITEMCODE,'') as ITEMCODE,D.autoid,                       "
            str1 = str1 & " ISNULL(G.PONO,'') AS PONO,G.PODATE,                   "
            str1 = str1 & " ISNULL(G.DOCTYPE,'') AS CATEGORY,                  "
            str1 = str1 & " ISNULL(S.INDENTNO,'') AS INDENTNO,                  "
            str1 = str1 & " ISNULL(S.INDENTDATE,'') AS INDENTDATE,                  "
            str1 = str1 & " ISNULL(POVENDORCODE,'') AS SUPPLIERCODE,isnull(a.vendorname,'') as SUPPLIERNAME,        "
            str1 = str1 & " isnull(g.AUTH_DOCNO,'') as AUTH_DOCNO, isnull(g.POQUOTNO,'') as QUOTNO,                  "
            str1 = str1 & " isnull(g.PODEPARTMENT,'') as DEPARTMENT, isnull(g.POAPPROVEDBY,'') as APPROVEDBY,                    "
            str1 = str1 & " isnull(g.POSTATUS,'') as POSTATUS,isnull(G.POVALUE,0) as POTOTAL,                  "
            str1 = str1 & " isnull(G.POTOTALVAT,0) as TOT_VAT, isnull(G.POTOTALTAX,0) as TOT_TAX,                  "
            str1 = str1 & " isnull(G.POTOTALDISCOUNT,0) as TOT_DISCOUNT, isnull(G.POADVANCE,0) as ADVANCE,                  "
            str1 = str1 & " isnull(G.POoveralldisc,0) as overalldisc,  isnull(G.POCF,0) as POCF,                  "
            str1 = str1 & " isnull(G.POTRANSPORT,0) as POTRANSPORT, isnull(G.PODELIVERYAMT,0) as PODELIVERYAMT,                  "
            str1 = str1 & " isnull(G.POTERMS,'') as PAYMENTTERMS,                  "
            str1 = str1 & " isnull(POREMARKS,'') as POREMARKS, isnull(G.PODELIVERYTERMS,'') as DELIVERYTERMS,                  "
            'str1 = str1 & " --isnull(A.ADDRESS1,'') as ADDRESS, ISNULL(A.ADDRESS2,'') AS ADDRESS2, ISNULL(A.ADDRESS3,'') AS ADDRESS3,   isnull(A.CITY,'') as CITY,   isnull(A.STATE,'') as STATE,                   "
            'str1 = str1 & " -- isnull(A.MOBILE,0) as MOBILENO,    isnull(A.PINCODE,0) as PINCODE,  isnull(A.EMAIL,'') as EMAIL,                    "
            str1 = str1 & " "
            str1 = str1 & " isnull(P.ITEMNAME,'') as ITEMNAME,                    "
            str1 = str1 & " isnull(D.UOM,'') as UOM,ISNULL(D.QUANTITY,0) AS QTY, ISNULL(D.RATE,0) AS RATE,                  "
            str1 = str1 & " ISNULL(D.DISCOUNT,0) AS DISCOUNT,ISNULL(D.VATAMT,0) AS VATAMT,ISNULL(D.VAT,0) AS VAT,ISNULL(D.TOTAL,0) AS TOTAL,                "
            str1 = str1 & " ISNULL(D.DISCAMT,0) AS DISCAMT,                  "
            str1 = str1 & " ISNULL(D.AMOUNT,0) AS AMOUNT,ISNULL(D.TOTAL,0) AS AMOUNT1,  "
            str1 = str1 & " isnull(g.FREEZE,'') as FREEZE,                   "
            str1 = str1 & " isnull(g.ADDUSER,'') as ADDUSER,                    "
            str1 = str1 & " ISNULL(g.AdddateTIME,'') AS ADDDATE ,isnull(g.UPDATEUSER,'') as UPDATEUSER, ISNULL(g.UPDATedateTIME,'') AS UPDATETIME, ISNULL(SUBJECT,'') AS SUBJECT,               "
            'str1 = str1 & " --ISNULL(A.FAX,'') AS FAX, ISNULL(CSTNO,'') AS CSTNO, ISNULL(TINNO,'') AS TINNO, ISNULL(PANNO,'') AS PANNO,ISNULL(CONTACTPERSON,'') AS CONTACTPERSON,              "
            str1 = str1 & " ISNULL(pocst,0) AS POCST, ISNULL(poed,0) AS POED, ISNULL(pomodvat,0) AS POMODVAT, ISNULL(poptax,0) AS POPTAX, ISNULL(pooctra,0) AS POOCTRA,              "
            str1 = str1 & " ISNULL(poinsurance,0) AS POINSURANCE, ISNULL(polst,0) AS POLST, ISNULL(POADVPERC,0) AS POADVPERC, ISNULL(POSALET,'') AS POSALET,              "
            str1 = str1 & " ISNULL(PODESPMODE,'') AS PODESPMODE, ISNULL(PODOCSTHROUGH,'') AS PODOCSTHROUGH,              "


            str1 = str1 & " ISNULL(G.POED,0) AS ED, ISNULL(G.POCST,0) AS CST,  "
            str1 = str1 & " ISNULL(G.MODVATVAL,0) AS MODVATVAL, isnull(G.quot_date,'') as quot_date, "
            str1 = str1 & " isnull(G.poquotno,'') as poquotno, isnull(G.ser_ch,0) as ser_Ch, ISNULL(G.WARRANTY,'') AS WARRANTY , "
            str1 = str1 & " (SELECT  isnull(DELIVERYTERMDESC,'') FROM PO_DELIVERYTERMS WHERE PO_DELIVERYTERMS.DELIVERYTERMCODE=G.PODELIVERYTERMS) as DELIVERYTERMDESC,"
            str1 = str1 & " (SELECT isnull(PAYMENTTERMDESC,'') FROM PO_PAYMENTTERMS WHERE PO_PAYMENTTERMS.PAYMENTTERMCODE=G.POTERMS) as PAYMENTTERMDESC"



            str1 = str1 & " FROM po_HDR AS G                  "
            str1 = str1 & " INNER JOIN po_ITEMdetAILS AS D ON G.PONO = D.PONO                   "
            str1 = str1 & " LEFT OUTER JOIN PO_VIEW_ITEMMASTER AS P ON D.ITEMCODE = P.ITEMCODE                   "
            str1 = str1 & " LEFT OUTER JOIN  PO_VIEW_VENDORMASTER AS A ON G.POVENDORCODE = A.VENDORCODE                "
            str1 = str1 & " LEFT OUTER JOIN  PO_STOCKINDENTAUTH_HDR AS S ON G.AUTH_DOCNO = S.DOCDETAILS"
            gconnection.dataOperation1(6, str1, "item")


            str1 = "IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'po_vendormaster' AND  COLUMN_NAME = 'VENDORTYPE') Begin alter table po_vendormaster add  VENDORTYPE varchar(20) End"
            gconnection.dataOperation1(6, str1, "item")

            str1 = "IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'po_vendormaster' AND  COLUMN_NAME = 'GSTINNO') Begin alter table po_vendormaster add  GSTINNO varchar(100) End"
            gconnection.dataOperation1(6, str1, "item")

            str1 = "IF NOT EXISTS( SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'po_vendormaster' AND  COLUMN_NAME = 'GSTINNO') Begin alter table po_vendormaster add  GSTINNO varchar(100) End"
            gconnection.dataOperation1(6, str1, "item")


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Main_MDI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub MenuItem52_Click(sender As Object, e As EventArgs) Handles MenuItem52.Click
        GmoduleName = "Purchase Order"
        Dim VP As New VenderPurcahase
        VP.MdiParent = Me
        VP.Show()
    End Sub

    Private Sub MenuItem53_Click(sender As Object, e As EventArgs) Handles MenuItem53.Click
        GmoduleName = "Work Order"
        Dim WO As New po_workorderbook1
        WO.formType = "SO"
        'If gCompanyShortName = "SATC" Then
        '    WO.formType = "WO"
        'Else

        'End If
        WO.MdiParent = Me
        WO.Show()
    End Sub

    Private Sub MenuItem55_Click(sender As Object, e As EventArgs) Handles MenuItem55.Click
        GmoduleName = "Designation Master"
        Dim PO_deliveryterm As New DesignationMaster
        PO_deliveryterm.MdiParent = Me
        PO_deliveryterm.Show()
    End Sub

    Private Sub MenuItem54_Click(sender As Object, e As EventArgs) Handles MenuItem54.Click
        GmoduleName = "Department Master"
        Dim PO_deliveryterm As New DepartmentMaster
        PO_deliveryterm.MdiParent = Me
        PO_deliveryterm.Show()
    End Sub
End Class