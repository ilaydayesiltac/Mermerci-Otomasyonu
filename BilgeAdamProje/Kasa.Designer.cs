namespace BilgeAdamProje
{
    partial class Kasa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXTKasaAdi = new System.Windows.Forms.TextBox();
            this.TXTBasBakiye = new System.Windows.Forms.TextBox();
            this.TXTKasaAciklama = new System.Windows.Forms.TextBox();
            this.TXTGiderKategori = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTKasaAdi
            // 
            this.TXTKasaAdi.Location = new System.Drawing.Point(327, 106);
            this.TXTKasaAdi.Name = "TXTKasaAdi";
            this.TXTKasaAdi.Size = new System.Drawing.Size(100, 22);
            this.TXTKasaAdi.TabIndex = 0;
            // 
            // TXTBasBakiye
            // 
            this.TXTBasBakiye.Location = new System.Drawing.Point(327, 168);
            this.TXTBasBakiye.Name = "TXTBasBakiye";
            this.TXTBasBakiye.Size = new System.Drawing.Size(100, 22);
            this.TXTBasBakiye.TabIndex = 0;
            // 
            // TXTKasaAciklama
            // 
            this.TXTKasaAciklama.Location = new System.Drawing.Point(327, 221);
            this.TXTKasaAciklama.Name = "TXTKasaAciklama";
            this.TXTKasaAciklama.Size = new System.Drawing.Size(100, 22);
            this.TXTKasaAciklama.TabIndex = 0;
            // 
            // TXTGiderKategori
            // 
            this.TXTGiderKategori.Location = new System.Drawing.Point(327, 282);
            this.TXTGiderKategori.Name = "TXTGiderKategori";
            this.TXTGiderKategori.Size = new System.Drawing.Size(100, 22);
            this.TXTGiderKategori.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "KASA ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAŞLANGIÇ BAKİYESİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "AÇIKLAMA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "GİDER KATEGORİSİ:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(975, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 65);
            this.button2.TabIndex = 3;
            this.button2.Text = "KASA GÖRÜNTÜLEME";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(975, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 65);
            this.button3.TabIndex = 3;
            this.button3.Text = "KASA İŞLEMLERİ GÖRÜNTÜLEME";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(975, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "GİDER KATEGORİLERİ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Kasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 605);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTGiderKategori);
            this.Controls.Add(this.TXTKasaAciklama);
            this.Controls.Add(this.TXTBasBakiye);
            this.Controls.Add(this.TXTKasaAdi);
            this.Name = "Kasa";
            this.Text = "Kasa";
            this.Load += new System.EventHandler(this.Kasa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTKasaAdi;
        private System.Windows.Forms.TextBox TXTBasBakiye;
        private System.Windows.Forms.TextBox TXTKasaAciklama;
        private System.Windows.Forms.TextBox TXTGiderKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}