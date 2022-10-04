namespace Assignment2
{
    public class ManageMember
    {
        public static List<Member> listMember = new List<Member>();
        public static void ListAllMember()
        {
            listMember.Add(new Member{ FirstName = "Dung",
                LastName = "Do",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 8, 21),
                BirthPlace = "Ha Noi",
                PhoneNumber = "24254535633",
                IsGraduated = false});

            listMember.Add(new Member{ FirstName = "Long",
                LastName = "Le",
                Gender = "Male",
                DateOfBirth = new DateTime(1999, 9, 8),
                BirthPlace = "Hai Phong",
                PhoneNumber = "35646567",
                IsGraduated = false});
            
            listMember.Add(new Member{ FirstName = "Linh",
                LastName = "Tai",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 12, 1),
                BirthPlace = "Ha Noi",
                PhoneNumber = "476470942",
                IsGraduated = false});
            
            listMember.Add(new Member{ FirstName = "Quynh",
                LastName = "Do",
                Gender = "Female",
                DateOfBirth = new DateTime(2002, 9, 4),
                BirthPlace = "Ha Noi",
                PhoneNumber = "5324676879",
                IsGraduated = false});
        } 
        public static void FindMale()
        {
            var information = listMember.Where(
                (mb) => {
                    return mb.Gender.Contains("Male");
                }
            );

            foreach(var item in information)
            {
                Console.WriteLine(item.Information);
            }
        }
        public static void FindOldestAge()
        {
            int max = listMember.Max((mb) => mb.Age);

            var information = listMember.Where(
                (mb) => {
                    return mb.Age.Equals(max);
                }
            );

            foreach(var item in information)
            {
                Console.WriteLine(item.Information);
            }
        }
        public static void FullName()
        {
            var information = listMember.Select(
                (mb) => {
                    return mb.FirstName + " " + mb.LastName;
                }
            );

            foreach(var item in information)
            {
                Console.WriteLine(item);
            }
        }
        public static void FindYear()
        {
            int key = 0;
            while(key != 4)
            {
                key = Convert.ToInt32(Console.ReadLine());
                switch(key)
                {
                    case 1:
                    {
                        Console.WriteLine("List of members born in 2000: ");

                        var information = listMember.Where(
                            (mb) => {
                                return mb.DateOfBirth.Year == 2000;
                            } 
                        );

                        foreach(var item in information)
                        {
                            Console.WriteLine(item.Information);
                        }
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("List of members born before 2000: ");

                        var information = listMember.Where(
                            (mb) => {
                                return mb.DateOfBirth.Year < 2000;
                            } 
                        );

                        foreach(var item in information)
                        {
                            Console.WriteLine(item.Information);
                        }
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("List of members born after 2000: ");

                        var information = listMember.Where(
                            (mb) => {
                                return mb.DateOfBirth.Year > 2000;
                            } 
                        );
                        
                        foreach(var item in information)
                        {
                            Console.WriteLine(item.Information);
                        }
                        break;
                    }
                }
            }
        }
        public static void FindFirstPersonWasBornHaNoi()
        {
            var information = listMember.Where(
                (mb) => {
                    return mb.BirthPlace == "Ha Noi";
                }
            );

            foreach(var item in information)
            {
                Console.WriteLine(item.Information);
                break;
            }
        }
    }
}