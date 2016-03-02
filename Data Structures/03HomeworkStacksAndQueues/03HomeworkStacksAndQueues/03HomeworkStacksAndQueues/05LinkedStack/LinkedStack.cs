using System;

namespace _05LinkedStack
{
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedStack<T> : IEnumerable<T>
    {
        private class LinkedStackNode<T>
        {
            public LinkedStackNode(T value, LinkedStackNode<T> next = null )
            {
                this.Value = value;
                this.Next = next;
            } 

            public T Value { get; private set; }

            public LinkedStackNode<T> Next { get; set; } 
        }

        private LinkedStackNode<T> firstElement; 

        public LinkedStack()
        {
            this.Count = 0;
        } 

        public int Count { get; private set; }

        public void Push(T element)
        {
            var newElement = new LinkedStackNode<T>(element,firstElement);
            this.firstElement = newElement;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            var element = this.firstElement.Value;
            this.firstElement = this.firstElement.Next;
            this.Count--;
            return element;
        }

        public T[] ToArray()
        {
            var array = new T[this.Count];
            var enumerator = this.GetEnumerator();
            for (int i = 0; i < this.Count; i++)
            {
                enumerator.MoveNext();
                array[i] = enumerator.Current;
            }

            return array;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = this.firstElement;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
