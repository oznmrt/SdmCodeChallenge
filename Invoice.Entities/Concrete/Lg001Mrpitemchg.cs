﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg001Mrpitemchg
    {
        public int Logicalref { get; set; }
        public int? Itemref { get; set; }
        public int? Paritemref { get; set; }
        public int? Variantref { get; set; }
    }
}
