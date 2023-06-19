using System.Threading.Channels;

namespace Rekursiq
{
    internal class Program
    {
        static void Rec()
        {
            char c = char.Parse(Console.ReadLine());
            if (c != 'X') Rec();
           Console.Write(c);
        }
        static void Main(string[] args)
        {
          Rec();
            Console.WriteLine("  ");
        }
    }
}