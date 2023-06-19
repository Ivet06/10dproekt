namespace ZadachaIzpitvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(10);
            stack.Push(2);
            stack.Push(5);
            stack.Push(7);
            stack.Push(9);
            for (int i = 0; i < 2; i++)
            {
                stack.Pop();
            }
            Console.WriteLine(stack.Peek());
            Stack<int> A = new Stack<int>();
            int a=int.Parse(Console.ReadLine());
            for (int i = 0; i <a; i++)
            {
                A.Push(int.Parse(Console.ReadLine()));
            }
            foreach (int i in stack)
            {
                A.Push(i);
            }
            int[] arr=new int[A.Count];
            arr=A.ToArray();
            A.OrderBy(x => x);
            Console.WriteLine(arr.Average());
            Console.WriteLine(string.Join(" ",arr));
            stack.Push(4);
            stack.Push(23);
        }
    }
}