using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg001Accdisttempln
    {
        public int Logicalref { get; set; }
        public int? Disttempref { get; set; }
        public int? Centerref { get; set; }
        public int? Projectref { get; set; }
        public double? Distfact { get; set; }
        public short? Linenr { get; set; }
    }
}
