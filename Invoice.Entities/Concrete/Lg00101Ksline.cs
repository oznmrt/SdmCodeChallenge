﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg00101Ksline
    {
        public int Logicalref { get; set; }
        public int? Cardref { get; set; }
        public int? Vcardref { get; set; }
        public int? Transref { get; set; }
        public int? Accref { get; set; }
        public int? Centerref { get; set; }
        public int? Csaccref { get; set; }
        public int? Cscenterref { get; set; }
        public DateTime? Date { get; set; }
        public short? Hour { get; set; }
        public short? Minute { get; set; }
        public short? Trcode { get; set; }
        public short? Branch { get; set; }
        public short? Department { get; set; }
        public short? Destbranch { get; set; }
        public short? Destdepartment { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Ficheno { get; set; }
        public string Custtitle { get; set; }
        public string Lineexp { get; set; }
        public double? Amount { get; set; }
        public double? Reportrate { get; set; }
        public double? Reportnet { get; set; }
        public double? Trrate { get; set; }
        public double? Trnet { get; set; }
        public short? Trcurr { get; set; }
        public short? Sign { get; set; }
        public short? Accounted { get; set; }
        public short? Cancelled { get; set; }
        public int? Accficheref { get; set; }
        public short? Printcnt { get; set; }
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
        public short? Cancelledacc { get; set; }
        public short? Genexctyp { get; set; }
        public short? Lineexctyp { get; set; }
        public string Tradinggrp { get; set; }
        public short? Textinc { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
        public short? Gpoptype { get; set; }
        public double? Gpincometacrat { get; set; }
        public double? Gpfundsharerat { get; set; }
        public string Gpplate { get; set; }
        public int? Gptaxacc { get; set; }
        public int? Gpfundacc { get; set; }
        public string Gpaddr { get; set; }
        public double? Smmvatrate { get; set; }
        public int? Smmvatacref { get; set; }
        public int? Smmvatcentref { get; set; }
        public string Smmdocode { get; set; }
        public double? Infidx { get; set; }
        public string Trangrpno { get; set; }
        public short? Trangrplineno { get; set; }
        public string Orglogoid { get; set; }
        public short? Vatinc { get; set; }
        public double? Vatrat { get; set; }
        public int? Vataccref { get; set; }
        public double? Vattot { get; set; }
        public int? Projectref { get; set; }
        public int? Cstransref { get; set; }
        public short? Status { get; set; }
        public int? Wflowcrdref { get; set; }
        public short? Affectcollatrl { get; set; }
        public short? Grpfirmtrans { get; set; }
        public string Tranno { get; set; }
        public string Docode { get; set; }
        public short? Affectrisk { get; set; }
        public short? Reflected { get; set; }
        public int? Reflaccficheref { get; set; }
        public short? Cancelledreflacc { get; set; }
        public string Taxnr { get; set; }
        public short? Approve { get; set; }
        public DateTime? Approvedate { get; set; }
        public string Tckno { get; set; }
        public short? Isperscomp { get; set; }
        public short? Eximtype { get; set; }
        public int? Eximfileref { get; set; }
        public short? Eximprocnr { get; set; }
        public short? Eidistflnnr { get; set; }
        public short? Eisrvdsttyp { get; set; }
        public short? Eximdisttyp { get; set; }
        public int? Salesmanref { get; set; }
        public DateTime? Docdate { get; set; }
        public string Guid { get; set; }
        public int? Offerref { get; set; }
        public int? Emflineref { get; set; }
        public short? Candeduct { get; set; }
        public short? Deductionpart1 { get; set; }
        public short? Deductionpart2 { get; set; }
        public short? Underdeductlimit { get; set; }
        public double? Vatdeductrate { get; set; }
        public int? Vatdeductaccref { get; set; }
        public int? Vatdeductothaccref { get; set; }
        public int? Vatdeductcenref { get; set; }
        public int? Vatdeductothcenref { get; set; }
        public short? Cantcrededuct { get; set; }
        public short? Cltrcurr { get; set; }
        public double? Cltrrate { get; set; }
        public double? Cltrnet { get; set; }
        public double? Brutamount { get; set; }
        public double? Netamount { get; set; }
        public double? Brutamounttr { get; set; }
        public double? Netamounttr { get; set; }
        public double? Brutamountrep { get; set; }
        public double? Netamountrep { get; set; }
        public short? Crcardwzd { get; set; }
        public string Smmserialcode { get; set; }
        public int? Cashaccref { get; set; }
        public int? Cashcenref { get; set; }
        public DateTime? Printdate { get; set; }
        public short? Incdeductamnt { get; set; }
        public short? Affectcost { get; set; }
        public string Custtitle2 { get; set; }
        public string Typecode { get; set; }
        public short? Einvoice { get; set; }
        public string Deductcode { get; set; }
        public int? Time { get; set; }
        public string Servreasondef { get; set; }
    }
}
