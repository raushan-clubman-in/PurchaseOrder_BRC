Imports System.Data.SqlClient
Imports System
Imports System.Data
Imports System.IO
Public Class itemmaster
    Inherits System.Windows.Forms.Form
    Dim ssql, vPromUOM As String
    Dim gconnection As New GlobalClass
    Dim vconn As New GlobalClass
    Dim boolchk As Boolean
    Dim vseqno As Double
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
    Friend WithEvents Lbl_itemname As System.Windows.Forms.Label
    Friend WithEvents txt_Itemcode As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_itemcode As System.Windows.Forms.Label
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Lbl_shortname As System.Windows.Forms.Label
    Friend WithEvents txt_shortname As System.Windows.Forms.TextBox
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents cmdItemHelp As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(itemmaster))
        Me.Label16 = New System.Windows.Forms.Label
        Me.Lbl_currentrate = New System.Windows.Forms.Label
        Me.txt_currentrate = New System.Windows.Forms.TextBox
        Me.lbl_UOM = New System.Windows.Forms.Label
        Me.Cmb_uom = New System.Windows.Forms.ComboBox
        Me.txt_itemname = New System.Windows.Forms.TextBox
        Me.Lbl_itemname = New System.Windows.Forms.Label
        Me.txt_Itemcode = New System.Windows.Forms.TextBox
        Me.Lbl_itemcode = New System.Windows.Forms.Label
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Lbl_shortname = New System.Windows.Forms.Label
        Me.txt_shortname = New System.Windows.Forms.TextBox
        Me.cmdItemHelp = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label16.Location = New System.Drawing.Point(88, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(424, 31)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "PURCHASE ORDER ITEM MASTER"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_currentrate
        '
        Me.Lbl_currentrate.AutoSize = True
        Me.Lbl_currentrate.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_currentrate.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_currentrate.ForeColor = System.Drawing.Color.Black
        Me.Lbl_currentrate.Location = New System.Drawing.Point(74, 232)
        Me.Lbl_currentrate.Name = "Lbl_currentrate"
        Me.Lbl_currentrate.Size = New System.Drawing.Size(119, 18)
        Me.Lbl_currentrate.TabIndex = 3
        Me.Lbl_currentrate.Text = "CURRENT RATE :"
        '
        'txt_currentrate
        '
        Me.txt_currentrate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_currentrate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currentrate.Location = New System.Drawing.Point(224, 232)
        Me.txt_currentrate.MaxLength = 12
        Me.txt_currentrate.Name = "txt_currentrate"
        Me.txt_currentrate.Size = New System.Drawing.Size(220, 26)
        Me.txt_currentrate.TabIndex = 0
        Me.txt_currentrate.Text = ""
        Me.txt_currentrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_UOM
        '
        Me.lbl_UOM.AutoSize = True
        Me.lbl_UOM.BackColor = System.Drawing.Color.Transparent
        Me.lbl_UOM.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_UOM.ForeColor = System.Drawing.Color.Black
        Me.lbl_UOM.Location = New System.Drawing.Point(123, 192)
        Me.lbl_UOM.Name = "lbl_UOM"
        Me.lbl_UOM.Size = New System.Drawing.Size(65, 18)
        Me.lbl_UOM.TabIndex = 5
        Me.lbl_UOM.Text = "UOM       :"
        '
        'Cmb_uom
        '
        Me.Cmb_uom.BackColor = System.Drawing.Color.White
        Me.Cmb_uom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_uom.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_uom.Location = New System.Drawing.Point(224, 192)
        Me.Cmb_uom.Name = "Cmb_uom"
        Me.Cmb_uom.Size = New System.Drawing.Size(220, 27)
        Me.Cmb_uom.TabIndex = 2
        '
        'txt_itemname
        '
        Me.txt_itemname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_itemname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_itemname.Location = New System.Drawing.Point(224, 112)
        Me.txt_itemname.MaxLength = 30
        Me.txt_itemname.Name = "txt_itemname"
        Me.txt_itemname.Size = New System.Drawing.Size(220, 26)
        Me.txt_itemname.TabIndex = 2
        Me.txt_itemname.Text = ""
        '
        'Lbl_itemname
        '
        Me.Lbl_itemname.AutoSize = True
        Me.Lbl_itemname.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_itemname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_itemname.ForeColor = System.Drawing.Color.Black
        Me.Lbl_itemname.Location = New System.Drawing.Point(100, 128)
        Me.Lbl_itemname.Name = "Lbl_itemname"
        Me.Lbl_itemname.Size = New System.Drawing.Size(93, 18)
        Me.Lbl_itemname.TabIndex = 23
        Me.Lbl_itemname.Text = "ITEM NAME :"
        '
        'txt_Itemcode
        '
        Me.txt_Itemcode.BackColor = System.Drawing.Color.Wheat
        Me.txt_Itemcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_Itemcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Itemcode.Location = New System.Drawing.Point(224, 72)
        Me.txt_Itemcode.MaxLength = 10
        Me.txt_Itemcode.Name = "txt_Itemcode"
        Me.txt_Itemcode.Size = New System.Drawing.Size(220, 26)
        Me.txt_Itemcode.TabIndex = 0
        Me.txt_Itemcode.Text = ""
        '
        'Lbl_itemcode
        '
        Me.Lbl_itemcode.AutoSize = True
        Me.Lbl_itemcode.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_itemcode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_itemcode.ForeColor = System.Drawing.Color.Black
        Me.Lbl_itemcode.Location = New System.Drawing.Point(103, 80)
        Me.Lbl_itemcode.Name = "Lbl_itemcode"
        Me.Lbl_itemcode.Size = New System.Drawing.Size(90, 18)
        Me.Lbl_itemcode.TabIndex = 20
        Me.Lbl_itemcode.Text = "ITEM CODE :"
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(248, 264)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 315
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(8, 304)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 321
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(320, 304)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 319
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Freeze.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.White
        Me.Cmd_Freeze.Image = CType(resources.GetObject("Cmd_Freeze.Image"), System.Drawing.Image)
        Me.Cmd_Freeze.Location = New System.Drawing.Point(216, 304)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Freeze.TabIndex = 320
        Me.Cmd_Freeze.Text = "Freeze[F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.White
        Me.Cmd_Add.Image = CType(resources.GetObject("Cmd_Add.Image"), System.Drawing.Image)
        Me.Cmd_Add.Location = New System.Drawing.Point(104, 16)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Add.TabIndex = 318
        Me.Cmd_Add.Text = "Add [F7]"
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.cmd_Exit.Image = CType(resources.GetObject("cmd_Exit.Image"), System.Drawing.Image)
        Me.cmd_Exit.Location = New System.Drawing.Point(544, 16)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 317
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox6.Controls.Add(Me.Button1)
        Me.GroupBox6.Controls.Add(Me.Cmd_Add)
        Me.GroupBox6.Controls.Add(Me.cmd_Exit)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 288)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(656, 56)
        Me.GroupBox6.TabIndex = 316
        Me.GroupBox6.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(472, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 22)
        Me.Label9.TabIndex = 322
        Me.Label9.Text = "[F4]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Location = New System.Drawing.Point(16, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(246, 16)
        Me.Label6.TabIndex = 417
        Me.Label6.Text = "Press F4 for HELP /Press ENTER key to navigate"
        '
        'Lbl_shortname
        '
        Me.Lbl_shortname.AutoSize = True
        Me.Lbl_shortname.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_shortname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_shortname.ForeColor = System.Drawing.Color.Black
        Me.Lbl_shortname.Location = New System.Drawing.Point(90, 160)
        Me.Lbl_shortname.Name = "Lbl_shortname"
        Me.Lbl_shortname.TabIndex = 418
        Me.Lbl_shortname.Text = "SHORTNAME :"
        '
        'txt_shortname
        '
        Me.txt_shortname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_shortname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shortname.Location = New System.Drawing.Point(224, 152)
        Me.txt_shortname.MaxLength = 10
        Me.txt_shortname.Name = "txt_shortname"
        Me.txt_shortname.Size = New System.Drawing.Size(220, 26)
        Me.txt_shortname.TabIndex = 419
        Me.txt_shortname.Text = ""
        '
        'cmdItemHelp
        '
        Me.cmdItemHelp.Image = CType(resources.GetObject("cmdItemHelp.Image"), System.Drawing.Image)
        Me.cmdItemHelp.Location = New System.Drawing.Point(448, 72)
        Me.cmdItemHelp.Name = "cmdItemHelp"
        Me.cmdItemHelp.Size = New System.Drawing.Size(23, 26)
        Me.cmdItemHelp.TabIndex = 429
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(424, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 320
        Me.Button1.Text = "VALIDATE"
        '
        'itemmaster
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(720, 373)
        Me.Controls.Add(Me.cmdItemHelp)
        Me.Controls.Add(Me.txt_shortname)
        Me.Controls.Add(Me.Lbl_shortname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Lbl_itemname)
        Me.Controls.Add(Me.txt_Itemcode)
        Me.Controls.Add(Me.Lbl_itemcode)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.txt_itemname)
        Me.Controls.Add(Me.lbl_UOM)
        Me.Controls.Add(Me.Lbl_currentrate)
        Me.Controls.Add(Me.txt_currentrate)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Freeze)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Cmb_uom)
        Me.Font = New System.Drawing.Font("Symbol", 8.0!)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "itemmaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PURCHASE ORDER ITEM MASTER"
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

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
        Cmd_Add.Text = "Add [F7]"
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txt_Itemcode.Enabled = True
        txt_Itemcode.Focus()
    End Sub

    Private Sub ItemMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cmb_uom.DropDownStyle = ComboBoxStyle.DropDownList
        ItemMasterbool = True
        txt_itemname.ReadOnly = False
        txt_Itemcode.ReadOnly = False
        'Cmd_Freeze.Enabled = False
        cmdItemHelp.Enabled = True
        Call FillUOM() ''' --> Fill All UOM 
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txt_Itemcode.Focus()
    End Sub

    Private Sub GetRights()
        Dim i, j, k, x As Integer
        Dim vmain, vsmod, vssmod As Long
        Dim ssql, SQLSTRING As String
        Dim M1 As New MainMenu
        Dim chstr As String
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='Purchase Order' AND MODULENAME LIKE 'ItemMaster%'"
        vconn.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.Cmd_Add.Enabled = False
        Me.Cmd_Freeze.Enabled = False
        Cmd_View.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_Add.Enabled = True
                    Me.Cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
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
                End If
            Next
        End If
    End Sub
    Private Function ItemValidate() As Boolean
        ItemValidate = False
        If Trim(txt_Itemcode.Text) = "" Then
            ItemValidate = False
            MsgBox("Item Code Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            txt_Itemcode.Focus()
            Exit Function
        End If
        If Trim(txt_itemname.Text) = "" Then
            ItemValidate = False
            MsgBox("Item Name Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            txt_itemname.Focus()
            Exit Function
        End If
        If Trim(txt_shortname.Text) = "" Then
            ItemValidate = False
            MsgBox("ShortName Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            txt_shortname.Focus()
            Exit Function
        End If
        If Trim(Cmb_uom.Text) = "" Then
            ItemValidate = False
            MsgBox("UOM Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            Cmb_uom.Focus()
            Exit Function
        End If
        If Trim(txt_currentrate.Text) = "" Then
            ItemValidate = False
            MsgBox("CurrentRate Cannot be Blank", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, MyCompanyName)
            txt_currentrate.Focus()
            Exit Function
        End If
        ItemValidate = True
    End Function

    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim vPromseqno, insert(0), VarPOSCODE(), sqlarray() As String
        Dim vstring, vDate As Date
        Dim vPOSno As Double
        Dim count As Integer
        '''*********************************** Check Validation *******************************************************'''
        'If ItemValidate() = False Then Exit Sub
        '''*********************************** Insert ItemMaster *******************************************'''
        Try
            If Cmd_Add.Text = "Add [F7]" Then
                Call ItemValidate()
                ssql = "INSERT INTO PO_ITEMMASTER(Itemcode,Itemname,shortname,uom,currentofferrate, "
                ssql = ssql & "freeze,adduser,adddatetime) values("
                ssql = ssql & " '" & Trim(txt_Itemcode.Text) & "','" & Trim(txt_itemname.Text) & "','" & Trim(txt_shortname.Text) & "',"
                ssql = ssql & " '" & Trim(Cmb_uom.Text) & "',"
                ssql = ssql & Format(Val(Me.txt_currentrate.Text), "0.00") & ","
                ssql = ssql & " 'N',"
                ssql = ssql & "  '" & gUsername & "',"
                ssql = ssql & "'" & Format(Now, "dd-MMM-yyyy HH:MM:ss") & "')"
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = ssql
                gconnection.MoreTrans(insert)

            ElseIf Cmd_Add.Text = "Update[F7]" And Me.lbl_Freeze.Visible = True Then
                Call ItemValidate()
                'If boolchk = False Then Exit Sub
                MessageBox.Show("The Freezed Record Cannot Be Updated", "ITEMMASTER", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                boolchk = False

            ElseIf Me.lbl_Freeze.Visible = False And Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
                ssql = "UPDATE PO_ITEMMASTER SET Itemname = '" & Replace(Trim(txt_itemname.Text), "'", " ") & "',"
                ssql = ssql & " ShortName = '" & Trim(txt_shortname.Text) & "',"
                ssql = ssql & " Uom = '" & Trim(Cmb_uom.Text) & "',"
                ssql = ssql & " Currentofferrate='" & Format(Val(Me.txt_currentrate.Text), "0.00") & "',"
                ssql = ssql & "updateuser= '" & gUsername & "',updatedatetime='" & Format(Now, "dd-MMM-yyyy HH:MM:ss") & "'"
                ssql = ssql & "where Itemcode= '" & txt_Itemcode.Text & "' "
                ReDim Preserve insert(insert.Length)
                insert(insert.Length - 1) = ssql
                gconnection.MoreTrans(insert)
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
            End If
        Catch ex As Exception
            MsgBox("Error In Saving")
            Call Me.Cmd_Clear_Click(sender, e)
            Exit Sub
        End Try
        Me.Cmd_Clear_Click(sender, e)
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim FrReport As New ReportDesigner
        tables = " PO_ITEMMASTER"
        Gheader = "ITEM MASTER"
        FrReport.SsGridReport.SetText(2, 1, "ITEMCODE")
        FrReport.SsGridReport.SetText(3, 1, 10)
        FrReport.SsGridReport.SetText(2, 2, "ITEMNAME")
        FrReport.SsGridReport.SetText(3, 2, 30)
        FrReport.SsGridReport.SetText(2, 3, "SHORTNAME")
        FrReport.SsGridReport.SetText(3, 3, 10)
        FrReport.SsGridReport.SetText(2, 4, "UOM")
        FrReport.SsGridReport.SetText(3, 4, 8)
        FrReport.SsGridReport.SetText(2, 5, "CURRENTOFFERRATE")
        FrReport.SsGridReport.SetText(3, 5, 17)
        FrReport.Show()
    End Sub
    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        Me.Close()
    End Sub
    Private Sub ItemMaster_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(Cmd_Clear, e)
        End If
        If e.KeyCode = Keys.F7 Then
            Call CmdAdd_Click(Cmd_Add, e)
        End If
        If e.KeyCode = Keys.F8 Then
            Call Cmd_Freeze_Click(Cmd_Freeze, e)
        End If
        If e.KeyCode = Keys.F9 Then
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
        If boolchk = False Then Exit Sub
        If Mid(Cmd_Freeze.Text, 1, 1) = "F" Then
            strsql = "UPDATE  PO_ITEMMASTER "
            strsql = strsql & " SET Freeze= 'Y',Freezeuser='" & gUsername & " ', Freezedatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            strsql = strsql & " WHERE ITEMCODE = '" & Trim(txt_Itemcode.Text) & "'"
            gconnection.dataOperation(3, strsql, "PO_ITEMMASTER")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        Else
            strsql = "UPDATE  PO_ITEMMASTER "
            strsql = strsql & " SET Freeze= 'N',Adduser='" & gUsername & " ', Adddatetime='" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "'"
            strsql = strsql & " WHERE ITEMCODE = '" & Trim(txt_Itemcode.Text) & "'"
            gconnection.dataOperation(4, strsql, "PO_ITEMMASTER")
            Me.Cmd_Clear_Click(sender, e)
            Cmd_Add.Text = "Add [F7]"
        End If
    End Sub


    Private Sub txt_itemname_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_itemname.KeyPress
        If txt_itemname.Text <> "" And e.KeyChar = Chr(13) Then
            txt_shortname.Focus()
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
            strsql = "SELECT * FROM PO_ITEMMASTER WHERE itemcode='" & Trim(txt_Itemcode.Text) & "'"
            gconnection.getDataSet(strsql, "PO_ITEMMASTER")
            If gdataset.Tables("PO_ITEMMASTER").Rows.Count > 0 Then
                txt_Itemcode.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("itemcode"))
                txt_itemname.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("itemname"))
                txt_shortname.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("shortname"))
                Cmb_uom.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("uom"))
                txt_currentrate.Text = Trim(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("currentofferrate"))
                If gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("Freeze") = "Y" Then
                    Me.lbl_Freeze.Visible = True
                    Me.lbl_Freeze.Text = ""
                    Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("PO_ITEMMASTER").Rows(0).Item("AddDatetime")), "dd-MMM-yyyy")
                    Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Freeze.Text = "Freeze[F8]"
                End If
                Me.Cmd_Add.Text = "Update[F7]"
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
        Else
            'txt_itemname.Focus()
        End If
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
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

    End Sub

    Private Sub txt_currentrate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_currentrate.KeyDown
        If txt_currentrate.Text <> "" And e.KeyCode = 13 Then
            Cmd_Add.Focus()
        Else
            txt_currentrate.Focus()
        End If
    End Sub

    Private Sub cmdItemHelp_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdItemHelp.Click
        gSQLString = "SELECT  ISNULL(ITEMCODE,'') AS ITEMCODE,ISNULL(ITEMNAME,'') AS ITEMNAME  FROM PO_ITEMMASTER"
        M_WhereCondition = ""
        Dim vform As New List_Operation
        vform.Field = "ITEMCODE,ITEMNAME"
        vform.vFormatstring = "  ITEMCODE         |                       ITEMNAME          "
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start(AppPath & "\STUDY\ITEMMASTER.XLS")
    End Sub
End Class