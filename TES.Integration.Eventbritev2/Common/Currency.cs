using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TES.Integration.Eventbritev2.Common
{
    public class Currency
    {
        public string currency { get; set; }

        public decimal value { get; set; }

        public string display { get; set; }

        public decimal major_value { get; set; }
    }
}
