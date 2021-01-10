using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00101Folder
    {
        public int Logicalref { get; set; }
        public short? Linetype { get; set; }
        public string Fpath { get; set; }
    }
}
