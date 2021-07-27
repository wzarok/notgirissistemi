using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJE
{
    public partial class frmogretmen : Form
    {
        public frmogretmen()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmkulüp fr = new frmkulüp();
            fr.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmdersler fr = new frmdersler();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fromogrenci fr = new fromogrenci();
            fr.Show();
        }

        private void frmogretmen_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmsinav fr = new frmsinav();
            fr.Show();
        }
    }
}
