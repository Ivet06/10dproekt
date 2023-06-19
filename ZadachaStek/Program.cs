using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachaStek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("H");
            stack.Push("E");
            stack.Push("L");
            stack.Push("L");
            stack.Push("O");
            for (int i = 0; i < stack.Count; i++)
            {

            }
            Console.WriteLine(stack);
           
        }
    }
}
