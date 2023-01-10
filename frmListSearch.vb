Public Class frmListSearch
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents grpSearch As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmListSearch))
        Me.grpSearch = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtSearch = New System.Windows.Forms.TextBox
        Me.grpSearch.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSearch
        '
        Me.grpSearch.BackColor = System.Drawing.Color.Transparent
        Me.grpSearch.Controls.Add(Me.Button1)
        Me.grpSearch.Controls.Add(Me.Label1)
        Me.grpSearch.Controls.Add(Me.btnCancel)
        Me.grpSearch.Controls.Add(Me.Label5)
        Me.grpSearch.Controls.Add(Me.btnSearch)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Location = New System.Drawing.Point(8, 0)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(384, 96)
        Me.grpSearch.TabIndex = 168
        Me.grpSearch.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(152, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 154
        Me.Button1.Text = "&Next  >>"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(24, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 23)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "F3-->Search Continue"
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(288, 56)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 32)
        Me.btnCancel.TabIndex = 152
        Me.btnCancel.Text = "&Cancel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 18)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "Search Text :"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(240, 56)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 32)
        Me.btnSearch.TabIndex = 1
        Me.btnSearch.Text = "&Go"
        '
        'txtSearch
        '
        Me.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSearch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(120, 24)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(240, 26)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = ""
        '
        'frmListSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(400, 102)
        Me.Controls.Add(Me.grpSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListSearch"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Search"
        Me.grpSearch.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public listbox As CheckedListBox
    Public boolSearchNext, boolSearchResult As Boolean
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        boolSearchNext = False
        Call listSearch_New()
    End Sub
    Private Sub listSearch()
        If Len(Trim(txtSearch.Text)) = 0 Then
            MsgBox("Search Text Can't Be Blank....", MsgBoxStyle.OKOnly, Application.ProductName)
            grpSearch.Focus()
            Exit Sub
        End If
        Dim i, j, init, intStringLength, intStringLength1 As Integer
        Dim Item() As String
        If listbox.Items.Count > 2 Then
            boolSearchResult = False
            If boolSearchNext = False Then
                init = 0
            Else
                init = listbox.SelectedIndex + 1
            End If
            For i = init To listbox.Items.Count - 1
                Item = Split(listbox.Items.Item(i), "-->")
                '------------ checking itemCode
                intStringLength = Item(0).Length
                For j = 0 To intStringLength - 1
                    If UCase(Mid(Trim(Item(0)), j + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
                        listbox.SetSelected(i, True)
                        boolSearchResult = True
                        grpSearch.Focus()
                        Exit For
                    End If
                Next
                If boolSearchResult = True Then
                    Exit For
                End If
                '------------ checking itemName
                If Item.Length = 2 Then
                    intStringLength1 = Item(1).Length
                    For j = 0 To intStringLength1 - 1
                        If UCase(Mid(Trim(Item(1)), j + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
                            listbox.SetSelected(i, True)
                            boolSearchResult = True
                            grpSearch.Focus()
                            Exit For
                        End If
                    Next
                End If
            Next
            If boolSearchResult = False Then
                MsgBox("Reached End of List ...", MsgBoxStyle.OKOnly, Application.ProductName)
                txtSearch.Focus()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub listSearch_New()
        If Len(Trim(txtSearch.Text)) = 0 Then
            MsgBox("Search Text Can't Be Blank....", MsgBoxStyle.OKOnly, Application.ProductName)
            grpSearch.Focus()
            Exit Sub
        End If
        Dim i, j, init, intStringLength, intStringLength1 As Integer
        Dim Item() As String
        If listbox.Items.Count > 2 Then
            boolSearchResult = False
            If boolSearchNext = False Then
                init = 0
            Else
                init = listbox.SelectedIndex + 1
            End If
            For i = init To listbox.Items.Count - 1
                Item = Split(listbox.Items.Item(i), "-->")
                '------------ checking itemCode
                intStringLength = Item(0).Length
                For j = 0 To intStringLength - 1
                    If UCase(Mid(Trim(Item(0)), j + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
                        listbox.SetSelected(i, True)
                        boolSearchResult = True
                        grpSearch.Focus()
                        Exit For
                    End If
                Next
                If boolSearchResult = True Then
                    Exit For
                End If
                '------------ checking itemName
                If Item.Length = 2 Then
                    intStringLength1 = Item(1).Length
                    For j = 0 To intStringLength1 - 1
                        If UCase(Mid(Trim(Item(1)), j + 1, Len(Trim(txtSearch.Text)))) = UCase(Trim(txtSearch.Text)) Then
                            listbox.SetSelected(i, True)
                            boolSearchResult = True
                            grpSearch.Focus()
                            Exit For
                        End If
                    Next
                End If
            Next
            If boolSearchResult = False Then
                MsgBox("Reached End of List ...", MsgBoxStyle.OKOnly, Application.ProductName)
                txtSearch.Focus()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub frmSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F3 Then
            boolSearchNext = True
            Call listSearch_New()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub grpSearch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grpSearch.KeyDown
        If e.KeyCode = Keys.F3 Then
            boolSearchNext = True
            Call listSearch_New()
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub txtSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSearch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call btnSearch_Click(sender, e)
        End If
    End Sub
    Private Sub txtSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        boolSearchNext = True
        Call listSearch_New()
    End Sub
End Class