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
    public partial class SATIŞ_FİŞİ : Form
    {
        public SATIŞ_FİŞİ()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GNNVQ70O;Initial Catalog=Mermerci_Otomasyonu;Integrated Security=True");

        private void BTNKAYDETSATİS_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into SATIŞ_FİŞİ (tarih,müsteriadi,urunadi,miktar,birimfiyati,toplamfiyat) values(@tarih, @müsteriadi, @urunadi, @miktar, @birimfiyati, @toplamfiyat)", baglanti);
            komut.Parameters.AddWithValue("@tarih", TXTTarih.Text);
            komut.Parameters.AddWithValue("@müsteriadi", TXTMüsteri.Text);
            komut.Parameters.AddWithValue("@urunadi", TXTÜrün.Text);
            komut.Parameters.AddWithValue("@miktar", TXTMiktar.Text);
            komut.Parameters.AddWithValue("@birimfiyati", TXTBirimSatis.Text);
            komut.Parameters.AddWithValue("@toplamfiyat", TXTTopSatis.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış Fişi Eklendi");
        }
    }
}
