using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMetod2
{
    internal class Program
    {
        static void Sort(List<double> uspeh)
        {
            int index;
            double max;
            for (int i = 0; i < uspeh.Count-1; i++)
            {
                index = 1;
                max = uspeh[i];
                for (int j= i+1; j < uspeh.Count; j++)
                    if (uspeh[j] > max)
                    {
                        index= j; 
                        max = uspeh[j]; 
                    }
                uspeh[index] = uspeh[i];
                uspeh[i] = max;
            }
        }
        static void Main(string[] args)
        {
            List<double>uspeh=Console.ReadLine().Split().Select(double.Parse).ToList();
            Sort(uspeh);
            Console.WriteLine();
            Console.Write(string.Join(" ",uspeh ));  
        }
    }
}
