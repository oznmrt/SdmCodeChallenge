using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lv00201Srvtot
    {
        public int Logicalref { get; set; }
        public int? Cardref { get; set; }
        public int? Invenno { get; set; }
        public int? Month { get; set; }
        public double? TotalsAmount { get; set; }
        public double? TotalsCashamnt { get; set; }
        public double? TotalsCurramnt { get; set; }
        public int TotalsVatamnt { get; set; }
        public int TotalsDiscamnt { get; set; }
        public int TotalsRetamnt { get; set; }
        public int? Year { get; set; }
    }
}
