using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Invoice.DataAccess.Abstract
{
    public interface IEntityRepository<TEntity> where TEntity: class, new()
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        void Add(TEntity tEntity);
        void Update(TEntity tEntity);
        void Delete(TEntity tEntity);
    }
}
