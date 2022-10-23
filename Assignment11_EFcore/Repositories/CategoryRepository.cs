using Assignment11_EFcore.Data;
using Assignment11_EFcore.Data.Entities;

namespace Assignment11_EFcore.Repositories;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(ProductStoreContext context) : base(context)
    {
    }
}