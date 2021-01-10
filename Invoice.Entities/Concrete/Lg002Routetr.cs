using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Routetr
    {
        public int Logicalref { get; set; }
        public int? Routeref { get; set; }
        public short? Lineno { get; set; }
        public int? Clientref { get; set; }
    }
}
