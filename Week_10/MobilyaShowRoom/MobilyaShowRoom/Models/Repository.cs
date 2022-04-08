using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilyaShowRoom.Models
{
    public static class Repository
    {
        public static List<Product> AllProducts()
        {
            var products = new List<Product>()
            {
                new Product {ID=470, ProductName="Dolap", ProductDetail="İki kapılı dolap", Price=5000 },
                new Product {ID=570, ProductName="Koltuk", ProductDetail="İki kapılı dolap", Price=6000 },
                new Product {ID=670, ProductName="TV sehpası", ProductDetail="İki kapılı dolap", Price=7000 },
                new Product {ID=430, ProductName="Yatak", ProductDetail="İki kapılı dolap", Price=8000 },
                new Product {ID=477, ProductName="Masa", ProductDetail="İki kapılı dolap", Price=9000 },
                new Product {ID=180, ProductName="Sandalye", ProductDetail="İki kapılı dolap", Price=10000 }
            };
            return products;
        }
        
    }
}
