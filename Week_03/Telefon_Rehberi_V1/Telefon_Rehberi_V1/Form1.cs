using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi_V1
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter adapter;
        DataTable dt;
        SqlCommand komut;
        string baglantiCumlesi = "Server=DESKTOP-5JA1DBH; Database=sRehber; User=sa; Pwd=123";

        string sorguCumlesi;
        string id;

        public Form1()
        {
            InitializeComponent();
        }
        void Aktar()
        {
            lblId.Text = dgvKisiler.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dgvKisiler.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dgvKisiler.CurrentRow.Cells[2].Value.ToString();
            //rdbKadin.Checked = dgvKisiler.CurrentRow.Cells[3].Value.ToString() == "K" ? true : false;
            if (dgvKisiler.CurrentRow.Cells[3].Value.ToString()=="K")
            {
                rdbKadin.Checked = true;
            }
            else
            {
                rdbErkek.Checked = true;
            }
            txtTel.Text = dgvKisiler.CurrentRow.Cells[4].Value.ToString();

        }
        void KisileriGetir()
        {
            sorguCumlesi = "SELECT * FROM tblKisiler";
            baglanti = new SqlConnection(baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi,baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvKisiler.DataSource = dt;
            dgvKisiler.Columns[0].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KisileriGetir();
        }

        private void dgvKisiler_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Aktar();
        }
        void Duzelt()
        {
            string id = lblId.Text;
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string cinsiyet;
            if (rdbKadin.Checked==true)
            {
                cinsiyet = "K";
            }
            else
            {
                cinsiyet = "E";
            }
            string tel = txtTel.Text;
            sorguCumlesi = $"UPDATE tblKisiler SET Ad='{ad}', Soyad='{soyad}', Cinsiyet='{cinsiyet}',Telefon='{tel}' WHERE ID={id}";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi,baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriGetir();
        }
        private void btnDuzelt_Click(object sender, EventArgs e)
        {
            Duzelt();
        }
        void Sil()
        {
            id = lblId.Text;
            sorguCumlesi = $"DELETE tblKisiler WHERE ID={id}";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi,baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriGetir();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            Sil();   
        }
        void YeniKayitFormuHazirla()
        {
            //Textboxları temizler, Düzelt ve Sil'i pasif yapar.
            lblId.Text = "Yeni Kayıt";
            txtAd.ResetText();
            txtSoyad.ResetText();
            rdbKadin.Checked = true;
            txtTel.ResetText();
            txtAd.Focus();

            AktifPasif();
        }

        void AktifPasif()
        {
            if (btnDuzelt.Enabled == true)
            {
                btnDuzelt.Enabled = false;
                btnSil.Enabled = false;
                dgvKisiler.Enabled = false;
            }
            else
            {
                btnDuzelt.Enabled = true;
                btnSil.Enabled = true;
                dgvKisiler.Enabled = true;
            }
        }
        void Kaydet()
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            string cinsiyet;
            if (rdbKadin.Checked == true)
            {
                cinsiyet = "K";
            }
            else
            {
                cinsiyet = "E";
            }
            string tel = txtTel.Text;
            sorguCumlesi = $"INSERT INTO tblKisiler VALUES ('{ad}','{soyad}','{cinsiyet}','{tel}')";
            baglanti = new SqlConnection(baglantiCumlesi);
            komut = new SqlCommand(sorguCumlesi,baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            KisileriGetir();
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (btnYeni.Text=="Yeni")
            {
                btnYeni.Text = "Kaydet";
                YeniKayitFormuHazirla();
            }
            else
            {
                btnYeni.Text = "Yeni";
                AktifPasif();
                Kaydet();
            }
        }
        void Arama()
        {
            DataView dw = dt.DefaultView;
            string ara = txtAranan.Text;
            dw.RowFilter = $"Ad LIKE '{ara}%' OR Soyad LIKE '{ara}%'";
            dgvKisiler.DataSource = dw;
        }
        private void btnAra_Click(object sender, EventArgs e)
        {
            Arama();
        }





        private void txtAranan_KeyUp(object sender, KeyEventArgs e)
        {
            Arama();
        }
    }
}
