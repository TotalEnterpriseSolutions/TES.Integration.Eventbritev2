using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TES.Integration.Eventbritev2.Common;

namespace TES.Integration.Eventbritev2.AttendeeObjects
{
    public class AttendeeCosts
    {
        public Currency base_price { get; set; }

        public Currency eventbrite_fee { get; set; }

        public Currency gross { get; set; }

        public Currency payment_fee { get; set; }

        public Currency tax { get; set; }
    }
}
