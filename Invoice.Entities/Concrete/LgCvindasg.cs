using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LgCvindasg
    {
        public int Logicalref { get; set; }
        public int? Cstvndref { get; set; }
        public int? Indref { get; set; }
        public short? Primaryflg { get; set; }
        public double? Annvolume { get; set; }
        public short? Volcurr { get; set; }
        public double? Annvolumerc { get; set; }
        public double? Employeecnt { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
