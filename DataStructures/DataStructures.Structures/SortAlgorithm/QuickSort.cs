using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Structures.SortAlgorithm
{
    public class QuickSort : ISortStrategy
    {
        public void Sort(int[] array)
        {
            QuickSortArray(array, 0, array.Length - 1);
        }

        private static void QuickSortArray(int[] array, int start, int end)
        {
            if (end <= start)
            {
                return;
            }

            int pivot = Partition(array, start, end);

            QuickSortArray(array, start, pivot - 1);
            QuickSortArray(array, pivot + 1, end);

        }

        private static int Partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int i = start - 1;

            for(int j = start; j<= end; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            i++;
            Swap(array, i, end);
            return i;

        }

        private static void Swap(int[] array, int pos1, int pos2)
        {
            int temp = array[pos1];
            array[pos1] = array[pos2];
            array[pos2] = temp;
        }
    }
}
