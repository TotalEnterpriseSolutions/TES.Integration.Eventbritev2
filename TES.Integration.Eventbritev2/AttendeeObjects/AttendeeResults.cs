using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TES.Integration.Eventbritev2.Common;

namespace TES.Integration.Eventbritev2.AttendeeObjects
{
    public class AttendeeResults
    {
        public pagination Pagination { get; set; }

        public List<Attendee> attendees { get; set; }
    }
}
