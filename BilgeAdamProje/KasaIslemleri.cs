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
    public partial class KasaIslemleri : Form
    {
        public KasaIslemleri()
        {
            InitializeComponent();
        }

        DataSet daset = new DataSet();
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GNNVQ70O;Initial Catalog=Mermerci_Otomasyonu;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into islem(islemtarihi,islemtürü,tutar,aciklama) values (@islemtarihi, @islemtürü,@tutar,@aciklama)", baglanti);
            komut.Parameters.AddWithValue("@islemtarihi" , TXTIslemTarihi.Text );
            komut.Parameters.AddWithValue("@islemtürü" , TXTIslemTuru.Text );
            komut.Parameters.AddWithValue("@tutar" , TXTTutar.Text );
            komut.Parameters.AddWithValue("@aciklama" , TXTKasaIslemAciklama.Text );
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kasa işlemi eklendi");

        }

        private void KasaIslemleri_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }

        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from cari ", baglanti);
            adtr.Fill(daset, "kasaislem");
            dataGridView1.DataSource = daset.Tables["kasaislem"];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Cells["islemtarihi"].Value.ToString();
            dataGridView1.CurrentRow.Cells["islemtürü"].Value.ToString();
            dataGridView1.CurrentRow.Cells["tutar"].Value.ToString();
            dataGridView1.CurrentRow.Cells["aciklama"].Value.ToString();
        }
    }
}
