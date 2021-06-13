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
    public partial class Kullanici_Panel : Form
    {
        Controller controller = new Controller();
        public Kullanici_Panel()
        {
            InitializeComponent();
        }

        private void Kullanici_Panel_Load(object sender, EventArgs e)
        {
            defaultDegerleridoldur();
            kullanıcılarıGetir();
        }
        private void defaultDegerleridoldur()
        {
            combo_yetki.Items.Add("admin");
            combo_yetki.Items.Add("kasiyer");
            combo_yetki.SelectedIndex = 0;
            combo_bolge.Items.Add("Adalar");
            combo_bolge.Items.Add("Arnavutköy");
            combo_bolge.Items.Add("Avcılar");
            combo_bolge.Items.Add("Bağcılar");
            combo_bolge.Items.Add("Bakırköy");
            combo_bolge.Items.Add("Çekmeköy");
            combo_bolge.Items.Add("Sancaktepe");
            combo_bolge.Items.Add("Çatalca");
            combo_bolge.Items.Add("Beyoğlu");
            combo_bolge.SelectedIndex = 0;
            combo_guvenlıksorusu.Items.Add("En sevdiğiniz Hayvan Nedir?");
            combo_guvenlıksorusu.Items.Add("En Sevdiğiniz Araba? ");
            combo_guvenlıksorusu.Items.Add("İlkokul öğretmeninizin ismi nedir?");
            combo_guvenlıksorusu.Items.Add("En sevdiğiniz hayvanın ismi nedir?");
            combo_guvenlıksorusu.Items.Add("Annenizin kızlık soyadı nedir?");
            combo_guvenlıksorusu.Items.Add("Çocukluk lakabınız nedir?");
            combo_guvenlıksorusu.Items.Add("İlk yolculuğunuz nereye gerçekleşti?");
            combo_guvenlıksorusu.Items.Add("İlk telefonunuzun modeli nedir?");
            combo_guvenlıksorusu.Items.Add("İlk aracınızın modeli nedir?");
            combo_guvenlıksorusu.SelectedIndex = 0;
        }
        public void kullanıcılarıGetir()
        {
            dataGridView1.DataSource = controller.getLoginTable();
        }

        private void btn_kayıtekle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifre.Text;
            user.yetki = combo_yetki.Text;
            user.bolge = combo_bolge.Text;
            user.emailAdres = txt_emailadres.Text;
            user.guvenlikSorusu = combo_guvenlıksorusu.Text;
            user.guvenlikCevabı = txt_guvenlıkcevabı.Text;
            LoginStatus result =controller.kayıtEkle(user);
            
            if (result == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt Eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.getLoginTable();
            }
            else
            {
                MessageBox.Show("Gerekli alanların hepsini doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kullaniciAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            combo_yetki.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            combo_bolge.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_emailadres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            combo_guvenlıksorusu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_guvenlıkcevabı.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_kayıtguncelle_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.id = int.Parse(txt_id.Text);
            user.kullaniciAdi = txt_kullaniciAdi.Text;
            user.sifre = txt_sifre.Text;
            user.yetki = combo_yetki.Text;
            user.bolge = combo_bolge.Text;
            user.emailAdres = txt_emailadres.Text;
            user.guvenlikSorusu = combo_guvenlıksorusu.Text;
            user.guvenlikCevabı = txt_guvenlıkcevabı.Text;
            LoginStatus result =controller.kullaniciGuncelle(user);
            if (result == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.getLoginTable();
            }
            else
            {
                MessageBox.Show("Kayıt Güncellenirken Hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grp_kullanıcı_Enter(object sender, EventArgs e)
        {

        }

        private void btn_kayıtSil_Click(object sender, EventArgs e)
        {

            LoginStatus result=controller.kullaniciSil(int.Parse(txt_id.Text));
            if (result == LoginStatus.basarili)
            {
                MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.getLoginTable();
            }
            else if(result==LoginStatus.basarisiz)
            {
                MessageBox.Show("Kayıt silinirken bir hata oluştu!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz id değerini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }

        private void combo_guvenlıksorusu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
