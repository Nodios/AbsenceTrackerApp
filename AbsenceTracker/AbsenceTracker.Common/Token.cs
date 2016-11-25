using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsenceTracker.Common
{
    public class Token
    {
        public string TokenValue { get; internal set; }
        public double ExpirationTime { get; internal set; }
    }

}
