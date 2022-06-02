using System;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        static void Task1()
        {
            double[] sequence = new double[] { 2, 5, 7, 1, 3};
            NumberSequence numberSequence = new NumberSequence(sequence);
            SortStrategy strategy1 = new BubbleSort();
            numberSequence.SetSortStrategy(strategy1);
            Console.WriteLine(numberSequence);
            numberSequence.Sort();
            Console.WriteLine(numberSequence);
        }
    }
}