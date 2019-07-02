namespace KafeOtomasyonu.WF
{
    partial class frmpersonelperformansraporu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpersonelperformansraporu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPersonelRaporu = new System.Windows.Forms.Button();
            this.btnStokDurumRaporu = new System.Windows.Forms.Button();
            this.btnUrunSatisRaporu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(117, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 141);
            this.dataGridView1.TabIndex = 9;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "depo1.png");
            this.ımageList1.Images.SetKeyName(1, "personel performans.jpg");
            this.ımageList1.Images.SetKeyName(2, "Product-sale-report-icon.png");
            // 
            // btnPersonelRaporu
            // 
            this.btnPersonelRaporu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPersonelRaporu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersonelRaporu.ImageKey = "personel performans.jpg";
            this.btnPersonelRaporu.ImageList = this.ımageList1;
            this.btnPersonelRaporu.Location = new System.Drawing.Point(418, 39);
            this.btnPersonelRaporu.Name = "btnPersonelRaporu";
            this.btnPersonelRaporu.Size = new System.Drawing.Size(114, 90);
            this.btnPersonelRaporu.TabIndex = 10;
            this.btnPersonelRaporu.Text = "Personel Performans Raporu";
            this.btnPersonelRaporu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonelRaporu.UseVisualStyleBackColor = false;
            this.btnPersonelRaporu.Click += new System.EventHandler(this.btnPersonelRaporu_Click);
            // 
            // btnStokDurumRaporu
            // 
            this.btnStokDurumRaporu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStokDurumRaporu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStokDurumRaporu.ImageKey = "depo1.png";
            this.btnStokDurumRaporu.ImageList = this.ımageList1;
            this.btnStokDurumRaporu.Location = new System.Drawing.Point(279, 39);
            this.btnStokDurumRaporu.Name = "btnStokDurumRaporu";
            this.btnStokDurumRaporu.Size = new System.Drawing.Size(115, 90);
            this.btnStokDurumRaporu.TabIndex = 11;
            this.btnStokDurumRaporu.Text = "                                                                                 " +
    "                                                          Stok Durum          Ra" +
    "poru";
            this.btnStokDurumRaporu.UseVisualStyleBackColor = false;
            this.btnStokDurumRaporu.Click += new System.EventHandler(this.btnStokDurumRaporu_Click);
            // 
            // btnUrunSatisRaporu
            // 
            this.btnUrunSatisRaporu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUrunSatisRaporu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUrunSatisRaporu.ImageKey = "Product-sale-report-icon.png";
            this.btnUrunSatisRaporu.ImageList = this.ımageList1;
            this.btnUrunSatisRaporu.Location = new System.Drawing.Point(139, 39);
            this.btnUrunSatisRaporu.Name = "btnUrunSatisRaporu";
            this.btnUrunSatisRaporu.Size = new System.Drawing.Size(118, 90);
            this.btnUrunSatisRaporu.TabIndex = 12;
            this.btnUrunSatisRaporu.Text = "                                                                                 " +
    "                                                               Ürün Satış       " +
    "   Raporu";
            this.btnUrunSatisRaporu.UseVisualStyleBackColor = false;
            this.btnUrunSatisRaporu.Click += new System.EventHandler(this.btnUrunSatisRaporu_Click);
            // 
            // frmpersonelperformansraporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 340);
            this.Controls.Add(this.btnPersonelRaporu);
            this.Controls.Add(this.btnStokDurumRaporu);
            this.Controls.Add(this.btnUrunSatisRaporu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmpersonelperformansraporu";
            this.Text = "Personel Performans Raporu";
            this.Load += new System.EventHandler(this.frmpersonelperformansraporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnPersonelRaporu;
        private System.Windows.Forms.Button btnStokDurumRaporu;
        private System.Windows.Forms.Button btnUrunSatisRaporu;
    }
}