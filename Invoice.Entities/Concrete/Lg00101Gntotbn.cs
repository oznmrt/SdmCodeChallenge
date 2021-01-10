using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00101Gntotbn
    {
        public int Logicalref { get; set; }
        public int? Cardref { get; set; }
        public short? Tottyp { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
    }
}
