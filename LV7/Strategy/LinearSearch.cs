using System;

namespace Strategy
{
    class LinearSearch : ISearchStrategy
    {
        public int Search(double element, double[] array)
        {
            int arrayLength = array.Length;
            for (int index = 0; index < arrayLength; index++)
            {
                if (array[index] == element)
                {
                    Console.WriteLine($"Found element at index {index}.");
                    return index;
                }
            }
            Console.WriteLine("Element not found.");
            return -1;
        }
    }
}