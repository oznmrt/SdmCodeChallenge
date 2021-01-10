using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Mobileasset
    {
        public int Logicalref { get; set; }
        public string Telnumber { get; set; }
        public string Definition { get; set; }
        public string Cyphcode { get; set; }
        public string Specode { get; set; }
        public short? Sourcetype { get; set; }
    }
}
