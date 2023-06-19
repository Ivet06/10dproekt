using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Rekursiq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void Rekursia(int n)
        {
            if(n >10) 
            {
                Console.WriteLine(n % 10);
                Rekursia(n 10) ;
            }
        }
    }
}
