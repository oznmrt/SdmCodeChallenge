using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Accounttemplate
    {
        public int Logicalref { get; set; }
        public int? Accountref { get; set; }
        public short? Trcode { get; set; }
        public short? Typ { get; set; }
        public short? Lastpartlevel { get; set; }
        public string Lastcode { get; set; }
    }
}
