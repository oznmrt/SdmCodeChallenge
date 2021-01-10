using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Ovrhdaccref
    {
        public int Logicalref { get; set; }
        public int? Cardref { get; set; }
        public int? Accountref { get; set; }
        public short? Typ { get; set; }
    }
}
