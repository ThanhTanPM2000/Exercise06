﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp3
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //S.Push("4");
            //Console.WriteLine("stack");
            //Console.WriteLine("Bạn đã lấy và xóa phần tử {0}", S.Pop());
            //Console.WriteLine("số lượng phần tử trong danh sách {0}", S.Count());
            //Console.WriteLine("=======================================");
            //MyQueue Q = new MyQueue();
            //Q.Enqueue(1);
            //Q.Enqueue(2);
            //Q.Enqueue(3);

            //Console.WriteLine("Queue");
            //Console.WriteLine("Bạn đã lấy và xóa phần tử {0}", Q.Dequeue());
            //Console.WriteLine("Bạn đã lấy và xóa phần tử {0}", Q.Dequeue());
            //Console.WriteLine("số lượng phần tử trong danh sách {0}", Q.count);

            string[] array = { "Mr", "Pham", "Ngoc", "Duy" };



            MyStack S = new MyStack(array.Length);
            for (int z = 0; z < array.Length; z++)
            {
                S.Push(array[z]);
            }
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = S.Pop();
            }


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }

            Console.ReadKey();
        }


    }


}
