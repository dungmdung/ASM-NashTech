namespace Assignment1
{
    public class ManageMember
    {
        public static List<Member> listMember = new List<Member>();

        public static void ListAllMember()
        {
            listMember.Add(new Member
            {
                FirstName = "Dung",
                LastName = "Do",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 8, 21),
                BirthPlace = "Ha Noi",
                PhoneNumber = "24254535633",
                IsGraduated = "Not graduated"
            });

            listMember.Add(new Member
            {
                FirstName = "Long",
                LastName = "Le",
                Gender = "Male",
                DateOfBirth = new DateTime(1997, 9, 8),
                BirthPlace = "Hai Phong",
                PhoneNumber = "35646567",
                IsGraduated = "Graduated"
            });

            listMember.Add(new Member
            {
                FirstName = "Linh",
                LastName = "Tai",
                Gender = "Male",
                DateOfBirth = new DateTime(2001, 12, 1),
                BirthPlace = "Ha Noi",
                PhoneNumber = "476470942",
                IsGraduated = "Not graduated"
            });

            listMember.Add(new Member
            {
                FirstName = "Quynh",
                LastName = "Do",
                Gender = "Female",
                DateOfBirth = new DateTime(2000, 9, 4),
                BirthPlace = "Ha Noi",
                PhoneNumber = "5324676879",
                IsGraduated = "Not graduated"
            });
        }
        public static void FindMale()
        {
            foreach (Member member in listMember)
            {
                if (member.Gender == "Male")
                {
                    Console.WriteLine(member.InformationOfAll);
                }
            }
        }
        public static void FindOldestAge()
        {
            Member Oldest = listMember.ElementAt(0);

            foreach (Member member in listMember)
            {
                if (member.Age > Oldest.Age)
                {
                    Oldest = member;
                }
            }
            Console.WriteLine(Oldest.InformationOfAll);
        }
        public static void FullName()
        {
            foreach (Member member in listMember)
            {
                Console.WriteLine(member.FullName);
            }
        }

        public static void FindYear()
        {
            while (true)
            {
                Console.WriteLine("1.List of members born in 2000: ");
                Console.WriteLine("2.List of members born before 2000: ");
                Console.WriteLine("3.List of members born after 2000: ");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Select function : ");

                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        {
                            Console.WriteLine("List of members born in 2000: ");

                            foreach (Member member in listMember)
                            {
                                if (member.DateOfBirth.Year == 2000)
                                {
                                    Console.WriteLine(member.InformationOfAll);
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("List of members born before 2000: ");

                            foreach (Member member in listMember)
                            {
                                if (member.DateOfBirth.Year < 2000)
                                {
                                    Console.WriteLine(member.InformationOfAll);
                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("List of members born after 2000: ");

                            foreach (Member member in listMember)
                            {
                                if (member.DateOfBirth.Year > 2000)
                                {
                                    Console.WriteLine(member.InformationOfAll);
                                }
                            }
                            break;
                        }
                    case 4:
                        {
                            return;
                        }
                    default:
                        {
                            Console.WriteLine("This funtion is not available!");
                            break;
                        }
                }
            }
        }
        public static void FindFirstPersonWasBornHaNoi()
        {
            int index = 0;
            while (true)
            {
                if (index >= listMember.Count) break;

                var member = listMember[index];

                if (member.BirthPlace == "Ha Noi")
                {
                    Console.WriteLine(member.InformationOfAll);
                    break;
                }
                ++index;
            }
        }
    }
}