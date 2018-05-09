using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TES.Integration.Eventbritev2.Common
{
    public class MultipartDate
    {
        public string timezone { get; set; }

        public DateTime local { get; set; }

        public DateTime utc { get; set; }
    }
}
