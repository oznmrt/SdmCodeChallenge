using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Bomvrntformula
    {
        public int Logicalref { get; set; }
        public int? Bomlref { get; set; }
        public short? Typ { get; set; }
        public short? Linenr { get; set; }
        public int? Mainitemref { get; set; }
        public int? Maincharref { get; set; }
        public short? Operator { get; set; }
        public short? Asgtyp { get; set; }
        public int? Cardref { get; set; }
        public short? Logicop { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public short? Isitemrefcboml { get; set; }
        public int? Mainvalref { get; set; }
    }
}
