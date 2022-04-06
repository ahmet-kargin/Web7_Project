using PersonelTakipUygulamasi.DataAccessLayer;
using PersonelTakipUygulamasi.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using PersonelTakipUygulamasi.BusinessLayer;

namespace PersonelTakipUygulamasi
{
    public partial class FormAna : Form
    {
        CalisanDAL calisanDAL = new CalisanDAL();
        Calisan calisan = null;
        BL bl = new BL();
        int secilenID = 0;
        public FormAna()
        {
            InitializeComponent();
        }
        List<string> FillCalisan()
        {
            List<string> liste = new List<string>();
            liste.Add(txtAd.Text);
            liste.Add(txtSoyad.Text);
            liste.Add(txtTcNo.Text);
            liste.Add(txtPersonelNo.Text);
            liste.Add(dtpDogumTarihi.Value.ToString());
            liste.Add(dtpIseBaslamaTarihi.Value.ToString());
            liste.Add(cmbDepartman.Text);
            liste.Add(cmbUnvan.Text);
            liste.Add(cmbDurumu.Text);
            liste.Add(secilenID.ToString());

            return liste;
        }
        void RefreshGrid()
        {
            dgvCalisanlar.DataSource = calisanDAL.GetAll();

        }
        private void FormAna_Load(object sender, EventArgs e)
        {
            ClearTools();
            RefreshGrid();
        }

        void ClearTools()
        {
            foreach (Control control in pnlAraclar.Controls)
            {
                //if (control.GetType()==typeof(DateTimePicker))//O sırada baktığın controlün tipi DateTimePicker ise
                //{
                //    control.CustomFormat = " ";
                //}
                if (control.GetType() != typeof(Label))//O sırada baktığın controlün tipi Label değilse
                {
                    control.Text = string.Empty;
                }
            }
            dtpDogumTarihi.Format = DateTimePickerFormat.Custom;
            dtpDogumTarihi.CustomFormat = " ";
            dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Custom;
            dtpIseBaslamaTarihi.CustomFormat = " ";
            dgvCalisanlar.ClearSelection();
            secilenID = 0;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            RefreshGrid();
            ClearTools();
        }

        private void dtpDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpDogumTarihi.Format = DateTimePickerFormat.Long;
        }

        private void dtpIseBaslamaTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Long;
        }
        public bool CheckBlank()
        {
            bool status = false;
            foreach (Control control in pnlAraclar.Controls)
            {
                MessageBox.Show(control.Text);
                if (control.Text == string.Empty || control.Text == " ")
                {
                    status = true;
                    break;
                }
            }
            return status;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            List<string> liste = FillCalisan();
            liste.RemoveAt(9);
            string mesaj = bl.Check(liste);
            if (mesaj == "İşlem başarıyla gerçekleşmiştir.")
            {
                bl.TrustedSave(liste);
                RefreshGrid();
            }
            MessageBox.Show(mesaj);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            List<string> liste = FillCalisan();
            string mesaj = bl.Check(liste);
            if (mesaj == "İşlem başarıyla gerçekleşmiştir.")
            {
                bl.TrustedSave(liste);
                RefreshGrid();
            }
            MessageBox.Show(mesaj);
        }
        void Transfer()
        {
            try
            {
                secilenID = Convert.ToInt32(dgvCalisanlar.SelectedRows[0].Cells[0].Value);
                txtAd.Text = dgvCalisanlar.SelectedRows[0].Cells[1].Value.ToString();
                txtSoyad.Text = dgvCalisanlar.SelectedRows[0].Cells[2].Value.ToString();
                txtTcNo.Text = dgvCalisanlar.SelectedRows[0].Cells[3].Value.ToString();
                txtPersonelNo.Text = dgvCalisanlar.SelectedRows[0].Cells[4].Value.ToString();
                dtpDogumTarihi.Format = DateTimePickerFormat.Long;
                dtpDogumTarihi.Value = Convert.ToDateTime(dgvCalisanlar.SelectedRows[0].Cells[5].Value);
                dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Long;
                dtpIseBaslamaTarihi.Value = Convert.ToDateTime(dgvCalisanlar.SelectedRows[0].Cells[6].Value);
                cmbDepartman.Text = dgvCalisanlar.SelectedRows[0].Cells[7].Value.ToString();
                cmbUnvan.Text = dgvCalisanlar.SelectedRows[0].Cells[8].Value.ToString();
                cmbDurumu.Text = dgvCalisanlar.SelectedRows[0].Cells[9].Value.ToString();

            }
            catch (Exception)
            {


            }
        }


        private void dgvCalisanlar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Transfer();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (secilenID == 0)
            {
                MessageBox.Show("Lütfen silinecek kaydı seçiniz!");
            }
            else
            {
                DialogResult answer = MessageBox.Show("Seçili kaydı silmek istediğinizden emin misiniz?", "DİKKAT!", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)//Kullanıcı Yes'e tıkladıysa
                {
                    bool result = calisanDAL.Delete(secilenID);
                    if (result)
                    {
                        RefreshGrid();
                        ClearTools();
                        MessageBox.Show("Seçili kayıt başarıyla silinmiştir!");
                    }
                }
            }
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            DialogResult answer =
                MessageBox.Show("Bu işlem tüm kayıtları KALICI olarak silecektir!\nEmin misiniz?", "DİKKAT DİKKAT!", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                bool result = calisanDAL.Delete();
                if (result)
                {
                    RefreshGrid();
                    MessageBox.Show("Tablodaki tüm kayıtlar başarıyla silinmiştir!\nGeçmişler olsun...");
                }
            }
        }
        string CreateQueryString()
        {
            string query = string.Empty;
            List<string> conditions = new List<string>();
            foreach (Control control in pnlAraclar.Controls)
            {
                if (control.GetType() == typeof(Label)) continue;
                if (String.IsNullOrEmpty(control.Text) || control.Text == " ") continue;
                string columnName = control.Tag.ToString();
                string value;
                if (control.GetType() == typeof(DateTimePicker))
                {
                    value = Convert.ToDateTime(control.Text).ToString("yyyy-MM-dd");
                    conditions.Add($"{columnName} = '{value}'");
                }
                else
                {
                    value = control.Text;
                    if (rdbTam.Checked)
                    {
                        conditions.Add($"{columnName} = '{value}'");
                    }
                    else if (rdbBaslangic.Checked)
                    {
                        conditions.Add($"{columnName} LIKE '{value}%'");
                    }
                    else
                    {
                        conditions.Add($"{columnName} LIKE '%{value}%'");
                    }

                }

            }
            query = "WHERE " + string.Join(" AND ", conditions);
            return query;

        }
        private void btnBul_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(CreateQueryString());
            dgvCalisanlar.DataSource = calisanDAL.GetAll(CreateQueryString());
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            calisan = new Calisan();
            calisan = calisanDAL.Get(CreateQueryString());
            if (calisan != null)
            {
                txtAd.Text = calisan.Ad;
                txtSoyad.Text = calisan.Soyad;
                txtTcNo.Text = calisan.TcNo;
                txtPersonelNo.Text = calisan.PersonelNo;
                dtpDogumTarihi.Format = DateTimePickerFormat.Long;
                dtpDogumTarihi.Value = calisan.DogumTarihi;
                dtpIseBaslamaTarihi.Format = DateTimePickerFormat.Long;
                dtpIseBaslamaTarihi.Value = calisan.IseBaslamaTarihi;
                cmbDepartman.Text = calisan.Departman;
                cmbUnvan.Text = calisan.Unvan;
                cmbDurumu.Text = calisan.Durumu;
            }
        }
    }
}
