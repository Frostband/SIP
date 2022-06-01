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
    public partial class formkoneksi : Form
    {
        koneksi sambung;
        
        public formkoneksi()
        {
            InitializeComponent();
        }
        
            private void button1_Click(object sender, EventArgs e)

        { 
                koneksi sambung = new koneksi();
                try
                {
                    sambung.buka();
                    MessageBox.Show("Berhasil koneksi ke data base", "informasi");
                }

                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            {
                                MessageBox.Show("koneksi gagal", "konfirmasi");
                            }

                            break;
                        case 1045:

                            {
                                MessageBox.Show("error");
                            }
                            break;
                    }
                }
            }


        }

        
    }

