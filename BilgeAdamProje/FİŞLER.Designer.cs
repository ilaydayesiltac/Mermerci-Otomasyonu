namespace BilgeAdamProje
{
    partial class FİŞLER
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
            this.BTNAlis = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTNALİSİADE = new System.Windows.Forms.Button();
            this.BTNSATİSİADE = new System.Windows.Forms.Button();
            this.BTNFİSHAREKET = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNAlis
            // 
            this.BTNAlis.Location = new System.Drawing.Point(47, 46);
            this.BTNAlis.Name = "BTNAlis";
            this.BTNAlis.Size = new System.Drawing.Size(133, 108);
            this.BTNAlis.TabIndex = 0;
            this.BTNAlis.Text = "ALIŞ FİŞİ";
            this.BTNAlis.UseVisualStyleBackColor = true;
            this.BTNAlis.Click += new System.EventHandler(this.BTNAlis_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 108);
            this.button2.TabIndex = 0;
            this.button2.Text = "SATIŞ FİŞİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNALİSİADE
            // 
            this.BTNALİSİADE.Location = new System.Drawing.Point(471, 46);
            this.BTNALİSİADE.Name = "BTNALİSİADE";
            this.BTNALİSİADE.Size = new System.Drawing.Size(175, 108);
            this.BTNALİSİADE.TabIndex = 0;
            this.BTNALİSİADE.Text = "ALIŞ İADE FİŞİ";
            this.BTNALİSİADE.UseVisualStyleBackColor = true;
            this.BTNALİSİADE.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTNSATİSİADE
            // 
            this.BTNSATİSİADE.Location = new System.Drawing.Point(702, 41);
            this.BTNSATİSİADE.Name = "BTNSATİSİADE";
            this.BTNSATİSİADE.Size = new System.Drawing.Size(162, 113);
            this.BTNSATİSİADE.TabIndex = 0;
            this.BTNSATİSİADE.Text = "SATIŞ İADE FİŞİ";
            this.BTNSATİSİADE.UseVisualStyleBackColor = true;
            this.BTNSATİSİADE.Click += new System.EventHandler(this.BTNSATİSİADE_Click);
            // 
            // BTNFİSHAREKET
            // 
            this.BTNFİSHAREKET.Location = new System.Drawing.Point(928, 41);
            this.BTNFİSHAREKET.Name = "BTNFİSHAREKET";
            this.BTNFİSHAREKET.Size = new System.Drawing.Size(163, 113);
            this.BTNFİSHAREKET.TabIndex = 1;
            this.BTNFİSHAREKET.Text = "FİŞ HAREKETLERİ";
            this.BTNFİSHAREKET.UseVisualStyleBackColor = true;
            this.BTNFİSHAREKET.Click += new System.EventHandler(this.BTNFİSHAREKET_Click);
            // 
            // FİŞLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 648);
            this.Controls.Add(this.BTNFİSHAREKET);
            this.Controls.Add(this.BTNSATİSİADE);
            this.Controls.Add(this.BTNALİSİADE);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BTNAlis);
            this.Name = "FİŞLER";
            this.Text = "FİŞLER";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNAlis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTNALİSİADE;
        private System.Windows.Forms.Button BTNSATİSİADE;
        private System.Windows.Forms.Button BTNFİSHAREKET;
    }
}