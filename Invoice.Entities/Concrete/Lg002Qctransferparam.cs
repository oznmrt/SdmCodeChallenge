using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Qctransferparam
    {
        public int Logicalref { get; set; }
        public short? Divnr { get; set; }
        public short? Factnr { get; set; }
        public short? Whnr { get; set; }
        public short? Destwhnr { get; set; }
        public short? Linenr { get; set; }
    }
}
