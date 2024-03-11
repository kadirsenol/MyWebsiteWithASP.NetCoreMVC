using Microsoft.EntityFrameworkCore;
using MyBlog_IoTAutomation.DataAccessLayer.Repositories.Abstract;
using MyBlog_IoTAutomation.EntityLayer.Entities.Abstract;
using System.Linq.Expressions;

namespace MyBlog_IoTAutomation.DataAccessLayer.Repositories.Concrete
{
    public class Repository<TDBContext, T, TId> : IRepository<T, TId> where T : BaseEntity<TId>
                                                                      where TDBContext : DbContext, new()
    {
        private readonly TDBContext dbContext;
        public Repository()
        {
            dbContext = new TDBContext();
        }
        public async Task<int> Insert(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> Update(T entity)
        {
            dbContext.Set<T>().Update(entity);
            return await dbContext.SaveChangesAsync();
        }
        public async Task<int> Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAll(Expression<Func<T, bool>> expression)
        {
            IEnumerable<T> findentities = await dbContext.Set<T>().Where(expression).ToListAsync();
            dbContext.Set<T>().RemoveRange(findentities);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteByPK(TId pk)
        {
            T findentity = await dbContext.Set<T>().FindAsync(pk);
            dbContext.Set<T>().Remove(findentity);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<ICollection<T>> GetAll(Expression<Func<T, bool>> expression = null)
        {
            if (expression != null)
            {
                return await dbContext.Set<T>().Where(expression).ToListAsync();
            }
            else
            {
                return await dbContext.Set<T>().ToListAsync();
            }
        }

        public async Task<T> GetByPK(TId pk)
        {
            return await dbContext.Set<T>().FindAsync(pk);
        }

        public async Task<IEnumerable<T>?> GetAllInclude(Expression<Func<T, bool>>? expression, params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> query;
            if (expression != null)
            {
                query = dbContext.Set<T>().Where(expression);
            }
            else
            {
                query = dbContext.Set<T>();
            }

            return include.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

    }
}
