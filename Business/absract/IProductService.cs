using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using entities.concrete;
using entities.DTOs;

namespace Business.absract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategory(int categoryId);

        IDataResult<List<Product>> GetByUnitPrice(decimal min , decimal max);

        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);

        IResult Add(Product product);
        void Update(Product product);
        void Delete(Product product);

    }
}
