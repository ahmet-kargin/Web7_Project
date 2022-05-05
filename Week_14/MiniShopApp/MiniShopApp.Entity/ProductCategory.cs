using System.Collections.Generic;

namespace MiniShopApp.Entity
{
    public class ProductCategory //Category ile Product arası çoka-çok ilişki sağlar.
        //Junction table yaparak(ProductCategory) istediğimiz sorguyu yapabiliriz iki tablo arasındaki veriler için
    {
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
