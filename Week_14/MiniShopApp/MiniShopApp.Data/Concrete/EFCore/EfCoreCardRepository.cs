using MiniShopApp.Data.Abstract;
using MiniShopApp.Data.Concrete.EfCore;
using MiniShopApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EFCore
{
    public class EfCoreCardRepository : EfCoreGenericRepository<Card,MiniShopContext>,ICardRepository
    {
    }
}
