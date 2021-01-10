using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg001Mrpitem
    {
        public int Logicalref { get; set; }
        public int? Headerref { get; set; }
        public int? Itemref { get; set; }
        public short? Changed { get; set; }
        public int? Variantref { get; set; }
    }
}
