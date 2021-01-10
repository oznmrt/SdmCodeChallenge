﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00201Clparam
    {
        public int Logicalref { get; set; }
        public int? Clref { get; set; }
        public int? Headerref { get; set; }
        public short? Paramtype { get; set; }
        public short? Paramnr { get; set; }
        public int? Paramval1 { get; set; }
        public string Paramstr1 { get; set; }
        public string Paramstr2 { get; set; }
        public short? Usernr { get; set; }
    }
}