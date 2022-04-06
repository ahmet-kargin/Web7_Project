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

namespace Form02_SQL
{
    public partial class Form3 : Form
    {
        SqlConnection baglanti;
        SqlDataAdapter adapter;
        DataTable dt;
        string baglantiCumlesi= @"Server=DESKTOP-5JA1DBH; Database=Sirket50; User=sa; Pwd=123";
        string sorguCumlesi;
        public Form3()
        {
            InitializeComponent();
        }
        void VerileriCek()
        {
            //tblPersonel tablosundaki dataları getirecek
            sorguCumlesi = "SELECT * FROM tblPersonel";
            baglanti = new SqlConnection(baglantiCumlesi);
            adapter = new SqlDataAdapter(sorguCumlesi,baglanti);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvPersonel.DataSource = dt;
            dgvPersonel.Columns[0].Visible = false;
            dgvPersonel.Columns["IlceId"].Visible = false;
            
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            VerileriCek();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
