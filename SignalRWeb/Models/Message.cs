﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRWeb.Models
{
    public class Message
    {
        public string Type { get; set; }
        public string Payload { get; set; }
    }
}
