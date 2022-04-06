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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            lblMesaj.Text = "Hoşgeldin " + txtAdSoyad.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {

        }
    }
}
