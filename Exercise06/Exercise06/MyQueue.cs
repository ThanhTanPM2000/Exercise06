﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp3
{
    class MyQueue
    {
        int top, i;
        string[] array;
        string a;

        public MyQueue(int item)
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
            i++;
            a = array[i];
            top--;
            return a;
        }

        public string Peek()
        {
            return array[i];
        }

        public int count()
        {
            return top +1;
        }

    }
}
