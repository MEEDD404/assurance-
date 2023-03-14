using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elhachmi_stag
{
    public partial class UserControl2 : UserControl
    {
        int m;
        Form n;
        Panel p;
        int mon;

        Label l1;
        Label l2;
        Label l3;
        public UserControl2(int day, Form k, Panel pn, int month, Label lb1, Label lb2, Label lb3)
        {
            InitializeComponent();
            m = day;
            n = k;
            p = pn;
            mon = month;

            l1 = lb1;
            l2 = lb2;
            l3 = lb3;
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {
            label1.Text = m.ToString();
            //3amaliya li kat7seb x7al mn miting
            label2.Text = "0";
            //------------------------
            if (m == DateTime.Now.Day && mon == DateTime.Now.Month)
            {
                label1.ForeColor = Color.FromArgb(251, 52, 103);
                label2.ForeColor = Color.FromArgb(163, 82, 103);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            p.Controls.Clear();
            add_new at = new add_new();
            at.TopLevel = false;
            p.Controls.Add(at);
            at.Dock = DockStyle.Fill;
            l2.Text = label1.Text+".";
            at.Show();
        }
    }
}
