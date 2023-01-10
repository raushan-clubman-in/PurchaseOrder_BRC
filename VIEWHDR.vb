'Imports System
'Imports System.Collections.Generic.i
'Imports System.ComponentModel
''Imports System.Data
'Imports System.Drawing
Imports System.Linq
'Imports System.Text
''Imports System.Windows.Forms
'Imports System.Configuration
'Imports System.IO
'Option Explicit On
'Option Strict On
Imports x = Microsoft.Office.Interop.Excel


Public Class VIEWHDR
    Dim CHECKCOL As New DataGridViewCheckBoxColumn
    Dim DETAIL As Boolean
    Dim VCONN As New GlobalClass
    Dim SSQL, KEYFIELD, FORMNAME As String
    Dim COLUMNSEQ As Integer
    Dim LD As Boolean
    Dim DataGridViewCheckBoxColumn As String
    Dim columnname, lastcol As String
    Public listbox As CheckedListBox
    Public boolSearchNext, boolSearchResult As Boolean
    Dim i As Integer

    Private Sub VIEWHDR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lastcol = ""
        'Call Load()
        'AppPath = Application.StartupPath
        'Call GetServer()
        'DTGRDHDR.DataSource = Nothing
        'DTGRDHDR.Rows.Clear()
        'Dim STRQUERY As String
        'STRQUERY = "SELECT *  FROM menumaster"
        'VCONN.getDataSet(STRQUERY, "MENUMASTER")
        'If gdataset.Tables("MENUMASTER").Rows.Count > 0 Then
        '    For I = 0 To gdataset.Tables("MENUMASTER").Rows.Count - 1
        '        'DTGRDHDR.Rows.Add()
        '        DTGRDHDR.Rows(I).Cells(0).Value = gdataset.Tables("MENUMASTER").Rows(I).Item(0).ToString
        '        DTGRDHDR.Rows(I).Cells(1).Value = gdataset.Tables("MENUMASTER").Rows(I).Item(1).ToString
        '        DTGRDHDR.Rows(I).Cells(2).Value = gdataset.Tables("MENUMASTER").Rows(I).Item(2).ToString
        '        DTGRDHDR.Rows(I).Cells(3).Value = gdataset.Tables("MENUMASTER").Rows(I).Item(3).ToString
        '        DTGRDHDR.Rows(I).Cells(4).Value = gdataset.Tables("MENUMASTER").Rows(I).Item(4).ToString
        '        DTGRDHDR.Rows(I).Cells(5).Value = gdataset.Tables("MENUMASTER").Rows(I).Item(5).ToString

        '    Next

        'End If
    End Sub
    'Public Sub GetServer()
    '    Dim ServerConn As New OleDb.OleDbConnection
    '    Dim servercmd As New OleDb.OleDbDataAdapter
    '    Dim getserver As New DataSet
    '    Dim sql, ssql As String
    '    sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
    '    sql = sql & AppPath & "\DBS_KEY.MDB"
    '    ServerConn.ConnectionString = sql
    '    Try
    '        ServerConn.Open()
    '        'Mk Kannan
    '        'Begin
    '        'UserName and Password is Added on 06 Oct'07
    '        ssql = "SELECT SERVER, UserName, Password, Company_ID,DATABASE FROM DBSKEY"
    '        'End
    '        servercmd = New OleDb.OleDbDataAdapter(ssql, ServerConn)
    '        servercmd.Fill(getserver)
    '        If getserver.Tables(0).Rows.Count > 0 Then
    '            gserver = Trim(getserver.Tables(0).Rows(0).Item(0) & "")
    '            'Mk Kannan
    '            'Begin
    '            'UserName and Password is Added on 06 Oct'07
    '            strDataSqlUsr = Trim(getserver.Tables(0).Rows(0).Item(1) & "")
    '            strDataSqlPwd = Trim(getserver.Tables(0).Rows(0).Item(2) & "")

    '            'End
    '            'Mk Kannan
    '            'Begin
    '            'Company ID is Added on 10 Dec'07
    '            strCompany_ID = Trim(getserver.Tables(0).Rows(0).Item(3) & "")
    '            gDatabase = Trim(getserver.Tables(0).Rows(0).Item(4) & "")
    '            'End
    '        Else
    '            MessageBox.Show("Failed to connect to Data Source")
    '            Me.Close()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Failed to connect to data source")
    '        MsgBox(ex.Message)
    '    Finally
    '        ServerConn.Close()
    '    End Try
    'End Sub
    Public Sub LOADGRID(ByVal DC As DataTable, ByVal DET As Boolean, ByVal FORMNM As String, ByVal SQL As String, ByVal KEYFILD As String, ByVal COLUMSEQ As Integer)
        LD = False
        DETAIL = DET
        SSQL = SQL
        KEYFIELD = KEYFILD
        COLUMNSEQ = COLUMSEQ
        FORMNAME = FORMNM


        If SSQL <> "" Then
            CHECKCOL.HeaderText = "SELECT"
            DTGRDHDR.Columns.Add(CHECKCOL)
        End If
        DTGRDHDR.DataSource = DC
        Dim J As Integer


        For J = 0 To DC.Columns.Count - 1
            cmbCol.Items.Add(DC.Columns(J).ColumnName).ToString()
        Next
        columnname = DTGRDHDR.Columns(1).HeaderText


        DTGRDHDR.EnableHeadersVisualStyles = False
        For i = 0 To DTGRDHDR.Columns.Count - 1
            DTGRDHDR.Columns(i).HeaderCell.Style.ForeColor = Color.Blue
            If i = 0 Then
            Else
                DTGRDHDR.Columns(i).ReadOnly = True
                'ComboBox1.Items.Add(DTGRDHDR.Columns.Item(i)).ToString()
            End If
        Next
        DTGRDHDR.Rows(1).Cells(1).Selected = True
        LD = False
    End Sub

    Private Sub DTGRDHDR_CellEnter(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DTGRDHDR_CellLeave(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DTGRDHDR_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DTGRDHDR_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Dim i, j As Integer
        If e.KeyCode = Keys.F4 Then
            j = DTGRDHDR.CurrentCellAddress.X
            For i = 0 To DTGRDHDR.RowCount - 1
                DTGRDHDR.Rows(i).Cells(j).Value = 1
            Next
        End If
        If e.KeyCode = Keys.F3 Then
            j = DTGRDHDR.CurrentCellAddress.X
            For i = 0 To DTGRDHDR.RowCount - 1
                DTGRDHDR.Rows(i).Cells(j).Value = 0
            Next
        End If
        If e.KeyCode = Keys.F11 Then
            Call CMD_CLEAR_Click(sender, e)
        End If
        If e.KeyCode = Keys.F12 Then
            Call Button2_Click(sender, e)
        End If
        If e.KeyCode = Keys.F9 Then
            Call cmdSearch_Click(sender, e)
        End If
        If e.KeyCode = Keys.F10 Then
            Call Button1_Click(sender, e)
        End If
        If e.KeyCode = Keys.F1 Then
            Dim K, L, MAXROWINDEX As Integer
            Dim FOC As String
            Dim intStringLength As Integer
            boolSearchResult = False
            MAXROWINDEX = 0
            Try

                If DTGRDHDR.Rows.Count > 0 Then
                    If cmbCol.Text <> "" And txtSearch.Text <> "" Then
                        If DTGRDHDR.SelectedRows.Count > 0 Then

                            For i = 0 To DTGRDHDR.SelectedRows.Count - 1
                                If DTGRDHDR.SelectedRows(i).Index > MAXROWINDEX Then
                                    MAXROWINDEX = DTGRDHDR.SelectedRows(i).Index
                                End If
                            Next

                            ' DTGRDHDR.Rows(i).Selected = True
                        End If
                        'For K = 0 To DTGRDHDR.Rows.Count - 1
                        '    If DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected = True Then
                        '        DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected = False
                        '        For L = K To DTGRDHDR.Rows.Count - 1
                        '            L = L + 1
                        '            If Trim(DTGRDHDR.Rows(L).Cells(cmbCol.Text).Value.ToString.ToUpper) = Trim(txtSearch.Text.ToUpper) Then
                        '                DTGRDHDR.Rows(L).Cells(cmbCol.Text).Selected = True
                        '                DTGRDHDR.FirstDisplayedScrollingRowIndex = L

                        '                DTGRDHDR.Focus()
                        '                Exit For
                        '            End If
                        '            L = L - 1
                        '        Next
                        '        Exit For
                        '    End If
                        'Next


                        ''For K = 0 To DTGRDHDR.Rows.Count - 1
                        ''    If DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected <> True Then




                        'DTGRDHDR.ClearSelection()

                        'For I = 0 To DTGRDHDR.Rows.Count - 1
                        '    DTGRDHDR.Rows(I).Cells(lastcol).Style.ForeColor = Color.Black
                        'Next

                        For i = MAXROWINDEX + 1 To DTGRDHDR.Rows.Count - 2
                            'farPoint.SelectedItem = farPoint.Items(I)
                            'farPoint.Col = farPoint.ActiveCol
                            intStringLength = Trim(DTGRDHDR.Rows(i).Cells(cmbCol.Text).Value.ToString.ToUpper).Length
                            For j = 0 To intStringLength - 1
                                If UCase(Mid(Trim(DTGRDHDR.Rows(i).Cells(cmbCol.Text).Value.ToString.ToUpper), j + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
                                    'farPoint.SelectedItem = farPoint.Items(I)
                                    boolSearchResult = True
                                    DTGRDHDR.Rows(i).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
                                    DTGRDHDR.Rows(i).Cells(cmbCol.Text).Selected = True
                                    DTGRDHDR.Rows(i).Selected = True
                                    FOC = DTGRDHDR.Rows(i).Cells(cmbCol.Text).Value.ToString()
                                    DTGRDHDR.FirstDisplayedScrollingRowIndex = i

                                    Me.DTGRDHDR.Focus()
                                    Exit For
                                End If
                            Next
                            If boolSearchResult = True Then
                                ' If CHK = True Then
                                '        With farPoint
                                '            farPoint.SelectedItem = farPoint.Items(I)
                                '            farPoint.SetItemChecked(I, True)

                                'End With
                                'End If
                                Exit For
                            End If
                        Next



                        '    If Trim(DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper) = Trim(txtSearch.Text.ToUpper) Then

                        '        DTGRDHDR.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
                        '        DTGRDHDR.Rows(I).Cells(cmbCol.Text).Selected = True
                        '        FOC = DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString()
                        '        DTGRDHDR.FirstDisplayedScrollingRowIndex = I
                        '        DTGRDHDR.Focus()
                        '        ' DTGRDHDR.Rows[DTGRDHDR.NewRowIndex].selected = True
                        '        'grp_browsehdr.Focus()
                        '        'cmbCol.Focus()
                        '        Exit Sub
                        '    End If

                        '    Next
                        'End If
                        'Next
                    End If

                End If

            Catch ex As Exception
                MsgBox(ex.Message, gCompanyname)
            End Try
        End If
    End Sub

    Private Sub DTGRDHDR_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub

    Friend Function Export(ByRef dgv As DataGridView, ByVal Path As String) As Boolean

        Dim xlWorkSheet As New x.Worksheet
        '; xlWorkSheet.SaveAs(Path, xlWorkSheet.xls, , )
        Dim misValue As Object = System.Reflection.Missing.Value



        Dim xlApp = New x.Application

        Dim xlWorkBook = xlApp.Workbooks.Add(misValue)

        xlWorkSheet = xlWorkBook.Sheets("sheet1")
        Dim ColNames As Generic.List(Of String) = (From col As DataGridViewColumn _
                                           In dgv.Columns.Cast(Of DataGridViewColumn)() _
                                           Where (col.Visible = True) _
                                           Order By col.DisplayIndex _
                                           Select col.Name).ToList
        Dim s As String
        Dim colcount = 0
        For Each s In ColNames
            colcount += 1
            xlWorkSheet.Cells(1, colcount) = dgv.Columns.Item(s).HeaderText
        Next
        'get the values
        Dim rowcount As Integer
        For rowcount = 0 To dgv.Rows.Count - 1  'for each row
            colcount = 0
            For Each s In ColNames 'for each column
                colcount += 1
                xlWorkSheet.Cells(rowcount + 2, colcount) = dgv.Rows(rowcount).Cells(s).Value
                'xlWorkSheet.Cells(rowcount + 2, colcount) = dgv.Rows(rowcount).Cells(s).FormattedValue
            Next
        Next
        Return True
        System.Diagnostics.Process.Start(Path & "\BOOK1.xlsx")
    End Function




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dgData As DataGridView = DirectCast(DTGRDHDR, DataGridView)
        With SaveExcelFileDialog
            .Filter = "Excel|*.xlsx"
            .Title = "Save griddata in Excel"
            If .ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                'Dim o As New ExcelExporter
                Dim b = exportnew(dgData, .FileName)
                MsgBox("EXPORT COMPLETED SUCCESSFULY")
            End If
            .Dispose()
        End With

    End Sub


    Private Function exportnew(ByRef dgv As DataGridView, ByVal Path As String) As Boolean
        Dim i, j As Integer
        Dim default_location As String = Path & ".xls"
        'Creating dataset to export
        Dim dset As New DataSet
        'add table to dataset
        dset.Tables.Add()
        'add column to that table
        For i = 0 To dgv.ColumnCount - 1
            dset.Tables(0).Columns.Add(dgv.Columns(i).HeaderText)
        Next
        'add rows to the table
        Dim dr1 As DataRow
        For i = 0 To dgv.RowCount - 1
            dr1 = dset.Tables(0).NewRow
            For j = 0 To dgv.Columns.Count - 1
                dr1(j) = dgv.Rows(i).Cells(j).Value
            Next
            dset.Tables(0).Rows.Add(dr1)
        Next

        Dim xp As New x.Application
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        xp.Visible = True
        xp.UserControl = True

        wBook = xp.Workbooks.Add(System.Reflection.Missing.Value)
        wSheet = wBook.Sheets("sheet1")
        xp.Range("A50:I50").EntireColumn.AutoFit()
        With wBook
            .Sheets("Sheet1").Select()
            .Sheets(1).Name = "NameYourSheet"
        End With

        Dim dt As System.Data.DataTable = dset.Tables(0)
        wSheet.Cells(1).value = Path
        ' Dim i As Integer
        Dim s As String
        Dim colcount = 0
        Dim ColNames As Generic.List(Of String) = (From col As DataGridViewColumn _
                                           In dgv.Columns.Cast(Of DataGridViewColumn)() _
                                           Where (col.Visible = True) _
                                           Order By col.DisplayIndex _
                                           Select col.Name).ToList
        For Each s In ColNames
            colcount += 1
            wSheet.Cells(1, colcount) = dgv.Columns.Item(s).HeaderText
        Next
        For i = 0 To dgv.RowCount - 2
            For j = 0 To dgv.ColumnCount - 2
                If IsDBNull(dgv.Rows(i).Cells(j).Value) = False Or dgv.Rows(i).Cells(j).Value IsNot Nothing Then
                    'If IsDBNull(dgv.Rows(i).Cells(j).Value) = True Or IsNothing(dgv.Rows(i).Cells(j).Value) Then
                    'Else
                    wSheet.Cells(i + 2, j + 1).value = dgv.Rows(i).Cells(j).Value.ToString()
                Else
                    wSheet.Cells(i + 2, j + 1).value = ""
                End If

            Next j
        Next i

        wSheet.Columns.AutoFit()
        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(default_location)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
        End Try

        If System.IO.File.Exists(default_location) Then
            System.IO.File.Delete(default_location)
        End If

        wBook.SaveAs(default_location)
        xp.Workbooks.Open(default_location)
        xp.Visible = True
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DTGRDHDR_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DTGRDHDR.CellClick
        Try
            TextBox1.Text = DTGRDHDR.CurrentCell.Value.ToString()
        Catch ex As Exception
            TextBox1.Text = ""
        End Try

    End Sub


    Private Sub DTGRDHDR_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DTGRDHDR.CellValueChanged
        If DTGRDHDR.CurrentCell.Value = True Then
            If DETAIL = True Then
                Dim DTLDET As New VIEWDET
                DTLDET.Show()
                Dim STRSQL As String
                Dim SSMS As String
                SSMS = DTGRDHDR.Rows(DTGRDHDR.CurrentCellAddress.Y).Cells(COLUMNSEQ).Value.ToString()
                STRSQL = SSQL & " WHERE " & KEYFIELD & " IN ('" & SSMS & "')"
                STRSQL = STRSQL & M_ORDERBY
                M_ORDERBY = ""
                VCONN.getDataSet(STRSQL, "DETAILS")
                DTLDET.LOADDATA(gdataset.Tables("DETAILS"), False, "MENUMASTER", STRSQL, "SERIALNO", 1)
                DTGRDHDR.Rows(DTGRDHDR.CurrentCellAddress.Y).Cells(0).Value = False
            End If
        End If
    End Sub

    Private Sub DTGRDHDR_ColumnStateChanged1(sender As Object, e As DataGridViewColumnStateChangedEventArgs) Handles DTGRDHDR.ColumnStateChanged
        If LD = True Then
            If DETAIL = True Then
                Dim DTLDET As New VIEWDET
                DTLDET.Show()
                Dim STRSQL As String
                Dim SSMS As String
                SSMS = DTGRDHDR.Rows(DTGRDHDR.CurrentCellAddress.Y).Cells(COLUMNSEQ).Value.ToString()
                STRSQL = SSQL & " WHERE " & KEYFIELD & " IN ('" & SSMS & "')"
                VCONN.getDataSet(STRSQL, "DETAILS")
                DTLDET.LOADDATA(gdataset.Tables("DETAILS"), False, "MENUMASTER", STRSQL, "SERIALNO", 1)
                DTGRDHDR.Rows(DTGRDHDR.CurrentCellAddress.Y).Cells(COLUMNSEQ).Value = False
            End If
        End If
    End Sub


    'Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        ' cmdSearch_Click(sender, e)
    '        If Len(txtSearch.Text) = 0 Then
    '            MessageBox.Show("Search Text Cann't Be Blank")
    '            Exit Sub
    '        End If
    '        Dim intStringLength, i, j As Integer
    '        Dim rowindex As String
    '        boolSearchResult = False
    '        'For Each row As DataGridViewRow In DTGRDHDR.Rows
    '        '    If (row.Cells.Item(columnname).Value Like "%" & Trim(txtSearch.Text) & "%") Then

    '        '        If (row.Cells.Item(columnname).Value.ToString().Contains(txtSearch.Text)) Then
    '        '            rowindex = row.Index.ToString()
    '        '            DTGRDHDR.Rows(rowindex).Selected = True
    '        '            Dim actie As String = row.Cells("pono").Value.ToString()
    '        '            MsgBox(rowindex)
    '        '            If actie <> "" Then
    '        '                DTGRDHDR.CurrentCell.Selected = True
    '        '                DTGRDHDR.CurrentCell = DTGRDHDR.SelectedCells(0)
    '        '                Exit For
    '        '            End If
    '        '            'DTGRDHDR.Rows(actie)

    '        '        Else

    '        '            MsgBox("Item not found")

    '        '        End If
    '        '    End If
    '        'Next
    '        For i = 0 To DTGRDHDR.Rows.Count - 1
    '            'farPoint.SelectedItem = farPoint.Items(I)
    '            'farPoint.Col = farPoint.ActiveCol
    '            intStringLength = Trim(DTGRDHDR.Rows(i).Cells(cmbCol.Text).Value.ToString.ToUpper).Length
    '            For J = 0 To intStringLength - 1
    '                If UCase(Mid(Trim(DTGRDHDR.Rows(i).Cells(cmbCol.Text).Value.ToString.ToUpper), J + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
    '                    'farPoint.SelectedItem = farPoint.Items(I)
    '                    boolSearchResult = True
    '                    DTGRDHDR.Rows(i).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
    '                    DTGRDHDR.Rows(i).Cells(cmbCol.Text).Selected = True
    '                    ' FOC = DTGRDHDR.Rows(i).Cells(cmbCol.Text).Value.ToString()
    '                    DTGRDHDR.FirstDisplayedScrollingRowIndex = i
    '                    DTGRDHDR.Focus()
    '                    Exit For
    '                End If
    '            Next
    '            If boolSearchResult = True Then
    '                ' If CHK = True Then
    '                '        With farPoint
    '                '            farPoint.SelectedItem = farPoint.Items(I)
    '                '            farPoint.SetItemChecked(I, True)

    '                'End With
    '                'End If
    '                Exit For
    '            End If
    '        Next



    '        'Dim STR As String
    '        'Dim J As Integer
    '        'STR = txtSearch.Text
    '        'For i As Integer = 0 To DTGRDHDR.Rows.Count - 2
    '        '    For J = 1 To Me.DTGRDHDR.Rows(i).Cells.Count - 2
    '        '        If DTGRDHDR.Item(J, i).Value.ToString() = STR Then
    '        '            DTGRDHDR.Rows(i).Selected = True
    '        '            DTGRDHDR.CurrentCell = DTGRDHDR.Rows(i).Cells(J)
    '        '            Exit For
    '        '        End If
    '        '    Next
    '        '    If DTGRDHDR.Item(j, i).Value.ToString() = STR Then
    '        '        Exit For
    '        '    End If
    '        'Next i
    '        'DTGRDHDR.Focus()
    '        'If Not DTGRDHDR.CurrentRow.Index = DTGRDHDR.Rows.Count - 1 Then
    '        '    If Not DTGRDHDR.CurrentRow.Index = -1 Then
    '        '        DTGRDHDR.CurrentCell = DTGRDHDR.Rows(DTGRDHDR.CurrentRow.Index + 1).Cells(0)
    '        '    Else
    '        '        DTGRDHDR.CurrentCell = DTGRDHDR.Rows(DTGRDHDR.CurrentRow.Index).Cells(0)
    '        '    End If
    '        'End If
    '    End If
    'End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        Dim I, J, K, L As Integer
        Dim FOC As String
        Dim intStringLength As Integer
        'Dim colvalue As String
        boolSearchResult = False
        Try

            If DTGRDHDR.Rows.Count > 0 Then
                If cmbCol.Text <> "" And txtSearch.Text <> "" Then

                    'For K = 0 To DTGRDHDR.Rows.Count - 1
                    '    If DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected = True Then
                    '        DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected = False
                    '        For L = K To DTGRDHDR.Rows.Count - 1
                    '            L = L + 1
                    '            If Trim(DTGRDHDR.Rows(L).Cells(cmbCol.Text).Value.ToString.ToUpper) = Trim(txtSearch.Text.ToUpper) Then
                    '                DTGRDHDR.Rows(L).Cells(cmbCol.Text).Selected = True
                    '                DTGRDHDR.FirstDisplayedScrollingRowIndex = L

                    '                DTGRDHDR.Focus()
                    '                Exit For
                    '            End If
                    '            L = L - 1
                    '        Next
                    '        Exit For
                    '    End If
                    'Next


                    ''For K = 0 To DTGRDHDR.Rows.Count - 1
                    ''    If DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected <> True Then




                    DTGRDHDR.ClearSelection()

                    'For I = 0 To DTGRDHDR.Rows.Count - 1
                    'DTGRDHDR.Rows(I).Cells(lastcol).Style.ForeColor = Color.Black
                    ' Next

                    For I = 0 To DTGRDHDR.Rows.Count - 1
                        'farPoint.SelectedItem = farPoint.Items(I)
                        'farPoint.Col = farPoint.ActiveCol


                        'modified
                        intStringLength = Trim(DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper).Length


                        'colvalue = Trim(DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper)

                        'modified
                        For J = 0 To intStringLength - 1



                            If UCase(Mid(Trim(DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper), J + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
                                'farPoint.SelectedItem = farPoint.Items(I)


                                ' If colvalue.Contains(txtSearch.Text) Then




                                boolSearchResult = True
                                DTGRDHDR.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
                                DTGRDHDR.Rows(I).Cells(cmbCol.Text).Selected = True
                                DTGRDHDR.Rows(I).Selected = True
                                FOC = DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString()
                                DTGRDHDR.FirstDisplayedScrollingRowIndex = I

                                Me.DTGRDHDR.Focus()
                                Exit For
                            End If


                            'modified
                        Next


                        If boolSearchResult = True Then
                            ' If CHK = True Then
                            '        With farPoint
                            '            farPoint.SelectedItem = farPoint.Items(I)
                            '            farPoint.SetItemChecked(I, True)

                            'End With
                            'End If
                            Exit For
                        End If
                    Next



                    '    If Trim(DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper) = Trim(txtSearch.Text.ToUpper) Then

                    '        DTGRDHDR.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
                    '        DTGRDHDR.Rows(I).Cells(cmbCol.Text).Selected = True
                    '        FOC = DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString()
                    '        DTGRDHDR.FirstDisplayedScrollingRowIndex = I
                    '        DTGRDHDR.Focus()
                    '        ' DTGRDHDR.Rows[DTGRDHDR.NewRowIndex].selected = True
                    '        'grp_browsehdr.Focus()
                    '        'cmbCol.Focus()
                    '        Exit Sub
                    '    End If

                    '    Next
                    'End If
                    'Next
                End If

            End If

        Catch ex As Exception
            MessageBox.Show("Plz Check Error" + ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    'Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
    '    Dim I, J, intStringLength As Integer
    '    Try
    '        If DTGRDHDR.Rows.Count > 0 Then

    '            If cmbCol.Text <> "" And txtSearch.Text <> "" Then

    '                DTGRDHDR.ClearSelection()
    '                If lastcol <> "" Then
    '                    For I = 0 To DTGRDHDR.Rows.Count - 1
    '                        DTGRDHDR.Rows(I).Cells(lastcol).Style.ForeColor = Color.Black
    '                    Next
    '                End If

    '                For I = 0 To DTGRDHDR.Rows.Count - 1
    '                    DTGRDHDR.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.Black
    '                Next

    '                For I = 0 To DTGRDHDR.Rows.Count - 1
    '                    'farPoint.SelectedItem = farPoint.Items(I)
    '                    'farPoint.Col = farPoint.ActiveCol
    '                    intStringLength = Trim(DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper).Length
    '                    For J = 0 To intStringLength - 1
    '                        If UCase(Mid(Trim(DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper), J + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
    '                            'farPoint.SelectedItem = farPoint.Items(I)
    '                            boolSearchResult = True
    '                            DTGRDHDR.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
    '                            DTGRDHDR.Rows(I).Cells(cmbCol.Text).Selected = True
    '                            'FOC = DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString()
    '                            DTGRDHDR.FirstDisplayedScrollingRowIndex = I
    '                            DTGRDHDR.Focus()
    '                            Exit For
    '                        End If
    '                    Next
    '                    If boolSearchResult = True Then
    '                        ' If CHK = True Then
    '                        '        With farPoint
    '                        '            farPoint.SelectedItem = farPoint.Items(I)
    '                        '            farPoint.SetItemChecked(I, True)

    '                        'End With
    '                        'End If
    '                        Exit For
    '                    End If
    '                Next



    '                ' lastcol = cmbCol.Text
    '            End If

    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, gCompanyname)
    '    End Try

    'End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim I, J, K, L As Integer
            Dim FOC As String
            Dim intStringLength As Integer
            boolSearchResult = False
            Try

                If DTGRDHDR.Rows.Count > 0 Then
                    If cmbCol.Text <> "" And txtSearch.Text <> "" Then

                        'For K = 0 To DTGRDHDR.Rows.Count - 1
                        '    If DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected = True Then
                        '        DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected = False
                        '        For L = K To DTGRDHDR.Rows.Count - 1
                        '            L = L + 1
                        '            If Trim(DTGRDHDR.Rows(L).Cells(cmbCol.Text).Value.ToString.ToUpper) = Trim(txtSearch.Text.ToUpper) Then
                        '                DTGRDHDR.Rows(L).Cells(cmbCol.Text).Selected = True
                        '                DTGRDHDR.FirstDisplayedScrollingRowIndex = L

                        '                DTGRDHDR.Focus()
                        '                Exit For
                        '            End If
                        '            L = L - 1
                        '        Next
                        '        Exit For
                        '    End If
                        'Next


                        ''For K = 0 To DTGRDHDR.Rows.Count - 1
                        ''    If DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected <> True Then




                        'DTGRDHDR.ClearSelection()

                        'For I = 0 To DTGRDHDR.Rows.Count - 1
                        '    DTGRDHDR.Rows(I).Cells(lastcol).Style.ForeColor = Color.Black
                        'Next

                        For I = DTGRDHDR.CurrentRow.Index + 1 To DTGRDHDR.Rows.Count - 1
                            'farPoint.SelectedItem = farPoint.Items(I)
                            'farPoint.Col = farPoint.ActiveCol
                            intStringLength = Trim(DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper).Length
                            For J = 0 To intStringLength - 1
                                If UCase(Mid(Trim(DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper), J + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
                                    'farPoint.SelectedItem = farPoint.Items(I)
                                    boolSearchResult = True
                                    DTGRDHDR.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
                                    DTGRDHDR.Rows(I).Cells(cmbCol.Text).Selected = True
                                    DTGRDHDR.Rows(I).Selected = True
                                    FOC = DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString()
                                    DTGRDHDR.FirstDisplayedScrollingRowIndex = I
                                    Me.DTGRDHDR.Focus()
                                    Exit For
                                End If
                            Next
                            If boolSearchResult = True Then
                                ' If CHK = True Then
                                '        With farPoint
                                '            farPoint.SelectedItem = farPoint.Items(I)
                                '            farPoint.SetItemChecked(I, True)

                                'End With
                                'End If
                                Exit For
                            End If
                        Next



                        '    If Trim(DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper) = Trim(txtSearch.Text.ToUpper) Then

                        '        DTGRDHDR.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
                        '        DTGRDHDR.Rows(I).Cells(cmbCol.Text).Selected = True
                        '        FOC = DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString()
                        '        DTGRDHDR.FirstDisplayedScrollingRowIndex = I
                        '        DTGRDHDR.Focus()
                        '        ' DTGRDHDR.Rows[DTGRDHDR.NewRowIndex].selected = True
                        '        'grp_browsehdr.Focus()
                        '        'cmbCol.Focus()
                        '        Exit Sub
                        '    End If

                        '    Next
                        'End If
                        'Next
                    End If

                End If

            Catch ex As Exception
                MsgBox(ex.Message, gCompanyname)
            End Try


        End If
        'If Asc(e.KeyChar) = 13 Then
        '    ' cmdSearch_Click(sender, e)
        '    If Len(txtSearch.Text) = 0 Then
        '        MessageBox.Show("Search Text Cann't Be Blank")
        '        Exit Sub
        '    End If
        '    Dim i, j, init, intStringLength, intStringLength1 As Integer
        '    Dim Item(), icode As String
        '    If DTGRDHDR.Rows.Count > 2 Then
        '        boolSearchResult = False
        '        If boolSearchNext = False Then
        '            init = 0
        '        Else
        '            init = listbox.SelectedIndex + 1
        '        End If
        '        For i = init To DTGRDHDR.Rows.Count - 1
        '            icode = cmbCol.Text
        '            Item = DTGRDHDR.Rows(i).Item("icode")
        '            '------------ checking itemCode
        '            intStringLength = Item(0).Length
        '            For j = 0 To intStringLength - 1
        '                If UCase(Mid(Trim(Item(0)), j + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
        '                    listbox.SetSelected(i, True)
        '                    boolSearchResult = True
        '                    grp_browsehdr.Focus()
        '                    Exit For
        '                End If
        '            Next
        '            If boolSearchResult = True Then
        '                Exit For
        '            End If
        '            '------------ checking itemName
        '            If Item.Length = 2 Then
        '                intStringLength1 = Item(1).Length
        '                For j = 0 To intStringLength1 - 1
        '                    If UCase(Mid(Trim(Item(1)), j + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
        '                        listbox.SetSelected(i, True)
        '                        boolSearchResult = True
        '                        grp_browsehdr.Focus()
        '                        Exit For
        '                    End If
        '                Next
        '            End If
        '        Next
        '        If boolSearchResult = False Then
        '            MsgBox("Reached End of List ...", MsgBoxStyle.OkOnly, Application.ProductName)
        '            txtSearch.Focus()
        '            Exit Sub
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub grp_browsehdr_Enter(sender As Object, e As EventArgs) Handles grp_browsehdr.Enter

    End Sub



    Private Sub DTGRDHDR_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DTGRDHDR.CellContentClick
        Try
            TextBox1.Text = DTGRDHDR.CurrentCell.Value.ToString()
        Catch ex As Exception
            TextBox1.Text = ""
        End Try

    End Sub





    Private Sub DTGRDHDR_Enter(sender As Object, e As DataGridViewCellEventArgs)
        Dim I, J, K, L As Integer
        Dim FOC As String
        Dim intStringLength As Integer
        boolSearchResult = False
        Try

            If DTGRDHDR.Rows.Count > 0 Then
                If cmbCol.Text <> "" And txtSearch.Text <> "" Then

                    'For K = 0 To DTGRDHDR.Rows.Count - 1
                    '    If DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected = True Then
                    '        DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected = False
                    '        For L = K To DTGRDHDR.Rows.Count - 1
                    '            L = L + 1
                    '            If Trim(DTGRDHDR.Rows(L).Cells(cmbCol.Text).Value.ToString.ToUpper) = Trim(txtSearch.Text.ToUpper) Then
                    '                DTGRDHDR.Rows(L).Cells(cmbCol.Text).Selected = True
                    '                DTGRDHDR.FirstDisplayedScrollingRowIndex = L

                    '                DTGRDHDR.Focus()
                    '                Exit For
                    '            End If
                    '            L = L - 1
                    '        Next
                    '        Exit For
                    '    End If
                    'Next


                    ''For K = 0 To DTGRDHDR.Rows.Count - 1
                    ''    If DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected <> True Then




                    'DTGRDHDR.ClearSelection()

                    'For I = 0 To DTGRDHDR.Rows.Count - 1
                    '    DTGRDHDR.Rows(I).Cells(lastcol).Style.ForeColor = Color.Black
                    'Next

                    For I = DTGRDHDR.CurrentRow.Index + 1 To DTGRDHDR.Rows.Count - 1
                        'farPoint.SelectedItem = farPoint.Items(I)
                        'farPoint.Col = farPoint.ActiveCol
                        intStringLength = Trim(DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper).Length
                        For J = 0 To intStringLength - 1
                            If UCase(Mid(Trim(DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper), J + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
                                'farPoint.SelectedItem = farPoint.Items(I)
                                boolSearchResult = True
                                DTGRDHDR.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
                                DTGRDHDR.Rows(I).Cells(cmbCol.Text).Selected = True
                                DTGRDHDR.Rows(I).Selected = True
                                FOC = DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString()
                                DTGRDHDR.FirstDisplayedScrollingRowIndex = I

                                Me.DTGRDHDR.Focus()
                                Exit For
                            End If
                        Next
                        If boolSearchResult = True Then
                            ' If CHK = True Then
                            '        With farPoint
                            '            farPoint.SelectedItem = farPoint.Items(I)
                            '            farPoint.SetItemChecked(I, True)

                            'End With
                            'End If
                            Exit For
                        End If
                    Next



                    '    If Trim(DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper) = Trim(txtSearch.Text.ToUpper) Then

                    '        DTGRDHDR.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
                    '        DTGRDHDR.Rows(I).Cells(cmbCol.Text).Selected = True
                    '        FOC = DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString()
                    '        DTGRDHDR.FirstDisplayedScrollingRowIndex = I
                    '        DTGRDHDR.Focus()
                    '        ' DTGRDHDR.Rows[DTGRDHDR.NewRowIndex].selected = True
                    '        'grp_browsehdr.Focus()
                    '        'cmbCol.Focus()
                    '        Exit Sub
                    '    End If

                    '    Next
                    'End If
                    'Next
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, gCompanyname)
        End Try
    End Sub


    Private Sub CMD_CLEAR_Click(sender As Object, e As EventArgs) Handles CMD_CLEAR.Click
        Try
            'Dim CHECKCOL As New DataGridViewCheckBoxColumn
            If DTGRDHDR.Rows.Count > 0 Then
                For i = 0 To DTGRDHDR.Rows.Count - 1
                    'Dim CHECKCOL As New DataGridViewCheckBoxColumn
                    'CHECKCOL.HeaderText = "SELECT"
                    'DTGRDHDR.Columns.Add(CHECKCOL)
                    'DTGRDHDR.Columns = False

                    'DTGRDHDR.Rows(i).Cells(0).Value = 0
                    'DTGRDHDR.Columns(CHECKCOL) = False
                    'DTGRDHDR.Columns(i).Selected = False
                    DTGRDHDR.Rows(i).Selected = False
                    'If DTGRDHDR.Columns(i).Selected = True Then
                    '    DTGRDHDR.Columns.Remove(CHECKCOL)
                    '    DTGRDHDR.Columns.Add(CHECKCOL)
                    'End If
                Next
            End If
            DTGRDHDR.FirstDisplayedScrollingRowIndex = 1
        Catch ex As Exception
            MessageBox.Show("Plz check error" + ex.Message, gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DTGRDHDR_SelectionChanged(sender As Object, e As EventArgs) Handles DTGRDHDR.SelectionChanged
        If LD = True Then
            'TextBox1.Text = IsDBNull(DTGRDHDR.CurrentCell.Value.ToString())
        End If
    End Sub
End Class