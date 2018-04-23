using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;

namespace WindowsApplication2
{
    public partial class Form1 : Form
    {
        DockHelper helper;

        public Form1()
        {
            InitializeComponent();
            helper = new DockHelper(dockManager1);
            helper.AllowDockToSplitContainer = true;
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            helper.AllowDockToSplitContainer = false;
        }
    }
}