namespace workingWithArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            string name;
            int i = 5;
            int index = 0;
            while (i > 0)
            {
                Console.WriteLine("Ad daxil edin:");
                name = Console.ReadLine();
                names[index] = name;
                index = index + 1;
                i = i - 1;

            }
            foreach (string output in names) {
                Console.WriteLine(output);
            
            }

        }
    }
}
