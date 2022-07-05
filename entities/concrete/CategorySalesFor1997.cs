using System;
using System.Collections.Generic;
using entities.absract;

namespace entities.concrete
{
    public partial class CategorySalesFor1997 :  IEntity
    {
        public string CategoryName { get; set; } = null!;
        public decimal? CategorySales { get; set; }
    }
}
