﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Glconnfilt
    {
        public int Logicalref { get; set; }
        public int? Connectionref { get; set; }
        public short? Selnr { get; set; }
        public short? Seltype { get; set; }
        public string Grpvalue { get; set; }
        public string Begvalue { get; set; }
        public string Endvalue { get; set; }
    }
}
