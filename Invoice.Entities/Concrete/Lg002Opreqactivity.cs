﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Opreqactivity
    {
        public int Logicalref { get; set; }
        public int? Opreqref { get; set; }
        public int? Ovhdref { get; set; }
        public string Formula { get; set; }
        public double? Amount { get; set; }
        public short? Whenhappen { get; set; }
    }
}
