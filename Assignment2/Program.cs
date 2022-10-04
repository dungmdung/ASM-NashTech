namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ManageMember.ListAllMember();

            while(true)
            {
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("1.Show all member is male");
                Console.WriteLine("2.Member oldest");
                Console.WriteLine("3.Full Name of members");
                Console.WriteLine("4.Return Birth Place");
                Console.WriteLine("5.The first person was born in Ha Noi");
                Console.WriteLine("6.Exit");
                Console.WriteLine("*******************************************************");
                Console.WriteLine("Select function : ");

                int key = Convert.ToInt32(Console.ReadLine());

                switch(key)
                {
                    case 1:
                        ManageMember.FindMale();
                        break;
                    
                    case 2:
                        ManageMember.FindOldestAge();
                        break;

                    case 3:
                        ManageMember.FullName();
                        break;

                    case 4:
                        ManageMember.FindYear();
                        break;
                    
                    case 5:
                        ManageMember.FindFirstPersonWasBornHaNoi();
                        break;
                    
                    case 6: 
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("This funtion is not available!");
                        break;
                }
            }
        }
    }
}

