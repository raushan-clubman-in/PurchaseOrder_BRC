Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Windows.Forms
Module IconsMenuMain
    Dim m_Font As New Font("Arial", 8)
    Sub MeasureItems(ByVal EvMeasureItem As System.Windows.Forms.MeasureItemEventArgs, ByVal Mi As MenuItem)
        Dim sf As StringFormat = New StringFormat()
        sf.HotkeyPrefix = HotkeyPrefix.Show
        sf.SetTabStops(60, New Single() {0})
        EvMeasureItem.ItemHeight = 22
        EvMeasureItem.ItemWidth = CInt(EvMeasureItem.Graphics.MeasureString(GetRealText(Mi), m_Font, 10000, sf).Width) + 10
        sf.Dispose()
        sf = Nothing
    End Sub
    Sub DrawItems(ByVal EvDrawItems As System.Windows.Forms.DrawItemEventArgs, ByVal Mi As MenuItem, ByVal m_Icon As Icon)
        Dim br As Brush
        Dim fDisposeBrush As Boolean
        If Not m_Icon Is Nothing Then
            If Not Mi.Checked Then
                EvDrawItems.Graphics.DrawIcon(m_Icon, EvDrawItems.Bounds.Left + 2, EvDrawItems.Bounds.Top + 2)
            Else
                EvDrawItems.Graphics.DrawIcon(m_Icon, EvDrawItems.Bounds.Left + 2, EvDrawItems.Bounds.Top + 2)
                Dim nPen As System.Drawing.Pen
                If Not Mi.Enabled Then
                    NPEN = New Pen(Color.DarkGray)
                Else
                    nPen = New Pen(Color.Gray)
                End If
                EvDrawItems.Graphics.DrawRectangle(nPen, 1, EvDrawItems.Bounds.Top, 20, 20)
                EvDrawItems.Graphics.DrawRectangle(nPen, 3, EvDrawItems.Bounds.Top + 2, 16, 16)
            End If
        Else
            If Mi.Checked Then
                Dim nPen As System.Drawing.Pen
                If Not Mi.Enabled Then
                    NPEN = New Pen(Color.DarkGray)
                Else
                    nPen = New Pen(Color.Gray)
                End If
                EvDrawItems.Graphics.DrawRectangle(nPen, 1, EvDrawItems.Bounds.Top, 20, 20)
                Dim Pnts() As Point
                ReDim Pnts(2)
                Pnts(0) = New Point(15, EvDrawItems.Bounds.Top + 6)
                Pnts(1) = New Point(8, EvDrawItems.Bounds.Top + 13)
                Pnts(2) = New Point(5, EvDrawItems.Bounds.Top + 10)
                If Mi.Enabled Then
                    EvDrawItems.Graphics.DrawLines(New Pen(Color.Black), Pnts)
                Else
                    EvDrawItems.Graphics.DrawLines(New Pen(Color.Gray), Pnts)
                End If
            End If
        End If
        Dim rcBk As Rectangle = EvDrawItems.Bounds
        rcBk.X += 24

        If CBool(EvDrawItems.State And DrawItemState.Selected) Then
            br = New LinearGradientBrush(rcBk, Color.MidnightBlue, Color.LightBlue, 0)
            fDisposeBrush = True
        Else
            br = SystemBrushes.Control
        End If
        EvDrawItems.Graphics.FillRectangle(br, rcBk)
        If fDisposeBrush Then br.Dispose()
        br = Nothing
        Dim sf As StringFormat = New StringFormat()
        sf.HotkeyPrefix = HotkeyPrefix.Show
        sf.SetTabStops(60, New Single() {0})
        If Mi.Enabled Then
            br = New SolidBrush(EvDrawItems.ForeColor)
        Else
            br = New SolidBrush(Color.Gray)
        End If
        EvDrawItems.Graphics.DrawString(GetRealText(Mi), m_Font, br, EvDrawItems.Bounds.Left + 25, EvDrawItems.Bounds.Top + 2, sf)
        br.Dispose()
        br = Nothing
        sf.Dispose()
        sf = Nothing
    End Sub
    Function GetRealText(ByVal Mi As MenuItem) As String
        Dim s As String = Mi.Text
        If Mi.ShowShortcut And Mi.Shortcut <> Shortcut.None Then
            Dim k As Keys = CType(Mi.Shortcut, Keys)
            s = s & Convert.ToChar(9) & TypeDescriptor.GetConverter(GetType(Keys)).ConvertToString(k)
        End If
        Return s
    End Function

End Module
