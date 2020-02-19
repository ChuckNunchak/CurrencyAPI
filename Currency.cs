using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Currency
    {
        public string PreviousUrl { get; set; }

        public Dictionary<string, Valute> Valute { get; set; }
    }
}
