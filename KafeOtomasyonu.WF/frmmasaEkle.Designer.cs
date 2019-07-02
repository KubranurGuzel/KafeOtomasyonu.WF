namespace KafeOtomasyonu.WF
{
    partial class frmmasaEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmasaEkle));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.gridmasalar = new System.Windows.Forms.DataGridView();
            this.txtkisiSayisi = new System.Windows.Forms.TextBox();
            this.txtmasaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmasalar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.gridmasalar);
            this.groupBox1.Controls.Add(this.txtkisiSayisi);
            this.groupBox1.Controls.Add(this.txtmasaAdi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 325);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.ımageList1.Images.SetKeyName(0, "12428083851546739178symbol_ok_svg_med (1).png");
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
            this.btnekle.ImageKey = "12428083851546739178symbol_ok_svg_med (1).png";
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
            // gridmasalar
            // 
            this.gridmasalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmasalar.Location = new System.Drawing.Point(9, 166);
            this.gridmasalar.Name = "gridmasalar";
            this.gridmasalar.Size = new System.Drawing.Size(429, 137);
            this.gridmasalar.TabIndex = 7;
            this.gridmasalar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridmasalar_CellContentClick);
            // 
            // txtkisiSayisi
            // 
            this.txtkisiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkisiSayisi.Location = new System.Drawing.Point(215, 51);
            this.txtkisiSayisi.Name = "txtkisiSayisi";
            this.txtkisiSayisi.Size = new System.Drawing.Size(121, 22);
            this.txtkisiSayisi.TabIndex = 2;
            // 
            // txtmasaAdi
            // 
            this.txtmasaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmasaAdi.Location = new System.Drawing.Point(215, 84);
            this.txtmasaAdi.Name = "txtmasaAdi";
            this.txtmasaAdi.Size = new System.Drawing.Size(121, 22);
            this.txtmasaAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(113, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kişi Sayısı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(113, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Masa Adı:";
            // 
            // frmmasaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 370);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmmasaEkle";
            this.Text = "Masa Ekleme";
            this.Load += new System.EventHandler(this.frmmasaEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmasalar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.DataGridView gridmasalar;
        private System.Windows.Forms.TextBox txtkisiSayisi;
        private System.Windows.Forms.TextBox txtmasaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList ımageList1;
    }
}