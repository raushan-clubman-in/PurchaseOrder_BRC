Imports System.Net.Mail
Imports System.Net
Imports System.Data.SqlClient
Imports System.IO
Imports System.Data
Imports System.Threading
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports outlook = Microsoft.Office.Interop.Outlook

Public Class EMAILPOSTING
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass

    Public indentstr, indentno, quotationno As String
    Public indentdt, qoutationdt As Date
    Friend WithEvents txt_ccmail As System.Windows.Forms.TextBox


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txttomailid As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txt_subject As System.Windows.Forms.TextBox
    Friend WithEvents txtebody As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SSGRIDVIEW As AxFPSpreadADO.AxfpSpread
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMAILPOSTING))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txttomailid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_subject = New System.Windows.Forms.TextBox()
        Me.SSGRIDVIEW = New AxFPSpreadADO.AxfpSpread()
        Me.txtebody = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_ccmail = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.SSGRIDVIEW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(187, 510)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 35)
        Me.Panel1.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(240, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "EXIT"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(128, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "CANCEL"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "POST"
        '
        'txttomailid
        '
        Me.txttomailid.Enabled = False
        Me.txttomailid.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttomailid.Location = New System.Drawing.Point(159, 451)
        Me.txttomailid.Name = "txttomailid"
        Me.txttomailid.Size = New System.Drawing.Size(184, 22)
        Me.txttomailid.TabIndex = 2
        Me.txttomailid.Text = "pur@kga.in"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 457)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Your Gmail ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(367, 457)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CC Mail ID"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMM"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(379, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(65, 29)
        Me.DateTimePicker1.TabIndex = 7
        Me.DateTimePicker1.Value = New Date(2009, 11, 10, 0, 0, 0, 0)
        Me.DateTimePicker1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(159, 415)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(206, 22)
        Me.TextBox3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 419)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Add Attachments"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(383, 418)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "SUBJECT"
        '
        'Txt_subject
        '
        Me.Txt_subject.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_subject.Location = New System.Drawing.Point(491, 415)
        Me.Txt_subject.Name = "Txt_subject"
        Me.Txt_subject.Size = New System.Drawing.Size(206, 22)
        Me.Txt_subject.TabIndex = 10
        '
        'SSGRIDVIEW
        '
        Me.SSGRIDVIEW.DataSource = Nothing
        Me.SSGRIDVIEW.Location = New System.Drawing.Point(5, 37)
        Me.SSGRIDVIEW.Name = "SSGRIDVIEW"
        Me.SSGRIDVIEW.OcxState = CType(resources.GetObject("SSGRIDVIEW.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRIDVIEW.Size = New System.Drawing.Size(761, 373)
        Me.SSGRIDVIEW.TabIndex = 0
        '
        'txtebody
        '
        Me.txtebody.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtebody.Location = New System.Drawing.Point(159, 480)
        Me.txtebody.Multiline = True
        Me.txtebody.Name = "txtebody"
        Me.txtebody.Size = New System.Drawing.Size(538, 28)
        Me.txtebody.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 483)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Message Body"
        '
        'txt_ccmail
        '
        Me.txt_ccmail.Enabled = False
        Me.txt_ccmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ccmail.Location = New System.Drawing.Point(491, 450)
        Me.txt_ccmail.Name = "txt_ccmail"
        Me.txt_ccmail.Size = New System.Drawing.Size(206, 22)
        Me.txt_ccmail.TabIndex = 14
        '
        'EMAILPOSTING
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = Global.SmartCard.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(768, 549)
        Me.Controls.Add(Me.txt_ccmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtebody)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txt_subject)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txttomailid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SSGRIDVIEW)
        Me.Name = "EMAILPOSTING"
        Me.Text = "EMAIL POSTING"
        Me.Panel1.ResumeLayout(False)
        CType(Me.SSGRIDVIEW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim mail As New MailMessage()
    ' Dim mbill As New QUOTATIONINVITATION
    Private Sub EMAILPOSTING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GRID_VIEW()
        'If UCase(Mid(Trim(gCompanyAddress(0)), 1, 3)) = "UNI" Then
        '    TextBox2.Text = "theunitedclub@gmail.com"
        '    TextBox1.Text = "kswaroop"
        'Else
        Me.DateTimePicker1.Value = Now()

        txt_ccmail.Text = ""
        txt_ccmail.Enabled = True
        txttomailid.Enabled = True
        'End If
        'SSGRIDVIEW.ActiveRow = 1
    End Sub

    Function GRID_VIEW()
        Dim VOutputfile, Vcatefile As String
        Dim sout, rout As String
        Randomize()
        Vcatefile = Mid("CATE" & CStr(Int(Rnd() * 5000)), 1, 8)
        VOutputfile = Mid("SUBS" & CStr(Int(Rnd() * 5000)), 1, 8)
        'Dim rsset As ADODB.Recordset
        sout = Mid("SUS" & CStr(Int(Rnd() * 5000)), 1, 8)
        rout = Mid("REV" & CStr(Int(Rnd() * 5000)), 1, 8)
        Dim Ssql As String
        Dim vroomno As Long
        Dim vsplit() As String
        Dim vAcc As Double
        Dim Total, Debit, Credit, RowNo, I As Double
        Total = 0
        Debit = 0
        Credit = 0
        'If UCase(Mid(Trim(gCompanyAddress(0)), 1, 3)) = "UNI" Then
        '    Ssql = "SELECT MCODE,MNAME,CONTEMAIL,mem_code FROM MEMBERMASTER WHERE isnull(billbasis,'')<>'none'and isnull(freeze,'')<>'y'and curentstatus in('live','absentee')and ISNULL(ltrim(rtrim(CONTEMAIL)),'')<>'' ORDER BY isnull(MCODEc,''),isnull(mcoden,0)"
        'Else
        '    Ssql = "SELECT MCODE,MNAME,CEMAIL AS CONTEMAIL, membertypecode as mem_code FROM MEMBERMASTER WHERE isnull(TERMINATION,'')NOT IN('C','Y')AND ISNULL(ltrim(rtrim(CEMAIL)),'')<>'' ORDER BY membertypecode,MCODE"
        'End If
        'Ssql = "SELECT MCODE,MNAME,CONTEMAIL,mem_code FROM MEMBERMASTER WHERE isnull(billbasis,'')<>'none'and isnull(freeze,'')<>'y'and curentstatus in('live','absentee')and ISNULL(ltrim(rtrim(CONTEMAIL)),'')<>'' ORDER BY isnull(MCODEc,''),isnull(mcoden,0)"
        gconnection.getDataSet(gSQLString, "VENDOR")
        If gdataset.Tables("VENDOR").Rows.Count = 0 Then
            MsgBox("No Records Available ", vbInformation + vbOKOnly, "MESSAGE")
        Else
            For I = 0 To gdataset.Tables("VENDOR").Rows.Count - 1
                With SSGRIDVIEW
                    .Row = I + 1
                    .Col = 1
                    .Text = Trim(gdataset.Tables("VENDOR").Rows(I).Item("vendorcode") & "")
                    .Col = 2
                    .Text = Trim(gdataset.Tables("VENDOR").Rows(I).Item("vendorname") & "")
                    .Col = 3
                    .Text = Trim(gdataset.Tables("VENDOR").Rows(I).Item("EMAIL") & "")
                    .Col = 5
                    .Text = Trim(gdataset.Tables("VENDOR").Rows(I).Item("contactperson") & "")

                End With
                If SSGRIDVIEW.MaxRows < I + 20 Then
                    SSGRIDVIEW.MaxRows = SSGRIDVIEW.MaxRows + 1
                End If
            Next
        End If



    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim i As Integer
            Dim vcode, mailid, MEMCODE, filename, SSQL As String
       
            With SSGRIDVIEW
                For i = 1 To SSGRIDVIEW.DataRowCnt
                    .Row = i

                    .Col = 6
                    If .Value = True Then
                        .Col = 4
                        .Text = "SENDING"
                        .Col = 1
                        vcode = .Text
                        .Col = 3
                        mailid = .Text
                        .Col = 5
                        'mailid = "manish.bhanumca@gmail.com'"
                        MEMCODE = .Text
                     
                        filename = ordnanceclubformail(vcode)
                        Dim f As Boolean
                        If filename <> "" Then
                            'f = sendmail(mailid, filename)
                            Dim esubject, emsg, fpath As String
                            If Txt_subject.Text <> "" Then
                                esubject = Txt_subject.Text
                            Else
                                esubject = "KGA Vendor Quotation"
                            End If
                            If txtebody.Text <> "" Then
                                emsg = txtebody.Text
                            Else
                                emsg = "KGA Vendor Quotation"
                            End If
                            fpath = AppPath & "\Reports\"
                            EMail(mailid, fpath, esubject, emsg, filename, Trim(txt_ccmail.Text))

                        Else
                            Exit Sub
                        End If

                    End If


                Next
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Public Function ordnanceclubformail(ByVal vcode As String) As String
        Dim str, MTYPE(), tspilt() As String
        Dim i As Integer

        Dim Heading(0) As String
        Dim sqlstring, SSQL As String
        Dim vMon As String
        Dim vSdate As Date
        Dim vEdate As Date
        Dim vMonthno, vMonthName As String
        'Dim MCODE As String()

        'vMonthName = MonthName()
        'vMonthno = CInt(Trim(vsplit(1) & ""))
        'vMon = Trim(vsplit(1) & "")
        'If CDbl(vMon) >= 4 And CDbl(vMon) <= 12 Then
        vSdate = Now.Date
        ' vEdate = DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, vSdate)
        'vEdate = DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, vEdate)
        'Else
        'vSdate = CDate("01/" & vMon & "/" & Year(GFINANCIALYEARENDING))
        'vEdate = DateAdd(Microsoft.VisualBasic.DateInterval.Month, 1, vSdate)
        'vEdate = DateAdd(Microsoft.VisualBasic.DateInterval.Day, -1, vEdate)
        'End If
        Try



            gconnection.getDataSet(indentstr, "PO_QUOT")
            If gdataset.Tables("PO_QUOT").Rows.Count > 0 Then
                ' For i = 0 To gdataset.Tables("PO_QUOT").Rows.Count - 1
                Dim rVIEWER As New Viewer
                Dim RPT As New RPT_quotationinvitation
                sqlstring = "SELECT * FROM PO_QUOTATIONINV WHERE QUOTATIONNO='" & quotationno & "' AND "
                sqlstring = sqlstring & "INDENTNO='" & indentno & "' and SUPPLIERCODE = '" & vcode & "' and itemcode in (select itemcode from PO_STOCKINDENTAUTH_DET where QuotFlag='" & quotationno & "' and ISNULL(AUTHORISED,'')='Y')"
                'SQLSTRING = "SELECT DISTINCT  SUPPLIERNAME "
                'SQLSTRING = SQLSTRING & "FROM PO_QUOTATIONINV1 WHERE INDENTNO='" & txt_IndentNo.Text & "'"
                gconnection.getDataSet(sqlstring, "PO_QUOTATIONINV1")
                If gdataset.Tables("PO_QUOTATIONINV1").Rows.Count > 0 Then
                    rVIEWER.ssql = sqlstring
                    rVIEWER.Report = RPT
                    rVIEWER.TableName = "PO_QUOTATIONINV1"

                    Dim TXTOBJ1 As TextObject
                    TXTOBJ1 = RPT.ReportDefinition.ReportObjects("Text1")
                    TXTOBJ1.Text = gCompanyname

                    Dim TXTOBJ2 As TextObject
                    TXTOBJ2 = RPT.ReportDefinition.ReportObjects("Text2")
                    TXTOBJ2.Text = Address1 & " , " & Address2 & " , " & gCity & " - " & gPincode

                    Dim txtobj3 As TextObject
                    txtobj3 = RPT.ReportDefinition.ReportObjects("Text3")
                    txtobj3.Text = "Tel:" & GPHONE & " , Fax:" & gFax & ", Email:" & gEmail & ", Web:" & gWebsite

                    Dim txtobj4 As TextObject
                    txtobj4 = RPT.ReportDefinition.ReportObjects("Text16")
                    txtobj4.Text = "Service Tax:" & gServiceTax & ", Tin No.:" & gTinNo

                    Dim txtobj5 As TextObject
                    txtobj5 = RPT.ReportDefinition.ReportObjects("Text63")
                    txtobj5.Text = indentdt

                    rVIEWER.Show()
                    Randomize()
                    vOutfile = Mid("mem" & (Rnd() * 800000), 1, 8)
                    VFilePath = AppPath & "\Reports\" & vOutfile & ".pdf"

                    CType(RPT, ReportDocument).ExportToDisk(ExportFormatType.PortableDocFormat, VFilePath)
                    rVIEWER.Hide()
                    rVIEWER.Close()
                    RPT = Nothing
                    rVIEWER = Nothing

                End If

                '  Next


            Else
                MsgBox("NO SUCH RECORDS FOUND", MsgBoxStyle.Information)
                Exit Function
            End If







            Return vOutfile & ".pdf"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Function
        End Try
    End Function

    Public Function EMail(ByVal emailid As String, ByVal path As String, ByVal message As String, ByVal filename As String, ByVal files As String, ByVal CCEmailId As String)
        Try
            Dim oApp As outlook._Application
            oApp = New outlook.Application()

            ' Create a new MailItem.
            Dim oMsg As outlook._MailItem
            oMsg = oApp.CreateItem(outlook.OlItemType.olMailItem)
            oMsg.Subject = message
            oMsg.Body = filename
            ' TODO: Replace with a valid e-mail address.
            oMsg.To = emailid
            oMsg.CC = CCEmailId
            ' Add an attachment
            ' TODO: Replace with a valid attachment path.
            Dim sSource As String = path
            ' TODO: Replace with attachment name
            Dim sDisplayName As String = files

            'Dim sBodyLen As String = oMsg.Body.Length
            Dim oAttachs As outlook.Attachments = oMsg.Attachments
            Dim oAttach As outlook.Attachment
            oAttach = oAttachs.Add(sSource & sDisplayName, , 2000 + 1, sDisplayName)

            ' Send
            oMsg.Send()

            ' Clean up
            oApp = Nothing
            oMsg = Nothing
            oAttach = Nothing
            oAttachs = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Private Function sendmail(ByVal mailid As String, ByVal filename As String) As Boolean
        Dim r As Boolean
        Dim SmtpServer As New SmtpClient()
        SmtpServer.Credentials = New Net.NetworkCredential(txttomailid.Text, txt_ccmail.Text)
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp.gmail.com"
        'SmtpServer.Timeout = 1000000
        SmtpServer.EnableSsl = True
        SmtpServer.UseDefaultCredentials = False
        SmtpServer.TargetName = "STARTTLS/smtp.gmail.com"

        mail = New MailMessage()
        'Dim addr() As String = TextBox2.Text.Split(",")
        Dim addr() As String = mailid.Split(",")
        Try
            'If UCase(Mid(Trim(gCompanyAddress(0)), 1, 3)) = "UNI" Then

            '    mail.From = New MailAddress(TextBox2.Text, "Vendor Quotation")
            'Else
            '    mail.From = New MailAddress(TextBox2.Text, "BBSR MONTHBILL")

            'End If
            mail.From = New MailAddress(txttomailid.Text, "Vendor Quotation")
            Dim i As Byte
            For i = 0 To addr.Length - 1
                mail.To.Add(addr(i))
            Next
            If UCase(Mid(Trim(gCompanyAddress(0)), 1, 3)) = "UNI" Then

                mail.Subject = " MONTHBILL FROM THE UNITED CLUB"
                mail.Body = "PLEASE FIND THE ATTACHMENT AS YOUR MONTHBILL( note: please open the attachment with wordpad for better look and feel)"
            Else
                mail.Subject = Txt_subject.Text
                mail.Body = "PLEASE FIND THE ATTACHMENT " & txtebody.Text

            End If
            If filename <> "" Then
                mail.Attachments.Add(New Attachment(filename))
            End If
            If Trim(Me.TextBox3.Text) <> "" Then
                mail.Attachments.Add(New Attachment(Trim(Me.TextBox3.Text)))
            End If
            ' Dim interval As Integer = 100000
            'Dim sw As New Stopwatch
            'sw.Start()
            'Do While sw.ElapsedMilliseconds < interval
            ' Allows UI to remain responsive
            'Application.DoEvents()
            'Loop
            'sw.Stop()
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            mail.ReplyTo = New MailAddress(txttomailid.Text)
            r = True
            'dim  client as new SmtpClient(args[1])
            'client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            SmtpServer.Timeout = 1000000
            SmtpServer.Send(mail)

        Catch ex As Exception
            MsgBox(ex.ToString())
            r = False
        End Try
        Return r

        'MsgBox("The form is setteled in real ?Environment please insure that the framework 2.0 is installed?")
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub SSGRIDVIEW_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles SSGRIDVIEW.KeyDownEvent
        Dim I As Integer
        Dim VSTR As Integer
        If e.keyCode = Keys.F2 Then
            I = SSGRIDVIEW.ActiveRow

            If SSGRIDVIEW.DataRowCnt > I + 50 Then
                For I = SSGRIDVIEW.ActiveRow To SSGRIDVIEW.ActiveRow + 50
                    With SSGRIDVIEW
                        .Row = I
                        .Col = 6
                        If .IsCellSelected(1, I) = False Then
                            .Text = 1
                        End If
                    End With
                Next
            Else
                For I = SSGRIDVIEW.ActiveRow To SSGRIDVIEW.DataRowCnt
                    With SSGRIDVIEW
                        .Row = I
                        .Col = 6
                        If .IsCellSelected(1, I) = False Then
                            .Text = 1
                        End If
                    End With
                Next
            End If

        End If
        If e.keyCode = Keys.F3 Then
            For I = SSGRIDVIEW.ActiveRow To SSGRIDVIEW.DataRowCnt
                With SSGRIDVIEW
                    .Row = I
                    .Col = 6
                    .Text = 0
                End With
            Next
        ElseIf e.keyCode = Keys.F7 Then
            'Mk Kannan
            'Added on 12 Nov 07 for Searching
            'Begin
            Dim frmSrc As New frmSearch
            frmSrc.farPoint = SSGRIDVIEW
            frmSrc.ShowDialog(Me)
            'GroupBox2.Top = 321
            'GroupBox2.Left = 287
            'TextBox1.Text = ""
            'vstrchk = "7"
            'TextBox1.Focus()
            'End
        End If

    End Sub

    Private Sub DateTimePicker1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim SSQL As String
            Dim I, j As Integer
            SSQL = "SELECT MCODE,MEMCODE,STATUS  FROM EMAILSTATUS WHERE MONTHNO=" & Month(Me.DateTimePicker1.Value) & ""
            gconnection.getDataSet(SSQL, "RAU")
            If gdataset.Tables("RAU").Rows.Count > 0 Then
                For I = 0 To gdataset.Tables("RAU").Rows.Count - 1
                    With SSGRIDVIEW
                        For j = 0 To SSGRIDVIEW.DataRowCnt - 1
                            .Row = j + 1
                            .Col = 1
                            If .Text = Trim(gdataset.Tables("RAU").Rows(I).Item("MCODE") & "") Then
                                .Col = 4
                                .Text = Trim(gdataset.Tables("RAU").Rows(I).Item("STATUS") & "")
                            End If
                        Next


                    End With
                Next
            End If
        End If
    End Sub



    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim file As New OpenFileDialog

        If file.ShowDialog = DialogResult.OK Then
            TextBox3.Text = file.FileName
            'ppath = File.FileName
            'PHOTO.Checked = True
        Else
            TextBox3.Text = ""
        End If
    End Sub

    Private Sub SSGRIDVIEW_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles SSGRIDVIEW.Advance

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class
