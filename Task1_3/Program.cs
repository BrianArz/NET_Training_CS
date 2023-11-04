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
            PrintArray(originalArray);

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

            //Delets extra 0's from new array
            newArray = CutArray(newArray, newArraySize);

            Console.WriteLine("\nNew Array with no duplicates: ");
            PrintArray(newArray);

        }

        /// <summary>
        /// Prints array
        /// </summary>
        /// <param name="array"></param>
        static void PrintArray(int[] array)
        {
            var stringArray = string.Join(",", array);
            Console.WriteLine($"[ {stringArray} ]");
        }

        /// <summary>
        /// Cuts array into specified length
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayLength"></param>
        /// <returns></returns>
        static int[] CutArray(int[] array, int arrayLength)
        {
            var newArray = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                newArray[i] = array[i];
            }
            return newArray;
        }
    }
}