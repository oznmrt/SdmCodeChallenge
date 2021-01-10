using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LTradgrp
    {
        public int Logicalref { get; set; }
        public string Gcode { get; set; }
        public string Gdef { get; set; }
        public int? Gattrib { get; set; }
        public short? Trdgrptype { get; set; }
        public short? Active { get; set; }
    }
}
