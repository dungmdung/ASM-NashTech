using Assignment11_EFcore.Models;

namespace Assignment11_EFcore.Repositories;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(ProductStoreContext context) : base(context)
    {
    }
}