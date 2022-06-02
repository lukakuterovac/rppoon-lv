using System;

namespace Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
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

        static void Task2()
        {
            double[] sequence = new double[] { 2, 5, 7, 1, 3};
            NumberSequence numberSequence = new NumberSequence(sequence);
            ISearchStrategy strategy1 = new LinearSearch();
            numberSequence.SetSearchStrategy(strategy1);
            numberSequence.Search(7);
            numberSequence.Search(9);
        }
    }
}