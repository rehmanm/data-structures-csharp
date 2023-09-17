using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Structures.SortAlgorithm
{
    public class MergeSort : ISortStrategy
    {
        public void Sort(int[] array)
        {
            MergeSortArray(array);
        }

        private static void MergeSortArray(int[] array)
        {

            int length = array.Length;
            if (length<=1)
            {
                return;
            }

            int middle = length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[length - middle];

            int j = 0;
            for (int i=0;i<length; i++)
            {
                if (i < middle)
                {
                    leftArray[i] = array[i];
                } else
                {
                    rightArray[j] = array[i];
                    j++;
                }
            }
            MergeSortArray(leftArray);
            MergeSortArray(rightArray);

            Merge(leftArray, rightArray, array);

        }

        private static void Merge(int[] leftArray, int[] rightArray, int[] array)
        {
            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;

            int i = 0, l= 0, r = 0;
            

            while (l < leftSize && r < rightSize)
            {
                if (leftArray[l] < rightArray[r])
                {
                    array[i] = leftArray[l];
                    i++;
                    l++; 
                } else
                {
                    array[i] = rightArray[r];
                    i++;
                    r++;
                }
            }
            while (l < leftSize)
            {
                array[i] = leftArray[l];
                i++;
                l++;
            }
            while (r < rightSize)
            {
                array[i] = rightArray[r];
                i++;
                r++;
            }
        }
    }
}
