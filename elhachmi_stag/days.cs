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
    public partial class days : Form
    {
        Panel pn;
        int yr;
        int mn;
        Label l1;
        Label l2;
        Label l3;
        public days(Panel pane, int year, int month, Label lb1, Label lb2, Label lb3)
        {
            InitializeComponent();
            pn = pane;
            yr = year;
            mn = month;
            l1 = lb1;
            l2 = lb2;
            l3 = lb3;
        }

        private void days_Load(object sender, EventArgs e)
        {
            int total = DateTime.DaysInMonth(yr, mn) + 1;
            Panel[] panels = { panel_1, panel_2, panel_3, panel_4, panel_5, panel_6, panel_7, panel_8, panel_9, panel_10, panel_11, panel_12, panel_13, panel_14, panel_15, panel_16, panel_17, panel_18, panel_19, panel_20, panel_21, panel_22, panel_23, panel_24, panel_25, panel_26, panel_27, panel_28, panel_29, panel_30, panel_31 };
            for (int i = 1; i < total; i++)
            {
                int x = i - 1;
                panels[x].Controls.Clear();
                UserControl2 us = new UserControl2(i, this, pn, mn, l1, l2, l3);
                panels[x].Controls.Add(us);
                us.Dock = DockStyle.Fill;
                us.Show();
            }
        }

        private void panel_1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
