﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Fichestatus
    {
        public int Logicalref { get; set; }
        public short? Typ { get; set; }
        public string Name { get; set; }
        public short? Active { get; set; }
        public short? Linenr { get; set; }
    }
}
