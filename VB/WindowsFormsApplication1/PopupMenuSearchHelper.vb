Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Repository
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Drawing
Imports DevExpress.Utils.Win
Imports DevExpress.XtraBars.Controls
Imports System.Reflection

Namespace WindowsFormsApplication1
    Public Class PopupMenuSearchHelper
        Private currentMenu As PopupMenu
        Private searchBarItem As BarEditItem
        Public Sub New(ByVal someMenu As PopupMenu)
            currentMenu = someMenu
            Dim searchEditor As New RepositoryItemButtonEdit()
            searchEditor.Buttons(0).Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph
            searchEditor.Buttons(0).Image = My.Resources.search16

            AddHandler searchEditor.ButtonClick, AddressOf searchEditor_ButtonClick
            AddHandler searchEditor.EditValueChanged, AddressOf searchEditor_EditValueChanged


            searchBarItem = New BarEditItem(currentMenu.Manager, searchEditor)
            searchBarItem.Width = 200
            searchBarItem.Caption = "Find item"

            If currentMenu.ItemLinks.Count = 0 Then
                currentMenu.AddItem(searchBarItem)
            Else
                currentMenu.InsertItem(currentMenu.ItemLinks(0), searchBarItem)
            End If
            RemoveHandler currentMenu.Popup, AddressOf menu_Popup
            AddHandler currentMenu.Popup, AddressOf menu_Popup

            AddHandler someMenu.Manager.HighlightedLinkChanged, AddressOf Manager_HighlightedLinkChanged
        End Sub

        Private editorShown As Boolean = False
        Private Sub Manager_HighlightedLinkChanged(ByVal sender As Object, ByVal e As HighlightedLinkChangedEventArgs)
            If e.Link IsNot Nothing AndAlso e.Link.Item.Equals(searchBarItem) Then
                TryCast(e.Link, BarEditItemLink).ShowEditor()
                editorShown = True
            End If
        End Sub

        Private Sub searchEditor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            FilterApplicationMenuItems((TryCast(sender, ButtonEdit)).EditValue)
        End Sub

        Private Sub searchEditor_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
            FilterApplicationMenuItems((TryCast(sender, ButtonEdit)).EditValue)
        End Sub

        Private Sub menu_Popup(ByVal sender As Object, ByVal e As EventArgs)
            Dim popupControl As PopupMenuBarControl = TryCast((TryCast(sender, PopupControl)).IPopup, PopupMenuBarControl)
            AddHandler popupControl.MouseMove, AddressOf popupControl_MouseMove
            TryCast(sender, PopupMenu).Manager.Form.BeginInvoke(New MethodInvoker(AddressOf FocusSearchItem))
        End Sub

        Private Sub FocusSearchItem()
            currentMenu.ItemLinks(0).Focus()
        End Sub

        Private Sub popupControl_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            If editorShown Then
                editorShown = False
                Return
            End If
            Dim highlightedLink As BarItemLink = (TryCast(sender, PopupMenuBarControl)).GetLinkByPoint(Cursor.Position)
            If highlightedLink IsNot Nothing Then
                If Not highlightedLink.Item.Equals(searchBarItem) Then
                    For Each item As BarEditItemLink In searchBarItem.Links
                        If item.ActiveEditor IsNot Nothing Then
                            item.CloseEditor()
                            item.PostEditor()
                            Exit For
                        End If
                    Next item
                End If
            End If
        End Sub

        Private Sub FilterApplicationMenuItems(ByVal searchString As Object)
            If searchString Is Nothing Then
                Return
            End If
            For Each item As BarItemLink In currentMenu.ItemLinks
                If item.Item.Equals(searchBarItem) Then
                    Continue For
                End If
                If searchString.ToString() = "" Then
                    item.Visible = True
                Else
                    item.Visible = item.Caption.ToUpper().Contains(searchString.ToString().ToUpper())
                End If
            Next item
        End Sub

    End Class
End Namespace

