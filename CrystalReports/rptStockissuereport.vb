Imports System.Data.SqlClient
Imports System.IO
Public Class rptStockissuereport
    Dim dr As DataRow
    Dim dc As DataColumn
    Dim pageno As Integer
    Dim pagesize As Integer
    Dim gconnection As New GlobalClass
    Public Function Reportdetails(ByVal sqlstring As String, ByVal pageheading() As String, ByVal columnheading() As String, ByVal colsize() As Integer)
        Dim x, docno, printline As String
        Dim I As Integer
        Dim booldocno As Boolean
        Dim total(10) As Double
        Dim slno As Integer = 0
        Dim vsubheader() As String = {"DOC NO. : ", "DOC DATE : ", "MAIN STORE CODE : ", "MAIN STORE NAME : ", "TO STORE CODE  : ", "TO STORE NAME :"}
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            'Filewrite.Write(Chr(15))
            gconnection.getDataSet(sqlstring, "Stockissuereport")
            Call Print_Headers(pageheading)
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            For Each dr In gdataset.Tables("Stockissuereport").Rows
                If pagesize > 55 Then
                    Filewrite.Write(StrDup(123, "-"))
                    Filewrite.Write(Chr(12))
                    pageno = pageno + 1
                    Call Print_Headers(pageheading)
                End If
                If docno <> dr("docdetails") Then
                    If booldocno = True Then
                        For I = 0 To 5
                            Filewrite.WriteLine("")
                            pagesize = pagesize + 1
                        Next I
                        Filewrite.Write(StrDup(123, "-"))
                    End If
                    Filewrite.WriteLine()
                    pagesize = pagesize + 1
                    printline = "INDENT NO. : " & Trim(dr("indentno"))
                    printline = printline & Space(80 - Len("INDENT NO. : " & Trim(dr("indentno"))))
                    printline = printline & vsubheader(0) & Trim(dr("docdetails"))
                    Filewrite.WriteLine(printline)
                    pagesize = pagesize + 1

                    printline = ""
                    printline = "INDENT DT. : " & Trim(Format(dr("INDENTDATE"), "dd-MM-yyyy"))
                    printline = printline & Space(80 - Len("INDENT DT. : " & Trim(Format(dr("INDENTDATE"), "dd-MM-yyyy"))))
                    'printline = printline & Space(80)
                    printline = printline & vsubheader(1) & Trim(Format(dr("docdate"), "dd-MM-yyyy"))
                    Filewrite.WriteLine(printline)
                    pagesize = pagesize + 1
                    Filewrite.WriteLine()
                    Filewrite.WriteLine("FROM : -" & Space(72) & "TO : -" & Chr(27) & "F")
                    pagesize = pagesize + 2

                    printline = "DEPT CODE : " & Trim(dr("storelocationcode"))
                    printline = printline & Space(80 - (Trim(dr("storelocationcode")).Length + 12))
                    printline = printline & "DEPT CODE : " & Trim(dr("opstorelocationcode"))
                    Filewrite.WriteLine(printline)
                    pagesize = pagesize + 1
                    
                    printline = "DEPT NAME : " & Trim(dr("storelocationname"))
                    printline = printline & Space(80 - (Trim(dr("storelocationname")).Length + 12))
                    printline = printline & "DEPT NAME : "
                    printline = printline & Trim(dr("opstorelocationname"))
                    Filewrite.WriteLine(printline)
                    pagesize = pagesize + 1
                    Filewrite.WriteLine()
                    pagesize = pagesize + 1

                    docno = Trim(dr("docdetails"))
                    Call Print_Columnheaders(columnheading, colsize)
                    booldocno = True
                End If
                slno = slno + 1
                'printline = Space(colsize(3) - Len(Trim(Format(slno, "0"))) - 2) & Mid(Trim(Format(slno, "0")), 1, 4) & Space(1)
                printline = Space(4 - Len(Trim(Format(slno, "0")))) & Trim(Format(slno, "0")) & Space(1)
                printline = printline & Mid(Trim(dr("Itemcode")), 1, 12) & Space(12 - Trim(dr("Itemcode")).Length)
                printline = printline & Mid(Trim(dr("Itemname")), 1, 40) & Space(40 - Trim(dr("Itemname")).Length)
                printline = printline & Mid(Trim(dr("UOM")), 1, 15) & Space(15 - Mid(Trim(dr("UOM")), 1, 15).Length) & Space(1)
                printline = printline & Space(10 - Len(Trim(Format(dr("Qty"), "0.000")))) & Mid(Trim(Format(dr("Qty"), "0.000")), 1, 10) & Space(2)
                total(0) = total(0) + Trim(dr("Qty"))
                printline = printline & Space(10 - Len(Trim(Format(dr("Rate"), "0.00")))) & Mid(Trim(Format(dr("Rate"), "0.00")), 1, 10) & Space(2)
                total(1) = total(1) + Trim(dr("Rate"))
                printline = printline & Space(11 - Len(Trim(Format(dr("Amount"), "##,##0.00")))) & Mid(Trim(Format(dr("Amount"), "##,##0.00")), 1, 11) & Space(2)
                total(2) = total(2) + Trim(dr("Amount"))


                Filewrite.WriteLine(printline)
                pagesize = pagesize + 1
            Next dr
            For I = 0 To 5
                Filewrite.WriteLine("")
                pagesize = pagesize + 1
            Next I

            'Call Print_Grandtotals("GRAND TOTAL ===>", colsize, total)
            Filewrite.WriteLine(StrDup(123, "-"))
            Filewrite.WriteLine(Chr(27) & "E" & Space(57) & "GRAND TOTAL ===>" & Space(10 - Len(Format(total(0), "##,##0.00"))) & Format(total(0), "##,##0.00") & Space(14) & Space(11 - Len(Format(total(2), "##,##0.00"))) & Format(total(2), "##,##0.00") & Chr(27) & "F")
            Filewrite.WriteLine(StrDup(123, "-"))
            Filewrite.WriteLine("")
            Filewrite.WriteLine(Space(0) & " Remarks:" & Trim(dr("remarks")))


            If pagesize < 50 Then
                Dim A As Integer
                For A = 1 To 50 - pagesize
                    Filewrite.WriteLine()
                Next
            End If
            If Trim(dr("STORELOCATIONCODE")) <> "" Then
                If Trim(dr("STORELOCATIONCODE")) <> "DRR" And Trim(dr("UPDFOOTER")) <> "" Then
                    'Filewrite.WriteLine(Chr(27) & "E" & " Indent By         			Supervisor          		Initials of Issues         			Received by " & Chr(27) & "F")
                    Filewrite.WriteLine(Space(2) & Trim(dr("UPDFOOTER")))
                    Filewrite.Write(Chr(12))
                Else
                    Filewrite.WriteLine(Chr(27) & "E" & " Indent By         			Supervisor          		Initials of Issues         			Received by " & Chr(27) & "F")
                    Filewrite.Write(Chr(12))
                End If
            Else
                MsgBox("IndentNo Not Issued")
            End If
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
    Private Function Print_Headers(ByVal pageheading() As String)
        Dim I, COLUMNCOUNT As Integer
        Dim CHECKEDITEMSNO As Integer
        'Dim Vheader() As String = {"THE HINDUSTHAN CLUB", "4/1,SARAT BOSE ROAD,", "KOLKATA-700020"}
        Dim Vheader() As String = {MyCompanyName, Address1, Address2}
        Dim head As String = "STOCK ISSUES"
        Dim x As String
        pagesize = 0
        Try
            'Filewrite.WriteLine(Chr(14) & Chr(15) & Space((123 - (Len(Vheader(0)))) / 2) & Vheader(0))
            Filewrite.WriteLine(Chr(27) & "E" & Chr(15) & Space(61 - Len(Trim(Vheader(0))) / 2) & Vheader(0))
            pagesize = pagesize + 1
            'Filewrite.Write(Space((123 - (Len(Vheader(1)))) / 2))
            'Filewrite.WriteLine(Vheader(1))
            'pagesize = pagesize + 1
            'Filewrite.Write(Space((123 - (Len(Vheader(2)))) / 2))
            'Filewrite.WriteLine(Vheader(2))
            'pagesize = pagesize + 1
            Filewrite.Write(Space((123 - (Len(head))) / 2))
            Filewrite.WriteLine(head)
            pagesize = pagesize + 1
            'Filewrite.Write(Space((123 - (Len(head))) / 2))
            'For I = 0 To head.Length
            '    Filewrite.Write("-")
            'Next
            'Filewrite.WriteLine()
        Catch ex As Exception
            Exit Function
        End Try
    End Function

    Private Function Print_Columnheaders(ByVal columnheading() As String, ByVal colsize() As Integer)
        Dim x As String
        Dim i As Integer
        i = 0
        For i = 0 To 123
            Filewrite.Write("-")
        Next
        Filewrite.WriteLine()
        pagesize = pagesize + 1
        i = 0
        For Each x In columnheading
            Filewrite.Write(x)
            If columnheading(i) = "QUANTITY" Then
                Filewrite.Write(Space(4))
                Filewrite.Write(Space(colsize(i) - Len(x)))

            Else
                Filewrite.Write(Space(colsize(i) - Len(x)))
            End If
            i = i + 1
        Next
        Filewrite.WriteLine()
        pagesize = pagesize + 1
        For i = 0 To 123
            Filewrite.Write("-")
        Next
        Filewrite.WriteLine()
        pagesize = pagesize + 1
    End Function
    Private Function Print_Grandtotals(ByVal captot As String, ByVal colsize() As Integer, ByVal total() As Double)
        Dim x, y As String
        Dim bool As Boolean
        Dim i, j As Integer
        i = 0
        For i = 0 To 123
            Filewrite.Write("-")
        Next
        Filewrite.WriteLine()
        pagesize = pagesize + 1
        Filewrite.Write(Trim(captot))
        Filewrite.Write(Space((colsize(0) + colsize(1) + colsize(2)) - (Len(Trim(captot)))))
        Filewrite.Write(Space(colsize(3) - Len(Trim(Format(total(0), "0.000"))) - 2))
        Filewrite.Write(Space(10))
        Filewrite.Write(Space(2))

        Filewrite.Write(Space(colsize(4) - Len(Trim(Format(total(1), "0.00"))) - 2))
        Filewrite.Write(Space(5))
        Filewrite.Write(Space(2))

        Filewrite.Write(Space(colsize(5) - Len(Trim(Format(total(2), "0.00"))) - 2))
        Filewrite.Write(Format(total(2), "0.00"))
        Filewrite.Write(Space(2))

        Filewrite.WriteLine()
        pagesize = pagesize + 1
        For i = 0 To 123
            Filewrite.Write("-")
        Next
        Filewrite.WriteLine()

        pagesize = pagesize + 1
    End Function
End Class
