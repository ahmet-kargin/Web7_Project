using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithClassSql_Crud1
{
    class VeriTabani
    {
        SqlConnection baglanti;
        SqlCommand komut;

        string sorguCumlesi;
        //Kodlarımızı (metotlar, propertyler...) burada yazacağız.
        public SqlConnection Baglan()
        {
            string baglantiCumlesi = @"Server=DESKTOP-5JA1DBH;Database=aHastane;User=sa;Pwd=123";
            baglanti = new SqlConnection(baglantiCumlesi);
            if (baglanti.State == System.Data.ConnectionState.Closed)
            {
                baglanti.Open();
            }
            return baglanti;
        }
        public void Kapat()
        {
            if (baglanti.State != System.Data.ConnectionState.Closed)
            {
                baglanti.Close();
            }
        }

        public DataTable HastalariListele()
        {
            sorguCumlesi = $"SELECT * FROM tblHastalar";
            SqlDataAdapter adaptor = new SqlDataAdapter(sorguCumlesi, Baglan());
            DataTable dt = new DataTable();
            adaptor.Fill(dt);
            return dt;
        }

        public void Ekle(string tcNo, string ad, string soyad, string cinsiyet, string adres, string tel, string mail)
        {
            sorguCumlesi = $"INSERT INTO tblHastalar VALUES ('{tcNo}','{ad}','{soyad}','{cinsiyet}','{adres}','{tel}','{mail}')";
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }
        public void Guncelle(string id, string tcNo, string ad, string soyad, string cinsiyet, string adres, string tel, string mail)
        {
            sorguCumlesi =
                $"UPDATE tblHastalar SET TcNo= '{tcNo}', ad = '{ad}', " +
                $"soyad='{soyad}',cinsiyet='{cinsiyet}'," +
                $"adres='{adres}',telefon='{tel}',mail='{mail}' " +
                $"WHERE ID='{id}'";
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.ExecuteNonQuery();

            Kapat();
        }

        public void Sil(string id)
        {
            sorguCumlesi = $"DELETE FROM tblHastalar WHERE ID='{id}'";
            komut = new SqlCommand(sorguCumlesi, Baglan());
            komut.ExecuteNonQuery();
            Kapat();
        }



    }
}
