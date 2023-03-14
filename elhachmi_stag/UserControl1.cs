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
    public partial class UserControl1 : UserControl
    {
        int m;
        Form n;
        Panel p;

        Label l1;
        Label l2;
        Label l3;

        public UserControl1(int month, Form k, Panel pn, Label lb1, Label lb2, Label lb3)
        {
            InitializeComponent();
            m = month;
            n=k;
            p = pn;
            l1 = lb1;
            l2 = lb2;
            l3 = lb3;
        }

        private void UserControl1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(58, 59, 61);
        }

        private void UserControl1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(49, 50, 52);

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            string[] txtm = { "janvier", "février", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "décembre" };
            label1.Text = txtm[m-1];
            label2.Text = m.ToString();
            if (m == DateTime.Now.Month)
            {
                label1.ForeColor = Color.FromArgb(251, 52, 103);
                label2.ForeColor = Color.FromArgb(163, 82, 103);
            }
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

          
           
            p.Controls.Clear();
            days at = new days(p,int.Parse(l1.Text),m,l1,l2,l3);
            at.TopLevel = false;
            p.Controls.Add(at);
            at.Dock = DockStyle.Fill;
            l3.Text = "."+l1.Text;
            l1.Text = label1.Text;
            
            at.Show();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
