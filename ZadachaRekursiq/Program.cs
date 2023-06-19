using System.Threading.Channels;

namespace ZadachaRekursiq
{
    internal class Program
    {
        static int SumN(int n)
        {
            if (n < 10) return n;
            return n%10 + SumN(n / 10);
            

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("n=");
            Console9.WriteLine(SumN(n));
        }
    }
}