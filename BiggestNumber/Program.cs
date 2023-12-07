namespace BiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amountNumber = int.Parse(Console.ReadLine());

            int biggestNumber = int.MinValue;

            for (int i = 0; i < amountNumber; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());
                if (newNumber > biggestNumber)
                {
                    biggestNumber = newNumber;
                }
            }

            Console.WriteLine(biggestNumber);
        }
    }
}