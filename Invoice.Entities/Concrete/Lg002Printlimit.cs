using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Printlimit
    {
        public int Logicalref { get; set; }
        public int? Formid { get; set; }
        public short? Prnlimit { get; set; }
        public short? Typ { get; set; }
    }
}
