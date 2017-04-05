using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailStatistics.Entities
{
    public class UserEvent
    {
        public List<string> EmailsList { get; set; }
        public DateTime DateTime { get; set; }
        public string MessageTheme { get; set; }
        public string MessageText { get; set; }
        public string FileName { get; set; }

        public UserEvent(DateTime datetime, string messageTheme, string messageText, string emails, string fileName)
        {
            this.DateTime = datetime;
            this.MessageTheme = messageTheme;
            this.MessageText = messageText;
            this.EmailsList = emails.Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            this.FileName = fileName;
        }
    }
}
