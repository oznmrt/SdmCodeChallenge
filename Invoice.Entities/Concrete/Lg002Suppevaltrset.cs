using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Suppevaltrset
    {
        public int Logicalref { get; set; }
        public int? Spevalficheref { get; set; }
        public int? Spevaltransref { get; set; }
        public int? Spevalcrsetref { get; set; }
        public int? Spevalcrref { get; set; }
        public int? Clientref { get; set; }
        public int? Itemref { get; set; }
        public int? Variantref { get; set; }
        public short? Lineno { get; set; }
        public double? Weight { get; set; }
        public double? Score { get; set; }
    }
}
