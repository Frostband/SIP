using SIP.Properties;
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
    public partial class frmLaporan : Form
    {

        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; database = perpus;");


        MySqlConnection mysqlcon = new MySqlConnection(@"server=localhost;user id=root;database=perpus");

        public frmLaporan()
        {
            InitializeComponent();
        }



        private void frmLaporan_Load(object sender, EventArgs e)
        {

        }

        private void transaksi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String id_transaksi;

            id_transaksi = transaksi.Text;


            try
            {
                String querry = "SELECT * FROM `transaksi` WHERE id_transaksi ='" + this.transaksi.Text + "' ";
                MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    id_transaksi = transaksi.Text;


                    MessageBox.Show("Lihat catatan laporan ");
                    transaksi.Clear();
                    dataGridView1.DataSource = dTable;
                }
                else
                {
                    MessageBox.Show("ID Transaksi salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaksi.Clear();



                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsemua_Click(object sender, EventArgs e)
        {

        }

        private void btnsemua_Click_1(object sender, EventArgs e)
        {
            try
            {
                String querry = "SELECT * FROM `transaksi`  ";
                MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {



                    MessageBox.Show("Lihat semua catatan laporan ");
                    transaksi.Clear();
                    dataGridView1.DataSource = dTable;
                }
                else
                {
                    MessageBox.Show("ID Transaksi tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    transaksi.Clear();



                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }


        }

        private void btnhapus_Click(object sender, EventArgs e)
        {

            dataGridView1 = new DataGridView();
                
            }

        private void btnhapus_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
        }
    }
    }

