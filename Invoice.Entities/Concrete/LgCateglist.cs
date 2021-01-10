using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LgCateglist
    {
        public int Logicalref { get; set; }
        public int? Categid { get; set; }
        public short? Lineno { get; set; }
        public int? Tag { get; set; }
        public string Catdesc { get; set; }
        public short? Custom { get; set; }
        public int? Recordid { get; set; }
    }
}
