﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Poaccref
    {
        public int Logicalref { get; set; }
        public int? Pordref { get; set; }
        public short? Typ { get; set; }
        public int? Wsref { get; set; }
        public int? Accountref { get; set; }
        public int? Centerref { get; set; }
        public int? Ovhdref { get; set; }
        public int? Stref { get; set; }
        public short? Ovhdtrantyp { get; set; }
    }
}