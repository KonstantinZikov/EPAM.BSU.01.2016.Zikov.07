using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
namespace Task5
{
    static public class Sorts
    {
        static public void QuickSort<T>(this IList<T> list, IComparer<T> comparer = null)
        {
            Contract.Requires<ArgumentNullException>(list != null);
            if (comparer == null)
                comparer = Comparer<T>.Default;
            Qsort(list,comparer, 0, list.Count - 1);
        }

        private static void Qsort<T>(this IList<T> list, IComparer<T> comparer, int left, int right)
        {
            int i = left, j = right;
            T middle = list[(left + right) / 2];
            while (i <= j)
            {
                while (comparer.Compare(list[i],middle) < 0) i++;
                while (comparer.Compare(list[j], middle) > 0) j--;
                if (i <= j)
                {
                    T temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
            }
            if (left < j) Qsort(list,comparer, left, j);
            if (i < right) Qsort(list,comparer, i, right);
        }

    }
}
