using System;
using System.Collections.Generic;
using System.Text;

namespace OPZ
{
    public class MyOPZ
    {
        private int current;
        private int priority;
        private string[] arr;
        private string[] opz_arr;

        public MyOPZ(string str)
        {
            arr = new string[str.Length];

        }

        public string[] ToOPZ()
        {
            opz_arr = new string[current];
            for (int i = 0; i < current; i++)
            {
                if (arr[i] == "(")
                    Parenthesis();

                if (arr[i] == "+" || arr[i] == "-" || arr[i] == "/" || arr[i] == "*" || arr[i] == "^")
                {
                    string opperant = arr[i];
                    if (opz_arr[i + 1] != "(")
                    {
                        opz_arr[i] = arr[i + 1];
                        opz_arr[i + 1] = opperant;
                        i++;
                    }
                    else
                    {
                        while (opz_arr[i] != ")")
                        {

                        }
                    }
                }
                else
                {
                    opz_arr[i] = arr[i];
                }
            }
            return opz_arr;
        }
        public void Enqueue(string val)
        {
            arr[current] = val;
            current++;
        }
        public void Parenthesis()
        {
            
        }
    }
}
