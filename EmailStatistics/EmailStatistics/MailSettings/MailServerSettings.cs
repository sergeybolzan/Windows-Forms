using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailStatistics.MailSettings
{
    [Serializable]
    public class MailServerSettings
    {
        #region FIELDS
        public string name;
        private string address;
        private int port;
        private bool isEnabledSSL;
        #endregion

        #region PROPERTIES
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Port
        {
            get { return port; }
            set { port = value; }
        }

        public bool IsEnabledSSL
        {
            get { return isEnabledSSL; }
            set { isEnabledSSL = value; }
        }
        #endregion

        #region CTORS
        public MailServerSettings()
        {

        }
        public MailServerSettings(string name, string address, int port, bool isEnabledSSL)
        {
            this.name = name;
            this.address = address;
            this.port = port;
            this.isEnabledSSL = isEnabledSSL;
        }
        #endregion
    }
}
