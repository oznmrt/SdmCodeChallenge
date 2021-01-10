using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Emgrpass
    {
        public int Logicalref { get; set; }
        public int? Empgrpref { get; set; }
        public short? Priority { get; set; }
        public int? Empref { get; set; }
        public short? Dominshftgrp { get; set; }
    }
}
