using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Futbolist

{
    internal class Program
    {
        static void Sort(string[] ime)
        {
            for (int i = 0; i < ime.Length - 1; i++)
                for (int j = 0; j < ime.Length - i - 1; j++)
                    if (ime[j].CompareTo(ime[i + 1]) > 0) 
                    {
                          string swap = ime[j];
                          ime[j] = ime[j + 1];
                          ime[j + 1] = swap;

                    }
        }
        static int Gol(int[] broi)
        {
            int sum = 0;
            for (int i = 0; i < broi.Length; i++)
            {
                if (broi[i]>3)
                {
                    sum = sum + broi[i];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string[]ime=Console.ReadLine().Split().ToArray();
            int[]broi = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            Sort(ime);
            Console.WriteLine(string.Join(" ",ime));
            int sum=Gol(broi);
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
