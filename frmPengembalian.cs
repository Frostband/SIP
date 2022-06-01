using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace SIP
{
    
    public partial class frmPengembalian : Form
    {
        koneksi sambungan;
        string sql;
        MySqlCommand query;
        public frmPengembalian()
        {
            InitializeComponent();
        }

        private void frmPengembalian_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            sambungan = new koneksi();
            sql = "UPDATE `transaksi` SET `nim`='"+this.nimBox.Text+"',isbn ='"+this.isbnBox.Text+"',`tgl_dikembalikan`='"+this.tglBalik.Text+ "' Where  `id_transaksi`='" + this.TransaksiBox.Text + "' ";
            try
            {
                sambungan.buka();
                query = new MySqlCommand(sql, sambungan.konek);
                query.ExecuteNonQuery();
                MessageBox.Show("Data Anda berhasil di submit", "informasi");
                TransaksiBox.Clear();
                nimBox.Clear();
                isbnBox.Clear();
                tglBalik.ResetText();
               
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            sambungan.tutup();

        }

        private void yellowbar_Click(object sender, EventArgs e)
        {

        }
    }
}
