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
    public partial class Form3 : Form
    {
        public enum MarkaTipi
        {
            Adidas,
            Nike,
            Kinetix,
            Hummel
        }
        public enum TurTipi
        {
            Bot,
            Çizme,
            Sandalet,
            Klasik,
            Spor
        }
        class Ayakkabi
        {
  
            public MarkaTipi Marka { get; set; }
            public short Numara { get; set; }
            public TurTipi Tur { get; set; }
            
            private double fiyat;

            public double Fiyat
            {
                get 
                { 
                    return fiyat * 1.5; 
                }
                set { fiyat = value; }
            }

        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Ayakkabi ayakkabi1 = new Ayakkabi();
            ayakkabi1.Marka = MarkaTipi.Hummel;
            ayakkabi1.Tur = TurTipi.Çizme;
            ayakkabi1.Fiyat = 500;
            lblSonuc.Text = ayakkabi1.Marka.ToString() + " " + ayakkabi1.Tur.ToString() + " Fiyat: " + ayakkabi1.Fiyat;
            

        }
    }
}
