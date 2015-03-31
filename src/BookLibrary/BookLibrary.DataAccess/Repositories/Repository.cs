using BookLibrary.DataAccess.Concrete;
using BookLibrary.DataAccess.Entities.Interfaces;
using BookLibrary.DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.DataAccess.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
    {
        protected BookLibraryDataContext dataContext;
        private DbSet<TEntity> dbSet;

        public Repository(BookLibraryDataContext context)
        {
            this.dataContext = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual void Add(TEntity entity)
        {
            this.dbSet.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            this.dbSet.Remove(entity);
        }

        public virtual void Update(TEntity entity)
        {
            this.dbSet.Attach(entity);
            this.dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,
                                           Func<IQueryable<TEntity>, 
                                           IOrderedQueryable<TEntity>> orderBy = null,
                                           string includeProperties = "")
       
        {
            IQueryable<TEntity> query = this.dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        public virtual TEntity Get(int id)
        {
            return this.dbSet.Find(id);
        }
    }
}
