Public Class Form2
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    Friend WithEvents Txt_POTerms As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Txt_TotalTax As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Balance As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txt_TotalVat As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_POValue As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txt_Insurance As System.Windows.Forms.TextBox
    Friend WithEvents Txt_LST As System.Windows.Forms.TextBox
    Friend WithEvents Txt_MODVat As System.Windows.Forms.TextBox
    Friend WithEvents Txt_PTax As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Octra As System.Windows.Forms.TextBox
    Friend WithEvents Txt_ED As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Txt_CST As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Cmd_POTermsHelp As System.Windows.Forms.Button
    Friend WithEvents Txt_AdvanceAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form2))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.Txt_POTerms = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Txt_TotalTax = New System.Windows.Forms.TextBox
        Me.Txt_Balance = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txt_TotalVat = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txt_POValue = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Txt_Insurance = New System.Windows.Forms.TextBox
        Me.Txt_LST = New System.Windows.Forms.TextBox
        Me.Txt_MODVat = New System.Windows.Forms.TextBox
        Me.Txt_PTax = New System.Windows.Forms.TextBox
        Me.Txt_Octra = New System.Windows.Forms.TextBox
        Me.Txt_ED = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Txt_CST = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Cmd_POTermsHelp = New System.Windows.Forms.Button
        Me.Txt_AdvanceAmt = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lbl_Freeze)
        Me.GroupBox3.Controls.Add(Me.Txt_POTerms)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Txt_TotalTax)
        Me.GroupBox3.Controls.Add(Me.Txt_Balance)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Txt_TotalVat)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Txt_POValue)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Txt_Insurance)
        Me.GroupBox3.Controls.Add(Me.Txt_LST)
        Me.GroupBox3.Controls.Add(Me.Txt_MODVat)
        Me.GroupBox3.Controls.Add(Me.Txt_PTax)
        Me.GroupBox3.Controls.Add(Me.Txt_Octra)
        Me.GroupBox3.Controls.Add(Me.Txt_ED)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Txt_CST)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Cmd_POTermsHelp)
        Me.GroupBox3.Controls.Add(Me.Txt_AdvanceAmt)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(-32, 61)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(912, 144)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(584, 112)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 572
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'Txt_POTerms
        '
        Me.Txt_POTerms.BackColor = System.Drawing.Color.Wheat
        Me.Txt_POTerms.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_POTerms.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_POTerms.Location = New System.Drawing.Point(136, 80)
        Me.Txt_POTerms.MaxLength = 8
        Me.Txt_POTerms.Name = "Txt_POTerms"
        Me.Txt_POTerms.Size = New System.Drawing.Size(128, 22)
        Me.Txt_POTerms.TabIndex = 17
        Me.Txt_POTerms.Text = ""
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(200, 40)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(24, 23)
        Me.Label36.TabIndex = 575
        Me.Label36.Text = "%"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(408, 48)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(24, 23)
        Me.Label35.TabIndex = 574
        Me.Label35.Text = "%"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(656, 48)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(24, 23)
        Me.Label34.TabIndex = 573
        Me.Label34.Text = "%"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(880, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(24, 23)
        Me.Label33.TabIndex = 572
        Me.Label33.Text = "%"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(656, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(24, 23)
        Me.Label32.TabIndex = 571
        Me.Label32.Text = "%"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(408, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(24, 23)
        Me.Label31.TabIndex = 570
        Me.Label31.Text = "%"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(200, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(24, 23)
        Me.Label30.TabIndex = 569
        Me.Label30.Text = "%"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_TotalTax
        '
        Me.Txt_TotalTax.BackColor = System.Drawing.Color.Wheat
        Me.Txt_TotalTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_TotalTax.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TotalTax.Location = New System.Drawing.Point(720, 81)
        Me.Txt_TotalTax.MaxLength = 6
        Me.Txt_TotalTax.Name = "Txt_TotalTax"
        Me.Txt_TotalTax.Size = New System.Drawing.Size(128, 22)
        Me.Txt_TotalTax.TabIndex = 1955
        Me.Txt_TotalTax.TabStop = False
        Me.Txt_TotalTax.Text = ""
        Me.Txt_TotalTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_Balance
        '
        Me.Txt_Balance.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Balance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Balance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Balance.Location = New System.Drawing.Point(432, 111)
        Me.Txt_Balance.MaxLength = 8
        Me.Txt_Balance.Name = "Txt_Balance"
        Me.Txt_Balance.Size = New System.Drawing.Size(136, 22)
        Me.Txt_Balance.TabIndex = 46
        Me.Txt_Balance.TabStop = False
        Me.Txt_Balance.Text = ""
        Me.Txt_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(320, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "BALANCE :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(320, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 23)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "TOTAL VAT:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_TotalVat
        '
        Me.Txt_TotalVat.BackColor = System.Drawing.Color.Wheat
        Me.Txt_TotalVat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_TotalVat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TotalVat.Location = New System.Drawing.Point(432, 80)
        Me.Txt_TotalVat.MaxLength = 8
        Me.Txt_TotalVat.Name = "Txt_TotalVat"
        Me.Txt_TotalVat.Size = New System.Drawing.Size(136, 22)
        Me.Txt_TotalVat.TabIndex = 5555
        Me.Txt_TotalVat.TabStop = False
        Me.Txt_TotalVat.Text = ""
        Me.Txt_TotalVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(600, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 23)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "TOTAL TAX :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_POValue
        '
        Me.Txt_POValue.BackColor = System.Drawing.Color.Wheat
        Me.Txt_POValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_POValue.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_POValue.Location = New System.Drawing.Point(824, 48)
        Me.Txt_POValue.MaxLength = 8
        Me.Txt_POValue.Name = "Txt_POValue"
        Me.Txt_POValue.Size = New System.Drawing.Size(48, 22)
        Me.Txt_POValue.TabIndex = 16
        Me.Txt_POValue.TabStop = False
        Me.Txt_POValue.Text = ""
        Me.Txt_POValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(712, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "P.O. VALUE :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_Insurance
        '
        Me.Txt_Insurance.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Insurance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Insurance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Insurance.Location = New System.Drawing.Point(352, 48)
        Me.Txt_Insurance.MaxLength = 4
        Me.Txt_Insurance.Name = "Txt_Insurance"
        Me.Txt_Insurance.Size = New System.Drawing.Size(48, 22)
        Me.Txt_Insurance.TabIndex = 14
        Me.Txt_Insurance.Text = ""
        Me.Txt_Insurance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_LST
        '
        Me.Txt_LST.BackColor = System.Drawing.Color.Wheat
        Me.Txt_LST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_LST.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_LST.Location = New System.Drawing.Point(600, 48)
        Me.Txt_LST.MaxLength = 4
        Me.Txt_LST.Name = "Txt_LST"
        Me.Txt_LST.Size = New System.Drawing.Size(48, 22)
        Me.Txt_LST.TabIndex = 15
        Me.Txt_LST.Text = ""
        Me.Txt_LST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_MODVat
        '
        Me.Txt_MODVat.BackColor = System.Drawing.Color.Wheat
        Me.Txt_MODVat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_MODVat.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MODVat.Location = New System.Drawing.Point(600, 16)
        Me.Txt_MODVat.MaxLength = 4
        Me.Txt_MODVat.Name = "Txt_MODVat"
        Me.Txt_MODVat.Size = New System.Drawing.Size(48, 22)
        Me.Txt_MODVat.TabIndex = 11
        Me.Txt_MODVat.Text = ""
        Me.Txt_MODVat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_PTax
        '
        Me.Txt_PTax.BackColor = System.Drawing.Color.Wheat
        Me.Txt_PTax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_PTax.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PTax.Location = New System.Drawing.Point(824, 16)
        Me.Txt_PTax.MaxLength = 4
        Me.Txt_PTax.Name = "Txt_PTax"
        Me.Txt_PTax.Size = New System.Drawing.Size(48, 22)
        Me.Txt_PTax.TabIndex = 12
        Me.Txt_PTax.Text = ""
        Me.Txt_PTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_Octra
        '
        Me.Txt_Octra.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Octra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Octra.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Octra.Location = New System.Drawing.Point(144, 48)
        Me.Txt_Octra.MaxLength = 4
        Me.Txt_Octra.Name = "Txt_Octra"
        Me.Txt_Octra.Size = New System.Drawing.Size(48, 22)
        Me.Txt_Octra.TabIndex = 13
        Me.Txt_Octra.Text = ""
        Me.Txt_Octra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txt_ED
        '
        Me.Txt_ED.BackColor = System.Drawing.Color.Wheat
        Me.Txt_ED.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_ED.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ED.Location = New System.Drawing.Point(144, 16)
        Me.Txt_ED.MaxLength = 4
        Me.Txt_ED.Name = "Txt_ED"
        Me.Txt_ED.Size = New System.Drawing.Size(48, 22)
        Me.Txt_ED.TabIndex = 9
        Me.Txt_ED.Text = ""
        Me.Txt_ED.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(496, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 18)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "MOD VAT  :"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(712, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 23)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "P. TAX :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(16, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 18)
        Me.Label18.TabIndex = 27
        Me.Label18.Text = "OCTROI  :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(240, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 18)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "CST    :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_CST
        '
        Me.Txt_CST.BackColor = System.Drawing.Color.Wheat
        Me.Txt_CST.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_CST.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CST.Location = New System.Drawing.Point(352, 16)
        Me.Txt_CST.MaxLength = 4
        Me.Txt_CST.Name = "Txt_CST"
        Me.Txt_CST.Size = New System.Drawing.Size(48, 22)
        Me.Txt_CST.TabIndex = 10
        Me.Txt_CST.Text = ""
        Me.Txt_CST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(502, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 23)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "LST  :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(240, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 23)
        Me.Label21.TabIndex = 20
        Me.Label21.Text = "INSURANCE  :"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(16, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 23)
        Me.Label23.TabIndex = 12
        Me.Label23.Text = "E.D.   :"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Cmd_POTermsHelp
        '
        Me.Cmd_POTermsHelp.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_POTermsHelp.Image = CType(resources.GetObject("Cmd_POTermsHelp.Image"), System.Drawing.Image)
        Me.Cmd_POTermsHelp.Location = New System.Drawing.Point(268, 80)
        Me.Cmd_POTermsHelp.Name = "Cmd_POTermsHelp"
        Me.Cmd_POTermsHelp.Size = New System.Drawing.Size(24, 25)
        Me.Cmd_POTermsHelp.TabIndex = 18
        '
        'Txt_AdvanceAmt
        '
        Me.Txt_AdvanceAmt.BackColor = System.Drawing.Color.Wheat
        Me.Txt_AdvanceAmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_AdvanceAmt.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_AdvanceAmt.Location = New System.Drawing.Point(136, 112)
        Me.Txt_AdvanceAmt.MaxLength = 8
        Me.Txt_AdvanceAmt.Name = "Txt_AdvanceAmt"
        Me.Txt_AdvanceAmt.Size = New System.Drawing.Size(128, 22)
        Me.Txt_AdvanceAmt.TabIndex = 16
        Me.Txt_AdvanceAmt.Text = ""
        Me.Txt_AdvanceAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(17, 84)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(131, 18)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "PAYMENT TERMS :"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 23)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "ADVANCE AMT :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(848, 486)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
