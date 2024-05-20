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
    public partial class FİŞ_HAREKETLERİ : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-GNNVQ70O;Initial Catalog=Mermerci_Otomasyonu;Integrated Security=True");
        
        DataSet daset = new DataSet();

        public object TxtFisUrunAd { get; private set; }

        public FİŞ_HAREKETLERİ()
        {
            InitializeComponent();
        }


        private void FİŞ_HAREKETLERİ_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }

        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter(" select * from ALIŞ_FİŞİ ", baglanti);
            adtr.Fill(daset, "ALIŞ_FİŞİ");
            dataGridView1.DataSource = daset.Tables["ALIŞ_FİŞİ"];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            dataGridView1.CurrentRow.Cells["miktar"].Value.ToString();
            dataGridView1.CurrentRow.Cells["birimfiyati"].Value.ToString();
            dataGridView1.CurrentRow.Cells["toplamfiyat"].Value.ToString();
            dataGridView1.CurrentRow.Cells["odemeyontemi"].Value.ToString();



        }
    }
}
