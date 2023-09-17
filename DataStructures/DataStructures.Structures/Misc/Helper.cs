namespace DataStructures.Structures.Misc
{
    public static class Helper<T>
    {
        public static void PrintArray(T[] items)
        {
            foreach (T item in items)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
