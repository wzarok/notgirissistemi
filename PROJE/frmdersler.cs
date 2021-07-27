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
    public partial class frmdersler : Form
    {
        public frmdersler()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.derstableTableAdapter ds = new DataSet1TableAdapters.derstableTableAdapter();
        private void frmdersler_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = ds.derslistele();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ds.dersekle(txtklpad.Text);
            MessageBox.Show("Ders Başarıyla eklendi");
            dataGridView1.DataSource = ds.derslistele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.derslistele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.derssil(byte.Parse(txtklpid.Text));
            MessageBox.Show("DERS BAŞARILI BİR BİÇİMDE SİLİNDİ");
            dataGridView1.DataSource = ds.derslistele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.dersguncelle(txtklpad.Text,byte.Parse(txtklpid.Text));
            MessageBox.Show("DERS BAŞARILI BİR BİÇİMDE GÜNCELLENDİ");
            dataGridView1.DataSource = ds.derslistele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtklpid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtklpad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
