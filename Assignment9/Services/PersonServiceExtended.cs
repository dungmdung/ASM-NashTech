using Assignment9.Models;

namespace Assignment9.Services
{
    public class PersonServiceExtended
    {
        private static List<PersonModel> listMember = new List<PersonModel>
        {
            new PersonModel
            {
                FirstName = "Dung",
                LastName = "Do",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 8, 21),
                BirthPlace = "Ha Noi",
                PhoneNumber = "24254535633",
                IsGraduated = false
            },

            new PersonModel
            {
                FirstName = "Long",
                LastName = "Le",
                Gender = "Male",
                DateOfBirth = new DateTime(1997, 9, 8),
                BirthPlace = "Hai Phong",
                PhoneNumber = "35646567",
                IsGraduated = true
            },

            new PersonModel
            {
                FirstName = "Linh",
                LastName = "Tai",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 12, 1),
                BirthPlace = "Ha Noi",
                PhoneNumber = "476470942",
                IsGraduated = false
            },

            new PersonModel
            {
                FirstName = "Quynh",
                LastName = "Do",
                Gender = "Female",
                DateOfBirth = new DateTime(2000, 9, 4),
                BirthPlace = "Ha Noi",
                PhoneNumber = "5324676879",
                IsGraduated = false
            }
        };

        public List<PersonModel> GetAll()
        {
            return listMember;
        }

        public PersonModel? GetOne(int index)
        {
            throw new NotImplementedException();
        }

        public PersonModel Create(PersonModel model)
        {
            listMember.Add(model);
            return model;
        }

        public PersonModel? Update(int index, PersonModel model)
        {
            if (index >= 0 && index < listMember.Count)
            {
                listMember[index] = model;
                return model;
            }
            return null;
        }

        public PersonModel? Delete(int index)
        {
            if (index >= 0 && index < listMember.Count)
            {
                var person = listMember[index];
                listMember.RemoveAt(index);
                return person;
            }
            return null;
        }
    }
}