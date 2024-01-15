namespace GA_Insertion_Sort
{
    internal class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int size = 10; // Change the size of the array as needed
            int minValue = 1; // Change the minimum value as needed
            int maxValue = 100; // Change the maximum value as needed

            // Generate a random integer array of the specified size and range
            int[] randomArray = GenerateRandomIntArray(size, minValue, maxValue);

            Console.WriteLine("Unsorted: " + String.Join(" ", randomArray));

            // Sort the randomArray using the Insertion Sort algorithm
            InsertionSortArray(randomArray);

            Console.WriteLine("Sorted: " + String.Join(" ", randomArray));
        }

        // Generates a random integer array of the specified size and range
        static int[] GenerateRandomIntArray(int size, int minValue, int maxValue)
        {
            if (size <= 0 || minValue > maxValue)
            {
                throw new ArgumentException("Invalid arguments");
            }

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                // Fill the array with random integers within the specified range
                arr[i] = random.Next(minValue, maxValue + 1);
            }
            return arr;
        }

        // Sorts an integer array using the Insertion Sort algorithm
        static void InsertionSortArray(int[] arr)
        {
            int arrayLength = arr.Length;
            for (int currentIndex = 1; currentIndex < arrayLength; currentIndex++)
            {
                int currentValue = arr[currentIndex];
                int previousIndex = currentIndex - 1;

                // Compare and shift elements to insert the current value at the correct position
                while (previousIndex >= 0 && arr[previousIndex] > currentValue)
                {
                    arr[previousIndex + 1] = arr[previousIndex];
                    previousIndex = previousIndex - 1;
                }

                // Insert the current value at the correct position in the sorted portion of the array
                arr[previousIndex + 1] = currentValue;
            }
        }
    }
}
