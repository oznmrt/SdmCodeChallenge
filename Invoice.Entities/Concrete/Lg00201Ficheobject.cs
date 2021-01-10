using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00201Ficheobject
    {
        public int Logicalref { get; set; }
        public int? Ficheref { get; set; }
        public short? Fichetype { get; set; }
        public short? Objecttype { get; set; }
        public byte[] Ldata { get; set; }
    }
}
