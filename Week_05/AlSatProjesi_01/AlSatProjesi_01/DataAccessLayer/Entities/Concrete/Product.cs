﻿using AlSatProjesi_01.DataAccessLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlSatProjesi_01.DataAccessLayer.Entities.Concrete
{
    class Product : IBaseEntity
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int CurrentStock { get; set; }
    }
}
