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

namespace BilgeAdamProje
{
    public partial class STOKLAR : Form
    {
        public STOKLAR()
        {
            InitializeComponent();
        }

        private void STOKLAR_Load(object sender, EventArgs e)
        {
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GNNVQ70O;Initial Catalog=Mermerci_Otomasyonu;Integrated Security=True");
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnStokKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into stok(ad,marka,model,yıl,adet,alışfiyatı,satışfiyatı) values(@ad,@marka,@model,@yıl,@adet,@alışfiyatı,@satışfiyatı)",baglanti);
            komut.Parameters.AddWithValue("@ad", TxtStokAd.Text);
            komut.Parameters.AddWithValue("@marka", TxtStokMarka.Text);
            komut.Parameters.AddWithValue("@model", TxtStokModel.Text);
            komut.Parameters.AddWithValue("@yıl", TxtStokYıl.Text);
            komut.Parameters.AddWithValue("@adet", TxtStokAdet.Text);
            komut.Parameters.AddWithValue("@alışfiyatı", TxtAlisFiyat.Text);
            komut.Parameters.AddWithValue("@satışfiyatı", TxtSatisFiyat.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Stok Eklendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnStokListesi_Click(object sender, EventArgs e)
        {
            StokListesi listele = new StokListesi();
            listele.ShowDialog();
        }
    }
}
