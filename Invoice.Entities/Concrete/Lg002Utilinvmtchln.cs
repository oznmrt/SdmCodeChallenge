using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Utilinvmtchln
    {
        public int Logicalref { get; set; }
        public short? Linetype { get; set; }
        public int? Uimtchtblref { get; set; }
        public int? Serviceref { get; set; }
        public string Serviceno { get; set; }
        public double? Taxrate { get; set; }
        public int? Projectref { get; set; }
        public short? Branch { get; set; }
    }
}
