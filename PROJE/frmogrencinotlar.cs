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
    public partial class frmogrencinotlar : Form
    {
        public frmogrencinotlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-QOJ02P2\SQLEXPRESS;Initial Catalog=ornek;Integrated Security=True");
        public string numara;
        private void frmogrencinotlar_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT dersad,sınav1,sınav2,sınav3,proje,ortalama,durum FROM tblnot INNER JOIN derstable on tblnot.dersid=derstable.dersid where ogrid=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", numara);
            
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
