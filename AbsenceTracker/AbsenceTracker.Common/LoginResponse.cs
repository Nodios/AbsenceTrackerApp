﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Common
{
    public class LoginResponse
    {
        public string UserName { get; set; }
        public Token Token { get; set; }
    }

}
