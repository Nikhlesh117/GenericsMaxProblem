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
            Console.WriteLine("The test cases to find the maximum string among three strings");

            Console.WriteLine("\nTest case 1: ");
            string String1 = MaximumString.MaxString("Peach", "Apple", "Banana");
            Console.WriteLine($"{String1} is the greatest among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 2: ");
            string String2 = MaximumString.MaxString("Apple", "Mango", "Limon");
            Console.WriteLine($"{String2} is the greatest among three number");
            Console.WriteLine("\n--------------");

            Console.WriteLine("Test case 3: ");
            string String3 = MaximumString.MaxString("Limon", "Mango", "Orange");
            Console.WriteLine($"{String3} is the greatest among three number");

            Console.ReadKey();
        }
    }
}
