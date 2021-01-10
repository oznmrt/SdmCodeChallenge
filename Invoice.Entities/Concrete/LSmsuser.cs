using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LSmsuser
    {
        public int Logicalref { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Telone { get; set; }
        public short? Activestatus { get; set; }
        public short? Supplierconfirmed { get; set; }
    }
}
