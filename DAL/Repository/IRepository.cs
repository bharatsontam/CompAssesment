using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public interface IRepository<T>
    {
        T InsertOrUpdate(T entity);
        void Remove(T entity);
        T GetById(Guid id);
        IEnumerable<T> GetAll { get; }
    }
}
