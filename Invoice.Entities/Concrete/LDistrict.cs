using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LDistrict
    {
        public int Logicalref { get; set; }
        public int? Townnr { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public string Name2 { get; set; }
        public string Netflag { get; set; }
    }
}
