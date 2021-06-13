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
    public partial class UrunPanel : Form
    {
        Controller controller = new Controller();
        public UrunPanel()
        {
            InitializeComponent();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.Show();
            this.Hide();
        }

        private void grp_Urun_Enter(object sender, EventArgs e)
        {

        }

        private void UrunPanel_Load(object sender, EventArgs e)
        {
            tumurunleriGetir();
            defaultAlanlarıDoldur();
        }
        public void defaultAlanlarıDoldur()
        {
            combo_urunisim.Items.Add("Elma");
            combo_urunisim.Items.Add("Muz");
            combo_urunisim.Items.Add("Brokoli");
            combo_urunisim.Items.Add("Üzüm");
            combo_urunisim.Items.Add("Lahana");
            combo_urunisim.Items.Add("Portakal");
            combo_urunisim.Items.Add("Çilek");
        }
        public void tumurunleriGetir()
        {
            dataGridView1.DataSource = controller.tumUrunleriGetir();
        }

        private void btn_kayıtekle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.id = txt_id.Text;
            urun.qrkod = txt_QrKod.Text;
            urun.barkodKod = txt_BarkodKod.Text;
            urun.olusturmaTarih = dateTime_olusturmatrh.Value;
            urun.güncellemeTarih = dateTime_guncellemetarih.Value;
            urun.urunIsim = combo_urunisim.Text;
            urun.kilo = int.Parse(txt_kilo.Text);
            urun.fiyat = int.Parse(txt_fiyat.Text);
            urun.ciro = int.Parse(txt_ciro.Text);
            LoginStatus result=controller.urunekle(urun);
            if (result == LoginStatus.basarili)
            {
               MessageBox.Show("Ürün eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               dataGridView1.DataSource=controller.tumUrunleriGetir();
            }
            else if (result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Ürün eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gerekli tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_QrKod.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_BarkodKod.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTime_olusturmatrh.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (!string.IsNullOrEmpty(dataGridView1.CurrentRow.Cells[4].Value.ToString()))
            {
                dateTime_guncellemetarih.Value= DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            }
            else
            {

            }
            combo_urunisim.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_kilo.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_fiyat.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_ciro.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void btn_kayıtguncelle_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.id = txt_id.Text;
            urun.qrkod = txt_QrKod.Text;
            urun.barkodKod = txt_BarkodKod.Text;
            urun.olusturmaTarih = dateTime_olusturmatrh.Value;
            urun.güncellemeTarih = dateTime_guncellemetarih.Value;
            urun.urunIsim = combo_urunisim.Text;
            urun.kilo = int.Parse(txt_kilo.Text);
            urun.fiyat = int.Parse(txt_fiyat.Text);
            urun.ciro = int.Parse(txt_ciro.Text);
            LoginStatus result = controller.urunGuncelle(urun);
            if (result == LoginStatus.basarili)
            {
                MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumUrunleriGetir();
            }
            else if (result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Ürün Güncellenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gerekli tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_kayıtSil_Click(object sender, EventArgs e)
        {
            LoginStatus result=controller.urunSil(txt_id.Text);
            if (result == LoginStatus.basarili)
            {
                MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = controller.tumUrunleriGetir();
            }
            else if (result == LoginStatus.basarisiz)
            {
                MessageBox.Show("Geçerli id giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz ürünün id değerini giriniz!", "Eksik Parametre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
