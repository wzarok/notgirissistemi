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
    public partial class fromogrenci : Form
    {
        public fromogrenci()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QOJ02P2\SQLEXPRESS;Initial Catalog=ornek;Integrated Security=True");


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void fromogrenci_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.ogrlistesi();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From klptable", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbklp.DisplayMember = "klpad";
            cmbklp.ValueMember = "klpid";
            cmbklp.DataSource = dt;
            baglanti.Close();
        }
        string c = "";
        private void button3_Click(object sender, EventArgs e)
        {
            
           
            ds.ogrekle(txtad.Text, txtsoyad.Text, byte.Parse(cmbklp.SelectedValue.ToString()),c);
            MessageBox.Show("Öğrenci Başarılı Bir Biçimde Eklendi");
            dataGridView1.DataSource = ds.ogrlistesi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.ogrlistesi();
        }

        private void cmbklp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            ds.ogrsil(int.Parse(txtid.Text));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbklp.Text = dataGridView1.Rows[e.RowIndex].Cells["klpad"].Value.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds.ogrgüncelle(txtad.Text, txtsoyad.Text, byte.Parse(cmbklp.SelectedValue.ToString()), c, int.Parse(txtid.Text));
            dataGridView1.DataSource = ds.ogrlistesi();
        }

        private void rbkadın_CheckedChanged(object sender, EventArgs e)
        {
           
            if (rbkadın.Checked == true)
            {
                c = "Kadın";
            }
        }

        private void rberkek_CheckedChanged(object sender, EventArgs e)
        {
            if (rberkek.Checked == true)
            {
                c = "Erkek";
            }
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource =ds.ogrgetir(textBox1.Text);
        }
    }
}
