using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Mblinfusrgrpln
    {
        public int Logicalref { get; set; }
        public int? Mblinfuserref { get; set; }
        public int? Mblinfgroupref { get; set; }
        public short? Linenr { get; set; }
        public short? Mbltype { get; set; }
    }
}
