using AlSatProjesi_01.DataAccessLayer.Connections;
using AlSatProjesi_01.DataAccessLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlSatProjesi_01.DataAccessLayer.DAL
{
    class OrderDAL
    {
        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            string queryString = $"SELECT * FROM tblOrders";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryString, ConnectionDAL.ConnectionObj))
                {
                    ConnectionDAL.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Order Order = new Order
                            {
                                ID = Convert.ToInt32(dr["ID"]),
                                OrderDate = Convert.ToDateTime(dr["OrderDate"]),
                                ProductID = Convert.ToInt32(dr["ProductID"]),
                                SoldQuantity = Convert.ToInt32(dr["SoldQuantity"])
                            };
                            orders.Add(Order);
                        }
                    }
                }
                return orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                ConnectionDAL.Close();
            }
        }
        public void InsertOrder(Order Order)
        {
            string queryString =
                $"INSERT INTO tblOrders (OrderDate,ProductID,SoldQuantity) " +
                $"VALUES (@p1,@p2,@p3)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryString, ConnectionDAL.ConnectionObj))
                {
                    cmd.Parameters.AddWithValue("@p1", Order.OrderDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@p2", Order.ProductID);
                    cmd.Parameters.AddWithValue("@p3", Order.SoldQuantity);
                    ConnectionDAL.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                ConnectionDAL.Close();
            }
        }
    }
}
