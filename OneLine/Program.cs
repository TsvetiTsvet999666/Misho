using System.Collections.Generic;

namespace OneLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int index = 0; index < list.Count; index++)
            {
                Console.WriteLine($"list [{index + 1}] = {list[index]}");
            }
        }
    }
}
