using System;

namespace ConsoleApp1
{
    public class EmailSender : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email");
        }
    }
}