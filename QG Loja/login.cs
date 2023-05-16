using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace projcarol
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = usuario.Text;
            string pass = senha.Text;

            string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database=loja;";
            string query = "SELECT * FROM usuarios where nick='" + usuario.Text + "' AND senha='" + senha.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Login realizado com sucesso");
                loja loj = new loja();
                loj.Show();
                this.Hide();
                this.usuario.Text = "";
                this.senha.Text = "";
            }

            catch (Exception ex)
            {
            
            }
            databaseConnection.Close();
        



    }

        private void button2_Click(object sender, EventArgs e)
        {
            conta loj = new conta();
            loj.Show();
            this.Hide();
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
