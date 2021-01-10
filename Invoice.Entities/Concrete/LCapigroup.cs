using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LCapigroup
    {
        public int Logicalref { get; set; }
        public short? Nr { get; set; }
        public string Name { get; set; }
        public short? Superflg { get; set; }
    }
}
