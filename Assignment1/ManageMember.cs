namespace Assignment1
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
                DateOfBirth = new DateTime(2002, 9, 8),
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
            foreach (Member mb in listMember)
            {
                if (mb.Gender == "Male")
                {
                    Console.WriteLine(mb.Information);
                }
            }
        }
        public static void FindOldestAge()
        {
            Member Oldest = listMember.ElementAt(0);

            foreach(Member mb in listMember)
            {
                if(mb.Age > Oldest.Age)
                {
                    Oldest = mb;
                }
            }
            Console.WriteLine(Oldest.Information);
        }
        public static void FullName()
        {
            foreach(Member mb in listMember)
            {
                Console.WriteLine(mb.FirstName + " " + mb.LastName);
            }
        }

        public static void FindYear()
        {
            while(key != 4)
            {
                Console.WriteLine("1.List of members born in 2000: ");
                Console.WriteLine("2.List of members born before 2000: ");
                Console.WriteLine("3.List of members born after 2000: ");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Select function : ");

                int key = Convert.ToInt32(Console.ReadLine());
                switch(key)
                {
                    case 1:
                    {
                        Console.WriteLine("List of members born in 2000: ");

                        foreach(Member mb in listMember)
                        {
                            if(mb.DateOfBirth.Year == 2000)
                            {
                                Console.WriteLine(mb);
                            }
                        }
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("List of members born before 2000: ");

                        foreach(Member mb in listMember)
                        {
                            if(mb.DateOfBirth.Year < 2000)
                            {
                                Console.WriteLine(mb.Information);
                            }
                        }
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("List of members born after 2000: ");

                        foreach(Member mb in listMember)
                        {
                            if(mb.DateOfBirth.Year > 2000)
                            {
                                Console.WriteLine(mb.Information);
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
            while(true) 
            {
                if (index >= listMember.Count) break;

                var mb = listMember[index];

                if (mb.BirthPlace == "Ha Noi")
                {
                    Console.WriteLine(mb.Information);
                    break;
                }
                ++index;
            }
        }
    }
}