using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
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
            string eventid = "34352886408";

            try
            {

                //Client c = new Client(token, userid, baseurl);
                //ServiceResult<Event> resultevent = c.GetEvent(eventid);
                //if (!resultevent.Success)
                //{
                //    Console.Write(resultevent.Message);
                //}
                //else
                //{
                //    Console.WriteLine(String.Format("Got Event {0} called {1}", resultevent.Data.id, resultevent.Data.description));
                //}

                #region
                using (var httpClient = new HttpClient())
                {
                    //var url = "/v3/events/34352886408/?token=3KGA5I5TOM3HVPWRERYH";
                    var url = "/v3/tlscheck/?token=3KGA5I5TOM3HVPWRERYH";
                    httpClient.BaseAddress = new Uri("https://www.eventbriteapi.com");                    
                    HttpResponseMessage response = httpClient.GetAsync(url).Result;                    
                    var responseString = response.Content.ReadAsStringAsync().Result;

                    Console.WriteLine(responseString);
                }
                #endregion
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
