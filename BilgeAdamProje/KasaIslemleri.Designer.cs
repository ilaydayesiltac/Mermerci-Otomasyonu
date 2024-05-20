namespace BilgeAdamProje
{
    partial class KasaIslemleri
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
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTKasaIslemAciklama = new System.Windows.Forms.TextBox();
            this.TXTTutar = new System.Windows.Forms.TextBox();
            this.TXTIslemTuru = new System.Windows.Forms.TextBox();
            this.TXTIslemTarihi = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "TUTAR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "AÇIKLAMA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "İŞLEM TÜRÜ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "İŞLEM TARİHİ:";
            // 
            // TXTKasaIslemAciklama
            // 
            this.TXTKasaIslemAciklama.Location = new System.Drawing.Point(247, 273);
            this.TXTKasaIslemAciklama.Name = "TXTKasaIslemAciklama";
            this.TXTKasaIslemAciklama.Size = new System.Drawing.Size(100, 22);
            this.TXTKasaIslemAciklama.TabIndex = 3;
            // 
            // TXTTutar
            // 
            this.TXTTutar.Location = new System.Drawing.Point(247, 212);
            this.TXTTutar.Name = "TXTTutar";
            this.TXTTutar.Size = new System.Drawing.Size(100, 22);
            this.TXTTutar.TabIndex = 4;
            // 
            // TXTIslemTuru
            // 
            this.TXTIslemTuru.Location = new System.Drawing.Point(247, 159);
            this.TXTIslemTuru.Name = "TXTIslemTuru";
            this.TXTIslemTuru.Size = new System.Drawing.Size(100, 22);
            this.TXTIslemTuru.TabIndex = 5;
            // 
            // TXTIslemTarihi
            // 
            this.TXTIslemTarihi.Location = new System.Drawing.Point(247, 97);
            this.TXTIslemTarihi.Name = "TXTIslemTarihi";
            this.TXTIslemTarihi.Size = new System.Drawing.Size(100, 22);
            this.TXTIslemTarihi.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(747, 509);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // KasaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTKasaIslemAciklama);
            this.Controls.Add(this.TXTTutar);
            this.Controls.Add(this.TXTIslemTuru);
            this.Controls.Add(this.TXTIslemTarihi);
            this.Name = "KasaIslemleri";
            this.Text = "KasaIslemleri";
            this.Load += new System.EventHandler(this.KasaIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTKasaIslemAciklama;
        private System.Windows.Forms.TextBox TXTTutar;
        private System.Windows.Forms.TextBox TXTIslemTuru;
        private System.Windows.Forms.TextBox TXTIslemTarihi;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}