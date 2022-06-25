using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.absract;
using entities.concrete;

namespace DataAccess.absract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    
    }
}
