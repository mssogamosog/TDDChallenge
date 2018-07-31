using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TDDChallenge2
{
    public class ArraySort
    {
        public static int[] Sort(int[] array)
        {
            if (array.Length == 0)
            {
                return array;
            }
            else
            {
                Quicksort(array, 0, array.Length - 1);
                return array;
            }
            

        }

        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}
