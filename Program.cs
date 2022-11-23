namespace Задание_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> offers = new List<string>();

            int numberOffers = GetNumber();
            GetOffers(offers, numberOffers);
            RepeatSearch(offers);
            Output();
        }
        private static int GetNumber()
        {
            Console.WriteLine("Введите количество предложений.");
            int numberOffers = Convert.ToInt32(Console.ReadLine());
            return numberOffers;
        }
        private static void GetOffers(List<string> offers, int numberOffers)
        {
            for (int i = 1; i <= numberOffers; i++)
            {
                Console.Write($"Предложение №{i}: ");
                offers.Add(Console.ReadLine());
                Console.WriteLine();
            }
        }
        private static void RepeatSearch(List<string> offers)
        {
            List<string> result = offers.GroupBy(word => word)
                        .Where(g => g.Count() > 1)
                        .Select(word => word.Key)
                        .ToList();
            Console.WriteLine(String.Join(", ", result));

            //List<string> repeatWords = new List<string>();
            //repeatWords = offers.Where(word => word.Count() > 1).Select(x => x.Key).ToList();

            //var seen = new HashSet<string>();
            //var duplicates = offers.Where(x => !seen.Add(x));

            //Console.WriteLine(String.Join(", ", duplicates));

        }
        private static void Output()
        {
            foreach (var repeatWord in repeatWords)
            {
                Console.WriteLine(repeatWord);
            }
        }
    }
}