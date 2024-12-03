namespace listOfTheBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = new List<string>();
            int i = 5;
            while (i > 0) { 
                i = i - 1;
                Console.WriteLine("Enter a book name:");
                string input = Console.ReadLine();
                books.Add(input);
            }
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
