using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Distlist
    {
        public int Logicalref { get; set; }
        public short? Tsusernr { get; set; }
        public string Tsname { get; set; }
        public string Tslogoadr { get; set; }
        public string Tsmailadr { get; set; }
    }
}
