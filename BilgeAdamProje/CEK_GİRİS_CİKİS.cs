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
    public partial class CEK_GİRİS_CİKİS : Form
    {
        public CEK_GİRİS_CİKİS()
        {
            InitializeComponent();
        }

        DataSet daset = new DataSet();
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GNNVQ70O;Initial Catalog=Mermerci_Otomasyonu;Integrated Security=True");


        private void BTNCEKKYDT_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into CEK_GİRİS_CİKİS(ad_soyad,firma_adi,adresi,telefon,cek_numarasi,cek_tarihi,cek_miktari,vade_tarihi,banka,teminat,aciklama)values(@ad_soyad,@firma_adi,@adresi,@telefon,@cek_numarasi,@cek_tarihi,@cek_miktari,@vade_tarihi,@banka,@teminat,@aciklama)", baglanti);
            komut.Parameters.AddWithValue("@ad_soyad", TXTAdCek.Text);
            komut.Parameters.AddWithValue("@firma_adi" , TXTFirmaCek.Text);
            komut.Parameters.AddWithValue("@adresi", TXTAdresCek.Text);
            komut.Parameters.AddWithValue("@telefon", TXTTelefonCek.Text);
            komut.Parameters.AddWithValue("@cek_numarasi", TXTCekNo.Text);
            komut.Parameters.AddWithValue("@cek_tarihi", TXTTarih.Text);
            komut.Parameters.AddWithValue("@cek_miktari", TXTMiktar.Text);
            komut.Parameters.AddWithValue("@vade_tarihi", TXTVade.Text);
            komut.Parameters.AddWithValue("@banka", TXTBanka.Text);
            komut.Parameters.AddWithValue("@teminat", TXTTeminat.Text);
            komut.Parameters.AddWithValue("@aciklama", TXTAciklama.Text);
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Çek Eklendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }



        }

        private void CEK_GİRİS_CİKİS_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }

        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from CEK_GİRİS_CİKİS", baglanti);
            adtr.Fill(daset, "CEK_GİRİS_CİKİS");
            dataGridView1.DataSource = daset.Tables["CEK_GİRİS_CİKİS"];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Cells["ad_soyad"].Value.ToString();
            dataGridView1.CurrentRow.Cells["firma_adi"].Value.ToString();
            dataGridView1.CurrentRow.Cells["adresi"].Value.ToString();
            dataGridView1.CurrentRow.Cells["telefon"].Value.ToString();
            dataGridView1.CurrentRow.Cells["cek_numarasi"].Value.ToString();
            dataGridView1.CurrentRow.Cells["cek_tarihi"].Value.ToString();
            dataGridView1.CurrentRow.Cells["cek_miktari"].Value.ToString();
            dataGridView1.CurrentRow.Cells["vade_tarihi"].Value.ToString();
            dataGridView1.CurrentRow.Cells["banka"].Value.ToString();
            dataGridView1.CurrentRow.Cells["teminat"].Value.ToString();
            dataGridView1.CurrentRow.Cells["aciklama"].Value.ToString();
        }
    }
}
