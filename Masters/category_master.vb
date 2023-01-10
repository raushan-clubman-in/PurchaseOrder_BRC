Imports System.Data.SqlClient
Imports System
Imports System.Data
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Public Class category_master
    Dim GCONNECTION As New GlobalClass
    Dim SQLSTRING As String
    Private Sub CmdClear_Click(sender As Object, e As EventArgs) Handles CmdClear.Click
        Try
            txt_catcode.Text = ""
            TXT_CATNAME.Text = ""
            txt_catcode.ReadOnly = False
            Call GetLastNo()
            CmdAdd.Text = "Add [F7]"
            UserCheckList.Items.Clear()
            bindchecklist()
        Catch ex As Exception
            MsgBox("Error In Clearing")
            Exit Sub
        End Try
       
    End Sub

    Private Sub CmdExit_Click(sender As Object, e As EventArgs) Handles CmdExit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("Error In Exit")
            Exit Sub
        End Try

    End Sub

    Private Sub CmdAdd_Click(sender As Object, e As EventArgs) Handles CmdAdd.Click
        Try
            Dim INSERT(0) As String
            If txt_catcode.Text = "" Then
                MessageBox.Show("CATEGORY CODE CAN'T BE BLANK")
                txt_catcode.Focus()
                Exit Sub
            End If
            If txt_catcode.Text = "" Then
                MessageBox.Show("CATEGORY NAME CAN'T BE BLANK")
                TXT_CATNAME.Focus()
                Exit Sub
            End If
            If CmdAdd.Text = "Add [F7]" Then
                SQLSTRING = "SELECT * FROM INVENTORYCATEGORYMASTER WHERE CATEGORYCODE='" & txt_catcode.Text & "'"
                GCONNECTION.getDataSet(SQLSTRING, "CAT")
                If gdataset.Tables("CAT").Rows.Count > 0 Then
                    MessageBox.Show("CATEGORYCODE ALREADY EXISTS...")
                    Exit Sub
                End If
                SQLSTRING = "INSERT INTO INVENTORYCATEGORYMASTER(CATEGORYCODE, CATEGORYDESC, FREEZE, ADDDATE, USERNAME) "
                SQLSTRING = SQLSTRING & "VALUES('" & txt_catcode.Text & "','" & TXT_CATNAME.Text & "','N','" & Format(Date.Now, "dd/MMM/yyyy") & "', '" & gUsername & "')"
                ReDim Preserve INSERT(INSERT.Length)
                INSERT(INSERT.Length - 1) = SQLSTRING
                GCONNECTION.MoreTrans(INSERT)

                insertcheckeduser()

            ElseIf CmdAdd.Text = "Update[F7]" Then
                SQLSTRING = "UPDATE INVENTORYCATEGORYMASTER SET CATEGORYDESC='" & TXT_CATNAME.Text & "' WHERE CATEGORYCODE='" & txt_catcode.Text & "' "
                ReDim Preserve INSERT(INSERT.Length)
                INSERT(INSERT.Length - 1) = SQLSTRING
                GCONNECTION.MoreTrans(INSERT)

                updatecheckeduser()

                insertcheckeduser()

                'GCONNECTION.dataOperation(2, SQLSTRING, "INVENTORYCATEGORYMASTER")
            End If
            
            CmdClear_Click(sender, e)
        Catch ex As Exception
            MsgBox("Error In Saving")
            Exit Sub
        End Try
        
    End Sub

    Private Sub category_master_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                Call CmdClear_Click(CmdClear, e)
            End If
            If e.KeyCode = Keys.F7 Then
                If CmdAdd.Enabled = True Then
                    Call CmdAdd_Click(CmdAdd, e)
                End If
            End If
            If e.KeyCode = Keys.F8 Then
                If cmdFreeze.Enabled = True Then
                    Call cmdFreeze_Click(cmdFreeze, e)
                End If
            End If
            'If e.KeyCode = Keys.F9 And CmdView.Enabled = True Then
            '    Call CmdView_Click(CmdView, e)
            'End If
            If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                Call CmdExit_Click(CmdExit, e)
            End If
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Customer Master KeyDown")
        End Try
    End Sub

    Private Sub category_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Resize_Form()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        If Not String.IsNullOrEmpty(gAuditFlg) Then
            If gAuditFlg.ToUpper = "Y" Then
                Me.CmdAdd.Enabled = False
                Me.cmdFreeze.Enabled = False
            End If
        End If
        Call GetLastNo()
        txt_catcode.Focus()
    End Sub


    Private Sub bindchecklist()
        UserCheckList.Items.Clear()
        '  Dim sqlstring = "SELECT DISTINCT USERNAME,CATEGORY FROM UserAdmin where Maingroup='Inventory'"
        Dim sqlstring = "  SELECT DISTINCT USERNAME,CATEGORY FROM UserAdmin where Maingroup='PURCHASE ORDER'"
        sqlstring = sqlstring & "    union "
        sqlstring = sqlstring & "  SELECT DISTINCT USERNAME,CATEGORY FROM UserAdmin where category='S'"
        gconnection.getDataSet(sqlstring, "UserAdmin")
        If (gdataset.Tables("UserAdmin").Rows.Count > 0) Then
            For i As Integer = 0 To gdataset.Tables("UserAdmin").Rows.Count - 1
                UserCheckList.Items.Add(gdataset.Tables("UserAdmin").Rows(i).Item("USERNAME"))
            Next
        End If

    End Sub

    Public Sub Resize_Form()
        Dim cControl As Control
        Dim i_i As Integer
        Dim J, K, L, M, n, o, P, Q, R, S, T, U As Integer
        'If (Screen.PrimaryScreen.Bounds.Height = 768) And (Screen.PrimaryScreen.Bounds.Width = 1366) Then
        '    Exit Sub
        'End If
        J = 728
        K = 1024
        Me.ResizeRedraw = True
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        T = CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)
        U = CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)
        If U = 800 Then
            T = T - 50
        End If
        If U = 1280 Then
            T = T - 50
        End If
        If U = 1360 Then
            T = T - 75
        End If
        If U = 1366 Then
            T = T - 75
        End If
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Width = U
        Me.Height = T


        With Me
            For i_i = 0 To .Controls.Count - 1
                ' MsgBox(Controls(i_i).Name)
                If TypeOf .Controls(i_i) Is Form Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0
                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If
                ElseIf TypeOf .Controls(i_i) Is Panel Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o

                    For Each cControl In .Controls(i_i).Controls

                        If cControl.Location.X = 0 Then
                            R = 0
                        Else
                            R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                        End If
                        If cControl.Location.Y = 0 Then
                            S = 0
                        Else
                            S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                        End If

                        cControl.Left = R
                        cControl.Top = S


                        If cControl.Size.Width = 0 Then
                            P = 0
                        Else
                            P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
                        End If

                        If cControl.Size.Height = 0 Then
                            Q = 0
                        Else
                            Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
                        End If

                        cControl.Width = P
                        cControl.Height = Q
                    Next
                ElseIf TypeOf .Controls(i_i) Is GroupBox Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        If Controls(i_i).Name = "GroupBox2" Then
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            If U = 800 Then
                                L = L + 50
                            End If
                            If U = 1280 Then
                                L = L + 50
                            End If
                            If U = 1360 Then
                                L = L + 75
                            End If
                            If U = 1366 Then
                                L = L + 75
                            End If
                        Else
                            L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))

                            ' L = L - 5
                        End If
                    End If

                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o

                    For Each cControl In .Controls(i_i).Controls

                        If cControl.Location.X = 0 Then
                            R = 0
                        Else
                            R = cControl.Location.X + CInt((cControl.Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                        End If
                        If cControl.Location.Y = 0 Then
                            S = 0
                        Else
                            S = cControl.Location.Y + CInt((cControl.Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                        End If

                        cControl.Left = R
                        cControl.Top = S


                        If cControl.Size.Width = 0 Then
                            P = 0
                        Else
                            P = (cControl.Size.Width + CInt((cControl.Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width)))))
                        End If

                        If cControl.Size.Height = 0 Then
                            Q = 0
                        Else
                            Q = (cControl.Size.Height + CInt((cControl.Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height)))))
                        End If

                        cControl.Width = P
                        cControl.Height = Q
                    Next
                ElseIf TypeOf .Controls(i_i) Is Label Then
                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        L = .Controls(i_i).Location.X + CInt((.Controls(i_i).Location.X) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Location.Y = 0 Then
                        L = 0

                    Else
                        M = .Controls(i_i).Location.Y + CInt((.Controls(i_i).Location.Y) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Left = L
                    .Controls(i_i).Top = M
                    If .Controls(i_i).Size.Width = 0 Then
                        n = 0
                    Else
                        n = .Controls(i_i).Size.Width + CInt((.Controls(i_i).Size.Width) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Width) - K) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Width))))
                    End If
                    If .Controls(i_i).Size.Height = 0 Then
                        o = 0
                    Else
                        o = .Controls(i_i).Size.Height + CInt((.Controls(i_i).Size.Height) * ((CInt(Screen.PrimaryScreen.WorkingArea.Size.Height) - J) / (CInt(Screen.PrimaryScreen.WorkingArea.Size.Height))))
                    End If

                    .Controls(i_i).Width = n
                    .Controls(i_i).Height = o
                End If
            Next i_i
        End With
    End Sub

    Private Sub TXT_CATNAME_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_CATNAME.KeyDown

    End Sub

    Private Sub TXT_CATNAME_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CATNAME.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(TXT_CATNAME.Text) <> "" Then
                    CmdAdd.Focus()
                Else
                    TXT_CATNAME.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
        
        
    End Sub

    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='PURCHASE ORDER' AND MODULENAME LIKE 'Category Master%' ORDER BY RIGHTS"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.CmdAdd.Enabled = False
        Me.cmdFreeze.Enabled = False
        ' Me.Cmd_View.Enabled = False
        'Me.cmd_rpt.Enabled = False
        ' Me.cmd_export.Enabled = False
        ' Me.cmd_auth.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdAdd.Enabled = True
                    Me.cmdFreeze.Enabled = True
                    'Me.Cmd_View.Enabled = True
                    'Me.cmd_auth.Enabled = True
                    'Me.cmd_export.Enabled = True
                    'Me.cmd_rpt.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.CmdAdd.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.CmdAdd.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.CmdAdd.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.cmdFreeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    ' Me.Cmd_View.Enabled = True
                    ' Me.cmd_rpt.Enabled = True
                    ' Me.cmd_export.Enabled = True
                End If
                If Right(x) = "U" Then
                    ' Me.cmd_auth.Enabled = True
                End If
            Next
        End If


    End Sub

    Private Sub txt_catcode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_catcode.KeyPress
        Try
            If Asc(e.KeyChar) = 13 Then
                If Trim(txt_catcode.Text) <> "" Then
                    SQLSTRING = "SELECT ISNULL(CATEGORYCODE,'') AS CATEGORYCODE FROM INVENTORYCATEGORYMASTER WHERE CATEGORYCODE='" & txt_catcode.Text & "'"
                    GCONNECTION.getDataSet(SQLSTRING, "INVENTORYCATEGORYMASTER")
                    If gdataset.Tables("INVENTORYCATEGORYMASTER").Rows.Count > 0 Then
                        MessageBox.Show("CATEGORY CODE ALREADY EXISTS!")
                        txt_catcode.Text = ""
                        txt_catcode.Focus()
                    Else
                        TXT_CATNAME.Focus()
                    End If
                Else
                    txt_catcode.Focus()
                End If
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub CusCodeHelp_Click(sender As Object, e As EventArgs) Handles CusCodeHelp.Click
        Try
            gSQLString = ""
            gSQLString = "SELECT ISNULL(CATEGORYCODE,'') AS CATEGORYCODE,ISNULL(CATEGORYDESC,'') AS CATEGORYDESC FROM  INVENTORYCATEGORYMASTER"
            M_WhereCondition = " WHERE ISNULL(FREEZE,'')<>'Y' "
            M_ORDERBY = " Order by CATEGORYDESC,CATEGORYCODE "
            Dim vform As New ListOperattion1_N
            vform.Field = "CATEGORYCODE,CATEGORYDESC"
            vform.vFormatstring = "     CATEGORY CODE                      |                    CATEGORY NAME                            "
            vform.vCaption = "CATEGORY MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                TXT_CATNAME.Text = Trim(vform.keyfield1 & "")
                txt_catcode.Text = Trim(vform.keyfield & "")
                Call txt_catcode_Validated(txt_catcode, e)
                'CmdAdd.Text = "Update[F7]"
            End If
            vform.Close()
            vform = Nothing
            M_ORDERBY = ""
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Customer Code Help Click")
        End Try
    End Sub

    Private Sub cmdFreeze_Click(sender As Object, e As EventArgs) Handles cmdFreeze.Click
        Dim INSERT(0) As String
        SQLSTRING = "UPDATE INVENTORYCATEGORYMASTER SET FREEZE='Y' WHERE CATEGORYCODE='" & txt_catcode.Text & "'"
        ReDim Preserve INSERT(INSERT.Length)
        INSERT(INSERT.Length - 1) = SQLSTRING
        GCONNECTION.MoreTrans(INSERT)

        updatecheckeduser()

    End Sub

    Private Sub GetLastNo()
        Dim SQLSTRING As String
        SQLSTRING = "select ISNULL(max(cast(categorycode as numeric)),0) as categorycode from inventorycategorymaster where isnumeric(categorycode)=1 and categorycode like '%[0-9]%'"

        'SQLSTRING = "SELECT Isnull(Max(categorycode),0)as categorycode FROM inventorycategorymaster "
        gconnection.getDataSet(SQLSTRING, "membermaster")
        If gdataset.Tables("membermaster").Rows.Count > 0 Then
            Me.lbl_last.Text = "Last No IS : " & " " & gdataset.Tables("membermaster").Rows(0).Item(0)
            txt_catcode.Text = Val(gdataset.Tables("membermaster").Rows(0).Item(0)) + 1
        Else
            Me.lbl_last.Text = "Last No" & " " & 0
            'Me.lbl_last.Text = "Last No" & " " & 0
        End If

    End Sub

    Private Sub Cmd_View_Click(sender As Object, e As EventArgs) Handles Cmd_View.Click
        Dim FRM As New ReportDesigner
        If txt_catcode.Text.Length > 0 Then
            tables = " FROM INVENTORYCATEGORYMASTER WHERE CATEGORYCODE ='" & txt_catcode.Text & "' "
        Else
            tables = "FROM INVENTORYCATEGORYMASTER "
        End If
        Gheader = "CATEGORY MASTER DETAILS"
        FRM.DataGridView1.ColumnCount = 2
        FRM.DataGridView1.Columns(0).Name = "COLUMN NAME"
        FRM.DataGridView1.Columns(0).Width = 300
        FRM.DataGridView1.Columns(1).Name = "SIZE"
        FRM.DataGridView1.Columns(1).Width = 100

        Dim ROW As String() = New String() {"CATEGORYCODE", "25"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"CATEGORYDESC", "35"}
        FRM.DataGridView1.Rows.Add(ROW)
       
        Dim CHK As New DataGridViewCheckBoxColumn()
        FRM.DataGridView1.Columns.Insert(0, CHK)
        CHK.HeaderText = "CHECK"
        CHK.Name = "CHK"
        FRM.ShowDialog(Me)
    End Sub

    Private Sub txt_catcode_Validated(sender As Object, e As EventArgs) Handles txt_catcode.Validated
        SQLSTRING = "SELECT ISNULL(CATEGORYCODE,'') AS CATEGORYCODE,ISNULL(CATEGORYDESC,'') AS CATEGORYDESC FROM  INVENTORYCATEGORYMASTER WHERE CATEGORYCODE='" & Trim(txt_catcode.Text) & "' AND ISNULL(FREEZE,'')<>'Y' "
        GCONNECTION.getDataSet(SQLSTRING, "INVENTORYCATEGORYMASTER")
        If gdataset.Tables("INVENTORYCATEGORYMASTER").Rows.Count > 0 Then
            TXT_CATNAME.Text = Trim(gdataset.Tables("INVENTORYCATEGORYMASTER").Rows(0).Item("CATEGORYDESC"))
            txt_catcode.Text = Trim(gdataset.Tables("INVENTORYCATEGORYMASTER").Rows(0).Item("CATEGORYCODE"))
            Me.CmdAdd.Text = "Update[F7]"

            UserCheckList.Items.Clear()
            bindchecklist()
            SQLSTRING = "select Usercode from Categoryuserdetail where CATEGORYCODE='" & Trim(txt_catcode.Text) & "' and isnull(void,'')='N'"
            GCONNECTION.getDataSet(SQLSTRING, "Categoryuserdetail")
            Dim TYPE As String
            Dim Usercode As String
            If (gdataset.Tables("Categoryuserdetail").Rows.Count > 0) Then
                For k As Integer = 0 To gdataset.Tables("Categoryuserdetail").Rows.Count - 1
                    Usercode = Trim(gdataset.Tables("Categoryuserdetail").Rows(k).Item("Usercode"))
                    For m As Integer = 0 To UserCheckList.Items.Count - 1
                        TYPE = UserCheckList.Items(m)
                        If TYPE = Usercode Then
                            UserCheckList.SetItemChecked(m, True)
                        End If
                    Next m
                Next k
            End If

            txt_catcode.ReadOnly = True
            TXT_CATNAME.Focus()

        Else
            'txt_catcode.Text = ""
            'TXT_CATNAME.Text = ""
            TXT_CATNAME.Focus()
        End If
    End Sub

    Private Sub insertcheckeduser()
        Dim insert(0) As String

        For i As Integer = 0 To UserCheckList.CheckedItems.Count - 1
            Dim sql As String = "Insert into Categoryuserdetail(categorycode,categorydesc,Usercode,void,adddate,adduser)"
            sql = sql & " values('" & Trim(txt_catcode.Text) & "','" & Trim(TXT_CATNAME.Text) & "','" & UserCheckList.CheckedItems(i) & "','N',GETDATE(),'" + Trim(gUsername) + "') "
            ReDim Preserve insert(insert.Length)
            insert(insert.Length - 1) = sql

        Next
        gconnection.MoreTrans2(insert)
    End Sub
    Private Sub updatecheckeduser()
        Dim insert(0) As String


        Dim sql As String = "Update Categoryuserdetail set void='Y',Updatedate=GETDATE(),Updateuser='" + Trim(gUsername) + "'"
        sql = sql & " where categorycode='" & Trim(txt_catcode.Text) & "' "
        gconnection.dataOperation(6, sql, "Categoryuserdetail")
    End Sub

    Private Sub updatecheckeduser1()
        Dim insert(0) As String


        Dim sql As String = "Update Categoryuserdetail set void='N',Updatedate=GETDATE(),Updateuser='" + Trim(gUsername) + "'"
        sql = sql & " where categorycode='" & Trim(txt_catcode.Text) & "' "
        gconnection.dataOperation(6, sql, "Categoryuserdetail")



    End Sub
    Private Sub voidcheckeduser()
        Dim sql As String = "Update Categoryuserdetail set void='Y',Voiddate=GETDATE(),Voiduser='" + Trim(gUsername) + "'"
        sql = sql & " where categorycode='" & Trim(txt_catcode.Text) & "' "
        gconnection.dataOperation(6, sql, "Categoryuserdetail")

    End Sub
End Class