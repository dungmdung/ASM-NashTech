using Assignment11_EFcore.Models;

namespace Assignment11_EFcore.Repositories;

public class ProductRepository : BaseRepository<Product>, IProductRepository
{
    public ProductRepository(ProductStoreContext context) : base(context)
    {
    }
}