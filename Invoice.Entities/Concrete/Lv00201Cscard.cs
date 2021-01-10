﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lv00201Cscard
    {
        public int Logicalref { get; set; }
        public string Portfoyno { get; set; }
        public string Serino { get; set; }
        public string Newserino { get; set; }
        public string Owing { get; set; }
        public DateTime? Duedate { get; set; }
        public string Bankname { get; set; }
        public double? Total { get; set; }
        public DateTime? Setdate { get; set; }
        public int? Rollref { get; set; }
    }
}