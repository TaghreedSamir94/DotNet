﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_03.Q3
{
    internal interface INotificationService
    {
        void SendNotification(string Recipient, string Msg);
    }
}