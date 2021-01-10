using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LOrgdef
    {
        public int Logicalref { get; set; }
        public int? Chartid { get; set; }
        public DateTime? Revdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string Code { get; set; }
        public string Exp { get; set; }
        public short? Grouping { get; set; }
    }
}
