using System;
using System.Collections.Generic;
using entities.absract;

namespace entities.concrete
{
    public partial class ProductSalesFor1997 : IEntity
    {
        public string CategoryName { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public decimal? ProductSales { get; set; }
    }
}
