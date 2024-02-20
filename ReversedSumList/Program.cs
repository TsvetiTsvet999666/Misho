namespace ReversedSumList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                int originalNumber = list[i];
                int reversedNumber = 0;
                while (originalNumber > 0)
                {
                    int digit = originalNumber % 10;
                    reversedNumber = reversedNumber * 10 + digit;
                    originalNumber /= 10;
                }
                sum += reversedNumber;
            }
            Console.WriteLine(sum);
        }
    }
}
