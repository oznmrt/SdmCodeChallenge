using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Appparam
    {
        public int Logicalref { get; set; }
        public short? Usernr { get; set; }
        public short? Toptentype { get; set; }
        public double? Topteninterval { get; set; }
        public short? Itemtreeview { get; set; }
        public short? Cltreeview { get; set; }
        public short? Bdgttreeview { get; set; }
        public short? Paydatetype { get; set; }
        public short? Itmcharview { get; set; }
        public short? Varcharview { get; set; }
        public short? Itmliveapply { get; set; }
        public short? Varliveapply { get; set; }
        public short? Srvtreeview { get; set; }
    }
}
