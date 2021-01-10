using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Charsetasgn
    {
        public int Logicalref { get; set; }
        public int? Charsetref { get; set; }
        public int? Charcoderef { get; set; }
        public short? Linenr { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
