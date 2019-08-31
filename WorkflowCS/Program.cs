using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowCS
{
    class Program
    {
        public interface IActivity
        {
             void Execute();
        }

        public class WorkflowEngine {
            private List<IActivity> _activities;


            public void Run()
            {
                for (int i = 0; i < _activities.Count; i++)
                {
                    _activities[i].Execute();
                }


            }
        }
        public class UploadCloudStorage : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("uploding image");

            }
        }
        public class CallWebService : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("casll web service"); 
            }
        }
        public class SendEmail : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("sednig e-mail your video is uploding"); ;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
