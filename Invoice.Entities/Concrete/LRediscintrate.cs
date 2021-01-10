using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LRediscintrate
    {
        public int Logicalref { get; set; }
        public short? Crtype { get; set; }
        public DateTime? Ratedate { get; set; }
        public double? Rate { get; set; }
    }
}
