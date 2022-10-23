using Assignment11_EFcore.DTOs;

namespace Assignment11_EFcore.Services;

public interface ICategoryService
{
    IEnumerable<GetCategoryResponse> GetAll();
    GetCategoryResponse? GetById(int id);
    AddCategoryResponse? Create(AddCategoryRequest requestModel);
    UpdateCategoryResponse? Update(UpdateCategoryRequest requestModel);
    bool Delete(int id);
}