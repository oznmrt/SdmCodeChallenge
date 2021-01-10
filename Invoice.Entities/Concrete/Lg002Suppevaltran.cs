using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Suppevaltran
    {
        public int Logicalref { get; set; }
        public int? Spevalficheref { get; set; }
        public string Ficheno { get; set; }
        public DateTime? Date { get; set; }
        public int? Time { get; set; }
        public DateTime? Begdate { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Clientref { get; set; }
        public int? Itemref { get; set; }
        public int? Variantref { get; set; }
        public int? Spevalcrsetref { get; set; }
        public double? Score { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
        public short? Textinc { get; set; }
        public string Guid { get; set; }
    }
}
