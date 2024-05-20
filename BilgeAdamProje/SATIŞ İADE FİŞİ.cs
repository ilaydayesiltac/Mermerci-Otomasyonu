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
    public partial class SATIŞ_İADE_FİŞİ : Form
    {
        public SATIŞ_İADE_FİŞİ()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GNNVQ70O;Initial Catalog=Mermerci_Otomasyonu;Integrated Security=True");


        private void BTNSATİSİADE_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into SATIŞ_İADE_FİŞİ (tarih,müsteriadi,urunadi,miktar,birimfiyati,toplamfiyat) values(@tarih, @müsteriadi, @urunadi, @miktar, @birimfiyati, @toplamfiyat)", baglanti);
            komut.Parameters.AddWithValue("@tarih", TXTTarihSİ.Text);
            komut.Parameters.AddWithValue("@müsteriadi", TXTMüsSİ.Text);
            komut.Parameters.AddWithValue("@urunadi", TXTUrunSİ.Text);
            komut.Parameters.AddWithValue("@miktar", TXTMikSİ.Text);
            komut.Parameters.AddWithValue("@birimfiyati", TXTBirSİ.Text);
            komut.Parameters.AddWithValue("@toplamfiyat", TXTTopSİ.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Satış Fişi Eklendi");
        }
    }
}
