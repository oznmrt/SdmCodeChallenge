﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LCpaCode
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public short? Level { get; set; }
        public short? Codeempty { get; set; }
        public short? Selectable { get; set; }
    }
}
