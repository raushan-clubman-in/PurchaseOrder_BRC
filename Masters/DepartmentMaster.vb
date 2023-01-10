Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class DepartmentMaster
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Friend WithEvents cmd_auth As System.Windows.Forms.Button
    Friend WithEvents cmd_export As System.Windows.Forms.Button
    Dim boolchk As Boolean


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_clear.Click
        Call clearform(Me)
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.cmd_freeze.Text = "Freeze[F8]"
        cmd_add.Text = "Add [F7]"
        Me.cmd_freeze.Enabled = True
        txt_dept.Enabled = True
        txt_dept.ReadOnly = False
        txt_deptname.ReadOnly = False
        txt_dept.Text = ""
        txt_deptname.Text = ""

        txt_dept.Focus()

    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check  Group desc Can't be blank *********************'''
        If Trim(txt_dept.Text) = "" Then
            MessageBox.Show("Department Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_dept.Focus()
            Exit Sub
        End If
        If Trim(txt_deptname.Text) = "" Then
            MessageBox.Show("Department Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_deptname.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub cmd_add_Click(sender As Object, e As EventArgs) Handles cmd_add.Click
        Dim strsql As String
        If cmd_add.Text = "Save [F7]" Then
            Call checkValidation()
            If boolchk = False Then Exit Sub
            strsql = "insert into PO_DEPARTMENT (code,name,freeze,adduser,adddatetime)"
            strsql = strsql & " values "
            strsql = strsql & "('" & Trim(txt_dept.Text) & "','" & Trim(txt_deptname.Text) & "',"
            strsql = strsql & " 'N','" & Trim(gUsername) & "','" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
            gconnection.dataOperation(1, strsql, "PO_DEPARTMENT")
            Me.Button1_Click(sender, e)
        ElseIf cmd_add.Text = "Update[F7]" And Me.lbl_Freeze.Visible = True Then
            Call checkValidation() '''--->Check Validation
            If Mid(Me.cmd_add.Text, 1, 1) = "U" And Me.lbl_Freeze.Visible = True Then
                MessageBox.Show(" The Freezed Record Cannot Be Updated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                boolchk = False
            End If
            If boolchk = False Then
                Call clearform(Me)
                Me.Button1_Click(sender, e)
                Exit Sub
            End If
        Else
            strsql = "UPDATE  PO_DEPARTMENT "
            strsql = strsql & " SET name='" & Replace(Trim(txt_deptname.Text), "'", "") & "',"
            strsql = strsql & "updatedatetime='" & Format(Now, "dd-MMM-yyyy hh:mm") & "',freeze='N'"
            strsql = strsql & " WHERE code = '" & Trim(txt_dept.Text) & "'"
            gconnection.dataOperation(2, strsql, "PO_DEPARTMENT")
            Me.Button1_Click(sender, e)
            cmd_add.Text = "Save [F7]"
        End If
        Call clearform(Me)
        Me.txt_dept.Focus()
    End Sub

    Private Sub cmd_freeze_Click(sender As Object, e As EventArgs) Handles cmd_freeze.Click
        Dim strsql As String
        Call checkValidation()
        If boolchk = False Then Exit Sub
        If Mid(cmd_freeze.Text, 1, 1) = "F" Then
            strsql = "UPDATE  PO_DEPARTMENT "
            strsql = strsql & " SET Freeze= 'Y',Freezeuser='" & gUsername & " ', Freezedatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            strsql = strsql & " WHERE code = '" & Trim(txt_dept.Text) & "'"
            gconnection.dataOperation(3, strsql, "PO_DEPARTMENT")
            Me.Button1_Click(sender, e)
            cmd_add.Text = "Save [F7]"
            'Else
            '    strsql = "UPDATE  PO_deliveryterms "
            '    strsql = strsql & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            '    strsql = strsql & " WHERE Deliverytermcode = '" & Trim(txtdeliverycode.Text) & "'"
            '    gconnection.dataOperation(4, strsql, "PO_deliveryterms")
            '    Me.Cmd_Clear_Click(sender, e)
            '    Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub cmd_exit_Click(sender As Object, e As EventArgs) Handles cmd_exit.Click
        Me.Close()
    End Sub

    Private Sub cmd_help_Click(sender As Object, e As EventArgs) Handles cmd_help.Click
        Try
            gSQLString = "SELECT ISNULL(code,'') AS code,ISNULL(name,'') AS               name FROM PO_DEPARTMENT"
            M_WhereCondition = " "
            Dim vform As New ListOperattion1_N
            vform.Field = "code,name"
            vform.vFormatstring = "    CODE              |                                                      name                                                             "
            vform.vCaption = "DEPARTMENT MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_dept.Text = Trim(vform.keyfield & "")
                Call txt_dept_Validated(txt_dept, e)
            End If
            vform.Close()
            vform = Nothing
            'Cmd_Freeze.Enabled = True
        
        Catch ex As Exception
            MsgBox(Err.Description & Err.Source & "Err in Operation", MsgBoxStyle.Information, "Customer Code Help Click")
        End Try
    End Sub

    Private Sub txt_dept_Validated(sender As Object, e As EventArgs) Handles txt_dept.Validated
        Dim strsql As String
        If Trim(txt_dept.Text) <> "" Then
            strsql = "SELECT * FROM PO_DEPARTMENT WHERE CODE='" & Trim(txt_dept.Text) & "'"
            gconnection.getDataSet(strsql, "PO_DEPARTMENT")
            If gdataset.Tables("PO_DEPARTMENT").Rows.Count > 0 Then
                txt_dept.Text = Trim(gdataset.Tables("PO_DEPARTMENT").Rows(0).Item("CODE"))
                txt_deptname.Text = Trim(gdataset.Tables("PO_DEPARTMENT").Rows(0).Item("NAME"))
                txt_deptname.Focus()

                If gdataset.Tables("PO_DEPARTMENT").Rows(0).Item("Freeze") = "Y" Then
                    Me.lbl_Freeze.Visible = True
                    Me.lbl_Freeze.Text = ""
                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("PO_DEPARTMENT").Rows(0).Item("AddDatetime")), "dd-MMM-yyyy")
                    ' Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                    Me.cmd_freeze.Enabled = False
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.cmd_freeze.Text = "Freeze[F8]"
                End If
                Me.cmd_add.Text = "Update[F7]"
            Else
                Me.lbl_Freeze.Visible = False
                Me.lbl_Freeze.Text = "Record Freezed  On "
                Me.cmd_add.Text = "Save [F7]"

                txt_deptname.Focus()
            End If
            
        Else
            txt_deptname.Focus()
        End If
        'If gUserCategory <> "S" Then
        '    Call GetRights()
        'End If
    End Sub

    Private Sub txt_dept_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dept.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_dept.Text) = "" Then
                Call cmd_help_Click(sender, e)
            Else
                txt_dept.Focus()
            End If
        End If
    End Sub

    Private Sub txt_dept_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_dept.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_help_Click(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub DepartmentMaster_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Button1_Click(cmd_clear, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F8 Then
            If cmd_freeze.Enabled = True Then
                Call cmd_freeze_Click(cmd_freeze, e)
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F7 And cmd_add.Enabled = True Then
            Call cmd_add_Click(cmd_add, e)
            Exit Sub
        End If
    
        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call cmd_exit_Click(cmd_exit, e)
            Exit Sub
        End If
    End Sub
End Class