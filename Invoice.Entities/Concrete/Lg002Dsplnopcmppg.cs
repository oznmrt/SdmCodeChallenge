﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Dsplnopcmppg
    {
        public int Logicalref { get; set; }
        public int? Prodordref { get; set; }
        public int? Displineref { get; set; }
        public int? Itemref { get; set; }
        public short? Detline { get; set; }
        public int? Parentitemref { get; set; }
        public short? Lineno { get; set; }
        public double? Consumpamnt { get; set; }
        public double? Wasteamnt { get; set; }
        public int? Variantref { get; set; }
    }
}
