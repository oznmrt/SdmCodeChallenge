using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00201Qprodline
    {
        public int Logicalref { get; set; }
        public int? Stcref { get; set; }
        public double? Amnt { get; set; }
        public double? Price { get; set; }
        public double? Perc { get; set; }
        public int? Maincref { get; set; }
        public short? Lineno { get; set; }
        public double? Lostfactor { get; set; }
        public short? Sourceindex { get; set; }
        public int? Uomref { get; set; }
        public short? Cardtype { get; set; }
        public short? Department { get; set; }
        public int? Qprofcref { get; set; }
        public int? Vrntref { get; set; }
        public int? Clientref { get; set; }
        public short? Comptype { get; set; }
    }
}
