namespace KafeOtomasyonu.WF
{
    partial class frmodeme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmodeme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdisyonNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTopTutar = new System.Windows.Forms.Label();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.cmbOdemeSekli = new System.Windows.Forms.ComboBox();
            this.gridOdeme = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSil = new System.Windows.Forms.Button();
            this.btnodeal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdeme)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdisyonNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblTopTutar);
            this.groupBox1.Controls.Add(this.lblMasaNo);
            this.groupBox1.Controls.Add(this.cmbOdemeSekli);
            this.groupBox1.Controls.Add(this.gridOdeme);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnodeal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblAdisyonNo
            // 
            this.lblAdisyonNo.AutoSize = true;
            this.lblAdisyonNo.Location = new System.Drawing.Point(269, 63);
            this.lblAdisyonNo.Name = "lblAdisyonNo";
            this.lblAdisyonNo.Size = new System.Drawing.Size(19, 13);
            this.lblAdisyonNo.TabIndex = 31;
            this.lblAdisyonNo.Text = "....";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(151, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Adisyon No:";
            // 
            // lblTopTutar
            // 
            this.lblTopTutar.AutoSize = true;
            this.lblTopTutar.Location = new System.Drawing.Point(269, 92);
            this.lblTopTutar.Name = "lblTopTutar";
            this.lblTopTutar.Size = new System.Drawing.Size(19, 13);
            this.lblTopTutar.TabIndex = 29;
            this.lblTopTutar.Text = "....";
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.AutoSize = true;
            this.lblMasaNo.Location = new System.Drawing.Point(269, 33);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(19, 13);
            this.lblMasaNo.TabIndex = 29;
            this.lblMasaNo.Text = "....";
            // 
            // cmbOdemeSekli
            // 
            this.cmbOdemeSekli.FormattingEnabled = true;
            this.cmbOdemeSekli.Location = new System.Drawing.Point(246, 116);
            this.cmbOdemeSekli.Name = "cmbOdemeSekli";
            this.cmbOdemeSekli.Size = new System.Drawing.Size(128, 21);
            this.cmbOdemeSekli.TabIndex = 28;
            // 
            // gridOdeme
            // 
            this.gridOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOdeme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.gridOdeme.Location = new System.Drawing.Point(95, 227);
            this.gridOdeme.Name = "gridOdeme";
            this.gridOdeme.Size = new System.Drawing.Size(343, 125);
            this.gridOdeme.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Masa No";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Toplam Tutar";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ödeme Şekli";
            this.Column3.Name = "Column3";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuncelle.ImageKey = "guncelle.png";
            this.btnGuncelle.ImageList = this.ımageList1;
            this.btnGuncelle.Location = new System.Drawing.Point(310, 173);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(102, 33);
            this.btnGuncelle.TabIndex = 24;
            this.btnGuncelle.Text = "        GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "guncelle.png");
            this.ımageList1.Images.SetKeyName(1, "red-letter-x-128.ico");
            this.ımageList1.Images.SetKeyName(2, "12428083851546739178symbol_ok_svg_med.png");
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageKey = "red-letter-x-128.ico";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(221, 173);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(83, 33);
            this.btnSil.TabIndex = 25;
            this.btnSil.Text = "    SİL ";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnodeal
            // 
            this.btnodeal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnodeal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnodeal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnodeal.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnodeal.ImageKey = "12428083851546739178symbol_ok_svg_med.png";
            this.btnodeal.ImageList = this.ımageList1;
            this.btnodeal.Location = new System.Drawing.Point(131, 173);
            this.btnodeal.Name = "btnodeal";
            this.btnodeal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnodeal.Size = new System.Drawing.Size(84, 33);
            this.btnodeal.TabIndex = 26;
            this.btnodeal.Text = "ÖDEME     ";
            this.btnodeal.UseVisualStyleBackColor = false;
            this.btnodeal.Click += new System.EventHandler(this.btnodeal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(151, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ödeme Şekli:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(151, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Toplam Tutar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(151, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Masa No:";
            // 
            // frmodeme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 388);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmodeme";
            this.Text = "Ödeme Paneli";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdeme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView gridOdeme;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnodeal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOdemeSekli;
        private System.Windows.Forms.Label lblTopTutar;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label lblAdisyonNo;
        private System.Windows.Forms.Label label7;
    }
}