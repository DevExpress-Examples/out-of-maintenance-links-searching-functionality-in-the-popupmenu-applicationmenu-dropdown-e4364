using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;

namespace WindowsFormsApplication1
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopupMenuSearchHelper helperAppMenu = new PopupMenuSearchHelper(applicationMenu1);
            PopupMenuSearchHelper helperPopupMenu = new PopupMenuSearchHelper(popupMenu1);
        }
    }
}
