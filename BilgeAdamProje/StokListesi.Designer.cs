namespace BilgeAdamProje
{
    partial class StokListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtStokAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStokSil = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtStokAdet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnStokGüncelle = new System.Windows.Forms.Button();
            this.TxtAlisFiyat = new System.Windows.Forms.TextBox();
            this.TxtStokAd = new System.Windows.Forms.TextBox();
            this.TxtStokModel = new System.Windows.Forms.TextBox();
            this.TxtStokMarka = new System.Windows.Forms.TextBox();
            this.TxtStokYıl = new System.Windows.Forms.TextBox();
            this.TxtSatisFiyat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 495);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // TxtStokAra
            // 
            this.TxtStokAra.Location = new System.Drawing.Point(769, 44);
            this.TxtStokAra.Name = "TxtStokAra";
            this.TxtStokAra.Size = new System.Drawing.Size(189, 22);
            this.TxtStokAra.TabIndex = 1;
            this.TxtStokAra.TextChanged += new System.EventHandler(this.TxtStokAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "STOK ARA";
            // 
            // btnStokSil
            // 
            this.btnStokSil.Location = new System.Drawing.Point(1055, 594);
            this.btnStokSil.Name = "btnStokSil";
            this.btnStokSil.Size = new System.Drawing.Size(93, 46);
            this.btnStokSil.TabIndex = 4;
            this.btnStokSil.Text = "SİL";
            this.btnStokSil.UseVisualStyleBackColor = true;
            this.btnStokSil.Click += new System.EventHandler(this.btnStokSil_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtStokAdet);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnStokGüncelle);
            this.groupBox3.Controls.Add(this.TxtAlisFiyat);
            this.groupBox3.Controls.Add(this.TxtStokAd);
            this.groupBox3.Controls.Add(this.TxtStokModel);
            this.groupBox3.Controls.Add(this.TxtStokMarka);
            this.groupBox3.Controls.Add(this.TxtStokYıl);
            this.groupBox3.Controls.Add(this.TxtSatisFiyat);
            this.groupBox3.Location = new System.Drawing.Point(114, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 530);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "STOK EKLE";
            // 
            // TxtStokAdet
            // 
            this.TxtStokAdet.Location = new System.Drawing.Point(116, 256);
            this.TxtStokAdet.Name = "TxtStokAdet";
            this.TxtStokAdet.Size = new System.Drawing.Size(100, 22);
            this.TxtStokAdet.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "YIL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = " MODEL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = " MARKA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "SATIŞ FİYATI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ALIŞ FİYATI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ADET:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = " AD:";
            // 
            // btnStokGüncelle
            // 
            this.btnStokGüncelle.Location = new System.Drawing.Point(116, 472);
            this.btnStokGüncelle.Name = "btnStokGüncelle";
            this.btnStokGüncelle.Size = new System.Drawing.Size(100, 23);
            this.btnStokGüncelle.TabIndex = 3;
            this.btnStokGüncelle.Text = "GÜNCELLE";
            this.btnStokGüncelle.UseVisualStyleBackColor = true;
            this.btnStokGüncelle.Click += new System.EventHandler(this.btnStokGüncelle_Click);
            // 
            // TxtAlisFiyat
            // 
            this.TxtAlisFiyat.Location = new System.Drawing.Point(116, 306);
            this.TxtAlisFiyat.Name = "TxtAlisFiyat";
            this.TxtAlisFiyat.Size = new System.Drawing.Size(100, 22);
            this.TxtAlisFiyat.TabIndex = 1;
            // 
            // TxtStokAd
            // 
            this.TxtStokAd.Location = new System.Drawing.Point(116, 32);
            this.TxtStokAd.Name = "TxtStokAd";
            this.TxtStokAd.Size = new System.Drawing.Size(100, 22);
            this.TxtStokAd.TabIndex = 1;
            // 
            // TxtStokModel
            // 
            this.TxtStokModel.Location = new System.Drawing.Point(116, 141);
            this.TxtStokModel.Name = "TxtStokModel";
            this.TxtStokModel.Size = new System.Drawing.Size(100, 22);
            this.TxtStokModel.TabIndex = 1;
            // 
            // TxtStokMarka
            // 
            this.TxtStokMarka.Location = new System.Drawing.Point(116, 86);
            this.TxtStokMarka.Name = "TxtStokMarka";
            this.TxtStokMarka.Size = new System.Drawing.Size(100, 22);
            this.TxtStokMarka.TabIndex = 1;
            // 
            // TxtStokYıl
            // 
            this.TxtStokYıl.Location = new System.Drawing.Point(116, 196);
            this.TxtStokYıl.Name = "TxtStokYıl";
            this.TxtStokYıl.Size = new System.Drawing.Size(100, 22);
            this.TxtStokYıl.TabIndex = 1;
            // 
            // TxtSatisFiyat
            // 
            this.TxtSatisFiyat.Location = new System.Drawing.Point(116, 361);
            this.TxtSatisFiyat.Name = "TxtSatisFiyat";
            this.TxtSatisFiyat.Size = new System.Drawing.Size(100, 22);
            this.TxtSatisFiyat.TabIndex = 2;
            // 
            // StokListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1198, 682);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnStokSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtStokAra);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StokListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokListesi";
            this.Load += new System.EventHandler(this.StokListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtStokAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStokSil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtStokAdet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnStokGüncelle;
        private System.Windows.Forms.TextBox TxtAlisFiyat;
        private System.Windows.Forms.TextBox TxtStokAd;
        private System.Windows.Forms.TextBox TxtStokModel;
        private System.Windows.Forms.TextBox TxtStokMarka;
        private System.Windows.Forms.TextBox TxtStokYıl;
        private System.Windows.Forms.TextBox TxtSatisFiyat;
    }
}