using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Ovrhdcenterln
    {
        public int Logicalref { get; set; }
        public int? Ovrhdcenterref { get; set; }
        public int? Costprdref { get; set; }
        public int? Overheadref { get; set; }
        public double? Capacity { get; set; }
        public double? Total { get; set; }
        public double? Reportrate { get; set; }
        public double? Activityamount { get; set; }
        public double? Ovhdstdunitcost { get; set; }
        public short? Prdlinenr { get; set; }
        public short? Linenr { get; set; }
        public short? Linetype { get; set; }
        public int? Indirectref { get; set; }
        public int? Distrateref { get; set; }
        public double? Rdtotal { get; set; }
    }
}
