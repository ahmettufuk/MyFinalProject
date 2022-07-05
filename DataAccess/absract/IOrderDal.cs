using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using DataAccess.concrete.EntityFrameWork;
using entities.concrete;


namespace DataAccess.absract
{
    public interface IOrderDal : IEntityRepository<Order>
    {
    }
}
