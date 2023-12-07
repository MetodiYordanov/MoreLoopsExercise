namespace VowelSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberVowels = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < numberVowels; i++)
            {
                char vowel = Convert.ToChar(Console.ReadLine());

                if (vowel == 'a')
                {
                    result += 1;
                }
                else if (vowel == 'e')
                {
                    result += 2;
                }
                else if (vowel == 'i')
                {
                    result += 3;
                }
                else if (vowel == 'o')
                {
                    result += 4;
                }
                else if (vowel == 'u')
                {
                    result += 5;
                }
            }

            Console.WriteLine(result);
        }
    }
}