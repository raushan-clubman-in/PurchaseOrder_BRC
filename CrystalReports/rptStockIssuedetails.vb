Imports System.Data.SqlClient
Imports System.io
Public Class rptStockIssuedetails
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function Reportdetails(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date, ByVal WITHRATE As Boolean)
        Dim dblGroupAmount, dblGrandAmount, dblLocationamount As Double
        Dim dblGroupQTY, dblGrandQTY, dblLocationQTY As Double
        Dim Groupdesc, Itemcode, StoreLoc, ssql As String
        Dim Groupbool, LocationBool As Boolean
        Dim I, J, K, L As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEAD, FROMDATE, TODATE, WITHRATE)
            gconnection.getDataSet(SQLSTRING, "ISSUEDETAILSDETAILS")
            If gdataset.Tables("ISSUEDETAILSDETAILS").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For K = 0 To gdataset.Tables("ISSUEDETAILSDETAILS").Rows.Count - 1
                    If Groupdesc <> Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("GROUPDESC"))) Then
                        Filewrite.WriteLine("{0,-30}", Mid("[" & Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("GROUPDESC"))) & "]", 1, 30))
                        pagesize = pagesize + 1
                        Filewrite.WriteLine(StrDup(Len(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(J).Item("GROUPDESC")) + 2, "-"))
                        pagesize = pagesize + 1

                        Groupdesc = Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("GROUPDESC")))
                    End If
                    If Itemcode <> Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("ITEMCODE"))) Then
                        Filewrite.Write("{0,-6}", Mid(Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("ITEMCODE"))), 1, 5))
                        Filewrite.Write("{0,-20}", Mid(Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("ITEMNAME"))), 1, 20))
                        Itemcode = Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("ITEMCODE")))
                        StoreLoc = ""
                    Else
                        If StoreLoc <> Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("LOCATIONNAME"))) Then
                            Filewrite.Write("{0,-6}", "")
                            Filewrite.Write("{0,-20}", "")
                        End If
                    End If
                    If StoreLoc <> Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("LOCATIONNAME"))) Then
                        Filewrite.Write("{0,-15}", Mid(Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("LOCATIONNAME"))), 1, 14))
                        StoreLoc = Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("LOCATIONNAME")))

                        ssql = "SELECT ITEMCODE,ITEMNAME,LOCATIONNAME,UOM,QTY,RATE,AMOUNT,GROUPDESC,VOID FROM ISSUEDETAILS"
                        ssql = ssql & " WHERE ITEMCODE = '" & Trim(Itemcode) & "' AND LOCATIONNAME = '" & Trim(StoreLoc) & "' AND DOCDATE BETWEEN "
                        ssql = ssql & " '" & Format(FROMDATE, "dd-MMM-yyyy") & "' AND ' " & Format(TODATE, "dd-MMM-yyyy") & "'"
                        ssql = ssql & " ORDER BY LOCATIONNAME"
                        gconnection.getDataSet(ssql, "ISSUEDETAILSDETAILS1")
                        If gdataset.Tables("ISSUEDETAILSDETAILS1").Rows.Count > 0 Then
                            For J = 0 To gdataset.Tables("ISSUEDETAILSDETAILS1").Rows.Count - 1
                                If J > 0 Then
                                    Filewrite.Write("{0,-6}", "")
                                    Filewrite.Write("{0,-20}", "")
                                    Filewrite.Write("{0,-15}", "")
                                End If
                                Filewrite.Write("{0,-10}", Mid(Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("UOM"))), 1, 10))
                                Filewrite.Write("{0,-8}", Mid(Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("QTY")), "0.000"), 1, 8))
                                dblLocationQTY = dblLocationQTY + Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("QTY")), "0.00")
                                dblGroupQTY = dblGroupQTY + Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("QTY")), "0.00")
                                dblGrandQTY = dblGrandQTY + Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("QTY")), "0.00")

                                If WITHRATE = True Then
                                    Filewrite.Write("{0,8}", Mid(Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("RATE")), "0.00"), 1, 8))
                                    Filewrite.WriteLine("{0,10}", Mid(Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("AMOUNT")), "0.00"), 1, 10))
                                    pagesize = pagesize + 1
                                    dblLocationamount = dblLocationamount + Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("AMOUNT")), "0.00")
                                    dblGroupAmount = dblGroupAmount + Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("AMOUNT")), "0.00")
                                    dblGrandAmount = dblGrandAmount + Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("AMOUNT")), "0.00")
                                Else
                                    Filewrite.WriteLine("")
                                    pagesize = pagesize + 1
                                End If
                                If pagesize > 56 Then
                                    Filewrite.Write(StrDup(78, "-"))
                                    Filewrite.Write(Chr(12))
                                    pageno = pageno + 1
                                    Call PrintHeader(PAGEHEAD, FROMDATE, TODATE, WITHRATE)
                                    Filewrite.WriteLine()
                                    pagesize = pagesize + 1
                                End If
                            Next
                            Filewrite.WriteLine()
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            If WITHRATE = True Then
                                'Filewrite.WriteLine("{0,-6}{1,-20}{2,-39}{3,12}", "", "LOC. TOTAL =====>", "", Format(Val(dblLocationamount), "0.00"))
                                Filewrite.WriteLine("{0,-6}{1,-20}{2,21}{3,10}{4,-8}{5,12}", "", "LOC. TOTAL =====>", "", Format(Val(dblLocationQTY), "0.000"), "", Format(Val(dblLocationamount), "0.00"))
                                pagesize = pagesize + 1
                            Else
                                Filewrite.WriteLine("{0,-6}{1,-20}{2,21}{3,10}{4,-8}{5,12}", "", "LOC. TOTAL =====>", "", Format(Val(dblLocationQTY), "0.000"), "", "")
                                pagesize = pagesize + 1
                            End If
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            dblLocationQTY = 0
                            dblLocationamount = 0
                        End If
                    End If
                    If pagesize > 56 Then
                        Filewrite.Write(StrDup(78, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, FROMDATE, TODATE, WITHRATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                Next


                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1
                If WITHRATE = True Then
                    Filewrite.WriteLine("{0,-6}{1,-20}{2,21}{3,10}{4,-8}{5,12}", "", "SUB TOTAL =====>", "", Format(Val(dblGroupQTY), "0.000"), "", Format(Val(dblGroupAmount), "0.00"))
                    pagesize = pagesize + 1
                Else
                    Filewrite.WriteLine("{0,-6}{1,-20}{2,21}{3,10}{4,-8}{5,12}", "", "SUB TOTAL =====>", "", Format(Val(dblGroupQTY), "0.000"), "", "")
                    pagesize = pagesize + 1
                End If
                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1

                Filewrite.WriteLine(StrDup(78, "="))
                pagesize = pagesize + 1
                If WITHRATE = True Then
                    Filewrite.WriteLine("{0,-6}{1,-20}{2,-39}{3,12}", "", "GRAND TOTAL =====>", "", Format(Val(dblGrandAmount), "0.00"))
                Else
                    Filewrite.WriteLine("{0,-6}{1,-20}{2,21}{3,10}{4,-8}{5,12}", "", "GRAND TOTAL =====>", "", Format(Val(dblGrandQTY), "0.000"), "", Format(Val(dblGrandAmount), "0.00"))
                End If
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "="))
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

    Private Function PrintHeader(ByVal Heading() As String, ByVal mskfromdate As Date, ByVal msktodate As Date, ByVal WITHRATE As Boolean)
        Dim I As Integer
        pagesize = 0
        '''*********************************************** PRINT REPORTS HEADING  *********************************'''
        Try
            Filewrite.WriteLine(Chr(18))
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
            Filewrite.WriteLine("{0,64}{1,-10}", " ", "DETAILS")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(mskfromdate, "MMM dd,yyyy") & " " & "To" & " " & Format(msktodate, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(78, "-"))
            pagesize = pagesize + 1
            If WITHRATE = True Then
                Filewrite.WriteLine("{0,-6}{1,-20}{2,-15}{3,-10}{4,-8}{5,8}{6,10}", "ITEM", "ITEM", "ISSUE TO", "UOM", "QTY", "RATE", "AMOUNT")
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-6}{1,-20}{2,-15}{3,-10}{4,-8}{5,8}{6,10}", "CODE", "DESCRIPTION", "", "", "", "", "")
                pagesize = pagesize + 1
            Else
                Filewrite.WriteLine("{0,-6}{1,-20}{2,-15}{3,-10}{4,-8}", "ITEM", "ITEM", "ISSUE TO", "UOM", "QTY")
                pagesize = pagesize + 1
                Filewrite.WriteLine("{0,-6}{1,-20}{2,-15}{3,-10}{4,-8}", "CODE", "DESCRIPTION", "", "", "")
            End If
            Filewrite.WriteLine(StrDup(78, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
    Public Function Reportdetails_withoutGroup(ByVal SQLSTRING As String, ByVal PAGEHEAD() As String, ByVal FROMDATE As Date, ByVal TODATE As Date, ByVal WITHRATE As Boolean)
        Dim dblGroupAmount, dblGrandAmount, dblLocationamount As Double
        Dim dblGroupQTY, dblGrandQTY, dblLocationQTY As Double
        Dim Groupdesc, Itemcode, StoreLoc, ssql As String
        Dim Groupbool, LocationBool As Boolean
        Dim I, J, K, L As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEAD, FROMDATE, TODATE, WITHRATE)
            gconnection.getDataSet(SQLSTRING, "ISSUEDETAILSDETAILS")
            If gdataset.Tables("ISSUEDETAILSDETAILS").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For K = 0 To gdataset.Tables("ISSUEDETAILSDETAILS").Rows.Count - 1
                    If Groupdesc <> Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("GROUPDESC"))) Then
                        'Filewrite.WriteLine("{0,-30}", Mid("[" & Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("GROUPDESC"))) & "]", 1, 30))
                        'pagesize = pagesize + 1
                        'Filewrite.WriteLine(StrDup(Len(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(J).Item("GROUPDESC")) + 2, "-"))
                        'pagesize = pagesize + 1
                        Groupdesc = Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("GROUPDESC")))
                    End If
                    If Itemcode <> Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("ITEMCODE"))) Then
                        Filewrite.Write("{0,-6}", Mid(Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("ITEMCODE"))), 1, 5))
                        Filewrite.Write("{0,-20}", Mid(Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("ITEMNAME"))), 1, 20))
                        Itemcode = Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("ITEMCODE")))
                        StoreLoc = ""
                    Else
                        If StoreLoc <> Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("LOCATIONNAME"))) Then
                            Filewrite.Write("{0,-6}", "")
                            Filewrite.Write("{0,-20}", "")
                        End If
                    End If
                    If StoreLoc <> Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("LOCATIONNAME"))) Then
                        Filewrite.Write("{0,-15}", Mid(Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("LOCATIONNAME"))), 1, 14))
                        StoreLoc = Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS").Rows(K).Item("LOCATIONNAME")))

                        ssql = "SELECT ITEMCODE,ITEMNAME,LOCATIONNAME,UOM,QTY,RATE,AMOUNT,GROUPDESC,VOID FROM ISSUEDETAILS"
                        ssql = ssql & " WHERE ITEMCODE = '" & Trim(Itemcode) & "' AND LOCATIONNAME = '" & Trim(StoreLoc) & "' AND DOCDATE BETWEEN "
                        ssql = ssql & " '" & Format(FROMDATE, "dd-MMM-yyyy") & "' AND ' " & Format(TODATE, "dd-MMM-yyyy") & "'"
                        ssql = ssql & " ORDER BY LOCATIONNAME"
                        gconnection.getDataSet(ssql, "ISSUEDETAILSDETAILS1")
                        If gdataset.Tables("ISSUEDETAILSDETAILS1").Rows.Count > 0 Then
                            For J = 0 To gdataset.Tables("ISSUEDETAILSDETAILS1").Rows.Count - 1
                                If J > 0 Then
                                    Filewrite.Write("{0,-6}", "")
                                    Filewrite.Write("{0,-20}", "")
                                    Filewrite.Write("{0,-15}", "")
                                End If
                                Filewrite.Write("{0,-10}", Mid(Trim(CStr(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("UOM"))), 1, 10))
                                Filewrite.Write("{0,-8}", Mid(Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("QTY")), "0.000"), 1, 8))
                                dblLocationQTY = dblLocationQTY + Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("QTY")), "0.00")
                                dblGroupQTY = dblGroupQTY + Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("QTY")), "0.00")
                                dblGrandQTY = dblGrandQTY + Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("QTY")), "0.00")

                                If WITHRATE = True Then
                                    Filewrite.Write("{0,8}", Mid(Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("RATE")), "0.00"), 1, 8))
                                    Filewrite.WriteLine("{0,10}", Mid(Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("AMOUNT")), "0.00"), 1, 10))
                                    pagesize = pagesize + 1
                                    dblLocationamount = dblLocationamount + Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("AMOUNT")), "0.00")
                                    dblGroupAmount = dblGroupAmount + Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("AMOUNT")), "0.00")
                                    dblGrandAmount = dblGrandAmount + Format(Val(gdataset.Tables("ISSUEDETAILSDETAILS1").Rows(J).Item("AMOUNT")), "0.00")
                                Else
                                    Filewrite.WriteLine("")
                                    pagesize = pagesize + 1
                                End If
                                If pagesize > 56 Then
                                    Filewrite.Write(StrDup(78, "-"))
                                    Filewrite.Write(Chr(12))
                                    pageno = pageno + 1
                                    Call PrintHeader(PAGEHEAD, FROMDATE, TODATE, WITHRATE)
                                    Filewrite.WriteLine()
                                    pagesize = pagesize + 1
                                End If
                            Next
                            Filewrite.WriteLine()
                            pagesize = pagesize + 1
                            Filewrite.WriteLine(StrDup(78, "-"))
                            pagesize = pagesize + 1
                            'If WITHRATE = True Then
                            '    'Filewrite.WriteLine("{0,-6}{1,-20}{2,-39}{3,12}", "", "LOC. TOTAL =====>", "", Format(Val(dblLocationamount), "0.00"))
                            '    Filewrite.WriteLine("{0,-6}{1,-20}{2,21}{3,10}{4,-8}{5,12}", "", "LOC. TOTAL =====>", "", Format(Val(dblLocationQTY), "0.000"), "", Format(Val(dblLocationamount), "0.00"))
                            '    pagesize = pagesize + 1
                            'Else
                            '    Filewrite.WriteLine("{0,-6}{1,-20}{2,21}{3,10}{4,-8}{5,12}", "", "LOC. TOTAL =====>", "", Format(Val(dblLocationQTY), "0.000"), "", "")
                            '    pagesize = pagesize + 1
                            'End If
                            'Filewrite.WriteLine(StrDup(78, "-"))
                            'pagesize = pagesize + 1
                            'dblLocationQTY = 0
                            'dblLocationamount = 0
                        End If
                        
                    End If
                    If WITHRATE = True Then
                        'Filewrite.WriteLine("{0,-6}{1,-20}{2,-39}{3,12}", "", "LOC. TOTAL =====>", "", Format(Val(dblLocationamount), "0.00"))
                        Filewrite.WriteLine("{0,-6}{1,-20}{2,21}{3,10}{4,-8}{5,12}", "", "LOC. TOTAL =====>", "", Format(Val(dblLocationQTY), "0.000"), "", Format(Val(dblLocationamount), "0.00"))
                        pagesize = pagesize + 1
                    Else
                        Filewrite.WriteLine("{0,-6}{1,-20}{2,21}{3,10}{4,-8}{5,12}", "", "LOC. TOTAL =====>", "", Format(Val(dblLocationQTY), "0.000"), "", "")
                        pagesize = pagesize + 1
                    End If
                    Filewrite.WriteLine(StrDup(78, "-"))
                    pagesize = pagesize + 1
                    dblLocationQTY = 0
                    dblLocationamount = 0

                    If pagesize > 56 Then
                        Filewrite.Write(StrDup(78, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEAD, FROMDATE, TODATE, WITHRATE)
                        Filewrite.WriteLine()
                        pagesize = pagesize + 1
                    End If
                Next


                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1
                If WITHRATE = True Then
                    Filewrite.WriteLine("{0,-6}{1,-20}{2,21}{3,10}{4,-8}{5,12}", "", "SUB TOTAL =====>", "", Format(Val(dblGroupQTY), "0.000"), "", Format(Val(dblGroupAmount), "0.00"))
                    pagesize = pagesize + 1
                Else
                    Filewrite.WriteLine("{0,-6}{1,-20}{2,21}{3,10}{4,-8}{5,12}", "", "SUB TOTAL =====>", "", Format(Val(dblGroupQTY), "0.000"), "", "")
                    pagesize = pagesize + 1
                End If
                Filewrite.WriteLine(StrDup(78, "-"))
                pagesize = pagesize + 1

                Filewrite.WriteLine(StrDup(78, "="))
                pagesize = pagesize + 1
                If WITHRATE = True Then
                    Filewrite.WriteLine("{0,-6}{1,-20}{2,-39}{3,12}", "", "GRAND TOTAL =====>", "", Format(Val(dblGrandAmount), "0.00"))
                Else
                    Filewrite.WriteLine("{0,-6}{1,-20}{2,21}{3,10}{4,-8}{5,12}", "", "GRAND TOTAL =====>", "", Format(Val(dblGrandQTY), "0.000"), "", Format(Val(dblGrandAmount), "0.00"))
                End If
                pagesize = pagesize + 1
                Filewrite.WriteLine(StrDup(78, "="))
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
End Class
