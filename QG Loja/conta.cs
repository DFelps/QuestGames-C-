using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace projcarol
{

    public partial class conta : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danie\source\repos\projcarol\projcarol\BD\Loja.mdf;Integrated Security=True;Connect Timeout=30;Integrated Security=True;";

        public conta()
        {
            InitializeComponent();


            String strSQL;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login loj = new login();
            loj.Show();
            this.Hide();
        }

        private void criar_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1; port=3306; username=root; password=; database=loja;";
            string query = "INSERT INTO usuarios(`id`, `nick`, `email`, `senha`) VALUES (NULL, '" + usuario.Text + "', '" + email.Text + "', '" + senha.Text + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                MessageBox.Show("Conta criada com sucesso");
                this.usuario.Text = "";
                this.email.Text = "";
                this.senha.Text = "";
                this.senha2.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            databaseConnection.Close();
        }
    

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
