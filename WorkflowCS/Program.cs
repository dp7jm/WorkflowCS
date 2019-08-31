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
             void ExecuteA();
        }

        public class WorkflowEngine {
            private List<IActivity> _activies;


            public void Run()
            {   



            }
        }
        public class UploadCloudStorage : IActivity
        {
            public void ExecuteA()
            {
                Console.WriteLine("uploding image");

            }
        }
        public class CallWebService : IActivity
        {
            public void ExecuteA()
            {
                Console.WriteLine("casll web service"); 
            }
        }
        public class SendEmail : IActivity
        {
            public void ExecuteA()
            {
                Console.WriteLine("sednig e-mail your video is uploding"); ;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
