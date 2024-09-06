
using System.Linq.Expressions;


namespace CR.DataAccess.Repository.IRepository
{
    public interface IRepositoryBase <T> where T : class
    {
        IEnumerable<T> GetAll (Expression<Func<T,bool>>? filter = null, string? includeProperties = null, bool tracked = false);
        T Get (Expression<Func<T, bool>>? filter = null, string? includeProperties = null, bool tracked = false);
        void Add(T entity);
        void Remove (T entity);
    }
}
