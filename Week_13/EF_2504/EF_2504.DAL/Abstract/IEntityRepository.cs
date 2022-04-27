﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2504.DAL.Abstract
{
    public interface IEntityRepository<T> where T:class
    {
        void Add(T entity);                     //(C)reate
        T GetBy();                              //(R)ead
        List<T> GetAll();
        void Update(T entity);                  //(U)pdate
        void Delete(T entity);                  //(D)elete
        
    }
}
