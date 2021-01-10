using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg001Wftaskper
    {
        public int Logicalref { get; set; }
        public short? Periodtype { get; set; }
        public short? Period { get; set; }
        public short? Weekdays { get; set; }
        public short? Monthdays { get; set; }
        public DateTime? Periodenddate { get; set; }
        public short? Nonworkdays { get; set; }
    }
}
