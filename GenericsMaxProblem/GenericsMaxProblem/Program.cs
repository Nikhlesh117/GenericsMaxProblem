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
            Console.WriteLine("The test cases to find the maximum Value");

            Console.WriteLine("\ncase 1: ");
            int[] intarray = { 10, 20, 30, 40, 50 };
            ExtendGenericMethod<int> intobj = new ExtendGenericMethod<int>(intarray);
            intobj.printMax();
            Console.WriteLine("\n--------------");

            Console.WriteLine("case 2: ");
            float[] floatarray = { 10.3f, 20.3f, 30.2f, 40.7f, 50.8f };
            ExtendGenericMethod<float> floatobj = new ExtendGenericMethod<float>(floatarray);
            floatobj.printMax();
            Console.WriteLine("\n--------------");


            Console.WriteLine("case 3: ");
            string[] stringArray = { "Apple", "Peach", "Banana" };
            ExtendGenericMethod<string> stringobj = new ExtendGenericMethod<string>(stringArray);
            stringobj.printMax();

            Console.ReadKey();
        }
    }
}
