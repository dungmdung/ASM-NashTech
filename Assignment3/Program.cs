namespace Assignment3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Task primenumber_1 = PrimeNumber.FindTheFirstPrimeNumbers();
            Task primenumber_2 = PrimeNumber.FindTheSecondPrimeNumbers();

            Task.WaitAll(primenumber_1, primenumber_2);

            Console.WriteLine("Press any key");

            Console.ReadKey();
        }
    }
}
