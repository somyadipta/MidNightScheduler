using Chronometer;
using SchedulerResearch.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerResearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Warming up...");
            JobRegistration.RegisterJobs();
        }
    }
}
