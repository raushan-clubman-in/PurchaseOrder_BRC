Imports System.data.sqlclient
Imports System.io
Public Class Datewisesaleregisterdetails
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function ReportsDetails(ByVal SQLSTRING As String, ByVal PAGEHEADER() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim I, J As Integer
        Dim POSDESC, PAYMENTMODE As String
        Dim pono, itemname, poapprovedby, podepartment As String
        Dim podate, poapproveddate As Date
        Dim totalqty, poadvance, pobalance, povendorcode, totalval, C As Integer
        Dim totalvat, totaltax, totalpovalue As Double
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("POREG" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            Dim sqlstr
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEADER, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "PO_DATEWISERPT")
            If gdataset.Tables("PO_DATEWISERPT").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("PO_DATEWISERPT").Rows
                    If pagesize > 56 Then
                        Filewrite.Write(StrDup(280, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEADER, FROMDATE, TODATE)
                    End If
                    C = C + 1
                    If podepartment <> CStr(dr("department")) Then
                        Filewrite.WriteLine()
                        Filewrite.WriteLine(Mid(CStr(dr("DEPARTMENT")), 1, 15))
                        Filewrite.WriteLine()
                        pagesize = pagesize + 3
                    End If
                    If pono <> CStr(dr("pono")) Then
                        Filewrite.WriteLine()
                        sqlstr = Space(4 - Len(Trim(Mid(Format(C, "0"), 1, 4)))) & Trim(Mid(Format(C, "0"), 1, 4))
                        sqlstr = sqlstr & Space(1) & Space(10 - Len(Mid(Format(dr("PONO")), 1, 10))) & Mid(Format(dr("PONO")), 1, 10)
                        sqlstr = sqlstr & Space(1) & Space(12 - Len(Mid(Format(dr("PODATE"), "dd-MM-yyyy"), 1, 12))) & Mid(Format(dr("PODATE"), "dd-MM-yyyy"), 1, 12)
                        sqlstr = sqlstr & Space(1) & Space(10 - Len(Mid(Format(dr("POQUOTNO")), 1, 10))) & Mid(Format(dr("POQUOTNO")), 1, 10)
                        sqlstr = sqlstr & Space(1) & Space(15 - Len(Mid(Format(dr("APPROVEDBY")), 1, 15))) & Mid(Format(dr("APPROVEDBY")), 1, 15)
                        sqlstr = sqlstr & Space(1) & Space(12 - Len(Mid(Format(dr("APPROVEDDATE"), "dd-MM-yyyy"), 1, 12))) & Mid(Format(dr("APPROVEDDATE"), "dd-MM-yyyy"), 1, 12)
                        sqlstr = sqlstr & Space(1) & Space(5 - Len(Mid(Format(dr("postatus")), 1, 5))) & Mid(Format(dr("POSTATUS")), 1, 5)
                        sqlstr = sqlstr & Space(1) & Space(5 - Len(Mid(Format(dr("VENDORCODE")), 1, 5))) & Mid(Format(dr("VENDORCODE")), 1, 5)
                        sqlstr = sqlstr & Space(1) & Space(20 - Len(Mid(Format(dr("VENDORNAME")), 1, 20))) & Mid(Format(dr("VENDORNAME")), 1, 20)
                        sqlstr = sqlstr & Space(1) & Space(5 - Len(Mid(Format(dr("DEPARTMENT")), 1, 5))) & Mid(Format(dr("DEPARTMENT")), 1, 5)
                        totalvat = Val(totalvat) + Val(dr("totalvat"))
                        totaltax = Val(totaltax) + Val(dr("totaltax"))
                        totalpovalue = Val(totalpovalue) + Val(dr("povalue"))
                    Else
                        sqlstr = Space(107)
                    End If
                    sqlstr = sqlstr & Space(1) & Space(6 - Len(Mid(Format(dr("ITEMCODE")), 1, 6))) & Mid(Format(dr("ITEMCODE")), 1, 6)
                    sqlstr = sqlstr & Space(1) & Space(20 - Len(Mid(Format(dr("ITEMNAME")), 1, 20))) & Mid(Format(dr("ITEMNAME")), 1, 20)
                    sqlstr = sqlstr & Space(1) & Space(3 - Len(Mid(Format(dr("UOM")), 1, 3))) & Mid(Format(dr("UOM")), 1, 3)
                    sqlstr = sqlstr & Space(1) & Space(10 - Len(Mid(Format(dr("QUANTITY"), "0.00"), 1, 10))) & Mid(Format(dr("QUANTITY"), "0.00"), 1, 10)
                    sqlstr = sqlstr & Space(1) & Space(12 - Len(Mid(Format(dr("REQUIREDDATE"), "dd-MM-yyyy"), 1, 12))) & Mid(Format(dr("REQUIREDDATE"), "dd-MM-yyyy"), 1, 12)
                    sqlstr = sqlstr & Space(1) & Space(10 - Len(Mid(Format(dr("RATE"), "0.00"), 1, 10))) & Mid(Format(dr("RATE"), "0.00"), 1, 10)
                    sqlstr = sqlstr & Space(1) & Space(6 - Len(Mid(Format(dr("DISCOUNT"), "0.00"), 1, 6))) & Mid(Format(dr("DISCOUNT"), "0.00"), 1, 6)
                    sqlstr = sqlstr & Space(1) & Space(6 - Len(Mid(Format(dr("VAT"), "0.00"), 1, 6))) & Mid(Format(dr("VAT"), "0.00"), 1, 6)
                    sqlstr = sqlstr & Space(1) & Space(10 - Len(Mid(Format(dr("TOTAL"), "0.00"), 1, 10))) & Mid(Format(dr("TOTAL"), "0.00"), 1, 10)
                    sqlstr = sqlstr & Space(1) & Space(6 - Len(Mid(Format(dr("ED"), "0.00"), 1, 6))) & Mid(Format(dr("ED"), "0.00"), 1, 6)
                    sqlstr = sqlstr & Space(1) & Space(6 - Len(Mid(Format(dr("CST"), "0.00"), 1, 6))) & Mid(Format(dr("CST"), "0.00"), 1, 6)
                    sqlstr = sqlstr & Space(1) & Space(6 - Len(Mid(Format(dr("MODVAT"), "0.00"), 1, 6))) & Mid(Format(dr("MODVAT"), "0.00"), 1, 6)
                    sqlstr = sqlstr & Space(1) & Space(6 - Len(Mid(Format(dr("PTAX"), "0.00"), 1, 6))) & Mid(Format(dr("PTAX"), "0.00"), 1, 6)
                    sqlstr = sqlstr & Space(1) & Space(6 - Len(Mid(Format(dr("OCTRAI"), "0.00"), 1, 6))) & Mid(Format(dr("OCTRAI"), "0.00"), 1, 6)
                    sqlstr = sqlstr & Space(1) & Space(6 - Len(Mid(Format(dr("INSURANCE"), "0.00"), 1, 6))) & Mid(Format(dr("INSURANCE"), "0.00"), 1, 6)
                    sqlstr = sqlstr & Space(1) & Space(6 - Len(Mid(Format(dr("LST"), "0.00"), 1, 6))) & Mid(Format(dr("LST"), "0.00"), 1, 6)
                    sqlstr = sqlstr & Space(1) & Space(10 - Len(Mid(Format(dr("TOTALVAT"), "0.00"), 1, 10))) & Mid(Format(dr("TOTALVAT"), "0.00"), 1, 10)
                    sqlstr = sqlstr & Space(1) & Space(10 - Len(Mid(Format(dr("TOTALTAX"), "0.00"), 1, 10))) & Mid(Format(dr("TOTALTAX"), "0.00"), 1, 10)
                    sqlstr = sqlstr & Space(1) & Space(10 - Len(Mid(Format(dr("POVALUE"), "0.00"), 1, 10))) & Mid(Format(dr("POVALUE"), "0.00"), 1, 10)
                    Filewrite.WriteLine(sqlstr)
                    pagesize = pagesize + 1
                    podepartment = dr("department")
                    pono = dr("pono")
                    totalqty = Val(totalqty) + Val(dr("QUANTITY"))
                    totalval = Val(totalval) + Val(dr("TOTAL"))

                Next dr
                Filewrite.WriteLine(StrDup(280, "="))
                Filewrite.Write(Space(140) & Space(10 - Len(Mid(Format(totalqty, "0.00"), 1, 10))) & Mid(Format(totalqty, "0.00"), 1, 10))
                Filewrite.Write(Space(39) & Space(10 - Len(Mid(Format(totalval, "0.00"), 1, 10))) & Mid(Format(totalval, "0.00"), 1, 10))
                Filewrite.Write(Space(50) & Space(10 - Len(Mid(Format(totalvat, "0.00"), 1, 10))) & Mid(Format(totalvat, "0.00"), 1, 10))
                Filewrite.Write(Space(5) & Mid(Format(totaltax, "0.00"), 1, 8) & Space(8 - Len(Mid(Format(totaltax, "0.00"), 1, 8))))
                Filewrite.WriteLine(Space(1) & Mid(Format(totalpovalue, "0.00"), 1, 10) & Space(10 - Len(Mid(Format(totalpovalue, "0.00"), 1, 10))))
                Filewrite.WriteLine(StrDup(280, "="))
                pagesize = pagesize + 1
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Function PrintHeader(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
        Dim I As Integer
        pagesize = 0
        '''*********************************************** PRINT REPORTS HEADING  *********************************'''
        Try
            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING(0)), 1, 32), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialyearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(280, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine("                                                       APPROVED               VENDOR                                  ITEM                                                              VAT     TOTAL     ED     CST   MVAT   PTAX  OCTRA  INSUR   LST     TOTVAT    TOTAL TAX  PO VALUE")
            Filewrite.WriteLine("SNO        PONO     PODATE       QUA.NO       PERSON          DATE  STATUS  CODE NAME                 DEPT    CODE           NAME       UOM      QTY      REQ.DATE      RATE   DISC.     %        Rs.      %      %      %      %     %      %       %       Rs.         Rs.       Rs. ")
            pagesize = pagesize + 2
            Filewrite.WriteLine(StrDup(280, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function

End Class
