using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Crdacref
    {
        public int Logicalref { get; set; }
        public short? Trcode { get; set; }
        public int? Cardref { get; set; }
        public short? Typ { get; set; }
        public int? Accountref { get; set; }
        public int? Centerref { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Projectref { get; set; }
    }
}
