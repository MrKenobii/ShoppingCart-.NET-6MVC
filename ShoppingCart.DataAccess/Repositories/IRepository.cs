using System.Linq.Expressions;

namespace ShoppingCart.DataAccess.Repositories;

public interface IRepository<T> where T : class
{
    IEnumerable<T> GetAll(Expression<Func<T, bool>>? predicate = null, string? includeProperties=null);
    T GetT(Expression<Func<T, bool>> predicate, string? includeProperties = null);
    void Add(T entity);
    void Delete(T entity);
    void DeleteRange(IEnumerable<T> entity);
}