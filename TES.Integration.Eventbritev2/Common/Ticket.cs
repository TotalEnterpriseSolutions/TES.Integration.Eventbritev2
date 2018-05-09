using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TES.Integration.Eventbritev2.Common
{
    public class Ticket
    {
        public string id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public Currency cost { get; set; }

        public Currency fee { get; set; }

        public bool donation { get; set; }

        public bool free { get; set; }

        public int? maximum_quantity { get; set; }

        public int? minimum_quantity { get; set; }

        public int actual_maximum_quantity { get; set; }

        public int actual_minimum_quantity { get; set; }
    }
}
