using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_API_Forms
{
    internal class ExchangeRate
    {
        public int timestamp { get; set; }

        public Dictionary<string, decimal> rates { get; set; }

        


    }
}
