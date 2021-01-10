using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LCapirole
    {
        public int Logicalref { get; set; }
        public short? Nr { get; set; }
        public string Name { get; set; }
        public string Custtable { get; set; }
    }
}
