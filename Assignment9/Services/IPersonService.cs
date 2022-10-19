using Assignment9.Models;

namespace Assignment9.Services
{
    public interface IPersonService
    {
        List<PersonModel> GetAll();

        PersonModel? GetOne(Guid id);

        PersonModel Create(PersonModel model);

        PersonModel? Update(Guid id, PersonModel model);

        PersonModel? Delete(Guid id);
    }
}