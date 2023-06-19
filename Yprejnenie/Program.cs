using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yprejnenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();    
            stack.Push(20);
            stack.Push(15);
            stack.Push(7);
            stack.Push(2);
            stack.Push(71);
            stack.Push(9);
            Console.WriteLine(stack.Peek());
            for (int i = 0; i < 2; i++)
            {
                stack.Pop();
            }
            Console.WriteLine(  stack.Peek() );
            stack.Push(40);
            stack.Push(18);
            for (int i = 0; i < 3; i++)
            {
                stack.Pop();
            }
            Console.WriteLine(stack.Peek());



        }
    }
}
