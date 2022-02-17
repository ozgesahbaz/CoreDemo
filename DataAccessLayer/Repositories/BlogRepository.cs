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
    public class BlogRepository : IBlogDal
    {
        Context dbContext = new Context();
        public void AddBlog(Blog blog)
        {
            dbContext.Add(blog);
            dbContext.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            dbContext.Remove(blog);
            dbContext.SaveChanges();
        }

        public Blog GetByID(int id)
        {
            return dbContext.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            return dbContext.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            dbContext.Update(blog);
            dbContext.SaveChanges(); 
        }
    }
}
