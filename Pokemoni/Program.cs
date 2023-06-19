using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokemoni
{
    
    internal class Program
    { 
        static void Sort(List<int>pokemoni)
        {
            for (int i = 0; i < pokemoni.Count; i++)
                for (int j = 0; j < pokemoni.Count-i-1; j++)
                    if (pokemoni[j] > pokemoni[j+1])
                    {
                        int swap = pokemoni[j];
                        pokemoni[j] = pokemoni[j+1];
                        pokemoni[j+1] = swap;
                    }
        }
        static int Find(List<int> pokemoni,int x)
        {
            int L = 0;
            int R = pokemoni.Count;
            int m;
            do
            {
                m = (L + R) / 2;
                if (pokemoni[m] < x)
                {
                    L = m + 1;
                }
                else
                {
                    R = m - 1;
                }
            } while (pokemoni[m] != x && R >= L);
            if (pokemoni[m] == x)
                return m;
            else return -1; 
        }
        static void Main(string[] args)
        {
            List<int>pokemoni=Console.ReadLine().Split().Select(int.Parse).ToList();
            Sort(pokemoni);
            int x=int.Parse(Console.ReadLine());
            int index;
            index=Find(pokemoni,x);
            if (index==-1)
            {
                Console.WriteLine("Няма съвпадение");
            }
            else
            {
                Console.WriteLine("Има съвпадение");
            }
            Console.WriteLine(pokemoni.Count-1);
            List<int>pocemoni1=new List<int>();
            foreach (int item in pokemoni)
            {
                if (item % 2 == 0)
                    pocemoni1.Add(item);
            }
            Console.Write(string.Join(" ", pocemoni1));
        }
    }
}
