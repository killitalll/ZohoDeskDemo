using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITest.Models
{
    public class Account
    {
        public string interact { get; set; }

        public Account()
        {
            interact = "Connection Made.";
        }
    }
}