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
            Console.WriteLine("The test cases to find the maximum value among three values");

            Console.WriteLine("\nTest case 1: ");
            int val1 = GenericClass<int>.MaxValue(100, 50, 75);
            Console.WriteLine($"{val1} is the greatest among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 2: ");
            float val2 = GenericClass<float>.MaxValue(4.5f, 6.5f, 2.5f);
            Console.WriteLine($"{val2} is the greatest among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 3: ");
            string val3 = GenericClass<string>.MaxValue("Peach", "Apple", "Banana");
            Console.WriteLine($"{val3} is the greatest among three number");

            Console.ReadKey();
        }
    }
}
