using Invoice.DataAccess.Abstract;
using Invoice.DataAccess.Concrete.EntityFramework;
using Invoice.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Invoice.DataAccess.Concrete.EntityFramework
{
    public class InvoiceDAL : EntityRepositoryBase<Lg00201Invoice, SDMContext>, IInvoiceDAL
    {
    }
}
