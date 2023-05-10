using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaxProblem
{
    public class ExtendMethod<T> where T : IComparable
    {
        public T[] value;
        public ExtendMethod(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] values)
        {
            Array.Sort(values);
            return values;
        }

        public T MaxValue(T[] value)
        {
            var sortedValues = Sort(this.value);
            return sortedValues[sortedValues.Length - 1];
        }
    }
}
