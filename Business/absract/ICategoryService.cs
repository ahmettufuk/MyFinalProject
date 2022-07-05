using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities.concrete;

namespace Business.absract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        List<Category> GetById(int categoryId);
        
        void Add(Category category);
        void Update(Category category);
        void Delete(Category category);
        
    }
}
