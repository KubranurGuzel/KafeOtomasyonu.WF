namespace KafeOtomasyonu.WF
{
    partial class frmstoktakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmstoktakip));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridstok = new System.Windows.Forms.DataGridView();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.txtbirimfyt = new System.Windows.Forms.TextBox();
            this.txturunmiktar = new System.Windows.Forms.TextBox();
            this.txtbirim = new System.Windows.Forms.TextBox();
            this.cmburunadi = new System.Windows.Forms.ComboBox();
            this.cmbkategori = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridstok)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridstok);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.txtbirimfyt);
            this.groupBox1.Controls.Add(this.txturunmiktar);
            this.groupBox1.Controls.Add(this.txtbirim);
            this.groupBox1.Controls.Add(this.cmburunadi);
            this.groupBox1.Controls.Add(this.cmbkategori);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gridstok
            // 
            this.gridstok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridstok.Location = new System.Drawing.Point(38, 206);
            this.gridstok.Name = "gridstok";
            this.gridstok.Size = new System.Drawing.Size(625, 132);
            this.gridstok.TabIndex = 9;
            this.gridstok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridstok_CellContentClick);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.ImageKey = "guncelle.png";
            this.btnguncelle.ImageList = this.ımageList1;
            this.btnguncelle.Location = new System.Drawing.Point(337, 167);
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
            this.btnsil.Location = new System.Drawing.Point(248, 167);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(83, 33);
            this.btnsil.TabIndex = 7;
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
            this.btnekle.Location = new System.Drawing.Point(158, 167);
            this.btnekle.Name = "btnekle";
            this.btnekle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnekle.Size = new System.Drawing.Size(84, 33);
            this.btnekle.TabIndex = 6;
            this.btnekle.Text = "EKLE     ";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtbirimfyt
            // 
            this.txtbirimfyt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbirimfyt.Location = new System.Drawing.Point(275, 129);
            this.txtbirimfyt.Name = "txtbirimfyt";
            this.txtbirimfyt.Size = new System.Drawing.Size(121, 22);
            this.txtbirimfyt.TabIndex = 5;
            // 
            // txturunmiktar
            // 
            this.txturunmiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunmiktar.Location = new System.Drawing.Point(275, 104);
            this.txturunmiktar.Name = "txturunmiktar";
            this.txturunmiktar.Size = new System.Drawing.Size(121, 22);
            this.txturunmiktar.TabIndex = 4;
            // 
            // txtbirim
            // 
            this.txtbirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbirim.Location = new System.Drawing.Point(275, 80);
            this.txtbirim.Name = "txtbirim";
            this.txtbirim.Size = new System.Drawing.Size(121, 22);
            this.txtbirim.TabIndex = 3;
            // 
            // cmburunadi
            // 
            this.cmburunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmburunadi.FormattingEnabled = true;
            this.cmburunadi.Location = new System.Drawing.Point(275, 54);
            this.cmburunadi.Name = "cmburunadi";
            this.cmburunadi.Size = new System.Drawing.Size(121, 24);
            this.cmburunadi.TabIndex = 2;
            // 
            // cmbkategori
            // 
            this.cmbkategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbkategori.FormattingEnabled = true;
            this.cmbkategori.Location = new System.Drawing.Point(275, 25);
            this.cmbkategori.Name = "cmbkategori";
            this.cmbkategori.Size = new System.Drawing.Size(121, 24);
            this.cmbkategori.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(183, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Birim Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(183, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ürün Miktarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(183, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Birim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(183, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(183, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kategori:";
            // 
            // frmstoktakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(705, 393);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmstoktakip";
            this.Text = "Stok Takip";
            this.Load += new System.EventHandler(this.frmstoktakip_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridstok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridstok;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtbirimfyt;
        private System.Windows.Forms.TextBox txturunmiktar;
        private System.Windows.Forms.TextBox txtbirim;
        private System.Windows.Forms.ComboBox cmburunadi;
        private System.Windows.Forms.ComboBox cmbkategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}