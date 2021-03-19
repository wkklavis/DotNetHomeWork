using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            head = tail = null;
        }
        public Node<T> Head { get => head; }
        public void Add(T t)
        {
            Node<T> node = new Node<T>(t);
            if (tail == null) { head = tail = node; }
            else
            {
                tail.Next = node;
                tail = node;
            }
        }
        public void ForEvery(Action<T> action)
        {
            Node<T> p = head;
            while (p != null) { action(p.data);p = p.Next; }
        }


    }
}
