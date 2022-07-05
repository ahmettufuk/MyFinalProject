using System;
using System.Collections.Generic;
using entities.absract;

namespace entities.concrete
{
    public partial class SummaryOfSalesByYear : IEntity
    {
        public DateTime? ShippedDate { get; set; }
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
