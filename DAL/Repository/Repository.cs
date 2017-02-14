using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class Repository<T> : IDisposable, IRepository<T> where T : Entity
    {
        private ApplicationContext appContext;
        public Repository()
        {
            this.appContext = new ApplicationContext();
        }

        public IEnumerable<T> GetAll
        {
            get
            {
                try
                {
                    return this.appContext.Set<T>().ToList();
                }
                catch (Exception e)
                {
                    return null;
                }
                
            }
        }

        public void Dispose()
        {
            
        }

        public T GetById(Guid id)
        {
            try
            {
                return this.appContext.Set<T>().Where(t => t.Id == id).FirstOrDefault();
            }
            catch (Exception e)
            {
                return null;
            }
            
        }

        public T InsertOrUpdate(T entity)
        {
            try
            {
                this.appContext.Entry<T>(entity).State = (entity.Id == Guid.Empty) ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
                this.appContext.SaveChanges();
                return entity;
            }
            catch (Exception e)
            {
                return entity;
            }
        }

        public void Remove(T entity)
        {
            try
            {
                this.appContext.Entry<T>(entity).State = System.Data.Entity.EntityState.Deleted;
                this.appContext.SaveChanges();
            }
            catch (Exception e)
            {
                
            }
            
        }
    }
}
