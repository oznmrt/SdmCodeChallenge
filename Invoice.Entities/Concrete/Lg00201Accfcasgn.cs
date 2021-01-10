using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00201Accfcasgn
    {
        public int Logicalref { get; set; }
        public int? Accfcref { get; set; }
        public int? Fcref { get; set; }
        public short? Typ { get; set; }
    }
}
