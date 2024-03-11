using System.Linq.Expressions;

namespace MyBlog_IoTAutomation.DataAccessLayer.Repositories.Abstract
{
    public interface IRepository<T, TId>
    {
        //CRUD
        public Task<int> Insert(T entity);
        public Task<int> Update(T entity);
        public Task<int> Delete(T entity);
        public Task<int> DeleteByPK(TId pk);
        public Task<int> DeleteAll(Expression<Func<T, bool>> expression = null);

        //QUERY
        public Task<T> GetByPK(TId pk);
        public Task<ICollection<T>> GetAll(Expression<Func<T, bool>> expression = null);
        public Task<IEnumerable<T>?> GetAllInclude(Expression<Func<T, bool>>? expression, params Expression<Func<T, object>>[] include);

    }
}
