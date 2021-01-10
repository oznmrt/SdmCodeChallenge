using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00201Impsrvrel
    {
        public int Logicalref { get; set; }
        public int? Srvcrdref { get; set; }
        public int? Invoiceref { get; set; }
        public short? Disttype { get; set; }
    }
}
