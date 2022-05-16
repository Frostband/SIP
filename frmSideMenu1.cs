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
    public partial class frmSideMenu1 : Form
    {
        
        public frmSideMenu1()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<frmDashboard>().Single();
            mainForm.btnHome();
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<frmDashboard>().Single();
            mainForm.btnPeminjaman();
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<frmDashboard>().Single();
            mainForm.btnPengembalian();
        }
    }
}
