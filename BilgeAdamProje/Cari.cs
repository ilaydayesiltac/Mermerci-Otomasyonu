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
    public partial class Cari : Form
    {
        public Cari()
        {
            InitializeComponent();
        }
        DataSet daset = new DataSet();
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GNNVQ70O;Initial Catalog=Mermerci_Otomasyonu;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into cari(firmaadi,vergino,iletisim,adres)values (@firmaadi,@vergino,@iletisim,@adres)", baglanti);
            komut.Parameters.AddWithValue("@firmaadi", TXTCariFirma.Text);
            komut.Parameters.AddWithValue("@vergino" , TXTCariVergi.Text);
            komut.Parameters.AddWithValue("@iletisim" , TXTCariIletisim.Text);
            komut.Parameters.AddWithValue("@adres", TXTCariAdres.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Cari kart eklendi");

        }

        private void Cari_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }

        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from cari ", baglanti);
            adtr.Fill(daset, "cari");
            dataGridView1.DataSource = daset.Tables["cari"];
            baglanti.Close() ;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Cells["firmaadi"].Value.ToString();
            dataGridView1.CurrentRow.Cells["vergino"].Value.ToString();
            dataGridView1.CurrentRow.Cells["iletisim"].Value.ToString();
            dataGridView1.CurrentRow.Cells["adres"].Value.ToString();
        }
    }
}
