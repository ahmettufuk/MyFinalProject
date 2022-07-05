using System;
using System.Collections.Generic;
using entities.absract;

namespace entities.concrete
{
    public partial class SalesTotalsByAmount : IEntity
    {
        public decimal? SaleAmount { get; set; }
        public int OrderId { get; set; }
        public string CompanyName { get; set; } = null!;
        public DateTime? ShippedDate { get; set; }
    }
}
