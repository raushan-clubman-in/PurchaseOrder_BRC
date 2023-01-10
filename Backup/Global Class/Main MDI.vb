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
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Main_MDI))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnu_Masters = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.Mnu_WarrantyTerms = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.Mnu_OtherTerms = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.mnu_Transaction = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.mnu_Reports = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.Mnu_Rpt_Amendment = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.mnu_Utility = New System.Windows.Forms.MenuItem
        Me.submnu_Calculator = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.submnu_Notepad = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.Mnu_Quit = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnu_Masters, Me.mnu_Transaction, Me.mnu_Reports, Me.mnu_Utility, Me.MenuItem16, Me.Mnu_Quit})
        '
        'mnu_Masters
        '
        Me.mnu_Masters.Index = 0
        Me.mnu_Masters.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4, Me.MenuItem7, Me.MenuItem5, Me.MenuItem10, Me.Mnu_WarrantyTerms, Me.MenuItem15, Me.Mnu_OtherTerms, Me.MenuItem14, Me.MenuItem8, Me.MenuItem2, Me.MenuItem3})
        Me.mnu_Masters.Text = "&Masters"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.OwnerDraw = True
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
        'MenuItem3
        '
        Me.MenuItem3.Index = 10
        Me.MenuItem3.Text = "Vendor Master"
        '
        'mnu_Transaction
        '
        Me.mnu_Transaction.Index = 1
        Me.mnu_Transaction.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem24, Me.MenuItem25, Me.MenuItem26, Me.MenuItem27, Me.MenuItem1, Me.MenuItem19, Me.MenuItem20, Me.MenuItem21, Me.MenuItem22})
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
        Me.MenuItem25.Text = "Indent Autorization"
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
        Me.MenuItem1.OwnerDraw = True
        Me.MenuItem1.Text = "Purchase Order"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 5
        Me.MenuItem19.Text = "Hire Order"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 6
        Me.MenuItem20.Text = "Work / Hire Order"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 7
        Me.MenuItem21.Text = "Work Order Indent"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 8
        Me.MenuItem22.Text = "Hire Order Return"
        '
        'mnu_Reports
        '
        Me.mnu_Reports.Index = 2
        Me.mnu_Reports.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem9, Me.MenuItem11, Me.Mnu_Rpt_Amendment, Me.MenuItem12, Me.MenuItem6, Me.MenuItem28})
        Me.mnu_Reports.Text = "Re&ports"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 0
        Me.MenuItem9.OwnerDraw = True
        Me.MenuItem9.Text = "Datewise P.O. Register"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "-"
        '
        'Mnu_Rpt_Amendment
        '
        Me.Mnu_Rpt_Amendment.Index = 2
        Me.Mnu_Rpt_Amendment.Text = "Amendment- Follow-up Register"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 3
        Me.MenuItem12.Text = "-"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 4
        Me.MenuItem6.Text = "Purchase Register Summary"
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
        'MenuItem28
        '
        Me.MenuItem28.Index = 5
        Me.MenuItem28.Text = "Indent Register"
        '
        'Main_MDI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 575)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Main_MDI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PURCHASE ORDER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized

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
        Call Clearfiles()
        Call FillCompanyinfo()
        Call GetAccountcode()
        Call Activateuseradmin()
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
        gconnection.getDataSet("SELECT * FROM USERADMIN WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='Purchase Order' order by convert(int,mainmoduleid) ,convert(int,submoduleid) , convert(int,ssubmoduleid)", "user")
        'If gdataset.Tables("user").Rows.Count - 1 >= 0 Then
        '    For i = 0 To gdataset.Tables("user").Rows.Count - 1
        '        With gdataset.Tables("user").Rows(i)
        '            If Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" And Trim(.Item("ssubmoduleid") & "") <> "" Then
        '                MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).MenuItems(Val(.Item("submoduleid"))).MenuItems(Val(.Item("ssubmoduleid"))).Enabled = True
        '                chstr = abcdMINUS(.Item("rights"))
        '            ElseIf Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" Then
        '                MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).MenuItems(Val(.Item("submoduleid"))).Enabled = True
        '                chstr = abcdMINUS(.Item("rights"))
        '            ElseIf Trim(.Item("mainmoduleid") & "") <> "" Then
        '                MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).Enabled = True
        '                chstr = abcdMINUS(.Item("rights"))
        '            End If
        '        End With
        '    Next
        'End If
        If gdataset.Tables("user").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("user").Rows.Count - 1
                With gdataset.Tables("user").Rows(i)
                    If Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" And Trim(.Item("ssubmoduleid") & "") <> "" Then
                        MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).MenuItems(Val(.Item("submoduleid"))).MenuItems(Val(.Item("ssubmoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" And Trim(.Item("submoduleid") & "") <> "" Then
                        MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).MenuItems(Val(.Item("submoduleid"))).Enabled = True
                        chstr = abcdMINUS(.Item("rights"))
                    ElseIf Trim(.Item("mainmoduleid") & "") <> "" Then
                        MainMenu1.MenuItems(Val(.Item("mainmoduleid"))).Enabled = True
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
    End Sub
    Public Sub FillCompanyinfo()
        Dim sqlstring As String
        Try
            If Trim(gDatabase) <> "" Then
                sqlstring = " SELECT ISNULL(CompanyName,'') AS CompanyName,ISNULL(Fromdate,getdate()) AS Fromdate,ISNULL(Todate,getdate()) AS Todate,ISNULL(Add1,'') AS Add1,ISNULL(Add2,'') AS Add2,"
                sqlstring = sqlstring & " ISNULL(City,'') AS City,ISNULL(State,'') AS State,ISNULL(Pincode,'') AS Pincode,ISNULL(Datafile,'')AS Datafile,ISNULL(PHONE1,'')+','+ISNULL(PHONE2,'')AS PHONE  FROM ClubMaster WHERE DATAFILE = '" & Trim(gDatabase) & "'"
            Else
                sqlstring = " SELECT ISNULL(CompanyName,'') AS CompanyName,ISNULL(Fromdate,getdate()) AS Fromdate,ISNULL(Todate,getdate()) AS Todate,ISNULL(Add1,'') AS Add1,ISNULL(Add2,'') AS Add2,"
                sqlstring = sqlstring & " ISNULL(City,'') AS City,ISNULL(State,'') AS State,ISNULL(Pincode,'') AS Pincode,ISNULL(Datafile,'') AS Datafile,ISNULL(PHONE1,'')+','+ISNULL(PHONE2,'')AS PHONE FROM ClubMaster "
            End If
            gconnection.getCompanyinfo(sqlstring, "ClubMaster")
            If gdataset.Tables("ClubMaster").Rows.Count > 0 Then
                MyCompanyName = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("CompanyName")))
                Address1 = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Add1")))
                Address2 = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Add2")))
                gCity = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("City")))
                gState = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("State")))
                gPincode = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Pincode")))
                gDatabase = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("Datafile")))
                GPHONE = Trim(CStr(gdataset.Tables("ClubMaster").Rows(0).Item("PHONE")))
                Me.Text = MyCompanyName & " [" & "PURCHASE ORDER SYSTEM" & " ]"
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
                gserver = getserver.Tables(0).Rows(0).Item(0)
                gDatabase = getserver.Tables(0).Rows(0).Item(1)
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
        Dim PO_paymentterm As New paymentterms
        PO_paymentterm.MdiParent = Me
        PO_paymentterm.Show()
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Dim PO_deliveryterm As New deliveryterms
        PO_deliveryterm.MdiParent = Me
        PO_deliveryterm.Show()
    End Sub
    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem8.Click
        Dim PO_itemmaster As New itemmaster
        PO_itemmaster.MdiParent = Me
        PO_itemmaster.Show()
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Dim PO_purchaseorderrpt As New DatewisePurchaseOrderRegister
        PO_purchaseorderrpt.MdiParent = Me
        PO_purchaseorderrpt.Show()
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim PO_Order As New PurchaseOrder_SC
        PO_Order.MdiParent = Me
        PO_Order.Show()
    End Sub

    Private Sub Mnu_Rpt_Amendment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_Rpt_Amendment.Click
        Dim PO_RptAmendment As New rptAmendment
        PO_RptAmendment.MdiParent = Me
        PO_RptAmendment.Show()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
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
        Dim PO_WarrantyTerms As New Warrantyterms
        PO_WarrantyTerms.MdiParent = Me
        PO_WarrantyTerms.Show()
    End Sub

    Private Sub Mnu_OtherTerms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mnu_OtherTerms.Click
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
        Dim Hire_Order As New PO_HireOrder
        Hire_Order.MdiParent = Me
        Hire_Order.Show()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Dim Work_Order As New PO_WorkOrder
        Work_Order.MdiParent = Me
        Work_Order.Show()
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Dim Work_OrderIndent As New PO_WorkOrderIndent
        Work_OrderIndent.MdiParent = Me
        Work_OrderIndent.Show()
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        Dim Hire_OrderReturn As New PO_HireOrderReturn
        Hire_OrderReturn.MdiParent = Me
        Hire_OrderReturn.Show()
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        Dim sti As New StockIndentnew
        sti.MdiParent = Me
        sti.Show()
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem25.Click
        Dim stiA As New StockIndentAUTHORIZATION
        stiA.MdiParent = Me
        stiA.Show()
    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        Dim QUOT As New QUOTATIONINVITATION
        QUOT.MdiParent = Me
        QUOT.Show()
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        Dim QT As New quotationuploaddownload
        QT.MdiParent = Me
        QT.Show()
    End Sub

    Private Sub MenuItem28_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        Dim IR As New Indent_Register
        IR.MdiParent = Me
        IR.Show()
    End Sub
End Class