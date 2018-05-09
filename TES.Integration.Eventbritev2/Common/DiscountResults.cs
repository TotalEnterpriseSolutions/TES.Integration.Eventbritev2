using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TES.Integration.Eventbritev2.Common
{
    public class DiscountResults
    {
        public pagination Pagination { get; set; }

        public List<Discount> discounts { get; set; }
    }
}
