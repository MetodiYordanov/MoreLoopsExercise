namespace PowerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            int poweredNumber = number;

            for (int i = 1; i < power; i++)
            {
                poweredNumber = poweredNumber * number;
            }

            Console.WriteLine(poweredNumber);
        }
    }
}