namespace _8._10._hamming_distance;
class Program
{
    static void Main(string[] args)
    {
        string dnaString1 = Input.AskString("Give up first DNA string, composed out of G,A,C,T");
        string dnaString2 = Input.AskString("Give up first DNA string, composed out of G,A,C,T");
        char[] dnaString1Chars = dnaString1.ToCharArray();
        char[] dnaString2Chars = dnaString2.ToCharArray();

        char [] indexes = new char [dnaString1.Length];
        for (int i = 0; i < dnaString1.Length; i++)
        {
            if(!(dnaString1Chars[i]==dnaString2Chars[i]))
            {
                indexes[i] = '^';
            }
            else
            {
                indexes[i] = ' ';
            }
        }

        Console.WriteLine($"{dnaString1}");
        Console.WriteLine($"{dnaString2}");
        Console.WriteLine($"{new string(indexes)}");

    }

    
    // Classes
    public static class Input
    {
        public static string AskString(string question)
        {
            Console.Write($"{question}");
            return Console.ReadLine() ?? string.Empty;
        }
        public static int AskInteger(string question)
        {
            while (true)
            {
                Console.Write($"{question}");
                if (int.TryParse(Console.ReadLine(), out int r))
                    return r;

            }
        }
        public static char AskChar(string question)
        {
            while (true)
            {
                Console.Write($"{question}");
                if (char.TryParse(Console.ReadLine(), out char r))
                    return r;

            }


        }
    }
}
