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
    public class DockHelper
    {
        DockManager manager;

        public DockHelper(DockManager manager)
        {
            this.manager = manager;
        }

        public bool AllowDockToSplitContainer
        {
            set
            {
                manager.Docking -= OnDockManagerDocking;
                if (value)
                    manager.Docking += OnDockManagerDocking;
            }
        }

        private void OnDockManagerDocking(object sender, DevExpress.XtraBars.Docking.DockingEventArgs e)
        {
            if (e.TargetPanel == null)
            {
                foreach (DockPanel p in manager.Panels)
                    if (p.Dock == e.Dock)
                    {
                        e.Cancel = true;
                        return;
                    }
            }
            else
                e.Cancel = e.Dock != DockingStyle.Fill;
        }


    }
}
