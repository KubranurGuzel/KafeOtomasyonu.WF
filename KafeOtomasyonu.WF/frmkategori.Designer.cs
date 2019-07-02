namespace KafeOtomasyonu.WF
{
    partial class frmkategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmkategori));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridkategori = new System.Windows.Forms.DataGridView();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtkadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridkategori)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.gridkategori);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.txtkadi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gridkategori
            // 
            this.gridkategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridkategori.Location = new System.Drawing.Point(62, 158);
            this.gridkategori.Name = "gridkategori";
            this.gridkategori.Size = new System.Drawing.Size(337, 150);
            this.gridkategori.TabIndex = 5;
            this.gridkategori.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridkategori_CellContentClick);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.ImageKey = "guncelle.png";
            this.btnguncelle.ImageList = this.ımageList1;
            this.btnguncelle.Location = new System.Drawing.Point(241, 119);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(102, 33);
            this.btnguncelle.TabIndex = 4;
            this.btnguncelle.Text = "        GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "12428083851546739178symbol_ok_svg_med.png");
            this.ımageList1.Images.SetKeyName(1, "red-letter-x-128.ico");
            this.ımageList1.Images.SetKeyName(2, "guncelle.png");
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageKey = "red-letter-x-128.ico";
            this.btnsil.ImageList = this.ımageList1;
            this.btnsil.Location = new System.Drawing.Point(152, 119);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(83, 33);
            this.btnsil.TabIndex = 3;
            this.btnsil.Text = "    SİL ";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnekle
            // 
            this.btnekle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnekle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnekle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnekle.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnekle.ImageKey = "12428083851546739178symbol_ok_svg_med.png";
            this.btnekle.ImageList = this.ımageList1;
            this.btnekle.Location = new System.Drawing.Point(62, 119);
            this.btnekle.Name = "btnekle";
            this.btnekle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnekle.Size = new System.Drawing.Size(84, 33);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "EKLE     ";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtkadi
            // 
            this.txtkadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkadi.Location = new System.Drawing.Point(194, 50);
            this.txtkadi.Name = "txtkadi";
            this.txtkadi.Size = new System.Drawing.Size(128, 22);
            this.txtkadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori Adı:";
            // 
            // frmkategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 353);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmkategori";
            this.Text = "Kategori";
            this.Load += new System.EventHandler(this.frmkategori_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridkategori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtkadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView gridkategori;
    }
}