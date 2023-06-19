using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FizicheskoMehurche
{
    internal class Program
    {
        static void Swap (List<double>list,int i, int j)
        {
            double swap = list[i];
            list[i] = list[j];
            list[j] = swap; 
        }
        static void SortH (List<double> list)
        {
            for (int i = 0; i < list.Count-1; i++)
                for (int j = 0; i < list.Count-i-1; i++)
                {
                    if (list[j] < list[j+1])
                        Swap (list,i,j+1);
                    
                }
           
        }
        static void Main(string[] args)
        {
            List<double> nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            SortH(nums);
            int count=nums.Count;
            int indexH1, indexH2;
            do
            {
                Console.Write("indexH1-");
                indexH1 = int.Parse(Console.ReadLine());
            } while (indexH1 > count - 1);
            do
            {
                Console.Write("indexH2-");
                indexH2 = int.Parse(Console.ReadLine());
            } while (indexH2 > count - 1);

            Console.WriteLine(string.Join(" ",nums));
            Console.Write($" Purvata visochina e {nums[indexH1]} i vtorata visochina e {nums[indexH2]} .");
        }
    }
}
