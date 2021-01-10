using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lv00201Cltotfil
    {
        public int Logicalref { get; set; }
        public int? Cardref { get; set; }
        public int Tottyp { get; set; }
        public int? Month { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public short? Year { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
    }
}
