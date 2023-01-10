Imports System.Linq
Imports x = Microsoft.Office.Interop.Excel
Public Class VIEWDET
    Dim columnname, lastcol As String
    Public boolSearchNext, boolSearchResult As Boolean

    Private Sub VIEWDET_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim i, j As Integer
        If e.KeyCode = Keys.F4 Then
            j = DGVDET.CurrentCellAddress.X
            For i = 0 To DGVDET.RowCount - 1
                DGVDET.Rows(i).Cells(j).Value = 1
            Next
        End If
        If e.KeyCode = Keys.F3 Then
            j = DGVDET.CurrentCellAddress.X
            For i = 0 To DGVDET.RowCount - 1
                DGVDET.Rows(i).Cells(j).Value = 0
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

                If DGVDET.Rows.Count > 0 Then
                    If cmbCol.Text <> "" And txtSearch.Text <> "" Then
                        If DGVDET.SelectedRows.Count > 0 Then

                            For i = 0 To DGVDET.SelectedRows.Count - 1
                                If DGVDET.SelectedRows(i).Index > MAXROWINDEX Then
                                    MAXROWINDEX = DGVDET.SelectedRows(i).Index
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

                        For i = MAXROWINDEX + 1 To DGVDET.Rows.Count - 2
                            'farPoint.SelectedItem = farPoint.Items(I)
                            'farPoint.Col = farPoint.ActiveCol
                            intStringLength = Trim(DGVDET.Rows(i).Cells(cmbCol.Text).Value.ToString.ToUpper).Length
                            For j = 0 To intStringLength - 1
                                If UCase(Mid(Trim(DGVDET.Rows(i).Cells(cmbCol.Text).Value.ToString.ToUpper), j + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
                                    'farPoint.SelectedItem = farPoint.Items(I)
                                    boolSearchResult = True
                                    DGVDET.Rows(i).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
                                    DGVDET.Rows(i).Cells(cmbCol.Text).Selected = True
                                    DGVDET.Rows(i).Selected = True
                                    FOC = DGVDET.Rows(i).Cells(cmbCol.Text).Value.ToString()
                                    DGVDET.FirstDisplayedScrollingRowIndex = i

                                    Me.DGVDET.Focus()
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
    Private Sub VIEWDET_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub LOADDATA(ByVal DC As DataTable, ByVal DET As Boolean, ByVal FORMNAME As String, ByVal SQL As String, ByVal KEYFILD As String, ByVal COLUMNSEQ As Integer)
        Try

            lastcol = ""
            DGVDET.DataSource = DC
            'Dim CHECKCOL As New DataGridViewCheckBoxColumn
            'CHECKCOL.HeaderText = "SELECT"
            'DGVDET.Columns.Add(CHECKCOL)


            Dim J As Integer
            For J = 0 To DC.Columns.Count - 1
                cmbCol.Items.Add(DC.Columns(J).ColumnName).ToString()
            Next

        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click
        'Dim I, J As Integer

        'Try

        '    If DGVDET.Rows.Count > 0 Then
        '        If cmbCol.Text <> "" And txtSearch.Text <> "" Then
        '            DGVDET.ClearSelection()

        '            For I = 0 To DGVDET.Rows.Count - 1
        '                DGVDET.Rows(I).Cells(lastcol).Style.ForeColor = Color.Black
        '            Next

        '            For I = 0 To DGVDET.Rows.Count - 1

        '                If Trim(DGVDET.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper) = Trim(txtSearch.Text.ToUpper) Then

        '                    DGVDET.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
        '                    DGVDET.Rows(I).Cells(cmbCol.Text).Selected = True
        '                    DGVDET.Focus()
        '                    Exit Sub
        '                End If

        '            Next

        '        End If

        '    End If



        'Catch ex As Exception
        '    MsgBox(ex.Message, gCompanyname)
        'End Try
        Dim I, J, K, L As Integer
        Dim FOC As String
        Dim intStringLength As Integer
        boolSearchResult = False
        Try

            If DGVDET.Rows.Count > 0 Then
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




                    DGVDET.ClearSelection()

                    For I = 0 To DGVDET.Rows.Count - 1
                        DGVDET.Rows(I).Cells(lastcol).Style.ForeColor = Color.Black
                    Next

                    For I = 0 To DGVDET.Rows.Count - 1
                        'farPoint.SelectedItem = farPoint.Items(I)
                        'farPoint.Col = farPoint.ActiveCol
                        intStringLength = Trim(DGVDET.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper).Length
                        For J = 0 To intStringLength - 1
                            If UCase(Mid(Trim(DGVDET.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper), J + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
                                'farPoint.SelectedItem = farPoint.Items(I)
                                boolSearchResult = True
                                DGVDET.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
                                DGVDET.Rows(I).Cells(cmbCol.Text).Selected = True
                                DGVDET.Rows(I).Selected = True
                                FOC = DGVDET.Rows(I).Cells(cmbCol.Text).Value.ToString()
                                DGVDET.FirstDisplayedScrollingRowIndex = I

                                Me.DGVDET.Focus()
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

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        'If Asc(e.KeyChar) = 13 Then
        '    Dim I, J, K, L As Integer
        '    Dim FOC As String
        '    Dim intStringLength As Integer
        '    boolSearchResult = False
        '    Try

        '        If DGVDET.Rows.Count > 0 Then
        '            If cmbCol.Text <> "" And txtSearch.Text <> "" Then

        '                'For K = 0 To DTGRDHDR.Rows.Count - 1
        '                '    If DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected = True Then
        '                '        DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected = False
        '                '        For L = K To DTGRDHDR.Rows.Count - 1
        '                '            L = L + 1
        '                '            If Trim(DTGRDHDR.Rows(L).Cells(cmbCol.Text).Value.ToString.ToUpper) = Trim(txtSearch.Text.ToUpper) Then
        '                '                DTGRDHDR.Rows(L).Cells(cmbCol.Text).Selected = True
        '                '                DTGRDHDR.FirstDisplayedScrollingRowIndex = L

        '                '                DTGRDHDR.Focus()
        '                '                Exit For
        '                '            End If
        '                '            L = L - 1
        '                '        Next
        '                '        Exit For
        '                '    End If
        '                'Next


        '                ''For K = 0 To DTGRDHDR.Rows.Count - 1
        '                ''    If DTGRDHDR.Rows(K).Cells(cmbCol.Text).Selected <> True Then




        '                'DTGRDHDR.ClearSelection()

        '                'For I = 0 To DTGRDHDR.Rows.Count - 1
        '                '    DTGRDHDR.Rows(I).Cells(lastcol).Style.ForeColor = Color.Black
        '                'Next

        '                For I = DGVDET.CurrentRow.Index + 1 To DGVDET.Rows.Count - 1
        '                    'farPoint.SelectedItem = farPoint.Items(I)
        '                    'farPoint.Col = farPoint.ActiveCol
        '                    intStringLength = Trim(DGVDET.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper).Length
        '                    For J = 0 To intStringLength - 1
        '                        If UCase(Mid(Trim(DGVDET.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper), J + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
        '                            'farPoint.SelectedItem = farPoint.Items(I)
        '                            boolSearchResult = True
        '                            DGVDET.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
        '                            DGVDET.Rows(I).Cells(cmbCol.Text).Selected = True
        '                            DGVDET.Rows(I).Selected = True
        '                            FOC = DGVDET.Rows(I).Cells(cmbCol.Text).Value.ToString()
        '                            DGVDET.FirstDisplayedScrollingRowIndex = I
        '                            Me.DGVDET.Focus()
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



        '                '    If Trim(DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper) = Trim(txtSearch.Text.ToUpper) Then

        '                '        DTGRDHDR.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
        '                '        DTGRDHDR.Rows(I).Cells(cmbCol.Text).Selected = True
        '                '        FOC = DTGRDHDR.Rows(I).Cells(cmbCol.Text).Value.ToString()
        '                '        DTGRDHDR.FirstDisplayedScrollingRowIndex = I
        '                '        DTGRDHDR.Focus()
        '                '        ' DTGRDHDR.Rows[DTGRDHDR.NewRowIndex].selected = True
        '                '        'grp_browsehdr.Focus()
        '                '        'cmbCol.Focus()
        '                '        Exit Sub
        '                '    End If

        '                '    Next
        '                'End If
        '                'Next
        '            End If

        '        End If

        '    Catch ex As Exception
        '        MsgBox(ex.Message, gCompanyname)
        '    End Try


        'End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim I, J As Integer
        Try
            If DGVDET.Rows.Count > 0 Then

                If cmbCol.Text <> "" And txtSearch.Text <> "" Then

                    DGVDET.ClearSelection()
                    If lastcol <> "" Then
                        For I = 0 To DGVDET.Rows.Count - 1
                            DGVDET.Rows(I).Cells(lastcol).Style.ForeColor = Color.Black
                        Next
                    End If

                    For I = 0 To DGVDET.Rows.Count - 1
                        DGVDET.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.Black
                    Next

                    For I = 0 To DGVDET.Rows.Count - 2

                        If DGVDET.Rows(I).Cells(cmbCol.Text).Value Is DBNull.Value = False Then
                            If Mid(Trim(DGVDET.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper), 1, txtSearch.Text.Length) = Trim(txtSearch.Text.ToUpper) Then

                                DGVDET.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.Red
                                'DTGRDHDR.Rows(I).Cells(cmbCol.Text).Selected = True
                                'Exit Sub
                            End If
                        End If

                    Next

                    lastcol = cmbCol.Text
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, gCompanyname)
        End Try

    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    Dim rowindex As String
        '    For Each row As DataGridViewRow In DGVDET.Rows
        '        If (row.Cells.Item(columnname).Value Like txtSearch.Text) Then

        '            If (row.Cells.Item(columnname).Value.ToString().Contains(txtSearch.Text)) Then
        '                rowindex = row.Index.ToString()
        '                DGVDET.Rows(rowindex).Selected = True
        '                'Dim actie As String = row.Cells("pono").Value.ToString()
        '                'MsgBox(rowindex)
        '                'If actie <> "" Then
        '                '    DTGRDHDR.CurrentCell.Selected = True
        '                '    DTGRDHDR.CurrentCell = DTGRDHDR.SelectedCells(0)
        '                'Exit For
        '                'End If
        '                ''DTGRDHDR.Rows(actie)

        '            Else

        '                'MsgBox("Item not found")

        '            End If
        '        End If
        '    Next
        '    'Dim STR As String
        '    'Str = TextBox1.Text
        '    'For i As Integer = 0 To DTGRDHDR.Rows.Count - 1
        '    '    For j As Integer = 0 To Me.DTGRDHDR.Rows(i).Cells.Count - 1
        '    '        If DTGRDHDR.Item(j, i).Value.ToString() = STR Then
        '    '            DTGRDHDR.Rows(i).Selected = True
        '    '            DTGRDHDR.CurrentCell = DTGRDHDR.Rows(i).Cells(j)

        '    '        End If
        '    '    Next
        '    'Next i
        '    ''DTGRDHDR.Focus()
        '    ''If Not DTGRDHDR.CurrentRow.Index = DTGRDHDR.Rows.Count - 1 Then
        '    ''    If Not DTGRDHDR.CurrentRow.Index = -1 Then
        '    ''        DTGRDHDR.CurrentCell = DTGRDHDR.Rows(DTGRDHDR.CurrentRow.Index + 1).Cells(0)
        '    ''    Else
        '    ''        DTGRDHDR.CurrentCell = DTGRDHDR.Rows(DTGRDHDR.CurrentRow.Index).Cells(0)
        '    ''    End If
        '    ''End If
        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dgData As DataGridView = DirectCast(DGVDET, DataGridView)
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

    Private Sub DGVDET_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDET.CellClick
        Try
            TextBox1.Text = DGVDET.CurrentCell.Value.ToString()
        Catch ex As Exception
            TextBox1.Text = ""
        End Try
    End Sub

    Private Sub DGVDET_Enter(sender As Object, e As EventArgs) Handles DGVDET.Enter
        Dim I, J, K, L As Integer
        Dim FOC As String
        Dim intStringLength As Integer
        boolSearchResult = False
        Try

            If DGVDET.Rows.Count > 0 Then
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

                    For I = DGVDET.CurrentRow.Index + 1 To DGVDET.Rows.Count - 1
                        'farPoint.SelectedItem = farPoint.Items(I)
                        'farPoint.Col = farPoint.ActiveCol
                        intStringLength = Trim(DGVDET.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper).Length
                        For J = 0 To intStringLength - 1
                            If UCase(Mid(Trim(DGVDET.Rows(I).Cells(cmbCol.Text).Value.ToString.ToUpper), J + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
                                'farPoint.SelectedItem = farPoint.Items(I)
                                boolSearchResult = True
                                DGVDET.Rows(I).Cells(cmbCol.Text).Style.ForeColor = Color.IndianRed
                                DGVDET.Rows(I).Cells(cmbCol.Text).Selected = True
                                DGVDET.Rows(I).Selected = True
                                FOC = DGVDET.Rows(I).Cells(cmbCol.Text).Value.ToString()
                                DGVDET.FirstDisplayedScrollingRowIndex = I

                                Me.DGVDET.Focus()
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
            Dim i As Integer
            If DGVDET.Rows.Count > 0 Then
                For i = 0 To DGVDET.Rows.Count - 1
                    DGVDET.Rows(i).Selected = False
                Next
            End If
            DGVDET.FirstDisplayedScrollingRowIndex = 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGVDET_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDET.CellValueChanged
        'If DGVDET.CurrentCell.Value = True Then
        '    If DETAIL = True Then
        '        Dim DTLDET As New VIEWDET
        '        DTLDET.Show()
        '        Dim STRSQL As String
        '        Dim SSMS As String
        '        SSMS = DTGRDHDR.Rows(DTGRDHDR.CurrentCellAddress.Y).Cells(COLUMNSEQ).Value.ToString()
        '        STRSQL = ssql & " WHERE " & KEYFIELD & " IN ('" & SSMS & "')"
        '        VCONN.getDataSet(STRSQL, "DETAILS")
        '        DTLDET.LOADDATA(gdataset.Tables("DETAILS"), False, "MENUMASTER", STRSQL, "SERIALNO", 1)
        '    End If
        'End If
    End Sub

    Private Sub DGVDET_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDET.CellContentClick
        Try
            TextBox1.Text = DGVDET.CurrentCell.Value.ToString()
        Catch ex As Exception
            TextBox1.Text = ""
        End Try
    End Sub
End Class