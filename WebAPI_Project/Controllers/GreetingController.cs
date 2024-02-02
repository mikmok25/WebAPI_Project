using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{


    public class GreetingController : ApiController
    {
        // <summary>
        // This method returns a string "Hello World"
        // usage:
        //localhost:xx/greeting => "Hello World"
        // </summary>
        public string Get()
        {
            return "Hello World";
        }

        // <summary>
        // This method returns a string "Hello to {number} people!"
        // usage:
        //localhost:xx/greeting/10 => "Hello to 10 people!"
        // </summary>
        public string Get(string id)
        {
            return "Hello to " + id + " people!";
        }
    }
}
