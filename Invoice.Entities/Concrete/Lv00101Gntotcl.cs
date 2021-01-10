﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lv00101Gntotcl
    {
        public int Logicalref { get; set; }
        public int? Cardref { get; set; }
        public int Tottyp { get; set; }
        public double? Debit { get; set; }
        public double? Credit { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
    }
}
