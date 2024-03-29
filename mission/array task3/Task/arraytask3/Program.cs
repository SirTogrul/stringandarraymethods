using System.ComponentModel.Design;

namespace arraytask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Checkarray("God Damn"));
        }
        static bool Checkarray(string word)
        {
            string[] words = word.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words.Length == 2)
                {
                    if ((word[i] >= 'A') && (word[i] <= 'Z'))
                    {
                        return true;
                    }
                }
               
                
            }
            return false;
        }
    }
}