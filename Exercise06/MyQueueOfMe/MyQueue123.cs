using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueOfMe
{
    class MyQueue123
    {
        int top, i, length;
        string[] array;

        public MyQueue123(int digit)
        {
            array = new string[digit];
            top = -1;
        }

        public void EnQueue(string item)
        {
            array[top + 1] = item;
            top++;
            length = top+1;
        }

        public string DeQueue()
        {
            string a = array[i];
            i++;
            length = length - 1;
            return a;
        }

        public string Peek()
        {       
            return array[i];
        }

        public int count()
        {
            return length;
        }
    }
}
