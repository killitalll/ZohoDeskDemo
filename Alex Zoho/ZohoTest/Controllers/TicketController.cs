using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZohoTest.Models;
using RestSharp;

namespace ZohoTest.Controllers
{
    public class TicketController : Controller
    {
        // GET: Ticket
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TicketCreator()
        {

            return View();
        }
        

        
        public ActionResult PostTicket(String Subject, String email)
        {
            Ticket info = new Ticket();
            info.subject = Subject;
            info.email = email;

            var createTicket = new ticketManager();
            var ticket = createTicket.ticketControl();
            return Content(ticket, "application/json");
            
        }
    }
}