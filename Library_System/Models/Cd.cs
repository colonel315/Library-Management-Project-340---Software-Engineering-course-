﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library_System.Models
{
    public class Cd : ItemBase
    {
        public string Artist { get; set; }
        public string Director { get; set; }
    }
}