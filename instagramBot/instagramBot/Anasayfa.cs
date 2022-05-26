using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace instagramBot
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.pnlForm.Controls.Count > 0)
                this.pnlForm.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlForm.Controls.Add(f);
            this.pnlForm.Tag = f;
            f.Show();
        }

        private void btnMenuTakip_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnMenuTakip_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnMenuTakip_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMenuTakip_Click(object sender, EventArgs e)
        {
            loadform(new TakipForm());
        }

        private void btnMenuMesaj_Click(object sender, EventArgs e)
        {
            loadform(new MesajForm());
        }

        private void btnMenuYorum_Click(object sender, EventArgs e)
        {
            loadform(new YorumForm());
        }

        private void btnMenuIslem_Click(object sender, EventArgs e)
        {
            loadform(new IslemForm());
        }
    }
}
