using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elhachmi_stag
{
    public partial class month : Form
    {
        Panel pn;
        Label l1;
        Label l2;
        Label l3;
        public month(Panel pane, Label lb1, Label lb2, Label lb3)
        {
            InitializeComponent();
            pn = pane;
            l1 = lb1;
            l2 = lb2;
            l3 = lb3;

        }
        
        private void month_Load(object sender, EventArgs e)
        {
            Panel[] panels = { panel_1, panel_2, panel_3, panel_4, panel_5, panel_6, panel_7, panel_8, panel_9, panel_10, panel_11, panel_12 };
            for (int i = 1; i < 13; i++)
            {
                int x = i - 1;
                panels[x].Controls.Clear();
                UserControl1 us = new UserControl1(i, this,pn,l1,l2,l3);
                panels[x].Controls.Add(us);
                us.Dock = DockStyle.Fill;
                us.Show();
            }
        }

        private void panel_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
