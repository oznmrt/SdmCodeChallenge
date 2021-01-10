﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LCapiunit
    {
        public int Logicalref { get; set; }
        public short? Firmnr { get; set; }
        public short? Nr { get; set; }
        public string Name { get; set; }
        public int? Userext { get; set; }
        public DateTime? Moddate { get; set; }
        public int? Modtime { get; set; }
        public short? Passive { get; set; }
        public string Netflag { get; set; }
    }
}
