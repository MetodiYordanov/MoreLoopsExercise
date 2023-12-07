namespace AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numAsString = Console.ReadLine();

            double balance = 0;

            while (numAsString != "End")
            {
                double number = double.Parse(numAsString);

                if (number < 0 )
                {
                    balance -= (number * -1);
                    Console.WriteLine($"Decrease: {(number * -1):F2}");
                }
                else if (number > 0)
                {
                    balance += number;
                    Console.WriteLine($"Increase: {number:F2}");
                }

                numAsString = Console.ReadLine();
            }

            Console.WriteLine($"Balance: {balance:F2}");
        }
    }
}