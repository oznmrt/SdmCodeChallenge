using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LTextfav
    {
        public int Logicalref { get; set; }
        public string Info { get; set; }
        public int? Usernr { get; set; }
    }
}
