using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00201Clbranchpayplan
    {
        public int Logicalref { get; set; }
        public int? Clcardref { get; set; }
        public short? Branch { get; set; }
        public int? Paypref { get; set; }
        public int? Projref { get; set; }
    }
}
