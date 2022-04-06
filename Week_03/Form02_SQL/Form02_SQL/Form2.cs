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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        void DepartmanGetir()
        {
            string baglantiCumlesi = @"Server=DESKTOP-5JA1DBH; Database=Sirket50; User=sa; Pwd=123";
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM tblDepartman";
            komut.Connection = baglanti;
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                int id = (int)dr["ID"];
                string departmanAd = dr["DepartmanAd"].ToString();
                lstDepartmanlar.Items.Add($"{id}\t{departmanAd}");
            }
            baglanti.Close();

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            DepartmanGetir();
        }
    }
}
