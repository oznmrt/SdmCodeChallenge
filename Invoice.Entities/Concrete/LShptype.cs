using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LShptype
    {
        public int Logicalref { get; set; }
        public string Scode { get; set; }
        public string Sdef { get; set; }
        public string Sdef2 { get; set; }
        public short? Pricelevel { get; set; }
        public string Edicode { get; set; }
    }
}
