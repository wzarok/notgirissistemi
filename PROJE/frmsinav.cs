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
    public partial class frmsinav : Form
    {
        public frmsinav()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.tblnotTableAdapter ds = new DataSet1TableAdapters.tblnotTableAdapter();
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QOJ02P2\SQLEXPRESS;Initial Catalog=ornek;Integrated Security=True");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmsinav_Load(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From derstable", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbders.DataSource = dt;
            
            cmbders.DisplayMember = "dersad";
            cmbders.ValueMember = "dersid";
            baglanti.Close();
        }
        int notid;
        private void btnara_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.notlistesi(int.Parse(txtid.Text));

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            notid=int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txts1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txts2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txts3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtpro.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtort.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtdurum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }
        int s1, s2, s3, pro;

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        double ort;
        private void btnhesap_Click(object sender, EventArgs e)
        {
           
            //string durum;
            s1 = Convert.ToInt16(txts1.Text);
            s2 = Convert.ToInt16(txts2.Text);
            s3 = Convert.ToInt16(txts3.Text);
            pro = Convert.ToInt16(txtpro.Text);
            ort = (s1 + s2 + s3 + pro) / 4;
            txtort.Text = ort.ToString();
            if (ort >= 50)
            {
                txtdurum.Text = "True";
            }
            else
            {
                txtdurum.Text = "False";
            }
        }

        private void btngun_Click(object sender, EventArgs e)
        {
            ds.notguncelle(byte.Parse(cmbders.SelectedValue.ToString()), int.Parse(txtid.Text), byte.Parse(s1.ToString()),byte.Parse( s2.ToString()), byte.Parse(s3.ToString()),byte.Parse( pro.ToString()), decimal.Parse(ort.ToString()),bool.Parse(txtdurum.Text),notid);
            dataGridView1.DataSource = ds.notlistesi(int.Parse(txtid.Text));
        }
    }
}
