using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailStatistics.MailSettings
{
    /// <summary>
    /// Класс для хранения параметров сервера SMTP в событии отправки письма
    /// </summary>
    [Serializable]
    public class EventServerSettings
    {
        #region FIELDS
        private MailServerSettings mailServerSettings;
        private string account;
        private string password;
        #endregion

        #region PROPERTIES
        public MailServerSettings MailServerSettings
        {
            get { return mailServerSettings; }
            set { mailServerSettings = value; }
        }

        public string Account
        {
            get { return account; }
            set { account = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion

        #region CTORS
        public EventServerSettings()
        {

        }
        public EventServerSettings(MailServerSettings mailServerSettings, string account, string password)
        {
            this.mailServerSettings = mailServerSettings;
            this.account = account;
            this.password = password;
        }
        #endregion
    }
}
