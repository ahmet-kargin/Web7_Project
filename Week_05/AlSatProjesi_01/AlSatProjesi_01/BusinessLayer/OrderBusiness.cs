using AlSatProjesi_01.DataAccessLayer.DAL;
using AlSatProjesi_01.DataAccessLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlSatProjesi_01.BusinessLayer
{
    class OrderBusiness
    {
        OrderDAL orderDAL = new OrderDAL();
        public List<Order> OrderList()
        {
            return orderDAL.GetAllOrders();
        }

        public void OrderInsert(Order order)
        {
            orderDAL.InsertOrder(order);
            //ProductDAL productDAL = new ProductDAL();
            //productDAL.DecraseStock(order);
        }
    }
}
