using ShoppingCart.Models;

namespace ShoppingCart.DataAccess.Repositories;

public interface ICategoryRepository : IRepository<Category>
{
    void Update(Category category);
}