using Assignment10_EFcore.DTOs;

namespace Assignment10_EFcore.Services
{
    public interface IStudentService
    {
        IEnumerable<GetStudentResponse> GetAll();
        GetStudentResponse? GetById(int id);
        AddStudentResponse? Create(AddStudentRequest createModel);
        UpdateStudentResponse? Update(int id, UpdateStudentRequest updateModel);
        bool Delete(int id);
    }
}