using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Itemobtainlimit
    {
        public int Logicalref { get; set; }
        public short? Obtaintype { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public double? Obtainlimit { get; set; }
    }
}
