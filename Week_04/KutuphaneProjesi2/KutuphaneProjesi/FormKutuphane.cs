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
        VeriTabani vt = new VeriTabani();

        public FormKutuphane()
        {
            InitializeComponent();
            
        }

        private void FormKutuphane_Load(object sender, EventArgs e)
        {
            //Ödünç işlemleri gridimizi dolduruyor
            vt.TableName = "tblOdunc";
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;

            //Üye listesini dolduruyor
            vt.TableName = "tblUyeler";
            vt.Islem();
            dgvOduncUyeler.DataSource = vt.dt;
            for (int i = 0; i < dgvOduncUyeler.ColumnCount; i++)
            {
                dgvOduncUyeler.Columns[i].Visible = false;
            }
            dgvOduncUyeler.Columns[1].Visible = true;
            dgvOduncUyeler.Columns[1].HeaderText = "Üye Adı";

            //Kitap listesini dolduruyor
            vt.TableName = "tblKitaplar";
            vt.Islem();
            dgvOduncKitaplar.DataSource = vt.dt;
            for (int i = 0; i < dgvOduncKitaplar.ColumnCount; i++)
            {
                dgvOduncKitaplar.Columns[i].Visible = false;
            }
            dgvOduncKitaplar.Columns[1].Visible = true;
            dgvOduncKitaplar.Columns[1].HeaderText = "Kitap Adı";

            pnlOduncTeslimTarihi.Visible = false;
            dtpOduncTeslimETarihi.Text=dtpOduncVerilisTarihi.Value.AddDays(5).ToString();
            
        }

        private void dtpOduncVerilisTarihi_ValueChanged(object sender, EventArgs e)
        {
            dtpOduncTeslimETarihi.Text = dtpOduncVerilisTarihi.Value.AddDays(5).ToString();
        }

        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            Odunc yeniOdunc = new Odunc();
            yeniOdunc.UyeID = 
                Convert.ToInt32(dgvOduncUyeler.SelectedRows[0].Cells[0].Value.ToString());
            yeniOdunc.KitapISBN =
                dgvOduncKitaplar.SelectedRows[0].Cells[0].Value.ToString();
            yeniOdunc.VerilisTarihi = dtpOduncVerilisTarihi.Value;
            yeniOdunc.Durum = false;//Yani bu kayıt silinmiş değil
            vt.Islem(yeniOdunc);
            //Ödünç işlemleri gridimizi dolduruyor
            vt.TableName = "tblOdunc";
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;
        }

        private void btnOduncIptal_Click(object sender, EventArgs e)
        {
            Odunc iptalOdunc = new Odunc();
            vt.TableName = "tblOdunc";
            string silinecekID = dgvOdunc.SelectedRows[0].Cells[0].Value.ToString();
            vt.Islem(silinecekID);
            //Ödünç işlemleri gridimizi dolduruyor
            vt.TableName = "tblOdunc";
            vt.Islem();
            dgvOdunc.DataSource = vt.dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dgvOduncUyeler.Rows[2].Selected = true;
        }
    }
}
