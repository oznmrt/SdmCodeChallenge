﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Clintel
    {
        public int Logicalref { get; set; }
        public int? Clientref { get; set; }
        public short? Linenum { get; set; }
        public string Intelline { get; set; }
    }
}
