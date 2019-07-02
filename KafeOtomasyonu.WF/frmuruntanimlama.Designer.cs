namespace KafeOtomasyonu.WF
{
    partial class frmuruntanimlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmuruntanimlama));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txturunadi = new System.Windows.Forms.TextBox();
            this.txturunfiyati = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.gridurun = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridurun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(113, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(116, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(113, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün  Fiyatı:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txturunadi
            // 
            this.txturunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunadi.Location = new System.Drawing.Point(215, 51);
            this.txturunadi.Name = "txturunadi";
            this.txturunadi.Size = new System.Drawing.Size(121, 22);
            this.txturunadi.TabIndex = 2;
            // 
            // txturunfiyati
            // 
            this.txturunfiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunfiyati.Location = new System.Drawing.Point(215, 84);
            this.txturunfiyati.Name = "txturunfiyati";
            this.txturunfiyati.Size = new System.Drawing.Size(121, 22);
            this.txturunfiyati.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbkategori);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.gridurun);
            this.groupBox1.Controls.Add(this.txturunadi);
            this.groupBox1.Controls.Add(this.txturunfiyati);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 325);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbkategori
            // 
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Location = new System.Drawing.Point(215, 20);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(121, 21);
            this.cmbkategori.TabIndex = 11;
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.ImageKey = "guncelle.png";
            this.btnguncelle.ImageList = this.ımageList1;
            this.btnguncelle.Location = new System.Drawing.Point(261, 124);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(102, 33);
            this.btnguncelle.TabIndex = 8;
            this.btnguncelle.Text = "        GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "12428083851546739178symbol_ok_svg_med.png");
            this.ımageList1.Images.SetKeyName(1, "guncelle.png");
            this.ımageList1.Images.SetKeyName(2, "red-letter-x-128.ico");
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageKey = "red-letter-x-128.ico";
            this.btnsil.ImageList = this.ımageList1;
            this.btnsil.Location = new System.Drawing.Point(172, 124);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(83, 33);
            this.btnsil.TabIndex = 9;
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
            this.btnekle.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnekle.ImageKey = "12428083851546739178symbol_ok_svg_med.png";
            this.btnekle.ImageList = this.ımageList1;
            this.btnekle.Location = new System.Drawing.Point(82, 124);
            this.btnekle.Name = "btnekle";
            this.btnekle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnekle.Size = new System.Drawing.Size(84, 33);
            this.btnekle.TabIndex = 10;
            this.btnekle.Text = "EKLE     ";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // gridurun
            // 
            this.gridurun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridurun.Location = new System.Drawing.Point(9, 166);
            this.gridurun.Name = "gridurun";
            this.gridurun.Size = new System.Drawing.Size(429, 137);
            this.gridurun.TabIndex = 7;
            this.gridurun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridurun_CellContentClick);
            // 
            // frmuruntanimlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 349);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmuruntanimlama";
            this.Text = "Ürün Tanımlama";
            this.Load += new System.EventHandler(this.frmuruntanimlama_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridurun)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txturunadi;
        private System.Windows.Forms.TextBox txturunfiyati;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridurun;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.ComboBox cmbkategori;
    }
}