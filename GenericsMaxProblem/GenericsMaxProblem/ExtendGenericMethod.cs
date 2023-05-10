using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaxProblem
{
    public class ExtendGenericMethod<T> where T : IComparable
    {
        public T[] value;
        public ExtendGenericMethod(T[] value)
        {
            this.value = value;
        }

        public T[] SortValue(T[] value)
        {
            Array.Sort(value);
            return value;
        }

        public T MaxValue(T[] value)
        {
            var sortedValues = SortValue(this.value);
            return sortedValues[sortedValues.Length - 1];
        }
        public void printMax()
        {
            var maximumValue = MaxValue(this.value);
            Console.WriteLine("Maximum value is: " + maximumValue);
        }
    }
}
