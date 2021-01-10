using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LUsersdef
    {
        public int Logicalref { get; set; }
        public short? Usernr { get; set; }
        public short? Firmnr { get; set; }
        public short? Divnr { get; set; }
        public short? Deptnr { get; set; }
        public short? Factnr { get; set; }
        public short? Whnr { get; set; }
        public short? Linenr { get; set; }
    }
}
