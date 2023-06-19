using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KrosovoBqgane
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Rezoltat1->");
            List<double> rezoltat1 = Console.ReadLine().Split().Select(double.Parse).ToList();
            Console.WriteLine();
            Console.Write("Rezoltat2->");
            List<double> rezoltat2 = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double>list3=new List<double>();
            list3=list3.Concat(rezoltat1).ToList();
            list3 = list3.Concat(rezoltat2).ToList();
            for (int i = 0; i < list3.Count; i++)
                for (int j = 0; j < list3.Count - 1 - i; j++)
                    if (list3[j] > list3[j + 1])
                    {
                        double swap = list3[j];
                        list3[j] = list3[j+1];
                        list3[j+1] = swap;
                    }
            Console.WriteLine();
                   Console.WriteLine(string.Join(" ", list3));  
                
        }  
    }
}
