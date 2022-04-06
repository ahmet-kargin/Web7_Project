using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XYZBilisim.KayitSistemi.BusinessLayer;

namespace XYZBilisim.KayitSistemi
{
    public partial class FormAna : Form
    {
        KursiyerBL kBl = new KursiyerBL();
        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            dgvKursiyerler.DataSource = kBl.AllKursiyer;
        }
    }
}
