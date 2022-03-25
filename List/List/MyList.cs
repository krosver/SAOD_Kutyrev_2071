using System;
using System.Collections.Generic;
using System.Text;

namespace List
{
    class MyList<T>
    {
        Node<T> first;
        Node<T> last;
        int count;
        T[] arr; 
        Node<T> current;
        public void Append(T val)
        {
            current = new Node<T>();
            current.val = val;
            if (first == null && last == null)
            {
                first = current;
                last = current;
            }
            else
            {
                current.prev = last;
                last.next = current;
                last = current;
            }
            count++;
        }
        public void Prepend(T val)
        {
            current = new Node<T>();
            current.val = val;
            if (first == null && last == null)
            {
                first = current;
                last = current;
            }
            else
            {
                current.next = first;
                first.prev = current;
                first = current;
            }
            count++;
        }
        public void Insert(T val)
        {
            current = new Node<T>();
            Node<T> elem = new Node<T>(); 
            current = first;
            if (first == null && last == null)
            {
                first = current;
                last = current;
            }
            else
            {
                for (int i = 0; i < count/2; i++)
                {
                    current = current.next;
                }
                elem.prev = current.prev;
                elem.next = current;
                elem.val = val;
                current.prev.next = elem;
                current.prev = elem;

            }
            count++;

        }
        public T Find(T val)
        {
            Node<T> elem = first;
            for (int i = 0; i < count; i++)
            {
                //if (elem.val == val)
                //{

                //}
            }
            return val;
        }
        //T FindByIndex(int index)
        //{
        //}
        //bool Remove(T val)
        //{
        //}
        //bool RemoveByIndex(int index)
        //{
        //}

        public T[] ToArray()
        {
            arr = new T[count];
            Node<T> elem = first; 
            for (int i = 0; i < count; i++)
            {
                arr[i] = elem.val;
                elem = elem.next;
            }
            return arr;
        }

    }
}
