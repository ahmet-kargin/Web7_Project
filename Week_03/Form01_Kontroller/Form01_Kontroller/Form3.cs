using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form01_Kontroller
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string CinsiyetBelirle()
        {
            if (rdbKadin.Checked==true)
            {
                return "Kadın";
            }
            else
            {
                return "Erkek";
            }
        }
        void Ekle()
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = txtAdSoyad.Text.ToUpper();//Text, lvi'nin 1.kolonu demektir.
            lvi.SubItems.Add(CinsiyetBelirle());//SubItems.Add 1.kolondan sonraki kolonlar için kullanılır.
            lvi.SubItems.Add("Wissen Akademie");
            lsvKisiler.Items.Add(lvi);
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            rdbKadin.Checked = true;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtAranan.Text.ToUpper();
            lblMesaj.Text = lsvKisiler.Items.Find(aranan, true).ToString();
            //ListViewItem[] lviSonuc = lsvKisiler.Items.Find(aranan, true);
            //MessageBox.Show(lviSonuc.Length.ToString());
            //lsvKisiler.Clear();
            //lsvKisiler.Items.AddRange(lviSonuc);
        }
    }
}
