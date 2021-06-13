﻿using System;
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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_saat.Text = DateTime.Now.Hour.ToString()+"  :";
            lbl_dakika.Text = DateTime.Now.Minute.ToString()+"  :";
            lbl_saniye.Text = DateTime.Now.Second.ToString();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_kullanıcı_Click(object sender, EventArgs e)
        {
            Kullanici_Panel kullanici = new Kullanici_Panel();
            kullanici.Show();
            this.Hide();
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btn_urunler_Click(object sender, EventArgs e)
        {
            UrunPanel urun = new UrunPanel();
            urun.Show();
            this.Hide();
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
