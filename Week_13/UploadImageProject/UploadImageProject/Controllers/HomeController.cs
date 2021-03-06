using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UploadImageProject.Models;

namespace UploadImageProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UploadImage()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images");
            var imageList = Directory.GetFiles(path);
            List<UploadedImage> uploadedImages = new List<UploadedImage>();
            foreach (var image in imageList)
            {
                FileInfo fileInfo = new FileInfo(image);
                UploadedImage uploadedImage = new UploadedImage();
                uploadedImage.ImageFullName = fileInfo.FullName.Substring(fileInfo.FullName.IndexOf("wwwroot")).Replace("wwwroot",string.Empty);
                uploadedImage.ImageName = fileInfo.Name;
                uploadedImage.ImageSize = fileInfo.Length /1024;
                uploadedImages.Add(uploadedImage);
            }
            return View(uploadedImages);
        }
        [HttpPost]
        public IActionResult UploadImage(IFormFile file)
        {
            if (file != null && file.ContentType =="image/png") //eğer file boş değilse, yani dosya seçilmişse
            {
                string imageExtenison = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid() + imageExtenison;
                string path = Path.Combine(Directory.GetCurrentDirectory(),$"wwwroot/images/{imageName}");

                var stream = new FileStream(path,FileMode.Create);
                file.CopyTo(stream);
            }
            return RedirectToAction("UploadImage");
        }
    }
}
