using KodlamaIODemo.Business.Abstract;
using KodlamaIODemo.DataAccess.Abstract;
using KodlamaIODemo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIODemo.Business.Concrete
{
    public class CategoryManager : ICategoryBusiness
    {
        private ICategoryDal _catogoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _catogoryDal = categoryDal;
        }
        public void Add(Category item)
        {
            _catogoryDal.Add(item);
        }

        public void Delete(int id)
        {
            _catogoryDal.Delete(id);
        }

        public Category Get(int id)
        {
            return _catogoryDal.Get(id);
        }

        public List<Category> GetAll()
        {
            return _catogoryDal.GetAll();
        }

        public void Update(Category item)
        {
            _catogoryDal.Update(item);
        }
    }
}
