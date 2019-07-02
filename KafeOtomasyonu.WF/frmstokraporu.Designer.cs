namespace KafeOtomasyonu.WF
{
    partial class frmstokraporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstokraporu));
            this.btnPersonelRaporu = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnStokDurumRaporu = new System.Windows.Forms.Button();
            this.btnUrunSatisRaporu = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnPersonelRaporu.TabIndex = 3;
            this.btnPersonelRaporu.Text = "Personel Performans Raporu";
            this.btnPersonelRaporu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersonelRaporu.UseVisualStyleBackColor = false;
            this.btnPersonelRaporu.Click += new System.EventHandler(this.btnPersonelRaporu_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "personel performans.jpg");
            this.ımageList1.Images.SetKeyName(1, "depo1.png");
            this.ımageList1.Images.SetKeyName(2, "Product-sale-report-icon.png");
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
            this.btnStokDurumRaporu.TabIndex = 4;
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
            this.btnUrunSatisRaporu.TabIndex = 5;
            this.btnUrunSatisRaporu.Text = "                                                                                 " +
    "                                                               Ürün Satış       " +
    "   Raporu";
            this.btnUrunSatisRaporu.UseVisualStyleBackColor = false;
            this.btnUrunSatisRaporu.Click += new System.EventHandler(this.btnUrunSatisRaporu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(36, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 117);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Stok No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Stok Adı";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Birim";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giren";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Çıkan";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Son Durum";
            this.Column5.Name = "Column5";
            // 
            // frmstokraporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 340);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPersonelRaporu);
            this.Controls.Add(this.btnStokDurumRaporu);
            this.Controls.Add(this.btnUrunSatisRaporu);
            this.Name = "frmstokraporu";
            this.Text = "Stok Raporu";
            this.Load += new System.EventHandler(this.frmstokraporu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelRaporu;
        private System.Windows.Forms.Button btnStokDurumRaporu;
        private System.Windows.Forms.Button btnUrunSatisRaporu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ImageList ımageList1;
    }
}