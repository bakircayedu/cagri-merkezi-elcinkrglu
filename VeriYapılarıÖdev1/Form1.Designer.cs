
namespace VeriYapılarıÖdev1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMusteriTanımlayıcısı = new System.Windows.Forms.Label();
            this.txtMusteriID = new System.Windows.Forms.TextBox();
            this.btnAramaYap = new System.Windows.Forms.Button();
            this.lblMusteriTuru = new System.Windows.Forms.Label();
            this.cbTicari = new System.Windows.Forms.CheckBox();
            this.cbBireysel = new System.Windows.Forms.CheckBox();
            this.btnCagriBitir = new System.Windows.Forms.Button();
            this.btnCagriAta = new System.Windows.Forms.Button();
            this.btnCagriBilgileri = new System.Windows.Forms.Button();
            this.grbAramaveCagriEkleme = new System.Windows.Forms.GroupBox();
            this.lbAramaListesi = new System.Windows.Forms.ListBox();
            this.gbCagriBilgileri = new System.Windows.Forms.GroupBox();
            this.lbCagriBilgileri = new System.Windows.Forms.ListBox();
            this.lbBireyselCagriListesi = new System.Windows.Forms.ListBox();
            this.lbticariCagriListesi = new System.Windows.Forms.ListBox();
            this.gbCagriEkleme = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMusteriID2 = new System.Windows.Forms.TextBox();
            this.AramaEkle = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tPNotlar = new System.Windows.Forms.TabPage();
            this.gbNotlar = new System.Windows.Forms.GroupBox();
            this.lblTemsilciID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtMusteri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNotlar = new System.Windows.Forms.TextBox();
            this.lblNotlar = new System.Windows.Forms.Label();
            this.btnNotlar = new System.Windows.Forms.Button();
            this.tpNotAra = new System.Windows.Forms.TabPage();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.lblAranan = new System.Windows.Forms.Label();
            this.btnNotAra = new System.Windows.Forms.Button();
            this.grbAramaveCagriEkleme.SuspendLayout();
            this.gbCagriBilgileri.SuspendLayout();
            this.gbCagriEkleme.SuspendLayout();
            this.AramaEkle.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tPNotlar.SuspendLayout();
            this.gbNotlar.SuspendLayout();
            this.tpNotAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMusteriTanımlayıcısı
            // 
            this.lblMusteriTanımlayıcısı.AutoSize = true;
            this.lblMusteriTanımlayıcısı.Location = new System.Drawing.Point(6, 52);
            this.lblMusteriTanımlayıcısı.Name = "lblMusteriTanımlayıcısı";
            this.lblMusteriTanımlayıcısı.Size = new System.Drawing.Size(71, 17);
            this.lblMusteriTanımlayıcısı.TabIndex = 0;
            this.lblMusteriTanımlayıcısı.Text = "Müşteri ID";
            // 
            // txtMusteriID
            // 
            this.txtMusteriID.Location = new System.Drawing.Point(133, 52);
            this.txtMusteriID.Name = "txtMusteriID";
            this.txtMusteriID.Size = new System.Drawing.Size(209, 22);
            this.txtMusteriID.TabIndex = 1;
            // 
            // btnAramaYap
            // 
            this.btnAramaYap.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAramaYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAramaYap.Location = new System.Drawing.Point(412, 41);
            this.btnAramaYap.Name = "btnAramaYap";
            this.btnAramaYap.Size = new System.Drawing.Size(164, 30);
            this.btnAramaYap.TabIndex = 2;
            this.btnAramaYap.Text = "Arama Yap";
            this.btnAramaYap.UseVisualStyleBackColor = false;
            this.btnAramaYap.Click += new System.EventHandler(this.btnAramaYap_Click);
            // 
            // lblMusteriTuru
            // 
            this.lblMusteriTuru.AutoSize = true;
            this.lblMusteriTuru.Location = new System.Drawing.Point(6, 89);
            this.lblMusteriTuru.Name = "lblMusteriTuru";
            this.lblMusteriTuru.Size = new System.Drawing.Size(88, 17);
            this.lblMusteriTuru.TabIndex = 3;
            this.lblMusteriTuru.Text = "Müşteri Türü";
            // 
            // cbTicari
            // 
            this.cbTicari.AutoSize = true;
            this.cbTicari.Location = new System.Drawing.Point(277, 85);
            this.cbTicari.Name = "cbTicari";
            this.cbTicari.Size = new System.Drawing.Size(65, 21);
            this.cbTicari.TabIndex = 4;
            this.cbTicari.Text = "Ticari";
            this.cbTicari.UseVisualStyleBackColor = true;
            // 
            // cbBireysel
            // 
            this.cbBireysel.AutoSize = true;
            this.cbBireysel.Location = new System.Drawing.Point(133, 85);
            this.cbBireysel.Name = "cbBireysel";
            this.cbBireysel.Size = new System.Drawing.Size(80, 21);
            this.cbBireysel.TabIndex = 5;
            this.cbBireysel.Text = "Bireysel";
            this.cbBireysel.UseVisualStyleBackColor = true;
            // 
            // btnCagriBitir
            // 
            this.btnCagriBitir.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnCagriBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCagriBitir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCagriBitir.Location = new System.Drawing.Point(82, 231);
            this.btnCagriBitir.Name = "btnCagriBitir";
            this.btnCagriBitir.Size = new System.Drawing.Size(456, 57);
            this.btnCagriBitir.TabIndex = 6;
            this.btnCagriBitir.Text = "Çağrı Bitir";
            this.btnCagriBitir.UseVisualStyleBackColor = false;
            this.btnCagriBitir.Click += new System.EventHandler(this.btnCagriBitir_Click);
            // 
            // btnCagriAta
            // 
            this.btnCagriAta.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCagriAta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCagriAta.Location = new System.Drawing.Point(133, 153);
            this.btnCagriAta.Name = "btnCagriAta";
            this.btnCagriAta.Size = new System.Drawing.Size(164, 33);
            this.btnCagriAta.TabIndex = 7;
            this.btnCagriAta.Text = "Çağrı Ata";
            this.btnCagriAta.UseVisualStyleBackColor = false;
            this.btnCagriAta.Click += new System.EventHandler(this.btnCagriAta_Click);
            // 
            // btnCagriBilgileri
            // 
            this.btnCagriBilgileri.BackColor = System.Drawing.Color.DarkGreen;
            this.btnCagriBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCagriBilgileri.Location = new System.Drawing.Point(121, 30);
            this.btnCagriBilgileri.Name = "btnCagriBilgileri";
            this.btnCagriBilgileri.Size = new System.Drawing.Size(303, 42);
            this.btnCagriBilgileri.TabIndex = 10;
            this.btnCagriBilgileri.Text = "Çağrı Bilgileri";
            this.btnCagriBilgileri.UseVisualStyleBackColor = false;
            this.btnCagriBilgileri.Click += new System.EventHandler(this.btnCagriBilgileri_Click);
            // 
            // grbAramaveCagriEkleme
            // 
            this.grbAramaveCagriEkleme.Controls.Add(this.lbAramaListesi);
            this.grbAramaveCagriEkleme.Controls.Add(this.lblMusteriTanımlayıcısı);
            this.grbAramaveCagriEkleme.Controls.Add(this.txtMusteriID);
            this.grbAramaveCagriEkleme.Controls.Add(this.btnAramaYap);
            this.grbAramaveCagriEkleme.Location = new System.Drawing.Point(14, 27);
            this.grbAramaveCagriEkleme.Name = "grbAramaveCagriEkleme";
            this.grbAramaveCagriEkleme.Size = new System.Drawing.Size(699, 283);
            this.grbAramaveCagriEkleme.TabIndex = 11;
            this.grbAramaveCagriEkleme.TabStop = false;
            this.grbAramaveCagriEkleme.Text = "Arama Ekleme";
            // 
            // lbAramaListesi
            // 
            this.lbAramaListesi.FormattingEnabled = true;
            this.lbAramaListesi.ItemHeight = 16;
            this.lbAramaListesi.Location = new System.Drawing.Point(6, 97);
            this.lbAramaListesi.Name = "lbAramaListesi";
            this.lbAramaListesi.Size = new System.Drawing.Size(582, 164);
            this.lbAramaListesi.TabIndex = 8;
            // 
            // gbCagriBilgileri
            // 
            this.gbCagriBilgileri.Controls.Add(this.lbCagriBilgileri);
            this.gbCagriBilgileri.Controls.Add(this.btnCagriBilgileri);
            this.gbCagriBilgileri.Location = new System.Drawing.Point(35, 36);
            this.gbCagriBilgileri.Name = "gbCagriBilgileri";
            this.gbCagriBilgileri.Size = new System.Drawing.Size(552, 255);
            this.gbCagriBilgileri.TabIndex = 12;
            this.gbCagriBilgileri.TabStop = false;
            this.gbCagriBilgileri.Text = "Çağrı Bilgileri";
            // 
            // lbCagriBilgileri
            // 
            this.lbCagriBilgileri.FormattingEnabled = true;
            this.lbCagriBilgileri.ItemHeight = 16;
            this.lbCagriBilgileri.Location = new System.Drawing.Point(92, 99);
            this.lbCagriBilgileri.Name = "lbCagriBilgileri";
            this.lbCagriBilgileri.Size = new System.Drawing.Size(374, 84);
            this.lbCagriBilgileri.TabIndex = 11;
            // 
            // lbBireyselCagriListesi
            // 
            this.lbBireyselCagriListesi.FormattingEnabled = true;
            this.lbBireyselCagriListesi.ItemHeight = 16;
            this.lbBireyselCagriListesi.Location = new System.Drawing.Point(361, 38);
            this.lbBireyselCagriListesi.Name = "lbBireyselCagriListesi";
            this.lbBireyselCagriListesi.Size = new System.Drawing.Size(235, 52);
            this.lbBireyselCagriListesi.TabIndex = 10;
            // 
            // lbticariCagriListesi
            // 
            this.lbticariCagriListesi.FormattingEnabled = true;
            this.lbticariCagriListesi.ItemHeight = 16;
            this.lbticariCagriListesi.Location = new System.Drawing.Point(361, 128);
            this.lbticariCagriListesi.Name = "lbticariCagriListesi";
            this.lbticariCagriListesi.Size = new System.Drawing.Size(235, 68);
            this.lbticariCagriListesi.TabIndex = 11;
            // 
            // gbCagriEkleme
            // 
            this.gbCagriEkleme.Controls.Add(this.label1);
            this.gbCagriEkleme.Controls.Add(this.lbticariCagriListesi);
            this.gbCagriEkleme.Controls.Add(this.txtMusteriID2);
            this.gbCagriEkleme.Controls.Add(this.btnCagriBitir);
            this.gbCagriEkleme.Controls.Add(this.cbBireysel);
            this.gbCagriEkleme.Controls.Add(this.lbBireyselCagriListesi);
            this.gbCagriEkleme.Controls.Add(this.cbTicari);
            this.gbCagriEkleme.Controls.Add(this.lblMusteriTuru);
            this.gbCagriEkleme.Controls.Add(this.btnCagriAta);
            this.gbCagriEkleme.Location = new System.Drawing.Point(18, 15);
            this.gbCagriEkleme.Name = "gbCagriEkleme";
            this.gbCagriEkleme.Size = new System.Drawing.Size(602, 333);
            this.gbCagriEkleme.TabIndex = 13;
            this.gbCagriEkleme.TabStop = false;
            this.gbCagriEkleme.Text = "Çağrı Ekleme";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müşteri ID";
            // 
            // txtMusteriID2
            // 
            this.txtMusteriID2.Location = new System.Drawing.Point(133, 38);
            this.txtMusteriID2.Name = "txtMusteriID2";
            this.txtMusteriID2.Size = new System.Drawing.Size(209, 22);
            this.txtMusteriID2.TabIndex = 7;
            // 
            // AramaEkle
            // 
            this.AramaEkle.Controls.Add(this.tabPage1);
            this.AramaEkle.Controls.Add(this.tabPage2);
            this.AramaEkle.Controls.Add(this.tabPage3);
            this.AramaEkle.Controls.Add(this.tPNotlar);
            this.AramaEkle.Controls.Add(this.tpNotAra);
            this.AramaEkle.Location = new System.Drawing.Point(85, 12);
            this.AramaEkle.Name = "AramaEkle";
            this.AramaEkle.SelectedIndex = 0;
            this.AramaEkle.Size = new System.Drawing.Size(634, 393);
            this.AramaEkle.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grbAramaveCagriEkleme);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arama Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbCagriEkleme);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çağrı Ekle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbCagriBilgileri);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(626, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Çağrı Özellikleri";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tPNotlar
            // 
            this.tPNotlar.Controls.Add(this.gbNotlar);
            this.tPNotlar.Location = new System.Drawing.Point(4, 25);
            this.tPNotlar.Name = "tPNotlar";
            this.tPNotlar.Padding = new System.Windows.Forms.Padding(3);
            this.tPNotlar.Size = new System.Drawing.Size(626, 364);
            this.tPNotlar.TabIndex = 3;
            this.tPNotlar.Text = "Notlar";
            this.tPNotlar.UseVisualStyleBackColor = true;
            // 
            // gbNotlar
            // 
            this.gbNotlar.Controls.Add(this.btnNotlar);
            this.gbNotlar.Controls.Add(this.txtNotlar);
            this.gbNotlar.Controls.Add(this.lblNotlar);
            this.gbNotlar.Controls.Add(this.txtMusteri);
            this.gbNotlar.Controls.Add(this.label2);
            this.gbNotlar.Controls.Add(this.textBox1);
            this.gbNotlar.Controls.Add(this.lblTemsilciID);
            this.gbNotlar.Location = new System.Drawing.Point(39, 46);
            this.gbNotlar.Name = "gbNotlar";
            this.gbNotlar.Size = new System.Drawing.Size(535, 277);
            this.gbNotlar.TabIndex = 0;
            this.gbNotlar.TabStop = false;
            this.gbNotlar.Text = "Notlar";
            // 
            // lblTemsilciID
            // 
            this.lblTemsilciID.AutoSize = true;
            this.lblTemsilciID.Location = new System.Drawing.Point(25, 52);
            this.lblTemsilciID.Name = "lblTemsilciID";
            this.lblTemsilciID.Size = new System.Drawing.Size(124, 17);
            this.lblTemsilciID.TabIndex = 0;
            this.lblTemsilciID.Text = "Musteri Temsilci Id";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 22);
            this.textBox1.TabIndex = 1;
            // 
            // txtMusteri
            // 
            this.txtMusteri.Location = new System.Drawing.Point(215, 107);
            this.txtMusteri.Name = "txtMusteri";
            this.txtMusteri.Size = new System.Drawing.Size(250, 22);
            this.txtMusteri.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Musteri Id";
            // 
            // txtNotlar
            // 
            this.txtNotlar.Location = new System.Drawing.Point(215, 154);
            this.txtNotlar.Multiline = true;
            this.txtNotlar.Name = "txtNotlar";
            this.txtNotlar.Size = new System.Drawing.Size(250, 83);
            this.txtNotlar.TabIndex = 5;
            // 
            // lblNotlar
            // 
            this.lblNotlar.AutoSize = true;
            this.lblNotlar.Location = new System.Drawing.Point(25, 183);
            this.lblNotlar.Name = "lblNotlar";
            this.lblNotlar.Size = new System.Drawing.Size(46, 17);
            this.lblNotlar.TabIndex = 4;
            this.lblNotlar.Text = "Notlar";
            // 
            // btnNotlar
            // 
            this.btnNotlar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNotlar.Location = new System.Drawing.Point(28, 230);
            this.btnNotlar.Name = "btnNotlar";
            this.btnNotlar.Size = new System.Drawing.Size(152, 28);
            this.btnNotlar.TabIndex = 6;
            this.btnNotlar.Text = "Not Ekle";
            this.btnNotlar.UseVisualStyleBackColor = false;
            this.btnNotlar.Click += new System.EventHandler(this.btnNotlar_Click);
            // 
            // tpNotAra
            // 
            this.tpNotAra.Controls.Add(this.btnNotAra);
            this.tpNotAra.Controls.Add(this.lblAranan);
            this.tpNotAra.Controls.Add(this.txtAranan);
            this.tpNotAra.Location = new System.Drawing.Point(4, 25);
            this.tpNotAra.Name = "tpNotAra";
            this.tpNotAra.Padding = new System.Windows.Forms.Padding(3);
            this.tpNotAra.Size = new System.Drawing.Size(626, 364);
            this.tpNotAra.TabIndex = 4;
            this.tpNotAra.Text = "Not Ara";
            this.tpNotAra.UseVisualStyleBackColor = true;
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(47, 79);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(447, 22);
            this.txtAranan.TabIndex = 0;
            // 
            // lblAranan
            // 
            this.lblAranan.AutoSize = true;
            this.lblAranan.Location = new System.Drawing.Point(47, 39);
            this.lblAranan.Name = "lblAranan";
            this.lblAranan.Size = new System.Drawing.Size(167, 17);
            this.lblAranan.TabIndex = 1;
            this.lblAranan.Text = "Aranacak kelimeyi giriniz.";
            // 
            // btnNotAra
            // 
            this.btnNotAra.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnNotAra.Location = new System.Drawing.Point(50, 139);
            this.btnNotAra.Name = "btnNotAra";
            this.btnNotAra.Size = new System.Drawing.Size(453, 53);
            this.btnNotAra.TabIndex = 2;
            this.btnNotAra.Text = "Not Ara";
            this.btnNotAra.UseVisualStyleBackColor = false;
            this.btnNotAra.Click += new System.EventHandler(this.btnNotAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 492);
            this.Controls.Add(this.AramaEkle);
            this.Name = "Form1";
            this.Text = "Çağrı Merkezine Hoşgeldiniz!!";
            this.grbAramaveCagriEkleme.ResumeLayout(false);
            this.grbAramaveCagriEkleme.PerformLayout();
            this.gbCagriBilgileri.ResumeLayout(false);
            this.gbCagriEkleme.ResumeLayout(false);
            this.gbCagriEkleme.PerformLayout();
            this.AramaEkle.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tPNotlar.ResumeLayout(false);
            this.gbNotlar.ResumeLayout(false);
            this.gbNotlar.PerformLayout();
            this.tpNotAra.ResumeLayout(false);
            this.tpNotAra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriTanımlayıcısı;
        private System.Windows.Forms.TextBox txtMusteriID;
        private System.Windows.Forms.Button btnAramaYap;
        private System.Windows.Forms.Label lblMusteriTuru;
        private System.Windows.Forms.CheckBox cbTicari;
        private System.Windows.Forms.CheckBox cbBireysel;
        private System.Windows.Forms.Button btnCagriBitir;
        private System.Windows.Forms.Button btnCagriAta;
        private System.Windows.Forms.Button btnCagriBilgileri;
        private System.Windows.Forms.GroupBox grbAramaveCagriEkleme;
        private System.Windows.Forms.GroupBox gbCagriBilgileri;
        private System.Windows.Forms.ListBox lbCagriBilgileri;
        private System.Windows.Forms.ListBox lbticariCagriListesi;
        private System.Windows.Forms.ListBox lbBireyselCagriListesi;
        private System.Windows.Forms.ListBox lbAramaListesi;
        private System.Windows.Forms.GroupBox gbCagriEkleme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriID2;
        private System.Windows.Forms.TabControl AramaEkle;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tPNotlar;
        private System.Windows.Forms.GroupBox gbNotlar;
        private System.Windows.Forms.TextBox txtNotlar;
        private System.Windows.Forms.Label lblNotlar;
        private System.Windows.Forms.TextBox txtMusteri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTemsilciID;
        private System.Windows.Forms.Button btnNotlar;
        private System.Windows.Forms.TabPage tpNotAra;
        private System.Windows.Forms.Label lblAranan;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Button btnNotAra;
    }
}

