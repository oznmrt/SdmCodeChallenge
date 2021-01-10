using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class LTscont
    {
        public int Logicalref { get; set; }
        public string Paramname { get; set; }
        public short? Reporttype { get; set; }
        public string Newprinter { get; set; }
        public short? AsciiSkg { get; set; }
        public short? AsciiKa { get; set; }
        public short? AsciiSs { get; set; }
        public string AsciiAk { get; set; }
        public byte[] Ldata { get; set; }
    }
}
