using Assignment10_EFcore.DTOs;
using Assignment10_EFcore.Models;
using Assignment10_EFcore.Repositories;
using Assignment10_EFcore.SaveChange;

namespace Assignment10_EFcore.Services
{
    public class StudentService : IStudentService
    {
        private readonly ISaveChange _saveChange;
        private readonly IBaseRepository<Student> _studentRepository;

        public StudentService(ISaveChange saveChange)
        {
            _saveChange = saveChange;
            _studentRepository = saveChange.GetRepository<Student>();
        }

        public AddStudentResponse? Create(AddStudentRequest createModel)
        {
            var newStudent = new Student
            {
                FirstName = createModel.FirstName,
                LastName = createModel.LastName,
                City = createModel.City,
                State = createModel.State
            };

            var createdStudent = _studentRepository.Create(newStudent);

            return _saveChange.SaveChanges() > 0 ?
                new AddStudentResponse
                {
                    Id = createdStudent.Id,
                    FirstName = createdStudent.FirstName,
                    LastName = createdStudent.LastName
                }
                : null;
        }

        public bool Delete(int id)
        {
            var deleteStudent = _studentRepository.Get(student => student.Id == id);

            if (deleteStudent == null) return false;

            bool isSucceeded = _studentRepository.Delete(deleteStudent);

            isSucceeded &= _saveChange.SaveChanges() > 0;

            return isSucceeded;
        }

        public IEnumerable<GetStudentResponse> GetAll()
        {
            return _studentRepository
                .GetAll(_ => true)
                .Select(student => new GetStudentResponse
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    City = student.City,
                    State = student.State
                });
        }

        public GetStudentResponse? GetById(int id)
        {
            var student = _studentRepository.Get(student => student.Id == id);

            return student == null
                ? null
                : new GetStudentResponse
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    City = student.City,
                    State = student.State
                };
        }

        public UpdateStudentResponse? Update(int id, UpdateStudentRequest updateModel)
        {
            var student = _studentRepository.Get(student => student.Id == id);

            if (student == null) return null;

            student.FirstName = updateModel.FirstName;
            student.LastName = updateModel.LastName;
            student.City = updateModel.City;
            student.State = updateModel.State;

            var updatedStudent = _studentRepository.Update(student);

            return _saveChange.SaveChanges() > 0
                ? new UpdateStudentResponse
                {
                    FirstName = updatedStudent.FirstName,
                    LastName = updatedStudent.LastName,
                    City = updatedStudent.City,
                    State = updatedStudent.State
                }
                : null;
        }
    }
}