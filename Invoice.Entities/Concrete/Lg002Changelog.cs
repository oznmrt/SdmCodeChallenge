using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Changelog
    {
        public int Logicalref { get; set; }
        public int? Recordref { get; set; }
        public short? Usernr { get; set; }
        public short? Operation { get; set; }
        public short? Formid { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
        public int? Time { get; set; }
        public short? Period { get; set; }
        public short? Moduletype { get; set; }
        public byte[] Ldata { get; set; }
    }
}
