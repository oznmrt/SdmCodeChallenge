using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LCapiupdate
    {
        public int Logicalref { get; set; }
        public DateTime? Date { get; set; }
        public short? Hr { get; set; }
        public short? Min { get; set; }
        public short? Sec { get; set; }
        public short? Msec { get; set; }
        public string Updates { get; set; }
    }
}
