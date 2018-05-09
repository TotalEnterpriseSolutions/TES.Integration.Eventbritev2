using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TES.Integration.Eventbritev2.AttendeeObjects;
using TES.Integration.Eventbritev2.Events;
using TES.Integration.Template.Common;

namespace TES.Integration.Eventbritev2.Common
{
    public class Client
    {
        private HttpClient client;

        public Client(string token, string eb_user, string baseURL)
        {
            this._token = token;
            this._eb_user = eb_user;
            this._baseURL = baseURL;
        }

        //public ServiceResult<AttendeeResults> GetAttendees(string orderId)
        //{
        //    try
        //    {
        //        this.GetClient();
        //        string address = $"/events/{orderId}/attendees/?token={this._token}&expand=promotional_code";
        //        //string str2 = this.client.DownloadString(address);
        //        client.BaseAddress = new Uri(this._baseURL);
        //        HttpResponseMessage response = client.GetAsync(address).Result;
        //        var responseString = response.Content.ReadAsStringAsync().Result;
        //        JsonSerializerSettings settings = new JsonSerializerSettings();
        //        settings.NullValueHandling = NullValueHandling.Include;
        //        AttendeeResults results = JsonConvert.DeserializeObject<AttendeeResults>(responseString, settings);
        //        AttendeeResults results2 = new AttendeeResults();
        //        if (results.Pagination.page_count > 1)
        //        {
        //            for (int i = 0; i < results.Pagination.page_count; i++)
        //            {
        //                string str3 = $"{this._baseURL}/events/{orderId}/attendees/?token={this._token}&page={i + 1}&expand=promotional_code";
        //                AttendeeResults results3 = JsonConvert.DeserializeObject<AttendeeResults>(this.client.DownloadString(str3), settings);
        //                if (results2.attendees == null)
        //                {
        //                    results2.attendees = new List<Attendee>();
        //                }
        //                if (results3.attendees != null)
        //                {
        //                    results2.attendees.AddRange(results3.attendees);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            results2.attendees = results.attendees;
        //        }
        //        return new ServiceResult<AttendeeResults>(true, results2, "");
        //    }
        //    catch (Exception exception)
        //    {
        //        this.GetClient();
        //        return new ServiceResult<AttendeeResults>(false, new AttendeeResults(), exception.Message);
        //    }
        //}

        private HttpClient GetClient()
        {
            if (this.client == null)
            {
                this.client = new HttpClient();
                return this.client;
            }
            return this.client;
        }

        //public ServiceResult<DiscountResults> GetDiscounts(string eventId)
        //{
        //    try
        //    {
        //        this.GetClient();
        //        string address = $"{this._baseURL}/events/{eventId}/discounts/?token={this._token}";
        //        string str2 = this.client.DownloadString(address);
        //        JsonSerializerSettings settings = new JsonSerializerSettings();
        //        settings.NullValueHandling = NullValueHandling.Include;
        //        DiscountResults results = JsonConvert.DeserializeObject<DiscountResults>(str2, settings);
        //        DiscountResults results2 = new DiscountResults();
        //        if (results.Pagination.page_count > 1)
        //        {
        //            for (int i = 0; i < results.Pagination.page_count; i++)
        //            {
        //                string str3 = $"{this._baseURL}/events/{eventId}/discounts/?token={this._token}&page={i + 1}";
        //                DiscountResults results3 = JsonConvert.DeserializeObject<DiscountResults>(this.client.DownloadString(str3), settings);
        //                if (results2.discounts == null)
        //                {
        //                    results2.discounts = new List<Discount>();
        //                }
        //                if (results3.discounts != null)
        //                {
        //                    results2.discounts.AddRange(results3.discounts);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            results2.discounts = results.discounts;
        //        }
        //        return new ServiceResult<DiscountResults>(true, results2, "");
        //    }
        //    catch (Exception exception)
        //    {
        //        this.GetClient();
        //        return new ServiceResult<DiscountResults>(false, new DiscountResults(), exception.Message);
        //    }
        //}

        public ServiceResult<Event> GetEvent(string eventId)
        {
            try
            {
                //this.GetClient();
                var httpClient = new HttpClient();
                //string address = $"/v3/events/{eventId}/?token={this._token}";
                var url = "/v3/events/34352886408/?token=3KGA5I5TOM3HVPWRERYH";
                //string str2 = this.client.DownloadString(address);
                //httpClient.BaseAddress = new Uri(this._baseURL);
                httpClient.BaseAddress = new Uri("https://www.eventbriteapi.com");
                HttpResponseMessage response = httpClient.GetAsync(url).Result;
                var responseString = response.Content.ReadAsStringAsync().Result;
                return new ServiceResult<Event>(true, JsonConvert.DeserializeObject<Event>(responseString), "");
            }
            catch (Exception exception)
            {
                this.GetClient();
                return new ServiceResult<Event>(false, new Event(), exception.Message);
            }
        }

        //public ServiceResult<Event> GetEvent(string eventId, int length)
        //{
        //    try
        //    {
        //        this.GetClient();
        //        string address = $"{this._baseURL}/events/{eventId}/?token={this._token}";
        //        string str2 = this.client.DownloadString(address);
        //        ServiceResult<Event> result = new ServiceResult<Event>(true, JsonConvert.DeserializeObject<Event>(str2), "");
        //        result.Data.description.text = this.Truncate(result.Data.description.text, length);
        //        return result;
        //    }
        //    catch (Exception exception)
        //    {
        //        this.GetClient();
        //        return new ServiceResult<Event>(false, new Event(), exception.Message);
        //    }
        //}

        //public ServiceResult<string> GetEventRaw(string eventId)
        //{
        //    try
        //    {
        //        this.GetClient();
        //        string address = $"{this._baseURL}/events/{eventId}/?token={this._token}";
        //        return new ServiceResult<string>(true, this.client.DownloadString(address), "");
        //    }
        //    catch (Exception exception)
        //    {
        //        this.GetClient();
        //        return new ServiceResult<string>(false, exception.Message, exception.Message);
        //    }
        //}

        //public ServiceResult<EventsResults> GetEvents()
        //{
        //    try
        //    {
        //        this.GetClient();
        //        string address = $"{this._baseURL}/users/{this._eb_user}/events/?token={this._token}";
        //        string str2 = this.client.DownloadString(address);
        //        ServiceResult<EventsResults> result = new ServiceResult<EventsResults>(true, JsonConvert.DeserializeObject<EventsResults>(str2), "");
        //        EventsResults results = new EventsResults();
        //        if (result.Data.Pagination.page_count > 1)
        //        {
        //            for (int i = 0; i < result.Data.Pagination.page_count; i++)
        //            {
        //                string str3 = $"{this._baseURL}/users/{this._eb_user}/events/?token={this._token}&page={i + 1}";
        //                string str4 = this.client.DownloadString(str3);
        //                ServiceResult<EventsResults> result2 = new ServiceResult<EventsResults>(true, JsonConvert.DeserializeObject<EventsResults>(str4), "");
        //                if (results.events == null)
        //                {
        //                    results.events = new List<Event>();
        //                }
        //                if (result2.Data.events != null)
        //                {
        //                    results.events.AddRange(result2.Data.events);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            results.events = result.Data.events;
        //        }
        //        return new ServiceResult<EventsResults>(true, results, "");
        //    }
        //    catch (Exception exception)
        //    {
        //        this.GetClient();
        //        return new ServiceResult<EventsResults>(false, new EventsResults(), exception.Message);
        //    }
        //}

        //public ServiceResult<EventsResults> GetEvents(int length)
        //{
        //    try
        //    {
        //        this.GetClient();
        //        string address = $"{this._baseURL}/users/{this._eb_user}/events/?token={this._token}";
        //        string str2 = this.client.DownloadString(address);
        //        ServiceResult<EventsResults> result = new ServiceResult<EventsResults>(true, JsonConvert.DeserializeObject<EventsResults>(str2), "");
        //        EventsResults results = new EventsResults();
        //        if (result.Data.Pagination.page_count > 1)
        //        {
        //            for (int i = 0; i < result.Data.Pagination.page_count; i++)
        //            {
        //                string str3 = $"{this._baseURL}/users/{this._eb_user}/events/?token={this._token}&page={i + 1}";
        //                string str4 = this.client.DownloadString(str3);
        //                ServiceResult<EventsResults> result2 = new ServiceResult<EventsResults>(true, JsonConvert.DeserializeObject<EventsResults>(str4), "");
        //                if (results.events == null)
        //                {
        //                    results.events = new List<Event>();
        //                }
        //                if (result2.Data.events != null)
        //                {
        //                    results.events.AddRange(result2.Data.events);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            results.events = result.Data.events;
        //        }
        //        foreach (Event event2 in results.events)
        //        {
        //            event2.description.text = this.Truncate(event2.description.text, length);
        //        }
        //        return new ServiceResult<EventsResults>(true, results, "");
        //    }
        //    catch (Exception exception)
        //    {
        //        this.GetClient();
        //        return new ServiceResult<EventsResults>(false, new EventsResults(), exception.Message);
        //    }
        //}

        //public ServiceResult<string> GetOrderRaw(string eventId, string orderId)
        //{
        //    try
        //    {
        //        this.GetClient();
        //        string address = $"{this._baseURL}/events/{eventId}/orders/?token={this._token}&expand=attendees";
        //        string str2 = this.client.DownloadString(address);
        //        string str3 = "";
        //        OrderResults results = JsonConvert.DeserializeObject<OrderResults>(str2);
        //        OrderResults results2 = new OrderResults
        //        {
        //            Pagination = results.Pagination
        //        };
        //        if (results.Pagination.page_count > 1)
        //        {
        //            for (int i = 0; i < results.Pagination.page_count; i++)
        //            {
        //                string str4 = $"{this._baseURL}/events/{eventId}/orders/?token={this._token}&page={i + 1}&expand=attendees";
        //                OrderResults results3 = JsonConvert.DeserializeObject<OrderResults>(this.client.DownloadString(str4));
        //                foreach (Order order in results3.orders)
        //                {
        //                    if (order.id == orderId)
        //                    {
        //                        str3 = JsonConvert.SerializeObject(order);
        //                        return new ServiceResult<string>(true, str3, "");
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            foreach (Order order in results.orders)
        //            {
        //                if (order.id == orderId)
        //                {
        //                    return new ServiceResult<string>(true, JsonConvert.SerializeObject(order), "");
        //                }
        //            }
        //        }
        //        return new ServiceResult<string>(true, "Error", "");
        //    }
        //    catch (Exception exception)
        //    {
        //        this.GetClient();
        //        return new ServiceResult<string>(false, exception.Message, exception.Message);
        //    }
        //}

        //public ServiceResult<OrderResults> GetOrders(string eventId)
        //{
        //    try
        //    {
        //        this.GetClient();
        //        string address = $"{this._baseURL}/events/{eventId}/orders/?token={this._token}&expand=attendees.promotional_code";
        //        OrderResults results = JsonConvert.DeserializeObject<OrderResults>(this.client.DownloadString(address));
        //        OrderResults results2 = new OrderResults
        //        {
        //            Pagination = results.Pagination
        //        };
        //        if (results.Pagination.page_count > 1)
        //        {
        //            for (int i = 0; i < results.Pagination.page_count; i++)
        //            {
        //                string str3 = $"{this._baseURL}/events/{eventId}/orders/?token={this._token}&page={i + 1}&expand=attendees.promotional_code";
        //                OrderResults results3 = JsonConvert.DeserializeObject<OrderResults>(this.client.DownloadString(str3));
        //                if (results2.orders == null)
        //                {
        //                    results2.orders = new List<Order>();
        //                }
        //                if (results3.orders != null)
        //                {
        //                    results2.orders.AddRange(results3.orders);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            results2.orders = results.orders;
        //        }
        //        return new ServiceResult<OrderResults>(true, results2, "");
        //    }
        //    catch (Exception exception)
        //    {
        //        this.GetClient();
        //        return new ServiceResult<OrderResults>(false, new OrderResults(), exception.Message);
        //    }
        //}

        //public ServiceResult<string> GetOrdersRaw(string eventId, string orderId)
        //{
        //    try
        //    {
        //        this.GetClient();
        //        string address = $"{this._baseURL}/events/{eventId}/orders/?token={this._token}&expand=attendees";
        //        string str2 = this.client.DownloadString(address);
        //        string str3 = "";
        //        string str4 = "";
        //        OrderResults results = JsonConvert.DeserializeObject<OrderResults>(str2);
        //        OrderResults results2 = new OrderResults
        //        {
        //            Pagination = results.Pagination
        //        };
        //        if (results.Pagination.page_count > 1)
        //        {
        //            for (int i = 0; i < results.Pagination.page_count; i++)
        //            {
        //                string str5 = $"{this._baseURL}/events/{eventId}/orders/?token={this._token}&page={i + 1}&expand=attendees";
        //                OrderResults results3 = JsonConvert.DeserializeObject<OrderResults>(this.client.DownloadString(str5));
        //                foreach (Order order in results3.orders)
        //                {
        //                    str3 = JsonConvert.SerializeObject(order);
        //                    str4 = str4 + Environment.NewLine + str3;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            foreach (Order order in results.orders)
        //            {
        //                if (order.id == orderId)
        //                {
        //                    return new ServiceResult<string>(true, JsonConvert.SerializeObject(order), "");
        //                }
        //            }
        //        }
        //        return new ServiceResult<string>(true, str4, "");
        //    }
        //    catch (Exception exception)
        //    {
        //        this.GetClient();
        //        return new ServiceResult<string>(false, exception.Message, exception.Message);
        //    }
        //}

        //public ServiceResult<TicketResults> GetTicketsByEvent(string eventId)
        //{
        //    try
        //    {
        //        this.GetClient();
        //        string address = $"{this._baseURL}/events/{eventId}/ticket_classes/?token={this._token}";
        //        TicketResults results = JsonConvert.DeserializeObject<TicketResults>(this.client.DownloadString(address));
        //        TicketResults results2 = new TicketResults();
        //        if (results.Pagination.page_count > 1)
        //        {
        //            for (int i = 0; i < results.Pagination.page_count; i++)
        //            {
        //                string str3 = $"{this._baseURL}/events/{eventId}/ticket_classes/?token={this._token}";
        //                TicketResults results3 = JsonConvert.DeserializeObject<TicketResults>(this.client.DownloadString(str3));
        //                if (results2.ticket_classes == null)
        //                {
        //                    results2.ticket_classes = new List<Ticket>();
        //                }
        //                if (results3.ticket_classes != null)
        //                {
        //                    results2.ticket_classes.AddRange(results3.ticket_classes);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            results2.ticket_classes = results.ticket_classes;
        //        }
        //        foreach (Ticket ticket in results2.ticket_classes)
        //        {
        //            if (!ticket.minimum_quantity.HasValue)
        //            {
        //                ticket.actual_minimum_quantity = 0;
        //            }
        //            else
        //            {
        //                ticket.actual_minimum_quantity = ticket.minimum_quantity.Value;
        //            }
        //            if (!ticket.maximum_quantity.HasValue)
        //            {
        //                ticket.actual_maximum_quantity = 0;
        //            }
        //            else
        //            {
        //                ticket.actual_maximum_quantity = ticket.maximum_quantity.Value;
        //            }
        //        }
        //        return new ServiceResult<TicketResults>(true, results2, "");
        //    }
        //    catch (Exception exception)
        //    {
        //        this.GetClient();
        //        return new ServiceResult<TicketResults>(false, new TicketResults(), exception.Message);
        //    }
        //}

        private string Truncate(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }
            return ((value.Length <= maxLength) ? value : value.Substring(0, maxLength));
        }

        public string _token { get; set; }

        public string _eb_user { get; set; }

        public string _baseURL { get; set; }
    }
}
