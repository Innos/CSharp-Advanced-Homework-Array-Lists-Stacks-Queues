using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03ImplementAnArrayBasedStack
{
    using System;

    public class ArrayStack<T> : IEnumerable<T>
    {
        private const int DefaultCapacity = 16;

        private T[] array;

        public ArrayStack(int capacity = DefaultCapacity)
        {
            this.array = new T[capacity];
            this.Count = 0;
            this.Capacity = capacity;
        }

        public int Count { get; private set; }

        public int Capacity { get; private set; }

        public void Push(T element)
        {
            if (this.Count == this.Capacity)
            {
                this.Resize();
            }

            this.array[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            this.Count--;
            var element = this.array[this.Count];
            this.array[this.Count] = default(T);
            return element;
        }

        public T[] ToArray()
        {
            var copyArray = new T[this.Count];
            Array.Copy(this.array, copyArray, this.Count);
            return copyArray.Reverse().ToArray();
        }

        private void Resize()
        {
            this.Capacity = this.Capacity * 2;
            var newArray = new T[this.Capacity];
            Array.Copy(this.array, newArray, this.Count);
            this.array = newArray;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count-1; i >= 0; i--)
            {
                yield return this.array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
