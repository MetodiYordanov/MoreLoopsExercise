namespace SpecialBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stopNumber = int.Parse(Console.ReadLine());

            int number = int.Parse(Console.ReadLine());
            int previousNumber = number;

            while (number != stopNumber)
            {
                previousNumber = number;

                number = int.Parse(Console.ReadLine());
            }

            double result = previousNumber + (previousNumber * 0.2);
            Console.WriteLine(result);
        }
    }
}