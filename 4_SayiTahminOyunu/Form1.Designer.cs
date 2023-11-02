namespace _4_SayiTahminOyunu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTahminSayisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lsbYapilanTahminler = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.tmrSure = new System.Windows.Forms.Timer(this.components);
            this.tmrBravo = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAyarlariKaydet = new System.Windows.Forms.Button();
            this.lsbTahminAraligi = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbKirk = new System.Windows.Forms.RadioButton();
            this.rdbOtuz = new System.Windows.Forms.RadioButton();
            this.rdbYirmi = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.grpOyunEkrani = new System.Windows.Forms.GroupBox();
            this.tmrBoyutlandir = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.grpOyunEkrani.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TAHMİNİNİZ :";
            // 
            // txtTahmin
            // 
            this.txtTahmin.Location = new System.Drawing.Point(125, 22);
            this.txtTahmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(132, 22);
            this.txtTahmin.TabIndex = 1;
            this.txtTahmin.TextChanged += new System.EventHandler(this.txtTahmin_TextChanged);
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Location = new System.Drawing.Point(125, 55);
            this.btnTahminEt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(100, 28);
            this.btnTahminEt.TabIndex = 2;
            this.btnTahminEt.Text = "TAHMİN ET";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "DURUM :";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.ForeColor = System.Drawing.Color.Red;
            this.lblDurum.Location = new System.Drawing.Point(104, 137);
            this.lblDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 16);
            this.lblDurum.TabIndex = 4;
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.Location = new System.Drawing.Point(4, 246);
            this.btnYeniOyun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(100, 28);
            this.btnYeniOyun.TabIndex = 5;
            this.btnYeniOyun.Text = "YENİ OYUN";
            this.btnYeniOyun.UseVisualStyleBackColor = true;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "TAHMİN SAYISI :";
            // 
            // lblTahminSayisi
            // 
            this.lblTahminSayisi.AutoSize = true;
            this.lblTahminSayisi.ForeColor = System.Drawing.Color.Red;
            this.lblTahminSayisi.Location = new System.Drawing.Point(151, 167);
            this.lblTahminSayisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTahminSayisi.Name = "lblTahminSayisi";
            this.lblTahminSayisi.Size = new System.Drawing.Size(0, 16);
            this.lblTahminSayisi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "YAPILAN TAHMİNLER :";
            // 
            // lsbYapilanTahminler
            // 
            this.lsbYapilanTahminler.FormattingEnabled = true;
            this.lsbYapilanTahminler.ItemHeight = 16;
            this.lsbYapilanTahminler.Location = new System.Drawing.Point(272, 42);
            this.lsbYapilanTahminler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbYapilanTahminler.Name = "lsbYapilanTahminler";
            this.lsbYapilanTahminler.Size = new System.Drawing.Size(159, 4);
            this.lsbYapilanTahminler.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "KALAN SÜRE :";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(383, 249);
            this.lblSure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(0, 17);
            this.lblSure.TabIndex = 11;
            // 
            // tmrSure
            // 
            this.tmrSure.Tick += new System.EventHandler(this.tmrSure_Tick);
            // 
            // tmrBravo
            // 
            this.tmrBravo.Interval = 250;
            this.tmrBravo.Tick += new System.EventHandler(this.tmrBravo_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAyarlariKaydet);
            this.groupBox1.Controls.Add(this.lsbTahminAraligi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rdbKirk);
            this.groupBox1.Controls.Add(this.rdbOtuz);
            this.groupBox1.Controls.Add(this.rdbYirmi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(7, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(459, 178);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OYUN AYARLARI";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAyarlariKaydet
            // 
            this.btnAyarlariKaydet.Location = new System.Drawing.Point(333, 37);
            this.btnAyarlariKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAyarlariKaydet.Name = "btnAyarlariKaydet";
            this.btnAyarlariKaydet.Size = new System.Drawing.Size(117, 102);
            this.btnAyarlariKaydet.TabIndex = 8;
            this.btnAyarlariKaydet.Text = "AYARLARI KAYDET - OYUNA BAŞLA";
            this.btnAyarlariKaydet.UseVisualStyleBackColor = true;
            this.btnAyarlariKaydet.Click += new System.EventHandler(this.btnAyarlariKaydet_Click);
            // 
            // lsbTahminAraligi
            // 
            this.lsbTahminAraligi.FormattingEnabled = true;
            this.lsbTahminAraligi.ItemHeight = 16;
            this.lsbTahminAraligi.Location = new System.Drawing.Point(152, 54);
            this.lsbTahminAraligi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lsbTahminAraligi.Name = "lsbTahminAraligi";
            this.lsbTahminAraligi.Size = new System.Drawing.Size(172, 84);
            this.lsbTahminAraligi.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "TAHMİN ARALIĞI :";
            // 
            // rdbKirk
            // 
            this.rdbKirk.AutoSize = true;
            this.rdbKirk.Location = new System.Drawing.Point(16, 111);
            this.rdbKirk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbKirk.Name = "rdbKirk";
            this.rdbKirk.Size = new System.Drawing.Size(62, 20);
            this.rdbKirk.TabIndex = 5;
            this.rdbKirk.TabStop = true;
            this.rdbKirk.Text = "40 sn.";
            this.rdbKirk.UseVisualStyleBackColor = true;
            // 
            // rdbOtuz
            // 
            this.rdbOtuz.AutoSize = true;
            this.rdbOtuz.Location = new System.Drawing.Point(16, 81);
            this.rdbOtuz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbOtuz.Name = "rdbOtuz";
            this.rdbOtuz.Size = new System.Drawing.Size(62, 20);
            this.rdbOtuz.TabIndex = 4;
            this.rdbOtuz.TabStop = true;
            this.rdbOtuz.Text = "30 sn.";
            this.rdbOtuz.UseVisualStyleBackColor = true;
            // 
            // rdbYirmi
            // 
            this.rdbYirmi.AutoSize = true;
            this.rdbYirmi.Location = new System.Drawing.Point(16, 54);
            this.rdbYirmi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbYirmi.Name = "rdbYirmi";
            this.rdbYirmi.Size = new System.Drawing.Size(62, 20);
            this.rdbYirmi.TabIndex = 3;
            this.rdbYirmi.TabStop = true;
            this.rdbYirmi.Text = "20 sn.";
            this.rdbYirmi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "SÜRE SEÇİMİ :";
            // 
            // grpOyunEkrani
            // 
            this.grpOyunEkrani.Controls.Add(this.btnTahminEt);
            this.grpOyunEkrani.Controls.Add(this.label1);
            this.grpOyunEkrani.Controls.Add(this.lblSure);
            this.grpOyunEkrani.Controls.Add(this.txtTahmin);
            this.grpOyunEkrani.Controls.Add(this.label5);
            this.grpOyunEkrani.Controls.Add(this.label2);
            this.grpOyunEkrani.Controls.Add(this.lsbYapilanTahminler);
            this.grpOyunEkrani.Controls.Add(this.lblDurum);
            this.grpOyunEkrani.Controls.Add(this.label4);
            this.grpOyunEkrani.Controls.Add(this.btnYeniOyun);
            this.grpOyunEkrani.Controls.Add(this.lblTahminSayisi);
            this.grpOyunEkrani.Controls.Add(this.label3);
            this.grpOyunEkrani.Location = new System.Drawing.Point(7, 202);
            this.grpOyunEkrani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOyunEkrani.Name = "grpOyunEkrani";
            this.grpOyunEkrani.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpOyunEkrani.Size = new System.Drawing.Size(459, 334);
            this.grpOyunEkrani.TabIndex = 13;
            this.grpOyunEkrani.TabStop = false;
            this.grpOyunEkrani.Text = "SAYI TAHMİN OYUNU - OYUN EKRANI";
            // 
            // tmrBoyutlandir
            // 
            this.tmrBoyutlandir.Interval = 5;
            this.tmrBoyutlandir.Tick += new System.EventHandler(this.tmrBoyutlandir_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnTahminEt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 198);
            this.Controls.Add(this.grpOyunEkrani);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpOyunEkrani.ResumeLayout(false);
            this.grpOyunEkrani.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnTahminEt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTahminSayisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lsbYapilanTahminler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer tmrSure;
        private System.Windows.Forms.Timer tmrBravo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAyarlariKaydet;
        private System.Windows.Forms.ListBox lsbTahminAraligi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbKirk;
        private System.Windows.Forms.RadioButton rdbOtuz;
        private System.Windows.Forms.RadioButton rdbYirmi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grpOyunEkrani;
        private System.Windows.Forms.Timer tmrBoyutlandir;
    }
}

