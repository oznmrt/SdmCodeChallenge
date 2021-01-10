using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg001Tradgrpayplancon
    {
        public int Logicalref { get; set; }
        public short? Linenr { get; set; }
        public int? Trdgrpref { get; set; }
        public int? Payplanref { get; set; }
    }
}
