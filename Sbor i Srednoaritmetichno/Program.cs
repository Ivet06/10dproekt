using System.Reflection.Metadata.Ecma335;

namespace Sbor_i_Srednoaritmetichno
{
    internal class Program
    {
        static int Sum (int[] arr,int chislo)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%chislo==0)
                {
                    sum += arr[i];
                }
            }
            return sum; 
        } 
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().
                Select(int.Parse).ToArray();
            int chislo = int.Parse(Console.ReadLine());
            int sum = Sum(arr,chislo);
            Console.WriteLine(sum/arr.Length); 

        }
    }
}