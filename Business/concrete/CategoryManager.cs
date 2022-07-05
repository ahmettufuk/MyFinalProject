using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.absract;
using DataAccess.absract;
using entities.concrete;

namespace Business.concrete
{
    public class CategoryManager : ICategoryService
    {
        private  ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        


        public List<Category> GetAll()
        {
            return  _categoryDal.GetAll();
        }

        public List<Category> GetById(int categoryId)
        {
            return _categoryDal.GetAll(c => c.CategoryId == categoryId).ToList();
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Update(Category category)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }
    }

    
}
