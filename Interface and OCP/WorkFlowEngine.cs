using System.Collections.Generic;

namespace ConsoleApp1
{
    public class WorkFlowEngine
    {
        private IList<IWorkflow> _workFlowsList { get; }

        public WorkFlowEngine(IWorkflow workflow)
        {
            _workFlowsList = new List<IWorkflow>();
            _workFlowsList.Add(workflow);
        }

        public void WorkFlowListCreator(IWorkflow workflow)
        {
            _workFlowsList.Add(workflow);
        }

        public void Run()
        {
            foreach (var workflow in _workFlowsList)
                workflow.Execute();
        }
    }
}