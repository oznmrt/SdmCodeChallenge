using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LCapiver
    {
        public int Logicalref { get; set; }
        public short? Nr { get; set; }
        public short? Firmnr { get; set; }
        public short? Majdbvers { get; set; }
        public short? Mindbvers { get; set; }
        public short? Reldbvers { get; set; }
    }
}
