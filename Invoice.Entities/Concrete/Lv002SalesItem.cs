﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lv002SalesItem
    {
        public int Period { get; set; }
        public short? ClassActive { get; set; }
        public string ClassActiveAdi { get; set; }
        public short? ClassCardtype { get; set; }
        public string ClassCardtypeTipi { get; set; }
        public string ClassCode { get; set; }
        public string ClassName { get; set; }
        public string ClassStgrpcode { get; set; }
        public string ClassProducercode { get; set; }
        public string ClassSpecode { get; set; }
        public string ClassCyphcode { get; set; }
        public short? ItemsActive { get; set; }
        public string ItemsActiveAdi { get; set; }
        public short? ItemsCardtype { get; set; }
        public string ItemsCardtypeTipi { get; set; }
        public string ItemsCode { get; set; }
        public string ItemsName { get; set; }
        public string ItemsStgrpcode { get; set; }
        public string ItemsProducercode { get; set; }
        public string ItemsSpecode { get; set; }
        public string ItemsCyphcode { get; set; }
        public short? ItemsTracktype { get; set; }
        public string ItemsIzlemeTuru { get; set; }
        public string UnitsetfCode { get; set; }
        public string UnitsetfName { get; set; }
        public string UnitsetfSpecode { get; set; }
        public string UnitsetfCyphcode { get; set; }
        public string UnitsetlCode { get; set; }
        public string UnitsetlName { get; set; }
        public double? Itmunita2Katsayi { get; set; }
        public string Unitsetl2Code { get; set; }
        public string Unitsetl2Name { get; set; }
        public double? Itmunita3Katsayi { get; set; }
        public string Unitsetl3Code { get; set; }
        public string Unitsetl3Name { get; set; }
        public short? ItmunitaLinenr { get; set; }
        public string ItmunitaBarcode { get; set; }
        public double? ItmunitaWidth { get; set; }
        public string WidthCode { get; set; }
        public double? ItmunitaLength { get; set; }
        public string LengthCode { get; set; }
        public double? ItmunitaHeight { get; set; }
        public string HeightCode { get; set; }
        public double? ItmunitaArea { get; set; }
        public string AreaCode { get; set; }
        public double? ItmunitaVolume { get; set; }
        public string VolumeCode { get; set; }
        public double? ItmunitaGrossvolume { get; set; }
        public string GrossvolumeCode { get; set; }
        public double? ItmunitaWeight { get; set; }
        public string WeightCode { get; set; }
        public double? ItmunitaGrossweight { get; set; }
        public string GrossweightCode { get; set; }
        public double? ItmunitaConvfact1 { get; set; }
        public double? ItmunitaConvfact2 { get; set; }
        public int? StlineLogicalref { get; set; }
        public short? StlineLinetype { get; set; }
        public string StlineSatirTuru { get; set; }
        public int? StlinePrevlineref { get; set; }
        public short? StlinePrevlineno { get; set; }
        public short? StlineTrcode { get; set; }
        public DateTime? StlineDate { get; set; }
        public int? StlineYear { get; set; }
        public int? StlineQuarter { get; set; }
        public int StlineHalf { get; set; }
        public int? StlineMonth { get; set; }
        public int? StlineWeek { get; set; }
        public int? StlineDay { get; set; }
        public int? StlineFtime { get; set; }
        public short? StlineGlobtrans { get; set; }
        public short? StlineSourceindex { get; set; }
        public short? StlineSourcecostgrp { get; set; }
        public short? StlineDestindex { get; set; }
        public short? StlineDestcostgrp { get; set; }
        public short? StlineIocode { get; set; }
        public string StlineIocodeTuru { get; set; }
        public int? StlineStficheref { get; set; }
        public short? StlineStfichelnno { get; set; }
        public int? StlineInvoiceref { get; set; }
        public short? StlineInvoicelnno { get; set; }
        public int? StlineClientref { get; set; }
        public int? StlineOrdtransref { get; set; }
        public int? StlineOrdficheref { get; set; }
        public string StlineSpecode { get; set; }
        public string StlineDelvrycode { get; set; }
        public double? StlineInputAmount { get; set; }
        public double? StlineOutputAmount { get; set; }
        public double? StlineInputPrice { get; set; }
        public double? StlineOutputPrice { get; set; }
        public double? StlineInputTotal { get; set; }
        public double? StlineOutputTotal { get; set; }
        public short? StlinePrcurr { get; set; }
        public double? StlineInputPrprice { get; set; }
        public double? StlineOutputPrprice { get; set; }
        public short? StlineTrcurr { get; set; }
        public double? StlineTrrate { get; set; }
        public double? StlineReportrate { get; set; }
        public double? StlineInputDistcost { get; set; }
        public double? StlineOutputDistcost { get; set; }
        public double? StlineInputDistdisc { get; set; }
        public double? StlineOutputDistdisc { get; set; }
        public double? StlineInputDistexp { get; set; }
        public double? StlineOutputDistexp { get; set; }
        public double? StlineInputDistprom { get; set; }
        public double? StlineOutputDistprom { get; set; }
        public double? StlineDiscper { get; set; }
        public string StlineLineexp { get; set; }
        public int? StlineUomref { get; set; }
        public int? StlineUsref { get; set; }
        public double? StlineUinfo1 { get; set; }
        public double? StlineUinfo2 { get; set; }
        public short? StlineVatinc { get; set; }
        public double? StlineVat { get; set; }
        public double? StlineInputVatamnt { get; set; }
        public double? StlineOutputVatamnt { get; set; }
        public double? StlineInputVatmatrah { get; set; }
        public double? StlineOutputVatmatrah { get; set; }
        public short? StlineBilled { get; set; }
        public string StlineBilledTipi { get; set; }
        public double? StlineInputOutcost { get; set; }
        public double? StlineOutputOutcost { get; set; }
        public short? StlineCancelled { get; set; }
        public double? StlineInputLinenet { get; set; }
        public double? StlineOutputLinenet { get; set; }
        public double? StlineInputDiffprcost { get; set; }
        public double? StlineOutputDiffprcost { get; set; }
        public double? StlineInputDiffrepprice { get; set; }
        public double? StlineOutputDiffrepprice { get; set; }
        public double? StlineInputDiffprcrcost { get; set; }
        public double? StlineOutputDiffprcrcost { get; set; }
        public short? StficheGrpcode { get; set; }
        public string StficheGrpcodeTipi { get; set; }
        public short? StficheTrcode { get; set; }
        public string StficheTrcodeAdi { get; set; }
        public short? StficheIocode { get; set; }
        public string StficheFicheno { get; set; }
        public DateTime? StficheDate { get; set; }
        public int? StficheFtime { get; set; }
        public string StficheDocode { get; set; }
        public string StficheInvno { get; set; }
        public string StficheSpecode { get; set; }
        public string StficheCyphcode { get; set; }
        public int? StficheInvoiceref { get; set; }
        public int? FstficheClientref { get; set; }
        public int? StficheRecvref { get; set; }
        public double? StficheInputAdddiscounts { get; set; }
        public double? StficheOutputAdddiscounts { get; set; }
        public double? StficheInputTotaldiscounts { get; set; }
        public double? StficheOutputTotaldiscounts { get; set; }
        public double? StficheInputTotaldiscounted { get; set; }
        public double? StficheOutputTotaldiscounted { get; set; }
        public double? StficheInputAddexpenses { get; set; }
        public double? StficheOutputAddexpenses { get; set; }
        public double? StficheInputTotalexpenses { get; set; }
        public double? StficheOutputTotalexpenses { get; set; }
        public double? StficheInputTotaldepozito { get; set; }
        public double? StficheOutputTotaldepozito { get; set; }
        public double? StficheInputTotalpromotions { get; set; }
        public double? StficheOutputTotalpromotions { get; set; }
        public double? StficheInputTotalvat { get; set; }
        public double? StficheOutputTotalvat { get; set; }
        public double? StficheInputGrosstotal { get; set; }
        public double? StficheOutputGrosstotal { get; set; }
        public double? StficheInputNettotal { get; set; }
        public double? StficheOutputNettotal { get; set; }
        public double? StficheReportrate { get; set; }
        public double? StficheInputReportnet { get; set; }
        public double? StficheOutputReportnet { get; set; }
        public short? StficheTrcurr { get; set; }
        public double? StficheTrrate { get; set; }
        public double? StficheInputTrnet { get; set; }
        public double? StficheOutputTrnet { get; set; }
        public short? StficheBilled { get; set; }
        public string StficheBilledTipi { get; set; }
        public short? StficheProdstat { get; set; }
        public string StficheProdstatAçiklama { get; set; }
        public short? StficheCancelled { get; set; }
        public string StficheCancelledAçiklama { get; set; }
        public short? InvoiceGrpcode { get; set; }
        public string InvoiceGrpcodeAçiklama { get; set; }
        public short? InvoiceTrcode { get; set; }
        public string InvoiceTrcodeAdi { get; set; }
        public string InvoiceFicheno { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? InvoiceTime { get; set; }
        public string InvoiceDocode { get; set; }
        public string InvoiceSpecode { get; set; }
        public string InvoiceCyphcode { get; set; }
        public int? InvoiceClientref { get; set; }
        public int? InvoiceRecvref { get; set; }
        public double? InvoiceInputAdddiscounts { get; set; }
        public double? InvoiceOutputAdddiscounts { get; set; }
        public double? InvoiceInputTotaldiscounts { get; set; }
        public double? InvoiceOutputTotaldiscounts { get; set; }
        public double? InvoiceInputTotaldiscounted { get; set; }
        public double? InvoiceOutputTotaldiscounted { get; set; }
        public double? InvoiceInputAddexpenses { get; set; }
        public double? InvoiceOutputAddexpenses { get; set; }
        public double? InvoiceInputTotalexpenses { get; set; }
        public double? InvoiceOutputTotalexpenses { get; set; }
        public double? InvoiceInputTotaldepozito { get; set; }
        public double? InvoiceOutputTotaldepozito { get; set; }
        public double? InvoiceInputTotalpromotions { get; set; }
        public double? InvoiceOutputTotalpromotions { get; set; }
        public double? InvoiceInputTotalvat { get; set; }
        public double? InvoiceOutputTotalvat { get; set; }
        public double? InvoiceInputGrosstotal { get; set; }
        public double? InvoiceOutputGrosstotal { get; set; }
        public double? InvoiceInputNettotal { get; set; }
        public double? InvoiceOutputNettotal { get; set; }
        public double? InvoiceReportrate { get; set; }
        public double? InvoiceInputReportnet { get; set; }
        public double? InvoiceOutputReportnet { get; set; }
        public short? InvoiceTrcurr { get; set; }
        public double? InvoiceTrrate { get; set; }
        public double? InvoiceInputTrnet { get; set; }
        public double? InvoiceOutputTrnet { get; set; }
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