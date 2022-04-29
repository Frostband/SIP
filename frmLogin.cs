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
using System.Data.SqlClient;

namespace SIP
{
    public partial class frmLogin : Form
    {
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; database = sip;");
        

        public frmLogin()
        {
            InitializeComponent();
        }

        private void checkbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPas.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txtUsername.Text;
            user_password = txtPassword.Text;

            try
            {
                String querry = "SELECT * FROM staff WHERE username = '"+txtUsername.Text+"' AND password = '"+txtPassword.Text+"'";
                MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if(dTable.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    user_password = txtPassword.Text;

                    frmHome form = new frmHome();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Clear();
                    txtPassword.Clear();

                    txtUsername.Focus();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            txtUsername.Focus();
        }
    }
}
