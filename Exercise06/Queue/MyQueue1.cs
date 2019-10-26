using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class MyQueue1
    {
        int top, i;
        string[] array;
        string a;

        public MyQueue1(int item)
        {
            array = new string[item];
            top = -1;
        }

        public void Enqueue(string item)
        {
            array[top + 1] = item;
            top++;
        }

        public string Dequeue()
        {
            string a;
            a = array[top];
            top--;
            i++;
            return a;
        }

        public string Peek()
        {
            return array[i];
        }

        public int count()
        {
            return top + 1;
        }
    }
}
