using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg001Wsgrpass
    {
        public int Logicalref { get; set; }
        public int? Wsgrpref { get; set; }
        public short? Priority { get; set; }
        public int? Wsref { get; set; }
        public short? Dominshftgrp { get; set; }
    }
}
