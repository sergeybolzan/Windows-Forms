using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailStatistics.MailSettings
{
    /// <summary>
    /// Класс для сериализации все параметров сервера в один файл.
    /// </summary>
    [Serializable]
    public class ServerSettings
    {
        #region FIELDS
        private BindingList<MailServerSettings> mailServerSettings;
        private string account;
        private string password;
        #endregion

        #region PROPERTIES
        public BindingList<MailServerSettings> MailServerSettings
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

        #region CTOR
        public ServerSettings()
        {

        }
        #endregion
    }
}
