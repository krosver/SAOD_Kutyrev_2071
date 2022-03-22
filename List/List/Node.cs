using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class Node<T>
    {
        T val;
        Node<T> prev;
        Node<T> next;
    }
}
