using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LCapiroleobj
    {
        public int Logicalref { get; set; }
        public short? Rolenr { get; set; }
        public short? Objtyp { get; set; }
        public short? Appid { get; set; }
        public short? Mdlid { get; set; }
        public int? Objid { get; set; }
    }
}
