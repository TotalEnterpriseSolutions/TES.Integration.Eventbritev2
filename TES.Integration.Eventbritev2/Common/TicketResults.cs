using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TES.Integration.Eventbritev2.Common
{
    public class TicketResults
    {
        public pagination Pagination { get; set; }

        public List<Ticket> ticket_classes { get; set; }
    }
}
