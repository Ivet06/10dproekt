namespace Kamione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kamioni;
            do
            {
                Console.WriteLine("Въведи бр.камиони-");
                kamioni = int.Parse(Console.ReadLine());
            } while (kamioni<7||kamioni>77);

            double[] tovar=new double[kamioni];

            for (int i = 0; i <kamioni; i++)
            {
                Console.WriteLine("Товар=");
                tovar[i] = double.Parse(Console.ReadLine());
            }

            int count = 0; //count=broj

            for (int i = 0; i < kamioni; i++)
            {
                if (tovar[i] > 1000 && tovar[i]>5000)
                {
                    count++;    
                }
            }

            Console.WriteLine($"Брой={count}");
            double maxTovar=tovar[0];
            int index = 0;

            for (int i = 0; i < kamioni; i++)
            {
                if (tovar[i]>maxTovar)
                {
                    maxTovar = tovar[i];
                    index=1;    
                }
                else if (maxTovar==tovar[i])    
                {
                    Console.WriteLine($"Макс={tovar[i]} Брой={i+1} ");    
                }
            }

            Console.WriteLine($"Макс={maxTovar} Брой={index+1}");
        }
    }
}