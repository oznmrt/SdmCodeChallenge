using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg001Ovhcdistrate
    {
        public int Logicalref { get; set; }
        public int? Cardref { get; set; }
        public int? Costprdref { get; set; }
        public int? Centerref { get; set; }
        public double? Distrate { get; set; }
    }
}
