﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Itmclsa
    {
        public int Logicalref { get; set; }
        public int? Parentref { get; set; }
        public int? Childref { get; set; }
        public short? Uplevel { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
