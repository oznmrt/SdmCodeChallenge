using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Genmodp
    {
        public int Logicalref { get; set; }
        public short? Modulenr { get; set; }
        public short? Level { get; set; }
        public int? Parentref { get; set; }
        public int? Ownerref { get; set; }
        public int? Index { get; set; }
        public int? Ivalue { get; set; }
    }
}
