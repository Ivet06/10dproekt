namespace KoledniIgrachki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<double> priceToys = new Stack<double>();
            int n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Price=");
                priceToys.Push(double.Parse(Console.ReadLine()));
            }
            Console.WriteLine(priceToys.Min());
            Console.WriteLine(priceToys.Max());
            foreach (double item in priceToys)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(priceToys.Peek());
            Console.WriteLine(priceToys.Pop());
            if (priceToys.Contains(10))
            {
                Console.WriteLine("Ima igrachka za 10 lv.");
            }
            double[]price=priceToys.ToArray();
            while (price.Length>0)
            {
                Console.WriteLine(priceToys.Pop());
            }

        }
    }
}