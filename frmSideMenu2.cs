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
    public partial class frmSideMenu2 : Form
    {
        public frmSideMenu2()
        {
            InitializeComponent();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<frmDashboard>().Single();
            mainForm.btnLaporan();
        }

        private void frmSideMenu2_Load(object sender, EventArgs e)
        {

        }
    }
}
