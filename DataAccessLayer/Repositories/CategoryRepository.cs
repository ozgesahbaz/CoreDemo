using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context dbcontext = new Context();
        public void AddCategory(Category category)
        {
            dbcontext.Add(category);
            dbcontext.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            dbcontext.Remove(category);
            dbcontext.SaveChanges();
        }

        public Category GetByID(int id)
        {
            return dbcontext.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
           return dbcontext.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            dbcontext.Update(category);
            dbcontext.SaveChanges();
        }
    }
}
