using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg001Stopasgn
    {
        public int Logicalref { get; set; }
        public int? Wsref { get; set; }
        public int? Causeref { get; set; }
        public short? Affectscost { get; set; }
        public short? Affectsplan { get; set; }
    }
}
