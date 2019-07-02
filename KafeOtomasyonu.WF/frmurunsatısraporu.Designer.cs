namespace KafeOtomasyonu.WF
{
    partial class frmurunsatısraporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmurunsatısraporu));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(117, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 117);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ürün No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün Adı";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Adet";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tutar";
            this.Column4.Name = "Column4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Toplam Satış Tutarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Toplam İndirim Tutarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Net Tutarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "...";
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
            this.btnPersonelRaporu.TabIndex = 9;
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
            this.btnStokDurumRaporu.TabIndex = 10;
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
            this.btnUrunSatisRaporu.TabIndex = 11;
            this.btnUrunSatisRaporu.Text = "                                                                                 " +
    "                                                               Ürün Satış       " +
    "   Raporu";
            this.btnUrunSatisRaporu.UseVisualStyleBackColor = false;
            this.btnUrunSatisRaporu.Click += new System.EventHandler(this.btnUrunSatisRaporu_Click);
            // 
            // frmurunsatısraporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 372);
            this.Controls.Add(this.btnPersonelRaporu);
            this.Controls.Add(this.btnStokDurumRaporu);
            this.Controls.Add(this.btnUrunSatisRaporu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmurunsatısraporu";
            this.Text = "Ürün Satış Raporu";
            this.Load += new System.EventHandler(this.frmurunsatısraporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnPersonelRaporu;
        private System.Windows.Forms.Button btnStokDurumRaporu;
        private System.Windows.Forms.Button btnUrunSatisRaporu;
    }
}