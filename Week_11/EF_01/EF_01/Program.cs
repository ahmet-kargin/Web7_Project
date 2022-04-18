using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToList ile bölümleri listeliyoruz.
            void BolumleriListele()
            {
                HastaneAksamEntities hastane = new HastaneAksamEntities();
                var bolumler = hastane.Bolumler.ToList();
                Console.WriteLine($"Bölüm ID\t\tBolumAd");

                foreach (var bolum in bolumler)
                {
                    Console.WriteLine($"{bolum.ID}\t\t{bolum.BolumAd}");
                }
                Console.ReadLine();
            }

            //BolümGetir, Where ile 
            void DoktorGetir()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var doktorlar = hastane.Doktorlar.Where(x => x.AdSoyad == "Sedat Kanar");
                    Console.WriteLine($"ID\tSİCİL NO\tAD SOYAD\tTEL\t\tBÖLÜM");
                    foreach (var doktor in doktorlar)
                    {
                        Console.WriteLine($"{doktor.ID}\t{doktor.SicilNo}\t\t{doktor.AdSoyad}\t{doktor.Tel}\t{doktor.Bolumler.BolumAd}");
                    }
                }
                Console.ReadLine();
            }

            //D ile başlayan bölümleri getir
            void BolumGetir()
            {
                using(HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var bolumler = hastane.Bolumler.Where(x => x.BolumAd.StartsWith("D"));
                    foreach (var bolum in bolumler)
                    {
                        Console.WriteLine($"{bolum.ID}--{bolum.BolumAd}");
                    }
                }
                Console.ReadLine();
            }


            //Doktor ad soyadlarını listele
            void DoktorAdSoyadListele()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var doktorAdlari = hastane.Doktorlar.Select(x => x.AdSoyad);
                    foreach (var doktorAd in doktorAdlari)
                    {
                        Console.WriteLine(doktorAd);
                    }
                }
                Console.ReadLine();
            }


            //Find ile hızlı arama
            void HizliAra()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    Doktorlar doktor = hastane.Doktorlar.Find(4);
                    //Find sadece ilgili Entity'nin priimary key'i üzerinde arama yapar.
                    Console.WriteLine($"Ad: {doktor.AdSoyad}, Bölüm: {doktor.Bolumler.BolumAd}");
                }
                Console.ReadLine();
            }

            //Doktorlardan ilk kaydı getir
            void IlkDoktoruGetir()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    Doktorlar doktor = hastane.Doktorlar
                        .Where(x => x.AdSoyad=="Demet Evgar")
                        .First();
                    Console.WriteLine($"{doktor.AdSoyad},{doktor.Bolumler.BolumAd}");
                }
                Console.ReadLine();
            }

            //İlk 3 doktoru getirsin
            void IlkUcDoktoruListele()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var ilkUcDoktor = hastane.Doktorlar.Take(3);
                    foreach (var doktor in ilkUcDoktor)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }
                }
                Console.ReadLine();
            }

            //Demet Evgar adında bir doktorumuz varmı?
            void DemetEvgarVarMi()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    bool sonuc = hastane.Doktorlar.Any(x => x.AdSoyad == "Demet Evgar");
                    if (sonuc)
                    {
                        Console.WriteLine("Aradığınız doktor var.");
                    }
                    else
                    {
                        Console.WriteLine("Hastanemeizde bu adda doktor yok.");
                    }
                }
                Console.ReadLine();
            }

            //Tüm doktorlar ortopedidemi
            void TumDoktorlarOrtapedideMi()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    bool sonuc = hastane.Doktorlar.All(x => x.Bolumler.BolumAd == "Ortopedi");
                    if (sonuc)
                    {
                        Console.WriteLine("Evet, hepsi ortopedi");
                    }
                    else
                    {
                        Console.WriteLine("Hayır, hepsi değil.");
                    }
                }
                Console.ReadLine();
            }

            //Doktorları A'dan Z'yw göre adına göre sıralayalım
            void DoktorSiralaAsc()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    //ÖDEV: List ile Icollection arasındaki farkları Araştırın.
                    var siraliDoktorlar = hastane.Doktorlar.OrderBy(x => x.AdSoyad);
                    foreach (var doktor in siraliDoktorlar)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }
                    Console.ReadLine();                }
            }

            //Doktorları Z'dan A'yw göre adına göre sıralayalım
            void DoktorSiralaDesc()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    //ÖDEV: List ile Icollection arasındaki farkları Araştırın.
                    var siraliDoktorlar = hastane.Doktorlar.OrderByDescending(x => x.AdSoyad);
                    foreach (var doktor in siraliDoktorlar)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }
                    Console.ReadLine();
                }
            }

            //Diş bölümünde çalışan doktor adlarını A'dan Z'ye sıralayınız.
            void DoktorAdlariAsc()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var doktorlar = hastane.Doktorlar.Where(x=>x.Bolumler.BolumAd=="Diş").OrderBy(x => x.AdSoyad);
                    foreach (var doktor in doktorlar)
                    {
                        Console.WriteLine(doktor.AdSoyad);
                    }
                }
                Console.ReadLine();
            }

            //Bölümlere göre çalışan doktor sayısını göstersim
            void BolumlereGoreDoktorSayisiniGoster()
            {
                using (HastaneAksamEntities hastane = new HastaneAksamEntities())
                {
                    var sonuc = hastane.Doktorlar
                        .GroupBy(x => x.Bolumler.BolumAd)
                        .Select(y => new
                        {
                            name = y.Key,
                            count = y.Count()
                        });
                    //Sadece count görmek istediğimizde name=y.Key satırını kaldırdık.
                    //ÖDEV: New yapmadan aynı işi yapmaya çalışın.
                    Console.WriteLine($"BÖLÜM\t\tDOKTOR SAYISI");
                    foreach (var bolum in sonuc)
                    {
                        Console.WriteLine($"{bolum.name}\t\t{bolum.count}");
                    }
                }
                Console.ReadLine();
            }
            BolumlereGoreDoktorSayisiniGoster();
            //DoktorAdlariAsc();
            //DoktorSiralaDesc();
            //TumDoktorlarOrtapedideMi();
            //DemetEvgarVarMi();
            //IlkUcDoktoruListele();
            //IlkDoktoruGetir();
            //HizliAra();
            //DoktorAdSoyadListele();
            //BolumGetir();
            //DoktorGetir();
            //BolumleriListele();
        }
    }
}
