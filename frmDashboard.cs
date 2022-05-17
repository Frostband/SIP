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
        int a;

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

        public void btnHome()
        {
            loadform(new frmHome());
        }

        public void btnPeminjaman()
        {
            loadform(new frmPeminjaman());
        }

        public void btnPengembalian()
        {
            loadform(new frmPengembalian());
        }

        public void btnLaporan()
        {
            loadform(new frmLaporan());
        }     

        private void btnKeluar_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            loadform(new frmHome());
            sidemenuloadform(new frmSideMenu1());
        }

        public void sidemenuloadform(object Form)
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
        private void btnSideMenuSwitch_Click(object sender, EventArgs e)
        {
            a++;
            if (a % 2 != 0)
            {
                sidemenuloadform(new frmSideMenu2());
            }
            else
            {
                sidemenuloadform(new frmSideMenu1());
            }          
        }       
    }
}
