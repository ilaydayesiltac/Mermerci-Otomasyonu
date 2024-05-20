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
    public partial class StokListesi : Form
    {
        public StokListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GNNVQ70O;Initial Catalog=Mermerci_Otomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void StokListesi_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }

        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from stok ", baglanti);
            adtr.Fill(daset, "stok");
            dataGridView1.DataSource = daset.Tables["stok"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtStokAd.Text = dataGridView1.CurrentRow.Cells["ad"].Value.ToString();
            TxtStokMarka.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            TxtStokModel.Text = dataGridView1.CurrentRow.Cells["model"].Value.ToString();
            TxtStokYıl.Text = dataGridView1.CurrentRow.Cells["yıl"].Value.ToString();
            TxtStokAdet.Text = dataGridView1.CurrentRow.Cells["adet"].Value.ToString();
            TxtAlisFiyat.Text = dataGridView1.CurrentRow.Cells["alışfiyatı"].Value.ToString();
            TxtSatisFiyat.Text = dataGridView1.CurrentRow.Cells["satışfiyatı"].Value.ToString();
        }
        
        private void btnStokGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" update stok set  marka=@marka, model=@model, yıl=@yıl,adet=@adet, alışfiyatı=@alışfiyatı, satışfiyatı=@satışfiyatı where ad=@ad ", baglanti); komut.Parameters.AddWithValue("@marka", TxtStokMarka.Text);
            komut.Parameters.AddWithValue("@model", TxtStokModel.Text);
            komut.Parameters.AddWithValue("@yıl", TxtStokYıl.Text);
            komut.Parameters.AddWithValue("@adet", TxtStokAdet.Text);
            komut.Parameters.AddWithValue("@alışfiyatı", TxtAlisFiyat.Text);
            komut.Parameters.AddWithValue("@satışfiyatı", TxtSatisFiyat.Text);
            komut.Parameters.AddWithValue("@ad", TxtStokAd.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["stok"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Stok Güncellendi");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void btnStokSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from stok where ad='" + dataGridView1.CurrentRow.Cells["ad"].Value.ToString() +"'" ,baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["stok"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Kayıt Silindi");

        }

        private void TxtStokAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            string arananKelime = TxtStokAra.Text; 
            string sorgu = "SELECT * FROM stok WHERE ad LIKE @arananKelime";
            using (SqlDataAdapter adtr = new SqlDataAdapter(sorgu, baglanti))
            {
                adtr.SelectCommand.Parameters.AddWithValue("@arananKelime", "%" + arananKelime + "%");
                adtr.Fill(tablo);
            }
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
