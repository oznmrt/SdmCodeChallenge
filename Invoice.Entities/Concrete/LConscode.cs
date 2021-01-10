using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LConscode
    {
        public int Logicalref { get; set; }
        public short? Cardtype { get; set; }
        public string Code { get; set; }
        public string Definition { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
    }
}
