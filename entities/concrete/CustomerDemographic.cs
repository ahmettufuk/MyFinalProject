using System;
using System.Collections.Generic;
using entities.absract;

namespace entities.concrete
{
    public partial class CustomerDemographic : IEntity
    {
        public CustomerDemographic()
        {
            Customers = new HashSet<Customer>();
        }

        public string CustomerTypeId { get; set; } = null!;
        public string? CustomerDesc { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
