using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerResearch.Notifications
{
    public class EmailNotification: IEmailNotification
    {
        private readonly string APIKey;

        public async Task SendEmail(string fromEmail, string fromName, string htmlEmailBody, string plaintextEmailBody, IEnumerable<Tuple<string, string>> emailTos, string emailSubject)
        {
            var client = new SendGridClient(APIKey);
            var msg = new SendGridMessage();
            msg = new SendGridMessage();
            msg.SetFrom(new EmailAddress(fromEmail, fromName));
            msg.SetSubject(emailSubject);
            if (!string.IsNullOrWhiteSpace(htmlEmailBody))
                msg.AddContent(MimeType.Html, htmlEmailBody);
            else
                msg.AddContent(MimeType.Text, plaintextEmailBody);

            emailTos.ToList().ForEach((receipient) =>
            {
                msg.AddTo(new EmailAddress(receipient.Item1, receipient.Item2));
            });
            await client.SendEmailAsync(msg);
        }
    }
}
