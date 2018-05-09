using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TES.Integration.Eventbritev2.Common
{
    public class Discount
    {
        public string id { get; set; }

        public string code { get; set; }

        public Currency amount_off { get; set; }

        public string percent_off { get; set; }

        public List<string> ticket_ids { get; set; }

        public int quantity_available { get; set; }

        public int quantity_sold { get; set; }

        public DateTime start_date { get; set; }

        public DateTime end_date { get; set; }

        public string event_id { get; set; }
    }
}
