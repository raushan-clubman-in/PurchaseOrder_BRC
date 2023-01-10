Imports System.Data.SqlClient
Public Class GridOperation
    Dim conn As New SqlConnection
    Dim dataset As New dataset
    Dim da As SqlDataAdapter
    Public DATAARRAY(10) As String
    Public GRIDARRAY(10) As Integer
    Public TOTALARRAY(10) As Integer
    Dim TOTAL(10) As Double
    Dim DSTABLENAME As String = "GRID"
    Dim GRID As AxFPSpreadADO.AxfpSpread
    Public DATABASETABLENAME As String
    Public DATABASESTR As String
    Public Sub GridLoad(ByVal grid As AxFPSpreadADO.AxfpSpread, ByVal SqlConn As String, ByVal sqlstring As String)
        Dim i, j As Integer
        For i = 1 To grid.MaxRows
            For j = 1 To grid.MaxCols
                With grid
                    .Col = j
                    .Row = i
                    .Lock = True
                End With
            Next
        Next
        Try
            conn.ConnectionString = SqlConn
            conn.Open()

            da = New SqlDataAdapter(sqlstring, conn)
            If dataset.Tables.Contains(DSTABLENAME) = True Then
                dataset.Tables.Remove(DSTABLENAME)
            End If
            da.Fill(dataset, DSTABLENAME)
            UNLOCKROW(grid, 1, grid.DataRowCnt + 1)
            grid.SetActiveCell(1, grid.DataRowCnt + 1)
        Catch ex As Exception
            MessageBox.Show(ex.Source & ex.Message & ex.ToString)
        End Try
    End Sub

    Public Sub GRIDKEYDOWNEVENT(ByVal grid As AxFPSpreadADO.AxfpSpread, ByVal keycode As Integer)
        Dim msgstatus As Integer
        Try
            'IF "ENTER" IS PRESSED
            If keycode = Keys.Enter Then
                grid.Col = grid.ActiveCol
                grid.Row = grid.ActiveRow
                If grid.ActiveCol = grid.MaxCols Then
                    Call EnterKeyPressEvent(grid, grid.ActiveCol, grid.ActiveRow, keycode)
                    grid.SetActiveCell(1, grid.Row + 1)
                    Call UNLOCKROW(grid, grid.ActiveCol, grid.ActiveRow)
                    Call COLUMNSTOTAL(grid)
                Else
                    Call EnterKeyPressEvent(grid, grid.ActiveCol, grid.ActiveRow, keycode)
                End If

            End If

            'IF "F4" IS PRESSED
            If keycode = Keys.F4 Then
                DATABASESTR = DATAARRAY(grid.ActiveCol - 1)
                Call F4KeyPressEvent(grid, grid.ActiveCol, grid.ActiveRow)
            End If

            'IF "ESC" IS PRESSED
            If keycode = Keys.Escape Then
                If grid.DataRowCnt <> 0 Then
                    LOCKROW(grid, grid.ActiveCol, grid.ActiveRow)
                End If

            End If

            'IF "F3" IS PRESSED
            If keycode = Keys.F3 Then
                grid.Row = grid.ActiveRow
                grid.Col = grid.ActiveCol
                If grid.Row <= grid.DataRowCnt Then
                    msgstatus = MsgBox("Are U Sure To Delete The Row", MsgBoxStyle.OKCancel)
                    If msgstatus = 1 Then
                        grid.DeleteRows(grid.Row, grid.Col)
                    End If
                End If
                If grid.DataRowCnt = 0 Then
                    Call UNLOCKROW(grid, 1, 1)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Function EnterKeyPressEvent(ByVal grid As AxFPSpreadADO.AxfpSpread, ByVal ACTIVECOL As Integer, ByVal ACTIVEROW As Integer, ByVal keycode As Integer)
        Dim DR As DataRow
        Dim I, J As Integer
        Dim VALIDATIONSTATUS As Boolean
        GRID.Col = ACTIVECOL
        GRID.Row = ACTIVEROW

        For Each DR In dataset.Tables(DSTABLENAME).Rows
            DATABASESTR = DATAARRAY(ACTIVECOL - 1)
            If DATABASESTR <> Nothing Then
                If GRID.ActiveCol = ACTIVECOL And GRID.ActiveRow = ACTIVEROW And GRIDARRAY(ACTIVECOL - 1) = ACTIVECOL And GRID.Lock = False Then
                    If ValidateSpace(grid, ACTIVECOL, ACTIVEROW) = False Then
                        VALIDATIONSTATUS = True
                        Exit Function
                    Else
                        ValidateDataEnterEvent(grid, ACTIVECOL, ACTIVEROW, keycode)
                        VALIDATIONSTATUS = True
                        Exit Function
                    End If
                End If
            End If
        Next
        If VALIDATIONSTATUS = False Then
            If keycode = 13 Then
                GRID.SetActiveCell(ACTIVECOL + 1, ACTIVEROW)
            End If
        End If
    End Function

    Private Function ValidateDataEnterEvent(ByVal grid As AxFPSpreadADO.AxfpSpread, ByVal ACTIVECOL As Integer, ByVal ACTIVEROW As Integer, ByVal keycode As Integer)
        Dim DR As DataRow
        Dim STATUS As Boolean
        GRID.Col = ACTIVECOL
        GRID.Row = ACTIVEROW

        For Each DR In dataset.Tables(DSTABLENAME).Rows
            If Trim(GRID.Text) = DR.Item(DATABASESTR) Then

                'IF "ENTER" IS PRESSED
                If keycode = 13 Then
                    GRID.SetActiveCell(ACTIVECOL + 1, ACTIVEROW)
                    STATUS = True
                    Exit For
                End If

            End If
        Next

        If STATUS = False Then
            GRID.SetText(ACTIVECOL, ACTIVEROW, "")
            GRID.SetActiveCell(ACTIVECOL, ACTIVEROW)
            Exit Function
        End If

    End Function

    Private Function ValidateSpace(ByVal grid As AxFPSpreadADO.AxfpSpread, ByVal ACTIVECOL As Integer, ByVal ACTIVEROW As Integer) As Boolean
        ValidateSpace = True
        GRID.Row = ACTIVEROW
        GRID.Col = ACTIVECOL
        If Trim(UCase(GRID.Text)) = "" Then
            GRID.SetText(ACTIVECOL, ACTIVEROW, "")
            GRID.SetActiveCell(ACTIVECOL, ACTIVEROW)
            ValidateSpace = False
        End If
    End Function
    Private Function F4KeyPressEvent(ByVal grid As AxFPSpreadADO.AxfpSpread, ByVal ACTIVECOL As Integer, ByVal ACTIVEROW As Integer)
        Dim i, j As Integer
        GRID.Col = ACTIVECOL
        GRID.Row = ACTIVEROW
        If DATABASESTR <> Nothing Then
            If grid.ActiveCol = ACTIVECOL And grid.ActiveRow = ACTIVEROW And grid.Lock = False Then
                Dim vform As New ListOperattion1_N
                gSQLString = "SELECT DISTINCT " & DATABASESTR & " FROM " & DATABASETABLENAME
                M_WhereCondition = ""
                vform.Field = DATABASESTR
                vform.vFormatstring = DATABASESTR
                vform.vCaption = "HELP"
                vform.KeyPos = 0
                vform.ShowDialog()
                If Trim(vform.keyfield & "") <> "" Then
                    grid.Col = ACTIVECOL
                    grid.Row = ACTIVEROW
                    grid.Text = Trim(vform.keyfield & "")
                    grid.SetActiveCell(ACTIVECOL + 1, ACTIVEROW)
                Else
                    grid.SetText(ACTIVECOL, ACTIVEROW, "")
                    grid.SetActiveCell(ACTIVECOL, ACTIVEROW)
                End If
                vform.Close()
                vform = Nothing
            End If
        Else
            Exit Function
        End If
        i = i + 1
    End Function

    Public Function GridLeaveCellEvent(ByVal grid As AxFPSpreadADO.AxfpSpread, ByVal ACTIVECOL As Integer, ByVal ACTIVEROW As Integer)
        Dim DR As DataRow
        Dim I, J As Integer
        Dim VALIDATIONSTATUS As Boolean
        GRID.Col = ACTIVECOL
        GRID.Row = ACTIVEROW

        DATABASESTR = DATAARRAY(ACTIVECOL - 1)
        If DATABASESTR <> Nothing Then
            If GRID.ActiveCol = ACTIVECOL And GRID.ActiveRow = ACTIVEROW And GRIDARRAY(ACTIVECOL - 1) = ACTIVECOL And GRID.Lock = False Then
                If ValidateSpace(grid, ACTIVECOL, ACTIVEROW) = False Then
                    Exit Function
                Else
                    ValidateDataLeaveEvent(grid, ACTIVECOL, ACTIVEROW)
                    Exit Function
                End If
            End If
        End If
    End Function

    Private Function ValidateDataLeaveEvent(ByVal grid As AxFPSpreadADO.AxfpSpread, ByVal ACTIVECOL As Integer, ByVal ACTIVEROW As Integer)
        Dim DR As DataRow
        Dim STATUS As Boolean
        GRID.Col = ACTIVECOL
        GRID.Row = ACTIVEROW
        For Each DR In dataset.Tables(DSTABLENAME).Rows
            If Trim(GRID.Text) = DR.Item(DATABASESTR) Then
                STATUS = True
                Exit For
            End If
        Next
        If STATUS = False Then
            GRID.SetText(ACTIVECOL, ACTIVEROW, "")
            GRID.SetActiveCell(ACTIVECOL, ACTIVEROW)
            Exit Function
        End If
    End Function
    Public Function Gridleaverow(ByVal grid As AxFPSpreadADO.AxfpSpread, ByVal ACTIVECOL As Integer, ByVal ACTIVEROW As Integer)
        GRID.SetActiveCell(1, ACTIVEROW + 1)
    End Function
    Private Function UNLOCKROW(ByVal grid As AxFPSpreadADO.AxfpSpread, ByVal ACTIVECOL As Integer, ByVal ACTIVEROW As Integer)
        Dim I As Integer
        I = 1
        With grid
            .Row = ACTIVEROW
            .Col = ACTIVECOL
            For I = ACTIVECOL To .MaxCols
                .Row = ACTIVEROW
                .Col = I
                .Lock = False
            Next
        End With
    End Function
    Private Function LOCKROW(ByVal grid As AxFPSpreadADO.AxfpSpread, ByVal ACTIVECOL As Integer, ByVal ACTIVEROW As Integer)
        Dim I As Integer
        I = 1
        With grid
            .Row = ACTIVEROW
            .Col = ACTIVECOL
            For I = ACTIVECOL To .MaxCols
                .Row = ACTIVEROW
                .Col = I
                .Lock = True
            Next
        End With
    End Function
    Private Function COLUMNSTOTAL(ByVal grid As AxFPSpreadADO.AxfpSpread)
        Dim i, j As Double
        Dim totalstr As Double
        ReDim TOTAL(10)
        For i = 0 To GRIDARRAY.Length - 1
            totalstr = TOTALARRAY(i)
            If totalstr <> 0 Then
                For j = 1 To grid.DataRowCnt
                    grid.Row = j
                    grid.Col = i + 1
                    TOTAL(i) = TOTAL(i) + Val(grid.Text)
                Next
            End If
        Next
        MsgBox(TOTAL(1) & "   " & TOTAL(2))
    End Function
End Class
