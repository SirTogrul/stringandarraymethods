namespace array_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Finffirstword("salam dunya ben masaka"));
        }
      static string Finffirstword(string word)
        {
            string[] words = word.Split(' ');
            if (words.Length > 0)
            {
                return words[0];
            }
            else
            {
                return "";
            }
        }
    }
}