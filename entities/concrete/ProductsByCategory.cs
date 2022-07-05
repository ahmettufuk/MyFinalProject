using System;
using System.Collections.Generic;
using entities.absract;

namespace entities.concrete
{
    public partial class ProductsByCategory : IEntity
    {
        public string CategoryName { get; set; } = null!;
        public string ProductName { get; set; } = null!;
        public string? QuantityPerUnit { get; set; }
        public short? UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
    }
}
