namespace KafeOtomasyonu.WF
{
    partial class frmmasasatis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnayarlar = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.lblmusterisayisi = new System.Windows.Forms.Label();
            this.lblacikmasa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMasalar = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnayarlar);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.lblmusterisayisi);
            this.groupBox1.Controls.Add(this.lblacikmasa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(810, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 108);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Masalar";
            // 
            // btnayarlar
            // 
            this.btnayarlar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnayarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnayarlar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnayarlar.ImageKey = "(none)";
            this.btnayarlar.Location = new System.Drawing.Point(496, 25);
            this.btnayarlar.Name = "btnayarlar";
            this.btnayarlar.Size = new System.Drawing.Size(101, 26);
            this.btnayarlar.TabIndex = 4;
            this.btnayarlar.Text = "Ayarlar";
            this.btnayarlar.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.ImageKey = "(none)";
            this.button16.Location = new System.Drawing.Point(603, 25);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(101, 26);
            this.button16.TabIndex = 4;
            this.button16.Text = " Detay";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // lblmusterisayisi
            // 
            this.lblmusterisayisi.AutoSize = true;
            this.lblmusterisayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmusterisayisi.Location = new System.Drawing.Point(109, 58);
            this.lblmusterisayisi.Name = "lblmusterisayisi";
            this.lblmusterisayisi.Size = new System.Drawing.Size(17, 16);
            this.lblmusterisayisi.TabIndex = 3;
            this.lblmusterisayisi.Text = "...";
            // 
            // lblacikmasa
            // 
            this.lblacikmasa.AutoSize = true;
            this.lblacikmasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblacikmasa.Location = new System.Drawing.Point(90, 33);
            this.lblacikmasa.Name = "lblacikmasa";
            this.lblacikmasa.Size = new System.Drawing.Size(17, 16);
            this.lblacikmasa.TabIndex = 2;
            this.lblacikmasa.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Açık Masa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Sayısı: ";
            // 
            // panelMasalar
            // 
            this.panelMasalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelMasalar.Location = new System.Drawing.Point(12, 12);
            this.panelMasalar.Name = "panelMasalar";
            this.panelMasalar.Size = new System.Drawing.Size(743, 399);
            this.panelMasalar.TabIndex = 1;
            this.panelMasalar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMasalar_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmmasasatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 452);
            this.Controls.Add(this.panelMasalar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmmasasatis";
            this.Text = "Masalar";
            this.Load += new System.EventHandler(this.frmmasasatis_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label lblmusterisayisi;
        private System.Windows.Forms.Label lblacikmasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnayarlar;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel panelMasalar;
        private System.Windows.Forms.Timer timer1;
    }
}