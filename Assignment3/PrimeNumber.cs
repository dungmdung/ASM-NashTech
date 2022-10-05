namespace Assignment3
{
    public class PrimeNumber
    {
        static void Number(int number, string message)
        {
            Console.WriteLine($"Start {message}");

            for (int i = 1; i <= number; i++)
            {
                int count = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && i != 1)
                {
                    Console.WriteLine($"{message,6} {i,4}");
                }

            }

            Console.WriteLine($"End {message}");
        }
        public static async Task FindTheFirstPrimeNumbers()
        {
            Task primeNumber_1 = new Task(
                (Object item) =>
                {
                    string letter = (string)item;
                    Number(100, letter);
                }, "Range1"
            );
            primeNumber_1.Start();

            await primeNumber_1;

        }
        public static async Task FindTheSecondPrimeNumbers()
        {
            Task primeNumber_2 = new Task(
                (Object item) =>
                {
                    string letter = (string)item;
                    Number(100, letter);
                }, "Range2"
            );
            primeNumber_2.Start();

            await primeNumber_2;

        }
    }
}