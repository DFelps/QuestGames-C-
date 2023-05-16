using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projcarol
{
    public partial class biblio : Form
    {
        public biblio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loja loj = new loja();
            loj.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cup.Visible = true;
            among.Visible = false;
            under.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            among.Visible = true;
            cup.Visible = false;
            under.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            under.Visible = true;
            among.Visible = false;
            cup.Visible = false;
        }

        private void biblio_Activated(object sender, EventArgs e)
        {
            among.Visible = false;
            cup.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/danie/OneDrive/Documentos/My Games/Undertale v1.001/UNDERTALE.exe");
        }
    }
}
