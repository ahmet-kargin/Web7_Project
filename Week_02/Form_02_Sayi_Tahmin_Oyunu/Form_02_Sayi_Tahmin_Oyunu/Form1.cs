using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_02_Sayi_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        public int hedef;
        public int puan;
        public int hak;
        public int tahmin;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            hedef = rnd.Next(1, 100);
            puan = 50;
            hak = 5;
            lblPuan.Text = puan.ToString();
            lblHak.Text = hak.ToString();
            lblHile.Text = hedef.ToString();
            AktifPasif();
            btnBaslat.Text = "YENİDEN BAŞLAT";
        }
        void AktifPasif()
        {
            if (txtTahmin.Enabled==true)
            {
                txtTahmin.Enabled = false;
                btnTahmin.Enabled = false;
                btnBaslat.Enabled = true;
            }
            else
            {
                txtTahmin.Enabled = true;
                btnTahmin.Enabled = true;
                btnBaslat.Enabled = false;
            }

        }
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            tahmin = int.Parse(txtTahmin.Text);
            string sozcuk = "";
            if (tahmin>hedef)
            {
                sozcuk = "küçük";
            }
            else if (tahmin<hedef)
            {
                sozcuk = "büyük";
            }

            if (tahmin==hedef)
            {
                lblMesaj.Text = "Tebrikler, kazandınız.";
                AktifPasif();
            }
            else
            {
                lblMesaj.Text = "Daha"  + sozcuk + "bir sayı gir!";
                puan -= 10;
                hak -= 1;
            }
            if (hak==0)
            {
                lblMesaj.Text = "Üzgünüm, kaybettin.";
                AktifPasif();
            }
            lblPuan.Text = puan.ToString();
            lblHak.Text = hak.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AktifPasif();
        }
    }
}
