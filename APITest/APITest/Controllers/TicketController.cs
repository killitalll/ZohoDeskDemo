using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestSharp;
using APITest.Models;

namespace APITest.Controllers
{
    public class TicketController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ticket()
        {
            ViewBag.Title = "Get Ticket";

            #region Get Tickets
            var client = new RestClient("https://desk.zoho.com");

            var getterRequest = new RestRequest("/api/v1/tickets", Method.GET);
            //getterRequest.AddHeader("username", "arad18@student.monash.edu");
            //getterRequest.AddHeader("password", "RedSurveillanceIE");
            getterRequest.AddHeader("orgId", "645284773");
            getterRequest.AddHeader("Authorization", "1e8fb00ae1e44e25e5dbcdd1af293a10");

            #region Tickets variables
            var ID = "If you ";
            var AssigneeID = " see this ";
            var AssigneeEmail = " it means that";
            var Subject = " There is no cow level! ";
            var DueDate = " request going";
            var Status = " through to Zoho Desk!! :(";

            #endregion

            var restResponse = client.ExecuteAsync<TicketList>(getterRequest, getterResponse =>
            {
                foreach (Ticket o in getterResponse.Data.data)
                {
                    ID = o.id;
                    AssigneeID = o.assigneeId;
                    AssigneeEmail = o.email;
                    Subject = o.subject;
                    DueDate = o.dueDate;
                    Status = o.status;
                }
            });

            ViewBag.Message = Subject;

            System.Diagnostics.Debug.WriteLine(Subject);

            var thing = new Account();
           // ViewBag.Message = thing.interact;
            #endregion


            /*
            #region Create Account
            var accountRequest = new RestRequest("/api/v1/accounts", Method.POST);
            accountRequest.AddHeader("orgId", orgId);
            accountRequest.AddHeader("Authorization", Authorization);
            Account account = new Account();
            account.accountName = "Account Name";
            accountRequest.AddJsonBody(account);
            var accountResponse = client.Execute<Account>(accountRequest);
            account = accountResponse.Data;
            #endregion

            
            */
            return View();



        }



        public ActionResult TicketCreator()
        {
            return View();
        }

        public ActionResult PostTicket()
        {
            #region Post Ticket
            var client = new RestClient("https://desk.zoho.com");

            var postRequest = new RestRequest("/api/v1/tickets", Method.POST);
            postRequest.RequestFormat = DataFormat.Json;

            postRequest.AddHeader("orgId", "6452844773");
            postRequest.AddHeader("Authorization", "1e8fb00ae1e44e25e5dbcdd1af293a10");

            Ticket toSend = new Ticket();

            toSend.productId = "";
            toSend.contactId = "186361000000152005"; // Need to create an account, to create a contact, to create a ticket associated with that contact.
            toSend.subject = "This is a ticket by Alex :" + DateTime.Now;
            toSend.dueDate = "2017-07-20T16:16:16.000Z";
            toSend.departmentId = "186361000000006907";
            toSend.channel = "alexie";
            toSend.description = "This is a ticket created through console app";
            toSend.priority = "High";
            toSend.classification = "Classification";
            toSend.assigneeId = "186361000000070005";
            toSend.phone = "079 774 6267";
            toSend.category = "Category";
            toSend.email = "arad18@student.monash.edu";
            toSend.status = "Open";

            postRequest.AddJsonBody(toSend);
            var postResponse = client.Execute<Ticket>(postRequest);
            Ticket t = postResponse.Data;

            var stringResponse = "ID: " + t.id + "\n" + "Contact ID: " + t.contactId + "\n" + "Ticket Number: " + t.ticketNumber + "\n" + "Subject: " + t.subject + "\n" + "Description: " + t.description + "\n" + "Email: " + t.email + "\n" + "Priority: " + t.priority + "\n" + "Channel: " + t.channel + "\n" + "Status: " + t.status;
            return Content(stringResponse, "application/json");
            #endregion
        }
    }
}