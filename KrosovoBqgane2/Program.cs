using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrosovoBqgane2
{
    internal class Program
    {
        static void Sort(List<int> poMalkoVreme)
        {
            for (int i = 0; i < poMalkoVreme.Count - 1; i++)
                for (int j = 0; j < poMalkoVreme.Count - i - 1; j++)
                {
                    if (poMalkoVreme[j] < poMalkoVreme[j + 1])
                    {
                        int swap = poMalkoVreme[j];
                       poMalkoVreme[j] = poMalkoVreme[j + 1];
                        poMalkoVreme[j + 1] = swap;
                    }
                }
        }
        static void Main(string[] args)
        {
            Console.Write("Ваведи времето от първия ден");
            List<int> sekyndiParviDen = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.Write("Ваведи времето от втория ден");
            List<int> sekyndiVtoriDen = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.Write("Ваведи времето от третия ден");
            List<int> sekyndiTretiDen = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int>poMalkoVreme=new List<int>();
            Console.Write("Ваведи време");
            int vreme=int.Parse(Console.ReadLine());
            for (int i = 0; i < sekyndiParviDen.Count; i++)
            {
                if (sekyndiParviDen[i] <vreme)
                {
                    poMalkoVreme.Add(sekyndiParviDen[i]);
                }
            }
            for (int i = 0; i < sekyndiVtoriDen.Count; i++)
            {
                if (sekyndiVtoriDen[i]<vreme)
                {
                    poMalkoVreme.Add(sekyndiVtoriDen[i]);
                }
            }
            for (int i = 0; i < sekyndiTretiDen.Count; i++)
            {
                if (sekyndiTretiDen[i]<vreme)
                {
                    poMalkoVreme.Add(sekyndiTretiDen[i]);
                }
            }
            Sort(poMalkoVreme);
            Console.WriteLine(string.Join(" ", poMalkoVreme));

        }
    }
}
