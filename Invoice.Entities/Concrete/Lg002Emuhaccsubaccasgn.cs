using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Emuhaccsubaccasgn
    {
        public int Logicalref { get; set; }
        public int? Accountref { get; set; }
        public int? Subaccountref { get; set; }
    }
}
