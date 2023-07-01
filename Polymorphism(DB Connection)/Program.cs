  namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sqlConection = new SQLConection("Something");
            sqlConection.OpenningConectiom();
            var oracleConection = new OracleConection("SomethingElse");
            oracleConection.OpenningConectiom();
            oracleConection.ClosingConectiom();
        }
    }
}
