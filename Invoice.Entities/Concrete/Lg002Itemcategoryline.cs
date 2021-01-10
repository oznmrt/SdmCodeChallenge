using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Itemcategoryline
    {
        public int Logicalref { get; set; }
        public int? Itemcategoryref { get; set; }
        public int? Itemref { get; set; }
        public short? Lineno { get; set; }
    }
}
