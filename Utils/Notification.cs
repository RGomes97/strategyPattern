using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estudo_strategy.Utils
{
    public class Notification
    {
        public string Key { get; }
        public string Message { get; }

        public Notification(string key, string message)
        {
            Key = key;
            Message = message;
        }
    }
}
