using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Wschval
    {
        public int Logicalref { get; set; }
        public int? Charcoderef { get; set; }
        public int? Valno { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
    }
}
