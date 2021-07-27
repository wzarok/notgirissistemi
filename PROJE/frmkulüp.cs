using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJE
{
    public partial class frmkulüp : Form
    {
        public frmkulüp()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QOJ02P2\SQLEXPRESS;Initial Catalog=ornek;Integrated Security=True");
       void liste()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM klptable", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void frmkulüp_Load(object sender, EventArgs e)
        {
            liste();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO klptable (klpad) VALUES (@P1)", baglanti);
            komut.Parameters.AddWithValue("@P1", txtklpad.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kulüp Listeye Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtklpid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtklpad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM klptable WHERE klpid=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", txtklpid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Gerçekleşti");
            liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE klptable SET klpad=@P1 WHERE klpid=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", txtklpad.Text);
            komut.Parameters.AddWithValue("@P2", txtklpid.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Gerçekleşti");
            liste();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
