using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg001Mblinfogroup
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Groupid { get; set; }
        public int? Mbltype { get; set; }
    }
}
