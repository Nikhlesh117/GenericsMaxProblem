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
            float num1 = MaximumFloat.MaxFloat(10.5f, 5.5f, 7.5f);
            Console.WriteLine($"{num1} is the greatest among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 2: ");
            float num2 = MaximumFloat.MaxFloat(4.5f, 6.5f, 2.5f);
            Console.WriteLine($"{num2} is the greatest among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 3: ");
            float num3 = MaximumFloat.MaxFloat(1.5f, 3.5f, 5.5f);
            Console.WriteLine($"{num3} is the greatest among three number");

            Console.ReadKey();
        }
    }
}
