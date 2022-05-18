using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        //[Required(ErrorMessage ="Lütfen ürün adını yazınız!")]       //[]: İndexer  Required:Boş bırakılamaz.
        //[StringLength(50,MinimumLength =50, ErrorMessage ="Lütfen 10-50 arasında bir ad giriniz.")]//Metin uzunluğu sınırlarını belirler.
        public string Name { get; set; }
        //[Required(ErrorMessage = "Lütfen ürün fiyatını yazınız!")]    //[]: İndexer  Required:Boş bırakılamaz.
        //[Range(1,100000,ErrorMessage ="Lütfen 1-100000 arasında fiyat giriniz")]
        public decimal? Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public List<Category> SelectedCategories { get; set; }
        
    }
}
