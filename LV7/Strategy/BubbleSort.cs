using System;

namespace Strategy
{
    class BubbleSort : SortStrategy
    {
        public override void Sort(double[] array)
        {
            int arrayLength = array.Length;
            for (int i = 0; i < arrayLength - 1; i++)
            {
                for (int j = 0; j < arrayLength - 1; j++)
                {
                    if (array[j] > array[j + 1]) Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }
}