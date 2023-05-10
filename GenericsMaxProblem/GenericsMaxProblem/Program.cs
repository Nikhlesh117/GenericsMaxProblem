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

            int[] arr = { 100, 200, 300, 500, 400 };
            ExtendMethod<int> generic = new ExtendMethod<int>(arr);
            Console.WriteLine("Maximum value amongst the provided numbers is : {0}", generic.MaxValue(arr));

            Console.ReadKey();
        }
    }
}
