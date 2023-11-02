using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _4_SayiTahminOyunu
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        int tutulanSayi, tahminEdilenSayi, sayac, sure ,aralik;
        Random rnd = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            //tutulanSayi = rnd.Next(1, 101);
            this.Text = tutulanSayi + "";
            btnYeniOyun.Enabled = false;
            lblSure.Text = sure + "";
            tmrSure.Interval = 1000;
            lsbTahminAraligi.Items.Add("0-100");
            lsbTahminAraligi.Items.Add("0-250");
            lsbTahminAraligi.Items.Add("0-500");
            lsbTahminAraligi.Items.Add("0-1000");
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {

            tmrSure.Start();

            if (txtTahmin.Text == "")
            {
                lblDurum.Text = "Boş bırakmayınız.";
                txtTahmin.Focus();
                txtTahmin.BackColor = Color.Red;
            }
            else
            {
                tahminEdilenSayi = Convert.ToInt32(txtTahmin.Text);
                if (tahminEdilenSayi < 0 || tahminEdilenSayi > aralik)
                {
                    lblDurum.Text = "0-"+ aralik+" arası giriniz.";
                }
                else
                {
                    sayac++;

                    if (lsbYapilanTahminler.Items.IndexOf(tahminEdilenSayi) == -1)
                    {
                        // eğer tahminEdilenSayi değeri lsbYapilanTahminler iinde yoksa
                        lsbYapilanTahminler.Items.Add(tahminEdilenSayi);
                        if (tahminEdilenSayi < tutulanSayi)
                        {
                            lblDurum.Text = "BÜYÜT";
                            txtTahmin.Focus();
                            txtTahmin.SelectAll();
                        }
                        else if (tahminEdilenSayi > tutulanSayi)
                        {
                            lblDurum.Text = "KÜÇÜLT";
                            txtTahmin.Focus();
                            txtTahmin.SelectAll();
                        }
                        else
                        {
                            lblDurum.Text = "BRAVO BULDUN.";
                            btnTahminEt.Enabled = false;
                            btnYeniOyun.Enabled = true;
                            lblTahminSayisi.Text = sayac + "";
                            lsbYapilanTahminler.Height = 100;
                            tmrSure.Stop();
                            tmrBravo.Enabled = true;
                        }
                    }
                    else
                    {
                        // eğer tahminEdilenSayi değeri lsbYapilanTahminler iinde varsa
                        lblDurum.Text = "Daha önce tahmin edildi.";
                    }
                }
            }

        }

        private void txtTahmin_TextChanged(object sender, EventArgs e)
        {
            if (txtTahmin.BackColor != Color.White)
            {
                txtTahmin.BackColor = Color.White;
            }
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            tutulanSayi = rnd.Next(1, 101);
            this.Text = tutulanSayi + "";
            txtTahmin.Text = "";
            lblDurum.Text = string.Empty;
            btnTahminEt.Enabled = true;
            btnYeniOyun.Enabled = false;
            lblTahminSayisi.Text = "";
            sayac = 0;
            sure = 5;
            lblSure.Text = sure + "";
            lsbYapilanTahminler.Items.Clear();
            tmrBravo.Stop();
            this.BackColor = SystemColors.Control;
            // Color. ile farklı, SystemColors. ile farklı renkler seçilebilir.

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tmrSure_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure + "";
            if (sure == 0)
            {
                tmrSure.Stop();
                btnTahminEt.Enabled = false;
                btnYeniOyun.Enabled = true;
                MessageBox.Show("SÜRENİZ BİTTİ");
            }
        }

        private void tmrBravo_Tick(object sender, EventArgs e)
        {
            //if (this.BackColor == Color.Red)
            //{
            //    this.BackColor = Color.Blue;

            //}
            //else
            //{
            //    this.BackColor = Color.Red;
            //}


            if (grpOyunEkrani.BackColor == Color.Red)
            {
                grpOyunEkrani.BackColor = Color.Blue;

            }
            else
            {
                grpOyunEkrani.BackColor = Color.Red;
            }
        }

        private void btnAyarlariKaydet_Click(object sender, EventArgs e)
        {


            if (!(lsbTahminAraligi.SelectedIndex < 0))
            {
                tmrBoyutlandir.Start();
                // eğer adam listboxtan b,ir seçimde bulunmuşsa
                if (rdbYirmi.Checked)
                {
                    sure = 20;
                    lblSure.Text = sure + "";
                }
                else if (rdbOtuz.Checked)
                {
                    sure = 30;
                    lblSure.Text = sure + "";
                }
                else if (rdbKirk.Checked)
                {
                    sure = 40;
                    lblSure.Text = sure + "";
                }

                switch (lsbTahminAraligi.SelectedIndex)
                {
                    case 0:
                        tutulanSayi = rnd.Next(0, 101);
                        aralik = 100;
                        this.Text = tutulanSayi + "";
                        break;
                    case 1:
                        tutulanSayi = rnd.Next(0, 251);
                        aralik = 250;
                        this.Text = tutulanSayi + "";
                        break;
                    case 2:
                        tutulanSayi = rnd.Next(0, 501);
                        aralik = 500;
                        this.Text = tutulanSayi + "";
                        break;
                    case 3:
                        tutulanSayi = rnd.Next(0, 1001);
                        aralik = 1000;
                        this.Text = tutulanSayi + "";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Lütfen sayı aralığı seçiniz");
            }




        }

        private void tmrBoyutlandir_Tick(object sender, EventArgs e)
        {
            if (this.Height != 485)
            {
                this.Height += 1;
            }
        }

     }
}
