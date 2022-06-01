using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SIP
{
    class koneksi
    {
        string alamat = "server = localhost; uid = root; database = perpus;pwd =''";
        public MySqlConnection konek;

        public void buka()
        {
            konek = new MySqlConnection(alamat);
            konek.Open();
        }
        public void tutup()
        {
            konek = new MySqlConnection(alamat);
            konek.Close();
        }
    }
}

