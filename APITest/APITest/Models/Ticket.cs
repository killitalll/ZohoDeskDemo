using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace APITest.Models
{
    public class Ticket
    {
        public class Account
        {
            public string accountName { get; set; }
            public string website { get; set; }
            public string id { get; set; }
        }

        public class Contact
        {
            public object firstName { get; set; }
            public string lastName { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public object type { get; set; }
            public string accountId { get; set; }
            public string id { get; set; }
        }

        public class Tickets
        {
            public string modifiedTime { get; set; }
            public string ticketNumber { get; set; }
            public string subCategory { get; set; }
            public string subject { get; set; }
            public string dueDate { get; set; }
            public string departmentId { get; set; }
            public string channel { get; set; }
            public string description { get; set; }
            public object resolution { get; set; }
            public object closedTime { get; set; }
            public string approvalCount { get; set; }
            public string timeEntryCount { get; set; }
            public string createdTime { get; set; }
            public string id { get; set; }
            public string email { get; set; }
            public string customerResponseTime { get; set; }
            public object product { get; set; }
            public object productId { get; set; }
            public string contactId { get; set; }
            public string threadCount { get; set; }
            public string priority { get; set; }
            public object classification { get; set; }
            public string assigneeId { get; set; }
            public string commentCount { get; set; }
            public string taskCount { get; set; }
            public string phone { get; set; }
            public string attachmentCount { get; set; }
            public string category { get; set; }
            public string status { get; set; }
        }

        public class TicketList
        {
            public List<Ticket> data { get; set; }
        }
    }
}