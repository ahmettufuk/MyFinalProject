using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.absract;
using entities.concrete;

namespace DataAccess.concrete.EntityFrameWork
{
    public class EfOrderDal :EfEntityRepositoryBase<Order,NorthwindContext> , IOrderDal
    {

    }
}
