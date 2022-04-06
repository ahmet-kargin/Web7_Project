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
    class ProductDAL
    {
        public List<Product> GetAllProducts()
        {
            
            List<Product> products = new List<Product>();
            string queryString = $"SELECT * FROM tblProducts";
            try
            {
                
                using (SqlCommand cmd = new SqlCommand(queryString, ConnectionDAL.ConnectionObj))
                {
                    ConnectionDAL.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Product product = new Product
                            {
                                ID = Convert.ToInt32(dr["ID"]),
                                ProductName = dr["ProductName"].ToString(),
                                CurrentStock = Convert.ToInt32(dr["CurrentStock"])
                            };
                            products.Add(product);
                        }
                    }
                }
                return products;
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
        public void DecraseStock(Order order)
        {
            string queryString =
                $"UPDATE tblProducts SET " +
                $"CurrentStock = CurrentStock - {order.SoldQuantity} " +
                $"WHERE ID={order.ProductID} AND CurrentStock >= {order.SoldQuantity}";
            try
            {
                using (SqlCommand cmd = new SqlCommand(queryString, ConnectionDAL.ConnectionObj))
                {
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
