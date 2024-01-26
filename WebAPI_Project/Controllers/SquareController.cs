using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class SquareController : ApiController
    {
        //  <summary>
        // This returns the squre of the integer input {id}
        // Usage: 
        // localhost:xx/api/square/10 => 100
        //  </summary>

        public int Get(int id)
        {
            return id * id;
        } 
    }
}