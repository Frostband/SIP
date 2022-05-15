using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIP
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKeluar_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadform(new frmHome());
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            loadform(new frmPeminjaman());
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            loadform(new frmPengembalian());
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            loadform(new frmHome());
            sidemenuloadform1(new frmSideMenu1());
        }

        public void sidemenuloadform1(object Form)
        {
            if (this.panelMenu.Controls.Count > 0)
                this.panelMenu.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMenu.Controls.Add(f);
            this.panelMenu.Tag = f;
            f.Show();
        }
        int a = 0;
        private void btnSideMenuSwitch_Click(object sender, EventArgs e)
        {
            if (btnSideMenuSwitch.Click)
              int a++;
            sidemenuloadform(new frmSideMenu2());
            if (btnSideMenuSwitch.Click.) 
                sidemenuloadform1(new frmSideMenu1());
            
        }
    }
}
