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
    public partial class loja : Form
    {
        public loja()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            deadpag loj = new deadpag();
            loj.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            deadcomp loj = new deadcomp();
            loj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            underpag loj = new underpag();
            loj.Show();
            this.Hide();
        }

        private void loja_Activated(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            button7.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            button7.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            biblio loj = new biblio();
            loj.Show();
            this.Hide();
        }
    }
}
