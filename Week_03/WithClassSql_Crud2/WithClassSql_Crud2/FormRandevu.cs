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
    public partial class FormRandevu : Form
    {
        VeriTabani vt = new VeriTabani();
        string sorguCumlesi;
        public FormRandevu()
        {
            InitializeComponent();
        }

        void BolumDoldur()
        {
            sorguCumlesi = "SELECT * FROM tblBolumler";
            cmbBolumler.DataSource = vt.Listele(sorguCumlesi);
            cmbBolumler.DisplayMember = "BolumAd";
            cmbBolumler.ValueMember = "ID";
        }
        void DoktorDoldur()
        {
            sorguCumlesi = 
                $"SELECT * FROM tblDoktorlar WHERE BolumID='{cmbBolumler.SelectedValue.ToString()}'";
            lstDoktorlar.DataSource = vt.Listele(sorguCumlesi);
            lstDoktorlar.DisplayMember = "AdSoyad";
            lstDoktorlar.ValueMember = "ID";
        }
        void HastalariDoldur()
        {
            sorguCumlesi =
                $"SELECT ID, Ad, Soyad, Cinsiyet FROM tblHastalar";
            dgvHastalar.DataSource = vt.Listele(sorguCumlesi);
            dgvHastalar.Columns[0].Visible = false;
        }
        private void FormRandevu_Load(object sender, EventArgs e)
        {
            BolumDoldur();
            DoktorDoldur();
            HastalariDoldur();
        }

        private void cmbBolumler_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DoktorDoldur();
            }
            catch (Exception)
            {

                //throw;
            }
        }
        void RandevuOlustur()
        {
            string BolumID = cmbBolumler.SelectedValue.ToString();
            string DoktorID = lstDoktorlar.SelectedValue.ToString();
            string HastaID = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            string Tarih = dtpTarih.Value.ToString("yyyy-MM-dd");
            sorguCumlesi =
                $"INSERT INTO tblRandevu VALUES " +
                $"('{BolumID}','{DoktorID}','{HastaID}','{Tarih}')";
            vt.Islem(sorguCumlesi);
        }
        private void btnRandevu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Randevu bu bilgilerle oluşturulacaktır.\nEmin misiniz?",
                "DİKKAT", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RandevuOlustur();
                MessageBox.Show("Randevu oluşturuldu");
            }
            //
            
        }

    }
}
