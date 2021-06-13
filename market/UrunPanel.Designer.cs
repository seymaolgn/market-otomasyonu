
namespace market
{
    partial class UrunPanel
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
            this.btn_geri = new System.Windows.Forms.Button();
            this.btn_kayıtekle = new System.Windows.Forms.Button();
            this.grp_Urun = new System.Windows.Forms.GroupBox();
            this.dateTime_guncellemetarih = new System.Windows.Forms.DateTimePicker();
            this.dateTime_olusturmatrh = new System.Windows.Forms.DateTimePicker();
            this.btn_kayıtguncelle = new System.Windows.Forms.Button();
            this.btn_kayıtSil = new System.Windows.Forms.Button();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_ciro = new System.Windows.Forms.TextBox();
            this.txt_kilo = new System.Windows.Forms.TextBox();
            this.txt_BarkodKod = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_QrKod = new System.Windows.Forms.TextBox();
            this.combo_urunisim = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grp_Urun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_geri
            // 
            this.btn_geri.BackColor = System.Drawing.Color.SlateGray;
            this.btn_geri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geri.Location = new System.Drawing.Point(6, 241);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(81, 32);
            this.btn_geri.TabIndex = 12;
            this.btn_geri.Text = "<";
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // btn_kayıtekle
            // 
            this.btn_kayıtekle.Location = new System.Drawing.Point(577, 241);
            this.btn_kayıtekle.Name = "btn_kayıtekle";
            this.btn_kayıtekle.Size = new System.Drawing.Size(150, 32);
            this.btn_kayıtekle.TabIndex = 10;
            this.btn_kayıtekle.Text = "Kayıt Ekle";
            this.btn_kayıtekle.UseVisualStyleBackColor = true;
            this.btn_kayıtekle.Click += new System.EventHandler(this.btn_kayıtekle_Click);
            // 
            // grp_Urun
            // 
            this.grp_Urun.Controls.Add(this.dateTime_guncellemetarih);
            this.grp_Urun.Controls.Add(this.dateTime_olusturmatrh);
            this.grp_Urun.Controls.Add(this.btn_geri);
            this.grp_Urun.Controls.Add(this.btn_kayıtekle);
            this.grp_Urun.Controls.Add(this.btn_kayıtguncelle);
            this.grp_Urun.Controls.Add(this.btn_kayıtSil);
            this.grp_Urun.Controls.Add(this.txt_fiyat);
            this.grp_Urun.Controls.Add(this.txt_ciro);
            this.grp_Urun.Controls.Add(this.txt_kilo);
            this.grp_Urun.Controls.Add(this.txt_BarkodKod);
            this.grp_Urun.Controls.Add(this.txt_id);
            this.grp_Urun.Controls.Add(this.txt_QrKod);
            this.grp_Urun.Controls.Add(this.combo_urunisim);
            this.grp_Urun.Controls.Add(this.label6);
            this.grp_Urun.Controls.Add(this.label9);
            this.grp_Urun.Controls.Add(this.label4);
            this.grp_Urun.Controls.Add(this.label7);
            this.grp_Urun.Controls.Add(this.label3);
            this.grp_Urun.Controls.Add(this.label5);
            this.grp_Urun.Controls.Add(this.label2);
            this.grp_Urun.Controls.Add(this.label8);
            this.grp_Urun.Controls.Add(this.label1);
            this.grp_Urun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_Urun.Location = new System.Drawing.Point(12, 196);
            this.grp_Urun.Name = "grp_Urun";
            this.grp_Urun.Size = new System.Drawing.Size(881, 375);
            this.grp_Urun.TabIndex = 3;
            this.grp_Urun.TabStop = false;
            this.grp_Urun.Text = "Ürün Panel";
            this.grp_Urun.Enter += new System.EventHandler(this.grp_Urun_Enter);
            // 
            // dateTime_guncellemetarih
            // 
            this.dateTime_guncellemetarih.Location = new System.Drawing.Point(176, 205);
            this.dateTime_guncellemetarih.Name = "dateTime_guncellemetarih";
            this.dateTime_guncellemetarih.Size = new System.Drawing.Size(229, 23);
            this.dateTime_guncellemetarih.TabIndex = 4;
            // 
            // dateTime_olusturmatrh
            // 
            this.dateTime_olusturmatrh.Location = new System.Drawing.Point(177, 161);
            this.dateTime_olusturmatrh.Name = "dateTime_olusturmatrh";
            this.dateTime_olusturmatrh.Size = new System.Drawing.Size(228, 23);
            this.dateTime_olusturmatrh.TabIndex = 3;
            // 
            // btn_kayıtguncelle
            // 
            this.btn_kayıtguncelle.Location = new System.Drawing.Point(436, 241);
            this.btn_kayıtguncelle.Name = "btn_kayıtguncelle";
            this.btn_kayıtguncelle.Size = new System.Drawing.Size(135, 32);
            this.btn_kayıtguncelle.TabIndex = 9;
            this.btn_kayıtguncelle.Text = "Kayıt Güncelle ";
            this.btn_kayıtguncelle.UseVisualStyleBackColor = true;
            this.btn_kayıtguncelle.Click += new System.EventHandler(this.btn_kayıtguncelle_Click);
            // 
            // btn_kayıtSil
            // 
            this.btn_kayıtSil.Location = new System.Drawing.Point(739, 241);
            this.btn_kayıtSil.Name = "btn_kayıtSil";
            this.btn_kayıtSil.Size = new System.Drawing.Size(142, 32);
            this.btn_kayıtSil.TabIndex = 11;
            this.btn_kayıtSil.Text = "Kayıt Sil";
            this.btn_kayıtSil.UseVisualStyleBackColor = true;
            this.btn_kayıtSil.Click += new System.EventHandler(this.btn_kayıtSil_Click);
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(600, 116);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(229, 23);
            this.txt_fiyat.TabIndex = 7;
            // 
            // txt_ciro
            // 
            this.txt_ciro.Location = new System.Drawing.Point(600, 161);
            this.txt_ciro.Name = "txt_ciro";
            this.txt_ciro.Size = new System.Drawing.Size(229, 23);
            this.txt_ciro.TabIndex = 8;
            // 
            // txt_kilo
            // 
            this.txt_kilo.Location = new System.Drawing.Point(600, 74);
            this.txt_kilo.Name = "txt_kilo";
            this.txt_kilo.Size = new System.Drawing.Size(229, 23);
            this.txt_kilo.TabIndex = 6;
            // 
            // txt_BarkodKod
            // 
            this.txt_BarkodKod.Location = new System.Drawing.Point(177, 119);
            this.txt_BarkodKod.Name = "txt_BarkodKod";
            this.txt_BarkodKod.Size = new System.Drawing.Size(228, 23);
            this.txt_BarkodKod.TabIndex = 2;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(177, 32);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(228, 23);
            this.txt_id.TabIndex = 0;
            // 
            // txt_QrKod
            // 
            this.txt_QrKod.Location = new System.Drawing.Point(177, 74);
            this.txt_QrKod.Name = "txt_QrKod";
            this.txt_QrKod.Size = new System.Drawing.Size(228, 23);
            this.txt_QrKod.TabIndex = 1;
            // 
            // combo_urunisim
            // 
            this.combo_urunisim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_urunisim.FormattingEnabled = true;
            this.combo_urunisim.Location = new System.Drawing.Point(600, 31);
            this.combo_urunisim.Name = "combo_urunisim";
            this.combo_urunisim.Size = new System.Drawing.Size(229, 24);
            this.combo_urunisim.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(442, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Fiyat :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(10, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Güncellenme Tarih :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oluşturulma Tarih :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(442, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ciro :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(442, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün İsim :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(442, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kilo :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Barkod Kod :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "İd :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qr Kod :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(881, 178);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // UrunPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(905, 481);
            this.Controls.Add(this.grp_Urun);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UrunPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunPanel";
            this.Load += new System.EventHandler(this.UrunPanel_Load);
            this.grp_Urun.ResumeLayout(false);
            this.grp_Urun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_kayıtekle;
        private System.Windows.Forms.GroupBox grp_Urun;
        private System.Windows.Forms.Button btn_kayıtguncelle;
        private System.Windows.Forms.Button btn_kayıtSil;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_kilo;
        private System.Windows.Forms.TextBox txt_BarkodKod;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_QrKod;
        private System.Windows.Forms.ComboBox combo_urunisim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTime_guncellemetarih;
        private System.Windows.Forms.DateTimePicker dateTime_olusturmatrh;
        private System.Windows.Forms.TextBox txt_ciro;
        private System.Windows.Forms.Label label9;
    }
}