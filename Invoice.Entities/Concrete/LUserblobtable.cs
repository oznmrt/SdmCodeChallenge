using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LUserblobtable
    {
        public int Logicalref { get; set; }
        public short? Usernr { get; set; }
        public short? Typ { get; set; }
        public byte[] Ldata { get; set; }
    }
}
