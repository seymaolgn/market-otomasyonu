
namespace market
{
    partial class Kullanici_Panel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grp_kullanıcı = new System.Windows.Forms.GroupBox();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_kayıtekle = new System.Windows.Forms.Button();
            this.btn_kayıtguncelle = new System.Windows.Forms.Button();
            this.btn_kayıtSil = new System.Windows.Forms.Button();
            this.txt_guvenlıkcevabı = new System.Windows.Forms.TextBox();
            this.txt_emailadres = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.combo_guvenlıksorusu = new System.Windows.Forms.ComboBox();
            this.combo_yetki = new System.Windows.Forms.ComboBox();
            this.combo_bolge = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grp_kullanıcı.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(867, 197);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // grp_kullanıcı
            // 
            this.grp_kullanıcı.Controls.Add(this.btn_geri);
            this.grp_kullanıcı.Controls.Add(this.btn_kayıtekle);
            this.grp_kullanıcı.Controls.Add(this.btn_kayıtguncelle);
            this.grp_kullanıcı.Controls.Add(this.btn_kayıtSil);
            this.grp_kullanıcı.Controls.Add(this.txt_guvenlıkcevabı);
            this.grp_kullanıcı.Controls.Add(this.txt_emailadres);
            this.grp_kullanıcı.Controls.Add(this.txt_sifre);
            this.grp_kullanıcı.Controls.Add(this.txt_id);
            this.grp_kullanıcı.Controls.Add(this.txt_kullaniciAdi);
            this.grp_kullanıcı.Controls.Add(this.combo_guvenlıksorusu);
            this.grp_kullanıcı.Controls.Add(this.combo_yetki);
            this.grp_kullanıcı.Controls.Add(this.combo_bolge);
            this.grp_kullanıcı.Controls.Add(this.label6);
            this.grp_kullanıcı.Controls.Add(this.label4);
            this.grp_kullanıcı.Controls.Add(this.label7);
            this.grp_kullanıcı.Controls.Add(this.label3);
            this.grp_kullanıcı.Controls.Add(this.label5);
            this.grp_kullanıcı.Controls.Add(this.label2);
            this.grp_kullanıcı.Controls.Add(this.label8);
            this.grp_kullanıcı.Controls.Add(this.label1);
            this.grp_kullanıcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_kullanıcı.Location = new System.Drawing.Point(12, 232);
            this.grp_kullanıcı.Name = "grp_kullanıcı";
            this.grp_kullanıcı.Size = new System.Drawing.Size(863, 383);
            this.grp_kullanıcı.TabIndex = 1;
            this.grp_kullanıcı.TabStop = false;
            this.grp_kullanıcı.Text = "Kullanıcı Panel";
            this.grp_kullanıcı.Enter += new System.EventHandler(this.grp_kullanıcı_Enter);
            // 
            // btn_geri
            // 
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(30, 246);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(81, 32);
            this.btn_geri.TabIndex = 10;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_kayıtekle
            // 
            this.btn_kayıtekle.Location = new System.Drawing.Point(375, 247);
            this.btn_kayıtekle.Name = "btn_kayıtekle";
            this.btn_kayıtekle.Size = new System.Drawing.Size(189, 32);
            this.btn_kayıtekle.TabIndex = 7;
            this.btn_kayıtekle.Text = "Kayıt Ekle";
            this.btn_kayıtekle.UseVisualStyleBackColor = true;
            this.btn_kayıtekle.Click += new System.EventHandler(this.btn_kayıtekle_Click);
            // 
            // btn_kayıtguncelle
            // 
            this.btn_kayıtguncelle.Location = new System.Drawing.Point(154, 247);
            this.btn_kayıtguncelle.Name = "btn_kayıtguncelle";
            this.btn_kayıtguncelle.Size = new System.Drawing.Size(189, 32);
            this.btn_kayıtguncelle.TabIndex = 8;
            this.btn_kayıtguncelle.Text = "Kayıt Güncelle ";
            this.btn_kayıtguncelle.UseVisualStyleBackColor = true;
            this.btn_kayıtguncelle.Click += new System.EventHandler(this.btn_kayıtguncelle_Click);
            // 
            // btn_kayıtSil
            // 
            this.btn_kayıtSil.Location = new System.Drawing.Point(592, 247);
            this.btn_kayıtSil.Name = "btn_kayıtSil";
            this.btn_kayıtSil.Size = new System.Drawing.Size(189, 32);
            this.btn_kayıtSil.TabIndex = 9;
            this.btn_kayıtSil.Text = "Kayıt Sil";
            this.btn_kayıtSil.UseVisualStyleBackColor = true;
            this.btn_kayıtSil.Click += new System.EventHandler(this.btn_kayıtSil_Click);
            // 
            // txt_guvenlıkcevabı
            // 
            this.txt_guvenlıkcevabı.Location = new System.Drawing.Point(575, 165);
            this.txt_guvenlıkcevabı.Name = "txt_guvenlıkcevabı";
            this.txt_guvenlıkcevabı.Size = new System.Drawing.Size(233, 23);
            this.txt_guvenlıkcevabı.TabIndex = 6;
            // 
            // txt_emailadres
            // 
            this.txt_emailadres.Location = new System.Drawing.Point(575, 82);
            this.txt_emailadres.Name = "txt_emailadres";
            this.txt_emailadres.Size = new System.Drawing.Size(233, 23);
            this.txt_emailadres.TabIndex = 4;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(129, 121);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(234, 23);
            this.txt_sifre.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(129, 34);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(234, 23);
            this.txt_id.TabIndex = 0;
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(129, 76);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(234, 23);
            this.txt_kullaniciAdi.TabIndex = 0;
            // 
            // combo_guvenlıksorusu
            // 
            this.combo_guvenlıksorusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_guvenlıksorusu.FormattingEnabled = true;
            this.combo_guvenlıksorusu.Location = new System.Drawing.Point(575, 120);
            this.combo_guvenlıksorusu.Name = "combo_guvenlıksorusu";
            this.combo_guvenlıksorusu.Size = new System.Drawing.Size(233, 24);
            this.combo_guvenlıksorusu.TabIndex = 5;
            this.combo_guvenlıksorusu.SelectedIndexChanged += new System.EventHandler(this.combo_guvenlıksorusu_SelectedIndexChanged);
            // 
            // combo_yetki
            // 
            this.combo_yetki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_yetki.FormattingEnabled = true;
            this.combo_yetki.Location = new System.Drawing.Point(129, 162);
            this.combo_yetki.Name = "combo_yetki";
            this.combo_yetki.Size = new System.Drawing.Size(234, 24);
            this.combo_yetki.TabIndex = 2;
            // 
            // combo_bolge
            // 
            this.combo_bolge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_bolge.FormattingEnabled = true;
            this.combo_bolge.Location = new System.Drawing.Point(575, 37);
            this.combo_bolge.Name = "combo_bolge";
            this.combo_bolge.Size = new System.Drawing.Size(234, 24);
            this.combo_bolge.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(429, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Güvenlik Sorusu :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yetki :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(429, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Güvenlik Cevabı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(430, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bölge :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(429, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email Adres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(16, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "İd :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // Kullanici_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(878, 543);
            this.Controls.Add(this.grp_kullanıcı);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kullanici_Panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici_Panel";
            this.Load += new System.EventHandler(this.Kullanici_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grp_kullanıcı.ResumeLayout(false);
            this.grp_kullanıcı.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grp_kullanıcı;
        private System.Windows.Forms.Button btn_kayıtekle;
        private System.Windows.Forms.Button btn_kayıtguncelle;
        private System.Windows.Forms.Button btn_kayıtSil;
        private System.Windows.Forms.TextBox txt_guvenlıkcevabı;
        private System.Windows.Forms.TextBox txt_emailadres;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.ComboBox combo_guvenlıksorusu;
        private System.Windows.Forms.ComboBox combo_yetki;
        private System.Windows.Forms.ComboBox combo_bolge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_geri;
    }
}