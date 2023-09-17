namespace DataStructures.Structures.Misc
{
    public static class FindNthItem
    {
        public static int LargestItem(int[] array, int n)
        {
            if (n > array.Length)
            {
                throw new Exception($"Invalid position {n}");
            }

            int maxNumber = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int currentMax = int.MinValue;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] >= maxNumber)
                    {
                        continue;
                    }
                    if (array[j] > currentMax)
                    {
                        currentMax = array[j];
                    }
                }

                maxNumber = currentMax;
            }
            return maxNumber;
        }

        public static int SmallestItem(int[] array, int n)
        {
            if (n > array.Length)
            {
                throw new Exception($"Invalid position {n}");
            }

            int minNumber = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int currentMin = int.MaxValue;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] <= minNumber)
                    {
                        continue;
                    }
                    if (array[j] < currentMin)
                    {
                        currentMin = array[j];
                    }
                }

                minNumber = currentMin;
            }
            return minNumber;
        }
    }
}
