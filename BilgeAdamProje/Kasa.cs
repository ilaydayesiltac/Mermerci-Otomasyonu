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
    public partial class Kasa : Form
    {
        public Kasa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KasaGörüntüleme listele = new KasaGörüntüleme();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KasaIslemleri listele = new KasaIslemleri();
            listele.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GiderKategorileri listele = new GiderKategorileri();
            listele.ShowDialog();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GNNVQ70O;Initial Catalog=Mermerci_Otomasyonu;Integrated Security=True");

        private void Kasa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kasa(kasaadi,baslangicbakiyesi,aciklama,giderkategorisi) values (@kasaadi,@baslangicbakiyesi,@aciklama,@giderkategorisi)", baglanti);
            komut.Parameters.AddWithValue("@kasaadi", TXTKasaAdi.Text);
            komut.Parameters.AddWithValue("@baslangicbakiyesi" , TXTBasBakiye.Text);
            komut.Parameters.AddWithValue("@aciklama" , TXTKasaAciklama.Text);
            komut.Parameters.AddWithValue("@giderkategorisi" , TXTGiderKategori.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kasa bilgileri eklendi");
            
        }
    }
}
