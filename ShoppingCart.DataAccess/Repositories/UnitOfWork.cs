using ShoppingCart.DataAccess.Data;

namespace ShoppingCart.DataAccess.Repositories;

public class UnitOfWork : IUnitOfWork
{
    public ICategoryRepository Category { get; private set; }
    public IProductRepository Product { get; private set; }
    private ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        Category = new CategoryRepository(context);
        Product = new ProductRepository(context);
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}