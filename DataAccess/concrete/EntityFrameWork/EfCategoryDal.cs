﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.Models;
using Core.DataAccess.EntityFramework;
using DataAccess.absract;
using entities.concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.concrete.EntityFrameWork
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category,NorthwindContext> , ICategoryDal
    {
        

    }
}
