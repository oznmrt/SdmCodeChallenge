using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Invoice.Business.Abstract;
using Invoice.Business.Concrete;
using Invoice.DataAccess.Concrete.EntityFramework;
using Invoice.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Invoice.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvoiceController : ControllerBase
    {
        private static readonly object padlock = new object();

        private static InvoiceManager invoiceManager;

        public InvoiceController()
        {
            lock (padlock) // for thread safe
            {
                if (invoiceManager == null)
                {
                    invoiceManager = new InvoiceManager(new InvoiceDAL());
                }
            }
        }

        [HttpGet]
        public IEnumerable<Lg00201Invoice> Get()
        {
            var data = invoiceManager.getAll();
            return data;
        }

        [HttpPost]
        public ActionResult Add([FromBody] Lg00201Invoice lg00201Invoice)
        {
            try
            {
                invoiceManager.insertInvoice(lg00201Invoice);

                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Update([FromBody] Lg00201Invoice lg00201Invoice)
        {
            try
            {
                invoiceManager.updateInvoice(lg00201Invoice);

                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] Lg00201Invoice lg00201Invoice)
        {
            try
            {
                invoiceManager.deleteInvoice(lg00201Invoice);
                return Ok();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Lg00201Invoice prepareSampleInvoiceData()
        {
            return new Lg00201Invoice
            {
                Grpcode = 2,
                Trcode = 8,
                Ficheno = "000002",
                Date = Convert.ToDateTime("2020-11-23 00:00:00"),
                Time = 252449280,
                Docode = "",
                Specode = "",
                Cyphcode = "",
                Clientref = 4,
                Recvref = 0,
                Centerref = 0,
                Accountref = 0,
                Sourceindex = 0,
                Sourcecostgrp = 0,
                Cancelled = 0,
                Accounted = 0,
                Paidincash = 0,
                Fromkasa = 0,
                Entegset = 247,
                Vat = 18,
                Adddiscounts = 0,
                Totaldiscounts = 0,
                Totaldiscounted = 200,
                Addexpenses = 0,
                Totalexpenses = 0,
                Distexpense = 0,
                Totaldepozito = 0,
                Totalpromotions = 0,
                Vatincgross = 0,
                Totalvat = 36,
                Grosstotal = 200,
                Nettotal = 236,
                Genexp1 = "",
                Genexp2 = "",
                Genexp3 = "",
                Genexp4 = "",
                Genexp5 = "",
                Genexp6 = "",
                Interestapp = 0,
                Trcurr = 0,
                Trrate = 0,
                Trnet = 236,
                Reportrate = 0,
                Reportnet = 0,
                Onlyonepayline = 0,
                Kastransref = 0,
                Paydefref = 0,
                Printcnt = 0,
                Gvatinc = 0,
                Branch = 0,
                Department = 0,
                Accficheref = 0,
                Addexpaccref = 0,
                Addexpcentref = 0,
                Decprdiff = 0,
                CapiblockCreatedby = 1,
                CapiblockCreadeddate = Convert.ToDateTime("2020-12-23 15:13:05.083"),
                CapiblockCreatedhour = 15,
                CapiblockCreatedmin = 13,
                CapiblockCreatedsec = 5,
                CapiblockModifiedby = 0,
                CapiblockModifieddate = null,
                CapiblockModifiedhour = 0,
                CapiblockModifiedmin = 0,
                CapiblockModifiedsec = 0,
                Salesmanref = 0,
                Cancelledacc = 0,
                Shptypcod = "",
                Shpagncod = "",
                Tracknr = "",
                Genexctyp = 1,
                Lineexctyp = 0,
                Tradinggrp = "",
                Textinc = 0,
                Siteid = 0,
                Recstatus = 1,
                Orglogicref = 0,
                Factorynr = 0,
                Wfstatus = 0,
                Shipinforef = 0,
                Distorderref = 0,
                Sendcnt = 0,
                Dlvclient = 0,
                Costofsalefcref = 0,
                Opstat = 0,
                Doctrackingnr = "",
                Totaladdtax = 0,
                Paymenttype = 0,
                Infidx = 0,
                Accountedcnt = 0,
                Orglogoid = "",
                Fromexim = 0,
                Frgtypcod = "",
                Eximfctype = 0,
                Fromordwithpay = 0,
                Projectref = 0,
                Wflowcrdref = 0,
                Status = 0,
                Deductionpart1 = 2,
                Deductionpart2 = 3,
                Totalexaddtax = 0,
                Exaccounted = 0,
                Frombank = 0,
                Bntransref = 0,
                Affectcollatrl = 0,
                Grpfirmtrans = 0,
                Affectrisk = 1,
                Controlinfo = 0,
                Postransferinfo = 0,
                Taxfreechx = 0,
                Passportno = "",
                Creditcardno = "",
                Ineffectivecost = 0,
                Reflected = 0,
                Reflaccficheref = 0,
                Cancelledreflacc = 0,
                Creditcardnum = "",
                Approve = 0,
                Approvedate = null,
                Cantcrededuct = 0,
                Entrust = 0,
                Docdate = Convert.ToDateTime("2020-11-23 00:00:00"),
                Einvoice = 0,
                Profileid = 0,
                Guid = "AFF9488A-74B9-4E8A-A231-99C7B8376CE4",
                Estatus = 0,
                Estartdate = null,
                Eenddate = null,
                Edescription = "",
                Eduration = 0,
                Edurationtype = 0,
                Devir = 0,
                Distadjpriceufrs = 0,
                Cosfcrefufrs = 0,
                Globalid = "",
                Totalservices = 0,
                Fromleasing = 0,
                Cancelexp = "",
                Undoexp = "",
                Vatexceptreason = "",
                Campaigncode = "",
                Canceldespsinv = 0,
                Fromexchdiff = 0,
                Eximvat = 0,
                Serialcode = "",
                Appcldeductlim = 0,
                Einvoicetyp = 0,
                Vatexceptcode = "",
                Offerref = 0,
                Ataxexceptreason = "",
                Ataxexceptcode = "",
                Fromstaffotherex = 0,
                Nocalculate = 0,
                Insteadofdesp = 0,
                Okcfiche = 0,
                Canceldate = null,
                Frgtypdesc = "",
                Markref = 0,
                Printdate = null,
                Delivercode = "",
                Accepteinvpublic = 0,
                Publicbnaccref = 0,
                Typecode = "",
                Futmnthyrexpinc = 0,
                Docdetail = 0
            };
        }
    }
}
