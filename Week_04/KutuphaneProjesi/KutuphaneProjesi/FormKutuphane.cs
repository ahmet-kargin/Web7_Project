using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class FormKutuphane : Form
    {
        VeriTabani vt = new VeriTabani("SELECT * FROM tblTurler");
        public FormKutuphane()
        {
            InitializeComponent();
        }

        private void FormKutuphane_Load(object sender, EventArgs e)
        {
            List<string> sutunlar = new List<string>();
            List<string> degerler = new List<string>();
            sutunlar.Add("Ad"); degerler.Add("Engin");
            sutunlar.Add("Soyad"); degerler.Add("Ergül");
            vt.TableName = "tblUyeler";
            vt.Sorgu(sutunlar, degerler, "ID=34");


        }

        private void tapTurler_Click(object sender, EventArgs e)
        {

        }
    }
}
