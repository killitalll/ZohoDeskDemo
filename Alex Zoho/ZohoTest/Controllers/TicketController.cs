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
            ticketManager info = new ticketManager();
            info.Subject = Subject;
            info.Email = email;

            var createTicket = new ticketManager();
            var ticket = createTicket.ticketControl();
            return Content(ticket, "application/json");
            
        }
    }
}