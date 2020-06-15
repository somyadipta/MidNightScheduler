using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerResearch.Services
{
    interface ISchedulerJobService
    {
        void SendOutMidNightEmails();
    }
}
