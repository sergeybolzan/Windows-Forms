using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailStatistics.Entities
{
    public class UserInfo
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value)) throw new ArgumentException("Введите имя");
                name = value;
            }
        }


        private string email;
        public string Email
        {
            get { return email; }
            set 
            { 
                string pattern = @"([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}";
                if (!Regex.IsMatch(value, pattern)) throw new ArgumentException("Некорректный email");
                email = value; 
            }
        }
    }
}
