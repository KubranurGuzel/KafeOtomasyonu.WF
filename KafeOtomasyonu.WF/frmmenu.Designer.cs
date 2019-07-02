namespace KafeOtomasyonu.WF
{
    partial class frmmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmenu));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridmenu = new System.Windows.Forms.DataGridView();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnekle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listmenu = new System.Windows.Forms.ListBox();
            this.cmburunadi = new System.Windows.Forms.ComboBox();
            this.txtmfiyat = new System.Windows.Forms.TextBox();
            this.txtmenuadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "12428083851546739178symbol_ok_svg_med.png");
            this.ımageList1.Images.SetKeyName(1, "guncelle.png");
            this.ımageList1.Images.SetKeyName(2, "red-letter-x-128.ico");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridmenu);
            this.groupBox1.Controls.Add(this.btnguncelle);
            this.groupBox1.Controls.Add(this.btnsil);
            this.groupBox1.Controls.Add(this.btnekle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbKategori);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listmenu);
            this.groupBox1.Controls.Add(this.cmburunadi);
            this.groupBox1.Controls.Add(this.txtmfiyat);
            this.groupBox1.Controls.Add(this.txtmenuadi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(647, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gridmenu
            // 
            this.gridmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmenu.Location = new System.Drawing.Point(87, 285);
            this.gridmenu.Name = "gridmenu";
            this.gridmenu.Size = new System.Drawing.Size(442, 112);
            this.gridmenu.TabIndex = 27;
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnguncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguncelle.ImageKey = "guncelle.png";
            this.btnguncelle.ImageList = this.ımageList1;
            this.btnguncelle.Location = new System.Drawing.Point(352, 217);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(102, 33);
            this.btnguncelle.TabIndex = 26;
            this.btnguncelle.Text = "        GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = false;
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsil.ImageKey = "red-letter-x-128.ico";
            this.btnsil.ImageList = this.ımageList1;
            this.btnsil.Location = new System.Drawing.Point(263, 217);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(83, 33);
            this.btnsil.TabIndex = 25;
            this.btnsil.Text = "    SİL ";
            this.btnsil.UseVisualStyleBackColor = false;
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
            this.btnekle.Location = new System.Drawing.Point(173, 217);
            this.btnekle.Name = "btnekle";
            this.btnekle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnekle.Size = new System.Drawing.Size(83, 34);
            this.btnekle.TabIndex = 24;
            this.btnekle.Text = "EKLE     ";
            this.btnekle.UseVisualStyleBackColor = false;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Kategori:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(317, 33);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listmenu
            // 
            this.listmenu.FormattingEnabled = true;
            this.listmenu.Location = new System.Drawing.Point(449, 31);
            this.listmenu.Name = "listmenu";
            this.listmenu.Size = new System.Drawing.Size(120, 82);
            this.listmenu.TabIndex = 20;
            this.listmenu.SelectedIndexChanged += new System.EventHandler(this.listmenu_SelectedIndexChanged);
            // 
            // cmburunadi
            // 
            this.cmburunadi.FormattingEnabled = true;
            this.cmburunadi.Location = new System.Drawing.Point(316, 65);
            this.cmburunadi.Name = "cmburunadi";
            this.cmburunadi.Size = new System.Drawing.Size(121, 21);
            this.cmburunadi.TabIndex = 2;
            this.cmburunadi.SelectedIndexChanged += new System.EventHandler(this.cmburunadi_SelectedIndexChanged);
            // 
            // txtmfiyat
            // 
            this.txtmfiyat.Location = new System.Drawing.Point(87, 61);
            this.txtmfiyat.Name = "txtmfiyat";
            this.txtmfiyat.Size = new System.Drawing.Size(121, 20);
            this.txtmfiyat.TabIndex = 3;
            // 
            // txtmenuadi
            // 
            this.txtmenuadi.Location = new System.Drawing.Point(87, 34);
            this.txtmenuadi.Name = "txtmenuadi";
            this.txtmenuadi.Size = new System.Drawing.Size(121, 20);
            this.txtmenuadi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fiyat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Menü Adı:";
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 426);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmmenu";
            this.Text = "Menü Oluşturma";
            this.Load += new System.EventHandler(this.frmmenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmburunadi;
        private System.Windows.Forms.TextBox txtmfiyat;
        private System.Windows.Forms.TextBox txtmenuadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listmenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.DataGridView gridmenu;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnekle;
    }
}