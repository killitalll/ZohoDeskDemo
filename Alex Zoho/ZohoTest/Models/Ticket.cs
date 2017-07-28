using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;

namespace ZohoTest.Models
{
    public class Ticket
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

    public class ticketManager
    { 
        public string ticketControl()
        { 
        var client = new RestClient("https://desk.zoho.com");

        var postRequest = new RestRequest("/api/v1/tickets", Method.POST);
        postRequest.RequestFormat = DataFormat.Json;

            //Does this need to be made actual variables that are private? 
            //There should probably be a config file to read from for this sensitive info.
            postRequest.AddHeader("orgId", "645284773");
            postRequest.AddHeader("Authorization", "1e8fb00ae1e44e25e5dbcdd1af293a10");

            Ticket toSend = new Ticket();

        toSend.productId = "";
            toSend.contactId = "186361000000152005"; // Need to create an account, to create a contact, to create a ticket associated with that contact.
            toSend.subject = "Alex:" + DateTime.Now;
            toSend.dueDate = "2017-07-20T16:16:16.000Z";
            toSend.departmentId = "186361000000006907"; //*Needs to change to RS details!*
            toSend.channel = "alexie"; //*Needs to change to RS details!*
            toSend.description = "This is a ticket created through [ASP.NET MVC 5 Web App]";
            toSend.priority = "High";
            toSend.classification = "Classification";
            toSend.assigneeId = "186361000000070005"; //*Needs to change to RS details!*
            toSend.phone = "072 760 7234";
            toSend.category = "Category";
            toSend.email = "arad18@student.monash.edu";
            toSend.status = "Open";

            postRequest.AddJsonBody(toSend);
            var postResponse = client.Execute<Ticket>(postRequest);
        Ticket t = postResponse.Data;

        var stringResponse = "ID: " + t.id + "\n" + "Contact ID: " + t.contactId + "\n" + "Ticket Number: " + t.ticketNumber + "\n" + "Subject: " + t.subject + "\n" + "Description: " + t.description + "\n" + "Email: " + t.email + "\n" + "Priority: " + t.priority + "\n" + "Channel: " + t.channel + "\n" + "Status: " + t.status;
        return stringResponse;
        }
    }  
}