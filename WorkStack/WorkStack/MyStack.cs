using System;

public class MyStack<T>
{
	public int current;
	public T[] arr;
	public MyStack(int size)
	{
		arr = new T[size];
		current = 0;
	}
	public void Push(T val)
	{
		arr[current] = val;
		current ++;
	}
	public T Pop()
	{
		current--;
		ToArray();
		return (arr[current]);
	}
	public T Top()
	{
		return (arr[current - 1]);
	}
	public T[] ToArray()
	{
		T[] mas = new T[current];
		for (int i=0;  i <= current-1;i++)
        {
			mas[i] = arr[i];
		}
		return mas;
	}
	public bool IsEmpty()
	{ 
		
		return true;
	}

}
