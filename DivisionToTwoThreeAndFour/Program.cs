namespace DivisionToTwoThreeAndFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountNumbers = int.Parse(Console.ReadLine());

            double dividedByTwo = 0;
            double dividedByThree = 0;
            double dividedByFour = 0;

            for (int i = 0; i < amountNumbers; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    dividedByTwo += 1;
                }
                if (number % 3 == 0)
                {
                    dividedByThree += 1;
                }
                if (number % 4 == 0)
                {
                    dividedByFour += 1;
                }
            }

            double percentageByTwo = (double)dividedByTwo / amountNumbers;
            double percentageByThree = (double)dividedByThree / amountNumbers;
            double percentageByFour = (double)dividedByFour / amountNumbers;

            Console.WriteLine($"{(percentageByTwo * 100):F2}%");
            Console.WriteLine($"{(percentageByThree * 100):F2}%");
            Console.WriteLine($"{(percentageByFour * 100):F2}%");
        }
    }
}