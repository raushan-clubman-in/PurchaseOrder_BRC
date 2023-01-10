Imports System.Data.SqlClient
Imports System.io
Public Class rptStockPurchaseregister
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim dblGroupbillamt, dblGrandbillamt, dblGroupBasicamt, dblGrandBasicamt, dblVATamount As Double
        Dim dblGroupVATamt, dblGrandVATamt, dblGroupOtherchg, dblGrandOtherchg, dblGroupdiscountamt As Double
        Dim dblBasicamount, dblothercharge, dbldiscountamt, dblBillamount, dblGranddiscountamt As Double
        Dim SUPPLIERNAME, GRNDETAILS, SSQL As String
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
            gconnection.getDataSet(SQLSTRING, "PURCHASEREGISTERREPORT")
            If gdataset.Tables("PURCHASEREGISTERREPORT").Rows.Count > 0 Then
                For Each dr In gdataset.Tables("PURCHASEREGISTERREPORT").Rows
                    If pagesize > 56 Then
                        Filewrite.Write(StrDup(135, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
                    End If
                    If SUPPLIERNAME <> Trim(CStr(dr("SUPPLIERNAME"))) Then
                        If SUPPLIERNAMEBOOL = True Then
                            Filewrite.WriteLine()
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "*"))
                            pagesize = pagesize + 1
                            Filewrite.Write("{0,-20}{1,-15}{2,-40}{3,-10}{4,-10}", "GROUP TOTAL =====>", "", "", Mid(Format(Val(dblGroupBasicamt), "0.00"), 1, 10), Mid(Format(Val(dblGroupVATamt), "0.00"), 1, 10))
                            Filewrite.WriteLine("{0,12}{1,15}{2,13}", Mid(Format(Val(dblGroupOtherchg), "0.00"), 1, 12), Mid(Format(Val(dblGroupdiscountamt), "0.00"), 1, 15), Mid(Format(Val(dblGroupbillamt), "0.00"), 1, 13))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "*"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-50}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("SUPPLIERNAME"))), 1, 50))
                            pagesize = pagesize + 1
                            SUPPLIERNAME = dr("SUPPLIERNAME")
                            SUPPLIERNAMEBOOL = True
                            dblGroupbillamt = 0 : dblGroupBasicamt = 0 : dblGroupVATamt = 0 : dblGroupOtherchg = 0 : dblGroupdiscountamt = 0
                        Else
                            Filewrite.WriteLine("{0,-50}", Chr(14) & Chr(15) & Mid(Trim(CStr(dr("SUPPLIERNAME"))), 1, 50))
                            pagesize = pagesize + 1
                            SUPPLIERNAME = dr("SUPPLIERNAME")
                            SUPPLIERNAMEBOOL = True : GRNBOOL = False
                            dblGroupbillamt = 0 : dblGroupBasicamt = 0 : dblGroupVATamt = 0 : dblGroupOtherchg = 0 : dblGroupdiscountamt = 0
                        End If
                    End If
                    If GRNDETAILS <> Trim(CStr(dr("GRNDETAILS"))) Then
                        GRNDETAILS = dr("GRNDETAILS")
                        Filewrite.Write("{0,-20}", Mid(Trim(CStr(dr("GRNDETAILS"))), 1, 20))
                        Filewrite.Write("{0,-15}", Mid(Format(CDate(dr("GRNDATE")), "dd/MM/yyyy"), 1, 15))
                        SSQL = "SELECT * FROM VIEWPURCHASEREGISTERSUMMARY WHERE GRNDETAILS = '" & Trim(CStr(dr("GRNDETAILS"))) & "'"
                        SSQL = SSQL & " ORDER BY GRNDETAILS,GRNDATE,SUPPLIERCODE,SUPPLIERNAME"
                        gconnection.getDataSet(SSQL, "VIEWPURCHASEREGISTERSUMMARY")
                        If gdataset.Tables("VIEWPURCHASEREGISTERSUMMARY").Rows.Count > 0 Then
                            For I = 0 To gdataset.Tables("VIEWPURCHASEREGISTERSUMMARY").Rows.Count - 1 Step 1
                                With gdataset.Tables("VIEWPURCHASEREGISTERSUMMARY").Rows(I)
                                    If I > 0 Then
                                        Filewrite.Write("{0,-20}", "")
                                        Filewrite.Write("{0,-15}", "")
                                    End If
                                    Filewrite.Write("{0,-10}", Mid(Trim(CStr(.Item("ITEMCODE"))), 1, 10))
                                    Filewrite.Write("{0,-30}", Mid(Trim(CStr(.Item("ITEMNAME"))), 1, 30))
                                    Filewrite.Write("{0,-10}", Mid(Trim(CStr(.Item("UOM"))), 1, 10))
                                    Filewrite.Write("{0,-10}", Mid(Format(Val(.Item("QTY")), "0.000"), 1, 10))
                                    Filewrite.Write("{0,12}", Mid(Format(Val(.Item("RATE")), "0.00"), 1, 12))
                                    Filewrite.Write("{0,15}", Mid(Format(Val(.Item("AMOUNT")), "0.00"), 1, 15))
                                    Filewrite.WriteLine("{0,12}", Mid(Format(Val(.Item("DISCOUNT")), "0.00"), 1, 12))
                                    pagesize = pagesize + 1
                                    dblBasicamount = dblBasicamount + Format(Val(.Item("AMOUNT")), "0.00")
                                    dblVATamount = Format(Val(.Item("VATAMOUNT")), "0.00")
                                    dblothercharge = Format(Val(.Item("SURCHARGEAMT")), "0.00")
                                    dbldiscountamt = Format(Val(.Item("DISCOUNTAMOUNT")), "0.00")
                                    dblBillamount = Format(Val(.Item("BILLAMOUNT")), "0.00")
                                    If pagesize > 54 Then
                                        Filewrite.Write(StrDup(135, "-"))
                                        Filewrite.Write(Chr(12))
                                        pageno = pageno + 1
                                        Call PrintHeader(PAGEHEAD, FROMDATE, TODATE)
                                    End If
                                End With
                            Next
                            Filewrite.WriteLine()
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "."))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-20}{1,-35}{2,20}{3,-20}{4,12}{5,15}", "PAID DETAILS", "", "BASIC :", "", "", Format(Val(dblBasicamount), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-20}{1,-35}{2,20}{3,-20}{4,12}{5,15}", "************", "", "V.A.T :", "", "", Format(Val(dblVATamount), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-20}{1,-35}{2,20}{3,-20}{4,12}{5,15}", "", "", "OTHER CHARGES :", "", "", Format(Val(dblothercharge), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-20}{1,-35}{2,20}{3,-20}{4,12}{5,15}", "", "", "DISCOUNT AMOUNT :", "", "", Format(Val(dbldiscountamt), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine("{0,-20}{1,-35}{2,20}{3,-20}{4,12}{5,15}", "", "", "BILL AMOUNT :", "", "", Format(Val(dblBillamount), "0.00"))
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(135, "."))
                            pagesize = pagesize + 1
                            dblGroupBasicamt = dblGroupBasicamt + Format(Val(dblBasicamount), "0.00")
                            dblGrandBasicamt = dblGrandBasicamt + Format(Val(dblBasicamount), "0.00")

                            dblGroupVATamt = dblGroupVATamt + Format(Val(dblVATamount), "0.00")
                            dblGrandVATamt = dblGrandVATamt + Format(Val(dblVATamount), "0.00")

                            dblGroupOtherchg = dblGroupOtherchg + Format(Val(dblothercharge), "0.00")
                            dblGrandOtherchg = dblGrandOtherchg + Format(Val(dblothercharge), "0.00")

                            dblGroupdiscountamt = dblGroupdiscountamt + Format(Val(dbldiscountamt), "0.00")
                            dblGroupdiscountamt = dblGroupdiscountamt + Format(Val(dbldiscountamt), "0.00")

                            dblGroupbillamt = dblGroupbillamt + Format(Val(dblBillamount), "0.00")
                            dblGrandbillamt = dblGrandbillamt + Format(Val(dblBillamount), "0.00")
                            dblBasicamount = 0 : dblVATamount = 0 : dblothercharge = 0 : dbldiscountamt = 0 : dblBillamount = 0
                        End If
                    End If
                Next dr
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "*"))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-20}{1,-15}{2,-40}{3,-10}{4,-10}", "GROUP TOTAL =====>", "", "", Mid(Format(Val(dblGroupBasicamt), "0.00"), 1, 10), Mid(Format(Val(dblGroupVATamt), "0.00"), 1, 10))
                Filewrite.WriteLine("{0,12}{1,15}{2,13}", Mid(Format(Val(dblGroupOtherchg), "0.00"), 1, 12), Mid(Format(Val(dblGroupdiscountamt), "0.00"), 1, 15), Mid(Format(Val(dblGroupbillamt), "0.00"), 1, 13))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "*"))
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(135, "="))
                pagesize = pagesize + 1
                Filewrite.Write("{0,-20}{1,-15}{2,-40}{3,-10}{4,-10}", "GRAND TOTAL =====>", "", "", Mid(Format(Val(dblGrandBasicamt), "0.00"), 1, 10), Mid(Format(Val(dblGrandVATamt), "0.00"), 1, 10))
                Filewrite.WriteLine("{0,12}{1,15}{2,13}", Mid(Format(Val(dblGrandOtherchg), "0.00"), 1, 12), Mid(Format(Val(dblGranddiscountamt), "0.00"), 1, 15), Mid(Format(Val(dblGrandbillamt), "0.00"), 1, 13))
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
                PrintTextFile(VFilePath)
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
            Filewrite.WriteLine("{0,62}{1,-10}", " ", "DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE :" & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
            Filewrite.Write("{0,-20}{1,-15}{2,-40}{3,-10}{4,-10}", "BILL NO.", "BILL", "BILL DETAILS", "UOM", "QUANTITY")
            Filewrite.WriteLine("{0,12}{1,15}{2,13}", "RATE", "AMOUNT", "DISCOUNT")
            pagesize = pagesize + 1
            Filewrite.Write("{0,-20}{1,-15}{2,-40}{3,-10}{4,-10}", "", "DATE", "", "", "")
            Filewrite.WriteLine("{0,12}{1,15}{2,13}", "", "", "AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(135, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
