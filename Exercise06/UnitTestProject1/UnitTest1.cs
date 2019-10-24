using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPop()
        {
            //PUSH 3 ITEM, CHECK COUNT
            MyStack C = new MyStack(3);
            C.Push("4");
            Assert.AreEqual("4", C.Pop());
        }

        [TestMethod]
        public void Count()
        {
            MyStack C = new MyStack(3);
            C.Push("4");
            C.Push("5");
            Assert.AreEqual(2, C.Count());
        }

        [TestMethod]
        public void Peek()
        {
            MyStack C = new MyStack(3);
            C.Push("4");
            C.Push("5");
            Assert.AreEqual("5", C.peek());
        }

        [TestMethod]
        public void clear()
        {
            MyStack C = new MyStack(3);
            C.Push("4");
            C.Push("5");
            C.clear();
            Assert.AreEqual(0, C.Count());
        }
    }
}
