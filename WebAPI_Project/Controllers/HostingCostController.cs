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

        //<summary>
        // The purpose of this method is be calculate the hosting cost based on the provided id and some predefined values for cost per fortnight, HST rate, and the number of fortnights.
        // usage:
        // localhost:xx/api/hostingcost/0  => [1 fortnight at $5.50/FN = $5.50 CAD, HST 13% = $0.72 CAD, Total = $6.22 CAD]
        //</summary>
        public IEnumerable<string> Get(double id)
        {
            double costPerFortnight = 5.50;
            double hstRate = 0.13;
            int fortnight = 14;

            // Calculate the number of fortnights
            // The number of `fortnights` is calculated by dividing the provided days by the length of a fortnight (14days) 
            // And round it down using the `Math.floor()`. The result was incremented by 1 to ensure that even a partial fortnight is counted as a full fortnight
            int fortnights = (int)Math.Floor(id / fortnight) + 1;

            // hostingCost: The hosting cost is calculated by multiplying the number of fortnights by the cost per fortnight and rounding the result to two decimal places.
            double hostingCost = Math.Round(fortnights * costPerFortnight, 2);
            // hstAmount: The HST amount is calculated by applying the HST rate to the hosting cost and rounding the result to two decimal places.
            double hstAmount = Math.Round(hostingCost * hstRate, 2);
            // totalCost: The total cost is the sum of the hosting cost and the HST amount, rounded to two decimal places.
            double totalCost = Math.Round(hostingCost + hstAmount, 2);

            //The method returns an array of strings, each containing information about the calculated costs and breakdown.
            return new string[]
            {
                // The strings are formatted using string interpolation ($"{...}"), where values are embedded within the string using curly braces {}. 
                // The :F2 format specifier is used to display floating-point numbers with two decimal places.
                $"{fortnights} {(fortnights <= 1 ? "fortnight" : "fortnights")} at ${costPerFortnight:F2}/FN = ${hostingCost:F2} CAD",
                $"HST {hstRate * 100}% = ${hstAmount} CAD",
                $"Total = ${totalCost} CAD"
    };
        }
    }

}
