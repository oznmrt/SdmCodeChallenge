using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00201Gntotcsh
    {
        public int Logicalref { get; set; }
        public int? Cardref { get; set; }
        public short? Tottype { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
    }
}
