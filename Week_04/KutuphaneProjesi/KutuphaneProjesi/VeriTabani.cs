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
        private string sorguCumlesi;

        public string SorguCumlesi
        {
            get { return sorguCumlesi; }
            set 
            { 
                sorguCumlesi = value; 
            }
        }

        SqlConnection baglanti;
        public VeriTabani()
        {
            baglanti = Baglan();
        }
        public VeriTabani(string sorguCumlesi)
        {
            baglanti = Baglan();
            SorguCumlesi = sorguCumlesi;
        }

        SqlConnection Baglan()
        {
            string dbName = "aKutuphane";
            string baglantiCumlesi =
                $@"Server=DESKTOP-5JA1DBH;
                Database={dbName}; User=sa;
                Pwd=123";
            baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            return baglanti;
        }

        void Kapat()
        {
            baglanti.Close();
        }

        public DataTable Listele()
        {
            SqlDataAdapter adaptor = new SqlDataAdapter(sorguCumlesi, baglanti);
            DataTable dt = new DataTable();
            adaptor.Fill(dt);
            return dt;
        }

        public void Islem(string sorguCumlesi)
        {
            SqlCommand komut = new SqlCommand(sorguCumlesi,baglanti);
            komut.ExecuteNonQuery();
            Kapat();
            TableName = "tblUyeler";
            //SorguCumlesiOlustur("ID=2");
        }
        public string TableName { get; set; }
        /// <summary>
        /// Bu kullanım şekli, SELECT işlemi içindir.
        /// </summary>
        public void Sorgu()
        {
            sorguCumlesi = $"SELECT * FROM {TableName}";
            Islem(sorguCumlesi);
        }
        /// <summary>
        /// Bu kullanım şekli, DELETE işlemi içindir.
        /// </summary>
        /// <param name="kosul">Silinmek istenen kayda dair koşul</param>
        public void Sorgu(string condition)
        {
            sorguCumlesi = $"DELETE FROM {TableName} WHERE {condition}";
            Islem(sorguCumlesi);
        }
        /// <summary>
        /// Bu kullanım şekli UPDATE işlemi içindir.
        /// </summary>
        /// <param name="columnNames">Sütun adları</param>
        /// <param name="columnValues">Değerler</param>
        /// <param name="condition">Koşul</param>
        public void Sorgu(List<string> columnNames, List<string> columnValues, string condition)
        {
            string text = "";
            for (int i = 0; i < columnNames.Count; i++)
            {
                text += columnNames[i] + "='" + columnValues[i] + "',";
            }
            text = text.Substring(0, text.Length - 1);
            sorguCumlesi =
                $"UPDATE {TableName} SET {text} WHERE {condition}";
            Islem(sorguCumlesi);
        }

        public void zzz()
        {
            List<string> sutunlar = new List<string>();
            List<string> degerler = new List<string>();
            sutunlar.Add("Ad"); degerler.Add("Engin");
            sutunlar.Add("Soyad"); degerler.Add("Ergül");
            Sorgu(sutunlar, degerler, "ID=34");
            sorguCumlesi = "UPDATE tblUyeler SET Ad='Engin', Soyad='Ergül' WHERE ID=65";
        }
    }
}
