Imports System.Data.SqlClient
Imports System.IO
Public Class ReportDesigner
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
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SsGridReport As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents lbl_caption As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ReportDesigner))
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SsGridReport = New AxFPSpreadADO.AxfpSpread
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.lbl_caption = New System.Windows.Forms.Label
        CType(Me.SsGridReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(232, 8)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(247, 31)
        Me.lbl_Heading.TabIndex = 4
        Me.lbl_Heading.Text = "REPORT DESIGNER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Location = New System.Drawing.Point(184, 331)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 56)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'SsGridReport
        '
        Me.SsGridReport.DataSource = Nothing
        Me.SsGridReport.Location = New System.Drawing.Point(12, 48)
        Me.SsGridReport.Name = "SsGridReport"
        Me.SsGridReport.OcxState = CType(resources.GetObject("SsGridReport.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SsGridReport.Size = New System.Drawing.Size(672, 264)
        Me.SsGridReport.TabIndex = 3
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(192, 347)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 0
        Me.Cmd_View.Text = " View[F10]"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(304, 347)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 1
        Me.Cmd_Print.Text = "Print[F11]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(416, 347)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 2
        Me.Cmd_Exit.Text = "Exit[F12]"
        '
        'lbl_caption
        '
        Me.lbl_caption.AutoSize = True
        Me.lbl_caption.BackColor = System.Drawing.Color.Transparent
        Me.lbl_caption.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_caption.Location = New System.Drawing.Point(16, 318)
        Me.lbl_caption.Name = "lbl_caption"
        Me.lbl_caption.Size = New System.Drawing.Size(463, 18)
        Me.lbl_caption.TabIndex = 6
        Me.lbl_caption.Text = "Note : Press F2 for Select All / Press F3 to Deselect all"
        '
        'ReportDesigner
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(694, 395)
        Me.Controls.Add(Me.lbl_caption)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.SsGridReport)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ReportDesigner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MASTER [ CHECKLIST ]"
        CType(Me.SsGridReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim Colomns As String
    Dim checkbool As Boolean
    Dim sizes As String
    Dim dr As DataRow
    Public Sub checkvalidation()
        Dim i, j As Integer
        Dim boolOrder As Boolean
        Dim getcheck, GETCHECK1, GETCHECK2 As Object
        Dim vaildOrderby As String
        checkbool = True : boolOrder = False
        For i = 1 To Me.SsGridReport.DataRowCnt
            SsGridReport.Col = 1
            SsGridReport.Row = i
            getcheck = Trim(SsGridReport.Text)
            If Val(getcheck) = 1 Then
                SsGridReport.Col = 5
                SsGridReport.Row = i
                If Trim(SsGridReport.Text) = "" Then
                    checkbool = True
                    Exit Sub
                End If
            End If
        Next i
        For i = 1 To Me.SsGridReport.DataRowCnt
            SsGridReport.Col = 1
            SsGridReport.Row = i
            getcheck = Trim(SsGridReport.Text)
            If Val(getcheck) = 1 Then
                SsGridReport.Col = 5
                SsGridReport.Row = i
                If Trim(SsGridReport.Text) <> "" Then
                    vaildOrderby = Trim(SsGridReport.Text)
                    For j = 1 To Me.SsGridReport.DataRowCnt
                        SsGridReport.Col = 1
                        SsGridReport.Row = j
                        GETCHECK1 = Trim(SsGridReport.Text)
                        If Val(GETCHECK1) = 1 Then
                            SsGridReport.Col = 2
                            SsGridReport.Row = j
                            If Trim(SsGridReport.Text) = vaildOrderby Then
                                boolOrder = True
                                Exit For
                            Else
                                boolOrder = False
                            End If
                        End If
                    Next j
                End If
            End If
        Next i
        If boolOrder = False Then
            MessageBox.Show("Plz Enter a valid column", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SsGridReport.ClearRange(5, 1, 5, -1, True)
            SsGridReport.SetActiveCell(5, SsGridReport.ActiveRow)
            SsGridReport.Focus()
            checkbool = False
            Exit Sub
        End If
        checkbool = True
    End Sub
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim chk As Boolean
        Dim getcheck As Object
        Dim i, j, cnt, totsize As Integer
        Dim Col, tab, ssql, Size, Caption, Order As String
        i = 1 : j = 1 : cnt = 0
        Call checkvalidation()
        If checkbool = False Then Exit Sub
        For i = 1 To Me.SsGridReport.DataRowCnt
            SsGridReport.Col = 1
            SsGridReport.Row = i
            getcheck = Trim(SsGridReport.Text)
            If Val(getcheck) = 1 Then
                If Colomns = "" Then
                    SsGridReport.Col = 2
                    SsGridReport.Row = i
                    Col = Trim(SsGridReport.Text)
                    SsGridReport.Col = 3
                    SsGridReport.Row = i
                    Size = Val(SsGridReport.Text)
                    totsize = totsize + Val(SsGridReport.Text)
                    Colomns = Col
                    Col = ""
                    cnt = cnt + 1
                Else
                    SsGridReport.Col = 2
                    SsGridReport.Row = i
                    Col = Trim(SsGridReport.Text)
                    Colomns = Colomns & "," & Col
                    SsGridReport.Col = 3
                    SsGridReport.Row = i
                    totsize = totsize + Val(SsGridReport.Text) + 1
                    Size = Size & "," & Trim(SsGridReport.Text)
                    Col = ""
                    cnt = cnt + 1
                End If
            End If
            getcheck = ""
        Next i
        If Colomns = "" Then
            MessageBox.Show("No Fields Has Been Selected", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If tables = "" Then
            MessageBox.Show("Table Name not found", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        For i = 1 To Me.SsGridReport.DataRowCnt
            SsGridReport.Col = 1
            SsGridReport.Row = i
            getcheck = Trim(SsGridReport.Text)
            If Val(getcheck) = 1 Then
                SsGridReport.Col = 4
                SsGridReport.Row = i
                If Trim(SsGridReport.Text) = "" Then
                    SsGridReport.Col = 2
                    SsGridReport.Row = i
                    Caption = Caption & "," & Trim(SsGridReport.Text)
                Else
                    SsGridReport.Col = 4
                    SsGridReport.Row = i
                    Caption = Caption & "," & Trim(SsGridReport.Text)
                End If
            End If
        Next i
        For i = 1 To Me.SsGridReport.DataRowCnt
            SsGridReport.Col = 1
            SsGridReport.Row = i
            getcheck = Trim(SsGridReport.Text)
            If Val(getcheck) = 1 Then
                SsGridReport.Col = 5
                SsGridReport.Row = i
                If Trim(SsGridReport.Text) <> "" Then
                    SsGridReport.Col = 5
                    SsGridReport.Row = i
                    Order = Order & "," & Trim(SsGridReport.Text)
                End If
            End If
        Next i
        If Mid(Order, 1, 1) = "," Then
            Order = Mid(Order, 2, Len(Order))
        End If
        If Order = "" Then
            For i = 1 To Me.SsGridReport.DataRowCnt
                SsGridReport.Col = 1
                SsGridReport.Row = i
                getcheck = Trim(SsGridReport.Text)
                If Val(getcheck) = 1 Then
                    SsGridReport.Col = 2
                    SsGridReport.Row = i
                    If Trim(SsGridReport.Text) <> "" Then
                        SsGridReport.Col = 2
                        SsGridReport.Row = i
                        Order = Order & "," & Trim(SsGridReport.Text)
                    End If
                End If
            Next i
        End If
        If Mid(Order, 1, 1) = "," Then
            Order = Mid(Order, 2, Len(Order))
        End If
        If Mid(Caption, 1, 1) = "," Then
            Caption = Mid(Caption, 2, Len(Caption))
        End If
        ssql = " SELECT " & Colomns & " FROM " & tables & " ORDER BY " & Order
        Colomns = ""
        gPrint = False
        Call PrintOperation(ssql, Size, Caption, totsize, cnt, Order)
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        Dim chk As Boolean
        Dim getcheck As Object
        Dim i, j, cnt, totsize As Integer
        Dim Col, tab, ssql, Size, Caption, Order As String
        i = 1 : j = 1 : cnt = 0
        Call checkvalidation()
        If checkbool = False Then Exit Sub
        For i = 1 To Me.SsGridReport.DataRowCnt
            SsGridReport.Col = 1
            SsGridReport.Row = i
            getcheck = Trim(SsGridReport.Text)
            If Val(getcheck) = 1 Then
                If Colomns = "" Then
                    SsGridReport.Col = 2
                    SsGridReport.Row = i
                    Col = Trim(SsGridReport.Text)
                    SsGridReport.Col = 3
                    SsGridReport.Row = i
                    Size = Val(SsGridReport.Text)
                    totsize = totsize + Val(SsGridReport.Text)
                    Colomns = Col
                    Col = ""
                    cnt = cnt + 1
                Else
                    SsGridReport.Col = 2
                    SsGridReport.Row = i
                    Col = Trim(SsGridReport.Text)
                    Colomns = Colomns & "," & Col
                    SsGridReport.Col = 3
                    SsGridReport.Row = i
                    totsize = totsize + Val(SsGridReport.Text) + 1
                    Size = Size & "," & Trim(SsGridReport.Text)
                    Col = ""
                    cnt = cnt + 1
                End If
            End If
            getcheck = ""
        Next i
        If Colomns = "" Then
            MessageBox.Show("No Fields Has Been Selected", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        If tables = "" Then
            MessageBox.Show("Table Name not found", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Exit Sub
        End If
        For i = 1 To Me.SsGridReport.DataRowCnt
            SsGridReport.Col = 1
            SsGridReport.Row = i
            getcheck = Trim(SsGridReport.Text)
            If Val(getcheck) = 1 Then
                SsGridReport.Col = 4
                SsGridReport.Row = i
                If Trim(SsGridReport.Text) = "" Then
                    SsGridReport.Col = 2
                    SsGridReport.Row = i
                    Caption = Caption & "," & Trim(SsGridReport.Text)
                Else
                    SsGridReport.Col = 4
                    SsGridReport.Row = i
                    Caption = Caption & "," & Trim(SsGridReport.Text)
                End If
            End If
        Next i
        For i = 1 To Me.SsGridReport.DataRowCnt
            SsGridReport.Col = 1
            SsGridReport.Row = i
            getcheck = Trim(SsGridReport.Text)
            If Val(getcheck) = 1 Then
                SsGridReport.Col = 5
                SsGridReport.Row = i
                If Trim(SsGridReport.Text) <> "" Then
                    SsGridReport.Col = 5
                    SsGridReport.Row = i
                    Order = Order & "," & Trim(SsGridReport.Text)
                End If
            End If
        Next i
        If Mid(Order, 1, 1) = "," Then
            Order = Mid(Order, 2, Len(Order))
        End If
        If Order = "" Then
            For i = 1 To Me.SsGridReport.DataRowCnt
                SsGridReport.Col = 1
                SsGridReport.Row = i
                getcheck = Trim(SsGridReport.Text)
                If Val(getcheck) = 1 Then
                    SsGridReport.Col = 2
                    SsGridReport.Row = i
                    If Trim(SsGridReport.Text) <> "" Then
                        SsGridReport.Col = 2
                        SsGridReport.Row = i
                        Order = Order & "," & Trim(SsGridReport.Text)
                    End If
                End If
            Next i
        End If
        If Mid(Order, 1, 1) = "," Then
            Order = Mid(Order, 2, Len(Order))
        End If
        If Mid(Caption, 1, 1) = "," Then
            Caption = Mid(Caption, 2, Len(Caption))
        End If
        ssql = " SELECT " & Colomns & tables & " ORDER BY " & Order
        Colomns = ""
        gPrint = True
        Call PrintOperation(ssql, Size, Caption, totsize, cnt, Order)
    End Sub
    Sub PrintOperation(ByVal sql As String, ByVal size As String, ByVal caption As String, ByVal totsize As Integer, ByVal cnt As Integer, ByVal Order As String)
        Dim Fsize(), Forder(), vFilepath, Itemcode, Array() As String
        Dim rowj, Loopindex, i, count, CountItem, Fo As Integer
        Dim ssql, vCaption, vPath, str As String
        Dim vOutfile, vheader, vline As String
        Dim ds As New DataSet
        Dim Filewrite As StreamWriter
        Dim vpagenumber, Vrowcount As Long
        Try
            pagesize = 0
            pageno = 1
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(vFilepath)
            printfile = vFilepath
            If Trim(Order) <> "" Then
                Forder = Order.Split(",")
                Forder.Sort(Forder)
                Order = ""
            End If
            gconnection.getDataSet(sql, "REPORTTABLE")
            If gdataset.Tables("REPORTTABLE").Rows.Count > 0 Then
                Filewrite.Write(Chr(15))
                'Filewrite.WriteLine("{0,60}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now.Today, "dd/MM/yyyy"))
                Filewrite.WriteLine(Space(60) & Chr(27) & "E" & "PRINTED ON : " & Format(Now.Today, "dd/MM/yyyy"))
                pagesize = pagesize + 1
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                'Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
                Filewrite.WriteLine(Mid(MyCompanyName, 1, 28) & Space(42) & "ACCOUNTING PERIOD")
                pagesize = pagesize + 1
                'Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(Gheader & " " & " DETAILS "), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialyearEnd)
                Filewrite.WriteLine(Mid(Address1, 1, 28) & Space(28 - Len(Trim(Mid(Address1, 1, 28)))) & Space(2) & Mid(Trim(Gheader & " " & " DETAILS "), 1, 30) & Space(30 - Len(Trim(Mid(Trim(Gheader & " " & " DETAILS "), 1, 30)))) & Space(3) & "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialyearEnd)
                pagesize = pagesize + 1
                'Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Gheader & " " & " DETAILS ")), "-"), 1, 30))
                Filewrite.WriteLine(Mid(Address2, 1, 30) & Space(28 - Len(Trim(Mid(Address2, 1, 28)))) & Space(2) & Mid(StrDup(Len(Trim(Gheader & " " & " DETAILS ")), "-"), 1, 30) & Chr(27) & "E")
                pagesize = pagesize + 1
                'Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
                'pagesize = pagesize + 1
                'Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
                'pagesize = pagesize + 1
                'Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(Now, "MMM dd,yyyy") & " " & "To" & " " & Format(Now, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
                'pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(90, "-"))
                pagesize = pagesize + 1
                Array = caption.Split(",")
                Fsize = size.Split(",")
                For count = 0 To Array.Length - 1
                    ssql = ssql & Mid(Trim(Array(count) & ""), 1, Val(Fsize(count))) & Space(Val(Fsize(count) + 1) - Len(Mid(Trim(Array(count) & ""), 1, Val(Fsize(count)))))
                Next
                Filewrite.WriteLine(ssql)
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(90, "-"))
                pagesize = pagesize + 1
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For rowj = 0 To gdataset.Tables("REPORTTABLE").Rows.Count - 1
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(90, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        pagesize = 0
                        'Filewrite.WriteLine("{0,60}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now.Today, "dd/MM/yyyy"))
                        Filewrite.WriteLine(Space(60) & Chr(27) & "E" & "PRINTED ON : " & Format(Now.Today, "dd/MM/yyyy"))
                        pagesize = pagesize + 1
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                        'Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
                        Filewrite.WriteLine(Mid(MyCompanyName, 1, 28) & Space(42) & "ACCOUNTING PERIOD")
                        pagesize = pagesize + 1
                        'Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(Gheader & " " & " DETAILS "), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialyearEnd)
                        Filewrite.WriteLine(Mid(Address1, 1, 28) & Space(28 - Len(Trim(Mid(Address1, 1, 28)))) & Space(2) & Mid(Trim(Gheader & " " & " DETAILS "), 1, 30) & Space(30 - Len(Trim(Mid(Trim(Gheader & " " & " DETAILS "), 1, 30)))) & Space(3) & "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialyearEnd)
                        pagesize = pagesize + 1
                        'Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Gheader & " " & " DETAILS ")), "-"), 1, 30))
                        Filewrite.WriteLine(Mid(Address2, 1, 30) & Space(28 - Len(Trim(Mid(Address2, 1, 28)))) & Space(2) & Mid(StrDup(Len(Trim(Gheader & " " & " DETAILS ")), "-"), 1, 30) & Chr(27) & "E")
                        pagesize = pagesize + 1
                        'Filewrite.WriteLine("{0,64}{1,-10}", " ", "SUMMARY")
                        'pagesize = pagesize + 1
                        'Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
                        'pagesize = pagesize + 1
                        'Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(Now, "MMM dd,yyyy") & " " & "To" & " " & Format(Now, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
                        'pagesize = pagesize + 1
                        Filewrite.WriteLine(StrDup(90, "-"))
                        pagesize = pagesize + 1
                        Array = caption.Split(",")
                        Fsize = size.Split(",")
                        For count = 0 To Array.Length - 1
                            ssql = ssql & Mid(Trim(Array(count) & ""), 1, Val(Fsize(count))) & Space(Val(Fsize(count) + 1) - Len(Mid(Trim(Array(count) & ""), 1, Val(Fsize(count)))))
                        Next
                        Filewrite.WriteLine(ssql)
                        pagesize = pagesize + 1
                        Filewrite.WriteLine(StrDup(90, "-"))
                        pagesize = pagesize + 1
                    End If
                    With gdataset.Tables("REPORTTABLE").Rows(rowj)
                        ssql = ""
                        While CountItem <= cnt - 1
                            ssql = ssql & Mid(Trim(.Item(CountItem) & ""), 1, Val(Fsize(CountItem))) & Space(Val(Fsize(CountItem) + 1) - Len(Mid(Trim(.Item(CountItem) & ""), 1, Val(Fsize(CountItem)))))
                            CountItem = CountItem + 1
                        End While
                        Filewrite.WriteLine(ssql)
                        pagesize = pagesize + 1
                        ssql = ""
                        CountItem = 0
                    End With
                Next rowj

                Filewrite.WriteLine(StrDup(90, "="))
                pagesize = pagesize + 1
                'Filewrite.WriteLine("The Software Is Designed And Developed By DATABASE SOFTWARE,Chennai")
                'Filewrite.WriteLine("To Know Abt DBS Pls Mail at :- info@databasesoftware.in")
                'pagesize = pagesize + 1
                'Filewrite.WriteLine(StrDup(135, "="))
                'pagesize = pagesize + 1
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vFilepath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub ReportDesigner_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim I As Integer
        If e.KeyCode = Keys.F10 Then
            Call Cmd_View_Click(Cmd_View, e)
        ElseIf e.KeyCode = Keys.F11 Then
            Call Cmd_Print_Click(Cmd_Print, e)
        ElseIf e.KeyCode = Keys.F2 Then
            For I = 1 To SsGridReport.DataRowCnt - 1
                SsGridReport.Col = 2
                SsGridReport.Row = I
                If Trim(SsGridReport.Text) <> "" Then
                    SsGridReport.SetText(1, I, 1)
                End If
            Next I
        ElseIf e.KeyCode = Keys.F3 Then
            For I = 1 To SsGridReport.DataRowCnt - 1
                SsGridReport.Col = 2
                SsGridReport.Row = I
                If Trim(SsGridReport.Text) <> "" Then
                    SsGridReport.SetText(1, I, 0)
                End If
            Next I
        ElseIf e.KeyCode = Keys.F12 Or e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub
End Class
