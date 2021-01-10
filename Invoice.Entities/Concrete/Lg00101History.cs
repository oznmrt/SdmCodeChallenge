﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00101History
    {
        public int Logicalref { get; set; }
        public int? Tableid { get; set; }
        public int? Dataref { get; set; }
        public short? Modifiedby { get; set; }
        public DateTime? Modifieddate { get; set; }
        public short? Modifiedhour { get; set; }
        public short? Modifiedmin { get; set; }
        public short? Modifiedsec { get; set; }
        public string Username { get; set; }
        public string Modiftxt { get; set; }
        public string Dataguid { get; set; }
    }
}
