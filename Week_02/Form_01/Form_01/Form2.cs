using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void IslemYap(string tur)
        {
            int sayi1 = int.Parse(txtSayi1.Text);
            int sayi2 = int.Parse(txtSayi2.Text);
            int sonuc = 0;
            if (tur=="+")
            {
                sonuc = sayi1 + sayi2;
            }
            else if (tur=="-")
            {
                sonuc = sayi1 - sayi2;
            }
            else if (tur=="*")
            {
                sonuc = sayi1 * sayi2;
            }
            else
            {
                sonuc = sayi1 / sayi2;
            }
            lblSonuc.Text = sonuc.ToString();
        }
        private void btnTopla_Click(object sender, EventArgs e)
        {
            IslemYap("+");
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            IslemYap("-");
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            IslemYap("*");
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            IslemYap("/");
        }

    }
}
