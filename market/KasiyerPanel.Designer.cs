
namespace market
{
    partial class KasiyerPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasiyerPanel));
            this.btn_et = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_baklagil = new System.Windows.Forms.Button();
            this.btn_süt = new System.Windows.Forms.Button();
            this.btn_meyveSebze = new System.Windows.Forms.Button();
            this.btn_çıkışYap = new System.Windows.Forms.Button();
            this.buttonicon = new System.Windows.Forms.ImageList(this.components);
            this.lbl_saat = new System.Windows.Forms.Label();
            this.lbl_saniye = new System.Windows.Forms.Label();
            this.lbl_dakika = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_et
            // 
            this.btn_et.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_et.ImageKey = "meat.ico";
            this.btn_et.ImageList = this.ımageList1;
            this.btn_et.Location = new System.Drawing.Point(28, 36);
            this.btn_et.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_et.Name = "btn_et";
            this.btn_et.Size = new System.Drawing.Size(108, 110);
            this.btn_et.TabIndex = 0;
            this.btn_et.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "milk.ico");
            this.ımageList1.Images.SetKeyName(1, "fruitandvegatable.ico");
            this.ımageList1.Images.SetKeyName(2, "legume.ico");
            this.ımageList1.Images.SetKeyName(3, "meat.ico");
            this.ımageList1.Images.SetKeyName(4, "Hopstarter-Sleek-Xp-Basic-Close-2.ico");
            // 
            // btn_baklagil
            // 
            this.btn_baklagil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_baklagil.ImageIndex = 2;
            this.btn_baklagil.ImageList = this.ımageList1;
            this.btn_baklagil.Location = new System.Drawing.Point(28, 174);
            this.btn_baklagil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_baklagil.Name = "btn_baklagil";
            this.btn_baklagil.Size = new System.Drawing.Size(108, 109);
            this.btn_baklagil.TabIndex = 2;
            this.btn_baklagil.UseVisualStyleBackColor = true;
            // 
            // btn_süt
            // 
            this.btn_süt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_süt.ImageKey = "milk.ico";
            this.btn_süt.ImageList = this.ımageList1;
            this.btn_süt.Location = new System.Drawing.Point(163, 36);
            this.btn_süt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_süt.Name = "btn_süt";
            this.btn_süt.Size = new System.Drawing.Size(108, 110);
            this.btn_süt.TabIndex = 1;
            this.btn_süt.UseVisualStyleBackColor = true;
            // 
            // btn_meyveSebze
            // 
            this.btn_meyveSebze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_meyveSebze.ImageKey = "fruitandvegatable.ico";
            this.btn_meyveSebze.ImageList = this.ımageList1;
            this.btn_meyveSebze.Location = new System.Drawing.Point(163, 174);
            this.btn_meyveSebze.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_meyveSebze.Name = "btn_meyveSebze";
            this.btn_meyveSebze.Size = new System.Drawing.Size(108, 109);
            this.btn_meyveSebze.TabIndex = 3;
            this.btn_meyveSebze.UseVisualStyleBackColor = true;
            this.btn_meyveSebze.Click += new System.EventHandler(this.btn_meyveSebze_Click);
            // 
            // btn_çıkışYap
            // 
            this.btn_çıkışYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_çıkışYap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_çıkışYap.ImageKey = "Hopstarter-Sleek-Xp-Basic-Close-2.ico";
            this.btn_çıkışYap.ImageList = this.buttonicon;
            this.btn_çıkışYap.Location = new System.Drawing.Point(195, 305);
            this.btn_çıkışYap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_çıkışYap.Name = "btn_çıkışYap";
            this.btn_çıkışYap.Size = new System.Drawing.Size(76, 27);
            this.btn_çıkışYap.TabIndex = 4;
            this.btn_çıkışYap.Text = "Çıkış Yap";
            this.btn_çıkışYap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_çıkışYap.UseVisualStyleBackColor = true;
            this.btn_çıkışYap.Click += new System.EventHandler(this.btn_çıkışYap_Click);
            // 
            // buttonicon
            // 
            this.buttonicon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonicon.ImageStream")));
            this.buttonicon.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonicon.Images.SetKeyName(0, "Hopstarter-Sleek-Xp-Basic-Close-2.ico");
            // 
            // lbl_saat
            // 
            this.lbl_saat.AutoSize = true;
            this.lbl_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saat.Location = new System.Drawing.Point(201, 8);
            this.lbl_saat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_saat.Name = "lbl_saat";
            this.lbl_saat.Size = new System.Drawing.Size(29, 13);
            this.lbl_saat.TabIndex = 5;
            this.lbl_saat.Text = "00 :";
            // 
            // lbl_saniye
            // 
            this.lbl_saniye.AutoSize = true;
            this.lbl_saniye.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_saniye.Location = new System.Drawing.Point(253, 8);
            this.lbl_saniye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_saniye.Name = "lbl_saniye";
            this.lbl_saniye.Size = new System.Drawing.Size(21, 13);
            this.lbl_saniye.TabIndex = 5;
            this.lbl_saniye.Text = "00";
            // 
            // lbl_dakika
            // 
            this.lbl_dakika.AutoSize = true;
            this.lbl_dakika.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dakika.Location = new System.Drawing.Point(225, 8);
            this.lbl_dakika.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_dakika.Name = "lbl_dakika";
            this.lbl_dakika.Size = new System.Drawing.Size(29, 13);
            this.lbl_dakika.TabIndex = 5;
            this.lbl_dakika.Text = "00 :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // KasiyerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 351);
            this.Controls.Add(this.lbl_dakika);
            this.Controls.Add(this.lbl_saniye);
            this.Controls.Add(this.lbl_saat);
            this.Controls.Add(this.btn_çıkışYap);
            this.Controls.Add(this.btn_baklagil);
            this.Controls.Add(this.btn_meyveSebze);
            this.Controls.Add(this.btn_süt);
            this.Controls.Add(this.btn_et);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "KasiyerPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Kasiyer Panel";
            this.Load += new System.EventHandler(this.KasiyerPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_et;
        private System.Windows.Forms.Button btn_baklagil;
        private System.Windows.Forms.Button btn_süt;
        private System.Windows.Forms.Button btn_meyveSebze;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_çıkışYap;
        private System.Windows.Forms.Label lbl_saat;
        private System.Windows.Forms.Label lbl_saniye;
        private System.Windows.Forms.Label lbl_dakika;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList buttonicon;
    }
}