using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class TestController : ApiController
    {
        static void Get(int days)
        {
            double costPerFortnight = 5.50;
            double hstRate = 0.13;

            int fortnights = (int)Math.Ceiling((double)days / 14 + 1);

            double hostingCost = fortnights * costPerFortnight;

            double 
        }

        // Goal
        //POST localhost:xx/api/test -> "Post Request"

      
    }
}
