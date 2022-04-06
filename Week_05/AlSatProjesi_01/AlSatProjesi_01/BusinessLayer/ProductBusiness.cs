using AlSatProjesi_01.DataAccessLayer.DAL;
using AlSatProjesi_01.DataAccessLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlSatProjesi_01.BusinessLayer
{
    class ProductBusiness
    {
        ProductDAL productDAL = new ProductDAL();
        public List<Product> ProductList()
        {
            return productDAL.GetAllProducts();
        }
    }
}
