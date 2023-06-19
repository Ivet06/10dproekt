using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaZaIzspitvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Queue<int> queue2 = new Queue<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведи елемент в опашка");
                queue.Enqueue(int.Parse(Console.ReadLine()));
                Console.Write("Въведи елемент в опашка2");
                queue2.Enqueue(int.Parse(Console.ReadLine()));  
            }
            Queue<int> queue3 = new Queue<int>();
            List<int> list = new List<int>();
           
        }
    }
}
