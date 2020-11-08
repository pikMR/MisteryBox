using MisteryBoxDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisteryBoxDomain.Entities;
using System.Linq.Expressions;
using System.Data.Entity;

namespace MisteryBoxInfraestructure.Data
{
    public class EfRepository<T> : IAsyncRepository<T> where T : Item
    {

        #region Fields

        protected Context Context;

        #endregion

        public EfRepository(Context context)
        {
            Context = context;
        }

        #region Public Methods

        public Task<T> GetById(int id) => Context.Set<T>().FindAsync(id);

        public Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate)
            => Context.Set<T>().FirstOrDefaultAsync(predicate);

        public Task Update(T entity)
        {
            // In case AsNoTracking is used
            Context.Entry(entity).State = EntityState.Modified;
            return Context.SaveChangesAsync();
        }

        public Task Remove(T entity)
        {
            Context.Set<T>().Remove(entity);
            return Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await Context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return await Context.Set<T>().Where(predicate).ToListAsync();
        }

        public Task<int> CountAll() => Context.Set<T>().CountAsync();

        public Task<int> CountWhere(Expression<Func<T, bool>> predicate)
            => Context.Set<T>().CountAsync(predicate);

        public Task Add(T entity)
        {
            Context.Set<T>().Add(entity);
            return Context.SaveChangesAsync();
        }
        #endregion

    }
}
