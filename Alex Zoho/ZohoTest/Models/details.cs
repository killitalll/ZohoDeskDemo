using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZohoTest.Models;

namespace ZohoTest.Models
{
    public class details
    {
        public string Subject { get; set; }
        public string Email { get; set; }

        public details(string Sub, string Em)
        {
            Subject = Sub;
            Email = Em;
        }
    }
}