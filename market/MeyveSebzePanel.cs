using AForge.Video.DirectShow;
using market.controller;
using market.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace market
{
    public partial class MeyveSebzePanel : Form
    {
        int sayı1;
        int sayı2;
        char islemtip;
       
        public MeyveSebzePanel()
        {
            InitializeComponent();
            txt_ıslem.Text = "0";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void grpbox_hesapMakinası_Enter(object sender, EventArgs e)
        {

        }
        FilterInfoCollection fıc;
        VideoCaptureDevice vcd;
       
        private void MeyveSebzePanel_Load(object sender, EventArgs e)
        {
            
            fıc = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo camera in fıc)
            {
                comboBox_kamera.Items.Add(camera.Name);
            }

           
        }

        private void secilentus(object sender, EventArgs e)
        {
            if (txt_ıslem.Text == "0")
            {
                txt_ıslem.Text = "";
            }
            txt_ıslem.Text += ((Button)sender).Text;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_ıslem.Text = "0";
        }

        private void btn_toplama_Click(object sender, EventArgs e)
        {
            sayı1 = int.Parse(txt_ıslem.Text);
            txt_ıslem.Text = "";
            islemtip = '+';
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sayı2 = int.Parse(txt_ıslem.Text);
            if (islemtip == '+')
            {
                txt_ıslem.Text = Convert.ToString(sayı1 + sayı2);
            }
            else if (islemtip == '-')
            {
                txt_ıslem.Text = Convert.ToString(sayı1 - sayı2);
            }
            else if (islemtip == 'X')
            {
                txt_ıslem.Text = Convert.ToString(sayı1 * sayı2);
            }
            else if (islemtip == '/')
            {
                txt_ıslem.Text = Convert.ToString(sayı1 / sayı2);
            }
        }

        private void btn_cıkarma_Click(object sender, EventArgs e)
        {
            sayı1 = int.Parse(txt_ıslem.Text);
            txt_ıslem.Text = "";
            islemtip = '-';
        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            sayı1 = int.Parse(txt_ıslem.Text);
            txt_ıslem.Text = "";
            islemtip = 'X';
        }

        private void btn_bölme_Click(object sender, EventArgs e)
        {
            sayı1 = int.Parse(txt_ıslem.Text);
            txt_ıslem.Text = "";
            islemtip = '/';
        }

        private void btn_gerigel_Click(object sender, EventArgs e)
        {
            txt_ıslem.Text = txt_ıslem.Text.Substring(0, txt_ıslem.Text.Length - 1);
            if (txt_ıslem.Text.Length == 0)
            {
                txt_ıslem.Text = "0";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btn_kameraaç_Click(object sender, EventArgs e)
        {
            vcd = new VideoCaptureDevice(fıc[comboBox_kamera.SelectedIndex].MonikerString);
            vcd.NewFrame += Vcd_NewFrame1;
            vcd.Start();
            timer2.Start();

        }

        private void Vcd_NewFrame1(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
           pcturebx_kamera.Image=(Bitmap) eventArgs.Frame.Clone();
        }

        private void Vcd_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pcturebx_kamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void grpbox_QRkod_Enter(object sender, EventArgs e)
        {

        }

        private void btn_kamerakpt_Click(object sender, EventArgs e)
        {
            vcd.Stop();
            pcturebx_kamera.Image = Image.FromFile(@"D:\market\market\kamera.ico");
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            if (pcturebx_kamera.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pcturebx_kamera.Image);
                if (result != null)
                {
                    textBox1.Text = result.ToString();
                    timer2.Stop();
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Controller controller = new Controller();
            Urun turun=controller.urunGetir(textBox1.Text);
            txt_ıslem.Text = turun.fiyat.ToString();
            lbl_ürünIsim.Text = turun.urunIsim.ToString();
            SoundPlayer ses = new SoundPlayer();
            ses.SoundLocation = @"D:\market\market\barkod.wav";
            ses.Play();

        }

        private void btn_menüCıkıs_Click(object sender, EventArgs e)
        {
            KasiyerPanel kasiyer = new KasiyerPanel();
            kasiyer.Show();
            this.Hide();
        }
    }
}
