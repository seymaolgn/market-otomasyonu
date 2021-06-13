using market.controller;
using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            User result =controller.login(txt_kullaniciAdi.Text,txt_sifre.Text);
            if(result!=null && result.status==LoginStatus.basarili && result.yetki == "admin")
            {
                AdminPanel admin = new AdminPanel();
                admin.Show();
                this.Hide();
            }
            else if(result != null && result.status == LoginStatus.basarili && result.yetki == "kasiyer")
            {
                KasiyerPanel kasiyer = new KasiyerPanel();
                kasiyer.Show();
                this.Hide();
            }
            else if(result != null && result.status == LoginStatus.basarisiz)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {
            sifreDegistirme sd = new sifreDegistirme();
            sd.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Çıkış Yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread(); 
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
