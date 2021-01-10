using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg001Multiaddtax
    {
        public int Logicalref { get; set; }
        public short? Cardtype { get; set; }
        public int? Cardref { get; set; }
        public int? Addtaxref { get; set; }
    }
}
