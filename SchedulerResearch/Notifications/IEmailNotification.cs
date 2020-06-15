using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerResearch.Notifications
{
    interface IEmailNotification
    {
        Task SendEmail(string fromEmail, string fromName, string htmlEmailBody, string plaintextEmailBody, IEnumerable<Tuple<string, string>> emailTos, string emailSubject);
    }
}
