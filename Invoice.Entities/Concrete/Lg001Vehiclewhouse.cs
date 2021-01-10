using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg001Vehiclewhouse
    {
        public int Logicalref { get; set; }
        public int? Vehicleref { get; set; }
        public short? Whousenr { get; set; }
        public short? Daynr { get; set; }
        public int? Shipbegtime { get; set; }
        public int? Shipendtime { get; set; }
        public short? Linenr { get; set; }
    }
}
