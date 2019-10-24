using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp3
{
    public class MyStack
    {
        int top=-1;
        string[] array;
        public MyStack(int size)
        {
            array = new string[size];
        }
        public void Push(string item)
        {
            array[top+1] = item;
            top++;
        }

        public string Pop()
        {
            string a = array[top];
            top--;
            return a;
        }

        public string peek()
        {
            return array[top];
        }

        public int Count()
        {
            return top +1;
        }

        public void clear()
        {           
            top = -1;
        }

    }
}
