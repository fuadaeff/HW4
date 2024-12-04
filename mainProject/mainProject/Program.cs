using System.Xml;

namespace mainProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Operator;
            while (true)
            {
                Console.WriteLine("Enter operator name:");
                Operator = Console.ReadLine();
                if (Operator.Length >= 3 && Operator.Length <= 15)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Input correctly!");
                }
            }
            string BrandName;
            while (true)
            {
                Console.WriteLine("Enter brand name:");
                BrandName = Console.ReadLine();
                if (BrandName.Length >= 3 && BrandName.Length <= 15)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Input correctly!");
                }
            }
            int size;
            while (true)
            {
                Console.WriteLine("Enter size:");
                size = int.Parse(Console.ReadLine());
                if (size >= 3 && size <= 15)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Input correctly!");
                }
            }
            Console.WriteLine("1.Red");
            Console.WriteLine("2.Black");
            Console.WriteLine("3.Blue");
            int color;
            while (true) {
                Console.WriteLine("Choose color:");
                color = int.Parse(Console.ReadLine());
                if(color != 1 && color != 2 && color != 3)
                {
                    Console.WriteLine("Input Correctly!");
                }
                else
                {
                    break;
                }
            }
            //ilk dusundum swtich le yazmaq lazimdi sonra gordum yeniden daxil etmelidi dogru olmadiqda
            //switch (color) 
            //{
            //    case 1:
            //        Console.WriteLine("Your shoes' color is red.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Your shoes' color is black.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Your shoes' color is blue.");
            //        break;
            //    default:
            //        Console.WriteLine("Choose correctly!");
            //        break;
            //}
            int count;
            while (true)
            {   
                Console.WriteLine("Enter count:");
                count = int.Parse(Console.ReadLine());
                if (count < 1 || count > 99)
                {
                    Console.WriteLine("Input correctly!");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("1.sport");
            Console.WriteLine("2.classic");
            Console.WriteLine("3.old money style");
            int category;
            while (true) {
                Console.WriteLine("Choose category:");
                category = int.Parse(Console.ReadLine());
                if (category != 1 || category != 2 || category != 3)
                {
                    Console.WriteLine("Input correctly!");
                }
                else
                {
                    break;
                }
            }
            int price;
            while (true) {
                Console.WriteLine("enter price:");
                price = int.Parse(Console.ReadLine());
                if(price <= 0)
                {
                    Console.WriteLine("Input correctly!");
                }
                else
                {
                    break;
                }
            }
            int totalPrice;
            totalPrice = count * price;
            Console.WriteLine(totalPrice);
        }
    }
}
