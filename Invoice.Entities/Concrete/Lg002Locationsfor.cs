﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Locationsfor
    {
        public int Logicalref { get; set; }
        public short? Modulenr { get; set; }
        public int? Parentref { get; set; }
        public short? Typ { get; set; }
        public short? Nr { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}