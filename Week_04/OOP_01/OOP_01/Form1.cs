using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_01
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Kisi
        {
            public string adSoyad;//Bir değişken class içerisinde tanımlanmışsa
            public short yas;     //Buna Field denir.
            public string cinsiyet;
        }

        class Ogrenci
        {
            
            private int ogrenciNo;

            public int OgrenciNo
            {
                get
                { 
                    return ogrenciNo; 
                }
                set { ogrenciNo = value; }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Kisi yeniKisi = new Kisi();
            yeniKisi.adSoyad = "Engin";
            yeniKisi.yas = 78;
            yeniKisi.cinsiyet = "Erkek";

            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.OgrenciNo = 45;

        }
    }
}
