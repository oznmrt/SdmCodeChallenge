using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LgCvarpasg
    {
        public int Logicalref { get; set; }
        public int? Cstvndref { get; set; }
        public int? Arpref { get; set; }
        public short? Firmno { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public short? Defaultflg { get; set; }
    }
}
