using System;
using System.Collections.Generic;
using System.Text;
using Invoice.Entities.Concrete;

namespace Invoice.DataAccess.Abstract
{
    public interface IInvoiceDAL: IEntityRepository<Lg00201Invoice>
    {
    }
}
