using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg001Bomparam
    {
        public int Logicalref { get; set; }
        public int? Paramref { get; set; }
        public int? Bommasterref { get; set; }
        public short? Linenr { get; set; }
        public double? Paramdefault { get; set; }
    }
}
