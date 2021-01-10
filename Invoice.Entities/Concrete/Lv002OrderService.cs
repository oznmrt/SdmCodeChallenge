﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lv002OrderService
    {
        public int Period { get; set; }
        public short? SrvcardActive { get; set; }
        public string SrvcardActiveAdi { get; set; }
        public short? SrvcardCardtype { get; set; }
        public string SrvcardCode { get; set; }
        public string SrvcardDefinition { get; set; }
        public string SrvcardSpecode { get; set; }
        public string SrvcardCyphcode { get; set; }
        public string UnitsetfCode { get; set; }
        public string UnitsetfName { get; set; }
        public string UnitsetfSpecode { get; set; }
        public string UnitsetfCyphcode { get; set; }
        public string UnitsetlCode { get; set; }
        public string UnitsetlName { get; set; }
        public string Unitsetl2Code { get; set; }
        public string Unitsetl2Name { get; set; }
        public string Unitsetl3Code { get; set; }
        public string Unitsetl3Name { get; set; }
        public short? SrvunitaLinenr { get; set; }
        public int? OrflineLogicalref { get; set; }
        public short? OrflineLinetype { get; set; }
        public string OrflineSatirTuru { get; set; }
        public int? OrflinePrevlineref { get; set; }
        public short? OrflinePrevlineno { get; set; }
        public short? OrflineTrcode { get; set; }
        public DateTime? OrflineDate { get; set; }
        public int? OrflineYear { get; set; }
        public int OrflineHalf { get; set; }
        public int? OrflineQuarter { get; set; }
        public int? OrflineMonth { get; set; }
        public int? OrflineWeek { get; set; }
        public int? OrflineDay { get; set; }
        public int? OrflineTime { get; set; }
        public short? OrflineGlobtrans { get; set; }
        public short? OrflineSourceindex { get; set; }
        public short? OrflineSourcecostgrp { get; set; }
        public int? OrflineOrdficheref { get; set; }
        public short? OrflineLineno { get; set; }
        public int? OrflineClientref { get; set; }
        public string OrflineSpecode { get; set; }
        public short? OrficheStatus { get; set; }
        public string OrficheStatusAdi { get; set; }
        public string OrflineDelvrycode { get; set; }
        public double? OrflineInputAmount { get; set; }
        public double? OrflineOutputAmount { get; set; }
        public double? OrflineInputPrice { get; set; }
        public double? OrflineOutputPrice { get; set; }
        public double? OrflineInputTotal { get; set; }
        public double? OrflineOutputTotal { get; set; }
        public short? OrflinePrcurr { get; set; }
        public double? OrflineInputPrprice { get; set; }
        public double? OrflineOutputPrprice { get; set; }
        public short? OrflineTrcurr { get; set; }
        public double? OrflineTrrate { get; set; }
        public double? OrflineReportrate { get; set; }
        public double? OrflineInputDistcost { get; set; }
        public double? OrflineOutputDistcost { get; set; }
        public double? OrflineInputDistdisc { get; set; }
        public double? OrflineOutputDistdisc { get; set; }
        public double? OrflineInputDistexp { get; set; }
        public double? OrflineOutputDistexp { get; set; }
        public double? OrflineInputDistprom { get; set; }
        public double? OrflineOutputDistprom { get; set; }
        public double? OrflineDiscper { get; set; }
        public string OrflineLineexp { get; set; }
        public int? OrflineUomref { get; set; }
        public int? OrflineUsref { get; set; }
        public double? OrflineUinfo1 { get; set; }
        public double? OrflineUinfo2 { get; set; }
        public short? OrflineVatinc { get; set; }
        public double? OrflineVat { get; set; }
        public double? OrflineInputVatamnt { get; set; }
        public double? OrflineOutputVatamnt { get; set; }
        public double? OrflineInputVatmatrah { get; set; }
        public double? OrflineOutputVatmatrah { get; set; }
        public short? OrflineCancelled { get; set; }
        public double? OrflineInputLinenet { get; set; }
        public double? OrflineOutputLinenet { get; set; }
        public short? OrficheTrcode { get; set; }
        public string OrficheTrcodeAdi { get; set; }
        public string OrficheFicheno { get; set; }
        public DateTime? OrficheDate { get; set; }
        public int? OrficheTime { get; set; }
        public string OrficheDocode { get; set; }
        public string OrficheSpecode { get; set; }
        public string OrficheCyphcode { get; set; }
        public int? ForficheClientref { get; set; }
        public int? OrficheRecvref { get; set; }
        public double? OrficheInputAdddiscounts { get; set; }
        public double? OrficheOutputAdddiscounts { get; set; }
        public double? OrficheInputTotaldiscounts { get; set; }
        public double? OrficheOutputTotaldiscounts { get; set; }
        public double? OrficheInputTotaldiscounted { get; set; }
        public double? OrficheOutputTotaldiscounted { get; set; }
        public double? OrficheInputAddexpenses { get; set; }
        public double? OrficheOutputAddexpenses { get; set; }
        public double? OrficheInputTotalexpenses { get; set; }
        public double? OrficheOutputTotalexpenses { get; set; }
        public double? OrficheInputTotalpromotions { get; set; }
        public double? OrficheOutputTotalpromotions { get; set; }
        public double? OrficheInputTotalvat { get; set; }
        public double? OrficheOutputTotalvat { get; set; }
        public double? OrficheInputGrosstotal { get; set; }
        public double? OrficheOutputGrosstotal { get; set; }
        public double? OrficheInputNettotal { get; set; }
        public double? OrficheOutputNettotal { get; set; }
        public double? OrficheReportrate { get; set; }
        public double? OrficheInputReportnet { get; set; }
        public double? OrficheOutputReportnet { get; set; }
        public short? OrficheTrcurr { get; set; }
        public double? OrficheTrrate { get; set; }
        public double? OrficheInputTrnet { get; set; }
        public double? OrficheOutputTrnet { get; set; }
        public short? OrficheCancelled { get; set; }
        public string OrficheCancelledAçiklama { get; set; }
        public string ShipinfoCode { get; set; }
        public string ShipinfoName { get; set; }
        public string ShipinfoSpecode { get; set; }
        public string ShipinfoCyphcode { get; set; }
        public short? CapiwhouseNr { get; set; }
        public string CapiwhouseName { get; set; }
        public short? CapidivNr { get; set; }
        public string CapidivName { get; set; }
        public short? CapideptNr { get; set; }
        public string CapideptName { get; set; }
        public string ClcardCode { get; set; }
        public string ClcardDefinition { get; set; }
        public string ClcardSpecode { get; set; }
        public string ClcardTaxoffice { get; set; }
        public string ClcardTaxnr { get; set; }
        public string ClcardCyphcode { get; set; }
        public string ClcardIncharge { get; set; }
        public short? ClcardActive { get; set; }
        public string ClcardActiveAdi { get; set; }
        public string ClcardCity { get; set; }
        public string ClcardTradinggrp { get; set; }
        public short? ClcardCardtype { get; set; }
        public string ClcardCardtypeAdi { get; set; }
        public string PayplansCode { get; set; }
        public string PayplansDefinition { get; set; }
        public string PayplansSpecode { get; set; }
        public string PayplansCyphcode { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public string EmcenterCode { get; set; }
        public string EmcenterDefinition { get; set; }
        public string SlsmanCode { get; set; }
        public string SlsmanDefinition { get; set; }
    }
}
