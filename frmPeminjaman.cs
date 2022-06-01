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
    public partial class frmPeminjaman : Form
    {
        koneksi sambung;
        string sql;
        MySqlCommand query;

        MySqlConnection mysqlcon = new MySqlConnection(@"server=localhost;user id=root;database=perpus");
        
        public frmPeminjaman()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sambung = new koneksi();
            sql = "insert into transaksi(id_transaksi,nim,isbn,tgl_peminjaman,tgl_kembali) value('" + transaksi.Text + "','" + nimBox.Text + "','" + isbnBox.Text + "','" + tglPinjam.Text + "','" + deadline.Text + "')";

            try
            {
                sambung.buka();
                query = new MySqlCommand(sql, sambung.konek);
                query.ExecuteNonQuery();
                MessageBox.Show("Data Anda berhasil di submit", "informasi");
                nimBox.Clear();
                transaksi.Clear();
                isbnBox.Clear();
               
                tglPinjam.ResetText();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            sambung.tutup();




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void yellowbar2_Click(object sender, EventArgs e)
        {

        }

        private void frmPeminjaman_Load(object sender, EventArgs e)
        {

        }
    }
}
