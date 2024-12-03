namespace minimumInArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 123, 324, 456, 234, 4 };
            int minimum = number[0];
            foreach (var minimal in number)
            {
                if(minimal < minimum)
                {
                    minimum = minimal;
                }

            }
            Console.WriteLine(minimum);           
        }
    }
}
