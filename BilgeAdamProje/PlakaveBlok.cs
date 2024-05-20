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
    public partial class PlakaveBlok : Form
    {
        public PlakaveBlok()
        {
            InitializeComponent();
        }
        DataSet daset = new DataSet();
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GNNVQ70O;Initial Catalog=Mermerci_Otomasyonu;Integrated Security=True");


        private void PlakaveBlok_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
            Kayıt_Gösterr();
        }

        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from plaka ", baglanti);
            adtr.Fill(daset, "plaka");
            dataGridView2.DataSource = daset.Tables["plaka"]; baglanti.Close();
        }



        private void Kayıt_Gösterr()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from blok ", baglanti);
            adtr.Fill(daset, "blok");
            dataGridView1.DataSource = daset.Tables["blok"]; baglanti.Close();
        }

        private void BTNPlakaKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into plaka(plakano,plakatipi,plakarengi,plakafiyat,plakastok) values (@plakano,@plakatipi,@plakarengi,@plakafiyat,@plakastok)", baglanti);
            komut.Parameters.AddWithValue("@plakano", TXTPlakaNo.Text);
            komut.Parameters.AddWithValue("@plakatipi" , TXTPlakaTipi.Text);
            komut.Parameters.AddWithValue("@plakarengi", TXTPlakaRenk.Text);
            komut.Parameters.AddWithValue("@plakafiyat", TXTPlakaFiyat.Text);
            komut.Parameters.AddWithValue("@plakastok", TXTPlakaStok.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Plaka kayıdı eklendi");

        }

        private void BTNBlokKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into blok(blokno,bloktipi,blokrengi,blokfiyat,blokstok) values (@blokno,@bloktipi,@blokrengi,@blokfiyat,@blokstok)", baglanti);
            komut.Parameters.AddWithValue("@blokno", TXTBlokNo.Text);
            komut.Parameters.AddWithValue("@bloktipi", TXTBlokTip.Text);
            komut.Parameters.AddWithValue("@blokrengi", TXTBlokRenk.Text);
            komut.Parameters.AddWithValue("@blokfiyat", TXTBlokFiyat.Text);
            komut.Parameters.AddWithValue("@blokstok", TXTBlokStok.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Blok kaydı eklendi");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.CurrentRow.Cells["@plakano"].Value.ToString();
            dataGridView2.CurrentRow.Cells["@plakatipi"].Value.ToString();
            dataGridView2.CurrentRow.Cells["@plakarengi"].Value.ToString();
            dataGridView2.CurrentRow.Cells["@plakafiyat"].Value.ToString();
            dataGridView2.CurrentRow.Cells["@plakastok"].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            dataGridView1.CurrentRow.Cells["@blokno"].Value.ToString();
            dataGridView1.CurrentRow.Cells["@bloktipi"].Value.ToString();
            dataGridView1.CurrentRow.Cells["@blokrengi"].Value.ToString();
            dataGridView1.CurrentRow.Cells["@blokfiyat"].Value.ToString();
            dataGridView1.CurrentRow.Cells["@blokstok"].Value.ToString();


        }
    }
}
