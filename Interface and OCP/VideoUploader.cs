using System;

namespace ConsoleApp1
{
    public class VideoUploader : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Uploading Video to Cloud Storage");
        }
    }
}