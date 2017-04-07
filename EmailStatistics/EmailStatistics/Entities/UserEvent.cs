using EmailStatistics.MailSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailStatistics.Entities
{
    [Serializable]
    public class UserEvent
    {
        #region FIELDS
        private DateTime dateTime;
        private string emails;
        private string messageTheme;
        private string messageText;
        private string fileName;
        private EventServerSettings eventServerSettings;
        #endregion

        #region PROPERTIES
        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        public string Emails
        {
            get { return emails; }
            set { emails = value; }
        }

        public string MessageTheme
        {
            get { return messageTheme; }
            set { messageTheme = value; }
        }

        public string MessageText
        {
            get { return messageText; }
            set { messageText = value; }
        }

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        public EventServerSettings EventServerSettings
        {
            get { return eventServerSettings; }
            set { eventServerSettings = value; }
        }
        #endregion

        #region CTORS
        public UserEvent()
        {

        }
        public UserEvent(DateTime datetime, string messageTheme, string messageText, string emails, string fileName, EventServerSettings eventServerSettings)
        {
            this.dateTime = datetime;
            this.messageTheme = messageTheme;
            this.messageText = messageText;
            this.emails = emails;
            this.fileName = fileName;
            this.eventServerSettings = eventServerSettings;
        }
        #endregion
    }
}
