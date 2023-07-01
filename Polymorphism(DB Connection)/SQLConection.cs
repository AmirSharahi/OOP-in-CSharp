using System;

namespace ConsoleApp1
{
    public class SQLConection : DBConection
    {

        public SQLConection(string conectionString) : base(conectionString)
        {
        }

        public SQLConection(string conectionString, TimeSpan timeout) : base(conectionString, timeout)
        {
        }
        public override void OpenningConectiom()
        {
            Console.WriteLine("SQL Conection");
        }

        public override void ClosingConectiom()
        {
            Console.WriteLine("SQL Conection Ended");
        }
    }
}