using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueOfMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            MyQueue123 Q = new MyQueue123(5);
            Q.EnQueue("3");
            Q.EnQueue("4");
            Q.EnQueue("5");
            Q.EnQueue("6");
            Console.WriteLine("số lượng phần tử là ban đầu: {0}", Q.count());
            Console.WriteLine("DeQueue phần tử : {0}",Q.DeQueue());
            Console.WriteLine("số lượng phần tử là {0}", Q.count());
            Console.WriteLine("Peek phần tử {0}", Q.Peek());
            Console.WriteLine("số lượng phần tử là {0}", Q.count());

            Console.ReadLine();
        }
    }
}
