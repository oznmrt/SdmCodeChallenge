using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Expcreditln
    {
        public int Logicalref { get; set; }
        public int? Excreditref { get; set; }
        public string Gtipcode { get; set; }
        public int? Unitsetref { get; set; }
        public int? Uomref { get; set; }
        public double? Amount { get; set; }
        public short? Trcurr { get; set; }
        public double? Trtotal { get; set; }
        public double? Trrate { get; set; }
        public double? Reportrate { get; set; }
        public short? Lineno { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
