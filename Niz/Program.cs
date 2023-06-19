using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruit = Console.ReadLine().Split().ToList();
            fruit.Insert(3, "banana");
            Console.WriteLine(fruit.Count);
            if (fruit.Contains("applr"))
            {
                
            }
        }
    }
}
