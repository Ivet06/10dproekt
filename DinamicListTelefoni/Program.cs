namespace DinamicListTelefoni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DinamicList telefoni=new DinamicList();
            int count=int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string tel = Console.ReadLine();
                telefoni.Add(tel);
            }
        }

    }
}