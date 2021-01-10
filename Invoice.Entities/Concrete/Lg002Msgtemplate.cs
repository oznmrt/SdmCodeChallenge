using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Msgtemplate
    {
        public int Logicalref { get; set; }
        public short? Msgtype { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Msgtext { get; set; }
    }
}
