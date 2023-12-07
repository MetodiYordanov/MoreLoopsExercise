namespace SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numAsString = Console.ReadLine();
            int number = int.Parse(numAsString);

            for (int i = 0; i < numAsString.Length; i++)
            {
                int digit = (int)Char.GetNumericValue(numAsString[i]);

                if (number % digit != 0)
                {
                    Console.WriteLine($"{number} is not special");
                    return;
                }
            }

            Console.WriteLine($"{number} is special");
        }
    }
}