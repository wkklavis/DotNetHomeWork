using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    class Node<T>
    {
        public Node<T> Next { get; set; }
        public T data { get; set; }

        public Node(T t)
        {
            Next = null;
            data = t;
        }

    }
}
