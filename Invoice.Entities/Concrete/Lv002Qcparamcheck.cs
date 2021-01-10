using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lv002Qcparamcheck
    {
        public int Grpcode { get; set; }
        public int Trcode { get; set; }
        public int Invoice { get; set; }
        public string Paramok { get; set; }
    }
}
