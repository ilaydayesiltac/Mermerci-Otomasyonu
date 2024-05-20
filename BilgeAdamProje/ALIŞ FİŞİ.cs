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
    public partial class ALIŞ_FİŞİ: Form
    {
        public ALIŞ_FİŞİ()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GNNVQ70O;Initial Catalog=Mermerci_Otomasyonu;Integrated Security=True");

        private void button6_Click(object sender, EventArgs e)
        {
            string odemeYontemi = "";
            if (RDBTNNAKİT.Checked)
            {
                odemeYontemi = "NAKİT";
            }
            else if (RDBTONKREDİ.Checked)
            {
                odemeYontemi = "KREDİ KARTI";
            }
            else
            {
                MessageBox.Show("Lütfen ödeme yöntemini seçiniz.");
                return; // Ödeme yöntemi seçilmediğinde işlemi durdur.
            }

            baglanti.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO ALIŞ_FİŞİ (urunadi, miktar, birimfiyati, toplamfiyat, ödemeyöntemi) VALUES (@urunadi, @miktar, @birimfiyati, @toplamfiyat, @odemeYontemi)", baglanti);
            komut.Parameters.AddWithValue("@urunadi", TXTFisUrunAd.Text);
            komut.Parameters.AddWithValue("@miktar", TXTFisMiktar.Text);
            komut.Parameters.AddWithValue("@birimfiyati", TXTFisBirim.Text);
            komut.Parameters.AddWithValue("@toplamfiyat", TXTFisToplam.Text);
            komut.Parameters.AddWithValue("@odemeYontemi", odemeYontemi); // Değişkeni burada kullanın.
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Alış Fişi Eklendi");
        }

    }
}
