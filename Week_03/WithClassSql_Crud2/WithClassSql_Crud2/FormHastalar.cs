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
    public partial class FormHastalar : Form
    {
        VeriTabani vt = new VeriTabani();
        public FormHastalar()
        {
            InitializeComponent();
        }
        void HastalariTazele()
        {
            string sorguCumlesi = "SELECT * FROM tblHastalar";
            dgvHastalar.DataSource = vt.Listele(sorguCumlesi);
        }
        private void FormHastalar_Load(object sender, EventArgs e)
        {
            HastalariTazele();
        }
        void Aktar()
        {
            rdbErkek.Checked = true;
            txtTcNo.Text = dgvHastalar.CurrentRow.Cells[1].Value.ToString();
            txtAd.Text = dgvHastalar.CurrentRow.Cells[2].Value.ToString();
            txtSoyad.Text= dgvHastalar.CurrentRow.Cells[3].Value.ToString();
            rdbKadin.Checked = dgvHastalar.CurrentRow.Cells[4].Value.ToString() == "K" ? true : false;
            txtAdres.Text= dgvHastalar.CurrentRow.Cells[5].Value.ToString();
            txtTelefon.Text= dgvHastalar.CurrentRow.Cells[6].Value.ToString();
            txtMail.Text= dgvHastalar.CurrentRow.Cells[7].Value.ToString();
        }
            void Yeni()
        {
            btnYeni.Text = "Kaydet";
            txtTcNo.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            txtAdres.Clear();
            txtMail.Clear();
            txtTelefon.Clear();
            rdbKadin.Checked = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            dgvHastalar.Enabled = false;
        }

        void Kaydet()
        {
            btnYeni.Text = "Yeni";
            string cinsiyet =
                rdbKadin.Checked == true ? "K" : "E";
            string sorguCumlesi =
                $@"INSERT INTO tblHastalar VALUES
                (
                    '{txtTcNo.Text}',
                    '{txtAd.Text}',
                    '{txtSoyad.Text}',
                    '{cinsiyet}',
                    '{txtAdres.Text}',
                    '{txtTelefon.Text}',
                    '{txtMail.Text}'
                 )";

            vt.Islem(sorguCumlesi);
            HastalariTazele();
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
            dgvHastalar.Enabled = true;

        }
        void Guncelle()
        {
            string cinsiyet =
                rdbKadin.Checked == true ? "K" : "E";
            string id = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            string sorguCumlesi =
                $@"UPDATE tblHastalar SET
                    TcNo='{txtTcNo.Text}',
                    Ad='{txtAd.Text}',
                    Soyad='{txtSoyad.Text}',
                    Cinsiyet='{cinsiyet}',
                    Adres='{txtAdres.Text}',
                    Telefon='{txtTelefon.Text}',
                    Mail='{txtMail.Text}'
                 WHERE ID={id}
                 ";
            vt.Islem(sorguCumlesi);
            HastalariTazele();
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (btnYeni.Text=="Yeni")
            {
                Yeni();
            }
            else
            {
                Kaydet();
            }
        }

        private void dgvHastalar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        void Sil()
        {
            string id = dgvHastalar.CurrentRow.Cells[0].Value.ToString();
            string sorguCumlesi = $"DELETE tblHastalar WHERE ID='{id}'";
            vt.Islem(sorguCumlesi);
            HastalariTazele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Silmek istediğinizden emin misiniz?","DİKKAT!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            //{
            //    Sil();
            //    MessageBox.Show("Kayıt silindi");
            //}
            //else
            //{
            //    MessageBox.Show("Silme işleminden vazgeçildi.");
            //}

            DialogResult cevap = MessageBox.Show("Silmek istediğinizden emin misiniz?", "DİKKAT!", MessageBoxButtons.YesNo);
            if ( cevap == DialogResult.Yes)
            {
                Sil();
                MessageBox.Show("Kayıt silindi");
            }
            else
            {
                MessageBox.Show("Silme işleminden vazgeçildi.");
            }
        }
    }
}
