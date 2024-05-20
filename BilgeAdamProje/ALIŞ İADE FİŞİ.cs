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
    public partial class ALIŞ_İADE_FİŞİ : Form
    {
        public ALIŞ_İADE_FİŞİ()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GNNVQ70O;Initial Catalog=Mermerci_Otomasyonu;Integrated Security=True");

        private void BTNKAYDETALİSİADE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO ALIŞ_İADE_FİŞİ (tarih, tedarikciadi, urunadi, miktar, birimfiyati, toplamfiyat) VALUES (@tarih, @tedarikciadi, @urunadi, @miktar, @birimfiyati, @toplamfiyat)", baglanti);
            komut.Parameters.AddWithValue("@tarih", TXTTarihAİ.Text);
            komut.Parameters.AddWithValue("@tedarikciadi", TXTTedAd.Text);
            komut.Parameters.AddWithValue("@urunadi", TXTUrunAİ.Text);
            komut.Parameters.AddWithValue("@miktar", TXTMikAİ.Text);
            komut.Parameters.AddWithValue("@birimfiyati", TXTBirAİ.Text);
            komut.Parameters.AddWithValue("@toplamfiyat", TXTTopAİ.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Alış İade Fişi Eklendi");
        }
    }
}
