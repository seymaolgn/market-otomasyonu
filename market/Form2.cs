using market.controller;
using market.enumaration;
using market.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market
{
    public partial class sifreDegistirme : Form
    {
        int code;
        public sifreDegistirme()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbo_güvenliksorusu_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void sifreDegistirme_Load(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            List<LoginTable> loginTableLıst = controller.getLoginTable();
            foreach(LoginTable lt in loginTableLıst)
            {
                cmbo_güvenliksorusu.Items.Add(lt.guvenlikSorusu.ToString());
            }
            cmbo_güvenliksorusu.SelectedIndex = 0;
        }

        private void btn_sorgula_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            LoginStatus result =controller.doAuthentication(txt_kullanıcıAdı.Text.Trim().ToLower(), cmbo_güvenliksorusu.Text, txt_güvenlikcevap.Text.ToLower());
            if (result == LoginStatus.basarili)
            {
                grpbox_mailalanı.Enabled = true;
            }
            else if(result==LoginStatus.basarisiz)
            {
                MessageBox.Show("Girdiginiz Bilgileri Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Tüm Alanları Doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_mailkodgndr_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            code = rnd.Next(111111, 999999);
            MailAddress mailAlan = new MailAddress(txt_emailadres.Text, txt_kullanıcıAdı.Text);
            MailAddress mailGönderen = new MailAddress("aliyolcu51@hotmail.com", "Ali Yolcu");
            MailMessage mesaj = new MailMessage();
            
            mesaj.To.Add(mailAlan);
            mesaj.From = mailGönderen;
            mesaj.Subject = "Şifre Değiştirme";
            mesaj.Body = "Şifre değiştirme işlemi için doğrulama kodunuz : " + code;
           
            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential("aliyolcu51@hotmail.com", "Yolculuk123");
            smtp.EnableSsl = true;
            smtp.Send(mesaj);
            MessageBox.Show("Doğrulama Kodu Gönderildi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_koduonayla_Click(object sender, EventArgs e)
        {
            if (txt_doğrulamakodu.Text == code.ToString())
            {
                grpbox_sifreDegistir.Enabled = true;
            }
            else
            {
                MessageBox.Show("Doğrulama Kodunuz Yanlıştır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_şifreyidegistir_Click(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            if (txt_yenişifre.Text == txt_şifretekrarla.Text)
            {
              LoginStatus result=controller.changePassword(txt_kullanıcıAdı.Text, txt_yenişifre.Text);
                if (result == LoginStatus.basarili)
                {
                    MessageBox.Show("Şifreniz Değiştirilmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Gerekli Alanları Doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                    MessageBox.Show("İki şifre birbirleriyle uyuşmuyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
