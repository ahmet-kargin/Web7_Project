using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XYZBilisim.KayitSistemi.DataAccessLayer.Connections;
using XYZBilisim.KayitSistemi.EntityLayer;

namespace XYZBilisim.KayitSistemi.DataAccessLayer
{
    public class KursiyerDal
    {
        public List<Kursiyer> GetAll(string conditionString=null)
        {
            List<Kursiyer> kursiyerler = new List<Kursiyer>();
            try
            {
                string queryString = $"SELECT * FROM tblKursiyerler {conditionString}";
                using (SqlCommand cmd = new SqlCommand(queryString,ConnectionDAL.Connection))
                {
                    ConnectionDAL.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Kursiyer kursiyer = new Kursiyer
                            {
                                ID = (int)dr["ID"],
                                AdSoyad = dr["AdSoyad"].ToString(),
                                EgiticiAdSoyad = dr["EgiticiAdSoyad"].ToString(),
                                Yil = (int)dr["Yil"]
                            };
                            kursiyerler.Add(kursiyer);
                        }
                    }

                }
                return kursiyerler;
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
    }
}
