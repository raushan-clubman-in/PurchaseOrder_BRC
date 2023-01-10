Imports System.IO
Imports System.Data.SqlClient
Public Class Laser_print
    Inherits System.Windows.Forms.Form
    Dim VCONN As New GlobalClass
    Dim gconnection As New GlobalClass
    Dim sprow, spcol As Integer
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmd_laser As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents fpSpreadVw As AxFPSpreadADO.AxfpSpread
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Laser_print))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmd_laser = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.fpSpreadVw = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fpSpreadVw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.OrangeRed
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmd_laser)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(192, 536)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 48)
        Me.GroupBox1.TabIndex = 5584
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Location = New System.Drawing.Point(232, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 23)
        Me.Button1.TabIndex = 5585
        Me.Button1.Text = "Exit"
        '
        'cmd_laser
        '
        Me.cmd_laser.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.cmd_laser.Location = New System.Drawing.Point(64, 16)
        Me.cmd_laser.Name = "cmd_laser"
        Me.cmd_laser.Size = New System.Drawing.Size(120, 23)
        Me.cmd_laser.TabIndex = 5584
        Me.cmd_laser.Text = "Laser Print"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.OrangeRed
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.fpSpreadVw)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(760, 504)
        Me.GroupBox2.TabIndex = 5585
        Me.GroupBox2.TabStop = False
        '
        'fpSpreadVw
        '
        Me.fpSpreadVw.ContainingControl = Me
        Me.fpSpreadVw.DataSource = Nothing
        Me.fpSpreadVw.Location = New System.Drawing.Point(16, 24)
        Me.fpSpreadVw.Name = "fpSpreadVw"
        Me.fpSpreadVw.OcxState = CType(resources.GetObject("fpSpreadVw.OcxState"), System.Windows.Forms.AxHost.State)
        Me.fpSpreadVw.Size = New System.Drawing.Size(728, 464)
        Me.fpSpreadVw.TabIndex = 5582
        '
        'Laser_print
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 598)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Laser_print"
        Me.Text = "Purchase Order Print"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.fpSpreadVw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Width = 792
        Me.Height = 656
        Call Viewoperation()
    End Sub
    Private Sub Viewoperation()

        Randomize()
        Dim PAGENO, ROWCOUNT, I As Integer
        Dim SSQL, SSQL1, SQLString, OtherTermsPO As String
        Dim SLCODE As String
        Dim VSQL As String
        Dim j, intPageLength As Int16

        Dim intDescriptionLength, intStartIndex, intDescLenIndex, intDescMaxLen As Int16
        Dim strSpaceBefore, strSpaceAfter As String
        strSpaceBefore = ""
        strSpaceAfter = ""
        intDescMaxLen = 66
        intPageLength = 80



        Dim SLNAME, ADDRESS1, ADDRESS2, ADDRESS3 As String
        vOutfile = Mid("CON" & (Rnd() * 800000), 1, 8)
        'vOutfile = Me.txt_PONo.Text & "-" & Mid("CON" & (Rnd() * 800000), 1, 8)
        VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
        Filewrite = File.AppendText(VFilePath)
        printfile = VFilePath
        PAGENO = 1 : ROWCOUNT = 0
        Dim VREF As Boolean = False

        Dim STR, NARRATION As String

        Dim rate, vat, ltotal, gtotal, temp As Double
        Dim lqty, gqty As Double

        SSQL = "Select P.PONO,P.PODATE,P.POVENDORCODE,P.PODEPARTMENT,P.POAPPROVEDBY,P.POAPPROVEDDATE,P.POSTATUS,P.POVALUE,P.POADVANCE,P.POTOTALVAT,P.POTOTALTAX,P.POTOTALDISCOUNT,P.POADVANCE,P.POBALANCE,P.POTERMS,P.PODELIVERYTERMS,P.PODESPATCH,P.POSHIPPING,P.PODELIVERY,P.POCREDITDAYS,P.POENCL,P.POREMARKS,P.POCLOSURE,P.POFREIGHT,P.POCSTFORM, P.FREEZE, P.POMCPO, P.POOTHERTERMS, P.PODELIVERYTERMS , P.POWARRANTYTERMS, P.POTERMS,P.POOVERALLDISC,P.PODELIVERYAMT,P.POCF,P.POTRANSPORT"
        SSQL = SSQL & " from PO_HDR P "
        SSQL = SSQL & " where isnull(FREEZE,'')<>'Y'   AND P.PONO = '" & Trim(PoNumber) & "' "
        VCONN.getDataSet(SSQL, "PO_HDR")

        Dim vcaption1 As String
        vcaption1 = ""
        ''''''PSAM
        Call fpheader()
        sprow = 7

        If gdataset.Tables("PO_HDR").Rows.Count > 0 Then
            I = 0
            'PRINTING HEADER
            If Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POMCPO")) = "N" Then
                Call subPrintVoucherHeader("PURCHASE ORDER VOUCHER", 80)
                ROWCOUNT = 7
            End If
            With gdataset.Tables("PO_HDR").Rows(I)
                If VREF = False Then

                    STR = "SELECT ISNULL(VENDORCODE,0) AS VENDORCODE, ISNULL(VENDORNAME,'') AS VENDORNAME, ADDRESS, CITY, STATE  FROM PO_VIEW_VENDORMASTER WHERE VENDORCODE = '" & .Item("POVENDORCODE") & "' "
                    VCONN.getDataSet(STR, "ACCOUNTSSUBLEDGERMASTER")

                    SSQL = "P.O. NO. : " & PoNumber
                    SSQL = SSQL & Space(22)

                    fpSpreadVw.Col = 1
                    fpSpreadVw.Row = sprow
                    fpSpreadVw.AllowCellOverflow = True
                    fpSpreadVw.FontBold = True
                    fpSpreadVw.SetText(1, sprow, "P.O. NO.")


                    fpSpreadVw.Col = 2
                    fpSpreadVw.AllowCellOverflow = True
                    fpSpreadVw.FontBold = True
                    fpSpreadVw.SetText(2, sprow, ":  " & Trim(PoNumber))

                    SSQL = SSQL & "         DATE : " & Mid(.Item("PODATE"), 1, 20) & Space(20 - Len(Mid(Trim(.Item("PODATE")), 1, 20)))

                    fpSpreadVw.Col = 6
                    fpSpreadVw.AllowCellOverflow = True
                    fpSpreadVw.FontBold = True
                    fpSpreadVw.SetText(6, sprow, "DATE : " & Trim(.Item("PODate")))
                    sprow = sprow + 2

                    If Trim(.Item("pomcpo")) = "N" Then
                        If gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).IsNull("VENDORNAME") = False Then
                            fpSpreadVw.Col = 1
                            fpSpreadVw.Row = sprow
                            fpSpreadVw.AllowCellOverflow = True
                            fpSpreadVw.FontBold = True
                            fpSpreadVw.SetText(1, sprow, gCompanyname)

                            fpSpreadVw.Col = 3
                            fpSpreadVw.AllowCellOverflow = True
                            fpSpreadVw.FontBold = True
                            fpSpreadVw.SetText(3, sprow, "TO")
                            sprow = sprow + 1

                            SSQL1 = "SELECT ISNULL(ADD1,'') AS ADD1, ISNULL(ADD2,'') AS ADD2, ISNULL(PINCODE,'') AS PINCODE FROM MASTER..CLUBMASTER WHERE DATAFILE = '" & gDatabase & "' "
                            VCONN.getDataSet(SSQL1, "CLUBMASTER")

                            fpSpreadVw.Row = sprow
                            fpSpreadVw.Col = 1
                            fpSpreadVw.AllowCellOverflow = True
                            fpSpreadVw.FontBold = True
                            fpSpreadVw.SetText(1, sprow, gdataset.Tables("CLUBMASTER").Rows(0).Item("ADD1"))


                            fpSpreadVw.Col = 3
                            fpSpreadVw.AllowCellOverflow = True
                            fpSpreadVw.FontBold = True
                            fpSpreadVw.SetText(3, sprow, gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORNAME"))
                            sprow = sprow + 1

                            fpSpreadVw.Col = 1
                            fpSpreadVw.AllowCellOverflow = True
                            fpSpreadVw.FontBold = True
                            fpSpreadVw.SetText(1, sprow, gdataset.Tables("CLUBMASTER").Rows(0).Item("ADD2") & " - " & gdataset.Tables("CLUBMASTER").Rows(0).Item("PINCODE"))

                            fpSpreadVw.Row = sprow
                            fpSpreadVw.Col = 3
                            fpSpreadVw.AllowCellOverflow = True
                            fpSpreadVw.FontBold = True
                            fpSpreadVw.SetText(3, sprow, "Vendor Code")

                            fpSpreadVw.Col = 5
                            fpSpreadVw.AllowCellOverflow = True
                            fpSpreadVw.FontBold = True
                            fpSpreadVw.SetText(5, sprow, gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"))
                           
                           

                        Else
                            SSQL = Space(48)
                            SSQL = SSQL & "DATE        : " & Mid(Trim(Format(DateValue(.Item("podate")), "dd/MM/yyyy")), 1, 20) & Space(20 - Len(Mid(Trim(.Item("podate")), 1, 20)))
                            fpSpreadVw.SetText(5, sprow, Trim(.Item("podate")))
                        End If
                        ROWCOUNT = ROWCOUNT + 2
                    Else

                        SSQL = Chr(27) & "E"
                        sprow = sprow + 1
                        fpSpreadVw.Col = 1
                        fpSpreadVw.Row = sprow
                        fpSpreadVw.AllowCellOverflow = True
                        fpSpreadVw.FontBold = True
                        fpSpreadVw.SetText(1, sprow, "To")

                        SSQL = SSQL & Mid(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"), 1, 6) & " : " & Space(6 - Len(Mid(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORCODE"), 1, 6))) & Space(2)
                        SSQL = SSQL & (gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("VENDORNAME"))
                        SSQL = SSQL & Chr(27) & "F"

                        sprow = sprow + 1
                        fpSpreadVw.Col = 1
                        fpSpreadVw.Row = sprow
                        fpSpreadVw.AllowCellOverflow = True
                        fpSpreadVw.FontBold = True
                        fpSpreadVw.SetText(1, sprow, "   " & gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("ADDRESS"))

                        sprow = sprow + 1
                        fpSpreadVw.Col = 1
                        fpSpreadVw.Row = sprow
                        fpSpreadVw.AllowCellOverflow = True
                        fpSpreadVw.FontBold = True
                        fpSpreadVw.SetText(1, sprow, "   " & gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("CITY"))

                        sprow = sprow + 1
                        fpSpreadVw.Col = 1
                        fpSpreadVw.Row = sprow
                        fpSpreadVw.AllowCellOverflow = True
                        fpSpreadVw.FontBold = True
                        fpSpreadVw.SetText(1, sprow, "   " & gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("STATE"))

                        sprow = sprow + 1
                        ROWCOUNT = ROWCOUNT + 6
                    End If

                    If .Item("POMCPO") <> "N" Then
                        fpSpreadVw.Row = sprow
                        fpSpreadVw.SetText(2, sprow, StrDup(30, " ") & "KIND ATTN: ")
                        Filewrite.WriteLine("Dear Sirs,")
                        sprow = sprow + 1
                        fpSpreadVw.Row = sprow
                        fpSpreadVw.Row = sprow
                        fpSpreadVw.SetText(1, sprow, "Dear Sirs,")
                        sprow = sprow + 2
                        ROWCOUNT = ROWCOUNT + 3

                        Dim bill As DataTable
                        Dim Loopindex As Integer
                        SQLString = "Select * from PO_OTHERTERMS where Trantype='" & Trim(PoNumber) & "' and DOCTYPE='SUBJECT' order by slno"
                        bill = gconnection.GetValues(SQLString)
                        If bill.Rows.Count > 0 Then
                            fpSpreadVw.Row = sprow
                            fpSpreadVw.SetText(1, sprow, "SUB:")
                            Loopindex = 0
                            For I = 0 To bill.Rows.Count - 1
                                Loopindex = Loopindex + 1
                                fpSpreadVw.Row = sprow
                                fpSpreadVw.SetText(2, sprow, bill.Rows(I).Item("MESSAGE"))
                                sprow = sprow + 1
                                ROWCOUNT = ROWCOUNT + 1
                            Next
                            sprow = sprow + 1
                            ROWCOUNT = ROWCOUNT + 1
                        End If
                        bill.Clear()
                        SQLString = "Select * from PO_OTHERTERMS where Trantype='" & Trim(PoNumber) & "' and DOCTYPE='REFERENCE' order by slno"
                        bill = gconnection.GetValues(SQLString)
                        If bill.Rows.Count > 0 Then
                            fpSpreadVw.Row = sprow
                            fpSpreadVw.SetText(1, sprow, "REF:")
                            Loopindex = 0
                            For I = 0 To bill.Rows.Count - 1
                                Loopindex = Loopindex + 1

                                fpSpreadVw.Row = sprow
                                fpSpreadVw.SetText(2, sprow, bill.Rows(I).Item("MESSAGE"))
                                sprow = sprow + 1

                                ROWCOUNT = ROWCOUNT + 1

                            Next
                            ROWCOUNT = ROWCOUNT + 1
                        End If
                        bill.Clear()
                        SQLString = "Select * from PO_OTHERTERMS where Trantype='" & Trim(PoNumber) & "' and DOCTYPE='BODY' order by slno"
                        bill = gconnection.GetValues(SQLString)
                        sprow = sprow + 1
                        If bill.Rows.Count > 0 Then
                            Loopindex = 0
                            For I = 0 To bill.Rows.Count - 1
                                Loopindex = Loopindex + 1
                                fpSpreadVw.Row = sprow
                                fpSpreadVw.SetText(2, sprow, bill.Rows(I).Item("MESSAGE"))
                                ROWCOUNT = ROWCOUNT + 1
                                sprow = sprow + 1
                            Next
                            ROWCOUNT = ROWCOUNT + 1
                        End If
                        bill.Clear()
                    End If

                    If .Item("POMCPO") = "N" Then
                        sprow = sprow + 3
                        fpSpreadVw.SetText(2, sprow, "SUB : PURCHASE ORDER FOR FOLLOWING MATERIAL - REG. - ")
                        sprow = sprow + 1
                        fpSpreadVw.SetText(2, sprow, "          FOR THE DEPARTMENT OF " & "'" & Trim(.Item("PODEPARTMENT")) & "' ")
                        'fpSpreadVw.SetText(3, 11, "'" & Trim(.Item("PODEPARTMENT")) & "' ")
                        ROWCOUNT = ROWCOUNT + 2
                        sprow = sprow + 2
                        fpSpreadVw.SetText(1, sprow, "PLEASE SUPPLY THE FOLLOWING MATERIAL AT THE EARLIEST: ")
                        ROWCOUNT = ROWCOUNT + 3
                    End If

                    sprow = sprow + 2
                    fpSpreadVw.Col = 1
                    fpSpreadVw.Row = sprow
                    fpSpreadVw.ForeColor = Color.Red
                    fpSpreadVw.SetText(1, sprow, StrDup(250, "-"))

                    sprow = sprow + 1
                    fpSpreadVw.Col = 1
                    fpSpreadVw.Row = sprow
                    fpSpreadVw.FontBold = True
                    fpSpreadVw.SetText(1, sprow, "NO.")
                    fpSpreadVw.Col = 2
                    fpSpreadVw.FontBold = True
                    fpSpreadVw.SetText(2, sprow, "ITEM DESCRIPTION")
                    fpSpreadVw.Col = 3
                    fpSpreadVw.FontBold = True
                    fpSpreadVw.SetText(3, sprow, "RATE")
                    fpSpreadVw.Col = 4
                    fpSpreadVw.FontBold = True
                    fpSpreadVw.SetText(4, sprow, "QTY")
                    fpSpreadVw.Col = 5
                    fpSpreadVw.FontBold = True
                    fpSpreadVw.SetText(5, sprow, "VAT")
                    fpSpreadVw.Col = 6
                    fpSpreadVw.FontBold = True
                    fpSpreadVw.SetText(6, sprow, "QTY*RATE+VAT-DISC")
                    fpSpreadVw.SetText(6, sprow, "GROSS")

                    sprow = sprow + 1
                    fpSpreadVw.Col = 1
                    fpSpreadVw.Row = sprow
                    fpSpreadVw.ForeColor = Color.Red
                    fpSpreadVw.SetText(1, sprow, StrDup(250, "-"))
                    ROWCOUNT = ROWCOUNT + 3
                    VREF = True
                End If

                'SSQL = "SELECT AUTOID,SUM(discount) as discount,ISNULL(PONO,'') AS PONO,ISNULL(ITEMCODE,'') AS ITEMCODE, ISNULL(QUANTITY,0) AS QUANTITY,ISNULL(REQUIREDDATE,'') AS REQUIREDDATE,ISNULL(RATE,0) AS RATE,ISNULL(VAT,0) AS VAT, ISNULL(TOTAL,0) AS TOTAL FROM PO_ITEMDETAILS WHERE PONO = '" & PoNumber & "' GROUP BY AUTOID,PONO,ITEMCODE,QUANTITY,REQUIREDDATE,RATE,VAT,TOTAL ORDER BY AUTOID "
                SSQL = "SELECT AUTOID,SUM(discount) as discount,ISNULL(PONO,'') AS PONO,ISNULL(ITEMCODE,'') AS ITEMCODE, "
                SSQL = SSQL & " ISNULL(QUANTITY,0) AS QUANTITY,ISNULL(REQUIREDDATE,'') AS REQUIREDDATE,ISNULL(RATE,0) AS RATE,"
                SSQL = SSQL & " ISNULL(VAT,0) AS VAT, ISNULL(TOTAL,0) AS TOTAL , ISNULL(AMOUNT,0) AMOUNT , ISNULL(DISCAMT,0) DISCAMT , ISNULL(VATAMT,0) VATAMT "
                SSQL = SSQL & " FROM PO_ITEMDETAILS WHERE PONO = '" & PoNumber & "'"
                SSQL = SSQL & " GROUP BY AUTOID,PONO,ITEMCODE,QUANTITY,REQUIREDDATE,RATE,VAT,TOTAL,AMOUNT,DISCAMT,VATAMT ORDER BY AUTOID "
                VCONN.getDataSet(SSQL, "PO_ITEMDETAILS")

                If gdataset.Tables("PO_ITEMDETAILS").Rows.Count > 0 Then
                    For j = 0 To gdataset.Tables("PO_ITEMDETAILS").Rows.Count - 1
                        ltotal = lqty = 0
                        ROWCOUNT = ROWCOUNT + 1
                        If ROWCOUNT > 58 Then
                            PAGENO = PAGENO + 1
                            Call subPrintVoucherHeader("PURCHASE ORDER", 80)
                            ROWCOUNT = 6
                        End If
                        'adding rate + tax
                        rate = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE")
                        vat = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("VAT")
                        temp = rate * vat / 100
                        'ltotal = rate + temp
                        ltotal = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("TOTAL")
                        ltotal = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("AMOUNT")
                        lqty = gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("QUANTITY")
                        'Dim vattotal As Double
                        'vattotal = rate * lqty
                        'vattotal = (vattotal * vat) / 100
                        rate = 0 : vat = 0 : temp = 0
                        If gdataset.Tables("PO_ITEMDETAILS").Rows(j).IsNull("ITEMCODE") = False Then
                            'ITEMCODE
                            SSQL = Space(2 - Len(Mid(Format(j + 1, ""), 1, 2))) & Mid(Format(j + 1, ""), 1, 2) & " "
                            sprow = sprow + 1
                            fpSpreadVw.SetText(1, sprow, j + 1)
                            'ITEM NAME RETRIEVAL
                            SSQL1 = "SELECT * FROM PO_VIEW_ITEMMASTER WHERE ITEMCODE = '" & gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("ITEMCODE") & "' "
                            VCONN.getDataSet(SSQL1, "INVENTORYITEMMASTER")
                            'ITEM NAME
                            SSQL = SSQL & Space(6)
                            SSQL = SSQL & Mid(gdataset.Tables("INVENTORYITEMMASTER").Rows(0).Item("ITEMNAME"), 1, 35) & Space(35 - Len(Mid(gdataset.Tables("INVENTORYITEMMASTER").Rows(0).Item("ITEMNAME"), 1, 35)))
                            fpSpreadVw.SetText(2, sprow, Mid(gdataset.Tables("INVENTORYITEMMASTER").Rows(0).Item("ITEMNAME"), 1, 35) & Space(35 - Len(Mid(gdataset.Tables("INVENTORYITEMMASTER").Rows(0).Item("ITEMNAME"), 1, 35))))
                            'RATE
                            SSQL = SSQL & Space(1)
                            SSQL = SSQL & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE"), 1, 8) & Space(8 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE"), 1, 8)))
                            fpSpreadVw.SetText(3, sprow, Space(8 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE"), 1, 8))) & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE"), 1, 8) & Space(8 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("RATE"), 1, 8))))
                            'QUANTITY
                            'SSQL = SSQL & Space(2)
                            SSQL = SSQL & Space(6 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("QUANTITY"), 1, 6))) & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("QUANTITY"), 1, 6)
                            fpSpreadVw.SetText(4, sprow, Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("QUANTITY"), 1, 6))
                            'VAT
                            SSQL = SSQL & Space(2)
                            SSQL = SSQL & Space(6 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("VAT"), 1, 6))) & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("VAT"), 1, 6)
                            fpSpreadVw.SetText(5, sprow, Space(6 - Len(Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("QUANTITY"), 1, 6))) & Mid(gdataset.Tables("PO_ITEMDETAILS").Rows(j).Item("VAT"), 1, 6))
                            'RATE
                            SSQL = SSQL & Space(2)
                            SSQL = SSQL & Space(10 - Len(Mid(Format(ltotal, "0.00"), 1, 10))) & Mid(Format(ltotal, "0.00"), 1, 10) & " "
                            fpSpreadVw.SetText(6, sprow, Space(10 - Len(Mid(Format(ltotal, "0.00"), 1, 10))) & Mid(Format(ltotal, "0.00"), 1, 10))
                            gtotal = gtotal + ltotal
                            'vattotal = Nothing
                            gqty = gqty + lqty
                        Else
                            SSQL = Space(53)
                        End If
                    Next j
                End If
                'FOR MINIMUM 10 BLANK LINES IN THE ITEM DETAILS SECTION    
                'If gdataset.Tables("PO_ITEMDETAILS").Rows.Count < 10 Then
                '    j = 0
                '    j = gdataset.Tables("PO_ITEMDETAILS").Rows.Count
                '    j = 10 - j
                '    sprow = sprow + j
                '    Dim K
                '    For K = 0 To j
                '        Filewrite.WriteLine()
                '    Next
                'End If

                'Dim povalue As Double
                'povalue = Val(gdataset.Tables("PO_HDR").Rows(0).Item("POVALUE")) - Val(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"))

                'sprow = sprow + 1
                'fpSpreadVw.SetText(4, sprow, "DELIVERY")
                'fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"), "0.00"), 1, 10) & " ")

                'sprow = sprow + 1
                'fpSpreadVw.SetText(4, sprow, "C & F")
                'fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"), "0.00"), 1, 10) & " ")

                'sprow = sprow + 1
                'fpSpreadVw.SetText(4, sprow, "TRANSPORT")
                'fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"), "0.00"), 1, 10) & " ")

                'sprow = sprow + 1
                'fpSpreadVw.SetText(4, sprow, "TOTAL VAT")
                'fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"), "0.00"), 1, 10) & " ")

                'sprow = sprow + 1
                'fpSpreadVw.SetText(4, sprow, "TOTAL DISCOUNT")
                'fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALDISCOUNT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALDISCOUNT"), "0.00"), 1, 10) & " ")

                'If Val(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE")) <> 0 Then
                '    sprow = sprow + 1
                '    fpSpreadVw.SetText(4, sprow, "ADVANCE")
                '    fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00"), 1, 10) & " ")

                '    sprow = sprow + 1
                '    fpSpreadVw.SetText(4, sprow, "BALANCE AMT")
                '    fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POBALANCE"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POBALANCE"), "0.00"), 1, 10) & " ")
                'End If

                'sprow = sprow + 1
                'fpSpreadVw.SetText(4, sprow, "TOTAL VALUE")
                'fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(Val(gdataset.Tables("PO_HDR").Rows(0).Item("POVALUE")), "0.00"), 1, 10))) & Mid(Format(Val(gdataset.Tables("PO_HDR").Rows(0).Item("POVALUE")), "0.00"), 1, 10) & " ")
                ROWCOUNT = ROWCOUNT + 3

                If gdataset.Tables("PO_HDR").Rows(0).IsNull("poremarks") = False Then
                    NARRATION = gdataset.Tables("PO_HDR").Rows(0).Item("poremarks")
                Else
                    NARRATION = ""
                End If
            End With

            sprow = sprow + 1
            If Len(NARRATION) > 0 Then
                intDescriptionLength = Split(Len(NARRATION) / intDescMaxLen, ".")(0)
                intDescriptionLength = intDescriptionLength + 1
                intStartIndex = 1
                intDescLenIndex = intDescMaxLen
                For j = 1 To intDescriptionLength
                    If j = 1 Then
                        strSpaceBefore = ""
                        sprow = sprow + 1
                        fpSpreadVw.SetText(1, sprow, "Narration : ")
                    Else
                        strSpaceBefore = Space(12)
                    End If
                    If j = intDescriptionLength Then
                        sprow = sprow + 1
                        fpSpreadVw.SetText(1, sprow, strSpaceBefore & Trim(Mid(Trim(NARRATION), intStartIndex, intDescMaxLen)) & Space((intDescMaxLen + 1) - Len(Trim(Mid(Trim(NARRATION), intStartIndex, intDescMaxLen)))) & strSpaceAfter)
                    Else
                        If Mid(NARRATION, intDescLenIndex, 1) = " " Then
                            sprow = sprow + 1
                            fpSpreadVw.SetText(1, sprow, strSpaceBefore & Trim(Mid(NARRATION, intStartIndex, intDescMaxLen)) & "- " & strSpaceAfter)
                        Else
                            sprow = sprow + 1
                            fpSpreadVw.Col = 1
                            fpSpreadVw.Row = sprow
                            fpSpreadVw.ForeColor = Color.Red
                            fpSpreadVw.SetText(1, sprow, strSpaceBefore & Trim(Mid(Trim(NARRATION), intStartIndex, intDescMaxLen)) & "-" & strSpaceAfter)
                        End If
                    End If
                    ROWCOUNT = ROWCOUNT + 1
                    intStartIndex = intStartIndex + intDescMaxLen
                    intDescLenIndex = intDescLenIndex + intDescMaxLen
                Next
            End If
        Else
            MsgBox("NO RECORD TO VIEW ", MsgBoxStyle.Information)
            Exit Sub
        End If

        fpSpreadVw.Col = 1
        fpSpreadVw.Row = sprow
        fpSpreadVw.ForeColor = Color.Red
        fpSpreadVw.SetText(1, sprow, StrDup(250, "-"))

        sprow = sprow + 1
        fpSpreadVw.Col = 1
        fpSpreadVw.Row = sprow
        fpSpreadVw.FontBold = True
        fpSpreadVw.SetText(1, sprow, "TOTAL")
        fpSpreadVw.Col = 2
        fpSpreadVw.FontBold = True
        fpSpreadVw.SetText(2, sprow, ":")

        fpSpreadVw.Col = 4
        fpSpreadVw.FontBold = True
        fpSpreadVw.SetText(4, sprow, Space(10 - Len(Mid(Format(gqty, "0.00"), 1, 10))) & Mid(Format(gqty, "0.00"), 1, 10))

        fpSpreadVw.Col = 6
        fpSpreadVw.FontBold = True
        fpSpreadVw.SetText(6, sprow, Space(10 - Len(Mid(Format(gtotal, "0.00"), 1, 10))) & Mid(Format(gtotal, "0.00"), 1, 10))

        sprow = sprow + 1
        fpSpreadVw.Col = 1
        fpSpreadVw.Row = sprow
        fpSpreadVw.ForeColor = Color.Red
        fpSpreadVw.SetText(1, sprow, StrDup(250, "-"))

        SSQL = " SELECT * FROM PO_PAYMENTTERMS WHERE PAYMENTTERMCODE = '" & gdataset.Tables("PO_HDR").Rows(0).Item("POTERMS") & "' "
        VCONN.getDataSet(SSQL, "PO_PAYMENTTERMS")
        SSQL = " SELECT * FROM PO_DELIVERYTERMS WHERE DELIVERYTERMCODE = '" & gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYTERMS") & "' "
        VCONN.getDataSet(SSQL, "PO_DELIVERYTERMS")
        SSQL = " SELECT * FROM PO_WARRANTYTERMS WHERE WARRANTYTERMCODE = '" & gdataset.Tables("PO_HDR").Rows(0).Item("POWARRANTYTERMS") & "' "
        VCONN.getDataSet(SSQL, "PO_WARRANTYTERMS")
        If Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POMCPO")) <> "N" Then
            sprow = sprow + 1
            fpSpreadVw.SetText(1, sprow, "TERMS & CONDITIONS: ")

            sprow = sprow + 1
            fpSpreadVw.SetText(1, sprow, "TERMS OF PAYMENT")
            fpSpreadVw.SetText(2, sprow, ":  " & gdataset.Tables("PO_PAYMENTTERMS").Rows(0).Item("PAYMENTTERMDESC"))

            sprow = sprow + 1
            fpSpreadVw.SetText(1, sprow, "TERMS OF DELIVERY")
            fpSpreadVw.SetText(2, sprow, ":  " & gdataset.Tables("PO_DELIVERYTERMS").Rows(0).Item("DELIVERYTERMDESC"))

            If gdataset.Tables("PO_WARRANTYTERMS").Rows.Count > 0 Then
                sprow = sprow + 1
                fpSpreadVw.SetText(1, sprow, "TERMS OF WARRANTY")
                fpSpreadVw.SetText(2, sprow, ":  " & gdataset.Tables("PO_WARRANTYTERMS").Rows(0).Item("WARRANTYTERMDESC"))
            End If
            ROWCOUNT = ROWCOUNT + 5
            If Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POOTHERTERMS")) <> "" Then
                Dim bill As DataTable
                Dim loop1, temp1 As Integer
                Dim Othertermcode(10), TextValue As String
                loop1 = 0
                TextValue = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POOTHERTERMS"))
                OtherTermsPO = Trim(gdataset.Tables("PO_HDR").Rows(0).Item("POOTHERTERMS"))
                For I = 0 To Len(gdataset.Tables("PO_HDR").Rows(0).Item("POOTHERTERMS")) - 1

                    If OtherTermsPO.Chars(I) = "," Then
                        If loop1 = 0 Then
                            Othertermcode(loop1) = TextValue.Substring(0, I)
                            loop1 = loop1 + 1
                            temp1 = I
                        Else
                            Othertermcode(loop1) = TextValue.Substring(temp1 + 2, I)
                            loop1 = loop1 + 1
                            temp1 = I
                        End If
                    End If
                Next

                sprow = sprow + 1
                fpSpreadVw.SetText(1, sprow, "OTHER TERMS")
                For I = 0 To loop1
                    SQLString = "Select * from PO_OTHERTERMS where Trantype='" & Trim(Othertermcode(I)) & "' and DOCTYPE='OTHERTERMS' order by slno"
                    bill = gconnection.GetValues(SQLString)
                    If bill.Rows.Count > 0 Then
                        For j = 0 To bill.Rows.Count - 1
                            Filewrite.WriteLine(Space(3) & bill.Rows(j).Item("MESSAGE"))
                            sprow = sprow + 1
                            fpSpreadVw.SetText(1, sprow, ":  " & Space(3) & bill.Rows(j).Item("MESSAGE"))
                            ROWCOUNT = ROWCOUNT + 1
                        Next j
                    End If
                    bill.Clear()
                Next I
                Filewrite.WriteLine()
                ROWCOUNT = ROWCOUNT + 1
            End If
        Else
            If gdataset.Tables("PO_PAYMENTTERMS").Rows(0).IsNull("PAYMENTTERMCODE") = False Then
                 sprow = sprow + 1
                fpSpreadVw.SetText(1, sprow, " PAYMENT TERMS")
                fpSpreadVw.SetText(2, sprow, ":  " & gdataset.Tables("PO_PAYMENTTERMS").Rows(0).Item("PAYMENTTERMDESC"))
            Else
                sprow = sprow + 1
            End If
            If gdataset.Tables("PO_DELIVERYTERMS").Rows(0).IsNull("DELIVERYTERMCODE") = False Then
                sprow = sprow + 1
                fpSpreadVw.SetText(1, sprow, " DELIVERY TERMS")
                fpSpreadVw.SetText(2, sprow, ":  " & gdataset.Tables("PO_DELIVERYTERMS").Rows(0).Item("DELIVERYTERMDESC"))
            Else
                sprow = sprow + 1
            End If
        End If

        Dim povalue As Double
        povalue = Val(gdataset.Tables("PO_HDR").Rows(0).Item("POVALUE")) - Val(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"))

        sprow = sprow + 1
        fpSpreadVw.SetText(4, sprow, "DELIVERY")
        fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("PODELIVERYAMT"), "0.00"), 1, 10) & " ")

        sprow = sprow + 1
        fpSpreadVw.SetText(4, sprow, "C & F")
        fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POCF"), "0.00"), 1, 10) & " ")

        sprow = sprow + 1
        fpSpreadVw.SetText(4, sprow, "TRANSPORT")
        fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTRANSPORT"), "0.00"), 1, 10) & " ")

        sprow = sprow + 1
        fpSpreadVw.SetText(4, sprow, "TOTAL VAT")
        fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALVAT"), "0.00"), 1, 10) & " ")

        sprow = sprow + 1
        fpSpreadVw.SetText(4, sprow, "TOTAL DISCOUNT")
        fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALDISCOUNT"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POTOTALDISCOUNT"), "0.00"), 1, 10) & " ")

        If Val(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE")) <> 0 Then
            sprow = sprow + 1
            fpSpreadVw.SetText(4, sprow, "ADVANCE")
            fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POADVANCE"), "0.00"), 1, 10) & " ")

            sprow = sprow + 1
            fpSpreadVw.SetText(4, sprow, "BALANCE AMT")
            fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POBALANCE"), "0.00"), 1, 10))) & Mid(Format(gdataset.Tables("PO_HDR").Rows(0).Item("POBALANCE"), "0.00"), 1, 10) & " ")
        End If

        sprow = sprow + 1
        fpSpreadVw.Row = sprow
        fpSpreadVw.Col = 4
        fpSpreadVw.FontBold = True
        fpSpreadVw.SetText(4, sprow, "TOTAL VALUE")
        fpSpreadVw.Col = 6
        fpSpreadVw.FontBold = True
        fpSpreadVw.SetText(6, sprow, ":  " & Space(10 - Len(Mid(Format(Val(gdataset.Tables("PO_HDR").Rows(0).Item("POVALUE")), "0.00"), 1, 10))) & Mid(Format(Val(gdataset.Tables("PO_HDR").Rows(0).Item("POVALUE")), "0.00"), 1, 10) & " ")
        sprow = sprow + 2

        If gdataset.Tables("PO_HDR").Rows(0).Item("POMCPO") = "N" Then
            fpSpreadVw.SetText(6, sprow, "For " & gCompanyname)
            sprow = sprow + 1
            sprow = sprow + 1
            fpSpreadVw.SetText(1, sprow, " Prepared By")
            fpSpreadVw.SetText(4, sprow, " Checked By")
            fpSpreadVw.SetText(6, sprow, "  Authorised Signature")
            Filewrite.WriteLine("Prepared By " & Space(15) & "     Checked By " & Space(15) & " Authorised Signature ")

            VCONN.subPrintVoucherFooter(80, PAGENO)
        Else
            sprow = sprow + 1
            fpSpreadVw.SetText(1, sprow, "Thanking you,")
            sprow = sprow + 2
            fpSpreadVw.SetText(1, sprow, "Yours sincerly,")
        End If

        Dim row, col As Integer
        For row = 1 To sprow
            fpSpreadVw.Row = row
            For col = 1 To 6
                fpSpreadVw.Col = col
                fpSpreadVw.Lock = True
            Next
        Next row
        fpSpreadVw.MaxRows = sprow
Header:
        sprow = 1
        fpSpreadVw.SetText(2, sprow, "              " & gCompanyname)
        sprow = sprow + 1
        fpSpreadVw.SetText(2, sprow, "                    " & ADDRESS1 & "," & ADDRESS2 & "," & gCity & "-" & gPincode)
        sprow = sprow + 1
        fpSpreadVw.SetText(2, sprow, "                                        PHONE : " & GPHONE)
        sprow = sprow + 1
        fpSpreadVw.SetText(2, sprow, "") 'EMAIL 
        Return

        'If gPrint = False Then
        '    OpenTextFile(vOutfile)
        'Else
        '    PrintTextFile1(VFilePath)
        'End If
    End Sub

    Public Sub subPrintVoucherHeader(ByVal strCaption As String, ByVal intLength As Int16)
        Dim SSQL1 As String
        Filewrite.WriteLine()
        Filewrite.Write(Space(30))
        Filewrite.WriteLine(Chr(27) & "E" & Trim(Mid(gCompanyname, 1, 80)) & Chr(27) & "F")
        SSQL1 = ""
        SSQL1 = "SELECT ISNULL(ADD1,'') AS ADD1, ISNULL(ADD2,'') AS ADD2, ISNULL(PINCODE,'') AS PINCODE FROM MASTER..CLUBMASTER WHERE DATAFILE = '" & gDatabase & "' "
        VCONN.getDataSet(SSQL1, "CLUBMASTER")
        SSQL1 = ""
        Filewrite.Write(Space(30))
        Filewrite.WriteLine(Chr(27) & "E" & Trim(Mid(gdataset.Tables("CLUBMASTER").Rows(0).Item("ADD1"), 1, 80)) & Chr(27) & "F")
        Filewrite.Write(Space(30))
        Filewrite.Write(Chr(27) & "E" & Trim(Mid(gdataset.Tables("CLUBMASTER").Rows(0).Item("ADD2"), 1, 80)))
        Filewrite.Write("   ")
        Filewrite.WriteLine(Trim(Mid(gdataset.Tables("CLUBMASTER").Rows(0).Item("PINCODE"), 1, 80)) & Chr(27) & "F")
        Filewrite.WriteLine()
        Filewrite.Write(Space(30))
        Filewrite.WriteLine(Chr(27) & "E" & Trim(Mid("PURCHASE ORDER", 1, 80)) & Chr(27) & "F")
        Filewrite.Write(Space(28))
        Filewrite.WriteLine(StrDup(18, "-"))
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
    Private Sub fpheader()
        fpSpreadVw.Col = 1
        sprow = 1
        fpSpreadVw.SetText(2, sprow, "        " & gCompanyname)
        sprow = sprow + 1
        fpSpreadVw.Col = 1
        fpSpreadVw.SetText(2, sprow, "    " & Address1 & "," & Address2 & "," & gCity & "-" & gPincode)
        sprow = sprow + 1
        fpSpreadVw.Col = 1
        fpSpreadVw.SetText(2, sprow, "PHONE : " & GPHONE)
        sprow = sprow + 1
        fpSpreadVw.Col = 1
        fpSpreadVw.SetText(2, sprow, "                   WEB SITE : www.rsibanglore.in")
    End Sub

    Private Sub cmd_laser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_laser.Click
        fpSpreadVw.Row = 1
        fpSpreadVw.RowHidden = False
        fpSpreadVw.Col = 1
        fpSpreadVw.Col2 = fpSpreadVw.MaxCols
        fpSpreadVw.Row = 1
        fpSpreadVw.Row2 = fpSpreadVw.DataRowCnt
        fpSpreadVw.BlockMode = True
        'ssgrid.Font = "Verdana"
        'ssgrid.FontSize = 10
        'ssgrid.FontBold = False
        fpSpreadVw.BlockMode = False
        fpSpreadVw.PrintAbortMsg = "Printing - Click Cancel to quit"
        fpSpreadVw.PrintJobName = "Purchase Order"

        'sstr = "/fz""15""/c" & gCompanyname & "/fz""10""/n/c " & vAddress & "/n/c" & "Room Bill " & Year(gFinancialyearStart)
        'sstr = "/fz""15""/c" & gCompanyname & "/fz""10""/n/c " & vAddress & "/n/c" & "Room Bill " & Year(Date)
        'sstr = "/n/n/n/n/n"
        ' sstr = "/fz""12""/lCheckout" & "/fz""10""/n/l " & gUserName & " DATE" & Format(Now, "DD/MM/YYYY") & "/n/l" & "Room Key and Safe deposit key returned" & "/n/n/n/n/n/l" & "Guest Singature" & "/r" & "Cashier"
        'fpSpreadVw.PrintFooter = sstr
        'Ssgrid.PrintGrid = False
        fpSpreadVw.PrintColHeaders = True
        fpSpreadVw.PrintBorder = True
        fpSpreadVw.PrintColor = True
        fpSpreadVw.PrintGrid = False
        ' Ssgrid.PrintSheet (1)
        fpSpreadVw.PrintMarginTop = 2000
        fpSpreadVw.PrintMarginBottom = 700
        fpSpreadVw.PrintMarginLeft = 250
        fpSpreadVw.PrintMarginRight = 0
        fpSpreadVw.PrintType = 0
        fpSpreadVw.PrintOrientation = FPSpreadADO.PrintOrientationConstants.PrintOrientationPortrait.PrintOrientationPortrait
        fpSpreadVw.PrintRowHeaders = True
        fpSpreadVw.PrintShadows = False
        fpSpreadVw.PrintUseDataMax = True
        fpSpreadVw.Action = 32
    End Sub

End Class
