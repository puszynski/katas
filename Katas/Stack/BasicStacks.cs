using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Katas.Stack
{
    public class BasicStacks
    {
        // LIFO collection  —the stack is last-in-first-out; 
        //Each element is added to the top. Each element we remove is removed from the top.
        Stack<int> _stockInt;

        public BasicStacks()
        {
            _stockInt = new Stack<int>();

            //int some data into stack
            _stockInt.Push(100);
            _stockInt.Push(200);
            _stockInt.Push(300);

        }

        public void ReadStack()
        {
            if (_stockInt.Count == 0) //When pop/peek empty collection => runtime will throw an exception !
            {
                Console.WriteLine("Stack is empty");
                return;
            }

            Console.WriteLine($"Stack content({_stockInt.Count}):");

            foreach (var item in _stockInt)
            {
                Console.WriteLine(item);
            }

            //_stockInt.Clear();
        }

        public int GetAndRemoveTopValueFromStack()
        {
            var lastAddedValue = _stockInt.Pop();
            ReadStack(); //100,200
            return lastAddedValue;
        }

        public int GetButNotRemoveTopValueFromStack()
        {
            var lastAddedValue = _stockInt.Peek();
            ReadStack(); //100,200,300
            return lastAddedValue;

        }
    }

    public class BasicStackVol2
    {
        Stack<string> _stack;

        public BasicStackVol2()
        {
            string[] values = { "soo", "doo", "foo" };
            _stack = new Stack<string>(values);              
        }

        public bool IsStackContains()
        {
            return _stack.Contains("foo");
        }
    }
}
