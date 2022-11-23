namespace Задание_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество предложений.");
            List<string> offers = new List<string>();
            int numberOffers = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numberOffers; i++)
            {
                Console.Write($"Предложение №{i}: ");
                offers.Add(Console.ReadLine());
                Console.WriteLine();
            }
            //List<string> repeatWords = new List<string>();
            //repeatWords = offers.Where(word => word.Count() > 1).Select(x => x.Key).ToList();


            //List<string> result = offers.GroupBy(word => word)
            //            .Where(g => g.Count() > 1)
            //            .Select(word => word.Key)
            //            .ToList();
            //Console.WriteLine(String.Join(", ", result));


            var seen = new HashSet<string>();
            var duplicates = offers.Where(x => !seen.Add(x));

            Console.WriteLine(String.Join(", ", duplicates));


            //foreach (var repeatWord in repeatWords)
            //{
            //    Console.WriteLine(repeatWord);
            //}
        }
    }
}