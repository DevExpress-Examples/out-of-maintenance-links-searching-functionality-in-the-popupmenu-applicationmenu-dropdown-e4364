using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing;
using DevExpress.Utils.Win;
using DevExpress.XtraBars.Controls;
using System.Reflection;

namespace WindowsFormsApplication1
{
    public class PopupMenuSearchHelper
    {
        PopupMenu currentMenu;
        BarEditItem searchBarItem;
        public PopupMenuSearchHelper(PopupMenu someMenu) 
        {
            currentMenu = someMenu;
            RepositoryItemButtonEdit searchEditor = new RepositoryItemButtonEdit();
            searchEditor.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            searchEditor.Buttons[0].Image = WindowsFormsApplication1.Properties.Resources.search16;

            searchEditor.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(searchEditor_ButtonClick);
            searchEditor.EditValueChanged += new EventHandler(searchEditor_EditValueChanged);


            searchBarItem = new BarEditItem(currentMenu.Manager, searchEditor);
            searchBarItem.Width = 200;
            searchBarItem.Caption = "Find item";            

            if (currentMenu.ItemLinks.Count == 0)
                currentMenu.AddItem(searchBarItem);
            else
                currentMenu.InsertItem(currentMenu.ItemLinks[0], searchBarItem);
            currentMenu.Popup -= new EventHandler(menu_Popup);
            currentMenu.Popup += new EventHandler(menu_Popup);

            someMenu.Manager.HighlightedLinkChanged += new HighlightedLinkChangedEventHandler(Manager_HighlightedLinkChanged);
        }

        bool editorShown = false;
        void Manager_HighlightedLinkChanged(object sender, HighlightedLinkChangedEventArgs e)
        {
            if (e.Link != null && e.Link.Item == searchBarItem)
            {                    
                (e.Link as BarEditItemLink). ShowEditor();
                editorShown = true;
            }
        }

        void searchEditor_EditValueChanged(object sender, EventArgs e)
        {
            FilterApplicationMenuItems((sender as ButtonEdit).EditValue);
        }

        void searchEditor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {                
            FilterApplicationMenuItems((sender as ButtonEdit).EditValue);
        }

        void menu_Popup(object sender, EventArgs e)
        {
            PopupMenuBarControl popupControl = (sender as PopupControl).IPopup as PopupMenuBarControl;
            popupControl.MouseMove += new MouseEventHandler(popupControl_MouseMove);
            (sender as PopupMenu).Manager.Form.BeginInvoke(new MethodInvoker(delegate{
                (sender as PopupMenu).ItemLinks[0].Focus(); 
            }));            
        }

        void popupControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (editorShown)
            {
                editorShown = false;
                return;
            }
            BarItemLink highlightedLink = (sender as PopupMenuBarControl).GetLinkByPoint(Cursor.Position);
            if (highlightedLink != null)
            {
                if (highlightedLink.Item != searchBarItem)
                {
                    foreach (BarEditItemLink item in searchBarItem.Links)
                    {
                        if (item.ActiveEditor != null)
                        {
                            item.CloseEditor();
                            item.PostEditor();
                            break;
                        }
                    }
                }            
            }
        }

        void FilterApplicationMenuItems(object searchString)
        {
            if (searchString == null) return;
            foreach (BarItemLink item in currentMenu.ItemLinks)
            {
                if (item.Item == searchBarItem) continue;
                if (searchString.ToString() == "")
                    item.Visible = true;
                else
                    item.Visible = item.Caption.ToUpper().Contains(searchString.ToString().ToUpper());
            }
        }
    }
}
