using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class stack
    {
        private List<object> _mainList { get; } = new List<object>();

        public void Push(object obj)
        {
            if (obj != null)
            {
                _mainList.Add(obj);
            }
        }

        public object Pop()
        {
            if (_mainList.Count > 0)
            {
                var last = _mainList[_mainList.Count - 1];
                _mainList.Remove(_mainList[_mainList.Count - 1]);
                return last;
            }
            return "First Push an Object To Stack!";
        }

        public void Clear()
        {
            _mainList.Clear();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack1 = new stack();
            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            Console.WriteLine(stack1.Pop());
            stack1.Clear();
        }
    }
}
