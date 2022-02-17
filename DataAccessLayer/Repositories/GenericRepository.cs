using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        Context dbContext = new Context(); 
        public void Delete(T t)
        {
            dbContext.Remove(t);
            dbContext.SaveChanges();
        }

        public T GetByID(int id)
        {
            return dbContext.Set<T>().Find(id);

        }

        public List<T> GetListAll()
        {
            return dbContext.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            dbContext.Add(t);
            dbContext.SaveChanges();
        }

        public void Update(T t)
        {
            dbContext.Update(t);
            dbContext.SaveChanges();
        }
    }
}
