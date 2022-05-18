namespace Iterator
{
    interface IAbstractIterator
    {
        Product First();
        Product Next();
        bool IsDone { get; }
        Product Current { get; }
    }
}