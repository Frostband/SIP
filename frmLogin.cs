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
        MySqlConnection conn = new MySqlConnection("server = localhost; uid = root; database = perpus;");
        

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
                String querry = "SELECT * FROM admin WHERE username = '"+txtUsername.Text+"' AND password = '"+txtPassword.Text+"'";
                MySqlDataAdapter sda = new MySqlDataAdapter(querry, conn);

                DataTable dTable = new DataTable();
                sda.Fill(dTable);

                if(dTable.Rows.Count > 0)
                {
                    username = txtUsername.Text;
                    user_password = txtPassword.Text;

                    MessageBox.Show("Berhasil Login", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmDashboard form = new frmDashboard();
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            txtUsername.Focus();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

       

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPassword.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
