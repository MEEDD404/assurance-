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
    public partial class Calendrier : Form
    {
        
        public Calendrier()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Calendrier_Load(object sender, EventArgs e)
        {


            label1.Text = DateTime.Now.Year.ToString();
            label2.Text = "";
            label3.Text = "";
            panel_contenar_frm.Controls.Clear();
            month mn = new month(panel_contenar_frm,label1,label2,label3);
            mn.TopLevel = false;
            panel_contenar_frm.Controls.Add(mn);
            mn.Dock = DockStyle.Fill;
            mn.Show();
        }

        private void panel_contenar_frm_Paint(object sender, PaintEventArgs e)
        {

        }
      
    }
}
