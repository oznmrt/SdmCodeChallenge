﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Unitsetc
    {
        public int Logicalref { get; set; }
        public int? Parentusref { get; set; }
        public int? Childusref { get; set; }
        public double? Convfact1 { get; set; }
        public double? Convfact2 { get; set; }
    }
}
