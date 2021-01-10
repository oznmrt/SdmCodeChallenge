using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LDynrepusrr
    {
        public int Logicalref { get; set; }
        public short? Usernr { get; set; }
        public int? Repid { get; set; }
        public short? Allowcustdsgn { get; set; }
        public short? Allowcustdsgnsel { get; set; }
        public short? Allowusereport { get; set; }
        public short? Firmnr { get; set; }
    }
}
