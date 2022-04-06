using AlSatProjesi_01.DataAccessLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlSatProjesi_01.DataAccessLayer.Entities.Concrete
{
    class Order : IBaseEntity
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public int ProductID { get; set; }
        public int SoldQuantity { get; set; }
    }
}
