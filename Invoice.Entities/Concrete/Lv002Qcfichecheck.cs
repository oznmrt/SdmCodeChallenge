using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lv002Qcfichecheck
    {
        public int Trcode { get; set; }
        public short? Asgntype { get; set; }
        public int? Asgnref { get; set; }
        public int? Setref { get; set; }
        public int? Revisionno { get; set; }
        public int? Okay1 { get; set; }
        public int? Okay2 { get; set; }
    }
}
