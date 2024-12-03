namespace reverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 23, 93, 141, 58 };
            int[] reversed = new int[numbers.Length];
            int i = numbers.Length - 1;
            int a = 0;
            while (i >= 0)
            {
                reversed[a] = numbers[i];
                i = i - 1;
                a = a + 1;
            }
            foreach (var output in reversed)
            {
                Console.WriteLine(output);
            }
        }
    }
}
