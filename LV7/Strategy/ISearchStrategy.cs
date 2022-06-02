using System;

namespace Strategy
{
    interface ISearchStrategy
    {
        public abstract int Search(double element, double[] array);
    }
}