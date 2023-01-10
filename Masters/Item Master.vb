Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class Item_Master
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_SaleRate As System.Windows.Forms.Label
    Friend WithEvents lbl_MaxQty As System.Windows.Forms.Label
    Friend WithEvents lbl_PurchaseRate As System.Windows.Forms.Label
    Friend WithEvents lbl_MinQty As System.Windows.Forms.Label
    Friend WithEvents txt_MinQty As System.Windows.Forms.TextBox
    Friend WithEvents txt_MaxQty As System.Windows.Forms.TextBox
    Friend WithEvents txt_PurchaseRate As System.Windows.Forms.TextBox
    Friend WithEvents txt_SaleRate As System.Windows.Forms.TextBox
    Friend WithEvents txt_Conversion As System.Windows.Forms.TextBox
    Friend WithEvents txt_OpeningStock As System.Windows.Forms.TextBox
    Friend WithEvents lbl_OpeningStock As System.Windows.Forms.Label
    Friend WithEvents lbl_LeadTime As System.Windows.Forms.Label
    Friend WithEvents txt_LeadTime As System.Windows.Forms.TextBox
    Friend WithEvents cbo_DoubleUnit As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_SubSubGroupCode As System.Windows.Forms.Label
    Friend WithEvents txt_SubSubGroupCode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_SubSubGroupCode As System.Windows.Forms.Button
    Friend WithEvents lbl_GroupCode As System.Windows.Forms.Label
    Friend WithEvents txt_GroupCode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_GroupCode As System.Windows.Forms.Button
    Friend WithEvents lbl_SubGroupCode As System.Windows.Forms.Label
    Friend WithEvents txt_SubGroupCode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_SubGroupCode As System.Windows.Forms.Button
    Friend WithEvents txt_GroupDesc As System.Windows.Forms.TextBox
    Friend WithEvents txt_SubSubGroupDesc As System.Windows.Forms.TextBox
    Friend WithEvents txt_Alias As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_ItemCode As System.Windows.Forms.Button
    Friend WithEvents txt_ItemName As System.Windows.Forms.TextBox
    Friend WithEvents txt_ItemCode As System.Windows.Forms.TextBox
    Friend WithEvents cbo_StockUOM As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_StockUOM As System.Windows.Forms.Label
    Friend WithEvents lbl_Alias As System.Windows.Forms.Label
    Friend WithEvents lbl_ItemName As System.Windows.Forms.Label
    Friend WithEvents lbl_ItemCode As System.Windows.Forms.Label
    Friend WithEvents txt_SubGroupDesc As System.Windows.Forms.TextBox
    Friend WithEvents txt_OpeningAmount As System.Windows.Forms.TextBox
    Friend WithEvents lbl_OpeningAmount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_storecode As System.Windows.Forms.Label
    Friend WithEvents txt_Storecode As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_Storecode As System.Windows.Forms.Button
    Friend WithEvents txt_StoreDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_ClstK As System.Windows.Forms.Label
    Friend WithEvents lbl_Clval As System.Windows.Forms.Label
    Friend WithEvents lbl_Clvalue As System.Windows.Forms.Label
    Friend WithEvents lbl_Clstock As System.Windows.Forms.Label
    Friend WithEvents txt_avgRate As System.Windows.Forms.Label
    Friend WithEvents Cbo_ABC_category As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents lbl_ReceivingUOM As System.Windows.Forms.Label
    Friend WithEvents cbo_ReceivingUOM As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmd_export As System.Windows.Forms.Button
    Friend WithEvents cmd_auth As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents cbo_SaleUOM As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_SaleUOM As System.Windows.Forms.Label
    Friend WithEvents chklst_Uom As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_BASERATE As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbo_Valuation As System.Windows.Forms.ComboBox
    Friend WithEvents Txt_profitper As System.Windows.Forms.TextBox
    Friend WithEvents lbl_profitper As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_Caseqty As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_eoq As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ReorderLevel As System.Windows.Forms.Label
    Friend WithEvents txt_ReorderLevel As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TXT_CATEGORY As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BttnCategory_Help As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LBL_TAXREBATE As System.Windows.Forms.Label
    Friend WithEvents CBO_TAXREBATE As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_excel As System.Windows.Forms.CheckBox
    Friend WithEvents cmd_rpt As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txt_vat As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Item_Master))
        Me.lbl_Heading = New System.Windows.Forms.Label()
        Me.lbl_SaleRate = New System.Windows.Forms.Label()
        Me.lbl_MaxQty = New System.Windows.Forms.Label()
        Me.lbl_PurchaseRate = New System.Windows.Forms.Label()
        Me.lbl_MinQty = New System.Windows.Forms.Label()
        Me.txt_MinQty = New System.Windows.Forms.TextBox()
        Me.txt_MaxQty = New System.Windows.Forms.TextBox()
        Me.txt_PurchaseRate = New System.Windows.Forms.TextBox()
        Me.txt_SaleRate = New System.Windows.Forms.TextBox()
        Me.txt_Conversion = New System.Windows.Forms.TextBox()
        Me.txt_OpeningStock = New System.Windows.Forms.TextBox()
        Me.lbl_OpeningStock = New System.Windows.Forms.Label()
        Me.lbl_LeadTime = New System.Windows.Forms.Label()
        Me.txt_LeadTime = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.LBL_TAXREBATE = New System.Windows.Forms.Label()
        Me.cbo_DoubleUnit = New System.Windows.Forms.ComboBox()
        Me.txt_OpeningAmount = New System.Windows.Forms.TextBox()
        Me.lbl_ClstK = New System.Windows.Forms.Label()
        Me.lbl_Clvalue = New System.Windows.Forms.Label()
        Me.lbl_Clstock = New System.Windows.Forms.Label()
        Me.lbl_Clval = New System.Windows.Forms.Label()
        Me.lbl_OpeningAmount = New System.Windows.Forms.Label()
        Me.lbl_SubSubGroupCode = New System.Windows.Forms.Label()
        Me.txt_SubSubGroupCode = New System.Windows.Forms.TextBox()
        Me.cmd_SubSubGroupCode = New System.Windows.Forms.Button()
        Me.lbl_GroupCode = New System.Windows.Forms.Label()
        Me.txt_GroupCode = New System.Windows.Forms.TextBox()
        Me.cmd_GroupCode = New System.Windows.Forms.Button()
        Me.lbl_SubGroupCode = New System.Windows.Forms.Label()
        Me.txt_SubGroupCode = New System.Windows.Forms.TextBox()
        Me.cmd_SubGroupCode = New System.Windows.Forms.Button()
        Me.txt_GroupDesc = New System.Windows.Forms.TextBox()
        Me.txt_SubSubGroupDesc = New System.Windows.Forms.TextBox()
        Me.txt_Alias = New System.Windows.Forms.TextBox()
        Me.Cmd_ItemCode = New System.Windows.Forms.Button()
        Me.txt_ItemName = New System.Windows.Forms.TextBox()
        Me.txt_ItemCode = New System.Windows.Forms.TextBox()
        Me.cbo_StockUOM = New System.Windows.Forms.ComboBox()
        Me.lbl_StockUOM = New System.Windows.Forms.Label()
        Me.lbl_Alias = New System.Windows.Forms.Label()
        Me.lbl_ItemName = New System.Windows.Forms.Label()
        Me.lbl_ItemCode = New System.Windows.Forms.Label()
        Me.txt_SubGroupDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_storecode = New System.Windows.Forms.Label()
        Me.txt_Storecode = New System.Windows.Forms.TextBox()
        Me.Cmd_Storecode = New System.Windows.Forms.Button()
        Me.txt_StoreDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_avgRate = New System.Windows.Forms.Label()
        Me.Cbo_ABC_category = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_Freeze = New System.Windows.Forms.Label()
        Me.lbl_ReceivingUOM = New System.Windows.Forms.Label()
        Me.cbo_ReceivingUOM = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Cmd_Exit = New System.Windows.Forms.Button()
        Me.cmd_export = New System.Windows.Forms.Button()
        Me.cmd_auth = New System.Windows.Forms.Button()
        Me.Cmd_View = New System.Windows.Forms.Button()
        Me.Cmd_Freeze = New System.Windows.Forms.Button()
        Me.Cmd_Add = New System.Windows.Forms.Button()
        Me.Cmd_Clear = New System.Windows.Forms.Button()
        Me.cbo_SaleUOM = New System.Windows.Forms.ComboBox()
        Me.lbl_SaleUOM = New System.Windows.Forms.Label()
        Me.chklst_Uom = New System.Windows.Forms.CheckedListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TXT_BASERATE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_Valuation = New System.Windows.Forms.ComboBox()
        Me.Txt_profitper = New System.Windows.Forms.TextBox()
        Me.lbl_profitper = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Caseqty = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txt_vat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_eoq = New System.Windows.Forms.TextBox()
        Me.lbl_ReorderLevel = New System.Windows.Forms.Label()
        Me.txt_ReorderLevel = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXT_CATEGORY = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BttnCategory_Help = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBO_TAXREBATE = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_excel = New System.Windows.Forms.CheckBox()
        Me.cmd_rpt = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_Heading.Location = New System.Drawing.Point(184, 69)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(116, 18)
        Me.lbl_Heading.TabIndex = 25
        Me.lbl_Heading.Text = "ITEM  MASTER"
        Me.lbl_Heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_SaleRate
        '
        Me.lbl_SaleRate.AutoSize = True
        Me.lbl_SaleRate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SaleRate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SaleRate.Location = New System.Drawing.Point(209, 65)
        Me.lbl_SaleRate.Name = "lbl_SaleRate"
        Me.lbl_SaleRate.Size = New System.Drawing.Size(71, 14)
        Me.lbl_SaleRate.TabIndex = 49
        Me.lbl_SaleRate.Text = "SALE RATE :"
        '
        'lbl_MaxQty
        '
        Me.lbl_MaxQty.AutoSize = True
        Me.lbl_MaxQty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MaxQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MaxQty.Location = New System.Drawing.Point(38, 97)
        Me.lbl_MaxQty.Name = "lbl_MaxQty"
        Me.lbl_MaxQty.Size = New System.Drawing.Size(104, 14)
        Me.lbl_MaxQty.TabIndex = 45
        Me.lbl_MaxQty.Text = "MAX ORDER QTY  :"
        '
        'lbl_PurchaseRate
        '
        Me.lbl_PurchaseRate.AutoSize = True
        Me.lbl_PurchaseRate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PurchaseRate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PurchaseRate.Location = New System.Drawing.Point(25, 64)
        Me.lbl_PurchaseRate.Name = "lbl_PurchaseRate"
        Me.lbl_PurchaseRate.Size = New System.Drawing.Size(100, 14)
        Me.lbl_PurchaseRate.TabIndex = 48
        Me.lbl_PurchaseRate.Text = "PURCHASE RATE :"
        '
        'lbl_MinQty
        '
        Me.lbl_MinQty.AutoSize = True
        Me.lbl_MinQty.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MinQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MinQty.Location = New System.Drawing.Point(46, 67)
        Me.lbl_MinQty.Name = "lbl_MinQty"
        Me.lbl_MinQty.Size = New System.Drawing.Size(96, 14)
        Me.lbl_MinQty.TabIndex = 43
        Me.lbl_MinQty.Text = "MIN ORDER QTY :"
        '
        'txt_MinQty
        '
        Me.txt_MinQty.BackColor = System.Drawing.Color.White
        Me.txt_MinQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MinQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MinQty.Location = New System.Drawing.Point(163, 64)
        Me.txt_MinQty.MaxLength = 15
        Me.txt_MinQty.Name = "txt_MinQty"
        Me.txt_MinQty.Size = New System.Drawing.Size(130, 20)
        Me.txt_MinQty.TabIndex = 12
        Me.txt_MinQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_MaxQty
        '
        Me.txt_MaxQty.BackColor = System.Drawing.Color.White
        Me.txt_MaxQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MaxQty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaxQty.Location = New System.Drawing.Point(161, 90)
        Me.txt_MaxQty.MaxLength = 15
        Me.txt_MaxQty.Name = "txt_MaxQty"
        Me.txt_MaxQty.Size = New System.Drawing.Size(131, 20)
        Me.txt_MaxQty.TabIndex = 13
        Me.txt_MaxQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_PurchaseRate
        '
        Me.txt_PurchaseRate.BackColor = System.Drawing.Color.Wheat
        Me.txt_PurchaseRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_PurchaseRate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PurchaseRate.Location = New System.Drawing.Point(147, 61)
        Me.txt_PurchaseRate.MaxLength = 15
        Me.txt_PurchaseRate.Name = "txt_PurchaseRate"
        Me.txt_PurchaseRate.Size = New System.Drawing.Size(57, 20)
        Me.txt_PurchaseRate.TabIndex = 15
        Me.txt_PurchaseRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_SaleRate
        '
        Me.txt_SaleRate.BackColor = System.Drawing.Color.White
        Me.txt_SaleRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SaleRate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SaleRate.Location = New System.Drawing.Point(288, 61)
        Me.txt_SaleRate.MaxLength = 15
        Me.txt_SaleRate.Name = "txt_SaleRate"
        Me.txt_SaleRate.ReadOnly = True
        Me.txt_SaleRate.Size = New System.Drawing.Size(61, 20)
        Me.txt_SaleRate.TabIndex = 17
        Me.txt_SaleRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_Conversion
        '
        Me.txt_Conversion.BackColor = System.Drawing.Color.Wheat
        Me.txt_Conversion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Conversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Conversion.Location = New System.Drawing.Point(164, 46)
        Me.txt_Conversion.MaxLength = 15
        Me.txt_Conversion.Name = "txt_Conversion"
        Me.txt_Conversion.Size = New System.Drawing.Size(184, 20)
        Me.txt_Conversion.TabIndex = 17
        Me.txt_Conversion.Text = "1.00"
        Me.txt_Conversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_Conversion.Visible = False
        '
        'txt_OpeningStock
        '
        Me.txt_OpeningStock.BackColor = System.Drawing.Color.Wheat
        Me.txt_OpeningStock.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_OpeningStock.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_OpeningStock.Location = New System.Drawing.Point(163, 10)
        Me.txt_OpeningStock.MaxLength = 15
        Me.txt_OpeningStock.Name = "txt_OpeningStock"
        Me.txt_OpeningStock.ReadOnly = True
        Me.txt_OpeningStock.Size = New System.Drawing.Size(184, 20)
        Me.txt_OpeningStock.TabIndex = 21
        Me.txt_OpeningStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_OpeningStock
        '
        Me.lbl_OpeningStock.AutoSize = True
        Me.lbl_OpeningStock.BackColor = System.Drawing.Color.Transparent
        Me.lbl_OpeningStock.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_OpeningStock.Location = New System.Drawing.Point(6, 15)
        Me.lbl_OpeningStock.Name = "lbl_OpeningStock"
        Me.lbl_OpeningStock.Size = New System.Drawing.Size(99, 14)
        Me.lbl_OpeningStock.TabIndex = 59
        Me.lbl_OpeningStock.Text = "OPENING STOCK :"
        '
        'lbl_LeadTime
        '
        Me.lbl_LeadTime.AutoSize = True
        Me.lbl_LeadTime.BackColor = System.Drawing.Color.Transparent
        Me.lbl_LeadTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LeadTime.Location = New System.Drawing.Point(0, 648)
        Me.lbl_LeadTime.Name = "lbl_LeadTime"
        Me.lbl_LeadTime.Size = New System.Drawing.Size(81, 13)
        Me.lbl_LeadTime.TabIndex = 54
        Me.lbl_LeadTime.Text = "LEAD TIME :"
        Me.lbl_LeadTime.Visible = False
        '
        'txt_LeadTime
        '
        Me.txt_LeadTime.BackColor = System.Drawing.Color.White
        Me.txt_LeadTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_LeadTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_LeadTime.Location = New System.Drawing.Point(0, 640)
        Me.txt_LeadTime.MaxLength = 15
        Me.txt_LeadTime.Name = "txt_LeadTime"
        Me.txt_LeadTime.Size = New System.Drawing.Size(88, 20)
        Me.txt_LeadTime.TabIndex = 15
        Me.txt_LeadTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_LeadTime.Visible = False
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.lbl_OpeningStock)
        Me.GroupBox9.Controls.Add(Me.LBL_TAXREBATE)
        Me.GroupBox9.Controls.Add(Me.txt_OpeningStock)
        Me.GroupBox9.Controls.Add(Me.cbo_DoubleUnit)
        Me.GroupBox9.Controls.Add(Me.txt_OpeningAmount)
        Me.GroupBox9.Controls.Add(Me.txt_Conversion)
        Me.GroupBox9.Controls.Add(Me.lbl_ClstK)
        Me.GroupBox9.Controls.Add(Me.lbl_Clvalue)
        Me.GroupBox9.Controls.Add(Me.lbl_Clstock)
        Me.GroupBox9.Controls.Add(Me.lbl_Clval)
        Me.GroupBox9.Controls.Add(Me.lbl_OpeningAmount)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(483, 444)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(365, 170)
        Me.GroupBox9.TabIndex = 56
        Me.GroupBox9.TabStop = False
        '
        'LBL_TAXREBATE
        '
        Me.LBL_TAXREBATE.AutoSize = True
        Me.LBL_TAXREBATE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_TAXREBATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TAXREBATE.Location = New System.Drawing.Point(47, -10)
        Me.LBL_TAXREBATE.Name = "LBL_TAXREBATE"
        Me.LBL_TAXREBATE.Size = New System.Drawing.Size(134, 13)
        Me.LBL_TAXREBATE.TabIndex = 438
        Me.LBL_TAXREBATE.Text = "INPUT TAX REBATE :"
        '
        'cbo_DoubleUnit
        '
        Me.cbo_DoubleUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_DoubleUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_DoubleUnit.Location = New System.Drawing.Point(163, 9)
        Me.cbo_DoubleUnit.Name = "cbo_DoubleUnit"
        Me.cbo_DoubleUnit.Size = New System.Drawing.Size(184, 21)
        Me.cbo_DoubleUnit.TabIndex = 16
        Me.cbo_DoubleUnit.Visible = False
        '
        'txt_OpeningAmount
        '
        Me.txt_OpeningAmount.BackColor = System.Drawing.Color.Wheat
        Me.txt_OpeningAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_OpeningAmount.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_OpeningAmount.Location = New System.Drawing.Point(163, 45)
        Me.txt_OpeningAmount.MaxLength = 15
        Me.txt_OpeningAmount.Name = "txt_OpeningAmount"
        Me.txt_OpeningAmount.ReadOnly = True
        Me.txt_OpeningAmount.Size = New System.Drawing.Size(184, 20)
        Me.txt_OpeningAmount.TabIndex = 22
        Me.txt_OpeningAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_ClstK
        '
        Me.lbl_ClstK.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ClstK.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ClstK.ForeColor = System.Drawing.Color.Black
        Me.lbl_ClstK.Location = New System.Drawing.Point(6, 82)
        Me.lbl_ClstK.Name = "lbl_ClstK"
        Me.lbl_ClstK.Size = New System.Drawing.Size(116, 26)
        Me.lbl_ClstK.TabIndex = 428
        Me.lbl_ClstK.Text = "CLOSING STOCK :"
        Me.lbl_ClstK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Clvalue
        '
        Me.lbl_Clvalue.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Clvalue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Clvalue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Clvalue.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Clvalue.Location = New System.Drawing.Point(168, 113)
        Me.lbl_Clvalue.Name = "lbl_Clvalue"
        Me.lbl_Clvalue.Size = New System.Drawing.Size(181, 28)
        Me.lbl_Clvalue.TabIndex = 433
        Me.lbl_Clvalue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Clstock
        '
        Me.lbl_Clstock.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Clstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_Clstock.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Clstock.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Clstock.Location = New System.Drawing.Point(168, 81)
        Me.lbl_Clstock.Name = "lbl_Clstock"
        Me.lbl_Clstock.Size = New System.Drawing.Size(181, 27)
        Me.lbl_Clstock.TabIndex = 432
        Me.lbl_Clstock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Clval
        '
        Me.lbl_Clval.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Clval.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Clval.ForeColor = System.Drawing.Color.Black
        Me.lbl_Clval.Location = New System.Drawing.Point(6, 113)
        Me.lbl_Clval.Name = "lbl_Clval"
        Me.lbl_Clval.Size = New System.Drawing.Size(126, 29)
        Me.lbl_Clval.TabIndex = 431
        Me.lbl_Clval.Text = "CLOSING VALUE :"
        Me.lbl_Clval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_OpeningAmount
        '
        Me.lbl_OpeningAmount.AutoSize = True
        Me.lbl_OpeningAmount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_OpeningAmount.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_OpeningAmount.Location = New System.Drawing.Point(6, 48)
        Me.lbl_OpeningAmount.Name = "lbl_OpeningAmount"
        Me.lbl_OpeningAmount.Size = New System.Drawing.Size(97, 14)
        Me.lbl_OpeningAmount.TabIndex = 60
        Me.lbl_OpeningAmount.Text = "OPENING VALUE :"
        '
        'lbl_SubSubGroupCode
        '
        Me.lbl_SubSubGroupCode.AutoSize = True
        Me.lbl_SubSubGroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SubSubGroupCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubSubGroupCode.Location = New System.Drawing.Point(3, 101)
        Me.lbl_SubSubGroupCode.Name = "lbl_SubSubGroupCode"
        Me.lbl_SubSubGroupCode.Size = New System.Drawing.Size(130, 14)
        Me.lbl_SubSubGroupCode.TabIndex = 38
        Me.lbl_SubSubGroupCode.Text = "SUB SUB GROUP CODE :"
        Me.lbl_SubSubGroupCode.Visible = False
        '
        'txt_SubSubGroupCode
        '
        Me.txt_SubSubGroupCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_SubSubGroupCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubSubGroupCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubSubGroupCode.Location = New System.Drawing.Point(146, 97)
        Me.txt_SubSubGroupCode.MaxLength = 15
        Me.txt_SubSubGroupCode.Name = "txt_SubSubGroupCode"
        Me.txt_SubSubGroupCode.Size = New System.Drawing.Size(80, 20)
        Me.txt_SubSubGroupCode.TabIndex = 8
        Me.txt_SubSubGroupCode.Visible = False
        '
        'cmd_SubSubGroupCode
        '
        Me.cmd_SubSubGroupCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_SubSubGroupCode.Image = CType(resources.GetObject("cmd_SubSubGroupCode.Image"), System.Drawing.Image)
        Me.cmd_SubSubGroupCode.Location = New System.Drawing.Point(228, 94)
        Me.cmd_SubSubGroupCode.Name = "cmd_SubSubGroupCode"
        Me.cmd_SubSubGroupCode.Size = New System.Drawing.Size(23, 26)
        Me.cmd_SubSubGroupCode.TabIndex = 39
        Me.cmd_SubSubGroupCode.Visible = False
        '
        'lbl_GroupCode
        '
        Me.lbl_GroupCode.AutoSize = True
        Me.lbl_GroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_GroupCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_GroupCode.Location = New System.Drawing.Point(49, 28)
        Me.lbl_GroupCode.Name = "lbl_GroupCode"
        Me.lbl_GroupCode.Size = New System.Drawing.Size(82, 14)
        Me.lbl_GroupCode.TabIndex = 32
        Me.lbl_GroupCode.Text = "GROUP CODE :"
        '
        'txt_GroupCode
        '
        Me.txt_GroupCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_GroupCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_GroupCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GroupCode.Location = New System.Drawing.Point(146, 24)
        Me.txt_GroupCode.MaxLength = 15
        Me.txt_GroupCode.Name = "txt_GroupCode"
        Me.txt_GroupCode.Size = New System.Drawing.Size(80, 20)
        Me.txt_GroupCode.TabIndex = 6
        '
        'cmd_GroupCode
        '
        Me.cmd_GroupCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_GroupCode.Image = CType(resources.GetObject("cmd_GroupCode.Image"), System.Drawing.Image)
        Me.cmd_GroupCode.Location = New System.Drawing.Point(227, 21)
        Me.cmd_GroupCode.Name = "cmd_GroupCode"
        Me.cmd_GroupCode.Size = New System.Drawing.Size(23, 26)
        Me.cmd_GroupCode.TabIndex = 33
        '
        'lbl_SubGroupCode
        '
        Me.lbl_SubGroupCode.AutoSize = True
        Me.lbl_SubGroupCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SubGroupCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SubGroupCode.Location = New System.Drawing.Point(24, 71)
        Me.lbl_SubGroupCode.Name = "lbl_SubGroupCode"
        Me.lbl_SubGroupCode.Size = New System.Drawing.Size(106, 14)
        Me.lbl_SubGroupCode.TabIndex = 35
        Me.lbl_SubGroupCode.Text = "SUB GROUP CODE :"
        '
        'txt_SubGroupCode
        '
        Me.txt_SubGroupCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_SubGroupCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubGroupCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubGroupCode.Location = New System.Drawing.Point(146, 64)
        Me.txt_SubGroupCode.MaxLength = 15
        Me.txt_SubGroupCode.Name = "txt_SubGroupCode"
        Me.txt_SubGroupCode.Size = New System.Drawing.Size(80, 20)
        Me.txt_SubGroupCode.TabIndex = 7
        '
        'cmd_SubGroupCode
        '
        Me.cmd_SubGroupCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_SubGroupCode.Image = CType(resources.GetObject("cmd_SubGroupCode.Image"), System.Drawing.Image)
        Me.cmd_SubGroupCode.Location = New System.Drawing.Point(228, 60)
        Me.cmd_SubGroupCode.Name = "cmd_SubGroupCode"
        Me.cmd_SubGroupCode.Size = New System.Drawing.Size(23, 26)
        Me.cmd_SubGroupCode.TabIndex = 36
        '
        'txt_GroupDesc
        '
        Me.txt_GroupDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_GroupDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_GroupDesc.Enabled = False
        Me.txt_GroupDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GroupDesc.Location = New System.Drawing.Point(250, 24)
        Me.txt_GroupDesc.MaxLength = 15
        Me.txt_GroupDesc.Name = "txt_GroupDesc"
        Me.txt_GroupDesc.Size = New System.Drawing.Size(115, 20)
        Me.txt_GroupDesc.TabIndex = 34
        '
        'txt_SubSubGroupDesc
        '
        Me.txt_SubSubGroupDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_SubSubGroupDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubSubGroupDesc.Enabled = False
        Me.txt_SubSubGroupDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubSubGroupDesc.Location = New System.Drawing.Point(251, 96)
        Me.txt_SubSubGroupDesc.MaxLength = 15
        Me.txt_SubSubGroupDesc.Name = "txt_SubSubGroupDesc"
        Me.txt_SubSubGroupDesc.Size = New System.Drawing.Size(114, 20)
        Me.txt_SubSubGroupDesc.TabIndex = 40
        Me.txt_SubSubGroupDesc.Visible = False
        '
        'txt_Alias
        '
        Me.txt_Alias.BackColor = System.Drawing.Color.White
        Me.txt_Alias.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Alias.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Alias.Location = New System.Drawing.Point(108, 129)
        Me.txt_Alias.MaxLength = 15
        Me.txt_Alias.Name = "txt_Alias"
        Me.txt_Alias.Size = New System.Drawing.Size(128, 20)
        Me.txt_Alias.TabIndex = 5
        '
        'Cmd_ItemCode
        '
        Me.Cmd_ItemCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_ItemCode.Image = CType(resources.GetObject("Cmd_ItemCode.Image"), System.Drawing.Image)
        Me.Cmd_ItemCode.Location = New System.Drawing.Point(215, 39)
        Me.Cmd_ItemCode.Name = "Cmd_ItemCode"
        Me.Cmd_ItemCode.Size = New System.Drawing.Size(23, 26)
        Me.Cmd_ItemCode.TabIndex = 28
        '
        'txt_ItemName
        '
        Me.txt_ItemName.BackColor = System.Drawing.Color.Wheat
        Me.txt_ItemName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ItemName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ItemName.Location = New System.Drawing.Point(108, 68)
        Me.txt_ItemName.MaxLength = 100
        Me.txt_ItemName.Name = "txt_ItemName"
        Me.txt_ItemName.Size = New System.Drawing.Size(182, 20)
        Me.txt_ItemName.TabIndex = 3
        '
        'txt_ItemCode
        '
        Me.txt_ItemCode.BackColor = System.Drawing.Color.Wheat
        Me.txt_ItemCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ItemCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ItemCode.Location = New System.Drawing.Point(108, 41)
        Me.txt_ItemCode.MaxLength = 15
        Me.txt_ItemCode.Name = "txt_ItemCode"
        Me.txt_ItemCode.Size = New System.Drawing.Size(104, 20)
        Me.txt_ItemCode.TabIndex = 2
        '
        'cbo_StockUOM
        '
        Me.cbo_StockUOM.BackColor = System.Drawing.Color.Wheat
        Me.cbo_StockUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_StockUOM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_StockUOM.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbo_StockUOM.Location = New System.Drawing.Point(122, 32)
        Me.cbo_StockUOM.Name = "cbo_StockUOM"
        Me.cbo_StockUOM.Size = New System.Drawing.Size(168, 22)
        Me.cbo_StockUOM.Sorted = True
        Me.cbo_StockUOM.TabIndex = 18
        '
        'lbl_StockUOM
        '
        Me.lbl_StockUOM.AutoSize = True
        Me.lbl_StockUOM.BackColor = System.Drawing.Color.Transparent
        Me.lbl_StockUOM.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_StockUOM.Location = New System.Drawing.Point(16, 35)
        Me.lbl_StockUOM.Name = "lbl_StockUOM"
        Me.lbl_StockUOM.Size = New System.Drawing.Size(78, 14)
        Me.lbl_StockUOM.TabIndex = 51
        Me.lbl_StockUOM.Text = "STOCK UOM :"
        '
        'lbl_Alias
        '
        Me.lbl_Alias.AutoSize = True
        Me.lbl_Alias.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Alias.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Alias.Location = New System.Drawing.Point(42, 132)
        Me.lbl_Alias.Name = "lbl_Alias"
        Me.lbl_Alias.Size = New System.Drawing.Size(46, 14)
        Me.lbl_Alias.TabIndex = 30
        Me.lbl_Alias.Text = "ALIAS :"
        '
        'lbl_ItemName
        '
        Me.lbl_ItemName.AutoSize = True
        Me.lbl_ItemName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ItemName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ItemName.Location = New System.Drawing.Point(18, 72)
        Me.lbl_ItemName.Name = "lbl_ItemName"
        Me.lbl_ItemName.Size = New System.Drawing.Size(73, 14)
        Me.lbl_ItemName.TabIndex = 29
        Me.lbl_ItemName.Text = "ITEM NAME :"
        '
        'lbl_ItemCode
        '
        Me.lbl_ItemCode.AutoSize = True
        Me.lbl_ItemCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ItemCode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ItemCode.Location = New System.Drawing.Point(21, 44)
        Me.lbl_ItemCode.Name = "lbl_ItemCode"
        Me.lbl_ItemCode.Size = New System.Drawing.Size(71, 14)
        Me.lbl_ItemCode.TabIndex = 27
        Me.lbl_ItemCode.Text = "ITEM CODE :"
        '
        'txt_SubGroupDesc
        '
        Me.txt_SubGroupDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_SubGroupDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_SubGroupDesc.Enabled = False
        Me.txt_SubGroupDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SubGroupDesc.Location = New System.Drawing.Point(251, 63)
        Me.txt_SubGroupDesc.MaxLength = 15
        Me.txt_SubGroupDesc.Name = "txt_SubGroupDesc"
        Me.txt_SubGroupDesc.Size = New System.Drawing.Size(114, 20)
        Me.txt_SubGroupDesc.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 648)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "[IN DAYS]"
        Me.Label1.Visible = False
        '
        'lbl_storecode
        '
        Me.lbl_storecode.AutoSize = True
        Me.lbl_storecode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_storecode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_storecode.Location = New System.Drawing.Point(12, 13)
        Me.lbl_storecode.Name = "lbl_storecode"
        Me.lbl_storecode.Size = New System.Drawing.Size(80, 14)
        Me.lbl_storecode.TabIndex = 426
        Me.lbl_storecode.Text = "STORE CODE :"
        '
        'txt_Storecode
        '
        Me.txt_Storecode.BackColor = System.Drawing.Color.Wheat
        Me.txt_Storecode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Storecode.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Storecode.Location = New System.Drawing.Point(109, 9)
        Me.txt_Storecode.MaxLength = 5
        Me.txt_Storecode.Name = "txt_Storecode"
        Me.txt_Storecode.Size = New System.Drawing.Size(48, 20)
        Me.txt_Storecode.TabIndex = 1
        '
        'Cmd_Storecode
        '
        Me.Cmd_Storecode.BackColor = System.Drawing.Color.Bisque
        Me.Cmd_Storecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Storecode.Image = CType(resources.GetObject("Cmd_Storecode.Image"), System.Drawing.Image)
        Me.Cmd_Storecode.Location = New System.Drawing.Point(160, 6)
        Me.Cmd_Storecode.Name = "Cmd_Storecode"
        Me.Cmd_Storecode.Size = New System.Drawing.Size(23, 26)
        Me.Cmd_Storecode.TabIndex = 427
        Me.Cmd_Storecode.UseVisualStyleBackColor = False
        '
        'txt_StoreDesc
        '
        Me.txt_StoreDesc.BackColor = System.Drawing.Color.Wheat
        Me.txt_StoreDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_StoreDesc.Enabled = False
        Me.txt_StoreDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_StoreDesc.Location = New System.Drawing.Point(187, 9)
        Me.txt_StoreDesc.MaxLength = 50
        Me.txt_StoreDesc.Name = "txt_StoreDesc"
        Me.txt_StoreDesc.Size = New System.Drawing.Size(105, 20)
        Me.txt_StoreDesc.TabIndex = 425
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label3.Location = New System.Drawing.Point(19, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 429
        Me.Label3.Text = "AVERAGE RATE :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txt_avgRate
        '
        Me.txt_avgRate.BackColor = System.Drawing.Color.Transparent
        Me.txt_avgRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txt_avgRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_avgRate.ForeColor = System.Drawing.Color.Blue
        Me.txt_avgRate.Location = New System.Drawing.Point(147, 88)
        Me.txt_avgRate.Margin = New System.Windows.Forms.Padding(3)
        Me.txt_avgRate.Name = "txt_avgRate"
        Me.txt_avgRate.Size = New System.Drawing.Size(56, 23)
        Me.txt_avgRate.TabIndex = 434
        Me.txt_avgRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cbo_ABC_category
        '
        Me.Cbo_ABC_category.BackColor = System.Drawing.Color.Wheat
        Me.Cbo_ABC_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_ABC_category.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbo_ABC_category.Items.AddRange(New Object() {"A", "B", "C"})
        Me.Cbo_ABC_category.Location = New System.Drawing.Point(148, 151)
        Me.Cbo_ABC_category.Name = "Cbo_ABC_category"
        Me.Cbo_ABC_category.Size = New System.Drawing.Size(81, 22)
        Me.Cbo_ABC_category.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 14)
        Me.Label6.TabIndex = 435
        Me.Label6.Text = "ABC  CATEGORY :"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(259, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 24)
        Me.Label8.TabIndex = 474
        Me.Label8.Text = "F4"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(259, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 24)
        Me.Label9.TabIndex = 475
        Me.Label9.Text = "F4"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(259, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 24)
        Me.Label10.TabIndex = 476
        Me.Label10.Text = "F4"
        Me.Label10.Visible = False
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(552, 16)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(312, 25)
        Me.lbl_Freeze.TabIndex = 477
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'lbl_ReceivingUOM
        '
        Me.lbl_ReceivingUOM.AutoSize = True
        Me.lbl_ReceivingUOM.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ReceivingUOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ReceivingUOM.Location = New System.Drawing.Point(8, 680)
        Me.lbl_ReceivingUOM.Name = "lbl_ReceivingUOM"
        Me.lbl_ReceivingUOM.Size = New System.Drawing.Size(114, 13)
        Me.lbl_ReceivingUOM.TabIndex = 479
        Me.lbl_ReceivingUOM.Text = "RECEIVING UOM :"
        Me.lbl_ReceivingUOM.Visible = False
        '
        'cbo_ReceivingUOM
        '
        Me.cbo_ReceivingUOM.BackColor = System.Drawing.Color.Wheat
        Me.cbo_ReceivingUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_ReceivingUOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_ReceivingUOM.Location = New System.Drawing.Point(144, 680)
        Me.cbo_ReceivingUOM.Name = "cbo_ReceivingUOM"
        Me.cbo_ReceivingUOM.Size = New System.Drawing.Size(152, 21)
        Me.cbo_ReceivingUOM.TabIndex = 478
        Me.cbo_ReceivingUOM.Visible = False
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(162, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(23, 24)
        Me.Label16.TabIndex = 473
        Me.Label16.Text = "F4"
        Me.Label16.Visible = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Exit.Location = New System.Drawing.Point(3, 449)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Exit.TabIndex = 24
        Me.Cmd_Exit.Text = "Exit[F11]"
        Me.Cmd_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Exit.UseVisualStyleBackColor = False
        '
        'cmd_export
        '
        Me.cmd_export.BackColor = System.Drawing.Color.Transparent
        Me.cmd_export.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_export.ForeColor = System.Drawing.Color.Black
        Me.cmd_export.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_export.Location = New System.Drawing.Point(4, 321)
        Me.cmd_export.Name = "cmd_export"
        Me.cmd_export.Size = New System.Drawing.Size(134, 56)
        Me.cmd_export.TabIndex = 26
        Me.cmd_export.Text = "Export"
        Me.cmd_export.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_export.UseVisualStyleBackColor = False
        '
        'cmd_auth
        '
        Me.cmd_auth.BackColor = System.Drawing.Color.Transparent
        Me.cmd_auth.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_auth.ForeColor = System.Drawing.Color.Black
        Me.cmd_auth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_auth.Location = New System.Drawing.Point(3, 384)
        Me.cmd_auth.Name = "cmd_auth"
        Me.cmd_auth.Size = New System.Drawing.Size(134, 56)
        Me.cmd_auth.TabIndex = 437
        Me.cmd_auth.Text = "Authorize"
        Me.cmd_auth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_auth.UseVisualStyleBackColor = False
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_View.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.Black
        Me.Cmd_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_View.Location = New System.Drawing.Point(4, 197)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_View.TabIndex = 25
        Me.Cmd_View.Text = " View[F9]"
        Me.Cmd_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_View.UseVisualStyleBackColor = False
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Freeze.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Freeze.Location = New System.Drawing.Point(4, 136)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Freeze.TabIndex = 24
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Me.Cmd_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Freeze.UseVisualStyleBackColor = False
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Add.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Add.Location = New System.Drawing.Point(4, 74)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Add.TabIndex = 23
        Me.Cmd_Add.Text = "Add [F7]"
        Me.Cmd_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Add.UseVisualStyleBackColor = False
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Clear.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Cmd_Clear.Location = New System.Drawing.Point(4, 13)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(134, 56)
        Me.Cmd_Clear.TabIndex = 21
        Me.Cmd_Clear.Text = "Clear[F6]"
        Me.Cmd_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Cmd_Clear.UseVisualStyleBackColor = False
        '
        'cbo_SaleUOM
        '
        Me.cbo_SaleUOM.BackColor = System.Drawing.Color.Wheat
        Me.cbo_SaleUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SaleUOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_SaleUOM.Location = New System.Drawing.Point(122, 194)
        Me.cbo_SaleUOM.Name = "cbo_SaleUOM"
        Me.cbo_SaleUOM.Size = New System.Drawing.Size(168, 21)
        Me.cbo_SaleUOM.TabIndex = 480
        '
        'lbl_SaleUOM
        '
        Me.lbl_SaleUOM.AutoSize = True
        Me.lbl_SaleUOM.BackColor = System.Drawing.Color.Transparent
        Me.lbl_SaleUOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_SaleUOM.Location = New System.Drawing.Point(13, 194)
        Me.lbl_SaleUOM.Name = "lbl_SaleUOM"
        Me.lbl_SaleUOM.Size = New System.Drawing.Size(98, 13)
        Me.lbl_SaleUOM.TabIndex = 481
        Me.lbl_SaleUOM.Text = "REPORT UOM :"
        '
        'chklst_Uom
        '
        Me.chklst_Uom.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chklst_Uom.Location = New System.Drawing.Point(119, 78)
        Me.chklst_Uom.Name = "chklst_Uom"
        Me.chklst_Uom.Size = New System.Drawing.Size(176, 109)
        Me.chklst_Uom.TabIndex = 479
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 14)
        Me.Label11.TabIndex = 480
        Me.Label11.Text = "TRANS  UOM :"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.chklst_Uom)
        Me.GroupBox7.Controls.Add(Me.lbl_SaleUOM)
        Me.GroupBox7.Controls.Add(Me.cbo_SaleUOM)
        Me.GroupBox7.Controls.Add(Me.lbl_StockUOM)
        Me.GroupBox7.Controls.Add(Me.cbo_StockUOM)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(173, 444)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(307, 222)
        Me.GroupBox7.TabIndex = 50
        Me.GroupBox7.TabStop = False
        '
        'TXT_BASERATE
        '
        Me.TXT_BASERATE.BackColor = System.Drawing.Color.FloralWhite
        Me.TXT_BASERATE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_BASERATE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BASERATE.Location = New System.Drawing.Point(288, 27)
        Me.TXT_BASERATE.MaxLength = 15
        Me.TXT_BASERATE.Name = "TXT_BASERATE"
        Me.TXT_BASERATE.Size = New System.Drawing.Size(59, 20)
        Me.TXT_BASERATE.TabIndex = 16
        Me.TXT_BASERATE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TXT_BASERATE.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(210, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 14)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "BASE RATE :"
        Me.Label4.Visible = False
        '
        'cbo_Valuation
        '
        Me.cbo_Valuation.BackColor = System.Drawing.Color.Wheat
        Me.cbo_Valuation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_Valuation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_Valuation.Items.AddRange(New Object() {"NONE", "AVERAGE"})
        Me.cbo_Valuation.Location = New System.Drawing.Point(159, 0)
        Me.cbo_Valuation.Name = "cbo_Valuation"
        Me.cbo_Valuation.Size = New System.Drawing.Size(8, 21)
        Me.cbo_Valuation.TabIndex = 51
        Me.cbo_Valuation.Visible = False
        '
        'Txt_profitper
        '
        Me.Txt_profitper.BackColor = System.Drawing.Color.Wheat
        Me.Txt_profitper.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_profitper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_profitper.Location = New System.Drawing.Point(148, 27)
        Me.Txt_profitper.MaxLength = 15
        Me.Txt_profitper.Name = "Txt_profitper"
        Me.Txt_profitper.Size = New System.Drawing.Size(56, 20)
        Me.Txt_profitper.TabIndex = 52
        Me.Txt_profitper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_profitper
        '
        Me.lbl_profitper.AutoSize = True
        Me.lbl_profitper.BackColor = System.Drawing.Color.Transparent
        Me.lbl_profitper.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profitper.Location = New System.Drawing.Point(4, 29)
        Me.lbl_profitper.Name = "lbl_profitper"
        Me.lbl_profitper.Size = New System.Drawing.Size(123, 14)
        Me.lbl_profitper.TabIndex = 53
        Me.lbl_profitper.Text = "PROFIT PERCENTAGE :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(212, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 14)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "CASE QTY :"
        '
        'txt_Caseqty
        '
        Me.txt_Caseqty.BackColor = System.Drawing.Color.White
        Me.txt_Caseqty.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Caseqty.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Caseqty.Location = New System.Drawing.Point(288, 101)
        Me.txt_Caseqty.MaxLength = 15
        Me.txt_Caseqty.Name = "txt_Caseqty"
        Me.txt_Caseqty.Size = New System.Drawing.Size(59, 20)
        Me.txt_Caseqty.TabIndex = 54
        Me.txt_Caseqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Txt_vat)
        Me.GroupBox6.Controls.Add(Me.lbl_profitper)
        Me.GroupBox6.Controls.Add(Me.cbo_Valuation)
        Me.GroupBox6.Controls.Add(Me.lbl_PurchaseRate)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Txt_profitper)
        Me.GroupBox6.Controls.Add(Me.TXT_BASERATE)
        Me.GroupBox6.Controls.Add(Me.txt_Caseqty)
        Me.GroupBox6.Controls.Add(Me.lbl_SaleRate)
        Me.GroupBox6.Controls.Add(Me.txt_SaleRate)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.txt_avgRate)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.txt_PurchaseRate)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(483, 286)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(361, 143)
        Me.GroupBox6.TabIndex = 46
        Me.GroupBox6.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 120)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 14)
        Me.Label13.TabIndex = 436
        Me.Label13.Text = "VAT(%) :"
        Me.Label13.Visible = False
        '
        'Txt_vat
        '
        Me.Txt_vat.BackColor = System.Drawing.Color.Wheat
        Me.Txt_vat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_vat.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_vat.Location = New System.Drawing.Point(148, 118)
        Me.Txt_vat.MaxLength = 6
        Me.Txt_vat.Name = "Txt_vat"
        Me.Txt_vat.Size = New System.Drawing.Size(57, 20)
        Me.Txt_vat.TabIndex = 435
        Me.Txt_vat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Txt_vat.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 14)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "ECONOMIC ORDER QTY :"
        '
        'txt_eoq
        '
        Me.txt_eoq.BackColor = System.Drawing.Color.White
        Me.txt_eoq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_eoq.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_eoq.Location = New System.Drawing.Point(161, 19)
        Me.txt_eoq.MaxLength = 15
        Me.txt_eoq.Name = "txt_eoq"
        Me.txt_eoq.Size = New System.Drawing.Size(130, 20)
        Me.txt_eoq.TabIndex = 47
        Me.txt_eoq.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_ReorderLevel
        '
        Me.lbl_ReorderLevel.AutoSize = True
        Me.lbl_ReorderLevel.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ReorderLevel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ReorderLevel.Location = New System.Drawing.Point(36, 119)
        Me.lbl_ReorderLevel.Name = "lbl_ReorderLevel"
        Me.lbl_ReorderLevel.Size = New System.Drawing.Size(102, 14)
        Me.lbl_ReorderLevel.TabIndex = 50
        Me.lbl_ReorderLevel.Text = "RE-ORDER LEVEL :"
        '
        'txt_ReorderLevel
        '
        Me.txt_ReorderLevel.BackColor = System.Drawing.Color.White
        Me.txt_ReorderLevel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ReorderLevel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ReorderLevel.Location = New System.Drawing.Point(161, 116)
        Me.txt_ReorderLevel.MaxLength = 15
        Me.txt_ReorderLevel.Name = "txt_ReorderLevel"
        Me.txt_ReorderLevel.Size = New System.Drawing.Size(131, 20)
        Me.txt_ReorderLevel.TabIndex = 49
        Me.txt_ReorderLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.txt_ReorderLevel)
        Me.GroupBox3.Controls.Add(Me.lbl_ReorderLevel)
        Me.GroupBox3.Controls.Add(Me.txt_eoq)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txt_MaxQty)
        Me.GroupBox3.Controls.Add(Me.txt_MinQty)
        Me.GroupBox3.Controls.Add(Me.lbl_MaxQty)
        Me.GroupBox3.Controls.Add(Me.lbl_MinQty)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(175, 282)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 161)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        '
        'TXT_CATEGORY
        '
        Me.TXT_CATEGORY.BackColor = System.Drawing.Color.Wheat
        Me.TXT_CATEGORY.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXT_CATEGORY.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CATEGORY.Location = New System.Drawing.Point(108, 98)
        Me.TXT_CATEGORY.MaxLength = 15
        Me.TXT_CATEGORY.Name = "TXT_CATEGORY"
        Me.TXT_CATEGORY.Size = New System.Drawing.Size(128, 20)
        Me.TXT_CATEGORY.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 14)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "CATEGORY :"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(242, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 24)
        Me.Label7.TabIndex = 474
        Me.Label7.Text = "F4"
        Me.Label7.Visible = False
        '
        'BttnCategory_Help
        '
        Me.BttnCategory_Help.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BttnCategory_Help.Image = CType(resources.GetObject("BttnCategory_Help.Image"), System.Drawing.Image)
        Me.BttnCategory_Help.Location = New System.Drawing.Point(242, 94)
        Me.BttnCategory_Help.Name = "BttnCategory_Help"
        Me.BttnCategory_Help.Size = New System.Drawing.Size(23, 26)
        Me.BttnCategory_Help.TabIndex = 475
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txt_Alias)
        Me.GroupBox1.Controls.Add(Me.lbl_Alias)
        Me.GroupBox1.Controls.Add(Me.Cmd_Storecode)
        Me.GroupBox1.Controls.Add(Me.BttnCategory_Help)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lbl_storecode)
        Me.GroupBox1.Controls.Add(Me.txt_StoreDesc)
        Me.GroupBox1.Controls.Add(Me.TXT_CATEGORY)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_Storecode)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_ItemCode)
        Me.GroupBox1.Controls.Add(Me.Cmd_ItemCode)
        Me.GroupBox1.Controls.Add(Me.txt_ItemName)
        Me.GroupBox1.Controls.Add(Me.lbl_ItemCode)
        Me.GroupBox1.Controls.Add(Me.lbl_ItemName)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(176, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 173)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        '
        'CBO_TAXREBATE
        '
        Me.CBO_TAXREBATE.BackColor = System.Drawing.Color.Wheat
        Me.CBO_TAXREBATE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBO_TAXREBATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_TAXREBATE.Items.AddRange(New Object() {"YES", "NO"})
        Me.CBO_TAXREBATE.Location = New System.Drawing.Point(416, 152)
        Me.CBO_TAXREBATE.Name = "CBO_TAXREBATE"
        Me.CBO_TAXREBATE.Size = New System.Drawing.Size(80, 21)
        Me.CBO_TAXREBATE.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CBO_TAXREBATE)
        Me.GroupBox2.Controls.Add(Me.txt_SubGroupCode)
        Me.GroupBox2.Controls.Add(Me.lbl_SubGroupCode)
        Me.GroupBox2.Controls.Add(Me.Cbo_ABC_category)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_SubSubGroupDesc)
        Me.GroupBox2.Controls.Add(Me.cmd_GroupCode)
        Me.GroupBox2.Controls.Add(Me.txt_SubGroupDesc)
        Me.GroupBox2.Controls.Add(Me.cmd_SubGroupCode)
        Me.GroupBox2.Controls.Add(Me.txt_GroupDesc)
        Me.GroupBox2.Controls.Add(Me.cmd_SubSubGroupCode)
        Me.GroupBox2.Controls.Add(Me.lbl_SubSubGroupCode)
        Me.GroupBox2.Controls.Add(Me.txt_GroupCode)
        Me.GroupBox2.Controls.Add(Me.txt_SubSubGroupCode)
        Me.GroupBox2.Controls.Add(Me.lbl_GroupCode)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(479, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 184)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'chk_excel
        '
        Me.chk_excel.BackColor = System.Drawing.Color.Transparent
        Me.chk_excel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_excel.Location = New System.Drawing.Point(857, 678)
        Me.chk_excel.Name = "chk_excel"
        Me.chk_excel.Size = New System.Drawing.Size(72, 24)
        Me.chk_excel.TabIndex = 466
        Me.chk_excel.Text = "Excel"
        Me.chk_excel.UseVisualStyleBackColor = False
        '
        'cmd_rpt
        '
        Me.cmd_rpt.BackColor = System.Drawing.Color.Transparent
        Me.cmd_rpt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_rpt.ForeColor = System.Drawing.Color.Black
        Me.cmd_rpt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_rpt.Location = New System.Drawing.Point(4, 259)
        Me.cmd_rpt.Name = "cmd_rpt"
        Me.cmd_rpt.Size = New System.Drawing.Size(134, 56)
        Me.cmd_rpt.TabIndex = 480
        Me.cmd_rpt.Text = "Report"
        Me.cmd_rpt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_rpt.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cmd_export)
        Me.GroupBox4.Controls.Add(Me.cmd_rpt)
        Me.GroupBox4.Controls.Add(Me.Cmd_View)
        Me.GroupBox4.Controls.Add(Me.cmd_auth)
        Me.GroupBox4.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox4.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox4.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox4.Controls.Add(Me.Cmd_Add)
        Me.GroupBox4.Location = New System.Drawing.Point(852, 97)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(141, 523)
        Me.GroupBox4.TabIndex = 481
        Me.GroupBox4.TabStop = False
        '
        'Item_Master
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1014, 692)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.chk_excel)
        Me.Controls.Add(Me.lbl_ReceivingUOM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.lbl_LeadTime)
        Me.Controls.Add(Me.txt_LeadTime)
        Me.Controls.Add(Me.cbo_ReceivingUOM)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Item_Master"
        Me.Opacity = 0.5R
        Me.Text = "MASTER[ITEM MASTER]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim sqlstring As String
    Dim vardoublevalue As Double
    Dim gconnection As New GlobalClass
    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim strSQL, ABCcategory, Taxrebate As String
        Dim varpurchrate, varsalerate, avgrate As Double
        Dim Insert(0), Update(0) As String

        If Trim(Cbo_ABC_category.Text) = "" Then
            ABCcategory = "A"
        Else
            ABCcategory = Cbo_ABC_category.Text
        End If
        If Trim(CBO_TAXREBATE.Text) = "" Then
            Taxrebate = "NO"
        Else
            Taxrebate = CBO_TAXREBATE.Text
        End If

        If Cmd_Add.Text = "Add [F7]" Then
            Call checkValidation() '''--->Check Validation
            If boolchk = False Then Exit Sub
            If Val(txt_OpeningStock.Text) = 0 Then
                avgrate = 0
            Else
                avgrate = Val(txt_OpeningAmount.Text) / Val(txt_OpeningStock.Text)
            End If
            '**********************For Purchase Order Entry**********************************
            strSQL = "INSERT INTO PO_ITEMMASTER(Itemcode,Itemname,shortname,uom,currentofferrate, "
            strSQL = strSQL & "freeze,adduser,adddatetime) values('" & Trim(txt_ItemCode.Text) & "', '" & Trim(txt_ItemName.Text) & "',"
            strSQL = strSQL & "'" & Trim(txt_Alias.Text) & "','" & cbo_StockUOM.Text & "', '" & txt_PurchaseRate.Text & "','N', "
            strSQL = strSQL & "'" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
            Insert(0) = strSQL
            '''************************************* For Inventory Item Master **********************************''''
            strSQL = "INSERT INTO inventoryitemmaster (itemcode,itemname,alias,groupcode,groupname,subgroupcode,subgroupname,"
            strSQL = strSQL & "subsubgroupcode,subsubgroupname,reorderlevel,minqty,maxqty,valuation,purchaserate,taxper,Profitper,salerate,stockuom,"
            strSQL = strSQL & "receiveuom,saleuom,leadtime,doubleuom,opstock,opvalue,convvalue,Freeze,Adduser,Adddate,CATEGORY,ABC,STORECODE,BASERATE,TAXREBATE,eoq,CASEQTY) "
            strSQL = strSQL & " VALUES('" & Trim(txt_ItemCode.Text) & "','" & Replace(Trim(txt_ItemName.Text), "'", "") & "' ,"
            strSQL = strSQL & " '" & Trim(txt_Alias.Text) & "' ,"
            strSQL = strSQL & " '" & Trim(txt_GroupCode.Text) & "' ,"
            strSQL = strSQL & " '" & Replace(Trim(txt_GroupDesc.Text), "'", "") & "' ,"
            strSQL = strSQL & " '" & Trim(txt_SubGroupCode.Text) & "' ,"
            strSQL = strSQL & " '" & Replace(Trim(txt_SubGroupDesc.Text), "'", "") & "' ,"
            strSQL = strSQL & " '" & Trim(txt_SubGroupCode.Text) & "' ,"
            strSQL = strSQL & " '" & Replace(Trim(txt_SubGroupDesc.Text), "'", "") & "' ,"
            strSQL = strSQL & " " & Val(txt_ReorderLevel.Text) & " ,"
            strSQL = strSQL & " " & Val(txt_MinQty.Text) & " ,"
            strSQL = strSQL & " " & Val(txt_MaxQty.Text) & " ,"
            strSQL = strSQL & " '" & Trim(cbo_Valuation.Text) & "' ,"
            strSQL = strSQL & " " & Format(Val(txt_PurchaseRate.Text), "0.00") & " ,"
            strSQL = strSQL & " " & Format(Val(Txt_vat.Text), "0.00") & " ,"
            strSQL = strSQL & " " & Format(Val(Txt_profitper.Text), "0.00") & " ,"
            strSQL = strSQL & " " & Format(Val(txt_SaleRate.Text), "0.00") & " ,"
            strSQL = strSQL & " '" & Trim(cbo_StockUOM.Text) & "' ,"
            strSQL = strSQL & " '" & Trim(cbo_StockUOM.Text) & "' ,"
            strSQL = strSQL & " '" & Trim(cbo_SaleUOM.Text) & "' ,"
            strSQL = strSQL & " 1,"
            strSQL = strSQL & " '" & IIf(Trim(cbo_DoubleUnit.Text) = "", Trim(cbo_StockUOM.Text), Trim(cbo_DoubleUnit.Text)) & "' ,"
            strSQL = strSQL & " " & Format(Val(txt_OpeningStock.Text), "0.000") & " ,"
            strSQL = strSQL & " " & Format(Val(txt_OpeningAmount.Text), "0.00") & " ,"
            strSQL = strSQL & " " & IIf(Format(Val(txt_Conversion.Text), "0.00") = 0, 1, Val(txt_Conversion.Text)) & " ,"
            strSQL = strSQL & "'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "','" & Trim(TXT_CATEGORY.Text) & "',"

            strSQL = strSQL & " '" & Trim(ABCcategory) & "' ,"
            strSQL = strSQL & "'" & Trim(txt_Storecode.Text) & "' ,"
            strSQL = strSQL & " " & Format(Val(txt_PurchaseRate.Text), "0.00") & " ,"
            strSQL = strSQL & " '" & Trim(Taxrebate) & "' ,"
            strSQL = strSQL & " " & Trim(Val(txt_eoq.Text)) & "," & Trim(Val(txt_Caseqty.Text)) & ")"
            'Dim MAINSTORE, QUERY As String
            'QUERY = "SELECT STORECODE FROM STOREMASTER WHERE STORESTATUS='M'"
            'gconnection.getDataSet(QUERY, "MAINSTORE")
            'If gdataset.Tables("MAINSTORE").Rows.Count > 0 Then
            '    MAINSTORE = Trim(gdataset.Tables("MAINSTORE").Rows(0).Item("STORECODE") & "")
            'End If
            'strSQL = strSQL & "'" & MAINSTORE & "' )"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = strSQL

            '************************************TRANS UOM INSERT ****************************************
            Dim TYPE() As String
            Dim I As Integer
            If chklst_Uom.CheckedItems.Count > 0 Then
                For I = 0 To chklst_Uom.CheckedItems.Count - 1
                    TYPE = Split(chklst_Uom.CheckedItems(I), "-->")
                    strSQL = "INSERT INTO INVITEM_TRANSUOM_LINK(Itemcode,ItemName,Tranuom,stockuom,Storecode,Adduser,Adddate)"
                    strSQL = strSQL & " VALUES('" & Trim(txt_ItemCode.Text) & "','" & Trim(txt_ItemName.Text) & "' ,"
                    'strSQL = strSQL & " " & "'" & TYPE(1) & "',"
                    strSQL = strSQL & " '" & Trim(cbo_SaleUOM.Text) & " ',"
                    strSQL = strSQL & " '" & Trim(cbo_StockUOM.Text) & " ',"
                    strSQL = strSQL & " '" & Trim(txt_Storecode.Text) & "',"
                    strSQL = strSQL & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
                    ReDim Preserve Insert(Insert.Length)
                    Insert(Insert.Length - 1) = strSQL
                Next
            End If
            '''************************************* For OpeningStock **********************************''''
            strSQL = "INSERT INTO openingstock(Itemcode,ItemName,mainOpstock,mainclstock,bar1opstock,bar1clstock,"
            strSQL = strSQL & " bar2opstock,bar2clstock,bar3opstock,bar3clstock,convuom,stockuom,doublevalue,bar1doublevalue, "
            strSQL = strSQL & " bar2doublevalue,bar3doublevalue,lowratio,highratio,avgrate,avgvalue,Adduser,Adddate)"
            strSQL = strSQL & " VALUES('" & Trim(txt_ItemCode.Text) & "','" & Trim(txt_ItemName.Text) & "' ,"
            strSQL = strSQL & " " & Format(Val(txt_OpeningStock.Text), "0.000") & "  ,"
            strSQL = strSQL & " " & Format(Val(txt_OpeningStock.Text), "0.00") & " ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " '" & IIf(Trim(cbo_DoubleUnit.Text) = "", Trim(cbo_StockUOM.Text), Trim(cbo_DoubleUnit.Text)) & "' , "
            strSQL = strSQL & " '" & Trim(cbo_StockUOM.Text) & "' , "
            strSQL = strSQL & " " & Val(vardoublevalue) & " , "
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 0 ,"
            strSQL = strSQL & " 1 ,"
            strSQL = strSQL & " " & IIf(Format(Val(txt_Conversion.Text), "0.00") = 0, 1, Val(txt_Conversion.Text)) & " , "
            strSQL = strSQL & " " & Val(avgrate) & " , "
            strSQL = strSQL & " " & Format(Val(txt_OpeningAmount.Text), "0.00") & " , "
            strSQL = strSQL & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = strSQL
            '''************************************* For InventoryRateHistory **********************************''''
            strSQL = "INSERT INTO inventoryratehistory (itemcode,itemname,modifydate,purchaserate,salerate,adduser,adddate)"
            strSQL = strSQL & " VALUES( '" & Trim(txt_ItemCode.Text) & "','" & Trim(txt_ItemName.Text) & "' ,"
            strSQL = strSQL & " '" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "' ,"
            strSQL = strSQL & " " & Format(Val(txt_PurchaseRate.Text), "0.00") & ","
            strSQL = strSQL & " " & Format(Val(txt_SaleRate.Text), "0.00") & ","
            strSQL = strSQL & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
            ReDim Preserve Insert(Insert.Length)
            Insert(Insert.Length - 1) = strSQL
            '''************************************* For GRN_DETAILS **********************************''''
            'If Mid(Me.txt_Storecode.Text, 1, 1) = "M" Then
            '    strSQL = "INSERT INTO GRN_DETAILS (Profitper)"
            '    strSQL = strSQL & " VALUES( '" & Trim(Txt_profitper.Text) & "')"
            '    strSQL = strSQL & " where grn_details.itemcode = '" & Trim(txt_ItemCode.Text) & "' and grn_details.storecode = 'MNS' )"
            '    ReDim Preserve Insert(Insert.Length)
            'End If
            Insert(Insert.Length - 1) = strSQL
            gconnection.MoreTrans(Insert)
            'RAJU
            'Me.Cmd_Clear_Click(sender, e)
            Call clearadd()
            'RAJU
            'gconnection.openConnection()
            'gcommand = New SqlCommand("CP_inventoryitemmaster", gconnection.Myconn)
            'gcommand.CommandTimeout = 1000000000
            'gcommand.CommandType = CommandType.StoredProcedure
            'gcommand.ExecuteNonQuery()
            'gconnection.closeConnection()

        ElseIf Cmd_Add.Text = "Update[F7]" Then
            Call checkValidation() '''--->Check Validation
            If Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
                If Me.lbl_Freeze.Visible = True Then
                    MessageBox.Show(" The Freezed Record Can't Be Updated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    boolchk = False
                End If
            End If
            If boolchk = False Then Exit Sub
            '***************************For Purchase Order Item Master*************************
            strSQL = "update PO_ITEMMASTER set "
            strSQL = strSQL & "itemname='" & Replace(Trim(txt_ItemName.Text), "'", "") & "' ,"
            strSQL = strSQL & "shortname='" & Replace(Trim(txt_Alias.Text), "'", "") & "',"
            strSQL = strSQL & "uom='" & Trim(cbo_StockUOM.Text) & "' ,"
            strSQL = strSQL & "currentofferrate=" & Format(Val(txt_PurchaseRate.Text), "0.00") & " ,"
            strSQL = strSQL & "adduser='" & Trim(gUsername) & "',"
            strSQL = strSQL & "adddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm") & "'"
            strSQL = strSQL & " WHERE itemcode='" & Trim(txt_ItemCode.Text) & "'"
            strSQL = strSQL & " AND storecode='" & Trim(txt_Storecode.Text) & "'"
            Update(0) = strSQL
            '''************************************* For Inventory Item Master **********************************''''
            strSQL = "UPDATE inventoryitemmaster SET "
            strSQL = strSQL & " itemname='" & Replace(Trim(txt_ItemName.Text), "'", "") & "' ,"
            strSQL = strSQL & " STORECODE = '" & Trim(txt_Storecode.Text) & "' ,"
            strSQL = strSQL & " alias='" & Trim(txt_Alias.Text) & "' ,"
            strSQL = strSQL & " groupcode='" & Trim(txt_GroupCode.Text) & "' ,"
            strSQL = strSQL & " groupname='" & Replace(Trim(txt_GroupDesc.Text), "'", "") & "' ,"
            strSQL = strSQL & " subgroupcode='" & Trim(txt_SubGroupCode.Text) & "' ,"
            strSQL = strSQL & " subgroupname='" & Replace(Trim(txt_SubGroupDesc.Text), "'", "") & "' ,"
            strSQL = strSQL & " subsubgroupcode='" & Trim(txt_SubSubGroupCode.Text) & "' ,"
            strSQL = strSQL & " subsubgroupname='" & Replace(Trim(txt_SubSubGroupDesc.Text), "'", "") & "' ,"
            strSQL = strSQL & " reorderlevel=" & Val(txt_ReorderLevel.Text) & " ,"
            strSQL = strSQL & " minqty=" & Val(txt_MinQty.Text) & " ,"
            strSQL = strSQL & " abc='" & Trim(ABCcategory) & "' ,"
            strSQL = strSQL & " maxqty=" & Val(txt_MaxQty.Text) & " ,"
            strSQL = strSQL & " valuation='" & Trim(cbo_Valuation.Text) & "' ,"
            strSQL = strSQL & " purchaserate=" & Format(Val(txt_PurchaseRate.Text), "0.00") & " ,"
            strSQL = strSQL & " taxper=" & Format(Val(Txt_vat.Text), "0.00") & " ,"
            strSQL = strSQL & " BASERATE=" & Format(Val(TXT_BASERATE.Text), "0.00") & " ,"
            strSQL = strSQL & " Profitper=" & Format(Val(Txt_profitper.Text), "0.00") & " ,"
            strSQL = strSQL & " salerate=" & Format(Val(txt_SaleRate.Text), "0.00") & " ,"
            strSQL = strSQL & " stockuom='" & Trim(cbo_StockUOM.Text) & "' ,"
            strSQL = strSQL & " receiveuom='" & Trim(cbo_StockUOM.Text) & "' ,"
            strSQL = strSQL & " saleuom='" & Trim(cbo_SaleUOM.Text) & "' ,"
            strSQL = strSQL & " leadtime= 1 ,"
            strSQL = strSQL & " doubleuom='" & Trim(cbo_DoubleUnit.Text) & "' ,"
            strSQL = strSQL & " opstock=" & Format(Val(txt_OpeningStock.Text), "0.000") & " ,"
            strSQL = strSQL & " opvalue=" & Format(Val(txt_OpeningAmount.Text), "0.00") & " ,"
            strSQL = strSQL & " convvalue=" & IIf(Format(Val(txt_Conversion.Text), "0.00") = 0, 1, Val(txt_Conversion.Text)) & " ,"
            strSQL = strSQL & " Freeze='N',UPDATEUSER='" & Trim(gUsername) & "',UPDATETIME='" & Format(Now, "dd-MMM-yyyy hh:mm") & "',"
            strSQL = strSQL & " CATEGORY = '" & Trim(TXT_CATEGORY.Text) & "',caseqty = " & Val(txt_Caseqty.Text) & ""
            strSQL = strSQL & " WHERE itemcode='" & Trim(txt_ItemCode.Text) & "'"
            strSQL = strSQL & " AND storecode='" & Trim(txt_Storecode.Text) & "'"
            ReDim Preserve Update(Update.Length)
            Update(Update.Length - 1) = strSQL

            strSQL = "Delete from  INVITEM_TRANSUOM_LINK  where  Itemcode= '" & Trim(txt_ItemCode.Text) & "'"
            ReDim Preserve Update(Update.Length)
            Update(Update.Length - 1) = strSQL

            Dim I As Integer
            Dim TYPE() As String
            If chklst_Uom.CheckedItems.Count > 0 Then
                For I = 0 To chklst_Uom.CheckedItems.Count - 1
                    TYPE = Split(chklst_Uom.CheckedItems(I), "-->")
                    strSQL = "INSERT INTO INVITEM_TRANSUOM_LINK(Itemcode,ItemName,Tranuom,stockuom,Storecode,Adduser,Adddate)"
                    strSQL = strSQL & " VALUES('" & Trim(txt_ItemCode.Text) & "','" & Trim(txt_ItemName.Text) & "' ,"
                    strSQL = strSQL & " " & "'" & TYPE(0) & "',"
                    strSQL = strSQL & " '" & Trim(cbo_StockUOM.Text) & " ',"
                    strSQL = strSQL & " '" & Trim(txt_Storecode.Text) & "',"
                    strSQL = strSQL & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
                    ReDim Preserve Update(Update.Length)
                    Update(Update.Length - 1) = strSQL
                Next
            End If
            '''************************************* For GRN_DETAILS **********************************''''

            'If Mid(Me.txt_Storecode.Text, 1, 1) = "M" Then
            '    strSQL = "UPDATE Grn_details SET "
            '    strSQL = strSQL & " Profitper=" & Format(Val(Txt_profitper.Text), "0.00") & " "
            '    ReDim Preserve Update(Update.Length)
            '    Update(Update.Length - 1) = strSQL
            'End If
            '''************************************* For OpeningStock **********************************''''
            strSQL = "UPDATE openingstock SET "
            strSQL = strSQL & " ItemName='" & Trim(txt_ItemName.Text) & "' ,"
            strSQL = strSQL & " convuom='" & Trim(cbo_DoubleUnit.Text) & "' , "
            strSQL = strSQL & " stockuom='" & Trim(cbo_StockUOM.Text) & "' , "
            strSQL = strSQL & " doublevalue=" & Format(Val(vardoublevalue), "0.00") & " , "
            strSQL = strSQL & " lowratio= 1 ,"
            strSQL = strSQL & " highratio=" & IIf(Format(Val(txt_Conversion.Text), "0.00") = 0, 1, Val(txt_Conversion.Text)) & " , "
            strSQL = strSQL & " avgrate=" & Val(avgrate) & " , "
            strSQL = strSQL & " avgvalue=" & Format(Val(txt_OpeningAmount.Text), "0.00") & " , "
            strSQL = strSQL & " Adduser='" & Trim(gUsername) & "',Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm") & "'"
            strSQL = strSQL & " WHERE itemcode='" & Trim(txt_ItemCode.Text) & "'"
            ReDim Preserve Update(Update.Length)
            Update(Update.Length - 1) = strSQL
            '''*************************************                         
            sqlstring = "SELECT * FROM inventoryratehistory WHERE itemcode='" & Trim(txt_ItemCode.Text) & "'"
            gconnection.getDataSet(sqlstring, "inventoryratehistory")
            If gdataset.Tables("inventoryratehistory").Rows.Count > 0 Then
                varpurchrate = Trim(gdataset.Tables("inventoryratehistory").Rows(0).Item("purchaserate"))
                varsalerate = Trim(gdataset.Tables("inventoryratehistory").Rows(0).Item("salerate"))
            End If
            '''*************************************
            '''************************************* For InventoryRateHistory **********************************''''
            If Val(txt_PurchaseRate.Text) <> Val(varpurchrate) Or Val(txt_SaleRate.Text) <> Val(varsalerate) Then
                strSQL = "INSERT INTO inventoryratehistory (itemcode,itemname,modifydate,purchaserate,salerate,adduser,adddate)"
                strSQL = strSQL & " VALUES( '" & Trim(txt_ItemCode.Text) & "','" & Trim(txt_ItemName.Text) & "' ,"
                strSQL = strSQL & " '" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "' ,"
                strSQL = strSQL & " " & Format(Val(txt_PurchaseRate.Text), "0.00") & ","
                strSQL = strSQL & " " & Format(Val(txt_SaleRate.Text), "0.00") & ","
                strSQL = strSQL & " '" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "')"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = strSQL
            End If
            gconnection.MoreTrans(Update)
            Call clearadd()

            ' Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If

    End Sub


    Public Sub checkValidation()
        boolchk = False
        '''********** Check  Storecode Can't be blank *********************''
        If Trim(txt_Storecode.Text) = "" Then
            MessageBox.Show(" Store Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_Storecode.Focus()
            Exit Sub
        End If
        '''********** Check  Storedesc Can't be blank *********************''
        If Trim(txt_StoreDesc.Text) = "" Then
            MessageBox.Show(" Store Desc can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_Storecode.Focus()
            Exit Sub
        End If
        '''********** Check  ItemCode Can't be blank *********************'''
        If Trim(txt_ItemCode.Text) = "" Then
            MessageBox.Show(" Item Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_ItemCode.Focus()
            Exit Sub
        End If
        '''********** Check  ItemName Can't be blank *********************'''
        If Trim(txt_ItemName.Text) = "" Then
            MessageBox.Show(" Item Name can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_ItemName.Focus()
            Exit Sub
        End If
        If Trim(TXT_CATEGORY.Text) = "" Then
            MessageBox.Show(" Category can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TXT_CATEGORY.Focus()
            Exit Sub
        End If
        '''********** Check  GroupCode Can't be blank *********************''
        If Trim(txt_GroupCode.Text) = "" Then
            MessageBox.Show(" Group Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_GroupCode.Focus()
            Exit Sub
        End If
        '''********** Check  GroupDesc Can't be blank *********************'''
        If Trim(txt_GroupDesc.Text) = "" Then
            MessageBox.Show(" Group Desc can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_GroupDesc.Focus()
            Exit Sub
        End If
        '''********** Check  SubGroupCode Can't be blank *********************'''
        If Trim(txt_SubGroupCode.Text) = "" Then
            MessageBox.Show(" SubGroup Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_MinQty.Focus()
            Exit Sub
        End If
        If Val(txt_MinQty.Text) > Val(txt_MaxQty.Text) Then
            MessageBox.Show("Min Order Qty Must Be greater then Max Order qty... ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_SubGroupCode.Focus()
            Exit Sub
        End If
        '''********** Check  SubGroupDesc Can't be blank *********************'''
        If Trim(txt_SubGroupDesc.Text) = "" Then
            MessageBox.Show(" SubGroup Desc can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_SubGroupDesc.Focus()
            Exit Sub
        End If
        '''********** Check  SubSubGroupCode Can't be blank *********************'''
        ''If Trim(txt_SubSubGroupCode.Text) = "" Then
        ''    MessageBox.Show(" SubSubGroup Code can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ''    txt_SubSubGroupCode.Focus()
        ''    Exit Sub
        ''End If
        '''********** Check  SubSubGroupDesc Can't be blank *********************'''
        '''If Trim(txt_SubSubGroupDesc.Text) = "" Then
        '''    MessageBox.Show(" SubSubGroup Desc can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '''    txt_SubSubGroupDesc.Focus()
        '''    Exit Sub
        '''End If
        '''********** Check  Valuation Can't be blank *********************'''
        '''********** Check  PurchaseRate Can't be blank *********************'''
        If Val(txt_PurchaseRate.Text) = 0 Then
            MessageBox.Show(" Purchase Rate can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_PurchaseRate.Focus()
            Exit Sub
        End If
        If Txt_vat.Visible = True Then
            If Val(Txt_vat.Text) < 0 Then
                MessageBox.Show(" Vat Percentage can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Txt_vat.Focus()
                Exit Sub
            End If
        End If
        '''********** Check  SaleRate Can't be blank *********************'''
        '''********** Check  StockUOM Can't be blank *********************'''
        If Trim(cbo_StockUOM.Text) = "" Then
            MessageBox.Show(" Stock UOM can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbo_StockUOM.Focus()
            Exit Sub
        End If
        '''********** Check  ReceivingUOM Can't be blank *********************'''
        If Trim(cbo_ReceivingUOM.Text) = "" Then
            MessageBox.Show(" Receiving UOM can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbo_ReceivingUOM.Focus()
            Exit Sub
        End If
        '''********** Check  SaleUOM Can't be blank *********************'''
        If Trim(cbo_SaleUOM.Text) = "" Then
            MessageBox.Show(" Sale UOM can't be blank ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cbo_SaleUOM.Focus()
            Exit Sub
        End If

        Dim TYPE() As String
        Dim I As Integer
        Dim strsql, strsql1 As String
        strsql = ""
        strsql1 = ""
        If chklst_Uom.CheckedItems.Count > 0 Then
            strsql = "Uom not in ("
            For I = 0 To chklst_Uom.CheckedItems.Count - 1
                TYPE = Split(chklst_Uom.CheckedItems(I), "-->")
                strsql1 = strsql1 & " " & "'" & TYPE(1) & "',"
            Next
            strsql = strsql & "" & strsql1 & "' '"
            strsql = strsql & ")"
        Else
            strsql = "Uom not in ('')"
        End If

        'Dim SQLSTRING1 As String
        'sqlstring = "SELECT UOM FROM GRN_details  WHERE itemcode='" & txt_ItemCode.Text & "' and " & strsql & ""
        'gconnection.getDataSet(sqlstring, "inventoryratehistory")
        'If gdataset.Tables("inventoryratehistory").Rows.Count > 0 Then
        '    If Trim(cbo_StockUOM.Text) <> Trim(gdataset.Tables("inventoryratehistory").Rows(0).Item("UOM")) Then
        '        MsgBox("Sorry! Already Puchase Is Entered For UOM  :  " & Trim(gdataset.Tables("inventoryratehistory").Rows(0).Item("UOM")))
        '        Exit Sub
        '    End If
        'End If

        'sqlstring = "SELECT UOM  FROM StockIssueDetail WHERE itemcode='" & txt_ItemCode.Text & "' and " & strsql & ""
        'gconnection.getDataSet(sqlstring, "inventoryratehistory")
        'If gdataset.Tables("inventoryratehistory").Rows.Count > 0 Then
        '    If Trim(cbo_StockUOM.Text) <> Trim(gdataset.Tables("inventoryratehistory").Rows(0).Item("UOM")) Then
        '        MsgBox("Sorry! Already Issue Is Entered For UOM  :  " & Trim(gdataset.Tables("inventoryratehistory").Rows(0).Item("UOM")))
        '        Exit Sub
        '    End If
        'End If

        'sqlstring = "SELECT UOM FROM StockAdjustDetails  WHERE itemcode='" & txt_ItemCode.Text & "' and " & strsql & ""
        'gconnection.getDataSet(sqlstring, "inventoryratehistory")
        'If gdataset.Tables("inventoryratehistory").Rows.Count > 0 Then
        '    If Trim(cbo_StockUOM.Text) <> Trim(gdataset.Tables("inventoryratehistory").Rows(0).Item("UOM")) Then
        '        MsgBox("Sorry! Already Adjustment Is Entered For UOM  :  " & Trim(gdataset.Tables("inventoryratehistory").Rows(0).Item("UOM")))
        '        Exit Sub
        '    End If
        'End If

        'sqlstring = "SELECT UOM FROM StockTransferDetail  WHERE itemcode='" & txt_ItemCode.Text & "' and " & strsql & ""
        'gconnection.getDataSet(sqlstring, "inventoryratehistory")
        'If gdataset.Tables("inventoryratehistory").Rows.Count > 0 Then
        '    If Trim(cbo_StockUOM.Text) <> Trim(gdataset.Tables("inventoryratehistory").Rows(0).Item("UOM")) Then
        '        MsgBox("Sorry! Already TransferDetails Is Entered For UOM  :  " & Trim(gdataset.Tables("inventoryratehistory").Rows(0).Item("UOM")))
        '        Exit Sub
        '    End If
        'End If

        '''********** Check  DoubleUnit Can't be blank *********************'''
        '''************ Calculate doublevalue ********************************'''
        vardoublevalue = IIf(Format(Val(txt_Conversion.Text), "0.00") = 0, 1, Val(txt_Conversion.Text)) * IIf(Format(Val(txt_OpeningStock.Text), "0.000") = 0, 1, Val(txt_OpeningStock.Text))
        boolchk = True
    End Sub

    Private Sub Resize_Form()
        Dim cControl As Control
        Dim i_i As Integer
        Dim J, K, L, M, n, o, P, Q, R, S, T, U As Integer
        'If (Screen.PrimaryScreen.Bounds.Height = 768) And (Screen.PrimaryScreen.Bounds.Width = 1366) Then
        '    Exit Sub
        'End If
        J = 692
        K = 1014
        Me.ResizeRedraw = True

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
                ElseIf TypeOf .Controls(i_i) Is Panel Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        If Controls(i_i).Name = "Panel" Then
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
                ElseIf TypeOf .Controls(i_i) Is GroupBox Then


                    If .Controls(i_i).Location.X = 0 Then
                        L = 0
                    Else
                        If Controls(i_i).Name = "GroupBox4" Then
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


    Private Sub Item_Master_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        Show()
        Call Resize_Form()


        txt_ItemCode.Enabled = True
        txt_ItemCode.ReadOnly = False
        txt_ItemName.ReadOnly = False
        txt_OpeningAmount.ReadOnly = True
        txt_OpeningStock.ReadOnly = True
        txt_GroupCode.ReadOnly = False
        txt_SubGroupCode.ReadOnly = False
        txt_SubSubGroupCode.ReadOnly = False
        Cbo_ABC_category.SelectedIndex = 0
        CBO_TAXREBATE.SelectedIndex = 1
        txt_ReorderLevel.Text = "1"
        ItemMasterbool = True
        Call FillUomMaster()
        If gTAXcode = "N" Then
            Txt_vat.Visible = True
            Label13.Visible = True
        Else
            Txt_vat.Visible = False
            Label13.Visible = False
        End If
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Call FillUOM()
    End Sub
    Private Sub FillUomMaster()
        Dim i As Integer
        Dim sqlstring As String
        chklst_Uom.Items.Clear()
        sqlstring = "SELECT ISNULL(UOMCODE,'') AS UOMCODE,ISNULL(UOMDESC,'') AS UOMDESC FROM UOMMASTER WHERE ISNULL(FREEZE,'')<>'Y' ORDER BY UOMDESC"
        gconnection.getDataSet(sqlstring, "UOMMASTER")
        If gdataset.Tables("UOMMASTER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("UOMMASTER").Rows.Count - 1
                With gdataset.Tables("UOMMASTER").Rows(i)
                    chklst_Uom.Items.Add(Trim(CStr(.Item("UOMCODE")) & "-->" & .Item("UOMDESC")))
                End With
            Next
        End If
    End Sub
    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='INVENTORY' AND MODULENAME LIKE '%" & Trim(GmoduleName) & "%' ORDER BY RIGHTS"
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
        'Me.Cmd_View.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Me.cmd_rpt.Enabled = True
                    Me.cmd_export.Enabled = True
                    Me.cmd_auth.Enabled = True
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
                    Me.cmd_export.Enabled = True
                    Me.cmd_rpt.Enabled = True
                End If
                If Right(x) = "U" Then
                    Me.cmd_auth.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub clearadd()
        Call clearform(Me)
        Call FillUOM()
        Call FillUomMaster()
        Cmd_Freeze.Enabled = True
        Cbo_ABC_category.SelectedIndex = 1
        TXT_CATEGORY.Text = ""
        ' txt_Storecode.Text = ""
        '  txt_StoreDesc.Text = ""
        txt_ItemCode.Text = ""
        txt_ItemName.Text = ""
        ' txt_Storecode.Text = ""
        Txt_vat.Text = ""
        txt_Alias.Text = ""
        txt_PurchaseRate.Text = ""
        txt_OpeningAmount.Text = ""
        txt_OpeningStock.Text = ""
        txt_Caseqty.Text = ""

        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Clstock.Text = ""
        Me.lbl_Clvalue.Text = ""
        Me.txt_avgRate.Text = ""
        Me.TXT_BASERATE.Text = ""
        Me.Txt_profitper.Text = ""
        Me.txt_eoq.Text = ""
        Me.CBO_TAXREBATE.SelectedIndex = 1
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add [F7]"
        txt_ItemCode.Enabled = True
        txt_GroupCode.ReadOnly = False
        txt_SubGroupCode.ReadOnly = False
        txt_SubSubGroupCode.ReadOnly = False
        txt_ItemCode.ReadOnly = False
        txt_ItemName.ReadOnly = False
        Cbo_ABC_category.SelectedIndex = 0
        CBO_TAXREBATE.SelectedIndex = 1
        txt_ReorderLevel.Text = "1"
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        If gTAXcode = "N" Then
            Txt_vat.Visible = True
            Label13.Visible = True
        Else
            Txt_vat.Visible = False
            Label13.Visible = True
        End If
        'txt_ItemCode.Focus()
        txt_Storecode.Focus()
        txt_ReorderLevel.Text = ""
        txt_MaxQty.Text = ""

    End Sub


    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Call clearform(Me)
        Call FillUOM()
        Call FillUomMaster()
        Cmd_Freeze.Enabled = True
        Cbo_ABC_category.SelectedIndex = 1
        TXT_CATEGORY.Text = ""
        txt_Storecode.Text = ""
        txt_StoreDesc.Text = ""
        txt_ItemCode.Text = ""
        txt_ItemName.Text = ""
        txt_Storecode.Text = ""
        Txt_vat.Text = ""
        txt_Alias.Text = ""
        txt_PurchaseRate.Text = ""
        txt_OpeningAmount.Text = ""
        txt_OpeningStock.Text = ""
        txt_Caseqty.Text = ""

        Me.lbl_Freeze.Visible = False
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Clstock.Text = ""
        Me.lbl_Clvalue.Text = ""
        Me.txt_avgRate.Text = ""
        Me.TXT_BASERATE.Text = ""
        Me.Txt_profitper.Text = ""
        Me.txt_eoq.Text = ""
        Me.CBO_TAXREBATE.SelectedIndex = 1
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        Cmd_Add.Text = "Add [F7]"
        txt_ItemCode.Enabled = True
        txt_GroupCode.ReadOnly = False
        txt_SubGroupCode.ReadOnly = False
        txt_SubSubGroupCode.ReadOnly = False
        txt_ItemCode.ReadOnly = False
        txt_ItemName.ReadOnly = False
        Cbo_ABC_category.SelectedIndex = 0
        CBO_TAXREBATE.SelectedIndex = 1
        txt_ReorderLevel.Text = "1"
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        If gTAXcode = "N" Then
            Txt_vat.Visible = True
            Label13.Visible = True
        Else
            Txt_vat.Visible = False
            Label13.Visible = True
        End If
        'txt_ItemCode.Focus()
        txt_Storecode.Focus()
        txt_ReorderLevel.Text = ""
        txt_MaxQty.Text = ""

    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Call checkValidation() ''-->Check Validation
        If boolchk = False Then Exit Sub
        If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
            sqlstring = "UPDATE  inventoryitemmaster "
            sqlstring = sqlstring & " SET Freeze= 'Y',voiduser='" & gUsername & " ', voiddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            sqlstring = sqlstring & " WHERE itemcode = '" & Trim(txt_ItemCode.Text) & "'"
            gconnection.dataOperation(3, sqlstring, "inventoryitemmaster")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
            'Else
            '    sqlstring = "UPDATE  inventoryitemmaster "
            '    sqlstring = sqlstring & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddate='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            '    sqlstring = sqlstring & " WHERE itemcode = '" & Trim(txt_ItemCode.Text) & "'"
            '    gconnection.dataOperation(4, sqlstring, "inventoryitemmaster")
            '    Me.Cmd_Clear_Click(sender, e)
            '    Cmd_Add.Text = "Add [F7]"
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click


        Dim FRM As New ReportDesigner
        If txt_ItemCode.Text.Length > 0 Then
            tables = " FROM inventoryitemmaster WHERE itemcode ='" & txt_ItemCode.Text & "' "
        Else
            tables = "FROM inventoryitemmaster "
        End If
        Gheader = "STOREMASTER DETAILS"
        FRM.DataGridView1.ColumnCount = 2
        FRM.DataGridView1.Columns(0).Name = "COLUMN NAME"
        FRM.DataGridView1.Columns(0).Width = 300
        FRM.DataGridView1.Columns(1).Name = "SIZE"
        FRM.DataGridView1.Columns(1).Width = 100

        Dim ROW As String() = New String() {"itemcode", "10"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"itemname", "20"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"alias", "5"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"groupcode", "9"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"groupname", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"subgroupcode", "12"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"subgroupname", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"purchaserate", "12 "}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"taxper", "6 "}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"salerate", "8"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"stockuom", "8"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"saleuom", "7"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"opstock", "7"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"opvalue", "7"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"closingqty", "10"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"closingval", "11"}
        FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"itemname", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"itemname", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        'ROW = New String() {"itemname", "20"}
        'FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"Freeze", "7"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"Adduser", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"Adddate", "11"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"UPDATEUSER", "15"}
        FRM.DataGridView1.Rows.Add(ROW)
        ROW = New String() {"UPDATETIME", "11"}
        FRM.DataGridView1.Rows.Add(ROW)
        Dim CHK As New DataGridViewCheckBoxColumn()
        FRM.DataGridView1.Columns.Insert(0, CHK)
        CHK.HeaderText = "CHECK"
        CHK.Name = "CHK"
        FRM.ShowDialog(Me)


    End Sub
    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub
    Private Sub txt_ItemCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ItemCode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_ItemCode.Text) = "" Then
                Call Cmd_ItemCode_Click(sender, e)
            Else
                txt_ItemCode_Validated(sender, e)
            End If
        End If
    End Sub
    Private Sub txt_ItemName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ItemName.KeyPress
        If Asc(e.KeyChar) = 13 Then
            TXT_CATEGORY.Focus()
        End If
    End Sub
    Private Sub txt_Alias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Alias.KeyPress
        'getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_GroupCode.Focus()
        End If
    End Sub
    Private Sub txt_GroupCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_GroupCode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_GroupCode.Text) = "" Then
                Call cmd_GroupCode_Click(cmd_GroupCode, e)
            Else
                txt_GroupCode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_GroupDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_GroupDesc.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_SubGroupCode.Focus()
        End If
    End Sub

    Private Sub txt_SubGroupCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SubGroupCode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_SubGroupCode.Text) = "" Then
                Call cmd_SubGroupCode_Click(sender, e)
            Else
                txt_SubGroupCode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_SubGroupDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SubGroupDesc.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_SubSubGroupCode.Focus()
        End If
    End Sub

    Private Sub txt_SubSubGroupCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SubSubGroupCode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_SubSubGroupCode.Text) = "" Then
                Call cmd_SubSubGroupCode_Click(sender, e)
            Else
                txt_SubSubGroupCode_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub txt_SubSubGroupDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SubSubGroupDesc.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_ReorderLevel.Focus()
        End If
    End Sub

    Private Sub txt_ReorderLevel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_MinQty.Focus()
        End If
    End Sub

    Private Sub txt_MinQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MinQty.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Val(txt_eoq.Text) > 0 Then
                If (Val(txt_MinQty.Text) > 0) Then
                    txt_MaxQty.Focus()
                Else
                    txt_MinQty.Text = 1
                    txt_MaxQty.Focus()
                End If
            Else
                txt_MaxQty.Focus()
            End If

        End If
    End Sub

    Private Sub txt_MaxQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MaxQty.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_ReorderLevel.Focus()
        End If
    End Sub

    Private Sub cbo_Valuation_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txt_PurchaseRate.Focus()
        End If
    End Sub

    Private Sub txt_PurchaseRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_PurchaseRate.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            'txt_SaleRate.Focus()
            'TXT_BASERATE.Focus()
            If Txt_vat.Visible = False Then
                Txt_profitper.Focus()
            Else
                Txt_vat.Focus()
            End If
        End If
    End Sub

    Private Sub txt_SaleRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_SaleRate.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            cbo_StockUOM.Focus()
        End If
    End Sub

    Private Sub cbo_StockUOM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_StockUOM.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cbo_ReceivingUOM.Focus()
        End If
    End Sub

    Private Sub cbo_ReceivingUOM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            cbo_SaleUOM.Focus()
        End If
    End Sub

    Private Sub cbo_SaleUOM_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            txt_OpeningStock.Focus()
        End If
    End Sub

    Private Sub cbo_DoubleUnit_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_DoubleUnit.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_Conversion.Focus()
        End If
    End Sub
    Private Sub txt_Conversion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Conversion.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_OpeningStock.Focus()
        End If
    End Sub
    Private Sub txt_OpeningStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_OpeningStock.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_OpeningAmount.Focus()
        End If
    End Sub

    Private Sub txt_LeadTime_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_LeadTime.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            cbo_DoubleUnit.Focus()
        End If
    End Sub
    Private Sub txt_OpeningAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_OpeningAmount.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            Cmd_Add.Focus()
        End If
    End Sub
    Private Sub FillUOM()
        Dim i As Integer
        sqlstring = "SELECT distinct(uomcode) FROM UOMMaster WHERE ISNULL(FREEZE,'')<>'Y' order by uomcode asc"
        gconnection.getDataSet(sqlstring, "UOMMaster1")
        cbo_StockUOM.Items.Clear()
        cbo_ReceivingUOM.Items.Clear()
        cbo_SaleUOM.Items.Clear()
        cbo_DoubleUnit.Items.Clear()
        If gdataset.Tables("UOMMaster1").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("UOMMaster1").Rows.Count - 1
                cbo_StockUOM.Items.Add(gdataset.Tables("UOMMaster1").Rows(i).Item("UOMcode"))
                cbo_ReceivingUOM.Items.Add(Trim(gdataset.Tables("UOMMaster1").Rows(i).Item("UOMcode")))
                cbo_SaleUOM.Items.Add(Trim(gdataset.Tables("UOMMaster1").Rows(i).Item("UOMcode")))
                cbo_DoubleUnit.Items.Add(Trim(gdataset.Tables("UOMMaster1").Rows(i).Item("UOMcode")))
            Next i
        End If
    End Sub
    Private Sub Item_Master_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ItemMasterbool = False
    End Sub
    Private Sub Cmd_ItemCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_ItemCode.Click
        gSQLString = "SELECT DISTINCT(itemcode),itemname  FROM inventoryitemmaster"
        M_WhereCondition = " where storecode ='" & Trim(txt_Storecode.Text) & "'"
        Dim vform As New ListOperattion1_N
        vform.Field = "ITEMNAME,ITEMCODE"
        vform.vFormatstring = "          ITEM CODE              |                        ITEM DESCRIPTION                                                                                                "
        vform.vCaption = "INVENTORY ITEM MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_ItemCode.Text = Trim(vform.keyfield & "")
            Call txt_ItemCode_Validated(txt_ItemCode, e)
        End If
        vform.Close()
        vform = Nothing
    End Sub

    Private Sub cmd_GroupCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_GroupCode.Click
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

    Private Sub cmd_SubGroupCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_SubGroupCode.Click
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
    Private Sub cmd_SubSubGroupCode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_SubSubGroupCode.Click
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

    Private Sub txt_ItemCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_ItemCode.Validated
        Try
            Dim itemflag As Boolean
            Dim Itemcode As String
            Dim GRNDATE As Date
            Dim I, J As Integer
            If Trim(txt_ItemCode.Text) <> "" Then
                sqlstring = "SELECT * FROM inventoryitemmaster WHERE itemcode='" & Trim(txt_ItemCode.Text) & "' and storecode = '" & Trim(txt_Storecode.Text) & "'"
                gconnection.getDataSet(sqlstring, "inventoryitem1")
                If gdataset.Tables("inventoryitem1").Rows.Count <= 0 Then
                    sqlstring = "SELECT * FROM inventoryitemmaster WHERE itemcode='" & Trim(txt_ItemCode.Text) & "' and storecode = '" & Trim(txt_Storecode.Text) & "'"
                    gconnection.getDataSet(sqlstring, "inventoryitem2")
                    If gdataset.Tables("inventoryitem2").Rows.Count > 0 Then
                        itemflag = False
                    End If
                Else
                    itemflag = True
                End If

                If itemflag = True Then
                    sqlstring = "SELECT * FROM inventoryitemmaster WHERE itemcode='" & Trim(txt_ItemCode.Text) & "' and storecode = '" & Trim(txt_Storecode.Text) & "'"
                Else
                    sqlstring = "SELECT * FROM inventoryitemmaster WHERE itemcode='" & Trim(txt_ItemCode.Text) & "'  and storecode = '" & Trim(txt_Storecode.Text) & "'"

                End If

                'sqlstring = "SELECT * FROM inventoryitemmaster WHERE itemcode='" & Trim(txt_ItemCode.Text) & "'"
                gconnection.getDataSet(sqlstring, "inventoryitemmaster")
                If gdataset.Tables("inventoryitemmaster").Rows.Count > 0 Then
                    txt_Storecode.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("storecode"))
                    sqlstring = " SELECT STOREDESC FROM STOREMASTER WHERE STORECODE = '" & Trim(txt_Storecode.Text) & "'"
                    gconnection.getDataSet(sqlstring, "STOREMASTER")
                    If gdataset.Tables("STOREMASTER").Rows.Count > 0 Then
                        txt_StoreDesc.Text = Trim(gdataset.Tables("STOREmaster").Rows(0).Item("storeDESC"))
                    End If
                    txt_ItemCode.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("itemcode"))
                    txt_ItemName.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("itemname"))
                    txt_Alias.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("alias") & "")
                    txt_GroupCode.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("groupcode") & "")
                    txt_GroupDesc.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("groupname") & "")
                    txt_SubGroupCode.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("subgroupcode") & "")
                    txt_SubGroupDesc.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("subgroupname") & "")
                    txt_SubSubGroupCode.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("subsubgroupcode") & "")
                    txt_SubSubGroupDesc.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("subsubgroupname") & "")
                    txt_ReorderLevel.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("reorderlevel") & ""), "0.00")
                    txt_MinQty.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("minqty") & ""), "0.00")
                    txt_MaxQty.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("maxqty") & ""), "0.00")
                    txt_eoq.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("eoq") & ""), "0.00")
                    cbo_Valuation.DropDownStyle = ComboBoxStyle.DropDown
                    Cbo_ABC_category.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("ABC") & "")
                    CBO_TAXREBATE.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("taxrebate") & "")
                    cbo_Valuation.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("valuation") & "")
                    cbo_Valuation.DropDownStyle = ComboBoxStyle.DropDownList
                    txt_PurchaseRate.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("purchaserate") & ""), "0.00")
                    If Txt_vat.Visible = True Then
                        Txt_vat.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("taxper") & ""), "0.00")
                    End If
                    TXT_BASERATE.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("BASERATE") & ""), "0.00")
                    Txt_profitper.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("Profitper") & ""), "0.00")
                    txt_SaleRate.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("salerate") & ""), "0.00")
                    cbo_StockUOM.DropDownStyle = ComboBoxStyle.DropDown
                    cbo_StockUOM.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("stockuom") & "")
                    cbo_StockUOM.DropDownStyle = ComboBoxStyle.DropDownList
                    cbo_ReceivingUOM.DropDownStyle = ComboBoxStyle.DropDown
                    cbo_ReceivingUOM.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("receiveuom") & "")
                    cbo_ReceivingUOM.DropDownStyle = ComboBoxStyle.DropDownList
                    cbo_SaleUOM.DropDownStyle = ComboBoxStyle.DropDown
                    cbo_SaleUOM.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("saleuom") & "")
                    cbo_SaleUOM.DropDownStyle = ComboBoxStyle.DropDownList
                    cbo_DoubleUnit.DropDownStyle = ComboBoxStyle.DropDown
                    cbo_DoubleUnit.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("doubleuom") & "")
                    cbo_DoubleUnit.DropDownStyle = ComboBoxStyle.DropDownList
                    txt_Conversion.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("convvalue") & ""), "0.00")
                    txt_Caseqty.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("CASEQTY") & ""), "0.00")
                    If itemflag = True Then
                        txt_OpeningStock.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("opstock") & ""), "0.000")
                        txt_OpeningAmount.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("opvalue") & ""), "0.00")
                    Else
                        txt_OpeningStock.Text = 0
                        txt_OpeningAmount.Text = 0
                    End If
                    If Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("clstock") & ""), "0.000") <> "0.000" Then
                        ''lbl_Clstock.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("clstock") & ""), "0.000")
                        ''lbl_Clvalue.Text = Format(Val(gdataset.Tables("inventoryitemmaster").Rows(0).Item("clvalue") & ""), "0.00")
                        GRNDATE = Format(CDate(Date.Now), "dd-MMM-yyyy")
                        lbl_Clstock.Text = ClosingQuantity_Date(Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("itemcode")), Trim(txt_Storecode.Text), Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("stockuom")), GRNDATE)
                        lbl_Clvalue.Text = Format(Val(DateClsValue), "0.00")
                    End If
                    txt_avgRate.Text = Format(CalAverageRate_new(txt_ItemCode.Text, Format(Now.Date, "dd/MM/yyyy"), txt_Storecode.Text, Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("stockuom") & "")), "0.00")
                    txt_LeadTime.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("leadtime") & "")
                    TXT_CATEGORY.Text = Trim(gdataset.Tables("inventoryitemmaster").Rows(0).Item("CATEGORY") & "")
                    txt_ItemName.Focus()
                    txt_ItemCode.ReadOnly = True
                    txt_OpeningAmount.ReadOnly = True
                    txt_OpeningStock.ReadOnly = True
                    If gdataset.Tables("inventoryitemmaster").Rows(0).Item("Freeze") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = "Record Freezed  On : " & Format(CDate(gdataset.Tables("inventoryitemmaster").Rows(0).Item("AddDate")), "dd-MMM-yyyy")
                        ' Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                        Cmd_Freeze.Enabled = False
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.lbl_Freeze.Text = ""
                        Me.Cmd_Freeze.Text = "Freeze[F8]"
                    End If
                    Me.Cmd_Add.Text = "Update[F7]"
                    sqlstring = "SELECT ISNULL(Tranuom,'') AS Tranuom FROM INVITEM_TRANSUOM_LINK WHERE Itemcode ='" & Trim(txt_ItemCode.Text) & "'"
                    gconnection.getDataSet(sqlstring, "UOMMASTER")
                    Dim TYPE() As String
                    If gdataset.Tables("UOMMASTER").Rows.Count > 0 Then
                        For I = 0 To gdataset.Tables("UOMMASTER").Rows.Count - 1
                            Itemcode = Trim(gdataset.Tables("UOMMASTER").Rows(I).Item("Tranuom"))
                            For J = 0 To chklst_Uom.Items.Count - 1
                                TYPE = Split(chklst_Uom.Items(J), "-->")
                                If TYPE(0) = Itemcode Then
                                    chklst_Uom.SetItemChecked(J, True)
                                End If
                            Next J
                        Next I
                    End If
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Add.Text = "Add [F7]"
                    txt_ItemCode.ReadOnly = False
                    txt_ItemName.Focus()
                End If
                If gUserCategory <> "S" Then
                    Call GetRights()
                End If
            Else
                txt_ItemCode.Text = ""
                txt_ItemName.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub
    Private Sub txt_GroupCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_GroupCode.Validated
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

    Private Sub txt_SubGroupCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubGroupCode.Validated
        If Trim(txt_SubGroupCode.Text) <> "" Then
            sqlstring = "SELECT * FROM inventorysubgroupmaster WHERE Groupcode='" & Trim(txt_GroupCode.Text) & "' AND SUBGROUPCODE = '" & Trim(txt_SubGroupCode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "inventorysubgroupmaster")
            If gdataset.Tables("inventorysubgroupmaster").Rows.Count > 0 Then
                txt_SubGroupCode.Text = Trim(gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("Subgroupcode"))
                txt_SubGroupDesc.Text = Trim(gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("Subgroupdesc"))
                Cbo_ABC_category.Focus()
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

    Private Sub txt_ItemCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ItemCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If Cmd_ItemCode.Enabled = True Then
                search = Trim(txt_Storecode.Text)
                Call Cmd_Storecode_Click(Cmd_Storecode, e)
            End If
        End If
    End Sub

    Private Sub txt_GroupCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_GroupCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmd_GroupCode.Enabled = True Then
                search = Trim(txt_GroupCode.Text)
                Call cmd_GroupCode_Click(cmd_GroupCode, e)
            End If
        End If
    End Sub

    Private Sub txt_SubGroupCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_SubGroupCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmd_SubGroupCode.Enabled = True Then
                search = Trim(txt_SubGroupCode.Text)
                Call cmd_SubGroupCode_Click(cmd_SubGroupCode, e)
            End If
        End If
    End Sub

    Private Sub txt_SubSubGroupCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_SubSubGroupCode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If cmd_SubSubGroupCode.Enabled = True Then
                search = Trim(txt_SubSubGroupCode.Text)
                Call cmd_SubSubGroupCode_Click(cmd_SubSubGroupCode, e)
            End If
        End If
    End Sub

    Private Sub txt_SubSubGroupCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubSubGroupCode.Validated
        If Trim(txt_SubGroupCode.Text) <> "" Then
            sqlstring = "SELECT * FROM inventorysubgroupmaster WHERE Groupcode='" & Trim(txt_GroupCode.Text) & "' AND SUBGROUPCODE = '" & Trim(txt_SubSubGroupCode.Text) & "' AND ISNULL(FREEZE,'')<>'Y'"
            gconnection.getDataSet(sqlstring, "inventorysubgroupmaster")
            If gdataset.Tables("inventorysubgroupmaster").Rows.Count > 0 Then
                txt_SubSubGroupCode.Text = Trim(gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("Subgroupcode"))
                txt_SubSubGroupDesc.Text = Trim(gdataset.Tables("inventorysubgroupmaster").Rows(0).Item("Subgroupdesc"))
                Cbo_ABC_category.Focus()
                txt_SubSubGroupDesc.ReadOnly = True
            Else
                txt_SubSubGroupCode.Text = ""
                txt_SubSubGroupDesc.ReadOnly = False
                txt_SubSubGroupCode.Focus()
            End If
        Else
            txt_SubSubGroupCode.Text = ""
            Cbo_ABC_category.Focus()
        End If
    End Sub

    Private Sub Item_Master_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(Cmd_Clear, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F8 And Cmd_Freeze.Enabled = True Then
            Call Cmd_Freeze_Click(Cmd_Freeze, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F4 Then
            Call Cmd_ItemCode_Click(Cmd_ItemCode, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F7 And Cmd_Add.Enabled = True Then
            Call Cmd_Add_Click(Cmd_Add, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F9 And Cmd_View.Enabled = True Then
            Call Cmd_View_Click(Cmd_View, e)
            Exit Sub
        End If
        If e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(Cmd_Exit, e)
            Exit Sub
        End If
    End Sub
    Private Sub txt_PurchaseRate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_PurchaseRate.LostFocus
        txt_PurchaseRate.Text = Format(Val(txt_PurchaseRate.Text), "0.00")
    End Sub
    Private Sub txt_SaleRate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SaleRate.LostFocus
        txt_SaleRate.Text = Format(Val(txt_SaleRate.Text), "0.00")
    End Sub
    Private Sub txt_Conversion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Conversion.LostFocus
        txt_Conversion.Text = Format(Val(txt_Conversion.Text), "0.00")
    End Sub
    Private Sub txt_ReorderLevel_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_ReorderLevel.Text = Format(Val(txt_ReorderLevel.Text), "0.00")
    End Sub
    Private Sub txt_MaxQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MaxQty.LostFocus
        txt_MaxQty.Text = Format(Val(txt_MaxQty.Text), "0.00")
    End Sub
    Private Sub txt_MinQty_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MinQty.LostFocus
        txt_MinQty.Text = Format(Val(txt_MinQty.Text), "0.00")
    End Sub
    Private Sub txt_OpeningStock_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_OpeningStock.LostFocus
        txt_OpeningStock.Text = Format(Val(txt_OpeningStock.Text), "0.000")
    End Sub
    Private Sub txt_OpeningAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_OpeningAmount.LostFocus
        txt_OpeningAmount.Text = Format(Val(txt_OpeningAmount.Text), "0.00")
    End Sub
    Private Sub txt_OpeningStock_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_OpeningStock.TextChanged
        If Val(txt_PurchaseRate.Text) <> 0 Then
            txt_OpeningAmount.Text = Format(Val(txt_PurchaseRate.Text) * Val(txt_OpeningStock.Text), "0.000")
        End If
    End Sub
    Private Sub TXT_CATEGORY_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_CATEGORY.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If TXT_CATEGORY.Text <> "" Then
                txt_Alias.Focus()
            Else
                BttnCategory_Help_Click(BttnCategory_Help, e)
            End If

        End If
    End Sub

    Private Sub Cmd_Storecode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Storecode.Click
        gSQLString = "SELECT DISTINCT(storecode),storedesc FROM storemaster "
        M_WhereCondition = " where freeze <> 'Y' "
        Dim vform As New ListOperattion1_N
        vform.Field = "STOREDESC,STORECODE"
        vform.vFormatstring = "         STORE CODE              |                  STORE DESCRIPTION                                                                                                   "
        vform.vCaption = "INVENTORY STORE MASTER HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_Storecode.Text = Trim(vform.keyfield & "")
            txt_StoreDesc.Text = Trim(vform.keyfield1 & "")
            txt_ItemCode.Focus()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub txt_Storecode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Storecode.Validated
        Try
            If Trim(txt_Storecode.Text) <> "" Then
                sqlstring = "SELECT * FROM storemaster WHERE storecode='" & Trim(txt_Storecode.Text) & "'"
                gconnection.getDataSet(sqlstring, "storemaster")
                If gdataset.Tables("storemaster").Rows.Count > 0 Then
                    txt_Storecode.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storecode"))
                    txt_StoreDesc.Text = Trim(gdataset.Tables("storemaster").Rows(0).Item("storedesc"))
                    txt_ItemCode.Focus()
                End If
            End If
        Catch
            MessageBox.Show("Check The Error", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub txt_Storecode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Storecode.KeyDown
        If e.KeyCode = Keys.F4 Then
            If Cmd_Storecode.Enabled = True Then
                search = Trim(txt_GroupCode.Text)
                Call Cmd_Storecode_Click(Cmd_Storecode, e)
            End If
        End If
    End Sub

    Private Sub txt_Storecode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Storecode.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_Storecode.Text) = "" Then
                Call Cmd_Storecode_Click(sender, e)
            Else
                Call txt_Storecode_Validated(txt_Storecode.Text, e)
            End If
        End If
    End Sub
    Private Sub cbo_StockUOM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_StockUOM.SelectedIndexChanged
        cbo_ReceivingUOM.Text = cbo_StockUOM.Text
        cbo_SaleUOM.Text = cbo_StockUOM.Text
        cbo_DoubleUnit.Text = cbo_StockUOM.Text
    End Sub

    'Private Sub cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_auth.Click
    '    Dim rViewer As New Viewer
    '    Dim sqlstring, SSQL As String
    '    Dim r As New Rpt_ItemMaster

    '    If Trim(txt_Storecode.Text) = "" Then
    '        MessageBox.Show(" Please Provide The Store Code ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        txt_Storecode.Focus()
    '        Exit Sub
    '    End If

    '    sqlstring = "SELECT * FROM inventoryitemmaster WHERE storecode = '" & Trim(txt_Storecode.Text) & "' order by  itemname"
    '    gconnection.getDataSet(sqlstring, "inventoryitem1")
    '    If gdataset.Tables("inventoryitem1").Rows.Count > 0 Then
    '        rViewer.ssql = sqlstring
    '        rViewer.Report = r
    '        rViewer.TableName = "inventoryitemmaster"
    '        Dim textobj1 As TextObject
    '        textobj1 = r.ReportDefinition.ReportObjects("Text13")
    '        textobj1.Text = MyCompanyName
    '        Dim textobj2 As TextObject
    '        textobj2 = r.ReportDefinition.ReportObjects("Text21")
    '        textobj2.Text = gUsername
    '        rViewer.Show()
    '    Else
    '        MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
    '    End If

    'End Sub

    Private Sub Cbo_ABC_category_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cbo_ABC_category.KeyDown
        CBO_TAXREBATE.Focus()
    End Sub

    Private Sub Cbo_ABC_category_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Cbo_ABC_category.SelectedIndexChanged
        CBO_TAXREBATE.Focus()
    End Sub

    Private Sub CBO_TAXREBATE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBO_TAXREBATE.KeyDown
        txt_eoq.Focus()
    End Sub
    Private Sub TXT_BASERATE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXT_BASERATE.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            Txt_profitper.Focus()
            'txt_SaleRate.Focus()
        End If
    End Sub

    Private Sub txt_eoq_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_PurchaseRate.Focus()
        End If
    End Sub

    Private Sub txt_eoq_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txt_eoq.Text = Format(Val(txt_eoq.Text), "0.00")
    End Sub

    Private Sub TXT_BASERATE_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TXT_BASERATE.LostFocus
        TXT_BASERATE.Text = Format(Val(TXT_BASERATE.Text), "0.00")
    End Sub

    Private Sub txt_GroupCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_GroupCode.GotFocus
        Label10.Visible = True
    End Sub

    Private Sub txt_GroupCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_GroupCode.LostFocus
        Label10.Visible = False
    End Sub

    Private Sub txt_Storecode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Storecode.GotFocus
        Label16.Visible = True
    End Sub

    Private Sub txt_Storecode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Storecode.LostFocus
        Label16.Visible = False
    End Sub

    Private Sub txt_SubGroupCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubGroupCode.GotFocus
        Label9.Visible = True
    End Sub

    Private Sub txt_SubGroupCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubGroupCode.LostFocus
        Label9.Visible = False
    End Sub

    Private Sub txt_SubSubGroupCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubSubGroupCode.GotFocus
        Label8.Visible = True
    End Sub

    Private Sub txt_SubSubGroupCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SubSubGroupCode.LostFocus
        Label8.Visible = False
    End Sub

    Private Sub txt_ItemCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ItemCode.TextChanged

    End Sub

    Private Sub txt_Storecode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_Storecode.TextChanged

    End Sub


    Private Sub BttnCategory_Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttnCategory_Help.Click
        gSQLString = "SELECT DISTINCT CATEGORY FROM INVENTORYITEMMASTER"
        M_WhereCondition = " "
        Dim vform As New ListOperattion1_N
        vform.Field = "CATEGORY"
        vform.vFormatstring = "CATEGORY                                                      "
        vform.vCaption = "INVENTORY CATEGORY MASTER HELP"
        vform.KeyPos = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TXT_CATEGORY.Text = Trim(vform.keyfield & "")
        End If
        vform.Close()
        vform = Nothing
        txt_Alias.Focus()
    End Sub

    Private Sub TXT_CATEGORY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_CATEGORY.TextChanged

    End Sub

    Private Sub txt_eoq_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_eoq.TextChanged
        If Val(txt_eoq.Text) > 0 Then
            txt_MinQty.Text = 1
        Else
            txt_MinQty.Text = 0
        End If
    End Sub

    Private Sub txt_eoq_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_eoq.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            txt_MinQty.Focus()
        End If
    End Sub



    Private Sub txt_ReorderLevel_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_ReorderLevel.TextChanged

    End Sub

    Private Sub txt_ReorderLevel_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ReorderLevel.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_PurchaseRate.Focus()
        End If
    End Sub

    Private Sub txt_MinQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MinQty.TextChanged

    End Sub

    Private Sub chklst_Uom_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklst_Uom.SelectedIndexChanged

    End Sub

    Private Sub cmd_export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_export.Click
        Dim sqlstring As String
        Dim _export As New EXPORT
        _export.TABLENAME = "inventoryitemmaster"
        sqlstring = "select * from inventoryitemmaster"
        Call _export.export_excel(sqlstring)
        _export.Show()
        Exit Sub
    End Sub

    Private Sub TXT_BASERATE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_BASERATE.TextChanged

    End Sub

    Private Sub Txt_profitper_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_profitper.TextChanged

    End Sub

    Private Sub Txt_profitper_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_profitper.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            cbo_StockUOM.Focus()
        End If
    End Sub

    Private Sub btn_validation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        System.Diagnostics.Process.Start(AppPath & "/STUDY/ITEMMASTER.XLS")
    End Sub

    Private Sub cbo_DoubleUnit_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbo_DoubleUnit.SelectedIndexChanged

    End Sub

    Private Sub txt_PurchaseRate_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txt_PurchaseRate.TextChanged

    End Sub

    Private Sub lbl_storecode_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lbl_storecode.Click

    End Sub

    Private Sub cmd_rpt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_rpt.Click
        Dim rViewer As New Viewer
        Dim sqlstring, SSQL As String
        Dim r As New Rpt_ItemMaster

        '''If Trim(txt_Storecode.Text) = "" Then
        '''    MessageBox.Show(" Please Provide The Store Code ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '''    txt_Storecode.Focus()
        '''    Exit Sub
        '''End If
        If txt_Storecode.Text <> "" Then
            sqlstring = "SELECT * FROM inventoryitemmaster WHERE storecode = '" & Trim(txt_Storecode.Text) & "' order by  itemname"
        Else
            sqlstring = "SELECT * FROM inventoryitemmaster order by  itemname "
        End If
        gconnection.getDataSet(sqlstring, "inventoryitem1")
        If gdataset.Tables("inventoryitem1").Rows.Count > 0 Then
            If chk_excel.Checked = True Then
                Dim exp As New exportexcel
                exp.Show()
                Call exp.export(sqlstring, "ITEM MASTER ", "")
            Else
                rViewer.ssql = sqlstring
                rViewer.Report = r
                rViewer.TableName = "inventoryitemmaster"
                Dim textobj1 As TextObject
                textobj1 = r.ReportDefinition.ReportObjects("Text13")
                textobj1.Text = MyCompanyName
                Dim textobj2 As TextObject
                textobj2 = r.ReportDefinition.ReportObjects("Text21")
                textobj2.Text = gUsername
                rViewer.Show()
            End If
        Else
            MessageBox.Show(" No Records To Display ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation.Information.Information)
        End If
    End Sub

    Private Sub cmd_auth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_auth.Click
        Dim SSQLSTR, SSQLSTR2 As String
        Dim USERT As Integer
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 1
        End If
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 2
        End If
        gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
        gconnection.getDataSet(gSQLString, "AUTHORIZELUSER")
        If gdataset.Tables("AUTHORIZELUSER").Rows.Count > 0 Then
            USERT = 3
        End If
        If USERT = 1 Then
            SSQLSTR2 = " SELECT * FROM inventoryitemmaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH1USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH1USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE")
                If gdataset.Tables("AUTHORIZE").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND ISNULL(AUTHORIZELEVEL,0)>0 "
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM inventoryitemmaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER1,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE inventoryitemmaster set  ", "itemcode", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 1, 1)
                        End If
                    Else
                        MsgBox("NO AUTHORIZATION REQUIRED FOR THE ENTRY")
                    End If
                End If
            End If
        ElseIf USERT = 2 Then
            SSQLSTR2 = " SELECT * FROM inventoryitemmaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')='' AND ISNULL(AUTHORISE_USER1,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH2USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH2USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE1")
                If gdataset.Tables("AUTHORIZE1").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM inventoryitemmaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER2,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()


                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE inventoryitemmaster set  ", "itemcode", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 2, 1)
                        End If
                    End If
                End If
            End If
        ElseIf USERT = 3 Then
            SSQLSTR2 = " SELECT * FROM inventoryitemmaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''AND ISNULL(AUTHORISE_USER1,'')<>''  AND ISNULL(AUTHORISE_USER2,'')<>''"
            gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
            If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                gSQLString = "  SELECT * FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' AND '" & gUsername & "' IN(SELECT AUTH3USER1 FROM AUTHORIZE  WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "' UNION ALL SELECT AUTH3USER2 FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "')"
                gconnection.getDataSet(gSQLString, "AUTHORIZE2")
                If gdataset.Tables("AUTHORIZE2").Rows.Count > 0 Then
                    SSQLSTR = "SELECT ISNULL(AUTHORIZELEVEL,0) AS AUTHORIZELEVEL FROM AUTHORIZE WHERE MODULENAME='MEMBER APPLICATION' AND FORMNAME='" & GmoduleName & "'"
                    gconnection.getDataSet(gSQLString, "AUTHORIZELEVEL")
                    If gdataset.Tables("AUTHORIZELEVEL").Rows.Count > 0 Then
                        SSQLSTR2 = " SELECT * FROM inventoryitemmaster WHERE ISNULL(AUTHORISED,'')<>'Y' AND ISNULL(AUTHORISE_USER3,'')=''"
                        gconnection.getDataSet(SSQLSTR2, "AUTHORIZEL")
                        If gdataset.Tables("AUTHORIZEL").Rows.Count > 0 Then
                            Dim VIEW1 As New AUTHORISATION
                            VIEW1.Show()
                            VIEW1.DTAUTH.DataSource = Nothing
                            VIEW1.DTAUTH.Rows.Clear()
                            Call VIEW1.LOADGRID(gdataset.Tables("AUTHORIZEL"), False, Me, "UPDATE inventoryitemmaster set  ", "itemcode", gdataset.Tables("AUTHORIZELEVEL").Rows(0).Item("AUTHORIZELEVEL"), 3, 1)
                        End If
                    End If
                End If
            Else
                MsgBox("U R NOT ELIGIBLE TO AUTHORISE IN ANY LEVEL", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Txt_vat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_vat.KeyPress
        getNumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Val(Txt_vat.Text) < 0 Then
                MessageBox.Show("can not less then zero")
            Else
                'txt_SaleRate.Focus()
                'TXT_BASERATE.Focus()
                Txt_profitper.Focus()
            End If
        End If
    End Sub
End Class