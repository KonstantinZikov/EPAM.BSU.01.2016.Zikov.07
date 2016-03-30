using System.Collections.Generic;

namespace Task2
{
    static public class NumericalSequences
    {
        public static IEnumerable<int> Fibonacci(int maxIndex)
        {
            int last = 0;
            int next = 1;
            for (int i = 0; i < maxIndex; i++)
            {
                next += last;
                last = next - last;
                yield return last;
            }         
        }
    }
}
