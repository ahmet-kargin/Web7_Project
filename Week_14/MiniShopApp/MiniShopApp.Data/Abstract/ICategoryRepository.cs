using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Abstract
{
    public interface ICategoryRepository: IRepository<Category>
    {
        //Burada IRepository içindeki tüm memberler var.
        //Ayrıca buraya Category entitysini ilgilendiren memberları yazabiliriz.
        Category GetByIdWithProducts(int id);
    }
}
