using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Faregnewvalue
    {
        public int Logicalref { get; set; }
        public int? Faregref { get; set; }
        public DateTime? Date { get; set; }
        public double? Newvalue { get; set; }
        public short? Lineno { get; set; }
        public short? Accflg { get; set; }
        public int? Accficheref { get; set; }
        public double? Reportrate { get; set; }
        public double? Newreportnet { get; set; }
        public short? Deptabtyp { get; set; }
    }
}
