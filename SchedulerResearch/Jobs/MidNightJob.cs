using Chronometer;
using SchedulerResearch.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SchedulerResearch.Jobs
{
    public class MidNightJob : Job
    {
        public override string Id => nameof(MidNightJob);
        ISchedulerJobService _schedulerJobService;
        public MidNightJob()// Can be injected with a dependency injection framework
        {
            _schedulerJobService = new SchedulerJobService();
        }

        public override void ExecuteImpl(CancellationToken token)
        {
            Console.WriteLine("Initiating Job: Mid night emails");
            _schedulerJobService.SendOutMidNightEmails();
        }

        public override JobSchedule GetSchedule()
        {
            return JobSchedule.AsAbsolute().WithDailyTime(00, 00, 00);
        }
    }
}
