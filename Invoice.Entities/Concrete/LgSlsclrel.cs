using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LgSlsclrel
    {
        public int Logicalref { get; set; }
        public int? Cstvndref { get; set; }
        public int? Salesmanref { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
