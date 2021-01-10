using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00101Divatran
    {
        public int Logicalref { get; set; }
        public short? Entitytpye { get; set; }
        public string Exportdatetime { get; set; }
        public string Importdatetime { get; set; }
    }
}
