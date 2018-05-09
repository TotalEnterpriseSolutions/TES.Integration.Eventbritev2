using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TES.Integration.Eventbritev2.Common;

namespace TES.Integration.Eventbritev2.AttendeeObjects
{
    public class AttendeeAddress
    {
        public Address home { get; set; }

        public Address ship { get; set; }

        public Address work { get; set; }
    }
}
