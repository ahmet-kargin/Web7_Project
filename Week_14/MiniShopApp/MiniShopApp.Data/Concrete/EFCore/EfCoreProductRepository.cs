﻿using Microsoft.EntityFrameworkCore;
using MiniShopApp.Data.Abstract;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EFCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, MiniShopContext>,
        IProductRepository
    {
        public List<Product> GetProductsByCategory(string name)
        {
            using (var context = new MiniShopContext())
            {
                var products = context.
                    Products
                    .Where(i => i.IsApproved)
                    .AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                    products = products
                        .Include(i => i.ProductCategories)
                        .ThenInclude(i => i.Category)
                        .Where(i=>i.ProductCategories.
                        Any(a=>a.Category.Url==name));
                        
                }
                return products.ToList();
            }
        }
    }
}
