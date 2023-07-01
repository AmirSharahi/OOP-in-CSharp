using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IWorkflow
    {
        void Execute();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var workFlowEngine = new WorkFlowEngine(new EmailSender());
            workFlowEngine.WorkFlowListCreator(new VideoUploader());
            workFlowEngine.Run();
            Console.Read();
        }
    }
}
