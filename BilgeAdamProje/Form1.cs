using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdamProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cARİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            STOKLAR ekle = new STOKLAR();
            ekle.ShowDialog();
        }

        private void fİŞLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FİŞLER listele = new FİŞLER();
            listele.ShowDialog();
        }

        private void fİŞLERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CEK_GİRİS_CİKİS listele = new CEK_GİRİS_CİKİS();
            listele.ShowDialog();
        }

        private void kASAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kasa listele = new Kasa();
            listele.ShowDialog();
            
        }

        private void pLAKAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlakaveBlok listele = new PlakaveBlok();
            listele.ShowDialog();
        }

        private void sTOKLARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cari listele = new Cari();
            listele.ShowDialog();
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaSayfa listele = new AnaSayfa();
            listele.ShowDialog();
        }

        private void tANIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tanım listele = new Tanım();
            listele.ShowDialog();
        }
    }
}
