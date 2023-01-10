Imports System.Text.RegularExpressions
Imports System.IO
Module GlobalFunction
    Dim regexp As Regex
    Dim gconnection As New GlobalClass
    Public boolexp As Boolean = False
    Public boolexp1 As Boolean = False
    Public boolexp2 As Boolean = False
    '*******************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Numeric
    'Function Name:getNumeric
    'Input Type:KeyPressEventArgs
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*******************************************************************
    Public Sub getNumeric(ByVal a As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(a.KeyChar)
            Case 65 To 127
                a.Handled = True
            Case 33 To 38
                a.Handled = True
            Case 40 To 44
                a.Handled = True
            Case 58 To 64
                a.Handled = True
        End Select
    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getAlphanumeric
    'Input Type:KeyPressEventArgs
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getAlphanumeric(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(b.KeyChar)
            Case 33 To 47
                b.Handled = True
            Case 58 To 64
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 123 To 135
                b.Handled = True
        End Select
    End Sub
    Public Sub Blank(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        If Asc(b.KeyChar) > 0 And Asc(b.KeyChar) < 225 Then
            b.Handled = True
        End If
    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Charater
    'Function Name:getCharater
    'Input Type:KeyPressEventArgs
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getCharater(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(b.KeyChar)
            Case 33 To 64
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 123 To 135
                b.Handled = True
        End Select
    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getEmail
    'Input Type:Textbox
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getEmail(ByVal txtbox As System.Windows.Forms.TextBox)
        Dim boolexp1 As Boolean = False
        If regexp.IsMatch(txtbox.Text, "^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") Then
            boolexp1 = True
            txtbox.ForeColor = Color.Black
        Else
            MsgBox(" E-mail Id field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            boolexp1 = False
            Exit Sub
        End If
    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getPincode
    'Input Type:Textbox
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getPincode(ByVal txtbox As System.Windows.Forms.TextBox)
        Dim boolexp As Boolean = False
        If regexp.IsMatch(txtbox.Text, "^\d{5}(-\d{4})?$") Then
            boolexp = True
            txtbox.ForeColor = Color.Blue
        Else
            MsgBox(" Pincode field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            boolexp = False
        End If

    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getPhoneno
    'Input Type:Textbox
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getPhoneno(ByVal txtbox As System.Windows.Forms.TextBox)
        If regexp.IsMatch(txtbox.Text, "^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$") Then
            boolexp = True
            txtbox.ForeColor = Color.Blue
        Else
            MsgBox(" Phoneno field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            boolexp = False
        End If
    End Sub
    '************************************************************
    'Purpose: To Clear all the textBox control,within a group Box
    'Function Name: clearPanel
    'Input Type: panel 
    'Return Type:Nothing
    'Author:Avinash
    'Date:30/08/2006
    '************************************************************
    Public Sub clearform(ByVal frm As System.Windows.Forms.Form)
        Dim ctrl As New Control
        For Each ctrl In frm.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                'ctrl.Text = ""
            End If
        Next ctrl
    End Sub
    '************************************************************
    'Purpose: To Open the text file
    'Function Name: OpenTextFile
    'Input Type: String 
    'Return Type:Nothing
    'Author:Avinash
    'Date:30/08/2006
    '************************************************************
    Public Sub OpenTextFile(ByVal VOutputfile As String)
        If Dir(AppPath & "\Reports\" & Trim(VOutputfile & "") & ".txt") <> "" Then
            If Dir(AppPath & "\Wordpad.exe") <> "" Then
                Shell(AppPath & "\Wordpad.exe " & AppPath & "\Reports\" & VOutputfile & ".txt", vbMaximizedFocus)
            Else
                MessageBox.Show("Wordpad.Exe Not Found in your System", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
        Else
            MessageBox.Show(VOutputfile & " Not Found in your System", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub
    '************************************************************
    'Purpose: To Print the text file
    'Function Name: PrintTextFile
    'Input Type: String 
    'Return Type:Nothing
    'Author:Avinash
    'Date:30/08/2006
    '************************************************************
    Public Sub PrintTextFile(ByVal VOutputfile As String)
        Dim Filewrite As StreamWriter
        If Dir(Trim(VOutputfile & "")) <> "" Then
            VOutputfile = Mid(VOutputfile, 1, VOutputfile.Length - 4)
            Filewrite = File.AppendText(VOutputfile & ".bat")
            Filewrite.WriteLine("Type " & VOutputfile & ".txt > \\" & computername & "\" & Printername)
            Filewrite.Close()
            Call Shell(VOutputfile & ".bat", vbHide)
        Else
            MessageBox.Show(VOutputfile & " Not Found in your System", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub
    '************************************************************
    'Purpose: To Print the text file
    'Function Name: Checkdaterangevalidate
    'Input Type: Startingdate,Endingdate 
    'Return Type:Boolean
    'Author:Prasant
    'Date:30/08/2006
    '************************************************************
    Public Function Checkdaterangevalidate(ByVal Startdate As Date, ByVal Enddate As Date) As Boolean
        chkdatevalidate = True
        If DateDiff(DateInterval.Day, Enddate, DateValue(Now)) < 0 Then
            MessageBox.Show("To Date cannot be greater than Current Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            chkdatevalidate = False
            Exit Function
        End If
        If DateDiff(DateInterval.Day, Startdate, Enddate) < 0 Then
            MessageBox.Show("From Date cannot be greater than To Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            chkdatevalidate = False
            Exit Function
        End If
        If CDate(Startdate) >= CDate(Startdate) And CDate(Enddate) <= CDate(Enddate) Then
            chkdatevalidate = True
        Else
            MsgBox("Date should be within Financial Year", MsgBoxStyle.Critical)
            chkdatevalidate = False
            Exit Function
        End If
        Return chkdatevalidate
    End Function
    '************************************************************
    'Purpose: To Print the text file
    'Function Name: Checkdatevalidate
    'Input Type: Startingdate 
    'Return Type:Boolean
    'Author:Prasant
    'Date:30/08/2006
    '************************************************************
    Public Function Checkdatevalidate(ByVal Startdate As Date) As Boolean
        chkdatevalidate = True
        If DateDiff(DateInterval.Day, Startdate, DateValue(Now)) < 0 Then
            MessageBox.Show("To Date cannot be greater than Current Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            chkdatevalidate = False
            'Exit Function
        End If
        If FyearDateCheck(Startdate) = False Then
            chkdatevalidate = False
            MessageBox.Show("Date should be within the Financial year", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            'Exit Function
        End If
        'If (DateDiff(DateInterval.Day, Startdate, DateValue("01-APR-" & gFinancalyearStart)) < 0) Or (DateDiff(DateInterval.Day, DateValue("31-MAR-" & gFinancialyearEnd), Startdate) < 0) Then
        '    MsgBox(DateDiff(DateInterval.Day, Startdate, DateValue("01-APR-" & gFinancalyearStart)))
        '    MsgBox(DateDiff(DateInterval.Day, DateValue("31-MAR-" & gFinancialyearEnd), Startdate))
        '    MessageBox.Show("Date should be within the Financial year", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    chkdatevalidate = False
        '    Exit Function
        'End If
        Return chkdatevalidate
    End Function
    '************************************************************
    'Purpose: To Print the text file
    'Function Name: PrintTextFile
    'Input Type: String 
    'Return Type:Nothing
    'Author:Shuvendu
    'Date:30/08/2006
    '************************************************************
    Public Function FyearDateCheck(ByVal Vdate As String) As Boolean
        FyearDateCheck = True
        Dim StartDate As String
        Dim EndDate As String
        StartDate = "01-APR-" & gFinancalyearStart
        EndDate = "31-MAR-" & gFinancialyearEnd
        If CDate(Vdate) >= CDate(StartDate) And CDate(Vdate) <= CDate(EndDate) Then
            FyearDateCheck = True
        Else
            FyearDateCheck = False
        End If
    End Function
    Public Function CalAverageRate(ByVal ITEMCODE As String) As Double
        Dim Opquantity, Opamount, Grnquantity, Grnamount As Double
        Dim Calquantity, Issuequantity, Issueamount As Double
        Dim transferqty, transferamount As Double
        Dim Calrate, Clsquantity As Double
        Dim sqlstring As String
        Dim opRate, grnRate, IssRate As Double
        '''********************************** CALCULATION OF AVERAGE FOR A PARTICULAR ITEM ***************'''
        ''''********************************* FEATCH FROM OPENING STOCK ******************************************'''
        sqlstring = "SELECT ISNULL(OPSTOCK,0) AS OPSTOCK,ISNULL(OPVALUE,0) AS OPVALUE FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'"
        gconnection.getDataSet(sqlstring, "INVENTORYITEM")
        If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
            Opquantity = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
            Opamount = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPVALUE")), "0.00")
        Else
            Opquantity = 0
            Opamount = 0
        End If
        ''''********************************* FEATCH FROM GRN_DETAILS ********************************************'''
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(AMOUNT),0) AS AMOUNT FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOIDITEM,'') <>'Y'"
        gconnection.getDataSet(sqlstring, "GRN_DETAILS")
        If gdataset.Tables("GRN_DETAILS").Rows.Count > 0 Then
            Grnquantity = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("QTY")), "0.000")
            Grnamount = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("AMOUNT")), "0.00")
        Else
            Grnquantity = 0
            Grnamount = 0
        End If
        ''''********************************* FROM STOCKISSUEDETAILS ***************************************'''
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(AMOUNT),0) AS AMOUNT FROM STOCKISSUEDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            Issuequantity = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("Qty")), "0.000")
            Issueamount = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("AMOUNT")), "0.00")
        Else
            Issuequantity = 0
            Issueamount = 0
        End If
        ''********************************** FROM STOCKRETURNDETAILS ***********************************************
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(AMOUNT),0) AS AMOUNT FROM STOCKtransferDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'')<>'Y' and doctype='RET' "
        gconnection.getDataSet(sqlstring, "STOCKtransferDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            transferqty = Format(Val(gdataset.Tables("STOCKtransferDETAIL").Rows(0).Item("Qty")), "0.000")
            transferamount = Format(Val(gdataset.Tables("STOCKtransferDETAIL").Rows(0).Item("AMOUNT")), "0.00")
        Else
            transferqty = 0
            transferamount = 0
        End If

        ''' ********************************* CALCULATE CLOSING BALANCE *********************************'''

        'Clsquantity = (Val(Opquantity) + Val(Grnquantity) - Val(Issuequantity))
        Clsquantity = (Val(Opquantity) + Val(Grnquantity) - Val(Issuequantity) + Val(transferqty))
        If Clsquantity = 0 Then
            If Grnquantity <> 0 Then
                Calrate = Val(Grnamount) / Val(Grnquantity)
                'TO CORRECT THE PROBLEM IN CALCULATING WEIGHTED AVERAGE RATE
            ElseIf Issuequantity <> 0 Then
                sqlstring = "SELECT TOP 1 ISNULL(RATE,0) RATE FROM STOCKISSUEDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'')<>'Y'"
                gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
                If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
                    Calrate = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("RATE")), "0.00")
                End If
            Else
                sqlstring = "SELECT ISNULL(PURCHASERATE,0) PURCHASERATE FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'"
                gconnection.getDataSet(sqlstring, "INVENTORYITEM")
                If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
                    Calrate = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("PURCHASERATE")), "0.00")
                End If
            End If
            '***********************************************(
        Else
            Calrate = (Val(Opamount) + Val(Grnamount) - Val(Issueamount) + Val(transferamount)) / (Val(Clsquantity))
        End If
        '''********************************** COMPLETE CALCULATION OF AVERAGE FOR PARTICULAR ITEM  ********'''
        'Calrate = (opRate + grnRate + IssRate) / 3
        Return Calrate
    End Function
    Public Function CalAverageQuantity(ByVal ITEMCODE As String) As Double
        Dim Opquantity, Opamount, Grnquantity, Grnamount As Double
        Dim Calquantity, Issuequantity, Issueamount As Double
        Dim Calrate, Clsquantity As Double
        Dim sqlstring As String
        '''********************************** CALCULATION OF AVERAGE FOR A PARTICULAR ITEM ***************'''
        ''''********************************* FEATCH FROM OPENING STOCK ******************************************'''
        sqlstring = "SELECT ISNULL(OPSTOCK,0) AS OPSTOCK,ISNULL(OPVALUE,0) AS OPVALUE FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'"
        gconnection.getDataSet(sqlstring, "INVENTORYITEM")
        If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
            Opquantity = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
            Opamount = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPVALUE")), "0.00")
        Else
            Opquantity = 0
            Opamount = 0
        End If
        ''''********************************* FEATCH FROM GRN_DETAILS ********************************************'''
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(AMOUNT),0) AS AMOUNT FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOIDITEM,'') <>'Y'"
        gconnection.getDataSet(sqlstring, "GRN_DETAILS")
        If gdataset.Tables("GRN_DETAILS").Rows.Count > 0 Then
            Grnquantity = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("QTY")), "0.000")
            Grnamount = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("AMOUNT")), "0.00")
        Else
            Grnquantity = 0
            Grnamount = 0
        End If
        ''''********************************* FROM STOCKISSUEDETAILS ***************************************'''
        sqlstring = "SELECT ISNULL(SUM(QTY),0) AS QTY ,ISNULL(SUM(AMOUNT),0) AS AMOUNT FROM STOCKISSUEDETAIL WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            Issuequantity = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("Qty")), "0.000")
            Issueamount = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("AMOUNT")), "0.00")
        Else
            Issuequantity = 0
            Issueamount = 0
        End If
        ''' ********************************* CALCULATE CLOSING BALANCE *********************************'''
        Clsquantity = (Val(Opquantity) + Val(Grnquantity) - Val(Issuequantity))
        If Clsquantity = 0 Then
            Calrate = Val(Grnamount) / Val(Grnquantity)
        Else
            Calrate = (Val(Opamount) + Val(Grnamount) - Val(Issueamount)) / (Val(Clsquantity))
        End If
        '''********************************** COMPLETE CALCULATION OF AVERAGE FOR PARTICULAR ITEM  ********'''
        Return Clsquantity
    End Function
    Public Function ClosingQuantity(ByVal ITEMCODE As String, ByVal STORECODE As String) As Double
        Dim AdjustQty, ClsQty, MainstockQty, TransQty, TransFromQty, TransToQty As Double
        Dim OpQty, GrnQty, IssueQty, ReturnQty, ReturnFromQty, ReturnToQty, IssueToQty, IssueFromQty As Double
        Dim sqlstring As String
        Dim i As Integer
        '''*************************************** CALCULATION OF CLOSING QUANTITY FOR A PARTICULAR ITEM ***********************'''
        sqlstring = "SELECT ISNULL(STORESTATUS,'') AS STORESTATUS FROM STOREMASTER WHERE ISNULL(STORECODE,'') = '" & Trim(STORECODE) & "' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STORECODE ASC"
        gconnection.getDataSet(sqlstring, "STOREMASTER")
        If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
            If Trim(gdataset.Tables("STOREMASTER").Rows(0).Item("STORESTATUS")) = "M" Then
                ''''********************************* FETCH FROM OPENING STOCK ******************************************'''
                sqlstring = "SELECT ISNULL(OPSTOCK,0) * ISNULL(CONVVALUE,0) AS OPSTOCK1,ISNULL(OPSTOCK,0) AS OPSTOCK FROM INVENTORYITEMMASTER WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(FREEZE,'') <> 'Y'"
                gconnection.getDataSet(sqlstring, "INVENTORYITEM")
                If gdataset.Tables("INVENTORYITEM").Rows.Count > 0 Then
                    OpQty = Format(Val(gdataset.Tables("INVENTORYITEM").Rows(0).Item("OPSTOCK")), "0.000")
                Else
                    OpQty = 0
                End If
                ''''********************************* FETCH FROM GRN_DETAILS ********************************************'''
                sqlstring = "SELECT ISNULL(SUM(DBLAMOUNT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY  FROM GRN_DETAILS WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND ISNULL(VOIDITEM,'') <>'Y'"
                gconnection.getDataSet(sqlstring, "GRN_DETAILS")
                If gdataset.Tables("GRN_DETAILS").Rows.Count > 0 Then
                    GrnQty = Format(Val(gdataset.Tables("GRN_DETAILS").Rows(0).Item("QTY")), "0.000")
                Else
                    GrnQty = 0
                End If
            End If
            ''''********************************* FROM STOCK RETURN *****************************************'''
            'sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
            'sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND TOSTORECODE = '" & Trim(STORECODE) & "' AND ISNULL(DOCTYPE,'')  = 'RET' AND ISNULL(VOID,'')<>'Y'"
            'gconnection.getDataSet(sqlstring, "STOCKRETURNDETAILS")
            'If gdataset.Tables("STOCKRETURNDETAILS").Rows.Count > 0 Then
            '    ReturnQty = Format(Val(gdataset.Tables("STOCKRETURNDETAILS").Rows(0).Item("QTY")), "0.000")
            'Else
            '    ReturnQty = 0
            'End If
            '==========================      
            MainstockQty = GrnQty + OpQty
        End If

        ''''********************************* FROM STOCKISSUEDETAILS ***************************************'''
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKISSUEDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            IssueFromQty = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")), "0.000")
        Else
            IssueFromQty = 0
        End If
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKISSUEDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND OPSTORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKISSUEDETAIL")
        If gdataset.Tables("STOCKISSUEDETAIL").Rows.Count > 0 Then
            IssueToQty = Format(Val(gdataset.Tables("STOCKISSUEDETAIL").Rows(0).Item("QTY")), "0.000")
        Else
            IssueToQty = 0
        End If
        IssueQty = IssueToQty - IssueFromQty
        ''''********************************* FROM STOCKADJUSTMENT ***************************************'''
        sqlstring = "SELECT ISNULL(SUM(DBLAMOUNT),0) AS QTY1,ISNULL(SUM(ADJUSTEDSTOCK),0) AS QTY FROM STOCKADJUSTDETAILS "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND STORELOCATIONCODE = '" & Trim(STORECODE) & "' AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKADJUSTDETAILS")
        If gdataset.Tables("STOCKADJUSTDETAILS").Rows.Count > 0 Then
            AdjustQty = Format(Val(gdataset.Tables("STOCKADJUSTDETAILS").Rows(0).Item("QTY")), "0.000")
        Else
            AdjustQty = 0
        End If
        '''********************************* FROM STOCK TRANSFER *****************************************'''
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND FROMSTORECODE = '" & Trim(STORECODE) & "'  AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKTRANSDETAILS")
        If gdataset.Tables("STOCKTRANSDETAILS").Rows.Count > 0 Then
            TransFromQty = Format(Val(gdataset.Tables("STOCKTRANSDETAILS").Rows(0).Item("QTY")), "0.000")
        Else
            TransFromQty = 0
        End If
        sqlstring = "SELECT ISNULL(SUM(DBLAMT),0) AS QTY1,ISNULL(SUM(QTY),0) AS QTY FROM STOCKTRANSFERDETAIL "
        sqlstring = sqlstring & " WHERE ITEMCODE='" & Trim(ITEMCODE) & "' AND TOSTORECODE = '" & Trim(STORECODE) & "'  AND ISNULL(VOID,'')<>'Y'"
        gconnection.getDataSet(sqlstring, "STOCKTRANSDETAILS1")
        If gdataset.Tables("STOCKTRANSDETAILS1").Rows.Count > 0 Then
            TransToQty = Format(Val(gdataset.Tables("STOCKTRANSDETAILS1").Rows(0).Item("QTY")), "0.000")
        Else
            TransToQty = 0
        End If
        TransQty = TransToQty - TransFromQty
        ''' ********************************* CALCULATE CLOSING QUANTITY *********************************'''
        sqlstring = "SELECT ISNULL(STORESTATUS,'') AS STORESTATUS FROM STOREMASTER WHERE ISNULL(STORECODE,'') = '" & Trim(STORECODE) & "' AND ISNULL(FREEZE,'') <> 'Y' ORDER BY STORECODE ASC"
        gconnection.getDataSet(sqlstring, "STOREMASTER")
        If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
            If Trim(gdataset.Tables("STOREMASTER").Rows(i).Item("STORESTATUS")) = "M" Then
                ClsQty = (Val(MainstockQty) + Val(AdjustQty)) + Val(IssueQty) + Val(TransQty)
            Else
                ClsQty = (Val(MainstockQty) + Val(AdjustQty)) + Val(IssueQty) + Val(TransQty)
            End If
        End If

        '''********************************** COMPLETE CALCULATION QUANTITY ******************************'''
        Return ClsQty
    End Function
    Public Function GetPassword(ByVal vUser As String) As String
        Dim Vdesc, vPass As String
        Dim vAsc, Loopindex As Long
        Vdesc = ""
        For Loopindex = 1 To Len(vUser)
            Vdesc = Mid(vUser, Loopindex, 1)
            vAsc = Asc(Vdesc) + 150
            vPass = Trim(vPass) & Chr(vAsc)
        Next Loopindex
        Return vPass
    End Function
    Public Function ExportTo(ByVal ssgrid As AxFPSpreadADO.AxfpSpread)
        Try
            Dim X As Boolean
            Dim vpath As String
            Dim vLog As String
            Dim strpath As String
            vpath = Application.StartupPath & "\Reports\Monprtn"
            vLog = Application.StartupPath & "\Reports\Monprtn.Txt"
            X = ssgrid.ExportRangeToTextFile(0, 0, ssgrid.Col2, ssgrid.Row2, Application.StartupPath & "\Reports\One.txt", "", ",", vbCrLf, FPSpreadADO.ExportRangeToTextFileConstants.ExportRangeToTextFileCreateNewFile, Application.StartupPath & "\Reports\One.log")
            With ssgrid
                If Dir(vpath & ".Xls") <> "" Then
                    Kill(vpath & ".Xls")
                End If
                X = .ExportToExcel(vpath & ".Xls", "", "")
                strpath = strexcelpath & " " & vpath & ".xls"
                Call Shell(strpath, AppWinStyle.NormalFocus)
            End With
        Catch ex As Exception
            MessageBox.Show("Before Opening New EXCEL Sheet Close Previous EXCEL sheet", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function
    'FOR DUPLICATE CARD ID
    'FILTER THE ADDED STRINGS IN THE 16_DIGIT_CODE
    'DDYYYYCARDIDMM --> DUPLICATE CARD ID FORMAT
    Public Function CardIdValidate(ByVal vCardID As String) As Boolean
        Try
            Dim vSQL, vDay, vDate, vMonth As String
            vTmp = vCardID.Substring(6, 11)
            vSQL = "SELECT * FROM SM_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(vTmp) & "' AND ISNULL(CARDCODE,'')<>'' "
            gconnection.getDataSet(vSQL, "SM_MEM_LINKAGE1")
            vCardcode = gdataset.Tables("SM_MEM_LINKAGE1").Rows(0).Item("CARDCODE")
            vDate = Format(DateTime.Today.Now, "dd/MM/yyyy")
            vDay = vDate.Substring(0, 2)
            vMonth = vDate.Substring(3, 2)
            If gdataset.Tables("SM_MEM_LINKAGE1").Rows.Count > 0 And Trim(vCardID.Substring(0, 2)) = Trim(vDay) And Trim(vCardID.Substring(17, 2)) = Trim(vMonth) Then
                Cardidcheck = True
                CardIdValidate = True
            Else
                vTmp = " "
                CardIdValidate = False
                Cardidcheck = False
            End If
        Catch ex As Exception
            Cardidcheck = False
            CardIdValidate = False
            Exit Function
        End Try
    End Function

    'FOR DUPLICATE CARD ID
    'FILTER THE ADDED STRINGS IN THE 16_DIGIT_CODE
    'DDYYYYCARDIDMM --> DUPLICATE CARD ID FORMAT
    'Public Function CardIdValidate_one(ByVal vCardID As String) As Boolean
    '    Try
    '        Dim vSQL, vDay, vDate, vMonth As String
    '        vTmp = vCardID.Substring(6, 11)
    '        vSQL = "SELECT * FROM SM_MEM_LINKAGE WHERE [16_DIGIT_CODE]='" & Trim(vTmp) & "' AND ISNULL(CARDCODE,'NULL')<>'NULL' "
    '        gconnection.getDataSet(vSQL, "SM_MEM_LINKAGE")
    '        vDate = Format(DateTime.Today.Now, "dd/MM/yyyy")
    '        vDay = vDate.Substring(0, 2)
    '        vMonth = vDate.Substring(3, 2)
    '        If gdataset.Tables("SM_MEM_LINKAGE").Rows.Count > 0 And Trim(vCardID.Substring(0, 2)) = Trim(vDay) And Trim(vCardID.Substring(17, 2)) = Trim(vMonth) Then
    '            Cardidcheck = True
    '            CardIdValidate_one = True
    '        Else
    '            vTmp = " "
    '            CardIdValidate_one = False
    '            Cardidcheck = False
    '        End If
    '    Catch ex As Exception
    '        Exit Function
    '    End Try
    'End Function

    Public Function Itemvalidate(ByVal SSGRID As AxFPSpreadADO.AxfpSpread, ByVal ITEMCODE As String, ByVal COLPOS As Integer) As Boolean
        Try
            Dim Loopindex, Counter As Integer
            Itemvalidate = False
            Counter = 0 : Loopindex = 1
            For Loopindex = 1 To SSGRID.DataRowCnt
                SSGRID.Col = COLPOS
                SSGRID.Row = Loopindex
                If Trim(SSGRID.Text) = Trim(ITEMCODE) Then
                    Counter = Counter + 1
                End If
                If Counter >= 2 Then
                    SSGRID.Col = COLPOS
                    SSGRID.Row = SSGRID.ActiveRow
                    MessageBox.Show("Duplicate item please check", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    SSGRID.ClearRange(1, SSGRID.ActiveRow, 15, SSGRID.ActiveRow, True)
                    Itemvalidate = True
                End If
            Next Loopindex
        Catch ex As Exception
        End Try
    End Function
    Public Sub PrintTextFile1(ByVal VOutputfile As String)
        Dim Filewrite As StreamWriter
        If Dir(Trim(VOutputfile & "")) <> "" Then
            VOutputfile = Mid(VOutputfile, 1, VOutputfile.Length - 4)
            Filewrite = File.AppendText(VOutputfile & ".bat")
            If computername = "" Or Printername = "" Then
                Filewrite.WriteLine("Type " & VOutputfile & ".txt >> prn")
            Else
                Filewrite.WriteLine("Type " & VOutputfile & ".txt > \\" & computername & "\" & Printername)
            End If
            Filewrite.Close()
            Call Shell(VOutputfile & ".bat", vbHide)
        Else
            MessageBox.Show(VOutputfile & " Not Found in your System", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub
    ' Function for conversion of a Indian Rupees into words
    '   Parameter - accept a Currency
    '   Returns the number in words format
    '   You can use this function in Excel, VBA, VB6,.NET
    '====================================================

    '****************************************************
    ' Code Created by 

    '****************************************************
    Function RupeesToWord(ByVal MyNumber)
        Dim Temp
        Dim Rupees, Paisa As String
        Dim DecimalPlace, iCount
        Dim Hundreds, Words As String
        Dim place(9) As String
        place(0) = " Thousand "
        place(2) = " Lakh "
        place(4) = " Crore "
        place(6) = " Arab "
        place(8) = " Kharab "
        On Error Resume Next
        ' Convert MyNumber to a string, trimming extra spaces.
        MyNumber = Trim(Str(MyNumber))

        ' Find decimal place.
        DecimalPlace = InStr(MyNumber, ".")

        ' If we find decimal place...
        If DecimalPlace > 0 Then
            ' Convert Paisa
            Temp = Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2)
            Paisa = " and " & ConvertTens(Temp) & " Paisa"

            ' Strip off paisa from remainder to convert.
            MyNumber = Trim(Left(MyNumber, DecimalPlace - 1))
        End If

        '===============================================================
        Dim TM As String  ' If MyNumber between Rs.1 To 99 Only.
        TM = Right(MyNumber, 2)

        If Len(MyNumber) > 0 And Len(MyNumber) <= 2 Then
            If Len(TM) = 1 Then
                Words = ConvertDigit(TM)
                RupeesToWord = "Rupees " & Words & Paisa & " Only"

                Exit Function

            Else
                If Len(TM) = 2 Then
                    Words = ConvertTens(TM)
                    RupeesToWord = "Rupees " & Words & Paisa & " Only"
                    Exit Function

                End If
            End If
        End If
        '===============================================================


        ' Convert last 3 digits of MyNumber to ruppees in word.
        Hundreds = ConvertHundreds(Right(MyNumber, 3))
        ' Strip off last three digits
        MyNumber = Left(MyNumber, Len(MyNumber) - 3)

        iCount = 0
        Do While MyNumber <> ""
            'Strip last two digits
            Temp = Right(MyNumber, 2)
            If Len(MyNumber) = 1 Then


                If Trim(Words) = "Thousand" Or _
                Trim(Words) = "Lakh  Thousand" Or _
                Trim(Words) = "Lakh" Or _
                Trim(Words) = "Crore" Or _
                Trim(Words) = "Crore  Lakh  Thousand" Or _
                Trim(Words) = "Arab  Crore  Lakh  Thousand" Or _
                Trim(Words) = "Arab" Or _
                Trim(Words) = "Kharab  Arab  Crore  Lakh  Thousand" Or _
                Trim(Words) = "Kharab" Then

                    Words = ConvertDigit(Temp) & place(iCount)
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)

                Else

                    Words = ConvertDigit(Temp) & place(iCount) & Words
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)

                End If
            Else

                If Trim(Words) = "Thousand" Or _
                   Trim(Words) = "Lakh  Thousand" Or _
                   Trim(Words) = "Lakh" Or _
                   Trim(Words) = "Crore" Or _
                   Trim(Words) = "Crore  Lakh  Thousand" Or _
                   Trim(Words) = "Arab  Crore  Lakh  Thousand" Or _
                   Trim(Words) = "Arab" Then


                    Words = ConvertTens(Temp) & place(iCount)


                    MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                Else

                    '=================================================================
                    ' if only Lakh, Crore, Arab, Kharab

                    If Trim(ConvertTens(Temp) & place(iCount)) = "Lakh" Or _
                       Trim(ConvertTens(Temp) & place(iCount)) = "Crore" Or _
                       Trim(ConvertTens(Temp) & place(iCount)) = "Arab" Then

                        Words = Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    Else
                        Words = ConvertTens(Temp) & place(iCount) & Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    End If

                End If
            End If

            iCount = iCount + 2
        Loop

        RupeesToWord = "Rupees " & Words & Hundreds & Paisa & " Only"
    End Function
    ' Conversion for hundreds
    '*****************************************
    Private Function ConvertHundreds(ByVal MyNumber)
        Dim Result As String

        ' Exit if there is nothing to convert.
        If Val(MyNumber) = 0 Then Exit Function

        ' Append leading zeros to number.
        MyNumber = Right("000" & MyNumber, 3)

        ' Do we have a hundreds place digit to convert?
        If Left(MyNumber, 1) <> "0" Then
            Result = ConvertDigit(Left(MyNumber, 1)) & " Hundreds "
        End If

        ' Do we have a tens place digit to convert?
        If Mid(MyNumber, 2, 1) <> "0" Then
            Result = Result & ConvertTens(Mid(MyNumber, 2))
        Else
            ' If not, then convert the ones place digit.
            Result = Result & ConvertDigit(Mid(MyNumber, 3))
        End If

        ConvertHundreds = Trim(Result)
    End Function

    ' Conversion for tens
    '*****************************************
    Private Function ConvertTens(ByVal MyTens)
        Dim Result As String

        ' Is value between 10 and 19?
        If Val(Left(MyTens, 1)) = 1 Then
            Select Case Val(MyTens)
                Case 10 : Result = "Ten"
                Case 11 : Result = "Eleven"
                Case 12 : Result = "Twelve"
                Case 13 : Result = "Thirteen"
                Case 14 : Result = "Fourteen"
                Case 15 : Result = "Fifteen"
                Case 16 : Result = "Sixteen"
                Case 17 : Result = "Seventeen"
                Case 18 : Result = "Eighteen"
                Case 19 : Result = "Nineteen"
                Case Else
            End Select
        Else
            ' .. otherwise it's between 20 and 99.
            Select Case Val(Left(MyTens, 1))
                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Forty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eighty "
                Case 9 : Result = "Ninety "
                Case Else
            End Select

            ' Convert ones place digit.
            Result = Result & ConvertDigit(Right(MyTens, 1))
        End If

        ConvertTens = Result
    End Function

    Private Function ConvertDigit(ByVal MyDigit)
        Select Case Val(MyDigit)
            Case 1 : ConvertDigit = "One"
            Case 2 : ConvertDigit = "Two"
            Case 3 : ConvertDigit = "Three"
            Case 4 : ConvertDigit = "Four"
            Case 5 : ConvertDigit = "Five"
            Case 6 : ConvertDigit = "Six"
            Case 7 : ConvertDigit = "Seven"
            Case 8 : ConvertDigit = "Eight"
            Case 9 : ConvertDigit = "Nine"
            Case Else : ConvertDigit = ""
        End Select
    End Function
    
End Module