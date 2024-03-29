using System.ComponentModel.Design;
using System.Runtime.Serialization.Formatters;

namespace array_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CustomSpace("salam,    dunya"));
        }
        static string CustomSpace(string word)
        {
            bool check = false;
            char space = ' ';
            string newword = "";
            for (int i = 0; i <word.Length; i++)
            {
                if (word[i]==space)
                {
                    check = true;
                }
                else
                {
                    if (check)
                    {
                        newword += space;
                        check = false;
                    }
                }              
            }
            return newword;
        }

    }
}