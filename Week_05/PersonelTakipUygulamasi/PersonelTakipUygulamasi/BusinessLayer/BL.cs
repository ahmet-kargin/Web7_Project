using PersonelTakipUygulamasi.DataAccessLayer;
using PersonelTakipUygulamasi.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PersonelTakipUygulamasi.BusinessLayer
{
    public class BL
    {
        static CalisanDAL calisanDAL = new CalisanDAL();
        static Calisan calisan = null;
        public void TrustedSave(List<string> liste)
        {

            if (liste.Count == 9)
            {
                calisan = new Calisan
                {
                    Ad = liste[0],
                    Soyad = liste[1],
                    TcNo = liste[2],
                    PersonelNo = liste[3],
                    DogumTarihi = Convert.ToDateTime(liste[4]),
                    IseBaslamaTarihi = Convert.ToDateTime(liste[5]),
                    Departman = liste[6],
                    Unvan = liste[7],
                    Durumu = liste[8]
                };
                calisanDAL.Insert(calisan);
            }
            else
            {
                calisan = new Calisan
                {
                    Ad = liste[0],
                    Soyad = liste[1],
                    TcNo = liste[2],
                    PersonelNo = liste[3],
                    DogumTarihi = Convert.ToDateTime(liste[4]),
                    IseBaslamaTarihi = Convert.ToDateTime(liste[5]),
                    Departman = liste[6],
                    Unvan = liste[7],
                    Durumu = liste[8],
                    ID = Convert.ToInt32(liste[9])
                };
                calisanDAL.Update(calisan);
            }
        }
        public bool CheckBlank2(List<string> liste)
        {
            bool status = false;
            foreach (var item in liste)
            {
                if (item == string.Empty || item == " ")
                {
                    status = true;
                    break;
                }
            }
            return status;
        }
        internal string Check(List<string> liste)
        {
            string mesaj = string.Empty;
            int pNoAdet = 0;
            int tCNoAdet = 0;
            if (liste.Count==10)
            {
                pNoAdet = calisanDAL.Duplicate($"PersonelNo='{liste[3]}' AND ID<>'{liste[9]}'");
                tCNoAdet = calisanDAL.Duplicate($"TcNo='{liste[2]}'  AND ID<>'{liste[9]}'");
            }
            else
            {
                pNoAdet = calisanDAL.Duplicate($"PersonelNo='{liste[3]}'");
                tCNoAdet = calisanDAL.Duplicate($"TcNo='{liste[2]}'");
            }
            if (CheckBlank2(liste))
            { mesaj = "Lütfen tüm alanları doldurunuz."; }
            else
            {
                if (pNoAdet == 0 && tCNoAdet == 0)
                { mesaj = "İşlem başarıyla gerçekleşmiştir."; }
                else if (pNoAdet == 1 && tCNoAdet == 1)
                { mesaj = "Bu personel numarası ve TC No kullanılmaktadır."; }
                else if (pNoAdet == 1)
                { mesaj = "Bu personel numarası kullanılmaktadır."; }
                else { mesaj = "Bu TC No kullanılmaktadır."; }
            }
            return mesaj;
        }
    }
}
