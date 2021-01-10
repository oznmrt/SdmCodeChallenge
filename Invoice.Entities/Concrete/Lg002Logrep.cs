﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Logrep
    {
        public int Logicalref { get; set; }
        public short? Logtype { get; set; }
        public int? Linenr { get; set; }
        public short? Linetype { get; set; }
        public string Lineexp { get; set; }
        public int? Msgnum1 { get; set; }
        public int? Msgnum2 { get; set; }
        public string Sessioncode { get; set; }
        public string Lineexplain2 { get; set; }
    }
}
