using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00201Plugin
    {
        public int Logicalref { get; set; }
        public short? Inuse { get; set; }
        public short? Plgid { get; set; }
        public string Plgname { get; set; }
        public string Description { get; set; }
        public string Version { get; set; }
        public string Author { get; set; }
        public string Libname { get; set; }
    }
}
