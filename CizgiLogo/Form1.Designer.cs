namespace CizgiLogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDosyaAdi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toplamKayit = new System.Windows.Forms.Label();
            this.toplamSayi = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.kayitListesi = new System.Windows.Forms.ListBox();
            this.toplamTutarVeri = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.arasTutarVeri = new System.Windows.Forms.Label();
            this.lblTutarKarsilastir = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progresKayit = new System.Windows.Forms.Label();
            this.guncelislem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.basariliSayi = new System.Windows.Forms.Label();
            this.hataliSayi = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.MistyRose;
            this.button1.Location = new System.Drawing.Point(12, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(943, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dosyayı Yükle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Magenta;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dosya Adı :";
            // 
            // lblDosyaAdi
            // 
            this.lblDosyaAdi.AutoSize = true;
            this.lblDosyaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDosyaAdi.Location = new System.Drawing.Point(112, 78);
            this.lblDosyaAdi.Name = "lblDosyaAdi";
            this.lblDosyaAdi.Size = new System.Drawing.Size(16, 24);
            this.lblDosyaAdi.TabIndex = 2;
            this.lblDosyaAdi.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Magenta;
            this.label2.Location = new System.Drawing.Point(12, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Tutar :";
            // 
            // toplamKayit
            // 
            this.toplamKayit.AutoSize = true;
            this.toplamKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamKayit.ForeColor = System.Drawing.Color.Magenta;
            this.toplamKayit.Location = new System.Drawing.Point(767, 78);
            this.toplamKayit.Name = "toplamKayit";
            this.toplamKayit.Size = new System.Drawing.Size(133, 24);
            this.toplamKayit.TabIndex = 4;
            this.toplamKayit.Text = "Toplam Kayıt : ";
            // 
            // toplamSayi
            // 
            this.toplamSayi.AutoSize = true;
            this.toplamSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamSayi.Location = new System.Drawing.Point(891, 78);
            this.toplamSayi.Name = "toplamSayi";
            this.toplamSayi.Size = new System.Drawing.Size(40, 24);
            this.toplamSayi.TabIndex = 5;
            this.toplamSayi.Text = "000";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 152);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(939, 45);
            this.progressBar1.TabIndex = 6;
            // 
            // kayitListesi
            // 
            this.kayitListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitListesi.FormattingEnabled = true;
            this.kayitListesi.ItemHeight = 20;
            this.kayitListesi.Location = new System.Drawing.Point(12, 209);
            this.kayitListesi.Name = "kayitListesi";
            this.kayitListesi.Size = new System.Drawing.Size(943, 284);
            this.kayitListesi.TabIndex = 7;
            // 
            // toplamTutarVeri
            // 
            this.toplamTutarVeri.AutoSize = true;
            this.toplamTutarVeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamTutarVeri.Location = new System.Drawing.Point(150, 507);
            this.toplamTutarVeri.Name = "toplamTutarVeri";
            this.toplamTutarVeri.Size = new System.Drawing.Size(20, 24);
            this.toplamTutarVeri.TabIndex = 8;
            this.toplamTutarVeri.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(12, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "ARAS Tutar :";
            // 
            // arasTutarVeri
            // 
            this.arasTutarVeri.AutoSize = true;
            this.arasTutarVeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arasTutarVeri.Location = new System.Drawing.Point(150, 540);
            this.arasTutarVeri.Name = "arasTutarVeri";
            this.arasTutarVeri.Size = new System.Drawing.Size(20, 24);
            this.arasTutarVeri.TabIndex = 10;
            this.arasTutarVeri.Text = "0";
            // 
            // lblTutarKarsilastir
            // 
            this.lblTutarKarsilastir.AutoSize = true;
            this.lblTutarKarsilastir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutarKarsilastir.ForeColor = System.Drawing.Color.Magenta;
            this.lblTutarKarsilastir.Location = new System.Drawing.Point(12, 573);
            this.lblTutarKarsilastir.Name = "lblTutarKarsilastir";
            this.lblTutarKarsilastir.Size = new System.Drawing.Size(16, 24);
            this.lblTutarKarsilastir.TabIndex = 11;
            this.lblTutarKarsilastir.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 812);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // progresKayit
            // 
            this.progresKayit.AutoSize = true;
            this.progresKayit.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.progresKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.progresKayit.Location = new System.Drawing.Point(450, 161);
            this.progresKayit.Name = "progresKayit";
            this.progresKayit.Size = new System.Drawing.Size(16, 24);
            this.progresKayit.TabIndex = 13;
            this.progresKayit.Text = "-";
            // 
            // guncelislem
            // 
            this.guncelislem.AutoSize = true;
            this.guncelislem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guncelislem.ForeColor = System.Drawing.Color.DarkRed;
            this.guncelislem.Location = new System.Drawing.Point(350, 109);
            this.guncelislem.Name = "guncelislem";
            this.guncelislem.Size = new System.Drawing.Size(0, 29);
            this.guncelislem.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(12, 608);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Başarılı Giriş :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 644);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hatalı Giriş :";
            // 
            // basariliSayi
            // 
            this.basariliSayi.AutoSize = true;
            this.basariliSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.basariliSayi.ForeColor = System.Drawing.Color.Green;
            this.basariliSayi.Location = new System.Drawing.Point(130, 608);
            this.basariliSayi.Name = "basariliSayi";
            this.basariliSayi.Size = new System.Drawing.Size(16, 24);
            this.basariliSayi.TabIndex = 17;
            this.basariliSayi.Text = "-";
            // 
            // hataliSayi
            // 
            this.hataliSayi.AutoSize = true;
            this.hataliSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hataliSayi.ForeColor = System.Drawing.Color.Red;
            this.hataliSayi.Location = new System.Drawing.Point(126, 644);
            this.hataliSayi.Name = "hataliSayi";
            this.hataliSayi.Size = new System.Drawing.Size(16, 24);
            this.hataliSayi.TabIndex = 18;
            this.hataliSayi.Text = "-";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(634, 760);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(853, 760);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 847);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.hataliSayi);
            this.Controls.Add(this.basariliSayi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.guncelislem);
            this.Controls.Add(this.progresKayit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTutarKarsilastir);
            this.Controls.Add(this.arasTutarVeri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toplamTutarVeri);
            this.Controls.Add(this.kayitListesi);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.toplamSayi);
            this.Controls.Add(this.toplamKayit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDosyaAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mert Albüm Xml Yükleyici";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDosyaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label toplamKayit;
        private System.Windows.Forms.Label toplamSayi;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox kayitListesi;
        private System.Windows.Forms.Label toplamTutarVeri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label arasTutarVeri;
        private System.Windows.Forms.Label lblTutarKarsilastir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label progresKayit;
        private System.Windows.Forms.Label guncelislem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label basariliSayi;
        private System.Windows.Forms.Label hataliSayi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
    }
}

