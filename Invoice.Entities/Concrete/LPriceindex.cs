using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LPriceindex
    {
        public int Logicalref { get; set; }
        public int? Idxtypref { get; set; }
        public DateTime? Idxdate { get; set; }
        public double? Priceidx { get; set; }
    }
}
