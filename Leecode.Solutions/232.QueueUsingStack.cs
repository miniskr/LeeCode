using System.Collections.Generic;

namespace Leecode.Solutions
{
    /**
     * 232. 用栈实现队列
     * 请你仅使用两个栈实现先入先出队列。队列应当支持一般队列的支持的所有操作（push、pop、peek、empty）：
     * 实现 MyQueue 类：
     *      void push(int x) 将元素 x 推到队列的末尾
     *      int pop() 从队列的开头移除并返回元素
     *      int peek() 返回队列开头的元素
     *      boolean empty() 如果队列为空，返回 true；否则，返回 false
     */
    public class QueueUsingStack<T> : IQueueUsingStack<T>
        where T : class
    {
        private readonly Stack<T> _inStack;
        private readonly Stack<T> _outStack;

        public QueueUsingStack()
        {
            this._inStack = new Stack<T>();
            this._outStack = new Stack<T>();
        }

        public bool Empty() =>
            this._inStack.Count == 0 &&
            this._outStack.Count == 0;

        public T Peek() => this._outStack.Peek();
        public T Pop()
        {
            if (this._outStack.Count == 0)
                this.InToOut();

            return this._outStack.Pop();
        }
        public void Push(T t)
        {
            this._inStack.Push(t);
        }

        private void InToOut()
        {
            while (this._inStack.Count > 0)
            {
                this._outStack.Push(this._inStack.Pop());
            }
        }
    }
}
