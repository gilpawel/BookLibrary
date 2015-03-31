using BookLibrary.DataAccess.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.DataAccess.Repositories.Interfaces
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,
                                           Func<IQueryable<TEntity>,
                                           IOrderedQueryable<TEntity>> orderBy = null,
                                           string includeProperties = "");
        TEntity Get(int id);
    }
}
