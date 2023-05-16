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
    public partial class deadcomp : Form
    {
        public deadcomp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loja loj = new loja();
            loj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
        }

        private void deadcomp_Activated(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            button3.Visible = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loja loj = new loja();
            loj.Show();
            this.Hide();
        }
    }
}
