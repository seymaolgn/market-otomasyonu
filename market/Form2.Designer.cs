
namespace market
{
    partial class sifreDegistirme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_kullanıcıAdı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sorgula = new System.Windows.Forms.Button();
            this.cmbo_güvenliksorusu = new System.Windows.Forms.ComboBox();
            this.txt_güvenlikcevap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_yenişifre = new System.Windows.Forms.TextBox();
            this.grpbox_sifreDegistir = new System.Windows.Forms.GroupBox();
            this.btn_şifreyidegistir = new System.Windows.Forms.Button();
            this.txt_şifretekrarla = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpbox_mailalanı = new System.Windows.Forms.GroupBox();
            this.btn_koduonayla = new System.Windows.Forms.Button();
            this.txt_emailadres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_mailkodgndr = new System.Windows.Forms.Button();
            this.txt_doğrulamakodu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_geri = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpbox_sifreDegistir.SuspendLayout();
            this.grpbox_mailalanı.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_geri);
            this.groupBox1.Controls.Add(this.txt_kullanıcıAdı);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_sorgula);
            this.groupBox1.Controls.Add(this.cmbo_güvenliksorusu);
            this.groupBox1.Controls.Add(this.txt_güvenlikcevap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(254, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Güvenlik Sorusu ile Değiştir";
            // 
            // txt_kullanıcıAdı
            // 
            this.txt_kullanıcıAdı.Location = new System.Drawing.Point(119, 41);
            this.txt_kullanıcıAdı.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_kullanıcıAdı.Name = "txt_kullanıcıAdı";
            this.txt_kullanıcıAdı.Size = new System.Drawing.Size(123, 20);
            this.txt_kullanıcıAdı.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kullanıcı Adı :";
            // 
            // btn_sorgula
            // 
            this.btn_sorgula.Location = new System.Drawing.Point(14, 151);
            this.btn_sorgula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_sorgula.Name = "btn_sorgula";
            this.btn_sorgula.Size = new System.Drawing.Size(227, 24);
            this.btn_sorgula.TabIndex = 3;
            this.btn_sorgula.Text = "Sorgula";
            this.btn_sorgula.UseVisualStyleBackColor = true;
            this.btn_sorgula.Click += new System.EventHandler(this.btn_sorgula_Click);
            // 
            // cmbo_güvenliksorusu
            // 
            this.cmbo_güvenliksorusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_güvenliksorusu.FormattingEnabled = true;
            this.cmbo_güvenliksorusu.Location = new System.Drawing.Point(119, 76);
            this.cmbo_güvenliksorusu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbo_güvenliksorusu.Name = "cmbo_güvenliksorusu";
            this.cmbo_güvenliksorusu.Size = new System.Drawing.Size(123, 21);
            this.cmbo_güvenliksorusu.TabIndex = 1;
            this.cmbo_güvenliksorusu.SelectedIndexChanged += new System.EventHandler(this.cmbo_güvenliksorusu_SelectedIndexChanged);
            // 
            // txt_güvenlikcevap
            // 
            this.txt_güvenlikcevap.Location = new System.Drawing.Point(119, 110);
            this.txt_güvenlikcevap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_güvenlikcevap.Name = "txt_güvenlikcevap";
            this.txt_güvenlikcevap.Size = new System.Drawing.Size(123, 20);
            this.txt_güvenlikcevap.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Güvenlik Cevabı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Güvenlik Sorusu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni Şifre :";
            // 
            // txt_yenişifre
            // 
            this.txt_yenişifre.Location = new System.Drawing.Point(109, 35);
            this.txt_yenişifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_yenişifre.Name = "txt_yenişifre";
            this.txt_yenişifre.Size = new System.Drawing.Size(153, 20);
            this.txt_yenişifre.TabIndex = 0;
            // 
            // grpbox_sifreDegistir
            // 
            this.grpbox_sifreDegistir.Controls.Add(this.btn_şifreyidegistir);
            this.grpbox_sifreDegistir.Controls.Add(this.txt_şifretekrarla);
            this.grpbox_sifreDegistir.Controls.Add(this.txt_yenişifre);
            this.grpbox_sifreDegistir.Controls.Add(this.label5);
            this.grpbox_sifreDegistir.Controls.Add(this.label1);
            this.grpbox_sifreDegistir.Enabled = false;
            this.grpbox_sifreDegistir.Location = new System.Drawing.Point(267, 179);
            this.grpbox_sifreDegistir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbox_sifreDegistir.Name = "grpbox_sifreDegistir";
            this.grpbox_sifreDegistir.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbox_sifreDegistir.Size = new System.Drawing.Size(274, 173);
            this.grpbox_sifreDegistir.TabIndex = 4;
            this.grpbox_sifreDegistir.TabStop = false;
            this.grpbox_sifreDegistir.Text = "Şifre Değiştirme Alanı";
            // 
            // btn_şifreyidegistir
            // 
            this.btn_şifreyidegistir.Location = new System.Drawing.Point(194, 98);
            this.btn_şifreyidegistir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_şifreyidegistir.Name = "btn_şifreyidegistir";
            this.btn_şifreyidegistir.Size = new System.Drawing.Size(67, 20);
            this.btn_şifreyidegistir.TabIndex = 2;
            this.btn_şifreyidegistir.Text = "Değiştir";
            this.btn_şifreyidegistir.UseVisualStyleBackColor = true;
            this.btn_şifreyidegistir.Click += new System.EventHandler(this.btn_şifreyidegistir_Click);
            // 
            // txt_şifretekrarla
            // 
            this.txt_şifretekrarla.Location = new System.Drawing.Point(109, 67);
            this.txt_şifretekrarla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_şifretekrarla.Name = "txt_şifretekrarla";
            this.txt_şifretekrarla.Size = new System.Drawing.Size(153, 20);
            this.txt_şifretekrarla.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 71);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifreyi Tekrarla :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // grpbox_mailalanı
            // 
            this.grpbox_mailalanı.Controls.Add(this.btn_koduonayla);
            this.grpbox_mailalanı.Controls.Add(this.txt_emailadres);
            this.grpbox_mailalanı.Controls.Add(this.label6);
            this.grpbox_mailalanı.Controls.Add(this.btn_mailkodgndr);
            this.grpbox_mailalanı.Controls.Add(this.txt_doğrulamakodu);
            this.grpbox_mailalanı.Controls.Add(this.label7);
            this.grpbox_mailalanı.Enabled = false;
            this.grpbox_mailalanı.Location = new System.Drawing.Point(267, 10);
            this.grpbox_mailalanı.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbox_mailalanı.Name = "grpbox_mailalanı";
            this.grpbox_mailalanı.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbox_mailalanı.Size = new System.Drawing.Size(274, 164);
            this.grpbox_mailalanı.TabIndex = 1;
            this.grpbox_mailalanı.TabStop = false;
            this.grpbox_mailalanı.Text = "Mail Bilgileri";
            // 
            // btn_koduonayla
            // 
            this.btn_koduonayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_koduonayla.Location = new System.Drawing.Point(194, 110);
            this.btn_koduonayla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_koduonayla.Name = "btn_koduonayla";
            this.btn_koduonayla.Size = new System.Drawing.Size(68, 20);
            this.btn_koduonayla.TabIndex = 2;
            this.btn_koduonayla.Text = "Onayla";
            this.btn_koduonayla.UseVisualStyleBackColor = true;
            this.btn_koduonayla.Click += new System.EventHandler(this.btn_koduonayla_Click);
            // 
            // txt_emailadres
            // 
            this.txt_emailadres.Location = new System.Drawing.Point(93, 41);
            this.txt_emailadres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_emailadres.Name = "txt_emailadres";
            this.txt_emailadres.Size = new System.Drawing.Size(168, 20);
            this.txt_emailadres.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Email Adresiniz :";
            // 
            // btn_mailkodgndr
            // 
            this.btn_mailkodgndr.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mailkodgndr.Location = new System.Drawing.Point(126, 70);
            this.btn_mailkodgndr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_mailkodgndr.Name = "btn_mailkodgndr";
            this.btn_mailkodgndr.Size = new System.Drawing.Size(135, 22);
            this.btn_mailkodgndr.TabIndex = 3;
            this.btn_mailkodgndr.Text = "Doğrulama Kodu Gönder";
            this.btn_mailkodgndr.UseVisualStyleBackColor = true;
            this.btn_mailkodgndr.Click += new System.EventHandler(this.btn_mailkodgndr_Click);
            // 
            // txt_doğrulamakodu
            // 
            this.txt_doğrulamakodu.Location = new System.Drawing.Point(99, 110);
            this.txt_doğrulamakodu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_doğrulamakodu.Name = "txt_doğrulamakodu";
            this.txt_doğrulamakodu.Size = new System.Drawing.Size(91, 20);
            this.txt_doğrulamakodu.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Doğrulama Kodu :";
            // 
            // btn_geri
            // 
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(7, 309);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 28);
            this.btn_geri.TabIndex = 4;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // sifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 355);
            this.Controls.Add(this.grpbox_mailalanı);
            this.Controls.Add(this.grpbox_sifreDegistir);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "sifreDegistirme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifre Değiştirme";
            this.Load += new System.EventHandler(this.sifreDegistirme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbox_sifreDegistir.ResumeLayout(false);
            this.grpbox_sifreDegistir.PerformLayout();
            this.grpbox_mailalanı.ResumeLayout(false);
            this.grpbox_mailalanı.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_kullanıcıAdı;
        private System.Windows.Forms.GroupBox grpbox_sifreDegistir;
        private System.Windows.Forms.Button btn_şifreyidegistir;
        private System.Windows.Forms.TextBox txt_şifretekrarla;
        private System.Windows.Forms.TextBox txt_yenişifre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sorgula;
        private System.Windows.Forms.ComboBox cmbo_güvenliksorusu;
        private System.Windows.Forms.TextBox txt_güvenlikcevap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpbox_mailalanı;
        private System.Windows.Forms.TextBox txt_emailadres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_mailkodgndr;
        private System.Windows.Forms.Button btn_koduonayla;
        private System.Windows.Forms.TextBox txt_doğrulamakodu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_geri;
    }
}