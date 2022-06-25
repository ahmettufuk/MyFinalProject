using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entities.concrete;

namespace Business.absract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategory(int categoryId);

        List<Product> GetByUnitPrice(decimal min , decimal max);

    }
}
