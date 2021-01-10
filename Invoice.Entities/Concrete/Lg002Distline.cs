using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Distline
    {
        public int Logicalref { get; set; }
        public int? Disttempref { get; set; }
        public int? Itemref { get; set; }
        public double? Distfact { get; set; }
        public short? Lineno { get; set; }
        public int? Variantref { get; set; }
    }
}
