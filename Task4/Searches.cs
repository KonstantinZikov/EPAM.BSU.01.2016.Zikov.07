using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Task4
{
    static public class Searches
    {
        public static int BinarySearch<T>(IList<T> collection, T element)
        {
            Contract.Requires<ArgumentNullException>(collection != null);

            IComparer<T> comparer = Comparer<T>.Default;
            int low = 0, high = collection.Count - 1;
            while (low <= high)
            {
                int mid = (int)((uint)low + high) / 2;
                switch (comparer.Compare(collection[mid], element))
                {
                    case 1:
                        high = mid - 1;
                        break;
                    case -1:
                        low = mid + 1;
                        if (((uint)low + high) % 2 != 0)
                            low++;
                        break;
                    default:
                        return mid;
                }              
            }
            return -1;
        }
    }
}
