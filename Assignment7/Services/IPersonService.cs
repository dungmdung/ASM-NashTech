using Assignment7.Models;

namespace Assignment7.Services
{
    public interface IPersonService
    {
        List<MembersModel> GetAll();

        MembersModel? GetOne(int index);

        MembersModel Create(MembersModel model);

        MembersModel? Update(int index, MembersModel model);

        MembersModel? Delete(int index);
    }
}