using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EFCategoryRepository EFCategoryRepository;
        public CategoryManager()
        {
            EFCategoryRepository = new EFCategoryRepository();
        }       
        
        public void AddCategory(Category category)
        {
            EFCategoryRepository.Insert(category);

        }

        public void DeleteCategory(Category category)
        {
            EFCategoryRepository.Delete(category);
        }

        public Category GetByID(int id)
        {
            return EFCategoryRepository.GetByID(id);
        }

        public List<Category> ListAllCategory()
        {
            return EFCategoryRepository.GetListAll();
        }

        public void UpdateCategory(Category category)
        {
            EFCategoryRepository.Update(category);
        }
    }
}
