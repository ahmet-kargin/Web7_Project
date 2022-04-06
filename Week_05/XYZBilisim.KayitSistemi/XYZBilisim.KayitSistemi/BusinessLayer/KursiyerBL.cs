using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XYZBilisim.KayitSistemi.DataAccessLayer;
using XYZBilisim.KayitSistemi.EntityLayer;

namespace XYZBilisim.KayitSistemi.BusinessLayer
{
    class KursiyerBL
    {
        KursiyerDal kd = new KursiyerDal();
        
        private List<Kursiyer> allKursiyer;

        public List<Kursiyer> AllKursiyer
        {
            get 
            {
                allKursiyer = kd.GetAll();
                return allKursiyer; 
            }
            set { allKursiyer = value; }
        }

    }
}
