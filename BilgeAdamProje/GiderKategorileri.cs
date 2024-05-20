using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdamProje
{
    public partial class GiderKategorileri : Form
    {
        public GiderKategorileri()
        {
            InitializeComponent();
        }
        DataSet daset = new DataSet();
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GNNVQ70O;Initial Catalog=Mermerci_Otomasyonu;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into gider(kategori,aciklama) values(@kategori,@aciklama)", baglanti);
            komut.Parameters.AddWithValue("@kategori", TXTKategori.Text);
            komut.Parameters.AddWithValue("@aciklama", TXTGiderAciklama.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Gider Kategorileri Eklendi");


        }

        private void GiderKategorileri_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }

        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from giderkategori", baglanti);
            adtr.Fill(daset, "giderkategori");
            dataGridView1.DataSource = daset.Tables["giderkategori"];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            dataGridView1.CurrentRow.Cells["aciklama"].Value.ToString();
        }
    }
}
