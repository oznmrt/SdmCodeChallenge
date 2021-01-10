using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Avgcurr
    {
        public int Logicalref { get; set; }
        public short? Currtype { get; set; }
        public int? Periodref { get; set; }
        public double? Avgcurrval { get; set; }
    }
}
