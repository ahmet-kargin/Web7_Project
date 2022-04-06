using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    class Kutuphane
    {
        
    }
    public class Tur
    {
        private int id;

        public int ID//ID Read only bir propertydir.
        {
            get { return id; }
        }
        public string Ad { get; set; }
    }

    public class Yayinevi
    {
        private int id;

        public int ID//ID Read only bir propertydir.
        {
            get { return id; }
        }
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
    }
    public class Kisi
    {
        private int id;

        public int ID//ID Read only bir propertydir.
        {
            get { return id; }
        }
        public string AdSoyad { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
    public class Yazar : Kisi
    {
        public int TurID { get; set; }
        public string Uyruk { get; set; }
        public DateTime OlumTarihi { get; set; }
    }
    public class Uye : Kisi
    {
        public Uye()
        {
            CezaDurumu = false;
        }
        public enum UTip
        {
            Standart,
            Elit
        }
        public enum ETip
        {
            Ilkokul,
            Ortaokul,
            Lise,
            OnLisans,
            Lisans,
            YuksekLisans,
            Doktora,
            Ogrenci
        }
        public DateTime UyelikTarihi { get; set; }
        public UTip UyeTipi { get; set; }
        public string TcNo { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string Meslek { get; set; }
        public ETip EgitimDurumu { get; set; }
        private bool cezaDurumu;

        public bool CezaDurumu
        {
            get { return cezaDurumu; }
            set { cezaDurumu = value; }
        }

    }


    public class Kitap
    {
        public string ISBN { get; set; }
        public string Ad { get; set; }
        public int SayfaSayisi { get; set; }
        public int Stok { get; set; }
        public int TurID { get; set; }
        public int YazarID { get; set; }
        //Birden fazla yazar için burda revize yapılacak
        public int YayinEviID { get; set; }
        public DateTime BasimTarihi { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
    public class Odunc
    {
        private int id;

        public int ID//ID Read only bir propertydir.
        {
            get { return id; }
        }
        public int UyeID { get; set; }
        public string KitapISBN { get; set; }
        public DateTime VerilisTarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public bool Durum { get; set; }//Silinmişse true
    }
}
