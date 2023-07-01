using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Video 6
    public class Person
    {
        public string Name;

        public void introduce(String To)
        {
            Console.WriteLine("Hi {0} i am {1}", To, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("ali");
            person.introduce("amir");
        }
    }
}