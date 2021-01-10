using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg001Fintbllineacc
    {
        public int Logicalref { get; set; }
        public int? Tblref { get; set; }
        public int? Lnref { get; set; }
        public short? Tbltyp { get; set; }
        public int? Accountref { get; set; }
    }
}
