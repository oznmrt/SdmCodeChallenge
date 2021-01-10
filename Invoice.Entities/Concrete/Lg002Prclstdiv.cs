using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Prclstdiv
    {
        public int Logicalref { get; set; }
        public int? Parentprcref { get; set; }
        public string Divcodes { get; set; }
    }
}
