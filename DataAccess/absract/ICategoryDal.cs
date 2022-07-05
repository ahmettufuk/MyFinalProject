using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using entities.concrete;


namespace DataAccess.absract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {    
        
    }
}
