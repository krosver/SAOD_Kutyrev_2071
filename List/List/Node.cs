using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class Node<T>
    {
        public T val;
        public Node<T> prev;
        public Node<T> next;
    }
}
