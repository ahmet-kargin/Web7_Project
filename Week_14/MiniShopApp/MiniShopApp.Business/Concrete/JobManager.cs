using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Business.Concrete
{
    public class JobManager
    {
        //Burada genel olarak tanımlamak istediğimiz, heryerde ihtiyaç duyma ihtimalimiz
        //olan metodlar yazılacak.
        public  string MakeUrl(string url)
        {
            //Kendisine gelen string değerin içindeki;
            //1)Türkçce karakterlerin yerine latin alfabesindeki karşılıklarını koyacak
            //2)Boşlukların yerine - işareti gelicek
            //3)Noktaları kaldıracak
            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");

            url = url.ToLower();

            url = url.Replace("ö", "i");
            url = url.Replace("ğ", "g");
            url = url.Replace("ş", "s");
            url = url.Replace("ü", "u");
            url = url.Replace("ç", "c");

            url = url.Replace(" ", "-");
            url = url.Replace(".", "");

            return url;
        }
        public  string UploadImage(IFormFile file, string url)
        {
            var extension = Path.GetExtension(file.FileName);
            var randomName = $"{url}{Guid.NewGuid()}-{extension}";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", randomName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return randomName;
        }
    }
}
