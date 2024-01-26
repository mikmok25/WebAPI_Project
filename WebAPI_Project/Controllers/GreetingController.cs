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
        public string Get()
        {
            return "Hello World";
        }

        public string Get(string id)
        {
            return "Hello to " + id + " people!";
        }
    }
}