using System;
using System.Collections.Generic;
using entities.absract;

namespace entities.concrete
{
    public partial class OrderSubtotal : IEntity
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
