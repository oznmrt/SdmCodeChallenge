﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00101Demandfiche
    {
        public int Logicalref { get; set; }
        public string Ficheno { get; set; }
        public DateTime? Date { get; set; }
        public int? Time { get; set; }
        public string Docode { get; set; }
        public short? Status { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public short? Sourceindex { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public short? Factorynr { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
        public short? CapiblockCreatedby { get; set; }
        public DateTime? CapiblockCreadeddate { get; set; }
        public short? CapiblockCreatedhour { get; set; }
        public short? CapiblockCreatedmin { get; set; }
        public short? CapiblockCreatedsec { get; set; }
        public short? CapiblockModifiedby { get; set; }
        public DateTime? CapiblockModifieddate { get; set; }
        public short? CapiblockModifiedhour { get; set; }
        public short? CapiblockModifiedmin { get; set; }
        public short? CapiblockModifiedsec { get; set; }
        public short? Demandtype { get; set; }
        public int? Demandref { get; set; }
        public short? Printcnt { get; set; }
        public short? Textinc { get; set; }
        public short? Userno { get; set; }
        public int? Wflowcrdref { get; set; }
        public int? Projectref { get; set; }
        public int? Perref { get; set; }
        public string Guid { get; set; }
        public DateTime? Printdate { get; set; }
    }
}
