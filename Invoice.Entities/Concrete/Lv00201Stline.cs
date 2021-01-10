using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lv00201Stline
    {
        public int Logicalref { get; set; }
        public int? Invoiceref { get; set; }
        public int? Stockref { get; set; }
        public short? Linetype { get; set; }
        public short? Trcode { get; set; }
        public double? Amount { get; set; }
        public double? Price { get; set; }
        public double? Total { get; set; }
        public short? Invoicelnno { get; set; }
        public string Code { get; set; }
        public string Lineexp { get; set; }
    }
}
