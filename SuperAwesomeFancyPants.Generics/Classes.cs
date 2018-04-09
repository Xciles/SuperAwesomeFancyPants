using System;
using System.Collections.Generic;
using System.Text;

namespace SuperAwesomeFancyPants.Generics
{
    public class GenericList<T>
    {
        private class Node
        {
            public Node(T s)
            {
                Data = s;
            }

            public T Data { get; set; }
            public Node Next { get; set; }
        }

        private Node _head = null;

        public GenericList()
        {
        }

        public void AddNode(T x)
        {
            var node = new Node(x);
            node.Next = _head;
            _head = node;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node begin = _head;

            while (begin != null)
            {
                yield return begin.Data;
                begin = begin.Next;
            }
        }

        public T this[int x]
        {
            get
            {
                var current = _head;
                for (int i = 0; i < x; i++)
                {
                    current = current.Next;
                }
                return current.Data;
            }
            set
            {
                var current = _head;
                for (int i = 0; i < x; i++)
                {
                    current = current.Next;
                }

                var node = new Node(value);
                node.Next = current;
                current.Next = node;
            }
        }
    }

    public class Person
    {
        private int _age;
        public string Name { get; set; }
        public string Function { get; set; }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public void SetAge(int value)
        {
            _age = value;
        }
    }
}
