using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LCtycode
    {
        public int Logicalref { get; set; }
        public string Cphcode { get; set; }
        public string Cname { get; set; }
    }
}
