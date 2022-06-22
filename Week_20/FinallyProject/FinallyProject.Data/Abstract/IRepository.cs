using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinallyProject.Data.Abstract
{
    public interface IRepository<T>
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAll();
        void Create(T Entity);
        void Delete(T Entity);
        void Update(T Entity);
    }
}
