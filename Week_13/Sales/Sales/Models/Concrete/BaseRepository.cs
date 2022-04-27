﻿using Sales.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        public void Add(T entity)
        {
            using (var _context = new SalesDbContext())
            {
                _context.Add(entity);
                _context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var _context = new SalesDbContext())
            {
                _context.Remove(entity);
                _context.SaveChanges();
            }
        }

        public T GetSingle()
        {
            using (var _context = new SalesDbContext())
            {
                return _context.Set<T>().ToList();
            }
        }

        public List<T> GetAll()
        {
            using (var _context = new SalesDbContext())
            {
                return _context.Set<T>().FirstOrDefault();
            }
        }

        public void Update(T entity)
        {
            using (var _context = new SalesDbContext())
            {
                _context.Update(entity);
                _context.SaveChanges();
            }
        }
    }
}