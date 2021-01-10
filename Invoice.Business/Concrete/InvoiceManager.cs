using Invoice.Business.Abstract;
using Invoice.DataAccess.Abstract;
using Invoice.DataAccess.Concrete.EntityFramework;
using Invoice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Invoice.Business.Concrete
{
    public class InvoiceManager : IInvoiceService
    {
        private IInvoiceDAL _invoiceDAL;

        public InvoiceManager(IInvoiceDAL invoiceDAL)
        {
            _invoiceDAL = invoiceDAL;
        }

        public List<Lg00201Invoice> getAll()
        {
            return _invoiceDAL.GetAll();
        }

        public void insertInvoice(Lg00201Invoice lg00201Invoice)
        {
            _invoiceDAL.Add(lg00201Invoice);
        }

        public void updateInvoice(Lg00201Invoice lg00201Invoice)
        {
            _invoiceDAL.Update(lg00201Invoice);
        }

        public void deleteInvoice(Lg00201Invoice lg00201Invoice)
        {
            _invoiceDAL.Delete(lg00201Invoice);
        }

        public Lg00201Invoice getInvoiceByRef(int invoiceLogicalRef)
        {
            return _invoiceDAL.Get(p => p.Logicalref == invoiceLogicalRef);
        }
    }
}
