using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Shftasgn
    {
        public int Logicalref { get; set; }
        public short? Sourcetype { get; set; }
        public int? Sourceref { get; set; }
        public int? Shiftref { get; set; }
        public DateTime? Begdate { get; set; }
        public short? Linenr { get; set; }
        public int? Shifttref { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
