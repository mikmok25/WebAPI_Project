using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class HostingCostController : ApiController
    {
        // GET api/<controller>/5
        public IEnumerable<string> Get(double id)
        {
            double costPerFortnight = 5.50;
            double hstRate = 0.13;
            int fortnight = 14;

            // Calculate the number of fortnights
            int fortnights = (int)Math.Floor(id / fortnight) + 1;

            double hostingCost = Math.Round(fortnights * costPerFortnight, 2);
            double hstAmount = Math.Round(hostingCost * hstRate, 2);
            double totalCost = Math.Round(hostingCost + hstAmount, 2);

            return new string[] 
            {
                $"{fortnights} {(fortnights <= 1 ? "fortnight" : "fortnights")} at ${costPerFortnight:F2}/FN = ${hostingCost:F2} CAD",
                $"HST {hstRate * 100}% = ${hstAmount} CAD",
                $"Total = ${totalCost} CAD"
    };
            }



    }


}
