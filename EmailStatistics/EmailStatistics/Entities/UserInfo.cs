using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailStatistics.Entities
{
    public class UserInfo
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private string email;
        public string Email
        {
            get { return email; }
            set 
            { 
                // validate correct email
                if(!value.Contains("@")) throw new ArgumentException("Некорректный email");
                email = value; 
            }
        }
    }
}
