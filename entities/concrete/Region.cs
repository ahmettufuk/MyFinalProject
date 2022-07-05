using System;
using System.Collections.Generic;
using entities.absract;

namespace entities.concrete
{
    public partial class Region : IEntity
    {
        public Region()
        {
            Territories = new HashSet<Territory>();
        }

        public int RegionId { get; set; }
        public string RegionDescription { get; set; } = null!;

        public virtual ICollection<Territory> Territories { get; set; }
    }
}
