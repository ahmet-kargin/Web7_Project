using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithClassSql_Crud2
{
    public partial class FormDoktorlar : Form
    {
        VeriTabani vt = new VeriTabani();
        string sorguCumlesi;
        public FormDoktorlar()
        {
            InitializeComponent();
        }
        void DoktorlariListele()
        {
            sorguCumlesi = $"SELECT * FROM tblDoktorlar";
            dgvDoktorlar.DataSource = vt.Listele(sorguCumlesi);
        }
        private void FormDoktorlar_Load(object sender, EventArgs e)
        {
            DoktorlariListele();
            cmbBolum.DataSource = vt.Listele("SELECT * FROM tblBolumler");
            cmbBolum.DisplayMember = "BolumAd";
            cmbBolum.ValueMember = "ID";
        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cmbBolum.SelectedValue.ToString());
        }
    }
}
