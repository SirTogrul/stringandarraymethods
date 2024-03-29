using System.ComponentModel.Design;
using System.Diagnostics;

namespace arraytask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Customstring("salam123"));
        }
        static bool Customstring(string word)
        {
            bool Boyukherf=false;
            bool Kicikherf=false;
            bool Reqem=false;
            foreach (char c in word)
            {
                if (c >= 'A' && c <= 'Z')
                    Boyukherf = true;
                else if (c >= 'a' && c <= 'z')
                    Kicikherf = true;
                else if (c >= '0' && c <= '9')
                    Reqem = true;
            }
            return Boyukherf && Kicikherf && Reqem;
        } 
    }
}