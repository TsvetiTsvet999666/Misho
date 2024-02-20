namespace SameNumberList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int currentStart = 0;
            int currentLength = 1;
            int bestStart = 0;
            int bestLength = 1;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == list[i - 1])
                {
                    currentLength++;

                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestStart = currentStart;
                    }
                }
                else
                {
                    currentStart = i;
                    currentLength = 1;
                }
            }
            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
