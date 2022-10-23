using Assignment11_EFcore.Data;
using Assignment11_EFcore.Data.Entities;

namespace Assignment11_EFcore.Repositories;

public class ProductRepository : BaseRepository<Product>, IProductRepository
{
    public ProductRepository(ProductStoreContext context) : base(context)
    {
    }
}