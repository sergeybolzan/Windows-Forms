﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailStatistics.Entities
{
    public class UserEvent
    {
        public DateTime DateTime { get; set; }
        public string MessageTheme { get; set; }
        public string MessageText { get; set; }

        public UserEvent(DateTime datetime, string messageTheme, string messageText)
        {
            this.DateTime = datetime;
            this.MessageTheme = messageTheme;
            this.MessageText = messageText;
        }
    }
}