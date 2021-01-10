using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LPckcode
    {
        public int Logicalref { get; set; }
        public string Pcode { get; set; }
        public string Pdef { get; set; }
        public string Pdef2 { get; set; }
        public string Edicode { get; set; }
    }
}
