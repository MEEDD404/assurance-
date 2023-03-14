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
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

       

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Label l1 = (Label)sender;
            l1.BackColor = Color.FromArgb(39, 40, 42);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Label l1 = (Label)sender;
            l1.BackColor = Color.FromArgb(29, 31, 32);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.CenterToScreen();
            }

            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.CenterToScreen();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void app_Load(object sender, EventArgs e)
        {
            panel_form.Controls.Clear();
            home at = new home();
            at.TopLevel = false;
            panel_form.Controls.Add(at);
            at.Dock = DockStyle.Fill;
            at.Show();
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            if (button_home.BackColor == Color.FromArgb(29, 31, 32)) { 
            button_home.BackColor = Color.FromArgb(39, 40, 42);
            button_Calendrier.BackColor = Color.FromArgb(29, 31, 32);
            button_add_new.BackColor = Color.FromArgb(29, 31, 32);
            panel_form.Controls.Clear();
            home at = new home();
            at.TopLevel = false;
            panel_form.Controls.Add(at);
            at.Dock = DockStyle.Fill;
            at.Show();
            }
        }

        private void button_Calendrier_Click(object sender, EventArgs e)
        {
            if (button_Calendrier.BackColor == Color.FromArgb(29, 31, 32))
            {
                button_Calendrier.BackColor = Color.FromArgb(39, 40, 42);
                button_home.BackColor = Color.FromArgb(29, 31, 32);
                button_add_new.BackColor = Color.FromArgb(29, 31, 32);
                panel_form.Controls.Clear();
                Calendrier at = new Calendrier();
                at.TopLevel = false;
                panel_form.Controls.Add(at);
                at.Dock = DockStyle.Fill;
                at.Show();
                
            }
        }

        private void button_add_new_Click(object sender, EventArgs e)
        {
            if (button_add_new.BackColor == Color.FromArgb(29, 31, 32))
            {
                button_add_new.BackColor = Color.FromArgb(39, 40, 42);
                button_home.BackColor = Color.FromArgb(29, 31, 32);
                button_Calendrier.BackColor = Color.FromArgb(29, 31, 32);
                panel_form.Controls.Clear();
                add_new at = new add_new();
                at.TopLevel = false;
                panel_form.Controls.Add(at);
                at.Dock = DockStyle.Fill;
                at.Show();
            }
        }
    }
}
