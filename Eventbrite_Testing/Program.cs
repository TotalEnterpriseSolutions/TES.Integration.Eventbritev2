using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using TES.Integration.Template.Common;
using TES.Integration.Eventbritev2.Common;
using TES.Integration.Eventbritev2.Events;

namespace Eventbrite_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "3KGA5I5TOM3HVPWRERYH";
            string userid = "27839720379";
            string baseurl = @"https://www.eventbriteapi.com";
            string eventid = "40577566594"; //34352886408
            string orderid = "22";

            try
            {

                Client c = new Client(token, userid, baseurl);
                ServiceResult<Event> resultevent = c.GetEvent(eventid);
                //ServiceResult<OrderResults> orderresults = c.GetOrders(eventid);
                //ServiceResult<DiscountResults> discountresults = c.GetDiscounts(eventid);
                //ServiceResult<string> raweventresult = c.GetEventRaw(eventid); 
                //ServiceResult<EventsResults> eventsresults = c.GetEvents();
                //ServiceResult<string> orderrawresults = c.GetOrderRaw(eventid, orderid);
                //ServiceResult<OrderResults> getorders = c.GetOrders(eventid);
                //ServiceResult<string> getordersrawresult = c.GetOrdersRaw(eventid,orderid);
                //ServiceResult<TicketResults> ticketresults = c.GetTicketsByEvent(eventid);
                if (!resultevent.Success)
                {
                    Console.Write(resultevent.Message);                    
                }
                else
                {
                    //TES.Integration.Eventbritev2.Common.Order order = orderresults.Data.orders.First();
                    //Console.WriteLine(String.Format("Got Order {0} from Event {1}", order.id,order.event_id));
                    //TES.Integration.Eventbritev2.Common.Discount discount = discountresults.Data.discounts.First();
                    //Console.WriteLine(String.Format("Got discount {0} from Event {1}", discount.id, discount.event_id));
                    //Console.WriteLine("Rawevent Length {0}", raweventresult.Data.Length);
                    //Console.WriteLine("Name: {0}, Description: {1}, Status: {2} ", resultevent.Data.name.text, resultevent.Data.description.text, resultevent.Data.status);
                    //Console.WriteLine("Events capacity {0} ", eventsresults.Data.events.Capacity);
                    //Console.WriteLine("Raw Order Data Length {0}", orderrawresults.Data.Length);
                    //Console.WriteLine("Total Orders: {0}", getorders.Data.orders.Count);
                    //Console.WriteLine("Raw Order Length: {0}", getordersrawresult.Data.Length);
                    //Console.WriteLine("Ticket Count: {0}, Ticket Classes {1} and Tick Success {2}", ticketresults.Data.ticket_classes.Count, ticketresults.Data.ticket_classes.Capacity, ticketresults.Success);
                    Console.WriteLine("Description {0}, Name {1}, ID {2}", resultevent.Data.description.text, resultevent.Data.name.text, resultevent.Data.id);


                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.WriteLine("OK");
            Console.Read();

        }
    }
}
