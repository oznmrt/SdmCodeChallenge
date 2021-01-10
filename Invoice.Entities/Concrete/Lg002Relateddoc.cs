using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Relateddoc
    {
        public int Logicalref { get; set; }
        public string Doccode { get; set; }
        public string Docdef { get; set; }
        public int? Creletterref { get; set; }
        public short? Originalcnt { get; set; }
        public short? Copycnt { get; set; }
    }
}
