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
        public List<Product> GetProductsByCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
