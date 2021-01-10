using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LCdbtmp
    {
        public int Lref { get; set; }
        public int? Module { get; set; }
        public short? Infotype { get; set; }
        public int? Objid { get; set; }
        public int? Instid { get; set; }
        public byte[] Ldata { get; set; }
    }
}
