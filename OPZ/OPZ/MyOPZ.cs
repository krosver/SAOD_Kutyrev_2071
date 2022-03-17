using System;
using System.Collections.Generic;
using System.Text;

namespace OPZ
{
    public class MyOPZ
    {
        private int current;
        private int priority_first;
        private int priority_second;
        private string[] stack;
        private string[] opz_stack;
        private string[] opz_queue;

        public MyOPZ(string str)
        {
            stack = new string[str.Length];
        }

        public string[] ToOPZ()
        {
            opz_stack = new string[current];
            int inStack = 0;
            int inQueue = 0;
            opz_queue = new string[current];
            int Num;
            for (int s = 0; s<current;s++)
            //foreach (string i in stack)
            {
                string i = stack[s];
                if (int.TryParse(i, out Num)) // проверка на число
                {
                    opz_queue[inQueue] = i;
                    inQueue++;
                }
                else
                {
                    if (i == "(") // вводим скобку
                    {
                        opz_stack[inStack] = i;
                        priority_first = 0;
                        inStack++;
                    }
                    else
                    {
                        priority_second = priority(i); // проверка приоритета
                        if (priority_second > priority_first)
                        {
                            opz_stack[inStack] = i;
                            priority_first = priority_second;
                            inStack++;
                        }
                        else
                        {
                            if (i == ")")
                            {
                                inStack--;
                                while (opz_stack[inStack] != "(")
                                {

                                    opz_queue[inQueue] = opz_stack[inStack];
                                    inQueue++;
                                    inStack--;
                                }
                                //opz_stack[inStack] = i;
                            }
                            else
                            {
                                opz_queue[inQueue] = opz_stack[inStack-1];
                                inQueue++;
                                inStack--;
                                opz_stack[inStack] = i;
                            }
                        }
                    }    


                }
            }
            while (inStack >= 0)
            {
                opz_queue[inQueue] = opz_stack[inStack];
                inQueue++;
                inStack--;
            }
            return opz_queue;
        }
        public void addStack(string val) // начальный массив
        {
            stack[current] = val;
            current++;
        }
        public int priority(string sign) // выставляет приоритеты
        {
            int volume = 0;
            //if (sign == ")")
            //{ volume = 0; }
            if (sign == "+" || sign == "-" )
            { volume = 1; }
            if (sign == "*" || sign == "/")
            { volume = 2; }
            if (sign == "^")
            { volume = 3; }
            //if (sign == "(")
            //{ volume = 4; }

            return volume;
        }
    }
}
