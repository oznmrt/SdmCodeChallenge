﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lv00201Cltotfilv1
    {
        public int? Cardref { get; set; }
        public int? Month { get; set; }
        public short? Year { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public double? Debit { get; set; }
        public double? DebitRc { get; set; }
        public double? Credit { get; set; }
        public double? CreditRc { get; set; }
        public long? TrnCntBig { get; set; }
    }
}
