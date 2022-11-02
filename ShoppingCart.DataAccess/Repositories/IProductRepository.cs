using ShoppingCart.Models;

namespace ShoppingCart.DataAccess.Repositories;

public interface IProductRepository : IRepository<Product>
{
    void Update(Product product);
}