using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private List<Category> _categories;

        public CategoryDal()
        {
            _categories = new List<Category> 
            {
                new Category{Id = 1, CategoryName = "Coding Backend"},
                new Category{Id = 2, CategoryName = "Coding Frontend"}
            };
        }
        public void Add(Category item)
        {
            _categories.Add(item);
        }

        public void Delete(int id)
        {
            Category filteredCategory = Get(id);
            if(filteredCategory != null)
            {
                _categories.Remove(filteredCategory);
            }
        }

        public Category Get(int id)
        {
            return _categories.Where(c => c.Id == id).SingleOrDefault();
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public void Update(Category item)
        {
            Category filteredCategory = Get(item.Id);
            filteredCategory.CategoryName = item.CategoryName;
        }
    }
}
