namespace Workshop2.Workshop2_Q4
{
    internal class Arrays
    {

        public void displayArray()
        {
            int[] favoriteNumbers = { 9, 6, 3, 2, 5 };

            Console.WriteLine("Original array: ");
            PrintArray(favoriteNumbers);

            Array.Sort(favoriteNumbers);
            Console.WriteLine("\nAfter storing:");
            PrintArray(favoriteNumbers);

            Array.Reverse(favoriteNumbers);
            Console.WriteLine("\nAfter reversing:");
            PrintArray(favoriteNumbers);

            int numberToFind = 3;
            int position = Array.IndexOf(favoriteNumbers, numberToFind);
            Console.WriteLine($"\nPosition of number {numberToFind}: {position}");
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Element [{i}]: {array[i]}");
            }
        }
    }
}
