using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LCapiwebconn
    {
        public int Logicalref { get; set; }
        public short? Nr { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
