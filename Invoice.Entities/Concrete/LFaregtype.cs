using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LFaregtype
    {
        public int Logicalref { get; set; }
        public string Rcode { get; set; }
        public string Rdef { get; set; }
    }
}
