using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TES.Integration.Eventbritev2.AttendeeObjects
{
    public class Attendee
    {
        public string id { get; set; }

        public DateTime created { get; set; }

        public DateTime changed { get; set; }

        public string ticket_class_id { get; set; }

        public List<AttendeeAnswer> answers { get; set; }

        public List<AttendeeBarcode> barcodes { get; set; }

        public AttendeeProfile profile { get; set; }

        public string event_id { get; set; }

        public string order_id { get; set; }

        public AttendeePromotion promotional_code { get; set; }

        public AttendeeCosts costs { get; set; }
    }
}
