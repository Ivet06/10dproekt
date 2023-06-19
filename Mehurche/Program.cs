using System.Collections.Generic;
using System.Threading.Channels;

namespace Mehurche
{
    internal class Program
    {
       
        static void Sort(List<int>list)
        {
            for (int i = 0; i < list.Count-1; i++)
                for (int j = 0; j < list.Count - i-1; j++)
                {
                    if (list[j]< list[j+1])
                    {
                        int swap = list[j];
                        list[j] = list[j + 1];
                        list[j+1]= swap;
                    }
                }
        }
        static void Main(string[] args)
        {
            List<int>nums=Console.ReadLine().Split().Select(int.Parse).ToList();  
            Sort(nums);
            Console.WriteLine(string.Join(",", nums));
        }
    }
}