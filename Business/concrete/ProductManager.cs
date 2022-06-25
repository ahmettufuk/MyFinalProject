using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.absract;
using DataAccess.absract;
using entities.concrete;

namespace Business.concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _productDal.GetAll().Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll().Where(p => p.UnitPrice > min && p.UnitPrice < max).ToList();
        }
    }
}
