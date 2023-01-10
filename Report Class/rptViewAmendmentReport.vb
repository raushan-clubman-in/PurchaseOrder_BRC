Imports System.data.sqlclient
Imports System.io
Public Class rptViewAmendmentReport
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
    Public Function ReportsDetails(ByVal SQLSTRING As String, ByVal PAGEHEADER() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim I, J As Integer
        Dim pono, podepartment As String
        Dim podate As Date
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("POREG" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            Dim sqlstr
            Dim sno As String
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEADER, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "PO_VW_AMENDEMNTREPORT")
            If gdataset.Tables("PO_VW_AMENDEMNTREPORT").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                sno = 1
                For Each dr In gdataset.Tables("PO_VW_AMENDEMNTREPORT").Rows
                    If pagesize > 56 Then
                        Filewrite.Write(StrDup(132, "-"))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEADER, FROMDATE, TODATE)
                    End If
                    'C = C + 1
                    If podepartment <> CStr(dr("POdepartment")) Then
                        Filewrite.WriteLine()
                        Filewrite.Write("P.O. DEPT.: ")
                        Filewrite.WriteLine(Mid(CStr(dr("PODEPARTMENT")), 1, 15))
                        Filewrite.WriteLine()
                        pagesize = pagesize + 3
                    End If

                    sqlstr = sno
                    sqlstr = sqlstr & Space(4)
                    sqlstr = sqlstr & Space(1) & Space(16 - Len(Mid(Format(dr("PONO")), 1, 16))) & Mid(Format(dr("PONO")), 1, 16)
                    sqlstr = sqlstr & Space(1) & Space(17 - Len(Mid(Format(dr("PODATE"), "dd-MM-yyyy"), 1, 24))) & Mid(Format(dr("PODATE"), "dd-MM-yyyy"), 1, 24)
                    sqlstr = sqlstr & Space(1) & Space(11 - Len(Mid(Format(dr("amendmentno")), 1, 10))) & Mid(Format(dr("amendmentno")), 1, 10)
                    sqlstr = sqlstr & Space(1) & Space(17 - Len(Mid(Format(dr("VENDORCODE")), 1, 15))) & Mid(Format(dr("VENDORCODE")), 1, 15)
                    sqlstr = sqlstr & Space(5) & Mid(Format(dr("amendmentdesc")), 1, 50) & Space(50 - Len(Mid(Format(dr("amendmentdesc")), 1, 50)))
                    sno = sno + 1
                    pagesize = pagesize + 1
                    podepartment = dr("POdepartment")
                    pono = dr("pono")
                    Filewrite.WriteLine(sqlstr)
                Next dr
                Filewrite.WriteLine(StrDup(132, "="))
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
            Filewrite.WriteLine(StrDup(132, "-"))
            pagesize = pagesize + 1
            Filewrite.WriteLine(" SNO        PONO                PODATE       AMEN/FOLL NO         VCODE                     DESCRIPTION ")
            pagesize = pagesize + 2
            Filewrite.WriteLine(StrDup(132, "-"))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
