namespace BilgeAdamProje
{
    partial class Cari
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTCariIletisim = new System.Windows.Forms.TextBox();
            this.TXTCariAdres = new System.Windows.Forms.TextBox();
            this.TXTCariFirma = new System.Windows.Forms.TextBox();
            this.TXTCariVergi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "FİRMA ADI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "VERGİ NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "İLETİŞİM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "ADRES:";
            // 
            // TXTCariIletisim
            // 
            this.TXTCariIletisim.Location = new System.Drawing.Point(219, 214);
            this.TXTCariIletisim.Name = "TXTCariIletisim";
            this.TXTCariIletisim.Size = new System.Drawing.Size(100, 22);
            this.TXTCariIletisim.TabIndex = 2;
            // 
            // TXTCariAdres
            // 
            this.TXTCariAdres.Location = new System.Drawing.Point(219, 276);
            this.TXTCariAdres.Name = "TXTCariAdres";
            this.TXTCariAdres.Size = new System.Drawing.Size(100, 22);
            this.TXTCariAdres.TabIndex = 2;
            // 
            // TXTCariFirma
            // 
            this.TXTCariFirma.Location = new System.Drawing.Point(219, 86);
            this.TXTCariFirma.Name = "TXTCariFirma";
            this.TXTCariFirma.Size = new System.Drawing.Size(100, 22);
            this.TXTCariFirma.TabIndex = 2;
            // 
            // TXTCariVergi
            // 
            this.TXTCariVergi.Location = new System.Drawing.Point(219, 148);
            this.TXTCariVergi.Name = "TXTCariVergi";
            this.TXTCariVergi.Size = new System.Drawing.Size(100, 22);
            this.TXTCariVergi.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(429, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 444);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(426, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cari:";
            // 
            // Cari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 580);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXTCariVergi);
            this.Controls.Add(this.TXTCariAdres);
            this.Controls.Add(this.TXTCariFirma);
            this.Controls.Add(this.TXTCariIletisim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cari";
            this.Text = "Cari";
            this.Load += new System.EventHandler(this.Cari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTCariIletisim;
        private System.Windows.Forms.TextBox TXTCariAdres;
        private System.Windows.Forms.TextBox TXTCariFirma;
        private System.Windows.Forms.TextBox TXTCariVergi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}