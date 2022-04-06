using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    class VeriTabani
    {
        SqlConnection baglanti;
        public VeriTabani()
        {
            BaglantiOlustur();
        }
        void BaglantiOlustur()
        {
            string sName = $@"DESKTOP-5JA1DBH";
            string dName = "aKutuphane";
            string uName = "sa";
            string pass = "123";
            string baglantiCumlesi = 
                $"Server={sName}; Database={dName}; User={uName}; Pwd={pass}";
            baglanti = new SqlConnection(baglantiCumlesi);
        }
        void Ac()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }

        void Kapa()
        {
            if (baglanti.State == ConnectionState.Open)
            {
                baglanti.Close();
            }
        }
        public string TableName { get; set; }
        
        public DataTable dt;
        public void Islem()
        {
            string kosul = "WHERE Durum='false'";
            if (TableName!="tblOdunc")
            {
                kosul = "";
            }
            string sorguCumlesi =
                $"SELECT * FROM {TableName} {kosul}";
            SqlDataAdapter adaptor = new SqlDataAdapter(sorguCumlesi,baglanti);
            dt = new DataTable();
            adaptor.Fill(dt);
        }
        public void Islem(Odunc yeniOdunc)
        {
            string sorguCumlesi = "INSERT INTO tblOdunc " +
                "(UyeID, KitapISBN, VerilisTarihi, Durum) VALUES " +
                "(@uyeID,@kitapISBN,@verilisTarihi,@durum)";
            SqlCommand komut = new SqlCommand(sorguCumlesi,baglanti);
            komut.Parameters.AddWithValue("@uyeID", yeniOdunc.UyeID);
            komut.Parameters.AddWithValue("@kitapISBN", yeniOdunc.KitapISBN);
            komut.Parameters.AddWithValue("@verilisTarihi", yeniOdunc.VerilisTarihi.ToString("yyyy-MM-dd"));
            komut.Parameters.AddWithValue("@durum", yeniOdunc.Durum);
            Ac();
            komut.ExecuteNonQuery();
            Kapa();
        }
        public void Islem(string silinecekID)
        {
            string sorguCumlesi =
                $"UPDATE {TableName} SET Durum='true' WHERE ID=@silinecekID";
            SqlCommand komut = new SqlCommand(sorguCumlesi, baglanti);
            komut.Parameters.AddWithValue("@silinecekID", silinecekID);
            Ac();
            komut.ExecuteNonQuery();
            Kapa();
        }


    }
}
