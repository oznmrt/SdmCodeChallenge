﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Charasgn
    {
        public int Logicalref { get; set; }
        public int? Itemref { get; set; }
        public int? Charcoderef { get; set; }
        public int? Charvalref { get; set; }
        public short? Linenr { get; set; }
        public short? Matrixloc { get; set; }
        public short? Priority { get; set; }
    }
}
