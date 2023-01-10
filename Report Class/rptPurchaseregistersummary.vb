Imports System.Data.SqlClient
Imports System.io
Public Class rptPurchaseregistersummary
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblGrandTotal, dblBasicTotal, dblVATTotal, dblOtherTotal, dblDiscountTotal As Double
        Dim SUPPLIERNAME, PODEPARTMENT As String
        Dim SUPPLIERNAMEBOOL, GRNBOOL As Boolean
        Dim I As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "PURCHASEREGISTERSUMMARYREPORT")
            If gdataset.Tables("PURCHASEREGISTERSUMMARYREPORT").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("PURCHASEREGISTERSUMMARYREPORT").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If PODEPARTMENT <> Trim(CStr(dr("PONO"))) Then
                        Filewrite.WriteLine("{0,-18}", Mid(Trim(CStr(dr("PONO"))), 1, 18))
                        Filewrite.Write("{0,-18}", Mid(Trim(CStr(dr("PODEPARTMENT"))), 1, 17))
                        Filewrite.Write("{0,-12}", Mid(Format(CDate(dr("PODATE")), "dd/MM/yyyy"), 1, 12))
                        Filewrite.Write("{0,-9}", Mid(Trim(CStr(dr("VENDORCODE"))), 1, 9))
                        Filewrite.Write("{0,-27}", Mid(Trim(CStr(dr("VENDORNAME"))), 1, 27))
                        Filewrite.Write("{0,12}", Mid(Format(Val(dr("POVALUE")), "0.00"), 1, 12))
                        Filewrite.Write("{0,12}", Mid(Format(Val(dr("POTOTALVAT")), "0.00"), 1, 12))
                        Filewrite.Write("{0,12}", Mid(Format(Val(dr("POTOTALTAX")), "0.00"), 1, 12))
                        Filewrite.Write("{0,15}", Mid(Format(Val(dr("POADVANCE")), "0.00"), 1, 12))
                        Filewrite.WriteLine("{0,15}", Mid(Format(Val(dr("POBALANCE")), "0.00"), 1, 12))
                        pagesize = pagesize + 1
                        dblBasicTotal = dblBasicTotal + Format(Val(dr("POVALUE")), "0.00")
                        dblVATTotal = dblVATTotal + Format(Val(dr("POTOTALVAT")), "0.00")
                        dblOtherTotal = dblOtherTotal + Format(Val(dr("POTOTALTAX")), "0.00")
                        dblDiscountTotal = dblDiscountTotal + Format(Val(dr("POADVANCE")), "0.00")
                        dblGrandTotal = dblGrandTotal + Format(Val(dr("POBALANCE")), "0.00")
                        PODEPARTMENT = CStr(dr("PONO"))
                    End If
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-18}{1,-12}{2,-9}{3,-27}{4,12}", "GRAND TOTAL =====>", "", "", "", Format(Val(dblBasicTotal), "0.00"))
                Filewrite.WriteLine("{0,12}{1,12}{2,15}{3,15}", Format(Val(dblVATTotal), "0.00"), Format(Val(dblOtherTotal), "0.00"), Format(Val(dblDiscountTotal), "0.00"), Format(Val(dblGrandTotal), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
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
    Private Function PrintHeader(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
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
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(Heading(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialyearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Heading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,62}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-18}{1,-12}{2,-9}{3,-27}{4,12}", "P.O.NO./", "P.O.", "VENDOR  ", "VENDOR  ", "P.O. ")
            Filewrite.WriteLine("{0,12}{1,12}{2,15}{3,15}", "VAT", " TAX", "ADVANCE ", "BAL.")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-18}{1,-12}{2,-9}{3,-27}{4,12}", "DEPTNAME", "DATE", "CODE", "NAME", "AMOUNT")
            Filewrite.WriteLine("{0,12}{1,12}{2,15}{3,15}", "AMOUNT", "CHARGE", "AMOUNT", "AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function

    'm
    Public Function Reportsummary(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblGrandTotal, dblBasicTotal, dblVATTotal, dblOtherTotal, dblDiscountTotal As Double
        Dim SUPPLIERNAME, PODEPARTMENT As String
        Dim SUPPLIERNAMEBOOL, GRNBOOL As Boolean
        Dim I As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "PURCHASEREGISTERSUMMARYREPORT")
            If gdataset.Tables("PURCHASEREGISTERSUMMARYREPORT").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("PURCHASEREGISTERSUMMARYREPORT").Rows
                    If pagesize > 58 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeaderD(PAGEHEAD, FROMDATE, TODATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                    If PODEPARTMENT <> Trim(CStr(dr("PONO"))) Then
                        Filewrite.WriteLine("{0,-18}", Mid(Trim(CStr(dr("PONO"))), 1, 18))
                        Filewrite.Write("{0,-18}", Mid(Trim(CStr(dr("DEPARTMENT"))), 1, 17))
                        Filewrite.Write("{0,-12}", Mid(Format(CDate(dr("PODATE")), "dd/MM/yyyy"), 1, 12))
                        Filewrite.Write("{0,-9}", Mid(Trim(CStr(dr("SUPPLIERCODE"))), 1, 9))
                        Filewrite.Write("{0,-27}", Mid(Trim(CStr(dr("SUPPLIERNAME"))), 1, 27))
                        Filewrite.Write("{0,12}", Mid(Format(Val(dr("POVALUE")), "0.00"), 1, 12))
                        Filewrite.Write("{0,12}", Mid(Format(Val(dr("POTOTALVAT")), "0.00"), 1, 12))
                        Filewrite.Write("{0,12}", Mid(Format(Val(dr("POTOTALTAX")), "0.00"), 1, 12))
                        Filewrite.Write("{0,15}", Mid(Format(Val(dr("POADVANCE")), "0.00"), 1, 12))
                        Filewrite.WriteLine("{0,15}", Mid(Format(Val(dr("POBALANCE")), "0.00"), 1, 12))
                        'Filewrite.WriteLine("{0,-18}", Mid(Trim(CStr(dr("APPROVEDBY"))), 1, 18))
                        'Filewrite.Write("{0,-12}", Mid(Format(CDate(dr("APPROVEDDATE")), "dd/MM/yyyy"), 1, 12))
                        Filewrite.WriteLine("{0,-12}", Mid(Trim(CStr(dr("POSTATUS"))), 1, 18))
                        pagesize = pagesize + 1
                        dblBasicTotal = dblBasicTotal + Format(Val(dr("POVALUE")), "0.00")
                        dblVATTotal = dblVATTotal + Format(Val(dr("POTOTALVAT")), "0.00")
                        dblOtherTotal = dblOtherTotal + Format(Val(dr("POTOTALTAX")), "0.00")
                        dblDiscountTotal = dblDiscountTotal + Format(Val(dr("POADVANCE")), "0.00")
                        dblGrandTotal = dblGrandTotal + Format(Val(dr("POBALANCE")), "0.00")
                        PODEPARTMENT = CStr(dr("PONO"))
                    End If
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-18}{1,-12}{2,-9}{3,-27}{4,12}", "GRAND TOTAL =====>", "", "", "", Format(Val(dblBasicTotal), "0.00"))
                Filewrite.WriteLine("{0,12}{1,12}{2,15}{3,15}", Format(Val(dblVATTotal), "0.00"), Format(Val(dblOtherTotal), "0.00"), Format(Val(dblDiscountTotal), "0.00"), Format(Val(dblGrandTotal), "0.00"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
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
    'M
    Private Function PrintHeaderD(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date)
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
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(Heading(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialyearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(Heading(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,62}{1,-10}", " ", "SUMMARY")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-18}{1,-12}{2,-9}{3,-27}{4,12}", "P.O.NO./", "P.O.", "VENDOR  ", "VENDOR  ", "P.O. ")
            Filewrite.WriteLine("{0,12}{1,12}{2,15}{3,15}{4,12}", "VAT", " TAX", "ADVANCE ", "BAL.", "PO STATUS")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-18}{1,-12}{2,-9}{3,-27}{4,12}", "DEPTNAME", "DATE", "CODE", "NAME", "AMOUNT")
            Filewrite.WriteLine("{0,12}{1,12}{2,15}{3,15}", "AMOUNT", "CHARGE", "AMOUNT", "AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class