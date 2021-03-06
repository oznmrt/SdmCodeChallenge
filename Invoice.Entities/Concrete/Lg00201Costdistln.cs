﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00201Costdistln
    {
        public int Logicalref { get; set; }
        public int? Srvref { get; set; }
        public DateTime? Date { get; set; }
        public int? Ftime { get; set; }
        public int? Costdistfcref { get; set; }
        public int? Srvficheref { get; set; }
        public int? Srvtransref { get; set; }
        public short? Linenr { get; set; }
        public short? Srvdisttype { get; set; }
        public double? Disttotal { get; set; }
        public int? Srvaccref { get; set; }
        public int? Srvcenterref { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
        public short? Trcode { get; set; }
        public double? Disttotalufrs { get; set; }
        public short? Fichetype { get; set; }
    }
}
