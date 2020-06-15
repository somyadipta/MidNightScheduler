using SchedulerResearch.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerResearch.Services
{
   public class SchedulerJobService: ISchedulerJobService
    {
        IEmailNotification _notificationService;
        public SchedulerJobService()
        {
            _notificationService = new EmailNotification();
        }

        public void SendOutMidNightEmails()
        {
            Console.WriteLine("Executing Job: Mid night emails");
            var emailTask = _notificationService.SendEmail("scheduler@mailinator.com", "Scheduler Researcher", "", "Test Email without tracker. It is wise to have this tracked by mail client like SendGrid & use sendgrid api to analyze the read or unread emails", GetRecepientList(), "Test Email");
            emailTask.GetAwaiter().GetResult();
            Console.WriteLine("Completing Job: Mid night emails");
        }

        private IEnumerable<Tuple<string,string>> GetRecepientList()
        {
            var emailIds = new List<Tuple<string, string>>();
            emailIds.Add(new Tuple<string, string>("t1@mailinator.com", "T1"));
            return emailIds;
        }
    }

}
