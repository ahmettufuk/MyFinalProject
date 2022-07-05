using System;
using System.Collections.Generic;
using entities.absract;

namespace entities.concrete
{
    public partial class QuarterlyOrder : IEntity
    {
        public string? CustomerId { get; set; }
        public string? CompanyName { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
    }
}
