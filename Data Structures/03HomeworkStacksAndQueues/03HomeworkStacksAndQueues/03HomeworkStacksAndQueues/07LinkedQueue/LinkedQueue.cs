using System;
using System.Collections;
using System.Collections.Generic;

namespace _07LinkedQueue
{
    public class LinkedQueue<T> : IEnumerable<T>
    {
        private class Node<T>
        {
            public Node(T value)
            {
                this.Value = value;
                this.Next = null;
            }

            public T Value { get; private set; }

            public Node<T> Next { get; set; }    
        }

        private Node<T> head;

        private Node<T> tail;  

        public LinkedQueue()
        {
            this.head = null;
            this.tail = null;
        }  

        public int Count { get; private set; }

        public void Enqueue(T element)
        {
            if (this.Count == 0)
            {
                this.head = this.tail = new Node<T>(element);
            }
            else
            {
                var node = new Node<T>(element);
                this.tail.Next = node;
                this.tail = node;
            }
            this.Count++;
        }

        public T Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            var element = this.head.Value;
            this.head = this.head.Next;
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
            var current = this.head;
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
