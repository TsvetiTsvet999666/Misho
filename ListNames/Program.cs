namespace ListNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            list.Reverse();
            Console.WriteLine(string.Join("; ", list));
        }
    }
}
