using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg001Paramasgn
    {
        public int Logicalref { get; set; }
        public int? Bomparamref { get; set; }
        public int? Prodordref { get; set; }
        public double? Paramval { get; set; }
    }
}
