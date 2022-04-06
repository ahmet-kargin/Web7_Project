using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_01
{
    public partial class Form2 : Form
    {
        class Ogrenci
        {
            //Constructor Method - Yapıcı/Kurucu Metot
            public Ogrenci()//default constructor
            {

            }
            public Ogrenci(string gAd, string gSoyad)
            {
                Ad = gAd;
                Soyad = gSoyad;
            }

            public Ogrenci(string gAd, string gSoyad, string gelenCinsiyet)
            {
                Ad = gAd;
                Soyad = gSoyad;
                Cinsiyet = gelenCinsiyet;
            }

            string ad;

            public string Ad//Full property
            {
                get
                {
                    //Bu alan dışarıda bir yerde okunmaya çalışıldığında
                    //burası tetiklenir.
                    return ad;
                }
                set 
                {
                    //Bu alana dışarıdan veri girildiği an burası tetiklenir.
                    ad = value.ToUpper();
                }
            }
            public string Soyad { get; set; }
            public string Cinsiyet { get; set; }

        }
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

            Ogrenci ogrenci1 = new Ogrenci("Ayşen Umay", "Ergül", "K");
            Ogrenci ogrenci2 = new Ogrenci();
            ogrenci1.Ad = "engin";
            lblSonuc.Text = ogrenci1.Ad + " " + ogrenci1.Soyad;
        }
    }
}
