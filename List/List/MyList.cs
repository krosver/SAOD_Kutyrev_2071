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
            Node<T> elem = FindNode(val);
            if (elem == null)
            {
                throw new Exception("NotFoundElement");
            }
            return elem.val;
        }
        Node<T> FindNode(T val)
        {
            Node<T> elem = first;
            do
            {
                if (elem.val.Equals(val))
                {
                    break;
                }
                else
                {
                    elem = elem.next;
                }
            }
            while (elem != null);
            return elem;
        }

        public T FindByIndex(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException("IndexOutOfRangeException");
            }
            Node<T> elem = ByIndexNode(index);
            return elem.val;
        }
        Node<T> ByIndexNode(int index)
        {
            Node<T> elem = first;
            for (int i = 0; i < index; i++)
            {
                elem = elem.next;
            }
            return elem;
        }


        public void Remove(T val)
        {
            Node<T> elem = FindNode(val);
            if (elem == null)
            {
                throw new Exception("NotFoundElement");
            }
            if (first == elem || last == elem)
            {
                if (first == elem && last == elem)
                {
                    first = null;
                    last = null;
                    elem = null;
                }
                else
                {
                    if (elem == first)
                    {
                        elem.next.prev = null;
                        first = elem.next;
                    }
                    if (elem == last)
                    {
                        elem.prev.next = null;
                        last = elem.prev;
                    }
                }
            }
            else
            {
                elem.prev.next = elem.next;
                elem.next.prev = elem.prev;
            }

            count--;
        }
        public void RemoveByIndex(int index)
        {
            if (index >= count)
            {
                throw new IndexOutOfRangeException("IndexOutOfRangeException");
            }
            Node<T> elem = ByIndexNode(index);
            if (first == elem || last == elem)
            {
                if (first == elem && last == elem)
                {
                    first = null;
                    last = null;
                    elem = null;
                }
                else
                {
                    if (elem == first)
                    {
                        elem.next.prev = null;
                        first = elem.next;
                    }
                    if (elem == last)
                    {
                        elem.prev.next = null;
                        last = elem.prev;
                    }
                }
            }
            else
            {
                elem.prev.next = elem.next;
                elem.next.prev = elem.prev;
            }

            count--;
        }

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
        //public T this[int index]
        //{
        //    set
        //    {
        //        array[index] = value;
        //    }

        //    get
        //    {
        //        return arr[index];
        //    }
        //}


    }
}
