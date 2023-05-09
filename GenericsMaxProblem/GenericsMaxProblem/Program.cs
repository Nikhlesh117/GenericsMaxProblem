using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaxProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The test cases to find the maximum numbe among three numbers");

            Console.WriteLine("\nTest case 1: ");
            int num1 = MaximumInteger.MaxInteger(100, 50, 75);
            Console.WriteLine($"{num1} is the greatest among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 2: ");
            int num2 = MaximumInteger.MaxInteger(40, 60, 20);
            Console.WriteLine($"{num2} is the greatest among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 3: ");
            int num3 = MaximumInteger.MaxInteger(10, 35, 50);
            Console.WriteLine($"{num3} is the greatest among three number");

            Console.ReadKey();
        }
    }
}
