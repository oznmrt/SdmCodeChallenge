﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00101Journal
    {
        public int Logicalref { get; set; }
        public short? Branchnr { get; set; }
        public int? Lstjndate { get; set; }
        public int? Lstjnumber { get; set; }
    }
}
