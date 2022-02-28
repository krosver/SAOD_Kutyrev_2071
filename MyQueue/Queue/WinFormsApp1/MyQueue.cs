using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    public class MyQueue<T>
    {
        private int currentIn;
        private int currentOut;
        public T[] arr;
        public MyQueue(int size)
        {
            arr = new T[size];
            currentIn = 0;
            currentOut = 0;
        }
        public void Enqueue( T val)
        {

            if (currentIn >= arr.Length)
            {
                currentIn = 0;
                arr[currentIn] = val;
            }
            else
            {
                arr[currentIn] = val;
                currentIn++;
            }
        }
        public T Dequeue()
        {
            T ret = arr[currentOut];
            if (currentOut <= arr.Length)
                currentOut++;
            else
                currentOut = 0;
            return ret;
        }
        public T Peek()
        {
            return (arr[currentOut]);
        }
        public T[] ToArray()
        {
            int current=0;
            int current_mas_out = currentOut;
            if (currentIn > currentOut)
                current = currentIn - currentOut;
            else
            {
                current++;
                while (current_mas_out != currentIn)
                {
                    current++;
                    if (current_mas_out == arr.Length - 1)
                        current_mas_out = 0;
                    else
                        current_mas_out++;
                }
            }
            current_mas_out = currentOut;
            T[] mas = new T[current];
            for (int i = 0; i <= current - 1; i++)
            {
                mas[i] = arr[current_mas_out];
                if (current_mas_out == arr.Length - 1)
                    current_mas_out = 0;
                else
                    current_mas_out++;
            }
            return mas;
        }
    }
}
