namespace NamesList2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();
            for (int i = 0; i < names.Count; i++)
            {
                string[] parts = names[i].Split();
                Console.WriteLine($"{parts[1]} {parts[0]}");
            }
        }
    }
}
