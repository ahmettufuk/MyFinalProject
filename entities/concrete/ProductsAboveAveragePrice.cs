using System;
using System.Collections.Generic;
using entities.absract;

namespace entities.concrete
{
    public partial class ProductsAboveAveragePrice :IEntity
    {
        public string ProductName { get; set; } = null!;
        public decimal? UnitPrice { get; set; }
    }
}
