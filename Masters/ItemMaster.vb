Imports System.Data.SqlClient
Imports System
Imports System.Data
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Text.RegularExpressions

Public Class itemmaster
    Inherits System.Windows.Forms.Form
    Dim ssql, sqlstring, vPromUOM As String
    Dim gconnection As New GlobalClass
    Dim vconn As New GlobalClass
    Dim boolchk, valchk As Boolean
    Dim vseqno As Double
    Friend WithEvents cmd_rpt As System.Windows.Forms.Button
    Friend WithEvents cmd_export As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_last As System.Windows.Forms.Label
    Friend WithEvents ButtonBrowse As System.Windows.Forms.Button
    Friend WithEvents CBSTKABLEITEM As System.Windows.Forms.CheckBox
    Friend WithEvents GBInventory As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_StockUOM As System.Windows.Forms.Label
    Friend WithEvents cbo_StockUOM As System.Windows.Forms.ComboBox
    Friend WithEvents txt_SubGroupCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_SubGroupCode As System.Windows.Forms.Label
    Friend WithEvents txt_SubSubGroupDesc As System.Windows.Forms.TextBox
    Friend WithEvents cmd_GroupCode As System.Windows.Forms.Button
    Friend WithEvents txt_SubGroupDesc As System.Windows.Forms.TextBox
    Friend WithEvents cmd_SubGroupCode As System.Windows.Forms.Button
    Friend WithEvents txt_GroupDesc As System.Windows.Forms.TextBox
    Friend WithEvents cmd_SubSubGroupCode As System.Windows.Forms.Button
    Friend WithEvents lbl_SubSubGroupCode As System.Windows.Forms.Label
    Friend WithEvents txt_GroupCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_SubSubGroupCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_GroupCode As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BttnCategory_Help As System.Windows.Forms.Button
    Friend WithEvents TXT_CATEGORY As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_itemname1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_confactor As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_Convfact As System.Windows.Forms.TextBox
    Friend WithEvents lblconFactor As System.Windows.Forms.Label
    Friend WithEvents txt_StkUom As System.Windows.Forms.TextBox
    Friend WithEvents lblstluom As System.Windows.Forms.Label
    Friend WithEvents lbl_itemname As System.Windows.Forms.Label
    Dim i As Integer
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
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents AxfpSpread1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents lbl_UOM As System.Windows.Forms.Label
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Lbl_currentrate As System.Windows.Forms.Label
    Friend WithEvents txt_currentrate As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_uom As System.Windows.Forms.ComboBox
    Friend WithEvents txt_itemname As System.Windows.Forms.TextBox
    Friend WithEvents txt_Itemcode As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_itemcode As System.Windows.Forms.Label
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Lbl_shortname As System.Windows.Forms.Label
    Friend WithEvents txt_shortname As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmdItemHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_auth As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(itemmaster))
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Lbl_currentrate = New System.Windows.Forms.Label()
        Me.txt_currentrate = New System.Windows.Forms.TextBox()
        Me.lbl_UOM = New System.Windows.Forms.Label()
        Me.Cmb_uom = New System.Windows.Forms.ComboBox()
        Me.txt_itemname = New System.Windows.Forms.TextBox()
        Me.txt_Itemcode = New System.Windows.Forms.TextBox()
        Me.Lbl_itemcode = New System.Windows.Forms.Label()
        Me.lbl_Freeze = New System.Windows.Forms.Label()
        Me.Cmd_Clear = New System.Windows.Forms.Button()
        Me.Cmd_View = New System.Windows.Forms.Button()
        Me.Cmd_Freeze = New System.Windows.Forms.Button()
        Me.Cmd_Add = New System.Windows.Forms.Button()
        Me.cmd_Exit = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ButtonBrowse = New System.Windows.Forms.Button()
        Me.cmd_auth = New System.Windows.Forms.Button()
        Me.cmd_rpt = New System.Windows.Forms.Button()
        Me.cmd_export = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lbl_shortname = New System.Windows.Forms.Label()
        Me.txt_shortname = New System.Windows.Forms.TextBox()
        Me.cmdItemHelp = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_itemname = New System.Windows.Forms.Label()
        Me.txt_Convfact = New System.Windows.Forms.TextBox()
        Me.lblconFactor = New System.Windows.Forms.Label()
        Me.txt_StkUom = New System.Windows.Forms.TextBox()
        Me.lblstluom = New System.Windows.Forms.Label()
        Me.CBSTKABLEITEM = New System.Windows.Forms.CheckBox()
        Me.lbl_last = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GBInventory = New System.Windows.Forms.GroupBox()
        Me.Txt_confactor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_StockUOM = New System.Windows.Forms.Label()
        Me.cbo_StockUOM = New System.Windows.Forms.ComboBox()
        Me.txt_SubGroupCode = New System.Windows.Forms.TextBox()
        Me.lbl_SubGroupCode = New System.Windows.Forms.Label()
        Me.txt_SubSubGroupDesc = New System.Windows.Forms.TextBox()
        Me.cmd_GroupCode = New System.Windows.Forms.Button()
        Me.txt_SubGroupDesc = New System.Windows.Forms.TextBox()
        Me.cmd_SubGroupCode = New System.Windows.Forms.Button()
        Me.txt_GroupDesc = New System.Windows.Forms.TextBox()
        Me.cmd_SubSubGroupCode = New System.Windows.Forms.Button()
        Me.lbl_SubSubGroupCode = New System.Windows.Forms.Label()
        Me.txt_GroupCode = New System.Windows.Forms.TextBox()
        Me.txt_SubSubGroupCode = New System.Windows.Forms.TextBox()
        Me.lbl_GroupCode = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BttnCategory_Help = New System.Windows.Forms.Button()
        Me.TXT_CATEGORY = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_itemname1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GBInventory.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(191, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(258, 18)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "PURCHASE ORDER ITEM MASTER"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_currentrate
        '
        Me.Lbl_currentrate.AutoSize = True
        Me.Lbl_currentrate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_currentrate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_currentrate.ForeColor = System.Drawing.Color.Black
        Me.Lbl_currentrate.Location = New System.Drawing.Point(50, 215)
        Me.Lbl_currentrate.Name = "Lbl_currentrate"
        Me.Lbl_currentrate.Size = New System.Drawing.Size(96, 15)
        Me.Lbl_currentrate.TabIndex = 3
        Me.Lbl_currentrate.Text = "CURRENT RATE:"
        '
        'txt_currentrate
        '
        Me.txt_currentrate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_currentrate.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currentrate.Location = New System.Drawing.Point(234, 216)
        Me.txt_currentrate.MaxLength = 12
        Me.txt_currentrate.Name = "txt_currentrate"
        Me.txt_currentrate.Size = New System.Drawing.Size(207, 21)
        Me.txt_currentrate.TabIndex = 0
        Me.txt_currentrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_UOM
        '
        Me.lbl_UOM.AutoSize = True
        Me.lbl_UOM.BackColor = System.Drawing.Color.Transparent
        Me.lbl_UOM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_UOM.ForeColor = System.Drawing.Color.Black
        Me.lbl_UOM.Location = New System.Drawing.Point(72, 183)
        Me.lbl_UOM.Name = "lbl_UOM"
        Me.lbl_UOM.Size = New System.Drawing.Size(37, 15)
        Me.lbl_UOM.TabIndex = 5
        Me.lbl_UOM.Text = "UOM:"
        '
        'Cmb_uom
        '
        Me.Cmb_uom.BackColor = System.Drawing.Color.White
        Me.Cmb_uom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_uom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_uom.Location = New System.Drawing.Point(234, 180)
        Me.Cmb_uom.Name = "Cmb_uom"
        Me.Cmb_uom.Size = New System.Drawing.Size(77, 23)
        Me.Cmb_uom.TabIndex = 2
        '
        'txt_itemname
        '
        Me.txt_itemname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_itemname.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_itemname.Location = New System.Drawing.Point(234, 68)
        Me.txt_itemname.MaxLength = 2000
        Me.txt_itemname.Multiline = True
        Me.txt_itemname.Name = "txt_itemname"
        Me.txt_itemname.Size = New System.Drawing.Size(349, 92)
        Me.txt_itemname.TabIndex = 2
        '
        'txt_Itemcode
        '
        Me.txt_Itemcode.BackColor = System.Drawing.Color.Wheat
        Me.txt_Itemcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Itemcode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Itemcode.Location = New System.Drawing.Point(234, 39)
        Me.txt_Itemcode.MaxLength = 10
        Me.txt_Itemcode.Name = "txt_Itemcode"
        Me.txt_Itemcode.Size = New System.Drawing.Size(273, 21)
        Me.txt_Itemcode.TabIndex = 0
        '
        'Lbl_itemcode
        '
        Me.Lbl_itemcode.AutoSize = True
        Me.Lbl_itemcode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_itemcode.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_itemcode.ForeColor = System.Drawing.Color.Black
        Me.Lbl_itemcode.Location = New System.Drawing.Point(37, 40)
        Me.Lbl_itemcode.Name = "Lbl_itemcode"
        Me.Lbl_itemcode.Size = New System.Drawing.Size(72, 15)
        Me.Lbl_itemcode.TabIndex = 20
        Me.Lbl_itemcode.Text = "ITEM CODE:"
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(205, 635)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(140, 16)
        Me.lbl_Freeze.TabIndex = 315
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Clear.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Clear.Image = Global.SmartCard.My.Resources.Resources.Clear
        Me.Cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Clear.Location = New System.Drawing.Point(8, 12)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Clear.TabIndex = 321
        Me.Cmd_Clear.Text = "Clear[F6]"
        Me.Cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Clear.UseVisualStyleBackColor = False
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_View.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.Black
        Me.Cmd_View.Image = Global.SmartCard.My.Resources.Resources.view
        Me.Cmd_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_View.Location = New System.Drawing.Point(7, 188)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_View.TabIndex = 319
        Me.Cmd_View.Text = " View[F9]"
        Me.Cmd_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_View.UseVisualStyleBackColor = False
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Freeze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Freeze.Image = Global.SmartCard.My.Resources.Resources.Delete
        Me.Cmd_Freeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Freeze.Location = New System.Drawing.Point(7, 129)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Freeze.TabIndex = 320
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Me.Cmd_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Freeze.UseVisualStyleBackColor = False
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cmd_Add.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Add.Image = Global.SmartCard.My.Resources.Resources.save
        Me.Cmd_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Add.Location = New System.Drawing.Point(9, 70)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Add.TabIndex = 318
        Me.Cmd_Add.Text = "Add [F7]"
        Me.Cmd_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Add.UseVisualStyleBackColor = False
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.cmd_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_Exit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.Black
        Me.cmd_Exit.Image = Global.SmartCard.My.Resources.Resources._Exit
        Me.cmd_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Exit.Location = New System.Drawing.Point(6, 483)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(134, 56)
        Me.cmd_Exit.TabIndex = 317
        Me.cmd_Exit.Text = "Exit[F11]"
        Me.cmd_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Exit.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.ButtonBrowse)
        Me.GroupBox6.Controls.Add(Me.cmd_Exit)
        Me.GroupBox6.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox6.Controls.Add(Me.cmd_auth)
        Me.GroupBox6.Controls.Add(Me.cmd_rpt)
        Me.GroupBox6.Controls.Add(Me.Cmd_View)
        Me.GroupBox6.Controls.Add(Me.cmd_export)
        Me.GroupBox6.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox6.Controls.Add(Me.Cmd_Add)
        Me.GroupBox6.Location = New System.Drawing.Point(741, 23)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(149, 549)
        Me.GroupBox6.TabIndex = 316
        Me.GroupBox6.TabStop = False
        '
        'ButtonBrowse
        '
        Me.ButtonBrowse.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBrowse.ForeColor = System.Drawing.Color.Black
        Me.ButtonBrowse.Location = New System.Drawing.Point(6, 428)
        Me.ButtonBrowse.Name = "ButtonBrowse"
        Me.ButtonBrowse.Size = New System.Drawing.Size(133, 52)
        Me.ButtonBrowse.TabIndex = 432
        Me.ButtonBrowse.Text = "Browse"
        Me.ButtonBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBrowse.UseVisualStyleBackColor = True
        '
        'cmd_auth
        '
        Me.cmd_auth.BackColor = System.Drawing.Color.Transparent
        Me.cmd_auth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_auth.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_auth.ForeColor = System.Drawing.Color.Black
        Me.cmd_auth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_auth.Location = New System.Drawing.Point(6, 368)
        Me.cmd_auth.Name = "cmd_auth"
        Me.cmd_auth.Size = New System.Drawing.Size(134, 56)
        Me.cmd_auth.TabIndex = 320
        Me.cmd_auth.Text = "Authorize"
        Me.cmd_auth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_auth.UseVisualStyleBackColor = False
        '
        'cmd_rpt
        '
        Me.cmd_rpt.BackColor = System.Drawing.Color.Transparent
        Me.cmd_rpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_rpt.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_rpt.ForeColor = System.Drawing.Color.Black
        Me.cmd_rpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_rpt.Location = New System.Drawing.Point(6, 248)
        Me.cmd_rpt.Name = "cmd_rpt"
        Me.cmd_rpt.Size = New System.Drawing.Size(134, 56)
        Me.cmd_rpt.TabIndex = 430
        Me.cmd_rpt.Text = "Report"
        Me.cmd_rpt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_rpt.UseVisualStyleBackColor = False
        '
        'cmd_export
        '
        Me.cmd_export.BackColor = System.Drawing.Color.Transparent
        Me.cmd_export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_export.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_export.ForeColor = System.Drawing.Color.Black
        Me.cmd_export.Image = Global.SmartCard.My.Resources.Resources.excel
        Me.cmd_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_export.Location = New System.Drawing.Point(5, 308)
        Me.cmd_export.Name = "cmd_export"
        Me.cmd_export.Size = New System.Drawing.Size(134, 56)
        Me.cmd_export.TabIndex = 431
        Me.cmd_export.Text = "Export"
        Me.cmd_export.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_export.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(541, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(28, 15)
        Me.Label9.TabIndex = 322
        Me.Label9.Text = "[F4]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(405, 635)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(277, 15)
        Me.Label6.TabIndex = 417
        Me.Label6.Text = "Press F4 for HELP /Press ENTER key to navigate"
        '
        'Lbl_shortname
        '
        Me.Lbl_shortname.AutoSize = True
        Me.Lbl_shortname.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_shortname.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_shortname.ForeColor = System.Drawing.Color.Black
        Me.Lbl_shortname.Location = New System.Drawing.Point(50, 173)
        Me.Lbl_shortname.Name = "Lbl_shortname"
        Me.Lbl_shortname.Size = New System.Drawing.Size(83, 15)
        Me.Lbl_shortname.TabIndex = 418
        Me.Lbl_shortname.Text = "SHORTNAME:"
        Me.Lbl_shortname.Visible = False
        '
        'txt_shortname
        '
        Me.txt_shortname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_shortname.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shortname.Location = New System.Drawing.Point(234, 166)
        Me.txt_shortname.MaxLength = 10
        Me.txt_shortname.Name = "txt_shortname"
        Me.txt_shortname.Size = New System.Drawing.Size(273, 21)
        Me.txt_shortname.TabIndex = 419
        Me.txt_shortname.Visible = False
        '
        'cmdItemHelp
        '
        Me.cmdItemHelp.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdItemHelp.Image = CType(resources.GetObject("cmdItemHelp.Image"), System.Drawing.Image)
        Me.cmdItemHelp.Location = New System.Drawing.Point(517, 36)
        Me.cmdItemHelp.Name = "cmdItemHelp"
        Me.cmdItemHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdItemHelp.TabIndex = 429
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbl_itemname)
        Me.GroupBox1.Controls.Add(Me.txt_Convfact)
        Me.GroupBox1.Controls.Add(Me.lblconFactor)
        Me.GroupBox1.Controls.Add(Me.txt_StkUom)
        Me.GroupBox1.Controls.Add(Me.lblstluom)
        Me.GroupBox1.Controls.Add(Me.CBSTKABLEITEM)
        Me.GroupBox1.Controls.Add(Me.lbl_last)
        Me.GroupBox1.Controls.Add(Me.txt_shortname)
        Me.GroupBox1.Controls.Add(Me.Lbl_shortname)
        Me.GroupBox1.Controls.Add(Me.cmdItemHelp)
        Me.GroupBox1.Controls.Add(Me.txt_Itemcode)
        Me.GroupBox1.Controls.Add(Me.Lbl_itemcode)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbl_UOM)
        Me.GroupBox1.Controls.Add(Me.Lbl_currentrate)
        Me.GroupBox1.Controls.Add(Me.txt_itemname)
        Me.GroupBox1.Controls.Add(Me.txt_currentrate)
        Me.GroupBox1.Controls.Add(Me.Cmb_uom)
        Me.GroupBox1.Location = New System.Drawing.Point(209, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(649, 267)
        Me.GroupBox1.TabIndex = 317
        Me.GroupBox1.TabStop = False
        '
        'lbl_itemname
        '
        Me.lbl_itemname.AutoSize = True
        Me.lbl_itemname.BackColor = System.Drawing.Color.Transparent
        Me.lbl_itemname.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_itemname.ForeColor = System.Drawing.Color.Black
        Me.lbl_itemname.Location = New System.Drawing.Point(37, 71)
        Me.lbl_itemname.Name = "lbl_itemname"
        Me.lbl_itemname.Size = New System.Drawing.Size(73, 15)
        Me.lbl_itemname.TabIndex = 508
        Me.lbl_itemname.Text = "ITEM NAME:"
        '
        'txt_Convfact
        '
        Me.txt_Convfact.BackColor = System.Drawing.Color.Wheat
        Me.txt_Convfact.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Convfact.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Convfact.ForeColor = System.Drawing.Color.Black
        Me.txt_Convfact.Location = New System.Drawing.Point(532, 181)
        Me.txt_Convfact.MaxLength = 15
        Me.txt_Convfact.Name = "txt_Convfact"
        Me.txt_Convfact.Size = New System.Drawing.Size(51, 20)
        Me.txt_Convfact.TabIndex = 507
        Me.txt_Convfact.Visible = False
        '
        'lblconFactor
        '
        Me.lblconFactor.AutoSize = True
        Me.lblconFactor.BackColor = System.Drawing.Color.Transparent
        Me.lblconFactor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblconFactor.ForeColor = System.Drawing.Color.Black
        Me.lblconFactor.Location = New System.Drawing.Point(442, 183)
        Me.lblconFactor.Name = "lblconFactor"
        Me.lblconFactor.Size = New System.Drawing.Size(89, 14)
        Me.lblconFactor.TabIndex = 506
        Me.lblconFactor.Text = "CONV. FACTOR:"
        Me.lblconFactor.Visible = False
        '
        'txt_StkUom
        '
        Me.txt_StkUom.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StkUom.ForeColor = System.Drawing.Color.Black
        Me.txt_StkUom.Location = New System.Drawing.Point(392, 181)
        Me.txt_StkUom.Name = "txt_StkUom"
        Me.txt_StkUom.Size = New System.Drawing.Size(49, 21)
        Me.txt_StkUom.TabIndex = 505
        Me.txt_StkUom.Visible = False
        '
        'lblstluom
        '
        Me.lblstluom.AutoSize = True
        Me.lblstluom.BackColor = System.Drawing.Color.Transparent
        Me.lblstluom.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstluom.ForeColor = System.Drawing.Color.Black
        Me.lblstluom.Location = New System.Drawing.Point(314, 183)
        Me.lblstluom.Name = "lblstluom"
        Me.lblstluom.Size = New System.Drawing.Size(78, 14)
        Me.lblstluom.TabIndex = 504
        Me.lblstluom.Text = "STOCK UOM :"
        Me.lblstluom.Visible = False
        '
        'CBSTKABLEITEM
        '
        Me.CBSTKABLEITEM.AutoSize = True
        Me.CBSTKABLEITEM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CBSTKABLEITEM.ForeColor = System.Drawing.Color.Black
        Me.CBSTKABLEITEM.Location = New System.Drawing.Point(233, 13)
        Me.CBSTKABLEITEM.Name = "CBSTKABLEITEM"
        Me.CBSTKABLEITEM.Size = New System.Drawing.Size(126, 19)
        Me.CBSTKABLEITEM.TabIndex = 430
        Me.CBSTKABLEITEM.Text = "STOCKABLE ITEM"
        Me.CBSTKABLEITEM.UseVisualStyleBackColor = True
        '
        'lbl_last
        '
        Me.lbl_last.AutoSize = True
        Me.lbl_last.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_last.ForeColor = System.Drawing.Color.Red
        Me.lbl_last.Location = New System.Drawing.Point(62, 18)
        Me.lbl_last.Name = "lbl_last"
        Me.lbl_last.Size = New System.Drawing.Size(0, 15)
        Me.lbl_last.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(205, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 16)
        Me.Label1.TabIndex = 430
        Me.Label1.Text = " "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'GBInventory
        '
        Me.GBInventory.AutoSize = True
        Me.GBInventory.BackColor = System.Drawing.Color.Transparent
        Me.GBInventory.Controls.Add(Me.Txt_confactor)
        Me.GBInventory.Controls.Add(Me.Label11)
        Me.GBInventory.Controls.Add(Me.lbl_StockUOM)
        Me.GBInventory.Controls.Add(Me.cbo_StockUOM)
        Me.GBInventory.Controls.Add(Me.txt_SubGroupCode)
        Me.GBInventory.Controls.Add(Me.lbl_SubGroupCode)
        Me.GBInventory.Controls.Add(Me.txt_SubSubGroupDesc)
        Me.GBInventory.Controls.Add(Me.cmd_GroupCode)
        Me.GBInventory.Controls.Add(Me.txt_SubGroupDesc)
        Me.GBInventory.Controls.Add(Me.cmd_SubGroupCode)
        Me.GBInventory.Controls.Add(Me.txt_GroupDesc)
        Me.GBInventory.Controls.Add(Me.cmd_SubSubGroupCode)
        Me.GBInventory.Controls.Add(Me.lbl_SubSubGroupCode)
        Me.GBInventory.Controls.Add(Me.txt_GroupCode)
        Me.GBInventory.Controls.Add(Me.txt_SubSubGroupCode)
        Me.GBInventory.Controls.Add(Me.lbl_GroupCode)
        Me.GBInventory.Controls.Add(Me.Label8)
        Me.GBInventory.Controls.Add(Me.Label5)
        Me.GBInventory.Controls.Add(Me.Label10)
        Me.GBInventory.Controls.Add(Me.BttnCategory_Help)
        Me.GBInventory.Controls.Add(Me.TXT_CATEGORY)
        Me.GBInventory.Controls.Add(Me.Label2)
        Me.GBInventory.Controls.Add(Me.txt_itemname1)
        Me.GBInventory.Controls.Add(Me.Label4)
        Me.GBInventory.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GBInventory.ForeColor = System.Drawing.Color.Black
        Me.GBInventory.Location = New System.Drawing.Point(209, 404)
        Me.GBInventory.Name = "GBInventory"
        Me.GBInventory.Size = New System.Drawing.Size(649, 168)
        Me.GBInventory.TabIndex = 431
        Me.GBInventory.TabStop = False
        Me.GBInventory.Text = "INVENTORY DETAILS"
        Me.GBInventory.Visible = False
        '
        'Txt_confactor
        '
        Me.Txt_confactor.BackColor = System.Drawing.Color.Wheat
        Me.Txt_confactor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_confactor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_confactor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Txt_confactor.Location = New System.Drawing.Point(410, 93)
        Me.Txt_confactor.MaxLength = 15
        Me.Txt_confactor.Name = "Txt_confactor"
        Me.Txt_confactor.Size = New System.Drawing.Size(80, 20)
        Me.Txt_confactor.TabIndex = 505
        Me.Txt_confactor.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(280, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 14)
        Me.Label11.TabIndex = 504
        Me.Label11.Text = "CONVERSION FACTOR:"
        Me.Label11.Visible = False
        '
        'lbl_StockUOM
        '
        Me.lbl_StockUOM.AutoSize = True
        Me.lbl_StockUOM.BackColor = System.Drawing.Color.Transparent
        Me.lbl_StockUOM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StockUOM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_StockUOM.Location = New System.Drawing.Point(11, 97)
        Me.lbl_StockUOM.Name = "lbl_StockUOM"
        Me.lbl_StockUOM.Size = New System.Drawing.Size(78, 14)
        Me.lbl_StockUOM.TabIndex = 503
        Me.lbl_StockUOM.Text = "STOCK UOM :"
        Me.lbl_StockUOM.Visible = False
        '
        'cbo_StockUOM
        '
        Me.cbo_StockUOM.BackColor = System.Drawing.Color.Wheat
        Me.cbo_StockUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_StockUOM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_StockUOM.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cbo_StockUOM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbo_StockUOM.Location = New System.Drawing.Point(94, 92)
        Me.cbo_StockUOM.Name = "cbo_StockUOM"
        Me.cbo_StockUOM.Size = New System.Drawing.Size(176, 22)
        Me.cbo_StockUOM.Sorted = True
        Me.cbo_StockUOM.TabIndex = 502
        Me.cbo_StockUOM.Visible = False
        '
        'txt_SubGroupCode
        '
        Me.txt_SubGroupCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_SubGroupCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubGroupCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubGroupCode.ForeColor = System.Drawing.Color.Black
        Me.txt_SubGroupCode.Location = New System.Drawing.Point(409, 59)
        Me.txt_SubGroupCode.MaxLength = 15
        Me.txt_SubGroupCode.Name = "txt_SubGroupCode"
        Me.txt_SubGroupCode.Size = New System.Drawing.Size(80, 20)
        Me.txt_SubGroupCode.TabIndex = 488
        '
        'lbl_SubGroupCode
        '
        Me.lbl_SubGroupCode.AutoSize = True
        Me.lbl_SubGroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SubGroupCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubGroupCode.ForeColor = System.Drawing.Color.Black
        Me.lbl_SubGroupCode.Location = New System.Drawing.Point(299, 62)
        Me.lbl_SubGroupCode.Name = "lbl_SubGroupCode"
        Me.lbl_SubGroupCode.Size = New System.Drawing.Size(106, 14)
        Me.lbl_SubGroupCode.TabIndex = 493
        Me.lbl_SubGroupCode.Text = "SUB GROUP CODE :"
        '
        'txt_SubSubGroupDesc
        '
        Me.txt_SubSubGroupDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_SubSubGroupDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubSubGroupDesc.Enabled = False
        Me.txt_SubSubGroupDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubSubGroupDesc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_SubSubGroupDesc.Location = New System.Drawing.Point(514, 92)
        Me.txt_SubSubGroupDesc.MaxLength = 15
        Me.txt_SubSubGroupDesc.Name = "txt_SubSubGroupDesc"
        Me.txt_SubSubGroupDesc.Size = New System.Drawing.Size(114, 20)
        Me.txt_SubSubGroupDesc.TabIndex = 498
        Me.txt_SubSubGroupDesc.Visible = False
        '
        'cmd_GroupCode
        '
        Me.cmd_GroupCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_GroupCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_GroupCode.Image = CType(resources.GetObject("cmd_GroupCode.Image"), System.Drawing.Image)
        Me.cmd_GroupCode.Location = New System.Drawing.Point(490, 27)
        Me.cmd_GroupCode.Name = "cmd_GroupCode"
        Me.cmd_GroupCode.Size = New System.Drawing.Size(23, 26)
        Me.cmd_GroupCode.TabIndex = 491
        '
        'txt_SubGroupDesc
        '
        Me.txt_SubGroupDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_SubGroupDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubGroupDesc.Enabled = False
        Me.txt_SubGroupDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubGroupDesc.ForeColor = System.Drawing.Color.Black
        Me.txt_SubGroupDesc.Location = New System.Drawing.Point(514, 59)
        Me.txt_SubGroupDesc.MaxLength = 15
        Me.txt_SubGroupDesc.Name = "txt_SubGroupDesc"
        Me.txt_SubGroupDesc.Size = New System.Drawing.Size(114, 20)
        Me.txt_SubGroupDesc.TabIndex = 495
        '
        'cmd_SubGroupCode
        '
        Me.cmd_SubGroupCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_SubGroupCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_SubGroupCode.Image = CType(resources.GetObject("cmd_SubGroupCode.Image"), System.Drawing.Image)
        Me.cmd_SubGroupCode.Location = New System.Drawing.Point(491, 59)
        Me.cmd_SubGroupCode.Name = "cmd_SubGroupCode"
        Me.cmd_SubGroupCode.Size = New System.Drawing.Size(23, 26)
        Me.cmd_SubGroupCode.TabIndex = 494
        '
        'txt_GroupDesc
        '
        Me.txt_GroupDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_GroupDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_GroupDesc.Enabled = False
        Me.txt_GroupDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GroupDesc.ForeColor = System.Drawing.Color.Black
        Me.txt_GroupDesc.Location = New System.Drawing.Point(513, 28)
        Me.txt_GroupDesc.MaxLength = 15
        Me.txt_GroupDesc.Name = "txt_GroupDesc"
        Me.txt_GroupDesc.Size = New System.Drawing.Size(115, 20)
        Me.txt_GroupDesc.TabIndex = 492
        '
        'cmd_SubSubGroupCode
        '
        Me.cmd_SubSubGroupCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_SubSubGroupCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_SubSubGroupCode.Image = CType(resources.GetObject("cmd_SubSubGroupCode.Image"), System.Drawing.Image)
        Me.cmd_SubSubGroupCode.Location = New System.Drawing.Point(491, 92)
        Me.cmd_SubSubGroupCode.Name = "cmd_SubSubGroupCode"
        Me.cmd_SubSubGroupCode.Size = New System.Drawing.Size(23, 26)
        Me.cmd_SubSubGroupCode.TabIndex = 497
        Me.cmd_SubSubGroupCode.Visible = False
        '
        'lbl_SubSubGroupCode
        '
        Me.lbl_SubSubGroupCode.AutoSize = True
        Me.lbl_SubSubGroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SubSubGroupCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubSubGroupCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_SubSubGroupCode.Location = New System.Drawing.Point(275, 97)
        Me.lbl_SubSubGroupCode.Name = "lbl_SubSubGroupCode"
        Me.lbl_SubSubGroupCode.Size = New System.Drawing.Size(130, 14)
        Me.lbl_SubSubGroupCode.TabIndex = 496
        Me.lbl_SubSubGroupCode.Text = "SUB SUB GROUP CODE :"
        Me.lbl_SubSubGroupCode.Visible = False
        '
        'txt_GroupCode
        '
        Me.txt_GroupCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_GroupCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_GroupCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GroupCode.ForeColor = System.Drawing.Color.Black
        Me.txt_GroupCode.Location = New System.Drawing.Point(409, 28)
        Me.txt_GroupCode.MaxLength = 15
        Me.txt_GroupCode.Name = "txt_GroupCode"
        Me.txt_GroupCode.Size = New System.Drawing.Size(80, 20)
        Me.txt_GroupCode.TabIndex = 487
        '
        'txt_SubSubGroupCode
        '
        Me.txt_SubSubGroupCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_SubSubGroupCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubSubGroupCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubSubGroupCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_SubSubGroupCode.Location = New System.Drawing.Point(409, 92)
        Me.txt_SubSubGroupCode.MaxLength = 15
        Me.txt_SubSubGroupCode.Name = "txt_SubSubGroupCode"
        Me.txt_SubSubGroupCode.Size = New System.Drawing.Size(80, 20)
        Me.txt_SubSubGroupCode.TabIndex = 489
        Me.txt_SubSubGroupCode.Visible = False
        '
        'lbl_GroupCode
        '
        Me.lbl_GroupCode.AutoSize = True
        Me.lbl_GroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupCode.ForeColor = System.Drawing.Color.Black
        Me.lbl_GroupCode.Location = New System.Drawing.Point(323, 31)
        Me.lbl_GroupCode.Name = "lbl_GroupCode"
        Me.lbl_GroupCode.Size = New System.Drawing.Size(82, 14)
        Me.lbl_GroupCode.TabIndex = 490
        Me.lbl_GroupCode.Text = "GROUP CODE :"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(522, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 24)
        Me.Label8.TabIndex = 499
        Me.Label8.Text = "F4"
        Me.Label8.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(522, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 24)
        Me.Label5.TabIndex = 500
        Me.Label5.Text = "F4"
        Me.Label5.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(522, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 24)
        Me.Label10.TabIndex = 501
        Me.Label10.Text = "F4"
        Me.Label10.Visible = False
        '
        'BttnCategory_Help
        '
        Me.BttnCategory_Help.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnCategory_Help.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BttnCategory_Help.Image = CType(resources.GetObject("BttnCategory_Help.Image"), System.Drawing.Image)
        Me.BttnCategory_Help.Location = New System.Drawing.Point(246, 56)
        Me.BttnCategory_Help.Name = "BttnCategory_Help"
        Me.BttnCategory_Help.Size = New System.Drawing.Size(23, 26)
        Me.BttnCategory_Help.TabIndex = 486
        '
        'TXT_CATEGORY
        '
        Me.TXT_CATEGORY.BackColor = System.Drawing.Color.Wheat
        Me.TXT_CATEGORY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CATEGORY.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CATEGORY.ForeColor = System.Drawing.Color.Black
        Me.TXT_CATEGORY.Location = New System.Drawing.Point(94, 59)
        Me.TXT_CATEGORY.MaxLength = 15
        Me.TXT_CATEGORY.Name = "TXT_CATEGORY"
        Me.TXT_CATEGORY.Size = New System.Drawing.Size(146, 20)
        Me.TXT_CATEGORY.TabIndex = 478
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(18, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 14)
        Me.Label2.TabIndex = 484
        Me.Label2.Text = "CATEGORY :"
        '
        'txt_itemname1
        '
        Me.txt_itemname1.BackColor = System.Drawing.Color.Wheat
        Me.txt_itemname1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_itemname1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_itemname1.ForeColor = System.Drawing.Color.Black
        Me.txt_itemname1.Location = New System.Drawing.Point(94, 32)
        Me.txt_itemname1.MaxLength = 50
        Me.txt_itemname1.Name = "txt_itemname1"
        Me.txt_itemname1.Size = New System.Drawing.Size(177, 20)
        Me.txt_itemname1.TabIndex = 477
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 14)
        Me.Label4.TabIndex = 482
        Me.Label4.Text = "ITEM NAME :"
        '
        'itemmaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.BackgroundImage = Global.SmartCard.My.Resources.Resources._111in1024res
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.GBInventory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Symbol", 8.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "itemmaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PURCHASE ORDER ITEM MASTER"
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBInventory.ResumeLayout(False)
        Me.GBInventory.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me) '''--> Clear All Form Object
        txt_Itemcode.Text = ""
        txt_itemname.Text = ""
        txt_currentrate.Text = ""
        Cmb_uom.Text = ""
        Cmb_uom.SelectedIndex = -1
        txt_shortname.Text = ""
        Cmd_Freeze.Enabled = False
        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Me.Cmd_Freeze.Enabled = True
        Cmd_Add.Text = "Add [F7]"

        Me.Cmd_Freeze.Enabled = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        If Not String.IsNullOrEmpty(gAuditFlg) Then
            If gAuditFlg.ToUpper = "Y" Then
                Me.Cmd_Add.Enabled = False
                Me.Cmd_Freeze.Enabled = False
            End If
        End If
        Label1.Text = "LAST NO "
        txt_itemname1.Text = ""
        TXT_CATEGORY.Text = ""
        txt_GroupCode.Text = ""
        txt_GroupDesc.Text = ""
        txt_SubGroupCode.Text = ""
        txt_SubGroupDesc.Text = ""
        txt_Convfact.Text = ""
        txt_StkUom.Text = ""
        lblstluom.Visible = False
        lblconFactor.Visible = False
        txt_StkUom.Visible = False
        txt_Convfact.Visible = False
        GBInventory.Visible = False
        CBSTKABLEITEM.Checked = False
        Call FillUOM()
        txt_Itemcode.Enabled = True
        txt_itemname.Focus()
        Call autogenerate1()
        Call GetLastNo()
        valchk = True
    End Sub

    Private Sub ItemMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Resize_Form()
        Cmb_uom.DropDownStyle = ComboBoxStyle.DropDownList
        ItemMasterbool = True
        txt_itemname.ReadOnly = False
        txt_Itemcode.ReadOnly = False
        'Cmd_Freeze.Enabled = False
        cmdItemHelp.Enabled = True
        Call FillUOM() ''' --> Fill All UOM 
        Call GetLastNo()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        If Not String.IsNullOrEmpty(gAuditFlg) Then
            If gAuditFlg.ToUpper = "Y" Then
                Me.Cmd_Add.Enabled = False
                Me.Cmd_Freeze.Enabled = False
            End If
        End If
        txt_itemname.Focus()
        Call autogenerate1()
    End Sub

    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='PURCHASE ORDER' AND MODULENAME LIKE 'itemmaster%' ORDER BY RIGHTS"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.Cmd_Add.Enabled = False
        Me.Cmd_Freeze.Enabled = False
        Me.Cmd_View.Enabled = False
        Me.cmd_rpt.Enabled = False
        Me.cmd_export.Enabled = False
        Me.cmd_auth.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Me.cmd_auth.Enabled = True
                    Me.cmd_export.Enabled = True
                    Me.cmd_rpt.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.Cmd_Add.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.Cmd_Add.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.Cmd_Freeze.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                    Me.cmd_rpt.Enabled = True
                    Me.cmd_export.Enabled = True
                End If
                If Right(x) = "U" Then
                    Me.cmd_auth.Enabled = True
                End If
            Next
        End If


    End Sub
    Private Function ItemValidate() As Boolean
        valchk = False
        Dim SQLSTRING As String
        If Cmd_Add.Text = "Add [F7]" Then
            SQLSTRING = "SELECT * FROM PO_VIEW_ITEMMASTER WHERE ITEMCODE = '" & Trim(txt_Itemcode.Text) & "'"
            gconnection.getDataSet(SQLSTRING, "CHKITEM")
            If gdataset.Tables("CHKITEM").Rows.Count > 0 Then
                valchk = False
                MsgBox("Item Code Already Exit Check in Inventory Or Po Item Master", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MyCompanyName)
                txt_Itemcode.Focus()
                Exit Function
            End If
        End If
       
        If Trim(txt_Itemcode.Text) = "" Then
            valchk = False
            MsgBox("Item Code Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MyCompanyName)
            txt_Itemcode.Focus()
            Exit Function
        End If
        If Trim(txt_itemname.Text) = "" Then
            valchk = False
            MsgBox("Item Name Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MyCompanyName)
            txt_itemname.Focus()
            Exit Function
        End If
        'If Trim(txt_shortname.Text) = "" Then
        '    valchk = False
        '    MsgBox("ShortName Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MyCompanyName)
        '    txt_shortname.Focus()
        '    Exit Function
        'End If
        If Trim(Cmb_uom.Text) = "" Then
            valchk = False
            MsgBox("UOM Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MyCompanyName)
            Cmb_uom.Focus()
            Exit Function
        End If
        'If Val(txt_currentrate.Text) = 0.0 Then
        '    valchk = False
        '    MsgBox("CurrentRate Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MyCompanyName)
        '    txt_currentrate.Focus()
        '    Exit Function
        'End If
        'If Trim(txt_currentrate.Text) = "" Then
        '    valchk = False
        '    MsgBox("CurrentRate Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MyCompanyName)
        '    txt_currentrate.Focus()
        '    Exit Function
        'End If
        If CBSTKABLEITEM.Checked = True Then
            If Trim(txt_itemname1.Text) = "" Then
                valchk = False
                MsgBox("Item Name Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MyCompanyName)
                txt_itemname1.Focus()
                Exit Function
            End If
            If Trim(TXT_CATEGORY.Text) = "" Then
                valchk = False
                MsgBox("Category Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MyCompanyName)
                TXT_CATEGORY.Focus()
                Exit Function
            End If
            If Trim(txt_GroupCode.Text) = "" Then
                valchk = False
                MsgBox("Group code Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MyCompanyName)
                txt_GroupCode.Focus()
                Exit Function
            End If
            If Trim(txt_SubGroupCode.Text) = "" Then
                valchk = False
                MsgBox("Sub Group code Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MyCompanyName)
                txt_SubGroupCode.Focus()
                Exit Function
            End If

            If Trim(txt_Convfact.Text) = "" Then
                valchk = False
                MsgBox("Conversion Factor Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MyCompanyName)
                Txt_confactor.Focus()
                Exit Function
            End If
            If Trim(txt_StkUom.Text) = "" Then
                valchk = False
                MsgBox("Stock UOM Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, MyCompanyName)
                Txt_confactor.Focus()
                Exit Function
            End If

        End If
        valchk = True
    End Function

    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim vPromseqno, insert(0), VarPOSCODE(), sqlarray(), strSQL As String
        Dim vstring, vDate As Date
        Dim vPOSno As Double
        Dim count As Integer
        '''*********************************** Check Validation *******************************************************'''
        'If ItemValidate() = False Then Exit Sub
        '''*********************************** Insert ItemMaster *******************************************'''
        Try
            If Cmd_Add.Text = "Add [F7]" Then
                Call ItemValidate()
                If valchk = False Then Exit Sub
                Call autogenerate1()
                If CBSTKABLEITEM.Checked = True And GBInventory.Visible = True Then
                    ssql = "INSERT INTO PO_ITEMMASTER(Itemcode,Itemname,shortname,uom,currentofferrate, "
                    ssql = ssql & "freeze,adduser,adddatetime,itemname2,category,groupcode,groupname,subgroupcode,subgroupname,stockuom) values("
                    ssql = ssql & " '" & Trim(txt_Itemcode.Text) & "','" & Trim(txt_itemname.Text) & "','" & Trim(txt_shortname.Text) & "',"
                    ssql = ssql & " '" & Trim(Cmb_uom.Text) & "',"
                    ssql = ssql & Format(Val(Me.txt_currentrate.Text), "0.00") & ","
                    ssql = ssql & " 'N',"
                    ssql = ssql & "  '" & gUsername & "',"
                    ssql = ssql & "'" & Format(Now, "dd-MMM-yyyy HH:MM:ss") & "',"
                    ssql = ssql & " '" & Trim(txt_itemname1.Text) & "',"
                    ssql = ssql & " '" & Trim(TXT_CATEGORY.Text) & "',"
                    ssql = ssql & " '" & Trim(txt_GroupCode.Text) & "',"
                    ssql = ssql & " '" & Trim(txt_GroupDesc.Text) & "',"
                    ssql = ssql & " '" & Trim(txt_SubGroupCode.Text) & "',"
                    ssql = ssql & " '" & Trim(txt_SubGroupDesc.Text) & "',"
                    ssql = ssql & " '" & Trim(txt_StkUom.Text) & "')"
                Else
                    ssql = "INSERT INTO PO_ITEMMASTER(Itemcode,Itemname,shortname,uom,currentofferrate, "
                    ssql = ssql & "freeze,adduser,adddatetime) values("
                    ssql = ssql & " '" & Trim(txt_Itemcode.Text) & "','" & Trim(txt_itemname.Text) & "','" & Trim(txt_shortname.Text) & "',"
                    ssql = ssql & " '" & Trim(Cmb_uom.Text) & "',"
                    ssql = ssql & Format(Val(Me.txt_currentrate.Text), "0.00") & ","
                    ssql = ssql & " 'N',"
                    ssql = ssql & "  '" & gUsername & "',"
                    ssql = ssql & "'" & Format(Now, "dd-MMM-yyyy HH:MM:ss") & "')"

                End If
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = ssql
                '***********insert tranuom************
                ssql = "INSERT INTO INVITEM_TRANSUOM_LINK (Tranuom,Itemcode,ItemName,stockuom,Adduser,ADDDATE)"
                ssql = ssql & " VALUES ('" & Trim(Cmb_uom.Text) & "','" & Trim(txt_Itemcode.Text) & "','" & Trim(txt_itemname.Text) & "',"
                ssql = ssql & "'" & Trim(Cmb_uom.Text) & "','" & gUsername & "','" & Format(Now, "dd-MMM-yyyy HH:MM:ss") & "')"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = ssql

                '*********insert into inventoryitemmaster*********
                If CBSTKABLEITEM.Checked = True And GBInventory.Visible = True And gInventoryVersion = "O" Then
                    ssql = "SELECT isnull(STORECODE,'') AS STORECODE , ISNULL(STOREDESC,'') AS STOREDESC FROM STOREMASTER "
                    ssql = ssql & " WHERE STORESTATUS = 'M' "
                    gconnection.getDataSet(ssql, "STOREMASTER")
                    If (gdataset.Tables("STOREMASTER").Rows.Count > 0) Then
                        For i = 0 To gdataset.Tables("STOREMASTER").Rows.Count - 1
                            strSQL = "INSERT INTO inventoryitemmaster (itemcode,itemname,groupcode,groupname,subgroupcode,subgroupname,"
                            strSQL = strSQL & "subsubgroupcode,subsubgroupname,minqty,maxqty,valuation,purchaserate,taxper,Profitper,salerate,stockuom,"
                            strSQL = strSQL & "receiveuom,saleuom,leadtime,doubleuom,opstock,opvalue,convvalue,Freeze,Adduser,Adddate,CATEGORY,ABC,STORECODE,BASERATE,TAXREBATE,eoq,CASEQTY) "
                            strSQL = strSQL & " VALUES('" & Trim(txt_Itemcode.Text) & "','" & Replace(Trim(txt_itemname.Text), "'", "") & "' ,"

                            strSQL = strSQL & " '" & Trim(txt_GroupCode.Text) & "' ,"
                            strSQL = strSQL & " '" & Replace(Trim(txt_GroupDesc.Text), "'", "") & "' ,"
                            strSQL = strSQL & " '" & Trim(txt_SubGroupCode.Text) & "' ,"
                            strSQL = strSQL & " '" & Replace(Trim(txt_SubGroupDesc.Text), "'", "") & "' ,"
                            strSQL = strSQL & " '" & Trim(txt_SubGroupCode.Text) & "' ,"
                            strSQL = strSQL & " '" & Replace(Trim(txt_SubGroupDesc.Text), "'", "") & "' ,"

                            strSQL = strSQL & " 0.00 ,"
                            strSQL = strSQL & " 0.00,"
                            strSQL = strSQL & " '' ,"
                            strSQL = strSQL & " " & Format(Val(txt_currentrate.Text), "0.00") & " ,"
                            strSQL = strSQL & "0.00,"
                            strSQL = strSQL & "0.00 ,"
                            strSQL = strSQL & "0.00,"
                            strSQL = strSQL & " '" & Trim(cbo_StockUOM.Text) & "' ,"
                            strSQL = strSQL & " '" & Trim(cbo_StockUOM.Text) & "' ,"
                            strSQL = strSQL & " '" & Trim(cbo_StockUOM.Text) & "' ,"
                            strSQL = strSQL & " 1,"
                            strSQL = strSQL & " '" & IIf(Trim(cbo_StockUOM.Text) = "", Trim(cbo_StockUOM.Text), Trim(cbo_StockUOM.Text)) & "' ,"
                            strSQL = strSQL & "0.000,"
                            strSQL = strSQL & "0.00,"
                            strSQL = strSQL & " 1,"
                            strSQL = strSQL & "'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "','" & Trim(TXT_CATEGORY.Text) & "',"

                            strSQL = strSQL & " 'A' ,"
                            strSQL = strSQL & "'" & Trim(gdataset.Tables("STOREMASTER").Rows(i).Item("STORECODE")) & "' ,"
                            strSQL = strSQL & " " & Format(Val(txt_currentrate.Text), "0.00") & " ,"
                            strSQL = strSQL & " 'NO' ,"
                            strSQL = strSQL & "0.00,0.00)"
                            ReDim Preserve insert(insert.Length)
                            insert(insert.Length - 1) = strSQL
                        Next


                    End If

                ElseIf CBSTKABLEITEM.Checked = True And GBInventory.Visible = True And gInventoryVersion = "N" Then

                    Dim sql As String = "Insert into INV_InventoryItemMaster(Itemcode,Itemname,Groupcode,subGroupcode,subsubgroupcode,Category,AbcCategory,TaxRebate,batchprocess,void,PROFITPER,adddate,adduser,STOCKUOM,stockcategory,COMPANYREQ,COMPANYcode,COMPANYDESC,SPLCESS,SALEITEM)  "
                    sql = sql & " values ('" + txt_Itemcode.Text + "','" + txt_itemname1.Text + "','" + txt_GroupCode.Text + "','" + txt_SubGroupCode.Text + "',"
                    sql = sql & " '" + txt_SubSubGroupCode.Text + "','" + TXT_CATEGORY.Text + "','C','NO','NO','N','0',getdate(),'" + gUsername + "','NO','STOCKABLE','NO','','',0,'NO')"

                    ReDim Preserve insert(insert.Length)
                    insert(insert.Length - 1) = sql

                End If

                gconnection.MoreTrans(insert)

            ElseIf Cmd_Add.Text = "Update[F7]" And Me.lbl_Freeze.Visible = True Then
                Call ItemValidate()
                'If boolchk = False Then Exit Sub

                MessageBox.Show("The Freezed Record Cannot Be Updated", "ITEMMASTER", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Exit Sub
                boolchk = False

            ElseIf Me.lbl_Freeze.Visible = False And Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
                Call ItemValidate()
                If valchk = False Then Exit Sub
                ssql = "UPDATE PO_ITEMMASTER SET Itemname = '" & Replace(Trim(txt_itemname.Text), "'", " ") & "',"
                ssql = ssql & " ShortName = '" & Trim(txt_shortname.Text) & "',"
                ssql = ssql & " Uom = '" & Trim(Cmb_uom.Text) & "',"
                ssql = ssql & " Currentofferrate='" & Format(Val(Me.txt_currentrate.Text), "0.00") & "',"
                ssql = ssql & " itemname2 = '" & Trim(txt_itemname1.Text) & "',"
                ssql = ssql & " category = '" & Trim(TXT_CATEGORY.Text) & "',"
                ssql = ssql & " groupcode = '" & Trim(txt_GroupCode.Text) & "',"
                ssql = ssql & " groupname = '" & Trim(txt_GroupDesc.Text) & "',"
                ssql = ssql & " subgroupcode = '" & Trim(txt_SubGroupCode.Text) & "',"
                ssql = ssql & " subgroupname = '" & Trim(txt_SubGroupDesc.Text) & "',"
                ssql = ssql & " stockuom = '" & Trim(txt_StkUom.Text) & "',"
                ssql = ssql & "updateuser= '" & gUsername & "',updatedatetime='" & Format(Now, "dd-MMM-yyyy HH:MM:ss") & "'"
                ssql = ssql & "where Itemcode= '" & txt_Itemcode.Text & "' "
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = ssql
                '*****UPDATE INVITEM_TRANSUOM_LINK***********
                ssql = "UPDATE INVITEM_TRANSUOM_LINK SET TRANUOM='" & Trim(Cmb_uom.Text) & "',"
                ssql = ssql & "ITEMNAME='" & Replace(Trim(txt_itemname.Text), "'", " ") & "',"
                ssql = ssql & "STOCKUOM='" & Trim(Cmb_uom.Text) & "',"
                ssql = ssql & "ADDUSER='" & gUsername & "',ADDDATE='" & Format(Now, "dd-MMM-yyyy HH:MM:ss") & "'"
                ssql = ssql & "where Itemcode= '" & txt_Itemcode.Text & "' "

                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = ssql

                If CBSTKABLEITEM.Checked = True And GBInventory.Visible = True And gInventoryVersion = "O" Then
                    strSQL = "update  inventoryitemmaster set "
                    strSQL = strSQL & "itemname='" & Trim(txt_itemname1.Text) & "',"
                    strSQL = strSQL & "groupcode= '" & Trim(txt_GroupCode.Text) & "' ,"
                    strSQL = strSQL & " category = '" & Trim(TXT_CATEGORY.Text) & "',"
                    strSQL = strSQL & "groupname= '" & Replace(Trim(txt_GroupDesc.Text), "'", "") & "' ,"
                    strSQL = strSQL & "subgroupcode= '" & Trim(txt_SubGroupCode.Text) & "',"
                    strSQL = strSQL & "subgroupname='" & Replace(Trim(txt_SubGroupDesc.Text), "'", "") & "',receiveuom='" + Cmb_uom.Text + "',convvalue=" & Val(txt_Convfact.Text) & ""
                    strSQL = strSQL & "where Itemcode= '" & txt_Itemcode.Text & "' "

                    ReDim Preserve insert(insert.Length)
                    insert(insert.Length - 1) = strSQL
                ElseIf CBSTKABLEITEM.Checked = True And GBInventory.Visible = True And gInventoryVersion = "N" Then
                    strSQL = "update  INV_inventoryitemmaster set "
                    strSQL = strSQL & "itemname='" & Trim(txt_itemname1.Text) & "',"
                    strSQL = strSQL & " category = '" & Trim(TXT_CATEGORY.Text) & "',"
                    strSQL = strSQL & "groupcode= '" & Trim(txt_GroupCode.Text) & "' ,"
                    strSQL = strSQL & "subgroupcode= '" & Trim(txt_SubGroupCode.Text) & "' "
                    strSQL = strSQL & "where Itemcode= '" & txt_Itemcode.Text & "' "
                    ReDim Preserve insert(insert.Length)
                    insert(insert.Length - 1) = strSQL
                End If
                gconnection.MoreTrans(insert)
                End If



                Me.Cmd_Clear_Click(sender, e)
                Cmd_Add.Text = "Add [F7]"
                'End If
                'If vconn.MoreTrans(sqlarray) = True Then
                '    MsgBox("Transaction completed successfully", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, Application.ProductName)
                '    If MessageBox.Show("Do You Want Print it Now ", MyCompanyName, MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
                '        'Call cmd_View_Click(cmd_View, e)
                '        'Call Cmd_Clear_Click(sender, e)
                '        gPrint = True
                '    Else
                '        gPrint = False
                '        'Call Cmd_Clear_Click(sender, e)
                '    End If
                'End If

        Catch ex As Exception
            MsgBox("Error In Saving")
            Call Me.Cmd_Clear_Click(sender, e)
            Exit Sub
        End Try
        Me.Cmd_Clear_Click(sender, e)
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim FRM As New ReportDesigner
        If txt_Itemcode.Text.Length > 0 Then
            tables = " FROM PO_ITEMMASTER WHERE itemcode ='" & txt_Itemcode.Text & "' "
        Else
            tables = "FROM PO_ITEMMASTER "
        End If
        Gheader = "ITEM MASTER DETAILS"
        FRM.DataGridView1.ColumnCount = 2
        FRM.DataGridView1.Columns(0).Name = "COLUMN NAME"
        FRM.DataGridView1.Columns(0).Width = 300
        FRM.DataGridView1.Columns(1).Name = "SIZE"
        FRM.DataGridView1.Columns(1).Width = 100

        Dim ROW As String() = New String() {"itemcode", "8"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"itemname", "20"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"shortname", "8"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"uom", "10"}
        FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"lastofferrate", "12"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"lastofferdate", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"currentofferrate", "16"}
        FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"currentofferdate", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"pomonthtodate", "11"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"poyeartodate", "11"}
        ' FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"Freeze", "7"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"Adduser", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"adddatetime", "11"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"updateuser", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"updatedatetime", "16"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"freezeuser", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"freezedatetime", "18"}
        FRM.DataGridView1.Rows.Add(ROW)
        Dim CHK As New DataGridViewCheckBoxColumn()
        FRM.DataGridView1.Columns.Insert(0, CHK)
        CHK.HeaderText = "CHECK"
        CHK.Name = "CHK"
        FRM.ShowDialog(Me)
    End Sub
    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        Me.Close()
    End Sub
    Private Sub ItemMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(Cmd_Clear, e)
        End If
        If e.KeyCode = Keys.F7 And Cmd_Add.Enabled = True Then
            Call CmdAdd_Click(Cmd_Add, e)
        End If
        If e.KeyCode = Keys.F8 Then
            If Cmd_Freeze.Enabled = True Then
                Call Cmd_Freeze_Click(Cmd_Freeze, e)
            End If
        End If
        If e.KeyCode = Keys.F9 And Cmd_Freeze.Enabled = True Then
            Call Cmd_View_Click(Cmd_View, e)
        End If
        If e.KeyCode = Keys.F11 Then
            Call cmd_Exit_Click(cmd_Exit, e)
        End If
    End Sub
    Private Sub FillUOM() '''---> Fill All UOM From UOMMASTER
        ssql = "SELECT DISTINCT ISNULL(UOMDESC,'') AS UOMDESC FROM UOMMaster WHERE ISNULL(Freeze,'') <> 'Y' ORDER BY uomdesc ASC"
        vconn.getDataSet(ssql, "UOMMaster")
        Cmb_uom.Items.Clear()
        If gdataset.Tables("UOMMaster").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("UOMMaster").Rows.Count - 1
                With gdataset.Tables("UOMMaster").Rows(i)
                    Cmb_uom.Items.Add(Trim(.Item("UOMdesc")))
                End With
            Next i
        End If
        Cmb_uom.Sorted = True
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Dim strsql As String
        Call ItemValidate()
        If valchk = False Then Exit Sub
        If Mid(Cmd_Freeze.Text, 1, 1) = "F" Then
            strsql = "UPDATE  PO_ITEMMASTER "
            strsql = strsql & " SET Freeze= 'Y',Freezeuser='" & gUsername & " ', Freezedatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            strsql = strsql & " WHERE ITEMCODE = '" & Trim(txt_Itemcode.Text) & "'"
            gconnection.dataOperation(3, strsql, "PO_ITEMMASTER")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
            'Else
            '    strsql = "UPDATE  PO_ITEMMASTER "
            '    strsql = strsql & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            '    strsql = strsql & " WHERE ITEMCODE = '" & Trim(txt_Itemcode.Text) & "'"
            '    gconnection.dataOperation(4, strsql, "PO_ITEMMASTER")
            '    Me.Cmd_Clear_Click(sender, e)
            '    Cmd_Add.Text = "Add [F7]"
        End If
    End Sub


    Private Sub txt_itemname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_itemname.KeyPress
        If txt_itemname.Text <> "" And e.KeyChar = Chr(13) Then
            ' txt_shortname.Focus()
            Cmb_uom.Focus()
        Else
            txt_itemname.Focus()
        End If
    End Sub

    Private Sub txt_shortname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_shortname.KeyPress
        If txt_shortname.Text <> "" And e.KeyChar = Chr(13) Then
            Cmb_uom.Focus()
        Else
            txt_shortname.Focus()
        End If

    End Sub

    Private Sub Cmb_uom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_uom.KeyPress

        If Cmb_uom.Text <> "" And e.KeyChar = Chr(13) Then
            txt_currentrate.Focus()
        Else
            Cmb_uom.Focus()
        End If
    End Sub

    Private Sub txt_currentrate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_currentrate.KeyPress
        getNumeric(e)
    End Sub

    Private Sub txt_Itemcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Itemcode.Validated
        Dim strsql As String

        If Trim(txt_Itemcode.Text) <> "" Then
            strsql = "SELECT * FROM PO_view_ITEMMASTER WHERE itemcode='" & Trim(txt_Itemcode.Text) & "'"
            gconnection.getDataSet(strsql, "PO_ITEMMASTER")
            If gdataset.Tables("PO_ITEMMASTER").Rows.Count > 0 Then
                txt_Itemcode.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("itemcode"))
                txt_itemname.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("itemname"))
                txt_shortname.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("itemcode"))
                Cmb_uom.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("stockuom"))
                txt_currentrate.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("purchaserate"))
                'If gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("Freeze") = "Y" Then
                '    Me.lbl_Freeze.Visible = True
                '    Me.lbl_Freeze.Text = ""
                '    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("AddDatetime")), "dd-MMM-yyyy")
                '    ' Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                '    Me.Cmd_Freeze.Enabled = False
                'Else
                '    Me.lbl_Freeze.Visible = False
                '    Me.lbl_Freeze.Text = "Record Freezed  On "
                '    Me.Cmd_Freeze.Text = "Freeze[F8]"
                'End If

                strsql = "SELECT isnull(itemname2,'') as itemname2,isnull(category,'') as category,isnull(groupcode,'') as groupcode,isnull(groupname,'') as groupname,isnull(subgroupcode,'') as subgroupcode,isnull(subgroupname,'') as subgroupname,isnull(stockuom,'') as stockuom FROM PO_ITEMMASTER WHERE itemcode='" & Trim(txt_Itemcode.Text) & "'"
                gconnection.getDataSet(strsql, "PO_ITEMMASTER")
                If gdataset.Tables("PO_ITEMMASTER").Rows.Count > 0 Then
                    If Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("itemname2")) <> "" Then
                        strsql = "SELECT itemcode,stockuom,ISNULL(convvalue,0) AS convvalue FROM INVENTORYITEMMASTER WHERE itemcode='" & Trim(txt_Itemcode.Text) & "'"
                        gconnection.getDataSet(strsql, "INVENTORYITEMMASTER")
                        If gdataset.Tables("INVENTORYITEMMASTER").Rows.Count > 0 Then
                            txt_itemname1.ReadOnly = True
                            TXT_CATEGORY.ReadOnly = True
                            txt_GroupCode.ReadOnly = True
                            txt_SubGroupCode.ReadOnly = True
                            txt_StkUom.Text = Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(0).Item("stockuom"))
                            Txt_confactor.Text = Trim(gdataset.Tables("INVENTORYITEMMASTER").Rows(0).Item("convvalue"))
                        End If
                        GBInventory.Visible = True
                        lblstluom.Visible = True
                        lblconFactor.Visible = True
                        txt_StkUom.Visible = True
                        txt_Convfact.Visible = True
                        CBSTKABLEITEM.Checked = True
                        txt_itemname1.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("itemname2"))
                        TXT_CATEGORY.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("category"))
                        txt_GroupCode.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("groupcode"))
                        txt_GroupDesc.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("groupname"))
                        txt_SubGroupCode.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("subgroupcode"))
                        txt_SubGroupDesc.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("subgroupname"))
                        txt_StkUom.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("stockuom"))

                    Else
                        GBInventory.Visible = False
                        lblstluom.Visible = False
                        lblconFactor.Visible = False
                        txt_StkUom.Visible = False
                        txt_Convfact.Visible = False
                        CBSTKABLEITEM.Checked = False
                        txt_itemname1.Text = ""
                        TXT_CATEGORY.Text = ""
                        txt_GroupCode.Text = ""
                        txt_GroupDesc.Text = ""
                        txt_SubGroupCode.Text = ""
                        txt_SubGroupDesc.Text = ""
                        txt_Convfact.Text = ""
                        txt_StkUom.Text = ""
                    End If
                End If
                Me.Cmd_Add.Text = "Update[F7]"
                ''Me.Cmd_Add.Enabled = False
            Else
                Me.lbl_Freeze.Visible = False
                Me.lbl_Freeze.Text = "Record Freezed  On "
                Me.Cmd_Add.Text = "Add [F7]"
                txt_Itemcode.ReadOnly = False
                txt_itemname.Focus()
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
            If Not String.IsNullOrEmpty(gAuditFlg) Then
                If gAuditFlg.ToUpper = "Y" Then
                    Me.Cmd_Add.Enabled = False
                    Me.Cmd_Freeze.Enabled = False
                End If
            End If
        Else
            'txt_itemname.Focus()
        End If
        'If gUserCategory <> "S" Then
        '    Call GetRights()
        'End If
    End Sub

    Private Sub txt_Itemcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Itemcode.TextChanged

    End Sub

    Private Sub txt_Itemcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Itemcode.KeyDown
        If txt_Itemcode.Text = "" And e.KeyCode = Keys.F4 Then
            Call cmdItemHelp_Click_1(sender, e)
        End If
    End Sub

    Private Sub txt_Itemcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Itemcode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_Itemcode.Text) = "" Then
                Call cmdItemHelp_Click_1(txt_Itemcode, e)
            Else
                txt_itemname.Focus()
            End If
        End If
    End Sub

    Private Sub txt_currentrate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_currentrate.TextChanged
        ' getNumeric(e)

        Dim myRegex As New Regex("^[0-9]*\.?[0-9]{0,2}$")
        If myRegex.IsMatch(txt_currentrate.Text.Trim) = False Then
            MsgBox("Invalid characters found")
            txt_currentrate.Text = ""
            Exit Sub
            'Else
            '    If CDec(txt_currentrate.Text.Trim) < 0 OrElse CDec(txt_currentrate.Text.Trim) > 100000000 Then
            '        MsgBox("Enter Positive Numeric Value ")
            '        txt_currentrate.Text = ""
            '        Exit Sub
            '    End If
        End If
    End Sub

    Private Sub txt_currentrate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_currentrate.KeyDown

        If txt_currentrate.Text <> "" And e.KeyCode = 13 Then
            If CBSTKABLEITEM.Checked = True Then
                txt_itemname1.Focus()
            Else
                Cmd_Add.Focus()
            End If

        Else
            txt_currentrate.Focus()
        End If
    End Sub

    Private Sub cmdItemHelp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdItemHelp.Click
        gSQLString = "SELECT  ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME  FROM po_view_itemmaster"
        M_WhereCondition = ""
        Dim vform As New ListOperattion1_N
        vform.Field = "ITEMNAME,ITEMCODE"
        vform.vFormatstring = "         ITEMCODE              |                                   ITEMNAME                                                           "
        vform.vCaption = " ITEM MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_Itemcode.Text = Trim(vform.keyfield & "")
            txt_itemname.Text = Trim(vform.keyfield1 & "")
            Cmd_Freeze.Enabled = True
            Call txt_Itemcode_Validated(txt_Itemcode, e)
        End If
        vform.Close()
        vform = Nothing
        txt_itemname.Focus()
        txt_Itemcode.Enabled = False
    End Sub


    Private Sub cmd_auth_Click(sender As Object, e As EventArgs) Handles cmd_auth.Click
        Dim SSQLSTR, SSQLSTR2 As String
        Dim USERT As Integer
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 1
        End If
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 2
        End If
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 3
        End If
        If USERT = 1 Then
            SSQLSTR2 = " SELECT * FROM PO_ITEMMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM PO_ITEMMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE PO_ITEMMASTER set  ", "ITEMCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM PO_ITEMMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM PO_ITEMMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE PO_ITEMMASTER set  ", "ITEMCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            End If
        ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM PO_ITEMMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='PURCHASE ORDER' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM PO_ITEMMASTER WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE PO_ITEMMASTER set  ", "ITEMCODE", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                        End If
                    End If
                End If
            Else
                MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub cmd_rpt_Click(sender As Object, e As EventArgs) Handles cmd_rpt.Click
        gPrint = False
        'If MsgBox("Click 'YES' to Windows view or 'NO' to Text view", MsgBoxStyle.YesNo, "Group Master") = MsgBoxResult.Yes Then
        Dim rViewer As New Viewer
        Dim sqlstring, SSQL As String
        Dim r As New Rpt_Itemmaster
        ' Dim r As New CrystalReport1
        sqlstring = "SELECT * FROM PO_ITEMMASTER order by itemcode "
        ' sqlstring = "SELECT * FROM inventoryitemmaster "
        gconnection.getDataSet(sqlstring, "PO_ITEMMASTER")
        If gdataset.Tables("PO_ITEMMASTER").Rows.Count > 0 Then

            rViewer.ssql = sqlstring
            rViewer.Report = r
            rViewer.TableName = "PO_ITEMMASTER"
            Dim textobj1 As TextObject
            textobj1 = r.ReportDefinition.ReportObjects("Text13")
            textobj1.Text = MyCompanyName
            Dim textobj2 As TextObject
            textobj2 = r.ReportDefinition.ReportObjects("Text21")
            textobj2.Text = gUsername
            rViewer.Show()

        Else
            MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
        End If

        ' Else
        ' PRINTOPERATION()
        '     End If
    End Sub

    Private Sub cmd_export_Click(sender As Object, e As EventArgs) Handles cmd_export.Click
        Dim sqlstring As String
        Dim _export As New EXPORT
        _export.TABLENAME = "PO_ITEMMASTER"
        sqlstring = "select * from PO_ITEMMASTER"
        Call _export.export_excel(sqlstring)
        _export.Show()
        Exit Sub
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
                        If Controls(i_i).Name = "GroupBox6" Then
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

    Private Sub GetLastNo()
        Dim SQLSTRING As String
        Dim DR As DataRow
        'SQLSTRING = "SELECT Isnull(Max(itemcode),0)as itemcode FROM PO_ITEMMASTER "
        SQLSTRING = "select ISNULL(max(cast(itemcode as numeric)),0) as itemcode from Vw_itemcode where isnumeric(itemcode)=1 and itemcode like '%[0-9]%'"
        gconnection.getDataSet(SQLSTRING, "membermaster")
        If gdataset.Tables("membermaster").Rows.Count > 0 Then
            Me.lbl_last.Text = "Last No IS : " & " " & gdataset.Tables("membermaster").Rows(0).Item(0)
        Else
            Me.lbl_last.Text = "Last No" & " " & 0
        End If

    End Sub

    Private Sub ButtonBrowse_Click(sender As Object, e As EventArgs) Handles ButtonBrowse.Click
        Try

            Dim obj1 As New VIEWHDR
            Dim sqlstr As String
            Dim childsql As String

            sqlstr = "SELECT ISNULL(ITEMCODE,'') AS ITEMCODE, ISNULL(ITEMNAME,'') AS ITEMDESC, ISNULL(PURCHASERATE,0) AS RATE, "
            sqlstr = sqlstr & " ISNULL(ADDUSER,'') AS ADDUSER, ISNULL(ADDDATE,'') AS ADDDATE, ISNULL(FREEZE,'') AS FREEZE FROM PO_VIEW_ITEMMASTER_BROWSE ORDER BY ITEMCODE"

            childsql = ""
            M_ORDERBY = " "
            gconnection.getDataSet(sqlstr, "PO_VIEW_ITEMMASTER_BROWSE")
            obj1.LOADGRID(gdataset.Tables("PO_VIEW_ITEMMASTER_BROWSE"), True, "ItemMaster", childsql, "", 1)
            obj1.Show()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub autogenerate1()
        Dim sqlstring, financalyear As String
        Try
            If UCase(gCompanyShortName) = "KGA" Then
                sqlstring = "select FORMAT(ISNULL(max(cast(itemcode as numeric)),0)+1,'0000000') as itemcode from Vw_itemcode where isnumeric(itemcode)=1 and itemcode like '%[0-9]%'"
            Else
                sqlstring = "select ISNULL(max(cast(itemcode as numeric)),0) as itemcode from Vw_itemcode where isnumeric(itemcode)=1 and itemcode like '%[0-9]%'"
            End If

            gconnection.getDataSet(sqlstring, "MaxNoPO_VIEW_itemMASTER")
            If gdataset.Tables("MaxNoPO_VIEW_itemMASTER").Rows.Count > 0 Then
                txt_Itemcode.Text = gdataset.Tables("MaxNoPO_VIEW_itemMASTER").Rows(0).Item("itemcode")
                ' txt_Itemcode.ReadOnly = True
            End If

        Catch ex As Exception
            MessageBox.Show("Plz Check Error" + ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub CBSTKABLEITEM_CheckedChanged(sender As Object, e As EventArgs) Handles CBSTKABLEITEM.CheckedChanged
        If CBSTKABLEITEM.Checked = True Then
            GBInventory.Visible = True
            'Call FillUOM_Inv()
            lblstluom.Visible = True
            lblconFactor.Visible = True
            txt_StkUom.Visible = True
            txt_Convfact.Visible = True
        Else
            GBInventory.Visible = False
            lblstluom.Visible = False
            lblconFactor.Visible = False
            txt_StkUom.Visible = False
            txt_Convfact.Visible = False
        End If
    End Sub

    Private Sub BttnCategory_Help_Click(sender As Object, e As EventArgs) Handles BttnCategory_Help.Click


        If gInventoryVersion = "O" Then
            gSQLString = "SELECT DISTINCT CATEGORYDESC,CATEGORYCODE FROM INVENTORYCATEGORYMASTER"
            M_WhereCondition = "  WHERE ISNULL(Freeze,'')<>'Y' "
            Dim vform As New ListOperattion1_N
            vform.Field = "CATEGORYDESC,CATEGORYCODE"
            vform.vFormatstring = "CATEGORYDESC                                       |                        CATEGORYCODE                                               "
            vform.vCaption = "INVENTORY CATEGORY MASTER HELP"
            vform.KeyPos = 0
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                TXT_CATEGORY.Text = Trim(vform.keyfield & "")
            End If
            vform.Close()
            vform = Nothing
            cbo_StockUOM.Focus()
        Else
            gSQLString = "SELECT DISTINCT CATEGORYCODE AS CATEGORYCODE,CATEGORYDESC AS CATEGORYDESC   FROM INVENTORYCATEGORYMASTER"
            M_WhereCondition = " WHERE ISNULL(FREEZE,'')<>'Y' "
            Dim vform As New ListOperattion1_N
            vform.Field = " CATEGORYCODE,CATEGORYDESC "
            vform.vFormatstring = "                   CATEGORYCODE          |                  CATEGORYDESC                        "
            vform.vCaption = "INVENTORY CATEGORY MASTER HELP"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                TXT_CATEGORY.Text = Trim(vform.keyfield & "")
            End If
            vform.Close()
            vform = Nothing
            cbo_StockUOM.Focus()
        End If



    End Sub

    Private Sub cmd_GroupCode_Click(sender As Object, e As EventArgs) Handles cmd_GroupCode.Click
        gSQLString = "SELECT Groupcode,Groupdesc FROM inventorygroupmaster"
        M_WhereCondition = " WHERE freeze='N' "
        Dim vform As New ListOperattion1_N
        vform.Field = "GROUPDESC,GROUPCODE"
        vform.vFormatstring = "         GROUP CODE              |                  GROUP DESCRIPTION                                                                                              "
        vform.vCaption = "GROUP MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_GroupCode.Text = Trim(vform.keyfield & "")
            Call txt_GroupCode_Validated(txt_GroupCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_GroupCode_Validated(sender As Object, e As EventArgs) Handles txt_GroupCode.Validated
        If Trim(txt_GroupCode.Text) <> "" Then
            sqlstring = "SELECT * FROM inventorygroupmaster WHERE Groupcode='" & Trim(txt_GroupCode.Text) & "' AND freeze='N'"
            gconnection.getDataSet(sqlstring, "inventorygroupmaster")
            If gdataset.Tables("inventorygroupmaster").Rows.Count > 0 Then
                txt_GroupCode.Text = Trim(gdataset.Tables("inventorygroupmaster").Rows(0).Item("Groupcode"))
                txt_GroupDesc.Text = Trim(gdataset.Tables("inventorygroupmaster").Rows(0).Item("Groupdesc"))
                txt_SubGroupCode.Focus()
                txt_GroupDesc.ReadOnly = True
            Else
                txt_GroupCode.Text = ""
                txt_GroupDesc.ReadOnly = False
                txt_GroupCode.Focus()
            End If
        Else
            txt_GroupCode.Text = ""
            txt_SubGroupCode.Focus()
        End If
    End Sub

    Private Sub cmd_SubGroupCode_Click(sender As Object, e As EventArgs) Handles cmd_SubGroupCode.Click
        gSQLString = "SELECT ISNULL(SUBGROUPCODE,'') AS SUBGROUPCODE,ISNULL(SUBGROUPDESC,'') AS SUBGROUPDESC FROM INVENTORYSUBGROUPMASTER"
        M_WhereCondition = " WHERE GROUPCODE='" & Trim(txt_GroupCode.Text) & "'  AND ISNULL(FREEZE,'') <> 'Y' "
        Dim vform As New ListOperattion1_N
        vform.Field = "SUBGROUPDESC,SUBGROUPCODE"
        vform.vFormatstring = "        SUB GROUP CODE              |            SUB GROUP DESCRIPTION                                                                                       "
        vform.vCaption = "SUBGROUP MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_SubGroupCode.Text = Trim(vform.keyfield & "")
            Call txt_SubGroupCode_Validated(txt_SubGroupCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_SubGroupCode_Validated(sender As Object, e As EventArgs) Handles txt_SubGroupCode.Validated
        If Trim(txt_SubGroupCode.Text) <> "" Then
            sqlstring = "SELECT * FROM inventorysubgroupmaster WHERE Groupcode='" & Trim(txt_GroupCode.Text) & "' AND SUBGROUPCODE = '" & Trim(txt_SubGroupCode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "inventorysubgroupmaster")
            If gdataset.Tables("inventorysubgroupmaster").Rows.Count > 0 Then
                txt_SubGroupCode.Text = Trim(gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("Subgroupcode"))
                txt_SubGroupDesc.Text = Trim(gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("Subgroupdesc"))
                Cmd_Add.Focus()
                txt_SubGroupDesc.ReadOnly = True
            Else
                txt_SubGroupCode.Text = ""
                txt_SubGroupCode.Focus()
            End If
        Else
            txt_SubGroupCode.Text = ""
            'txt_SubGroupCode.Focus()
        End If
    End Sub

    Private Sub cmd_SubSubGroupCode_Click(sender As Object, e As EventArgs) Handles cmd_SubSubGroupCode.Click
        gSQLString = "SELECT ISNULL(SUBGROUPCODE,'') AS SUBGROUPCODE,ISNULL(SUBGROUPDESC,'') AS SUBGROUPDESC FROM INVENTORYSUBGROUPMASTER"
        M_WhereCondition = " WHERE GROUPCODE='" & Trim(txt_GroupCode.Text) & "' AND ISNULL(FREEZE,'') <> 'Y' "
        Dim vform As New ListOperattion1_N
        vform.Field = "SUBGROUPCODE,SUBGROUPDESC"
        vform.vFormatstring = "         SUB SUB GROUP CODE     |               SUB SUB GROUP DESCRIPTION                                                                          "
        vform.vCaption = "SUBSUBGROUP MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_SubSubGroupCode.Text = Trim(vform.keyfield & "")
            Call txt_SubSubGroupCode_Validated(txt_SubSubGroupCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub txt_SubSubGroupCode_Validated(sender As Object, e As EventArgs) Handles txt_SubSubGroupCode.Validated
        If Trim(txt_SubGroupCode.Text) <> "" Then
            sqlstring = "SELECT * FROM inventorysubgroupmaster WHERE Groupcode='" & Trim(txt_GroupCode.Text) & "' AND SUBGROUPCODE = '" & Trim(txt_SubSubGroupCode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "inventorysubgroupmaster")
            If gdataset.Tables("inventorysubgroupmaster").Rows.Count > 0 Then
                txt_SubSubGroupCode.Text = Trim(gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("Subgroupcode"))
                txt_SubSubGroupDesc.Text = Trim(gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("Subgroupdesc"))
                Txt_confactor.Focus()
                txt_SubSubGroupDesc.ReadOnly = True
            Else
                txt_SubSubGroupCode.Text = ""
                txt_SubSubGroupDesc.ReadOnly = False
                txt_SubSubGroupCode.Focus()
            End If
        Else
            txt_SubSubGroupCode.Text = ""
            Txt_confactor.Focus()
        End If
    End Sub
    Private Sub FillUOM_Inv()
        Dim i As Integer
        sqlstring = "SELECT distinct(uomcode) FROM UOMMaster WHERE ISNULL(FREEZE,'')<>'Y' order by uomcode asc"
        gconnection.getDataSet(sqlstring, "UOMMaster1")

        cbo_StockUOM.Items.Clear()
        If gdataset.Tables("UOMMaster1").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("UOMMaster1").Rows.Count - 1
                cbo_StockUOM.Items.Add(gdataset.Tables("UOMMaster1").Rows(i).Item("UOMcode"))
            Next i
        End If
    End Sub

    Private Sub Cmb_uom_SelectedValueChanged(sender As Object, e As EventArgs) Handles Cmb_uom.SelectedValueChanged
        If GBInventory.Visible = True Then
            txt_StkUom.Text = Cmb_uom.Text
            sqlstring = "SELECT isnull(convvalue,0) as convvalue FROM INVENTORY_TRANSCONVERSION WHERE baseuom='" & txt_StkUom.Text & "' and transuom = '" & Cmb_uom.Text & "'"
            gconnection.getDataSet(sqlstring, "INVENTORY_TRANSCONVERSION")
            If gdataset.Tables("INVENTORY_TRANSCONVERSION").Rows.Count > 0 Then
                txt_Convfact.Text = gdataset.Tables("INVENTORY_TRANSCONVERSION").Rows(0).Item("convvalue")

            Else
                txt_Convfact.Text = ""
            End If
        End If
    End Sub

    Private Sub cbo_StockUOM_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_StockUOM.SelectedValueChanged
        If GBInventory.Visible = True Then
            txt_StkUom.Text = Cmb_uom.Text
            sqlstring = "SELECT isnull(convvalue,0) as convvalue FROM INVENTORY_TRANSCONVERSION WHERE baseuom='" & cbo_StockUOM.Text & "' and transuom = '" & Cmb_uom.Text & "'"
            gconnection.getDataSet(sqlstring, "INVENTORY_TRANSCONVERSION")
            If gdataset.Tables("INVENTORY_TRANSCONVERSION").Rows.Count > 0 Then
                txt_Convfact.Text = gdataset.Tables("INVENTORY_TRANSCONVERSION").Rows(0).Item("convvalue")
            Else
                txt_Convfact.Text = ""
            End If

        End If
    End Sub

    Private Sub txt_StkUom_TextChanged(sender As Object, e As EventArgs) Handles txt_StkUom.TextChanged
        If GBInventory.Visible = True Then
            txt_StkUom.Text = Cmb_uom.Text
            sqlstring = "SELECT isnull(convvalue,0) as convvalue FROM INVENTORY_TRANSCONVERSION WHERE baseuom='" & cbo_StockUOM.Text & "' and transuom = '" & Cmb_uom.Text & "'"
            gconnection.getDataSet(sqlstring, "INVENTORY_TRANSCONVERSION")
            If gdataset.Tables("INVENTORY_TRANSCONVERSION").Rows.Count > 0 Then
                txt_Convfact.Text = gdataset.Tables("INVENTORY_TRANSCONVERSION").Rows(0).Item("convvalue")
            Else
                txt_Convfact.Text = ""
            End If

        End If
    End Sub

    Private Sub txt_itemname1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_itemname1.KeyPress
        If txt_itemname1.Text <> "" And e.KeyChar = Chr(13) Then
            ' txt_shortname.Focus()
            TXT_CATEGORY.Focus()
        Else
            txt_itemname1.Focus()
        End If
    End Sub

    Private Sub TXT_CATEGORY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_CATEGORY.KeyPress

        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If TXT_CATEGORY.Text <> "" Then
                txt_GroupCode.Focus()
            Else
                BttnCategory_Help_Click(BttnCategory_Help, e)
            End If

        End If
    End Sub

    Private Sub txt_GroupCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_GroupCode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_GroupCode.Text) = "" Then
                Call cmd_GroupCode_Click(cmd_GroupCode, e)
            Else
                txt_GroupCode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_SubGroupCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_SubGroupCode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_SubGroupCode.Text) = "" Then
                Call cmd_SubGroupCode_Click(sender, e)
            Else
                txt_SubGroupCode_Validated(sender, e)
            End If
        End If
    End Sub
End Class