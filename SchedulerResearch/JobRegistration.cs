using Chronometer;
using SchedulerResearch.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerResearch
{
    public static class JobRegistration
    {
        public static void RegisterJobs()
        {
            Console.WriteLine("Registering Jobs");
            JobManager.Current.Initialize();
            JobManager.Current.LoadJobInstance(new MidNightJob());
            JobManager.Current.Start(); //start!
        }
    }
}
