﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Leasingregln
    {
        public int Logicalref { get; set; }
        public int? Leasingregref { get; set; }
        public int? Fixassetref { get; set; }
        public double? Amount { get; set; }
        public int? Uomref { get; set; }
        public string Description { get; set; }
        public short? Lineno { get; set; }
    }
}