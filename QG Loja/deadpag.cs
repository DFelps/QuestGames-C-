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
    public partial class deadpag : Form
    {
        public deadpag()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loja loj = new loja();
            loj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            deadcomp loj = new deadcomp();
            loj.Show();
            this.Hide();
        }
    }
}
