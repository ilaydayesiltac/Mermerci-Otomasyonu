using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdamProje
{
    public partial class FİŞLER : Form
    {
        public FİŞLER()
        {
            InitializeComponent();
        }

        private void BTNAlis_Click(object sender, EventArgs e)
        {
            ALIŞ_FİŞİ listele = new ALIŞ_FİŞİ();
            listele.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SATIŞ_FİŞİ listele = new SATIŞ_FİŞİ();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ALIŞ_İADE_FİŞİ listele = new ALIŞ_İADE_FİŞİ();
            listele.ShowDialog();
        }

        private void BTNSATİSİADE_Click(object sender, EventArgs e)
        {
            SATIŞ_İADE_FİŞİ listele = new SATIŞ_İADE_FİŞİ();
            listele.ShowDialog();
        }

        private void BTNFİSHAREKET_Click(object sender, EventArgs e)
        {
            FİŞ_HAREKETLERİ listele = new FİŞ_HAREKETLERİ();
            listele.ShowDialog();
        }
    }
}
