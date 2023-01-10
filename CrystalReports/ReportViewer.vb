Imports System.Data.SqlClient
Public Class Viewer
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Public str As String
    Dim myconn As SqlConnection
    Public sqlstring As String
    Dim chkbool As Boolean
    Dim vconn As New GlobalClass
    Public ssql, TableName As String
    Public Report As Object

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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CryRptViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Viewer))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CryRptViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(496, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'CryRptViewer
        '
        Me.CryRptViewer.ActiveViewIndex = -1
        Me.CryRptViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryRptViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.CryRptViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CryRptViewer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CryRptViewer.Location = New System.Drawing.Point(0, 0)
        Me.CryRptViewer.Name = "CryRptViewer"
        Me.CryRptViewer.Size = New System.Drawing.Size(1028, 733)
        Me.CryRptViewer.TabIndex = 3
        Me.CryRptViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Viewer
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1028, 733)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CryRptViewer)
        Me.Name = "Viewer"
        Me.Text = "Report Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CryRptViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CryRptViewer.Load
        If ssql = Nothing Then

        Else
            Call GetDetails(ssql, TableName, Report)
        End If


    End Sub
    Public Function GetDetails(ByVal sqlstring As String, ByVal Tabname As String, ByVal rpt As Object)
        Try
            myconn = New SqlConnection(gconnection.Getconnection())
            Dim adp As New SqlDataAdapter
            Dim ds As New DataSet
            adp = New SqlDataAdapter(sqlstring, myconn)

            adp.SelectCommand.CommandTimeout = 999999999

            adp.Fill(ds, Tabname)
            rpt.SetDataSource(ds.Tables(0))
            CryRptViewer.ReportSource = rpt
            CryRptViewer.Zoom(100)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "PurchaseOrder", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Function GetDetails1(ByVal ssql As String, ByVal Tab As String, ByVal rpt As Object)
        Dim dt As New DataTable
        myconn = New SqlConnection(gconnection.Getconnection())
        gadapter = New SqlDataAdapter(ssql, myconn)
        gadapter.Fill(dt)

        dt.TableName = Tab
        If gdataset.Tables.Contains(Tab) = True Then
            gdataset.Tables.Remove(Tab)
        End If
        gdataset.Tables.Add(dt)
        rpt.SetDataSource(gdataset)
        CryRptViewer.Refresh()
        CryRptViewer.ReportSource = rpt
        CryRptViewer.Zoom(100)
        CryRptViewer.Refresh()
    End Function



    Public Function GetDetailsDS(ByVal ds As DataSet, ByVal rpt As Object)
        rpt.SetDataSource(ds)
        CryRptViewer.Refresh()
        CryRptViewer.ReportSource = rpt
        CryRptViewer.Zoom(100)
        CryRptViewer.Refresh()
    End Function

End Class
