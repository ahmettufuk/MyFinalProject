using System;
using System.Collections.Generic;
using entities.absract;

namespace entities.concrete
{
    public partial class CustomerAndSuppliersByCity : IEntity
    {
        public string? City { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? ContactName { get; set; }
        public string Relationship { get; set; } = null!;
    }
}
