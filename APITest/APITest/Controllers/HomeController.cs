using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestSharp;
using APITest.Models;

namespace APITest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }


        public ActionResult Ticket()
        {
            ViewBag.Title = "Get Ticket";

            var client = new RestClient("https://desk.zoho.com");

            var getterRequest = new RestRequest("/api/v1/tickets", Method.GET);
            //getterRequest.AddHeader("username", "arad18@student.monash.edu");
            //getterRequest.AddHeader("password", "RedSurveillanceIE");
            getterRequest.AddHeader("orgId", "645284773");
            getterRequest.AddHeader("Authorization", "1e8fb00ae1e44e25e5dbcdd1af293a10");

            #region Ticket variables
            var ID = "If you ";
            var AssigneeID = " see this ";
            var AssigneeEmail = " it means that";
            var Subject = " There is no cow level! ";
            var DueDate = " request going";
            var Status = " through to Zoho Desk!! :(";

            #endregion

            var restResponse = client.ExecuteAsync<TicketList>(getterRequest, getterResponse =>
            {
                foreach (Tickets o in getterResponse.Data.data)
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


            return View();
        }

        public ActionResult Contact()
        {
            var thing = new Account();
            ViewBag.Message = thing.interact;
            return View();

            return View();
        }
    }
}
