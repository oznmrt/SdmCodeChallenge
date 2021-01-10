﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00201Diibbomline
    {
        public int Logicalref { get; set; }
        public int? Diibficheref { get; set; }
        public int? Explineref { get; set; }
        public int? Implineref { get; set; }
        public short? Lineno { get; set; }
        public double? Amount { get; set; }
        public double? Scrapper { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}