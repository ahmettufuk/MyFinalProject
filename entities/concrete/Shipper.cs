using System;
using System.Collections.Generic;
using entities.absract;

namespace entities.concrete
{
    public partial class Shipper :IEntity
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public int ShipperId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
