﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00201Tmpacasgn
    {
        public int Logicalref { get; set; }
        public int? Diiblineref { get; set; }
        public int? Inveximlineref { get; set; }
        public double? Clsdamount { get; set; }
        public int? Clsduomref { get; set; }
        public int? Clsdusref { get; set; }
        public double? Clsdtotal { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
