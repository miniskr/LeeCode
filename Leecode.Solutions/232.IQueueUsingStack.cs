namespace Leecode.Solutions
{
    public interface IQueueUsingStack<T>
        where T : class
    {
        void Push(T t);
        T Pop();
        T Peek();
        bool Empty();
    }
}
