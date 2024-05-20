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
    public partial class KasaGörüntüleme : Form
    {
        public KasaGörüntüleme()
        {
            InitializeComponent();
        }

        DataSet daset = new DataSet();
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GNNVQ70O;Initial Catalog=Mermerci_Otomasyonu;Integrated Security=True");


        private void KasaGörüntüleme_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }

        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(" select * from kasa ", baglanti);
            adtr.Fill(daset, "kasa");
            dataGridView1.DataSource = daset.Tables["kasa"];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Cells["kasaadi"].Value.ToString();
            dataGridView1.CurrentRow.Cells["baslangicbakiyesi"].Value.ToString();
            dataGridView1.CurrentRow.Cells["aciklama"].Value.ToString();
            dataGridView1.CurrentRow.Cells["giderkategorisi"].Value.ToString();

        }
    }
}
