﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Toolreq
    {
        public int Logicalref { get; set; }
        public int? Opreqref { get; set; }
        public int? Lineno { get; set; }
        public int? Toolref { get; set; }
        public double? Amount { get; set; }
        public int? Uomref { get; set; }
        public short? Tooltype { get; set; }
        public int? Revref { get; set; }
        public int? Operationref { get; set; }
    }
}
