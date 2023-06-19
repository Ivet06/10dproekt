using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSoti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("n=");
                n = int.Parse(Console.ReadLine());
            } while (n<10||n>1000);
            List<int> nums = new List<int>();
            for (int i = 0; i < n; i++)
            {
                nums.Add(int.Parse(Console.ReadLine()));   
                if (nums[i] > 0 && nums[i]<1001)
                {
                    Console.Write(nums+" ");
                }
            }
            int sum=0;
            for (int i = 0; i < n; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}
 