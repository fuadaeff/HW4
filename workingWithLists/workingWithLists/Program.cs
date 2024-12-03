namespace workingWithLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Console.WriteLine("Eded daxil edin:");
            int a = int.Parse(Console.ReadLine());
            while (a != -1)
            {
                numbers.Add(a);
                Console.WriteLine("Eded daxil edin:");
                a = int.Parse(Console.ReadLine());
            }
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
