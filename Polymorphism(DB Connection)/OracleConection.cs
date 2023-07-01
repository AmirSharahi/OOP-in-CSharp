using System;

namespace ConsoleApp1
{
    public class OracleConection : DBConection
    {
        public OracleConection(string conectionString) : base(conectionString)
        {
        }

        public OracleConection(string conectionString, TimeSpan timeout) : base(conectionString, timeout)
        {
        }
        public override void OpenningConectiom()
        {
            Console.WriteLine("Oracle Conection");
        }

        public override void ClosingConectiom()
        {
            Console.WriteLine("Oracle Conection Ended");
        }
    }
}