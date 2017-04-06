using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailStatistics.MailSettings
{
    public class EventServerSettings
    {
        public MailServerSettings MailServerSettings { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public EventServerSettings(MailServerSettings mailServerSettings, string account, string password)
        {
            this.MailServerSettings = mailServerSettings;
            this.Account = account;
            this.Password = password;
        }
    }
}
