namespace ShoppingCart.DataAccess.Repositories;

public interface IUnitOfWork
{
    ICategoryRepository Category { get; }
    IProductRepository Product { get; }
    void Save();
}