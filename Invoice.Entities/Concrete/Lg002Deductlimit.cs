﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Deductlimit
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public double? Deductlimit { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
