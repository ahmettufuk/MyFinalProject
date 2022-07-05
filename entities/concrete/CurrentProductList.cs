using System;
using System.Collections.Generic;
using entities.absract;

namespace entities.concrete
{
    public partial class CurrentProductList : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
