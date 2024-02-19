namespace ListCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete spisuk ot cvetove>>>>Done za krai<<<<:");
            List<string> ColorsList = new List<string>();
            string input = null;
            do
            {
                input = Console.ReadLine();
                ColorsList.Add(input);
            } while (input != "done");
            ColorsList.Remove(input);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            foreach (string kvadrat in ColorsList)
            {
                Console.WriteLine(kvadrat);
            }
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("0 do " + (ColorsList.Count-1));
            int index = int.Parse(Console.ReadLine());
            ColorsList.RemoveAt(index);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            //for (int i = 0; i < ColorsList.Count; i++) 
            //{
            //    Console.WriteLine(ColorsList[i]);
            //}
            foreach (string kvadrat in ColorsList)
            {
                Console.WriteLine(kvadrat);
            }
        }
    }
}
