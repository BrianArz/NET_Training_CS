namespace Task1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size");
            var arraySize = int.Parse(Console.ReadLine());

            var originalArray = new int[arraySize];
            var newArray = new int[arraySize];
            var newArraySize = 0;

            Console.WriteLine();
            for (int index = 0; index < arraySize; index++)
            {
                Console.WriteLine($"Enter array digit No. {(index + 1)}");
                originalArray[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nOriginal Array: ");
            PrintArray(originalArray, arraySize);

            for (int i = 0; i < arraySize; i++)
            {
                var isDuplicate = false;
                for (int j = 0; j < newArraySize; j++)
                {
                    if (originalArray[i] == newArray[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    newArray[newArraySize++] = originalArray[i];
                }
            }

            Console.WriteLine("\nNew Array with no duplicates: ");
            PrintArray(newArray, newArraySize);

        }

        /// <summary>
        /// Print specified length of a given array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayLength"></param>
        static void PrintArray(int[] array, int arrayLength)
        {
            var newArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                newArray[i] = array[i];
            }
            var stringArray = string.Join(",", newArray);
            Console.WriteLine($"[ {stringArray} ]");
        }
    }
}