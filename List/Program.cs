namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> nums = new List<int>();
            int count=int.Parse(Console.ReadLine());
            int num;
            for (int i = 0; i < count; i++)
            {
                num = int.Parse(Console.ReadLine());
                nums.Add(num);

            }
            nums.Sort();
            nums.Reverse();
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}